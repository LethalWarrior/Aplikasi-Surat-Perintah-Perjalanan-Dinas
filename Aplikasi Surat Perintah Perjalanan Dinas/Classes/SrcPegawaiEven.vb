Imports MySql.Data.MySqlClient

Public Class SrcPegawaiEven
    Private FRS As FrSearch
    Private Ctrl As New CtrlForm

    Public Sub New(ByVal FRS As FrSearch)
        Me.FRS = FRS
    End Sub

    Private Function SearchpegawaiByNama(ByVal kode As String)
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT pegawai.kd_pegawai, pegawai.nama, jabatan.nm_jab FROM pegawai JOIN jabatan ON pegawai.kd_jab = jabatan.kd_jab WHERE pegawai.kd_divisi=@divisi AND pegawai.nama LIKE @value", Conn)
            Cmd.Parameters.AddWithValue("@value", "%" & FRS.TbxSearch.Text & "%")
            Cmd.Parameters.AddWithValue("@divisi", kode)
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
        dt.Columns(0).ColumnName = "Kode pegawai"
        dt.Columns(1).ColumnName = "Nama pegawai"
        dt.Columns(2).ColumnName = "Jabatan"
    End Sub

    Private Function SearchpegawaiByKode(ByVal kode As String)
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT pegawai.kd_pegawai, pegawai.nama, jabatan.nm_jab FROM pegawai JOIN jabatan ON pegawai.kd_jab = jabatan.kd_jab WHERE pegawai.kd_divisi=@divisi AND pegawai.kd_pegawai LIKE @value", Conn)
            Cmd.Parameters.AddWithValue("@value", "%" & FRS.TbxSearch.Text & "%")
            Cmd.Parameters.AddWithValue("@divisi", kode)
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

    Private Function SearchpegawaiByJabatan(ByVal kode As String)
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT pegawai.kd_pegawai, pegawai.nama, jabatan.nm_jab FROM pegawai JOIN jabatan ON pegawai.kd_jab = jabatan.kd_jab WHERE pegawai.kd_divisi=@divisi AND jabatan.nm_jab LIKE @value", Conn)
            Cmd.Parameters.AddWithValue("@value", "%" & FRS.TbxSearch.Text & "%")
            Cmd.Parameters.AddWithValue("@divisi", kode)
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

    Public Sub Searchpegawai(ByVal kode As String)
        If (SearchpegawaiByKode(kode) = False) Then
            If (SearchpegawaiByNama(kode) = False) Then
                If (SearchpegawaiByJabatan(kode) = False) Then
                    FRS.DgvSearch.DataSource = Nothing
                End If
            End If
        End If
    End Sub

End Class
