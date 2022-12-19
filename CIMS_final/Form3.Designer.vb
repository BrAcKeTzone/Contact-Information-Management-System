<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbChangeUser = New System.Windows.Forms.TextBox()
        Me.tbChangePass = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.tbChangePassConfirm = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.Location = New System.Drawing.Point(169, 288)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(110, 30)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-5, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 81)
        Me.Panel1.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change your USERNAME and PASSWORD"
        '
        'tbChangeUser
        '
        Me.tbChangeUser.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbChangeUser.Location = New System.Drawing.Point(29, 135)
        Me.tbChangeUser.Name = "tbChangeUser"
        Me.tbChangeUser.Size = New System.Drawing.Size(250, 30)
        Me.tbChangeUser.TabIndex = 31
        '
        'tbChangePass
        '
        Me.tbChangePass.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbChangePass.Location = New System.Drawing.Point(29, 185)
        Me.tbChangePass.Name = "tbChangePass"
        Me.tbChangePass.Size = New System.Drawing.Size(250, 30)
        Me.tbChangePass.TabIndex = 32
        Me.tbChangePass.UseSystemPasswordChar = True
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSubmit.Location = New System.Drawing.Point(29, 288)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(110, 30)
        Me.btnSubmit.TabIndex = 33
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'tbChangePassConfirm
        '
        Me.tbChangePassConfirm.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbChangePassConfirm.Location = New System.Drawing.Point(29, 236)
        Me.tbChangePassConfirm.Name = "tbChangePassConfirm"
        Me.tbChangePassConfirm.Size = New System.Drawing.Size(250, 30)
        Me.tbChangePassConfirm.TabIndex = 34
        Me.tbChangePassConfirm.UseSystemPasswordChar = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbChangePassConfirm)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.tbChangePass)
        Me.Controls.Add(Me.tbChangeUser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form3"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents tbChangeUser As TextBox
    Friend WithEvents tbChangePass As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents tbChangePassConfirm As TextBox
End Class
