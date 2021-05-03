Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.usuario

    Public Class vi_aipusudisp
        '
        Private p_idaipusudisp As Decimal
        Private p_idsegmanusu As Decimal
        Private p_xcedula As String
        Private p_xnombres As String
        Private p_xapellidos As String
        Private p_xnombrecompleto As String
        Private p_fnacimiento As DateTime
        Private p_xsexo As String
        Private p_idaipmandisp As Decimal
        Private p_xcodimmandisp As String
        Private p_xfabmandisp As String
        Private p_xmodmandisp As String
        Private p_itipomandisp As String
        Private p_xdescmandisp As String
        Private p_iestatmandisp As String
        Private p_idseglogreg As Decimal

        Public Property idaipusudisp() As Decimal
            Get
                Return Me.p_idaipusudisp
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipusudisp = Value
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

        Public Property xcedula() As String
            Get
                Return Me.p_xcedula
            End Get
            Set(ByVal Value As String)
                Me.p_xcedula = Value
            End Set
        End Property

        Public Property xnombres() As String
            Get
                Return Me.p_xnombres
            End Get
            Set(ByVal Value As String)
                Me.p_xnombres = Value
            End Set
        End Property

        Public Property xapellidos() As String
            Get
                Return Me.p_xapellidos
            End Get
            Set(ByVal Value As String)
                Me.p_xapellidos = Value
            End Set
        End Property

        Public Property xnombrecompleto() As String
            Get
                Return Me.p_xnombrecompleto
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecompleto = Value
            End Set
        End Property

        Public Property fnacimiento() As DateTime
            Get
                Return Me.p_fnacimiento
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fnacimiento = Value
            End Set
        End Property

        Public Property xsexo() As String
            Get
                Return Me.p_xsexo
            End Get
            Set(ByVal Value As String)
                Me.p_xsexo = Value
            End Set
        End Property

        Public Property idaipmandisp() As Decimal
            Get
                Return Me.p_idaipmandisp
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipmandisp = Value
            End Set
        End Property

        Public Property xcodimmandisp() As String
            Get
                Return Me.p_xcodimmandisp
            End Get
            Set(ByVal Value As String)
                Me.p_xcodimmandisp = Value
            End Set
        End Property

        Public Property xfabmandisp() As String
            Get
                Return Me.p_xfabmandisp
            End Get
            Set(ByVal Value As String)
                Me.p_xfabmandisp = Value
            End Set
        End Property

        Public Property xmodmandisp() As String
            Get
                Return Me.p_xmodmandisp
            End Get
            Set(ByVal Value As String)
                Me.p_xmodmandisp = Value
            End Set
        End Property

        Public Property itipomandisp() As String
            Get
                Return Me.p_itipomandisp
            End Get
            Set(ByVal Value As String)
                Me.p_itipomandisp = Value
            End Set
        End Property

        Public Property xdescmandisp() As String
            Get
                Return Me.p_xdescmandisp
            End Get
            Set(ByVal Value As String)
                Me.p_xdescmandisp = Value
            End Set
        End Property

        Public Property iestatmandisp() As String
            Get
                Return Me.p_iestatmandisp
            End Get
            Set(ByVal Value As String)
                Me.p_iestatmandisp = Value
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

    Public Class petivi_aipusudisppaglist

        Private p_pagvi_aipusudisp As paginacion
        Private p_vi_aipusudisp As vi_aipusudisp

        Public Property pagvi_aipusudisp() As paginacion
            Get
                Return Me.p_pagvi_aipusudisp
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagvi_aipusudisp = Value
            End Set
        End Property

        Public Property vi_aipusudisp() As vi_aipusudisp
            Get
                Return Me.p_vi_aipusudisp
            End Get
            Set(ByVal Value As vi_aipusudisp)
                Me.p_vi_aipusudisp = Value
            End Set
        End Property
    End Class

    Public Class respvi_aipusudisppaglist

        Private p_pagvi_aipusudisp As paginacion
        Private p_lista_vi_aipusudisp As List(Of vi_aipusudisp)

        Public Property pagvi_aipusudisp() As paginacion
            Get
                Return Me.p_pagvi_aipusudisp
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagvi_aipusudisp = Value
            End Set
        End Property

        Public Property lista_vi_aipusudisp() As List(Of vi_aipusudisp)
            Get
                Return Me.p_lista_vi_aipusudisp
            End Get
            Set(ByVal Value As List(Of vi_aipusudisp))
                Me.p_lista_vi_aipusudisp = Value
            End Set
        End Property
    End Class

End Namespace
