Imports estarseguros20.capaobjetos.modelo.personalizados

Namespace comun.modelo.dbestarseguros20.entidades.mantenimiento

    Public Class comunmanempr

        Private p_idcomunmanempr As Decimal
        Private p_xrif As String
        Private p_xrazonsocial As String
        Private p_xnombrecomercial As String


        Public Property idcomunmanempr() As Decimal
            Get
                Return Me.p_idcomunmanempr
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanempr = Value
            End Set
        End Property

        Public Property xrif() As String
            Get
                Return Me.p_xrif
            End Get
            Set(ByVal Value As String)
                Me.p_xrif = Value
            End Set
        End Property

        Public Property xrazonsocial() As String
            Get
                Return Me.p_xrazonsocial
            End Get
            Set(ByVal Value As String)
                Me.p_xrazonsocial = Value
            End Set
        End Property

        Public Property xnombrecomercial() As String
            Get
                Return Me.p_xnombrecomercial
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecomercial = Value
            End Set
        End Property


    End Class
End Namespace
