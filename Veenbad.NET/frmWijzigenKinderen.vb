Option Strict Off
Option Explicit On
Friend Class frmWijzigenKinderen
	Inherits System.Windows.Forms.Form

    Private _showDeleted As Boolean = False

	Public Sub btnDelete_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnDelete.Click
		Dim vbResult As MsgBoxResult
		Dim sSQL As String
		
        vbResult = MsgBox("Weet u zeker dut u '" & lvKinderen.SelectedItems(0).Text & "' uit het systeem wilt verwijderen?", MsgBoxStyle.YesNo, "Bevestiging")
        If (vbResult = MsgBoxResult.Yes) Then
            chkVerwijderd.Checked = True
            btnSave_Click(eventSender, eventArgs)
            DeleteKid(CInt(lvKinderen.SelectedItems(0).SubItems(1).Text))
            Call ResetList()
        End If
		frmGroepsSamenstelling.Close()
	End Sub
	
    Private Sub btnExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
	
	Private Sub btnSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSave.Click
        On Error GoTo save_err
        Dim cmd As OleDb.OleDbCommand
        Dim iItem As Short
		Dim iKind As Short
		
        iKind = CShort(Trim(lvKinderen.SelectedItems(0).SubItems.Item(1).Text))
        If txtOpmKind.Text = "" Then txtOpmKind.Text = "geen"
        cmd = DbGetCommand()
        cmd.CommandText = _
            "UPDATE kind " & _
            "SET " & _
                "naam = ?, " & _
                "geboortedatum = ?, " & _
                "telefoonnummer = ?, " & _
                "inschrijfdatum = ?, " & _
                "opmerking = ?, "
        If (chkVerwijderd.Checked) Then
            cmd.CommandText &= "deldate = IIF(ISNULL(deldate), ?, deldate) "
        Else
            cmd.CommandText &= "deldate = ? "
        End If
        cmd.CommandText &= _
            "WHERE kindnummer = ?"
        cmd.Parameters.Add("@Name", OleDb.OleDbType.VarChar).Value = txtNaam.Text
        cmd.Parameters.Add("@GebDat", OleDb.OleDbType.Date).Value = txtGebDat.Value
        cmd.Parameters.Add("@Tel", OleDb.OleDbType.VarChar).Value = txtTelefoon.Text
        cmd.Parameters.Add("@InsDat", OleDb.OleDbType.Date).Value = txtInsDat.Value
        cmd.Parameters.Add("@OpmKind", OleDb.OleDbType.VarChar).Value = txtOpmKind.Text
        If (chkVerwijderd.Checked) Then
            cmd.Parameters.Add("@DelDate", OleDb.OleDbType.Date).Value = DateTime.Now
        Else
            cmd.Parameters.Add("@DelDate", OleDb.OleDbType.Date).Value = System.DBNull.Value
        End If
        cmd.Parameters.Add("@KindNummer", OleDb.OleDbType.Integer).Value = iKind
        dbExecSQL(cmd)
        If (txtOpmerking.Visible = True) Then
            If (Trim(txtOpmerking.Text) = "") Then txtOpmerking.Text = "geen"
            cmd = DbGetCommand()
            cmd.CommandText = _
                "UPDATE wachtlijst " & _
                "SET " & _
                    "opmerking = ?, " & _
                    "prioriteit = ? " & _
                "WHERE kindnummer = ?"
            cmd.Parameters.Add("@OpmKind", OleDb.OleDbType.VarChar).Value = txtOpmerking.Text
            cmd.Parameters.Add("@Prio", OleDb.OleDbType.Integer).Value = txtPrioriteit.Value
            cmd.Parameters.Add("@KindNummer", OleDb.OleDbType.Integer).Value = iKind
            dbExecSQL(cmd)
        End If
        If (chkVerwijderd.Checked) Then DeleteKid(iKind)

        frmGroepsSamenstelling.Close()

exit_sub:
        lvKinderen.SelectedItems(0).Text = txtNaam.Text
        Call checkChild()
        Exit Sub

