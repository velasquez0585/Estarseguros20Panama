Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsperitagrupController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsperitagrupxid(idsegmanusuperit As Decimal) As vi_aipinsperitagrup
            Dim vi_aipinsperitagrup As vi_aipinsperitagrup = (From p In _db.vi_aipinsperitagrup
                                            Where p.idsegmanusuperit = idsegmanusuperit
                                            Select p).SingleOrDefault
            Return vi_aipinsperitagrup
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsperitagrup() As List(Of vi_aipinsperitagrup)
		Dim lista_vi_aipinsperitagrup As List(Of vi_aipinsperitagrup) = (From p In _db.vi_aipinsperitagrup
													Select p).ToList
		'
		Return lista_vi_aipinsperitagrup
	End Function

<HttpPost()> _
	Public Function selvi_aipinsperitagrupxwheredinamicopag(petivi_aipinsperitagruppaglist as petivi_aipinsperitagruppaglist) as respvi_aipinsperitagruppaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsperitagruppaglist.vi_aipinsperitagrup.idsegmanusuperit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusuperit=")
				sb.Append(valor_entero(petivi_aipinsperitagruppaglist.vi_aipinsperitagrup.idsegmanusuperit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusuperit=")
				sb.Append(valor_entero(petivi_aipinsperitagruppaglist.vi_aipinsperitagrup.idsegmanusuperit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsperitagruppaglist.vi_aipinsperitagrup.xnombrecompletoperit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompletoperit='")
				sb.Append(petivi_aipinsperitagruppaglist.vi_aipinsperitagrup.xnombrecompletoperit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompletoperit='")
				sb.Append(petivi_aipinsperitagruppaglist.vi_aipinsperitagrup.xnombrecompletoperit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
            If petivi_aipinsperitagruppaglist.vi_aipinsperitagrup.idsegmanorgperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanorgperit=")
                    sb.Append(valor_entero(petivi_aipinsperitagruppaglist.vi_aipinsperitagrup.idsegmanorgperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanorgperit=")
                        sb.Append(valor_entero(petivi_aipinsperitagruppaglist.vi_aipinsperitagrup.idsegmanorgperit))
                        sb.Append("")
                    End If
                End If
            End If
	 '
		If petivi_aipinsperitagruppaglist.vi_aipinsperitagrup.xnombrecomercialperit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecomercialperit='")
				sb.Append(petivi_aipinsperitagruppaglist.vi_aipinsperitagrup.xnombrecomercialperit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecomercialperit='")
				sb.Append(petivi_aipinsperitagruppaglist.vi_aipinsperitagrup.xnombrecomercialperit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsperitagruppaglist.vi_aipinsperitagrup.ncantreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantreg=")
				sb.Append(valor_entero(petivi_aipinsperitagruppaglist.vi_aipinsperitagrup.ncantreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantreg=")
				sb.Append(valor_entero(petivi_aipinsperitagruppaglist.vi_aipinsperitagrup.ncantreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsperitagruppaglist As New respvi_aipinsperitagruppaglist
	respvi_aipinsperitagruppaglist.pagvi_aipinsperitagrup = petivi_aipinsperitagruppaglist.pagvi_aipinsperitagrup
	Dim skip = skip_paginacion(petivi_aipinsperitagruppaglist.pagvi_aipinsperitagrup.npagactual, petivi_aipinsperitagruppaglist.pagvi_aipinsperitagrup.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsperitagruppaglist.lista_vi_aipinsperitagrup = _db.vi_aipinsperitagrup.OrderBy(petivi_aipinsperitagruppaglist.pagvi_aipinsperitagrup.xcamposord & " "  & petivi_aipinsperitagruppaglist.pagvi_aipinsperitagrup.idirord).Skip(skip).Take(petivi_aipinsperitagruppaglist.pagvi_aipinsperitagrup.npagtamano).ToList
		Else
			respvi_aipinsperitagruppaglist.lista_vi_aipinsperitagrup = _db.vi_aipinsperitagrup.Where(sb.ToString).OrderBy(petivi_aipinsperitagruppaglist.pagvi_aipinsperitagrup.xcamposord & " "  & petivi_aipinsperitagruppaglist.pagvi_aipinsperitagrup.idirord).Skip(skip).Take(petivi_aipinsperitagruppaglist.pagvi_aipinsperitagrup.npagtamano).ToList
		End If
		'
		If (respvi_aipinsperitagruppaglist.lista_vi_aipinsperitagrup.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsperitagrupxwheredinamicocount(sb)
		respvi_aipinsperitagruppaglist.pagvi_aipinsperitagrup.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsperitagruppaglist.pagvi_aipinsperitagrup.npagtamano)
		Else
		respvi_aipinsperitagruppaglist.pagvi_aipinsperitagrup.npagcantidad = 0
		respvi_aipinsperitagruppaglist.pagvi_aipinsperitagrup.npagactual = 0
		End If
	
		Return respvi_aipinsperitagruppaglist
	End Function


        Public Function selvi_aipinsperitagrupxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.vi_aipinsperitagrup.Count
            Else
                Return _db.vi_aipinsperitagrup.Where(sb.ToString).Count
            End If

        End Function


End Class
End Namespace
