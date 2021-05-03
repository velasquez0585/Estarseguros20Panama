Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinssinrepuController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinssinrepuxid(idaipinssinrepu As Decimal) As vi_aipinssinrepu
            Dim vi_aipinssinrepu As vi_aipinssinrepu = (From p In _db.vi_aipinssinrepu
                                            Where p.idaipinssinrepu = idaipinssinrepu
                                            Select p).SingleOrDefault
            Return vi_aipinssinrepu
        End Function

	<HttpPost()> _
	Public Function selvi_aipinssinrepu() As List(Of vi_aipinssinrepu)
		Dim lista_vi_aipinssinrepu As List(Of vi_aipinssinrepu) = (From p In _db.vi_aipinssinrepu
													Select p).ToList
		'
		Return lista_vi_aipinssinrepu
	End Function

<HttpPost()> _
	Public Function selvi_aipinssinrepuxwheredinamicopag(petivi_aipinssinrepupaglist as petivi_aipinssinrepupaglist) as respvi_aipinssinrepupaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinssinrepupaglist.vi_aipinssinrepu.idaipinssinrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssinrepu=")
				sb.Append(valor_entero(petivi_aipinssinrepupaglist.vi_aipinssinrepu.idaipinssinrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssinrepu=")
				sb.Append(valor_entero(petivi_aipinssinrepupaglist.vi_aipinssinrepu.idaipinssinrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinrepupaglist.vi_aipinssinrepu.idaipinssin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssin=")
				sb.Append(valor_entero(petivi_aipinssinrepupaglist.vi_aipinssinrepu.idaipinssin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssin=")
				sb.Append(valor_entero(petivi_aipinssinrepupaglist.vi_aipinssinrepu.idaipinssin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinrepupaglist.vi_aipinssinrepu.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssinrepupaglist.vi_aipinssinrepu.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssinrepupaglist.vi_aipinssinrepu.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinrepupaglist.vi_aipinssinrepu.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinssinrepupaglist.vi_aipinssinrepu.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinssinrepupaglist.vi_aipinssinrepu.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		
	 '
		If petivi_aipinssinrepupaglist.vi_aipinssinrepu.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinssinrepupaglist.vi_aipinssinrepu.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinssinrepupaglist.vi_aipinssinrepu.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinrepupaglist.vi_aipinssinrepu.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipinssinrepupaglist.vi_aipinssinrepu.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipinssinrepupaglist.vi_aipinssinrepu.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		
		If petivi_aipinssinrepupaglist.vi_aipinssinrepu.ncantinssinrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinssinrepu=")
				sb.Append(valor_entero(petivi_aipinssinrepupaglist.vi_aipinssinrepu.ncantinssinrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinssinrepu=")
				sb.Append(valor_entero(petivi_aipinssinrepupaglist.vi_aipinssinrepu.ncantinssinrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinrepupaglist.vi_aipinssinrepu.nprecfininssinrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininssinrepu=")
				sb.Append(valor_entero(petivi_aipinssinrepupaglist.vi_aipinssinrepu.nprecfininssinrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininssinrepu=")
				sb.Append(valor_entero(petivi_aipinssinrepupaglist.vi_aipinssinrepu.nprecfininssinrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinrepupaglist.vi_aipinssinrepu.xdescinssinrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinssinrepu='")
				sb.Append(petivi_aipinssinrepupaglist.vi_aipinssinrepu.xdescinssinrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinssinrepu='")
				sb.Append(petivi_aipinssinrepupaglist.vi_aipinssinrepu.xdescinssinrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinrepupaglist.vi_aipinssinrepu.iestatinssinrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinssinrepu='")
				sb.Append(petivi_aipinssinrepupaglist.vi_aipinssinrepu.iestatinssinrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinssinrepu='")
				sb.Append(petivi_aipinssinrepupaglist.vi_aipinssinrepu.iestatinssinrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinrepupaglist.vi_aipinssinrepu.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssinrepupaglist.vi_aipinssinrepu.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssinrepupaglist.vi_aipinssinrepu.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinssinrepupaglist As New respvi_aipinssinrepupaglist
	respvi_aipinssinrepupaglist.pagvi_aipinssinrepu = petivi_aipinssinrepupaglist.pagvi_aipinssinrepu
	Dim skip = skip_paginacion(petivi_aipinssinrepupaglist.pagvi_aipinssinrepu.npagactual, petivi_aipinssinrepupaglist.pagvi_aipinssinrepu.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinssinrepupaglist.lista_vi_aipinssinrepu = _db.vi_aipinssinrepu.OrderBy(petivi_aipinssinrepupaglist.pagvi_aipinssinrepu.xcamposord & " "  & petivi_aipinssinrepupaglist.pagvi_aipinssinrepu.idirord).Skip(skip).Take(petivi_aipinssinrepupaglist.pagvi_aipinssinrepu.npagtamano).ToList
		Else
			respvi_aipinssinrepupaglist.lista_vi_aipinssinrepu = _db.vi_aipinssinrepu.Where(sb.ToString).OrderBy(petivi_aipinssinrepupaglist.pagvi_aipinssinrepu.xcamposord & " "  & petivi_aipinssinrepupaglist.pagvi_aipinssinrepu.idirord).Skip(skip).Take(petivi_aipinssinrepupaglist.pagvi_aipinssinrepu.npagtamano).ToList
		End If
		'
		If (respvi_aipinssinrepupaglist.lista_vi_aipinssinrepu.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinssinrepuxwheredinamicocount(sb)
		respvi_aipinssinrepupaglist.pagvi_aipinssinrepu.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinssinrepupaglist.pagvi_aipinssinrepu.npagtamano)
		Else
		respvi_aipinssinrepupaglist.pagvi_aipinssinrepu.npagcantidad = 0
		respvi_aipinssinrepupaglist.pagvi_aipinssinrepu.npagactual = 0
		End If
	
		Return respvi_aipinssinrepupaglist
	End Function

	Public Function selvi_aipinssinrepuxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinssinrepu.count
	Else
	Return _db.vi_aipinssinrepu.Where(sb.ToString).Count
	End If
	End Function


        <HttpPost()> _
        Public Function selvi_aipinssinrepuxidaipinssin(idaipinssin As Decimal) As List(Of vi_aipinssinrepu)
            Dim lista_vi_aipinssinrepu As List(Of vi_aipinssinrepu) = (From p In _db.vi_aipinssinrepu
                                            Where p.idaipinssin = idaipinssin
                                            Select p).ToList
            Return lista_vi_aipinssinrepu
        End Function

        <HttpPost()> _
        Public Function selnprecfininssinrepuxidaipinssin(idaipinssin As Decimal) As Decimal
            Dim nprecfininssinrepu2 As Decimal = (From p In _db.vi_aipinssinrepu
                                            Where p.idaipinssin = idaipinssin
                                            Select p.nprecfininssinrepu).ToList().Sum()
            Return nprecfininssinrepu2
        End Function

        <HttpPost()> _
        Public Function selnprecfinxidaipinssin(idaipinssin As Decimal) As Int32
            Dim ncantinssinrepu2 As Int32 = (From p In _db.vi_aipinssinrepu
                                            Where p.idaipinssin = idaipinssin
                                            Select p).DefaultIfEmpty.Sum(Function(a) a.ncantinssinrepu)
            Return ncantinssinrepu2
        End Function
End Class
End Namespace
