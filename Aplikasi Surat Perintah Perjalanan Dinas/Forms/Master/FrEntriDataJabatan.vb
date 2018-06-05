Imports MySql.Data.MySqlClient
Public Class FrEntriDataJabatan
    Private EProf As New ErrorProvider
    'Private Ctrl As CtrlForm
    Friend CtrlJ As New CtrlJabatan(Me)
    Private Edit As Boolean
    Private Ctrl As New CtrlForm(New Control.ControlCollection() {Me.Controls}, EProf)
    Private SelectedKode As String
    Private Sub FrEntriDataJabatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StateAwal()
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        Dim frs As New FrSearch(FrSearch.SearchCategories.Jabatan, Me)
        frs.Show()
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If (BtnSimpan.Text = "TAMBAH") Then
            StateInput()
        Else
            If (Ctrl.ValidateEmpty(Me.EProf) = False) Then
                Return
            End If
            If (Ctrl.ShowMessageYesNo("Apakah anda yakin dengan data tersebut?", MessageBoxIcon.Question)) Then
                If (Edit = False) Then
                    CtrlJ.Input()
                    StateAwal()
                Else
                    CtrlJ.Ubah()
                    StateAwal()
                End If
            End If
        End If
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        Edit = True
        StateInput()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If (Ctrl.ShowMessageYesNo("Apakah anda yakin ingin menghapus entry ini?", MessageBoxIcon.Exclamation)) Then
            CtrlJ.Hapus()
            StateAwal()
        End If
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        StateAwal()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub
    Public Sub SetSelectedKode(ByVal kd As String)
        SelectedKode = kd
    End Sub

    Public Function GetSelectedKode()
        Return SelectedKode
    End Function
    Private Sub StateAwal()
        Ctrl.ClearControls()
        Ctrl.EnableControls(False)
        Ctrl.EnableControls(True, New Control() {BtnCari, BtnKeluar, BtnSimpan})
        Edit = False
        BtnSimpan.Text = "TAMBAH"
    End Sub

    Private Sub StateInput()
        Ctrl.EnableControls(False)
        Ctrl.EnableControls(True, New Control() {BtnSimpan, BtnBatal, BtnKeluar, TbxNamaJabatan})
        BtnSimpan.Text = "SIMPAN"
        If (Edit = False) Then
            TbxKodeJabatan.Text = CtrlJ.GetAutoNumber()
        End If
    End Sub

    Friend Sub StateCari()
        Ctrl.EnableControls(False)
        Ctrl.EnableControls(True, New Control() {BtnHapus, BtnUbah, BtnBatal, BtnKeluar})
    End Sub

    Private Sub FrEntriDataJabatan_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        FrMain.SetSlaveOpened(False)
    End Sub
End Class