Imports MySql.Data.MySqlClient
Public Class CtrlPegawai
    Private Fpegawai As FrEntriDataPegawai
    Private Ctrl As New CtrlForm

    Public Sub New(ByVal Fpegawai As FrEntriDataPegawai)
        Me.Fpegawai = Fpegawai
    End Sub

    Public Function GetAutoNumber()
        Return AutoNumber("SELECT kd_pegawai FROM pegawai ORDER BY kd_pegawai DESC LIMIT 1", "kd_pegawai", "P", 1)
    End Function

    Public Sub Input()
        If (ExecSQL("INSERT INTO pegawai(kd_pegawai, nama, kd_gol, kd_divisi, kd_jab, tlp, alamat, email) VALUES('" & Fpegawai.TbxKodePegawai.Text & "','" & Fpegawai.TbxNamaPegawai.Text & "','" & Fpegawai.CbxGol.SelectedItem & "','" & Fpegawai.CbxDivisi.SelectedItem & "','" & Fpegawai.CbxJabatan.SelectedItem & "','" & Fpegawai.TbxTlp.Text & "','" & Fpegawai.TbxAlamat.Text & "','" & Fpegawai.TbxEmail.Text & "')")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub Ubah()
        If (ExecSQL("UPDATE pegawai SET nama='" & Fpegawai.TbxNamaPegawai.Text & "' ,kd_gol='" & Fpegawai.CbxGol.SelectedItem & "',kd_divisi='" & Fpegawai.CbxDivisi.SelectedItem & "',kd_jab='" & Fpegawai.CbxJabatan.SelectedItem & "',tlp='" & Fpegawai.TbxTlp.Text & "',alamat='" & Fpegawai.TbxAlamat.Text & "',email='" & Fpegawai.TbxEmail.Text & "' WHERE kd_pegawai='" & Fpegawai.TbxKodePegawai.Text & "'")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub Hapus()
        If (ExecSQL("DELETE FROM pegawai WHERE kd_pegawai='" & Fpegawai.TbxKodePegawai.Text & "'")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Function Cari()
        OpenConnection()
        Try
            Dim Query As String = "SELECT * FROM pegawai WHERE kd_pegawai='" & Fpegawai.GetSelectedKode & "'"
            Cmd = New MySqlCommand(Query, Conn)
            Rdr = Cmd.ExecuteReader()
            Rdr.Read()
            If (Rdr.HasRows()) Then
                Fpegawai.TbxKodePegawai.Text = Rdr.Item("kd_pegawai").ToString()
                Fpegawai.TbxNamaPegawai.Text = Rdr.Item("nama").ToString()
                Fpegawai.CbxGol.SelectedItem = Rdr.Item("kd_gol").ToString()
                Fpegawai.CbxJabatan.SelectedItem = Rdr.Item("kd_jab")
                Fpegawai.CbxDivisi.SelectedItem = Rdr.Item("kd_divisi")
                Fpegawai.TbxAlamat.Text = Rdr.Item("alamat").ToString()
                Fpegawai.TbxTlp.Text = Rdr.Item("tlp").ToString()
                Fpegawai.TbxEmail.Text = Rdr.Item("email").ToString()
                Fpegawai.StateCari()
            Else
                Return False
            End If
        Catch ex As Exception
            Ctrl.ShowMessageOK("Error!, " & ex.Message, MessageBoxIcon.Error)
            Return False
        Finally
            CloseConnection()
            Cmd.Dispose()
            Rdr.Close()
        End Try
        Return True
    End Function
End Class
