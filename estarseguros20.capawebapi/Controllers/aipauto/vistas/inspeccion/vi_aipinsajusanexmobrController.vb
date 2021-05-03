Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsajusanexmobrController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsajusanexmobrxid(idaipinsajusanexmobr As Decimal) As vi_aipinsajusanexmobr
            Dim vi_aipinsajusanexmobr As vi_aipinsajusanexmobr = (From p In _db.vi_aipinsajusanexmobr
                                            Where p.idaipinsajusanexmobr = idaipinsajusanexmobr
                                            Select p).SingleOrDefault
            Return vi_aipinsajusanexmobr
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsajusanexmobr() As List(Of vi_aipinsajusanexmobr)
		Dim lista_vi_aipinsajusanexmobr As List(Of vi_aipinsajusanexmobr) = (From p In _db.vi_aipinsajusanexmobr
													Select p).ToList
		'
		Return lista_vi_aipinsajusanexmobr
	End Function

<HttpPost()> _
	Public Function selvi_aipinsajusanexmobrxwheredinamicopag(petivi_aipinsajusanexmobrpaglist as petivi_aipinsajusanexmobrpaglist) as respvi_aipinsajusanexmobrpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idaipinsajusanexmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajusanexmobr=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idaipinsajusanexmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajusanexmobr=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idaipinsajusanexmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idaipinsajusanex <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idaipinsajusanex))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idaipinsajusanex))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idaipbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbaremobr=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idaipbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbaremobr=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idaipbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.faplibaremobr > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.faplibaremobr >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.faplibaremobr)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.faplibaremobr >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.faplibaremobr)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.itipobaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipobaremobr='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.itipobaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipobaremobr='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.itipobaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.itamapiezbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itamapiezbaremobr='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.itamapiezbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itamapiezbaremobr='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.itamapiezbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.imaterpiezbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.imaterpiezbaremobr='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.imaterpiezbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.imaterpiezbaremobr='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.imaterpiezbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.mcostbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mcostbaremobr=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.mcostbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mcostbaremobr=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.mcostbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.xdescbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescbaremobr='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.xdescbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescbaremobr='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.xdescbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.ncantinsajusanexmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinsajusanexmobr=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.ncantinsajusanexmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinsajusanexmobr=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.ncantinsajusanexmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.nprecfininsajusanexmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininsajusanexmobr=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.nprecfininsajusanexmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininsajusanexmobr=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.nprecfininsajusanexmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.xdescinsajusanexmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsajusanexmobr='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.xdescinsajusanexmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsajusanexmobr='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.xdescinsajusanexmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.iestatinsajusanexmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsajusanexmobr='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.iestatinsajusanexmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsajusanexmobr='")
				sb.Append(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.iestatinsajusanexmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsajusanexmobrpaglist.vi_aipinsajusanexmobr.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsajusanexmobrpaglist As New respvi_aipinsajusanexmobrpaglist
	respvi_aipinsajusanexmobrpaglist.pagvi_aipinsajusanexmobr = petivi_aipinsajusanexmobrpaglist.pagvi_aipinsajusanexmobr
	Dim skip = skip_paginacion(petivi_aipinsajusanexmobrpaglist.pagvi_aipinsajusanexmobr.npagactual, petivi_aipinsajusanexmobrpaglist.pagvi_aipinsajusanexmobr.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsajusanexmobrpaglist.lista_vi_aipinsajusanexmobr = _db.vi_aipinsajusanexmobr.OrderBy(petivi_aipinsajusanexmobrpaglist.pagvi_aipinsajusanexmobr.xcamposord & " "  & petivi_aipinsajusanexmobrpaglist.pagvi_aipinsajusanexmobr.idirord).Skip(skip).Take(petivi_aipinsajusanexmobrpaglist.pagvi_aipinsajusanexmobr.npagtamano).ToList
		Else
			respvi_aipinsajusanexmobrpaglist.lista_vi_aipinsajusanexmobr = _db.vi_aipinsajusanexmobr.Where(sb.ToString).OrderBy(petivi_aipinsajusanexmobrpaglist.pagvi_aipinsajusanexmobr.xcamposord & " "  & petivi_aipinsajusanexmobrpaglist.pagvi_aipinsajusanexmobr.idirord).Skip(skip).Take(petivi_aipinsajusanexmobrpaglist.pagvi_aipinsajusanexmobr.npagtamano).ToList
		End If
		'
		If (respvi_aipinsajusanexmobrpaglist.lista_vi_aipinsajusanexmobr.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsajusanexmobrxwheredinamicocount(sb)
		respvi_aipinsajusanexmobrpaglist.pagvi_aipinsajusanexmobr.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsajusanexmobrpaglist.pagvi_aipinsajusanexmobr.npagtamano)
		Else
		respvi_aipinsajusanexmobrpaglist.pagvi_aipinsajusanexmobr.npagcantidad = 0
		respvi_aipinsajusanexmobrpaglist.pagvi_aipinsajusanexmobr.npagactual = 0
		End If
	
		Return respvi_aipinsajusanexmobrpaglist
	End Function

	Public Function selvi_aipinsajusanexmobrxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsajusanexmobr.count
	Else
	Return _db.vi_aipinsajusanexmobr.Where(sb.ToString).Count
	End If
	End Function


        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinsajusanexmobrxidaipinsajusanex(idaipinsajusanex As Decimal) As List(Of vi_aipinsajusanexmobr)
            Dim lista_vi_aipinsajusanexmobr As List(Of vi_aipinsajusanexmobr) = (From p In _db.vi_aipinsajusanexmobr
                                                                                 Where p.idaipinsajusanex = idaipinsajusanex
                                                        Select p).ToList
            '
            Return lista_vi_aipinsajusanexmobr
        End Function

        <HttpPost()> _
        Public Function selnprecfininsajusanexmobrxidaipinsajusanex(idaipinsajusanex As Decimal) As Decimal
            Dim totalnprecfininsajusanexmobr As Decimal = (From p In _db.vi_aipinsajusanexmobr
                                                                             Where p.idaipinsajusanex = idaipinsajusanex
                                                        Select p.nprecfininsajusanexmobr).ToList.Sum
            '
            Return totalnprecfininsajusanexmobr
        End Function

        <HttpPost()> _
        Public Function selvi_aipinsajusanexmobrxidaipinsajussinAndRepuesto(idaipinsajusanex As Decimal, idaipinsenc As Decimal, idaipmanrepu As Decimal) As List(Of vi_aipinsajusanexmobr)
            Dim lista_vi_aipinsajusanexmobr As List(Of vi_aipinsajusanexmobr) = (From p In _db.vi_aipinsajusanexmobr
                                                                               Where p.idaipinsajusanex = idaipinsajusanex And p.idaipinsenc = idaipinsenc And p.idaipmanrepu = idaipmanrepu
                                                        Select p).ToList
            '
            Return lista_vi_aipinsajusanexmobr
        End Function
End Class
End Namespace
