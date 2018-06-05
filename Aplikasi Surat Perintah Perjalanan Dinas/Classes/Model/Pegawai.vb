Public Class Pegawai
    Private _kode_pegawai As String
    Private _nama_pegawai As String
    Private _jabatan As String

    Public Property Kode_Pegawai()
        Get
            Return _kode_pegawai
        End Get
        Set(ByVal value)
            _kode_pegawai = value
        End Set
    End Property

    Public Property Jabatan()
        Get
            Return _jabatan
        End Get
        Set(ByVal value)
            _jabatan = value
        End Set
    End Property

    Public Property Nama_Pegawai()
        Get
            Return _nama_pegawai
        End Get
        Set(ByVal value)
            _nama_pegawai = value
        End Set
    End Property
End Class
