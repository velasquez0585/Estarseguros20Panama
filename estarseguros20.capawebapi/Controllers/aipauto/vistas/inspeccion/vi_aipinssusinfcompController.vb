Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinssusinfcompController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinssusinfcompxid(idaipinssusinfcomp As Decimal) As vi_aipinssusinfcomp
            Dim vi_aipinssusinfcomp As vi_aipinssusinfcomp = (From p In _db.vi_aipinssusinfcomp
                                            Where p.idaipinssusinfcomp = idaipinssusinfcomp
                                            Select p).SingleOrDefault
            Return vi_aipinssusinfcomp
        End Function

	<HttpPost()> _
	Public Function selvi_aipinssusinfcomp() As List(Of vi_aipinssusinfcomp)
		Dim lista_vi_aipinssusinfcomp As List(Of vi_aipinssusinfcomp) = (From p In _db.vi_aipinssusinfcomp
													Select p).ToList
		'
		Return lista_vi_aipinssusinfcomp
	End Function

<HttpPost()> _
	Public Function selvi_aipinssusinfcompxwheredinamicopag(petivi_aipinssusinfcomppaglist as petivi_aipinssusinfcomppaglist) as respvi_aipinssusinfcomppaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.idaipinssusinfcomp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssusinfcomp=")
				sb.Append(valor_entero(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.idaipinssusinfcomp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssusinfcomp=")
				sb.Append(valor_entero(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.idaipinssusinfcomp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.idaipinssus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssus=")
				sb.Append(valor_entero(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.idaipinssus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssus=")
				sb.Append(valor_entero(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.idaipinssus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.idaipmaninfcomp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmaninfcomp=")
				sb.Append(valor_entero(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.idaipmaninfcomp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmaninfcomp=")
				sb.Append(valor_entero(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.idaipmaninfcomp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.xnommaninfcomp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommaninfcomp='")
				sb.Append(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.xnommaninfcomp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommaninfcomp='")
				sb.Append(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.xnommaninfcomp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.nordenmaninfcomp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nordenmaninfcomp=")
				sb.Append(valor_entero(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.nordenmaninfcomp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nordenmaninfcomp=")
				sb.Append(valor_entero(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.nordenmaninfcomp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.iexisinssusinfcomp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iexisinssusinfcomp=")
				sb.Append(valor_entero(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.iexisinssusinfcomp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iexisinssusinfcomp=")
				sb.Append(valor_entero(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.iexisinssusinfcomp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssusinfcomppaglist.vi_aipinssusinfcomp.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinssusinfcomppaglist As New respvi_aipinssusinfcomppaglist
	respvi_aipinssusinfcomppaglist.pagvi_aipinssusinfcomp = petivi_aipinssusinfcomppaglist.pagvi_aipinssusinfcomp
	Dim skip = skip_paginacion(petivi_aipinssusinfcomppaglist.pagvi_aipinssusinfcomp.npagactual, petivi_aipinssusinfcomppaglist.pagvi_aipinssusinfcomp.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinssusinfcomppaglist.lista_vi_aipinssusinfcomp = _db.vi_aipinssusinfcomp.OrderBy(petivi_aipinssusinfcomppaglist.pagvi_aipinssusinfcomp.xcamposord & " "  & petivi_aipinssusinfcomppaglist.pagvi_aipinssusinfcomp.idirord).Skip(skip).Take(petivi_aipinssusinfcomppaglist.pagvi_aipinssusinfcomp.npagtamano).ToList
		Else
			respvi_aipinssusinfcomppaglist.lista_vi_aipinssusinfcomp = _db.vi_aipinssusinfcomp.Where(sb.ToString).OrderBy(petivi_aipinssusinfcomppaglist.pagvi_aipinssusinfcomp.xcamposord & " "  & petivi_aipinssusinfcomppaglist.pagvi_aipinssusinfcomp.idirord).Skip(skip).Take(petivi_aipinssusinfcomppaglist.pagvi_aipinssusinfcomp.npagtamano).ToList
		End If
		'
		If (respvi_aipinssusinfcomppaglist.lista_vi_aipinssusinfcomp.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinssusinfcompxwheredinamicocount(sb)
		respvi_aipinssusinfcomppaglist.pagvi_aipinssusinfcomp.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinssusinfcomppaglist.pagvi_aipinssusinfcomp.npagtamano)
		Else
		respvi_aipinssusinfcomppaglist.pagvi_aipinssusinfcomp.npagcantidad = 0
		respvi_aipinssusinfcomppaglist.pagvi_aipinssusinfcomp.npagactual = 0
		End If
	
		Return respvi_aipinssusinfcomppaglist
	End Function

	Public Function selvi_aipinssusinfcompxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinssusinfcomp.count
	Else
	Return _db.vi_aipinssusinfcomp.Where(sb.ToString).Count
	End If
	End Function



        'Personalizados

        <HttpPost()> _
        Public Function selvi_aipinssusinfcompxidsus(idaipinssus As Decimal) As List(Of vi_aipinssusinfcomp)
            Dim lista_vi_aipinssusinfcomp As List(Of vi_aipinssusinfcomp) = (From p In _db.vi_aipinssusinfcomp
                                                                             Where p.idaipinssus = idaipinssus
                                                        Select p).ToList
            '
            Return lista_vi_aipinssusinfcomp
        End Function

End Class
End Namespace
