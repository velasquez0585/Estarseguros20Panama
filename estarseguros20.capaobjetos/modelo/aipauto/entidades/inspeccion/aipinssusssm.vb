Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinssusssm

		Private p_idaipinssusssm As Decimal
		Private p_idaipinssus As Decimal
		Private p_idaipmanvehssm As Decimal
		Private p_iexisinssusssm As Boolean
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinssus As aipinssus
        Private p_aipmanvehssm As aipmanvehssm

		Public Property idaipinssusssm() As Decimal
			Get
				Return Me.p_idaipinssusssm
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinssusssm = Value
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

		Public Property idaipmanvehssm() As Decimal
			Get
				Return Me.p_idaipmanvehssm
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehssm = Value
			End Set
		End Property

		Public Property iexisinssusssm() As Boolean
			Get
				Return Me.p_iexisinssusssm
			End Get
			Set(ByVal Value As Boolean)
				Me.p_iexisinssusssm = Value
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

        Public Property aipmanvehssm() As aipmanvehssm
            Get
                Return Me.p_aipmanvehssm
            End Get
            Set(ByVal Value As aipmanvehssm)
                Me.p_aipmanvehssm = Value
            End Set
        End Property
	End Class
	
	Public Class petiaipinssusssmpaglist

	Private p_pagaipinssusssm As paginacion
	Private p_aipinssusssm As aipinssusssm

	Public Property pagaipinssusssm() As paginacion
	Get
	Return Me.p_pagaipinssusssm
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinssusssm = Value
	End Set
	End Property

	Public Property aipinssusssm() As aipinssusssm
	Get
	Return Me.p_aipinssusssm
	End Get
	Set(ByVal Value As aipinssusssm)
	Me.p_aipinssusssm = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinssusssmpaglist

	Private p_pagaipinssusssm As paginacion
	Private p_lista_aipinssusssm As  List(Of aipinssusssm)

	Public Property pagaipinssusssm() As paginacion
	Get
	Return Me.p_pagaipinssusssm
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinssusssm = Value
	End Set
	End Property

	Public Property lista_aipinssusssm() As List(Of aipinssusssm)
	Get
	Return Me.p_lista_aipinssusssm
	End Get
	Set(ByVal Value As List(Of aipinssusssm))
	Me.p_lista_aipinssusssm = Value
	End Set
	End Property
	End Class

End Namespace
