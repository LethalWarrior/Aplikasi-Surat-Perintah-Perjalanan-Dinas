Public Class FrEntriBeritaAcaraUndanganKegiatan

    Private FrMaster As FrMain
    Private EProf As New ErrorProvider
    Private Ctrl As CtrlForm
    Friend CtrlBAUK As New CtrlBeritaAcaraUndanganKegiatan(Me)
    Private CheckPenyelenggara As Boolean
    Private SelectedKode As String

    Public Sub New(ByVal FrMaster As FrMain)
        InitializeComponent()
        Me.FrMaster = FrMaster
        Ctrl = New CtrlForm(New Control.ControlCollection() {GbxPenyelenggara.Controls, GbxTeknisKegiatan.Controls, GbxIsiKegiatan.Controls}, Me.EProf)
    End Sub

    Public Sub SetSelectedKode(ByVal kd As String)
        SelectedKode = kd
    End Sub

    Public Function GetSelectedKode()
        Return SelectedKode
    End Function

    Private Sub StateAwal()
        Ctrl.ClearControls()
        TbxKodeBAUK.Clear()
        DefaultDateTime()
        Ctrl.EnableControls(False)
        Ctrl.EnableControls(False, New Control() {TbxKodeBAUK, DtpBAUK, BtnHapus, BtnBatal, BtnUbah})
        Ctrl.EnableControls(True, New Control() {BtnCariBAUK, BtnKeluar, BtnSimpan})
        CheckPenyelenggara = False
        BtnSimpan.Text = "TAMBAH"
    End Sub

    Private Sub StateInput()
        Ctrl.EnableControls(False)
        BtnCariBAUK.Enabled = False
        Ctrl.EnableControls(True, New Control() { _
                            BtnSimpan, BtnBatal, BtnKeluar, _
                            BtnCariPenyelenggara, _
                            DtpTanggalPelaksanaan, DtpWaktuPelaksanaan, TbxTempatPelaksanaan, _
                            TbxIsiKegiatan})
        BtnSimpan.Text = "SIMPAN"
    End Sub

    Private Sub DefaultDateTime()
        DtpBAUK.Value = DateTime.UtcNow
        DtpTanggalPelaksanaan.Value = DateTime.UtcNow
        DtpWaktuPelaksanaan.Value = DateTime.UtcNow
    End Sub

    Private Sub FrEntriBeritaAcaraUndanganKegiatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StateAwal()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub FrEntriBeritaAcaraUndanganKegiatan_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        FrMaster.SetSlaveOpened(False)
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If (BtnSimpan.Text.Equals("TAMBAH")) Then
            StateInput()
            TbxKodeBAUK.Text = CtrlBAUK.GetAutoNumber()
        End If
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        StateAwal()
    End Sub

    Private Sub BtnCariPenyelenggara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariPenyelenggara.Click
        Dim FRS As New FrSearch(FrSearch.SearchCategories.Penyelenggara, Me)
        FRS.Show()
    End Sub
End Class