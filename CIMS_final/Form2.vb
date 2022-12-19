Imports MySql.Data.MySqlClient

Public Class Form2
    Public Sub display_data_to_datagrid()
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tb + "", conn)
                sqlDA = New MySqlDataAdapter(sqlCmd)
                sqlDS = New DataSet
                sqlDA.Fill(sqlDS, tb)
                contacts.DataSource = sqlDS.Tables(tb)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on Query!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
        btnUpdate.Enabled = False
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Public Sub Clear_Data()
        tbName.Clear()
        cbGender.SelectedIndex = -1
        tbDesc.Clear()
        tbAddress.Clear()
        tbEmail.Clear()
        tbPhone.Clear()
        display_data_to_datagrid()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MessageBox.Show("Save Contact?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If (tbName.Text.Length > 0) And (cbGender.SelectedIndex > -1) And (tbDesc.Text.Length > 0) And (tbAddress.Text.Length > 0) And (tbAddress.Text.Length > 0) And (tbEmail.Text.Length > 0) And (tbPhone.Text.Length > 0) Then
                If (tbPhone.Text.Length = 11) Then
                    If connection() = True Then
                        Try
                            Dim saveCommand As New MySqlCommand("INSERT INTO " + tb + " (name, gender, description, address, email_address, phone_number) " +
                                " VALUES (@name, @gender, @description, @address, @email_address, @phone_number)", conn)
                            With saveCommand.Parameters
                                .AddWithValue("@name", tbName.Text)
                                .AddWithValue("@gender", cbGender.Text)
                                .AddWithValue("@description", tbDesc.Text)
                                .AddWithValue("@address", tbAddress.Text)
                                .AddWithValue("@email_address", tbEmail.Text)
                                .AddWithValue("@phone_number", tbPhone.Text)
                            End With
                            saveCommand.ExecuteNonQuery()
                            MessageBox.Show("Contact information successfully save!", "Successfully saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Clear_Data()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                    If conn.State = ConnectionState.Open Then conn.Close()
                Else
                    MessageBox.Show("Invalid Phone Number", "Saving Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("All fields are required", "Saving Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub tbnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If MessageBox.Show("Save Contact?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If (tbName.Text.Length > 0) And (cbGender.SelectedIndex > -1) And (tbDesc.Text.Length > 0) And (tbAddress.Text.Length > 0) And (tbAddress.Text.Length > 0) And (tbEmail.Text.Length > 0) And (tbPhone.Text.Length > 0) Then
                If (tbPhone.Text.Length = 11) Then
                    If connection() = True Then
                        Try
                            Dim updateCommand As New MySqlCommand("UPDATE " + tb + " SET gender = @gender, description = @description, address = @address, email_address = @email_address, phone_number = @phone_number WHERE name = @name", conn)
                            With updateCommand.Parameters
                                .AddWithValue("@name", tbName.Text)
                                .AddWithValue("@gender", cbGender.Text)
                                .AddWithValue("@description", tbDesc.Text)
                                .AddWithValue("@address", tbAddress.Text)
                                .AddWithValue("@email_address", tbEmail.Text)
                                .AddWithValue("@phone_number", tbPhone.Text)
                            End With
                            updateCommand.ExecuteNonQuery()
                            MessageBox.Show("Contact updated succesfully!", "Update saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Clear_Data()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                    If conn.State = ConnectionState.Open Then conn.Close()
                Else
                    MessageBox.Show("Invalid Phone Number", "Saving Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If

            End If
        display_data_to_datagrid()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear_Data()
        btnSave.Enabled = True
        tbName.Enabled = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If connection() = True Then
            Try
                Dim dbSearch = tbSearchBar.Text
                sqlCmd = New MySqlCommand("SELECT * fROM " + tb + " WHERE name LIKE '%" + dbSearch + "%'  OR gender LIKE '%" + dbSearch + "%' OR address LIKE '%" + dbSearch + "%'    OR phone_number LIKE '%" + dbSearch + "%' ", conn)
                sqlDA = New MySqlDataAdapter(sqlCmd)
                sqlDS = New DataSet
                sqlDA.Fill(sqlDS, tb)
                contacts.DataSource = sqlDS.Tables(tb)

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        tbSearchBar.Clear()
        display_data_to_datagrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ans As Integer = MessageBox.Show("Are you sure you want to delete selected Data?", "Delete selected Data?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            If connection() = True Then
                Try
                    sqlCmd = New MySqlCommand("DELETE FROM " & tb & " WHERE phone_number = '" & tbPhone.Text & "' ", conn)
                    sqlDR = sqlCmd.ExecuteReader

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
            If conn.State = ConnectionState.Open Then conn.Close()
            display_data_to_datagrid()
        End If
    End Sub

    Private Sub contacts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles contacts.CellClick
        Dim index As Integer
        index = e.RowIndex
        If (index > -1) Then
            Dim selectedrow As DataGridViewRow
            selectedrow = contacts.Rows(index)
            tbName.Text = selectedrow.Cells(0).Value.ToString()
            cbGender.Text = selectedrow.Cells(1).Value.ToString()
            tbDesc.Text = selectedrow.Cells(2).Value.ToString()
            tbAddress.Text = selectedrow.Cells(3).Value.ToString()
            tbEmail.Text = selectedrow.Cells(4).Value.ToString()
            tbPhone.Text = selectedrow.Cells(5).Value.ToString()

            btnUpdate.Enabled = True
            btnSave.Enabled = False
            tbName.Enabled = False

        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_data_to_datagrid()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim a As Integer = MessageBox.Show("Are you sure do you want to logout?", "Logout Option!",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = vbYes Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Form3.Show()
    End Sub
End Class