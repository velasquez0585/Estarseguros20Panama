Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinssusacc

		Private p_idaipinssusacc As Decimal
		Private p_idaipinssus As Decimal
		Private p_idaipmanvehacc As Decimal
        Private p_ioriginssusacc As Boolean
        Private p_inoexistinssusacc As Boolean
        Private p_inooriginssusacc As Boolean
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinssus As aipinssus
        Private p_aipmanvehacc As aipmanvehacc

        Public Property idaipinssusacc() As Decimal
            Get
                Return Me.p_idaipinssusacc
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinssusacc = Value
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

        Public Property idaipmanvehacc() As Decimal
            Get
                Return Me.p_idaipmanvehacc
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipmanvehacc = Value
            End Set
        End Property

        Public Property ioriginssusacc() As Boolean
            Get
                Return Me.p_ioriginssusacc
            End Get
            Set(ByVal Value As Boolean)
                Me.p_ioriginssusacc = Value
            End Set
        End Property

        Public Property inoexistinssusacc() As Boolean
            Get
                Return Me.p_inoexistinssusacc
            End Get
            Set(ByVal Value As Boolean)
                Me.p_inoexistinssusacc = Value
            End Set
        End Property

        Public Property inooriginssusacc() As Boolean
            Get
                Return Me.p_inooriginssusacc
            End Get
            Set(ByVal Value As Boolean)
                Me.p_inooriginssusacc = Value
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
        Public Property aipmanvehacc() As aipmanvehacc
            Get
                Return Me.p_aipmanvehacc
            End Get
            Set(ByVal Value As aipmanvehacc)
                Me.p_aipmanvehacc = Value
            End Set
        End Property


	End Class
	
	Public Class petiaipinssusaccpaglist

	Private p_pagaipinssusacc As paginacion
	Private p_aipinssusacc As aipinssusacc

	Public Property pagaipinssusacc() As paginacion
	Get
	Return Me.p_pagaipinssusacc
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinssusacc = Value
	End Set
	End Property

	Public Property aipinssusacc() As aipinssusacc
	Get
	Return Me.p_aipinssusacc
	End Get
	Set(ByVal Value As aipinssusacc)
	Me.p_aipinssusacc = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinssusaccpaglist

	Private p_pagaipinssusacc As paginacion
	Private p_lista_aipinssusacc As  List(Of aipinssusacc)

	Public Property pagaipinssusacc() As paginacion
	Get
	Return Me.p_pagaipinssusacc
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinssusacc = Value
	End Set
	End Property

	Public Property lista_aipinssusacc() As List(Of aipinssusacc)
	Get
	Return Me.p_lista_aipinssusacc
	End Get
	Set(ByVal Value As List(Of aipinssusacc))
	Me.p_lista_aipinssusacc = Value
	End Set
	End Property
	End Class

End Namespace
