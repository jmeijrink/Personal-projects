<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrintKids
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
	Public WithEvents tmrKlok As System.Windows.Forms.Timer
	Public WithEvents chkOpmWachtlijst As System.Windows.Forms.CheckBox
	Public WithEvents pbPrinting As System.Windows.Forms.ProgressBar
	Public WithEvents chkPrioriteit As System.Windows.Forms.CheckBox
	Public WithEvents btnClose As System.Windows.Forms.Button
	Public WithEvents btnPrint As System.Windows.Forms.Button
	Public WithEvents chkOpm As System.Windows.Forms.CheckBox
	Public WithEvents chkTelnr As System.Windows.Forms.CheckBox
	Public WithEvents chkInsDat As System.Windows.Forms.CheckBox
	Public WithEvents chkGebDat As System.Windows.Forms.CheckBox
	Public WithEvents chkNaam As System.Windows.Forms.CheckBox
	Public WithEvents txtTop As System.Windows.Forms.TextBox
	Public WithEvents _lvGroepen_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvGroepen_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvGroepen As System.Windows.Forms.ListView
	Public WithEvents lblCheckBox As System.Windows.Forms.Label
	Public WithEvents lblInfo As System.Windows.Forms.Label
	Public WithEvents lblTop As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintKids))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrKlok = New System.Windows.Forms.Timer(Me.components)
        Me.chkOpmWachtlijst = New System.Windows.Forms.CheckBox
        Me.pbPrinting = New System.Windows.Forms.ProgressBar
        Me.chkPrioriteit = New System.Windows.Forms.CheckBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.chkOpm = New System.Windows.Forms.CheckBox
        Me.chkTelnr = New System.Windows.Forms.CheckBox
        Me.chkInsDat = New System.Windows.Forms.CheckBox
        Me.chkGebDat = New System.Windows.Forms.CheckBox
        Me.chkNaam = New System.Windows.Forms.CheckBox
        Me.txtTop = New System.Windows.Forms.TextBox
        Me.lvGroepen = New System.Windows.Forms.ListView
        Me._lvGroepen_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me._lvGroepen_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
        Me.lblCheckBox = New System.Windows.Forms.Label
        Me.lblInfo = New System.Windows.Forms.Label
        Me.lblTop = New System.Windows.Forms.Label
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'tmrKlok
        '
        Me.tmrKlok.Enabled = True
        Me.tmrKlok.Interval = 2000
        '
        'chkOpmWachtlijst
        '
        Me.chkOpmWachtlijst.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkOpmWachtlijst.AutoSize = True
        Me.chkOpmWachtlijst.BackColor = System.Drawing.SystemColors.Control
        Me.chkOpmWachtlijst.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkOpmWachtlijst.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOpmWachtlijst.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkOpmWachtlijst.Location = New System.Drawing.Point(397, 193)
        Me.chkOpmWachtlijst.Name = "chkOpmWachtlijst"
        Me.chkOpmWachtlijst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkOpmWachtlijst.Size = New System.Drawing.Size(126, 18)
        Me.chkOpmWachtlijst.TabIndex = 13
        Me.chkOpmWachtlijst.Text = "Opmerking Wachtlijst"
        Me.chkOpmWachtlijst.UseVisualStyleBackColor = False
        '
        'pbPrinting
        '
        Me.pbPrinting.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbPrinting.Location = New System.Drawing.Point(8, 305)
        Me.pbPrinting.Name = "pbPrinting"
        Me.pbPrinting.Size = New System.Drawing.Size(510, 17)
        Me.pbPrinting.TabIndex = 12
        '
        'chkPrioriteit
        '
        Me.chkPrioriteit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPrioriteit.AutoSize = True
        Me.chkPrioriteit.BackColor = System.Drawing.SystemColors.Control
        Me.chkPrioriteit.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkPrioriteit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrioriteit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkPrioriteit.Location = New System.Drawing.Point(397, 73)
        Me.chkPrioriteit.Name = "chkPrioriteit"
        Me.chkPrioriteit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPrioriteit.Size = New System.Drawing.Size(64, 18)
        Me.chkPrioriteit.TabIndex = 11
        Me.chkPrioriteit.Text = "Prioriteit"
        Me.chkPrioriteit.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(429, 273)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClose.Size = New System.Drawing.Size(89, 25)
        Me.btnClose.TabIndex = 10
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
        Me.btnPrint.Location = New System.Drawing.Point(429, 242)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPrint.Size = New System.Drawing.Size(89, 25)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "&Afdrukken"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'chkOpm
        '
        Me.chkOpm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkOpm.AutoSize = True
        Me.chkOpm.BackColor = System.Drawing.SystemColors.Control
        Me.chkOpm.Checked = True
        Me.chkOpm.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOpm.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkOpm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOpm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkOpm.Location = New System.Drawing.Point(397, 169)
        Me.chkOpm.Name = "chkOpm"
        Me.chkOpm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkOpm.Size = New System.Drawing.Size(101, 18)
        Me.chkOpm.TabIndex = 8
        Me.chkOpm.Text = "&Opmerking Kind"
        Me.chkOpm.UseVisualStyleBackColor = False
        '
        'chkTelnr
        '
        Me.chkTelnr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTelnr.AutoSize = True
        Me.chkTelnr.BackColor = System.Drawing.SystemColors.Control
        Me.chkTelnr.Checked = True
        Me.chkTelnr.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTelnr.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkTelnr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTelnr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkTelnr.Location = New System.Drawing.Point(397, 145)
        Me.chkTelnr.Name = "chkTelnr"
        Me.chkTelnr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkTelnr.Size = New System.Drawing.Size(106, 18)
        Me.chkTelnr.TabIndex = 7
        Me.chkTelnr.Text = "&Telefoonnummer"
        Me.chkTelnr.UseVisualStyleBackColor = False
        '
        'chkInsDat
        '
        Me.chkInsDat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkInsDat.AutoSize = True
        Me.chkInsDat.BackColor = System.Drawing.SystemColors.Control
        Me.chkInsDat.Checked = True
        Me.chkInsDat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInsDat.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkInsDat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInsDat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkInsDat.Location = New System.Drawing.Point(397, 49)
        Me.chkInsDat.Name = "chkInsDat"
        Me.chkInsDat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkInsDat.Size = New System.Drawing.Size(97, 18)
        Me.chkInsDat.TabIndex = 6
        Me.chkInsDat.Text = "&Inschrijf Datum"
        Me.chkInsDat.UseVisualStyleBackColor = False
        '
        'chkGebDat
        '
        Me.chkGebDat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkGebDat.AutoSize = True
        Me.chkGebDat.BackColor = System.Drawing.SystemColors.Control
        Me.chkGebDat.Checked = True
        Me.chkGebDat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGebDat.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkGebDat.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGebDat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkGebDat.Location = New System.Drawing.Point(397, 121)
        Me.chkGebDat.Name = "chkGebDat"
        Me.chkGebDat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkGebDat.Size = New System.Drawing.Size(104, 18)
        Me.chkGebDat.TabIndex = 5
        Me.chkGebDat.Text = "&Geboorte Datum"
        Me.chkGebDat.UseVisualStyleBackColor = False
        '
        'chkNaam
        '
        Me.chkNaam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkNaam.AutoSize = True
        Me.chkNaam.BackColor = System.Drawing.SystemColors.Control
        Me.chkNaam.Checked = True
        Me.chkNaam.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNaam.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNaam.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNaam.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkNaam.Location = New System.Drawing.Point(397, 97)
        Me.chkNaam.Name = "chkNaam"
        Me.chkNaam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkNaam.Size = New System.Drawing.Size(53, 18)
        Me.chkNaam.TabIndex = 4
        Me.chkNaam.Text = "&Naam"
        Me.chkNaam.UseVisualStyleBackColor = False
        '
        'txtTop
        '
        Me.txtTop.AcceptsReturn = True
        Me.txtTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTop.BackColor = System.Drawing.SystemColors.Window
        Me.txtTop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTop.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTop.Location = New System.Drawing.Point(401, 23)
        Me.txtTop.MaxLength = 0
        Me.txtTop.Name = "txtTop"
        Me.txtTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTop.Size = New System.Drawing.Size(37, 20)
        Me.txtTop.TabIndex = 2
        Me.txtTop.Text = "0"
        '
        'lvGroepen
        '
        Me.lvGroepen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvGroepen.BackColor = System.Drawing.SystemColors.Window
        Me.lvGroepen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvGroepen_ColumnHeader_1, Me._lvGroepen_ColumnHeader_2, Me.ColumnHeader1})
        Me.lvGroepen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvGroepen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvGroepen.FullRowSelect = True
        Me.lvGroepen.HideSelection = False
        Me.lvGroepen.Location = New System.Drawing.Point(8, 8)
        Me.lvGroepen.Name = "lvGroepen"
        Me.lvGroepen.Size = New System.Drawing.Size(383, 290)
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
        Me._lvGroepen_ColumnHeader_2.Text = "Nummer"
        Me._lvGroepen_ColumnHeader_2.Width = 52
        '
        'lblCheckBox
        '
        Me.lblCheckBox.BackColor = System.Drawing.SystemColors.Control
        Me.lblCheckBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCheckBox.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckBox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCheckBox.Location = New System.Drawing.Point(116, 236)
        Me.lblCheckBox.Name = "lblCheckBox"
        Me.lblCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCheckBox.Size = New System.Drawing.Size(181, 17)
        Me.lblCheckBox.TabIndex = 14
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfo.BackColor = System.Drawing.SystemColors.Control
        Me.lblInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblInfo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblInfo.Location = New System.Drawing.Point(444, 26)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInfo.Size = New System.Drawing.Size(53, 17)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.Text = "0 = alles"
        '
        'lblTop
        '
        Me.lblTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTop.AutoSize = True
        Me.lblTop.BackColor = System.Drawing.SystemColors.Control
        Me.lblTop.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTop.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTop.Location = New System.Drawing.Point(398, 9)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTop.Size = New System.Drawing.Size(105, 14)
        Me.lblTop.TabIndex = 1
        Me.lblTop.Text = "Max Aantal kinderen"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Aantal kinderen"
        '
        'frmPrintKids
        '
        Me.AcceptButton = Me.btnPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(525, 327)
        Me.Controls.Add(Me.chkOpmWachtlijst)
        Me.Controls.Add(Me.pbPrinting)
        Me.Controls.Add(Me.chkPrioriteit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.chkOpm)
        Me.Controls.Add(Me.chkTelnr)
        Me.Controls.Add(Me.chkInsDat)
        Me.Controls.Add(Me.chkGebDat)
        Me.Controls.Add(Me.chkNaam)
        Me.Controls.Add(Me.txtTop)
        Me.Controls.Add(Me.lvGroepen)
        Me.Controls.Add(Me.lblCheckBox)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblTop)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximumSize = New System.Drawing.Size(584, 499)
        Me.MinimumSize = New System.Drawing.Size(341, 359)
        Me.Name = "frmPrintKids"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Afdrukken - Lijst Kinderen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
#End Region 
End Class