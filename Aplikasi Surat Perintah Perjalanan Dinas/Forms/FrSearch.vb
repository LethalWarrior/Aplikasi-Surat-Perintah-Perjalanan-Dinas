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
            If (Category = SearchCategories.Penyelenggara) Then
                Dim SPenyelenggara As New SrcPenyelenggara(Me)
                SPenyelenggara.SearchPenyelenggara()
            End If
        End If
    End Sub

    Private Sub DgvSearch_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvSearch.CellClick
        Dim row As DataGridViewRow = DgvSearch.Rows(e.RowIndex)
        If (SelectedIndex = e.RowIndex) Then
            If (FrParent.GetType().Equals(GetType(FrEntriBeritaAcaraUndanganKegiatan))) Then
                Dim FrBAUK As FrEntriBeritaAcaraUndanganKegiatan = FrParent
                FrBAUK.SetSelectedKode(row.Cells("Kode Penyelenggara").Value.ToString())
                FrBAUK.CtrlBAUK.CariPenyelenggara()
                Me.Close()
            End If
        End If
    End Sub
End Class