Imports MySql.Data.MySqlClient
Public Class CtrlDivisi
    Private Fdivisi As FrEntriDivisi
    Private Ctrl As New CtrlForm
    Public Sub New(ByVal Fdivisi As FrEntriDivisi)
        Me.Fdivisi = Fdivisi
    End Sub

    Public Function GetAutoNumber()
        Return AutoNumber("SELECT kd_divisi FROM divisi ORDER BY kd_divisi DESC LIMIT 1", "kd_divisi", "D", 1)
    End Function

    Public Sub Input()
        If (ExecSQL("INSERT INTO divisi(kd_divisi, nm_divisi) VALUES('" & Fdivisi.TbxKodeDivisi.Text & "','" & Fdivisi.TbxNamaDivisi.Text & "')")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub Ubah()
        If (ExecSQL("UPDATE divisi SET kd_divisi='" & Fdivisi.TbxNamaDivisi.Text & "' ,nm_divisi='" & Fdivisi.TbxNamaDivisi.Text & "' WHERE kd_divisi='" & Fdivisi.TbxKodeDivisi.Text & "'")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub Hapus()
        If (ExecSQL("DELETE FROM divisi WHERE kd_divisi='" & Fdivisi.TbxKodeDivisi.Text & "'")) Then
            Ctrl.ShowMessageOK("Sukses!", MessageBoxIcon.Information)
        End If
    End Sub

    Public Function Cari()
        OpenConnection()
        Try
            Dim Query As String = "SELECT * FROM divisi WHERE kd_divisi='" & Fdivisi.GetSelectedKode & "'"
            Cmd = New MySqlCommand(Query, Conn)
            Rdr = Cmd.ExecuteReader()
            Rdr.Read()
            If (Rdr.HasRows()) Then
                Fdivisi.TbxKodeDivisi.Text = Rdr.Item("kd_divisi").ToString()
                Fdivisi.TbxNamaDivisi.Text = Rdr.Item("nm_divisi").ToString()
                Fdivisi.StateCari()
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
