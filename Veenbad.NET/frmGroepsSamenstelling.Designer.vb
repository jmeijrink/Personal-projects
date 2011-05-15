<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmGroepsSamenstelling
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
	Public WithEvents picUp1 As System.Windows.Forms.PictureBox
	Public WithEvents picUp2 As System.Windows.Forms.PictureBox
	Public WithEvents txtGroep2 As System.Windows.Forms.TextBox
	Public WithEvents btnClose As System.Windows.Forms.Button
	Public WithEvents btnDelete As System.Windows.Forms.Button
	Public WithEvents txtLine6 As System.Windows.Forms.TextBox
	Public WithEvents btnWijzigen As System.Windows.Forms.Button
	Public WithEvents txtLine5 As System.Windows.Forms.TextBox
	Public WithEvents txtLine4 As System.Windows.Forms.TextBox
	Public WithEvents txtLine3 As System.Windows.Forms.TextBox
	Public WithEvents txtLine2 As System.Windows.Forms.TextBox
	Public WithEvents txtLine1 As System.Windows.Forms.TextBox
	Public WithEvents txtType As System.Windows.Forms.TextBox
	Public WithEvents lblLine6 As System.Windows.Forms.Label
	Public WithEvents lblLine5 As System.Windows.Forms.Label
	Public WithEvents lblLine4 As System.Windows.Forms.Label
	Public WithEvents lblLine3 As System.Windows.Forms.Label
	Public WithEvents lblLine2 As System.Windows.Forms.Label
	Public WithEvents lblLine1 As System.Windows.Forms.Label
	Public WithEvents lblType As System.Windows.Forms.Label
	Public WithEvents frmInfo As System.Windows.Forms.GroupBox
	Public WithEvents txtGroep As System.Windows.Forms.TextBox
	Public WithEvents optCopy As System.Windows.Forms.RadioButton
	Public WithEvents optMove As System.Windows.Forms.RadioButton
	Public WithEvents frmCopyKind As System.Windows.Forms.GroupBox
	Public WithEvents _lvGroepen_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvGroepen_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvGroepen As System.Windows.Forms.ListView
	Public WithEvents ilImages As System.Windows.Forms.ImageList
	Public WithEvents _lvBrowser_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
    Public WithEvents prioriteit As System.Windows.Forms.ColumnHeader
    Public WithEvents lvBrowser As System.Windows.Forms.ListView
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGroepsSamenstelling))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picUp1 = New System.Windows.Forms.PictureBox
        Me.picUp2 = New System.Windows.Forms.PictureBox
        Me.txtGroep2 = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.frmInfo = New System.Windows.Forms.GroupBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.txtLine6 = New System.Windows.Forms.TextBox
        Me.btnWijzigen = New System.Windows.Forms.Button
        Me.txtLine5 = New System.Windows.Forms.TextBox
        Me.txtLine4 = New System.Windows.Forms.TextBox
        Me.txtLine3 = New System.Windows.Forms.TextBox
        Me.txtLine2 = New System.Windows.Forms.TextBox
        Me.txtLine1 = New System.Windows.Forms.TextBox
        Me.txtType = New System.Windows.Forms.TextBox
        Me.lblLine6 = New System.Windows.Forms.Label
        Me.lblLine5 = New System.Windows.Forms.Label
        Me.lblLine4 = New System.Windows.Forms.Label
        Me.lblLine3 = New System.Windows.Forms.Label
        Me.lblLine2 = New System.Windows.Forms.Label
        Me.lblLine1 = New System.Windows.Forms.Label
        Me.lblType = New System.Windows.Forms.Label
        Me.txtGroep = New System.Windows.Forms.TextBox
        Me.frmCopyKind = New System.Windows.Forms.GroupBox
        Me.optCopy = New System.Windows.Forms.RadioButton
        Me.optMove = New System.Windows.Forms.RadioButton
        Me.lvGroepen = New System.Windows.Forms.ListView
        Me._lvGroepen_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me._lvGroepen_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
        Me.ilImages = New System.Windows.Forms.ImageList(Me.components)
        Me.lvBrowser = New System.Windows.Forms.ListView
        Me._lvBrowser_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me.prioriteit = New System.Windows.Forms.ColumnHeader
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblPos = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        CType(Me.picUp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUp2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmInfo.SuspendLayout()
        Me.frmCopyKind.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'picUp1
        '
        Me.picUp1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picUp1.BackColor = System.Drawing.SystemColors.Control
        Me.picUp1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picUp1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picUp1.Image = CType(resources.GetObject("picUp1.Image"), System.Drawing.Image)
        Me.picUp1.Location = New System.Drawing.Point(218, 5)
        Me.picUp1.Name = "picUp1"
        Me.picUp1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picUp1.Size = New System.Drawing.Size(20, 21)
        Me.picUp1.TabIndex = 25
        Me.picUp1.TabStop = False
        '
        'picUp2
        '
        Me.picUp2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picUp2.BackColor = System.Drawing.SystemColors.Control
        Me.picUp2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picUp2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picUp2.Image = CType(resources.GetObject("picUp2.Image"), System.Drawing.Image)
        Me.picUp2.Location = New System.Drawing.Point(218, 3)
        Me.picUp2.Name = "picUp2"
        Me.picUp2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picUp2.Size = New System.Drawing.Size(20, 21)
        Me.picUp2.TabIndex = 24
        Me.picUp2.TabStop = False
        '
        'txtGroep2
        '
        Me.txtGroep2.AcceptsReturn = True
        Me.txtGroep2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGroep2.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroep2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroep2.Enabled = False
        Me.txtGroep2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroep2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroep2.Location = New System.Drawing.Point(3, 3)
        Me.txtGroep2.MaxLength = 0
        Me.txtGroep2.Name = "txtGroep2"
        Me.txtGroep2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroep2.Size = New System.Drawing.Size(211, 20)
        Me.txtGroep2.TabIndex = 23
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(608, 388)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClose.Size = New System.Drawing.Size(89, 25)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Af&sluiten"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmInfo
        '
        Me.frmInfo.BackColor = System.Drawing.SystemColors.Control
        Me.frmInfo.Controls.Add(Me.btnDelete)
        Me.frmInfo.Controls.Add(Me.txtLine6)
        Me.frmInfo.Controls.Add(Me.btnWijzigen)
        Me.frmInfo.Controls.Add(Me.txtLine5)
        Me.frmInfo.Controls.Add(Me.txtLine4)
        Me.frmInfo.Controls.Add(Me.txtLine3)
        Me.frmInfo.Controls.Add(Me.txtLine2)
        Me.frmInfo.Controls.Add(Me.txtLine1)
        Me.frmInfo.Controls.Add(Me.txtType)
        Me.frmInfo.Controls.Add(Me.lblLine6)
        Me.frmInfo.Controls.Add(Me.lblLine5)
        Me.frmInfo.Controls.Add(Me.lblLine4)
        Me.frmInfo.Controls.Add(Me.lblLine3)
        Me.frmInfo.Controls.Add(Me.lblLine2)
        Me.frmInfo.Controls.Add(Me.lblLine1)
        Me.frmInfo.Controls.Add(Me.lblType)
        Me.frmInfo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmInfo.Location = New System.Drawing.Point(3, 67)
        Me.frmInfo.Name = "frmInfo"
        Me.frmInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmInfo.Size = New System.Drawing.Size(181, 269)
        Me.frmInfo.TabIndex = 6
        Me.frmInfo.TabStop = False
        Me.frmInfo.Text = "Informatie"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelete.Location = New System.Drawing.Point(72, 240)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDelete.Size = New System.Drawing.Size(97, 21)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "Verwijderen"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtLine6
        '
        Me.txtLine6.AcceptsReturn = True
        Me.txtLine6.BackColor = System.Drawing.SystemColors.Window
        Me.txtLine6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLine6.Enabled = False
        Me.txtLine6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLine6.Location = New System.Drawing.Point(72, 184)
        Me.txtLine6.MaxLength = 0
        Me.txtLine6.Name = "txtLine6"
        Me.txtLine6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLine6.Size = New System.Drawing.Size(97, 20)
        Me.txtLine6.TabIndex = 21
        Me.txtLine6.Visible = False
        '
        'btnWijzigen
        '
        Me.btnWijzigen.BackColor = System.Drawing.SystemColors.Control
        Me.btnWijzigen.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnWijzigen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWijzigen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnWijzigen.Location = New System.Drawing.Point(72, 212)
        Me.btnWijzigen.Name = "btnWijzigen"
        Me.btnWijzigen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnWijzigen.Size = New System.Drawing.Size(97, 21)
        Me.btnWijzigen.TabIndex = 19
        Me.btnWijzigen.Text = "&Wijzigen"
        Me.btnWijzigen.UseVisualStyleBackColor = False
        '
        'txtLine5
        '
        Me.txtLine5.AcceptsReturn = True
        Me.txtLine5.BackColor = System.Drawing.SystemColors.Window
        Me.txtLine5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLine5.Enabled = False
        Me.txtLine5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLine5.Location = New System.Drawing.Point(72, 156)
        Me.txtLine5.MaxLength = 0
        Me.txtLine5.Name = "txtLine5"
        Me.txtLine5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLine5.Size = New System.Drawing.Size(97, 20)
        Me.txtLine5.TabIndex = 18
        Me.txtLine5.Visible = False
        '
        'txtLine4
        '
        Me.txtLine4.AcceptsReturn = True
        Me.txtLine4.BackColor = System.Drawing.SystemColors.Window
        Me.txtLine4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLine4.Enabled = False
        Me.txtLine4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLine4.Location = New System.Drawing.Point(72, 128)
        Me.txtLine4.MaxLength = 0
        Me.txtLine4.Name = "txtLine4"
        Me.txtLine4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLine4.Size = New System.Drawing.Size(97, 20)
        Me.txtLine4.TabIndex = 16
        Me.txtLine4.Visible = False
        '
        'txtLine3
        '
        Me.txtLine3.AcceptsReturn = True
        Me.txtLine3.BackColor = System.Drawing.SystemColors.Window
        Me.txtLine3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLine3.Enabled = False
        Me.txtLine3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLine3.Location = New System.Drawing.Point(72, 100)
        Me.txtLine3.MaxLength = 0
        Me.txtLine3.Name = "txtLine3"
        Me.txtLine3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLine3.Size = New System.Drawing.Size(97, 20)
        Me.txtLine3.TabIndex = 14
        Me.txtLine3.Visible = False
        '
        'txtLine2
        '
        Me.txtLine2.AcceptsReturn = True
        Me.txtLine2.BackColor = System.Drawing.SystemColors.Window
        Me.txtLine2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLine2.Enabled = False
        Me.txtLine2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLine2.Location = New System.Drawing.Point(72, 72)
        Me.txtLine2.MaxLength = 0
        Me.txtLine2.Name = "txtLine2"
        Me.txtLine2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLine2.Size = New System.Drawing.Size(97, 20)
        Me.txtLine2.TabIndex = 12
        Me.txtLine2.Visible = False
        '
        'txtLine1
        '
        Me.txtLine1.AcceptsReturn = True
        Me.txtLine1.BackColor = System.Drawing.SystemColors.Window
        Me.txtLine1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLine1.Enabled = False
        Me.txtLine1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLine1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLine1.Location = New System.Drawing.Point(72, 44)
        Me.txtLine1.MaxLength = 0
        Me.txtLine1.Name = "txtLine1"
        Me.txtLine1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLine1.Size = New System.Drawing.Size(97, 20)
        Me.txtLine1.TabIndex = 10
        '
        'txtType
        '
        Me.txtType.AcceptsReturn = True
        Me.txtType.BackColor = System.Drawing.SystemColors.Window
        Me.txtType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtType.Enabled = False
        Me.txtType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtType.Location = New System.Drawing.Point(72, 16)
        Me.txtType.MaxLength = 0
        Me.txtType.Name = "txtType"
        Me.txtType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtType.Size = New System.Drawing.Size(97, 20)
        Me.txtType.TabIndex = 8
        '
        'lblLine6
        '
        Me.lblLine6.BackColor = System.Drawing.SystemColors.Control
        Me.lblLine6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLine6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLine6.Location = New System.Drawing.Point(8, 188)
        Me.lblLine6.Name = "lblLine6"
        Me.lblLine6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLine6.Size = New System.Drawing.Size(41, 17)
        Me.lblLine6.TabIndex = 20
        '
        'lblLine5
        '
        Me.lblLine5.BackColor = System.Drawing.SystemColors.Control
        Me.lblLine5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLine5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLine5.Location = New System.Drawing.Point(8, 160)
        Me.lblLine5.Name = "lblLine5"
        Me.lblLine5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLine5.Size = New System.Drawing.Size(65, 21)
        Me.lblLine5.TabIndex = 17
        '
        'lblLine4
        '
        Me.lblLine4.BackColor = System.Drawing.SystemColors.Control
        Me.lblLine4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLine4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLine4.Location = New System.Drawing.Point(8, 132)
        Me.lblLine4.Name = "lblLine4"
        Me.lblLine4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLine4.Size = New System.Drawing.Size(65, 21)
        Me.lblLine4.TabIndex = 15
        '
        'lblLine3
        '
        Me.lblLine3.BackColor = System.Drawing.SystemColors.Control
        Me.lblLine3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLine3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLine3.Location = New System.Drawing.Point(8, 104)
        Me.lblLine3.Name = "lblLine3"
        Me.lblLine3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLine3.Size = New System.Drawing.Size(65, 21)
        Me.lblLine3.TabIndex = 13
        '
        'lblLine2
        '
        Me.lblLine2.BackColor = System.Drawing.SystemColors.Control
        Me.lblLine2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLine2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLine2.Location = New System.Drawing.Point(8, 76)
        Me.lblLine2.Name = "lblLine2"
        Me.lblLine2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLine2.Size = New System.Drawing.Size(61, 21)
        Me.lblLine2.TabIndex = 11
        '
        'lblLine1
        '
        Me.lblLine1.BackColor = System.Drawing.SystemColors.Control
        Me.lblLine1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLine1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLine1.Location = New System.Drawing.Point(8, 48)
        Me.lblLine1.Name = "lblLine1"
        Me.lblLine1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLine1.Size = New System.Drawing.Size(61, 17)
        Me.lblLine1.TabIndex = 9
        '
        'lblType
        '
        Me.lblType.BackColor = System.Drawing.SystemColors.Control
        Me.lblType.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblType.Location = New System.Drawing.Point(8, 20)
        Me.lblType.Name = "lblType"
        Me.lblType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblType.Size = New System.Drawing.Size(49, 17)
        Me.lblType.TabIndex = 7
        Me.lblType.Text = "Type"
        '
        'txtGroep
        '
        Me.txtGroep.AcceptsReturn = True
        Me.txtGroep.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGroep.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroep.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGroep.Enabled = False
        Me.txtGroep.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroep.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGroep.Location = New System.Drawing.Point(3, 5)
        Me.txtGroep.MaxLength = 0
        Me.txtGroep.Name = "txtGroep"
        Me.txtGroep.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroep.Size = New System.Drawing.Size(209, 20)
        Me.txtGroep.TabIndex = 5
        '
        'frmCopyKind
        '
        Me.frmCopyKind.BackColor = System.Drawing.SystemColors.Control
        Me.frmCopyKind.Controls.Add(Me.optCopy)
        Me.frmCopyKind.Controls.Add(Me.optMove)
        Me.frmCopyKind.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmCopyKind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmCopyKind.Location = New System.Drawing.Point(3, 4)
        Me.frmCopyKind.Name = "frmCopyKind"
        Me.frmCopyKind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmCopyKind.Size = New System.Drawing.Size(181, 57)
        Me.frmCopyKind.TabIndex = 2
        Me.frmCopyKind.TabStop = False
        Me.frmCopyKind.Text = "Sleep Wijze"
        '
        'optCopy
        '
        Me.optCopy.BackColor = System.Drawing.SystemColors.Control
        Me.optCopy.Cursor = System.Windows.Forms.Cursors.Default
        Me.optCopy.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optCopy.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optCopy.Location = New System.Drawing.Point(12, 32)
        Me.optCopy.Name = "optCopy"
        Me.optCopy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optCopy.Size = New System.Drawing.Size(149, 17)
        Me.optCopy.TabIndex = 4
        Me.optCopy.TabStop = True
        Me.optCopy.Text = "&Toevoegen"
        Me.optCopy.UseVisualStyleBackColor = False
        '
        'optMove
        '
        Me.optMove.BackColor = System.Drawing.SystemColors.Control
        Me.optMove.Checked = True
        Me.optMove.Cursor = System.Windows.Forms.Cursors.Default
        Me.optMove.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMove.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMove.Location = New System.Drawing.Point(12, 16)
        Me.optMove.Name = "optMove"
        Me.optMove.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optMove.Size = New System.Drawing.Size(157, 17)
        Me.optMove.TabIndex = 3
        Me.optMove.TabStop = True
        Me.optMove.Text = "&Verplaatsen"
        Me.optMove.UseVisualStyleBackColor = False
        '
        'lvGroepen
        '
        Me.lvGroepen.AllowDrop = True
        Me.lvGroepen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvGroepen.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lvGroepen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvGroepen_ColumnHeader_1, Me._lvGroepen_ColumnHeader_2})
        Me.lvGroepen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvGroepen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvGroepen.HideSelection = False
        Me.lvGroepen.LargeImageList = Me.ilImages
        Me.lvGroepen.Location = New System.Drawing.Point(3, 27)
        Me.lvGroepen.MultiSelect = False
        Me.lvGroepen.Name = "lvGroepen"
        Me.lvGroepen.Size = New System.Drawing.Size(234, 342)
        Me.lvGroepen.TabIndex = 1
        Me.lvGroepen.UseCompatibleStateImageBehavior = False
        '
        '_lvGroepen_ColumnHeader_1
        '
        Me._lvGroepen_ColumnHeader_1.Text = "Naam"
        Me._lvGroepen_ColumnHeader_1.Width = 236
        '
        '_lvGroepen_ColumnHeader_2
        '
        Me._lvGroepen_ColumnHeader_2.Text = "Prioriteit"
        Me._lvGroepen_ColumnHeader_2.Width = 95
        '
        'ilImages
        '
        Me.ilImages.ImageStream = CType(resources.GetObject("ilImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilImages.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ilImages.Images.SetKeyName(0, "groep")
        Me.ilImages.Images.SetKeyName(1, "kind")
        Me.ilImages.Images.SetKeyName(2, "transferlijst")
        Me.ilImages.Images.SetKeyName(3, "wachtlijst")
        Me.ilImages.Images.SetKeyName(4, "alleen")
        '
        'lvBrowser
        '
        Me.lvBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvBrowser.BackColor = System.Drawing.SystemColors.Window
        Me.lvBrowser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvBrowser_ColumnHeader_1, Me.prioriteit})
        Me.lvBrowser.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvBrowser.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvBrowser.HideSelection = False
        Me.lvBrowser.LargeImageList = Me.ilImages
        Me.lvBrowser.Location = New System.Drawing.Point(3, 31)
        Me.lvBrowser.MultiSelect = False
        Me.lvBrowser.Name = "lvBrowser"
        Me.lvBrowser.Size = New System.Drawing.Size(235, 338)
        Me.lvBrowser.TabIndex = 0
        Me.lvBrowser.UseCompatibleStateImageBehavior = False
        '
        '_lvBrowser_ColumnHeader_1
        '
        Me._lvBrowser_ColumnHeader_1.Text = "Naam"
        Me._lvBrowser_ColumnHeader_1.Width = 236
        '
        'prioriteit
        '
        Me.prioriteit.Text = "Prioriteit"
        Me.prioriteit.Width = 95
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(694, 378)
        Me.TableLayoutPanel1.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txtGroep)
        Me.Panel1.Controls.Add(Me.picUp1)
        Me.Panel1.Controls.Add(Me.lvBrowser)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(241, 372)
        Me.Panel1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.lblPos)
        Me.Panel2.Controls.Add(Me.frmInfo)
        Me.Panel2.Controls.Add(Me.frmCopyKind)
        Me.Panel2.Location = New System.Drawing.Point(250, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(194, 372)
        Me.Panel2.TabIndex = 28
        '
        'lblPos
        '
        Me.lblPos.AutoSize = True
        Me.lblPos.Location = New System.Drawing.Point(4, 343)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(39, 14)
        Me.lblPos.TabIndex = 7
        Me.lblPos.Text = "Label1"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.txtGroep2)
        Me.Panel3.Controls.Add(Me.picUp2)
        Me.Panel3.Controls.Add(Me.lvGroepen)
        Me.Panel3.Location = New System.Drawing.Point(450, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(241, 372)
        Me.Panel3.TabIndex = 29
        '
        'frmGroepsSamenstelling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(702, 418)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnClose)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MinimumSize = New System.Drawing.Size(585, 422)
        Me.Name = "frmGroepsSamenstelling"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Groeps Samenstelling"
        CType(Me.picUp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUp2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmInfo.ResumeLayout(False)
        Me.frmInfo.PerformLayout()
        Me.frmCopyKind.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblPos As System.Windows.Forms.Label
#End Region 
End Class