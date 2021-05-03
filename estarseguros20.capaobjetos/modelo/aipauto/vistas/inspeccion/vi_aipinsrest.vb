Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsrest

        Private p_idaipinsrest As Decimal
        Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
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
		Private p_xllavinsenc As String
		Private p_fcreainsenc As DateTime
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
		Private p_itraccmanveh As String
		Private p_iimpmanveh As Boolean
		Private p_ncilinmanveh As Int16
		Private p_xcargmanveh As String
		Private p_xcapmanveh As String
		Private p_xsucuinsrest As String
		Private p_nkiloinsrest As Int32
		Private p_idcomunmanestado As Decimal
		Private p_idcomunmanlocalid As Decimal
		Private p_xdirinsrest As String
		Private p_msumaseginsrest As Decimal
		Private p_msumaseg75insrest As Decimal
		Private p_mvalinminsrest As Decimal
		Private p_mdanoinsrest As Decimal
		Private p_mavalinsrest As Decimal
		Private p_xnomtalinsrest As String
		Private p_xnomperinsrest As String
		Private p_xnomjefperinsrest As String
		Private p_xdescinsrest As String
		Private p_iestatinsrest As String
		Private p_idseglogreg As Decimal
		Private p_xnombreestado As String
		Private p_xnombrelocalid As String

		Public Property idaipinsrest() As Decimal
			Get
				Return Me.p_idaipinsrest
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsrest = Value
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

		Public Property xllavinsenc() As String
			Get
				Return Me.p_xllavinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xllavinsenc = Value
			End Set
		End Property

		Public Property fcreainsenc() As DateTime
			Get
				Return Me.p_fcreainsenc
			End Get
			Set(ByVal Value As DateTime)
				Me.p_fcreainsenc = Value
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

		Public Property itraccmanveh() As String
			Get
				Return Me.p_itraccmanveh
			End Get
			Set(ByVal Value As String)
				Me.p_itraccmanveh = Value
			End Set
		End Property

		Public Property iimpmanveh() As Boolean
			Get
				Return Me.p_iimpmanveh
			End Get
			Set(ByVal Value As Boolean)
				Me.p_iimpmanveh = Value
			End Set
		End Property

		Public Property ncilinmanveh() As Int16
			Get
				Return Me.p_ncilinmanveh
			End Get
			Set(ByVal Value As Int16)
				Me.p_ncilinmanveh = Value
			End Set
		End Property

		Public Property xcargmanveh() As String
			Get
				Return Me.p_xcargmanveh
			End Get
			Set(ByVal Value As String)
				Me.p_xcargmanveh = Value
			End Set
		End Property

		Public Property xcapmanveh() As String
			Get
				Return Me.p_xcapmanveh
			End Get
			Set(ByVal Value As String)
				Me.p_xcapmanveh = Value
			End Set
		End Property

		Public Property xsucuinsrest() As String
			Get
				Return Me.p_xsucuinsrest
			End Get
			Set(ByVal Value As String)
				Me.p_xsucuinsrest = Value
			End Set
		End Property

		Public Property nkiloinsrest() As Int32
			Get
				Return Me.p_nkiloinsrest
			End Get
			Set(ByVal Value As Int32)
				Me.p_nkiloinsrest = Value
			End Set
		End Property

		Public Property idcomunmanestado() As Decimal
			Get
				Return Me.p_idcomunmanestado
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idcomunmanestado = Value
			End Set
		End Property

		Public Property idcomunmanlocalid() As Decimal
			Get
				Return Me.p_idcomunmanlocalid
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idcomunmanlocalid = Value
			End Set
		End Property

		Public Property xdirinsrest() As String
			Get
				Return Me.p_xdirinsrest
			End Get
			Set(ByVal Value As String)
				Me.p_xdirinsrest = Value
			End Set
		End Property

		Public Property msumaseginsrest() As Decimal
			Get
				Return Me.p_msumaseginsrest
			End Get
			Set(ByVal Value As Decimal)
				Me.p_msumaseginsrest = Value
			End Set
		End Property

		Public Property msumaseg75insrest() As Decimal
			Get
				Return Me.p_msumaseg75insrest
			End Get
			Set(ByVal Value As Decimal)
				Me.p_msumaseg75insrest = Value
			End Set
		End Property

		Public Property mvalinminsrest() As Decimal
			Get
				Return Me.p_mvalinminsrest
			End Get
			Set(ByVal Value As Decimal)
				Me.p_mvalinminsrest = Value
			End Set
		End Property

		Public Property mdanoinsrest() As Decimal
			Get
				Return Me.p_mdanoinsrest
			End Get
			Set(ByVal Value As Decimal)
				Me.p_mdanoinsrest = Value
			End Set
		End Property

		Public Property mavalinsrest() As Decimal
			Get
				Return Me.p_mavalinsrest
			End Get
			Set(ByVal Value As Decimal)
				Me.p_mavalinsrest = Value
			End Set
		End Property

		Public Property xnomtalinsrest() As String
			Get
				Return Me.p_xnomtalinsrest
			End Get
			Set(ByVal Value As String)
				Me.p_xnomtalinsrest = Value
			End Set
		End Property

		Public Property xnomperinsrest() As String
			Get
				Return Me.p_xnomperinsrest
			End Get
			Set(ByVal Value As String)
				Me.p_xnomperinsrest = Value
			End Set
		End Property

		Public Property xnomjefperinsrest() As String
			Get
				Return Me.p_xnomjefperinsrest
			End Get
			Set(ByVal Value As String)
				Me.p_xnomjefperinsrest = Value
			End Set
		End Property

		Public Property xdescinsrest() As String
			Get
				Return Me.p_xdescinsrest
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinsrest = Value
			End Set
		End Property

		Public Property iestatinsrest() As String
			Get
				Return Me.p_iestatinsrest
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinsrest = Value
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

		Public Property xnombreestado() As String
			Get
				Return Me.p_xnombreestado
			End Get
			Set(ByVal Value As String)
				Me.p_xnombreestado = Value
			End Set
		End Property

		Public Property xnombrelocalid() As String
			Get
				Return Me.p_xnombrelocalid
			End Get
			Set(ByVal Value As String)
				Me.p_xnombrelocalid = Value
			End Set
		End Property

	End Class
	
	Public Class petivi_aipinsrestpaglist

	Private p_pagvi_aipinsrest As paginacion
	Private p_vi_aipinsrest As vi_aipinsrest

	Public Property pagvi_aipinsrest() As paginacion
	Get
	Return Me.p_pagvi_aipinsrest
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsrest = Value
	End Set
	End Property

	Public Property vi_aipinsrest() As vi_aipinsrest
	Get
	Return Me.p_vi_aipinsrest
	End Get
	Set(ByVal Value As vi_aipinsrest)
	Me.p_vi_aipinsrest = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsrestpaglist

	Private p_pagvi_aipinsrest As paginacion
	Private p_lista_vi_aipinsrest As  List(Of vi_aipinsrest)

	Public Property pagvi_aipinsrest() As paginacion
	Get
	Return Me.p_pagvi_aipinsrest
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsrest = Value
	End Set
	End Property

	Public Property lista_vi_aipinsrest() As List(Of vi_aipinsrest)
	Get
	Return Me.p_lista_vi_aipinsrest
	End Get
	Set(ByVal Value As List(Of vi_aipinsrest))
	Me.p_lista_vi_aipinsrest = Value
	End Set
	End Property
	End Class

End Namespace
