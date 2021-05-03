Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipmanrepuController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipmanrepuxid(idaipmanrepu As Decimal) As vi_aipmanrepu
            Dim vi_aipmanrepu As vi_aipmanrepu = (From p In _db.vi_aipmanrepu
                                            Where p.idaipmanrepu = idaipmanrepu
                                            Select p).SingleOrDefault
            Return vi_aipmanrepu
        End Function

	<HttpPost()> _
	Public Function selvi_aipmanrepu() As List(Of vi_aipmanrepu)
		Dim lista_vi_aipmanrepu As List(Of vi_aipmanrepu) = (From p In _db.vi_aipmanrepu
													Select p).ToList
		'
		Return lista_vi_aipmanrepu
	End Function

<HttpPost()> _
	Public Function selvi_aipmanrepuxwheredinamicopag(petivi_aipmanrepupaglist as petivi_aipmanrepupaglist) as respvi_aipmanrepupaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipmanrepupaglist.vi_aipmanrepu.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanrepupaglist.vi_aipmanrepu.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipmanrepupaglist.vi_aipmanrepu.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipmanrepupaglist.vi_aipmanrepu.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanrepupaglist.vi_aipmanrepu.ipartextdelmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ipartextdelmanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.ipartextdelmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ipartextdelmanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.ipartextdelmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanrepupaglist.vi_aipmanrepu.ipartextmedmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ipartextmedmanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.ipartextmedmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ipartextmedmanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.ipartextmedmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanrepupaglist.vi_aipmanrepu.ipartexttrasmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ipartexttrasmanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.ipartexttrasmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ipartexttrasmanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.ipartexttrasmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanrepupaglist.vi_aipmanrepu.ipartintmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ipartintmanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.ipartintmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ipartintmanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.ipartintmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanrepupaglist.vi_aipmanrepu.iposdermanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iposdermanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.iposdermanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iposdermanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.iposdermanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanrepupaglist.vi_aipmanrepu.iposizqmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iposizqmanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.iposizqmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iposizqmanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.iposizqmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanrepupaglist.vi_aipmanrepu.iposfronmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iposfronmanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.iposfronmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iposfronmanrepu=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.iposfronmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanrepupaglist.vi_aipmanrepu.xdescmanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescmanrepu='")
				sb.Append(petivi_aipmanrepupaglist.vi_aipmanrepu.xdescmanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescmanrepu='")
				sb.Append(petivi_aipmanrepupaglist.vi_aipmanrepu.xdescmanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanrepupaglist.vi_aipmanrepu.iestatmanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmanrepu='")
				sb.Append(petivi_aipmanrepupaglist.vi_aipmanrepu.iestatmanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmanrepu='")
				sb.Append(petivi_aipmanrepupaglist.vi_aipmanrepu.iestatmanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipmanrepupaglist.vi_aipmanrepu.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipmanrepupaglist.vi_aipmanrepu.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipmanrepupaglist As New respvi_aipmanrepupaglist
	respvi_aipmanrepupaglist.pagvi_aipmanrepu = petivi_aipmanrepupaglist.pagvi_aipmanrepu
	Dim skip = skip_paginacion(petivi_aipmanrepupaglist.pagvi_aipmanrepu.npagactual, petivi_aipmanrepupaglist.pagvi_aipmanrepu.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipmanrepupaglist.lista_vi_aipmanrepu = _db.vi_aipmanrepu.OrderBy(petivi_aipmanrepupaglist.pagvi_aipmanrepu.xcamposord & " "  & petivi_aipmanrepupaglist.pagvi_aipmanrepu.idirord).Skip(skip).Take(petivi_aipmanrepupaglist.pagvi_aipmanrepu.npagtamano).ToList
		Else
			respvi_aipmanrepupaglist.lista_vi_aipmanrepu = _db.vi_aipmanrepu.Where(sb.ToString).OrderBy(petivi_aipmanrepupaglist.pagvi_aipmanrepu.xcamposord & " "  & petivi_aipmanrepupaglist.pagvi_aipmanrepu.idirord).Skip(skip).Take(petivi_aipmanrepupaglist.pagvi_aipmanrepu.npagtamano).ToList
		End If
		'
		If (respvi_aipmanrepupaglist.lista_vi_aipmanrepu.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipmanrepuxwheredinamicocount(sb)
		respvi_aipmanrepupaglist.pagvi_aipmanrepu.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipmanrepupaglist.pagvi_aipmanrepu.npagtamano)
		Else
		respvi_aipmanrepupaglist.pagvi_aipmanrepu.npagcantidad = 0
		respvi_aipmanrepupaglist.pagvi_aipmanrepu.npagactual = 0
		End If
	
		Return respvi_aipmanrepupaglist
	End Function

	Public Function selvi_aipmanrepuxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipmanrepu.count
	Else
	Return _db.vi_aipmanrepu.Where(sb.ToString).Count
	End If
	End Function

End Class
End Namespace
