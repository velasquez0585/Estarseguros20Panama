Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinssin

		Private p_idaipinssin As Decimal
		Private p_idaipinsenc As Decimal
        Private p_itipoinsenc As String
        Private p_idaipinsmotiv As Decimal
        Private p_xnominsmotiv As String
		Private p_idsegmanusuperit As Decimal
		Private p_xcedula As String
		Private p_xnombres As String
		Private p_xapellidos As String
		Private p_xnombrecompleto As String
		Private p_xcedpropinsenc As String
		Private p_xcedsidoinsenc As String
		Private p_xplacinsenc As String
		Private p_xsermotinsenc As String
		Private p_xsercarrinsenc As String
		Private p_xnumpolinsenc As String
		Private p_xnumsininsenc As String
		Private p_nfactinssin As Decimal
		Private p_irepuinssin As Boolean
		Private p_imobrinssin As Boolean
		Private p_xnomaseginssin As String
		Private p_idaipmanveh As Decimal
		Private p_idaipmanvehmar As Decimal
		Private p_xnommanvehmar As String
		Private p_idaipmanvehmod As Decimal
		Private p_xnommanvehmod As String
		Private p_idaipmanvehver As Decimal
		Private p_xnommanvehver As String
		Private p_itipotransmanveh As String
		Private p_itipomanveh As String
		Private p_iclasemanveh As String
		Private p_icolormanveh As String
		Private p_xplacamanveh As String
		Private p_xsercarrmanveh As String
		Private p_xsermotmanveh As String
		Private p_xsucuinssin As String
		Private p_nkiloinssin As Int32
		Private p_xdescinssin As String
		Private p_iestatinssin As String
		Private p_idseglogreg As Decimal

		Public Property idaipinssin() As Decimal
			Get
				Return Me.p_idaipinssin
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinssin = Value
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

        Public Property idaipinsmotiv() As Decimal
            Get
                Return Me.p_idaipinsmotiv
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinsmotiv = Value
            End Set
        End Property

        Public Property xnominsmotiv() As String
            Get
                Return Me.p_xnominsmotiv
            End Get
            Set(ByVal Value As String)
                Me.p_xnominsmotiv = Value
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

		Public Property xcedula() As String
			Get
				Return Me.p_xcedula
			End Get
			Set(ByVal Value As String)
				Me.p_xcedula = Value
			End Set
		End Property

		Public Property xnombres() As String
			Get
				Return Me.p_xnombres
			End Get
			Set(ByVal Value As String)
				Me.p_xnombres = Value
			End Set
		End Property

		Public Property xapellidos() As String
			Get
				Return Me.p_xapellidos
			End Get
			Set(ByVal Value As String)
				Me.p_xapellidos = Value
			End Set
		End Property

		Public Property xnombrecompleto() As String
			Get
				Return Me.p_xnombrecompleto
			End Get
			Set(ByVal Value As String)
				Me.p_xnombrecompleto = Value
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

		Public Property xsermotinsenc() As String
			Get
				Return Me.p_xsermotinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xsermotinsenc = Value
			End Set
		End Property

		Public Property xsercarrinsenc() As String
			Get
				Return Me.p_xsercarrinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xsercarrinsenc = Value
			End Set
		End Property

		Public Property xnumpolinsenc() As String
			Get
				Return Me.p_xnumpolinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xnumpolinsenc = Value
			End Set
		End Property

		Public Property xnumsininsenc() As String
			Get
				Return Me.p_xnumsininsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xnumsininsenc = Value
			End Set
		End Property

		Public Property nfactinssin() As Decimal
			Get
				Return Me.p_nfactinssin
			End Get
			Set(ByVal Value As Decimal)
				Me.p_nfactinssin = Value
			End Set
		End Property

		Public Property irepuinssin() As Boolean
			Get
				Return Me.p_irepuinssin
			End Get
			Set(ByVal Value As Boolean)
				Me.p_irepuinssin = Value
			End Set
		End Property

		Public Property imobrinssin() As Boolean
			Get
				Return Me.p_imobrinssin
			End Get
			Set(ByVal Value As Boolean)
				Me.p_imobrinssin = Value
			End Set
		End Property

		Public Property xnomaseginssin() As String
			Get
				Return Me.p_xnomaseginssin
			End Get
			Set(ByVal Value As String)
				Me.p_xnomaseginssin = Value
			End Set
		End Property

		Public Property idaipmanveh() As Decimal
			Get
				Return Me.p_idaipmanveh
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanveh = Value
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

		Public Property xnommanvehmar() As String
			Get
				Return Me.p_xnommanvehmar
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehmar = Value
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

		Public Property xnommanvehmod() As String
			Get
				Return Me.p_xnommanvehmod
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehmod = Value
			End Set
		End Property

		Public Property idaipmanvehver() As Decimal
			Get
				Return Me.p_idaipmanvehver
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehver = Value
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

		Public Property itipotransmanveh() As String
			Get
				Return Me.p_itipotransmanveh
			End Get
			Set(ByVal Value As String)
				Me.p_itipotransmanveh = Value
			End Set
		End Property

		Public Property itipomanveh() As String
			Get
				Return Me.p_itipomanveh
			End Get
			Set(ByVal Value As String)
				Me.p_itipomanveh = Value
			End Set
		End Property

		Public Property iclasemanveh() As String
			Get
				Return Me.p_iclasemanveh
			End Get
			Set(ByVal Value As String)
				Me.p_iclasemanveh = Value
			End Set
		End Property

		Public Property icolormanveh() As String
			Get
				Return Me.p_icolormanveh
			End Get
			Set(ByVal Value As String)
				Me.p_icolormanveh = Value
			End Set
		End Property

		Public Property xplacamanveh() As String
			Get
				Return Me.p_xplacamanveh
			End Get
			Set(ByVal Value As String)
				Me.p_xplacamanveh = Value
			End Set
		End Property

		Public Property xsercarrmanveh() As String
			Get
				Return Me.p_xsercarrmanveh
			End Get
			Set(ByVal Value As String)
				Me.p_xsercarrmanveh = Value
			End Set
		End Property

		Public Property xsermotmanveh() As String
			Get
				Return Me.p_xsermotmanveh
			End Get
			Set(ByVal Value As String)
				Me.p_xsermotmanveh = Value
			End Set
		End Property

		Public Property xsucuinssin() As String
			Get
				Return Me.p_xsucuinssin
			End Get
			Set(ByVal Value As String)
				Me.p_xsucuinssin = Value
			End Set
		End Property

		Public Property nkiloinssin() As Int32
			Get
				Return Me.p_nkiloinssin
			End Get
			Set(ByVal Value As Int32)
				Me.p_nkiloinssin = Value
			End Set
		End Property

		Public Property xdescinssin() As String
			Get
				Return Me.p_xdescinssin
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinssin = Value
			End Set
		End Property

		Public Property iestatinssin() As String
			Get
				Return Me.p_iestatinssin
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinssin = Value
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
	
	Public Class petivi_aipinssinpaglist

	Private p_pagvi_aipinssin As paginacion
	Private p_vi_aipinssin As vi_aipinssin

	Public Property pagvi_aipinssin() As paginacion
	Get
	Return Me.p_pagvi_aipinssin
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssin = Value
	End Set
	End Property

	Public Property vi_aipinssin() As vi_aipinssin
	Get
	Return Me.p_vi_aipinssin
	End Get
	Set(ByVal Value As vi_aipinssin)
	Me.p_vi_aipinssin = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinssinpaglist

	Private p_pagvi_aipinssin As paginacion
	Private p_lista_vi_aipinssin As  List(Of vi_aipinssin)

	Public Property pagvi_aipinssin() As paginacion
	Get
	Return Me.p_pagvi_aipinssin
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssin = Value
	End Set
	End Property

	Public Property lista_vi_aipinssin() As List(Of vi_aipinssin)
	Get
	Return Me.p_lista_vi_aipinssin
	End Get
	Set(ByVal Value As List(Of vi_aipinssin))
	Me.p_lista_vi_aipinssin = Value
	End Set
	End Property
	End Class

End Namespace
