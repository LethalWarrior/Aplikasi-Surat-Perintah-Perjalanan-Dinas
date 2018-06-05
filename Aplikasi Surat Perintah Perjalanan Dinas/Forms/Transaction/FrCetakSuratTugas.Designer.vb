<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrCetakSuratTugas
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.DtpST = New System.Windows.Forms.DateTimePicker
        Me.TbxKodeST = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GbxBAUK = New System.Windows.Forms.GroupBox
        Me.GbxPegawai = New System.Windows.Forms.GroupBox
        Me.BtnCariPegawai = New System.Windows.Forms.Button
        Me.TbxKodePegawai = New System.Windows.Forms.TextBox
        Me.TbxJabatan = New System.Windows.Forms.TextBox
        Me.TbxNamaPegawai = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CbxDivisi = New System.Windows.Forms.ComboBox
        Me.DgvPegawai = New System.Windows.Forms.DataGridView
        Me.BtnTambah = New System.Windows.Forms.Button
        Me.BtnCetak = New System.Windows.Forms.Button
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnBatal = New System.Windows.Forms.Button
        Me.BtnKeluar = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.DtpWaktuPelaksanaan = New System.Windows.Forms.DateTimePicker
        Me.DtpTanggalPelaksanaan = New System.Windows.Forms.DateTimePicker
        Me.TbxTempatPelaksanaan = New System.Windows.Forms.TextBox
        Me.BtnCariBAUK = New System.Windows.Forms.Button
        Me.TbxKodeBAUK = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TbxIsiKegiatan = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TbxNamaPenyelenggara = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GbxBAUK.SuspendLayout()
        Me.GbxPegawai.SuspendLayout()
        CType(Me.DgvPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Impact", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(973, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cetak Surat Tugas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DtpST
        '
        Me.DtpST.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DtpST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpST.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpST.Location = New System.Drawing.Point(681, 71)
        Me.DtpST.Name = "DtpST"
        Me.DtpST.Size = New System.Drawing.Size(115, 22)
        Me.DtpST.TabIndex = 62
        '
        'TbxKodeST
        '
        Me.TbxKodeST.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TbxKodeST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxKodeST.Location = New System.Drawing.Point(224, 74)
        Me.TbxKodeST.Name = "TbxKodeST"
        Me.TbxKodeST.Size = New System.Drawing.Size(145, 22)
        Me.TbxKodeST.TabIndex = 60
        Me.TbxKodeST.Text = "STXXXX"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(102, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 16)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Kode Surat Tugas"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(556, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Tanggal Dibuat"
        '
        'GbxBAUK
        '
        Me.GbxBAUK.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GbxBAUK.Controls.Add(Me.Label13)
        Me.GbxBAUK.Controls.Add(Me.DtpWaktuPelaksanaan)
        Me.GbxBAUK.Controls.Add(Me.DtpTanggalPelaksanaan)
        Me.GbxBAUK.Controls.Add(Me.TbxTempatPelaksanaan)
        Me.GbxBAUK.Controls.Add(Me.BtnCariBAUK)
        Me.GbxBAUK.Controls.Add(Me.TbxKodeBAUK)
        Me.GbxBAUK.Controls.Add(Me.Label12)
        Me.GbxBAUK.Controls.Add(Me.TbxIsiKegiatan)
        Me.GbxBAUK.Controls.Add(Me.Label11)
        Me.GbxBAUK.Controls.Add(Me.TbxNamaPenyelenggara)
        Me.GbxBAUK.Controls.Add(Me.Label4)
        Me.GbxBAUK.Controls.Add(Me.Label2)
        Me.GbxBAUK.Controls.Add(Me.Label3)
        Me.GbxBAUK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxBAUK.Location = New System.Drawing.Point(39, 156)
        Me.GbxBAUK.Name = "GbxBAUK"
        Me.GbxBAUK.Size = New System.Drawing.Size(447, 289)
        Me.GbxBAUK.TabIndex = 63
        Me.GbxBAUK.TabStop = False
        Me.GbxBAUK.Text = "BAUK"
        '
        'GbxPegawai
        '
        Me.GbxPegawai.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GbxPegawai.Controls.Add(Me.BtnCariPegawai)
        Me.GbxPegawai.Controls.Add(Me.TbxKodePegawai)
        Me.GbxPegawai.Controls.Add(Me.TbxJabatan)
        Me.GbxPegawai.Controls.Add(Me.TbxNamaPegawai)
        Me.GbxPegawai.Controls.Add(Me.Label5)
        Me.GbxPegawai.Controls.Add(Me.Label6)
        Me.GbxPegawai.Controls.Add(Me.Label7)
        Me.GbxPegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxPegawai.Location = New System.Drawing.Point(492, 156)
        Me.GbxPegawai.Name = "GbxPegawai"
        Me.GbxPegawai.Size = New System.Drawing.Size(447, 185)
        Me.GbxPegawai.TabIndex = 70
        Me.GbxPegawai.TabStop = False
        Me.GbxPegawai.Text = "Pegawai"
        '
        'BtnCariPegawai
        '
        Me.BtnCariPegawai.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCariPegawai.Location = New System.Drawing.Point(339, 48)
        Me.BtnCariPegawai.Name = "BtnCariPegawai"
        Me.BtnCariPegawai.Size = New System.Drawing.Size(84, 32)
        Me.BtnCariPegawai.TabIndex = 69
        Me.BtnCariPegawai.Text = "CARI"
        Me.BtnCariPegawai.UseVisualStyleBackColor = True
        '
        'TbxKodePegawai
        '
        Me.TbxKodePegawai.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbxKodePegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxKodePegawai.Location = New System.Drawing.Point(179, 53)
        Me.TbxKodePegawai.Name = "TbxKodePegawai"
        Me.TbxKodePegawai.Size = New System.Drawing.Size(145, 22)
        Me.TbxKodePegawai.TabIndex = 66
        Me.TbxKodePegawai.Text = "PXXXX"
        '
        'TbxJabatan
        '
        Me.TbxJabatan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbxJabatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxJabatan.Location = New System.Drawing.Point(179, 114)
        Me.TbxJabatan.Name = "TbxJabatan"
        Me.TbxJabatan.Size = New System.Drawing.Size(244, 22)
        Me.TbxJabatan.TabIndex = 67
        '
        'TbxNamaPegawai
        '
        Me.TbxNamaPegawai.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbxNamaPegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxNamaPegawai.Location = New System.Drawing.Point(179, 86)
        Me.TbxNamaPegawai.Name = "TbxNamaPegawai"
        Me.TbxNamaPegawai.Size = New System.Drawing.Size(244, 22)
        Me.TbxNamaPegawai.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Jabatan"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Kode Pegawai"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 16)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Nama Pegawai"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(292, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 16)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Divisi"
        '
        'CbxDivisi
        '
        Me.CbxDivisi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CbxDivisi.FormattingEnabled = True
        Me.CbxDivisi.Location = New System.Drawing.Point(339, 117)
        Me.CbxDivisi.Name = "CbxDivisi"
        Me.CbxDivisi.Size = New System.Drawing.Size(290, 21)
        Me.CbxDivisi.TabIndex = 71
        '
        'DgvPegawai
        '
        Me.DgvPegawai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPegawai.Location = New System.Drawing.Point(39, 451)
        Me.DgvPegawai.Name = "DgvPegawai"
        Me.DgvPegawai.Size = New System.Drawing.Size(900, 163)
        Me.DgvPegawai.TabIndex = 72
        '
        'BtnTambah
        '
        Me.BtnTambah.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnTambah.Location = New System.Drawing.Point(855, 350)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(84, 32)
        Me.BtnTambah.TabIndex = 73
        Me.BtnTambah.Text = "TAMBAH"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnCetak
        '
        Me.BtnCetak.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCetak.Location = New System.Drawing.Point(39, 620)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(84, 32)
        Me.BtnCetak.TabIndex = 74
        Me.BtnCetak.Text = "CETAK"
        Me.BtnCetak.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnHapus.Location = New System.Drawing.Point(129, 620)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(84, 32)
        Me.BtnHapus.TabIndex = 74
        Me.BtnHapus.Text = "HAPUS"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnBatal.Location = New System.Drawing.Point(219, 620)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(84, 32)
        Me.BtnBatal.TabIndex = 74
        Me.BtnBatal.Text = "BATAL"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnKeluar.Location = New System.Drawing.Point(855, 620)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(84, 32)
        Me.BtnKeluar.TabIndex = 75
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 202)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 16)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Tempat Pelaksanaan"
        '
        'DtpWaktuPelaksanaan
        '
        Me.DtpWaktuPelaksanaan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DtpWaktuPelaksanaan.CustomFormat = "HH:mm"
        Me.DtpWaktuPelaksanaan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpWaktuPelaksanaan.Location = New System.Drawing.Point(179, 170)
        Me.DtpWaktuPelaksanaan.Name = "DtpWaktuPelaksanaan"
        Me.DtpWaktuPelaksanaan.ShowUpDown = True
        Me.DtpWaktuPelaksanaan.Size = New System.Drawing.Size(74, 23)
        Me.DtpWaktuPelaksanaan.TabIndex = 84
        '
        'DtpTanggalPelaksanaan
        '
        Me.DtpTanggalPelaksanaan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DtpTanggalPelaksanaan.CustomFormat = "dddd,  dd MMMM yyyy"
        Me.DtpTanggalPelaksanaan.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpTanggalPelaksanaan.Location = New System.Drawing.Point(179, 141)
        Me.DtpTanggalPelaksanaan.Name = "DtpTanggalPelaksanaan"
        Me.DtpTanggalPelaksanaan.Size = New System.Drawing.Size(244, 23)
        Me.DtpTanggalPelaksanaan.TabIndex = 85
        '
        'TbxTempatPelaksanaan
        '
        Me.TbxTempatPelaksanaan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TbxTempatPelaksanaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxTempatPelaksanaan.Location = New System.Drawing.Point(179, 199)
        Me.TbxTempatPelaksanaan.Multiline = True
        Me.TbxTempatPelaksanaan.Name = "TbxTempatPelaksanaan"
        Me.TbxTempatPelaksanaan.Size = New System.Drawing.Size(225, 42)
        Me.TbxTempatPelaksanaan.TabIndex = 83
        '
        'BtnCariBAUK
        '
        Me.BtnCariBAUK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCariBAUK.Location = New System.Drawing.Point(339, 47)
        Me.BtnCariBAUK.Name = "BtnCariBAUK"
        Me.BtnCariBAUK.Size = New System.Drawing.Size(84, 32)
        Me.BtnCariBAUK.TabIndex = 82
        Me.BtnCariBAUK.Text = "CARI"
        Me.BtnCariBAUK.UseVisualStyleBackColor = True
        '
        'TbxKodeBAUK
        '
        Me.TbxKodeBAUK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbxKodeBAUK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxKodeBAUK.Location = New System.Drawing.Point(179, 52)
        Me.TbxKodeBAUK.Name = "TbxKodeBAUK"
        Me.TbxKodeBAUK.Size = New System.Drawing.Size(145, 22)
        Me.TbxKodeBAUK.TabIndex = 79
        Me.TbxKodeBAUK.Text = "BAUKXXXX"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 175)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 16)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Waktu"
        '
        'TbxIsiKegiatan
        '
        Me.TbxIsiKegiatan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbxIsiKegiatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxIsiKegiatan.Location = New System.Drawing.Point(179, 113)
        Me.TbxIsiKegiatan.Name = "TbxIsiKegiatan"
        Me.TbxIsiKegiatan.Size = New System.Drawing.Size(244, 22)
        Me.TbxIsiKegiatan.TabIndex = 80
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Hari/Tanggal"
        '
        'TbxNamaPenyelenggara
        '
        Me.TbxNamaPenyelenggara.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbxNamaPenyelenggara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxNamaPenyelenggara.Location = New System.Drawing.Point(179, 85)
        Me.TbxNamaPenyelenggara.Name = "TbxNamaPenyelenggara"
        Me.TbxNamaPenyelenggara.Size = New System.Drawing.Size(244, 22)
        Me.TbxNamaPenyelenggara.TabIndex = 81
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Isi Kegiatan"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Kode BAUK"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 16)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Penyelenggara"
        '
        'FrCetakSuratTugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 665)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnCetak)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.DgvPegawai)
        Me.Controls.Add(Me.CbxDivisi)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GbxPegawai)
        Me.Controls.Add(Me.GbxBAUK)
        Me.Controls.Add(Me.DtpST)
        Me.Controls.Add(Me.TbxKodeST)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FrCetakSuratTugas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrCetakSuratTugas"
        Me.GbxBAUK.ResumeLayout(False)
        Me.GbxBAUK.PerformLayout()
        Me.GbxPegawai.ResumeLayout(False)
        Me.GbxPegawai.PerformLayout()
        CType(Me.DgvPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtpST As System.Windows.Forms.DateTimePicker
    Friend WithEvents TbxKodeST As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GbxBAUK As System.Windows.Forms.GroupBox
    Friend WithEvents GbxPegawai As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCariPegawai As System.Windows.Forms.Button
    Friend WithEvents TbxKodePegawai As System.Windows.Forms.TextBox
    Friend WithEvents TbxJabatan As System.Windows.Forms.TextBox
    Friend WithEvents TbxNamaPegawai As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CbxDivisi As System.Windows.Forms.ComboBox
    Friend WithEvents DgvPegawai As System.Windows.Forms.DataGridView
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents BtnCetak As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DtpWaktuPelaksanaan As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpTanggalPelaksanaan As System.Windows.Forms.DateTimePicker
    Friend WithEvents TbxTempatPelaksanaan As System.Windows.Forms.TextBox
    Friend WithEvents BtnCariBAUK As System.Windows.Forms.Button
    Friend WithEvents TbxKodeBAUK As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TbxIsiKegiatan As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TbxNamaPenyelenggara As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
