Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsenc

        Private p_idaipinsenc As Decimal
        Private p_idaipinsintext As Decimal
        Private p_itipoinsenc As String
        Private p_idaipinsmotiv As Decimal
        Private p_xnominsmotiv As String
        Private p_itipoperitinsenc As String 'nuevo
        Private p_iorigeninsenc As String

        Private p_xnombrecomercial As String
        Private p_idsegmanusuperit As Decimal
        Private p_xcedulaperit As String
        Private p_xnombresperit As String
        Private p_xapellidosperit As String
        Private p_xnombrecompletoperit As String
        Private p_xnombreusuarioperit As String
        Private p_idsegmanorgperit As Decimal
        Private p_xnombrecomercialperit As String
        Private p_idsegmanusuaudit As Decimal
        Private p_xcedulaaudit As String
        Private p_xnombresaudit As String
        Private p_xapellidosaudit As String
        Private p_xnombrecompletoaudit As String
        Private p_xnombreusuarioaudit As String
        Private p_idsegmanorgaudit As Decimal
        Private p_xnombrecomercialaudit As String 'fin nuevo


		Private p_xcedpropinsenc As String
		Private p_xcedsidoinsenc As String
		Private p_xplacinsenc As String
		Private p_xsermotinsenc As String
		Private p_xsercarrinsenc As String
		Private p_xnumpolinsenc As String
		Private p_xnumsininsenc As String
        Private p_xllavinsenc As String
        Private p_xnomprodinsenc As String
        Private p_xnomprodtorinsenc As String
        Private p_xnomramopolizinsenc As String
        Private p_xnomsucinsinsenc As String
        Private p_xnuminspinsenc As String ''numero de inspeccion (nuevo por agregar en la base de datos)
		Private p_fcreainsenc As DateTime
		Private p_fprocinsenc As DateTime
		Private p_faudinsenc As DateTime
        Private p_fultrechinsenc As DateTime
        Private p_irechinsenc As Boolean
        Private p_xmotcrechinsenc As String
		Private p_fcancinsenc As DateTime
		Private p_facepinsenc As DateTime
        Private p_xdescinsenc As String
        Private p_icerrarinsenc As Boolean
		Private p_iestatinsenc As String
        Private p_idseglogreg As Decimal

        Private p_idaipactivperi As Decimal  'nuevo
        Private p_idcomunmancont As Decimal
        Private p_idcomunmanpais As Decimal
        Private p_idcomunmanestado As Decimal
        Private p_idcomunmanlocalid As Decimal
        Private p_xdireccionactivperi As String
        Private p_xtelfmovilactivperi As String
        Private p_xnomcliactivperi As String
        Private p_xcorreoelectronicoactivperi As String
        Private p_xtituactivperi As String
        Private p_fejecactivperi As DateTime
        Private p_ffinejecactivperi As DateTime
        Private p_xdescactivperi As String
        Private p_ialcanactivperi As String
        Private p_iestatactivperi As String
        Private p_idsegmanusucrea As Decimal
        Private p_xnombrecompleto As String
        Private p_fcrearegactivperi As DateTime ''fin nuevo
        Private p_nanexoinsenc As Int16

        'campos que no estan en la tabla de base de datos
        Private p_check As Boolean



		Public Property idaipinsenc() As Decimal
			Get
				Return Me.p_idaipinsenc
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsenc = Value
			End Set
        End Property

        Public Property idaipinsintext() As Decimal
            Get
                Return Me.p_idaipinsintext
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinsintext = Value
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

        Public Property itipoperitinsenc() As String
            Get
                Return Me.p_itipoperitinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_itipoperitinsenc = Value
            End Set
        End Property

        Public Property iorigeninsenc() As String
            Get
                Return Me.p_iorigeninsenc
            End Get
            Set(ByVal Value As String)
                Me.p_iorigeninsenc = Value
            End Set
        End Property

        Public Property xnombrecomercial() As String
            Get
                Return Me.p_xnombrecomercial
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecomercial = Value
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

        Public Property xcedulaperit() As String
            Get
                Return Me.p_xcedulaperit
            End Get
            Set(ByVal Value As String)
                Me.p_xcedulaperit = Value
            End Set
        End Property

        Public Property xnombresperit() As String
            Get
                Return Me.p_xnombresperit
            End Get
            Set(ByVal Value As String)
                Me.p_xnombresperit = Value
            End Set
        End Property

        Public Property xapellidosperit() As String
            Get
                Return Me.p_xapellidosperit
            End Get
            Set(ByVal Value As String)
                Me.p_xapellidosperit = Value
            End Set
        End Property

        Public Property xnombrecompletoperit() As String
            Get
                Return Me.p_xnombrecompletoperit
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecompletoperit = Value
            End Set
        End Property

        Public Property xnombreusuarioperit() As String
            Get
                Return Me.p_xnombreusuarioperit
            End Get
            Set(ByVal Value As String)
                Me.p_xnombreusuarioperit = Value
            End Set
        End Property



        Public Property idsegmanorgperit() As Decimal
            Get
                Return Me.p_idsegmanorgperit
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanorgperit = Value
            End Set
        End Property

        Public Property xnombrecomercialperit() As String
            Get
                Return Me.p_xnombrecomercialperit
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecomercialperit = Value
            End Set
        End Property

        Public Property idsegmanusuaudit() As Decimal
            Get
                Return Me.p_idsegmanusuaudit
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanusuaudit = Value
            End Set
        End Property

        Public Property xcedulaaudit() As String
            Get
                Return Me.p_xcedulaaudit
            End Get
            Set(ByVal Value As String)
                Me.p_xcedulaaudit = Value
            End Set
        End Property

        Public Property xnombresaudit() As String
            Get
                Return Me.p_xnombresaudit
            End Get
            Set(ByVal Value As String)
                Me.p_xnombresaudit = Value
            End Set
        End Property

        Public Property xapellidosaudit() As String
            Get
                Return Me.p_xapellidosaudit
            End Get
            Set(ByVal Value As String)
                Me.p_xapellidosaudit = Value
            End Set
        End Property

        Public Property xnombrecompletoaudit() As String
            Get
                Return Me.p_xnombrecompletoaudit
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecompletoaudit = Value
            End Set
        End Property

        Public Property xnombreusuarioaudit() As String
            Get
                Return Me.p_xnombreusuarioaudit
            End Get
            Set(ByVal Value As String)
                Me.p_xnombreusuarioaudit = Value
            End Set
        End Property

        Public Property idsegmanorgaudit() As Decimal
            Get
                Return Me.p_idsegmanorgaudit
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanorgaudit = Value
            End Set
        End Property

        Public Property xnombrecomercialaudit() As String
            Get
                Return Me.p_xnombrecomercialaudit
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecomercialaudit = Value
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

        Public Property xnomprodinsenc() As String
            Get
                Return Me.p_xnomprodinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xnomprodinsenc = Value
            End Set
        End Property

        Public Property xnomprodtorinsenc() As String
            Get
                Return Me.p_xnomprodtorinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xnomprodtorinsenc = Value
            End Set
        End Property

        Public Property xnomramopolizinsenc() As String
            Get
                Return Me.p_xnomramopolizinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xnomramopolizinsenc = Value
            End Set
        End Property

        Public Property xnomsucinsinsenc() As String
            Get
                Return Me.p_xnomsucinsinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xnomsucinsinsenc = Value
            End Set
        End Property

        Public Property xnuminspinsenc() As String
            Get
                Return Me.p_xnuminspinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xnuminspinsenc = Value
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

		Public Property fprocinsenc() As DateTime
			Get
				Return Me.p_fprocinsenc
			End Get
			Set(ByVal Value As DateTime)
				Me.p_fprocinsenc = Value
			End Set
		End Property

		Public Property faudinsenc() As DateTime
			Get
				Return Me.p_faudinsenc
			End Get
			Set(ByVal Value As DateTime)
				Me.p_faudinsenc = Value
			End Set
		End Property

		Public Property fultrechinsenc() As DateTime
			Get
				Return Me.p_fultrechinsenc
			End Get
			Set(ByVal Value As DateTime)
				Me.p_fultrechinsenc = Value
			End Set
        End Property

        Public Property irechinsenc() As Boolean
            Get
                Return Me.p_irechinsenc
            End Get
            Set(ByVal Value As Boolean)
                Me.p_irechinsenc = Value
            End Set
        End Property

        Public Property xmotcrechinsenc() As String
            Get
                Return Me.p_xmotcrechinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xmotcrechinsenc = Value
            End Set
        End Property


		Public Property fcancinsenc() As DateTime
			Get
				Return Me.p_fcancinsenc
			End Get
			Set(ByVal Value As DateTime)
				Me.p_fcancinsenc = Value
			End Set
		End Property

		Public Property facepinsenc() As DateTime
			Get
				Return Me.p_facepinsenc
			End Get
			Set(ByVal Value As DateTime)
				Me.p_facepinsenc = Value
			End Set
		End Property

		Public Property xdescinsenc() As String
			Get
				Return Me.p_xdescinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinsenc = Value
			End Set
        End Property

        Public Property icerrarinsenc() As Boolean
            Get
                Return Me.p_icerrarinsenc
            End Get
            Set(ByVal Value As Boolean)
                Me.p_icerrarinsenc = Value
            End Set
        End Property

		Public Property iestatinsenc() As String
			Get
				Return Me.p_iestatinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinsenc = Value
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

        Public Property idaipactivperi() As Decimal
            Get
                Return Me.p_idaipactivperi
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipactivperi = Value
            End Set
        End Property

        Public Property idcomunmancont() As Decimal
            Get
                Return Me.p_idcomunmancont
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmancont = Value
            End Set
        End Property

        Public Property idcomunmanpais() As Decimal
            Get
                Return Me.p_idcomunmanpais
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanpais = Value
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

        Public Property xdireccionactivperi() As String
            Get
                Return Me.p_xdireccionactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_xdireccionactivperi = Value
            End Set
        End Property

        Public Property xtelfmovilactivperi() As String
            Get
                Return Me.p_xtelfmovilactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_xtelfmovilactivperi = Value
            End Set
        End Property

        Public Property xnomcliactivperi() As String
            Get
                Return Me.p_xnomcliactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_xnomcliactivperi = Value
            End Set
        End Property

        Public Property xcorreoelectronicoactivperi() As String
            Get
                Return Me.p_xcorreoelectronicoactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_xcorreoelectronicoactivperi = Value
            End Set
        End Property

        Public Property xtituactivperi() As String
            Get
                Return Me.p_xtituactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_xtituactivperi = Value
            End Set
        End Property

        Public Property fejecactivperi() As DateTime
            Get
                Return Me.p_fejecactivperi
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fejecactivperi = Value
            End Set
        End Property

        Public Property ffinejecactivperi() As DateTime
            Get
                Return Me.p_ffinejecactivperi
            End Get
            Set(ByVal Value As DateTime)
                Me.p_ffinejecactivperi = Value
            End Set
        End Property

        Public Property xdescactivperi() As String
            Get
                Return Me.p_xdescactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_xdescactivperi = Value
            End Set
        End Property

        Public Property ialcanactivperi() As String
            Get
                Return Me.p_ialcanactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_ialcanactivperi = Value
            End Set
        End Property

        Public Property iestatactivperi() As String
            Get
                Return Me.p_iestatactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_iestatactivperi = Value
            End Set
        End Property


        Public Property idsegmanusucrea() As Decimal
            Get
                Return Me.p_idsegmanusucrea
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanusucrea = Value
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

        Public Property fcrearegactivperi() As DateTime
            Get
                Return Me.p_fcrearegactivperi
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fcrearegactivperi = Value
            End Set
        End Property

        Public Property nanexoinsenc() As Int16
            Get
                Return Me.p_nanexoinsenc
            End Get
            Set(ByVal Value As Int16)
                Me.p_nanexoinsenc = Value
            End Set
        End Property

        Public Property check() As Boolean
            Get
                Return Me.p_check
            End Get
            Set(ByVal Value As Boolean)
                Me.p_check = Value
            End Set
        End Property

	End Class
	
	Public Class petivi_aipinsencpaglist

	Private p_pagvi_aipinsenc As paginacion
	Private p_vi_aipinsenc As vi_aipinsenc

	Public Property pagvi_aipinsenc() As paginacion
	Get
	Return Me.p_pagvi_aipinsenc
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsenc = Value
	End Set
	End Property

	Public Property vi_aipinsenc() As vi_aipinsenc
	Get
	Return Me.p_vi_aipinsenc
	End Get
	Set(ByVal Value As vi_aipinsenc)
	Me.p_vi_aipinsenc = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsencpaglist

	Private p_pagvi_aipinsenc As paginacion
	Private p_lista_vi_aipinsenc As  List(Of vi_aipinsenc)

	Public Property pagvi_aipinsenc() As paginacion
	Get
	Return Me.p_pagvi_aipinsenc
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsenc = Value
	End Set
	End Property

	Public Property lista_vi_aipinsenc() As List(Of vi_aipinsenc)
	Get
	Return Me.p_lista_vi_aipinsenc
	End Get
	Set(ByVal Value As List(Of vi_aipinsenc))
	Me.p_lista_vi_aipinsenc = Value
	End Set
	End Property
	End Class

End Namespace
