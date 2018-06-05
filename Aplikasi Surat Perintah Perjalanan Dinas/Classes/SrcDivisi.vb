Imports MySql.Data.MySqlClient
Public Class SrcDivisi
    Private FRS As FrSearch
    Private Ctrl As New CtrlForm
    Public Sub New(ByVal FRS As FrSearch)
        Me.FRS = FRS
    End Sub

    Private Function SearchdivisiByNama()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT * FROM divisi WHERE nm_divisi LIKE @value", Conn)
            Cmd.Parameters.AddWithValue("@value", "%" & FRS.TbxSearch.Text & "%")
            Try
                Rdr = Cmd.ExecuteReader
                Rdr.Read()
                If (Rdr.HasRows()) Then
                    Rdr.Close()
                    Da.SelectCommand = Cmd
                    Dim dt = New DataTable()
                    Da.Fill(dt)
                    ChangeColname(dt)
                    FRS.DgvSearch.DataSource = dt
                    Return True
                End If
            Catch ex As Exception
                Ctrl.ShowMessageOK("Error! " & ex.Message, MessageBoxIcon.Error)
            Finally
                CloseConnection()
            End Try
        End Using
        Return False
    End Function

    Private Sub ChangeColname(ByVal dt As DataTable)
        dt.Columns(0).ColumnName = "Kode Divisi"
        dt.Columns(1).ColumnName = "Nama Divisi"
    End Sub

    Private Function SearchdivisiByKode()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT * FROM divisi WHERE kd_divisi LIKE @value", Conn)
            Cmd.Parameters.AddWithValue("@value", "%" & FRS.TbxSearch.Text & "%")
            Try
                Rdr = Cmd.ExecuteReader
                Rdr.Read()
                If (Rdr.HasRows()) Then
                    Rdr.Close()
                    Da.SelectCommand = Cmd
                    Dim dt = New DataTable
                    Da.Fill(dt)
                    ChangeColname(dt)
                    FRS.DgvSearch.DataSource = dt
                    Return True
                End If
            Catch ex As Exception
                Ctrl.ShowMessageOK("Error! " & ex.Message, MessageBoxIcon.Error)
            Finally
                CloseConnection()
            End Try
        End Using
        Return False
    End Function

    Public Sub Searchdivisi()
        If (SearchdivisiByKode() = False) Then
            If (SearchdivisiByNama() = False) Then
                FRS.DgvSearch.DataSource = Nothing
            End If
        End If
    End Sub
End Class
