Imports MySql.Data.MySqlClient

Public Class CtrlSuratDinas
    Private FSD As FrCetakSuratDinas
    Private Ctrl As New CtrlForm
    Private ListPegawai As List(Of Pegawai)
    Private pegawai As Pegawai
    Private index As Integer
    Private CrSD As New CrSuratDinas

    Public Sub New(ByVal FSD As FrCetakSuratDinas)
        Me.FSD = FSD
        pegawai = New Pegawai
        ListPegawai = New List(Of Pegawai)
    End Sub

    Public Sub ClearListPegawai()
        ListPegawai.Clear()
    End Sub

    Public Sub SetIndex(ByVal value As Integer)
        index = value
    End Sub

    Public Sub SetListPegawai(ByVal value As List(Of Pegawai))
        ListPegawai = value
    End Sub

    Private Sub ChangeColname(ByVal dt As DataTable)
        dt.Columns(0).ColumnName = "Kode Pegawai"
        dt.Columns(1).ColumnName = "Nama Pegawai"
        dt.Columns(2).ColumnName = "Golongan"
        dt.Columns(3).ColumnName = "Jabatan"
        dt.Columns(4).ColumnName = "Divisi"
    End Sub

    Public Function CariSuratTugas(ByVal kode As String)
        OpenConnection()
        Try
            Dim Query As String = "SELECT pegawai.kd_pegawai, pegawai.nama, golongan.nm_gol, jabatan.nm_jab, divisi.nm_divisi " & _
            "FROM detail_surat_tugas JOIN pegawai ON detail_surat_tugas.kd_pegawai = pegawai.kd_pegawai " & _
            "JOIN divisi ON pegawai.kd_divisi = divisi.kd_divisi " & _
            "JOIN golongan ON pegawai.kd_gol = golongan.kd_gol " & _
            "JOIN jabatan ON pegawai.kd_jab = jabatan.kd_jab " & _
            "WHERE detail_surat_tugas.no_st='" & kode & "'"
            Cmd = New MySqlCommand(Query, Conn)
            Rdr = Cmd.ExecuteReader()
            Rdr.Read()
            If (Rdr.HasRows()) Then
                Rdr.Close()
                Da.SelectCommand = Cmd
                Dim dt = New DataTable
                Da.Fill(dt)
                ChangeColname(dt)
                FSD.DgvPegawai.DataSource = dt
                Return True
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
