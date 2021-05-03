
Namespace modelo.personalizados

    Public Class Android
        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = value
            End Set
        End Property
        Private m_Name As String


        Public Property ArchivoByteChar() As String
            Get
                Return m_ArchivoByteChar
            End Get
            Set(value As String)
                m_ArchivoByteChar = value
            End Set
        End Property
        Private m_ArchivoByteChar As String

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

