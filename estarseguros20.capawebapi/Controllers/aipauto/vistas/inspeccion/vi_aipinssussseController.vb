Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinssussseController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinssusssexid(idaipinssussse As Decimal) As vi_aipinssussse
            Dim vi_aipinssussse As vi_aipinssussse = (From p In _db.vi_aipinssussse
                                            Where p.idaipinssussse = idaipinssussse
                                            Select p).SingleOrDefault
            Return vi_aipinssussse
        End Function

	<HttpPost()> _
	Public Function selvi_aipinssussse() As List(Of vi_aipinssussse)
		Dim lista_vi_aipinssussse As List(Of vi_aipinssussse) = (From p In _db.vi_aipinssussse
													Select p).ToList
		'
		Return lista_vi_aipinssussse
	End Function

<HttpPost()> _
	Public Function selvi_aipinssusssexwheredinamicopag(petivi_aipinssusssepaglist as petivi_aipinssusssepaglist) as respvi_aipinssusssepaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinssusssepaglist.vi_aipinssussse.idaipinssussse <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssussse=")
				sb.Append(valor_entero(petivi_aipinssusssepaglist.vi_aipinssussse.idaipinssussse))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssussse=")
				sb.Append(valor_entero(petivi_aipinssusssepaglist.vi_aipinssussse.idaipinssussse))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusssepaglist.vi_aipinssussse.idaipinssus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssus=")
				sb.Append(valor_entero(petivi_aipinssusssepaglist.vi_aipinssussse.idaipinssus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssus=")
				sb.Append(valor_entero(petivi_aipinssusssepaglist.vi_aipinssussse.idaipinssus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusssepaglist.vi_aipinssussse.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssusssepaglist.vi_aipinssussse.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssusssepaglist.vi_aipinssussse.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusssepaglist.vi_aipinssussse.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinssusssepaglist.vi_aipinssussse.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinssusssepaglist.vi_aipinssussse.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusssepaglist.vi_aipinssussse.idaipmanvehsse <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehsse=")
				sb.Append(valor_entero(petivi_aipinssusssepaglist.vi_aipinssussse.idaipmanvehsse))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehsse=")
				sb.Append(valor_entero(petivi_aipinssusssepaglist.vi_aipinssussse.idaipmanvehsse))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusssepaglist.vi_aipinssussse.xnommanvehsse <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehsse='")
				sb.Append(petivi_aipinssusssepaglist.vi_aipinssussse.xnommanvehsse)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehsse='")
				sb.Append(petivi_aipinssusssepaglist.vi_aipinssussse.xnommanvehsse)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusssepaglist.vi_aipinssussse.iexisinssussse <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iexisinssussse=")
				sb.Append(valor_entero(petivi_aipinssusssepaglist.vi_aipinssussse.iexisinssussse))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iexisinssussse=")
				sb.Append(valor_entero(petivi_aipinssusssepaglist.vi_aipinssussse.iexisinssussse))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusssepaglist.vi_aipinssussse.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssusssepaglist.vi_aipinssussse.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssusssepaglist.vi_aipinssussse.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinssusssepaglist As New respvi_aipinssusssepaglist
	respvi_aipinssusssepaglist.pagvi_aipinssussse = petivi_aipinssusssepaglist.pagvi_aipinssussse
	Dim skip = skip_paginacion(petivi_aipinssusssepaglist.pagvi_aipinssussse.npagactual, petivi_aipinssusssepaglist.pagvi_aipinssussse.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinssusssepaglist.lista_vi_aipinssussse = _db.vi_aipinssussse.OrderBy(petivi_aipinssusssepaglist.pagvi_aipinssussse.xcamposord & " "  & petivi_aipinssusssepaglist.pagvi_aipinssussse.idirord).Skip(skip).Take(petivi_aipinssusssepaglist.pagvi_aipinssussse.npagtamano).ToList
		Else
			respvi_aipinssusssepaglist.lista_vi_aipinssussse = _db.vi_aipinssussse.Where(sb.ToString).OrderBy(petivi_aipinssusssepaglist.pagvi_aipinssussse.xcamposord & " "  & petivi_aipinssusssepaglist.pagvi_aipinssussse.idirord).Skip(skip).Take(petivi_aipinssusssepaglist.pagvi_aipinssussse.npagtamano).ToList
		End If
		'
		If (respvi_aipinssusssepaglist.lista_vi_aipinssussse.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinssusssexwheredinamicocount(sb)
		respvi_aipinssusssepaglist.pagvi_aipinssussse.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinssusssepaglist.pagvi_aipinssussse.npagtamano)
		Else
		respvi_aipinssusssepaglist.pagvi_aipinssussse.npagcantidad = 0
		respvi_aipinssusssepaglist.pagvi_aipinssussse.npagactual = 0
		End If
	
		Return respvi_aipinssusssepaglist
	End Function

	Public Function selvi_aipinssusssexwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinssussse.count
	Else
	Return _db.vi_aipinssussse.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinssusssexidaipinssus(idaipinssus As Decimal) As List(Of vi_aipinssussse)
            Dim lista_vi_aipinssussse As List(Of vi_aipinssussse) = (From p In _db.vi_aipinssussse
                                            Where p.idaipinssus = idaipinssus
                                            Select p).ToList
            Return lista_vi_aipinssussse
        End Function
End Class
End Namespace
