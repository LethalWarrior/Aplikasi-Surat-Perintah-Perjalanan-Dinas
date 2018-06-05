Imports MySql.Data.MySqlClient
Public Class FrEntriDataPegawai
    Private EProf As New ErrorProvider
    ' Private Ctrl As CtrlForm
    Friend CtrlP As New CtrlPegawai(Me)
    Private Edit As Boolean
    Private Ctrl As New CtrlForm(New Control.ControlCollection() {Me.Controls}, EProf)
    Private SelectedKode As String
    Public Sub SetSelectedKode(ByVal kd As String)
        SelectedKode = kd
    End Sub

    Public Function GetSelectedKode()
        Return SelectedKode
    End Function
    Private Sub StateAwal()
        CbxDivisi.Enabled = True
        CbxGol.Enabled = True
        CbxJabatan.Enabled = True
        Ctrl.ClearControls()
        Ctrl.EnableControls(False)
        Ctrl.EnableControls(True, New Control() {BtnCari, BtnKeluar, BtnSimpan})
        Edit = False
        BtnSimpan.Text = "TAMBAH"
        TampilGol()
        TampilJab()
        TampilDiv()
    End Sub

    Private Sub StateInput()
        Ctrl.EnableControls(False)
        Ctrl.EnableControls(True, New Control() {BtnSimpan, BtnBatal, BtnKeluar, TbxNamaPegawai, TbxAlamat, TbxTlp, TbxEmail, CbxDivisi, CbxGol, CbxJabatan})
        BtnSimpan.Text = "SIMPAN"
        If (Edit = False) Then
            TbxKodePegawai.Text = CtrlP.GetAutoNumber()
        End If
    End Sub

    Friend Sub StateCari()
        Ctrl.EnableControls(False)
        Ctrl.EnableControls(True, New Control() {BtnHapus, BtnUbah, BtnBatal, BtnKeluar})
    End Sub
    Private Sub FrEntriDataPegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StateAwal()
    End Sub

    Private Sub BtnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCari.Click
        Dim frs As New FrSearch(FrSearch.SearchCategories.Pegawai, Me)
        frs.Show()
    End Sub
    Sub TampilGol()
        OpenConnection()
        Cmd = New MySqlCommand("select * from golongan", Conn)
        Rdr = Cmd.ExecuteReader
        Do While Rdr.Read
            CbxGol.SelectedItem = CbxGol.Items.Add(Rdr.Item("kd_gol") + " - " + Rdr.Item("nm_gol"))
        Loop
    End Sub

    Sub TampilJab()
        OpenConnection()
        Cmd = New MySqlCommand("select * from jabatan", Conn)
        Rdr = Cmd.ExecuteReader
        Do While Rdr.Read
            CbxJabatan.SelectedItem = CbxJabatan.Items.Add(Rdr.Item("kd_jab") + " - " + Rdr.Item("nm_jab"))
        Loop
    End Sub
    Sub TampilDiv()
        OpenConnection()
        Cmd = New MySqlCommand("select * from divisi", Conn)
        Rdr = Cmd.ExecuteReader
        Do While Rdr.Read

            CbxDivisi.SelectedItem = CbxDivisi.Items.Add(Rdr.Item("kd_divisi") + " - " + Rdr.Item("nm_divisi"))
        Loop
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
                    If (CbxDivisi.SelectedItem = "" Or CbxGol.SelectedItem = "" Or CbxJabatan.SelectedItem = "") Then
                        MessageBox.Show("Masukan Data!!")
                    Else
                        CtrlP.Input()
                        StateAwal()
                    End If
                Else
                    If (CbxDivisi.SelectedItem = "" Or CbxGol.SelectedItem = "" Or CbxJabatan.SelectedItem = "") Then
                        MessageBox.Show("Masukan Data!!")
                    Else
                        CtrlP.Ubah()
                        StateAwal()
                    End If
                End If
                End If
        End If
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        Edit = True
        StateInput()
        'CbxDivisi.Enabled = True
        'CbxGol.Enabled = True
        'CbxJabatan.Enabled = True
        'TampilGol()
        'TampilJab()
        'TampilDiv()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If (Ctrl.ShowMessageYesNo("Apakah anda yakin ingin menghapus entry ini?", MessageBoxIcon.Exclamation)) Then
            CtrlP.Hapus()
            StateAwal()
        End If
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        CbxGol.Items.Clear()
        CbxJabatan.Items.Clear()
        CbxDivisi.Items.Clear()
        CbxGol.SelectedItem = " "
        CbxJabatan.SelectedItem = " "
        CbxDivisi.SelectedItem = " "
        StateAwal()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub FrEntriDataPegawai_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        FrMain.SetSlaveOpened(False)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub CbxGol_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxGol.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub CbxDivisi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxDivisi.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub CbxJabatan_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxJabatan.KeyPress
        e.KeyChar = Chr(0)
    End Sub
End Class