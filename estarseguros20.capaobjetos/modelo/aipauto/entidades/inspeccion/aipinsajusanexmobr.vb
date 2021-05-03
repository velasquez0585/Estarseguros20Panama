Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinsajusanexmobr

		Private p_idaipinsajusanexmobr As Decimal
		Private p_idaipinsajusanex As Decimal
		Private p_idaipbaremobr As Decimal
		Private p_ncantinsajusanexmobr As Int16
		Private p_nprecfininsajusanexmobr As Decimal
		Private p_xdescinsajusanexmobr As String
		Private p_iestatinsajusanexmobr As String
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsajusanex As aipinsajusanex
        Private p_aipbaremobr As aipbaremobr

		Public Property idaipinsajusanexmobr() As Decimal
			Get
				Return Me.p_idaipinsajusanexmobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajusanexmobr = Value
			End Set
		End Property

		Public Property idaipinsajusanex() As Decimal
			Get
				Return Me.p_idaipinsajusanex
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajusanex = Value
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

		Public Property ncantinsajusanexmobr() As Int16
			Get
				Return Me.p_ncantinsajusanexmobr
			End Get
			Set(ByVal Value As Int16)
				Me.p_ncantinsajusanexmobr = Value
			End Set
		End Property

		Public Property nprecfininsajusanexmobr() As Decimal
			Get
				Return Me.p_nprecfininsajusanexmobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_nprecfininsajusanexmobr = Value
			End Set
		End Property

		Public Property xdescinsajusanexmobr() As String
			Get
				Return Me.p_xdescinsajusanexmobr
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinsajusanexmobr = Value
			End Set
		End Property

		Public Property iestatinsajusanexmobr() As String
			Get
				Return Me.p_iestatinsajusanexmobr
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinsajusanexmobr = Value
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
        Public Property aipinsajusanex() As aipinsajusanex
            Get
                Return Me.p_aipinsajusanex
            End Get
            Set(ByVal Value As aipinsajusanex)
                Me.p_aipinsajusanex = Value
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
	
	Public Class petiaipinsajusanexmobrpaglist

	Private p_pagaipinsajusanexmobr As paginacion
	Private p_aipinsajusanexmobr As aipinsajusanexmobr

	Public Property pagaipinsajusanexmobr() As paginacion
	Get
	Return Me.p_pagaipinsajusanexmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsajusanexmobr = Value
	End Set
	End Property

	Public Property aipinsajusanexmobr() As aipinsajusanexmobr
	Get
	Return Me.p_aipinsajusanexmobr
	End Get
	Set(ByVal Value As aipinsajusanexmobr)
	Me.p_aipinsajusanexmobr = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinsajusanexmobrpaglist

	Private p_pagaipinsajusanexmobr As paginacion
	Private p_lista_aipinsajusanexmobr As  List(Of aipinsajusanexmobr)

	Public Property pagaipinsajusanexmobr() As paginacion
	Get
	Return Me.p_pagaipinsajusanexmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsajusanexmobr = Value
	End Set
	End Property

	Public Property lista_aipinsajusanexmobr() As List(Of aipinsajusanexmobr)
	Get
	Return Me.p_lista_aipinsajusanexmobr
	End Get
	Set(ByVal Value As List(Of aipinsajusanexmobr))
	Me.p_lista_aipinsajusanexmobr = Value
	End Set
	End Property
	End Class

End Namespace
