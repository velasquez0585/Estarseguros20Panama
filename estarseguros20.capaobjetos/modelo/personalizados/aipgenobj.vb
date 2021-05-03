Namespace modelo.personalizados
    Public Class aipgenobj

        ''objeto generico para el movil

        Private p_id As Decimal
        Private p_id2 As Int16
        Private p_xnombre As String
        Private p_xnombre2 As String


        Public Property id() As Decimal
            Get
                Return Convert.ToInt32(Me.p_id)
            End Get
            Set(ByVal Value As Decimal)
                Me.p_id = Value
            End Set
        End Property

        Public Property id2() As Int16
            Get
                Return Me.p_id2
            End Get
            Set(ByVal Value As Int16)
                Me.p_id2 = Value
            End Set
        End Property

        Public Property xnombre() As String
            Get
                Return Me.p_xnombre
            End Get
            Set(ByVal Value As String)
                Me.p_xnombre = Value
            End Set
        End Property

        Public Property xnombre2() As String
            Get
                Return Me.p_xnombre2
            End Get
            Set(ByVal Value As String)
                Me.p_xnombre2 = Value
            End Set
        End Property


    End Class
End Namespace