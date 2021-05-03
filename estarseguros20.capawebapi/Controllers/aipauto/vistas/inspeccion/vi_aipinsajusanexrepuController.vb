Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsajusanexrepuController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsajusanexrepuxid(idaipinsajusanexrepu As Decimal) As vi_aipinsajusanexrepu
            Dim vi_aipinsajusanexrepu As vi_aipinsajusanexrepu = (From p In _db.vi_aipinsajusanexrepu
                                            Where p.idaipinsajusanexrepu = idaipinsajusanexrepu
                                            Select p).SingleOrDefault
            Return vi_aipinsajusanexrepu
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsajusanexrepu() As List(Of vi_aipinsajusanexrepu)
		Dim lista_vi_aipinsajusanexrepu As List(Of vi_aipinsajusanexrepu) = (From p In _db.vi_aipinsajusanexrepu
													Select p).ToList
		'
		Return lista_vi_aipinsajusanexrepu
	End Function

<HttpPost()> _
	Public Function selvi_aipinsajusanexrepuxwheredinamicopag(petivi_aipinsajusanexrepupaglist as petivi_aipinsajusanexrepupaglist) as respvi_aipinsajusanexrepupaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.idaipinsajusanexrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajusanexrepu=")
				sb.Append(valor_entero(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.idaipinsajusanexrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajusanexrepu=")
				sb.Append(valor_entero(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.idaipinsajusanexrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.idaipinsajusanex <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.idaipinsajusanex))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.idaipinsajusanex))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.idaipbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbarerepu=")
				sb.Append(valor_entero(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.idaipbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbarerepu=")
				sb.Append(valor_entero(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.idaipbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.faplibarerepu > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.faplibarerepu >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.faplibarerepu)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.faplibarerepu >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.faplibarerepu)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.iorigbarerepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iorigbarerepu='")
				sb.Append(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.iorigbarerepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iorigbarerepu='")
				sb.Append(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.iorigbarerepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.mcostbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mcostbarerepu=")
				sb.Append(valor_entero(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.mcostbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mcostbarerepu=")
				sb.Append(valor_entero(petivi_aipinsajusanexrepupaglist.vi_aipinsajusanexrepu.mcostbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsajusanexrepupaglist As New respvi_aipinsajusanexrepupaglist
	respvi_aipinsajusanexrepupaglist.pagvi_aipinsajusanexrepu = petivi_aipinsajusanexrepupaglist.pagvi_aipinsajusanexrepu
	Dim skip = skip_paginacion(petivi_aipinsajusanexrepupaglist.pagvi_aipinsajusanexrepu.npagactual, petivi_aipinsajusanexrepupaglist.pagvi_aipinsajusanexrepu.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsajusanexrepupaglist.lista_vi_aipinsajusanexrepu = _db.vi_aipinsajusanexrepu.OrderBy(petivi_aipinsajusanexrepupaglist.pagvi_aipinsajusanexrepu.xcamposord & " "  & petivi_aipinsajusanexrepupaglist.pagvi_aipinsajusanexrepu.idirord).Skip(skip).Take(petivi_aipinsajusanexrepupaglist.pagvi_aipinsajusanexrepu.npagtamano).ToList
		Else
			respvi_aipinsajusanexrepupaglist.lista_vi_aipinsajusanexrepu = _db.vi_aipinsajusanexrepu.Where(sb.ToString).OrderBy(petivi_aipinsajusanexrepupaglist.pagvi_aipinsajusanexrepu.xcamposord & " "  & petivi_aipinsajusanexrepupaglist.pagvi_aipinsajusanexrepu.idirord).Skip(skip).Take(petivi_aipinsajusanexrepupaglist.pagvi_aipinsajusanexrepu.npagtamano).ToList
		End If
		'
		If (respvi_aipinsajusanexrepupaglist.lista_vi_aipinsajusanexrepu.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsajusanexrepuxwheredinamicocount(sb)
		respvi_aipinsajusanexrepupaglist.pagvi_aipinsajusanexrepu.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsajusanexrepupaglist.pagvi_aipinsajusanexrepu.npagtamano)
		Else
		respvi_aipinsajusanexrepupaglist.pagvi_aipinsajusanexrepu.npagcantidad = 0
		respvi_aipinsajusanexrepupaglist.pagvi_aipinsajusanexrepu.npagactual = 0
		End If
	
		Return respvi_aipinsajusanexrepupaglist
	End Function

	Public Function selvi_aipinsajusanexrepuxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsajusanexrepu.count
	Else
	Return _db.vi_aipinsajusanexrepu.Where(sb.ToString).Count
	End If
	End Function


        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinsajusanexrepuxidaipinsajusanex(idaipinsajusanex As Decimal) As List(Of vi_aipinsajusanexrepu)
            Dim lista_vi_aipinsajusanexrepu As List(Of vi_aipinsajusanexrepu) = (From p In _db.vi_aipinsajusanexrepu
                                                                                 Where p.idaipinsajusanex = idaipinsajusanex
                                                        Select p).ToList
            '
            Return lista_vi_aipinsajusanexrepu
        End Function

        <HttpPost()> _
        Public Function selnprecfininsajusanexrepuxidaipinsajusanex(idaipinsajusanex As Decimal) As Decimal
            Dim totalnprecfininsajusanexrepu As Decimal = (From p In _db.vi_aipinsajusanexrepu
                                                                             Where p.idaipinsajusanex = idaipinsajusanex
                                                        Select p.nprecfininsajusanexrepu).ToList.Sum
            '
            Return totalnprecfininsajusanexrepu
        End Function
End Class
End Namespace
