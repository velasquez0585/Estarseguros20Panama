Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.baremo
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_comboaipbarerepuorigController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        'en este caso no hay por id porque esta vista no tiene un id unico que lo identifique
        '<HttpPost()> _
        'Public Function selvi_comboaipbarerepuorigxid(idvi_comboaipbarerepuorig As Decimal) As vi_comboaipbarerepuorig
        '	Dim vi_comboaipbarerepuorig As vi_comboaipbarerepuorig = (From p In _db.vi_comboaipbarerepuorig
        '									Where p.idvi_comboaipbarerepuorig = idvi_comboaipbarerepuorig
        '									Select p).SingleOrDefault
        '	Return vi_comboaipbarerepuorig
        'End Function

	<HttpPost()> _
	Public Function selvi_comboaipbarerepuorig() As List(Of vi_comboaipbarerepuorig)
		Dim lista_vi_comboaipbarerepuorig As List(Of vi_comboaipbarerepuorig) = (From p In _db.vi_comboaipbarerepuorig
													Select p).ToList
		'
		Return lista_vi_comboaipbarerepuorig
	End Function

<HttpPost()> _
	Public Function selvi_comboaipbarerepuorigxwheredinamicopag(petivi_comboaipbarerepuorigpaglist as petivi_comboaipbarerepuorigpaglist) as respvi_comboaipbarerepuorigpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_comboaipbarerepuorigpaglist.vi_comboaipbarerepuorig.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_comboaipbarerepuorigpaglist.vi_comboaipbarerepuorig.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_comboaipbarerepuorigpaglist.vi_comboaipbarerepuorig.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_comboaipbarerepuorigpaglist.vi_comboaipbarerepuorig.iorigbarerepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iorigbarerepu='")
				sb.Append(petivi_comboaipbarerepuorigpaglist.vi_comboaipbarerepuorig.iorigbarerepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iorigbarerepu='")
				sb.Append(petivi_comboaipbarerepuorigpaglist.vi_comboaipbarerepuorig.iorigbarerepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_comboaipbarerepuorigpaglist As New respvi_comboaipbarerepuorigpaglist
	respvi_comboaipbarerepuorigpaglist.pagvi_comboaipbarerepuorig = petivi_comboaipbarerepuorigpaglist.pagvi_comboaipbarerepuorig
	Dim skip = skip_paginacion(petivi_comboaipbarerepuorigpaglist.pagvi_comboaipbarerepuorig.npagactual, petivi_comboaipbarerepuorigpaglist.pagvi_comboaipbarerepuorig.npagtamano)
	
		If sb.ToString = "" Then
			respvi_comboaipbarerepuorigpaglist.lista_vi_comboaipbarerepuorig = _db.vi_comboaipbarerepuorig.OrderBy(petivi_comboaipbarerepuorigpaglist.pagvi_comboaipbarerepuorig.xcamposord & " "  & petivi_comboaipbarerepuorigpaglist.pagvi_comboaipbarerepuorig.idirord).Skip(skip).Take(petivi_comboaipbarerepuorigpaglist.pagvi_comboaipbarerepuorig.npagtamano).ToList
		Else
			respvi_comboaipbarerepuorigpaglist.lista_vi_comboaipbarerepuorig = _db.vi_comboaipbarerepuorig.Where(sb.ToString).OrderBy(petivi_comboaipbarerepuorigpaglist.pagvi_comboaipbarerepuorig.xcamposord & " "  & petivi_comboaipbarerepuorigpaglist.pagvi_comboaipbarerepuorig.idirord).Skip(skip).Take(petivi_comboaipbarerepuorigpaglist.pagvi_comboaipbarerepuorig.npagtamano).ToList
		End If
		'
		If (respvi_comboaipbarerepuorigpaglist.lista_vi_comboaipbarerepuorig.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_comboaipbarerepuorigxwheredinamicocount(sb)
		respvi_comboaipbarerepuorigpaglist.pagvi_comboaipbarerepuorig.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_comboaipbarerepuorigpaglist.pagvi_comboaipbarerepuorig.npagtamano)
		Else
		respvi_comboaipbarerepuorigpaglist.pagvi_comboaipbarerepuorig.npagcantidad = 0
		respvi_comboaipbarerepuorigpaglist.pagvi_comboaipbarerepuorig.npagactual = 0
		End If
	
		Return respvi_comboaipbarerepuorigpaglist
	End Function

	Public Function selvi_comboaipbarerepuorigxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_comboaipbarerepuorig.count
	Else
	Return _db.vi_comboaipbarerepuorig.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_comboaipbarerepuorigxidaipmanrepu(idaipmanrepu As Decimal) As List(Of vi_comboaipbarerepuorig)
            Dim lista_vi_comboaipbarerepuorig As List(Of vi_comboaipbarerepuorig) = (From p In _db.vi_comboaipbarerepuorig
                                            Where p.idaipmanrepu = idaipmanrepu
                                            Select p).ToList

            Dim vi_comboaipbarerepuorig As New vi_comboaipbarerepuorig
            vi_comboaipbarerepuorig.idaipmanrepu = 0
            vi_comboaipbarerepuorig.iorigbarerepu = "SELECCIONE..."
            lista_vi_comboaipbarerepuorig.Insert(0, vi_comboaipbarerepuorig)

            Return lista_vi_comboaipbarerepuorig
        End Function
End Class
End Namespace
