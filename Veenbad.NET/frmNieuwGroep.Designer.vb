<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmNieuwGroep
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
	Public WithEvents txtDagEnTijd4 As System.Windows.Forms.TextBox
	Public WithEvents txtDagEnTijd3 As System.Windows.Forms.TextBox
	Public WithEvents txtDagEnTijd2 As System.Windows.Forms.TextBox
	Public WithEvents txtDagEnTijd1 As System.Windows.Forms.TextBox
	Public WithEvents txtDiploma As System.Windows.Forms.TextBox
	Public WithEvents txtNummer As System.Windows.Forms.TextBox
	Public WithEvents txtNaam As System.Windows.Forms.TextBox
	Public WithEvents lblDagEnTijd4 As System.Windows.Forms.Label
	Public WithEvents lblDagEnTijd3 As System.Windows.Forms.Label
	Public WithEvents lblDagEnTijd2 As System.Windows.Forms.Label
	Public WithEvents lblDagEnTijd1 As System.Windows.Forms.Label
	Public WithEvents lblDiploma As System.Windows.Forms.Label
	Public WithEvents lblNummer As System.Windows.Forms.Label
	Public WithEvents lblNaam As System.Windows.Forms.Label
	Public WithEvents frmGroepen As System.Windows.Forms.GroupBox
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNieuwGroep))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDagEnTijd1 = New System.Windows.Forms.TextBox
        Me.txtDiploma = New System.Windows.Forms.TextBox
        Me.txtNaam = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.frmGroepen = New System.Windows.Forms.GroupBox
        Me.txtDagEnTijd4 = New System.Windows.Forms.TextBox
        Me.txtDagEnTijd3 = New System.Windows.Forms.TextBox
        Me.txtDagEnTijd2 = New System.Windows.Forms.TextBox
        Me.txtNummer = New System.Windows.Forms.TextBox
        Me.lblDagEnTijd4 = New System.Windows.Forms.Label
        Me.lblDagEnTijd3 = New System.Windows.Forms.Label
        Me.lblDagEnTijd2 = New System.Windows.Forms.Label
        Me.lblDagEnTijd1 = New System.Windows.Forms.Label
        Me.lblDiploma = New System.Windows.Forms.Label
        Me.lblNummer = New System.Windows.Forms.Label
        Me.lblNaam = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.frmGroepen.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDagEnTijd1
        '
        Me.txtDagEnTijd1.AcceptsReturn = True
        Me.txtDagEnTijd1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDagEnTijd1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDagEnTijd1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDagEnTijd1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDagEnTijd1.Location = New System.Drawing.Point(88, 100)
        Me.txtDagEnTijd1.MaxLength = 0
        Me.txtDagEnTijd1.Name = "txtDagEnTijd1"
        Me.txtDagEnTijd1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDagEnTijd1.Size = New System.Drawing.Size(117, 21)
        Me.txtDagEnTijd1.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtDagEnTijd1, "Verplicht veld")
        '
        'txtDiploma
        '
        Me.txtDiploma.AcceptsReturn = True
        Me.txtDiploma.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDiploma.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiploma.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiploma.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDiploma.Location = New System.Drawing.Point(88, 72)
        Me.txtDiploma.MaxLength = 0
        Me.txtDiploma.Name = "txtDiploma"
        Me.txtDiploma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiploma.Size = New System.Drawing.Size(117, 21)
        Me.txtDiploma.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtDiploma, "Verplicht veld")
        '
        'txtNaam
        '
        Me.txtNaam.AcceptsReturn = True
        Me.txtNaam.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNaam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNaam.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNaam.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNaam.Location = New System.Drawing.Point(88, 44)
        Me.txtNaam.MaxLength = 0
        Me.txtNaam.Name = "txtNaam"
        Me.txtNaam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNaam.Size = New System.Drawing.Size(117, 21)
        Me.txtNaam.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtNaam, "Verplicht veld")
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.Location = New System.Drawing.Point(124, 212)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSave.Size = New System.Drawing.Size(73, 25)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Opslaan"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.Control
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(204, 212)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnClose.Size = New System.Drawing.Size(81, 25)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Af&sluiten"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmGroepen
        '
        Me.frmGroepen.BackColor = System.Drawing.SystemColors.Control
        Me.frmGroepen.Controls.Add(Me.txtDagEnTijd4)
        Me.frmGroepen.Controls.Add(Me.txtDagEnTijd3)
        Me.frmGroepen.Controls.Add(Me.txtDagEnTijd2)
        Me.frmGroepen.Controls.Add(Me.txtDagEnTijd1)
        Me.frmGroepen.Controls.Add(Me.txtDiploma)
        Me.frmGroepen.Controls.Add(Me.txtNummer)
        Me.frmGroepen.Controls.Add(Me.txtNaam)
        Me.frmGroepen.Controls.Add(Me.lblDagEnTijd4)
        Me.frmGroepen.Controls.Add(Me.lblDagEnTijd3)
        Me.frmGroepen.Controls.Add(Me.lblDagEnTijd2)
        Me.frmGroepen.Controls.Add(Me.lblDagEnTijd1)
        Me.frmGroepen.Controls.Add(Me.lblDiploma)
        Me.frmGroepen.Controls.Add(Me.lblNummer)
        Me.frmGroepen.Controls.Add(Me.lblNaam)
        Me.frmGroepen.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmGroepen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmGroepen.Location = New System.Drawing.Point(4, 4)
        Me.frmGroepen.Name = "frmGroepen"
        Me.frmGroepen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmGroepen.Size = New System.Drawing.Size(217, 201)
        Me.frmGroepen.TabIndex = 0
        Me.frmGroepen.TabStop = False
        Me.frmGroepen.Text = "Gegevens"
        '
        'txtDagEnTijd4
        '
        Me.txtDagEnTijd4.AcceptsReturn = True
        Me.txtDagEnTijd4.BackColor = System.Drawing.SystemColors.Window
        Me.txtDagEnTijd4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDagEnTijd4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDagEnTijd4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDagEnTijd4.Location = New System.Drawing.Point(88, 172)
        Me.txtDagEnTijd4.MaxLength = 0
        Me.txtDagEnTijd4.Name = "txtDagEnTijd4"
        Me.txtDagEnTijd4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDagEnTijd4.Size = New System.Drawing.Size(117, 21)
        Me.txtDagEnTijd4.TabIndex = 7
        '
        'txtDagEnTijd3
        '
        Me.txtDagEnTijd3.AcceptsReturn = True
        Me.txtDagEnTijd3.BackColor = System.Drawing.SystemColors.Window
        Me.txtDagEnTijd3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDagEnTijd3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDagEnTijd3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDagEnTijd3.Location = New System.Drawing.Point(88, 148)
        Me.txtDagEnTijd3.MaxLength = 0
        Me.txtDagEnTijd3.Name = "txtDagEnTijd3"
        Me.txtDagEnTijd3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDagEnTijd3.Size = New System.Drawing.Size(117, 21)
        Me.txtDagEnTijd3.TabIndex = 6
        '
        'txtDagEnTijd2
        '
        Me.txtDagEnTijd2.AcceptsReturn = True
        Me.txtDagEnTijd2.BackColor = System.Drawing.SystemColors.Window
        Me.txtDagEnTijd2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDagEnTijd2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDagEnTijd2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDagEnTijd2.Location = New System.Drawing.Point(88, 124)
        Me.txtDagEnTijd2.MaxLength = 0
        Me.txtDagEnTijd2.Name = "txtDagEnTijd2"
        Me.txtDagEnTijd2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDagEnTijd2.Size = New System.Drawing.Size(117, 21)
        Me.txtDagEnTijd2.TabIndex = 5
        '
        'txtNummer
        '
        Me.txtNummer.AcceptsReturn = True
        Me.txtNummer.BackColor = System.Drawing.SystemColors.Window
        Me.txtNummer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNummer.Enabled = False
        Me.txtNummer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNummer.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNummer.Location = New System.Drawing.Point(88, 16)
        Me.txtNummer.MaxLength = 0
        Me.txtNummer.Name = "txtNummer"
        Me.txtNummer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNummer.Size = New System.Drawing.Size(117, 21)
        Me.txtNummer.TabIndex = 1
        '
        'lblDagEnTijd4
        '
        Me.lblDagEnTijd4.BackColor = System.Drawing.SystemColors.Control
        Me.lblDagEnTijd4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDagEnTijd4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDagEnTijd4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDagEnTijd4.Location = New System.Drawing.Point(12, 176)
        Me.lblDagEnTijd4.Name = "lblDagEnTijd4"
        Me.lblDagEnTijd4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDagEnTijd4.Size = New System.Drawing.Size(65, 13)
        Me.lblDagEnTijd4.TabIndex = 16
        Me.lblDagEnTijd4.Text = "Dag en tijd 4"
        '
        'lblDagEnTijd3
        '
        Me.lblDagEnTijd3.BackColor = System.Drawing.SystemColors.Control
        Me.lblDagEnTijd3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDagEnTijd3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDagEnTijd3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDagEnTijd3.Location = New System.Drawing.Point(12, 152)
        Me.lblDagEnTijd3.Name = "lblDagEnTijd3"
        Me.lblDagEnTijd3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDagEnTijd3.Size = New System.Drawing.Size(65, 13)
        Me.lblDagEnTijd3.TabIndex = 15
        Me.lblDagEnTijd3.Text = "Dag en tijd 3"
        '
        'lblDagEnTijd2
        '
        Me.lblDagEnTijd2.BackColor = System.Drawing.SystemColors.Control
        Me.lblDagEnTijd2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDagEnTijd2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDagEnTijd2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDagEnTijd2.Location = New System.Drawing.Point(12, 128)
        Me.lblDagEnTijd2.Name = "lblDagEnTijd2"
        Me.lblDagEnTijd2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDagEnTijd2.Size = New System.Drawing.Size(65, 13)
        Me.lblDagEnTijd2.TabIndex = 14
        Me.lblDagEnTijd2.Text = "Dag en tijd 2"
        '
        'lblDagEnTijd1
        '
        Me.lblDagEnTijd1.BackColor = System.Drawing.SystemColors.Control
        Me.lblDagEnTijd1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDagEnTijd1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDagEnTijd1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDagEnTijd1.Location = New System.Drawing.Point(12, 104)
        Me.lblDagEnTijd1.Name = "lblDagEnTijd1"
        Me.lblDagEnTijd1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDagEnTijd1.Size = New System.Drawing.Size(65, 13)
        Me.lblDagEnTijd1.TabIndex = 13
        Me.lblDagEnTijd1.Text = "Dag en tijd 1"
        '
        'lblDiploma
        '
        Me.lblDiploma.BackColor = System.Drawing.SystemColors.Control
        Me.lblDiploma.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDiploma.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiploma.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDiploma.Location = New System.Drawing.Point(12, 76)
        Me.lblDiploma.Name = "lblDiploma"
        Me.lblDiploma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDiploma.Size = New System.Drawing.Size(69, 17)
        Me.lblDiploma.TabIndex = 12
        Me.lblDiploma.Text = "Doel diploma"
        '
        'lblNummer
        '
        Me.lblNummer.BackColor = System.Drawing.SystemColors.Control
        Me.lblNummer.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNummer.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNummer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNummer.Location = New System.Drawing.Point(12, 20)
        Me.lblNummer.Name = "lblNummer"
        Me.lblNummer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNummer.Size = New System.Drawing.Size(53, 17)
        Me.lblNummer.TabIndex = 11
        Me.lblNummer.Text = "Nummer"
        '
        'lblNaam
        '
        Me.lblNaam.BackColor = System.Drawing.SystemColors.Control
        Me.lblNaam.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNaam.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaam.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNaam.Location = New System.Drawing.Point(12, 48)
        Me.lblNaam.Name = "lblNaam"
        Me.lblNaam.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNaam.Size = New System.Drawing.Size(41, 17)
        Me.lblNaam.TabIndex = 10
        Me.lblNaam.Text = "Naam"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(224, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "dddd uu:mm"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(224, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "dddd uu:mm"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(224, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "dddd uu:mm"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(224, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "dddd uu:mm"
        '
        'frmNieuwGroep
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(289, 244)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.frmGroepen)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(295, 276)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(295, 276)
        Me.Name = "frmNieuwGroep"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Groepen - Nieuw"
        Me.frmGroepen.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class