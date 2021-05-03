Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinsmotiv

		Private p_idaipinsmotiv As Decimal
		Private p_xnominsmotiv As String
        Private p_xdescinsmotiv As String
        Private p_itipoinsmotiv As String
		Private p_iestatinsmotiv As String
        Private p_idseglogreg As Decimal

        Private p_isel As Boolean

        'relaciones
        Private p_aipinssusmotiv As List(Of aipinssusmotiv)
        Private p_aipinssinmotiv As List(Of aipinssinmotiv)
        Private p_aipinsenc As List(Of aipinsenc)

		Public Property idaipinsmotiv() As Decimal
			Get
				Return Me.p_idaipinsmotiv
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsmotiv = Value
			End Set
		End Property

		Public Property xnominsmotiv() As String
			Get
				Return Me.p_xnominsmotiv
			End Get
			Set(ByVal Value As String)
				Me.p_xnominsmotiv = Value
			End Set
		End Property

		Public Property xdescinsmotiv() As String
			Get
				Return Me.p_xdescinsmotiv
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinsmotiv = Value
			End Set
        End Property

        Public Property itipoinsmotiv() As String
            Get
                Return Me.p_itipoinsmotiv
            End Get
            Set(ByVal Value As String)
                Me.p_itipoinsmotiv = Value
            End Set
        End Property

		Public Property iestatinsmotiv() As String
			Get
				Return Me.p_iestatinsmotiv
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinsmotiv = Value
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

        Public Property isel() As Boolean
            Get
                Return Me.p_isel
            End Get
            Set(ByVal Value As Boolean)
                Me.p_isel = Value
            End Set
        End Property

        'relaciones
        Public Property aipinssusmotiv() As List(Of aipinssusmotiv)
            Get
                Return Me.p_aipinssusmotiv
            End Get
            Set(ByVal Value As List(Of aipinssusmotiv))
                Me.p_aipinssusmotiv = Value
            End Set
        End Property

        Public Property aipinssinmotiv() As List(Of aipinssinmotiv)
            Get
                Return Me.p_aipinssinmotiv
            End Get
            Set(ByVal Value As List(Of aipinssinmotiv))
                Me.p_aipinssinmotiv = Value
            End Set
        End Property

        Public Property aipinsenc() As List(Of aipinsenc)
            Get
                Return Me.p_aipinsenc
            End Get
            Set(ByVal Value As List(Of aipinsenc))
                Me.p_aipinsenc = Value
            End Set
        End Property


	End Class
	
	Public Class petiaipinsmotivpaglist

	Private p_pagaipinsmotiv As paginacion
	Private p_aipinsmotiv As aipinsmotiv

	Public Property pagaipinsmotiv() As paginacion
	Get
	Return Me.p_pagaipinsmotiv
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsmotiv = Value
	End Set
	End Property

	Public Property aipinsmotiv() As aipinsmotiv
	Get
	Return Me.p_aipinsmotiv
	End Get
	Set(ByVal Value As aipinsmotiv)
	Me.p_aipinsmotiv = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinsmotivpaglist

	Private p_pagaipinsmotiv As paginacion
	Private p_lista_aipinsmotiv As  List(Of aipinsmotiv)

	Public Property pagaipinsmotiv() As paginacion
	Get
	Return Me.p_pagaipinsmotiv
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsmotiv = Value
	End Set
	End Property

	Public Property lista_aipinsmotiv() As List(Of aipinsmotiv)
	Get
	Return Me.p_lista_aipinsmotiv
	End Get
	Set(ByVal Value As List(Of aipinsmotiv))
	Me.p_lista_aipinsmotiv = Value
	End Set
	End Property
	End Class

End Namespace
