Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipmanvehController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipmanvehxid(idaipmanveh As Decimal) As vi_aipmanveh
            Dim vi_aipmanveh As vi_aipmanveh = (From p In _db.vi_aipmanveh
                                            Where p.idaipmanveh = idaipmanveh
                                            Select p).SingleOrDefault
            Return vi_aipmanveh
        End Function

	<HttpPost()> _
	Public Function selvi_aipmanveh() As List(Of vi_aipmanveh)
		Dim lista_vi_aipmanveh As List(Of vi_aipmanveh) = (From p In _db.vi_aipmanveh
													Select p).ToList
		'
		Return lista_vi_aipmanveh
	End Function

<HttpPost()> _
	Public Function selvi_aipmanvehxwheredinamicopag(petivi_aipmanvehpaglist as petivi_aipmanvehpaglist) as respvi_aipmanvehpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipmanvehpaglist.vi_aipmanveh.idaipmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipmanvehpaglist.vi_aipmanveh.idaipmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipmanvehpaglist.vi_aipmanveh.idaipmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.idaipmanvehmar <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipmanvehpaglist.vi_aipmanveh.idaipmanvehmar))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipmanvehpaglist.vi_aipmanveh.idaipmanvehmar))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.xnommanvehmar <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmar='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xnommanvehmar)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmar='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xnommanvehmar)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.idaipmanvehmod <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipmanvehpaglist.vi_aipmanveh.idaipmanvehmod))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipmanvehpaglist.vi_aipmanveh.idaipmanvehmod))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.xnommanvehmod <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmod='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xnommanvehmod)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmod='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xnommanvehmod)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.idaipmanvehver <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipmanvehpaglist.vi_aipmanveh.idaipmanvehver))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipmanvehpaglist.vi_aipmanveh.idaipmanvehver))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.xnommanvehver <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehver='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xnommanvehver)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehver='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xnommanvehver)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.itipotransmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipotransmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.itipotransmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipotransmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.itipotransmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.itipomanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipomanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.itipomanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipomanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.itipomanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.iclasemanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iclasemanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.iclasemanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iclasemanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.iclasemanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.icolormanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.icolormanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.icolormanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.icolormanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.icolormanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.xplacamanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacamanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xplacamanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacamanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xplacamanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.xsercarrmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsercarrmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xsercarrmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsercarrmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xsercarrmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.xsermotmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsermotmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xsermotmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsermotmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xsermotmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.itraccmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itraccmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.itraccmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itraccmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.itraccmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.iimpmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iimpmanveh=")
				sb.Append(valor_entero(petivi_aipmanvehpaglist.vi_aipmanveh.iimpmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iimpmanveh=")
				sb.Append(valor_entero(petivi_aipmanvehpaglist.vi_aipmanveh.iimpmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.ncilinmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncilinmanveh=")
				sb.Append(valor_entero(petivi_aipmanvehpaglist.vi_aipmanveh.ncilinmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncilinmanveh=")
				sb.Append(valor_entero(petivi_aipmanvehpaglist.vi_aipmanveh.ncilinmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.xcargmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcargmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xcargmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcargmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xcargmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.xcapmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcapmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xcapmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcapmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xcapmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.xdescmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xdescmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.xdescmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.iestatmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.iestatmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmanveh='")
				sb.Append(petivi_aipmanvehpaglist.vi_aipmanveh.iestatmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanvehpaglist.vi_aipmanveh.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipmanvehpaglist.vi_aipmanveh.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipmanvehpaglist.vi_aipmanveh.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipmanvehpaglist As New respvi_aipmanvehpaglist
	respvi_aipmanvehpaglist.pagvi_aipmanveh = petivi_aipmanvehpaglist.pagvi_aipmanveh
	Dim skip = skip_paginacion(petivi_aipmanvehpaglist.pagvi_aipmanveh.npagactual, petivi_aipmanvehpaglist.pagvi_aipmanveh.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipmanvehpaglist.lista_vi_aipmanveh = _db.vi_aipmanveh.OrderBy(petivi_aipmanvehpaglist.pagvi_aipmanveh.xcamposord & " "  & petivi_aipmanvehpaglist.pagvi_aipmanveh.idirord).Skip(skip).Take(petivi_aipmanvehpaglist.pagvi_aipmanveh.npagtamano).ToList
		Else
			respvi_aipmanvehpaglist.lista_vi_aipmanveh = _db.vi_aipmanveh.Where(sb.ToString).OrderBy(petivi_aipmanvehpaglist.pagvi_aipmanveh.xcamposord & " "  & petivi_aipmanvehpaglist.pagvi_aipmanveh.idirord).Skip(skip).Take(petivi_aipmanvehpaglist.pagvi_aipmanveh.npagtamano).ToList
		End If
		'
		If (respvi_aipmanvehpaglist.lista_vi_aipmanveh.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipmanvehxwheredinamicocount(sb)
		respvi_aipmanvehpaglist.pagvi_aipmanveh.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipmanvehpaglist.pagvi_aipmanveh.npagtamano)
		Else
		respvi_aipmanvehpaglist.pagvi_aipmanveh.npagcantidad = 0
		respvi_aipmanvehpaglist.pagvi_aipmanveh.npagactual = 0
		End If
	
		Return respvi_aipmanvehpaglist
	End Function

	Public Function selvi_aipmanvehxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipmanveh.count
	Else
	Return _db.vi_aipmanveh.Where(sb.ToString).Count
	End If
	End Function

End Class
End Namespace
