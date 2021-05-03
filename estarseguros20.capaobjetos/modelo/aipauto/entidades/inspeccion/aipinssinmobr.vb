Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento

Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

    Public Class aipinssinmobr

        Private p_idaipinssinmobr As Decimal
        Private p_idaipinssin As Decimal
        Private p_idaipmanrepu As Decimal
        Private p_ncantinssinmobr As Int16
        Private p_iorigrepuinssinmobr As String
        Private p_itaminssinmobr As String
        Private p_itipomatinssinmobr As String
        Private p_itidainssinmobr As String
        Private p_nprecfininssinmobr As Decimal
        Private p_xdescinssinmobr As String
        Private p_iestatinssinmobr As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinssin As aipinssin
        Private p_aipmanrepu As aipmanrepu



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

        Public Property idaipmanrepu() As Decimal
            Get
                Return Me.p_idaipmanrepu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipmanrepu = Value
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


        'relaciones
        Public Property aipinssin() As aipinssin
            Get
                Return Me.p_aipinssin
            End Get
            Set(ByVal Value As aipinssin)
                Me.p_aipinssin = Value
            End Set
        End Property

        Public Property aipmanrepu() As aipmanrepu
            Get
                Return Me.p_aipmanrepu
            End Get
            Set(ByVal Value As aipmanrepu)
                Me.p_aipmanrepu = Value
            End Set
        End Property

    End Class

    Public Class petiaipinssinmobrpaglist

        Private p_pagaipinssinmobr As paginacion
        Private p_aipinssinmobr As aipinssinmobr

        Public Property pagaipinssinmobr() As paginacion
            Get
                Return Me.p_pagaipinssinmobr
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinssinmobr = Value
            End Set
        End Property

        Public Property aipinssinmobr() As aipinssinmobr
            Get
                Return Me.p_aipinssinmobr
            End Get
            Set(ByVal Value As aipinssinmobr)
                Me.p_aipinssinmobr = Value
            End Set
        End Property
    End Class

    Public Class respaipinssinmobrpaglist

        Private p_pagaipinssinmobr As paginacion
        Private p_lista_aipinssinmobr As List(Of aipinssinmobr)

        Public Property pagaipinssinmobr() As paginacion
            Get
                Return Me.p_pagaipinssinmobr
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinssinmobr = Value
            End Set
        End Property

        Public Property lista_aipinssinmobr() As List(Of aipinssinmobr)
            Get
                Return Me.p_lista_aipinssinmobr
            End Get
            Set(ByVal Value As List(Of aipinssinmobr))
                Me.p_lista_aipinssinmobr = Value
            End Set
        End Property
    End Class

End Namespace
