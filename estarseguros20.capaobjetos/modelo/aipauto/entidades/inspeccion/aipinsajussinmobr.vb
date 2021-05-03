Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinsajussinmobr

		Private p_idaipinsajussinmobr As Decimal
		Private p_idaipinsajussin As Decimal
		Private p_idaipbaremobr As Decimal
		Private p_ncantinsajussinmobr As Int16
		Private p_nprecfininsajussinmobr As Decimal
		Private p_xdescinsajussinmobr As String
		Private p_iestatinsajussinmobr As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsajussin As aipinsajussin
        Private p_aipbaremobr As aipbaremobr

		Public Property idaipinsajussinmobr() As Decimal
			Get
				Return Me.p_idaipinsajussinmobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajussinmobr = Value
			End Set
		End Property

		Public Property idaipinsajussin() As Decimal
			Get
				Return Me.p_idaipinsajussin
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajussin = Value
			End Set
		End Property

		Public Property idaipbaremobr() As Decimal
			Get
				Return Me.p_idaipbaremobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipbaremobr = Value
			End Set
		End Property

		Public Property ncantinsajussinmobr() As Int16
			Get
				Return Me.p_ncantinsajussinmobr
			End Get
			Set(ByVal Value As Int16)
				Me.p_ncantinsajussinmobr = Value
			End Set
		End Property

		Public Property nprecfininsajussinmobr() As Decimal
			Get
				Return Me.p_nprecfininsajussinmobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_nprecfininsajussinmobr = Value
			End Set
		End Property

		Public Property xdescinsajussinmobr() As String
			Get
				Return Me.p_xdescinsajussinmobr
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinsajussinmobr = Value
			End Set
		End Property

		Public Property iestatinsajussinmobr() As String
			Get
				Return Me.p_iestatinsajussinmobr
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinsajussinmobr = Value
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
        Public Property aipinsajussin() As aipinsajussin
            Get
                Return Me.p_aipinsajussin
            End Get
            Set(ByVal Value As aipinsajussin)
                Me.p_aipinsajussin = Value
            End Set
        End Property

        Public Property aipbaremobr() As aipbaremobr
            Get
                Return Me.p_aipbaremobr
            End Get
            Set(ByVal Value As aipbaremobr)
                Me.p_aipbaremobr = Value
            End Set
        End Property

	End Class
	
	Public Class petiaipinsajussinmobrpaglist

	Private p_pagaipinsajussinmobr As paginacion
	Private p_aipinsajussinmobr As aipinsajussinmobr

	Public Property pagaipinsajussinmobr() As paginacion
	Get
	Return Me.p_pagaipinsajussinmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsajussinmobr = Value
	End Set
	End Property

	Public Property aipinsajussinmobr() As aipinsajussinmobr
	Get
	Return Me.p_aipinsajussinmobr
	End Get
	Set(ByVal Value As aipinsajussinmobr)
	Me.p_aipinsajussinmobr = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinsajussinmobrpaglist

	Private p_pagaipinsajussinmobr As paginacion
	Private p_lista_aipinsajussinmobr As  List(Of aipinsajussinmobr)

	Public Property pagaipinsajussinmobr() As paginacion
	Get
	Return Me.p_pagaipinsajussinmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsajussinmobr = Value
	End Set
	End Property

	Public Property lista_aipinsajussinmobr() As List(Of aipinsajussinmobr)
	Get
	Return Me.p_lista_aipinsajussinmobr
	End Get
	Set(ByVal Value As List(Of aipinsajussinmobr))
	Me.p_lista_aipinsajussinmobr = Value
	End Set
	End Property
	End Class

End Namespace
