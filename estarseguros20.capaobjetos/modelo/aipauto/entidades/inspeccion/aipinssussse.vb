Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinssussse

		Private p_idaipinssussse As Decimal
		Private p_idaipinssus As Decimal
		Private p_idaipmanvehsse As Decimal
		Private p_iexisinssussse As Int32
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinssus As aipinssus
        Private p_aipmanvehsse As aipmanvehsse


		Public Property idaipinssussse() As Decimal
			Get
				Return Me.p_idaipinssussse
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinssussse = Value
			End Set
		End Property

		Public Property idaipinssus() As Decimal
			Get
				Return Me.p_idaipinssus
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinssus = Value
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

		Public Property iexisinssussse() As Int32
			Get
				Return Me.p_iexisinssussse
			End Get
			Set(ByVal Value As Int32)
				Me.p_iexisinssussse = Value
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

        Public Property aipinssus() As aipinssus
            Get
                Return Me.p_aipinssus
            End Get
            Set(ByVal Value As aipinssus)
                Me.p_aipinssus = Value
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
	
	Public Class petiaipinssusssepaglist

	Private p_pagaipinssussse As paginacion
	Private p_aipinssussse As aipinssussse

	Public Property pagaipinssussse() As paginacion
	Get
	Return Me.p_pagaipinssussse
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinssussse = Value
	End Set
	End Property

	Public Property aipinssussse() As aipinssussse
	Get
	Return Me.p_aipinssussse
	End Get
	Set(ByVal Value As aipinssussse)
	Me.p_aipinssussse = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinssusssepaglist

	Private p_pagaipinssussse As paginacion
	Private p_lista_aipinssussse As  List(Of aipinssussse)

	Public Property pagaipinssussse() As paginacion
	Get
	Return Me.p_pagaipinssussse
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinssussse = Value
	End Set
	End Property

	Public Property lista_aipinssussse() As List(Of aipinssussse)
	Get
	Return Me.p_lista_aipinssussse
	End Get
	Set(ByVal Value As List(Of aipinssussse))
	Me.p_lista_aipinssussse = Value
	End Set
	End Property
	End Class

End Namespace
