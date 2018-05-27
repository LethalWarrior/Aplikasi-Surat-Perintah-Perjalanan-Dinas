Imports MySql.Data.MySqlClient

Public Class CtrlBeritaAcaraUndanganKegiatan

    Private FBAUK As FrEntriBeritaAcaraUndanganKegiatan
    Private Ctrl As New CtrlForm

    Public Sub New(ByVal FBAUK As FrEntriBeritaAcaraUndanganKegiatan)
        Me.FBAUK = FBAUK
    End Sub

    Public Function GetAutoNumber()
        Return AutoNumber("SELECT no_bauk FROM bauk ORDER BY no_bauk DESC LIMIT 1", "no_bauk", "BAUK", 4)
    End Function

    Public Function Input()
        Try
            OpenConnection()
            Using Cmd As New MySqlCommand("INSERT INTO bauk(no_bauk, tgl_bauk, isi_acara, tgl_acara, waktu_acara, tempat, kd_penyelenggara) VALUES (@no_bauk, @tgl_bauk, @isi_acara, @tgl_acara, @waktu_acara, @tempat, @kd_penyelenggara)", Conn)
                Cmd.Parameters.AddWithValue("@no_bauk", FBAUK.TbxKodeBAUK.Text)
                Cmd.Parameters.Add("@tgl_bauk", MySqlDbType.DateTime).Value = FBAUK.DtpBAUK.Value
                Cmd.Parameters.AddWithValue("@isi_acara", FBAUK.TbxIsiKegiatan.Text)
                Cmd.Parameters.Add("@tgl_acara", MySqlDbType.Date).Value = FBAUK.DtpTanggalPelaksanaan.Value.Date
                Cmd.Parameters.AddWithValue("@waktu_acara", FBAUK.DtpWaktuPelaksanaan.Value.ToString("HH:mm"))
                Cmd.Parameters.AddWithValue("@tempat", FBAUK.TbxTempatPelaksanaan.Text)
                Cmd.Parameters.AddWithValue("@kd_penyelenggara", FBAUK.TbxKodePenyelenggara.Text)
                Cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Ctrl.ShowMessageOK("Error! " & ex.Message, MessageBoxIcon.Error)
            Return False
        Finally
            CloseConnection()
            Cmd.Dispose()
        End Try
        Return True
    End Function

    Public Function Ubah()
        Try
            OpenConnection()
            Using Cmd As New MySqlCommand("UPDATE bauk SET isi_acara=@isi_acara, tgl_acara=@tgl_acara, waktu_acara=@waktu_acara, tempat=@tempat, kd_penyelenggara=@kd_penyelenggara " + _
                                          "WHERE no_bauk=@no_bauk", Conn)
                Cmd.Parameters.AddWithValue("@no_bauk", FBAUK.TbxKodeBAUK.Text)
                Cmd.Parameters.AddWithValue("@isi_acara", FBAUK.TbxIsiKegiatan.Text)
                Cmd.Parameters.Add("@tgl_acara", MySqlDbType.Date).Value = FBAUK.DtpTanggalPelaksanaan.Value.Date
                Cmd.Parameters.AddWithValue("@waktu_acara", FBAUK.DtpWaktuPelaksanaan.Value.ToString("HH:mm"))
                Cmd.Parameters.AddWithValue("@tempat", FBAUK.TbxTempatPelaksanaan.Text)
                Cmd.Parameters.AddWithValue("@kd_penyelenggara", FBAUK.TbxKodePenyelenggara.Text)
                Cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Ctrl.ShowMessageOK("Error! " & ex.Message, MessageBoxIcon.Error)
            Return False
        Finally
            CloseConnection()
            Cmd.Dispose()
        End Try
        Return True
    End Function

    Public Sub Hapus()
        If (ExecSQL("DELETE FROM bauk WHERE no_bauk='" & FBAUK.TbxKodeBAUK.Text & "'")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Function CariPenyelenggara(ByVal kode As String)
        OpenConnection()
        Try
            Dim Query As String = "SELECT * FROM penyelenggara WHERE kd_penyelenggara='" & kode & "'"
            Cmd = New MySqlCommand(Query, Conn)
            Rdr = Cmd.ExecuteReader()
            Rdr.Read()
            If (Rdr.HasRows()) Then
                FBAUK.TbxKodePenyelenggara.Text = Rdr.Item("kd_penyelenggara").ToString()
                FBAUK.TbxNamaPenyelenggara.Text = Rdr.Item("nm_penyelenggara").ToString()
            Else
                Return False
            End If
        Catch ex As Exception
            Ctrl.ShowMessageOK("Error!, " & ex.Message, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Public Function CariBAUK(ByVal kode As String)
        OpenConnection()
        Try
            Dim Query As String = "SELECT * FROM bauk WHERE no_bauk='" & kode & "'"
            Cmd = New MySqlCommand(Query, Conn)
            Rdr = Cmd.ExecuteReader()
            Rdr.Read()
            If (Rdr.HasRows()) Then
                FBAUK.TbxKodeBAUK.Text = Rdr.Item("no_bauk").ToString()
                FBAUK.DtpBAUK.Value = Rdr.Item("tgl_bauk")
                FBAUK.TbxKodePenyelenggara.Text = Rdr.Item("kd_penyelenggara").ToString()
                FBAUK.DtpTanggalPelaksanaan.Value = Rdr.Item("tgl_acara")
                FBAUK.DtpWaktuPelaksanaan.Value = CDate(Date.Now.Date.ToString("dd/MM/yyyy") + " " + Rdr.Item("waktu_acara").ToString())
                FBAUK.TbxTempatPelaksanaan.Text = Rdr.Item("tempat").ToString()
                FBAUK.TbxIsiKegiatan.Text = Rdr.Item("isi_acara").ToString()
                FBAUK.StateCari()
                CariPenyelenggara(FBAUK.TbxKodePenyelenggara.Text)
            Else
                Return False
            End If
        Catch ex As Exception
            Ctrl.ShowMessageOK("Error!, " & ex.Message, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

End Class
