Imports System.Drawing.Printing

Friend Class frmPrintKids
    Inherits System.Windows.Forms.Form

    Public Sub checkChkBox(ByRef ChkBox As System.Windows.Forms.CheckBox)
        Dim iCount As Integer

        iCount = 0
        If (chkInsDat.CheckState = 1) Then
            iCount = iCount + 1
        End If
        If (chkPrioriteit.CheckState = 1) Then
            iCount = iCount + 1
        End If
        If (chkNaam.CheckState = 1) Then
            iCount = iCount + 1
        End If
        If (chkGebDat.CheckState = 1) Then
            iCount = iCount + 1
        End If
        If (chkTelnr.CheckState = 1) Then
            iCount = iCount + 1
        End If
        If (chkOpm.CheckState = 1) Then
            iCount = iCount + 1
        End If
        If (chkOpmWachtlijst.CheckState = 1) Then
            iCount = iCount + 1
        End If
        If (iCount > 5) Then
            lblCheckBox.Text = "Selecteer maximaal 5 boxes."
            tmrKlok.Enabled = False
            tmrKlok.Enabled = True
            ChkBox.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
    End Sub

    Private Sub btnClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPrint.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim sSQL As String
        Dim dt As DataTable = Nothing
        Dim sMultiplier As String = String.Empty
        Dim sOffsetX As String = String.Empty
        Dim sOffsetY As String = String.Empty

        RegGetValue("HKEY_CURRENT_USER\Software\Veenbad\Printer\LKMultiplier", sMultiplier, "1")
        RegGetValue("HKEY_CURRENT_USER\Software\Veenbad\Printer\LKOffsetX", sOffsetX, "0")
        RegGetValue("HKEY_CURRENT_USER\Software\Veenbad\Printer\LKOffsetY", sOffsetY, "0")

        Dim coorX As New PrintCoordinator()
        Dim coorY As New PrintCoordinator()

        If (Not Decimal.TryParse(sMultiplier, coorX.Multiplier)) Then coorX.Multiplier = 1
        coorY.Multiplier = coorX.Multiplier
        Integer.TryParse(sOffsetX, coorX.Offset)
        Integer.TryParse(sOffsetY, coorY.Offset)

        btnPrint.Enabled = False
        btnClose.Enabled = False
        lvGroepen.Enabled = False
        txtTop.Enabled = False
        chkNaam.Enabled = False
        chkGebDat.Enabled = False
        chkInsDat.Enabled = False
        chkTelnr.Enabled = False
        chkOpm.Enabled = False
        chkPrioriteit.Enabled = False
        chkOpmWachtlijst.Enabled = False

        System.Windows.Forms.Application.DoEvents()

        PrintDialog1.PrinterSettings.DefaultPageSettings.Landscape = False
        PrintDialog1.ShowDialog()

        If lvGroepen.SelectedItems(0).Name = "wachtlijst" Then
            sSQL = _
                "SELECT * " & _
                "FROM kind k, wachtlijst w " & _
                "WHERE k.kindnummer = w.kindnummer " & _
                "ORDER BY w.prioriteit, k.inschrijfdatum"

        ElseIf lvGroepen.SelectedItems(0).Name = "transferlijst" Then
            sSQL = _
                "SELECT * " & _
                "FROM kind " & _
                "WHERE kindnummer IN (" & _
                    "SELECT kindnummer " & _
                    "FROM transferlijst) " & _
                "ORDER BY naam"

        ElseIf Mid(lvGroepen.SelectedItems(0).Name, 1, 5) = "groep" Then
            sSQL = _
                "SELECT * " & _
                "FROM kind " & _
                "WHERE kindnummer IN (" & _
                    "SELECT kindnummer " & _
                    "FROM groepssamenstelling " & _
                    "WHERE groepnummer = " & Mid(lvGroepen.SelectedItems(0).Name, 6) & ") " & _
                "ORDER BY naam"
        Else
            Throw New Exception("Selecteer een valide groep!")
        End If

        dbOpenRS(dt, sSQL)
        If dt.Rows.Count > 0 Then
            Dim linesToPrint As Integer = CInt(txtTop.Text)
            If (linesToPrint = 0) Then linesToPrint = dt.Rows.Count

            Dim printJob As New PrintJob()
            Dim printDoc As New PrintDocument()
            printDoc.PrinterSettings = PrintDialog1.PrinterSettings
            printDoc.PrinterSettings.DefaultPageSettings.Landscape = False
            AddHandler printDoc.PrintPage, AddressOf printJob.PrintPageHandler
            printJob.CoorX = coorX
            printJob.CoorY = coorY
            printJob.DataTableKids = dt
            printJob.IncludeInschrijfDatum = (chkInsDat.CheckState = CheckState.Checked)
            printJob.IncludePrioriteit = (chkPrioriteit.CheckState = CheckState.Checked)
            printJob.IncludeNaam = (chkNaam.CheckState = CheckState.Checked)
            printJob.IncludeGeboorteDatum = (chkGebDat.CheckState = CheckState.Checked)
            printJob.IncludeTelefoonnummer = (chkTelnr.CheckState = CheckState.Checked)
            printJob.IncludeOpmerking = (chkOpm.CheckState = CheckState.Checked)
            printJob.IncludeOpmerkingWachtLijst = (chkOpmWachtlijst.CheckState = CheckState.Checked)
            printJob.totalNrOfLines = dt.Rows.Count
            AddHandler printJob.PercentageComplete, AddressOf updateProgressBar
            printDoc.Print()
        End If

        MsgBox("Document is naar de printer verzonden.", MsgBoxStyle.Information, "Informatie")
        Me.Close()
        Exit Sub

