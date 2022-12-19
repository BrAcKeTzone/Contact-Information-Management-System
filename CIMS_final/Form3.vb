Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tb2 + "", conn)
                sqlDA = New MySqlDataAdapter(sqlCmd)
                sqlDR = sqlCmd.ExecuteReader
                If sqlDR.HasRows Then
                    sqlDR.Read()
                    tbChangeUser.Text = sqlDR.GetValue(1).ToString()
                    tbChangePass.Text = sqlDR.GetValue(2).ToString()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on Query!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim a As Integer = MessageBox.Show("Are you sure do you want to Cancel?", "Cancel Option!",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = vbYes Then
            Close()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim a As Integer = MessageBox.Show("Are you sure do you want to Update Account?", "Update Option!",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (tbChangeUser.Text.Length > 0) And (tbChangePass.Text.Length > 0) Then
            If a = vbYes Then
                If tbChangePass.Text = tbChangePassConfirm.Text Then
                    If connection() = True Then
                        Try
                            Dim updateCommand As New MySqlCommand("UPDATE " + tb2 + " SET username = @username, password = @password", conn)
                            With updateCommand.Parameters
                                .AddWithValue("@username", tbChangeUser.Text)
                                .AddWithValue("@password", tbChangePass.Text)
                            End With
                            updateCommand.ExecuteNonQuery()
                            MessageBox.Show("Account updated succesfully!", "Update saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Close()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                Else
                    MessageBox.Show("Password don't match", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("Fields must not be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub
End Class