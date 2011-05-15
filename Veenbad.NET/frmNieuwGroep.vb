Option Strict On
Option Explicit On
Friend Class frmNieuwGroep
	Inherits System.Windows.Forms.Form
	
	Private Sub btnClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub
	
	Private Sub btnSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSave.Click
		Dim sSQL As String
		Dim sSQL2 As String
		
		On Error GoTo save_err
		btnSave.Enabled = False
		btnClose.Enabled = False
		txtNaam.Enabled = False
		txtDiploma.Enabled = False
		txtDagEnTijd1.Enabled = False
		txtDagEnTijd2.Enabled = False
		txtDagEnTijd3.Enabled = False
		txtDagEnTijd4.Enabled = False
		sSQL = "INSERT INTO groep (groepnummer, naam, doeldiploma, dagentijd1"
		sSQL2 = ") VALUES(" & txtNummer.Text & ", '" & txtNaam.Text & "', '"
		sSQL2 = sSQL2 & txtDiploma.Text & "', '" & txtDagEnTijd1.Text & "'"
		If (txtDagEnTijd2.Text <> "") Then
			sSQL = sSQL & ", dagentijd2"
			sSQL2 = sSQL2 & ", '" & txtDagEnTijd2.Text & "'"
		End If
		If (txtDagEnTijd3.Text <> "") Then
			sSQL = sSQL & ", dagentijd3"
			sSQL2 = sSQL2 & ", '" & txtDagEnTijd3.Text & "'"
		End If
		If (txtDagEnTijd4.Text <> "") Then
			sSQL = sSQL & ", dagentijd4"
			sSQL2 = sSQL2 & ", '" & txtDagEnTijd4.Text & "'"
		End If
		sSQL = sSQL & sSQL2 & ")"

        dbExecSQL(sSQL)
		
save_exit: 
		txtNummer.Text = CStr(CShort(txtNummer.Text) + 1)
		txtNaam.Text = ""
		txtDiploma.Text = ""
		txtDagEnTijd1.Text = ""
		txtDagEnTijd2.Text = ""
		txtDagEnTijd3.Text = ""
		txtDagEnTijd4.Text = ""
		btnSave.Enabled = True
		btnClose.Enabled = True
		txtNaam.Enabled = True
		txtDiploma.Enabled = True
		txtDagEnTijd1.Enabled = True
		txtDagEnTijd2.Enabled = True
		txtDagEnTijd3.Enabled = True
		txtDagEnTijd4.Enabled = True
		Exit Sub
		
save_err: 
		MsgBox("Groep is niet opgeslagen, controleer de invoer velden." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation, "Foutmelding")
		btnSave.Enabled = True
		btnClose.Enabled = True
		txtNaam.Enabled = True
		txtDiploma.Enabled = True
		txtDagEnTijd1.Enabled = True
		txtDagEnTijd2.Enabled = True
		txtDagEnTijd3.Enabled = True
		txtDagEnTijd4.Enabled = True
	End Sub
	
	Private Sub frmNieuwGroep_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim sSQL As String
        Dim dr As DataRow = Nothing
		
		GetWindowProperties(Me)
		On Error GoTo load_err
		sSQL = "SELECT MAX(groepnummer) + 1 AS maxgroepnr FROM groep"
        dbOpenRS(dr, sSQL)

        Dim strMaxGroep As String = String.Empty
        If (Not dr.IsNull("maxgroepnr")) Then strMaxGroep = CStr(dr("maxgroepnr"))
        If (Len(strMaxGroep) = 0) Then strMaxGroep = "0"
        txtNummer.Text = strMaxGroep

        mdiMain.Cursor = System.Windows.Forms.Cursors.Default
        Exit Sub
load_err:
        mdiMain.Cursor = System.Windows.Forms.Cursors.Default
        MsgBox("Het venster kan niet geladen worden." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation, "Foutmelding")
    End Sub
	
	Private Sub frmNieuwGroep_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		SetWindowProperties(Me)
		eventArgs.Cancel = Cancel
	End Sub
End Class