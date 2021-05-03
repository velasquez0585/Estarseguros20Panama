Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.baremo
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_comboaipbaremobrtamaController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        'en este caso no hay por id porque esta vista no tiene un id unico que lo identifique
        '<HttpPost()> _
        'Public Function selvi_comboaipbaremobrtamaxid(idvi_comboaipbaremobrtama As Decimal) As vi_comboaipbaremobrtama
        '	Dim vi_comboaipbaremobrtama As vi_comboaipbaremobrtama = (From p In _db.vi_comboaipbaremobrtama
        '									Where p.idvi_comboaipbaremobrtama = idvi_comboaipbaremobrtama
        '									Select p).SingleOrDefault
        '	Return vi_comboaipbaremobrtama
        'End Function

	<HttpPost()> _
	Public Function selvi_comboaipbaremobrtama() As List(Of vi_comboaipbaremobrtama)
		Dim lista_vi_comboaipbaremobrtama As List(Of vi_comboaipbaremobrtama) = (From p In _db.vi_comboaipbaremobrtama
													Select p).ToList
		'
		Return lista_vi_comboaipbaremobrtama
	End Function

<HttpPost()> _
	Public Function selvi_comboaipbaremobrtamaxwheredinamicopag(petivi_comboaipbaremobrtamapaglist as petivi_comboaipbaremobrtamapaglist) as respvi_comboaipbaremobrtamapaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_comboaipbaremobrtamapaglist.vi_comboaipbaremobrtama.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_comboaipbaremobrtamapaglist.vi_comboaipbaremobrtama.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_comboaipbaremobrtamapaglist.vi_comboaipbaremobrtama.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_comboaipbaremobrtamapaglist.vi_comboaipbaremobrtama.itamapiezbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itamapiezbaremobr='")
				sb.Append(petivi_comboaipbaremobrtamapaglist.vi_comboaipbaremobrtama.itamapiezbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itamapiezbaremobr='")
				sb.Append(petivi_comboaipbaremobrtamapaglist.vi_comboaipbaremobrtama.itamapiezbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_comboaipbaremobrtamapaglist As New respvi_comboaipbaremobrtamapaglist
	respvi_comboaipbaremobrtamapaglist.pagvi_comboaipbaremobrtama = petivi_comboaipbaremobrtamapaglist.pagvi_comboaipbaremobrtama
	Dim skip = skip_paginacion(petivi_comboaipbaremobrtamapaglist.pagvi_comboaipbaremobrtama.npagactual, petivi_comboaipbaremobrtamapaglist.pagvi_comboaipbaremobrtama.npagtamano)
	
		If sb.ToString = "" Then
			respvi_comboaipbaremobrtamapaglist.lista_vi_comboaipbaremobrtama = _db.vi_comboaipbaremobrtama.OrderBy(petivi_comboaipbaremobrtamapaglist.pagvi_comboaipbaremobrtama.xcamposord & " "  & petivi_comboaipbaremobrtamapaglist.pagvi_comboaipbaremobrtama.idirord).Skip(skip).Take(petivi_comboaipbaremobrtamapaglist.pagvi_comboaipbaremobrtama.npagtamano).ToList
		Else
			respvi_comboaipbaremobrtamapaglist.lista_vi_comboaipbaremobrtama = _db.vi_comboaipbaremobrtama.Where(sb.ToString).OrderBy(petivi_comboaipbaremobrtamapaglist.pagvi_comboaipbaremobrtama.xcamposord & " "  & petivi_comboaipbaremobrtamapaglist.pagvi_comboaipbaremobrtama.idirord).Skip(skip).Take(petivi_comboaipbaremobrtamapaglist.pagvi_comboaipbaremobrtama.npagtamano).ToList
		End If
		'
		If (respvi_comboaipbaremobrtamapaglist.lista_vi_comboaipbaremobrtama.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_comboaipbaremobrtamaxwheredinamicocount(sb)
		respvi_comboaipbaremobrtamapaglist.pagvi_comboaipbaremobrtama.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_comboaipbaremobrtamapaglist.pagvi_comboaipbaremobrtama.npagtamano)
		Else
		respvi_comboaipbaremobrtamapaglist.pagvi_comboaipbaremobrtama.npagcantidad = 0
		respvi_comboaipbaremobrtamapaglist.pagvi_comboaipbaremobrtama.npagactual = 0
		End If
	
		Return respvi_comboaipbaremobrtamapaglist
	End Function

	Public Function selvi_comboaipbaremobrtamaxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_comboaipbaremobrtama.count
	Else
	Return _db.vi_comboaipbaremobrtama.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_comboaipbaremobrtamaxidaipmanrepu(idaipmanrepu As Decimal) As List(Of vi_comboaipbaremobrtama)
            Dim lista_vi_comboaipbaremobrtama As List(Of vi_comboaipbaremobrtama) = (From p In _db.vi_comboaipbaremobrtama
                                            Where p.idaipmanrepu = idaipmanrepu
                                            Select p).ToList

            Dim vi_comboaipbaremobrtama As New vi_comboaipbaremobrtama
            vi_comboaipbaremobrtama.idaipmanrepu = 0
            vi_comboaipbaremobrtama.itamapiezbaremobr = "SELECCIONE..."
            lista_vi_comboaipbaremobrtama.Insert(0, vi_comboaipbaremobrtama)

            Return lista_vi_comboaipbaremobrtama
        End Function
End Class
End Namespace
