Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsdistperitperf

		Private p_idsegmanusuperit As Decimal
		Private p_xnombrecompletoperit As String
		Private p_idsegmanorgperit As Decimal
		Private p_xnombrecomercialperit As String
		Private p_idsegmanapp As Decimal
		Private p_idsegmanperf As Decimal
		Private p_xnombreperf As String
		Private p_ibloqueado As Boolean
		Private p_ncantinsperit As Int32

		Public Property idsegmanusuperit() As Decimal
			Get
				Return Me.p_idsegmanusuperit
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idsegmanusuperit = Value
			End Set
		End Property

		Public Property xnombrecompletoperit() As String
			Get
				Return Me.p_xnombrecompletoperit
			End Get
			Set(ByVal Value As String)
				Me.p_xnombrecompletoperit = Value
			End Set
		End Property

		Public Property idsegmanorgperit() As Decimal
			Get
				Return Me.p_idsegmanorgperit
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idsegmanorgperit = Value
			End Set
		End Property

		Public Property xnombrecomercialperit() As String
			Get
				Return Me.p_xnombrecomercialperit
			End Get
			Set(ByVal Value As String)
				Me.p_xnombrecomercialperit = Value
			End Set
		End Property

		Public Property idsegmanapp() As Decimal
			Get
				Return Me.p_idsegmanapp
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idsegmanapp = Value
			End Set
		End Property

		Public Property idsegmanperf() As Decimal
			Get
				Return Me.p_idsegmanperf
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idsegmanperf = Value
			End Set
		End Property

		Public Property xnombreperf() As String
			Get
				Return Me.p_xnombreperf
			End Get
			Set(ByVal Value As String)
				Me.p_xnombreperf = Value
			End Set
		End Property

		Public Property ibloqueado() As Boolean
			Get
				Return Me.p_ibloqueado
			End Get
			Set(ByVal Value As Boolean)
				Me.p_ibloqueado = Value
			End Set
		End Property

		Public Property ncantinsperit() As Int32
			Get
				Return Me.p_ncantinsperit
			End Get
			Set(ByVal Value As Int32)
				Me.p_ncantinsperit = Value
			End Set
		End Property

	End Class
	
	Public Class petivi_aipinsdistperitperfpaglist

	Private p_pagvi_aipinsdistperitperf As paginacion
	Private p_vi_aipinsdistperitperf As vi_aipinsdistperitperf

	Public Property pagvi_aipinsdistperitperf() As paginacion
	Get
	Return Me.p_pagvi_aipinsdistperitperf
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsdistperitperf = Value
	End Set
	End Property

	Public Property vi_aipinsdistperitperf() As vi_aipinsdistperitperf
	Get
	Return Me.p_vi_aipinsdistperitperf
	End Get
	Set(ByVal Value As vi_aipinsdistperitperf)
	Me.p_vi_aipinsdistperitperf = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsdistperitperfpaglist

	Private p_pagvi_aipinsdistperitperf As paginacion
	Private p_lista_vi_aipinsdistperitperf As  List(Of vi_aipinsdistperitperf)

	Public Property pagvi_aipinsdistperitperf() As paginacion
	Get
	Return Me.p_pagvi_aipinsdistperitperf
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsdistperitperf = Value
	End Set
	End Property

	Public Property lista_vi_aipinsdistperitperf() As List(Of vi_aipinsdistperitperf)
	Get
	Return Me.p_lista_vi_aipinsdistperitperf
	End Get
	Set(ByVal Value As List(Of vi_aipinsdistperitperf))
	Me.p_lista_vi_aipinsdistperitperf = Value
	End Set
	End Property
	End Class

End Namespace
