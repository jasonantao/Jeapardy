<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_menu))
        Me.cmd_start = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmd_instructions = New System.Windows.Forms.Button()
        Me.cmd_quitmenu = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_start
        '
        Me.cmd_start.BackColor = System.Drawing.Color.Red
        Me.cmd_start.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_start.Location = New System.Drawing.Point(274, 384)
        Me.cmd_start.Name = "cmd_start"
        Me.cmd_start.Size = New System.Drawing.Size(166, 40)
        Me.cmd_start.TabIndex = 0
        Me.cmd_start.Text = "Play Jeopardy!"
        Me.cmd_start.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(120, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(483, 282)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'cmd_instructions
        '
        Me.cmd_instructions.BackColor = System.Drawing.Color.Yellow
        Me.cmd_instructions.Location = New System.Drawing.Point(314, 430)
        Me.cmd_instructions.Name = "cmd_instructions"
        Me.cmd_instructions.Size = New System.Drawing.Size(75, 23)
        Me.cmd_instructions.TabIndex = 2
        Me.cmd_instructions.Text = "Instructions"
        Me.cmd_instructions.UseVisualStyleBackColor = False
        '
        'cmd_quitmenu
        '
        Me.cmd_quitmenu.BackColor = System.Drawing.Color.Fuchsia
        Me.cmd_quitmenu.Location = New System.Drawing.Point(660, 487)
        Me.cmd_quitmenu.Name = "cmd_quitmenu"
        Me.cmd_quitmenu.Size = New System.Drawing.Size(75, 23)
        Me.cmd_quitmenu.TabIndex = 3
        Me.cmd_quitmenu.Text = "QUIT"
        Me.cmd_quitmenu.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 353)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sourcecode : Jason Antao"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aqua
        Me.Button1.Location = New System.Drawing.Point(9, 486)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Acknowledgments"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'form_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Chrysanthemum
        Me.ClientSize = New System.Drawing.Size(747, 518)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmd_quitmenu)
        Me.Controls.Add(Me.cmd_instructions)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmd_start)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_menu"
        Me.Text = "Jeopardy"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_start As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_instructions As System.Windows.Forms.Button
    Friend WithEvents cmd_quitmenu As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
