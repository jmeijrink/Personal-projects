<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWijzigenGroepen
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
	Public WithEvents txtAantal As System.Windows.Forms.TextBox
	Public WithEvents lblAantal As System.Windows.Forms.Label
	Public WithEvents frmInfo As System.Windows.Forms.GroupBox
	Public WithEvents btnAfsluiten As System.Windows.Forms.Button
	Public WithEvents btnOpslaan As System.Windows.Forms.Button
	Public WithEvents btnVerwijderen As System.Windows.Forms.Button
	Public WithEvents txtDagEnTijd4 As System.Windows.Forms.TextBox
	Public WithEvents txtDagEnTijd3 As System.Windows.Forms.TextBox
	Public WithEvents txtDagEnTijd2 As System.Windows.Forms.TextBox
	Public WithEvents txtDagEnTijd1 As System.Windows.Forms.TextBox
	Public WithEvents txtDiploma As System.Windows.Forms.TextBox
	Public WithEvents txtNaam As System.Windows.Forms.TextBox
	Public WithEvents _lvGroepen_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvGroepen_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvGroepen As System.Windows.Forms.ListView
	Public WithEvents lblMask4 As System.Windows.Forms.Label
	Public WithEvents lblMask3 As System.Windows.Forms.Label
	Public WithEvents lblMask2 As System.Windows.Forms.Label
	Public WithEvents lblMask1 As System.Windows.Forms.Label
	Public WithEvents lblDagEnTijd4 As System.Windows.Forms.Label
	Public WithEvents lblDagEnTijd3 As System.Windows.Forms.Label
	Public WithEvents lblDagEnTijd2 As System.Windows.Forms.Label
	Public WithEvents lblDagEnTijd1 As System.Windows.Forms.Label
	Public WithEvents lblDiploma As System.Windows.Forms.Label
	Public WithEvents lblNaam As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWijzigenGroepen))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDagEnTijd1 = New System.Windows.Forms.TextBox
        Me.txtDiploma = New System.Windows.Forms.TextBox
        Me.txtNaam = New System.Windows.Forms.TextBox
        Me.frmInfo = New System.Windows.Forms.GroupBox
        Me.txtAantal = New System.Windows.Forms.TextBox
        Me.lblAantal = New System.Windows.Forms.Label
        Me.btnAfsluiten = New System.Windows.Forms.Button
        Me.btnOpslaan = New System.Windows.Forms.Button
        Me.btnVerwijderen = New System.Windows.Forms.Button
        Me.txtDagEnTijd4 = New System.Windows.Forms.TextBox
        Me.txtDagEnTijd3 = New System.Windows.Forms.TextBox
        Me.txtDagEnTijd2 = New System.Windows.Forms.TextBox
        Me.lvGroepen = New System.Windows.Forms.ListView
        Me._lvGroepen_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me._lvGroepen_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
        Me.lblMask4 = New System.Windows.Forms.Label
        Me.lblMask3 = New System.Windows.Forms.Label
        Me.lblMask2 = New System.Windows.Forms.Label
        Me.lblMask1 = New System.Windows.Forms.Label
        Me.lblDagEnTijd4 = New System.Windows.Forms.Label
        Me.lblDagEnTijd3 = New System.Windows.Forms.Label
        Me.lblDagEnTijd2 = New System.Windows.Forms.Label
        Me.lblDagEnTijd1 = New System.Windows.Forms.Label
        Me.lblDiploma = New System.Windows.Forms.Label
        Me.lblNaam = New System.Windows.Forms.Label
        Me.frmInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDagEnTijd1
        '
        Me.txtDagEnTijd1.AcceptsReturn = True
        Me.txtDagEnTijd1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDagEnTijd1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDagEnTijd1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDagEnTijd1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDagEnTijd1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDagEnTijd1.Location = New System.Drawing.Point(252, 60)
        Me.txtDagEnTijd1.MaxLength = 0
        Me.txtDagEnTijd1.Name = "txtDagEnTijd1"
        Me.txtDagEnTijd1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDagEnTijd1.Size = New System.Drawing.Size(121, 20)
        Me.txtDagEnTijd1.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtDagEnTijd1, "Verplicht veld")
        '
        'txtDiploma
        '
        Me.txtDiploma.AcceptsReturn = True
        Me.txtDiploma.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiploma.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDiploma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiploma.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiploma.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiploma.Location = New System.Drawing.Point(252, 34)
        Me.txtDiploma.MaxLength = 0
        Me.txtDiploma.Name = "txtDiploma"
        Me.txtDiploma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiploma.Size = New System.Drawing.Size(121, 20)
        Me.txtDiploma.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtDiploma, "Verplicht veld")
        '
        'txtNaam
        '
        Me.txtNaam.AcceptsReturn = True
        Me.txtNaam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNaam.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNaam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNaam.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNaam.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNaam.Location = New System.Drawing.Point(252, 8)
        Me.txtNaam.MaxLength = 0
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNaam.Size = New System.Drawing.Size(121, 20)
        Me.txtNaam.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtNaam, "Verplicht veld")
        '
        'frmInfo
        '
        Me.frmInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frmInfo.BackColor = System.Drawing.SystemColors.Control
        Me.frmInfo.Controls.Add(Me.txtAantal)
        Me.frmInfo.Controls.Add(Me.lblAantal)
        Me.frmInfo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmInfo.Location = New System.Drawing.Point(171, 164)
        Me.frmInfo.Name = "frmInfo"
        Me.frmInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmInfo.Size = New System.Drawing.Size(266, 45)
        Me.frmInfo.TabIndex = 16
        Me.frmInfo.TabStop = False
        Me.frmInfo.Text = "Info"
        '
        'txtAantal
        '
        Me.txtAantal.AcceptsReturn = True
        Me.txtAantal.BackColor = System.Drawing.SystemColors.Window
        Me.txtAantal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAantal.Enabled = False
        Me.txtAantal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAantal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAantal.Location = New System.Drawing.Point(94, 13)
        Me.txtAantal.MaxLength = 0
        Me.txtAantal.Name = "txtAantal"
        Me.txtAantal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAantal.Size = New System.Drawing.Size(37, 20)
        Me.txtAantal.TabIndex = 18
        '
        'lblAantal
        '
        Me.lblAantal.AutoSize = True
        Me.lblAantal.BackColor = System.Drawing.SystemColors.Control
        Me.lblAantal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAantal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAantal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAantal.Location = New System.Drawing.Point(6, 16)
        Me.lblAantal.Name = "lblAantal"
        Me.lblAantal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAantal.Size = New System.Drawing.Size(82, 14)
        Me.lblAantal.TabIndex = 17
        Me.lblAantal.Text = "Aantal kinderen"
        '
        'btnAfsluiten
        '
        Me.btnAfsluiten.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAfsluiten.BackColor = System.Drawing.SystemColors.Control
        Me.btnAfsluiten.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAfsluiten.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAfsluiten.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAfsluiten.Location = New System.Drawing.Point(374, 217)
        Me.btnAfsluiten.Name = "btnAfsluiten"
        Me.btnAfsluiten.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAfsluiten.Size = New System.Drawing.Size(97, 25)
        Me.btnAfsluiten.TabIndex = 15
        Me.btnAfsluiten.Text = "Af&sluiten"
        Me.btnAfsluiten.UseVisualStyleBackColor = False
        '
        'btnOpslaan
        '
        Me.btnOpslaan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpslaan.BackColor = System.Drawing.SystemColors.Control
        Me.btnOpslaan.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOpslaan.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpslaan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOpslaan.Location = New System.Drawing.Point(271, 217)
        Me.btnOpslaan.Name = "btnOpslaan"
        Me.btnOpslaan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOpslaan.Size = New System.Drawing.Size(97, 25)
        Me.btnOpslaan.TabIndex = 14
        Me.btnOpslaan.Text = "&Opslaan"
        Me.btnOpslaan.UseVisualStyleBackColor = False
        '
        'btnVerwijderen
        '
        Me.btnVerwijderen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVerwijderen.BackColor = System.Drawing.SystemColors.Control
        Me.btnVerwijderen.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnVerwijderen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerwijderen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVerwijderen.Location = New System.Drawing.Point(171, 217)
        Me.btnVerwijderen.Name = "btnVerwijderen"
        Me.btnVerwijderen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnVerwijderen.Size = New System.Drawing.Size(94, 25)
        Me.btnVerwijderen.TabIndex = 13
        Me.btnVerwijderen.Text = "&Verwijderen"
        Me.btnVerwijderen.UseVisualStyleBackColor = False
        '
        'txtDagEnTijd4
        '
        Me.txtDagEnTijd4.AcceptsReturn = True
        Me.txtDagEnTijd4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDagEnTijd4.BackColor = System.Drawing.SystemColors.Window
        Me.txtDagEnTijd4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDagEnTijd4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDagEnTijd4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDagEnTijd4.Location = New System.Drawing.Point(252, 138)
        Me.txtDagEnTijd4.MaxLength = 0
        Me.txtDagEnTijd4.Name = "txtDagEnTijd4"
        Me.txtDagEnTijd4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDagEnTijd4.Size = New System.Drawing.Size(121, 20)
        Me.txtDagEnTijd4.TabIndex = 6
        '
        'txtDagEnTijd3
        '
        Me.txtDagEnTijd3.AcceptsReturn = True
        Me.txtDagEnTijd3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDagEnTijd3.BackColor = System.Drawing.SystemColors.Window
        Me.txtDagEnTijd3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDagEnTijd3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDagEnTijd3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDagEnTijd3.Location = New System.Drawing.Point(252, 112)
        Me.txtDagEnTijd3.MaxLength = 0
        Me.txtDagEnTijd3.Name = "txtDagEnTijd3"
        Me.txtDagEnTijd3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDagEnTijd3.Size = New System.Drawing.Size(121, 20)
        Me.txtDagEnTijd3.TabIndex = 5
        '
        'txtDagEnTijd2
        '
        Me.txtDagEnTijd2.AcceptsReturn = True
        Me.txtDagEnTijd2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDagEnTijd2.BackColor = System.Drawing.SystemColors.Window
        Me.txtDagEnTijd2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDagEnTijd2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDagEnTijd2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDagEnTijd2.Location = New System.Drawing.Point(252, 86)
        Me.txtDagEnTijd2.MaxLength = 0
        Me.txtDagEnTijd2.Name = "txtDagEnTijd2"
        Me.txtDagEnTijd2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDagEnTijd2.Size = New System.Drawing.Size(121, 20)
        Me.txtDagEnTijd2.TabIndex = 4
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
        Me.lvGroepen.Location = New System.Drawing.Point(4, 8)
        Me.lvGroepen.Name = "lvGroepen"
        Me.lvGroepen.Size = New System.Drawing.Size(161, 234)
        Me.lvGroepen.TabIndex = 0
        Me.lvGroepen.UseCompatibleStateImageBehavior = False
        Me.lvGroepen.View = System.Windows.Forms.View.Details
        '
        '_lvGroepen_ColumnHeader_1
        '
        Me._lvGroepen_ColumnHeader_1.Text = "Naam"
        Me._lvGroepen_ColumnHeader_1.Width = 236
        '
        '_lvGroepen_ColumnHeader_2
        '
        Me._lvGroepen_ColumnHeader_2.Text = "nummer"
        Me._lvGroepen_ColumnHeader_2.Width = 83
        '
        'lblMask4
        '
        Me.lblMask4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMask4.BackColor = System.Drawing.SystemColors.Control
        Me.lblMask4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMask4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMask4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMask4.Location = New System.Drawing.Point(379, 141)
        Me.lblMask4.Name = "lblMask4"
        Me.lblMask4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMask4.Size = New System.Drawing.Size(97, 21)
        Me.lblMask4.TabIndex = 22
        Me.lblMask4.Text = "dag uu:mm"
        '
        'lblMask3
        '
        Me.lblMask3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMask3.BackColor = System.Drawing.SystemColors.Control
        Me.lblMask3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMask3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMask3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMask3.Location = New System.Drawing.Point(379, 115)
        Me.lblMask3.Name = "lblMask3"
        Me.lblMask3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMask3.Size = New System.Drawing.Size(97, 21)
        Me.lblMask3.TabIndex = 21
        Me.lblMask3.Text = "dag uu:mm"
        '
        'lblMask2
        '
        Me.lblMask2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMask2.BackColor = System.Drawing.SystemColors.Control
        Me.lblMask2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMask2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMask2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMask2.Location = New System.Drawing.Point(379, 89)
        Me.lblMask2.Name = "lblMask2"
        Me.lblMask2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMask2.Size = New System.Drawing.Size(97, 21)
        Me.lblMask2.TabIndex = 20
        Me.lblMask2.Text = "dag uu:mm"
        '
        'lblMask1
        '
        Me.lblMask1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMask1.BackColor = System.Drawing.SystemColors.Control
        Me.lblMask1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMask1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMask1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMask1.Location = New System.Drawing.Point(379, 63)
        Me.lblMask1.Name = "lblMask1"
        Me.lblMask1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMask1.Size = New System.Drawing.Size(97, 21)
        Me.lblMask1.TabIndex = 19
        Me.lblMask1.Text = "dag uu:mm"
        '
        'lblDagEnTijd4
        '
        Me.lblDagEnTijd4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDagEnTijd4.BackColor = System.Drawing.SystemColors.Control
        Me.lblDagEnTijd4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDagEnTijd4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDagEnTijd4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDagEnTijd4.Location = New System.Drawing.Point(171, 141)
        Me.lblDagEnTijd4.Name = "lblDagEnTijd4"
        Me.lblDagEnTijd4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDagEnTijd4.Size = New System.Drawing.Size(75, 17)
        Me.lblDagEnTijd4.TabIndex = 12
        Me.lblDagEnTijd4.Text = "Dag en tijd 4"
        '
        'lblDagEnTijd3
        '
        Me.lblDagEnTijd3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDagEnTijd3.BackColor = System.Drawing.SystemColors.Control
        Me.lblDagEnTijd3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDagEnTijd3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDagEnTijd3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDagEnTijd3.Location = New System.Drawing.Point(171, 115)
        Me.lblDagEnTijd3.Name = "lblDagEnTijd3"
        Me.lblDagEnTijd3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDagEnTijd3.Size = New System.Drawing.Size(69, 13)
        Me.lblDagEnTijd3.TabIndex = 11
        Me.lblDagEnTijd3.Text = "Dag en tijd 3"
        '
        'lblDagEnTijd2
        '
        Me.lblDagEnTijd2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDagEnTijd2.BackColor = System.Drawing.SystemColors.Control
        Me.lblDagEnTijd2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDagEnTijd2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDagEnTijd2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDagEnTijd2.Location = New System.Drawing.Point(171, 89)
        Me.lblDagEnTijd2.Name = "lblDagEnTijd2"
        Me.lblDagEnTijd2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDagEnTijd2.Size = New System.Drawing.Size(73, 17)
        Me.lblDagEnTijd2.TabIndex = 10
        Me.lblDagEnTijd2.Text = "Dag en tijd 2"
        '
        'lblDagEnTijd1
        '
        Me.lblDagEnTijd1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDagEnTijd1.BackColor = System.Drawing.SystemColors.Control
        Me.lblDagEnTijd1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDagEnTijd1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDagEnTijd1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDagEnTijd1.Location = New System.Drawing.Point(171, 63)
        Me.lblDagEnTijd1.Name = "lblDagEnTijd1"
        Me.lblDagEnTijd1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDagEnTijd1.Size = New System.Drawing.Size(73, 17)
        Me.lblDagEnTijd1.TabIndex = 9
        Me.lblDagEnTijd1.Text = "Dag en tijd 1"
        '
        'lblDiploma
        '
        Me.lblDiploma.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDiploma.BackColor = System.Drawing.SystemColors.Control
        Me.lblDiploma.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDiploma.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiploma.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDiploma.Location = New System.Drawing.Point(171, 37)
        Me.lblDiploma.Name = "lblDiploma"
        Me.lblDiploma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDiploma.Size = New System.Drawing.Size(65, 17)
        Me.lblDiploma.TabIndex = 8
        Me.lblDiploma.Text = "Doel Diploma"
        '
        'lblNaam
        '
        Me.lblNaam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNaam.BackColor = System.Drawing.SystemColors.Control
        Me.lblNaam.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNaam.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaam.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNaam.Location = New System.Drawing.Point(171, 11)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNaam.Size = New System.Drawing.Size(57, 17)
        Me.lblNaam.TabIndex = 7
        Me.lblNaam.Text = "Naam"
        '
        'frmWijzigenGroepen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(483, 247)
        Me.Controls.Add(Me.frmInfo)
        Me.Controls.Add(Me.btnAfsluiten)
        Me.Controls.Add(Me.btnOpslaan)
        Me.Controls.Add(Me.btnVerwijderen)
        Me.Controls.Add(Me.txtDagEnTijd4)
        Me.Controls.Add(Me.txtDagEnTijd3)
        Me.Controls.Add(Me.txtDagEnTijd2)
        Me.Controls.Add(Me.txtDagEnTijd1)
        Me.Controls.Add(Me.txtDiploma)
        Me.Controls.Add(Me.txtNaam)
        Me.Controls.Add(Me.lvGroepen)
        Me.Controls.Add(Me.lblMask4)
        Me.Controls.Add(Me.lblMask3)
        Me.Controls.Add(Me.lblMask2)
        Me.Controls.Add(Me.lblMask1)
        Me.Controls.Add(Me.lblDagEnTijd4)
        Me.Controls.Add(Me.lblDagEnTijd3)
        Me.Controls.Add(Me.lblDagEnTijd2)
        Me.Controls.Add(Me.lblDagEnTijd1)
        Me.Controls.Add(Me.lblDiploma)
        Me.Controls.Add(Me.lblNaam)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(491, 281)
        Me.Name = "frmWijzigenGroepen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Wijzigen - Groepen"
        Me.frmInfo.ResumeLayout(False)
        Me.frmInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class