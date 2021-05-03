Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsdistauditperf

		Private p_idsegmanusuaudit As Decimal
		Private p_xnombrecompletoaudit As String
		Private p_idsegmanorgaudit As Decimal
		Private p_xnombrecomercialaudit As String
		Private p_idsegmanapp As Decimal
		Private p_idsegmanperf As Decimal
		Private p_xnombreperf As String
		Private p_ibloqueado As Boolean
		Private p_ncantinsperit As Int32

		Public Property idsegmanusuaudit() As Decimal
			Get
				Return Me.p_idsegmanusuaudit
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idsegmanusuaudit = Value
			End Set
		End Property

		Public Property xnombrecompletoaudit() As String
			Get
				Return Me.p_xnombrecompletoaudit
			End Get
			Set(ByVal Value As String)
				Me.p_xnombrecompletoaudit = Value
			End Set
		End Property

		Public Property idsegmanorgaudit() As Decimal
			Get
				Return Me.p_idsegmanorgaudit
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idsegmanorgaudit = Value
			End Set
		End Property

		Public Property xnombrecomercialaudit() As String
			Get
				Return Me.p_xnombrecomercialaudit
			End Get
			Set(ByVal Value As String)
				Me.p_xnombrecomercialaudit = Value
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
	
	Public Class petivi_aipinsdistauditperfpaglist

	Private p_pagvi_aipinsdistauditperf As paginacion
	Private p_vi_aipinsdistauditperf As vi_aipinsdistauditperf

	Public Property pagvi_aipinsdistauditperf() As paginacion
	Get
	Return Me.p_pagvi_aipinsdistauditperf
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsdistauditperf = Value
	End Set
	End Property

	Public Property vi_aipinsdistauditperf() As vi_aipinsdistauditperf
	Get
	Return Me.p_vi_aipinsdistauditperf
	End Get
	Set(ByVal Value As vi_aipinsdistauditperf)
	Me.p_vi_aipinsdistauditperf = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsdistauditperfpaglist

	Private p_pagvi_aipinsdistauditperf As paginacion
	Private p_lista_vi_aipinsdistauditperf As  List(Of vi_aipinsdistauditperf)

	Public Property pagvi_aipinsdistauditperf() As paginacion
	Get
	Return Me.p_pagvi_aipinsdistauditperf
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsdistauditperf = Value
	End Set
	End Property

	Public Property lista_vi_aipinsdistauditperf() As List(Of vi_aipinsdistauditperf)
	Get
	Return Me.p_lista_vi_aipinsdistauditperf
	End Get
	Set(ByVal Value As List(Of vi_aipinsdistauditperf))
	Me.p_lista_vi_aipinsdistauditperf = Value
	End Set
	End Property
	End Class

End Namespace
