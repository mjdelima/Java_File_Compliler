<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ckRemove = New System.Windows.Forms.CheckBox()
        Me.btnCompileOnly = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnCompileRun = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ckRemove
        '
        Me.ckRemove.AutoSize = True
        Me.ckRemove.Location = New System.Drawing.Point(24, 88)
        Me.ckRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.ckRemove.Name = "ckRemove"
        Me.ckRemove.Size = New System.Drawing.Size(153, 22)
        Me.ckRemove.TabIndex = 10
        Me.ckRemove.Text = "Remove Package?"
        Me.ckRemove.UseVisualStyleBackColor = True
        '
        'btnCompileOnly
        '
        Me.btnCompileOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompileOnly.Location = New System.Drawing.Point(26, 123)
        Me.btnCompileOnly.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btnCompileOnly.Name = "btnCompileOnly"
        Me.btnCompileOnly.Size = New System.Drawing.Size(180, 42)
        Me.btnCompileOnly.TabIndex = 9
        Me.btnCompileOnly.Text = "Compile"
        Me.btnCompileOnly.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.AllowDrop = True
        Me.TextBox1.Location = New System.Drawing.Point(24, 16)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(374, 61)
        Me.TextBox1.TabIndex = 8
        '
        'btnRun
        '
        Me.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRun.Location = New System.Drawing.Point(218, 123)
        Me.btnRun.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(180, 42)
        Me.btnRun.TabIndex = 7
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnCompileRun
        '
        Me.btnCompileRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompileRun.Location = New System.Drawing.Point(26, 179)
        Me.btnCompileRun.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btnCompileRun.Name = "btnCompileRun"
        Me.btnCompileRun.Size = New System.Drawing.Size(372, 42)
        Me.btnCompileRun.TabIndex = 6
        Me.btnCompileRun.Text = "Compile and Run"
        Me.btnCompileRun.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(429, 240)
        Me.Controls.Add(Me.ckRemove)
        Me.Controls.Add(Me.btnCompileOnly)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.btnCompileRun)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Java Compiler | Drag and Drop your class file"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ckRemove As CheckBox
    Friend WithEvents btnCompileOnly As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnRun As Button
    Friend WithEvents btnCompileRun As Button
End Class
