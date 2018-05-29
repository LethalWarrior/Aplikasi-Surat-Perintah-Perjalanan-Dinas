Imports MySql.Data.MySqlClient
Public Class SrcGolongan
    Private FRS As FrSearch
    Private Ctrl As New CtrlForm
    Public Sub New(ByVal FRS As FrSearch)
        Me.FRS = FRS
    End Sub

    Private Function SearchgolonganByNama()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT * FROM golongan WHERE nm_gol LIKE @value", Conn)
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
        dt.Columns(0).ColumnName = "Kode Golongan"
        dt.Columns(1).ColumnName = "Nama Golongan"
        dt.Columns(2).ColumnName = "Max Pembiayaan"
    End Sub

    Private Function SearchgolonganByKode()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT * FROM golongan WHERE kd_gol LIKE @value", Conn)
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

    Private Function SearchgolonganBymax_pembiayaan()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT * FROM golongan WHERE max_pembiayaan LIKE @value", Conn)
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

    Public Sub Searchgolongan()
        If (SearchgolonganByKode() = False) Then
            If (SearchgolonganByNama() = False) Then
                If (SearchgolonganBymax_pembiayaan() = False) Then
                    FRS.DgvSearch.DataSource = Nothing
                End If
            End If
        End If
    End Sub
End Class
