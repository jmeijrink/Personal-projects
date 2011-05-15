Option Strict Off
Option Explicit On
Friend Class mdiMain
	Inherits System.Windows.Forms.Form
	Public bGroepsSamenStellingLoaded As Boolean
	
	Private Sub mdiMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        If (Not dbOpenConn()) Then
            MsgBox("De gegevens zijn niet toegankelijk.")
            End
        End If
        GetWindowProperties(Me)
		bGroepsSamenStellingLoaded = False
	End Sub
	
	Private Sub mdiMain_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		SetWindowProperties(Me)
        If (MsgBox("Weet u zeker dat u wilt afsluiten?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Zeker ?") = MsgBoxResult.No) Then
            Cancel = True
        End If
		eventArgs.Cancel = Cancel
	End Sub
	
	Public Sub mnuAfdrukkenDiplomas_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAfdrukkenDiplomas.Click
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		frmPrintDiplomas.Show()
	End Sub
	
	Public Sub mnuAfdrukkenInstellingen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAfdrukkenInstellingen.Click
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		frmPrinterInstellingen.Show()
	End Sub
	
	Public Sub mnuAfdrukkenLijstKinderen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAfdrukkenLijstKinderen.Click
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		frmPrintKids.Show()
	End Sub
	
	Public Sub mnuAfdrukkenPresentie_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAfdrukkenPresentie.Click
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		frmPrintPresent.Show()
	End Sub
	
	Public Sub mnuBestandAfsluiten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuBestandAfsluiten.Click
		Me.Close()
	End Sub
	
	Public Sub mnuGroepen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuGroepen.Click
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		frmWijzigenGroepen.Show()
	End Sub
	
	Public Sub mnuInfo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuInfo.Click
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		frmAbout.Show()
	End Sub
	
	Public Sub mnuNieuwGroep_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuNieuwGroep.Click
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		frmNieuwGroep.Show()
	End Sub
	
	Public Sub mnuNieuwKind_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuNieuwKind.Click
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		frmNieuwKind.Show()
	End Sub
	
	Public Sub mnuWijzigenGroepsindeling_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuWijzigenGroepsindeling.Click
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		frmGroepsIndeling.Show()
	End Sub
	
	Public Sub mnuWijzigenGroepsSamenstelling_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuWijzigenGroepsSamenstelling.Click
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		frmGroepsSamenstelling.Show()
		bGroepsSamenStellingLoaded = True
	End Sub
	
	Public Sub mnuWijzigenKinderen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuWijzigenKinderen.Click
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		frmWijzigenKinderen.Show()
	End Sub
	
	Public Sub mnuZoekenKinderen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuZoekenKinderen.Click
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		frmZoekKind.Show()
	End Sub
End Class