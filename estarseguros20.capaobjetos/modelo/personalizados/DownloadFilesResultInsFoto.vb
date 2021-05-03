Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Namespace modelo.personalizados


    Public Class DownloadFilesResultInsFoto
        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = value
            End Set
        End Property
        Private m_Name As String

        Public Property Type() As String
            Get
                Return m_Type
            End Get
            Set(value As String)
                m_Type = value
            End Set
        End Property
        Private m_Type As String

        Public Property ArchivoByte() As Byte()
            Get
                Return m_ArchivoByte
            End Get
            Set(value As Byte())
                m_ArchivoByte = value
            End Set
        End Property
        Private m_ArchivoByte As Byte()

        Public Property aipinsfoto() As aipinsfoto
            Get
                Return m_aipinsfoto
            End Get
            Set(value As aipinsfoto)
                m_aipinsfoto = value
            End Set
        End Property
        Private m_aipinsfoto As aipinsfoto

    End Class
End Namespace