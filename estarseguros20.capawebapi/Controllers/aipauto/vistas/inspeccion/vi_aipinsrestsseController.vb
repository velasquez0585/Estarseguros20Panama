Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsrestsseController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsrestssexid(idaipinsrestsse As Decimal) As vi_aipinsrestsse
            Dim vi_aipinsrestsse As vi_aipinsrestsse = (From p In _db.vi_aipinsrestsse
                                            Where p.idaipinsrestsse = idaipinsrestsse
                                            Select p).SingleOrDefault
            Return vi_aipinsrestsse
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsrestsse() As List(Of vi_aipinsrestsse)
		Dim lista_vi_aipinsrestsse As List(Of vi_aipinsrestsse) = (From p In _db.vi_aipinsrestsse
													Select p).ToList
		'
		Return lista_vi_aipinsrestsse
	End Function

<HttpPost()> _
	Public Function selvi_aipinsrestssexwheredinamicopag(petivi_aipinsrestssepaglist as petivi_aipinsrestssepaglist) as respvi_aipinsrestssepaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsrestssepaglist.vi_aipinsrestsse.idaipinsrestsse <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsrestsse=")
				sb.Append(valor_entero(petivi_aipinsrestssepaglist.vi_aipinsrestsse.idaipinsrestsse))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsrestsse=")
				sb.Append(valor_entero(petivi_aipinsrestssepaglist.vi_aipinsrestsse.idaipinsrestsse))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestssepaglist.vi_aipinsrestsse.idaipinsrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsrest=")
				sb.Append(valor_entero(petivi_aipinsrestssepaglist.vi_aipinsrestsse.idaipinsrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsrest=")
				sb.Append(valor_entero(petivi_aipinsrestssepaglist.vi_aipinsrestsse.idaipinsrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestssepaglist.vi_aipinsrestsse.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsrestssepaglist.vi_aipinsrestsse.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsrestssepaglist.vi_aipinsrestsse.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestssepaglist.vi_aipinsrestsse.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinsrestssepaglist.vi_aipinsrestsse.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinsrestssepaglist.vi_aipinsrestsse.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestssepaglist.vi_aipinsrestsse.idaipmanvehsse <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehsse=")
				sb.Append(valor_entero(petivi_aipinsrestssepaglist.vi_aipinsrestsse.idaipmanvehsse))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehsse=")
				sb.Append(valor_entero(petivi_aipinsrestssepaglist.vi_aipinsrestsse.idaipmanvehsse))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestssepaglist.vi_aipinsrestsse.xnommanvehsse <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehsse='")
				sb.Append(petivi_aipinsrestssepaglist.vi_aipinsrestsse.xnommanvehsse)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehsse='")
				sb.Append(petivi_aipinsrestssepaglist.vi_aipinsrestsse.xnommanvehsse)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestssepaglist.vi_aipinsrestsse.iexisinsrestsse <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iexisinsrestsse=")
				sb.Append(valor_entero(petivi_aipinsrestssepaglist.vi_aipinsrestsse.iexisinsrestsse))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iexisinsrestsse=")
				sb.Append(valor_entero(petivi_aipinsrestssepaglist.vi_aipinsrestsse.iexisinsrestsse))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestssepaglist.vi_aipinsrestsse.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsrestssepaglist.vi_aipinsrestsse.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsrestssepaglist.vi_aipinsrestsse.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsrestssepaglist As New respvi_aipinsrestssepaglist
	respvi_aipinsrestssepaglist.pagvi_aipinsrestsse = petivi_aipinsrestssepaglist.pagvi_aipinsrestsse
	Dim skip = skip_paginacion(petivi_aipinsrestssepaglist.pagvi_aipinsrestsse.npagactual, petivi_aipinsrestssepaglist.pagvi_aipinsrestsse.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsrestssepaglist.lista_vi_aipinsrestsse = _db.vi_aipinsrestsse.OrderBy(petivi_aipinsrestssepaglist.pagvi_aipinsrestsse.xcamposord & " "  & petivi_aipinsrestssepaglist.pagvi_aipinsrestsse.idirord).Skip(skip).Take(petivi_aipinsrestssepaglist.pagvi_aipinsrestsse.npagtamano).ToList
		Else
			respvi_aipinsrestssepaglist.lista_vi_aipinsrestsse = _db.vi_aipinsrestsse.Where(sb.ToString).OrderBy(petivi_aipinsrestssepaglist.pagvi_aipinsrestsse.xcamposord & " "  & petivi_aipinsrestssepaglist.pagvi_aipinsrestsse.idirord).Skip(skip).Take(petivi_aipinsrestssepaglist.pagvi_aipinsrestsse.npagtamano).ToList
		End If
		'
		If (respvi_aipinsrestssepaglist.lista_vi_aipinsrestsse.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsrestssexwheredinamicocount(sb)
		respvi_aipinsrestssepaglist.pagvi_aipinsrestsse.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsrestssepaglist.pagvi_aipinsrestsse.npagtamano)
		Else
		respvi_aipinsrestssepaglist.pagvi_aipinsrestsse.npagcantidad = 0
		respvi_aipinsrestssepaglist.pagvi_aipinsrestsse.npagactual = 0
		End If
	
		Return respvi_aipinsrestssepaglist
	End Function

	Public Function selvi_aipinsrestssexwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsrestsse.count
	Else
	Return _db.vi_aipinsrestsse.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinsrestssexidaipinsrest(idaipinsrest As Decimal) As List(Of vi_aipinsrestsse)
            Dim lista_vi_aipinsrestsse As List(Of vi_aipinsrestsse) = (From p In _db.vi_aipinsrestsse
                                            Where p.idaipinsrest = idaipinsrest
                                            Select p).ToList
            Return lista_vi_aipinsrestsse
        End Function

End Class
End Namespace
