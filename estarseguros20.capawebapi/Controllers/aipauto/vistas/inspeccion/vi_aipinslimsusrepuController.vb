Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinslimsusrepuController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinslimsusrepuxid(idaipinslimsusrepu As Decimal) As vi_aipinslimsusrepu
            Dim vi_aipinslimsusrepu As vi_aipinslimsusrepu = (From p In _db.vi_aipinslimsusrepu
                                            Where p.idaipinslimsusrepu = idaipinslimsusrepu
                                            Select p).SingleOrDefault
            Return vi_aipinslimsusrepu
        End Function

	<HttpPost()> _
	Public Function selvi_aipinslimsusrepu() As List(Of vi_aipinslimsusrepu)
		Dim lista_vi_aipinslimsusrepu As List(Of vi_aipinslimsusrepu) = (From p In _db.vi_aipinslimsusrepu
													Select p).ToList
		'
		Return lista_vi_aipinslimsusrepu
	End Function

<HttpPost()> _
	Public Function selvi_aipinslimsusrepuxwheredinamicopag(petivi_aipinslimsusrepupaglist as petivi_aipinslimsusrepupaglist) as respvi_aipinslimsusrepupaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idaipinslimsusrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsusrepu=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idaipinslimsusrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsusrepu=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idaipinslimsusrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idaipinslimsus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsus=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idaipinslimsus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsus=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idaipinslimsus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idaipbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbarerepu=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idaipbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbarerepu=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idaipbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.faplibarerepu > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.faplibarerepu >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.faplibarerepu)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.faplibarerepu >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.faplibarerepu)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.iorigbarerepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iorigbarerepu='")
				sb.Append(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.iorigbarerepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iorigbarerepu='")
				sb.Append(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.iorigbarerepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.mcostbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mcostbarerepu=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.mcostbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mcostbarerepu=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.mcostbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.ncantinslimsusrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinslimsusrepu=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.ncantinslimsusrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinslimsusrepu=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.ncantinslimsusrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.nprecfininslimsusrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininslimsusrepu=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.nprecfininslimsusrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininslimsusrepu=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.nprecfininslimsusrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.xdescinslimsusrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinslimsusrepu='")
				sb.Append(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.xdescinslimsusrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinslimsusrepu='")
				sb.Append(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.xdescinslimsusrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.iestatinslimsusrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinslimsusrepu='")
				sb.Append(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.iestatinslimsusrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinslimsusrepu='")
				sb.Append(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.iestatinslimsusrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinslimsusrepupaglist.vi_aipinslimsusrepu.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinslimsusrepupaglist As New respvi_aipinslimsusrepupaglist
	respvi_aipinslimsusrepupaglist.pagvi_aipinslimsusrepu = petivi_aipinslimsusrepupaglist.pagvi_aipinslimsusrepu
	Dim skip = skip_paginacion(petivi_aipinslimsusrepupaglist.pagvi_aipinslimsusrepu.npagactual, petivi_aipinslimsusrepupaglist.pagvi_aipinslimsusrepu.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinslimsusrepupaglist.lista_vi_aipinslimsusrepu = _db.vi_aipinslimsusrepu.OrderBy(petivi_aipinslimsusrepupaglist.pagvi_aipinslimsusrepu.xcamposord & " "  & petivi_aipinslimsusrepupaglist.pagvi_aipinslimsusrepu.idirord).Skip(skip).Take(petivi_aipinslimsusrepupaglist.pagvi_aipinslimsusrepu.npagtamano).ToList
		Else
			respvi_aipinslimsusrepupaglist.lista_vi_aipinslimsusrepu = _db.vi_aipinslimsusrepu.Where(sb.ToString).OrderBy(petivi_aipinslimsusrepupaglist.pagvi_aipinslimsusrepu.xcamposord & " "  & petivi_aipinslimsusrepupaglist.pagvi_aipinslimsusrepu.idirord).Skip(skip).Take(petivi_aipinslimsusrepupaglist.pagvi_aipinslimsusrepu.npagtamano).ToList
		End If
		'
		If (respvi_aipinslimsusrepupaglist.lista_vi_aipinslimsusrepu.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinslimsusrepuxwheredinamicocount(sb)
		respvi_aipinslimsusrepupaglist.pagvi_aipinslimsusrepu.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinslimsusrepupaglist.pagvi_aipinslimsusrepu.npagtamano)
		Else
		respvi_aipinslimsusrepupaglist.pagvi_aipinslimsusrepu.npagcantidad = 0
		respvi_aipinslimsusrepupaglist.pagvi_aipinslimsusrepu.npagactual = 0
		End If
	
		Return respvi_aipinslimsusrepupaglist
	End Function

	Public Function selvi_aipinslimsusrepuxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinslimsusrepu.count
	Else
	Return _db.vi_aipinslimsusrepu.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinslimsusrepuxidaipinslimsus(idaipinslimsus As Decimal) As List(Of vi_aipinslimsusrepu)
            Dim lista_vi_aipinslimsusrepu As List(Of vi_aipinslimsusrepu) = (From p In _db.vi_aipinslimsusrepu
                                                                             Where p.idaipinslimsus = idaipinslimsus
                                                        Select p).ToList
            '
            Return lista_vi_aipinslimsusrepu
        End Function


        <HttpPost()> _
        Public Function selnprecfininslimsusrepuxidaipinslimsus(idaipinslimsus As Decimal) As Decimal
            Dim totalnprecfininslimsusrepu As Decimal = (From p In _db.vi_aipinslimsusrepu
                                                                             Where p.idaipinslimsus = idaipinslimsus
                                                        Select p.nprecfininslimsusrepu).ToList.Sum
            '
            Return totalnprecfininslimsusrepu
        End Function

End Class
End Namespace
