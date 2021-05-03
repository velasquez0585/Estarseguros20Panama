Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

    Public Class aipinssus

        Private p_idaipinssus As Decimal
        Private p_idaipinsenc As Decimal
        Private p_xnomintinssus As String
        Private p_xnomsolinssus As String
        Private p_iluginssus As String
        Private p_idaipmanveh As Decimal
        Private p_nkiloinssus As Int32
        Private p_xsucuinssus As String
        Private p_iserbodinssus As Boolean
        Private p_ialarcorrinssus As Boolean
        Private p_xserinssus As String
        Private p_xdictinssus As String
        Private p_xdescinssus As String
        Private p_iestatinssus As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsenc As aipinsenc
        Private p_aipmanveh As aipmanveh
        Private p_aipinssusacc As List(Of aipinssusacc)
        Private p_aipinssusmotiv As List(Of aipinssusmotiv)
        Private p_aipinssusrepuest As List(Of aipinssusrepuest)
        Private p_aipinssussse As List(Of aipinssussse)
        Private p_aipinssusssm As List(Of aipinssusssm)
        Private p_aipinssusinfcomp As List(Of aipinssusinfcomp)



        Public Property idaipinssus() As Decimal
            Get
                Return Me.p_idaipinssus
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinssus = Value
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

        Public Property xnomintinssus() As String
            Get
                Return Me.p_xnomintinssus
            End Get
            Set(ByVal Value As String)
                Me.p_xnomintinssus = Value
            End Set
        End Property

        Public Property xnomsolinssus() As String
            Get
                Return Me.p_xnomsolinssus
            End Get
            Set(ByVal Value As String)
                Me.p_xnomsolinssus = Value
            End Set
        End Property

        Public Property iluginssus() As String
            Get
                Return Me.p_iluginssus
            End Get
            Set(ByVal Value As String)
                Me.p_iluginssus = Value
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

        Public Property nkiloinssus() As Int32
            Get
                Return Me.p_nkiloinssus
            End Get
            Set(ByVal Value As Int32)
                Me.p_nkiloinssus = Value
            End Set
        End Property

        Public Property xsucuinssus() As String
            Get
                Return Me.p_xsucuinssus
            End Get
            Set(ByVal Value As String)
                Me.p_xsucuinssus = Value
            End Set
        End Property

        Public Property iserbodinssus() As Boolean
            Get
                Return Me.p_iserbodinssus
            End Get
            Set(ByVal Value As Boolean)
                Me.p_iserbodinssus = Value
            End Set
        End Property

        Public Property ialarcorrinssus() As Boolean
            Get
                Return Me.p_ialarcorrinssus
            End Get
            Set(ByVal Value As Boolean)
                Me.p_ialarcorrinssus = Value
            End Set
        End Property

        Public Property xserinssus() As String
            Get
                Return Me.p_xserinssus
            End Get
            Set(ByVal Value As String)
                Me.p_xserinssus = Value
            End Set
        End Property

        Public Property xdictinssus() As String
            Get
                Return Me.p_xdictinssus
            End Get
            Set(ByVal Value As String)
                Me.p_xdictinssus = Value
            End Set
        End Property

        Public Property xdescinssus() As String
            Get
                Return Me.p_xdescinssus
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinssus = Value
            End Set
        End Property

        Public Property iestatinssus() As String
            Get
                Return Me.p_iestatinssus
            End Get
            Set(ByVal Value As String)
                Me.p_iestatinssus = Value
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

        Public Property aipinssusacc() As List(Of aipinssusacc)
            Get
                Return Me.p_aipinssusacc
            End Get
            Set(ByVal Value As List(Of aipinssusacc))
                Me.p_aipinssusacc = Value
            End Set
        End Property

        Public Property aipinssusmotiv() As List(Of aipinssusmotiv)
            Get
                Return Me.p_aipinssusmotiv
            End Get
            Set(ByVal Value As List(Of aipinssusmotiv))
                Me.p_aipinssusmotiv = Value
            End Set
        End Property

        Public Property aipinssusrepuest() As List(Of aipinssusrepuest)
            Get
                Return Me.p_aipinssusrepuest
            End Get
            Set(ByVal Value As List(Of aipinssusrepuest))
                Me.p_aipinssusrepuest = Value
            End Set
        End Property

        Public Property aipinssussse() As List(Of aipinssussse)
            Get
                Return Me.p_aipinssussse
            End Get
            Set(ByVal Value As List(Of aipinssussse))
                Me.p_aipinssussse = Value
            End Set
        End Property

        Public Property aipinssusssm() As List(Of aipinssusssm)
            Get
                Return Me.p_aipinssusssm
            End Get
            Set(ByVal Value As List(Of aipinssusssm))
                Me.p_aipinssusssm = Value
            End Set
        End Property

        Public Property aipinssusinfcomp() As List(Of aipinssusinfcomp)
            Get
                Return Me.p_aipinssusinfcomp
            End Get
            Set(ByVal Value As List(Of aipinssusinfcomp))
                Me.p_aipinssusinfcomp = Value
            End Set
        End Property

    End Class

    Public Class petiaipinssuspaglist

        Private p_pagaipinssus As paginacion
        Private p_aipinssus As aipinssus

        Public Property pagaipinssus() As paginacion
            Get
                Return Me.p_pagaipinssus
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinssus = Value
            End Set
        End Property

        Public Property aipinssus() As aipinssus
            Get
                Return Me.p_aipinssus
            End Get
            Set(ByVal Value As aipinssus)
                Me.p_aipinssus = Value
            End Set
        End Property
    End Class

    Public Class respaipinssuspaglist

        Private p_pagaipinssus As paginacion
        Private p_lista_aipinssus As List(Of aipinssus)

        Public Property pagaipinssus() As paginacion
            Get
                Return Me.p_pagaipinssus
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinssus = Value
            End Set
        End Property

        Public Property lista_aipinssus() As List(Of aipinssus)
            Get
                Return Me.p_lista_aipinssus
            End Get
            Set(ByVal Value As List(Of aipinssus))
                Me.p_lista_aipinssus = Value
            End Set
        End Property
    End Class

End Namespace
