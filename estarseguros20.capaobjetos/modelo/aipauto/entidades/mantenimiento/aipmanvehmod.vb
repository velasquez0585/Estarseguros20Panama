Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.entidades.mantenimiento

	Public Class aipmanvehmod

		Private p_idaipmanvehmod As Decimal
		Private p_idaipmanvehmar As Decimal
		Private p_xnommanvehmod As String
		Private p_xdescmanvehmod As String
		Private p_iestatmanvehmod As String
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipmanvehmar As aipmanvehmar
        Private p_aipmanveh As List(Of aipmanveh)
        Private p_aipmanvehver As List(Of aipmanvehver)


		Public Property idaipmanvehmod() As Decimal
			Get
				Return Me.p_idaipmanvehmod
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehmod = Value
			End Set
		End Property

		Public Property idaipmanvehmar() As Decimal
			Get
				Return Me.p_idaipmanvehmar
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehmar = Value
			End Set
		End Property

		Public Property xnommanvehmod() As String
			Get
				Return Me.p_xnommanvehmod
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehmod = Value
			End Set
		End Property

		Public Property xdescmanvehmod() As String
			Get
				Return Me.p_xdescmanvehmod
			End Get
			Set(ByVal Value As String)
				Me.p_xdescmanvehmod = Value
			End Set
		End Property

		Public Property iestatmanvehmod() As String
			Get
				Return Me.p_iestatmanvehmod
			End Get
			Set(ByVal Value As String)
				Me.p_iestatmanvehmod = Value
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
        Public Property aipmanvehmar() As aipmanvehmar
            Get
                Return Me.p_aipmanvehmar
            End Get
            Set(ByVal Value As aipmanvehmar)
                Me.p_aipmanvehmar = Value
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

        Public Property aipmanvehver() As List(Of aipmanvehver)
            Get
                Return Me.p_aipmanvehver
            End Get
            Set(ByVal Value As List(Of aipmanvehver))
                Me.p_aipmanvehver = Value
            End Set
        End Property


	End Class
	
	Public Class petiaipmanvehmodpaglist

	Private p_pagaipmanvehmod As paginacion
	Private p_aipmanvehmod As aipmanvehmod

	Public Property pagaipmanvehmod() As paginacion
	Get
	Return Me.p_pagaipmanvehmod
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanvehmod = Value
	End Set
	End Property

	Public Property aipmanvehmod() As aipmanvehmod
	Get
	Return Me.p_aipmanvehmod
	End Get
	Set(ByVal Value As aipmanvehmod)
	Me.p_aipmanvehmod = Value
	End Set
	End Property
	End Class
	
	Public Class respaipmanvehmodpaglist

	Private p_pagaipmanvehmod As paginacion
	Private p_lista_aipmanvehmod As  List(Of aipmanvehmod)

	Public Property pagaipmanvehmod() As paginacion
	Get
	Return Me.p_pagaipmanvehmod
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanvehmod = Value
	End Set
	End Property

	Public Property lista_aipmanvehmod() As List(Of aipmanvehmod)
	Get
	Return Me.p_lista_aipmanvehmod
	End Get
	Set(ByVal Value As List(Of aipmanvehmod))
	Me.p_lista_aipmanvehmod = Value
	End Set
	End Property
	End Class

End Namespace
