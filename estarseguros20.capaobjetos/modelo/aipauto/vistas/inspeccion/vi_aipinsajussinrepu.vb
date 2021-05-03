Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsajussinrepu

		Private p_idaipinsajussinrepu As Decimal
		Private p_idaipinsajussin As Decimal
		Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
		Private p_idaipbarerepu As Decimal
		Private p_idaipmanrepu As Decimal
		Private p_xnommanrepu As String
		Private p_faplibarerepu As DateTime
		Private p_iorigbarerepu As String
        Private p_mcostbarerepu As Decimal
        Private p_ncantinsajussinrepu As Int16
        Private p_nprecfininsajussinrepu As Decimal
        Private p_xdescinsajussinrepu As String
        Private p_iestatinsajussinrepu As String
        Private p_idseglogreg As Decimal

		Public Property idaipinsajussinrepu() As Decimal
			Get
				Return Me.p_idaipinsajussinrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajussinrepu = Value
			End Set
		End Property

		Public Property idaipinsajussin() As Decimal
			Get
				Return Me.p_idaipinsajussin
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajussin = Value
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

		Public Property idaipbarerepu() As Decimal
			Get
				Return Me.p_idaipbarerepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipbarerepu = Value
			End Set
		End Property

		Public Property idaipmanrepu() As Decimal
			Get
				Return Me.p_idaipmanrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanrepu = Value
			End Set
		End Property

		Public Property xnommanrepu() As String
			Get
				Return Me.p_xnommanrepu
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanrepu = Value
			End Set
		End Property

		Public Property faplibarerepu() As DateTime
			Get
				Return Me.p_faplibarerepu
			End Get
			Set(ByVal Value As DateTime)
				Me.p_faplibarerepu = Value
			End Set
		End Property

		Public Property iorigbarerepu() As String
			Get
				Return Me.p_iorigbarerepu
			End Get
			Set(ByVal Value As String)
				Me.p_iorigbarerepu = Value
			End Set
		End Property

		Public Property mcostbarerepu() As Decimal
			Get
				Return Me.p_mcostbarerepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_mcostbarerepu = Value
			End Set
		End Property

        Public Property ncantinsajussinrepu() As Int16
            Get
                Return Me.p_ncantinsajussinrepu
            End Get
            Set(ByVal Value As Int16)
                Me.p_ncantinsajussinrepu = Value
            End Set
        End Property

        Public Property nprecfininsajussinrepu() As Decimal
            Get
                Return Me.p_nprecfininsajussinrepu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_nprecfininsajussinrepu = Value
            End Set
        End Property

        Public Property xdescinsajussinrepu() As String
            Get
                Return Me.p_xdescinsajussinrepu
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinsajussinrepu = Value
            End Set
        End Property

        Public Property iestatinsajussinrepu() As String
            Get
                Return Me.p_iestatinsajussinrepu
            End Get
            Set(ByVal Value As String)
                Me.p_iestatinsajussinrepu = Value
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
	
	Public Class petivi_aipinsajussinrepupaglist

	Private p_pagvi_aipinsajussinrepu As paginacion
	Private p_vi_aipinsajussinrepu As vi_aipinsajussinrepu

	Public Property pagvi_aipinsajussinrepu() As paginacion
	Get
	Return Me.p_pagvi_aipinsajussinrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsajussinrepu = Value
	End Set
	End Property

	Public Property vi_aipinsajussinrepu() As vi_aipinsajussinrepu
	Get
	Return Me.p_vi_aipinsajussinrepu
	End Get
	Set(ByVal Value As vi_aipinsajussinrepu)
	Me.p_vi_aipinsajussinrepu = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsajussinrepupaglist

	Private p_pagvi_aipinsajussinrepu As paginacion
	Private p_lista_vi_aipinsajussinrepu As  List(Of vi_aipinsajussinrepu)

	Public Property pagvi_aipinsajussinrepu() As paginacion
	Get
	Return Me.p_pagvi_aipinsajussinrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsajussinrepu = Value
	End Set
	End Property

	Public Property lista_vi_aipinsajussinrepu() As List(Of vi_aipinsajussinrepu)
	Get
	Return Me.p_lista_vi_aipinsajussinrepu
	End Get
	Set(ByVal Value As List(Of vi_aipinsajussinrepu))
	Me.p_lista_vi_aipinsajussinrepu = Value
	End Set
	End Property
	End Class

End Namespace
