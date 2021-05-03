Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

    Public Class aipinslimsin

        Private p_idaipinslimsin As Decimal
        Private p_idaipinsenc As Decimal
        Private p_nfactinslimsin As Decimal
        Private p_irepuinslimsin As Boolean
        Private p_imobrinslimsin As Boolean
        Private p_xnomaseginslimsin As String
        Private p_idaipmanveh As Decimal
        Private p_xsucuinslimsin As String
        Private p_nkiloinslimsin As Int32
        Private p_xdescinslimsin As String
        Private p_iestatinslimsin As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsenc As aipinsenc
        Private p_aipmanveh As aipmanveh
        Private p_aipinslimsinmobr As List(Of aipinslimsinmobr)
        Private p_aipinslimsinrepu As List(Of aipinslimsinrepu)

        Public Property idaipinslimsin() As Decimal
            Get
                Return Me.p_idaipinslimsin
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinslimsin = Value
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

        Public Property nfactinslimsin() As Decimal
            Get
                Return Me.p_nfactinslimsin
            End Get
            Set(ByVal Value As Decimal)
                Me.p_nfactinslimsin = Value
            End Set
        End Property

        Public Property irepuinslimsin() As Boolean
            Get
                Return Me.p_irepuinslimsin
            End Get
            Set(ByVal Value As Boolean)
                Me.p_irepuinslimsin = Value
            End Set
        End Property

        Public Property imobrinslimsin() As Boolean
            Get
                Return Me.p_imobrinslimsin
            End Get
            Set(ByVal Value As Boolean)
                Me.p_imobrinslimsin = Value
            End Set
        End Property

        Public Property xnomaseginslimsin() As String
            Get
                Return Me.p_xnomaseginslimsin
            End Get
            Set(ByVal Value As String)
                Me.p_xnomaseginslimsin = Value
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

        Public Property xsucuinslimsin() As String
            Get
                Return Me.p_xsucuinslimsin
            End Get
            Set(ByVal Value As String)
                Me.p_xsucuinslimsin = Value
            End Set
        End Property

        Public Property nkiloinslimsin() As Int32
            Get
                Return Me.p_nkiloinslimsin
            End Get
            Set(ByVal Value As Int32)
                Me.p_nkiloinslimsin = Value
            End Set
        End Property

        Public Property xdescinslimsin() As String
            Get
                Return Me.p_xdescinslimsin
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinslimsin = Value
            End Set
        End Property

        Public Property iestatinslimsin() As String
            Get
                Return Me.p_iestatinslimsin
            End Get
            Set(ByVal Value As String)
                Me.p_iestatinslimsin = Value
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

        Public Property aipinslimsinmobr() As List(Of aipinslimsinmobr)
            Get
                Return Me.p_aipinslimsinmobr
            End Get
            Set(ByVal Value As List(Of aipinslimsinmobr))
                Me.p_aipinslimsinmobr = Value
            End Set
        End Property

        Public Property aipinslimsinrepu() As List(Of aipinslimsinrepu)
            Get
                Return Me.p_aipinslimsinrepu
            End Get
            Set(ByVal Value As List(Of aipinslimsinrepu))
                Me.p_aipinslimsinrepu = Value
            End Set
        End Property

    End Class

    Public Class petiaipinslimsinpaglist

        Private p_pagaipinslimsin As paginacion
        Private p_aipinslimsin As aipinslimsin

        Public Property pagaipinslimsin() As paginacion
            Get
                Return Me.p_pagaipinslimsin
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinslimsin = Value
            End Set
        End Property

        Public Property aipinslimsin() As aipinslimsin
            Get
                Return Me.p_aipinslimsin
            End Get
            Set(ByVal Value As aipinslimsin)
                Me.p_aipinslimsin = Value
            End Set
        End Property
    End Class

    Public Class respaipinslimsinpaglist

        Private p_pagaipinslimsin As paginacion
        Private p_lista_aipinslimsin As List(Of aipinslimsin)

        Public Property pagaipinslimsin() As paginacion
            Get
                Return Me.p_pagaipinslimsin
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinslimsin = Value
            End Set
        End Property

        Public Property lista_aipinslimsin() As List(Of aipinslimsin)
            Get
                Return Me.p_lista_aipinslimsin
            End Get
            Set(ByVal Value As List(Of aipinslimsin))
                Me.p_lista_aipinslimsin = Value
            End Set
        End Property
    End Class

End Namespace
