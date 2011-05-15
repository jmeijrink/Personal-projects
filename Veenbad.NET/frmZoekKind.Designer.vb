<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmZoekKind
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
	Public WithEvents btnWijzigen As System.Windows.Forms.Button
	Public WithEvents chkDeleted As System.Windows.Forms.CheckBox
	Public WithEvents btnClose As System.Windows.Forms.Button
	Public WithEvents _lvKinderen_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvKinderen_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvKinderen_ColumnHeader_3 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvKinderen_ColumnHeader_4 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvKinderen_ColumnHeader_5 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvKinderen_ColumnHeader_6 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvKinderen As System.Windows.Forms.ListView
	Public WithEvents btnZoek As System.Windows.Forms.Button
	Public WithEvents txtNaam As System.Windows.Forms.TextBox
	Public WithEvents lblNaam As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmZoekKind))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnWijzigen = New System.Windows.Forms.Button
        Me.chkDeleted = New System.Windows.Forms.CheckBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.lvKinderen = New System.Windows.Forms.ListView
        Me._lvKinderen_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me._lvKinderen_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
        Me._lvKinderen_ColumnHeader_3 = New System.Windows.Forms.ColumnHeader
        Me._lvKinderen_ColumnHeader_4 = New System.Windows.Forms.ColumnHeader
        Me._lvKinderen_ColumnHeader_5 = New System.Windows.Forms.ColumnHeader
        Me._lvKinderen_ColumnHeader_6 = New System.Windows.Forms.ColumnHeader
        Me.btnZoek = New System.Windows.Forms.Button
        Me.txtNaam = New System.Windows.Forms.TextBox
        Me.lblNaam = New System.Windows.Forms.Label
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'btnWijzigen
        '
        Me.btnWijzigen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnWijzigen.BackColor = System.Drawing.SystemColors.Control
        Me.btnWijzigen.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnWijzigen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWijzigen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnWijzigen.Location = New System.Drawing.Point(12, 279)
        Me.btnWijzigen.Name = "btnWijzigen"
        Me.btnWijzigen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnWijzigen.Size = New System.Drawing.Size(93, 21)
        Me.btnWijzigen.TabIndex = 6
        Me.btnWijzigen.Text = "&Wijzigen"
        Me.btnWijzigen.UseVisualStyleBackColor = False
        '
        'chkDeleted
        '
        Me.chkDeleted.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDeleted.AutoSize = True
        Me.chkDeleted.BackColor = System.Drawing.SystemColors.Control
        Me.chkDeleted.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDeleted.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDeleted.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDeleted.Location = New System.Drawing.Point(336, 8)
        Me.chkDeleted.Name = "chkDeleted"
        Me.chkDeleted.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDeleted.Size = New System.Drawing.Size(180, 18)
        Me.chkDeleted.TabIndex = 5
        Me.chkDeleted.Text = "Zoek door verwijderde kinderen"
        Me.chkDeleted.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(415, 279)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClose.Size = New System.Drawing.Size(101, 21)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Af&sluiten"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lvKinderen
        '
        Me.lvKinderen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvKinderen.BackColor = System.Drawing.SystemColors.Window
        Me.lvKinderen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvKinderen_ColumnHeader_1, Me._lvKinderen_ColumnHeader_2, Me._lvKinderen_ColumnHeader_3, Me._lvKinderen_ColumnHeader_4, Me._lvKinderen_ColumnHeader_5, Me._lvKinderen_ColumnHeader_6, Me.ColumnHeader1})
        Me.lvKinderen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvKinderen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvKinderen.FullRowSelect = True
        Me.lvKinderen.Location = New System.Drawing.Point(12, 33)
        Me.lvKinderen.Name = "lvKinderen"
        Me.lvKinderen.Size = New System.Drawing.Size(504, 240)
        Me.lvKinderen.TabIndex = 3
        Me.lvKinderen.UseCompatibleStateImageBehavior = False
        Me.lvKinderen.View = System.Windows.Forms.View.Details
        '
        '_lvKinderen_ColumnHeader_1
        '
        Me._lvKinderen_ColumnHeader_1.Text = "Nummer"
        Me._lvKinderen_ColumnHeader_1.Width = 74
        '
        '_lvKinderen_ColumnHeader_2
        '
        Me._lvKinderen_ColumnHeader_2.Text = "Naam"
        Me._lvKinderen_ColumnHeader_2.Width = 111
        '
        '_lvKinderen_ColumnHeader_3
        '
        Me._lvKinderen_ColumnHeader_3.Text = "Telefoonnummer"
        Me._lvKinderen_ColumnHeader_3.Width = 98
        '
        '_lvKinderen_ColumnHeader_4
        '
        Me._lvKinderen_ColumnHeader_4.Text = "Geb. Dat."
        Me._lvKinderen_ColumnHeader_4.Width = 67
        '
        '_lvKinderen_ColumnHeader_5
        '
        Me._lvKinderen_ColumnHeader_5.Text = "Ins. Dat."
        Me._lvKinderen_ColumnHeader_5.Width = 170
        '
        '_lvKinderen_ColumnHeader_6
        '
        Me._lvKinderen_ColumnHeader_6.Text = "Opmerking"
        Me._lvKinderen_ColumnHeader_6.Width = 170
        '
        'btnZoek
        '
        Me.btnZoek.BackColor = System.Drawing.SystemColors.Control
        Me.btnZoek.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnZoek.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZoek.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnZoek.Location = New System.Drawing.Point(234, 6)
        Me.btnZoek.Name = "btnZoek"
        Me.btnZoek.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnZoek.Size = New System.Drawing.Size(77, 21)
        Me.btnZoek.TabIndex = 2
        Me.btnZoek.Text = "&Zoeken"
        Me.btnZoek.UseVisualStyleBackColor = False
        '
        'txtNaam
        '
        Me.txtNaam.AcceptsReturn = True
        Me.txtNaam.BackColor = System.Drawing.SystemColors.Window
        Me.txtNaam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNaam.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNaam.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNaam.Location = New System.Drawing.Point(59, 6)
        Me.txtNaam.MaxLength = 0
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNaam.Size = New System.Drawing.Size(169, 20)
        Me.txtNaam.TabIndex = 1
        '
        'lblNaam
        '
        Me.lblNaam.BackColor = System.Drawing.SystemColors.Control
        Me.lblNaam.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNaam.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaam.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNaam.Location = New System.Drawing.Point(12, 9)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNaam.Size = New System.Drawing.Size(41, 17)
        Me.lblNaam.TabIndex = 0
        Me.lblNaam.Text = "Naam"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Verwijderd"
        '
        'frmZoekKind
        '
        Me.AcceptButton = Me.btnZoek
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(528, 308)
        Me.Controls.Add(Me.btnWijzigen)
        Me.Controls.Add(Me.chkDeleted)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lvKinderen)
        Me.Controls.Add(Me.btnZoek)
        Me.Controls.Add(Me.txtNaam)
        Me.Controls.Add(Me.lblNaam)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(520, 220)
        Me.Name = "frmZoekKind"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Zoeken - Kinderen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
#End Region 
End Class