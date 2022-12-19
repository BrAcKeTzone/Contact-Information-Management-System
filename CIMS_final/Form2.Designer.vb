<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbDesc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tbEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPhone = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.tbSearchBar = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.contacts = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.contacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(144, 400)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(73, 24)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(123, 2)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contact Details"
        '
        'tbDesc
        '
        Me.tbDesc.Location = New System.Drawing.Point(135, 273)
        Me.tbDesc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbDesc.Name = "tbDesc"
        Me.tbDesc.Size = New System.Drawing.Size(223, 23)
        Me.tbDesc.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Description"
        '
        'cbGender
        '
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Male", "Female", "LGBTQ+"})
        Me.cbGender.Location = New System.Drawing.Point(135, 244)
        Me.cbGender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(223, 23)
        Me.cbGender.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Gender"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(222, 400)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(73, 24)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(0, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(476, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contact Information Management System"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Wide Latin", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label9.Location = New System.Drawing.Point(122, 92)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(112, 24)
        Me.label9.TabIndex = 14
        Me.label9.Text = "CIMS"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(108, 35)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(158, 151)
        Me.pictureBox1.TabIndex = 13
        Me.pictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.btnChange)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1226, 50)
        Me.Panel1.TabIndex = 23
        '
        'btnChange
        '
        Me.btnChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChange.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnChange.Location = New System.Drawing.Point(995, 9)
        Me.btnChange.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(110, 30)
        Me.btnChange.TabIndex = 29
        Me.btnChange.Text = "Account"
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Location = New System.Drawing.Point(1111, 9)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(110, 30)
        Me.btnLogout.TabIndex = 28
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(68, 400)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 24)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tbEmail
        '
        Me.tbEmail.Location = New System.Drawing.Point(135, 331)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.Size = New System.Drawing.Size(223, 23)
        Me.tbEmail.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Phone Number"
        '
        'tbAddress
        '
        Me.tbAddress.Location = New System.Drawing.Point(135, 304)
        Me.tbAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(223, 23)
        Me.tbAddress.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Email Address"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(135, 216)
        Me.tbName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(223, 23)
        Me.tbName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Name"
        '
        'tbPhone
        '
        Me.tbPhone.Location = New System.Drawing.Point(135, 359)
        Me.tbPhone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbPhone.Name = "tbPhone"
        Me.tbPhone.Size = New System.Drawing.Size(223, 23)
        Me.tbPhone.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.label9)
        Me.Panel2.Controls.Add(Me.pictureBox1)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.tbDesc)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.cbGender)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.tbPhone)
        Me.Panel2.Controls.Add(Me.tbEmail)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.tbAddress)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.tbName)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(0, 53)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(372, 445)
        Me.Panel2.TabIndex = 25
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.btnShowAll)
        Me.Panel3.Location = New System.Drawing.Point(378, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(573, 33)
        Me.Panel3.TabIndex = 26
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(492, 3)
        Me.btnShowAll.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(73, 24)
        Me.btnShowAll.TabIndex = 35
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'tbSearchBar
        '
        Me.tbSearchBar.Location = New System.Drawing.Point(378, 56)
        Me.tbSearchBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbSearchBar.Name = "tbSearchBar"
        Me.tbSearchBar.Size = New System.Drawing.Size(407, 23)
        Me.tbSearchBar.TabIndex = 33
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(1111, 55)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(114, 24)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "Delete Selected"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'contacts
        '
        Me.contacts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.contacts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.contacts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.contacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.contacts.Location = New System.Drawing.Point(378, 84)
        Me.contacts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.contacts.Name = "contacts"
        Me.contacts.ReadOnly = True
        Me.contacts.RowHeadersWidth = 51
        Me.contacts.RowTemplate.Height = 29
        Me.contacts.Size = New System.Drawing.Size(848, 416)
        Me.contacts.TabIndex = 37
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(791, 56)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(73, 24)
        Me.btnSearch.TabIndex = 34
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 500)
        Me.Controls.Add(Me.tbSearchBar)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.contacts)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.contacts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbDesc As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Private WithEvents label9 As Label
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents tbEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbPhone As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnChange As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnShowAll As Button
    Friend WithEvents tbSearchBar As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents contacts As DataGridView
    Friend WithEvents btnSearch As Button
End Class
