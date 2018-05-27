Imports MySql.Data.MySqlClient

Public Class CtrlBeritaAcaraUndanganKegiatan

    Private FBAUK As FrEntriBeritaAcaraUndanganKegiatan
    Private Ctrl As New CtrlForm

    Public Sub New(ByVal FBAUK As FrEntriBeritaAcaraUndanganKegiatan)
        Me.FBAUK = FBAUK
    End Sub

    Public Function GetAutoNumber()
        Return AutoNumber("SELECT no_bauk FROM bauk ORDER BY no_bauk DESC LIMIT 1", "no_bauk", "BAUK", 3)
    End Function

    Public Function Input()
        Try
            OpenConnection()
            Using Cmd As New MySqlCommand("INSERT INTO bauk(no_bauk, tgl_bauk, isi_acara, tgl_acara, jam_acara, tempat, kd_penyelenggara) VALUES (@no_bauk, @tgl_bauk, @isi_acara, @tgl_acara, @jam_acara, @kd_penyelenggara)", Conn)
                Cmd.Parameters.AddWithValue("@no_bauk", FBAUK.TbxKodeBAUK.Text)
                Cmd.Parameters.Add("@tgl_bauk", MySqlDbType.DateTime).Value = FBAUK.DtpBAUK.Value
                Cmd.Parameters.AddWithValue("@isi_acara", FBAUK.TbxIsiKegiatan.Text)
                Cmd.Parameters.Add("@tgl_acara", MySqlDbType.Date).Value = FBAUK.DtpTanggalPelaksanaan.Value.Date
                Cmd.Parameters.Add("@jam_acara", MySqlDbType.Time).Value = FBAUK.DtpWaktuPelaksanaan.Value
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

    Public Function CariPenyelenggara()
        OpenConnection()
        Try
            Dim Query As String = "SELECT * FROM penyelenggara WHERE kd_penyelenggara='" & FBAUK.GetSelectedKode & "'"
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

End Class
