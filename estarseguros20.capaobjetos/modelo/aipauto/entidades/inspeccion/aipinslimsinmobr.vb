Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

    Public Class aipinslimsinmobr

        Private p_idaipinslimsinmobr As Decimal
        Private p_idaipinslimsin As Decimal
        Private p_idaipbaremobr As Decimal
        Private p_ncantinslimsinmobr As Int16
        Private p_nprecfininslimsinmobr As Decimal
        Private p_xdescinslimsinmobr As String
        Private p_iestatinslimsinmobr As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinslimsin As aipinslimsin
        Private p_aipbaremobr As aipbaremobr

        Public Property idaipinslimsinmobr() As Decimal
            Get
                Return Me.p_idaipinslimsinmobr
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinslimsinmobr = Value
            End Set
        End Property

        Public Property idaipinslimsin() As Decimal
            Get
                Return Me.p_idaipinslimsin
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinslimsin = Value
            End Set
        End Property

        Public Property idaipbaremobr() As Decimal
            Get
                Return Me.p_idaipbaremobr
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipbaremobr = Value
            End Set
        End Property

        Public Property ncantinslimsinmobr() As Int16
            Get
                Return Me.p_ncantinslimsinmobr
            End Get
            Set(ByVal Value As Int16)
                Me.p_ncantinslimsinmobr = Value
            End Set
        End Property

        Public Property nprecfininslimsinmobr() As Decimal
            Get
                Return Me.p_nprecfininslimsinmobr
            End Get
            Set(ByVal Value As Decimal)
                Me.p_nprecfininslimsinmobr = Value
            End Set
        End Property

        Public Property xdescinslimsinmobr() As String
            Get
                Return Me.p_xdescinslimsinmobr
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinslimsinmobr = Value
            End Set
        End Property

        Public Property iestatinslimsinmobr() As String
            Get
                Return Me.p_iestatinslimsinmobr
            End Get
            Set(ByVal Value As String)
                Me.p_iestatinslimsinmobr = Value
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
        Public Property aipinslimsin() As aipinslimsin
            Get
                Return Me.p_aipinslimsin
            End Get
            Set(ByVal Value As aipinslimsin)
                Me.p_aipinslimsin = Value
            End Set
        End Property
        Public Property aipbaremobr() As aipbaremobr
            Get
                Return Me.p_aipbaremobr
            End Get
            Set(ByVal Value As aipbaremobr)
                Me.p_aipbaremobr = Value
            End Set
        End Property

    End Class

    Public Class petiaipinslimsinmobrpaglist

        Private p_pagaipinslimsinmobr As paginacion
        Private p_aipinslimsinmobr As aipinslimsinmobr

        Public Property pagaipinslimsinmobr() As paginacion
            Get
                Return Me.p_pagaipinslimsinmobr
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinslimsinmobr = Value
            End Set
        End Property

        Public Property aipinslimsinmobr() As aipinslimsinmobr
            Get
                Return Me.p_aipinslimsinmobr
            End Get
            Set(ByVal Value As aipinslimsinmobr)
                Me.p_aipinslimsinmobr = Value
            End Set
        End Property
    End Class

    Public Class respaipinslimsinmobrpaglist

        Private p_pagaipinslimsinmobr As paginacion
        Private p_lista_aipinslimsinmobr As List(Of aipinslimsinmobr)

        Public Property pagaipinslimsinmobr() As paginacion
            Get
                Return Me.p_pagaipinslimsinmobr
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinslimsinmobr = Value
            End Set
        End Property

        Public Property lista_aipinslimsinmobr() As List(Of aipinslimsinmobr)
            Get
                Return Me.p_lista_aipinslimsinmobr
            End Get
            Set(ByVal Value As List(Of aipinslimsinmobr))
                Me.p_lista_aipinslimsinmobr = Value
            End Set
        End Property
    End Class

End Namespace
