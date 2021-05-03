Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinslimsusmobrController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinslimsusmobrxid(idaipinslimsusmobr As Decimal) As vi_aipinslimsusmobr
            Dim vi_aipinslimsusmobr As vi_aipinslimsusmobr = (From p In _db.vi_aipinslimsusmobr
                                            Where p.idaipinslimsusmobr = idaipinslimsusmobr
                                            Select p).SingleOrDefault
            Return vi_aipinslimsusmobr
        End Function

	<HttpPost()> _
	Public Function selvi_aipinslimsusmobr() As List(Of vi_aipinslimsusmobr)
		Dim lista_vi_aipinslimsusmobr As List(Of vi_aipinslimsusmobr) = (From p In _db.vi_aipinslimsusmobr
													Select p).ToList
		'
		Return lista_vi_aipinslimsusmobr
	End Function

<HttpPost()> _
	Public Function selvi_aipinslimsusmobrxwheredinamicopag(petivi_aipinslimsusmobrpaglist as petivi_aipinslimsusmobrpaglist) as respvi_aipinslimsusmobrpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idaipinslimsusmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsusmobr=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idaipinslimsusmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsusmobr=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idaipinslimsusmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idaipinslimsus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsus=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idaipinslimsus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsus=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idaipinslimsus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idaipbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbaremobr=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idaipbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbaremobr=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idaipbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.faplibaremobr > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.faplibaremobr >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.faplibaremobr)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.faplibaremobr >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.faplibaremobr)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.itipobaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipobaremobr='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.itipobaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipobaremobr='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.itipobaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.itamapiezbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itamapiezbaremobr='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.itamapiezbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itamapiezbaremobr='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.itamapiezbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.imaterpiezbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.imaterpiezbaremobr='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.imaterpiezbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.imaterpiezbaremobr='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.imaterpiezbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.mcostbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mcostbaremobr=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.mcostbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mcostbaremobr=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.mcostbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.xdescbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescbaremobr='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.xdescbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescbaremobr='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.xdescbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.ncantinslimsusmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinslimsusmobr=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.ncantinslimsusmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinslimsusmobr=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.ncantinslimsusmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.nprecfininslimsusmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininslimsusmobr=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.nprecfininslimsusmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininslimsusmobr=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.nprecfininslimsusmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.xdescinslimsusmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinslimsusmobr='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.xdescinslimsusmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinslimsusmobr='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.xdescinslimsusmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.iestatinslimsusmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinslimsusmobr='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.iestatinslimsusmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinslimsusmobr='")
				sb.Append(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.iestatinslimsusmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinslimsusmobrpaglist.vi_aipinslimsusmobr.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinslimsusmobrpaglist As New respvi_aipinslimsusmobrpaglist
	respvi_aipinslimsusmobrpaglist.pagvi_aipinslimsusmobr = petivi_aipinslimsusmobrpaglist.pagvi_aipinslimsusmobr
	Dim skip = skip_paginacion(petivi_aipinslimsusmobrpaglist.pagvi_aipinslimsusmobr.npagactual, petivi_aipinslimsusmobrpaglist.pagvi_aipinslimsusmobr.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinslimsusmobrpaglist.lista_vi_aipinslimsusmobr = _db.vi_aipinslimsusmobr.OrderBy(petivi_aipinslimsusmobrpaglist.pagvi_aipinslimsusmobr.xcamposord & " "  & petivi_aipinslimsusmobrpaglist.pagvi_aipinslimsusmobr.idirord).Skip(skip).Take(petivi_aipinslimsusmobrpaglist.pagvi_aipinslimsusmobr.npagtamano).ToList
		Else
			respvi_aipinslimsusmobrpaglist.lista_vi_aipinslimsusmobr = _db.vi_aipinslimsusmobr.Where(sb.ToString).OrderBy(petivi_aipinslimsusmobrpaglist.pagvi_aipinslimsusmobr.xcamposord & " "  & petivi_aipinslimsusmobrpaglist.pagvi_aipinslimsusmobr.idirord).Skip(skip).Take(petivi_aipinslimsusmobrpaglist.pagvi_aipinslimsusmobr.npagtamano).ToList
		End If
		'
		If (respvi_aipinslimsusmobrpaglist.lista_vi_aipinslimsusmobr.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinslimsusmobrxwheredinamicocount(sb)
		respvi_aipinslimsusmobrpaglist.pagvi_aipinslimsusmobr.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinslimsusmobrpaglist.pagvi_aipinslimsusmobr.npagtamano)
		Else
		respvi_aipinslimsusmobrpaglist.pagvi_aipinslimsusmobr.npagcantidad = 0
		respvi_aipinslimsusmobrpaglist.pagvi_aipinslimsusmobr.npagactual = 0
		End If
	
		Return respvi_aipinslimsusmobrpaglist
	End Function

	Public Function selvi_aipinslimsusmobrxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinslimsusmobr.count
	Else
	Return _db.vi_aipinslimsusmobr.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinslimsusmobrxidaipinslimsus(idaipinslimsus As Decimal) As List(Of vi_aipinslimsusmobr)
            Dim lista_vi_aipinslimsusmobr As List(Of vi_aipinslimsusmobr) = (From p In _db.vi_aipinslimsusmobr
                                                                             Where p.idaipinslimsus = idaipinslimsus
                                                        Select p).ToList
            '
            Return lista_vi_aipinslimsusmobr
        End Function

        <HttpPost()> _
        Public Function selnprecfininslimsusmobrxidaipinslimsus(idaipinslimsus As Decimal) As Decimal
            Dim totalnprecfininslimsusmobr As Decimal = (From p In _db.vi_aipinslimsusmobr
                                                                             Where p.idaipinslimsus = idaipinslimsus
                                                        Select p.nprecfininslimsusmobr).ToList.Sum
            '
            Return totalnprecfininslimsusmobr
        End Function
End Class
End Namespace
