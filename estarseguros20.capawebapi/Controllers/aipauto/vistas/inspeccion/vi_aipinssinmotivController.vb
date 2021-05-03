Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinssinmotivController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinssinmotivxid(idaipinssinmotiv As Decimal) As vi_aipinssinmotiv
            Dim vi_aipinssinmotiv As vi_aipinssinmotiv = (From p In _db.vi_aipinssinmotiv
                                            Where p.idaipinssinmotiv = idaipinssinmotiv
                                            Select p).SingleOrDefault
            Return vi_aipinssinmotiv
        End Function

	<HttpPost()> _
	Public Function selvi_aipinssinmotiv() As List(Of vi_aipinssinmotiv)
		Dim lista_vi_aipinssinmotiv As List(Of vi_aipinssinmotiv) = (From p In _db.vi_aipinssinmotiv
													Select p).ToList
		'
		Return lista_vi_aipinssinmotiv
	End Function

<HttpPost()> _
	Public Function selvi_aipinssinmotivxwheredinamicopag(petivi_aipinssinmotivpaglist as petivi_aipinssinmotivpaglist) as respvi_aipinssinmotivpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.idaipinssinmotiv <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssinmotiv=")
				sb.Append(valor_entero(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.idaipinssinmotiv))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssinmotiv=")
				sb.Append(valor_entero(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.idaipinssinmotiv))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.idaipinssin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssin=")
				sb.Append(valor_entero(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.idaipinssin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssin=")
				sb.Append(valor_entero(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.idaipinssin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.idaipinsmotiv <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsmotiv=")
				sb.Append(valor_entero(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.idaipinsmotiv))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsmotiv=")
				sb.Append(valor_entero(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.idaipinsmotiv))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.xnominsmotiv <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnominsmotiv='")
				sb.Append(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.xnominsmotiv)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnominsmotiv='")
				sb.Append(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.xnominsmotiv)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.itipoinsmotiv <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsmotiv='")
				sb.Append(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.itipoinsmotiv)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsmotiv='")
				sb.Append(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.itipoinsmotiv)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.iestatinsmotiv <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsmotiv='")
				sb.Append(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.iestatinsmotiv)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsmotiv='")
				sb.Append(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.iestatinsmotiv)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.itilinssinmotiv <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.itilinssinmotiv=")
				sb.Append(valor_entero(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.itilinssinmotiv))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itilinssinmotiv=")
				sb.Append(valor_entero(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.itilinssinmotiv))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssinmotivpaglist.vi_aipinssinmotiv.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinssinmotivpaglist As New respvi_aipinssinmotivpaglist
	respvi_aipinssinmotivpaglist.pagvi_aipinssinmotiv = petivi_aipinssinmotivpaglist.pagvi_aipinssinmotiv
	Dim skip = skip_paginacion(petivi_aipinssinmotivpaglist.pagvi_aipinssinmotiv.npagactual, petivi_aipinssinmotivpaglist.pagvi_aipinssinmotiv.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinssinmotivpaglist.lista_vi_aipinssinmotiv = _db.vi_aipinssinmotiv.OrderBy(petivi_aipinssinmotivpaglist.pagvi_aipinssinmotiv.xcamposord & " "  & petivi_aipinssinmotivpaglist.pagvi_aipinssinmotiv.idirord).Skip(skip).Take(petivi_aipinssinmotivpaglist.pagvi_aipinssinmotiv.npagtamano).ToList
		Else
			respvi_aipinssinmotivpaglist.lista_vi_aipinssinmotiv = _db.vi_aipinssinmotiv.Where(sb.ToString).OrderBy(petivi_aipinssinmotivpaglist.pagvi_aipinssinmotiv.xcamposord & " "  & petivi_aipinssinmotivpaglist.pagvi_aipinssinmotiv.idirord).Skip(skip).Take(petivi_aipinssinmotivpaglist.pagvi_aipinssinmotiv.npagtamano).ToList
		End If
		'
		If (respvi_aipinssinmotivpaglist.lista_vi_aipinssinmotiv.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinssinmotivxwheredinamicocount(sb)
		respvi_aipinssinmotivpaglist.pagvi_aipinssinmotiv.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinssinmotivpaglist.pagvi_aipinssinmotiv.npagtamano)
		Else
		respvi_aipinssinmotivpaglist.pagvi_aipinssinmotiv.npagcantidad = 0
		respvi_aipinssinmotivpaglist.pagvi_aipinssinmotiv.npagactual = 0
		End If
	
		Return respvi_aipinssinmotivpaglist
	End Function


        Public Function selvi_aipinssinmotivxwheredinamicocount(sb As StringBuilder) As Integer

            If sb.ToString = "" Then
                Return _db.vi_aipinssinmotiv.Count
            Else
                Return _db.vi_aipinssinmotiv.Where(sb.ToString).Count
            End If
        End Function

        ''personalizados



        <HttpPost()> _
        Public Function selvi_aipinssinmotivxidaipinssin(idaipinssin As Decimal) As List(Of vi_aipinssinmotiv)
            Dim lista_vi_aipinssinmotiv As List(Of vi_aipinssinmotiv) = (From p In _db.vi_aipinssinmotiv
                                            Where p.idaipinssin = idaipinssin
                                            Select p).ToList
            Return lista_vi_aipinssinmotiv
        End Function
End Class
End Namespace
