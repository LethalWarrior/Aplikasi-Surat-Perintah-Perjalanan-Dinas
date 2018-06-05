Imports MySql.Data.MySqlClient

Public Class SrcSuratTugas
    Private FRS As FrSearch
    Private Ctrl As New CtrlForm

    Public Sub New(ByVal FRS As FrSearch)
        Me.FRS = FRS
    End Sub

    Private Sub ChangeColname(ByVal dt As DataTable)
        dt.Columns(0).ColumnName = "No. Surat Tugas"
        dt.Columns(1).ColumnName = "Tanggal Terbit"
        dt.Columns(2).ColumnName = "Penyelenggara"
        dt.Columns(3).ColumnName = "Isi Acara"
    End Sub

    Private Function SearchSuratTugasByKode()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT surat_tugas.no_st, surat_tugas.tgl_st, penyelenggara.nm_penyelenggara, bauk.isi_acara " & _
                                      "FROM surat_tugas JOIN bauk ON surat_tugas.no_bauk = bauk.no_bauk " & _
                                      "JOIN penyelenggara ON bauk.kd_penyelenggara = penyelenggara.kd_penyelenggara " & _
                                      "WHERE surat_tugas.no_st LIKE @value", Conn)
            Cmd.Parameters.AddWithValue("@value", "%" & FRS.TbxSearch.Text & "%")
            Try
                Rdr = Cmd.ExecuteReader
                Rdr.Read()
                If (Rdr.HasRows()) Then
                    Rdr.Close()
                    Da.SelectCommand = Cmd
                    Dim dt = New DataTable
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

    Private Function SearchSuratTugasByTanggal()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT surat_tugas.no_st, surat_tugas.tgl_st, penyelenggara.nm_penyelenggara, bauk.isi_acara " & _
                                      "FROM surat_tugas JOIN bauk ON surat_tugas.no_bauk = bauk.no_bauk " & _
                                      "JOIN penyelenggara ON bauk.kd_penyelenggara = penyelenggara.kd_penyelenggara " & _
                                      "WHERE surat_tugas.tgl_st LIKE @value", Conn)
            Cmd.Parameters.AddWithValue("@value", "%" & FRS.TbxSearch.Text & "%")
            Try
                Rdr = Cmd.ExecuteReader
                Rdr.Read()
                If (Rdr.HasRows()) Then
                    Rdr.Close()
                    Da.SelectCommand = Cmd
                    Dim dt = New DataTable
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

    Private Function SearchSuratTugasByPenyelenggara()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT surat_tugas.no_st, surat_tugas.tgl_st, penyelenggara.nm_penyelenggara, bauk.isi_acara " & _
                                      "FROM surat_tugas JOIN bauk ON surat_tugas.no_bauk = bauk.no_bauk " & _
                                      "JOIN penyelenggara ON bauk.kd_penyelenggara = penyelenggara.kd_penyelenggara " & _
                                      "WHERE penyelenggara.kd_penyelenggara LIKE @value", Conn)
            Cmd.Parameters.AddWithValue("@value", "%" & FRS.TbxSearch.Text & "%")
            Try
                Rdr = Cmd.ExecuteReader
                Rdr.Read()
                If (Rdr.HasRows()) Then
                    Rdr.Close()
                    Da.SelectCommand = Cmd
                    Dim dt = New DataTable
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

    Private Function SearchSuratTugasByIsiAcara()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT surat_tugas.no_st, surat_tugas.tgl_st, penyelenggara.nm_penyelenggara, bauk.isi_acara " & _
                                      "FROM surat_tugas JOIN bauk ON surat_tugas.no_bauk = bauk.no_bauk " & _
                                      "JOIN penyelenggara ON bauk.kd_penyelenggara = penyelenggara.kd_penyelenggara " & _
                                      "WHERE bauk.isi_acara LIKE @value", Conn)
            Cmd.Parameters.AddWithValue("@value", "%" & FRS.TbxSearch.Text & "%")
            Try
                Rdr = Cmd.ExecuteReader
                Rdr.Read()
                If (Rdr.HasRows()) Then
                    Rdr.Close()
                    Da.SelectCommand = Cmd
                    Dim dt = New DataTable
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

    Public Sub SearchSuratTugas()
        If (SearchSuratTugasByKode() = False) Then
            If (SearchSuratTugasByTanggal() = False) Then
                If (SearchSuratTugasByPenyelenggara() = False) Then
                    If (SearchSuratTugasByIsiAcara() = False) Then
                        FRS.DgvSearch.DataSource = Nothing
                    End If
                End If
            End If
        End If
    End Sub
End Class
