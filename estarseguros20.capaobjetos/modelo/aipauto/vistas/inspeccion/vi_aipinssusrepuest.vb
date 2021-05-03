Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinssusrepuest


        Private p_idaipinssusrepuest As Decimal
        Private p_idaipinssus As Decimal
        Private p_idaipinsenc As Decimal
        Private p_itipoinsenc As String
        Private p_idaipmanrepu As Decimal
        Private p_xnommanrepu As String
        Private p_nordenmanrepu As Short
        Private p_xnominssusrepuest As String
        Private p_inoapliinssusrepuest As Boolean
        Private p_ileveinssusrepuest As Boolean
        Private p_imedinssusrepuest As Boolean
        Private p_ifueinssusrepuest As Boolean
        Private p_ibueestinssusrepuest As Boolean
        Private p_iestinssusrepuest As String
        Private p_idseglogreg As Decimal

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

        Public Property idaipinsenc() As Decimal
            Get
                Return Me.p_idaipinsenc
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinsenc = Value
            End Set
        End Property

        Public Property itipoinsenc() As String
            Get
                Return Me.p_itipoinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_itipoinsenc = Value
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

        Public Property xnommanrepu() As String
            Get
                Return Me.p_xnommanrepu
            End Get
            Set(ByVal Value As String)
                Me.p_xnommanrepu = Value
            End Set
        End Property

        Public Property nordenmanrepu() As Short
            Get
                Return Me.p_nordenmanrepu
            End Get
            Set(ByVal Value As Short)
                Me.p_nordenmanrepu = Value
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

	End Class
	
	Public Class petivi_aipinssusrepuestpaglist

	Private p_pagvi_aipinssusrepuest As paginacion
	Private p_vi_aipinssusrepuest As vi_aipinssusrepuest

	Public Property pagvi_aipinssusrepuest() As paginacion
	Get
	Return Me.p_pagvi_aipinssusrepuest
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssusrepuest = Value
	End Set
	End Property

	Public Property vi_aipinssusrepuest() As vi_aipinssusrepuest
	Get
	Return Me.p_vi_aipinssusrepuest
	End Get
	Set(ByVal Value As vi_aipinssusrepuest)
	Me.p_vi_aipinssusrepuest = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinssusrepuestpaglist

	Private p_pagvi_aipinssusrepuest As paginacion
	Private p_lista_vi_aipinssusrepuest As  List(Of vi_aipinssusrepuest)

	Public Property pagvi_aipinssusrepuest() As paginacion
	Get
	Return Me.p_pagvi_aipinssusrepuest
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssusrepuest = Value
	End Set
	End Property

	Public Property lista_vi_aipinssusrepuest() As List(Of vi_aipinssusrepuest)
	Get
	Return Me.p_lista_vi_aipinssusrepuest
	End Get
	Set(ByVal Value As List(Of vi_aipinssusrepuest))
	Me.p_lista_vi_aipinssusrepuest = Value
	End Set
	End Property
	End Class

End Namespace
