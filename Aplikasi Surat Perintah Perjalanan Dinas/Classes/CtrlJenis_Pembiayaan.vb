Imports MySql.Data.MySqlClient
Public Class CtrlJenis_Pembiayaan
    Private Fjenis_pembiayaan As FrEntriJenisPembiayaan
    Private Ctrl As New CtrlForm
    Public Sub New(ByVal Fjenis_pembiayaan As FrEntriJenisPembiayaan)
        Me.Fjenis_pembiayaan = Fjenis_pembiayaan
    End Sub

    Public Function GetAutoNumber()
        Return AutoNumber("SELECT kd_jnspembiayaan FROM jenis_pembiayaan ORDER BY kd_jnspembiayaan DESC LIMIT 1", "kd_jnspembiayaan", "JP", 2)
    End Function

    Public Sub Input()
        If (ExecSQL("INSERT INTO jenis_pembiayaan(kd_jnspembiayaan, nm_jnspembiayaan) VALUES('" & Fjenis_pembiayaan.TbxKodeJPembiayaan.Text & "','" & Fjenis_pembiayaan.TbxNamaJPembiayaan.Text & "')")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub Ubah()
        If (ExecSQL("UPDATE jenis_pembiayaan SET kd_jnspembiayaan='" & Fjenis_pembiayaan.TbxNamaJPembiayaan.Text & "' ,nm_jnspembiayaan='" & Fjenis_pembiayaan.TbxNamaJPembiayaan.Text & "' WHERE kd_jnspembiayaan='" & Fjenis_pembiayaan.TbxKodeJPembiayaan.Text & "'")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub Hapus()
        If (ExecSQL("DELETE FROM jenis_pembiayaan WHERE kd_jnspembiayaan='" & Fjenis_pembiayaan.TbxKodeJPembiayaan.Text & "'")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Function Cari()
        OpenConnection()
        Try
            Dim Query As String = "SELECT * FROM jenis_pembiayaan WHERE kd_jnspembiayaan='" & Fjenis_pembiayaan.GetSelectedKode & "'"
            Cmd = New MySqlCommand(Query, Conn)
            Rdr = Cmd.ExecuteReader()
            Rdr.Read()
            If (Rdr.HasRows()) Then
                Fjenis_pembiayaan.TbxKodeJPembiayaan.Text = Rdr.Item("kd_jnspembiayaan").ToString()
                Fjenis_pembiayaan.TbxNamaJPembiayaan.Text = Rdr.Item("nm_jnspembiayaan").ToString()
                Fjenis_pembiayaan.StateCari()
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
