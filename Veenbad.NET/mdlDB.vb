Module mdlDB
    Public dbConn As OleDb.OleDbConnection

    Function dbOpenConn() As Boolean
        Try
            dbConn = _
                New OleDb.OleDbConnection( _
                    "Data Source=" & System.Configuration.ConfigurationManager.AppSettings("mdbPath") & ";" & _
                    "Provider=Microsoft.Jet.OLEDB.4.0;")
            dbConn.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & vbCrLf & ex.StackTrace)
            Return False
        End Try
    End Function

    Sub dbOpenRS( _
        ByRef dt As DataTable, _
        ByRef sql As String)

        Dim cmd As New OleDb.OleDbCommand(sql)
        dbOpenRS(dt, cmd)
    End Sub

    Sub dbOpenRS( _
        ByRef dt As DataTable, _
        ByVal cmd As OleDb.OleDbCommand)

        cmd.Connection = dbConn
        Dim da As New OleDb.OleDbDataAdapter(cmd)
        Dim ds As New DataSet()
        da.Fill(ds)
        dt = ds.Tables(0)
    End Sub

    Sub dbOpenRS( _
        ByRef dr As DataRow, _
        ByVal cmd As OleDb.OleDbCommand)

        Dim dt As DataTable = Nothing
        dbOpenRS(dt, cmd)

        dr = Nothing
        If (dt.Rows.Count > 0) Then dr = dt.Rows(0)
    End Sub

    Sub dbOpenRS( _
        ByRef dr As DataRow, _
        ByVal sql As String)

        Dim dt As DataTable = Nothing
        dbOpenRS(dt, sql)

        dr = Nothing
        If (dt.Rows.Count > 0) Then dr = dt.Rows(0)
    End Sub

    Sub dbCloseConn()
        On Error Resume Next
        dbConn.Close()
    End Sub

    Sub dbExecSQL( _
        ByRef sql As String, _
        Optional ByRef affectedRecords As Integer = 0)

        Dim cmd As New OleDb.OleDbCommand(sql)
        dbExecSQL(cmd, affectedRecords)
    End Sub

    Sub dbExecSQL( _
        ByRef cmd As OleDb.OleDbCommand, _
        Optional ByRef affectedRecords As Integer = 0)

        cmd.Connection = dbConn
        affectedRecords = cmd.ExecuteNonQuery()
    End Sub

    Function SQLEncode(ByRef sValue As String) As String
        SQLEncode = Replace(sValue, "'", "''")
    End Function

    Function SQLLikeEncode(ByRef S As String) As String
        SQLLikeEncode = Replace(Replace(Replace(S, "'", "''"), "?", "_"), "*", "%")
    End Function

    Function DbGetCommand() As OleDb.OleDbCommand
        Dim cmd As New OleDb.OleDbCommand()
        cmd.Connection = dbConn
        Return cmd
    End Function
End Module