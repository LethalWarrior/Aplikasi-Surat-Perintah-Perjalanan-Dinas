Imports MySql.Data.MySqlClient
Public Class CtrlJabatan
    Private Fjabatan As FrEntriDataJabatan
    Private Ctrl As New CtrlForm
    Public Sub New(ByVal Fjabatan As FrEntriDataJabatan)
        Me.Fjabatan = Fjabatan
    End Sub

    Public Function GetAutoNumber()
        Return AutoNumber("SELECT kd_jab FROM jabatan ORDER BY kd_jab DESC LIMIT 1", "kd_jab", "J", 1)
    End Function

    Public Sub Input()
        If (ExecSQL("INSERT INTO jabatan(kd_jab, nm_jab) VALUES('" & Fjabatan.TbxKodeJabatan.Text & "','" & Fjabatan.TbxNamaJabatan.Text & "')")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub Ubah()
        If (ExecSQL("UPDATE jabatan SET kd_jab='" & Fjabatan.TbxNamaJabatan.Text & "' ,nm_jab='" & Fjabatan.TbxNamaJabatan.Text & "' WHERE kd_jab='" & Fjabatan.TbxKodeJabatan.Text & "'")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub Hapus()
        If (ExecSQL("DELETE FROM jabatan WHERE kd_jab='" & Fjabatan.TbxKodeJabatan.Text & "'")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Function Cari()
        OpenConnection()
        Try
            Dim Query As String = "SELECT * FROM jabatan WHERE kd_jab='" & Fjabatan.GetSelectedKode & "'"
            Cmd = New MySqlCommand(Query, Conn)
            Rdr = Cmd.ExecuteReader()
            Rdr.Read()
            If (Rdr.HasRows()) Then
                Fjabatan.TbxKodeJabatan.Text = Rdr.Item("kd_jab").ToString()
                Fjabatan.TbxNamaJabatan.Text = Rdr.Item("nm_jab").ToString()
                Fjabatan.StateCari()
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
