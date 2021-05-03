Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.usuario
Namespace aipauto.modelo.dbestarseguros20.entidades.mantenimiento

    Public Class aipmanusuconf

        Private p_idaipmanusuconf As Decimal
        Private p_idsegmanusu As Decimal
        Private p_finisusmanusuconf As DateTime
        Private p_ffinsusmanusuconf As DateTime
        Private p_iestatmanusuconf As String
        Private p_fcreamanusuconf As DateTime
        Private p_fmodmanusuconf As DateTime        
        Private p_idseglogreg As Decimal

        Public Property idaipmanusuconf() As Decimal
            Get
                Return Me.p_idaipmanusuconf
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipmanusuconf = Value
            End Set
        End Property

        Public Property idsegmanusu() As Decimal
            Get
                Return Me.p_idsegmanusu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanusu = Value
            End Set
        End Property

        Public Property finisusmanusuconf() As DateTime
            Get
                Return Me.p_finisusmanusuconf
            End Get
            Set(ByVal Value As DateTime)
                Me.p_finisusmanusuconf = Value
            End Set
        End Property

        Public Property ffinsusmanusuconf() As DateTime
            Get
                Return Me.p_ffinsusmanusuconf
            End Get
            Set(ByVal Value As DateTime)
                Me.p_ffinsusmanusuconf = Value
            End Set
        End Property

        Public Property iestatmanusuconf() As String
            Get
                Return Me.p_iestatmanusuconf
            End Get
            Set(ByVal Value As String)
                Me.p_iestatmanusuconf = Value
            End Set
        End Property

        Public Property fcreamanusuconf() As DateTime
            Get
                Return Me.p_fcreamanusuconf
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fcreamanusuconf = Value
            End Set
        End Property

        Public Property fmodmanusuconf() As DateTime
            Get
                Return Me.p_fmodmanusuconf
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fmodmanusuconf = Value
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

    Public Class petiaipmanusuconfpaglist

        Private p_pagaipmanusuconf As paginacion
        Private p_aipmanusuconf As aipmanusuconf

        Public Property pagaipmanusuconf() As paginacion
            Get
                Return Me.p_pagaipmanusuconf
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipmanusuconf = Value
            End Set
        End Property

        Public Property aipmanusuconf() As aipmanusuconf
            Get
                Return Me.p_aipmanusuconf
            End Get
            Set(ByVal Value As aipmanusuconf)
                Me.p_aipmanusuconf = Value
            End Set
        End Property
    End Class

    Public Class respaipmanusuconfpaglist

        Private p_pagaipmanusuconf As paginacion
        Private p_lista_aipmanusuconf As List(Of aipmanusuconf)

        Public Property pagaipmanusuconf() As paginacion
            Get
                Return Me.p_pagaipmanusuconf
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipmanusuconf = Value
            End Set
        End Property

        Public Property lista_aipmanusuconf() As List(Of aipmanusuconf)
            Get
                Return Me.p_lista_aipmanusuconf
            End Get
            Set(ByVal Value As List(Of aipmanusuconf))
                Me.p_lista_aipmanusuconf = Value
            End Set
        End Property
    End Class

End Namespace