save_err:
        MsgBox("Kind niet opgeslagen." & vbCrLf & Err.Description)
        GoTo exit_sub
    End Sub
	
    Private Sub DeleteKid(ByVal kidId As Integer)
        Dim sSQL As String = _
            "DELETE FROM wachtlijst " & _
            "WHERE kindnummer = " & CStr(kidId)
        dbExecSQL(sSQL)

        sSQL = _
            "DELETE FROM transferlijst " & _
            "WHERE kindnummer = " & CStr(kidId)
        dbExecSQL(sSQL)

        sSQL = _
            "DELETE FROM groepssamenstelling " & _
            "WHERE kindnummer = " & CStr(kidId)
        dbExecSQL(sSQL)
    End Sub

    Private Sub frmWijzigenKinderen_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        GetWindowProperties(Me)
        Call ResetList()
        mdiMain.Cursor = System.Windows.Forms.Cursors.Default
        g_blnWijzigenKinderenVisible = True
    End Sub
	
	Private Sub frmWijzigenKinderen_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		SetWindowProperties(Me)
		g_blnWijzigenKinderenVisible = False
		eventArgs.Cancel = Cancel
	End Sub
	
	Private Sub lvKinderen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvKinderen.Click
		Call checkChild()
	End Sub
	
	Private Sub checkChild()
        Dim sSQL As String
        Dim dr As DataRow = Nothing

        If (lvKinderen.SelectedItems.Count = 0) Then Return

        Dim kindNummer As Integer = CInt(lvKinderen.SelectedItems(0).SubItems.Item(1).Text)

        On Error GoTo checkchild_error
        sSQL = _
            "SELECT * " & _
            "FROM kind " & _
            "WHERE kindnummer = " & CStr(kindNummer)
        lstGroepen.Visible = False

        dbOpenRS(dr, sSQL)
        txtNaam.Text = DirectCast(dr("naam"), String)
        txtTelefoon.Text = DirectCast(dr("telefoonnummer"), String)
        txtGebDat.Text = CStr(dr("geboortedatum"))
        txtInsDat.Text = CStr(dr("inschrijfdatum"))
        If (dr.IsNull("opmerking")) Then
            txtOpmKind.Text = String.Empty
        Else
            txtOpmKind.Text = DirectCast(dr("opmerking"), String)
        End If
        chkVerwijderd.Checked = Not dr.IsNull("deldate")
        If (chkVerwijderd.Checked) Then
            chkVerwijderd.Text = "op " & DirectCast(dr("deldate"), Date).ToShortDateString()
        Else
            chkVerwijderd.Text = String.Empty
        End If

        sSQL = _
            "SELECT * " & _
            "FROM wachtlijst " & _
            "WHERE kindnummer = " & CStr(kindNummer)
        dbOpenRS(dr, sSQL)
        If (dr IsNot Nothing) Then
            lblInfo1.Text = "Op de wachtlijst."
            lblOpmerking.Visible = True
            txtOpmerking.Visible = True
            lblPrioriteit.Visible = True
            txtPrioriteit.Visible = True

            sSQL = _
                "SELECT opmerking, prioriteit " & _
                "FROM wachtlijst " & _
                "WHERE kindnummer = " & CStr(kindNummer)
            dbOpenRS(dr, sSQL)

            If (dr.IsNull("opmerking")) Then
                txtOpmerking.Text = String.Empty
            Else
                txtOpmerking.Text = DirectCast(dr("opmerking"), String)
            End If
            txtPrioriteit.Value = CType(dr("prioriteit"), Decimal)
        Else
            Dim dt As DataTable = Nothing

            txtOpmerking.Visible = False
            lblOpmerking.Visible = False
            lblPrioriteit.Visible = False
            txtPrioriteit.Visible = False

            sSQL = _
                "SELECT * " & _
                "FROM groepssamenstelling " & _
                "WHERE kindnummer = " & CStr(kindNummer)
            dbOpenRS(dt, sSQL)

            If (dt.Rows.Count > 0) Then
                Dim dt2 As DataTable = Nothing

                lblInfo1.Text = "In de groepen:"
                lstGroepen.Visible = True
                lstGroepen.Items.Clear()

                For Each dr In dt.Rows
                    sSQL = _
                        "SELECT * " & _
                        "FROM groep " & _
                        "WHERE groepnummer = " & CStr(dr("groepnummer"))
                    dbOpenRS(dt2, sSQL)

                    For Each dr2 As DataRow In dt2.Rows
                        lstGroepen.Items.Add(CStr(dr2("groepnummer")) & ", " & DirectCast(dr2("naam"), String))
                    Next dr2
                Next dr
            Else
                lblInfo1.Text = "Niet ingedeeld."
            End If
        End If

checkchild_exit:
        Exit Sub

checkchild_error:
        Dim strError As String = Err.Description
        On Error Resume Next
        MsgBox("Er heeft zich een fout voorgedaan." & vbCrLf & strError, MsgBoxStyle.Exclamation, "Foutmelding")
        Exit Sub

checkchild_nokids:
        MsgBox("Er zijn nog geen kinderen ingevoerd." & vbCrLf & "Voeg eerste een kind toe.", MsgBoxStyle.Exclamation, "Foutmelding")
        frmNieuwKind.Show()
    End Sub
	
	Public Sub ResetList()
        Dim dt As DataTable = Nothing
		Dim sSQL As String
		Dim liLstItem As System.Windows.Forms.ListViewItem

        Dim oldIndex As Integer = 0
        If (lvKinderen.SelectedIndices.Count > 0) Then oldIndex = lvKinderen.SelectedIndices(0)

        lvKinderen.Items.Clear()
        sSQL = _
            "SELECT * " & _
            "FROM kind "
        If (Not _showDeleted) Then
            sSQL &= "WHERE deldate IS NULL "
        End If
        sSQL &= "ORDER BY naam"
        dbOpenRS(dt, sSQL)
        For Each dr As DataRow In dt.Rows
            liLstItem = lvKinderen.Items.Add(DirectCast(dr("naam"), String))
            liLstItem.SubItems.Add(CStr(dr("kindnummer")))
        Next dr

        If (lvKinderen.Items.Count > oldIndex) Then
            lvKinderen.Items(oldIndex).Selected = True
        ElseIf (lvKinderen.Items.Count > 0) Then
            lvKinderen.Items(0).Selected = True
        End If
        Call checkChild()
    End Sub
	Private Sub lvKinderen_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles lvKinderen.KeyUp
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		Call checkChild()
	End Sub
	
    Public Sub SelectChild(ByRef iChild As Short, Optional ByVal showDeleted As Boolean = False)
        Dim iNrOfKids As Short
        Dim iCounter As Short

        If (_showDeleted <> showDeleted) Then
            _showDeleted = showDeleted
            ResetList()
        End If

        iNrOfKids = lvKinderen.Items.Count
        For iCounter = 0 To iNrOfKids - 1
            If (CShort(lvKinderen.Items.Item(iCounter).SubItems(1).Text) = iChild) Then
                lvKinderen.Items.Item(iCounter).Selected = True
            End If
        Next
        Call checkChild()

        lvKinderen.SelectedItems(0).EnsureVisible()
    End Sub
End Class