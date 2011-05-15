<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrintDiplomas
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
    Public WithEvents pbPrinten As System.Windows.Forms.ProgressBar
    Public ComDialOpen As System.Windows.Forms.OpenFileDialog
	Public ComDialSave As System.Windows.Forms.SaveFileDialog
	Public ComDialFont As System.Windows.Forms.FontDialog
	Public ComDialColor As System.Windows.Forms.ColorDialog
	Public ComDialPrint As System.Windows.Forms.PrintDialog
	Public WithEvents btnDesAll As System.Windows.Forms.Button
	Public WithEvents btnSelAll As System.Windows.Forms.Button
	Public WithEvents _lvKinderen_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvKinderen_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvKinderen As System.Windows.Forms.ListView
	Public WithEvents btnClose As System.Windows.Forms.Button
	Public WithEvents btnPrint As System.Windows.Forms.Button
	Public WithEvents _lvGroepen_ColumnHeader_1 As System.Windows.Forms.ColumnHeader
	Public WithEvents _lvGroepen_ColumnHeader_2 As System.Windows.Forms.ColumnHeader
	Public WithEvents lvGroepen As System.Windows.Forms.ListView
	Public WithEvents lblAantal As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintDiplomas))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbPrinten = New System.Windows.Forms.ProgressBar
        Me.ComDialOpen = New System.Windows.Forms.OpenFileDialog
        Me.ComDialSave = New System.Windows.Forms.SaveFileDialog
        Me.ComDialFont = New System.Windows.Forms.FontDialog
        Me.ComDialColor = New System.Windows.Forms.ColorDialog
        Me.ComDialPrint = New System.Windows.Forms.PrintDialog
        Me.btnDesAll = New System.Windows.Forms.Button
        Me.btnSelAll = New System.Windows.Forms.Button
        Me.lvKinderen = New System.Windows.Forms.ListView
        Me._lvKinderen_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me._lvKinderen_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.lvGroepen = New System.Windows.Forms.ListView
        Me._lvGroepen_ColumnHeader_1 = New System.Windows.Forms.ColumnHeader
        Me._lvGroepen_ColumnHeader_2 = New System.Windows.Forms.ColumnHeader
        Me.lblAantal = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAfzDat = New System.Windows.Forms.DateTimePicker
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.cmbDiploma = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbPrinten
        '
        Me.pbPrinten.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbPrinten.Location = New System.Drawing.Point(4, 319)
        Me.pbPrinten.Name = "pbPrinten"
        Me.pbPrinten.Size = New System.Drawing.Size(460, 17)
        Me.pbPrinten.TabIndex = 9
        '
        'btnDesAll
        '
        Me.btnDesAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDesAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnDesAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDesAll.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDesAll.Location = New System.Drawing.Point(355, 84)
        Me.btnDesAll.Name = "btnDesAll"
        Me.btnDesAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDesAll.Size = New System.Drawing.Size(105, 37)
        Me.btnDesAll.TabIndex = 6
        Me.btnDesAll.Text = "Alles &Deselecteren"
        Me.btnDesAll.UseVisualStyleBackColor = False
        '
        'btnSelAll
        '
        Me.btnSelAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelAll.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelAll.Location = New System.Drawing.Point(355, 44)
        Me.btnSelAll.Name = "btnSelAll"
        Me.btnSelAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSelAll.Size = New System.Drawing.Size(105, 34)
        Me.btnSelAll.TabIndex = 5
        Me.btnSelAll.Text = "Alles &Selecteren"
        Me.btnSelAll.UseVisualStyleBackColor = False
        '
        'lvKinderen
        '
        Me.lvKinderen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvKinderen.BackColor = System.Drawing.SystemColors.Window
        Me.lvKinderen.CheckBoxes = True
        Me.lvKinderen.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me._lvKinderen_ColumnHeader_1, Me._lvKinderen_ColumnHeader_2})
        Me.lvKinderen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvKinderen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvKinderen.FullRowSelect = True
        Me.lvKinderen.HideSelection = False
        Me.lvKinderen.LabelEdit = True
        Me.lvKinderen.Location = New System.Drawing.Point(3, 3)
        Me.lvKinderen.Name = "lvKinderen"
        Me.lvKinderen.Size = New System.Drawing.Size(164, 237)
        Me.lvKinderen.TabIndex = 4
        Me.lvKinderen.UseCompatibleStateImageBehavior = False
        Me.lvKinderen.View = System.Windows.Forms.View.Details
        '
        '_lvKinderen_ColumnHeader_1
        '
        Me._lvKinderen_ColumnHeader_1.Text = "Naam"
        Me._lvKinderen_ColumnHeader_1.Width = 200
        '
        '_lvKinderen_ColumnHeader_2
        '
        Me._lvKinderen_ColumnHeader_2.Text = "Nummer"
        Me._lvKinderen_ColumnHeader_2.Width = 59
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(379, 291)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClose.Size = New System.Drawing.Size(81, 25)
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
        Me.btnPrint.Location = New System.Drawing.Point(291, 291)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPrint.Size = New System.Drawing.Size(81, 25)
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
        Me.lvGroepen.Location = New System.Drawing.Point(5, 4)
        Me.lvGroepen.Name = "lvGroepen"
        Me.lvGroepen.Size = New System.Drawing.Size(160, 236)
        Me.lvGroepen.TabIndex = 1
        Me.lvGroepen.UseCompatibleStateImageBehavior = False
        Me.lvGroepen.View = System.Windows.Forms.View.Details
        '
        '_lvGroepen_ColumnHeader_1
        '
        Me._lvGroepen_ColumnHeader_1.Text = "Naam"
        Me._lvGroepen_ColumnHeader_1.Width = 200
        '
        '_lvGroepen_ColumnHeader_2
        '
        Me._lvGroepen_ColumnHeader_2.Text = "Nummer"
        Me._lvGroepen_ColumnHeader_2.Width = 59
        '
        'lblAantal
        '
        Me.lblAantal.BackColor = System.Drawing.SystemColors.Control
        Me.lblAantal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAantal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAantal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAantal.Location = New System.Drawing.Point(368, 104)
        Me.lblAantal.Name = "lblAantal"
        Me.lblAantal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAantal.Size = New System.Drawing.Size(93, 17)
        Me.lblAantal.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(153, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selecteer de groep waarvan u de diploma's wilt afdrukken"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 14)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Afzwemdatum"
        '
        'txtAfzDat
        '
        Me.txtAfzDat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAfzDat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtAfzDat.Location = New System.Drawing.Point(88, 292)
        Me.txtAfzDat.Name = "txtAfzDat"
        Me.txtAfzDat.Size = New System.Drawing.Size(81, 20)
        Me.txtAfzDat.TabIndex = 19
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(7, 40)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lvGroepen)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lvKinderen)
        Me.SplitContainer1.Size = New System.Drawing.Size(342, 244)
        Me.SplitContainer1.SplitterDistance = 168
        Me.SplitContainer1.TabIndex = 20
        '
        'cmbDiploma
        '
        Me.cmbDiploma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDiploma.FormattingEnabled = True
        Me.cmbDiploma.Items.AddRange(New Object() {"Diploma A", "Diploma B", "Diploma C"})
        Me.cmbDiploma.Location = New System.Drawing.Point(229, 15)
        Me.cmbDiploma.Name = "cmbDiploma"
        Me.cmbDiploma.Size = New System.Drawing.Size(121, 22)
        Me.cmbDiploma.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 14)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Diploma"
        '
        'frmPrintDiplomas
        '
        Me.AcceptButton = Me.btnPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(467, 340)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbDiploma)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.txtAfzDat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbPrinten)
        Me.Controls.Add(Me.btnDesAll)
        Me.Controls.Add(Me.btnSelAll)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblAantal)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(473, 372)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(473, 372)
        Me.Name = "frmPrintDiplomas"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Print - Diploma's"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAfzDat As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmbDiploma As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
#End Region 
End Class