Public Class FrEntriBeritaAcaraUndanganKegiatan

    Private FrMaster As FrMain
    Private EProf As New ErrorProvider
    Private Ctrl As CtrlForm
    Friend CtrlBAUK As New CtrlBeritaAcaraUndanganKegiatan(Me)
    Private CheckPenyelenggara As Boolean
    Private SelectedKode As String
    Private Edit As Boolean

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

    Public Sub SetEditStatus(ByVal status As Boolean)
        Edit = status
    End Sub

    Private Sub StateAwal()
        Ctrl.ClearControls()
        TbxKodeBAUK.Clear()
        Edit = False
        DefaultDateTime()
        Ctrl.EnableControls(False)
        Ctrl.EnableControls(False, New Control() {TbxKodeBAUK, DtpBAUK, BtnHapus, BtnBatal, BtnUbah})
        Ctrl.EnableControls(True, New Control() {BtnCariBAUK, BtnKeluar, BtnSimpan})
        CheckPenyelenggara = False
        BtnSimpan.Text = "TAMBAH"
    End Sub

    Friend Sub StateCari()
        Ctrl.EnableControls(False)
        BtnSimpan.Enabled = False
        Ctrl.EnableControls(True, New Control() {BtnHapus, BtnUbah, BtnBatal, BtnKeluar})
    End Sub

    Private Sub StateInput()
        Ctrl.EnableControls(False)
        BtnCariBAUK.Enabled = False
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        Ctrl.EnableControls(True, New Control() { _
                            BtnSimpan, BtnBatal, BtnKeluar, _
                            BtnCariPenyelenggara, _
                            DtpTanggalPelaksanaan, DtpWaktuPelaksanaan, TbxTempatPelaksanaan, _
                            TbxIsiKegiatan})
        BtnSimpan.Text = "SIMPAN"
        If (Edit = False) Then
            TbxKodeBAUK.Text = CtrlBAUK.GetAutoNumber()
        End If
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
        Else
            If (Ctrl.ValidateEmpty(Me.EProf) = False) Then
                Return
            End If
            If (Ctrl.ShowMessageYesNo("Apakah anda yakin dengan data tersebut?", MessageBoxIcon.Question)) Then
                If (Edit = False) Then
                    CtrlBAUK.Input()
                    StateAwal()
                Else
                    CtrlBAUK.Ubah()
                    StateAwal()
                End If
            End If
        End If
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        StateAwal()
    End Sub

    Private Sub BtnCariPenyelenggara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariPenyelenggara.Click
        Dim FRS As New FrSearch(FrSearch.SearchCategories.Penyelenggara, Me)
        FRS.Show()
    End Sub

    Private Sub BtnCariBAUK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariBAUK.Click
        Dim FRS As New FrSearch(FrSearch.SearchCategories.BAUK, Me)
        FRS.Show()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        Edit = True
        StateInput()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If (Ctrl.ShowMessageYesNo("Apakah anda yakin ingin menghapus entry ini?", MessageBoxIcon.Exclamation)) Then
            CtrlBAUK.Hapus()
            StateAwal()
        End If
    End Sub
End Class