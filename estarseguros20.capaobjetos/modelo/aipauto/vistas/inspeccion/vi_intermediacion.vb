Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_intermediacion

        Private p_idintermediacion As Decimal
        Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
		Private p_xnominsmotiv As String
		Private p_iorigeninsenc As String
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
		Private p_xnombrecomercialaudit As String
		Private p_xcedpropinsenc As String
		Private p_xcedsidoinsenc As String
		Private p_xplacinsenc As String
		Private p_xsermotinsenc As String
		Private p_xsercarrinsenc As String
		Private p_xnumpolinsenc As String
		Private p_xnumsininsenc As String
		Private p_xnomprodinsenc As String
		Private p_xnomprodtorinsenc As String
		Private p_xnomramopolizinsenc As String
		Private p_xnomsucinsinsenc As String
		Private p_fcreainsenc As DateTime
		Private p_fprocinsenc As DateTime
		Private p_faudinsenc As DateTime
		Private p_fultrechinsenc As DateTime
		Private p_fcancinsenc As DateTime
		Private p_facepinsenc As DateTime
		Private p_iestatinsenc As String
		Private p_xnomcliactivperi As String
        Private p_xcorreoelectronicoactivperi As String

        Private p_nu_ticket As String
		Private p_tipo_operacion As String
		Private p_tipo_inspeccion As String
        Private p_sucursal As Decimal
        Private p_siniestro As Decimal
		Private p_placa As String
		Private p_serialmotor As Decimal
		Private p_fecha As DateTime
		Private p_estatus As String
		Private p_usuario As String
		Private p_origen As String
		Private p_perito As String
        Private p_nu_cotiza As Decimal
        Private p_xnomsucinsinsenc2 As String
        Private p_idsegmanorg2 As Decimal

        Public Property idintermediacion() As Decimal
            Get
                Return Me.p_idintermediacion
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idintermediacion = Value
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

		Public Property xnominsmotiv() As String
			Get
				Return Me.p_xnominsmotiv
			End Get
			Set(ByVal Value As String)
				Me.p_xnominsmotiv = Value
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

		Public Property iestatinsenc() As String
			Get
				Return Me.p_iestatinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinsenc = Value
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

        Public Property nu_ticket() As String
            Get
                Return Me.p_nu_ticket
            End Get
            Set(ByVal Value As String)
                Me.p_nu_ticket = Value
            End Set
        End Property

		Public Property tipo_operacion() As String
			Get
				Return Me.p_tipo_operacion
			End Get
			Set(ByVal Value As String)
				Me.p_tipo_operacion = Value
			End Set
		End Property

		Public Property tipo_inspeccion() As String
			Get
				Return Me.p_tipo_inspeccion
			End Get
			Set(ByVal Value As String)
				Me.p_tipo_inspeccion = Value
			End Set
		End Property

        Public Property sucursal() As Decimal
            Get
                Return Me.p_sucursal
            End Get
            Set(ByVal Value As Decimal)
                Me.p_sucursal = Value
            End Set
        End Property

        Public Property siniestro() As Decimal
            Get
                Return Me.p_siniestro
            End Get
            Set(ByVal Value As Decimal)
                Me.p_siniestro = Value
            End Set
        End Property

		Public Property placa() As String
			Get
				Return Me.p_placa
			End Get
			Set(ByVal Value As String)
				Me.p_placa = Value
			End Set
		End Property

		Public Property serialmotor() As Decimal
			Get
				Return Me.p_serialmotor
			End Get
			Set(ByVal Value As Decimal)
				Me.p_serialmotor = Value
			End Set
		End Property

		Public Property fecha() As DateTime
			Get
				Return Me.p_fecha
			End Get
			Set(ByVal Value As DateTime)
				Me.p_fecha = Value
			End Set
		End Property

		Public Property estatus() As String
			Get
				Return Me.p_estatus
			End Get
			Set(ByVal Value As String)
				Me.p_estatus = Value
			End Set
		End Property

		Public Property usuario() As String
			Get
				Return Me.p_usuario
			End Get
			Set(ByVal Value As String)
				Me.p_usuario = Value
			End Set
		End Property

		Public Property origen() As String
			Get
				Return Me.p_origen
			End Get
			Set(ByVal Value As String)
				Me.p_origen = Value
			End Set
		End Property

		Public Property perito() As String
			Get
				Return Me.p_perito
			End Get
			Set(ByVal Value As String)
				Me.p_perito = Value
			End Set
		End Property

		Public Property nu_cotiza() As Decimal
			Get
				Return Me.p_nu_cotiza
			End Get
			Set(ByVal Value As Decimal)
				Me.p_nu_cotiza = Value
			End Set
        End Property

        Public Property xnomsucinsinsenc2() As String
            Get
                Return Me.p_xnomsucinsinsenc2
            End Get
            Set(ByVal Value As String)
                Me.p_xnomsucinsinsenc2 = Value
            End Set
        End Property

        Public Property idsegmanorg2() As Decimal
            Get
                Return Me.p_idsegmanorg2
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanorg2 = Value
            End Set
        End Property
	End Class
	
	Public Class petivi_intermediacionpaglist

	Private p_pagvi_intermediacion As paginacion
	Private p_vi_intermediacion As vi_intermediacion

	Public Property pagvi_intermediacion() As paginacion
	Get
	Return Me.p_pagvi_intermediacion
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_intermediacion = Value
	End Set
	End Property

	Public Property vi_intermediacion() As vi_intermediacion
	Get
	Return Me.p_vi_intermediacion
	End Get
	Set(ByVal Value As vi_intermediacion)
	Me.p_vi_intermediacion = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_intermediacionpaglist

	Private p_pagvi_intermediacion As paginacion
	Private p_lista_vi_intermediacion As  List(Of vi_intermediacion)

	Public Property pagvi_intermediacion() As paginacion
	Get
	Return Me.p_pagvi_intermediacion
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_intermediacion = Value
	End Set
	End Property

	Public Property lista_vi_intermediacion() As List(Of vi_intermediacion)
	Get
	Return Me.p_lista_vi_intermediacion
	End Get
	Set(ByVal Value As List(Of vi_intermediacion))
	Me.p_lista_vi_intermediacion = Value
	End Set
	End Property
	End Class

End Namespace
