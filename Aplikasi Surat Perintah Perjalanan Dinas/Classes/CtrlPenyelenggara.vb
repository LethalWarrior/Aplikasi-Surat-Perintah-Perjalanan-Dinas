Imports MySql.Data.MySqlClient
Public Class CtrlPenyelenggara
    Private Fpenyelenggara As FrEntriDataPenyelenggara
    Private Ctrl As New CtrlForm
    Public Sub New(ByVal Fpenyelenggara As FrEntriDataPenyelenggara)
        Me.Fpenyelenggara = Fpenyelenggara
    End Sub

    Public Function GetAutoNumber()
        Return AutoNumber("SELECT kd_penyelenggara FROM penyelenggara ORDER BY kd_penyelenggara DESC LIMIT 1", "kd_penyelenggara", "PY", 2)
    End Function

    Public Sub Input()
        If (ExecSQL("INSERT INTO penyelenggara(kd_penyelenggara, nm_penyelenggara,alamat,tlp) VALUES('" & Fpenyelenggara.TbxKodepenyelenggara.Text & "','" & Fpenyelenggara.TbxNamapenyelenggara.Text & "','" & Fpenyelenggara.TbxAlamat.Text & "','" & Fpenyelenggara.TbxTlp.Text & "')")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub Ubah()
        If (ExecSQL("UPDATE penyelenggara SET kd_penyelenggara='" & Fpenyelenggara.TbxNamapenyelenggara.Text & "' ,nm_penyelenggara='" & Fpenyelenggara.TbxNamapenyelenggara.Text & "',alamat='" & Fpenyelenggara.TbxAlamat.Text & "',tlp='" & Fpenyelenggara.TbxTlp.Text & "' WHERE kd_penyelenggara='" & Fpenyelenggara.TbxKodepenyelenggara.Text & "'")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub Hapus()
        If (ExecSQL("DELETE FROM penyelenggara WHERE kd_penyelenggara='" & Fpenyelenggara.TbxKodepenyelenggara.Text & "'")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Function Cari()
        OpenConnection()
        Try
            Dim Query As String = "SELECT * FROM penyelenggara WHERE kd_penyelenggara='" & Fpenyelenggara.GetSelectedKode & "'"
            Cmd = New MySqlCommand(Query, Conn)
            Rdr = Cmd.ExecuteReader()
            Rdr.Read()
            If (Rdr.HasRows()) Then
                Fpenyelenggara.TbxKodePenyelenggara.Text = Rdr.Item("kd_penyelenggara").ToString()
                Fpenyelenggara.TbxNamaPenyelenggara.Text = Rdr.Item("nm_penyelenggara").ToString()
                Fpenyelenggara.TbxAlamat.Text = Rdr.Item("alamat").ToString()
                Fpenyelenggara.TbxTlp.Text = Rdr.Item("tlp").ToString()
                Fpenyelenggara.StateCari()
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
