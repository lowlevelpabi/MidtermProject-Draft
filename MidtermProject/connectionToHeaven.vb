Imports MySqlConnector

Public Class connectionToHeaven

    Private connection As New MySqlConnection("server=localhost;port=;Connection Timeout=30;user id=root;password=;database=alterdb")


    ' return the connection
    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return connection
        End Get
    End Property

    ' open the connection
    Sub openConnection()

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

    End Sub

    ' close the connection
    Sub closeConnection()

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

    End Sub

End Class