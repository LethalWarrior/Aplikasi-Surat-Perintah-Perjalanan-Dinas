<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrCetakSuratDinas
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
        Me.TbxKodeST = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.DgvPegawai = New System.Windows.Forms.DataGridView
        Me.BtnCariST = New System.Windows.Forms.Button
        Me.GbxPegawai = New System.Windows.Forms.GroupBox
        Me.GbxSPD = New System.Windows.Forms.GroupBox
        Me.DtpBerangkat = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CbxJenisAngkut = New System.Windows.Forms.ComboBox
        Me.TbxTujuan = New System.Windows.Forms.TextBox
        Me.TbxHari = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TbxBerangkat = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TbxKodePegawai = New System.Windows.Forms.TextBox
        Me.TbxGol = New System.Windows.Forms.TextBox
        Me.TbxJabatan = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TbxNamaPegawai = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.BtnCetak = New System.Windows.Forms.Button
        Me.BtnBatal = New System.Windows.Forms.Button
        Me.BtnKeluar = New System.Windows.Forms.Button
        CType(Me.DgvPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbxPegawai.SuspendLayout()
        Me.GbxSPD.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Impact", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(973, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cetak Surat Dinas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TbxKodeST
        '
        Me.TbxKodeST.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbxKodeST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxKodeST.Location = New System.Drawing.Point(433, 72)
        Me.TbxKodeST.Name = "TbxKodeST"
        Me.TbxKodeST.Size = New System.Drawing.Size(145, 22)
        Me.TbxKodeST.TabIndex = 64
        Me.TbxKodeST.Text = "STXXXX"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(311, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 16)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Kode Surat Tugas"
        '
        'DgvPegawai
        '
        Me.DgvPegawai.AllowUserToAddRows = False
        Me.DgvPegawai.AllowUserToDeleteRows = False
        Me.DgvPegawai.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DgvPegawai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPegawai.Location = New System.Drawing.Point(35, 120)
        Me.DgvPegawai.Name = "DgvPegawai"
        Me.DgvPegawai.ReadOnly = True
        Me.DgvPegawai.Size = New System.Drawing.Size(900, 163)
        Me.DgvPegawai.TabIndex = 73
        '
        'BtnCariST
        '
        Me.BtnCariST.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCariST.Location = New System.Drawing.Point(584, 67)
        Me.BtnCariST.Name = "BtnCariST"
        Me.BtnCariST.Size = New System.Drawing.Size(84, 32)
        Me.BtnCariST.TabIndex = 83
        Me.BtnCariST.Text = "CARI"
        Me.BtnCariST.UseVisualStyleBackColor = True
        '
        'GbxPegawai
        '
        Me.GbxPegawai.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GbxPegawai.Controls.Add(Me.TbxKodePegawai)
        Me.GbxPegawai.Controls.Add(Me.TbxGol)
        Me.GbxPegawai.Controls.Add(Me.TbxJabatan)
        Me.GbxPegawai.Controls.Add(Me.Label2)
        Me.GbxPegawai.Controls.Add(Me.TbxNamaPegawai)
        Me.GbxPegawai.Controls.Add(Me.Label5)
        Me.GbxPegawai.Controls.Add(Me.Label6)
        Me.GbxPegawai.Controls.Add(Me.Label7)
        Me.GbxPegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxPegawai.Location = New System.Drawing.Point(35, 289)
        Me.GbxPegawai.Name = "GbxPegawai"
        Me.GbxPegawai.Size = New System.Drawing.Size(447, 216)
        Me.GbxPegawai.TabIndex = 84
        Me.GbxPegawai.TabStop = False
        Me.GbxPegawai.Text = "Pegawai"
        '
        'GbxSPD
        '
        Me.GbxSPD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GbxSPD.Controls.Add(Me.DtpBerangkat)
        Me.GbxSPD.Controls.Add(Me.Label12)
        Me.GbxSPD.Controls.Add(Me.Label11)
        Me.GbxSPD.Controls.Add(Me.CbxJenisAngkut)
        Me.GbxSPD.Controls.Add(Me.TbxTujuan)
        Me.GbxSPD.Controls.Add(Me.TbxHari)
        Me.GbxSPD.Controls.Add(Me.Label3)
        Me.GbxSPD.Controls.Add(Me.TbxBerangkat)
        Me.GbxSPD.Controls.Add(Me.Label4)
        Me.GbxSPD.Controls.Add(Me.Label8)
        Me.GbxSPD.Controls.Add(Me.Label10)
        Me.GbxSPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxSPD.Location = New System.Drawing.Point(488, 289)
        Me.GbxSPD.Name = "GbxSPD"
        Me.GbxSPD.Size = New System.Drawing.Size(447, 216)
        Me.GbxSPD.TabIndex = 85
        Me.GbxSPD.TabStop = False
        Me.GbxSPD.Text = "Perjalanan Dinas"
        '
        'DtpBerangkat
        '
        Me.DtpBerangkat.Location = New System.Drawing.Point(178, 153)
        Me.DtpBerangkat.Name = "DtpBerangkat"
        Me.DtpBerangkat.Size = New System.Drawing.Size(200, 23)
        Me.DtpBerangkat.TabIndex = 83
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(124, 16)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "Tanggal Berangkat"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(240, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 16)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "hari"
        '
        'CbxJenisAngkut
        '
        Me.CbxJenisAngkut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxJenisAngkut.FormattingEnabled = True
        Me.CbxJenisAngkut.Items.AddRange(New Object() {"Transportasi Darat", "Transportasi Laut", "Transportasi Udara"})
        Me.CbxJenisAngkut.Location = New System.Drawing.Point(178, 39)
        Me.CbxJenisAngkut.Name = "CbxJenisAngkut"
        Me.CbxJenisAngkut.Size = New System.Drawing.Size(244, 24)
        Me.CbxJenisAngkut.TabIndex = 80
        '
        'TbxTujuan
        '
        Me.TbxTujuan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbxTujuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxTujuan.Location = New System.Drawing.Point(178, 97)
        Me.TbxTujuan.Name = "TbxTujuan"
        Me.TbxTujuan.Size = New System.Drawing.Size(244, 22)
        Me.TbxTujuan.TabIndex = 78
        '
        'TbxHari
        '
        Me.TbxHari.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbxHari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxHari.Location = New System.Drawing.Point(178, 125)
        Me.TbxHari.Name = "TbxHari"
        Me.TbxHari.Size = New System.Drawing.Size(56, 22)
        Me.TbxHari.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Tempat Tujuan"
        '
        'TbxBerangkat
        '
        Me.TbxBerangkat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbxBerangkat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxBerangkat.Location = New System.Drawing.Point(178, 69)
        Me.TbxBerangkat.Name = "TbxBerangkat"
        Me.TbxBerangkat.Size = New System.Drawing.Size(244, 22)
        Me.TbxBerangkat.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 16)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Lama Perjalanan Dinas"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 16)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Jenis Angkutan"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Tempat Berangkat"
        '
        'TbxKodePegawai
        '
        Me.TbxKodePegawai.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbxKodePegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxKodePegawai.Location = New System.Drawing.Point(179, 53)
        Me.TbxKodePegawai.Name = "TbxKodePegawai"
        Me.TbxKodePegawai.Size = New System.Drawing.Size(145, 22)
        Me.TbxKodePegawai.TabIndex = 73
        Me.TbxKodePegawai.Text = "PXXXX"
        '
        'TbxGol
        '
        Me.TbxGol.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbxGol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxGol.Location = New System.Drawing.Point(179, 114)
        Me.TbxGol.Name = "TbxGol"
        Me.TbxGol.Size = New System.Drawing.Size(244, 22)
        Me.TbxGol.TabIndex = 75
        '
        'TbxJabatan
        '
        Me.TbxJabatan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbxJabatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxJabatan.Location = New System.Drawing.Point(179, 142)
        Me.TbxJabatan.Name = "TbxJabatan"
        Me.TbxJabatan.Size = New System.Drawing.Size(244, 22)
        Me.TbxJabatan.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Golongan"
        '
        'TbxNamaPegawai
        '
        Me.TbxNamaPegawai.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TbxNamaPegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxNamaPegawai.Location = New System.Drawing.Point(179, 86)
        Me.TbxNamaPegawai.Name = "TbxNamaPegawai"
        Me.TbxNamaPegawai.Size = New System.Drawing.Size(244, 22)
        Me.TbxNamaPegawai.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 69
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
        Me.Label6.TabIndex = 72
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
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Nama Pegawai"
        '
        'BtnCetak
        '
        Me.BtnCetak.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCetak.Location = New System.Drawing.Point(354, 511)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(84, 32)
        Me.BtnCetak.TabIndex = 86
        Me.BtnCetak.Text = "CETAK"
        Me.BtnCetak.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnBatal.Location = New System.Drawing.Point(444, 511)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(84, 32)
        Me.BtnBatal.TabIndex = 87
        Me.BtnBatal.Text = "BATAL"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnKeluar.Location = New System.Drawing.Point(534, 511)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(84, 32)
        Me.BtnKeluar.TabIndex = 87
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'FrCetakSuratDinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 563)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnCetak)
        Me.Controls.Add(Me.GbxSPD)
        Me.Controls.Add(Me.GbxPegawai)
        Me.Controls.Add(Me.BtnCariST)
        Me.Controls.Add(Me.DgvPegawai)
        Me.Controls.Add(Me.TbxKodeST)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FrCetakSuratDinas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrCetakSuratDinas"
        CType(Me.DgvPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbxPegawai.ResumeLayout(False)
        Me.GbxPegawai.PerformLayout()
        Me.GbxSPD.ResumeLayout(False)
        Me.GbxSPD.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbxKodeST As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DgvPegawai As System.Windows.Forms.DataGridView
    Friend WithEvents BtnCariST As System.Windows.Forms.Button
    Friend WithEvents GbxPegawai As System.Windows.Forms.GroupBox
    Friend WithEvents GbxSPD As System.Windows.Forms.GroupBox
    Friend WithEvents TbxKodePegawai As System.Windows.Forms.TextBox
    Friend WithEvents TbxGol As System.Windows.Forms.TextBox
    Friend WithEvents TbxJabatan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbxNamaPegawai As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DtpBerangkat As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CbxJenisAngkut As System.Windows.Forms.ComboBox
    Friend WithEvents TbxTujuan As System.Windows.Forms.TextBox
    Friend WithEvents TbxHari As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TbxBerangkat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnCetak As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
End Class
