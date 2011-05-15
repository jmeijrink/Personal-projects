<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWijzigenKinderen
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
	Public WithEvents txtOpmKind As System.Windows.Forms.TextBox
	Public WithEvents btnDelete As System.Windows.Forms.Button
    Public WithEvents txtOpmerking As System.Windows.Forms.TextBox
	Public WithEvents lstGroepen As System.Windows.Forms.ListBox
	Public WithEvents lblPrioriteit As System.Windows.Forms.Label
	Public WithEvents lblOpmerking As System.Windows.Forms.Label
	Public WithEvents lblInfo1 As System.Windows.Forms.Label
	Public WithEvents frmExtInf As System.Windows.Forms.GroupBox
    Public WithEvents txtTelefoon As System.Windows.Forms.TextBox
	Public WithEvents txtNaam As System.Windows.Forms.TextBox
	Public WithEvents btnSave As System.Windows.Forms.Button
	Public WithEvents _lvKinderen_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvKinderen_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvKinderen As System.Windows.Forms.ListView
	Public WithEvents btnExit As System.Windows.Forms.Button
	Public WithEvents lblOpmKind As System.Windows.Forms.Label
    Public WithEvents lblInsDat As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblNaam As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWijzigenKinderen))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtTelefoon = New System.Windows.Forms.TextBox
        Me.txtNaam = New System.Windows.Forms.TextBox
        Me.txtOpmKind = New System.Windows.Forms.TextBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.frmExtInf = New System.Windows.Forms.GroupBox
        Me.txtPrioriteit = New System.Windows.Forms.NumericUpDown
        Me.txtOpmerking = New System.Windows.Forms.TextBox
        Me.lblPrioriteit = New System.Windows.Forms.Label
        Me.lblOpmerking = New System.Windows.Forms.Label
        Me.lblInfo1 = New System.Windows.Forms.Label
        Me.lstGroepen = New System.Windows.Forms.ListBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.lvKinderen = New System.Windows.Forms.ListView
        Me._lvKinderen_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me._lvKinderen_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblOpmKind = New System.Windows.Forms.Label
        Me.lblInsDat = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblNaam = New System.Windows.Forms.Label
        Me.txtGebDat = New System.Windows.Forms.DateTimePicker
        Me.txtInsDat = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkVerwijderd = New System.Windows.Forms.CheckBox
        Me.frmExtInf.SuspendLayout()
        CType(Me.txtPrioriteit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTelefoon
        '
        Me.txtTelefoon.AcceptsReturn = True
        Me.txtTelefoon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefoon.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelefoon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefoon.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefoon.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTelefoon.Location = New System.Drawing.Point(347, 31)
        Me.txtTelefoon.MaxLength = 0
        Me.txtTelefoon.Name = "txtTelefoon"
        Me.txtTelefoon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTelefoon.Size = New System.Drawing.Size(137, 20)
        Me.txtTelefoon.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtTelefoon, "Verplicht veld")
        '
        'txtNaam
        '
        Me.txtNaam.AcceptsReturn = True
        Me.txtNaam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNaam.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNaam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNaam.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNaam.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNaam.Location = New System.Drawing.Point(347, 5)
        Me.txtNaam.MaxLength = 0
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNaam.Size = New System.Drawing.Size(137, 20)
        Me.txtNaam.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtNaam, "Verplicht veld")
        '
        'txtOpmKind
        '
        Me.txtOpmKind.AcceptsReturn = True
        Me.txtOpmKind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOpmKind.BackColor = System.Drawing.SystemColors.Window
        Me.txtOpmKind.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpmKind.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpmKind.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOpmKind.Location = New System.Drawing.Point(347, 109)
        Me.txtOpmKind.MaxLength = 0
        Me.txtOpmKind.Name = "txtOpmKind"
        Me.txtOpmKind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOpmKind.Size = New System.Drawing.Size(137, 20)
        Me.txtOpmKind.TabIndex = 22
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelete.Location = New System.Drawing.Point(248, 305)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDelete.Size = New System.Drawing.Size(77, 29)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "&Verwijderen"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'frmExtInf
        '
        Me.frmExtInf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmExtInf.BackColor = System.Drawing.SystemColors.Control
        Me.frmExtInf.Controls.Add(Me.txtPrioriteit)
        Me.frmExtInf.Controls.Add(Me.txtOpmerking)
        Me.frmExtInf.Controls.Add(Me.lblPrioriteit)
        Me.frmExtInf.Controls.Add(Me.lblOpmerking)
        Me.frmExtInf.Controls.Add(Me.lblInfo1)
        Me.frmExtInf.Controls.Add(Me.lstGroepen)
        Me.frmExtInf.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmExtInf.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmExtInf.Location = New System.Drawing.Point(248, 164)
        Me.frmExtInf.Name = "frmExtInf"
        Me.frmExtInf.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmExtInf.Size = New System.Drawing.Size(247, 135)
        Me.frmExtInf.TabIndex = 11
        Me.frmExtInf.TabStop = False
        Me.frmExtInf.Text = "Extra Informatie"
        '
        'txtPrioriteit
        '
        Me.txtPrioriteit.Location = New System.Drawing.Point(79, 30)
        Me.txtPrioriteit.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.txtPrioriteit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtPrioriteit.Name = "txtPrioriteit"
        Me.txtPrioriteit.Size = New System.Drawing.Size(33, 20)
        Me.txtPrioriteit.TabIndex = 19
        Me.txtPrioriteit.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtOpmerking
        '
        Me.txtOpmerking.AcceptsReturn = True
        Me.txtOpmerking.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOpmerking.BackColor = System.Drawing.SystemColors.Window
        Me.txtOpmerking.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpmerking.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpmerking.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOpmerking.Location = New System.Drawing.Point(79, 53)
        Me.txtOpmerking.MaxLength = 0
        Me.txtOpmerking.Multiline = True
        Me.txtOpmerking.Name = "txtOpmerking"
        Me.txtOpmerking.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOpmerking.Size = New System.Drawing.Size(157, 71)
        Me.txtOpmerking.TabIndex = 16
        Me.txtOpmerking.Visible = False
        '
        'lblPrioriteit
        '
        Me.lblPrioriteit.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrioriteit.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPrioriteit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioriteit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrioriteit.Location = New System.Drawing.Point(12, 32)
        Me.lblPrioriteit.Name = "lblPrioriteit"
        Me.lblPrioriteit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPrioriteit.Size = New System.Drawing.Size(45, 21)
        Me.lblPrioriteit.TabIndex = 18
        Me.lblPrioriteit.Text = "Prioriteit"
        Me.lblPrioriteit.Visible = False
        '
        'lblOpmerking
        '
        Me.lblOpmerking.BackColor = System.Drawing.SystemColors.Control
        Me.lblOpmerking.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOpmerking.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpmerking.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOpmerking.Location = New System.Drawing.Point(12, 56)
        Me.lblOpmerking.Name = "lblOpmerking"
        Me.lblOpmerking.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOpmerking.Size = New System.Drawing.Size(61, 13)
        Me.lblOpmerking.TabIndex = 17
        Me.lblOpmerking.Text = "Opmerking"
        Me.lblOpmerking.Visible = False
        '
        'lblInfo1
        '
        Me.lblInfo1.AutoSize = True
        Me.lblInfo1.BackColor = System.Drawing.SystemColors.Control
        Me.lblInfo1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInfo1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInfo1.Location = New System.Drawing.Point(12, 16)
        Me.lblInfo1.Name = "lblInfo1"
        Me.lblInfo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInfo1.Size = New System.Drawing.Size(0, 14)
        Me.lblInfo1.TabIndex = 12
        '
        'lstGroepen
        '
        Me.lstGroepen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstGroepen.BackColor = System.Drawing.SystemColors.Window
        Me.lstGroepen.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstGroepen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGroepen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstGroepen.ItemHeight = 14
        Me.lstGroepen.Location = New System.Drawing.Point(12, 33)
        Me.lstGroepen.Name = "lstGroepen"
        Me.lstGroepen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstGroepen.Size = New System.Drawing.Size(224, 88)
        Me.lstGroepen.TabIndex = 13
        Me.lstGroepen.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.Location = New System.Drawing.Point(331, 305)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSave.Size = New System.Drawing.Size(77, 29)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Opslaan"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lvKinderen
        '
        Me.lvKinderen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvKinderen.BackColor = System.Drawing.SystemColors.Window
        Me.lvKinderen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvKinderen_ColumnHeader_1, Me._lvKinderen_ColumnHeader_2})
        Me.lvKinderen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvKinderen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvKinderen.HideSelection = False
        Me.lvKinderen.Location = New System.Drawing.Point(12, 12)
        Me.lvKinderen.MultiSelect = False
        Me.lvKinderen.Name = "lvKinderen"
        Me.lvKinderen.Size = New System.Drawing.Size(230, 322)
        Me.lvKinderen.TabIndex = 1
        Me.lvKinderen.UseCompatibleStateImageBehavior = False
        Me.lvKinderen.View = System.Windows.Forms.View.Details
        '
        '_lvKinderen_ColumnHeader_1
        '
        Me._lvKinderen_ColumnHeader_1.Text = "Naam"
        Me._lvKinderen_ColumnHeader_1.Width = 224
        '
        '_lvKinderen_ColumnHeader_2
        '
        Me._lvKinderen_ColumnHeader_2.Text = "Nummer"
        Me._lvKinderen_ColumnHeader_2.Width = 48
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(414, 305)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExit.Size = New System.Drawing.Size(81, 29)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Af&sluiten"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblOpmKind
        '
        Me.lblOpmKind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOpmKind.BackColor = System.Drawing.SystemColors.Control
        Me.lblOpmKind.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOpmKind.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpmKind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOpmKind.Location = New System.Drawing.Point(248, 112)
        Me.lblOpmKind.Name = "lblOpmKind"
        Me.lblOpmKind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOpmKind.Size = New System.Drawing.Size(69, 21)
        Me.lblOpmKind.TabIndex = 23
        Me.lblOpmKind.Text = "Opmerking"
        '
        'lblInsDat
        '
        Me.lblInsDat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInsDat.BackColor = System.Drawing.SystemColors.Control
        Me.lblInsDat.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInsDat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsDat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInsDat.Location = New System.Drawing.Point(248, 86)
        Me.lblInsDat.Name = "lblInsDat"
        Me.lblInsDat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInsDat.Size = New System.Drawing.Size(77, 17)
        Me.lblInsDat.TabIndex = 9
        Me.lblInsDat.Text = "Inschrijf dat."
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(248, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Geb. datum"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(248, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(57, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Telefoon"
        '
        'lblNaam
        '
        Me.lblNaam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNaam.BackColor = System.Drawing.SystemColors.Control
        Me.lblNaam.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNaam.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaam.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNaam.Location = New System.Drawing.Point(248, 8)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNaam.Size = New System.Drawing.Size(45, 17)
        Me.lblNaam.TabIndex = 3
        Me.lblNaam.Text = "Naam"
        '
        'txtGebDat
        '
        Me.txtGebDat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGebDat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtGebDat.Location = New System.Drawing.Point(347, 57)
        Me.txtGebDat.Name = "txtGebDat"
        Me.txtGebDat.Size = New System.Drawing.Size(137, 20)
        Me.txtGebDat.TabIndex = 24
        '
        'txtInsDat
        '
        Me.txtInsDat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInsDat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtInsDat.Location = New System.Drawing.Point(347, 83)
        Me.txtInsDat.Name = "txtInsDat"
        Me.txtInsDat.Size = New System.Drawing.Size(137, 20)
        Me.txtInsDat.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(248, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 14)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Verwijderd"
        '
        'chkVerwijderd
        '
        Me.chkVerwijderd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkVerwijderd.Location = New System.Drawing.Point(347, 136)
        Me.chkVerwijderd.Name = "chkVerwijderd"
        Me.chkVerwijderd.Size = New System.Drawing.Size(137, 22)
        Me.chkVerwijderd.TabIndex = 27
        Me.chkVerwijderd.UseVisualStyleBackColor = True
        '
        'frmWijzigenKinderen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(502, 346)
        Me.Controls.Add(Me.chkVerwijderd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtInsDat)
        Me.Controls.Add(Me.txtGebDat)
        Me.Controls.Add(Me.txtOpmKind)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.frmExtInf)
        Me.Controls.Add(Me.txtTelefoon)
        Me.Controls.Add(Me.txtNaam)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lvKinderen)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblOpmKind)
        Me.Controls.Add(Me.lblInsDat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNaam)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(287, 233)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(495, 302)
        Me.Name = "frmWijzigenKinderen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Wijzigen Kinderen"
        Me.frmExtInf.ResumeLayout(False)
        Me.frmExtInf.PerformLayout()
        CType(Me.txtPrioriteit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGebDat As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPrioriteit As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtInsDat As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkVerwijderd As System.Windows.Forms.CheckBox
#End Region 
End Class