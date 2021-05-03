Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsdistperitController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsdistperitxid(idsegmanusuperit As Decimal) As vi_aipinsdistperit
            Dim vi_aipinsdistperit As vi_aipinsdistperit = (From p In _db.vi_aipinsdistperit
                                            Where p.idsegmanusuperit = idsegmanusuperit
                                            Select p).SingleOrDefault
            Return vi_aipinsdistperit
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsdistperit() As List(Of vi_aipinsdistperit)
		Dim lista_vi_aipinsdistperit As List(Of vi_aipinsdistperit) = (From p In _db.vi_aipinsdistperit
													Select p).ToList
		'
		Return lista_vi_aipinsdistperit
	End Function

<HttpPost()> _
	Public Function selvi_aipinsdistperitxwheredinamicopag(petivi_aipinsdistperitpaglist as petivi_aipinsdistperitpaglist) as respvi_aipinsdistperitpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsdistperitpaglist.vi_aipinsdistperit.idsegmanusuperit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusuperit=")
				sb.Append(valor_entero(petivi_aipinsdistperitpaglist.vi_aipinsdistperit.idsegmanusuperit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusuperit=")
				sb.Append(valor_entero(petivi_aipinsdistperitpaglist.vi_aipinsdistperit.idsegmanusuperit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitpaglist.vi_aipinsdistperit.xnombrecompletoperit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompletoperit='")
				sb.Append(petivi_aipinsdistperitpaglist.vi_aipinsdistperit.xnombrecompletoperit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompletoperit='")
				sb.Append(petivi_aipinsdistperitpaglist.vi_aipinsdistperit.xnombrecompletoperit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitpaglist.vi_aipinsdistperit.idsegmanorgperit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanorgperit=")
				sb.Append(valor_entero(petivi_aipinsdistperitpaglist.vi_aipinsdistperit.idsegmanorgperit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanorgperit=")
				sb.Append(valor_entero(petivi_aipinsdistperitpaglist.vi_aipinsdistperit.idsegmanorgperit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitpaglist.vi_aipinsdistperit.xnombrecomercialperit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecomercialperit='")
				sb.Append(petivi_aipinsdistperitpaglist.vi_aipinsdistperit.xnombrecomercialperit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecomercialperit='")
				sb.Append(petivi_aipinsdistperitpaglist.vi_aipinsdistperit.xnombrecomercialperit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitpaglist.vi_aipinsdistperit.ncantinsperit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinsperit=")
				sb.Append(valor_entero(petivi_aipinsdistperitpaglist.vi_aipinsdistperit.ncantinsperit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinsperit=")
				sb.Append(valor_entero(petivi_aipinsdistperitpaglist.vi_aipinsdistperit.ncantinsperit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsdistperitpaglist As New respvi_aipinsdistperitpaglist
	respvi_aipinsdistperitpaglist.pagvi_aipinsdistperit = petivi_aipinsdistperitpaglist.pagvi_aipinsdistperit
	Dim skip = skip_paginacion(petivi_aipinsdistperitpaglist.pagvi_aipinsdistperit.npagactual, petivi_aipinsdistperitpaglist.pagvi_aipinsdistperit.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsdistperitpaglist.lista_vi_aipinsdistperit = _db.vi_aipinsdistperit.OrderBy(petivi_aipinsdistperitpaglist.pagvi_aipinsdistperit.xcamposord & " "  & petivi_aipinsdistperitpaglist.pagvi_aipinsdistperit.idirord).Skip(skip).Take(petivi_aipinsdistperitpaglist.pagvi_aipinsdistperit.npagtamano).ToList
		Else
			respvi_aipinsdistperitpaglist.lista_vi_aipinsdistperit = _db.vi_aipinsdistperit.Where(sb.ToString).OrderBy(petivi_aipinsdistperitpaglist.pagvi_aipinsdistperit.xcamposord & " "  & petivi_aipinsdistperitpaglist.pagvi_aipinsdistperit.idirord).Skip(skip).Take(petivi_aipinsdistperitpaglist.pagvi_aipinsdistperit.npagtamano).ToList
		End If
		'
		If (respvi_aipinsdistperitpaglist.lista_vi_aipinsdistperit.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsdistperitxwheredinamicocount(sb)
		respvi_aipinsdistperitpaglist.pagvi_aipinsdistperit.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsdistperitpaglist.pagvi_aipinsdistperit.npagtamano)
		Else
		respvi_aipinsdistperitpaglist.pagvi_aipinsdistperit.npagcantidad = 0
		respvi_aipinsdistperitpaglist.pagvi_aipinsdistperit.npagactual = 0
		End If
	
		Return respvi_aipinsdistperitpaglist
	End Function

	Public Function selvi_aipinsdistperitxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsdistperit.count
	Else
	Return _db.vi_aipinsdistperit.Where(sb.ToString).Count
	End If
	End Function

End Class
End Namespace
