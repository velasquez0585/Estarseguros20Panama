Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinssinmotiv

		Private p_idaipinssinmotiv As Decimal
		Private p_idaipinssin As Decimal
		Private p_idaipinsmotiv As Decimal
		Private p_itilinssinmotiv As Boolean
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinssin As aipinssin
        Private p_aipinsmotiv As aipinsmotiv

		Public Property idaipinssinmotiv() As Decimal
			Get
				Return Me.p_idaipinssinmotiv
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinssinmotiv = Value
			End Set
		End Property

		Public Property idaipinssin() As Decimal
			Get
				Return Me.p_idaipinssin
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinssin = Value
			End Set
		End Property

		Public Property idaipinsmotiv() As Decimal
			Get
				Return Me.p_idaipinsmotiv
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsmotiv = Value
			End Set
		End Property

		Public Property itilinssinmotiv() As Boolean
			Get
				Return Me.p_itilinssinmotiv
			End Get
			Set(ByVal Value As Boolean)
				Me.p_itilinssinmotiv = Value
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

        Public Property aipinssin() As aipinssin
            Get
                Return Me.p_aipinssin
            End Get
            Set(ByVal Value As aipinssin)
                Me.p_aipinssin = Value
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
	
	Public Class petiaipinssinmotivpaglist

	Private p_pagaipinssinmotiv As paginacion
	Private p_aipinssinmotiv As aipinssinmotiv

	Public Property pagaipinssinmotiv() As paginacion
	Get
	Return Me.p_pagaipinssinmotiv
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinssinmotiv = Value
	End Set
	End Property

	Public Property aipinssinmotiv() As aipinssinmotiv
	Get
	Return Me.p_aipinssinmotiv
	End Get
	Set(ByVal Value As aipinssinmotiv)
	Me.p_aipinssinmotiv = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinssinmotivpaglist

	Private p_pagaipinssinmotiv As paginacion
	Private p_lista_aipinssinmotiv As  List(Of aipinssinmotiv)

	Public Property pagaipinssinmotiv() As paginacion
	Get
	Return Me.p_pagaipinssinmotiv
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinssinmotiv = Value
	End Set
	End Property

	Public Property lista_aipinssinmotiv() As List(Of aipinssinmotiv)
	Get
	Return Me.p_lista_aipinssinmotiv
	End Get
	Set(ByVal Value As List(Of aipinssinmotiv))
	Me.p_lista_aipinssinmotiv = Value
	End Set
	End Property
	End Class

End Namespace
