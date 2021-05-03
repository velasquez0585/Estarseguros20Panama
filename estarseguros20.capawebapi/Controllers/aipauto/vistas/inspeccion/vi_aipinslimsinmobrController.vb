Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinslimsinmobrController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinslimsinmobrxid(idaipinslimsinmobr As Decimal) As vi_aipinslimsinmobr
            Dim vi_aipinslimsinmobr As vi_aipinslimsinmobr = (From p In _db.vi_aipinslimsinmobr
                                            Where p.idaipinslimsinmobr = idaipinslimsinmobr
                                            Select p).SingleOrDefault
            Return vi_aipinslimsinmobr
        End Function

	<HttpPost()> _
	Public Function selvi_aipinslimsinmobr() As List(Of vi_aipinslimsinmobr)
		Dim lista_vi_aipinslimsinmobr As List(Of vi_aipinslimsinmobr) = (From p In _db.vi_aipinslimsinmobr
													Select p).ToList
		'
		Return lista_vi_aipinslimsinmobr
	End Function

<HttpPost()> _
	Public Function selvi_aipinslimsinmobrxwheredinamicopag(petivi_aipinslimsinmobrpaglist as petivi_aipinslimsinmobrpaglist) as respvi_aipinslimsinmobrpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idaipinslimsinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsinmobr=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idaipinslimsinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsinmobr=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idaipinslimsinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idaipinslimsin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsin=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idaipinslimsin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsin=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idaipinslimsin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idaipbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbaremobr=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idaipbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbaremobr=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idaipbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.faplibaremobr > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.faplibaremobr >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.faplibaremobr)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.faplibaremobr >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.faplibaremobr)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.itipobaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipobaremobr='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.itipobaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipobaremobr='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.itipobaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.itamapiezbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itamapiezbaremobr='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.itamapiezbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itamapiezbaremobr='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.itamapiezbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.imaterpiezbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.imaterpiezbaremobr='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.imaterpiezbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.imaterpiezbaremobr='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.imaterpiezbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.mcostbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mcostbaremobr=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.mcostbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mcostbaremobr=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.mcostbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.xdescbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescbaremobr='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.xdescbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescbaremobr='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.xdescbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.ncantinslimsinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinslimsinmobr=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.ncantinslimsinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinslimsinmobr=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.ncantinslimsinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.nprecfininslimsinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininslimsinmobr=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.nprecfininslimsinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininslimsinmobr=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.nprecfininslimsinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.xdescinslimsinmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinslimsinmobr='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.xdescinslimsinmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinslimsinmobr='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.xdescinslimsinmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.iestatinslimsinmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinslimsinmobr='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.iestatinslimsinmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinslimsinmobr='")
				sb.Append(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.iestatinslimsinmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinslimsinmobrpaglist.vi_aipinslimsinmobr.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinslimsinmobrpaglist As New respvi_aipinslimsinmobrpaglist
	respvi_aipinslimsinmobrpaglist.pagvi_aipinslimsinmobr = petivi_aipinslimsinmobrpaglist.pagvi_aipinslimsinmobr
	Dim skip = skip_paginacion(petivi_aipinslimsinmobrpaglist.pagvi_aipinslimsinmobr.npagactual, petivi_aipinslimsinmobrpaglist.pagvi_aipinslimsinmobr.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinslimsinmobrpaglist.lista_vi_aipinslimsinmobr = _db.vi_aipinslimsinmobr.OrderBy(petivi_aipinslimsinmobrpaglist.pagvi_aipinslimsinmobr.xcamposord & " "  & petivi_aipinslimsinmobrpaglist.pagvi_aipinslimsinmobr.idirord).Skip(skip).Take(petivi_aipinslimsinmobrpaglist.pagvi_aipinslimsinmobr.npagtamano).ToList
		Else
			respvi_aipinslimsinmobrpaglist.lista_vi_aipinslimsinmobr = _db.vi_aipinslimsinmobr.Where(sb.ToString).OrderBy(petivi_aipinslimsinmobrpaglist.pagvi_aipinslimsinmobr.xcamposord & " "  & petivi_aipinslimsinmobrpaglist.pagvi_aipinslimsinmobr.idirord).Skip(skip).Take(petivi_aipinslimsinmobrpaglist.pagvi_aipinslimsinmobr.npagtamano).ToList
		End If
		'
		If (respvi_aipinslimsinmobrpaglist.lista_vi_aipinslimsinmobr.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinslimsinmobrxwheredinamicocount(sb)
		respvi_aipinslimsinmobrpaglist.pagvi_aipinslimsinmobr.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinslimsinmobrpaglist.pagvi_aipinslimsinmobr.npagtamano)
		Else
		respvi_aipinslimsinmobrpaglist.pagvi_aipinslimsinmobr.npagcantidad = 0
		respvi_aipinslimsinmobrpaglist.pagvi_aipinslimsinmobr.npagactual = 0
		End If
	
		Return respvi_aipinslimsinmobrpaglist
	End Function

	Public Function selvi_aipinslimsinmobrxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinslimsinmobr.count
	Else
	Return _db.vi_aipinslimsinmobr.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinslimsinmobrxidaipinslimsin(idaipinslimsin As Decimal) As List(Of vi_aipinslimsinmobr)
            Dim lista_vi_aipinslimsinmobr As List(Of vi_aipinslimsinmobr) = (From p In _db.vi_aipinslimsinmobr
                                                                             Where p.idaipinslimsin = idaipinslimsin
                                                        Select p).ToList
            '
            Return lista_vi_aipinslimsinmobr
        End Function

        <HttpPost()> _
        Public Function selnprecfininslimsinmobrxidaipinslimsin(idaipinslimsin As Decimal) As Decimal
            Dim totalnprecfininslimsinmobr As Decimal = (From p In _db.vi_aipinslimsinmobr
                                                                             Where p.idaipinslimsin = idaipinslimsin
                                                        Select p.nprecfininslimsinmobr).ToList.Sum
            '
            Return totalnprecfininslimsinmobr
        End Function
End Class
End Namespace
