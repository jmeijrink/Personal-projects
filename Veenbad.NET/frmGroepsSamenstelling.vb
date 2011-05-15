Imports VB = Microsoft.VisualBasic
Imports System.Data.OleDb

Friend Class frmGroepsSamenstelling
    Inherits System.Windows.Forms.Form
    Private _dragBoxFromMouseDown As Nullable(Of Rectangle)

    Private Sub btnClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnGroepen_Click()
        Call readGroups(lvBrowser)
        lvBrowser.Focus()
    End Sub

    Private Sub btnWijzigen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnWijzigen.Click
        Dim iKind As Short
        Dim iGroep As Short

        If (txtType.Text = "Kind") Then
            iKind = CShort(Mid(lvBrowser.SelectedItems(0).Name, 5))
            frmWijzigenKinderen.Show()
            Call frmWijzigenKinderen.SelectChild(iKind)
            frmWijzigenKinderen.Activate()
        ElseIf (txtType.Text = "Groep") Then
            iGroep = CShort(Mid(lvBrowser.SelectedItems(0).Name, 6))
            frmWijzigenGroepen.Show()
            Call frmWijzigenGroepen.SelectGroup(iGroep)
            frmWijzigenGroepen.Activate()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnDelete.Click
        Dim iItem As Short

        If (txtType.Text = "Kind") Then
            iItem = CShort(Mid(lvBrowser.SelectedItems(0).Name, 5))
            frmWijzigenKinderen.Show()
            Call frmWijzigenKinderen.SelectChild(iItem)
            frmWijzigenKinderen.Activate()
            frmWijzigenKinderen.btnDelete_Click(Nothing, New System.EventArgs())
        ElseIf (txtType.Text = "Groep") Then
            iItem = CShort(Mid(lvBrowser.SelectedItems(0).Name, 6))
            frmWijzigenGroepen.Show()
            Call frmWijzigenGroepen.SelectGroup(iItem)
            frmWijzigenGroepen.Activate()
            frmWijzigenGroepen.btnVerwijderen_Click(Nothing, New System.EventArgs())
        End If
    End Sub

    Private Sub frmGroepsSamenstelling_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        GetWindowProperties(Me)
        Call readGroups(lvBrowser)
        Call readGroups(lvGroepen)
        mdiMain.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Public Sub readGroups( _
            ByRef lvTarget As System.Windows.Forms.ListView)
        Dim dt As DataTable = Nothing
        Dim cmd As OleDb.OleDbCommand

        lvTarget.Items.Clear()
        lvTarget.View = View.LargeIcon
        lvTarget.MultiSelect = False

        lvTarget.Tag = "Groepen"
        If (lvTarget Is lvBrowser) Then
            txtGroep.Text = "Overzicht"
        Else
            txtGroep2.Text = "Overzicht"
        End If

        lvTarget.Items.Add("wachtlijst", "Wachtlijst", 1)
        lvTarget.Items.Add("transferlijst", "Transferlijst", 2)
        If (lvTarget Is lvBrowser) Then
            lvBrowser.Items.Add("alleen", "Niet ingedeeld", 4)
        End If

        cmd = New OleDb.OleDbCommand()
        cmd.CommandText = _
            "SELECT * " & _
            "FROM groep"
        dbOpenRS(dt, cmd)

        For Each dr As DataRow In dt.Rows
            lvTarget.Items.Add("groep" & CStr(dr("groepnummer")), DirectCast(dr("naam"), String), 0)
        Next dr

        lvTarget.Items(0).Selected = True
        ItemClick(lvTarget.Items(0))
    End Sub

    Private Sub frmGroepsSamenstelling_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        mdiMain.bGroepsSamenStellingLoaded = False
        SetWindowProperties(Me)
        eventArgs.Cancel = Cancel
    End Sub

    Private Sub lvBrowser_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvBrowser.DoubleClick
        If (CStr(lvBrowser.Tag) = "Groepen") Then
            lvBrowser.MultiSelect = True
            If (lvBrowser.SelectedItems(0).Name = "wachtlijst") Then
                txtGroep.Text = "Wachtlijst"
                lvBrowser.Tag = "wachtlijst"
            ElseIf (lvBrowser.SelectedItems(0).Name = "transferlijst") Then
                txtGroep.Text = "Transferlijst"
                lvBrowser.Tag = "transferlijst"
            ElseIf (lvBrowser.SelectedItems(0).Name = "alleen") Then
                txtGroep.Text = "Niet Ingedeeld"
                lvBrowser.Tag = "alleen"
            Else
                txtGroep.Text = lvBrowser.SelectedItems(0).Text
                lvBrowser.Tag = lvBrowser.SelectedItems(0).Name
            End If
            readbrowsekids()
            If (lvBrowser.SelectedItems.Count > 0) Then
                ItemClick(lvBrowser.SelectedItems(0))
            Else
                lblLine1.Text = String.Empty
                lblLine2.Text = String.Empty
                lblLine3.Text = String.Empty
                lblLine4.Text = String.Empty
                lblLine5.Text = String.Empty
                lblLine6.Text = String.Empty
                txtLine1.Visible = False
                txtLine2.Visible = False
                txtLine3.Visible = False
                txtLine4.Visible = False
                txtLine5.Visible = False
                txtLine6.Visible = False
                btnWijzigen.Enabled = False
                btnDelete.Enabled = False
            End If
        End If
    End Sub

    Public Sub readbrowsekids()
        Dim cmd As OleDb.OleDbCommand
        Dim dt As DataTable = Nothing
        Dim dt2 As DataTable = Nothing
        Dim liListItem As System.Windows.Forms.ListViewItem
        Dim iIndex As Integer

        On Error Resume Next
        iIndex = lvBrowser.SelectedItems(0).Index
        lvBrowser.Items.Clear()
        lvBrowser.View = System.Windows.Forms.View.Details
        If (CStr(lvBrowser.Tag) = "wachtlijst") Then
            lvBrowser.Columns.Item(1).Text = "Prioriteit"
            cmd = New OleDb.OleDbCommand()
            cmd.CommandText = _
                "SELECT wachtlijst.kindnummer, kind.naam, wachtlijst.prioriteit " & _
                "FROM wachtlijst, kind " & _
                "WHERE wachtlijst.kindnummer = kind.kindnummer " & _
                "ORDER BY wachtlijst.prioriteit, kind.naam"
            dbOpenRS(dt, cmd)

            For Each dr As DataRow In dt.Rows
                liListItem = lvBrowser.Items.Add("kind" & Trim(CStr(dr("kindnummer"))), Trim(DirectCast(dr("naam"), String)), "")
                liListItem.SubItems.Add(Trim(CStr(dr("prioriteit"))))
            Next dr

        ElseIf (CStr(lvBrowser.Tag) = "transferlijst") Then
            lvBrowser.Columns.Item(1).Text = ""
            cmd = New OleDb.OleDbCommand()
            cmd.CommandText = _
                "SELECT transferlijst.kindnummer, kind.naam " & _
                "FROM transferlijst, kind " & _
                "WHERE kind.kindnummer = transferlijst.kindnummer " & _
                "ORDER BY kind.naam"
            dbOpenRS(dt, cmd)
            For Each dr As DataRow In dt.Rows
                liListItem = lvBrowser.Items.Add("kind" & CStr(dr("kindnummer")), Trim(DirectCast(dr("naam"), String)), "")
            Next dr

        ElseIf (CStr(lvBrowser.Tag) = "alleen") Then
            lvBrowser.Columns.Item(1).Text = String.Empty
            cmd = New OleDb.OleDbCommand()
            cmd.CommandText = _
                "SELECT kindnummer " & _
                "FROM kind " & _
                "WHERE kindnummer NOT IN (" & _
                    "SELECT kindnummer " & _
                    "FROM transferlijst) " & _
                "AND kindnummer NOT IN (" & _
                    "SELECT kindnummer " & _
                    "FROM wachtlijst) " & _
                "AND kindnummer NOT IN (" & _
                    "SELECT kindnummer " & _
                    "FROM groepssamenstelling) " & _
                "AND deldate IS NULL " & _
                "ORDER BY naam"
            dbOpenRS(dt, cmd)

            cmd = New OleDb.OleDbCommand()
            cmd.CommandText = _
                "SELECT naam " & _
                "FROM kind " & _
                "WHERE kindnummer = ?"
            cmd.Parameters.Add("@KindNummer", OleDb.OleDbType.Integer)
            For Each dr As DataRow In dt.Rows
                cmd.Parameters("@KindNummer").Value = DirectCast(dr("kindnummer"), Integer)
                dbOpenRS(dt2, cmd)
                If (dt2.Rows.Count > 0) Then
                    liListItem = lvBrowser.Items.Add("kind" & Trim(CStr(dr("kindnummer"))), Trim(DirectCast(dt2.Rows(0)("naam"), String)), "")
                End If
            Next dr
        Else
            lvBrowser.Columns.Item(1).Text = String.Empty
            cmd = New OleDb.OleDbCommand()
            cmd.CommandText = _
                "SELECT * " & _
                "FROM groepssamenstelling " & _
                "WHERE groepnummer = " & Mid(CStr(lvBrowser.Tag), 6)
            dbOpenRS(dt, cmd)

            cmd = New OleDb.OleDbCommand()
            cmd.CommandText = _
                "SELECT naam " & _
                "FROM kind " & _
                "WHERE kindnummer = ?"
            cmd.Parameters.Add("@KindNummer", OleDb.OleDbType.Integer)
            For Each dr As DataRow In dt.Rows
                cmd.Parameters("@KindNummer").Value = CStr(dr("kindnummer"))

                dbOpenRS(dt2, cmd)
                If (dt2.Rows.Count > 0) Then
                    liListItem = lvBrowser.Items.Add("kind" & CStr(dr("kindnummer")), Trim(DirectCast(dt2.Rows(0)("naam"), String)), "")
                End If
            Next dr
        End If
        If (lvBrowser.Items.Count > iIndex) Then
            lvBrowser.Items.Item(iIndex).Selected = True
        End If
    End Sub

    Private Sub ItemClick(ByRef Item As System.Windows.Forms.ListViewItem)
        Dim iGroep As Short
        Dim iKind As Short
        Dim sSQL As String
        Dim cmd As OleDb.OleDbCommand
        Dim dr As DataRow = Nothing
        Dim dr2 As DataRow = Nothing

        If (Mid(Item.Name, 1, 5) = "groep") Then
            iGroep = CShort(Mid(Item.Name, 6))
            cmd = New OleDb.OleDbCommand
            cmd.CommandText = _
                "SELECT * " & _
                "FROM groep " & _
                "WHERE groepnummer = " & iGroep
            dbOpenRS(dr, cmd)
            cmd = New OleDb.OleDbCommand
            cmd.CommandText = _
                "SELECT COUNT(*) AS aantal " & _
                "FROM groepssamenstelling " & _
                "WHERE groepnummer = " & iGroep
            dbOpenRS(dr2, cmd)
            txtType.Text = "Groep"
            lblLine1.Text = "Nummer"
            lblLine2.Text = "Naam"
            lblLine3.Text = "# kinderen"
            lblLine4.Text = "tijd 1"
            lblLine5.Text = "tijd 2"
            lblLine6.Text = "tijd 3"
            txtLine1.Text = CStr(iGroep)
            txtLine1.Visible = True
            txtLine2.Text = DirectCast(dr("naam"), String)
            txtLine2.Visible = True
            txtLine3.Text = CStr(dr2("aantal"))
            txtLine3.Visible = True
            txtLine4.Text = EmptyStringIfNull(dr, "dagentijd1")
            txtLine4.Visible = True
            txtLine5.Text = EmptyStringIfNull(dr, "dagentijd2")
            txtLine5.Visible = True
            txtLine6.Text = EmptyStringIfNull(dr, "dagentijd3")
            txtLine6.Visible = True
            btnWijzigen.Enabled = True
            btnDelete.Enabled = True
        ElseIf (Item.Name = "wachtlijst") Then
            txtType.Text = "Wachtlijst"
            lblLine2.Text = ""
            lblLine3.Text = ""
            lblLine4.Text = ""
            lblLine5.Text = ""
            lblLine6.Text = ""
            txtLine1.Visible = True
            txtLine2.Visible = False
            txtLine3.Visible = False
            txtLine4.Visible = False
            txtLine5.Visible = False
            txtLine6.Visible = False
            lblLine1.Text = "# kinderen"
            sSQL = "SELECT COUNT(*) AS aantal FROM wachtlijst"
            dbOpenRS(dr, sSQL)
            txtLine1.Text = CStr(dr("aantal"))
            btnWijzigen.Enabled = False
            btnDelete.Enabled = False
        ElseIf (Item.Name = "transferlijst") Then
            txtType.Text = "Transferlijst"
            lblLine2.Text = ""
            lblLine3.Text = ""
            lblLine4.Text = ""
            lblLine5.Text = ""
            lblLine6.Text = ""
            txtLine1.Visible = True
            txtLine2.Visible = False
            txtLine3.Visible = False
            txtLine4.Visible = False
            txtLine5.Visible = False
            txtLine6.Visible = False
            lblLine1.Text = "# kinderen"
            sSQL = "SELECT COUNT(*) AS aantal FROM transferlijst"
            dbOpenRS(dr, sSQL)
            txtLine1.Text = CStr(dr("aantal"))
            btnWijzigen.Enabled = False
            btnDelete.Enabled = False
        ElseIf (Item.Name = "alleen") Then
            txtType.Text = "Niet Ingedeeld"
            lblLine1.Text = "# kinderen"
            lblLine2.Text = ""
            lblLine3.Text = ""
            lblLine4.Text = ""
            lblLine5.Text = ""
            lblLine6.Text = ""
            txtLine1.Visible = True
            txtLine2.Visible = False
            txtLine3.Visible = False
            txtLine4.Visible = False
            txtLine5.Visible = False
            txtLine6.Visible = False
            sSQL = _
                "SELECT COUNT(*) AS aantal " & _
                "FROM kind " & _
                "WHERE kindnummer NOT IN (" & _
                    "SELECT kindnummer " & _
                    "FROM transferlijst) " & _
                "AND kindnummer NOT IN (" & _
                    "SELECT kindnummer " & _
                    "FROM wachtlijst) " & _
                "AND kindnummer NOT IN (" & _
                    "SELECT kindnummer " & _
                    "FROM groepssamenstelling) " & _
                "AND deldate IS NULL"
            dbOpenRS(dr, sSQL)
            txtLine1.Text = CStr(dr("aantal"))
            btnWijzigen.Enabled = False
            btnDelete.Enabled = False
        Else
            btnWijzigen.Enabled = True
            btnDelete.Enabled = True
            txtType.Text = "Kind"
            lblLine1.Text = "Naam"
            lblLine2.Text = "Telefoon"
            lblLine3.Text = "Geb. Dat."
            lblLine4.Text = "Ins. Dat."
            lblLine5.Text = ""
            lblLine6.Text = ""
            txtLine1.Visible = True
            txtLine2.Visible = True
            txtLine3.Visible = True
            txtLine4.Visible = True
            txtLine5.Visible = False
            txtLine6.Visible = False
            iKind = CShort(Mid(Item.Name, 5))
            sSQL = "SELECT * FROM kind WHERE kindnummer = " & iKind
            dbOpenRS(dr, sSQL)
            txtLine1.Text = DirectCast(dr("naam"), String)
            txtLine2.Text = DirectCast(dr("telefoonnummer"), String)
            txtLine3.Text = VB6.Format(dr("geboortedatum"), "dd/mm/yyyy")
            txtLine4.Text = VB6.Format(dr("inschrijfdatum"), "dd/mm/yyyy")
            sSQL = "SELECT * FROM wachtlijst WHERE kindnummer = " & iKind
            dbOpenRS(dr, sSQL)
            If (dr IsNot Nothing) Then
                lblLine5.Text = "Opmerking"
                lblLine6.Text = "Prioriteit"
                If (dr.IsNull("opmerking")) Then
                    txtLine5.Text = String.Empty
                Else
                    txtLine5.Text = DirectCast(dr("opmerking"), String)
                End If
                txtLine5.Visible = True
                txtLine6.Text = CStr(dr("prioriteit"))
                txtLine6.Visible = True
            End If
        End If
    End Sub

    Private Sub lvBrowser_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles lvBrowser.KeyDown
        Dim KeyCode As Keys = eventArgs.KeyCode
        Dim sSQL As String
        Dim iKind As Short
        Dim iGroep As Short
        Dim mbResult As MsgBoxResult
        Dim dr As DataRow = Nothing
        Dim dr2 As DataRow = Nothing

        On Error GoTo keydown_err
        If (Keys.Delete = KeyCode) Then
            If (Mid(lvBrowser.SelectedItems(0).Name, 1, 5) = "groep") Then
                mbResult = MsgBox("Weet u zeker dat u deze groep wilt verwijderen?", MsgBoxStyle.YesNo, "Bevestiging")
                If (mbResult = MsgBoxResult.Yes) Then
                    iGroep = CShort(Mid(lvBrowser.SelectedItems(0).Name, 6))
                    sSQL = "DELETE FROM groepssamenstelling WHERE groepnummer = " & iGroep
                    dbExecSQL(sSQL)
                    sSQL = "DELETE FROM groep WHERE groepnummer = " & iGroep
                    dbExecSQL(sSQL)
                End If
            ElseIf (Mid(lvBrowser.SelectedItems(0).Name, 1, 4) = "kind") Then
                iKind = CShort(Mid(lvBrowser.SelectedItems(0).Name, 5))
                sSQL = "SELECT * FROM kind WHERE kindnummer = " & iKind
                dbOpenRS(dr, sSQL)
                If (CStr(lvBrowser.Tag) = "wachtlijst") OrElse _
                   (CStr(lvBrowser.Tag) = "transferlijst") Then
                    mbResult = MsgBox("Weet u zeker dat u '" & DirectCast(dr("naam"), String) & "' van de " & CStr(lvBrowser.Tag) & " wilt verwijderen?", MsgBoxStyle.YesNo, "Bevestiging")
                ElseIf (CStr(lvBrowser.Tag) = "alleen") Then
                    mbResult = MsgBox("Weet u zeker dat u '" & DirectCast(dr("naam"), String) & "' uit het systeem wilt verwijderen?", MsgBoxStyle.YesNo, "Bevestiging")
                Else
                    sSQL = _
                        "SELECT * " & _
                        "FROM groep " & _
                        "WHERE groepnummer = " & Mid(CStr(lvBrowser.Tag), 6)
                    dbOpenRS(dr2, sSQL)
                    mbResult = MsgBox("Weet u zeker dat u '" & DirectCast(dr("naam"), String) & "' uit de groep '" & DirectCast(dr2("naam"), String) & "' wilt verwijderen?", MsgBoxStyle.YesNo, "Bevestiging")
                End If
                If (mbResult = MsgBoxResult.Yes) Then
                    If (CStr(lvBrowser.Tag) = "wachtlijst") OrElse _
                       (CStr(lvBrowser.Tag) = "transferlijst") Then
                        sSQL = _
                            "DELETE FROM " & SQLEncode(CStr(lvBrowser.Tag)) & " " & _
                            "WHERE kindnummer = " & SQLEncode(Mid(lvBrowser.SelectedItems(0).Name, 5))
                        dbExecSQL(sSQL)
                    ElseIf (CStr(lvBrowser.Tag) = "alleen") Then
                        sSQL = _
                            "UPDATE kind " & _
                            "SET deldate = '" & SQLEncode(CStr(Today)) & "' " & _
                            "WHERE kindnummer = " & SQLEncode(Mid(lvBrowser.SelectedItems(0).Name, 5))
                        dbExecSQL(sSQL)
                    Else
                        sSQL = _
                            "DELETE FROM groepssamenstelling " & _
                            "WHERE groepnummer = " & Mid(CStr(lvBrowser.Tag), 6) & " " & _
                            "AND kindnummer = " & SQLEncode(Mid(lvBrowser.SelectedItems(0).Name, 5))
                        dbExecSQL(sSQL)
                    End If
                    lvBrowser.Items.RemoveAt(lvBrowser.SelectedItems(0).Index)
                    Call readbrowsekids()
                End If
            ElseIf (lvBrowser.SelectedItems(0).Name = "alleen") Then
                MsgBox("Het is niet mogelijk om de groep niet ingedeelde kinderen te verwijderen.", MsgBoxStyle.OkOnly, "Foutmelding")
            Else
                MsgBox("Het is niet mogelijk om de " & lvBrowser.SelectedItems(0).Name & " te verwijderen.", MsgBoxStyle.OkOnly, "Foutmelding")
            End If
        End If
        Exit Sub
