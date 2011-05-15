<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintSettings
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtMultiplier = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtOffsetX = New System.Windows.Forms.TextBox
        Me.txtOffsetY = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMultiplier
        '
        Me.txtMultiplier.AcceptsReturn = True
        Me.txtMultiplier.BackColor = System.Drawing.SystemColors.Window
        Me.txtMultiplier.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMultiplier.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMultiplier.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMultiplier.Location = New System.Drawing.Point(90, 13)
        Me.txtMultiplier.MaxLength = 0
        Me.txtMultiplier.Name = "txtMultiplier"
        Me.txtMultiplier.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMultiplier.Size = New System.Drawing.Size(93, 20)
        Me.txtMultiplier.TabIndex = 22
        Me.txtMultiplier.Text = "1"
        Me.txtMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(69, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Multiplier"
        '
        'txtOffsetX
        '
        Me.txtOffsetX.AcceptsReturn = True
        Me.txtOffsetX.BackColor = System.Drawing.SystemColors.Window
        Me.txtOffsetX.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOffsetX.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffsetX.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOffsetX.Location = New System.Drawing.Point(90, 39)
        Me.txtOffsetX.MaxLength = 0
        Me.txtOffsetX.Name = "txtOffsetX"
        Me.txtOffsetX.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOffsetX.Size = New System.Drawing.Size(93, 20)
        Me.txtOffsetX.TabIndex = 18
        Me.txtOffsetX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOffsetY
        '
        Me.txtOffsetY.AcceptsReturn = True
        Me.txtOffsetY.BackColor = System.Drawing.SystemColors.Window
        Me.txtOffsetY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOffsetY.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffsetY.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOffsetY.Location = New System.Drawing.Point(90, 65)
        Me.txtOffsetY.MaxLength = 0
        Me.txtOffsetY.Name = "txtOffsetY"
        Me.txtOffsetY.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOffsetY.Size = New System.Drawing.Size(93, 20)
        Me.txtOffsetY.TabIndex = 17
        Me.txtOffsetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(6, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Offset X"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(6, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Offset Y"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtMultiplier)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtOffsetX)
        Me.GroupBox1.Controls.Add(Me.txtOffsetY)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 92)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'PrintSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PrintSettings"
        Me.Size = New System.Drawing.Size(208, 100)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents txtMultiplier As System.Windows.Forms.TextBox
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents txtOffsetX As System.Windows.Forms.TextBox
    Private WithEvents txtOffsetY As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
