Imports MySql.Data.MySqlClient
Public Class CtrlGolongan
    Private Fgolongan As FrEntriDataGolongan
    Private Ctrl As New CtrlForm

    Public Sub New(ByVal Fgolongan As FrEntriDataGolongan)
        Me.Fgolongan = Fgolongan
    End Sub

    Public Function GetAutoNumber()
        Return AutoNumber("SELECT kd_gol FROM golongan ORDER BY kd_gol DESC LIMIT 1", "kd_gol", "G", 1)
    End Function

    Public Sub Input()
        If (ExecSQL("INSERT INTO golongan(kd_gol, nm_gol, max_pembiayaan) VALUES('" & Fgolongan.TbxKodeGolongan.Text & "','" & Fgolongan.TbxNamaGolongan.Text & "','" & Fgolongan.TbxMaxPembiayaan.Text & "')")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub Ubah()
        If (ExecSQL("UPDATE golongan SET kd_gol='" & Fgolongan.TbxNamaGolongan.Text & "' ,nm_gol='" & Fgolongan.TbxNamaGolongan.Text & "',max_pembiayaan='" & Fgolongan.TbxMaxPembiayaan.Text & "' WHERE kd_gol='" & Fgolongan.TbxKodeGolongan.Text & "'")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub Hapus()
        If (ExecSQL("DELETE FROM golongan WHERE kd_gol='" & Fgolongan.TbxKodeGolongan.Text & "'")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Function Cari()
        OpenConnection()
        Try
            Dim Query As String = "SELECT * FROM golongan WHERE kd_gol='" & Fgolongan.GetSelectedKode & "'"
            Cmd = New MySqlCommand(Query, Conn)
            Rdr = Cmd.ExecuteReader()
            Rdr.Read()
            If (Rdr.HasRows()) Then
                Fgolongan.TbxKodeGolongan.Text = Rdr.Item("kd_gol").ToString()
                Fgolongan.TbxNamaGolongan.Text = Rdr.Item("nm_gol").ToString()
                Fgolongan.TbxMaxPembiayaan.Text = Rdr.Item("max_pembiayaan").ToString()
                Fgolongan.StateCari()
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
