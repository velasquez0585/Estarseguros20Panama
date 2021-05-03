Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsajussinrepuController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsajussinrepuxid(idaipinsajussinrepu As Decimal) As vi_aipinsajussinrepu
            Dim vi_aipinsajussinrepu As vi_aipinsajussinrepu = (From p In _db.vi_aipinsajussinrepu
                                            Where p.idaipinsajussinrepu = idaipinsajussinrepu
                                            Select p).SingleOrDefault
            Return vi_aipinsajussinrepu
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsajussinrepu() As List(Of vi_aipinsajussinrepu)
		Dim lista_vi_aipinsajussinrepu As List(Of vi_aipinsajussinrepu) = (From p In _db.vi_aipinsajussinrepu
													Select p).ToList
		'
		Return lista_vi_aipinsajussinrepu
	End Function

<HttpPost()> _
	Public Function selvi_aipinsajussinrepuxwheredinamicopag(petivi_aipinsajussinrepupaglist as petivi_aipinsajussinrepupaglist) as respvi_aipinsajussinrepupaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.idaipinsajussinrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajussinrepu=")
				sb.Append(valor_entero(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.idaipinsajussinrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajussinrepu=")
				sb.Append(valor_entero(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.idaipinsajussinrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.idaipinsajussin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.idaipinsajussin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.idaipinsajussin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.idaipbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbarerepu=")
				sb.Append(valor_entero(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.idaipbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbarerepu=")
				sb.Append(valor_entero(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.idaipbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.faplibarerepu > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.faplibarerepu >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.faplibarerepu)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.faplibarerepu >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.faplibarerepu)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.iorigbarerepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iorigbarerepu='")
				sb.Append(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.iorigbarerepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iorigbarerepu='")
				sb.Append(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.iorigbarerepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.mcostbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mcostbarerepu=")
				sb.Append(valor_entero(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.mcostbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mcostbarerepu=")
				sb.Append(valor_entero(petivi_aipinsajussinrepupaglist.vi_aipinsajussinrepu.mcostbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsajussinrepupaglist As New respvi_aipinsajussinrepupaglist
	respvi_aipinsajussinrepupaglist.pagvi_aipinsajussinrepu = petivi_aipinsajussinrepupaglist.pagvi_aipinsajussinrepu
	Dim skip = skip_paginacion(petivi_aipinsajussinrepupaglist.pagvi_aipinsajussinrepu.npagactual, petivi_aipinsajussinrepupaglist.pagvi_aipinsajussinrepu.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsajussinrepupaglist.lista_vi_aipinsajussinrepu = _db.vi_aipinsajussinrepu.OrderBy(petivi_aipinsajussinrepupaglist.pagvi_aipinsajussinrepu.xcamposord & " "  & petivi_aipinsajussinrepupaglist.pagvi_aipinsajussinrepu.idirord).Skip(skip).Take(petivi_aipinsajussinrepupaglist.pagvi_aipinsajussinrepu.npagtamano).ToList
		Else
			respvi_aipinsajussinrepupaglist.lista_vi_aipinsajussinrepu = _db.vi_aipinsajussinrepu.Where(sb.ToString).OrderBy(petivi_aipinsajussinrepupaglist.pagvi_aipinsajussinrepu.xcamposord & " "  & petivi_aipinsajussinrepupaglist.pagvi_aipinsajussinrepu.idirord).Skip(skip).Take(petivi_aipinsajussinrepupaglist.pagvi_aipinsajussinrepu.npagtamano).ToList
		End If
		'
		If (respvi_aipinsajussinrepupaglist.lista_vi_aipinsajussinrepu.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsajussinrepuxwheredinamicocount(sb)
		respvi_aipinsajussinrepupaglist.pagvi_aipinsajussinrepu.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsajussinrepupaglist.pagvi_aipinsajussinrepu.npagtamano)
		Else
		respvi_aipinsajussinrepupaglist.pagvi_aipinsajussinrepu.npagcantidad = 0
		respvi_aipinsajussinrepupaglist.pagvi_aipinsajussinrepu.npagactual = 0
		End If
	
		Return respvi_aipinsajussinrepupaglist
	End Function

	Public Function selvi_aipinsajussinrepuxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsajussinrepu.count
	Else
	Return _db.vi_aipinsajussinrepu.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinsajussinrepuxidaipinsajussin(idaipinsajussin As Decimal) As List(Of vi_aipinsajussinrepu)
            Dim lista_vi_aipinsajussinrepu As List(Of vi_aipinsajussinrepu) = (From p In _db.vi_aipinsajussinrepu
                                                                               Where p.idaipinsajussin = idaipinsajussin
                                                        Select p).ToList
            '
            Return lista_vi_aipinsajussinrepu
        End Function

        <HttpPost()> _
        Public Function selnprecfininsajussinrepuxidaipinsajussin(idaipinsajussin As Decimal) As Decimal
            Dim totalnprecfininsajussinrepu As Decimal = (From p In _db.vi_aipinsajussinrepu
                                                                             Where p.idaipinsajussin = idaipinsajussin
                                                        Select p.nprecfininsajussinrepu).ToList.Sum
            '
            Return totalnprecfininsajussinrepu
        End Function
End Class
End Namespace
