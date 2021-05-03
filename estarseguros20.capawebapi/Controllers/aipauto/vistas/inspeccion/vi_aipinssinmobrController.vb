Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinssinmobrController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinssinmobrxid(idaipinssinmobr As Decimal) As vi_aipinssinmobr
            Dim vi_aipinssinmobr As vi_aipinssinmobr = (From p In _db.vi_aipinssinmobr
                                            Where p.idaipinssinmobr = idaipinssinmobr
                                            Select p).SingleOrDefault
            Return vi_aipinssinmobr
        End Function

	<HttpPost()> _
	Public Function selvi_aipinssinmobr() As List(Of vi_aipinssinmobr)
		Dim lista_vi_aipinssinmobr As List(Of vi_aipinssinmobr) = (From p In _db.vi_aipinssinmobr
													Select p).ToList
		'
		Return lista_vi_aipinssinmobr
	End Function

<HttpPost()> _
	Public Function selvi_aipinssinmobrxwheredinamicopag(petivi_aipinssinmobrpaglist as petivi_aipinssinmobrpaglist) as respvi_aipinssinmobrpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinssinmobrpaglist.vi_aipinssinmobr.idaipinssinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssinmobr=")
				sb.Append(valor_entero(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.idaipinssinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssinmobr=")
				sb.Append(valor_entero(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.idaipinssinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmobrpaglist.vi_aipinssinmobr.idaipinssin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssin=")
				sb.Append(valor_entero(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.idaipinssin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssin=")
				sb.Append(valor_entero(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.idaipinssin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmobrpaglist.vi_aipinssinmobr.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmobrpaglist.vi_aipinssinmobr.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		
	 '
		If petivi_aipinssinmobrpaglist.vi_aipinssinmobr.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmobrpaglist.vi_aipinssinmobr.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		
	 '
		
	 '
		If petivi_aipinssinmobrpaglist.vi_aipinssinmobr.ncantinssinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinssinmobr=")
				sb.Append(valor_entero(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.ncantinssinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinssinmobr=")
				sb.Append(valor_entero(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.ncantinssinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmobrpaglist.vi_aipinssinmobr.nprecfininssinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininssinmobr=")
				sb.Append(valor_entero(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.nprecfininssinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininssinmobr=")
				sb.Append(valor_entero(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.nprecfininssinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmobrpaglist.vi_aipinssinmobr.xdescinssinmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinssinmobr='")
				sb.Append(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.xdescinssinmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinssinmobr='")
				sb.Append(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.xdescinssinmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmobrpaglist.vi_aipinssinmobr.iestatinssinmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinssinmobr='")
				sb.Append(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.iestatinssinmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinssinmobr='")
				sb.Append(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.iestatinssinmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinmobrpaglist.vi_aipinssinmobr.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssinmobrpaglist.vi_aipinssinmobr.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinssinmobrpaglist As New respvi_aipinssinmobrpaglist
	respvi_aipinssinmobrpaglist.pagvi_aipinssinmobr = petivi_aipinssinmobrpaglist.pagvi_aipinssinmobr
	Dim skip = skip_paginacion(petivi_aipinssinmobrpaglist.pagvi_aipinssinmobr.npagactual, petivi_aipinssinmobrpaglist.pagvi_aipinssinmobr.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinssinmobrpaglist.lista_vi_aipinssinmobr = _db.vi_aipinssinmobr.OrderBy(petivi_aipinssinmobrpaglist.pagvi_aipinssinmobr.xcamposord & " "  & petivi_aipinssinmobrpaglist.pagvi_aipinssinmobr.idirord).Skip(skip).Take(petivi_aipinssinmobrpaglist.pagvi_aipinssinmobr.npagtamano).ToList
		Else
			respvi_aipinssinmobrpaglist.lista_vi_aipinssinmobr = _db.vi_aipinssinmobr.Where(sb.ToString).OrderBy(petivi_aipinssinmobrpaglist.pagvi_aipinssinmobr.xcamposord & " "  & petivi_aipinssinmobrpaglist.pagvi_aipinssinmobr.idirord).Skip(skip).Take(petivi_aipinssinmobrpaglist.pagvi_aipinssinmobr.npagtamano).ToList
		End If
		'
		If (respvi_aipinssinmobrpaglist.lista_vi_aipinssinmobr.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinssinmobrxwheredinamicocount(sb)
		respvi_aipinssinmobrpaglist.pagvi_aipinssinmobr.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinssinmobrpaglist.pagvi_aipinssinmobr.npagtamano)
		Else
		respvi_aipinssinmobrpaglist.pagvi_aipinssinmobr.npagcantidad = 0
		respvi_aipinssinmobrpaglist.pagvi_aipinssinmobr.npagactual = 0
		End If
	
		Return respvi_aipinssinmobrpaglist
	End Function

	Public Function selvi_aipinssinmobrxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinssinmobr.count
	Else
	Return _db.vi_aipinssinmobr.Where(sb.ToString).Count
	End If
        End Function

        'personalizados
        <HttpPost()> _
        Public Function selvi_aipinssinmobrxidaipinssin(idaipinssin As Decimal) As List(Of vi_aipinssinmobr)
            Dim lista_vi_aipinssinmobr As List(Of vi_aipinssinmobr) = (From p In _db.vi_aipinssinmobr
                                            Where p.idaipinssin = idaipinssin
                                            Select p).ToList
            Return lista_vi_aipinssinmobr
        End Function

        <HttpPost()> _
        Public Function selnprecfininssinmobrxidaipinssin(idaipinssin As Decimal) As Decimal
            Dim nprecfininssinmobr2 As Decimal = (From p In _db.vi_aipinssinmobr
                                            Where p.idaipinssin = idaipinssin
                                            Select p.nprecfininssinmobr).ToList().Sum()
            Return nprecfininssinmobr2
        End Function

        <HttpPost()> _
        Public Function selnprecfinxidaipinssin(idaipinssin As Decimal) As Int32
            Dim ncantinssinmobr2 As Int32 = (From p In _db.vi_aipinssinmobr
                                            Where p.idaipinssin = idaipinssin
                                            Select p).DefaultIfEmpty.Sum(Function(a) a.ncantinssinmobr)
            Return ncantinssinmobr2
        End Function





End Class
End Namespace
