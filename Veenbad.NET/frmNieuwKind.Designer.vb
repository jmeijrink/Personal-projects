<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmNieuwKind
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
    Public WithEvents btnSave As System.Windows.Forms.Button
	Public WithEvents btnClose As System.Windows.Forms.Button
    Public WithEvents txtOpm As System.Windows.Forms.TextBox
	Public WithEvents _lvGroepen_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvGroepen_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvGroepen As System.Windows.Forms.ListView
	Public WithEvents optGroep As System.Windows.Forms.RadioButton
	Public WithEvents optAlleen As System.Windows.Forms.RadioButton
	Public WithEvents optWachtlijst As System.Windows.Forms.RadioButton
	Public WithEvents lblPrioriteit As System.Windows.Forms.Label
	Public WithEvents lblOpm As System.Windows.Forms.Label
	Public WithEvents frmGoal As System.Windows.Forms.GroupBox
	Public WithEvents txtOpmerking As System.Windows.Forms.TextBox
	Public WithEvents txtTelNr As System.Windows.Forms.TextBox
    Public WithEvents txtNaam As System.Windows.Forms.TextBox
	Public WithEvents txtKindNummer As System.Windows.Forms.TextBox
	Public WithEvents lblOpmerking As System.Windows.Forms.Label
	Public WithEvents lblTelNr As System.Windows.Forms.Label
	Public WithEvents lblNaam As System.Windows.Forms.Label
	Public WithEvents lblNummer As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNieuwKind))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtTelNr = New System.Windows.Forms.TextBox
        Me.txtNaam = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.frmGoal = New System.Windows.Forms.GroupBox
        Me.txtPrioriteit = New System.Windows.Forms.NumericUpDown
        Me.txtOpm = New System.Windows.Forms.TextBox
        Me.lvGroepen = New System.Windows.Forms.ListView
        Me._lvGroepen_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me._lvGroepen_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
        Me.optGroep = New System.Windows.Forms.RadioButton
        Me.optAlleen = New System.Windows.Forms.RadioButton
        Me.optWachtlijst = New System.Windows.Forms.RadioButton
        Me.lblPrioriteit = New System.Windows.Forms.Label
        Me.lblOpm = New System.Windows.Forms.Label
        Me.txtOpmerking = New System.Windows.Forms.TextBox
        Me.txtKindNummer = New System.Windows.Forms.TextBox
        Me.lblOpmerking = New System.Windows.Forms.Label
        Me.lblTelNr = New System.Windows.Forms.Label
        Me.lblNaam = New System.Windows.Forms.Label
        Me.lblNummer = New System.Windows.Forms.Label
        Me.txtGebDat = New System.Windows.Forms.DateTimePicker
        Me.txtInsDat = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.frmGoal.SuspendLayout()
        CType(Me.txtPrioriteit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTelNr
        '
        Me.txtTelNr.AcceptsReturn = True
        Me.txtTelNr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelNr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelNr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelNr.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTelNr.Location = New System.Drawing.Point(112, 92)
        Me.txtTelNr.MaxLength = 0
        Me.txtTelNr.Name = "txtTelNr"
        Me.txtTelNr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTelNr.Size = New System.Drawing.Size(105, 20)
        Me.txtTelNr.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtTelNr, "Verplicht veld")
        '
        'txtNaam
        '
        Me.txtNaam.AcceptsReturn = True
        Me.txtNaam.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNaam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNaam.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNaam.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNaam.Location = New System.Drawing.Point(112, 36)
        Me.txtNaam.MaxLength = 0
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNaam.Size = New System.Drawing.Size(105, 20)
        Me.txtNaam.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtNaam, "Verplicht veld")
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.Location = New System.Drawing.Point(53, 247)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSave.Size = New System.Drawing.Size(77, 25)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "&Opslaan"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(136, 247)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClose.Size = New System.Drawing.Size(81, 25)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Af&sluiten"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmGoal
        '
        Me.frmGoal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmGoal.BackColor = System.Drawing.SystemColors.Control
        Me.frmGoal.Controls.Add(Me.txtPrioriteit)
        Me.frmGoal.Controls.Add(Me.txtOpm)
        Me.frmGoal.Controls.Add(Me.lvGroepen)
        Me.frmGoal.Controls.Add(Me.optGroep)
        Me.frmGoal.Controls.Add(Me.optAlleen)
        Me.frmGoal.Controls.Add(Me.optWachtlijst)
        Me.frmGoal.Controls.Add(Me.lblPrioriteit)
        Me.frmGoal.Controls.Add(Me.lblOpm)
        Me.frmGoal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmGoal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmGoal.Location = New System.Drawing.Point(232, 4)
        Me.frmGoal.Name = "frmGoal"
        Me.frmGoal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmGoal.Size = New System.Drawing.Size(233, 268)
        Me.frmGoal.TabIndex = 21
        Me.frmGoal.TabStop = False
        Me.frmGoal.Text = "Doel"
        '
        'txtPrioriteit
        '
        Me.txtPrioriteit.Location = New System.Drawing.Point(100, 75)
        Me.txtPrioriteit.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.txtPrioriteit.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtPrioriteit.Name = "txtPrioriteit"
        Me.txtPrioriteit.Size = New System.Drawing.Size(37, 20)
        Me.txtPrioriteit.TabIndex = 24
        Me.txtPrioriteit.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtOpm
        '
        Me.txtOpm.AcceptsReturn = True
        Me.txtOpm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOpm.BackColor = System.Drawing.SystemColors.Window
        Me.txtOpm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpm.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOpm.Location = New System.Drawing.Point(99, 52)
        Me.txtOpm.MaxLength = 0
        Me.txtOpm.Name = "txtOpm"
        Me.txtOpm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOpm.Size = New System.Drawing.Size(126, 20)
        Me.txtOpm.TabIndex = 8
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
        Me.lvGroepen.Location = New System.Drawing.Point(43, 127)
        Me.lvGroepen.Name = "lvGroepen"
        Me.lvGroepen.Size = New System.Drawing.Size(182, 133)
        Me.lvGroepen.TabIndex = 12
        Me.lvGroepen.UseCompatibleStateImageBehavior = False
        Me.lvGroepen.View = System.Windows.Forms.View.Details
        '
        '_lvGroepen_ColumnHeader_1
        '
        Me._lvGroepen_ColumnHeader_1.Text = "Naam"
        Me._lvGroepen_ColumnHeader_1.Width = 120
        '
        '_lvGroepen_ColumnHeader_2
        '
        Me._lvGroepen_ColumnHeader_2.Text = "Nummer"
        Me._lvGroepen_ColumnHeader_2.Width = 170
        '
        'optGroep
        '
        Me.optGroep.BackColor = System.Drawing.SystemColors.Control
        Me.optGroep.Cursor = System.Windows.Forms.Cursors.Default
        Me.optGroep.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optGroep.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optGroep.Location = New System.Drawing.Point(16, 100)
        Me.optGroep.Name = "optGroep"
        Me.optGroep.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optGroep.Size = New System.Drawing.Size(93, 21)
        Me.optGroep.TabIndex = 11
        Me.optGroep.TabStop = True
        Me.optGroep.Text = "&Groepen"
        Me.optGroep.UseVisualStyleBackColor = False
        '
        'optAlleen
        '
        Me.optAlleen.BackColor = System.Drawing.SystemColors.Control
        Me.optAlleen.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAlleen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAlleen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAlleen.Location = New System.Drawing.Point(16, 12)
        Me.optAlleen.Name = "optAlleen"
        Me.optAlleen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAlleen.Size = New System.Drawing.Size(149, 25)
        Me.optAlleen.TabIndex = 6
        Me.optAlleen.TabStop = True
        Me.optAlleen.Text = "&Niet Indelen"
        Me.optAlleen.UseVisualStyleBackColor = False
        '
        'optWachtlijst
        '
        Me.optWachtlijst.BackColor = System.Drawing.SystemColors.Control
        Me.optWachtlijst.Checked = True
        Me.optWachtlijst.Cursor = System.Windows.Forms.Cursors.Default
        Me.optWachtlijst.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optWachtlijst.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optWachtlijst.Location = New System.Drawing.Point(16, 36)
        Me.optWachtlijst.Name = "optWachtlijst"
        Me.optWachtlijst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optWachtlijst.Size = New System.Drawing.Size(153, 17)
        Me.optWachtlijst.TabIndex = 7
        Me.optWachtlijst.TabStop = True
        Me.optWachtlijst.Text = "&Wachtlijst"
        Me.optWachtlijst.UseVisualStyleBackColor = False
        '
        'lblPrioriteit
        '
        Me.lblPrioriteit.BackColor = System.Drawing.SystemColors.Control
        Me.lblPrioriteit.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPrioriteit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioriteit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrioriteit.Location = New System.Drawing.Point(40, 77)
        Me.lblPrioriteit.Name = "lblPrioriteit"
        Me.lblPrioriteit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPrioriteit.Size = New System.Drawing.Size(49, 17)
        Me.lblPrioriteit.TabIndex = 23
        Me.lblPrioriteit.Text = "Prioriteit"
        '
        'lblOpm
        '
        Me.lblOpm.BackColor = System.Drawing.SystemColors.Control
        Me.lblOpm.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOpm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOpm.Location = New System.Drawing.Point(40, 55)
        Me.lblOpm.Name = "lblOpm"
        Me.lblOpm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOpm.Size = New System.Drawing.Size(53, 17)
        Me.lblOpm.TabIndex = 22
        Me.lblOpm.Text = "Opmerking"
        '
        'txtOpmerking
        '
        Me.txtOpmerking.AcceptsReturn = True
        Me.txtOpmerking.BackColor = System.Drawing.SystemColors.Window
        Me.txtOpmerking.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpmerking.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpmerking.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOpmerking.Location = New System.Drawing.Point(112, 148)
        Me.txtOpmerking.MaxLength = 0
        Me.txtOpmerking.Name = "txtOpmerking"
        Me.txtOpmerking.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOpmerking.Size = New System.Drawing.Size(105, 20)
        Me.txtOpmerking.TabIndex = 5
        '
        'txtKindNummer
        '
        Me.txtKindNummer.AcceptsReturn = True
        Me.txtKindNummer.BackColor = System.Drawing.SystemColors.Window
        Me.txtKindNummer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKindNummer.Enabled = False
        Me.txtKindNummer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKindNummer.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtKindNummer.Location = New System.Drawing.Point(112, 12)
        Me.txtKindNummer.MaxLength = 0
        Me.txtKindNummer.Name = "txtKindNummer"
        Me.txtKindNummer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKindNummer.Size = New System.Drawing.Size(105, 20)
        Me.txtKindNummer.TabIndex = 0
        '
        'lblOpmerking
        '
        Me.lblOpmerking.BackColor = System.Drawing.SystemColors.Control
        Me.lblOpmerking.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOpmerking.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpmerking.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOpmerking.Location = New System.Drawing.Point(16, 152)
        Me.lblOpmerking.Name = "lblOpmerking"
        Me.lblOpmerking.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOpmerking.Size = New System.Drawing.Size(93, 17)
        Me.lblOpmerking.TabIndex = 20
        Me.lblOpmerking.Text = "Opmerking"
        '
        'lblTelNr
        '
        Me.lblTelNr.BackColor = System.Drawing.SystemColors.Control
        Me.lblTelNr.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTelNr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelNr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTelNr.Location = New System.Drawing.Point(16, 96)
        Me.lblTelNr.Name = "lblTelNr"
        Me.lblTelNr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTelNr.Size = New System.Drawing.Size(89, 17)
        Me.lblTelNr.TabIndex = 19
        Me.lblTelNr.Text = "Telefoon nummer"
        '
        'lblNaam
        '
        Me.lblNaam.BackColor = System.Drawing.SystemColors.Control
        Me.lblNaam.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNaam.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaam.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNaam.Location = New System.Drawing.Point(16, 40)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNaam.Size = New System.Drawing.Size(85, 17)
        Me.lblNaam.TabIndex = 18
        Me.lblNaam.Text = "Naam"
        '
        'lblNummer
        '
        Me.lblNummer.BackColor = System.Drawing.SystemColors.Control
        Me.lblNummer.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNummer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNummer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNummer.Location = New System.Drawing.Point(16, 16)
        Me.lblNummer.Name = "lblNummer"
        Me.lblNummer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNummer.Size = New System.Drawing.Size(77, 17)
        Me.lblNummer.TabIndex = 17
        Me.lblNummer.Text = "Kind Nummer"
        '
        'txtGebDat
        '
        Me.txtGebDat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtGebDat.Location = New System.Drawing.Point(111, 63)
        Me.txtGebDat.Name = "txtGebDat"
        Me.txtGebDat.Size = New System.Drawing.Size(106, 20)
        Me.txtGebDat.TabIndex = 25
        '
        'txtInsDat
        '
        Me.txtInsDat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtInsDat.Location = New System.Drawing.Point(112, 120)
        Me.txtInsDat.Name = "txtInsDat"
        Me.txtInsDat.Size = New System.Drawing.Size(105, 20)
        Me.txtInsDat.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 14)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Geboorte datum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 14)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Inschrijfdatum"
        '
        'frmNieuwKind
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(470, 284)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInsDat)
        Me.Controls.Add(Me.txtGebDat)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.frmGoal)
        Me.Controls.Add(Me.txtOpmerking)
        Me.Controls.Add(Me.txtTelNr)
        Me.Controls.Add(Me.txtNaam)
        Me.Controls.Add(Me.txtKindNummer)
        Me.Controls.Add(Me.lblOpmerking)
        Me.Controls.Add(Me.lblTelNr)
        Me.Controls.Add(Me.lblNaam)
        Me.Controls.Add(Me.lblNummer)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(444, 252)
        Me.Name = "frmNieuwKind"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Kinderen - Nieuw"
        Me.frmGoal.ResumeLayout(False)
        Me.frmGoal.PerformLayout()
        CType(Me.txtPrioriteit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGebDat As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtInsDat As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPrioriteit As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
#End Region 
End Class