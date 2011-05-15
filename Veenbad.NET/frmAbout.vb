Option Strict Off
Option Explicit On
Friend Class frmAbout
	Inherits System.Windows.Forms.Form
	
	Private Sub btnClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub
	
	Private Sub frmAbout_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		GetWindowProperties(Me)
        mdiMain.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub frmAbout_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		SetWindowProperties(Me)
		eventArgs.Cancel = Cancel
	End Sub
End Class