Imports MySql.Data.MySqlClient

Module DatabaseModule

    Public Conn As MySqlConnection
    Public Cmd As MySqlCommand
    Public Ds As DataSet
    Public Da As New MySqlDataAdapter
    Public Rdr As MySqlDataReader
    Private Ctrl As New CtrlForm

    Public Sub OpenConnection()
        Conn = New MySqlConnection("server=localhost; userid=root; database=sppdinas")
        Try
            Conn.Open()
        Catch ex As Exception
            Ctrl.ShowMessageOK("Error!, " & ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CloseConnection()
        Try
            Conn.Close()
        Catch ex As Exception
            Ctrl.ShowMessageOK("Error!, " & ex.Message, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function ExecSQL(ByVal query As String) As Boolean
        OpenConnection()
        Try
            Cmd = New MySqlCommand(query, Conn)
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Ctrl.ShowMessageOK("Error!, " & ex.Message, MessageBoxIcon.Error)
            Return False
        Finally
            CloseConnection()
            Cmd.Dispose()
        End Try
    End Function

    'Public Function FetchData(ByVal query As String, ByVal table As String, ByVal grid As DataGridView) As Boolean
    '    OpenConnection()
    '    Ds = New DataSet
    '    Try
    '        Cmd = New MySqlCommand(query, Conn)
    '        Da.SelectCommand = Cmd
    '        Da.Fill(Ds, table)

    '        grid.DataSource = Ds.Tables(table)
    '        grid.TopLeftHeaderCell.Value = "No."
    '        grid.TopLeftHeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

    '        For i As Integer = 0 To grid.Rows.Count - 1
    '            grid.Rows(i).HeaderCell.Value = (i + 1).ToString()
    '            grid.Rows(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '            grid.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders)
    '        Next

    '        Return True
    '    Catch ex As Exception
    '        Ctrl.ShowMessageOK("Error!, " & ex.Message, MessageBoxIcon.Error)
    '        Return False
    '    Finally
    '        CloseConnection()
    '        Ds.Dispose()
    '        Da.Dispose()
    '        Cmd.Dispose()
    '    End Try
    'End Function

    Public Function AutoNumber(ByVal query As String, ByVal id As String, ByVal prefix As String, ByVal numindex As Integer)
        OpenConnection()
        Try
            Cmd = New MySqlCommand(query, Conn)
            Rdr = Cmd.ExecuteReader()
            Rdr.Read()

            If (Not Rdr.HasRows) Then
                Return prefix + "0001"
            Else
                Dim Stringnumeric As String = Rdr.Item(id).ToString.Substring(numindex, 4)
                Dim numeric As Integer = Stringnumeric + 1
                Return prefix + numeric.ToString("d4")
            End If
        Catch ex As Exception
            Ctrl.ShowMessageOK("Error!, " & ex.Message, MessageBoxIcon.Error)
            Return False
        Finally
            CloseConnection()
            Rdr.Close()
            Cmd.Dispose()
        End Try
    End Function

End Module
