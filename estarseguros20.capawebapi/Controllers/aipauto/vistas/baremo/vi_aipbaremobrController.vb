Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.baremo
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipbaremobrController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipbaremobrxid(idaipbaremobr As Decimal) As vi_aipbaremobr
            Dim vi_aipbaremobr As vi_aipbaremobr = (From p In _db.vi_aipbaremobr
                                            Where p.idaipbaremobr = idaipbaremobr
                                            Select p).SingleOrDefault
            Return vi_aipbaremobr
        End Function

	<HttpPost()> _
	Public Function selvi_aipbaremobr() As List(Of vi_aipbaremobr)
		Dim lista_vi_aipbaremobr As List(Of vi_aipbaremobr) = (From p In _db.vi_aipbaremobr
													Select p).ToList
		'
		Return lista_vi_aipbaremobr
	End Function

<HttpPost()> _
	Public Function selvi_aipbaremobrxwheredinamicopag(petivi_aipbaremobrpaglist as petivi_aipbaremobrpaglist) as respvi_aipbaremobrpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipbaremobrpaglist.vi_aipbaremobr.idaipbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbaremobr=")
				sb.Append(valor_entero(petivi_aipbaremobrpaglist.vi_aipbaremobr.idaipbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbaremobr=")
				sb.Append(valor_entero(petivi_aipbaremobrpaglist.vi_aipbaremobr.idaipbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipbaremobrpaglist.vi_aipbaremobr.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipbaremobrpaglist.vi_aipbaremobr.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipbaremobrpaglist.vi_aipbaremobr.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipbaremobrpaglist.vi_aipbaremobr.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipbaremobrpaglist.vi_aipbaremobr.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipbaremobrpaglist.vi_aipbaremobr.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipbaremobrpaglist.vi_aipbaremobr.faplibaremobr > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.faplibaremobr >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipbaremobrpaglist.vi_aipbaremobr.faplibaremobr)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.faplibaremobr >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipbaremobrpaglist.vi_aipbaremobr.faplibaremobr)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aipbaremobrpaglist.vi_aipbaremobr.itipobaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipobaremobr='")
				sb.Append(petivi_aipbaremobrpaglist.vi_aipbaremobr.itipobaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipobaremobr='")
				sb.Append(petivi_aipbaremobrpaglist.vi_aipbaremobr.itipobaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipbaremobrpaglist.vi_aipbaremobr.itamapiezbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itamapiezbaremobr='")
				sb.Append(petivi_aipbaremobrpaglist.vi_aipbaremobr.itamapiezbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itamapiezbaremobr='")
				sb.Append(petivi_aipbaremobrpaglist.vi_aipbaremobr.itamapiezbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipbaremobrpaglist.vi_aipbaremobr.imaterpiezbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.imaterpiezbaremobr='")
				sb.Append(petivi_aipbaremobrpaglist.vi_aipbaremobr.imaterpiezbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.imaterpiezbaremobr='")
				sb.Append(petivi_aipbaremobrpaglist.vi_aipbaremobr.imaterpiezbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipbaremobrpaglist.vi_aipbaremobr.mcostbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mcostbaremobr=")
				sb.Append(valor_entero(petivi_aipbaremobrpaglist.vi_aipbaremobr.mcostbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mcostbaremobr=")
				sb.Append(valor_entero(petivi_aipbaremobrpaglist.vi_aipbaremobr.mcostbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipbaremobrpaglist.vi_aipbaremobr.xdescbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescbaremobr='")
				sb.Append(petivi_aipbaremobrpaglist.vi_aipbaremobr.xdescbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescbaremobr='")
				sb.Append(petivi_aipbaremobrpaglist.vi_aipbaremobr.xdescbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipbaremobrpaglist As New respvi_aipbaremobrpaglist
	respvi_aipbaremobrpaglist.pagvi_aipbaremobr = petivi_aipbaremobrpaglist.pagvi_aipbaremobr
	Dim skip = skip_paginacion(petivi_aipbaremobrpaglist.pagvi_aipbaremobr.npagactual, petivi_aipbaremobrpaglist.pagvi_aipbaremobr.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipbaremobrpaglist.lista_vi_aipbaremobr = _db.vi_aipbaremobr.OrderBy(petivi_aipbaremobrpaglist.pagvi_aipbaremobr.xcamposord & " "  & petivi_aipbaremobrpaglist.pagvi_aipbaremobr.idirord).Skip(skip).Take(petivi_aipbaremobrpaglist.pagvi_aipbaremobr.npagtamano).ToList
		Else
			respvi_aipbaremobrpaglist.lista_vi_aipbaremobr = _db.vi_aipbaremobr.Where(sb.ToString).OrderBy(petivi_aipbaremobrpaglist.pagvi_aipbaremobr.xcamposord & " "  & petivi_aipbaremobrpaglist.pagvi_aipbaremobr.idirord).Skip(skip).Take(petivi_aipbaremobrpaglist.pagvi_aipbaremobr.npagtamano).ToList
		End If
		'
		If (respvi_aipbaremobrpaglist.lista_vi_aipbaremobr.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipbaremobrxwheredinamicocount(sb)
		respvi_aipbaremobrpaglist.pagvi_aipbaremobr.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipbaremobrpaglist.pagvi_aipbaremobr.npagtamano)
		Else
		respvi_aipbaremobrpaglist.pagvi_aipbaremobr.npagcantidad = 0
		respvi_aipbaremobrpaglist.pagvi_aipbaremobr.npagactual = 0
		End If
	
		Return respvi_aipbaremobrpaglist
	End Function

	Public Function selvi_aipbaremobrxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipbaremobr.count
	Else
	Return _db.vi_aipbaremobr.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipbaremobrxfapli(faplibaremobr As Date) As List(Of vi_aipbaremobr)
            Dim lista_vi_aipbaremobr As List(Of vi_aipbaremobr) = (From p In _db.vi_aipbaremobr
                                            Where p.faplibaremobr = faplibaremobr
                                            Select p).ToList
            Return lista_vi_aipbaremobr
        End Function

        <HttpPost()> _
        Public Function faplibaremobrmax() As Date
            Dim faplibaremobr2 As Date = (From p In _db.vi_aipbaremobr
                                            Select p.faplibaremobr).Max()
            Return faplibaremobr2
        End Function

        <HttpPost()> _
        Public Function selvi_aipbaremobrxfaplipag(faplibaremobr As Date, paginacion As paginacion) As respvi_aipbaremobrpaglist
            Dim sb As New StringBuilder("")
            '

            If faplibaremobr > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.faplibaremobr = DATETIME'{0:yyyy-MM-dd HH:mm}'", faplibaremobr)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.faplibaremobr = DATETIME'{0:yyyy-MM-dd HH:mm}'", faplibaremobr)
                        sb.Append(fecha)
                    End If
                End If
            End If


            Dim respvi_aipbaremobrpaglist As New respvi_aipbaremobrpaglist
            respvi_aipbaremobrpaglist.pagvi_aipbaremobr = paginacion
            Dim skip = skip_paginacion(paginacion.npagactual, paginacion.npagtamano)

            If sb.ToString = "" Then
                respvi_aipbaremobrpaglist.lista_vi_aipbaremobr = _db.vi_aipbaremobr.OrderBy(paginacion.xcamposord & " " & paginacion.idirord).Skip(skip).Take(paginacion.npagtamano).ToList
            Else
                respvi_aipbaremobrpaglist.lista_vi_aipbaremobr = _db.vi_aipbaremobr.Where(sb.ToString).OrderBy(paginacion.xcamposord & " " & paginacion.idirord).Skip(skip).Take(paginacion.npagtamano).ToList
            End If
            '
            If (respvi_aipbaremobrpaglist.lista_vi_aipbaremobr.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_aipbaremobrxwheredinamicocount(sb)
                respvi_aipbaremobrpaglist.pagvi_aipbaremobr.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipbaremobrpaglist.pagvi_aipbaremobr.npagtamano)
            Else
                respvi_aipbaremobrpaglist.pagvi_aipbaremobr.npagcantidad = 0
                respvi_aipbaremobrpaglist.pagvi_aipbaremobr.npagactual = 0
            End If

            Return respvi_aipbaremobrpaglist
        End Function


        <HttpPost()> _
        Public Function selmcostbaremobrxidaipmanrepuyfapliytamyimatyitipo(idaipmanrepu As Decimal, faplibaremobr As Date, itamapiezbaremobr As String, imaterpiezbaremobr As String, itipobaremobr As String) As Decimal
            Dim mcostbaremobr2 As Decimal = (From p In _db.vi_aipbaremobr
                                            Where p.idaipmanrepu = idaipmanrepu And p.faplibaremobr = faplibaremobr And p.itamapiezbaremobr = itamapiezbaremobr And p.imaterpiezbaremobr = imaterpiezbaremobr And p.itipobaremobr = itipobaremobr
                                            Select p.mcostbaremobr).SingleOrDefault
            Return mcostbaremobr2
        End Function

        <HttpPost()> _
        Public Function selidaipbaremobrxidaipmanrepuyfapliytamyimatyitipo(idaipmanrepu As Decimal, faplibaremobr As Date, itamapiezbaremobr As String, imaterpiezbaremobr As String, itipobaremobr As String) As Decimal
            Dim idaipbaremobr2 As Decimal = (From p In _db.vi_aipbaremobr
                                            Where p.idaipmanrepu = idaipmanrepu And p.faplibaremobr = faplibaremobr And p.itamapiezbaremobr = itamapiezbaremobr And p.imaterpiezbaremobr = imaterpiezbaremobr And p.itipobaremobr = itipobaremobr
                                            Select p.idaipbaremobr).SingleOrDefault
            Return idaipbaremobr2
        End Function
End Class
End Namespace
