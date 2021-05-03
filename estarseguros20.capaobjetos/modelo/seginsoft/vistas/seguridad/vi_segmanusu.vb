
Namespace seginsoft.modelo.dbestarseguros20.vistas.seguridad

    Public Class vi_segmanusu

        Private p_idsegmanusu As Decimal
        Private p_idcomunmanpers As Decimal
        Private p_xcedula As String
        Private p_xnombres As String
        Private p_xapellidos As String
        Private p_xnombrecompleto As String
        Private p_fnacimiento As DateTime
        Private p_xsexo As String
        Private p_xnacionalidad As String
        Private p_xestatura As String
        Private p_xmedestatura As String
        Private p_xpeso As String
        Private p_xmedpeso As String
        Private p_idcomunmancom As Decimal
        Private p_xtelfmovil1 As String
        Private p_xtelfmovil2 As String
        Private p_xtelfoficina1 As String
        Private p_xtelfoficina2 As String
        Private p_xcorreoelectronico1 As String
        Private p_xcorreoelectronico2 As String
        Private p_xtwitter1 As String
        Private p_xfacebook1 As String
        Private p_idcomunmandir As Decimal
        Private p_idcomunmancont As Decimal
        Private p_xnombrecont As String
        Private p_idcomunmanpais As Decimal
        Private p_xnombrepais As String
        Private p_idcomunmanestado As Decimal
        Private p_xnombreestado As String
        Private p_idcomunmanlocalid As Decimal
        Private p_xnombrelocalid As String
        Private p_xdireccion As String
        Private p_idsegmanorg As Decimal
        Private p_xnombrecomercial As String
        Private p_idsegmandep As Decimal
        Private p_xnombredep As String
        Private p_idsegmancarg As Decimal
        Private p_xnombrecarg As String
        Private p_xnombreusuario As String
        Private p_xcontrasena As String
        Private p_fcreacion As DateTime
        Private p_ibloqueado As Boolean
        Private p_fultbloqueo As DateTime
        Private p_fultiniciosesion As DateTime
        Private p_fultcambpass As DateTime
        Private p_fultrecuppass As DateTime
        Private p_npassintfallido As Int64
        Private p_npassintfallidoacum As Int64
        Private p_xcultura As String
        Private p_idseglogreg As Decimal

        Public Property idsegmanusu() As Decimal
            Get
                Return Me.p_idsegmanusu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanusu = Value
            End Set
        End Property

        Public Property idcomunmanpers() As Decimal
            Get
                Return Me.p_idcomunmanpers
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanpers = Value
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

        Public Property xnacionalidad() As String
            Get
                Return Me.p_xnacionalidad
            End Get
            Set(ByVal Value As String)
                Me.p_xnacionalidad = Value
            End Set
        End Property

        Public Property xestatura() As String
            Get
                Return Me.p_xestatura
            End Get
            Set(ByVal Value As String)
                Me.p_xestatura = Value
            End Set
        End Property

        Public Property xmedestatura() As String
            Get
                Return Me.p_xmedestatura
            End Get
            Set(ByVal Value As String)
                Me.p_xmedestatura = Value
            End Set
        End Property

        Public Property xpeso() As String
            Get
                Return Me.p_xpeso
            End Get
            Set(ByVal Value As String)
                Me.p_xpeso = Value
            End Set
        End Property

        Public Property xmedpeso() As String
            Get
                Return Me.p_xmedpeso
            End Get
            Set(ByVal Value As String)
                Me.p_xmedpeso = Value
            End Set
        End Property

        Public Property idcomunmancom() As Decimal
            Get
                Return Me.p_idcomunmancom
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmancom = Value
            End Set
        End Property

        Public Property xtelfmovil1() As String
            Get
                Return Me.p_xtelfmovil1
            End Get
            Set(ByVal Value As String)
                Me.p_xtelfmovil1 = Value
            End Set
        End Property

        Public Property xtelfmovil2() As String
            Get
                Return Me.p_xtelfmovil2
            End Get
            Set(ByVal Value As String)
                Me.p_xtelfmovil2 = Value
            End Set
        End Property

        Public Property xtelfoficina1() As String
            Get
                Return Me.p_xtelfoficina1
            End Get
            Set(ByVal Value As String)
                Me.p_xtelfoficina1 = Value
            End Set
        End Property

        Public Property xtelfoficina2() As String
            Get
                Return Me.p_xtelfoficina2
            End Get
            Set(ByVal Value As String)
                Me.p_xtelfoficina2 = Value
            End Set
        End Property

        Public Property xcorreoelectronico1() As String
            Get
                Return Me.p_xcorreoelectronico1
            End Get
            Set(ByVal Value As String)
                Me.p_xcorreoelectronico1 = Value
            End Set
        End Property

        Public Property xcorreoelectronico2() As String
            Get
                Return Me.p_xcorreoelectronico2
            End Get
            Set(ByVal Value As String)
                Me.p_xcorreoelectronico2 = Value
            End Set
        End Property

        Public Property xtwitter1() As String
            Get
                Return Me.p_xtwitter1
            End Get
            Set(ByVal Value As String)
                Me.p_xtwitter1 = Value
            End Set
        End Property


        Public Property xfacebook1() As String
            Get
                Return Me.p_xfacebook1
            End Get
            Set(ByVal Value As String)
                Me.p_xfacebook1 = Value
            End Set
        End Property


        Public Property idcomunmandir() As Decimal
            Get
                Return Me.p_idcomunmandir
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmandir = Value
            End Set
        End Property


        Public Property idcomunmancont() As Decimal
            Get
                Return Me.p_idcomunmancont
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmancont = Value
            End Set
        End Property


        Public Property xnombrecont() As String
            Get
                Return Me.p_xnombrecont
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecont = Value
            End Set
        End Property


        Public Property idcomunmanpais() As Decimal
            Get
                Return Me.p_idcomunmanpais
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanpais = Value
            End Set
        End Property


        Public Property xnombrepais() As String
            Get
                Return Me.p_xnombrepais
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrepais = Value
            End Set
        End Property


        Public Property idcomunmanestado() As Decimal
            Get
                Return Me.p_idcomunmanestado
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanestado = Value
            End Set
        End Property


        Public Property xnombreestado() As String
            Get
                Return Me.p_xnombreestado
            End Get
            Set(ByVal Value As String)
                Me.p_xnombreestado = Value
            End Set
        End Property


        Public Property idcomunmanlocalid() As Decimal
            Get
                Return Me.p_idcomunmanlocalid
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanlocalid = Value
            End Set
        End Property


        Public Property xnombrelocalid() As String
            Get
                Return Me.p_xnombrelocalid
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrelocalid = Value
            End Set
        End Property


        Public Property xdireccion() As String
            Get
                Return Me.p_xdireccion
            End Get
            Set(ByVal Value As String)
                Me.p_xdireccion = Value
            End Set
        End Property


        Public Property idsegmanorg() As Decimal
            Get
                Return Me.p_idsegmanorg
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanorg = Value
            End Set
        End Property


        Public Property xnombrecomercial() As String
            Get
                Return Me.p_xnombrecomercial
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecomercial = Value
            End Set
        End Property


        Public Property idsegmandep() As Decimal
            Get
                Return Me.p_idsegmandep
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmandep = Value
            End Set
        End Property


        Public Property xnombredep() As String
            Get
                Return Me.p_xnombredep
            End Get
            Set(ByVal Value As String)
                Me.p_xnombredep = Value
            End Set
        End Property


        Public Property idsegmancarg() As Decimal
            Get
                Return Me.p_idsegmancarg
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmancarg = Value
            End Set
        End Property


        Public Property xnombrecarg() As String
            Get
                Return Me.p_xnombrecarg
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecarg = Value
            End Set
        End Property


        Public Property xnombreusuario() As String
            Get
                Return Me.p_xnombreusuario
            End Get
            Set(ByVal Value As String)
                Me.p_xnombreusuario = Value
            End Set
        End Property


        Public Property xcontrasena() As String
            Get
                Return Me.p_xcontrasena
            End Get
            Set(ByVal Value As String)
                Me.p_xcontrasena = Value
            End Set
        End Property


        Public Property fcreacion() As DateTime
            Get
                Return Me.p_fcreacion
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fcreacion = Value
            End Set
        End Property


        Public Property ibloqueado() As Boolean
            Get
                Return Me.p_ibloqueado
            End Get
            Set(ByVal Value As Boolean)
                Me.p_ibloqueado = Value
            End Set
        End Property


        Public Property fultbloqueo() As DateTime
            Get
                Return Me.p_fultbloqueo
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fultbloqueo = Value
            End Set
        End Property


        Public Property fultiniciosesion() As DateTime
            Get
                Return Me.p_fultiniciosesion
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fultiniciosesion = Value
            End Set
        End Property


        Public Property fultcambpass() As DateTime
            Get
                Return Me.p_fultcambpass
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fultcambpass = Value
            End Set
        End Property


        Public Property fultrecuppass() As DateTime
            Get
                Return Me.p_fultrecuppass
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fultrecuppass = Value
            End Set
        End Property


        Public Property npassintfallido() As Int64
            Get
                Return Me.p_npassintfallido
            End Get
            Set(ByVal Value As Int64)
                Me.p_npassintfallido = Value
            End Set
        End Property


        Public Property npassintfallidoacum() As Int64
            Get
                Return Me.p_npassintfallidoacum
            End Get
            Set(ByVal Value As Int64)
                Me.p_npassintfallidoacum = Value
            End Set
        End Property

         _
        Public Property xcultura() As String
            Get
                Return Me.p_xcultura
            End Get
            Set(ByVal Value As String)
                Me.p_xcultura = Value
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
End Namespace