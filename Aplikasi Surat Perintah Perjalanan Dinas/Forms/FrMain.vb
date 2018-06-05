Public Class FrMain

    Private IsSlaveOpened As Boolean = False

    Public Sub SetSlaveOpened(ByVal value As Boolean)
        IsSlaveOpened = value
    End Sub

    Private Sub FrMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub EntriBeritaAcaraUndanganKegiatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntriBeritaAcaraUndanganKegiatanToolStripMenuItem.Click
        If (IsSlaveOpened = False) Then
            Dim FrBAUK = New FrEntriBeritaAcaraUndanganKegiatan(Me)
            FrBAUK.Show()
            SetSlaveOpened(True)
        End If
    End Sub

    Private Sub EntriDataGolonganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntriDataGolonganToolStripMenuItem.Click
        If (IsSlaveOpened = False) Then
            Dim FrGol = New FrEntriDataGolongan
            FrGol.Show()
            SetSlaveOpened(True)
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CetakSuratTugasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakSuratTugasToolStripMenuItem.Click
        If (IsSlaveOpened = False) Then
            Dim FrCetakST = New FrCetakSuratTugas(Me)
            FrCetakST.Show()
        End If
    End Sub
    Private Sub EntriDataPegawaiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntriDataPegawaiToolStripMenuItem.Click
        If (IsSlaveOpened = False) Then
            Dim FrPeg = New FrEntriDataPegawai
            FrPeg.Show()
            SetSlaveOpened(True)
        End If
    End Sub

    Private Sub CetakSuratDinasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakSuratDinasToolStripMenuItem.Click
        If (IsSlaveOpened = False) Then
            Dim FrCetakSD = New FrCetakSuratDinas(Me)
            FrCetakSD.Show()
        End If
    End Sub

    Private Sub EntriDataPenyelenggaraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntriDataPenyelenggaraToolStripMenuItem.Click
        If (IsSlaveOpened = False) Then
            Dim FrPen = New FrEntriDataPenyelenggara
            FrPen.Show()
            SetSlaveOpened(True)
        End If
    End Sub

    Private Sub EntriDataJabatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntriDataJabatanToolStripMenuItem.Click
        If (IsSlaveOpened = False) Then
            Dim FrJab = New FrEntriDataJabatan
            FrJab.Show()
            SetSlaveOpened(True)
        End If
    End Sub

    Private Sub EntriJenisPembiayaanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntriJenisPembiayaanToolStripMenuItem.Click
        If (IsSlaveOpened = False) Then
            Dim FrJP = New FrEntriJenisPembiayaan
            FrJP.Show()
            SetSlaveOpened(True)
        End If
    End Sub

    Private Sub EntriDivisiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntriDivisiToolStripMenuItem.Click
        If (IsSlaveOpened = False) Then
            Dim FrDiv = New FrEntriDivisi
            FrDiv.Show()
            SetSlaveOpened(True)
        End If
    End Sub
End Class