print_error:
        Me.Cursor = System.Windows.Forms.Cursors.Default
        MsgBox("Fout tijdens printen." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation, "Foutmelding")
        'UPGRADE_ISSUE: Printer method Printer.KillDoc was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
        'Printer.KillDoc()
    End Sub

    Private Sub updateProgressBar(ByVal percentage As Integer)
        pbPrinting.Value = percentage
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub chkGebDat_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkGebDat.CheckStateChanged
        checkChkBox(chkGebDat)
    End Sub

    Private Sub chkInsDat_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkInsDat.CheckStateChanged
        checkChkBox(chkInsDat)
    End Sub

    Private Sub chkNaam_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkNaam.CheckStateChanged
        checkChkBox(chkNaam)
    End Sub

    Private Sub chkOpm_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkOpm.CheckStateChanged
        checkChkBox(chkOpm)
    End Sub

    Private Sub chkOpmWachtlijst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkOpmWachtlijst.CheckStateChanged
        checkChkBox(chkOpmWachtlijst)
    End Sub

    Private Sub chkPrioriteit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkPrioriteit.CheckStateChanged
        checkChkBox(chkPrioriteit)
    End Sub

    Private Sub chkTelnr_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkTelnr.CheckStateChanged
        checkChkBox(chkTelnr)
    End Sub

    Private Sub frmPrintKids_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim liItem As System.Windows.Forms.ListViewItem
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing
        Dim sSQL As String

        GetWindowProperties(Me)

        dbOpenRS(dr, "SELECT COUNT(*) FROM wachtlijst")
        liItem = lvGroepen.Items.Add("wachtlijst", "Wachtlijst", "")
        liItem.SubItems.Add(String.Empty)
        liItem.SubItems.Add(CStr(dr(0)))

        dbOpenRS(dr, "SELECT COUNT(*) FROM transferlijst")
        liItem = lvGroepen.Items.Add("transferlijst", "Transferlijst", "")
        liItem.SubItems.Add(String.Empty)
        liItem.SubItems.Add(CStr(dr(0)))

        sSQL = _
            "SELECT g.groepnummer, g.naam, COUNT(*) " & _
            "FROM groep g " & _
            "INNER JOIN groepssamenstelling s ON g.groepnummer = s.groepnummer " & _
            "GROUP BY g.groepnummer, g.naam"
        dbOpenRS(dt, sSQL)
        For Each dr In dt.Rows
            liItem = lvGroepen.Items.Add("groep" & CStr(dr("groepnummer")), DirectCast(dr("naam"), String), String.Empty)
            liItem.SubItems.Add(CStr(dr("groepnummer")))
            liItem.SubItems.Add(CStr(dr(2)))
        Next dr
        mdiMain.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub frmPrintKids_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        SetWindowProperties(Me)
        eventArgs.Cancel = Cancel
    End Sub

    'UPGRADE_ISSUE: MSComctlLib.ListView event lvGroepen.ItemClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
    Private Sub lvGroepen_ItemClick(ByVal Item As System.Windows.Forms.ListViewItem)
        checkItem()
    End Sub

    Public Sub checkItem()
        If (lvGroepen.SelectedItems(0).Name = "wachtlijst") Then
            chkPrioriteit.Enabled = True
            chkOpmWachtlijst.Enabled = True
        Else
            chkPrioriteit.CheckState = System.Windows.Forms.CheckState.Unchecked
            chkPrioriteit.Enabled = False
            chkOpmWachtlijst.CheckState = System.Windows.Forms.CheckState.Unchecked
            chkOpmWachtlijst.Enabled = False
        End If
    End Sub

    Private Sub tmrKlok_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrKlok.Tick
        tmrKlok.Enabled = False
        lblCheckBox.Text = String.Empty
    End Sub

    Private Class PrintDoc : Inherits PrintDocument
        Public DataTableKids As DataTable
        Public totalNrOfLines As Integer

        Private currentPage As Integer = 0

        Protected Overrides Sub OnPrintPage( _
                ByVal e As System.Drawing.Printing.PrintPageEventArgs)
            MyBase.OnPrintPage(e)
            currentPage += 1

            e.HasMorePages = ((currentPage * 70) > totalNrOfLines)
        End Sub
    End Class

    Private Class PrintJob
        Const linesPerPage As Integer = 70
        Const iRegelAfstand As Integer = 200

        Public DataTableKids As DataTable
        Public CoorX As PrintCoordinator
        Public CoorY As PrintCoordinator
        Public totalNrOfLines As Integer
        Public IncludeInschrijfDatum As Boolean
        Public IncludePrioriteit As Boolean
        Public IncludeNaam As Boolean
        Public IncludeGeboorteDatum As Boolean
        Public IncludeTelefoonnummer As Boolean
        Public IncludeOpmerking As Boolean
        Public IncludeOpmerkingWachtLijst As Boolean

        Private currentPage As Integer = 1
        Private currentLine As Integer = 1

        Public Event PercentageComplete(ByVal percentageCompleted As Integer)

        Public Sub PrintPageHandler( _
                ByVal sender As Object, _
                ByVal args As Printing.PrintPageEventArgs)

            Dim gr As System.Drawing.Graphics = args.Graphics
            gr.PageUnit = GraphicsUnit.Pixel

            Dim iCount As Integer = 0
            Dim iCurrentCoor As Single = 900
            Dim iCoor(5) As Single

            iCurrentCoor = CoorX.Calc(900)
            If (IncludeInschrijfDatum) Then
                iCoor(iCount) = iCurrentCoor
                iCurrentCoor += CoorX.Calc(1250)
                iCount += 1
            End If
            If (IncludePrioriteit) Then
                iCoor(iCount) = iCurrentCoor
                iCurrentCoor += CoorX.Calc(500)
                iCount += 1
            End If
            If (IncludeNaam) Then
                iCoor(iCount) = iCurrentCoor
                iCurrentCoor += CoorX.Calc(3000)
                iCount += 1
            End If
            If (IncludeGeboorteDatum) Then
                iCoor(iCount) = iCurrentCoor
                iCurrentCoor += CoorX.Calc(1250)
                iCount += 1
            End If
            If (IncludeTelefoonnummer) Then
                iCoor(iCount) = iCurrentCoor
                iCurrentCoor += CoorX.Calc(1500)
                iCount += 1
            End If
            If (IncludeOpmerking) Then
                iCoor(iCount) = iCurrentCoor
                iCurrentCoor += CoorX.Calc(3000)
                iCount += 1
            End If
            If (IncludeOpmerkingWachtLijst) Then
                iCoor(iCount) = iCurrentCoor
            End If

            'iCoor(1) = CSng((3000 + OffsetX) / 2.5)
            'iCoor(2) = CSng((5000 + OffsetX) / 2.5)
            'iCoor(3) = CSng((7000 + OffsetX) / 2.5)
            'iCoor(4) = CSng((8500 + OffsetX) / 2.5)
            'iCoor(5) = CSng((10000 + OffsetX) / 2.5)

            Dim ar10 As Font = New Font("Arial", 10, FontStyle.Regular)

            Dim sSQL As String
            Dim dr As DataRow
            Dim dr2 As DataRow = Nothing
            'Printer.Font = VB6.FontChangeSize(Printer.Font, 10)
            'Printer.CurrentX = 0 + lOffsetX
            'Printer.CurrentY = 250 + lOffsetY
            'Printer.Orientation = vbPRORPortrait
            'Printer.Print("Nummer")
            gr.DrawString("Nummer", ar10, Brushes.Black, CoorX.Calc(0), CoorY.Calc(250))

            iCount = 0
            If IncludeInschrijfDatum Then
                'Printer.CurrentX = iCoor(iCount) + lOffsetX
                'Printer.CurrentY = 250 + lOffsetY
                'Printer.Print("Ins. Dat.")
                gr.DrawString("Ins. Dat.", ar10, Brushes.Black, iCoor(iCount), CoorY.Calc(250))
                iCount = iCount + 1
            End If
            If IncludePrioriteit Then
                'Printer.CurrentX = iCoor(iCount) + lOffsetX
                'Printer.CurrentY = 250 + lOffsetY
                'Printer.Print("Prioriteit")
                gr.DrawString("Prioriteit", ar10, Brushes.Black, iCoor(iCount), CoorY.Calc(250))
                iCount = iCount + 1
            End If
            If IncludeNaam Then
                'Printer.CurrentX = iCoor(iCount) + lOffsetX
                'Printer.CurrentY = 250 + lOffsetY
                'Printer.Print("Naam")
                gr.DrawString("Naam", ar10, Brushes.Black, iCoor(iCount), CoorY.Calc(250))
                iCount = iCount + 1
            End If
            If IncludeGeboorteDatum Then
                'Printer.CurrentX = iCoor(iCount) + lOffsetX
                'Printer.CurrentY = 250 + lOffsetY
                'Printer.Print("Geb. Dat.")
                gr.DrawString("Geb. Dat.", ar10, Brushes.Black, iCoor(iCount), CoorY.Calc(250))
                iCount = iCount + 1
            End If
            If IncludeTelefoonnummer Then
                'Printer.CurrentX = iCoor(iCount) + lOffsetX
                'Printer.CurrentY = 250 + lOffsetY
                'Printer.Print("Tel. Nr.")
                gr.DrawString("Tel. Nr.", ar10, Brushes.Black, iCoor(iCount), CoorY.Calc(250))
                iCount = iCount + 1
            End If
            If IncludeOpmerking Then
                'Printer.CurrentX = iCoor(iCount) + lOffsetX
                'Printer.CurrentY = 250 + lOffsetY
                'Printer.Print("Opmerking Kind")
                gr.DrawString("Opmerking kind", ar10, Brushes.Black, iCoor(iCount), CoorY.Calc(250))
                iCount = iCount + 1
            End If
            If IncludeOpmerkingWachtLijst Then
                'Printer.CurrentX = iCoor(iCount) + lOffsetX
                'Printer.CurrentY = 250 + lOffsetY
                'Printer.Print("Opmerking Wachtlijst")
                gr.DrawString("Opmerking wachtlijst", ar10, Brushes.Black, iCoor(iCount), CoorY.Calc(250))
            End If

            Dim startLine As Integer = ((currentPage - 1) * 70) + 1
            Dim endLine As Integer = startLine + 69
            If (endLine > totalNrOfLines) Then endLine = totalNrOfLines

            'Printer.Print("")
            For i As Integer = startLine To endLine
                dr = DataTableKids.Rows(i - 1)
                iCount = 0
                'Printer.CurrentX = 0 + lOffsetX
                'Printer.CurrentY = (iRegelAfstand * iLine) + lOffsetY
                'Printer.Print(oRS.Fields("kindnummer").Value)
                gr.DrawString(CStr(dr("kindnummer")), ar10, Brushes.Black, CoorX.Calc(0), CSng(iRegelAfstand * i) + CoorY.Calc(250))

                If IncludeInschrijfDatum Then
                    'Printer.CurrentX = iCoor(iCount) + lOffsetX
                    'Printer.CurrentY = (iRegelAfstand * iLine) + lOffsetY
                    'Printer.Print(oRS.Fields("inschrijfdatum").Value)
                    gr.DrawString(CStr(dr("inschrijfdatum")), ar10, Brushes.Black, iCoor(iCount), CSng(iRegelAfstand * i) + CoorY.Calc(250))
                    iCount = iCount + 1
                End If
                If IncludePrioriteit Then
                    'Printer.CurrentX = iCoor(iCount) + lOffsetX
                    'Printer.CurrentY = (iRegelAfstand * iLine) + lOffsetY
                    'Printer.Print(oRS.Fields("prioriteit").Value)
                    gr.DrawString(CStr(dr("prioriteit")), ar10, Brushes.Black, iCoor(iCount), CSng(iRegelAfstand * i) + CoorY.Calc(250))
                    iCount = iCount + 1
                End If
                If IncludeNaam Then
                    'Printer.CurrentX = iCoor(iCount) + lOffsetX
                    'Printer.CurrentY = (iRegelAfstand * iLine) + lOffsetY
                    'Printer.Print(oRS.Fields("naam").Value)
                    gr.DrawString(DirectCast(dr("naam"), String), ar10, Brushes.Black, iCoor(iCount), CSng(iRegelAfstand * i) + CoorY.Calc(250))
                    iCount = iCount + 1
                End If
                If IncludeGeboorteDatum Then
                    'Printer.CurrentX = iCoor(iCount) + lOffsetX
                    'Printer.CurrentY = (iRegelAfstand * iLine) + lOffsetY
                    'Printer.Print(oRS.Fields("geboortedatum").Value)
                    gr.DrawString(CStr(dr("geboortedatum")), ar10, Brushes.Black, iCoor(iCount), CSng(iRegelAfstand * i) + CoorY.Calc(250))
                    iCount = iCount + 1
                End If
                If IncludeTelefoonnummer Then
                    'Printer.CurrentX = iCoor(iCount) + lOffsetX
                    'Printer.CurrentY = (iRegelAfstand * iLine) + lOffsetY
                    'Printer.Print(oRS.Fields("telefoonnummer").Value)
                    gr.DrawString(DirectCast(dr("telefoonnummer"), String), ar10, Brushes.Black, iCoor(iCount), CSng(iRegelAfstand * i) + CoorY.Calc(250))
                    iCount = iCount + 1
                End If
                If IncludeOpmerking Then
                    'Printer.CurrentX = iCoor(iCount) + lOffsetX
                    'Printer.CurrentY = (iRegelAfstand * iLine) + lOffsetY
                    'Printer.Print(oRS.Fields("opmerking").Value)
                    If (Not dr.IsNull("opmerking")) Then
                        gr.DrawString(DirectCast(dr("opmerking"), String), ar10, Brushes.Black, iCoor(iCount), CSng(iRegelAfstand * i) + CoorY.Calc(250))
                    End If
                    iCount = iCount + 1
                End If
                If (IncludeOpmerkingWachtLijst) Then
                    iCount = iCount + 1
                    sSQL = _
                        "SELECT opmerking " & _
                        "FROM wachtlijst " & _
                        "WHERE kindnummer = " & CStr(dr("kindnummer"))
                    dbOpenRS(dr2, sSQL)

                    If dr2 IsNot Nothing Then
                        'Printer.CurrentX = iCoor(iCount) + lOffsetX
                        'Printer.CurrentY = (iRegelAfstand * iLine) + lOffsetY
                        'Printer.Print(oRS2.Fields("opmerking").Value)
                        If (Not dr.IsNull("opmerking")) Then
                            gr.DrawString(DirectCast(dr("opmerking"), String), ar10, Brushes.Black, iCoor(iCount), CSng(iRegelAfstand * i) + CoorY.Calc(250))
                        End If
                    End If
                End If

                RaiseEvent PercentageComplete(CInt(100 / (((endLine - startLine) + 1) / (i - startLine + 1))))
            Next i
        End Sub
    End Class
End Class