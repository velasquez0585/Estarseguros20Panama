Public Class datosfoto
    Private p_ruta As String
    Private p_nombre As String

    Public Property ruta() As String
        Get
            Return Me.p_ruta
        End Get
        Set(ByVal Value As String)
            Me.p_ruta = Value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return Me.p_nombre
        End Get
        Set(ByVal Value As String)
            Me.p_nombre = Value
        End Set
    End Property

End Class
