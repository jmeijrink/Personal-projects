<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrinterInstellingen
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
    Public WithEvents btnCancel As System.Windows.Forms.Button
	Public WithEvents btnOpslaan As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOpslaan = New System.Windows.Forms.Button
        Me.prtSetDPC = New HetVeenbad.PrintSettings
        Me.prtSetDPB = New HetVeenbad.PrintSettings
        Me.prtSetDPA = New HetVeenbad.PrintSettings
        Me.prtSetPL = New HetVeenbad.PrintSettings
        Me.prtSetLK = New HetVeenbad.PrintSettings
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Location = New System.Drawing.Point(349, 319)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCancel.Size = New System.Drawing.Size(81, 25)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Annuleren"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOpslaan
        '
        Me.btnOpslaan.BackColor = System.Drawing.SystemColors.Control
        Me.btnOpslaan.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnOpslaan.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpslaan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOpslaan.Location = New System.Drawing.Point(264, 319)
        Me.btnOpslaan.Name = "btnOpslaan"
        Me.btnOpslaan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnOpslaan.Size = New System.Drawing.Size(81, 25)
        Me.btnOpslaan.TabIndex = 0
        Me.btnOpslaan.Text = "Opslaan"
        Me.btnOpslaan.UseVisualStyleBackColor = False
        '
        'prtSetDPC
        '
        Me.prtSetDPC.DocumentType = HetVeenbad.PrintSettings.PrintType.DiplomaC
        Me.prtSetDPC.Location = New System.Drawing.Point(12, 241)
        Me.prtSetDPC.Name = "prtSetDPC"
        Me.prtSetDPC.Size = New System.Drawing.Size(208, 109)
        Me.prtSetDPC.TabIndex = 6
        '
        'prtSetDPB
        '
        Me.prtSetDPB.DocumentType = HetVeenbad.PrintSettings.PrintType.DiplomaB
        Me.prtSetDPB.Location = New System.Drawing.Point(12, 127)
        Me.prtSetDPB.Name = "prtSetDPB"
        Me.prtSetDPB.Size = New System.Drawing.Size(208, 117)
        Me.prtSetDPB.TabIndex = 5
        '
        'prtSetDPA
        '
        Me.prtSetDPA.DocumentType = HetVeenbad.PrintSettings.PrintType.DiplomaA
        Me.prtSetDPA.Location = New System.Drawing.Point(12, 12)
        Me.prtSetDPA.Name = "prtSetDPA"
        Me.prtSetDPA.Size = New System.Drawing.Size(208, 109)
        Me.prtSetDPA.TabIndex = 4
        '
        'prtSetPL
        '
        Me.prtSetPL.DocumentType = HetVeenbad.PrintSettings.PrintType.PresentieLijst
        Me.prtSetPL.Location = New System.Drawing.Point(226, 127)
        Me.prtSetPL.Name = "prtSetPL"
        Me.prtSetPL.Size = New System.Drawing.Size(208, 108)
        Me.prtSetPL.TabIndex = 3
        '
        'prtSetLK
        '
        Me.prtSetLK.DocumentType = HetVeenbad.PrintSettings.PrintType.GroepLijst
        Me.prtSetLK.Location = New System.Drawing.Point(226, 12)
        Me.prtSetLK.Name = "prtSetLK"
        Me.prtSetLK.Size = New System.Drawing.Size(211, 109)
        Me.prtSetLK.TabIndex = 2
        '
        'frmPrinterInstellingen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(438, 350)
        Me.Controls.Add(Me.prtSetDPC)
        Me.Controls.Add(Me.prtSetDPB)
        Me.Controls.Add(Me.prtSetDPA)
        Me.Controls.Add(Me.prtSetPL)
        Me.Controls.Add(Me.prtSetLK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOpslaan)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(444, 382)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(444, 382)
        Me.Name = "frmPrinterInstellingen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Printer instellingen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents prtSetLK As HetVeenbad.PrintSettings
    Friend WithEvents prtSetPL As HetVeenbad.PrintSettings
    Friend WithEvents prtSetDPA As HetVeenbad.PrintSettings
    Friend WithEvents prtSetDPB As HetVeenbad.PrintSettings
    Friend WithEvents prtSetDPC As HetVeenbad.PrintSettings
#End Region
End Class