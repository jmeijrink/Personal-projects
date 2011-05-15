Friend Class frmWijzigenGroepen
    Inherits System.Windows.Forms.Form

    Private Sub btnAfsluiten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnAfsluiten.Click
        Me.Close()
    End Sub

    Private Sub btnOpslaan_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOpslaan.Click
        Dim sSQL As String
        Dim sSQL2 As String
        Dim iGroep As Short
        Dim iIndex As Short

        btnOpslaan.Enabled = False
        btnVerwijderen.Enabled = False
        btnAfsluiten.Enabled = False
        txtNaam.Enabled = False
        txtDiploma.Enabled = False
        txtDagEnTijd1.Enabled = False
        txtDagEnTijd2.Enabled = False
        txtDagEnTijd3.Enabled = False
        txtDagEnTijd4.Enabled = False

        iGroep = CShort(Mid(lvGroepen.SelectedItems(0).Name, 6))

        txtNaam.Text = Trim(txtNaam.Text)
        On Error GoTo opsl_err
        sSQL = _
            "UPDATE groep " & _
            "SET " & _
                "naam = '" & SQLEncode(txtNaam.Text) & "', " & _
                "doeldiploma = '" & UCase(txtDiploma.Text) & "', " & _
                "dagentijd1 = '" & Trim(txtDagEnTijd1.Text) & "', " & _
                "dagentijd2 = " & IIf(Of String)(txtDagEnTijd2.Text = "", "NULL", "'" & SQLEncode(Trim(txtDagEnTijd2.Text)) & "'") & ", " & _
                "dagentijd3 = " & IIf(Of String)(txtDagEnTijd3.Text = "", "NULL", "'" & SQLEncode(Trim(txtDagEnTijd3.Text)) & "'") & ", " & _
                "dagentijd4 = " & IIf(Of String)(txtDagEnTijd4.Text = "", "NULL", "'" & SQLEncode(Trim(txtDagEnTijd4.Text)) & "'") & " " & _
            "WHERE groepnummer = " & CStr(iGroep)

        dbExecSQL(sSQL)

        On Error Resume Next
        frmGroepsSamenstelling.Close()

opsl_exit:
        lvGroepen.SelectedItems(0).Text = txtNaam.Text
        btnOpslaan.Enabled = True
        btnVerwijderen.Enabled = True
        btnAfsluiten.Enabled = True
        txtNaam.Enabled = True
        txtDiploma.Enabled = True
        txtDagEnTijd1.Enabled = True
        txtDagEnTijd2.Enabled = True
        txtDagEnTijd3.Enabled = True
        txtDagEnTijd4.Enabled = True
        Exit Sub

opsl_err:
        MsgBox("Onmogelijk om de groep op te slaan, controleer of de velden wel goed zijn ingevuld." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation, "Error")
        GoTo opsl_exit

    End Sub

    Public Sub btnVerwijderen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnVerwijderen.Click
        Dim sSQL As String

        Dim mbResult As MsgBoxResult

        If (lvGroepen.SelectedItems.Count = 0) Then
            MsgBox("U dient een groep te selecteren.", MsgBoxStyle.Exclamation, "Foutmelding")
        Else
            mbResult = MsgBox("Weet u zeker dat u de groep '" & Trim(txtNaam.Text) & "' wilt verwijderen?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Bevestiging")
            If (mbResult = MsgBoxResult.Yes) Then
                sSQL = _
                    "DELETE FROM groepssamenstelling " & _
                    "WHERE groepnummer = " & Mid(lvGroepen.SelectedItems(0).Name, 6)
                dbExecSQL(sSQL)
                sSQL = _
                    "DELETE FROM groep " & _
                    "WHERE groepnummer = " & Mid(lvGroepen.SelectedItems(0).Name, 6)
                dbExecSQL(sSQL)
                frmGroepsSamenstelling.Close()

                Dim index As Integer = lvGroepen.SelectedIndices(0) - 1
                lvGroepen.Items.Remove(lvGroepen.SelectedItems(0))
                If (index > -1) Then lvGroepen.Items(index).Selected = True

            End If
        End If

del_exit:
        Exit Sub

del_error:
        GoTo del_exit

    End Sub

    Private Sub frmWijzigenGroepen_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        GetWindowProperties(Me)
        Call listGroups()
        mdiMain.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Public Sub SelectGroup(ByRef iGroep As Short)
        Dim iNrOfGroups As Integer
        Dim iCounter As Integer

        iNrOfGroups = lvGroepen.Items.Count
        For iCounter = 1 To iNrOfGroups
            If (CShort(lvGroepen.Items.Item(iCounter - 1).SubItems.Item(0).Text) = iGroep) Then
                lvGroepen.Items.Item(iCounter - 1).Selected = True
            End If
        Next
        Call getInfo()

        lvGroepen.SelectedItems(0).EnsureVisible()
    End Sub

    Private Sub listGroups()
        Dim sSQL As String
        Dim dt As DataTable = Nothing
        Dim liItem As System.Windows.Forms.ListViewItem
        Dim iIndex As Integer = 0

        If (lvGroepen.SelectedIndices.Count = 1) Then iIndex = lvGroepen.SelectedIndices(0)

        lvGroepen.Items.Clear()
        sSQL = _
            "SELECT naam, groepnummer " & _
            "FROM groep " & _
            "ORDER BY groepnummer"
        dbOpenRS(dt, sSQL)
        For Each dr As DataRow In dt.Rows
            liItem = lvGroepen.Items.Add("groep" & Trim(CStr(dr("groepnummer"))), Trim(DirectCast(dr("naam"), String)), "")
            liItem.SubItems.Add(Trim(CStr(dr("groepnummer"))))
        Next dr
        lvGroepen.Items.Item(iIndex).Selected = True
        Call getInfo()
    End Sub

    Public Sub getInfo()
        Dim sSQL As String
        Dim dr As DataRow = Nothing
        Dim iGroepNummer As Integer

        If (lvGroepen.SelectedIndices.Count <> 1) Then Return

        iGroepNummer = CInt(Mid(lvGroepen.SelectedItems(0).Name, 6))
        sSQL = _
            "SELECT " & _
                "naam, doeldiploma, dagentijd1, dagentijd2, " & _
                "dagentijd3, dagentijd4 " & _
            "FROM groep " & _
            "WHERE groepnummer = " & iGroepNummer
        dbOpenRS(dr, sSQL)

        txtNaam.Text = DirectCast(dr("naam"), String)
        txtDiploma.Text = DirectCast(dr("doeldiploma"), String)
        txtDagEnTijd1.Text = EmptyStringIfNull(dr, "dagentijd1")
        txtDagEnTijd2.Text = EmptyStringIfNull(dr, "dagentijd2")
        txtDagEnTijd3.Text = EmptyStringIfNull(dr, "dagentijd3")
        txtDagEnTijd4.Text = EmptyStringIfNull(dr, "dagentijd4")

        sSQL = _
            "SELECT COUNT(*) As aantal " & _
            "FROM groepssamenstelling " & _
            "WHERE groepnummer = " & iGroepNummer
        dbOpenRS(dr, sSQL)
        txtAantal.Text = CStr(dr("aantal"))
    End Sub

    Private Sub frmWijzigenGroepen_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        SetWindowProperties(Me)
        eventArgs.Cancel = Cancel
    End Sub

    Private Sub lvGroepen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvGroepen.SelectedIndexChanged
        Call getInfo()
    End Sub
End Class