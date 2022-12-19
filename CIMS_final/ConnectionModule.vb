Imports MySql.Data.MySqlClient

Module module_Connection
    Friend result As Boolean
    Friend sqlDS As DataSet
    Friend sqlDA As MySqlDataAdapter
    Friend conn As MySqlConnection
    Friend sqlDR As MySqlDataReader
    Friend sqlCmd As MySqlCommand
    Friend strConn As String
    ''' - - - DATABASE CREDENTIALS - - - '''
    Friend dbhost = "localhost"
    Friend dbuser = "JP"
    Friend dbpass = "Maniwskie"
    Friend dbname = "contact_info_ms"
    Friend dbport = "3306"
    ' ' ' - - LIST OF TABLES - - ' ' '
    Friend tb As String = "profile"
    Friend tb2 As String = "account"


    Public Function connection() As Boolean
        Try
            conn = New MySqlConnection
            If conn.State = ConnectionState.Open Then conn.Close()
            strConn = "SERVER=" + dbhost + "; USERNAME=" + dbuser + ";PASSWORD=" + dbpass + ";DATABASE=" + dbname + ";PORT=" + dbport + ";"
            conn.ConnectionString = strConn
            conn.Open()
            result = True
        Catch ex As MySqlException
            result = False
            MessageBox.Show(ex.Message, "Database Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return result
    End Function

End Module
