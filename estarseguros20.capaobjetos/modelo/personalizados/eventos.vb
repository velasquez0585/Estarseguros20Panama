Namespace modelo.personalizados

    Public Class eventos

        Private p_contadorprivados As Integer
        Private p_contadorpublicos As Integer
        Private p_contadorpublicosotros As Integer

        Public Property contadorprivados() As Integer
            Get
                Return Me.p_contadorprivados
            End Get
            Set(ByVal Value As Integer)
                Me.p_contadorprivados = Value
            End Set
        End Property

        Public Property contadorpublicos() As Integer
            Get
                Return Me.p_contadorpublicos
            End Get
            Set(ByVal Value As Integer)
                Me.p_contadorpublicos = Value
            End Set
        End Property

        Public Property contadorpublicosotros() As Integer
            Get
                Return Me.p_contadorpublicosotros
            End Get
            Set(ByVal Value As Integer)
                Me.p_contadorpublicosotros = Value
            End Set
        End Property

    End Class
End Namespace
