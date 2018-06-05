Imports MySql.Data.MySqlClient

Public Class CtrlSuratTugas
    Private FST As FrCetakSuratTugas
    Private Ctrl As New CtrlForm
    Private ListPegawai As List(Of Pegawai)
    Private pegawai As Pegawai
    Private index As Integer
    Private CrST As New CrSuratTugas

    Public Sub New(ByVal FST As FrCetakSuratTugas)
        Me.FST = FST
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

    Public Function GetAutoNumber()
        Return AutoNumber("SELECT no_st FROM surat_tugas ORDER BY no_st DESC LIMIT 1", "no_st", "ST", 2)
    End Function

    Public Function GetAutoNumberDetailST()
        Return AutoNumber("SELECT kd_detail_st FROM detail_surat_tugas ORDER BY kd_detail_st DESC LIMIT 1", "kd_detail_st", "DST", 3)
    End Function

    Public Sub FillCombo()
        OpenConnection()
        Using Cmd As New MySqlCommand("SELECT kd_divisi, nm_divisi FROM divisi ", Conn)
            Try
                Rdr = Cmd.ExecuteReader
                Rdr.Read()
                If (Rdr.HasRows()) Then
                    Rdr.Close()
                    Da.SelectCommand = Cmd
                    Dim dt = New DataTable
                    Da.Fill(dt)

                    For index As Integer = 0 To dt.Rows.Count - 1
                        Dim ComboItem As String = dt.Rows(index).Item(0).ToString() & " - " & dt.Rows(index).Item(1).ToString()
                        FST.CbxDivisi.Items.Add(ComboItem)
                    Next
                End If
            Catch ex As Exception
                Ctrl.ShowMessageOK("Error! " & ex.Message, MessageBoxIcon.Error)
            Finally
                CloseConnection()
            End Try
        End Using
    End Sub

    Private Function GetNomorST()
        Dim KodeDivisi As String = FST.CbxDivisi.SelectedItem.ToString().Split(" ")(0)
        Dim DigitST As String = FST.TbxKodeST.Text.Substring(2, 4)
        Return DigitST & "/" & KodeDivisi & "/ST/" & DateTime.Now.Year.ToString()
    End Function

    Private Function GetParagrafAwal()
        Dim NamaDivisi As String = FST.CbxDivisi.SelectedItem.ToString().Split("-")(1).Remove(0, 1)
        Return NamaDivisi & ", Kementrian Riset, Teknologi, dan Pendidikan Tinggi dengan ini menugaskan nama - nama sebagai berikut."
    End Function

    Private Function GetParagrafAkhir()
        Return "Untuk melaksanakan Kegiatan " & FST.TbxIsiKegiatan.Text & " yang diselenggarakan oleh " & FST.TbxNamaPenyelenggara.Text & " dan akan diselenggarakan pada : "
    End Function

    Private Function GetNamaDivisi()
        Return FST.CbxDivisi.SelectedItem.ToString().Split("-")(1).Remove(0, 1).ToUpper
    End Function

    Private Function InputSuratTugas()
        Try
            OpenConnection()
            Using Cmd As New MySqlCommand("INSERT INTO surat_tugas(no_st, tgl_st, no_bauk) VALUES (@no_st, @tgl_st, @no_bauk)", Conn)
                Cmd.Parameters.AddWithValue("@no_st", FST.TbxKodeST.Text)
                Cmd.Parameters.AddWithValue("@no_bauk", FST.TbxKodeBAUK.Text)
                Cmd.Parameters.Add("@tgl_st", MySqlDbType.Date).Value = DateTime.Now
                Cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Ctrl.ShowMessageOK("Error! " & ex.Message, MessageBoxIcon.Error)
            Return False
        Finally
            CloseConnection()
        End Try
        Return True
    End Function

    Private Function InputListToDatabase()
        Try
            For Each pegawai As Pegawai In ListPegawai
                ExecSQL("INSERT INTO detail_surat_tugas(kd_detail_st, no_st, kd_pegawai) " & _
                        "VALUES('" & GetAutoNumberDetailST() & "', '" & FST.TbxKodeST.Text & "', '" & pegawai.Kode_Pegawai & "')")
            Next
        Catch ex As Exception
            Ctrl.ShowMessageOK("Error! " & ex.Message, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Public Function Input()
        If InputSuratTugas() Then
            If InputListToDatabase() Then
                Ctrl.ShowMessageOK("Data berhasil disimpan dan siap dicetak!", MessageBoxIcon.Information)
                Return True
            End If
        End If
        Return False
    End Function

    Public Function CariBAUK(ByVal kode As String)
        OpenConnection()
        Try
            Dim Query As String = "SELECT bauk.no_bauk, penyelenggara.nm_penyelenggara, bauk.isi_acara, bauk.tgl_acara, bauk.tempat, bauk.waktu_acara FROM bauk JOIN penyelenggara ON bauk.kd_penyelenggara = penyelenggara.kd_penyelenggara WHERE bauk.no_bauk='" & kode & "'"
            Cmd = New MySqlCommand(Query, Conn)
            Rdr = Cmd.ExecuteReader()
            Rdr.Read()
            If (Rdr.HasRows()) Then
                FST.TbxKodeBAUK.Text = Rdr.Item("no_bauk").ToString()
                FST.TbxNamaPenyelenggara.Text = Rdr.Item("nm_penyelenggara").ToString()
                FST.TbxIsiKegiatan.Text = Rdr.Item("isi_acara").ToString()
                FST.DtpTanggalPelaksanaan.Value = Rdr.Item("tgl_acara")
                FST.DtpWaktuPelaksanaan.Value = CDate(Date.Now.Date.ToString("dd/MM/yyyy") + " " + Rdr.Item("waktu_acara").ToString())
                FST.TbxTempatPelaksanaan.Text = Rdr.Item("tempat").ToString()
                FST.CheckBAUK = True
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

    Public Function CariPegawai(ByVal kode As String)
        OpenConnection()
        Try
            Dim Query As String = "SELECT pegawai.kd_pegawai, pegawai.nama, jabatan.nm_jab FROM pegawai JOIN jabatan ON pegawai.kd_jab = jabatan.kd_jab WHERE pegawai.kd_pegawai='" & kode & "'"
            Cmd = New MySqlCommand(Query, Conn)
            Rdr = Cmd.ExecuteReader()
            Rdr.Read()
            If (Rdr.HasRows()) Then
                FST.TbxKodePegawai.Text = Rdr.Item("kd_pegawai").ToString()
                FST.TbxNamaPegawai.Text = Rdr.Item("nama").ToString()
                FST.TbxJabatan.Text = Rdr.Item("nm_jab").ToString()
                FST.CheckPegawai = True
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

    Public Sub TambahKeList()
        Dim pegawai As Pegawai = ListPegawai.Where(Function(p) p.Kode_Pegawai = FST.TbxKodePegawai.Text).FirstOrDefault()
        If (pegawai Is Nothing) Then
            Dim _pegawai As Pegawai = New Pegawai
            _pegawai.Kode_Pegawai = FST.TbxKodePegawai.Text
            _pegawai.Nama_Pegawai = FST.TbxNamaPegawai.Text
            _pegawai.Jabatan = FST.TbxJabatan.Text
            ListPegawai.Add(_pegawai)
            Ctrl.EnableControls(True, New Control() {FST.BtnHapus, FST.BtnCetak})
        End If
        InisialisasiDatagridView()
    End Sub

    Public Sub HapusDariList()
        If (FST.DgvPegawai.Rows.Count > 0) Then
            pegawai = ListPegawai(index)
            ListPegawai.Remove(pegawai)
            If (ListPegawai.Count = 0) Then
                FST.DgvPegawai.DataSource = Nothing
                Ctrl.EnableControls(False, New Control() {FST.BtnHapus, FST.BtnCetak})
            End If
        End If
        InisialisasiDatagridView()
    End Sub

    Private Sub SortColumn()
        FST.DgvPegawai.Columns("No").DisplayIndex = 0
        FST.DgvPegawai.Columns("Kode_Pegawai").DisplayIndex = 1
        FST.DgvPegawai.Columns("Nama_Pegawai").DisplayIndex = 2
        FST.DgvPegawai.Columns("Jabatan").DisplayIndex = 3
    End Sub

    Private Sub InisialisasiDatagridView()
        If (ListPegawai.Count > 0) Then
            Dim bs = New BindingSource
            bs.DataSource = From p In ListPegawai _
                            Select New With { _
                            .No = (ListPegawai.IndexOf(p) + 1), _
                            .Kode_Pegawai = p.Kode_Pegawai, _
                            .Nama_Pegawai = p.Nama_Pegawai, _
                            .Jabatan = p.Jabatan}
            FST.DgvPegawai.DataSource = bs
            SortColumn()
        Else
            FST.DgvPegawai.DataSource = Nothing
        End If
    End Sub

    Private Function GetPrintDataTable()
        Dim Dt = New DataTable("DtSuratTugasFields")
        Dt.Columns.Add(New DataColumn("nomor_surat", GetType(String)))
        Dt.Columns.Add(New DataColumn("divisi", GetType(String)))
        Dt.Columns.Add(New DataColumn("paragraf_awal", GetType(String)))
        Dt.Columns.Add(New DataColumn("paragraf_akhir", GetType(String)))
        Dt.Columns.Add(New DataColumn("hari_tanggal", GetType(String)))
        Dt.Columns.Add(New DataColumn("waktu", GetType(String)))
        Dt.Columns.Add(New DataColumn("tempat", GetType(String)))
        Dim row = Dt.NewRow
        row("nomor_surat") = GetNomorST()
        row("divisi") = GetNamaDivisi()
        row("paragraf_awal") = GetParagrafAwal()
        row("paragraf_akhir") = GetParagrafAkhir()
        row("hari_tanggal") = FST.DtpTanggalPelaksanaan.Value.ToString("dddd,  dd MMMM yyyy")
        row("waktu") = FST.DtpWaktuPelaksanaan.Value.ToString("HH:mm")
        row("tempat") = FST.TbxTempatPelaksanaan.Text
        Dt.Rows.Add(row)
        Return Dt
    End Function

    Public Function Print()
        Try
            OpenConnection()
            Using Cmd As New MySqlCommand
                Dim Query As String = "SELECT pegawai.nama, jabatan.nm_jab " & _
                "FROM detail_surat_tugas JOIN pegawai ON detail_surat_tugas.kd_pegawai = pegawai.kd_pegawai " & _
                "JOIN jabatan ON pegawai.kd_jab = jabatan.kd_jab WHERE detail_surat_tugas.no_st='" & FST.TbxKodeST.Text() & "'"
                Ds = New DataSet
                Da = New MySqlDataAdapter(Query, Conn)
                Da.Fill(Ds, "DtCetakSTPegawai")
                Dim dt = GetPrintDataTable()
                Ds.Tables.Add(dt)
                CrST.SetDataSource(Ds)
                Dim Fprint As New FrPrint(CrST)
                Fprint.Show()
                Return True
            End Using
        Catch ex As Exception
            Ctrl.ShowMessageOK("Error!, " & ex.Message, MessageBoxIcon.Error)
            Return False
        Finally
            CloseConnection()
        End Try
        Return False
    End Function

End Class
