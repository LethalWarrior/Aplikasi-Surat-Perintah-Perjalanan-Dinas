Imports MySql.Data.MySqlClient
Public Class SrcJenis_Pembiayaan
    Private FRS As FrSearch
    Private Ctrl As New CtrlForm
    Public Sub New(ByVal FRS As FrSearch)
        Me.FRS = FRS
    End Sub

    Private Function Searchjenis_pembiayaanByNama()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT * FROM jenis_pembiayaan WHERE nm_jnspembiayaan LIKE @value", Conn)
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
        dt.Columns(0).ColumnName = "Kode Jenis Pembiayaan"
        dt.Columns(1).ColumnName = "Nama JenisPembiayaan"
    End Sub

    Private Function Searchjenis_pembiayaanByKode()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT * FROM jenis_pembiayaan WHERE kd_jnspembiayaan LIKE @value", Conn)
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

    Public Sub Searchjenis_pembiayaan()
        If (Searchjenis_pembiayaanByKode() = False) Then
            If (Searchjenis_pembiayaanByNama() = False) Then
                FRS.DgvSearch.DataSource = Nothing
            End If
        End If
    End Sub
End Class
