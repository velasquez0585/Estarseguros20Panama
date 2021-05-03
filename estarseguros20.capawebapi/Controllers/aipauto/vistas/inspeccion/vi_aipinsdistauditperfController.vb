Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsdistauditperfController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsdistauditperfxid(idsegmanusuaudit As Decimal) As vi_aipinsdistauditperf
            Dim vi_aipinsdistauditperf As vi_aipinsdistauditperf = (From p In _db.vi_aipinsdistauditperf
                                            Where p.idsegmanusuaudit = idsegmanusuaudit
                                            Select p).SingleOrDefault
            Return vi_aipinsdistauditperf
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsdistauditperf() As List(Of vi_aipinsdistauditperf)
		Dim lista_vi_aipinsdistauditperf As List(Of vi_aipinsdistauditperf) = (From p In _db.vi_aipinsdistauditperf
													Select p).ToList
		'
		Return lista_vi_aipinsdistauditperf
	End Function

<HttpPost()> _
	Public Function selvi_aipinsdistauditperfxwheredinamicopag(petivi_aipinsdistauditperfpaglist as petivi_aipinsdistauditperfpaglist) as respvi_aipinsdistauditperfpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.idsegmanusuaudit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusuaudit=")
				sb.Append(valor_entero(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.idsegmanusuaudit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusuaudit=")
				sb.Append(valor_entero(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.idsegmanusuaudit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.xnombrecompletoaudit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompletoaudit='")
				sb.Append(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.xnombrecompletoaudit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompletoaudit='")
				sb.Append(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.xnombrecompletoaudit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.idsegmanorgaudit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanorgaudit=")
				sb.Append(valor_entero(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.idsegmanorgaudit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanorgaudit=")
				sb.Append(valor_entero(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.idsegmanorgaudit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.xnombrecomercialaudit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecomercialaudit='")
				sb.Append(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.xnombrecomercialaudit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecomercialaudit='")
				sb.Append(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.xnombrecomercialaudit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.idsegmanapp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanapp=")
				sb.Append(valor_entero(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.idsegmanapp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanapp=")
				sb.Append(valor_entero(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.idsegmanapp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.idsegmanperf <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanperf=")
				sb.Append(valor_entero(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.idsegmanperf))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanperf=")
				sb.Append(valor_entero(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.idsegmanperf))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.xnombreperf <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombreperf='")
				sb.Append(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.xnombreperf)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombreperf='")
				sb.Append(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.xnombreperf)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.ibloqueado <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ibloqueado=")
				sb.Append(valor_entero(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.ibloqueado))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ibloqueado=")
				sb.Append(valor_entero(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.ibloqueado))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.ncantinsperit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinsperit=")
				sb.Append(valor_entero(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.ncantinsperit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinsperit=")
				sb.Append(valor_entero(petivi_aipinsdistauditperfpaglist.vi_aipinsdistauditperf.ncantinsperit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsdistauditperfpaglist As New respvi_aipinsdistauditperfpaglist
	respvi_aipinsdistauditperfpaglist.pagvi_aipinsdistauditperf = petivi_aipinsdistauditperfpaglist.pagvi_aipinsdistauditperf
	Dim skip = skip_paginacion(petivi_aipinsdistauditperfpaglist.pagvi_aipinsdistauditperf.npagactual, petivi_aipinsdistauditperfpaglist.pagvi_aipinsdistauditperf.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsdistauditperfpaglist.lista_vi_aipinsdistauditperf = _db.vi_aipinsdistauditperf.OrderBy(petivi_aipinsdistauditperfpaglist.pagvi_aipinsdistauditperf.xcamposord & " "  & petivi_aipinsdistauditperfpaglist.pagvi_aipinsdistauditperf.idirord).Skip(skip).Take(petivi_aipinsdistauditperfpaglist.pagvi_aipinsdistauditperf.npagtamano).ToList
		Else
			respvi_aipinsdistauditperfpaglist.lista_vi_aipinsdistauditperf = _db.vi_aipinsdistauditperf.Where(sb.ToString).OrderBy(petivi_aipinsdistauditperfpaglist.pagvi_aipinsdistauditperf.xcamposord & " "  & petivi_aipinsdistauditperfpaglist.pagvi_aipinsdistauditperf.idirord).Skip(skip).Take(petivi_aipinsdistauditperfpaglist.pagvi_aipinsdistauditperf.npagtamano).ToList
		End If
		'
		If (respvi_aipinsdistauditperfpaglist.lista_vi_aipinsdistauditperf.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsdistauditperfxwheredinamicocount(sb)
		respvi_aipinsdistauditperfpaglist.pagvi_aipinsdistauditperf.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsdistauditperfpaglist.pagvi_aipinsdistauditperf.npagtamano)
		Else
		respvi_aipinsdistauditperfpaglist.pagvi_aipinsdistauditperf.npagcantidad = 0
		respvi_aipinsdistauditperfpaglist.pagvi_aipinsdistauditperf.npagactual = 0
		End If
	
		Return respvi_aipinsdistauditperfpaglist
	End Function

	Public Function selvi_aipinsdistauditperfxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsdistauditperf.count
	Else
	Return _db.vi_aipinsdistauditperf.Where(sb.ToString).Count
	End If
	End Function

End Class
End Namespace
