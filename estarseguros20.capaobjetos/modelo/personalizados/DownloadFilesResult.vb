Namespace modelo.personalizados


    Public Class DownloadFilesResult
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
    End Class
End Namespace