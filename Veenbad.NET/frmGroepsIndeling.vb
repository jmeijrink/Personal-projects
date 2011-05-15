Option Strict On
Option Explicit On
Friend Class frmGroepsIndeling
	Inherits System.Windows.Forms.Form
	Dim sDragSource As String
	
	Private Sub frmGroepsIndeling_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim cmd As OleDb.OleDbCommand
        Dim dt As DataTable = Nothing
        Dim dt2 As DataTable = Nothing
		Dim liItem As System.Windows.Forms.TreeNode
		Dim sGroepKey As String
		
        'Wachtlijst
        liItem = tv1.Nodes.Add("wachtlijst", "Wachtlijst")
        'TODO:Find out how expandedImage can be replaced...
        'liItem.ExpandedImage = 5
		liItem.ImageIndex = 4
        tv1.SelectedNode = liItem

        cmd = New OleDb.OleDbCommand()
        cmd.CommandText = _
            "SELECT k.kindnummer, k.naam " & _
            "FROM kind k, wachtlijst w " & _
            "WHERE k.kindnummer = w.kindnummer " & _
            "ORDER BY w.prioriteit, k.naam"
        dbOpenRS(dt, cmd)
        For Each dr As DataRow In dt.Rows
            liItem = _
                tv1.Nodes.Find("wachtlijst", True)(0).Nodes.Add("kind" & CStr(dr("kindnummer")), DirectCast(dr("naam"), String))
            liItem.ImageIndex = 3
        Next dr

        'Transferlijst
        liItem = tv1.Nodes.Add("transferlijst", "Transferlijst")
        'TODO:Find out how expandedImage can be replaced...
        'liItem.ExpandedImage = 7
        liItem.ImageIndex = 6
        cmd = New OleDb.OleDbCommand()
        cmd.CommandText = _
            "SELECT k.kindnummer, k.naam " & _
            "FROM kind k, transferlijst t " & _
            "WHERE k.kindnummer = t.kindnummer " & _
            "ORDER BY k.naam"
        dbOpenRS(dt, cmd)
        For Each dr As DataRow In dt.Rows
            liItem = tv1.Nodes.Find("transferlijst", True)(0).Nodes.Add("kind" & CStr(dr("kindnummer")), DirectCast(dr("naam"), String))
            liItem.ImageIndex = 3
        Next dr

        'Groepen
        cmd = New OleDb.OleDbCommand()
        cmd.CommandText = _
            "SELECT groepnummer, naam " & _
            "FROM groep " & _
            "ORDER BY naam"
        dbOpenRS(dt, cmd)
        For Each dr As DataRow In dt.Rows
            sGroepKey = "groep" & CStr(dr("groepnummer"))
            liItem = tv1.Nodes.Add(sGroepKey, DirectCast(dr("naam"), String))
            'UPGRADE_ISSUE: MSComctlLib.Node property liItem.ExpandedImage was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'liItem.ExpandedImage = 9
            liItem.ImageIndex = 8

            cmd = New OleDb.OleDbCommand()
            cmd.CommandText = _
                "SELECT kindnummer, naam " & _
                "FROM kind " & _
                "WHERE kindnummer IN (" & _
                    "SELECT kindnummer " & _
                    "FROM groepssamenstelling " & _
                    "WHERE groepnummer = ?) " & _
                "ORDER BY naam"
            cmd.Parameters.Add("@GroepNummer", OleDb.OleDbType.Integer).Value = DirectCast(dr("groepnummer"), Integer)
            dbOpenRS(dt2, cmd)
            For Each dr2 As DataRow In dt2.Rows
                liItem = tv1.Nodes.Find(sGroepKey, True)(0).Nodes.Add("kind" & CStr(dr2("kindnummer")), DirectCast(dr2("naam"), String))
                liItem.ImageIndex = 3
            Next dr2
        Next dr
        Call readItemInfo()
        mdiMain.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
	
	Private Sub readItemInfo()
		Dim sSelectedKey As String
        Dim cmd As OleDb.OleDbCommand
        Dim dt As DataTable = Nothing
        Dim dr As DataRow
		Dim lAantal As Integer
		
		sSelectedKey = tv1.SelectedNode.Name
		If ((sSelectedKey = "wachtlijst") Or (sSelectedKey = "transferlijst")) Then
            Call ClearLBLTXT()
            cmd = New OleDb.OleDbCommand()
            cmd.CommandText = _
                "SELECT COUNT(*) AS aantal " & _
                "FROM " & sSelectedKey
            dbOpenRS(dt, cmd)
            dr = dt.Rows(0)
			lbl1.Text = "Type"
			lbl2.Text = "# kinderen"
			txt1.Text = UCase(Mid(sSelectedKey, 1, 1)) & Mid(sSelectedKey, 2)
			'UPGRADE_WARNING: Couldn't resolve default property of object oRS.Fields. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            txt2.Text = CStr(dr("aantal"))
			txt1.Visible = True
            txt2.Visible = True

		ElseIf (Mid(sSelectedKey, 1, 4) = "kind") Then 
			Call ClearLBLTXT()
            cmd = New OleDb.OleDbCommand()
            cmd.CommandText = _
                "SELECT * " & _
                "FROM kind " & _
                "WHERE kindnummer = " & Mid(sSelectedKey, 5)
            dbOpenRS(dt, cmd)
            dr = dt.Rows(0)
            lbl1.Text = "Type"
			lbl2.Text = "Nummer"
			lbl3.Text = "Naam"
			lbl4.Text = "Geb. Dat."
			lbl5.Text = "Tel. Nr."
			lbl6.Text = "Ins. Dat."
			lbl7.Text = "Opmerking"
			txt1.Text = "Kind"
            txt2.Text = CStr(dr("kindnummer"))
            txt3.Text = DirectCast(dr("naam"), String)
            txt4.Text = CStr(dr("geboortedatum"))
            txt5.Text = DirectCast(dr("telefoonnummer"), String)
            txt6.Text = CStr("inschrijfdatum")
            If (dr.IsNull("opmerking")) Then
                txt7.Text = String.Empty
            Else
                txt7.Text = DirectCast(dr("opmerking"), String)
            End If
            txt1.Visible = True
            txt2.Visible = True
            txt3.Visible = True
            txt4.Visible = True
            txt5.Visible = True
            txt6.Visible = True
            txt7.Visible = True

            ElseIf (Mid(sSelectedKey, 1, 5) = "groep") Then
                Call ClearLBLTXT()
                cmd = New OleDb.OleDbCommand()
                cmd.CommandText = _
                    "SELECT COUNT(*) AS aantal " & _
                    "FROM groepssamenstelling " & _
                    "WHERE groepnummer = " & Mid(sSelectedKey, 6)
                dbOpenRS(dt, cmd)
                dr = dt.Rows(0)
                lAantal = DirectCast(dr("aantal"), Integer)

                cmd = New OleDb.OleDbCommand()
                cmd.CommandText = _
                    "SELECT * " & _
                    "FROM groep " & _
                    "WHERE groepnummer = " & Mid(sSelectedKey, 6)
                dbOpenRS(dt, cmd)
                dr = dt.Rows(0)
                lbl1.Text = "Type"
                lbl2.Text = "Nummer"
                lbl3.Text = "Naam"
                lbl4.Text = "# kinderen"
                lbl5.Text = "Diploma's"
                lbl6.Text = "Dag en tijd 1"
                lbl7.Text = "Dag en tijd 2"
                lbl8.Text = "Dag en tijd 3"
                lbl9.Text = "Dag en tijd 4"
                txt1.Text = "Groep"
                txt2.Text = CStr(dr("groepnummer"))
                txt3.Text = DirectCast(dr("naam"), String)
                txt4.Text = CStr(lAantal)
                txt5.Text = UCase(DirectCast(dr("doeldiploma"), String))
                txt6.Text = DirectCast(dr("dagentijd1"), String)
                If (dr.IsNull("dagentijd2")) Then
                    txt7.Text = String.Empty
                Else
                    txt7.Text = DirectCast(dr("dagentijd2"), String)
                End If
                If (dr.IsNull("dagentijd3")) Then
                    txt8.Text = String.Empty
                Else
                    txt8.Text = DirectCast(dr("dagentijd3"), String)
                End If
                If (dr.IsNull("dagentijd4")) Then
                    txt9.Text = String.Empty
                Else
                    txt9.Text = DirectCast(dr("dagentijd4"), String)
                End If
                txt1.Visible = True
                txt2.Visible = True
                txt3.Visible = True
                txt4.Visible = True
                txt5.Visible = True
                txt6.Visible = True
                txt7.Visible = True
                txt8.Visible = True
                txt9.Visible = True
            End If
	End Sub
	
	Private Sub ClearLBLTXT()
		lbl1.Text = ""
		lbl2.Text = ""
		lbl3.Text = ""
		lbl4.Text = ""
		lbl5.Text = ""
		lbl6.Text = ""
		lbl7.Text = ""
		lbl8.Text = ""
		lbl9.Text = ""
		lbl10.Text = ""
		txt1.Visible = False
		txt2.Visible = False
		txt3.Visible = False
		txt4.Visible = False
		txt5.Visible = False
		txt6.Visible = False
		txt7.Visible = False
		txt8.Visible = False
		txt9.Visible = False
		txt10.Visible = False
	End Sub
	
	Private Sub tv1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tv1.Click
		Call readItemInfo()
	End Sub
	
    Private Sub tv1_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles tv1.MouseDown
        Dim x As Integer = eventArgs.X
        Dim y As Integer = eventArgs.Y
        Dim liItem As System.Windows.Forms.TreeNode

        On Error Resume Next
        liItem = tv1.GetNodeAt(x, y)
        tv1.SelectedNode = liItem
        sDragSource = liItem.Name
    End Sub
	
    'TODO: Re-implement drag & drop (including multiple children at once).
    'UPGRADE_ISSUE: MSComctlLib.TreeView event tv1.OLEDragDrop was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
    'Private Sub tv1_OLEDragDrop(ByRef Data As mscomctl.DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single)
    '	Dim liItem As System.Windows.Forms.TreeNode
    '	Dim mbResult As MsgBoxResult

    '	lblDrag.Text = ""
    '	mbResult = MsgBoxResult.Yes
    '	liItem = tv1.SelectedNode
    '	If (liItem.Name = "wachtlijst") Then
    '		If (chkConfirm.CheckState = 1) Then
    '			mbResult = MsgBox("Weet u zeker dat u '" & tv1.Nodes.Item(sDragSource).Text & "' naar de wachtlijst wilt verplaatsen.", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Bevestiging")
    '			If (mbResult = MsgBoxResult.No) Then
    '				Exit Sub
    '			End If
    '		End If
    '		If (mbResult = MsgBoxResult.Yes) Then
    '			MsgBox(liItem.Text)
    '		End If
    '	ElseIf (liItem.Name = "transferlijst") Then 
    '		MsgBox(liItem.Text)
    '	ElseIf (Mid(liItem.Name, 1, 5) = "groep") Then 
    '		MsgBox(liItem.Text)
    '	End If
    'End Sub

    ''UPGRADE_ISSUE: MSComctlLib.TreeView event tv1.OLEDragOver was not upgraded. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
    'Private Sub tv1_OLEDragOver(ByRef Data As mscomctl.DataObject, ByRef Effect As Integer, ByRef Button As Short, ByRef Shift As Short, ByRef x As Single, ByRef y As Single, ByRef State As Short)
    '	Dim liItem As System.Windows.Forms.TreeNode

    '	liItem = tv1.GetNodeAt(x, y)
    '	If Not liItem Is Nothing Then
    '		If (Mid(liItem.Name, 1, 4) <> "kind") Then
    '               tv1.SelectedNode = liItem
    '               lblDrag.Text = tv1.Nodes.Item(sDragSource).Text & " -> " & liItem.Text
    '		End If
    '	End If
    'End Sub
End Class