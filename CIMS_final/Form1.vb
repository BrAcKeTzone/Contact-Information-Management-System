Imports MySql.Data.MySqlClient

Public Class Form1
    Public Sub ClearField()
        tbUser.Text = ""
        tbPass.Text = ""
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If connection() = True Then
            Try
                sqlCmd = New MySqlCommand("Select * from " + tb2 + " where username = '" + tbUser.Text + "' and password = '" + tbPass.Text + "' ", conn)
                sqlDR = sqlCmd.ExecuteReader
                Dim count = 0
                While sqlDR.Read
                    count = count + 1
                End While

                If count = 1 Then
                    MessageBox.Show("Logged in successfully!")
                    ClearField()
                    Form2.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("Logged in failed!")
                    ClearField()
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Database Query Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim a As Integer = MessageBox.Show("Are you sure do you want to close?", "Close Option!",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = vbYes Then
            Application.Exit()
        End If
    End Sub
End Class
