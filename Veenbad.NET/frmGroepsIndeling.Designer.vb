<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmGroepsIndeling
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		'This form is an MDI child.
		'This code simulates the VB6 
		' functionality of automatically
		' loading and showing an MDI
		' child's parent.
		Me.MDIParent = HetVeenbad.mdiMain
		HetVeenbad.mdiMain.Show
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents chkConfirm As System.Windows.Forms.CheckBox
	Public WithEvents txt10 As System.Windows.Forms.TextBox
	Public WithEvents txt9 As System.Windows.Forms.TextBox
	Public WithEvents txt8 As System.Windows.Forms.TextBox
	Public WithEvents txt7 As System.Windows.Forms.TextBox
	Public WithEvents txt6 As System.Windows.Forms.TextBox
	Public WithEvents txt5 As System.Windows.Forms.TextBox
	Public WithEvents txt4 As System.Windows.Forms.TextBox
	Public WithEvents txt3 As System.Windows.Forms.TextBox
	Public WithEvents txt2 As System.Windows.Forms.TextBox
	Public WithEvents txt1 As System.Windows.Forms.TextBox
	Public WithEvents ImageList1 As System.Windows.Forms.ImageList
	Public WithEvents tv1 As System.Windows.Forms.TreeView
	Public WithEvents lblDrag As System.Windows.Forms.Label
	Public WithEvents lbl10 As System.Windows.Forms.Label
	Public WithEvents lbl9 As System.Windows.Forms.Label
	Public WithEvents lbl8 As System.Windows.Forms.Label
	Public WithEvents lbl7 As System.Windows.Forms.Label
	Public WithEvents lbl6 As System.Windows.Forms.Label
	Public WithEvents lbl5 As System.Windows.Forms.Label
	Public WithEvents lbl4 As System.Windows.Forms.Label
	Public WithEvents lbl3 As System.Windows.Forms.Label
	Public WithEvents lbl1 As System.Windows.Forms.Label
	Public WithEvents lbl2 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGroepsIndeling))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkConfirm = New System.Windows.Forms.CheckBox
        Me.txt10 = New System.Windows.Forms.TextBox
        Me.txt9 = New System.Windows.Forms.TextBox
        Me.txt8 = New System.Windows.Forms.TextBox
        Me.txt7 = New System.Windows.Forms.TextBox
        Me.txt6 = New System.Windows.Forms.TextBox
        Me.txt5 = New System.Windows.Forms.TextBox
        Me.txt4 = New System.Windows.Forms.TextBox
        Me.txt3 = New System.Windows.Forms.TextBox
        Me.txt2 = New System.Windows.Forms.TextBox
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tv1 = New System.Windows.Forms.TreeView
        Me.lblDrag = New System.Windows.Forms.Label
        Me.lbl10 = New System.Windows.Forms.Label
        Me.lbl9 = New System.Windows.Forms.Label
        Me.lbl8 = New System.Windows.Forms.Label
        Me.lbl7 = New System.Windows.Forms.Label
        Me.lbl6 = New System.Windows.Forms.Label
        Me.lbl5 = New System.Windows.Forms.Label
        Me.lbl4 = New System.Windows.Forms.Label
        Me.lbl3 = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'chkConfirm
        '
        Me.chkConfirm.AutoSize = True
        Me.chkConfirm.BackColor = System.Drawing.SystemColors.Control
        Me.chkConfirm.Checked = True
        Me.chkConfirm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConfirm.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkConfirm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConfirm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkConfirm.Location = New System.Drawing.Point(176, 4)
        Me.chkConfirm.Name = "chkConfirm"
        Me.chkConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkConfirm.Size = New System.Drawing.Size(136, 18)
        Me.chkConfirm.TabIndex = 22
        Me.chkConfirm.Text = "Bevestiging bij slepen?"
        Me.ToolTip1.SetToolTip(Me.chkConfirm, "Als U een bevestiging wil geven voordat het kind daadwerkelijk wordt verplaatst. " & _
                "Vink deze checkbox dan aan.")
        Me.chkConfirm.UseVisualStyleBackColor = False
        '
        'txt10
        '
        Me.txt10.AcceptsReturn = True
        Me.txt10.BackColor = System.Drawing.SystemColors.Window
        Me.txt10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt10.Enabled = False
        Me.txt10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt10.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt10.Location = New System.Drawing.Point(268, 252)
        Me.txt10.MaxLength = 0
        Me.txt10.Name = "txt10"
        Me.txt10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt10.Size = New System.Drawing.Size(97, 19)
        Me.txt10.TabIndex = 20
        '
        'txt9
        '
        Me.txt9.AcceptsReturn = True
        Me.txt9.BackColor = System.Drawing.SystemColors.Window
        Me.txt9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt9.Enabled = False
        Me.txt9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt9.Location = New System.Drawing.Point(268, 228)
        Me.txt9.MaxLength = 0
        Me.txt9.Name = "txt9"
        Me.txt9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt9.Size = New System.Drawing.Size(97, 19)
        Me.txt9.TabIndex = 19
        '
        'txt8
        '
        Me.txt8.AcceptsReturn = True
        Me.txt8.BackColor = System.Drawing.SystemColors.Window
        Me.txt8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt8.Enabled = False
        Me.txt8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt8.Location = New System.Drawing.Point(268, 204)
        Me.txt8.MaxLength = 0
        Me.txt8.Name = "txt8"
        Me.txt8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt8.Size = New System.Drawing.Size(97, 19)
        Me.txt8.TabIndex = 18
        '
        'txt7
        '
        Me.txt7.AcceptsReturn = True
        Me.txt7.BackColor = System.Drawing.SystemColors.Window
        Me.txt7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt7.Enabled = False
        Me.txt7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt7.Location = New System.Drawing.Point(268, 180)
        Me.txt7.MaxLength = 0
        Me.txt7.Name = "txt7"
        Me.txt7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt7.Size = New System.Drawing.Size(97, 19)
        Me.txt7.TabIndex = 17
        '
        'txt6
        '
        Me.txt6.AcceptsReturn = True
        Me.txt6.BackColor = System.Drawing.SystemColors.Window
        Me.txt6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt6.Enabled = False
        Me.txt6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt6.Location = New System.Drawing.Point(268, 156)
        Me.txt6.MaxLength = 0
        Me.txt6.Name = "txt6"
        Me.txt6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt6.Size = New System.Drawing.Size(97, 19)
        Me.txt6.TabIndex = 12
        '
        'txt5
        '
        Me.txt5.AcceptsReturn = True
        Me.txt5.BackColor = System.Drawing.SystemColors.Window
        Me.txt5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt5.Enabled = False
        Me.txt5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt5.Location = New System.Drawing.Point(268, 132)
        Me.txt5.MaxLength = 0
        Me.txt5.Name = "txt5"
        Me.txt5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt5.Size = New System.Drawing.Size(97, 19)
        Me.txt5.TabIndex = 11
        '
        'txt4
        '
        Me.txt4.AcceptsReturn = True
        Me.txt4.BackColor = System.Drawing.SystemColors.Window
        Me.txt4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt4.Enabled = False
        Me.txt4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt4.Location = New System.Drawing.Point(268, 108)
        Me.txt4.MaxLength = 0
        Me.txt4.Name = "txt4"
        Me.txt4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt4.Size = New System.Drawing.Size(97, 19)
        Me.txt4.TabIndex = 10
        '
        'txt3
        '
        Me.txt3.AcceptsReturn = True
        Me.txt3.BackColor = System.Drawing.SystemColors.Window
        Me.txt3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt3.Enabled = False
        Me.txt3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt3.Location = New System.Drawing.Point(268, 84)
        Me.txt3.MaxLength = 0
        Me.txt3.Name = "txt3"
        Me.txt3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt3.Size = New System.Drawing.Size(97, 19)
        Me.txt3.TabIndex = 9
        '
        'txt2
        '
        Me.txt2.AcceptsReturn = True
        Me.txt2.BackColor = System.Drawing.SystemColors.Window
        Me.txt2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt2.Enabled = False
        Me.txt2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt2.Location = New System.Drawing.Point(268, 60)
        Me.txt2.MaxLength = 0
        Me.txt2.Name = "txt2"
        Me.txt2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt2.Size = New System.Drawing.Size(97, 19)
        Me.txt2.TabIndex = 8
        '
        'txt1
        '
        Me.txt1.AcceptsReturn = True
        Me.txt1.BackColor = System.Drawing.SystemColors.Window
        Me.txt1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt1.Enabled = False
        Me.txt1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt1.Location = New System.Drawing.Point(268, 36)
        Me.txt1.MaxLength = 0
        Me.txt1.Name = "txt1"
        Me.txt1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt1.Size = New System.Drawing.Size(97, 19)
        Me.txt1.TabIndex = 7
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        '
        'tv1
        '
        Me.tv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tv1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tv1.HideSelection = False
        Me.tv1.ImageIndex = 0
        Me.tv1.ImageList = Me.ImageList1
        Me.tv1.Location = New System.Drawing.Point(4, 8)
        Me.tv1.Name = "tv1"
        Me.tv1.SelectedImageIndex = 0
        Me.tv1.Size = New System.Drawing.Size(165, 337)
        Me.tv1.TabIndex = 0
        '
        'lblDrag
        '
        Me.lblDrag.BackColor = System.Drawing.SystemColors.Control
        Me.lblDrag.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDrag.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrag.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDrag.Location = New System.Drawing.Point(4, 348)
        Me.lblDrag.Name = "lblDrag"
        Me.lblDrag.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDrag.Size = New System.Drawing.Size(165, 13)
        Me.lblDrag.TabIndex = 21
        '
        'lbl10
        '
        Me.lbl10.BackColor = System.Drawing.SystemColors.Control
        Me.lbl10.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl10.Location = New System.Drawing.Point(176, 256)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl10.Size = New System.Drawing.Size(85, 17)
        Me.lbl10.TabIndex = 16
        '
        'lbl9
        '
        Me.lbl9.BackColor = System.Drawing.SystemColors.Control
        Me.lbl9.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl9.Location = New System.Drawing.Point(176, 232)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl9.Size = New System.Drawing.Size(85, 17)
        Me.lbl9.TabIndex = 15
        '
        'lbl8
        '
        Me.lbl8.BackColor = System.Drawing.SystemColors.Control
        Me.lbl8.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl8.Location = New System.Drawing.Point(176, 208)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl8.Size = New System.Drawing.Size(85, 17)
        Me.lbl8.TabIndex = 14
        '
        'lbl7
        '
        Me.lbl7.BackColor = System.Drawing.SystemColors.Control
        Me.lbl7.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl7.Location = New System.Drawing.Point(176, 184)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl7.Size = New System.Drawing.Size(85, 17)
        Me.lbl7.TabIndex = 13
        '
        'lbl6
        '
        Me.lbl6.BackColor = System.Drawing.SystemColors.Control
        Me.lbl6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl6.Location = New System.Drawing.Point(176, 160)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl6.Size = New System.Drawing.Size(85, 17)
        Me.lbl6.TabIndex = 6
        '
        'lbl5
        '
        Me.lbl5.BackColor = System.Drawing.SystemColors.Control
        Me.lbl5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl5.Location = New System.Drawing.Point(176, 136)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl5.Size = New System.Drawing.Size(85, 17)
        Me.lbl5.TabIndex = 5
        '
        'lbl4
        '
        Me.lbl4.BackColor = System.Drawing.SystemColors.Control
        Me.lbl4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl4.Location = New System.Drawing.Point(176, 112)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl4.Size = New System.Drawing.Size(85, 17)
        Me.lbl4.TabIndex = 4
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.SystemColors.Control
        Me.lbl3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl3.Location = New System.Drawing.Point(176, 88)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl3.Size = New System.Drawing.Size(85, 17)
        Me.lbl3.TabIndex = 3
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.SystemColors.Control
        Me.lbl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl1.Location = New System.Drawing.Point(176, 40)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl1.Size = New System.Drawing.Size(85, 17)
        Me.lbl1.TabIndex = 2
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.SystemColors.Control
        Me.lbl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl2.Location = New System.Drawing.Point(176, 64)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl2.Size = New System.Drawing.Size(85, 17)
        Me.lbl2.TabIndex = 1
        '
        'frmGroepsIndeling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(528, 435)
        Me.Controls.Add(Me.chkConfirm)
        Me.Controls.Add(Me.txt10)
        Me.Controls.Add(Me.txt9)
        Me.Controls.Add(Me.txt8)
        Me.Controls.Add(Me.txt7)
        Me.Controls.Add(Me.txt6)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.tv1)
        Me.Controls.Add(Me.lblDrag)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl9)
        Me.Controls.Add(Me.lbl8)
        Me.Controls.Add(Me.lbl7)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmGroepsIndeling"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Wijzigen - Groepsindeling (boomstructuur)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class