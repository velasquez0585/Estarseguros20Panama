Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinsfoto

		Private p_idaipinsfoto As Decimal
		Private p_idaipinsenc As Decimal
		Private p_nsecinsfoto As Int16
		Private p_xrutainsfoto As String
		Private p_xurlinsfoto As String
		Private p_xtituinsfoto As String
		Private p_xnomarchinsfoto As String
        Private p_xextinsfoto As String
        Private p_xlatcinsfoto As String
        Private p_xlonginsfoto As String
        Private p_ioriginsfoto As String
		Private p_xdescinsfoto As String
        Private p_iestatinsfoto As String
        Private p_fcreaaipinsfoto As DateTime
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsenc As aipinsenc

		Public Property idaipinsfoto() As Decimal
			Get
				Return Me.p_idaipinsfoto
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsfoto = Value
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

		Public Property nsecinsfoto() As Int16
			Get
				Return Me.p_nsecinsfoto
			End Get
			Set(ByVal Value As Int16)
				Me.p_nsecinsfoto = Value
			End Set
		End Property

		Public Property xrutainsfoto() As String
			Get
				Return Me.p_xrutainsfoto
			End Get
			Set(ByVal Value As String)
				Me.p_xrutainsfoto = Value
			End Set
		End Property

		Public Property xurlinsfoto() As String
			Get
				Return Me.p_xurlinsfoto
			End Get
			Set(ByVal Value As String)
				Me.p_xurlinsfoto = Value
			End Set
		End Property

		Public Property xtituinsfoto() As String
			Get
				Return Me.p_xtituinsfoto
			End Get
			Set(ByVal Value As String)
				Me.p_xtituinsfoto = Value
			End Set
		End Property

		Public Property xnomarchinsfoto() As String
			Get
				Return Me.p_xnomarchinsfoto
			End Get
			Set(ByVal Value As String)
				Me.p_xnomarchinsfoto = Value
			End Set
		End Property

		Public Property xextinsfoto() As String
			Get
				Return Me.p_xextinsfoto
			End Get
			Set(ByVal Value As String)
				Me.p_xextinsfoto = Value
			End Set
		End Property

        Public Property xlatcinsfoto() As String
            Get
                Return Me.p_xlatcinsfoto
            End Get
            Set(ByVal Value As String)
                Me.p_xlatcinsfoto = Value
            End Set
        End Property

        Public Property xlonginsfoto() As String
            Get
                Return Me.p_xlonginsfoto
            End Get
            Set(ByVal Value As String)
                Me.p_xlonginsfoto = Value
            End Set
        End Property

        Public Property ioriginsfoto() As String
            Get
                Return Me.p_ioriginsfoto
            End Get
            Set(ByVal Value As String)
                Me.p_ioriginsfoto = Value
            End Set
        End Property

		Public Property xdescinsfoto() As String
			Get
				Return Me.p_xdescinsfoto
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinsfoto = Value
			End Set
		End Property

		Public Property iestatinsfoto() As String
			Get
				Return Me.p_iestatinsfoto
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinsfoto = Value
			End Set
		End Property

        Public Property fcreaaipinsfoto() As DateTime
            Get
                Return Me.p_fcreaaipinsfoto
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fcreaaipinsfoto = Value
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
        Public Property aipinsenc() As aipinsenc
            Get
                Return Me.p_aipinsenc
            End Get
            Set(ByVal Value As aipinsenc)
                Me.p_aipinsenc = Value
            End Set
        End Property
	End Class
	
	Public Class petiaipinsfotopaglist

	Private p_pagaipinsfoto As paginacion
	Private p_aipinsfoto As aipinsfoto

	Public Property pagaipinsfoto() As paginacion
	Get
	Return Me.p_pagaipinsfoto
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsfoto = Value
	End Set
	End Property

	Public Property aipinsfoto() As aipinsfoto
	Get
	Return Me.p_aipinsfoto
	End Get
	Set(ByVal Value As aipinsfoto)
	Me.p_aipinsfoto = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinsfotopaglist

	Private p_pagaipinsfoto As paginacion
	Private p_lista_aipinsfoto As  List(Of aipinsfoto)

	Public Property pagaipinsfoto() As paginacion
	Get
	Return Me.p_pagaipinsfoto
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsfoto = Value
	End Set
	End Property

	Public Property lista_aipinsfoto() As List(Of aipinsfoto)
	Get
	Return Me.p_lista_aipinsfoto
	End Get
	Set(ByVal Value As List(Of aipinsfoto))
	Me.p_lista_aipinsfoto = Value
	End Set
	End Property
	End Class

End Namespace
