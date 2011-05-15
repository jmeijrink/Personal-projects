Imports System.Drawing.Printing

Friend Class frmPrintDiplomas
    Inherits System.Windows.Forms.Form

    Private Sub btnClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub countItems()
        Dim iItem As System.Windows.Forms.ListViewItem
        Dim iCount As Integer

        iCount = 0
        For Each iItem In lvKinderen.Items
            If iItem.Checked = True Then
                iCount = iCount + 1
            End If
        Next iItem
        lblAantal.Text = "Aantal: " & iCount
    End Sub

    Private Sub btnDesAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnDesAll.Click
        Dim iItem As System.Windows.Forms.ListViewItem
        For Each iItem In lvKinderen.Items
            iItem.Checked = False
        Next iItem
        Call countItems()
    End Sub

    Private Sub btnPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnPrint.Click
        Dim printSettings As New PrintSettings()
        Select Case cmbDiploma.Text
            Case "Diploma A"
                printSettings.DocumentType = HetVeenbad.PrintSettings.PrintType.DiplomaA

            Case "Diploma B"
                printSettings.DocumentType = HetVeenbad.PrintSettings.PrintType.DiplomaB

            Case "Diploma C"
                printSettings.DocumentType = HetVeenbad.PrintSettings.PrintType.DiplomaC

            Case Else
                MessageBox.Show("Selecteer een diploma.")
                Return
        End Select
        printSettings.ReadSettings()

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim iItem As System.Windows.Forms.ListViewItem
        Dim coorX As New PrintCoordinator()
        Dim coorY As New PrintCoordinator()

        coorX.Multiplier = printSettings.Multiplier
        coorY.Multiplier = printSettings.Multiplier
        coorX.Offset = printSettings.OffsetX
        coorY.Offset = printSettings.OffsetY

        lvGroepen.Enabled = False
        lvKinderen.Enabled = False
        btnSelAll.Enabled = False
        btnDesAll.Enabled = False
        txtAfzDat.Enabled = False
        btnPrint.Enabled = False
        btnClose.Enabled = False

        System.Windows.Forms.Application.DoEvents()

        PrintDialog1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintDialog1.ShowDialog()

        Dim iAantal As Integer = 0
        For Each iItem In lvKinderen.Items
            If iItem.Checked Then iAantal += 1
        Next iItem

        System.Windows.Forms.Application.DoEvents()
        pbPrinten.Maximum = iAantal
        For Each iItem In lvKinderen.Items
            If iItem.Checked Then
                Dim printJob As New PrintJob()
                Dim printDoc As New PrintDocument()
                AddHandler printDoc.PrintPage, AddressOf printJob.PrintPageHandler
                printJob.KindNummer = CInt(Mid(iItem.Name, 5))
                printJob.CoorX = coorX
                printJob.CoorY = coorY
                printJob.AfzwemDatum = txtAfzDat.Text
                printDoc.PrinterSettings = PrintDialog1.PrinterSettings
                printDoc.PrinterSettings.DefaultPageSettings.Landscape = True
                'printDoc.PrinterSettings.PrintToFile = True
                'printDoc.PrinterSettings.PrintFileName = "c:\print.tmp"
                printDoc.Print()
                pbPrinten.Value += 1
            End If
        Next iItem

        MsgBox("Alle diploma's zijn verzonden.", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Status")
        lvGroepen.Enabled = True
        lvKinderen.Enabled = True
        btnSelAll.Enabled = True
        btnDesAll.Enabled = True
        txtAfzDat.Enabled = True
        btnPrint.Enabled = True
        btnClose.Enabled = True

        Me.Cursor = System.Windows.Forms.Cursors.Default
        pbPrinten.Value = 0

        Exit Sub

print_error:
        Me.Cursor = System.Windows.Forms.Cursors.Default
        MsgBox("Fout tijdens het printen." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation, "Foutmelding")
        On Error Resume Next

print_cancel:
        lvGroepen.Enabled = True
        lvKinderen.Enabled = True
        btnSelAll.Enabled = True
        btnDesAll.Enabled = True
        txtAfzDat.Enabled = True
        btnPrint.Enabled = True
        btnClose.Enabled = True
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub


    Private Sub btnSelAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSelAll.Click
        Dim iItem As System.Windows.Forms.ListViewItem
        For Each iItem In lvKinderen.Items
            iItem.Checked = True
        Next iItem
        Call countItems()
    End Sub

    Private Sub frmPrintDiplomas_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        GetWindowProperties(Me)
        Call listGroups()
        Call countItems()
        mdiMain.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub listGroups()
        Dim sSQL As String
        Dim dt As DataTable = Nothing
        Dim liItem As System.Windows.Forms.ListViewItem

        sSQL = "SELECT naam, groepnummer FROM GROEP"
        dbOpenRS(dt, sSQL)
        For Each dr As DataRow In dt.Rows
            liItem = lvGroepen.Items.Add("groep" & CStr(dr("groepnummer")), DirectCast(dr("naam"), String), "")
            liItem.SubItems.Add(CStr(dr("groepnummer")))
        Next dr

        If lvGroepen.SelectedItems.Count = 0 Then
            lvKinderen.Items.Clear()
        Else
            Call listKids()
        End If

        txtAfzDat.Text = VB6.Format(Today, "d mmmm yyyy")
    End Sub

    Private Sub listKids()
        Dim sSQL As String
        Dim dt As DataTable = Nothing
        Dim liItem As System.Windows.Forms.ListViewItem
        Dim iGroep As Short

        lvKinderen.Items.Clear()
        If (lvGroepen.Items.Count > 0) Then
            If (lvGroepen.SelectedItems.Count = 1) Then
                iGroep = CShort(Mid(lvGroepen.SelectedItems(0).Name, 6))
                sSQL = _
                    "SELECT naam, kindnummer " & _
                    "FROM kind " & _
                    "WHERE kindnummer IN (" & _
                        "SELECT kindnummer " & _
                        "FROM groepssamenstelling " & _
                        "WHERE groepnummer = " & iGroep & ") " & _
                    "ORDER BY naam"
                dbOpenRS(dt, sSQL)
                For Each dr As DataRow In dt.Rows
                    liItem = lvKinderen.Items.Add("kind" & CStr(dr("kindnummer")), DirectCast(dr("naam"), String), "")
                    liItem.SubItems.Add(CStr(dr("kindnummer")))
                    liItem.Checked = True
                Next dr
            End If
        Else
            MsgBox("Er zijn nog geen groepen gedefinieerd.", MsgBoxStyle.Exclamation, "Foutmelding")
        End If
        countItems()
    End Sub

    Private Sub frmPrintDiplomas_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        SetWindowProperties(Me)
        eventArgs.Cancel = Cancel
    End Sub

    Private Sub lvKinderen_ItemCheck(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ItemCheckEventArgs) Handles lvKinderen.ItemCheck
        Dim Item As System.Windows.Forms.ListViewItem = lvKinderen.Items(eventArgs.Index)
        Call countItems()
    End Sub

    Private Class PrintJob
        Public KindNummer As Integer
        Public AfzwemDatum As String
        Public CoorX As PrintCoordinator
        Public CoorY As PrintCoordinator

        Private Const Multiplier As Single = 2.5

        Public Sub PrintPageHandler( _
                ByVal sender As Object, _
                ByVal args As Printing.PrintPageEventArgs)

            Dim dr As DataRow = Nothing
            Dim sSQL As String = _
                "SELECT naam, geboortedatum " & _
                "FROM kind " & _
                "WHERE kindnummer = " & CStr(KindNummer)
            dbOpenRS(dr, sSQL)

            Dim gr As System.Drawing.Graphics = args.Graphics
            Dim sv40 As Font = New Font("ShelleyVolante BT", 40, FontStyle.Regular)
            Dim sv14 As Font = New Font("ShelleyVolante BT", 14, FontStyle.Regular)
            Dim ar9 As Font = New Font("Arial", 9, FontStyle.Regular)

            gr.PageUnit = GraphicsUnit.Pixel
            'Printer.CurrentX = 2850 + lOffsetX
            'Printer.CurrentY = 6350 + lOffsetY
            'Printer.Font = VB6.FontChangeName(Printer.Font, "ShelleyVolante BT")
            'Printer.Font = VB6.FontChangeSize(Printer.Font, 40)
            'Printer.Print(Trim(DirectCast(dr("naam"), String)))
            'CSng((2850 + OffsetX) / Multiplier), CSng((6350 + OffsetY) / Multiplier)
            gr.DrawString(Trim(DirectCast(dr("naam"), String)), sv40, Brushes.Black, CoorX.Calc(2850), CoorY.Calc(6350))

            'Printer.CurrentX = 3200 + lOffsetX
            'Printer.CurrentY = 7550 + lOffsetY
            'Printer.Font = VB6.FontChangeSize(Printer.Font, 14)
            'Printer.Print(VB6.Format(DirectCast(dr("geboortedatum"), Date), "d mmmm yyyy"))
            gr.DrawString(VB6.Format(DirectCast(dr("geboortedatum"), Date), "d mmmm yyyy"), sv14, Brushes.Black, CoorX.Calc(3200), CoorY.Calc(7550))
            'Printer.CurrentX = 3200 + lOffsetX
            'Printer.CurrentY = 7925 + lOffsetY
            'Printer.Print(txtAfzDat.Text)
            gr.DrawString(AfzwemDatum, sv14, Brushes.Black, CoorX.Calc(3200), CoorY.Calc(7925))

            'Printer.CurrentX = 9250 + lOffsetX
            'Printer.CurrentY = 7900 + lOffsetY
            'Printer.Print("Zwembad Het Veenbad")
            gr.DrawString("Zwembad Het Veenbad", sv14, Brushes.Black, CoorX.Calc(9250), CoorY.Calc(7900))

            'Printer.CurrentX = 9350 + lOffsetX
            'Printer.CurrentY = 8630 + lOffsetY
            'Printer.Print("Het Veenbad, Vinkeveen")
            gr.DrawString("Het Veenbad, Vinkeveen", sv14, Brushes.Black, CoorX.Calc(9350), CoorY.Calc(8630))

            'Printer.Font = VB6.FontChangeName(Printer.Font, "Arial")
            'Printer.Font = VB6.FontChangeSize(Printer.Font, 9)
            'Printer.CurrentX = 3200 + lOffsetX
            'Printer.CurrentY = 10250 + lOffsetY
            'Printer.Print("Janna Stokhof")
            gr.DrawString("Janna Stokhof", ar9, Brushes.Black, CoorX.Calc(3200), CoorY.Calc(10250))

            'Printer.CurrentX = 5250 + lOffsetX
            'Printer.CurrentY = 10250 + lOffsetY
            'Printer.Print("Linda Bos")
            gr.DrawString("Linda Bos", ar9, Brushes.Black, CoorX.Calc(5250), CoorY.Calc(10250))
        End Sub
    End Class

    Private Sub lvGroepen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvGroepen.SelectedIndexChanged
        Call listKids()
    End Sub
End Class

