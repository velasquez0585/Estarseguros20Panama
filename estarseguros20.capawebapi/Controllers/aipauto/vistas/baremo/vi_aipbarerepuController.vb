Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.baremo
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipbarerepuController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipbarerepuxid(idaipbarerepu As Decimal) As vi_aipbarerepu
            Dim vi_aipbarerepu As vi_aipbarerepu = (From p In _db.vi_aipbarerepu
                                            Where p.idaipbarerepu = idaipbarerepu
                                            Select p).SingleOrDefault
            Return vi_aipbarerepu
        End Function

	<HttpPost()> _
	Public Function selvi_aipbarerepu() As List(Of vi_aipbarerepu)
		Dim lista_vi_aipbarerepu As List(Of vi_aipbarerepu) = (From p In _db.vi_aipbarerepu
													Select p).ToList
		'
		Return lista_vi_aipbarerepu
	End Function

<HttpPost()> _
	Public Function selvi_aipbarerepuxwheredinamicopag(petivi_aipbarerepupaglist as petivi_aipbarerepupaglist) as respvi_aipbarerepupaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipbarerepupaglist.vi_aipbarerepu.idaipbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbarerepu=")
				sb.Append(valor_entero(petivi_aipbarerepupaglist.vi_aipbarerepu.idaipbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbarerepu=")
				sb.Append(valor_entero(petivi_aipbarerepupaglist.vi_aipbarerepu.idaipbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipbarerepupaglist.vi_aipbarerepu.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipbarerepupaglist.vi_aipbarerepu.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipbarerepupaglist.vi_aipbarerepu.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipbarerepupaglist.vi_aipbarerepu.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipbarerepupaglist.vi_aipbarerepu.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipbarerepupaglist.vi_aipbarerepu.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipbarerepupaglist.vi_aipbarerepu.faplibarerepu > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.faplibarerepu >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipbarerepupaglist.vi_aipbarerepu.faplibarerepu)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.faplibarerepu >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipbarerepupaglist.vi_aipbarerepu.faplibarerepu)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aipbarerepupaglist.vi_aipbarerepu.iorigbarerepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iorigbarerepu='")
				sb.Append(petivi_aipbarerepupaglist.vi_aipbarerepu.iorigbarerepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iorigbarerepu='")
				sb.Append(petivi_aipbarerepupaglist.vi_aipbarerepu.iorigbarerepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipbarerepupaglist.vi_aipbarerepu.mcostbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mcostbarerepu=")
				sb.Append(valor_entero(petivi_aipbarerepupaglist.vi_aipbarerepu.mcostbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mcostbarerepu=")
				sb.Append(valor_entero(petivi_aipbarerepupaglist.vi_aipbarerepu.mcostbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipbarerepupaglist As New respvi_aipbarerepupaglist
	respvi_aipbarerepupaglist.pagvi_aipbarerepu = petivi_aipbarerepupaglist.pagvi_aipbarerepu
	Dim skip = skip_paginacion(petivi_aipbarerepupaglist.pagvi_aipbarerepu.npagactual, petivi_aipbarerepupaglist.pagvi_aipbarerepu.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipbarerepupaglist.lista_vi_aipbarerepu = _db.vi_aipbarerepu.OrderBy(petivi_aipbarerepupaglist.pagvi_aipbarerepu.xcamposord & " "  & petivi_aipbarerepupaglist.pagvi_aipbarerepu.idirord).Skip(skip).Take(petivi_aipbarerepupaglist.pagvi_aipbarerepu.npagtamano).ToList
		Else
			respvi_aipbarerepupaglist.lista_vi_aipbarerepu = _db.vi_aipbarerepu.Where(sb.ToString).OrderBy(petivi_aipbarerepupaglist.pagvi_aipbarerepu.xcamposord & " "  & petivi_aipbarerepupaglist.pagvi_aipbarerepu.idirord).Skip(skip).Take(petivi_aipbarerepupaglist.pagvi_aipbarerepu.npagtamano).ToList
		End If
		'
		If (respvi_aipbarerepupaglist.lista_vi_aipbarerepu.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipbarerepuxwheredinamicocount(sb)
		respvi_aipbarerepupaglist.pagvi_aipbarerepu.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipbarerepupaglist.pagvi_aipbarerepu.npagtamano)
		Else
		respvi_aipbarerepupaglist.pagvi_aipbarerepu.npagcantidad = 0
		respvi_aipbarerepupaglist.pagvi_aipbarerepu.npagactual = 0
		End If
	
		Return respvi_aipbarerepupaglist
	End Function

	Public Function selvi_aipbarerepuxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipbarerepu.count
	Else
	Return _db.vi_aipbarerepu.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos

        'Notas verificar si se necesita una regla de negocio aqui 
        <HttpPost()> _
        Public Function selvi_aipbarerepuxfapli(faplibarerepu As Date) As List(Of vi_aipbarerepu)
            Dim lista_vi_aipbarerepu As List(Of vi_aipbarerepu) = (From p In _db.vi_aipbarerepu
                                            Where p.faplibarerepu = faplibarerepu
                                            Select p).ToList
            Return lista_vi_aipbarerepu
        End Function

        <HttpPost()> _
        Public Function faplibarerepumax() As Date
            Dim faplibarerepu2 As Date = (From p In _db.vi_aipbarerepu
                                            Select p.faplibarerepu).Max()
            Return faplibarerepu2
        End Function

        <HttpPost()> _
        Public Function selvi_aipbarerepuxfaplipag(faplibarerepu As Date, paginacion As paginacion) As respvi_aipbarerepupaglist
            Dim sb As New StringBuilder("")
            '
            If faplibarerepu > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.faplibarerepu = DATETIME'{0:yyyy-MM-dd HH:mm}'", faplibarerepu)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.faplibarerepu = DATETIME'{0:yyyy-MM-dd HH:mm}'", faplibarerepu)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '

            Dim respvi_aipbarerepupaglist As New respvi_aipbarerepupaglist
            respvi_aipbarerepupaglist.pagvi_aipbarerepu = paginacion
            Dim skip = skip_paginacion(paginacion.npagactual, paginacion.npagtamano)

            If sb.ToString = "" Then
                respvi_aipbarerepupaglist.lista_vi_aipbarerepu = _db.vi_aipbarerepu.OrderBy(paginacion.xcamposord & " " & paginacion.idirord).Skip(skip).Take(paginacion.npagtamano).ToList
            Else
                respvi_aipbarerepupaglist.lista_vi_aipbarerepu = _db.vi_aipbarerepu.Where(sb.ToString).OrderBy(paginacion.xcamposord & " " & paginacion.idirord).Skip(skip).Take(paginacion.npagtamano).ToList
            End If
            '
            If (respvi_aipbarerepupaglist.lista_vi_aipbarerepu.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_aipbarerepuxwheredinamicocount(sb)
                respvi_aipbarerepupaglist.pagvi_aipbarerepu.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipbarerepupaglist.pagvi_aipbarerepu.npagtamano)
            Else
                respvi_aipbarerepupaglist.pagvi_aipbarerepu.npagcantidad = 0
                respvi_aipbarerepupaglist.pagvi_aipbarerepu.npagactual = 0
            End If

            Return respvi_aipbarerepupaglist
        End Function

        <HttpPost()> _
        Public Function selmcostbarerepuxidaipmanrepuyfapliyiorig(idaipmanrepu As Decimal, faplibarerepu As Date, iorigbarerepu As String) As Decimal
            Dim mcostbarerepu2 As Decimal = (From p In _db.vi_aipbarerepu
                                            Where p.idaipmanrepu = idaipmanrepu And p.faplibarerepu = faplibarerepu And p.iorigbarerepu = iorigbarerepu
                                            Select p.mcostbarerepu).SingleOrDefault
            Return mcostbarerepu2
        End Function

        <HttpPost()> _
        Public Function selidaipbarerepuxidaipmanrepuyfapliyiorig(idaipmanrepu As Decimal, faplibarerepu As Date, iorigbarerepu As String) As Decimal
            Dim idaipbarerepu2 As Decimal = (From p In _db.vi_aipbarerepu
                                            Where p.idaipmanrepu = idaipmanrepu And p.faplibarerepu = faplibarerepu And p.iorigbarerepu = iorigbarerepu
                                            Select p.idaipbarerepu).SingleOrDefault
            Return idaipbarerepu2
        End Function
End Class
End Namespace
