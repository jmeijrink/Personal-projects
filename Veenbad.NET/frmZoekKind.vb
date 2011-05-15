Option Strict Off
Option Explicit On
Friend Class frmZoekKind
	Inherits System.Windows.Forms.Form
	
	Private Sub btnClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub
	
	Private Sub btnWijzigen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnWijzigen.Click
		frmWijzigenKinderen.Show()
        frmWijzigenKinderen.SelectChild(CShort(lvKinderen.SelectedItems(0).Text))
	End Sub
	
	Private Sub btnZoek_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnZoek.Click
		Dim sSQL As String
        Dim dt As DataTable = Nothing
		Dim iItem As System.Windows.Forms.ListViewItem
        Dim varArray() As String
		Dim I As Integer
		Dim blnWhere As Boolean
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		lvKinderen.Items.Clear()
        sSQL = _
            "SELECT * " & _
            "FROM kind "
        varArray = Split(txtNaam.Text, " ")
        For I = 0 To UBound(varArray)
            blnWhere = True
            sSQL = sSQL & _
                IIf(I = 0, "WHERE ", "AND ") & "naam LIKE '%" & SQLLikeEncode(varArray(I)) & "%' "
        Next I
        If (chkDeleted.CheckState = CheckState.Unchecked) Then
            sSQL = sSQL & IIf(varArray.Length > 0, "AND ", "WHERE ") & "deldate IS NULL"
        End If
		sSQL = sSQL & " ORDER BY naam"
        dbOpenRS(dt, sSQL)

        For Each dr As DataRow In dt.Rows
            iItem = lvKinderen.Items.Add("kind" & CStr(dr("kindnummer")), CStr(dr("kindnummer")), "")
            iItem.SubItems.Add(DirectCast(dr("naam"), String))
            iItem.SubItems.Add(DirectCast(dr("telefoonnummer"), String))
            iItem.SubItems.Add(DirectCast(dr("geboortedatum"), DateTime).ToShortDateString())
            iItem.SubItems.Add(DirectCast(dr("inschrijfdatum"), DateTime).ToShortDateString())
            If (dr.IsNull("opmerking")) Then
                iItem.SubItems.Add(String.Empty)
            Else
                iItem.SubItems.Add(DirectCast(dr("opmerking"), String))
            End If
            iItem.SubItems.Add(IIf(Of String)(dr.IsNull("deldate"), "Nee", "Ja"))
        Next dr

        Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub frmZoekKind_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		GetWindowProperties(Me)
		mdiMain.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub frmZoekKind_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		SetWindowProperties(Me)
		eventArgs.Cancel = Cancel
	End Sub
	
	Private Sub lvKinderen_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvKinderen.DoubleClick
		frmWijzigenKinderen.Show()
        frmWijzigenKinderen.SelectChild(CShort(lvKinderen.SelectedItems(0).Text), lvKinderen.SelectedItems(0).SubItems(6).Text = "Ja")
	End Sub
End Class