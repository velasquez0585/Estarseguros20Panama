Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsdistperitdet

		Private p_idsegmanusu As Decimal
		Private p_xnombrecompleto As String
		Private p_xnombreusuario As String
		Private p_idsegmanorg As Decimal
		Private p_idsegmanapp As Decimal
		Private p_idsegmanperf As Decimal
		Private p_xnombreperf As String
		Private p_ibloqueado As Boolean
		Private p_ncantinsperit As Int32

		Public Property idsegmanusu() As Decimal
			Get
				Return Me.p_idsegmanusu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idsegmanusu = Value
			End Set
		End Property

		Public Property xnombrecompleto() As String
			Get
				Return Me.p_xnombrecompleto
			End Get
			Set(ByVal Value As String)
				Me.p_xnombrecompleto = Value
			End Set
		End Property

		Public Property xnombreusuario() As String
			Get
				Return Me.p_xnombreusuario
			End Get
			Set(ByVal Value As String)
				Me.p_xnombreusuario = Value
			End Set
		End Property

		Public Property idsegmanorg() As Decimal
			Get
				Return Me.p_idsegmanorg
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idsegmanorg = Value
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
	
	Public Class petivi_aipinsdistperitdetpaglist

	Private p_pagvi_aipinsdistperitdet As paginacion
	Private p_vi_aipinsdistperitdet As vi_aipinsdistperitdet

	Public Property pagvi_aipinsdistperitdet() As paginacion
	Get
	Return Me.p_pagvi_aipinsdistperitdet
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsdistperitdet = Value
	End Set
	End Property

	Public Property vi_aipinsdistperitdet() As vi_aipinsdistperitdet
	Get
	Return Me.p_vi_aipinsdistperitdet
	End Get
	Set(ByVal Value As vi_aipinsdistperitdet)
	Me.p_vi_aipinsdistperitdet = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsdistperitdetpaglist

	Private p_pagvi_aipinsdistperitdet As paginacion
	Private p_lista_vi_aipinsdistperitdet As  List(Of vi_aipinsdistperitdet)

	Public Property pagvi_aipinsdistperitdet() As paginacion
	Get
	Return Me.p_pagvi_aipinsdistperitdet
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsdistperitdet = Value
	End Set
	End Property

	Public Property lista_vi_aipinsdistperitdet() As List(Of vi_aipinsdistperitdet)
	Get
	Return Me.p_lista_vi_aipinsdistperitdet
	End Get
	Set(ByVal Value As List(Of vi_aipinsdistperitdet))
	Me.p_lista_vi_aipinsdistperitdet = Value
	End Set
	End Property
	End Class

End Namespace
