Namespace modelo.personalizados

    Public Class peraipdatosdeclara

        Private p_xdessiniestro As String
        Private p_xdesobservacion As String

        Public Property xdessiniestro() As String
            Get
                Return Me.p_xdessiniestro
            End Get
            Set(ByVal Value As String)
                Me.p_xdessiniestro = Value
            End Set
        End Property

        Public Property xdesobservacion() As String
            Get
                Return Me.p_xdesobservacion
            End Get
            Set(ByVal Value As String)
                Me.p_xdesobservacion = Value
            End Set
        End Property



    End Class
End Namespace
