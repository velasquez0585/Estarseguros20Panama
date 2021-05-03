Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinssinmobr

		Private p_idaipinssinmobr As Decimal
        Private p_idaipinssin As Decimal
        Private p_idaipinsenc As Decimal
        Private p_itipoinsenc As String
        Private p_idaipmanrepu As Decimal
        Private p_xnommanrepu As String
        Private p_ncantinssinmobr As Int16
        Private p_iorigrepuinssinmobr As String
        Private p_itaminssinmobr As String
        Private p_itipomatinssinmobr As String
        Private p_itidainssinmobr As String
        Private p_nprecfininssinmobr As Decimal
        Private p_xdescinssinmobr As String
        Private p_iestatinssinmobr As String
        Private p_idseglogreg As Decimal

        Public Property idaipinssinmobr() As Decimal
            Get
                Return Me.p_idaipinssinmobr
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinssinmobr = Value
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

        Public Property ncantinssinmobr() As Int16
            Get
                Return Me.p_ncantinssinmobr
            End Get
            Set(ByVal Value As Int16)
                Me.p_ncantinssinmobr = Value
            End Set
        End Property

        Public Property iorigrepuinssinmobr() As String
            Get
                Return Me.p_iorigrepuinssinmobr
            End Get
            Set(ByVal Value As String)
                Me.p_iorigrepuinssinmobr = Value
            End Set
        End Property

        Public Property itaminssinmobr() As String
            Get
                Return Me.p_itaminssinmobr
            End Get
            Set(ByVal Value As String)
                Me.p_itaminssinmobr = Value
            End Set
        End Property

        Public Property itipomatinssinmobr() As String
            Get
                Return Me.p_itipomatinssinmobr
            End Get
            Set(ByVal Value As String)
                Me.p_itipomatinssinmobr = Value
            End Set
        End Property

        Public Property itidainssinmobr() As String
            Get
                Return Me.p_itidainssinmobr
            End Get
            Set(ByVal Value As String)
                Me.p_itidainssinmobr = Value
            End Set
        End Property

        Public Property nprecfininssinmobr() As Decimal
            Get
                Return Me.p_nprecfininssinmobr
            End Get
            Set(ByVal Value As Decimal)
                Me.p_nprecfininssinmobr = Value
            End Set
        End Property

        Public Property xdescinssinmobr() As String
            Get
                Return Me.p_xdescinssinmobr
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinssinmobr = Value
            End Set
        End Property

        Public Property iestatinssinmobr() As String
            Get
                Return Me.p_iestatinssinmobr
            End Get
            Set(ByVal Value As String)
                Me.p_iestatinssinmobr = Value
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
	
	Public Class petivi_aipinssinmobrpaglist

	Private p_pagvi_aipinssinmobr As paginacion
	Private p_vi_aipinssinmobr As vi_aipinssinmobr

	Public Property pagvi_aipinssinmobr() As paginacion
	Get
	Return Me.p_pagvi_aipinssinmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssinmobr = Value
	End Set
	End Property

	Public Property vi_aipinssinmobr() As vi_aipinssinmobr
	Get
	Return Me.p_vi_aipinssinmobr
	End Get
	Set(ByVal Value As vi_aipinssinmobr)
	Me.p_vi_aipinssinmobr = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinssinmobrpaglist

	Private p_pagvi_aipinssinmobr As paginacion
	Private p_lista_vi_aipinssinmobr As  List(Of vi_aipinssinmobr)

	Public Property pagvi_aipinssinmobr() As paginacion
	Get
	Return Me.p_pagvi_aipinssinmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssinmobr = Value
	End Set
	End Property

	Public Property lista_vi_aipinssinmobr() As List(Of vi_aipinssinmobr)
	Get
	Return Me.p_lista_vi_aipinssinmobr
	End Get
	Set(ByVal Value As List(Of vi_aipinssinmobr))
	Me.p_lista_vi_aipinssinmobr = Value
	End Set
	End Property
	End Class

End Namespace
