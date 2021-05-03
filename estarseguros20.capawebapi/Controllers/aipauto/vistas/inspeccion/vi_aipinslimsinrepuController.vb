Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinslimsinrepuController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinslimsinrepuxid(idaipinslimsinrepu As Decimal) As vi_aipinslimsinrepu
            Dim vi_aipinslimsinrepu As vi_aipinslimsinrepu = (From p In _db.vi_aipinslimsinrepu
                                            Where p.idaipinslimsinrepu = idaipinslimsinrepu
                                            Select p).SingleOrDefault
            Return vi_aipinslimsinrepu
        End Function

	<HttpPost()> _
	Public Function selvi_aipinslimsinrepu() As List(Of vi_aipinslimsinrepu)
		Dim lista_vi_aipinslimsinrepu As List(Of vi_aipinslimsinrepu) = (From p In _db.vi_aipinslimsinrepu
													Select p).ToList
		'
		Return lista_vi_aipinslimsinrepu
	End Function

<HttpPost()> _
	Public Function selvi_aipinslimsinrepuxwheredinamicopag(petivi_aipinslimsinrepupaglist as petivi_aipinslimsinrepupaglist) as respvi_aipinslimsinrepupaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idaipinslimsinrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsinrepu=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idaipinslimsinrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsinrepu=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idaipinslimsinrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idaipinslimsin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsin=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idaipinslimsin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsin=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idaipinslimsin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idaipbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbarerepu=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idaipbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbarerepu=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idaipbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.faplibarerepu > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.faplibarerepu >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.faplibarerepu)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.faplibarerepu >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.faplibarerepu)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.iorigbarerepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iorigbarerepu='")
				sb.Append(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.iorigbarerepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iorigbarerepu='")
				sb.Append(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.iorigbarerepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.mcostbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mcostbarerepu=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.mcostbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mcostbarerepu=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.mcostbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.ncantinslimsinrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinslimsinrepu=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.ncantinslimsinrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinslimsinrepu=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.ncantinslimsinrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.nprecfininslimsinrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininslimsinrepu=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.nprecfininslimsinrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininslimsinrepu=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.nprecfininslimsinrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.xdescinslimsinrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinslimsinrepu='")
				sb.Append(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.xdescinslimsinrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinslimsinrepu='")
				sb.Append(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.xdescinslimsinrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.iestatinslimsinrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinslimsinrepu='")
				sb.Append(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.iestatinslimsinrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinslimsinrepu='")
				sb.Append(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.iestatinslimsinrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinslimsinrepupaglist.vi_aipinslimsinrepu.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinslimsinrepupaglist As New respvi_aipinslimsinrepupaglist
	respvi_aipinslimsinrepupaglist.pagvi_aipinslimsinrepu = petivi_aipinslimsinrepupaglist.pagvi_aipinslimsinrepu
	Dim skip = skip_paginacion(petivi_aipinslimsinrepupaglist.pagvi_aipinslimsinrepu.npagactual, petivi_aipinslimsinrepupaglist.pagvi_aipinslimsinrepu.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinslimsinrepupaglist.lista_vi_aipinslimsinrepu = _db.vi_aipinslimsinrepu.OrderBy(petivi_aipinslimsinrepupaglist.pagvi_aipinslimsinrepu.xcamposord & " "  & petivi_aipinslimsinrepupaglist.pagvi_aipinslimsinrepu.idirord).Skip(skip).Take(petivi_aipinslimsinrepupaglist.pagvi_aipinslimsinrepu.npagtamano).ToList
		Else
			respvi_aipinslimsinrepupaglist.lista_vi_aipinslimsinrepu = _db.vi_aipinslimsinrepu.Where(sb.ToString).OrderBy(petivi_aipinslimsinrepupaglist.pagvi_aipinslimsinrepu.xcamposord & " "  & petivi_aipinslimsinrepupaglist.pagvi_aipinslimsinrepu.idirord).Skip(skip).Take(petivi_aipinslimsinrepupaglist.pagvi_aipinslimsinrepu.npagtamano).ToList
		End If
		'
		If (respvi_aipinslimsinrepupaglist.lista_vi_aipinslimsinrepu.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinslimsinrepuxwheredinamicocount(sb)
		respvi_aipinslimsinrepupaglist.pagvi_aipinslimsinrepu.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinslimsinrepupaglist.pagvi_aipinslimsinrepu.npagtamano)
		Else
		respvi_aipinslimsinrepupaglist.pagvi_aipinslimsinrepu.npagcantidad = 0
		respvi_aipinslimsinrepupaglist.pagvi_aipinslimsinrepu.npagactual = 0
		End If
	
		Return respvi_aipinslimsinrepupaglist
	End Function

	Public Function selvi_aipinslimsinrepuxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinslimsinrepu.count
	Else
	Return _db.vi_aipinslimsinrepu.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinslimsinrepuxidaipinslimsin(idaipinslimsin As Decimal) As List(Of vi_aipinslimsinrepu)
            Dim lista_vi_aipinslimsinrepu As List(Of vi_aipinslimsinrepu) = (From p In _db.vi_aipinslimsinrepu
                                                                             Where p.idaipinslimsin = idaipinslimsin
                                                        Select p).ToList
            '
            Return lista_vi_aipinslimsinrepu
        End Function

        <HttpPost()> _
        Public Function selnprecfininslimsinrepuxidaipinslimsin(idaipinslimsin As Decimal) As Decimal
            Dim totalnprecfininslimsinrepu As Decimal = (From p In _db.vi_aipinslimsinrepu
                                                                             Where p.idaipinslimsin = idaipinslimsin
                                                        Select p.nprecfininslimsinrepu).ToList.Sum
            '
            Return totalnprecfininslimsinrepu
        End Function

End Class
End Namespace
