Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsperitagrup

		Private p_idsegmanusuperit As Decimal
		Private p_xnombrecompletoperit As String
        Private p_idsegmanorgperit As Decimal
		Private p_xnombrecomercialperit As String
		Private p_ncantreg As Int32

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

		Public Property ncantreg() As Int32
			Get
				Return Me.p_ncantreg
			End Get
			Set(ByVal Value As Int32)
				Me.p_ncantreg = Value
			End Set
		End Property

	End Class
	
	Public Class petivi_aipinsperitagruppaglist

	Private p_pagvi_aipinsperitagrup As paginacion
	Private p_vi_aipinsperitagrup As vi_aipinsperitagrup

	Public Property pagvi_aipinsperitagrup() As paginacion
	Get
	Return Me.p_pagvi_aipinsperitagrup
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsperitagrup = Value
	End Set
	End Property

	Public Property vi_aipinsperitagrup() As vi_aipinsperitagrup
	Get
	Return Me.p_vi_aipinsperitagrup
	End Get
	Set(ByVal Value As vi_aipinsperitagrup)
	Me.p_vi_aipinsperitagrup = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsperitagruppaglist

	Private p_pagvi_aipinsperitagrup As paginacion
	Private p_lista_vi_aipinsperitagrup As  List(Of vi_aipinsperitagrup)

	Public Property pagvi_aipinsperitagrup() As paginacion
	Get
	Return Me.p_pagvi_aipinsperitagrup
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsperitagrup = Value
	End Set
	End Property

	Public Property lista_vi_aipinsperitagrup() As List(Of vi_aipinsperitagrup)
	Get
	Return Me.p_lista_vi_aipinsperitagrup
	End Get
	Set(ByVal Value As List(Of vi_aipinsperitagrup))
	Me.p_lista_vi_aipinsperitagrup = Value
	End Set
	End Property
	End Class

End Namespace
