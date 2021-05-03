Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipmanvehmodController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selvi_aipmanvehmodxid(idvi_aipmanvehmod As Decimal) As vi_aipmanvehmod
            Dim vi_aipmanvehmod As vi_aipmanvehmod = (From p In _db.vi_aipmanvehmod
                                            Where p.idaipmanvehmod = idvi_aipmanvehmod
                                            Select p).SingleOrDefault
		Return vi_aipmanvehmod
	End Function

	<HttpPost()> _
	Public Function selvi_aipmanvehmod() As List(Of vi_aipmanvehmod)
		Dim lista_vi_aipmanvehmod As List(Of vi_aipmanvehmod) = (From p In _db.vi_aipmanvehmod
													Select p).ToList
		'
		Return lista_vi_aipmanvehmod
	End Function

<HttpPost()> _
	Public Function selvi_aipmanvehmodxwheredinamicopag(petivi_aipmanvehmodpaglist as petivi_aipmanvehmodpaglist) as respvi_aipmanvehmodpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipmanvehmodpaglist.vi_aipmanvehmod.idaipmanvehmod <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipmanvehmodpaglist.vi_aipmanvehmod.idaipmanvehmod))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipmanvehmodpaglist.vi_aipmanvehmod.idaipmanvehmod))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehmodpaglist.vi_aipmanvehmod.idaipmanvehmar <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipmanvehmodpaglist.vi_aipmanvehmod.idaipmanvehmar))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipmanvehmodpaglist.vi_aipmanvehmod.idaipmanvehmar))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehmodpaglist.vi_aipmanvehmod.xnommanvehmar <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmar='")
				sb.Append(petivi_aipmanvehmodpaglist.vi_aipmanvehmod.xnommanvehmar)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmar='")
				sb.Append(petivi_aipmanvehmodpaglist.vi_aipmanvehmod.xnommanvehmar)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehmodpaglist.vi_aipmanvehmod.xnommanvehmod <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmod='")
				sb.Append(petivi_aipmanvehmodpaglist.vi_aipmanvehmod.xnommanvehmod)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmod='")
				sb.Append(petivi_aipmanvehmodpaglist.vi_aipmanvehmod.xnommanvehmod)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehmodpaglist.vi_aipmanvehmod.xdescmanvehmod <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescmanvehmod='")
				sb.Append(petivi_aipmanvehmodpaglist.vi_aipmanvehmod.xdescmanvehmod)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescmanvehmod='")
				sb.Append(petivi_aipmanvehmodpaglist.vi_aipmanvehmod.xdescmanvehmod)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehmodpaglist.vi_aipmanvehmod.iestatmanvehmod <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmanvehmod='")
				sb.Append(petivi_aipmanvehmodpaglist.vi_aipmanvehmod.iestatmanvehmod)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmanvehmod='")
				sb.Append(petivi_aipmanvehmodpaglist.vi_aipmanvehmod.iestatmanvehmod)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehmodpaglist.vi_aipmanvehmod.iestatmanvehmar <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmanvehmar='")
				sb.Append(petivi_aipmanvehmodpaglist.vi_aipmanvehmod.iestatmanvehmar)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmanvehmar='")
				sb.Append(petivi_aipmanvehmodpaglist.vi_aipmanvehmod.iestatmanvehmar)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipmanvehmodpaglist As New respvi_aipmanvehmodpaglist
	respvi_aipmanvehmodpaglist.pagvi_aipmanvehmod = petivi_aipmanvehmodpaglist.pagvi_aipmanvehmod
	Dim skip = skip_paginacion(petivi_aipmanvehmodpaglist.pagvi_aipmanvehmod.npagactual, petivi_aipmanvehmodpaglist.pagvi_aipmanvehmod.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipmanvehmodpaglist.lista_vi_aipmanvehmod = _db.vi_aipmanvehmod.OrderBy(petivi_aipmanvehmodpaglist.pagvi_aipmanvehmod.xcamposord & " "  & petivi_aipmanvehmodpaglist.pagvi_aipmanvehmod.idirord).Skip(skip).Take(petivi_aipmanvehmodpaglist.pagvi_aipmanvehmod.npagtamano).ToList
		Else
			respvi_aipmanvehmodpaglist.lista_vi_aipmanvehmod = _db.vi_aipmanvehmod.Where(sb.ToString).OrderBy(petivi_aipmanvehmodpaglist.pagvi_aipmanvehmod.xcamposord & " "  & petivi_aipmanvehmodpaglist.pagvi_aipmanvehmod.idirord).Skip(skip).Take(petivi_aipmanvehmodpaglist.pagvi_aipmanvehmod.npagtamano).ToList
		End If
		'
		If (respvi_aipmanvehmodpaglist.lista_vi_aipmanvehmod.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipmanvehmodxwheredinamicocount(sb)
		respvi_aipmanvehmodpaglist.pagvi_aipmanvehmod.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipmanvehmodpaglist.pagvi_aipmanvehmod.npagtamano)
		Else
		respvi_aipmanvehmodpaglist.pagvi_aipmanvehmod.npagcantidad = 0
		respvi_aipmanvehmodpaglist.pagvi_aipmanvehmod.npagactual = 0
		End If
	
		Return respvi_aipmanvehmodpaglist
	End Function

	Public Function selvi_aipmanvehmodxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipmanvehmod.count
	Else
	Return _db.vi_aipmanvehmod.Where(sb.ToString).Count
	End If
	End Function

End Class
End Namespace
