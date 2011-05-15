Imports VB = Microsoft.VisualBasic
Imports VB6 = Microsoft.VisualBasic.Compatibility.VB6
Imports System.Drawing.Printing

Friend Class frmPrintPresent
    Inherits System.Windows.Forms.Form

    Const iRegelAfstand As Short = 300

    Private Sub btnClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPrint.Click
        Dim I As Short
        Dim I2 As Short
        Dim I3 As Short
        Dim sSQL As String
        Dim oRS As Object
        Dim oRS2 As Object
        Dim bKleineLijst As Boolean
        Dim iAantalrijen As Short
        Dim iStopRij As Short
        Dim iGroep As Short
        Dim bLeeg As Boolean
        Dim sTemp As String
        Dim iAantalKinderen As Short
        Dim sMultiplier As String = String.Empty
        Dim sOffsetX As String = String.Empty
        Dim sOffsetY As String = String.Empty
        Dim strError As String
        Dim strDagEnTijd As String
        Dim lngFrom As Integer
        Dim lngTo As Integer
        Dim lngDagen As Integer
        Dim blnShowLine As Boolean

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        RegGetValue("HKEY_CURRENT_USER\Software\Veenbad\Printer\PLMultiplier", sMultiplier, "1")
        RegGetValue("HKEY_CURRENT_USER\Software\Veenbad\Printer\PLOffsetX", sOffsetX, "0")
        RegGetValue("HKEY_CURRENT_USER\Software\Veenbad\Printer\PLOffsetY", sOffsetY, "0")

        Dim coorX As New PrintCoordinator()
        Dim coorY As New PrintCoordinator()

        If (Not Decimal.TryParse(sMultiplier, coorX.Multiplier)) Then coorX.Multiplier = 1
        coorY.Multiplier = coorX.Multiplier
        Integer.TryParse(sOffsetX, coorX.Offset)
        Integer.TryParse(sOffsetY, coorY.Offset)

        bKleineLijst = optKL.Checked

        btnPrint.Enabled = False
        btnClose.Enabled = False
        txtStartDat.Enabled = False
        optKL.Enabled = False
        optGL.Enabled = False
        chkLeeg.Enabled = False
        lvGroepen.Enabled = False

        System.Windows.Forms.Application.DoEvents()

        If chkLeeg.CheckState = 1 Then bLeeg = True
        On Error GoTo print_cancel
        If (lvGroepen.Items.Count > 0) Then
            iGroep = CShort(Mid(lvGroepen.SelectedItems(0).Name, 6))
        Else
            iGroep = -1
        End If

        cmdPrinterPrint.PrinterSettings.DefaultPageSettings.Landscape = True
        cmdPrinterPrint.ShowDialog()

        Dim printJob As New PrintJob()
        Dim printDoc As New PrintDocument()
        printDoc.PrinterSettings.DefaultPageSettings.Landscape = True
        AddHandler printDoc.PrintPage, AddressOf printJob.PrintPageHandler
        printJob.CoorX = coorX
        printJob.CoorY = coorY
        printJob.GroupNumber = iGroep
        printJob.PrintEmptySheet = bLeeg
        printJob.SmallList = bKleineLijst
        printJob.NumberOfRows = iAantalKinderen
        printJob.GroupName = lvGroepen.SelectedItems(0).Text
        printJob.StartDate = Trim(txtStartDat.Text)
        printDoc.PrinterSettings = cmdPrinterPrint.PrinterSettings
        printDoc.Print()

        MsgBox("Document(en) verzonden naar de printer.", MsgBoxStyle.Information, "Status")
        Me.Close()
        Exit Sub

print_error:
        strError = Err.Description
        On Error Resume Next
        Me.Cursor = System.Windows.Forms.Cursors.Default

print_cancel:
        If (Len(strError) = 0) Then strError = Err.Description

        MsgBox("Fout tijdens printen." & vbCrLf & strError, MsgBoxStyle.Exclamation, "Fout")

        On Error Resume Next
        Me.Cursor = System.Windows.Forms.Cursors.Default
        btnPrint.Enabled = True
        btnClose.Enabled = True
        txtStartDat.Enabled = True
        optKL.Enabled = True
        optGL.Enabled = True
        chkLeeg.Enabled = True
        lvGroepen.Enabled = True
        Exit Sub

