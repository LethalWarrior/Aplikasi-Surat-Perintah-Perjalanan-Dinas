Imports MySql.Data.MySqlClient

Public Class SrcPenyelenggara
    Private FRS As FrSearch
    Private Ctrl As New CtrlForm

    Public Sub New(ByVal FRS As FrSearch)
        Me.FRS = FRS
    End Sub

    Private Function SearchPenyelenggaraByNama()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT * FROM penyelenggara WHERE nm_penyelenggara LIKE @value", Conn)
            Cmd.Parameters.AddWithValue("@value", "%" & FRS.TbxSearch.Text & "%")
            Try
                Rdr = Cmd.ExecuteReader
                Rdr.Read()
                If (Rdr.HasRows()) Then
                    Rdr.Close()
                    Da.SelectCommand = Cmd
                    Dim dt = New DataTable()
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

    Private Sub ChangeColname(ByVal dt As DataTable)
        dt.Columns(0).ColumnName = "Kode Penyelenggara"
        dt.Columns(1).ColumnName = "Nama Penyelenggara"
        dt.Columns(2).ColumnName = "Alamat"
        dt.Columns(3).ColumnName = "No. Telepon"
    End Sub

    Private Function SearchPenyelenggaraByKode()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT * FROM penyelenggara WHERE kd_penyelenggara LIKE @value", Conn)
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

    Private Function SearchPenyelenggaraByAlamat()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT * FROM penyelenggara WHERE alamat LIKE @value", Conn)
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

    Private Function SearchPenyelenggaraByNoTlp()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT * FROM penyelenggara WHERE tlp LIKE @value", Conn)
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

    Public Sub SearchPenyelenggara()
        If (SearchPenyelenggaraByKode() = False) Then
            If (SearchPenyelenggaraByNama() = False) Then
                If (SearchPenyelenggaraByAlamat() = False) Then
                    If (SearchPenyelenggaraByNoTlp() = False) Then
                        FRS.DgvSearch.DataSource = Nothing
                    End If
                End If
            End If
        End If
    End Sub

End Class
