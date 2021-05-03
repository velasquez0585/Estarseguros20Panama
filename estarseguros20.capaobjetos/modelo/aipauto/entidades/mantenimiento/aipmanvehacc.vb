Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Namespace aipauto.modelo.dbestarseguros20.entidades.mantenimiento

	Public Class aipmanvehacc

		Private p_idaipmanvehacc As Decimal
        Private p_xnommanvehacc As String
        Private p_nordenmanvehacc As Short
		Private p_xdescmanvehacc As String
		Private p_iestatmanvehacc As String
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinssusacc As List(Of aipinssusacc)


		Public Property idaipmanvehacc() As Decimal
			Get
				Return Me.p_idaipmanvehacc
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehacc = Value
			End Set
		End Property

		Public Property xnommanvehacc() As String
			Get
				Return Me.p_xnommanvehacc
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehacc = Value
			End Set
        End Property

        Public Property nordenmanvehacc() As Short
            Get
                Return Me.p_nordenmanvehacc
            End Get
            Set(ByVal Value As Short)
                Me.p_nordenmanvehacc = Value
            End Set
        End Property

		Public Property xdescmanvehacc() As String
			Get
				Return Me.p_xdescmanvehacc
			End Get
			Set(ByVal Value As String)
				Me.p_xdescmanvehacc = Value
			End Set
		End Property

		Public Property iestatmanvehacc() As String
			Get
				Return Me.p_iestatmanvehacc
			End Get
			Set(ByVal Value As String)
				Me.p_iestatmanvehacc = Value
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

        Public Property aipinssusacc() As List(Of aipinssusacc)
            Get
                Return Me.p_aipinssusacc
            End Get
            Set(ByVal Value As List(Of aipinssusacc))
                Me.p_aipinssusacc = Value
            End Set
        End Property
	End Class
	
	Public Class petiaipmanvehaccpaglist

	Private p_pagaipmanvehacc As paginacion
	Private p_aipmanvehacc As aipmanvehacc

	Public Property pagaipmanvehacc() As paginacion
	Get
	Return Me.p_pagaipmanvehacc
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanvehacc = Value
	End Set
	End Property

	Public Property aipmanvehacc() As aipmanvehacc
	Get
	Return Me.p_aipmanvehacc
	End Get
	Set(ByVal Value As aipmanvehacc)
	Me.p_aipmanvehacc = Value
	End Set
	End Property
	End Class
	
	Public Class respaipmanvehaccpaglist

	Private p_pagaipmanvehacc As paginacion
	Private p_lista_aipmanvehacc As  List(Of aipmanvehacc)

	Public Property pagaipmanvehacc() As paginacion
	Get
	Return Me.p_pagaipmanvehacc
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanvehacc = Value
	End Set
	End Property

	Public Property lista_aipmanvehacc() As List(Of aipmanvehacc)
	Get
	Return Me.p_lista_aipmanvehacc
	End Get
	Set(ByVal Value As List(Of aipmanvehacc))
	Me.p_lista_aipmanvehacc = Value
	End Set
	End Property
	End Class

End Namespace
