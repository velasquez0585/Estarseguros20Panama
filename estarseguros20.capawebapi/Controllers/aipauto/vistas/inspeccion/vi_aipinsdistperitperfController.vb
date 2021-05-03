Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsdistperitperfController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsdistperitperfxid(idsegmanusuperit As Decimal) As vi_aipinsdistperitperf
            Dim vi_aipinsdistperitperf As vi_aipinsdistperitperf = (From p In _db.vi_aipinsdistperitperf
                                            Where p.idsegmanusuperit = idsegmanusuperit
                                            Select p).SingleOrDefault
            Return vi_aipinsdistperitperf
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsdistperitperf() As List(Of vi_aipinsdistperitperf)
		Dim lista_vi_aipinsdistperitperf As List(Of vi_aipinsdistperitperf) = (From p In _db.vi_aipinsdistperitperf
													Select p).ToList
		'
		Return lista_vi_aipinsdistperitperf
	End Function

<HttpPost()> _
	Public Function selvi_aipinsdistperitperfxwheredinamicopag(petivi_aipinsdistperitperfpaglist as petivi_aipinsdistperitperfpaglist) as respvi_aipinsdistperitperfpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.idsegmanusuperit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusuperit=")
				sb.Append(valor_entero(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.idsegmanusuperit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusuperit=")
				sb.Append(valor_entero(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.idsegmanusuperit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.xnombrecompletoperit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompletoperit='")
				sb.Append(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.xnombrecompletoperit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompletoperit='")
				sb.Append(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.xnombrecompletoperit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.idsegmanorgperit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanorgperit=")
				sb.Append(valor_entero(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.idsegmanorgperit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanorgperit=")
				sb.Append(valor_entero(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.idsegmanorgperit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.xnombrecomercialperit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecomercialperit='")
				sb.Append(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.xnombrecomercialperit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecomercialperit='")
				sb.Append(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.xnombrecomercialperit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.idsegmanapp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanapp=")
				sb.Append(valor_entero(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.idsegmanapp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanapp=")
				sb.Append(valor_entero(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.idsegmanapp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.idsegmanperf <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanperf=")
				sb.Append(valor_entero(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.idsegmanperf))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanperf=")
				sb.Append(valor_entero(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.idsegmanperf))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.xnombreperf <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombreperf='")
				sb.Append(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.xnombreperf)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombreperf='")
				sb.Append(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.xnombreperf)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.ibloqueado <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ibloqueado=")
				sb.Append(valor_entero(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.ibloqueado))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ibloqueado=")
				sb.Append(valor_entero(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.ibloqueado))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.ncantinsperit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinsperit=")
				sb.Append(valor_entero(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.ncantinsperit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinsperit=")
				sb.Append(valor_entero(petivi_aipinsdistperitperfpaglist.vi_aipinsdistperitperf.ncantinsperit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsdistperitperfpaglist As New respvi_aipinsdistperitperfpaglist
	respvi_aipinsdistperitperfpaglist.pagvi_aipinsdistperitperf = petivi_aipinsdistperitperfpaglist.pagvi_aipinsdistperitperf
	Dim skip = skip_paginacion(petivi_aipinsdistperitperfpaglist.pagvi_aipinsdistperitperf.npagactual, petivi_aipinsdistperitperfpaglist.pagvi_aipinsdistperitperf.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsdistperitperfpaglist.lista_vi_aipinsdistperitperf = _db.vi_aipinsdistperitperf.OrderBy(petivi_aipinsdistperitperfpaglist.pagvi_aipinsdistperitperf.xcamposord & " "  & petivi_aipinsdistperitperfpaglist.pagvi_aipinsdistperitperf.idirord).Skip(skip).Take(petivi_aipinsdistperitperfpaglist.pagvi_aipinsdistperitperf.npagtamano).ToList
		Else
			respvi_aipinsdistperitperfpaglist.lista_vi_aipinsdistperitperf = _db.vi_aipinsdistperitperf.Where(sb.ToString).OrderBy(petivi_aipinsdistperitperfpaglist.pagvi_aipinsdistperitperf.xcamposord & " "  & petivi_aipinsdistperitperfpaglist.pagvi_aipinsdistperitperf.idirord).Skip(skip).Take(petivi_aipinsdistperitperfpaglist.pagvi_aipinsdistperitperf.npagtamano).ToList
		End If
		'
		If (respvi_aipinsdistperitperfpaglist.lista_vi_aipinsdistperitperf.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsdistperitperfxwheredinamicocount(sb)
		respvi_aipinsdistperitperfpaglist.pagvi_aipinsdistperitperf.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsdistperitperfpaglist.pagvi_aipinsdistperitperf.npagtamano)
		Else
		respvi_aipinsdistperitperfpaglist.pagvi_aipinsdistperitperf.npagcantidad = 0
		respvi_aipinsdistperitperfpaglist.pagvi_aipinsdistperitperf.npagactual = 0
		End If
	
		Return respvi_aipinsdistperitperfpaglist
	End Function

	Public Function selvi_aipinsdistperitperfxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsdistperitperf.count
	Else
	Return _db.vi_aipinsdistperitperf.Where(sb.ToString).Count
	End If
	End Function

End Class
End Namespace
