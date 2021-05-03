Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinsrestsse

		Private p_idaipinsrestsse As Decimal
		Private p_idaipinsrest As Decimal
		Private p_idaipmanvehsse As Decimal
		Private p_iexisinsrestsse As Boolean
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsrest As aipinsrest
        Private p_aipmanvehsse As aipmanvehsse


		Public Property idaipinsrestsse() As Decimal
			Get
				Return Me.p_idaipinsrestsse
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsrestsse = Value
			End Set
		End Property

		Public Property idaipinsrest() As Decimal
			Get
				Return Me.p_idaipinsrest
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsrest = Value
			End Set
		End Property

		Public Property idaipmanvehsse() As Decimal
			Get
				Return Me.p_idaipmanvehsse
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehsse = Value
			End Set
		End Property

		Public Property iexisinsrestsse() As Boolean
			Get
				Return Me.p_iexisinsrestsse
			End Get
			Set(ByVal Value As Boolean)
				Me.p_iexisinsrestsse = Value
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
        Public Property aipinsrest() As aipinsrest
            Get
                Return Me.p_aipinsrest
            End Get
            Set(ByVal Value As aipinsrest)
                Me.p_aipinsrest = Value
            End Set
        End Property
        Public Property aipmanvehsse() As aipmanvehsse
            Get
                Return Me.p_aipmanvehsse
            End Get
            Set(ByVal Value As aipmanvehsse)
                Me.p_aipmanvehsse = Value
            End Set
        End Property


	End Class
	
	Public Class petiaipinsrestssepaglist

	Private p_pagaipinsrestsse As paginacion
	Private p_aipinsrestsse As aipinsrestsse

	Public Property pagaipinsrestsse() As paginacion
	Get
	Return Me.p_pagaipinsrestsse
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsrestsse = Value
	End Set
	End Property

	Public Property aipinsrestsse() As aipinsrestsse
	Get
	Return Me.p_aipinsrestsse
	End Get
	Set(ByVal Value As aipinsrestsse)
	Me.p_aipinsrestsse = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinsrestssepaglist

	Private p_pagaipinsrestsse As paginacion
	Private p_lista_aipinsrestsse As  List(Of aipinsrestsse)

	Public Property pagaipinsrestsse() As paginacion
	Get
	Return Me.p_pagaipinsrestsse
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsrestsse = Value
	End Set
	End Property

	Public Property lista_aipinsrestsse() As List(Of aipinsrestsse)
	Get
	Return Me.p_lista_aipinsrestsse
	End Get
	Set(ByVal Value As List(Of aipinsrestsse))
	Me.p_lista_aipinsrestsse = Value
	End Set
	End Property
	End Class

End Namespace
