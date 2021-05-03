Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsajussinmobragrupController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsajussinmobragrupxid(idaipinsajussin As Decimal) As vi_aipinsajussinmobragrup
            Dim vi_aipinsajussinmobragrup As vi_aipinsajussinmobragrup = (From p In _db.vi_aipinsajussinmobragrup
                                            Where p.idaipinsajussin = idaipinsajussin
                                            Select p).SingleOrDefault
            Return vi_aipinsajussinmobragrup
        End Function

        <HttpPost()> _
        Public Function selvi_aipinsajussinmobragrup(idaipinsajussin As Decimal) As List(Of vi_aipinsajussinmobragrup)
            Dim lista_vi_aipinsajussinmobragrup As List(Of vi_aipinsajussinmobragrup) = (From p In _db.vi_aipinsajussinmobragrup
                                                        Where p.idaipinsajussin = idaipinsajussin
                                                        Order By p.xnommanrepu
                                                        Select p).ToList
            '
            Return lista_vi_aipinsajussinmobragrup
        End Function

<HttpPost()> _
	Public Function selvi_aipinsajussinmobragrupxwheredinamicopag(petivi_aipinsajussinmobragruppaglist as petivi_aipinsajussinmobragruppaglist) as respvi_aipinsajussinmobragruppaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.idaipinsajussin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.idaipinsajussin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.idaipinsajussin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.ncantinsajussinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinsajussinmobr=")
				sb.Append(valor_entero(petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.ncantinsajussinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinsajussinmobr=")
				sb.Append(valor_entero(petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.ncantinsajussinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.nreginsajussinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nreginsajussinmobr=")
				sb.Append(valor_entero(petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.nreginsajussinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nreginsajussinmobr=")
				sb.Append(valor_entero(petivi_aipinsajussinmobragruppaglist.vi_aipinsajussinmobragrup.nreginsajussinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsajussinmobragruppaglist As New respvi_aipinsajussinmobragruppaglist
	respvi_aipinsajussinmobragruppaglist.pagvi_aipinsajussinmobragrup = petivi_aipinsajussinmobragruppaglist.pagvi_aipinsajussinmobragrup
	Dim skip = skip_paginacion(petivi_aipinsajussinmobragruppaglist.pagvi_aipinsajussinmobragrup.npagactual, petivi_aipinsajussinmobragruppaglist.pagvi_aipinsajussinmobragrup.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsajussinmobragruppaglist.lista_vi_aipinsajussinmobragrup = _db.vi_aipinsajussinmobragrup.OrderBy(petivi_aipinsajussinmobragruppaglist.pagvi_aipinsajussinmobragrup.xcamposord & " "  & petivi_aipinsajussinmobragruppaglist.pagvi_aipinsajussinmobragrup.idirord).Skip(skip).Take(petivi_aipinsajussinmobragruppaglist.pagvi_aipinsajussinmobragrup.npagtamano).ToList
		Else
			respvi_aipinsajussinmobragruppaglist.lista_vi_aipinsajussinmobragrup = _db.vi_aipinsajussinmobragrup.Where(sb.ToString).OrderBy(petivi_aipinsajussinmobragruppaglist.pagvi_aipinsajussinmobragrup.xcamposord & " "  & petivi_aipinsajussinmobragruppaglist.pagvi_aipinsajussinmobragrup.idirord).Skip(skip).Take(petivi_aipinsajussinmobragruppaglist.pagvi_aipinsajussinmobragrup.npagtamano).ToList
		End If
		'
		If (respvi_aipinsajussinmobragruppaglist.lista_vi_aipinsajussinmobragrup.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsajussinmobragrupxwheredinamicocount(sb)
		respvi_aipinsajussinmobragruppaglist.pagvi_aipinsajussinmobragrup.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsajussinmobragruppaglist.pagvi_aipinsajussinmobragrup.npagtamano)
		Else
		respvi_aipinsajussinmobragruppaglist.pagvi_aipinsajussinmobragrup.npagcantidad = 0
		respvi_aipinsajussinmobragruppaglist.pagvi_aipinsajussinmobragrup.npagactual = 0
		End If
	
		Return respvi_aipinsajussinmobragruppaglist
	End Function

	Public Function selvi_aipinsajussinmobragrupxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsajussinmobragrup.count
	Else
	Return _db.vi_aipinsajussinmobragrup.Where(sb.ToString).Count
	End If
	End Function

End Class
End Namespace
