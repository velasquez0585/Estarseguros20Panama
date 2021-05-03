Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipmanvehverController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipmanvehverxid(idaipmanvehver As Decimal) As vi_aipmanvehver
            Dim vi_aipmanvehver As vi_aipmanvehver = (From p In _db.vi_aipmanvehver
                                            Where p.idaipmanvehver = idaipmanvehver
                                            Select p).SingleOrDefault
            Return vi_aipmanvehver
        End Function

	<HttpPost()> _
	Public Function selvi_aipmanvehver() As List(Of vi_aipmanvehver)
		Dim lista_vi_aipmanvehver As List(Of vi_aipmanvehver) = (From p In _db.vi_aipmanvehver
													Select p).ToList
		'
		Return lista_vi_aipmanvehver
	End Function

<HttpPost()> _
	Public Function selvi_aipmanvehverxwheredinamicopag(petivi_aipmanvehverpaglist as petivi_aipmanvehverpaglist) as respvi_aipmanvehverpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipmanvehverpaglist.vi_aipmanvehver.idaipmanvehver <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipmanvehverpaglist.vi_aipmanvehver.idaipmanvehver))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipmanvehverpaglist.vi_aipmanvehver.idaipmanvehver))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehverpaglist.vi_aipmanvehver.idaipmanvehmar <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipmanvehverpaglist.vi_aipmanvehver.idaipmanvehmar))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipmanvehverpaglist.vi_aipmanvehver.idaipmanvehmar))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehverpaglist.vi_aipmanvehver.xnommanvehmar <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmar='")
				sb.Append(petivi_aipmanvehverpaglist.vi_aipmanvehver.xnommanvehmar)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmar='")
				sb.Append(petivi_aipmanvehverpaglist.vi_aipmanvehver.xnommanvehmar)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehverpaglist.vi_aipmanvehver.idaipmanvehmod <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipmanvehverpaglist.vi_aipmanvehver.idaipmanvehmod))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipmanvehverpaglist.vi_aipmanvehver.idaipmanvehmod))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehverpaglist.vi_aipmanvehver.xnommanvehmod <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmod='")
				sb.Append(petivi_aipmanvehverpaglist.vi_aipmanvehver.xnommanvehmod)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmod='")
				sb.Append(petivi_aipmanvehverpaglist.vi_aipmanvehver.xnommanvehmod)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehverpaglist.vi_aipmanvehver.xnommanvehver <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehver='")
				sb.Append(petivi_aipmanvehverpaglist.vi_aipmanvehver.xnommanvehver)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehver='")
				sb.Append(petivi_aipmanvehverpaglist.vi_aipmanvehver.xnommanvehver)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehverpaglist.vi_aipmanvehver.naniomanvehver <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.naniomanvehver=")
				sb.Append(valor_entero(petivi_aipmanvehverpaglist.vi_aipmanvehver.naniomanvehver))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.naniomanvehver=")
				sb.Append(valor_entero(petivi_aipmanvehverpaglist.vi_aipmanvehver.naniomanvehver))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehverpaglist.vi_aipmanvehver.xdescmanvehver <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescmanvehver='")
				sb.Append(petivi_aipmanvehverpaglist.vi_aipmanvehver.xdescmanvehver)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescmanvehver='")
				sb.Append(petivi_aipmanvehverpaglist.vi_aipmanvehver.xdescmanvehver)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehverpaglist.vi_aipmanvehver.iestatmanvehmar <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmanvehmar='")
				sb.Append(petivi_aipmanvehverpaglist.vi_aipmanvehver.iestatmanvehmar)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmanvehmar='")
				sb.Append(petivi_aipmanvehverpaglist.vi_aipmanvehver.iestatmanvehmar)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehverpaglist.vi_aipmanvehver.iestatmanvehmod <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmanvehmod='")
				sb.Append(petivi_aipmanvehverpaglist.vi_aipmanvehver.iestatmanvehmod)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmanvehmod='")
				sb.Append(petivi_aipmanvehverpaglist.vi_aipmanvehver.iestatmanvehmod)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehverpaglist.vi_aipmanvehver.iestatmanvehver <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmanvehver='")
				sb.Append(petivi_aipmanvehverpaglist.vi_aipmanvehver.iestatmanvehver)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmanvehver='")
				sb.Append(petivi_aipmanvehverpaglist.vi_aipmanvehver.iestatmanvehver)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipmanvehverpaglist As New respvi_aipmanvehverpaglist
	respvi_aipmanvehverpaglist.pagvi_aipmanvehver = petivi_aipmanvehverpaglist.pagvi_aipmanvehver
	Dim skip = skip_paginacion(petivi_aipmanvehverpaglist.pagvi_aipmanvehver.npagactual, petivi_aipmanvehverpaglist.pagvi_aipmanvehver.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipmanvehverpaglist.lista_vi_aipmanvehver = _db.vi_aipmanvehver.OrderBy(petivi_aipmanvehverpaglist.pagvi_aipmanvehver.xcamposord & " "  & petivi_aipmanvehverpaglist.pagvi_aipmanvehver.idirord).Skip(skip).Take(petivi_aipmanvehverpaglist.pagvi_aipmanvehver.npagtamano).ToList
		Else
			respvi_aipmanvehverpaglist.lista_vi_aipmanvehver = _db.vi_aipmanvehver.Where(sb.ToString).OrderBy(petivi_aipmanvehverpaglist.pagvi_aipmanvehver.xcamposord & " "  & petivi_aipmanvehverpaglist.pagvi_aipmanvehver.idirord).Skip(skip).Take(petivi_aipmanvehverpaglist.pagvi_aipmanvehver.npagtamano).ToList
		End If
		'
		If (respvi_aipmanvehverpaglist.lista_vi_aipmanvehver.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipmanvehverxwheredinamicocount(sb)
		respvi_aipmanvehverpaglist.pagvi_aipmanvehver.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipmanvehverpaglist.pagvi_aipmanvehver.npagtamano)
		Else
		respvi_aipmanvehverpaglist.pagvi_aipmanvehver.npagcantidad = 0
		respvi_aipmanvehverpaglist.pagvi_aipmanvehver.npagactual = 0
		End If
	
		Return respvi_aipmanvehverpaglist
	End Function

	Public Function selvi_aipmanvehverxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipmanvehver.count
	Else
	Return _db.vi_aipmanvehver.Where(sb.ToString).Count
	End If
	End Function

End Class
End Namespace
