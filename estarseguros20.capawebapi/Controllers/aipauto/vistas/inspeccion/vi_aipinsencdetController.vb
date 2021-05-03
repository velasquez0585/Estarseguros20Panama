Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsencdetController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsencdetxid(idaipactivperi As Decimal) As vi_aipinsencdet
            Dim vi_aipinsencdet As vi_aipinsencdet = (From p In _db.vi_aipinsencdet
                                            Where p.idaipactivperi = idaipactivperi
                                            Select p).SingleOrDefault
            Return vi_aipinsencdet
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsencdet() As List(Of vi_aipinsencdet)
		Dim lista_vi_aipinsencdet As List(Of vi_aipinsencdet) = (From p In _db.vi_aipinsencdet
													Select p).ToList
		'
		Return lista_vi_aipinsencdet
	End Function

<HttpPost()> _
	Public Function selvi_aipinsencdetxwheredinamicopag(petivi_aipinsencdetpaglist as petivi_aipinsencdetpaglist) as respvi_aipinsencdetpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.idsegmanusucreaactivperi <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusucreaactivperi=")
				sb.Append(valor_entero(petivi_aipinsencdetpaglist.vi_aipinsencdet.idsegmanusucreaactivperi))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusucreaactivperi=")
				sb.Append(valor_entero(petivi_aipinsencdetpaglist.vi_aipinsencdet.idsegmanusucreaactivperi))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.xnombrecompletocrea <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompletocrea='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xnombrecompletocrea)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompletocrea='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xnombrecompletocrea)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.idaipactivperi <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipactivperi=")
				sb.Append(valor_entero(petivi_aipinsencdetpaglist.vi_aipinsencdet.idaipactivperi))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipactivperi=")
				sb.Append(valor_entero(petivi_aipinsencdetpaglist.vi_aipinsencdet.idaipactivperi))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.fejecactivperi > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.fejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsencdetpaglist.vi_aipinsencdet.fejecactivperi)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.fejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsencdetpaglist.vi_aipinsencdet.fejecactivperi)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.xtituactivperi <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xtituactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xtituactivperi)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xtituactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xtituactivperi)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.ialcanactivperi <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.ialcanactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.ialcanactivperi)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ialcanactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.ialcanactivperi)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.iestatactivperi <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.iestatactivperi)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.iestatactivperi)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.ffinejecactivperi > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.ffinejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsencdetpaglist.vi_aipinsencdet.ffinejecactivperi)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.ffinejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsencdetpaglist.vi_aipinsencdet.ffinejecactivperi)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.idsegmanusu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusu=")
				sb.Append(valor_entero(petivi_aipinsencdetpaglist.vi_aipinsencdet.idsegmanusu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusu=")
				sb.Append(valor_entero(petivi_aipinsencdetpaglist.vi_aipinsencdet.idsegmanusu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.xnombreusuario <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombreusuario='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xnombreusuario)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombreusuario='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xnombreusuario)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.xnombrecompletoperito <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompletoperito='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xnombrecompletoperito)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompletoperito='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xnombrecompletoperito)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.xcedpropinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedpropinsenc='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xcedpropinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedpropinsenc='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xcedpropinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.xcidaseactivperi <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcidaseactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xcidaseactivperi)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcidaseactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xcidaseactivperi)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.xplacaactivperi <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacaactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xplacaactivperi)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacaactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xplacaactivperi)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.xsermotactivperi <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsermotactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xsermotactivperi)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsermotactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xsermotactivperi)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.xsercarractivperi <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsercarractivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xsercarractivperi)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsercarractivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xsercarractivperi)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.xnumpolinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumpolinsenc='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xnumpolinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumpolinsenc='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xnumpolinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.xnumsininsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumsininsenc='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xnumsininsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumsininsenc='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xnumsininsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.xtelfmovilactivperi <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xtelfmovilactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xtelfmovilactivperi)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xtelfmovilactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xtelfmovilactivperi)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsencdetpaglist.vi_aipinsencdet.xdescactivperi <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xdescactivperi)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescactivperi='")
				sb.Append(petivi_aipinsencdetpaglist.vi_aipinsencdet.xdescactivperi)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsencdetpaglist As New respvi_aipinsencdetpaglist
	respvi_aipinsencdetpaglist.pagvi_aipinsencdet = petivi_aipinsencdetpaglist.pagvi_aipinsencdet
	Dim skip = skip_paginacion(petivi_aipinsencdetpaglist.pagvi_aipinsencdet.npagactual, petivi_aipinsencdetpaglist.pagvi_aipinsencdet.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsencdetpaglist.lista_vi_aipinsencdet = _db.vi_aipinsencdet.OrderBy(petivi_aipinsencdetpaglist.pagvi_aipinsencdet.xcamposord & " "  & petivi_aipinsencdetpaglist.pagvi_aipinsencdet.idirord).Skip(skip).Take(petivi_aipinsencdetpaglist.pagvi_aipinsencdet.npagtamano).ToList
		Else
			respvi_aipinsencdetpaglist.lista_vi_aipinsencdet = _db.vi_aipinsencdet.Where(sb.ToString).OrderBy(petivi_aipinsencdetpaglist.pagvi_aipinsencdet.xcamposord & " "  & petivi_aipinsencdetpaglist.pagvi_aipinsencdet.idirord).Skip(skip).Take(petivi_aipinsencdetpaglist.pagvi_aipinsencdet.npagtamano).ToList
		End If
		'
		If (respvi_aipinsencdetpaglist.lista_vi_aipinsencdet.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsencdetxwheredinamicocount(sb)
		respvi_aipinsencdetpaglist.pagvi_aipinsencdet.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsencdetpaglist.pagvi_aipinsencdet.npagtamano)
		Else
		respvi_aipinsencdetpaglist.pagvi_aipinsencdet.npagcantidad = 0
		respvi_aipinsencdetpaglist.pagvi_aipinsencdet.npagactual = 0
		End If
	
		Return respvi_aipinsencdetpaglist
	End Function

	Public Function selvi_aipinsencdetxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsencdet.count
	Else
	Return _db.vi_aipinsencdet.Where(sb.ToString).Count
	End If
	End Function



        'personalizado

        <HttpPost()> _
        Public Function selvi_aipinsencdetxCorreoElectronicoYstart(start As Date, ialcanactivperi As String, xcorreoelectronico1 As String) As List(Of vi_aipinsencdet)
            Dim fecha_start As New Date(start.Year, start.Month, start.Day, 0, 0, 0)
            '
            Dim lista_vi_aipinsencdet As List(Of vi_aipinsencdet) = (From p In _db.vi_aipinsencdet
                                                                     Where p.fejecactivperi >= fecha_start And p.ialcanactivperi = ialcanactivperi And p.xnombreusuario = xcorreoelectronico1
                                                                     Select p).ToList
            '
            Return lista_vi_aipinsencdet
        End Function

End Class
End Namespace
