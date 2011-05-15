<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrintPresent
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
    Public WithEvents chkLeeg As System.Windows.Forms.CheckBox
	Public WithEvents optGL As System.Windows.Forms.RadioButton
	Public WithEvents optKL As System.Windows.Forms.RadioButton
	Public WithEvents frmAfdrukOpties As System.Windows.Forms.GroupBox
	Public cmdPrinterPrint As System.Windows.Forms.PrintDialog
	Public WithEvents btnClose As System.Windows.Forms.Button
	Public WithEvents btnPrint As System.Windows.Forms.Button
    Public WithEvents _lvGroepen_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvGroepen_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvGroepen As System.Windows.Forms.ListView
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintPresent))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.frmAfdrukOpties = New System.Windows.Forms.GroupBox
        Me.chkLeeg = New System.Windows.Forms.CheckBox
        Me.optGL = New System.Windows.Forms.RadioButton
        Me.optKL = New System.Windows.Forms.RadioButton
        Me.cmdPrinterPrint = New System.Windows.Forms.PrintDialog
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.lvGroepen = New System.Windows.Forms.ListView
        Me._lvGroepen_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me._lvGroepen_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtStartDat = New System.Windows.Forms.DateTimePicker
        Me.frmAfdrukOpties.SuspendLayout()
        Me.SuspendLayout()
        '
        'frmAfdrukOpties
        '
        Me.frmAfdrukOpties.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmAfdrukOpties.BackColor = System.Drawing.SystemColors.Control
        Me.frmAfdrukOpties.Controls.Add(Me.chkLeeg)
        Me.frmAfdrukOpties.Controls.Add(Me.optGL)
        Me.frmAfdrukOpties.Controls.Add(Me.optKL)
        Me.frmAfdrukOpties.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmAfdrukOpties.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmAfdrukOpties.Location = New System.Drawing.Point(144, 64)
        Me.frmAfdrukOpties.Name = "frmAfdrukOpties"
        Me.frmAfdrukOpties.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmAfdrukOpties.Size = New System.Drawing.Size(125, 77)
        Me.frmAfdrukOpties.TabIndex = 4
        Me.frmAfdrukOpties.TabStop = False
        Me.frmAfdrukOpties.Text = "Lijst"
        '
        'chkLeeg
        '
        Me.chkLeeg.AutoSize = True
        Me.chkLeeg.BackColor = System.Drawing.SystemColors.Control
        Me.chkLeeg.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkLeeg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLeeg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkLeeg.Location = New System.Drawing.Point(8, 52)
        Me.chkLeeg.Name = "chkLeeg"
        Me.chkLeeg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkLeeg.Size = New System.Drawing.Size(68, 18)
        Me.chkLeeg.TabIndex = 7
        Me.chkLeeg.Text = "&Lege lijst"
        Me.chkLeeg.UseVisualStyleBackColor = False
        '
        'optGL
        '
        Me.optGL.AutoSize = True
        Me.optGL.BackColor = System.Drawing.SystemColors.Control
        Me.optGL.Cursor = System.Windows.Forms.Cursors.Default
        Me.optGL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optGL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optGL.Location = New System.Drawing.Point(8, 32)
        Me.optGL.Name = "optGL"
        Me.optGL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optGL.Size = New System.Drawing.Size(70, 18)
        Me.optGL.TabIndex = 6
        Me.optGL.TabStop = True
        Me.optGL.Text = "&Grote lijst"
        Me.optGL.UseVisualStyleBackColor = False
        '
        'optKL
        '
        Me.optKL.AutoSize = True
        Me.optKL.BackColor = System.Drawing.SystemColors.Control
        Me.optKL.Checked = True
        Me.optKL.Cursor = System.Windows.Forms.Cursors.Default
        Me.optKL.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optKL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optKL.Location = New System.Drawing.Point(8, 16)
        Me.optKL.Name = "optKL"
        Me.optKL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optKL.Size = New System.Drawing.Size(72, 18)
        Me.optKL.TabIndex = 5
        Me.optKL.TabStop = True
        Me.optKL.Text = "&Kleine lijst"
        Me.optKL.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(176, 184)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClose.Size = New System.Drawing.Size(93, 29)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Af&sluiten"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPrint.Location = New System.Drawing.Point(176, 149)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPrint.Size = New System.Drawing.Size(93, 29)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "&Afdrukken"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lvGroepen
        '
        Me.lvGroepen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvGroepen.BackColor = System.Drawing.SystemColors.Window
        Me.lvGroepen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvGroepen_ColumnHeader_1, Me._lvGroepen_ColumnHeader_2})
        Me.lvGroepen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvGroepen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvGroepen.FullRowSelect = True
        Me.lvGroepen.HideSelection = False
        Me.lvGroepen.LabelEdit = True
        Me.lvGroepen.Location = New System.Drawing.Point(12, 8)
        Me.lvGroepen.Name = "lvGroepen"
        Me.lvGroepen.Size = New System.Drawing.Size(125, 205)
        Me.lvGroepen.TabIndex = 0
        Me.lvGroepen.UseCompatibleStateImageBehavior = False
        Me.lvGroepen.View = System.Windows.Forms.View.Details
        '
        '_lvGroepen_ColumnHeader_1
        '
        Me._lvGroepen_ColumnHeader_1.Text = "Naam"
        Me._lvGroepen_ColumnHeader_1.Width = 189
        '
        '_lvGroepen_ColumnHeader_2
        '
        Me._lvGroepen_ColumnHeader_2.Text = "Nummer"
        Me._lvGroepen_ColumnHeader_2.Width = 59
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Startdatum"
        '
        'txtStartDat
        '
        Me.txtStartDat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStartDat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtStartDat.Location = New System.Drawing.Point(144, 26)
        Me.txtStartDat.Name = "txtStartDat"
        Me.txtStartDat.Size = New System.Drawing.Size(125, 20)
        Me.txtStartDat.TabIndex = 6
        '
        'frmPrintPresent
        '
        Me.AcceptButton = Me.btnPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(276, 225)
        Me.Controls.Add(Me.txtStartDat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.frmAfdrukOpties)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lvGroepen)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(282, 257)
        Me.Name = "frmPrintPresent"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Afdrukken - Presentielijst"
        Me.frmAfdrukOpties.ResumeLayout(False)
        Me.frmAfdrukOpties.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStartDat As System.Windows.Forms.DateTimePicker
#End Region 
End Class