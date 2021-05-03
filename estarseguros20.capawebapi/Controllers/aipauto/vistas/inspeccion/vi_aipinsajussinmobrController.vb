Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsajussinmobrController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsajussinmobrxid(idaipinsajussinmobr As Decimal) As vi_aipinsajussinmobr
            Dim vi_aipinsajussinmobr As vi_aipinsajussinmobr = (From p In _db.vi_aipinsajussinmobr
                                            Where p.idaipinsajussinmobr = idaipinsajussinmobr
                                            Select p).SingleOrDefault
            Return vi_aipinsajussinmobr
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsajussinmobr() As List(Of vi_aipinsajussinmobr)
		Dim lista_vi_aipinsajussinmobr As List(Of vi_aipinsajussinmobr) = (From p In _db.vi_aipinsajussinmobr
													Select p).ToList
		'
		Return lista_vi_aipinsajussinmobr
	End Function

<HttpPost()> _
	Public Function selvi_aipinsajussinmobrxwheredinamicopag(petivi_aipinsajussinmobrpaglist as petivi_aipinsajussinmobrpaglist) as respvi_aipinsajussinmobrpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idaipinsajussinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajussinmobr=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idaipinsajussinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajussinmobr=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idaipinsajussinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idaipinsajussin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idaipinsajussin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idaipinsajussin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idaipbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbaremobr=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idaipbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbaremobr=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idaipbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.faplibaremobr > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.faplibaremobr >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.faplibaremobr)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.faplibaremobr >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.faplibaremobr)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.itipobaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipobaremobr='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.itipobaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipobaremobr='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.itipobaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.itamapiezbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itamapiezbaremobr='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.itamapiezbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itamapiezbaremobr='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.itamapiezbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.imaterpiezbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.imaterpiezbaremobr='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.imaterpiezbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.imaterpiezbaremobr='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.imaterpiezbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.mcostbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mcostbaremobr=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.mcostbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mcostbaremobr=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.mcostbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.xdescbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescbaremobr='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.xdescbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescbaremobr='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.xdescbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.ncantinsajussinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinsajussinmobr=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.ncantinsajussinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinsajussinmobr=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.ncantinsajussinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.nprecfininsajussinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininsajussinmobr=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.nprecfininsajussinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininsajussinmobr=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.nprecfininsajussinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.xdescinsajussinmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsajussinmobr='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.xdescinsajussinmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsajussinmobr='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.xdescinsajussinmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.iestatinsajussinmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsajussinmobr='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.iestatinsajussinmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsajussinmobr='")
				sb.Append(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.iestatinsajussinmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsajussinmobrpaglist.vi_aipinsajussinmobr.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsajussinmobrpaglist As New respvi_aipinsajussinmobrpaglist
	respvi_aipinsajussinmobrpaglist.pagvi_aipinsajussinmobr = petivi_aipinsajussinmobrpaglist.pagvi_aipinsajussinmobr
	Dim skip = skip_paginacion(petivi_aipinsajussinmobrpaglist.pagvi_aipinsajussinmobr.npagactual, petivi_aipinsajussinmobrpaglist.pagvi_aipinsajussinmobr.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsajussinmobrpaglist.lista_vi_aipinsajussinmobr = _db.vi_aipinsajussinmobr.OrderBy(petivi_aipinsajussinmobrpaglist.pagvi_aipinsajussinmobr.xcamposord & " "  & petivi_aipinsajussinmobrpaglist.pagvi_aipinsajussinmobr.idirord).Skip(skip).Take(petivi_aipinsajussinmobrpaglist.pagvi_aipinsajussinmobr.npagtamano).ToList
		Else
			respvi_aipinsajussinmobrpaglist.lista_vi_aipinsajussinmobr = _db.vi_aipinsajussinmobr.Where(sb.ToString).OrderBy(petivi_aipinsajussinmobrpaglist.pagvi_aipinsajussinmobr.xcamposord & " "  & petivi_aipinsajussinmobrpaglist.pagvi_aipinsajussinmobr.idirord).Skip(skip).Take(petivi_aipinsajussinmobrpaglist.pagvi_aipinsajussinmobr.npagtamano).ToList
		End If
		'
		If (respvi_aipinsajussinmobrpaglist.lista_vi_aipinsajussinmobr.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsajussinmobrxwheredinamicocount(sb)
		respvi_aipinsajussinmobrpaglist.pagvi_aipinsajussinmobr.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsajussinmobrpaglist.pagvi_aipinsajussinmobr.npagtamano)
		Else
		respvi_aipinsajussinmobrpaglist.pagvi_aipinsajussinmobr.npagcantidad = 0
		respvi_aipinsajussinmobrpaglist.pagvi_aipinsajussinmobr.npagactual = 0
		End If
	
		Return respvi_aipinsajussinmobrpaglist
	End Function

	Public Function selvi_aipinsajussinmobrxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsajussinmobr.count
	Else
	Return _db.vi_aipinsajussinmobr.Where(sb.ToString).Count
	End If
        End Function


        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinsajussinmobrxidaipinsajussin(idaipinsajussin As Decimal) As List(Of vi_aipinsajussinmobr)
            Dim lista_vi_aipinsajussinmobr As List(Of vi_aipinsajussinmobr) = (From p In _db.vi_aipinsajussinmobr
                                                                               Where p.idaipinsajussin = idaipinsajussin
                                                        Select p).ToList
            '
            Return lista_vi_aipinsajussinmobr
        End Function

        <HttpPost()> _
        Public Function selnprecfininsajussinmobrxidaipinsajussin(idaipinsajussin As Decimal) As Decimal
            Dim totalnprecfininsajussinmobr As Decimal = (From p In _db.vi_aipinsajussinmobr
                                                                             Where p.idaipinsajussin = idaipinsajussin
                                                        Select p.nprecfininsajussinmobr).ToList.Sum
            '
            Return totalnprecfininsajussinmobr
        End Function

        <HttpPost()> _
        Public Function selvi_aipinsajussinmobrxidaipinsajussinAndRepuesto(idaipinsajussin As Decimal, idaipinsenc As Decimal, idaipmanrepu As Decimal) As List(Of vi_aipinsajussinmobr)
            Dim lista_vi_aipinsajussinmobr As List(Of vi_aipinsajussinmobr) = (From p In _db.vi_aipinsajussinmobr
                                                                               Where p.idaipinsajussin = idaipinsajussin And p.idaipinsenc = idaipinsenc And p.idaipmanrepu = idaipmanrepu
                                                        Select p).ToList
            '
            Return lista_vi_aipinsajussinmobr
        End Function
End Class
End Namespace
