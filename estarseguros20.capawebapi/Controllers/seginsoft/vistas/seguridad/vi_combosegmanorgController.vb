Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace seginsoft.vistas.controlador
    Public Class vi_combosegmanorgController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_combosegmanorgxid(idsegmanorg As Decimal) As vi_combosegmanorg
            Dim vi_combosegmanorg As vi_combosegmanorg = (From p In _db.vi_combosegmanorg
                                            Where p.idsegmanorg = idsegmanorg
                                            Select p).SingleOrDefault
            Return vi_combosegmanorg
        End Function

        <HttpPost()> _
        Public Function selvi_combosegmanorg() As List(Of vi_combosegmanorg)
            Dim lista_vi_combosegmanorg As List(Of vi_combosegmanorg) = (From p In _db.vi_combosegmanorg
                                                                         Where p.idsegmanorg > 0
                                                                         Order By p.xnombrecomercial Ascending
                                                        Select p).ToList
            'agregar el item vacio para seleccion
            Dim vi_combosegmanorg As New vi_combosegmanorg
            With vi_combosegmanorg
                .idsegmanorg = 0
                .xnombrecomercial = "SELECCIONE"
            End With
            lista_vi_combosegmanorg.Insert(0, vi_combosegmanorg)
            Return lista_vi_combosegmanorg
        End Function

        <HttpPost()> _
        Public Function selvi_combosegmanorgsinsel() As List(Of vi_combosegmanorg)
            Dim lista_vi_combosegmanorg As List(Of vi_combosegmanorg) = (From p In _db.vi_combosegmanorg
                                                                         Where p.idsegmanorg > 0
                                                                         Order By p.xnombrecomercial Ascending
                                                        Select p).ToList

            Return lista_vi_combosegmanorg
        End Function

        '<HttpPost()> _
        '	Public Function selvi_combosegmanorgxwheredinamicopag(petivi_combosegmanorgpaglist as petivi_combosegmanorgpaglist) as respvi_combosegmanorgpaglist
        '		Dim sb As New StringBuilder("")
        '		'
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.idsegmanorg <> 0 Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.idsegmanorg=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idsegmanorg))
        '				sb.Append("")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.idsegmanorg=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idsegmanorg))
        '				sb.Append("")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmanempr <> 0 Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.idcomunmanempr=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmanempr))
        '				sb.Append("")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.idcomunmanempr=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmanempr))
        '				sb.Append("")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xrif <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xrif='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xrif)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xrif='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xrif)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xrazonsocial <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xrazonsocial='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xrazonsocial)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xrazonsocial='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xrazonsocial)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xnombrecomercial <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xnombrecomercial='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xnombrecomercial)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xnombrecomercial='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xnombrecomercial)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmandir <> 0 Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.idcomunmandir=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmandir))
        '				sb.Append("")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.idcomunmandir=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmandir))
        '				sb.Append("")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmancont <> 0 Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.idcomunmancont=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmancont))
        '				sb.Append("")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.idcomunmancont=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmancont))
        '				sb.Append("")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xnombrecont <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xnombrecont='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xnombrecont)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xnombrecont='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xnombrecont)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmanpais <> 0 Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.idcomunmanpais=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmanpais))
        '				sb.Append("")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.idcomunmanpais=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmanpais))
        '				sb.Append("")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xnombrepais <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xnombrepais='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xnombrepais)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xnombrepais='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xnombrepais)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmanestado <> 0 Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.idcomunmanestado=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmanestado))
        '				sb.Append("")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.idcomunmanestado=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmanestado))
        '				sb.Append("")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xnombreestado <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xnombreestado='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xnombreestado)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xnombreestado='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xnombreestado)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmanlocalid <> 0 Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.idcomunmanlocalid=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmanlocalid))
        '				sb.Append("")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.idcomunmanlocalid=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmanlocalid))
        '				sb.Append("")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xnombrelocalid <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xnombrelocalid='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xnombrelocalid)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xnombrelocalid='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xnombrelocalid)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xdireccion <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xdireccion='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xdireccion)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xdireccion='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xdireccion)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmancom <> 0 Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.idcomunmancom=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmancom))
        '				sb.Append("")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.idcomunmancom=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idcomunmancom))
        '				sb.Append("")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xtelfoficina1 <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xtelfoficina1='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xtelfoficina1)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xtelfoficina1='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xtelfoficina1)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xtelfoficina2 <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xtelfoficina2='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xtelfoficina2)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xtelfoficina2='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xtelfoficina2)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xtelffax1 <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xtelffax1='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xtelffax1)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xtelffax1='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xtelffax1)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xtelffax2 <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xtelffax2='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xtelffax2)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xtelffax2='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xtelffax2)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xcorreoelectronico1 <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xcorreoelectronico1='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xcorreoelectronico1)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xcorreoelectronico1='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xcorreoelectronico1)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xcorreoelectronico2 <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xcorreoelectronico2='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xcorreoelectronico2)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xcorreoelectronico2='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xcorreoelectronico2)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xdireccionweb1 <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xdireccionweb1='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xdireccionweb1)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xdireccionweb1='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xdireccionweb1)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xtwitter1 <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xtwitter1='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xtwitter1)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xtwitter1='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xtwitter1)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.xfacebook1 <> "" Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.xfacebook1='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xfacebook1)
        '				sb.Append("'")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.xfacebook1='")
        '				sb.Append(petivi_combosegmanorgpaglist.vi_combosegmanorg.xfacebook1)
        '				sb.Append("'")
        '	        End If
        '	    End If
        '	End If
        '	 '
        '		If petivi_combosegmanorgpaglist.vi_combosegmanorg.idseglogreg <> 0 Then
        '	    If sb.Length = 0 Then
        '				sb.Append("it.idseglogreg=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idseglogreg))
        '				sb.Append("")
        '	    Else
        '	        If sb.Length > 0 Then
        '				sb.Append(" and it.idseglogreg=")
        '				sb.Append(valor_entero(petivi_combosegmanorgpaglist.vi_combosegmanorg.idseglogreg))
        '				sb.Append("")
        '	        End If
        '	    End If
        '	End If
        '	 '


        '	Dim respvi_combosegmanorgpaglist As New respvi_combosegmanorgpaglist
        '	respvi_combosegmanorgpaglist.pagvi_combosegmanorg = petivi_combosegmanorgpaglist.pagvi_combosegmanorg
        '	Dim skip = skip_paginacion(petivi_combosegmanorgpaglist.pagvi_combosegmanorg.npagactual, petivi_combosegmanorgpaglist.pagvi_combosegmanorg.npagtamano)

        '		If sb.ToString = "" Then
        '			respvi_combosegmanorgpaglist.lista_vi_combosegmanorg = _db.vi_combosegmanorg.OrderBy(petivi_combosegmanorgpaglist.pagvi_combosegmanorg.xcamposord & " "  & petivi_combosegmanorgpaglist.pagvi_combosegmanorg.idirord).Skip(skip).Take(petivi_combosegmanorgpaglist.pagvi_combosegmanorg.npagtamano).ToList
        '		Else
        '			respvi_combosegmanorgpaglist.lista_vi_combosegmanorg = _db.vi_combosegmanorg.Where(sb.ToString).OrderBy(petivi_combosegmanorgpaglist.pagvi_combosegmanorg.xcamposord & " "  & petivi_combosegmanorgpaglist.pagvi_combosegmanorg.idirord).Skip(skip).Take(petivi_combosegmanorgpaglist.pagvi_combosegmanorg.npagtamano).ToList
        '		End If
        '		'
        '		If (respvi_combosegmanorgpaglist.lista_vi_combosegmanorg.Count > 0) Then
        '		 Dim cant_entero_reg As Integer = 0
        '		cant_entero_reg = selvi_combosegmanorgxwheredinamicocount(sb)
        '		respvi_combosegmanorgpaglist.pagvi_combosegmanorg.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_combosegmanorgpaglist.pagvi_combosegmanorg.npagtamano)
        '		Else
        '		respvi_combosegmanorgpaglist.pagvi_combosegmanorg.npagcantidad = 0
        '		respvi_combosegmanorgpaglist.pagvi_combosegmanorg.npagactual = 0
        '		End If

        '		Return respvi_combosegmanorgpaglist
        '	End Function

        Public Function selvi_combosegmanorgxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.vi_combosegmanorg.Count
            Else
                Return _db.vi_combosegmanorg.Where(sb.ToString).Count
            End If
        End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_combosegmanorgsel() As List(Of vi_combosegmanorg)
            Dim lista_vi_combosegmanorg As List(Of vi_combosegmanorg) = (From p In _db.vi_combosegmanorg
                                                                         Where p.idsegmanorg > 0
                                                                         Order By p.xnombrecomercial Ascending
                                                        Select p).ToList
            '
            'agregar el item vacio para seleccion
            Dim vi_combosegmanorg As New vi_combosegmanorg
            With vi_combosegmanorg
                .idsegmanorg = 0
                .idcomunmanempr = 0
                .xnombrecomercial = "SELECCIONE..."
                .xrazonsocial = "SELECCIONE..."
            End With
            lista_vi_combosegmanorg.Insert(0, vi_combosegmanorg)

            Return lista_vi_combosegmanorg
        End Function

    End Class
End Namespace
