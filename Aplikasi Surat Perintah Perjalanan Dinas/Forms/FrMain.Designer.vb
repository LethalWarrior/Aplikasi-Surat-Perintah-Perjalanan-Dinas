<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EntriDataPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EntriDataPenyelenggaraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EntriDataGolonganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EntriDataJabatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EntriJenisPembiayaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EntriDivisiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EntriBeritaAcaraUndanganKegiatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EntriRencanaLaporanPertanggungjawabanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakKwitansiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakSuratDinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakSuratTugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakLaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakLapRekapRPKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakLapSDinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakLapBiayaDinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakLapDaftarRiilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakLapBeritaAcaraKegiatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.CetakLaporanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(734, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntriDataPegawaiToolStripMenuItem, Me.EntriDataPenyelenggaraToolStripMenuItem, Me.EntriDataGolonganToolStripMenuItem, Me.EntriDataJabatanToolStripMenuItem, Me.EntriJenisPembiayaanToolStripMenuItem, Me.EntriDivisiToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'EntriDataPegawaiToolStripMenuItem
        '
        Me.EntriDataPegawaiToolStripMenuItem.Name = "EntriDataPegawaiToolStripMenuItem"
        Me.EntriDataPegawaiToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.EntriDataPegawaiToolStripMenuItem.Text = "Entri Data Pegawai"
        '
        'EntriDataPenyelenggaraToolStripMenuItem
        '
        Me.EntriDataPenyelenggaraToolStripMenuItem.Name = "EntriDataPenyelenggaraToolStripMenuItem"
        Me.EntriDataPenyelenggaraToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.EntriDataPenyelenggaraToolStripMenuItem.Text = "Entri Data Penyelenggara"
        '
        'EntriDataGolonganToolStripMenuItem
        '
        Me.EntriDataGolonganToolStripMenuItem.Name = "EntriDataGolonganToolStripMenuItem"
        Me.EntriDataGolonganToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.EntriDataGolonganToolStripMenuItem.Text = "Entri Data Golongan"
        '
        'EntriDataJabatanToolStripMenuItem
        '
        Me.EntriDataJabatanToolStripMenuItem.Name = "EntriDataJabatanToolStripMenuItem"
        Me.EntriDataJabatanToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.EntriDataJabatanToolStripMenuItem.Text = "Entri Data Jabatan"
        '
        'EntriJenisPembiayaanToolStripMenuItem
        '
        Me.EntriJenisPembiayaanToolStripMenuItem.Name = "EntriJenisPembiayaanToolStripMenuItem"
        Me.EntriJenisPembiayaanToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.EntriJenisPembiayaanToolStripMenuItem.Text = "Entri Jenis Pembiayaan"
        '
        'EntriDivisiToolStripMenuItem
        '
        Me.EntriDivisiToolStripMenuItem.Name = "EntriDivisiToolStripMenuItem"
        Me.EntriDivisiToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.EntriDivisiToolStripMenuItem.Text = "Entri Divisi"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntriBeritaAcaraUndanganKegiatanToolStripMenuItem, Me.EntriRencanaLaporanPertanggungjawabanToolStripMenuItem, Me.CetakKwitansiToolStripMenuItem, Me.CetakSuratDinasToolStripMenuItem, Me.CetakSuratTugasToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'EntriBeritaAcaraUndanganKegiatanToolStripMenuItem
        '
        Me.EntriBeritaAcaraUndanganKegiatanToolStripMenuItem.Name = "EntriBeritaAcaraUndanganKegiatanToolStripMenuItem"
        Me.EntriBeritaAcaraUndanganKegiatanToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
        Me.EntriBeritaAcaraUndanganKegiatanToolStripMenuItem.Text = "Entri Berita Acara Undangan Kegiatan"
        '
        'EntriRencanaLaporanPertanggungjawabanToolStripMenuItem
        '
        Me.EntriRencanaLaporanPertanggungjawabanToolStripMenuItem.Name = "EntriRencanaLaporanPertanggungjawabanToolStripMenuItem"
        Me.EntriRencanaLaporanPertanggungjawabanToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
        Me.EntriRencanaLaporanPertanggungjawabanToolStripMenuItem.Text = "Entri Rencana Laporan Pertanggungjawaban"
        '
        'CetakKwitansiToolStripMenuItem
        '
        Me.CetakKwitansiToolStripMenuItem.Name = "CetakKwitansiToolStripMenuItem"
        Me.CetakKwitansiToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
        Me.CetakKwitansiToolStripMenuItem.Text = "Cetak Kwitansi"
        '
        'CetakSuratDinasToolStripMenuItem
        '
        Me.CetakSuratDinasToolStripMenuItem.Name = "CetakSuratDinasToolStripMenuItem"
        Me.CetakSuratDinasToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
        Me.CetakSuratDinasToolStripMenuItem.Text = "Cetak Surat Dinas"
        '
        'CetakSuratTugasToolStripMenuItem
        '
        Me.CetakSuratTugasToolStripMenuItem.Name = "CetakSuratTugasToolStripMenuItem"
        Me.CetakSuratTugasToolStripMenuItem.Size = New System.Drawing.Size(308, 22)
        Me.CetakSuratTugasToolStripMenuItem.Text = "Cetak Surat Tugas"
        '
        'CetakLaporanToolStripMenuItem
        '
        Me.CetakLaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CetakLapRekapRPKToolStripMenuItem, Me.CetakLapSDinasToolStripMenuItem, Me.CetakLapBiayaDinasToolStripMenuItem, Me.CetakLapDaftarRiilToolStripMenuItem, Me.CetakLapBeritaAcaraKegiatanToolStripMenuItem})
        Me.CetakLaporanToolStripMenuItem.Name = "CetakLaporanToolStripMenuItem"
        Me.CetakLaporanToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.CetakLaporanToolStripMenuItem.Text = "Cetak Laporan"
        '
        'CetakLapRekapRPKToolStripMenuItem
        '
        Me.CetakLapRekapRPKToolStripMenuItem.Name = "CetakLapRekapRPKToolStripMenuItem"
        Me.CetakLapRekapRPKToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.CetakLapRekapRPKToolStripMenuItem.Text = "Cetak Lap. Rekap RPK"
        '
        'CetakLapSDinasToolStripMenuItem
        '
        Me.CetakLapSDinasToolStripMenuItem.Name = "CetakLapSDinasToolStripMenuItem"
        Me.CetakLapSDinasToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.CetakLapSDinasToolStripMenuItem.Text = "Cetak Lap. S. Dinas"
        '
        'CetakLapBiayaDinasToolStripMenuItem
        '
        Me.CetakLapBiayaDinasToolStripMenuItem.Name = "CetakLapBiayaDinasToolStripMenuItem"
        Me.CetakLapBiayaDinasToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.CetakLapBiayaDinasToolStripMenuItem.Text = "Cetak Lap. Biaya Dinas"
        '
        'CetakLapDaftarRiilToolStripMenuItem
        '
        Me.CetakLapDaftarRiilToolStripMenuItem.Name = "CetakLapDaftarRiilToolStripMenuItem"
        Me.CetakLapDaftarRiilToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.CetakLapDaftarRiilToolStripMenuItem.Text = "Cetak Lap. Daftar Riil"
        '
        'CetakLapBeritaAcaraKegiatanToolStripMenuItem
        '
        Me.CetakLapBeritaAcaraKegiatanToolStripMenuItem.Name = "CetakLapBeritaAcaraKegiatanToolStripMenuItem"
        Me.CetakLapBeritaAcaraKegiatanToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.CetakLapBeritaAcaraKegiatanToolStripMenuItem.Text = "Cetak Lap. Berita Acara Kegiatan"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'FrMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(734, 460)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Surat Perintah Perjalanan Dinas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntriDataPegawaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntriDataPenyelenggaraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntriDataGolonganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntriDataJabatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakLaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntriJenisPembiayaanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntriDivisiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntriBeritaAcaraUndanganKegiatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntriRencanaLaporanPertanggungjawabanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakKwitansiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakSuratDinasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakSuratTugasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakLapRekapRPKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakLapSDinasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakLapBiayaDinasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakLapDaftarRiilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakLapBeritaAcaraKegiatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
