Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.entidades.mantenimiento

	Public Class aipmanvehmar

		Private p_idaipmanvehmar As Decimal
		Private p_xnommanvehmar As String
		Private p_xdescmanvehmar As String
		Private p_iestatmanvehmar As String
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipmanveh As List(Of aipmanveh)
        Private p_aipmanvehmod As List(Of aipmanvehmod)


		Public Property idaipmanvehmar() As Decimal
			Get
				Return Me.p_idaipmanvehmar
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehmar = Value
			End Set
		End Property

		Public Property xnommanvehmar() As String
			Get
				Return Me.p_xnommanvehmar
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehmar = Value
			End Set
		End Property

		Public Property xdescmanvehmar() As String
			Get
				Return Me.p_xdescmanvehmar
			End Get
			Set(ByVal Value As String)
				Me.p_xdescmanvehmar = Value
			End Set
		End Property

		Public Property iestatmanvehmar() As String
			Get
				Return Me.p_iestatmanvehmar
			End Get
			Set(ByVal Value As String)
				Me.p_iestatmanvehmar = Value
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
        Public Property aipmanveh() As List(Of aipmanveh)
            Get
                Return Me.p_aipmanveh
            End Get
            Set(ByVal Value As List(Of aipmanveh))
                Me.p_aipmanveh = Value
            End Set
        End Property

        Public Property aipmanvehmod() As List(Of aipmanvehmod)
            Get
                Return Me.p_aipmanvehmod
            End Get
            Set(ByVal Value As List(Of aipmanvehmod))
                Me.p_aipmanvehmod = Value
            End Set
        End Property



	End Class
	
	Public Class petiaipmanvehmarpaglist

	Private p_pagaipmanvehmar As paginacion
	Private p_aipmanvehmar As aipmanvehmar

	Public Property pagaipmanvehmar() As paginacion
	Get
	Return Me.p_pagaipmanvehmar
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanvehmar = Value
	End Set
	End Property

	Public Property aipmanvehmar() As aipmanvehmar
	Get
	Return Me.p_aipmanvehmar
	End Get
	Set(ByVal Value As aipmanvehmar)
	Me.p_aipmanvehmar = Value
	End Set
	End Property
	End Class
	
	Public Class respaipmanvehmarpaglist

	Private p_pagaipmanvehmar As paginacion
	Private p_lista_aipmanvehmar As  List(Of aipmanvehmar)

	Public Property pagaipmanvehmar() As paginacion
	Get
	Return Me.p_pagaipmanvehmar
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanvehmar = Value
	End Set
	End Property

	Public Property lista_aipmanvehmar() As List(Of aipmanvehmar)
	Get
	Return Me.p_lista_aipmanvehmar
	End Get
	Set(ByVal Value As List(Of aipmanvehmar))
	Me.p_lista_aipmanvehmar = Value
	End Set
	End Property
	End Class

End Namespace
