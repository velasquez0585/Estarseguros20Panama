Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinssusmotivController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinssusmotivxid(idaipinssusmotiv As Decimal) As vi_aipinssusmotiv
            Dim vi_aipinssusmotiv As vi_aipinssusmotiv = (From p In _db.vi_aipinssusmotiv
                                            Where p.idaipinssusmotiv = idaipinssusmotiv
                                            Select p).SingleOrDefault
            Return vi_aipinssusmotiv
        End Function

	<HttpPost()> _
	Public Function selvi_aipinssusmotiv() As List(Of vi_aipinssusmotiv)
		Dim lista_vi_aipinssusmotiv As List(Of vi_aipinssusmotiv) = (From p In _db.vi_aipinssusmotiv
													Select p).ToList
		'
		Return lista_vi_aipinssusmotiv
	End Function

<HttpPost()> _
	Public Function selvi_aipinssusmotivxwheredinamicopag(petivi_aipinssusmotivpaglist as petivi_aipinssusmotivpaglist) as respvi_aipinssusmotivpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.idaipinssusmotiv <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssusmotiv=")
				sb.Append(valor_entero(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.idaipinssusmotiv))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssusmotiv=")
				sb.Append(valor_entero(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.idaipinssusmotiv))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.idaipinssus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssus=")
				sb.Append(valor_entero(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.idaipinssus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssus=")
				sb.Append(valor_entero(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.idaipinssus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.idaipinsmotiv <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsmotiv=")
				sb.Append(valor_entero(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.idaipinsmotiv))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsmotiv=")
				sb.Append(valor_entero(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.idaipinsmotiv))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.xnominsmotiv <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnominsmotiv='")
				sb.Append(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.xnominsmotiv)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnominsmotiv='")
				sb.Append(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.xnominsmotiv)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.itilinssusmotiv <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.itilinssusmotiv=")
				sb.Append(valor_entero(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.itilinssusmotiv))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itilinssusmotiv=")
				sb.Append(valor_entero(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.itilinssusmotiv))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssusmotivpaglist.vi_aipinssusmotiv.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinssusmotivpaglist As New respvi_aipinssusmotivpaglist
	respvi_aipinssusmotivpaglist.pagvi_aipinssusmotiv = petivi_aipinssusmotivpaglist.pagvi_aipinssusmotiv
	Dim skip = skip_paginacion(petivi_aipinssusmotivpaglist.pagvi_aipinssusmotiv.npagactual, petivi_aipinssusmotivpaglist.pagvi_aipinssusmotiv.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinssusmotivpaglist.lista_vi_aipinssusmotiv = _db.vi_aipinssusmotiv.OrderBy(petivi_aipinssusmotivpaglist.pagvi_aipinssusmotiv.xcamposord & " "  & petivi_aipinssusmotivpaglist.pagvi_aipinssusmotiv.idirord).Skip(skip).Take(petivi_aipinssusmotivpaglist.pagvi_aipinssusmotiv.npagtamano).ToList
		Else
			respvi_aipinssusmotivpaglist.lista_vi_aipinssusmotiv = _db.vi_aipinssusmotiv.Where(sb.ToString).OrderBy(petivi_aipinssusmotivpaglist.pagvi_aipinssusmotiv.xcamposord & " "  & petivi_aipinssusmotivpaglist.pagvi_aipinssusmotiv.idirord).Skip(skip).Take(petivi_aipinssusmotivpaglist.pagvi_aipinssusmotiv.npagtamano).ToList
		End If
		'
		If (respvi_aipinssusmotivpaglist.lista_vi_aipinssusmotiv.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinssusmotivxwheredinamicocount(sb)
		respvi_aipinssusmotivpaglist.pagvi_aipinssusmotiv.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinssusmotivpaglist.pagvi_aipinssusmotiv.npagtamano)
		Else
		respvi_aipinssusmotivpaglist.pagvi_aipinssusmotiv.npagcantidad = 0
		respvi_aipinssusmotivpaglist.pagvi_aipinssusmotiv.npagactual = 0
		End If
	
		Return respvi_aipinssusmotivpaglist
	End Function

	Public Function selvi_aipinssusmotivxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinssusmotiv.count
	Else
	Return _db.vi_aipinssusmotiv.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinssusmotivxidaipinssus(idaipinssus As Decimal) As List(Of vi_aipinssusmotiv)
            Dim lista_vi_aipinssusmotiv As List(Of vi_aipinssusmotiv) = (From p In _db.vi_aipinssusmotiv
                                            Where p.idaipinssus = idaipinssus
                                            Select p).ToList
            Return lista_vi_aipinssusmotiv
        End Function
End Class
End Namespace
