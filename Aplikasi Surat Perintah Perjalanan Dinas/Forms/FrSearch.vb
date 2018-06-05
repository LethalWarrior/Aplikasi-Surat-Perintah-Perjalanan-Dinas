Imports MySql.Data.MySqlClient

Public Class FrSearch

    Private Ctrl As New CtrlForm
    Private Category As SearchCategories
    Private SelectedIndex As Integer
    Private FrParent As Form
    Private EXTRA As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal Category As SearchCategories, ByVal FrParent As Form)
        InitializeComponent()
        Me.Category = Category
        Me.FrParent = FrParent
    End Sub

    '==============================================================================
    '    Enum untuk kategori pencarian dalam Form Pencarian
    '==============================================================================
    Public Enum SearchCategories
        Pegawai
        Penyelenggara
        Golongan
        Jabatan
        Divisi
        Jenis_Pembiayaan
        BAUK
        Surat_Tugas
    End Enum

    Private Sub FrSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TbxSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbxSearch.TextChanged
        If (String.IsNullOrEmpty(TbxSearch.Text)) Then
            DgvSearch.DataSource = Nothing
        Else
            If (Category = SearchCategories.Divisi) Then
                Dim SDivisi As New SrcDivisi(Me)
                SDivisi.Searchdivisi()
            ElseIf (Category = SearchCategories.Golongan) Then
                Dim SGolongan As New SrcGolongan(Me)
                SGolongan.Searchgolongan()
            ElseIf (Category = SearchCategories.Jabatan) Then
                Dim SJabatan As New SrcJabatan(Me)
                SJabatan.Searchjabatan()
            ElseIf (Category = SearchCategories.Jenis_Pembiayaan) Then
                Dim SJenis_Pembiayaan As New SrcJenis_Pembiayaan(Me)
                SJenis_Pembiayaan.Searchjenis_pembiayaan()
            ElseIf (Category = SearchCategories.Penyelenggara) Then
                Dim SPenyelenggara As New SrcPenyelenggara(Me)
                SPenyelenggara.SearchPenyelenggara()
            ElseIf (Category = SearchCategories.BAUK) Then
                Dim SBAUK As New SrcBAUK(Me)
                SBAUK.SearchBAUK()
            ElseIf (Category = SearchCategories.Pegawai) Then
                If (FrParent.GetType().Equals(GetType(FrCetakSuratTugas))) Then
                    Dim SPegawai As New SrcPegawaiEven(Me)
                    Dim FrST As FrCetakSuratTugas = FrParent
                    SPegawai.Searchpegawai(FrST.GetSelectedKodeDivisi)
                ElseIf (FrParent.GetType().Equals(GetType(FrEntriDataPegawai))) Then
                    Dim SPegawai As New SrcPegawai(Me)
                    SPegawai.Searchpegawai()
                End If
            ElseIf (Category = SearchCategories.Surat_Tugas) Then
                Dim SSuratTugas As New SrcSuratTugas(Me)
                SSuratTugas.SearchSuratTugas()
                End If
            End If
    End Sub

    Private Sub DgvSearch_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvSearch.CellClick
        if e.RowIndex > -1 Then
            Dim row As DataGridViewRow = DgvSearch.Rows(e.RowIndex)
            If (SelectedIndex = e.RowIndex) Then
                If (FrParent.GetType().Equals(GetType(FrEntriBeritaAcaraUndanganKegiatan))) Then
                    Dim FrBAUK As FrEntriBeritaAcaraUndanganKegiatan = FrParent
                    If (Category = SearchCategories.Penyelenggara) Then
                        FrBAUK.SetSelectedKode(row.Cells("Kode Penyelenggara").Value.ToString())
                        FrBAUK.CtrlBAUK.CariPenyelenggara(FrBAUK.GetSelectedKode)
                    ElseIf (Category = SearchCategories.BAUK) Then
                        FrBAUK.SetSelectedKode(row.Cells("No. BAUK").Value.ToString())
                        FrBAUK.CtrlBAUK.CariBAUK(FrBAUK.GetSelectedKode)
                    End If
                    Me.Close()
                ElseIf (FrParent.GetType().Equals(GetType(FrCetakSuratTugas))) Then
                    Dim FrST As FrCetakSuratTugas = FrParent
                    If (Category = SearchCategories.Pegawai) Then
                        FrST.SetSelectedKodePegawai(row.Cells("Kode Pegawai").Value.ToString())
                        FrST.CtrlST.CariPegawai(FrST.GetSelectedKodePegawai)
                    ElseIf (Category = SearchCategories.BAUK) Then
                        FrST.SetSelectedKodeBAUK(row.Cells("No. BAUK").Value.ToString())
                        FrST.CtrlST.CariBAUK(FrST.GetSelectedKodeBAUK)
                    End If
                    Me.Close()
                ElseIf (FrParent.GetType().Equals(GetType(FrCetakSuratDinas))) Then
                    Dim FrSD As FrCetakSuratDinas = FrParent
                    If (Category = SearchCategories.Surat_Tugas) Then
                        FrSD.SetSelectedKodeST(row.Cells("No. Surat Tugas").Value.ToString())
                        FrSD.CtrlSD.CariSuratTugas(FrSD.GetSelectedKodeST)
                        FrSD.StateCari()
                    End If
                    Me.Close()
                ElseIf (FrParent.GetType().Equals(GetType(FrEntriDivisi))) Then
                    Dim frDivisi As FrEntriDivisi = FrParent
                    frDivisi.SetSelectedKode(row.Cells("Kode Divisi").Value.ToString())
                    frDivisi.CtrlD.Cari()
                    Me.Close()
                ElseIf (FrParent.GetType().Equals(GetType(FrEntriDataPegawai))) Then
                    Dim frPegawai As FrEntriDataPegawai = FrParent
                    frPegawai.SetSelectedKode(row.Cells("Kode Pegawai").Value.ToString())
                    frPegawai.CtrlP.Cari()
                    Me.Close()
                ElseIf (FrParent.GetType().Equals(GetType(FrEntriDataGolongan))) Then
                    Dim frGolongan As FrEntriDataGolongan = FrParent
                    frGolongan.SetSelectedKode(row.Cells("Kode Golongan").Value.ToString())
                    frGolongan.CtrlG.Cari()
                    Me.Close()
                ElseIf (FrParent.GetType().Equals(GetType(FrEntriDataJabatan))) Then
                    Dim frJabatan As FrEntriDataJabatan = FrParent
                    frJabatan.SetSelectedKode(row.Cells("Kode Jabatan").Value.ToString())
                    frJabatan.CtrlJ.Cari()
                    Me.Close()
                ElseIf (FrParent.GetType().Equals(GetType(FrEntriJenisPembiayaan))) Then
                    Dim frJenis_Pembiayaan As FrEntriJenisPembiayaan = FrParent
                    frJenis_Pembiayaan.SetSelectedKode(row.Cells("Kode Jenis Pembiayaan").Value.ToString())
                    frJenis_Pembiayaan.CtrlJP.Cari()
                    Me.Close()
                ElseIf (FrParent.GetType().Equals(GetType(FrEntriDataPenyelenggara))) Then
                    Dim frPenyelenggara As FrEntriDataPenyelenggara = FrParent
                    frPenyelenggara.SetSelectedKode(row.Cells("Kode Penyelenggara").Value.ToString())
                    frPenyelenggara.CtrlPY.Cari()
                    Me.Close()
                End If
            End If
        End If
    End Sub

End Class