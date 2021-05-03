Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsajusanexmobragrupController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsajusanexmobragrupxid(idaipinsajusanex As Decimal) As vi_aipinsajusanexmobragrup
            Dim vi_aipinsajusanexmobragrup As vi_aipinsajusanexmobragrup = (From p In _db.vi_aipinsajusanexmobragrup
                                            Where p.idaipinsajusanex = idaipinsajusanex
                                            Select p).SingleOrDefault
            Return vi_aipinsajusanexmobragrup
        End Function

        <HttpPost()> _
        Public Function selvi_aipinsajusanexmobragrup(idaipinsajusanex As Decimal) As List(Of vi_aipinsajusanexmobragrup)
            Dim lista_vi_aipinsajusanexmobragrup As List(Of vi_aipinsajusanexmobragrup) = (From p In _db.vi_aipinsajusanexmobragrup
                                                        Where p.idaipinsajusanex = idaipinsajusanex
                                                        Order By p.xnommanrepu
                                                        Select p).ToList
            '
            Return lista_vi_aipinsajusanexmobragrup
        End Function

<HttpPost()> _
	Public Function selvi_aipinsajusanexmobragrupxwheredinamicopag(petivi_aipinsajusanexmobragruppaglist as petivi_aipinsajusanexmobragruppaglist) as respvi_aipinsajusanexmobragruppaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.idaipinsajusanex <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.idaipinsajusanex))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.idaipinsajusanex))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.ncantinsajusanexmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinsajusanexmobr=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.ncantinsajusanexmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinsajusanexmobr=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.ncantinsajusanexmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.nreginsajusanexmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nreginsajusanexmobr=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.nreginsajusanexmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nreginsajusanexmobr=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobragruppaglist.vi_aipinsajusanexmobragrup.nreginsajusanexmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsajusanexmobragruppaglist As New respvi_aipinsajusanexmobragruppaglist
	respvi_aipinsajusanexmobragruppaglist.pagvi_aipinsajusanexmobragrup = petivi_aipinsajusanexmobragruppaglist.pagvi_aipinsajusanexmobragrup
	Dim skip = skip_paginacion(petivi_aipinsajusanexmobragruppaglist.pagvi_aipinsajusanexmobragrup.npagactual, petivi_aipinsajusanexmobragruppaglist.pagvi_aipinsajusanexmobragrup.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsajusanexmobragruppaglist.lista_vi_aipinsajusanexmobragrup = _db.vi_aipinsajusanexmobragrup.OrderBy(petivi_aipinsajusanexmobragruppaglist.pagvi_aipinsajusanexmobragrup.xcamposord & " "  & petivi_aipinsajusanexmobragruppaglist.pagvi_aipinsajusanexmobragrup.idirord).Skip(skip).Take(petivi_aipinsajusanexmobragruppaglist.pagvi_aipinsajusanexmobragrup.npagtamano).ToList
		Else
			respvi_aipinsajusanexmobragruppaglist.lista_vi_aipinsajusanexmobragrup = _db.vi_aipinsajusanexmobragrup.Where(sb.ToString).OrderBy(petivi_aipinsajusanexmobragruppaglist.pagvi_aipinsajusanexmobragrup.xcamposord & " "  & petivi_aipinsajusanexmobragruppaglist.pagvi_aipinsajusanexmobragrup.idirord).Skip(skip).Take(petivi_aipinsajusanexmobragruppaglist.pagvi_aipinsajusanexmobragrup.npagtamano).ToList
		End If
		'
		If (respvi_aipinsajusanexmobragruppaglist.lista_vi_aipinsajusanexmobragrup.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsajusanexmobragrupxwheredinamicocount(sb)
		respvi_aipinsajusanexmobragruppaglist.pagvi_aipinsajusanexmobragrup.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsajusanexmobragruppaglist.pagvi_aipinsajusanexmobragrup.npagtamano)
		Else
		respvi_aipinsajusanexmobragruppaglist.pagvi_aipinsajusanexmobragrup.npagcantidad = 0
		respvi_aipinsajusanexmobragruppaglist.pagvi_aipinsajusanexmobragrup.npagactual = 0
		End If
	
		Return respvi_aipinsajusanexmobragruppaglist
	End Function

	Public Function selvi_aipinsajusanexmobragrupxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsajusanexmobragrup.count
	Else
	Return _db.vi_aipinsajusanexmobragrup.Where(sb.ToString).Count
	End If
	End Function

End Class
End Namespace