print_landscape:
        strError = "Printer ondersteund geen landscape."
        GoTo print_cancel

    End Sub

    Private Sub frmPrintPresent_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim sSQL As String
        Dim dt As DataTable = Nothing
        Dim liItem As System.Windows.Forms.ListViewItem

        GetWindowProperties(Me)
        sSQL = "SELECT naam, groepnummer FROM groep"
        dbOpenRS(dt, sSQL)
        For Each dr As DataRow In dt.Rows
            liItem = lvGroepen.Items.Add("groep" & CStr(dr("groepnummer")), DirectCast(dr("naam"), String), "")
            liItem.SubItems.Add(CStr(dr("groepnummer")))
        Next dr
        If (lvGroepen.Items.Count = 0) Then
            txtStartDat.Enabled = False
            optKL.Enabled = False
            optGL.Enabled = False
            chkLeeg.Enabled = False
            lvGroepen.Enabled = False
            chkLeeg.CheckState = System.Windows.Forms.CheckState.Checked
        End If

        txtStartDat.Text = VB.Right("00" & VB.Day(Today), 2) & "/" & VB.Right("00" & Month(Today), 2) & "/" & VB.Right("0000" & Year(Today), 4)
        mdiMain.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub frmPrintPresent_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        SetWindowProperties(Me)
        eventArgs.Cancel = Cancel
    End Sub

    Private Class PrintJob
        Public CoorX As PrintCoordinator
        Public CoorY As PrintCoordinator
        Public GroupNumber As Integer
        Public PrintEmptySheet As Boolean
        Public SmallList As Boolean
        Public NumberOfRows As Integer
        Public GroupName As String
        Public StartDate As String

        Public Sub PrintPageHandler( _
                ByVal sender As Object, _
                ByVal args As Printing.PrintPageEventArgs)
            Dim sSQL As String
            Dim dr As DataRow = Nothing

            Dim gr As System.Drawing.Graphics = args.Graphics

            gr.PageUnit = GraphicsUnit.Pixel
            Dim ar10 As Font = New Font("Arial", 10, FontStyle.Regular)
            Dim lngDagen As Integer = 0
            Dim I2 As Integer

            sSQL = _
                "SELECT dagentijd1, dagentijd2, dagentijd3, dagentijd4 " & _
                "FROM groep " & _
                "WHERE groepnummer = " & CStr(GroupNumber)
            dbOpenRS(dr, sSQL)
            Dim strDagEnTijd As String = "Dag(en): "
            If Not PrintEmptySheet Then
                For I2 = 1 To 4
                    If (Not dr.IsNull("dagentijd" & I2) AndAlso DirectCast(dr("dagentijd" & I2), String) <> "") Then
                        strDagEnTijd = strDagEnTijd & DirectCast(dr("dagentijd" & I2), String) & ", "
                        lngDagen += 1
                    End If
                Next
            End If

            Dim sTemp As String = "Groep: "
            If Not PrintEmptySheet Then sTemp &= GroupName

            'Printer.CurrentX = 5050 + lOffsetX
            'Printer.CurrentY = 500 + lOffsetY
            'Printer.Print(sTemp)
            gr.DrawString(sTemp, ar10, Brushes.Black, CoorX.Calc(5050), CoorY.Calc(500))

            'Printer.CurrentX = 7550 + lOffsetX
            'Printer.CurrentY = 500 + lOffsetY
            'Printer.Print("Maand: ......")
            gr.DrawString("Maand: ......", ar10, Brushes.Black, CoorX.Calc(7550), CoorY.Calc(500))

            'Printer.CurrentX = 8800 + lOffsetX
            'Printer.CurrentY = 500 + lOffsetY
            'Printer.Print("Jaar: .........")
            gr.DrawString("Jaar: .........", ar10, Brushes.Black, CoorX.Calc(8800), CoorY.Calc(500))

            dr = Nothing
            Dim dt As DataTable = Nothing
            Dim currentRow As Integer = 0

            Dim iAantalKinderen As Integer = 0
            If Not PrintEmptySheet Then
                sSQL = _
                    "SELECT naam, opmerking " & _
                    "FROM kind " & _
                    "WHERE kindnummer IN (" & _
                        "SELECT kindnummer " & _
                        "FROM groepssamenstelling " & _
                        "WHERE groepnummer = " & CStr(GroupNumber) & ") " & _
                    "ORDER BY naam"
                dbOpenRS(dt, sSQL)
                iAantalKinderen = dt.Rows.Count
            End If
            'Printer.Line((0 + lOffsetX, 1300 + lOffsetY) - (16000 + lOffsetX, 1300 + lOffsetY))
            gr.DrawLine(Pens.Black, CoorX.Calc(0), CoorY.Calc(1300), CoorX.Calc(16000), CoorY.Calc(1300))

            Dim lngFrom As Integer = 1300 + iRegelAfstand
            Dim lngTo As Integer = 1300 + (iAantalKinderen * iRegelAfstand)

            For I2 = lngFrom To lngTo Step iRegelAfstand
                'Printer.Line((0 + lOffsetX, I2 + lOffsetY) - (16000 + lOffsetX, I2 + lOffsetY))
                gr.DrawLine(Pens.Black, CoorX.Calc(0), CoorY.Calc(I2), CoorX.Calc(16000), CoorY.Calc(I2))

                If Not PrintEmptySheet Then
                    'Printer.CurrentX = 0 + lOffsetX
                    'Printer.CurrentY = I2 - iRegelAfstand + 25 + lOffsetY
                    'Printer.Print(Trim(txtStartDat.Text))
                    gr.DrawString(StartDate, ar10, Brushes.Black, CoorX.Calc(0), CoorY.Calc(I2 - iRegelAfstand + 25))

                    If dt IsNot Nothing AndAlso dt.Rows.Count > currentRow Then
                        dr = dt.Rows(currentRow)

                        'Printer.CurrentX = 2750 + lOffsetX
                        'Printer.CurrentY = I2 - iRegelAfstand + 25 + lOffsetY
                        'Printer.Print(Trim(oRS2.Fields("naam").Value))
                        gr.DrawString(Trim(DirectCast(dr("naam"), String)), ar10, Brushes.Black, CoorX.Calc(2750), CoorY.Calc(I2 - iRegelAfstand + 25))

                        If (Not dr.IsNull("opmerking")) Then
                            If (UCase(Trim(DirectCast(dr("opmerking"), String))) <> "GEEN") Then
                                'Printer.CurrentX = 12300 + lOffsetX
                                'Printer.CurrentY = I2 - iRegelAfstand + 25 + lOffsetY
                                'Printer.Print(Trim(oRS2.Fields("opmerking").Value))
                                gr.DrawString(Trim(DirectCast(dr("opmerking"), String)), ar10, Brushes.Black, CoorX.Calc(12300), CoorY.Calc(I2 - iRegelAfstand + 25))
                            End If
                        End If

                        currentRow += 1
                    End If
                End If
            Next

            If SmallList Then NumberOfRows = 15 Else NumberOfRows = 30
            For I3 As Integer = I2 To I2 + (((NumberOfRows - iAantalKinderen) * iRegelAfstand) - iRegelAfstand) Step iRegelAfstand
                'Printer.Line((0 + lOffsetX, I3 + lOffsetY) - (16000 + lOffsetX, I3 + lOffsetY))
                gr.DrawLine(Pens.Black, CoorX.Calc(0), CoorY.Calc(I3), CoorX.Calc(16000), CoorY.Calc(I3))
            Next I3

            'Verticale lijnen
            Dim iStopRij As Integer = 1300 + (NumberOfRows * iRegelAfstand)

            'Printer.Line((1150 + lOffsetX, 800 + lOffsetY) - (1150 + lOffsetX, iStopRij + lOffsetY))
            'Printer.Line((1900 + lOffsetX, 800 + lOffsetY) - (1900 + lOffsetX, iStopRij + lOffsetY))
            'Printer.Line((2700 + lOffsetX, 800 + lOffsetY) - (2700 + lOffsetX, iStopRij + lOffsetY))
            gr.DrawLine(Pens.Black, CoorX.Calc(1150), CoorY.Calc(800), CoorX.Calc(1150), CoorY.Calc(iStopRij))
            gr.DrawLine(Pens.Black, CoorX.Calc(1900), CoorY.Calc(800), CoorX.Calc(1900), CoorY.Calc(iStopRij))
            gr.DrawLine(Pens.Black, CoorX.Calc(2700), CoorY.Calc(800), CoorX.Calc(2700), CoorY.Calc(iStopRij))

            Dim blnShowLine As Boolean = False
            For I2 = 4750 To 12250 Step 250
                blnShowLine = Not blnShowLine
                If ((lngDagen > 1) Or blnShowLine) Then
                    'laat de verticale lijnen zien, bij 1 lesdag, maar 15 kolommen.
                    gr.DrawLine(Pens.Black, CoorX.Calc(I2), CoorY.Calc(850), CoorX.Calc(I2), CoorY.Calc(iStopRij))
                End If
            Next
            'Printer.Line((4750 + lOffsetX, 850 + lOffsetY) - (16000 + lOffsetX, 850 + lOffsetY))
            gr.DrawLine(Pens.Black, CoorX.Calc(4750), CoorY.Calc(850), CoorX.Calc(16000), CoorY.Calc(850))

            'Printer.CurrentX = 0 + lOffsetX
            'Printer.CurrentY = 1000 + lOffsetY
            'Printer.Print("Start Datum")
            gr.DrawString("Start Datum", ar10, Brushes.Black, CoorX.Calc(0), CoorY.Calc(1000))

            'Printer.CurrentX = 1200 + lOffsetX
            'Printer.CurrentY = 750 + lOffsetY
            'Printer.Print("Aantal")
            gr.DrawString("Aantal", ar10, Brushes.Black, CoorX.Calc(1200), CoorY.Calc(750))

            'Printer.CurrentX = 1200 + lOffsetX
            'Printer.CurrentY = 1000 + lOffsetY
            'Printer.Print("lessen")
            gr.DrawString("lessen", ar10, Brushes.Black, CoorX.Calc(1200), CoorY.Calc(1000))

            'Printer.CurrentX = 2000 + lOffsetX
            'Printer.CurrentY = 750 + lOffsetY
            'Printer.Print("Aantal")
            gr.DrawString("Aantal", ar10, Brushes.Black, CoorX.Calc(2000), CoorY.Calc(750))

            'Printer.CurrentX = 2000 + lOffsetX
            'Printer.CurrentY = 1000 + lOffsetY
            'Printer.Print("afwezig")
            gr.DrawString("afwezig", ar10, Brushes.Black, CoorX.Calc(2000), CoorY.Calc(1000))

            'Printer.CurrentX = 2750 + lOffsetX
            'Printer.CurrentY = 1000 + lOffsetY
            'Printer.Print("Naam")
            gr.DrawString("Naam", ar10, Brushes.Black, CoorX.Calc(2750), CoorY.Calc(1000))

            'Printer.Line((5000 + lOffsetX, 850 + lOffsetY) - (5000 + lOffsetX, 400 + lOffsetY))
            'Printer.Line((7500 + lOffsetX, 850 + lOffsetY) - (7500 + lOffsetX, 400 + lOffsetY))
            'Printer.Line((8750 + lOffsetX, 850 + lOffsetY) - (8750 + lOffsetX, 400 + lOffsetY))
            'Printer.Line((10000 + lOffsetX, 850 + lOffsetY) - (10000 + lOffsetX, 400 + lOffsetY))
            'Printer.Line((5000 + lOffsetX, 400 + lOffsetY) - (16000 + lOffsetX, 400 + lOffsetY))
            gr.DrawLine(Pens.Black, CoorX.Calc(5000), CoorY.Calc(850), CoorX.Calc(5000), CoorY.Calc(400))
            gr.DrawLine(Pens.Black, CoorX.Calc(7500), CoorY.Calc(850), CoorX.Calc(7500), CoorY.Calc(400))
            gr.DrawLine(Pens.Black, CoorX.Calc(8750), CoorY.Calc(850), CoorX.Calc(8750), CoorY.Calc(400))
            gr.DrawLine(Pens.Black, CoorX.Calc(10000), CoorY.Calc(850), CoorX.Calc(10000), CoorY.Calc(400))
            gr.DrawLine(Pens.Black, CoorX.Calc(5000), CoorY.Calc(400), CoorX.Calc(16000), CoorY.Calc(400))

            'Printer.CurrentX = 10050 + lOffsetX
            'Printer.CurrentY = 500 + lOffsetY
            'Printer.Print(Mid(strDagEnTijd, 1, Len(strDagEnTijd) - 2))
            gr.DrawString(Mid(strDagEnTijd, 1, Len(strDagEnTijd) - 2), ar10, Brushes.Black, CoorX.Calc(10050), CoorY.Calc(500))

            'Printer.CurrentX = 13550 + lOffsetX
            'Printer.CurrentY = 1000 + lOffsetY
            'Printer.Print("Opmerking")
            gr.DrawString("Opmerking", ar10, Brushes.Black, CoorX.Calc(13550), CoorY.Calc(1000))
        End Sub
    End Class
End Class