Public Class FrEntriDataGolongan

    Private Sub FrEntriDataGolongan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        TbxKodeGolongan.Text = AutoNumber("SELECT kd_gol FROM golongan ORDER BY kd_gol DESC LIMIT 1", "kd_gol", "G", 1)
    End Sub
End Class