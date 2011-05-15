Friend Class frmPrinterInstellingen
    Inherits System.Windows.Forms.Form



    Private Sub btnCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOpslaan_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnOpslaan.Click
        If (prtSetLK.SaveSettings() _
                AndAlso prtSetPL.SaveSettings() _
                AndAlso prtSetDPA.SaveSettings() _
                AndAlso prtSetDPB.SaveSettings() _
                AndAlso prtSetDPC.SaveSettings()) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmPrinterInstellingen_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        prtSetLK.ReadSettings()
        prtSetPL.ReadSettings()
        prtSetDPA.ReadSettings()
        prtSetDPB.ReadSettings()
        prtSetDPC.ReadSettings()
        mdiMain.Cursor = Cursors.Default
    End Sub
End Class