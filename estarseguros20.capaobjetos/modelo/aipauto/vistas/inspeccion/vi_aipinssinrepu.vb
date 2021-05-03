Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinssinrepu

		Private p_idaipinssinrepu As Decimal
        Private p_idaipinssin As Decimal
        Private p_idaipinsenc As Decimal
        Private p_itipoinsenc As String
        Private p_idaipmanrepu As Decimal
        Private p_xnommanrepu As String
        Private p_ncantinssinrepu As Int16
        Private p_iorigrepuinssinrepu As String
        Private p_nprecfininssinrepu As Decimal
        Private p_xdescinssinrepu As String
        Private p_iestatinssinrepu As String
        Private p_idseglogreg As Decimal

        Public Property idaipinssinrepu() As Decimal
            Get
                Return Me.p_idaipinssinrepu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinssinrepu = Value
            End Set
        End Property

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

        Public Property ncantinssinrepu() As Int16
            Get
                Return Me.p_ncantinssinrepu
            End Get
            Set(ByVal Value As Int16)
                Me.p_ncantinssinrepu = Value
            End Set
        End Property

        Public Property iorigrepuinssinrepu() As String
            Get
                Return Me.p_iorigrepuinssinrepu
            End Get
            Set(ByVal Value As String)
                Me.p_iorigrepuinssinrepu = Value
            End Set
        End Property

        Public Property nprecfininssinrepu() As Decimal
            Get
                Return Me.p_nprecfininssinrepu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_nprecfininssinrepu = Value
            End Set
        End Property

        Public Property xdescinssinrepu() As String
            Get
                Return Me.p_xdescinssinrepu
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinssinrepu = Value
            End Set
        End Property

        Public Property iestatinssinrepu() As String
            Get
                Return Me.p_iestatinssinrepu
            End Get
            Set(ByVal Value As String)
                Me.p_iestatinssinrepu = Value
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
	
	Public Class petivi_aipinssinrepupaglist

	Private p_pagvi_aipinssinrepu As paginacion
	Private p_vi_aipinssinrepu As vi_aipinssinrepu

	Public Property pagvi_aipinssinrepu() As paginacion
	Get
	Return Me.p_pagvi_aipinssinrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssinrepu = Value
	End Set
	End Property

	Public Property vi_aipinssinrepu() As vi_aipinssinrepu
	Get
	Return Me.p_vi_aipinssinrepu
	End Get
	Set(ByVal Value As vi_aipinssinrepu)
	Me.p_vi_aipinssinrepu = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinssinrepupaglist

	Private p_pagvi_aipinssinrepu As paginacion
	Private p_lista_vi_aipinssinrepu As  List(Of vi_aipinssinrepu)

	Public Property pagvi_aipinssinrepu() As paginacion
	Get
	Return Me.p_pagvi_aipinssinrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssinrepu = Value
	End Set
	End Property

	Public Property lista_vi_aipinssinrepu() As List(Of vi_aipinssinrepu)
	Get
	Return Me.p_lista_vi_aipinssinrepu
	End Get
	Set(ByVal Value As List(Of vi_aipinssinrepu))
	Me.p_lista_vi_aipinssinrepu = Value
	End Set
	End Property
	End Class

End Namespace
