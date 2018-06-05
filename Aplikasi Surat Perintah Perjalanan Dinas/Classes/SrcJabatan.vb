Imports MySql.Data.MySqlClient
Public Class SrcJabatan
    Private FRS As FrSearch
    Private Ctrl As New CtrlForm
    Public Sub New(ByVal FRS As FrSearch)
        Me.FRS = FRS
    End Sub

    Private Function SearchjabatanByNama()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT * FROM jabatan WHERE nm_jab LIKE @value", Conn)
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
        dt.Columns(0).ColumnName = "Kode Jabatan"
        dt.Columns(1).ColumnName = "Nama Jabatan"
    End Sub

    Private Function SearchjabatanByKode()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT * FROM jabatan WHERE kd_jab LIKE @value", Conn)
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

    Public Sub Searchjabatan()
        If (SearchjabatanByKode() = False) Then
            If (SearchjabatanByNama() = False) Then
                FRS.DgvSearch.DataSource = Nothing
            End If
        End If
    End Sub
End Class