keydown_err:
        MsgBox("Het kind / de groep is niet verwijderd." & vbCrLf & Err.Description)
    End Sub

    Private Sub lvGroepen_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lvGroepen.DoubleClick
        Dim sSQL As String
        Dim dt As DataTable = Nothing
        Dim bWachtlijst As Boolean
        Dim liItem As System.Windows.Forms.ListViewItem

        If (lvGroepen.SelectedItems.Count <> 1) Then Return

        Dim groep As String = CStr(lvGroepen.SelectedItems(0).Name)
        txtGroep2.Text = lvGroepen.SelectedItems(0).Text

        lvGroepen.Items.Clear()
        Select Case groep
            Case "wachtlijst"
                bWachtlijst = True
                sSQL = _
                    "SELECT k.kindnummer, k.naam, w.prioriteit " & _
                    "FROM wachtlijst w, kind k " & _
                    "WHERE k.kindnummer = w.kindnummer " & _
                    "ORDER BY w.prioriteit, k.naam"
                dbOpenRS(dt, sSQL)
            Case "transferlijst"
                sSQL = _
                    "SELECT k.kindnummer, k.naam " & _
                    "FROM transferlijst t, kind k " & _
                    "WHERE k.kindnummer = t.kindnummer " & _
                    "ORDER BY k.naam"
                dbOpenRS(dt, sSQL)
            Case Else
                sSQL = _
                    "SELECT kindnummer, naam " & _
                    "FROM kind " & _
                    "WHERE kindnummer IN (" & _
                        "SELECT kindnummer " & _
                        "FROM groepssamenstelling " & _
                        "WHERE groepnummer = " & Mid(groep, 6) & ") " & _
                    "ORDER BY naam"
                dbOpenRS(dt, sSQL)
        End Select

        lvGroepen.Tag = groep
        lvGroepen.View = System.Windows.Forms.View.Details
        If bWachtlijst Then
            lvGroepen.Columns.Item(1).Text = "Prioriteit"
        End If
        For Each dr As DataRow In dt.Rows
            liItem = lvGroepen.Items.Add("kind" & CStr(dr("kindnummer")), DirectCast(dr("naam"), String), "")
            If bWachtlijst Then
                liItem.SubItems.Add(CStr(dr("prioriteit")))
            End If
        Next

        If (lvGroepen.SelectedItems.Count > 0) Then
            ItemClick(lvGroepen.SelectedItems(0))
        Else
            lblLine1.Text = ""
            lblLine2.Text = ""
            lblLine3.Text = ""
            lblLine4.Text = ""
            lblLine5.Text = ""
            lblLine6.Text = ""
            txtLine1.Visible = False
            txtLine2.Visible = False
            txtLine3.Visible = False
            txtLine4.Visible = False
            txtLine5.Visible = False
            txtLine6.Visible = False
            btnWijzigen.Enabled = False
        End If
    End Sub

    Private Sub optCopy_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optCopy.CheckedChanged
        If DirectCast(eventSender, RadioButton).Checked Then
            Dim mbResult As MsgBoxResult

            mbResult = MsgBox("Weet u zeker dat u wilt overschakelen naar toevoeg modus?" & vbCrLf & "LET OP: Na een actie wordt de optie weer op 'verplaatsen' gezet.", MsgBoxStyle.YesNo, "Bevestiging")
            If (mbResult = MsgBoxResult.Yes) Then
                optCopy.Checked = True
            Else
                optMove.Checked = True
            End If
        End If
    End Sub

    Private Sub picUp1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picUp1.Click
        Call readGroups(lvBrowser)
        lvBrowser.Focus()
    End Sub

    Private Sub picUp2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picUp2.Click
        readGroups(lvGroepen)
    End Sub

    Private Sub lvBrowser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvBrowser.SelectedIndexChanged
        If (lvBrowser.SelectedItems.Count > 0) Then ItemClick(lvBrowser.SelectedItems(0))
    End Sub

    Private Sub lvBrowser_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvBrowser.MouseDown
        Dim lvi As ListViewItem = lvBrowser.GetItemAt(e.X, e.Y)

        If (lvBrowser.GetItemAt(e.X, e.Y) IsNot Nothing) Then
            _dragBoxFromMouseDown = New Rectangle(e.X - 5, e.Y - 5, 11, 11)
        End If
    End Sub

    Private Sub lvBrowser_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvBrowser.MouseMove
        If (lvBrowser.View <> View.LargeIcon) Then
            If (_dragBoxFromMouseDown.HasValue) Then
                If (Not _dragBoxFromMouseDown.Value.Contains(e.X, e.Y)) Then
                    lvBrowser.DoDragDrop(lvBrowser.SelectedItems, IIf(Of DragDropEffects)(optCopy.Checked, DragDropEffects.Copy, DragDropEffects.Move))
                End If
            End If
        End If
    End Sub

    Private Sub lvBrowser_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvBrowser.MouseUp
        _dragBoxFromMouseDown = Nothing
    End Sub

    Private Sub lvGroepen_DragOver(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvGroepen.DragOver
        Dim strGroup As String = DetermineDropGroup(New System.Drawing.Point(e.X, e.Y))

        e.Effect = IIf(Of DragDropEffects)(strGroup.Length > 0, e.AllowedEffect, DragDropEffects.None)
    End Sub

    Private Sub lvGroepen_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvGroepen.DragDrop
        Dim strGroup As String = DetermineDropGroup(New System.Drawing.Point(e.X, e.Y))

        If (strGroup.Length > 0) Then
            If (e.Data.GetDataPresent(GetType(ListView.SelectedListViewItemCollection))) Then
                CopyOrMoveKids( _
                    CType(e.Data.GetData(GetType(ListView.SelectedListViewItemCollection)), ListView.SelectedListViewItemCollection), _
                    strGroup)
            End If
        End If
    End Sub

    Private Function DetermineDropGroup(ByVal point As System.Drawing.Point) As String
        If (lvGroepen.View = View.LargeIcon) Then
            point = lvGroepen.PointToClient(point)
            Dim lvi As ListViewItem = lvGroepen.GetItemAt(point.X, point.Y)
            If (lvi IsNot Nothing) Then
                If (Not lvi.Selected) Then lvi.Selected = True
                Return lvi.Name
            End If
            If (lvGroepen.SelectedItems.Count > 0) Then lvGroepen.SelectedItems.Clear()
        Else
            Return CStr(lvGroepen.Tag)
        End If

        Return String.Empty
    End Function

    Private Sub CopyOrMoveKids( _
            ByVal kids As ListView.SelectedListViewItemCollection, _
            ByVal targetGroup As String)

        Dim cmd As OleDbCommand
        Dim deleteSucceeded As Boolean
        Dim insertSucceeded As Boolean
        Dim sourceGroup As String = CStr(lvBrowser.Tag)

        If (sourceGroup = targetGroup) Then
            MessageBox.Show("De bron- en doelgroep zijn hetzelfde.")
            Return
        End If

        If (optCopy.Checked) Then
            If (sourceGroup = "wachtlijst" OrElse _
                targetGroup = "wachtlijst") Then
                'Ask for permission to remove from wachtlijst
                Dim mbResult As DialogResult
                mbResult = MessageBox.Show("Kinderen kunnen niet op de wachtlijst en op een andere lijst voorkomen. Wilt u de kinderen verplaatsen in plaats van kopieren?", "Verplaatsen?", MessageBoxButtons.YesNo)
                If (mbResult = Windows.Forms.DialogResult.Yes) Then optMove.Checked = True
            End If
        End If

        Dim kidId As Integer
        For Each kid As ListViewItem In kids
            kidId = CInt(kid.Name.Substring(4))

            'Delete kid from old group if move is selected...
            If (optMove.Checked) Then
                Select Case sourceGroup
                    Case "alleen"
                        deleteSucceeded = True
                    Case "wachtlijst"
                        cmd = New OleDbCommand()
                        cmd.CommandText = _
                            "DELETE FROM wachtlijst " & _
                            "WHERE kindnummer = ?"
                        cmd.Parameters.Add("?KidId", OleDbType.Integer).Value = kidId
                        Try
                            dbExecSQL(cmd)
                            deleteSucceeded = True
                        Catch ex As Exception
                            deleteSucceeded = False
                        End Try

                    Case "transferlijst"
                        cmd = New OleDbCommand()
                        cmd.CommandText = _
                            "DELETE FROM transferlijst " & _
                            "WHERE kindnummer = ?"
                        cmd.Parameters.Add("?KidId", OleDbType.Integer).Value = kidId
                        Try
                            dbExecSQL(cmd)
                            deleteSucceeded = True
                        Catch ex As Exception
                            deleteSucceeded = False
                        End Try

                    Case Else
                        Dim group As Integer = CInt(Mid(CStr(lvBrowser.Tag), 6))

                        cmd = New OleDbCommand()
                        cmd.CommandText = _
                            "DELETE FROM groepssamenstelling " & _
                            "WHERE groepnummer = ? " & _
                            "AND kindnummer = ?"
                        cmd.Parameters.Add("?GroupId", OleDbType.Integer).Value = group
                        cmd.Parameters.Add("?KidId", OleDbType.Integer).Value = kidId
                        Try
                            dbExecSQL(cmd)
                            deleteSucceeded = True
                        Catch ex As Exception
                            deleteSucceeded = False
                        End Try

                End Select
            Else
                deleteSucceeded = True
            End If

            'Add kid to new group.
            If (deleteSucceeded) Then
                Select Case targetGroup
                    Case "wachtlijst"
                        cmd = New OleDbCommand()
                        cmd.CommandText = _
                            "INSERT INTO wachtlijst (kindnummer, prioriteit) " & _
                            "VALUES (?, 1)"
                        cmd.Parameters.Add("?KidId", OleDbType.Integer).Value = kidId
                        Try
                            dbExecSQL(cmd)
                            insertSucceeded = True
                        Catch ex As Exception
                            insertSucceeded = False
                        End Try

                    Case "transferlijst"
                        cmd = New OleDbCommand()
                        cmd.CommandText = _
                            "INSERT INTO transferlijst (kindnummer) " & _
                            "VALUES (?)"
                        cmd.Parameters.Add("?KidId", OleDbType.Integer).Value = kidId
                        Try
                            dbExecSQL(cmd)
                            insertSucceeded = True
                        Catch ex As Exception
                            insertSucceeded = False
                        End Try

                    Case Else
                        Dim group As Integer = CInt(Mid(targetGroup, 6))
                        cmd = New OleDbCommand()
                        cmd.CommandText = _
                            "INSERT INTO groepssamenstelling (kindnummer, groepnummer) " & _
                            "VALUES (?, ?)"
                        cmd.Parameters.Add("?KidId", OleDbType.Integer).Value = kidId
                        cmd.Parameters.Add("?GroupId", OleDbType.Integer).Value = group
                        Try
                            dbExecSQL(cmd)
                            insertSucceeded = True
                        Catch ex As Exception
                            insertSucceeded = False
                        End Try

                End Select
                If (Not insertSucceeded) Then
                    MessageBox.Show( _
                        String.Format( _
                            "{0} kon niet toegevoegd worden aan de doelgroep maar is al wel verwijderd uit de brongroep. Als het kind nu geen deel meer uitmaakt van een groep dan staat het kind onder 'Niet ingedeeld'.", _
                            kid.Text), "Mislukt", MessageBoxButtons.OK)
                End If
            End If
        Next kid
        RefreshKids(lvBrowser)
        RefreshKids(lvGroepen)
    End Sub

    Private Sub lvGroepen_SelectedIndexChanged( _
            ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles lvGroepen.SelectedIndexChanged
        If (lvGroepen.SelectedItems.Count = 0) Then
            lvGroepen.Tag = Nothing
            txtGroep2.Text = "Groepen"
        Else
            Dim Item As ListViewItem = lvGroepen.SelectedItems(0)

            If (Item.Name = "wachtlijst") Then
                txtGroep2.Text = "Wachtlijst"
                lvGroepen.Tag = "wachtlijst"
            ElseIf (Item.Name = "transferlijst") Then
                txtGroep2.Text = "Transferlijst"
                lvGroepen.Tag = "transferlijst"
            ElseIf (Item.Name = "alleen") Then
                txtGroep2.Text = "Niet Ingedeeld"
                lvGroepen.Tag = "alleen"
            Else
                txtGroep2.Text = Item.Text
                If (Item.Name.StartsWith("groep")) Then
                    lvGroepen.Tag = Item.Name
                End If
            End If
            ItemClick(Item)
        End If
    End Sub

    Private Sub RefreshKids( _
            ByRef lvTarget As System.Windows.Forms.ListView)
        If (CStr(lvTarget.Tag) <> "Groepen") Then
            readbrowsekids()
        End If

    End Sub
End Class