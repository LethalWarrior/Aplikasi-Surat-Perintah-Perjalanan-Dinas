Public Class FrCetakSuratDinas

    Private FrMaster As FrMain
    Private EProf As New ErrorProvider
    Private Ctrl As CtrlForm
    Friend CtrlSD As New CtrlSuratDinas(Me)
    Friend CheckPegawai As Boolean
    Private SelectedKodeST As String
    Private SelectedDivisi As String

    Public Sub New(ByVal FrMaster As FrMain)
        InitializeComponent()
        Me.FrMaster = FrMaster
        Ctrl = New CtrlForm(New Control.ControlCollection() {GbxSPD.Controls, GbxPegawai.Controls}, Me.EProf)
    End Sub

    Public Sub SetSelectedKodeST(ByVal kd As String)
        SelectedKodeST = kd
    End Sub

    Public Function GetSelectedKodeST()
        Return SelectedKodeST
    End Function

    Public Sub SetSelectedKodeDivisi(ByVal kd As String)
        SelectedKodeST = kd
    End Sub

    Public Function GetSelectedDivisi()
        Return SelectedKodeST
    End Function

    Private Sub StateAwal()
        DgvPegawai.DataSource = Nothing
        SetSelectedKodeDivisi("")
        Ctrl.ClearControls()
        TbxKodeST.Clear()
        CbxJenisAngkut.SelectedItem = CbxJenisAngkut.Items(0)
        Ctrl.EnableControls(False)
        Ctrl.EnableControls(False, New Control() {TbxKodeST, BtnCetak, BtnBatal})
        Ctrl.EnableControls(True, New Control() {BtnCariST, BtnKeluar})
    End Sub

    Friend Sub StateCari()
        Ctrl.EnableControls(True, New Control() {BtnCetak, BtnBatal, DgvPegawai})
    End Sub

    Private Sub FrCetakSuratDinas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StateAwal()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub FrCetakSuratDinas_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        FrMaster.SetSlaveOpened(False)
    End Sub

    Private Sub BtnCariST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCariST.Click
        Dim frs As New FrSearch(FrSearch.SearchCategories.Surat_Tugas, Me)
        frs.Show()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        StateAwal()
    End Sub

    Private Sub DgvPegawai_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DgvPegawai.SelectionChanged
        If (DgvPegawai.SelectedRows.Count > 0 And DgvPegawai.SelectedRows.Count < 2) Then
            Dim row As DataGridViewRow = DgvPegawai.SelectedRows(0)
            SetSelectedKodeDivisi(row.Cells("Divisi").Value.ToString())
            TbxKodePegawai.Text = row.Cells("Kode Pegawai").Value.ToString()
            TbxNamaPegawai.Text = row.Cells("Nama Pegawai").Value.ToString()
            TbxJabatan.Text = row.Cells("Jabatan").Value.ToString()
            TbxGol.Text = row.Cells("Golongan").Value.ToString()
        End If
    End Sub
End Class