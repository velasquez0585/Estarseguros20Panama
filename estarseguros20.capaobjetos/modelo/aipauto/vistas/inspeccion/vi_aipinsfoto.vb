Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsfoto

		Private p_idaipinsfoto As Decimal
		Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
        Private p_idsegmanusuperit As Decimal
		Private p_xcedpropinsenc As String
		Private p_xcedsidoinsenc As String
		Private p_xplacinsenc As String
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

		Public Property itipoinsenc() As String
			Get
				Return Me.p_itipoinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_itipoinsenc = Value
			End Set
		End Property

        Public Property idsegmanusuperit() As Decimal
            Get
                Return Me.p_idsegmanusuperit
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanusuperit = Value
            End Set
        End Property

		Public Property xcedpropinsenc() As String
			Get
				Return Me.p_xcedpropinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xcedpropinsenc = Value
			End Set
		End Property

		Public Property xcedsidoinsenc() As String
			Get
				Return Me.p_xcedsidoinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xcedsidoinsenc = Value
			End Set
		End Property

		Public Property xplacinsenc() As String
			Get
				Return Me.p_xplacinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xplacinsenc = Value
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

	End Class
	
	Public Class petivi_aipinsfotopaglist

	Private p_pagvi_aipinsfoto As paginacion
	Private p_vi_aipinsfoto As vi_aipinsfoto

	Public Property pagvi_aipinsfoto() As paginacion
	Get
	Return Me.p_pagvi_aipinsfoto
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsfoto = Value
	End Set
	End Property

	Public Property vi_aipinsfoto() As vi_aipinsfoto
	Get
	Return Me.p_vi_aipinsfoto
	End Get
	Set(ByVal Value As vi_aipinsfoto)
	Me.p_vi_aipinsfoto = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsfotopaglist

	Private p_pagvi_aipinsfoto As paginacion
	Private p_lista_vi_aipinsfoto As  List(Of vi_aipinsfoto)

	Public Property pagvi_aipinsfoto() As paginacion
	Get
	Return Me.p_pagvi_aipinsfoto
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsfoto = Value
	End Set
	End Property

	Public Property lista_vi_aipinsfoto() As List(Of vi_aipinsfoto)
	Get
	Return Me.p_lista_vi_aipinsfoto
	End Get
	Set(ByVal Value As List(Of vi_aipinsfoto))
	Me.p_lista_vi_aipinsfoto = Value
	End Set
	End Property
	End Class

End Namespace
