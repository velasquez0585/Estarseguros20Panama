Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

    Public Class vi_aipinsarch

        Private p_idaipinsarch As Decimal
        Private p_idaipinsenc As Decimal
        Private p_itipoinsenc As String
        Private p_idsegmanusuperit As Decimal
        Private p_xcedpropinsenc As String
        Private p_xcedsidoinsenc As String
        Private p_xplacinsenc As String
        Private p_nsecinsarch As Int16
        Private p_itipoinsarch As String
        Private p_xrutainsarch As String
        Private p_xurlinsarch As String
        Private p_xtituinsarch As String
        Private p_xnominsarch As String
        Private p_xextinsarch As String
        Private p_xlatcinsarch As String
        Private p_xlonginsarch As String
        Private p_mimetypeinsarch As String
        Private p_ioriginsarch As String
        Private p_xdescinsarch As String
        Private p_iestatinsarch As String
        Private p_fcreaaipinsarch As DateTime
        Private p_idseglogreg As Decimal

        Public Property idaipinsarch() As Decimal
            Get
                Return Me.p_idaipinsarch
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinsarch = Value
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

        Public Property idsegmanusuperit() As Decimal
            Get
                Return Me.p_idsegmanusuperit
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanusuperit = Value
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

        Public Property nsecinsarch() As Int16
            Get
                Return Me.p_nsecinsarch
            End Get
            Set(ByVal Value As Int16)
                Me.p_nsecinsarch = Value
            End Set
        End Property

        Public Property itipoinsarch() As String
            Get
                Return Me.p_itipoinsarch
            End Get
            Set(ByVal Value As String)
                Me.p_itipoinsarch = Value
            End Set
        End Property

        Public Property xrutainsarch() As String
            Get
                Return Me.p_xrutainsarch
            End Get
            Set(ByVal Value As String)
                Me.p_xrutainsarch = Value
            End Set
        End Property

        Public Property xurlinsarch() As String
            Get
                Return Me.p_xurlinsarch
            End Get
            Set(ByVal Value As String)
                Me.p_xurlinsarch = Value
            End Set
        End Property

        Public Property xtituinsarch() As String
            Get
                Return Me.p_xtituinsarch
            End Get
            Set(ByVal Value As String)
                Me.p_xtituinsarch = Value
            End Set
        End Property

        Public Property xnominsarch() As String
            Get
                Return Me.p_xnominsarch
            End Get
            Set(ByVal Value As String)
                Me.p_xnominsarch = Value
            End Set
        End Property

        Public Property xextinsarch() As String
            Get
                Return Me.p_xextinsarch
            End Get
            Set(ByVal Value As String)
                Me.p_xextinsarch = Value
            End Set
        End Property

        Public Property xlatcinsarch() As String
            Get
                Return Me.p_xlatcinsarch
            End Get
            Set(ByVal Value As String)
                Me.p_xlatcinsarch = Value
            End Set
        End Property

        Public Property xlonginsarch() As String
            Get
                Return Me.p_xlonginsarch
            End Get
            Set(ByVal Value As String)
                Me.p_xlonginsarch = Value
            End Set
        End Property

        Public Property mimetypeinsarch() As String
            Get
                Return Me.p_mimetypeinsarch
            End Get
            Set(ByVal Value As String)
                Me.p_mimetypeinsarch = Value
            End Set
        End Property

        Public Property ioriginsarch() As String
            Get
                Return Me.p_ioriginsarch
            End Get
            Set(ByVal Value As String)
                Me.p_ioriginsarch = Value
            End Set
        End Property

        Public Property xdescinsarch() As String
            Get
                Return Me.p_xdescinsarch
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinsarch = Value
            End Set
        End Property

        Public Property iestatinsarch() As String
            Get
                Return Me.p_iestatinsarch
            End Get
            Set(ByVal Value As String)
                Me.p_iestatinsarch = Value
            End Set
        End Property

        Public Property fcreaaipinsarch() As DateTime
            Get
                Return Me.p_fcreaaipinsarch
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fcreaaipinsarch = Value
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

    Public Class petivi_aipinsarchpaglist

        Private p_pagvi_aipinsarch As paginacion
        Private p_vi_aipinsarch As vi_aipinsarch

        Public Property pagvi_aipinsarch() As paginacion
            Get
                Return Me.p_pagvi_aipinsarch
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagvi_aipinsarch = Value
            End Set
        End Property

        Public Property vi_aipinsarch() As vi_aipinsarch
            Get
                Return Me.p_vi_aipinsarch
            End Get
            Set(ByVal Value As vi_aipinsarch)
                Me.p_vi_aipinsarch = Value
            End Set
        End Property
    End Class

    Public Class respvi_aipinsarchpaglist

        Private p_pagvi_aipinsarch As paginacion
        Private p_lista_vi_aipinsarch As List(Of vi_aipinsarch)

        Public Property pagvi_aipinsarch() As paginacion
            Get
                Return Me.p_pagvi_aipinsarch
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagvi_aipinsarch = Value
            End Set
        End Property

        Public Property lista_vi_aipinsarch() As List(Of vi_aipinsarch)
            Get
                Return Me.p_lista_vi_aipinsarch
            End Get
            Set(ByVal Value As List(Of vi_aipinsarch))
                Me.p_lista_vi_aipinsarch = Value
            End Set
        End Property
    End Class

End Namespace
