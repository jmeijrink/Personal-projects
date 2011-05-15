Option Strict Off
Option Explicit On
Friend Class frmNieuwKind
	Inherits System.Windows.Forms.Form
	
	Private Sub btnClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub
	
    Private Sub btnSave_Click( _
            ByVal eventSender As System.Object, _
            ByVal eventArgs As System.EventArgs) Handles btnSave.Click
        Dim sSQL As String
        Dim iNrOfGroups As Short
        Dim iCounter As Short

        txtNaam.Enabled = False
        txtGebDat.Enabled = False
        txtTelNr.Enabled = False
        txtInsDat.Enabled = False
        txtOpmerking.Enabled = False
        txtPrioriteit.Enabled = False
        txtOpm.Enabled = False
        optAlleen.Enabled = False
        optGroep.Enabled = False
        optWachtlijst.Enabled = False
        lvGroepen.Enabled = False

        Try
            If (Len(txtTelNr.Text) = 0) Then Err.Raise(168, , "Het telefoonnummer is verplicht.")

            If (txtOpmerking.Text = "") Then txtOpmerking.Text = "geen"
            sSQL = "INSERT INTO kind (kindnummer, naam, geboortedatum, telefoonnummer, "
            sSQL = sSQL & "inschrijfdatum, opmerking) VALUES (" & txtKindNummer.Text & ", '"
            sSQL = sSQL & txtNaam.Text & "', '" & txtGebDat.Text & "', '" & txtTelNr.Text & "', '"
            sSQL = sSQL & txtInsDat.Text & "', '" & txtOpmerking.Text & "')"
            dbExecSQL(sSQL)
            If (optWachtlijst.Checked = True) Then
                If (txtOpm.Text = "") Then txtOpm.Text = "geen"
                sSQL = "INSERT INTO wachtlijst (kindnummer, prioriteit, opmerking) "
                sSQL = sSQL & "VALUES (" & txtKindNummer.Text & ", " & txtPrioriteit.Text
                sSQL = sSQL & ", '" & txtOpm.Text & "')"
                Try
                    dbExecSQL(sSQL)
                Catch
                    MessageBox.Show("Het kind is niet toegevoegd aan de wachtlijst, voor deze handeling handmatig uit.")
                End Try
            ElseIf (optGroep.Checked = True) Then
                iNrOfGroups = lvGroepen.Items.Count
                For iCounter = 1 To iNrOfGroups
                    If (lvGroepen.Items.Item(iCounter - 1).Selected = True) Then
                        sSQL = "INSERT INTO groepssamenstelling (kindnummer, groepnummer) "
                        sSQL = sSQL & "VALUES (" & txtKindNummer.Text & ", "
                        sSQL = sSQL & Mid(lvGroepen.Items.Item(iCounter - 1).Name, 6) & ")"

                        Try
                            dbExecSQL(sSQL)
                        Catch
                            MessageBox.Show("Het kind is niet toegevoegd aan groep '" & lvGroepen.Items(iCounter - 1).Text & "', voor deze handeling handmatig uit.")
                        End Try
                    End If
                Next iCounter
            End If

        Catch
            MsgBox("Nieuw kind niet opgeslagen." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation, "Foutmelding")
            txtNaam.Enabled = True
            txtGebDat.Enabled = True
            txtTelNr.Enabled = True
            txtInsDat.Enabled = True
            txtOpmerking.Enabled = True
            txtPrioriteit.Enabled = True
            txtOpm.Enabled = True
            optAlleen.Enabled = True
            optGroep.Enabled = True
            optWachtlijst.Enabled = True
            lvGroepen.Enabled = True
            Exit Sub
        End Try

        txtKindNummer.Text = CStr(CShort(txtKindNummer.Text) + 1)
        txtNaam.Text = ""
        txtGebDat.Text = ""
        txtTelNr.Text = ""
        txtInsDat.Text = ""
        txtOpmerking.Text = ""
        txtPrioriteit.Value = 2
        txtOpm.Text = ""
        optWachtlijst.Checked = True
        txtNaam.Enabled = True
        txtGebDat.Enabled = True
        txtTelNr.Enabled = True
        txtInsDat.Enabled = True
        txtOpmerking.Enabled = True
        txtPrioriteit.Enabled = True
        txtOpm.Enabled = True
        optAlleen.Enabled = True
        optGroep.Enabled = True
        optWachtlijst.Enabled = True
        lvGroepen.Enabled = True
        txtNaam.Focus()

        If (g_blnWijzigenKinderenVisible) Then Call frmWijzigenKinderen.ResetList()
    End Sub
	
    Private Sub frmNieuwKind_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim sSQL As String
        Dim liItem As System.Windows.Forms.ListViewItem

        GetWindowProperties(Me)

        Dim dr As DataRow = Nothing
        sSQL = "SELECT MAX(kindnummer) + 1 AS maxkindnr FROM kind"
        dbOpenRS(dr, sSQL)

        Dim strMaxNr As String = "0"
        If (Not dr.IsNull("maxkindnr")) Then strMaxNr = CStr(dr("maxkindnr"))
        txtKindNummer.Text = strMaxNr

        Dim dt As DataTable = Nothing
        sSQL = "SELECT groepnummer, naam FROM groep"
        dbOpenRS(dt, sSQL)

        For Each dr In dt.Rows
            liItem = lvGroepen.Items.Add("groep" & CStr(dr("groepnummer")), DirectCast(dr("naam"), String), "")
            liItem.SubItems.Add(CStr(dr("groepnummer")))
        Next dr
        mdiMain.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
	
	Private Sub frmNieuwKind_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		SetWindowProperties(Me)
		eventArgs.Cancel = Cancel
	End Sub
	
	Private Sub lvGroepen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvGroepen.Click
		optGroep.Checked = True
	End Sub
	
    Private Sub txtOpm_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOpm.Enter
        optWachtlijst.Checked = True
    End Sub
End Class