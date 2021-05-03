Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento

Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

    Public Class aipinssin

        Private p_idaipinssin As Decimal
        Private p_idaipinsenc As Decimal
        Private p_nfactinssin As Decimal
        Private p_irepuinssin As Boolean
        Private p_imobrinssin As Boolean
        Private p_xnomaseginssin As String
        Private p_idaipmanveh As Decimal
        Private p_xsucuinssin As String
        Private p_nkiloinssin As Int32
        Private p_xdescinssin As String
        Private p_iestatinssin As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsenc As aipinsenc
        Private p_aipmanveh As aipmanveh
        Private p_aipinssinmobr As List(Of aipinssinmobr)
        Private p_aipinssinmotiv As List(Of aipinssinmotiv)
        Private p_aipinssinrepu As List(Of aipinssinrepu)


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

        'relaciones
        Public Property aipinsenc() As aipinsenc
            Get
                Return Me.p_aipinsenc
            End Get
            Set(ByVal Value As aipinsenc)
                Me.p_aipinsenc = Value
            End Set
        End Property

        Public Property aipmanveh() As aipmanveh
            Get
                Return Me.p_aipmanveh
            End Get
            Set(ByVal Value As aipmanveh)
                Me.p_aipmanveh = Value
            End Set
        End Property

        Public Property aipinssinmobr() As List(Of aipinssinmobr)
            Get
                Return Me.p_aipinssinmobr
            End Get
            Set(ByVal Value As List(Of aipinssinmobr))
                Me.p_aipinssinmobr = Value
            End Set
        End Property

        Public Property aipinssinmotiv() As List(Of aipinssinmotiv)
            Get
                Return Me.p_aipinssinmotiv
            End Get
            Set(ByVal Value As List(Of aipinssinmotiv))
                Me.p_aipinssinmotiv = Value
            End Set
        End Property

        Public Property aipinssinrepu() As List(Of aipinssinrepu)
            Get
                Return Me.p_aipinssinrepu
            End Get
            Set(ByVal Value As List(Of aipinssinrepu))
                Me.p_aipinssinrepu = Value
            End Set
        End Property



    End Class

    Public Class petiaipinssinpaglist

        Private p_pagaipinssin As paginacion
        Private p_aipinssin As aipinssin

        Public Property pagaipinssin() As paginacion
            Get
                Return Me.p_pagaipinssin
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinssin = Value
            End Set
        End Property

        Public Property aipinssin() As aipinssin
            Get
                Return Me.p_aipinssin
            End Get
            Set(ByVal Value As aipinssin)
                Me.p_aipinssin = Value
            End Set
        End Property
    End Class

    Public Class respaipinssinpaglist

        Private p_pagaipinssin As paginacion
        Private p_lista_aipinssin As List(Of aipinssin)

        Public Property pagaipinssin() As paginacion
            Get
                Return Me.p_pagaipinssin
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinssin = Value
            End Set
        End Property

        Public Property lista_aipinssin() As List(Of aipinssin)
            Get
                Return Me.p_lista_aipinssin
            End Get
            Set(ByVal Value As List(Of aipinssin))
                Me.p_lista_aipinssin = Value
            End Set
        End Property
    End Class

End Namespace
