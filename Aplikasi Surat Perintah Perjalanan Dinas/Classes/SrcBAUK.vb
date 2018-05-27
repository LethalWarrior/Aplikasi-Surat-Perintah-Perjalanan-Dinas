Imports MySql.Data.MySqlClient

Public Class SrcBAUK
    Private FRS As FrSearch
    Private Ctrl As New CtrlForm

    Public Sub New(ByVal FRS As FrSearch)
        Me.FRS = FRS
    End Sub

    Private Sub ChangeColname(ByVal dt As DataTable)
        dt.Columns(0).ColumnName = "No. BAUK"
        dt.Columns(1).ColumnName = "Tanggal BAUK"
        dt.Columns(2).ColumnName = "Isi Acara"
        dt.Columns(3).ColumnName = "Tanggal"
        dt.Columns(4).ColumnName = "Waktu"
        dt.Columns(5).ColumnName = "Tempat"
        dt.Columns(6).ColumnName = "Penyelenggara"
    End Sub

    Private Function SearchBAUKByKode()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT bauk.no_bauk, bauk.tgl_bauk, bauk.isi_acara, bauk.tgl_acara, bauk.waktu_acara, bauk.tempat, penyelenggara.nm_penyelenggara " + _
                                      "FROM bauk JOIN penyelenggara ON bauk.kd_penyelenggara = penyelenggara.kd_penyelenggara WHERE bauk.no_bauk LIKE @value", Conn)
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

    Private Function SearchBAUKByTglBAUK()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT bauk.no_bauk, bauk.tgl_bauk, bauk.isi_acara, bauk.tgl_acara, bauk.waktu_acara, bauk.tempat, penyelenggara.nm_penyelenggara " + _
                                      "FROM bauk JOIN penyelenggara ON bauk.kd_penyelenggara = penyelenggara.kd_penyelenggara WHERE bauk.tgl_bauk LIKE @value", Conn)
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

    Private Function SearchBAUKByIsi()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT bauk.no_bauk, bauk.tgl_bauk, bauk.isi_acara, bauk.tgl_acara, bauk.waktu_acara, bauk.tempat, penyelenggara.nm_penyelenggara " + _
                                      "FROM bauk JOIN penyelenggara ON bauk.kd_penyelenggara = penyelenggara.kd_penyelenggara WHERE bauk.isi_acara LIKE @value", Conn)
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

    Private Function SearchBAUKByTglAcara()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT bauk.no_bauk, bauk.tgl_bauk, bauk.isi_acara, bauk.tgl_acara, bauk.waktu_acara, bauk.tempat, penyelenggara.nm_penyelenggara " + _
                                      "FROM bauk JOIN penyelenggara ON bauk.kd_penyelenggara = penyelenggara.kd_penyelenggara WHERE bauk.tgl_acara LIKE @value", Conn)
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

    Private Function SearchBAUKByWaktuAcara()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT bauk.no_bauk, bauk.tgl_bauk, bauk.isi_acara, bauk.tgl_acara, bauk.waktu_acara, bauk.tempat, penyelenggara.nm_penyelenggara " + _
                                      "FROM bauk JOIN penyelenggara ON bauk.kd_penyelenggara = penyelenggara.kd_penyelenggara WHERE bauk.waktu_acara LIKE @value", Conn)
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

    Private Function SearchBAUKByTempat()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT bauk.no_bauk, bauk.tgl_bauk, bauk.isi_acara, bauk.tgl_acara, bauk.waktu_acara, bauk.tempat, penyelenggara.nm_penyelenggara " + _
                                      "FROM bauk JOIN penyelenggara ON bauk.kd_penyelenggara = penyelenggara.kd_penyelenggara WHERE bauk.tempat LIKE @value", Conn)
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

    Private Function SearchBAUKByPenyelenggara()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT bauk.no_bauk, bauk.tgl_bauk, bauk.isi_acara, bauk.tgl_acara, bauk.waktu_acara, bauk.tempat, penyelenggara.nm_penyelenggara " + _
                                      "FROM bauk JOIN penyelenggara ON bauk.kd_penyelenggara = penyelenggara.kd_penyelenggara WHERE penyelenggara.kd_penyelenggara LIKE @value", Conn)
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

    Public Sub SearchBAUK()
        If (SearchBAUKByKode() = False) Then
            If (SearchBAUKByTglBAUK() = False) Then
                If (SearchBAUKByIsi() = False) Then
                    If (SearchBAUKByTglAcara() = False) Then
                        If (SearchBAUKByWaktuAcara() = False) Then
                            If (SearchBAUKByTempat() = False) Then
                                If (SearchBAUKByPenyelenggara() = False) Then
                                    FRS.DgvSearch.DataSource = Nothing
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

End Class
