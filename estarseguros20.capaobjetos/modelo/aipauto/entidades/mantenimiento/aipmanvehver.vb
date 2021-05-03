Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.entidades.mantenimiento

	Public Class aipmanvehver

		Private p_idaipmanvehver As Decimal
		Private p_idaipmanvehmod As Decimal
		Private p_xnommanvehver As String
		Private p_naniomanvehver As Int16
		Private p_xdescmanvehver As String
		Private p_iestatmanvehver As String
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipmanvehmod As aipmanvehmod
        Private p_aipmanveh As List(Of aipmanveh)


		Public Property idaipmanvehver() As Decimal
			Get
				Return Me.p_idaipmanvehver
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehver = Value
			End Set
		End Property

		Public Property idaipmanvehmod() As Decimal
			Get
				Return Me.p_idaipmanvehmod
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehmod = Value
			End Set
		End Property

		Public Property xnommanvehver() As String
			Get
				Return Me.p_xnommanvehver
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehver = Value
			End Set
		End Property

		Public Property naniomanvehver() As Int16
			Get
				Return Me.p_naniomanvehver
			End Get
			Set(ByVal Value As Int16)
				Me.p_naniomanvehver = Value
			End Set
		End Property

		Public Property xdescmanvehver() As String
			Get
				Return Me.p_xdescmanvehver
			End Get
			Set(ByVal Value As String)
				Me.p_xdescmanvehver = Value
			End Set
		End Property

		Public Property iestatmanvehver() As String
			Get
				Return Me.p_iestatmanvehver
			End Get
			Set(ByVal Value As String)
				Me.p_iestatmanvehver = Value
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

        Public Property aipmanvehmod() As aipmanvehmod
            Get
                Return Me.p_aipmanvehmod
            End Get
            Set(ByVal Value As aipmanvehmod)
                Me.p_aipmanvehmod = Value
            End Set
        End Property

        Public Property aipmanveh() As List(Of aipmanveh)
            Get
                Return Me.p_aipmanveh
            End Get
            Set(ByVal Value As List(Of aipmanveh))
                Me.p_aipmanveh = Value
            End Set
        End Property

	End Class
	
	Public Class petiaipmanvehverpaglist

	Private p_pagaipmanvehver As paginacion
	Private p_aipmanvehver As aipmanvehver

	Public Property pagaipmanvehver() As paginacion
	Get
	Return Me.p_pagaipmanvehver
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanvehver = Value
	End Set
	End Property

	Public Property aipmanvehver() As aipmanvehver
	Get
	Return Me.p_aipmanvehver
	End Get
	Set(ByVal Value As aipmanvehver)
	Me.p_aipmanvehver = Value
	End Set
	End Property
	End Class
	
	Public Class respaipmanvehverpaglist

	Private p_pagaipmanvehver As paginacion
	Private p_lista_aipmanvehver As  List(Of aipmanvehver)

	Public Property pagaipmanvehver() As paginacion
	Get
	Return Me.p_pagaipmanvehver
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanvehver = Value
	End Set
	End Property

	Public Property lista_aipmanvehver() As List(Of aipmanvehver)
	Get
	Return Me.p_lista_aipmanvehver
	End Get
	Set(ByVal Value As List(Of aipmanvehver))
	Me.p_lista_aipmanvehver = Value
	End Set
	End Property
	End Class

End Namespace
