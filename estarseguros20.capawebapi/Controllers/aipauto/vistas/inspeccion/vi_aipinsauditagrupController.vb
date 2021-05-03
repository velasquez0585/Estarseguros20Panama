Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsauditagrupController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsauditagrupxid(idsegmanusuaudit As Decimal) As vi_aipinsauditagrup
            Dim vi_aipinsauditagrup As vi_aipinsauditagrup = (From p In _db.vi_aipinsauditagrup
                                            Where p.idsegmanusuaudit = idsegmanusuaudit
                                            Select p).SingleOrDefault
            Return vi_aipinsauditagrup
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsauditagrup() As List(Of vi_aipinsauditagrup)
		Dim lista_vi_aipinsauditagrup As List(Of vi_aipinsauditagrup) = (From p In _db.vi_aipinsauditagrup
													Select p).ToList
		'
		Return lista_vi_aipinsauditagrup
	End Function

<HttpPost()> _
	Public Function selvi_aipinsauditagrupxwheredinamicopag(petivi_aipinsauditagruppaglist as petivi_aipinsauditagruppaglist) as respvi_aipinsauditagruppaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsauditagruppaglist.vi_aipinsauditagrup.idsegmanusuaudit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusuaudit=")
				sb.Append(valor_entero(petivi_aipinsauditagruppaglist.vi_aipinsauditagrup.idsegmanusuaudit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusuaudit=")
				sb.Append(valor_entero(petivi_aipinsauditagruppaglist.vi_aipinsauditagrup.idsegmanusuaudit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsauditagruppaglist.vi_aipinsauditagrup.xnombrecompletoaudit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompletoaudit='")
				sb.Append(petivi_aipinsauditagruppaglist.vi_aipinsauditagrup.xnombrecompletoaudit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompletoaudit='")
				sb.Append(petivi_aipinsauditagruppaglist.vi_aipinsauditagrup.xnombrecompletoaudit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsauditagruppaglist.vi_aipinsauditagrup.idsegmanorgaudit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanorgaudit=")
				sb.Append(valor_entero(petivi_aipinsauditagruppaglist.vi_aipinsauditagrup.idsegmanorgaudit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanorgaudit=")
				sb.Append(valor_entero(petivi_aipinsauditagruppaglist.vi_aipinsauditagrup.idsegmanorgaudit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsauditagruppaglist.vi_aipinsauditagrup.xnombrecomercialaudit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecomercialaudit='")
				sb.Append(petivi_aipinsauditagruppaglist.vi_aipinsauditagrup.xnombrecomercialaudit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecomercialaudit='")
				sb.Append(petivi_aipinsauditagruppaglist.vi_aipinsauditagrup.xnombrecomercialaudit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsauditagruppaglist.vi_aipinsauditagrup.ncantreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantreg=")
				sb.Append(valor_entero(petivi_aipinsauditagruppaglist.vi_aipinsauditagrup.ncantreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantreg=")
				sb.Append(valor_entero(petivi_aipinsauditagruppaglist.vi_aipinsauditagrup.ncantreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsauditagruppaglist As New respvi_aipinsauditagruppaglist
	respvi_aipinsauditagruppaglist.pagvi_aipinsauditagrup = petivi_aipinsauditagruppaglist.pagvi_aipinsauditagrup
	Dim skip = skip_paginacion(petivi_aipinsauditagruppaglist.pagvi_aipinsauditagrup.npagactual, petivi_aipinsauditagruppaglist.pagvi_aipinsauditagrup.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsauditagruppaglist.lista_vi_aipinsauditagrup = _db.vi_aipinsauditagrup.OrderBy(petivi_aipinsauditagruppaglist.pagvi_aipinsauditagrup.xcamposord & " "  & petivi_aipinsauditagruppaglist.pagvi_aipinsauditagrup.idirord).Skip(skip).Take(petivi_aipinsauditagruppaglist.pagvi_aipinsauditagrup.npagtamano).ToList
		Else
			respvi_aipinsauditagruppaglist.lista_vi_aipinsauditagrup = _db.vi_aipinsauditagrup.Where(sb.ToString).OrderBy(petivi_aipinsauditagruppaglist.pagvi_aipinsauditagrup.xcamposord & " "  & petivi_aipinsauditagruppaglist.pagvi_aipinsauditagrup.idirord).Skip(skip).Take(petivi_aipinsauditagruppaglist.pagvi_aipinsauditagrup.npagtamano).ToList
		End If
		'
		If (respvi_aipinsauditagruppaglist.lista_vi_aipinsauditagrup.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsauditagrupxwheredinamicocount(sb)
		respvi_aipinsauditagruppaglist.pagvi_aipinsauditagrup.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsauditagruppaglist.pagvi_aipinsauditagrup.npagtamano)
		Else
		respvi_aipinsauditagruppaglist.pagvi_aipinsauditagrup.npagcantidad = 0
		respvi_aipinsauditagruppaglist.pagvi_aipinsauditagrup.npagactual = 0
		End If
	
		Return respvi_aipinsauditagruppaglist
	End Function

	Public Function selvi_aipinsauditagrupxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsauditagrup.count
	Else
	Return _db.vi_aipinsauditagrup.Where(sb.ToString).Count
	End If
	End Function

End Class
End Namespace
