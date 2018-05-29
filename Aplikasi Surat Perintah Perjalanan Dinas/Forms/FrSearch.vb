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
            ElseIf (Category = SearchCategories.Pegawai) Then
                Dim SPegawai As New SrcPegawai(Me)
                SPegawai.Searchpegawai()
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
            End If
        End If
    End Sub

    Private Sub DgvSearch_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvSearch.CellClick
        If e.RowIndex > -1 Then
            Dim row As DataGridViewRow = DgvSearch.Rows(e.RowIndex)
            If (SelectedIndex = e.RowIndex) Then
                If (FrParent.GetType().Equals(GetType(FrEntriDivisi))) Then
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