Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinssusacc

		Private p_idaipinssusacc As Decimal
		Private p_idaipinssus As Decimal
		Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
		Private p_idaipmanvehacc As Decimal
		Private p_xnommanvehacc As String
        Private p_ioriginssusacc As Boolean
        Private p_inoexistinssusacc As Boolean
        Private p_inooriginssusacc As Boolean
        Private p_idseglogreg As Decimal

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

        Public Property idaipinsenc() As Decimal
            Get
                Return Me.p_idaipinsenc
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinsenc = Value
            End Set
        End Property

        Public Property itipoinsenc() As String
            Get
                Return Me.p_itipoinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_itipoinsenc = Value
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

        Public Property xnommanvehacc() As String
            Get
                Return Me.p_xnommanvehacc
            End Get
            Set(ByVal Value As String)
                Me.p_xnommanvehacc = Value
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

	End Class
	
	Public Class petivi_aipinssusaccpaglist

	Private p_pagvi_aipinssusacc As paginacion
	Private p_vi_aipinssusacc As vi_aipinssusacc

	Public Property pagvi_aipinssusacc() As paginacion
	Get
	Return Me.p_pagvi_aipinssusacc
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssusacc = Value
	End Set
	End Property

	Public Property vi_aipinssusacc() As vi_aipinssusacc
	Get
	Return Me.p_vi_aipinssusacc
	End Get
	Set(ByVal Value As vi_aipinssusacc)
	Me.p_vi_aipinssusacc = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinssusaccpaglist

	Private p_pagvi_aipinssusacc As paginacion
	Private p_lista_vi_aipinssusacc As  List(Of vi_aipinssusacc)

	Public Property pagvi_aipinssusacc() As paginacion
	Get
	Return Me.p_pagvi_aipinssusacc
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssusacc = Value
	End Set
	End Property

	Public Property lista_vi_aipinssusacc() As List(Of vi_aipinssusacc)
	Get
	Return Me.p_lista_vi_aipinssusacc
	End Get
	Set(ByVal Value As List(Of vi_aipinssusacc))
	Me.p_lista_vi_aipinssusacc = Value
	End Set
	End Property
	End Class

End Namespace
