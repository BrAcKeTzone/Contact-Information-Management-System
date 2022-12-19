<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panel1.Controls.Add(Me.btnExit)
        Me.panel1.Controls.Add(Me.btnLogin)
        Me.panel1.Controls.Add(Me.tbPass)
        Me.panel1.Controls.Add(Me.tbUser)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Location = New System.Drawing.Point(12, 12)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(475, 487)
        Me.panel1.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(394, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 32)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(170, 282)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(126, 32)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'tbPass
        '
        Me.tbPass.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbPass.Location = New System.Drawing.Point(114, 223)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.Size = New System.Drawing.Size(240, 30)
        Me.tbPass.TabIndex = 2
        Me.tbPass.UseSystemPasswordChar = True
        '
        'tbUser
        '
        Me.tbUser.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbUser.Location = New System.Drawing.Point(114, 165)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(240, 30)
        Me.tbUser.TabIndex = 1
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(35, 39)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(404, 396)
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents btnLogin As Button
    Private WithEvents tbPass As TextBox
    Private WithEvents tbUser As TextBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnExit As Button
End Class
