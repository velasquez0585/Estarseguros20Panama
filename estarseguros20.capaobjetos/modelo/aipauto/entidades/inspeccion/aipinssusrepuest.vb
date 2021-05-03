Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinssusrepuest

        Private p_idaipinssusrepuest As Decimal
        Private p_idaipinssus As Decimal
        Private p_idaipmanrepu As Decimal
        Private p_xnominssusrepuest As String
        Private p_inoapliinssusrepuest As Boolean
        Private p_ileveinssusrepuest As Boolean
        Private p_imedinssusrepuest As Boolean
        Private p_ifueinssusrepuest As Boolean
        Private p_ibueestinssusrepuest As Boolean
        Private p_iestinssusrepuest As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinssus As aipinssus
        Private p_aipmanrepu As aipmanrepu

        Public Property idaipinssusrepuest() As Decimal
            Get
                Return Me.p_idaipinssusrepuest
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinssusrepuest = Value
            End Set
        End Property

        Public Property idaipinssus() As Decimal
            Get
                Return Me.p_idaipinssus
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinssus = Value
            End Set
        End Property

        Public Property idaipmanrepu() As Decimal
            Get
                Return Me.p_idaipmanrepu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipmanrepu = Value
            End Set
        End Property

        Public Property xnominssusrepuest() As String
            Get
                Return Me.p_xnominssusrepuest
            End Get
            Set(ByVal Value As String)
                Me.p_xnominssusrepuest = Value
            End Set
        End Property

        Public Property inoapliinssusrepuest() As Boolean
            Get
                Return Me.p_inoapliinssusrepuest
            End Get
            Set(ByVal Value As Boolean)
                Me.p_inoapliinssusrepuest = Value
            End Set
        End Property

        Public Property ileveinssusrepuest() As Boolean
            Get
                Return Me.p_ileveinssusrepuest
            End Get
            Set(ByVal Value As Boolean)
                Me.p_ileveinssusrepuest = Value
            End Set
        End Property

        Public Property imedinssusrepuest() As Boolean
            Get
                Return Me.p_imedinssusrepuest
            End Get
            Set(ByVal Value As Boolean)
                Me.p_imedinssusrepuest = Value
            End Set
        End Property

        Public Property ifueinssusrepuest() As Boolean
            Get
                Return Me.p_ifueinssusrepuest
            End Get
            Set(ByVal Value As Boolean)
                Me.p_ifueinssusrepuest = Value
            End Set
        End Property

        Public Property ibueestinssusrepuest() As Boolean
            Get
                Return Me.p_ibueestinssusrepuest
            End Get
            Set(ByVal Value As Boolean)
                Me.p_ibueestinssusrepuest = Value
            End Set
        End Property

        Public Property iestinssusrepuest() As String
            Get
                Return Me.p_iestinssusrepuest
            End Get
            Set(ByVal Value As String)
                Me.p_iestinssusrepuest = Value
            End Set
        End Property

        Public Property idseglogreg() As Decimal
            Get
                Return Me.p_idseglogreg
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idseglogreg = Value
            End Set
        End Property

        'relaciones
        Public Property aipinssus() As aipinssus
            Get
                Return Me.p_aipinssus
            End Get
            Set(ByVal Value As aipinssus)
                Me.p_aipinssus = Value
            End Set
        End Property        
        Public Property aipmanrepu() As aipmanrepu
            Get
                Return Me.p_aipmanrepu
            End Get
            Set(ByVal Value As aipmanrepu)
                Me.p_aipmanrepu = Value
            End Set
        End Property

	End Class
	
	Public Class petiaipinssusrepuestpaglist

	Private p_pagaipinssusrepuest As paginacion
	Private p_aipinssusrepuest As aipinssusrepuest

	Public Property pagaipinssusrepuest() As paginacion
	Get
	Return Me.p_pagaipinssusrepuest
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinssusrepuest = Value
	End Set
	End Property

	Public Property aipinssusrepuest() As aipinssusrepuest
	Get
	Return Me.p_aipinssusrepuest
	End Get
	Set(ByVal Value As aipinssusrepuest)
	Me.p_aipinssusrepuest = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinssusrepuestpaglist

	Private p_pagaipinssusrepuest As paginacion
	Private p_lista_aipinssusrepuest As  List(Of aipinssusrepuest)

	Public Property pagaipinssusrepuest() As paginacion
	Get
	Return Me.p_pagaipinssusrepuest
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinssusrepuest = Value
	End Set
	End Property

	Public Property lista_aipinssusrepuest() As List(Of aipinssusrepuest)
	Get
	Return Me.p_lista_aipinssusrepuest
	End Get
	Set(ByVal Value As List(Of aipinssusrepuest))
	Me.p_lista_aipinssusrepuest = Value
	End Set
	End Property
	End Class

End Namespace
