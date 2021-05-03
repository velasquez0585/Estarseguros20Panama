Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsajusanexrepu

		Private p_idaipinsajusanexrepu As Decimal
		Private p_idaipinsajusanex As Decimal
		Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
		Private p_idaipbarerepu As Decimal
		Private p_idaipmanrepu As Decimal
		Private p_xnommanrepu As String
		Private p_faplibarerepu As DateTime
		Private p_iorigbarerepu As String
        Private p_mcostbarerepu As Decimal
        Private p_ncantinsajusanexrepu As Int16
        Private p_nprecfininsajusanexrepu As Decimal
        Private p_xdescinsajusanexrepu As String
        Private p_iestatinsajusanexrepu As String
        Private p_idseglogreg As Decimal

		Public Property idaipinsajusanexrepu() As Decimal
			Get
				Return Me.p_idaipinsajusanexrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajusanexrepu = Value
			End Set
		End Property

		Public Property idaipinsajusanex() As Decimal
			Get
				Return Me.p_idaipinsajusanex
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajusanex = Value
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

        Public Property ncantinsajusanexrepu() As Int16
            Get
                Return Me.p_ncantinsajusanexrepu
            End Get
            Set(ByVal Value As Int16)
                Me.p_ncantinsajusanexrepu = Value
            End Set
        End Property

        Public Property nprecfininsajusanexrepu() As Decimal
            Get
                Return Me.p_nprecfininsajusanexrepu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_nprecfininsajusanexrepu = Value
            End Set
        End Property

        Public Property xdescinsajusanexrepu() As String
            Get
                Return Me.p_xdescinsajusanexrepu
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinsajusanexrepu = Value
            End Set
        End Property

        Public Property iestatinsajusanexrepu() As String
            Get
                Return Me.p_iestatinsajusanexrepu
            End Get
            Set(ByVal Value As String)
                Me.p_iestatinsajusanexrepu = Value
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
	
	Public Class petivi_aipinsajusanexrepupaglist

	Private p_pagvi_aipinsajusanexrepu As paginacion
	Private p_vi_aipinsajusanexrepu As vi_aipinsajusanexrepu

	Public Property pagvi_aipinsajusanexrepu() As paginacion
	Get
	Return Me.p_pagvi_aipinsajusanexrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsajusanexrepu = Value
	End Set
	End Property

	Public Property vi_aipinsajusanexrepu() As vi_aipinsajusanexrepu
	Get
	Return Me.p_vi_aipinsajusanexrepu
	End Get
	Set(ByVal Value As vi_aipinsajusanexrepu)
	Me.p_vi_aipinsajusanexrepu = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsajusanexrepupaglist

	Private p_pagvi_aipinsajusanexrepu As paginacion
	Private p_lista_vi_aipinsajusanexrepu As  List(Of vi_aipinsajusanexrepu)

	Public Property pagvi_aipinsajusanexrepu() As paginacion
	Get
	Return Me.p_pagvi_aipinsajusanexrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsajusanexrepu = Value
	End Set
	End Property

	Public Property lista_vi_aipinsajusanexrepu() As List(Of vi_aipinsajusanexrepu)
	Get
	Return Me.p_lista_vi_aipinsajusanexrepu
	End Get
	Set(ByVal Value As List(Of vi_aipinsajusanexrepu))
	Me.p_lista_vi_aipinsajusanexrepu = Value
	End Set
	End Property
	End Class

End Namespace
