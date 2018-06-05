Public Class FrCetakSuratTugas

    Private FrMaster As FrMain
    Private EProf As New ErrorProvider
    Private Ctrl As CtrlForm
    Friend CtrlST As New CtrlSuratTugas(Me)
    Friend CheckBAUK As Boolean
    Friend CheckPegawai As Boolean
    Private SelectedKodeBAUK As String
    Private SelectedKodePegawai As String
    Private SelectedKodeDivisi As String

    Public Sub New(ByVal FrMaster As FrMain)
        InitializeComponent()
        Me.FrMaster = FrMaster
        Ctrl = New CtrlForm(New Control.ControlCollection() {GbxBAUK.Controls, GbxPegawai.Controls}, Me.EProf)
    End Sub

    Public Sub SetSelectedKodeBAUK(ByVal kd As String)
        SelectedKodeBAUK = kd
    End Sub

    Public Function GetSelectedKodeBAUK()
        Return SelectedKodeBAUK
    End Function

    Public Sub SetSelectedKodePegawai(ByVal kd As String)
        SelectedKodePegawai = kd
    End Sub

    Public Function GetSelectedKodePegawai()
        Return SelectedKodePegawai
    End Function

    Public Function GetSelectedKodeDivisi()
        Dim Strings As String() = CbxDivisi.SelectedItem.ToString().Split(" ")
        SelectedKodeDivisi = Strings(0)
        Return SelectedKodeDivisi
    End Function

    Public Function IsDivisiSelected()
        If (Not (CbxDivisi.SelectedItem Is Nothing)) Then
            Return True
        End If
        Return False
    End Function

    Public Function IsAllSearch()
        If (CheckPegawai And CheckBAUK) Then
            Return True
        End If
        Return False
    End Function

    Private Sub StateAwal()
        DgvPegawai.DataSource = Nothing
        CtrlST.ClearListPegawai()
        Ctrl.ClearControls()
        TbxKodeST.Text = CtrlST.GetAutoNumber()
        CtrlST.FillCombo()
        CbxDivisi.SelectedItem = CbxDivisi.Items(0)
        Ctrl.EnableControls(False)
        Ctrl.EnableControls(False, New Control() {TbxKodeST, DtpST, BtnCetak, BtnHapus, BtnBatal, BtnTambah})
        Ctrl.EnableControls(True, New Control() {BtnCariBAUK, BtnKeluar, BtnTambah})
        If (IsDivisiSelected()) Then
            BtnCariPegawai.Enabled = True
        End If
        CheckBAUK = False
        CheckPegawai = False
    End Sub

    Private Sub FrCetakSuratTugas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StateAwal()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub FrCetakSuratTugas_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        FrMaster.SetSlaveOpened(False)
    End Sub

    Private Sub BtnCariBAUK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariBAUK.Click
        Dim frs As New FrSearch(FrSearch.SearchCategories.BAUK, Me)
        frs.Show()
    End Sub

    Private Sub BtnCariPegawai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariPegawai.Click
        Dim frs As New FrSearch(FrSearch.SearchCategories.Pegawai, Me)
        frs.Show()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        StateAwal()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        CtrlST.HapusDariList()
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If (CheckBAUK And CheckPegawai) Then
            CtrlST.TambahKeList()
        End If
    End Sub

    Private Sub CbxDivisi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxDivisi.SelectedIndexChanged
        Ctrl.ClearControls(GbxPegawai.Controls)
        CheckPegawai = False
    End Sub


    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        If (IsAllSearch()) Then
            If (CtrlST.Input()) Then
                If (CtrlST.Print()) Then
                    StateAwal()
                End If
            End If
        Else
            Ctrl.ShowMessageOK("Input belum selesai! mohon periksa kembali!", MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class