Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsdistauditController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsdistauditxid(idsegmanusuaudit As Decimal) As vi_aipinsdistaudit
            Dim vi_aipinsdistaudit As vi_aipinsdistaudit = (From p In _db.vi_aipinsdistaudit
                                            Where p.idsegmanusuaudit = idsegmanusuaudit
                                            Select p).SingleOrDefault
            Return vi_aipinsdistaudit
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsdistaudit() As List(Of vi_aipinsdistaudit)
		Dim lista_vi_aipinsdistaudit As List(Of vi_aipinsdistaudit) = (From p In _db.vi_aipinsdistaudit
													Select p).ToList
		'
		Return lista_vi_aipinsdistaudit
	End Function

<HttpPost()> _
	Public Function selvi_aipinsdistauditxwheredinamicopag(petivi_aipinsdistauditpaglist as petivi_aipinsdistauditpaglist) as respvi_aipinsdistauditpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsdistauditpaglist.vi_aipinsdistaudit.idsegmanusuaudit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusuaudit=")
				sb.Append(valor_entero(petivi_aipinsdistauditpaglist.vi_aipinsdistaudit.idsegmanusuaudit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusuaudit=")
				sb.Append(valor_entero(petivi_aipinsdistauditpaglist.vi_aipinsdistaudit.idsegmanusuaudit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditpaglist.vi_aipinsdistaudit.xnombrecompletoaudit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompletoaudit='")
				sb.Append(petivi_aipinsdistauditpaglist.vi_aipinsdistaudit.xnombrecompletoaudit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompletoaudit='")
				sb.Append(petivi_aipinsdistauditpaglist.vi_aipinsdistaudit.xnombrecompletoaudit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditpaglist.vi_aipinsdistaudit.idsegmanorgaudit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanorgaudit=")
				sb.Append(valor_entero(petivi_aipinsdistauditpaglist.vi_aipinsdistaudit.idsegmanorgaudit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanorgaudit=")
				sb.Append(valor_entero(petivi_aipinsdistauditpaglist.vi_aipinsdistaudit.idsegmanorgaudit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditpaglist.vi_aipinsdistaudit.xnombrecomercialaudit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecomercialaudit='")
				sb.Append(petivi_aipinsdistauditpaglist.vi_aipinsdistaudit.xnombrecomercialaudit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecomercialaudit='")
				sb.Append(petivi_aipinsdistauditpaglist.vi_aipinsdistaudit.xnombrecomercialaudit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditpaglist.vi_aipinsdistaudit.ncantinsperit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinsperit=")
				sb.Append(valor_entero(petivi_aipinsdistauditpaglist.vi_aipinsdistaudit.ncantinsperit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinsperit=")
				sb.Append(valor_entero(petivi_aipinsdistauditpaglist.vi_aipinsdistaudit.ncantinsperit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsdistauditpaglist As New respvi_aipinsdistauditpaglist
	respvi_aipinsdistauditpaglist.pagvi_aipinsdistaudit = petivi_aipinsdistauditpaglist.pagvi_aipinsdistaudit
	Dim skip = skip_paginacion(petivi_aipinsdistauditpaglist.pagvi_aipinsdistaudit.npagactual, petivi_aipinsdistauditpaglist.pagvi_aipinsdistaudit.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsdistauditpaglist.lista_vi_aipinsdistaudit = _db.vi_aipinsdistaudit.OrderBy(petivi_aipinsdistauditpaglist.pagvi_aipinsdistaudit.xcamposord & " "  & petivi_aipinsdistauditpaglist.pagvi_aipinsdistaudit.idirord).Skip(skip).Take(petivi_aipinsdistauditpaglist.pagvi_aipinsdistaudit.npagtamano).ToList
		Else
			respvi_aipinsdistauditpaglist.lista_vi_aipinsdistaudit = _db.vi_aipinsdistaudit.Where(sb.ToString).OrderBy(petivi_aipinsdistauditpaglist.pagvi_aipinsdistaudit.xcamposord & " "  & petivi_aipinsdistauditpaglist.pagvi_aipinsdistaudit.idirord).Skip(skip).Take(petivi_aipinsdistauditpaglist.pagvi_aipinsdistaudit.npagtamano).ToList
		End If
		'
		If (respvi_aipinsdistauditpaglist.lista_vi_aipinsdistaudit.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsdistauditxwheredinamicocount(sb)
		respvi_aipinsdistauditpaglist.pagvi_aipinsdistaudit.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsdistauditpaglist.pagvi_aipinsdistaudit.npagtamano)
		Else
		respvi_aipinsdistauditpaglist.pagvi_aipinsdistaudit.npagcantidad = 0
		respvi_aipinsdistauditpaglist.pagvi_aipinsdistaudit.npagactual = 0
		End If
	
		Return respvi_aipinsdistauditpaglist
	End Function

	Public Function selvi_aipinsdistauditxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsdistaudit.count
	Else
	Return _db.vi_aipinsdistaudit.Where(sb.ToString).Count
	End If
	End Function

End Class
End Namespace
