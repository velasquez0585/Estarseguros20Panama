Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.agenda

	Public Class vi_aipactivperi

		Private p_idaipactivperi As Decimal

		Private p_idcomunmancont As Decimal
		Private p_idcomunmanpais As Decimal
		Private p_idcomunmanlocalid As Decimal
		Private p_fejecactivperi As DateTime
		Private p_idcomunmanestado As Decimal
		Private p_xdireccionactivperi As String
		Private p_xtelfmovilactivperi As String
        Private p_ffinejecactivperi As DateTime
        Private p_xnomcliactivperi As String
		Private p_xcorreoelectronicoactivperi As String
		Private p_xdescactivperi As String
		Private p_ialcanactivperi As String
		Private p_xtituactivperi As String
        Private p_iestatactivperi As String
        Private p_idsegmanusucrea As Decimal ''nuevo
        Private p_xnombrecompleto As String
        Private p_fcrearegactivperi As DateTime ''fin nuevo
        Private p_idseglogreg As Decimal

       
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

		Public Property idcomunmanlocalid() As Decimal
			Get
				Return Me.p_idcomunmanlocalid
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idcomunmanlocalid = Value
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

		Public Property idcomunmanestado() As Decimal
			Get
				Return Me.p_idcomunmanestado
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idcomunmanestado = Value
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

		Public Property ffinejecactivperi() As DateTime
			Get
				Return Me.p_ffinejecactivperi
			End Get
			Set(ByVal Value As DateTime)
				Me.p_ffinejecactivperi = Value
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

		Public Property xtituactivperi() As String
			Get
				Return Me.p_xtituactivperi
			End Get
			Set(ByVal Value As String)
				Me.p_xtituactivperi = Value
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

		Public Property idseglogreg() As Decimal
			Get
				Return Me.p_idseglogreg
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idseglogreg = Value
			End Set
        End Property

        
	End Class
	
	Public Class petivi_aipactivperipaglist

	Private p_pagvi_aipactivperi As paginacion
	Private p_vi_aipactivperi As vi_aipactivperi

	Public Property pagvi_aipactivperi() As paginacion
	Get
	Return Me.p_pagvi_aipactivperi
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipactivperi = Value
	End Set
	End Property

	Public Property vi_aipactivperi() As vi_aipactivperi
	Get
	Return Me.p_vi_aipactivperi
	End Get
	Set(ByVal Value As vi_aipactivperi)
	Me.p_vi_aipactivperi = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipactivperipaglist

	Private p_pagvi_aipactivperi As paginacion
	Private p_lista_vi_aipactivperi As  List(Of vi_aipactivperi)

	Public Property pagvi_aipactivperi() As paginacion
	Get
	Return Me.p_pagvi_aipactivperi
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipactivperi = Value
	End Set
	End Property

	Public Property lista_vi_aipactivperi() As List(Of vi_aipactivperi)
	Get
	Return Me.p_lista_vi_aipactivperi
	End Get
	Set(ByVal Value As List(Of vi_aipactivperi))
	Me.p_lista_vi_aipactivperi = Value
	End Set
	End Property
	End Class

End Namespace
