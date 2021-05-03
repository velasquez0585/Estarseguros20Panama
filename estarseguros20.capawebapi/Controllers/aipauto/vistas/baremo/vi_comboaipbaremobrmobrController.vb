Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.baremo
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_comboaipbaremobrmobrController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        'en este caso no hay por id porque esta vista no tiene un id unico que lo identifique
        '<HttpPost()> _
        'Public Function selvi_comboaipbaremobrmobrxid(idvi_comboaipbaremobrmobr As Decimal) As vi_comboaipbaremobrmobr
        '	Dim vi_comboaipbaremobrmobr As vi_comboaipbaremobrmobr = (From p In _db.vi_comboaipbaremobrmobr
        '									Where p.idvi_comboaipbaremobrmobr = idvi_comboaipbaremobrmobr
        '									Select p).SingleOrDefault
        '	Return vi_comboaipbaremobrmobr
        'End Function

	<HttpPost()> _
	Public Function selvi_comboaipbaremobrmobr() As List(Of vi_comboaipbaremobrmobr)
		Dim lista_vi_comboaipbaremobrmobr As List(Of vi_comboaipbaremobrmobr) = (From p In _db.vi_comboaipbaremobrmobr
													Select p).ToList
		'
		Return lista_vi_comboaipbaremobrmobr
	End Function

<HttpPost()> _
	Public Function selvi_comboaipbaremobrmobrxwheredinamicopag(petivi_comboaipbaremobrmobrpaglist as petivi_comboaipbaremobrmobrpaglist) as respvi_comboaipbaremobrmobrpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_comboaipbaremobrmobrpaglist.vi_comboaipbaremobrmobr.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_comboaipbaremobrmobrpaglist.vi_comboaipbaremobrmobr.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_comboaipbaremobrmobrpaglist.vi_comboaipbaremobrmobr.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_comboaipbaremobrmobrpaglist.vi_comboaipbaremobrmobr.itipobaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipobaremobr='")
				sb.Append(petivi_comboaipbaremobrmobrpaglist.vi_comboaipbaremobrmobr.itipobaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipobaremobr='")
				sb.Append(petivi_comboaipbaremobrmobrpaglist.vi_comboaipbaremobrmobr.itipobaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_comboaipbaremobrmobrpaglist As New respvi_comboaipbaremobrmobrpaglist
	respvi_comboaipbaremobrmobrpaglist.pagvi_comboaipbaremobrmobr = petivi_comboaipbaremobrmobrpaglist.pagvi_comboaipbaremobrmobr
	Dim skip = skip_paginacion(petivi_comboaipbaremobrmobrpaglist.pagvi_comboaipbaremobrmobr.npagactual, petivi_comboaipbaremobrmobrpaglist.pagvi_comboaipbaremobrmobr.npagtamano)
	
		If sb.ToString = "" Then
			respvi_comboaipbaremobrmobrpaglist.lista_vi_comboaipbaremobrmobr = _db.vi_comboaipbaremobrmobr.OrderBy(petivi_comboaipbaremobrmobrpaglist.pagvi_comboaipbaremobrmobr.xcamposord & " "  & petivi_comboaipbaremobrmobrpaglist.pagvi_comboaipbaremobrmobr.idirord).Skip(skip).Take(petivi_comboaipbaremobrmobrpaglist.pagvi_comboaipbaremobrmobr.npagtamano).ToList
		Else
			respvi_comboaipbaremobrmobrpaglist.lista_vi_comboaipbaremobrmobr = _db.vi_comboaipbaremobrmobr.Where(sb.ToString).OrderBy(petivi_comboaipbaremobrmobrpaglist.pagvi_comboaipbaremobrmobr.xcamposord & " "  & petivi_comboaipbaremobrmobrpaglist.pagvi_comboaipbaremobrmobr.idirord).Skip(skip).Take(petivi_comboaipbaremobrmobrpaglist.pagvi_comboaipbaremobrmobr.npagtamano).ToList
		End If
		'
		If (respvi_comboaipbaremobrmobrpaglist.lista_vi_comboaipbaremobrmobr.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_comboaipbaremobrmobrxwheredinamicocount(sb)
		respvi_comboaipbaremobrmobrpaglist.pagvi_comboaipbaremobrmobr.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_comboaipbaremobrmobrpaglist.pagvi_comboaipbaremobrmobr.npagtamano)
		Else
		respvi_comboaipbaremobrmobrpaglist.pagvi_comboaipbaremobrmobr.npagcantidad = 0
		respvi_comboaipbaremobrmobrpaglist.pagvi_comboaipbaremobrmobr.npagactual = 0
		End If
	
		Return respvi_comboaipbaremobrmobrpaglist
	End Function

	Public Function selvi_comboaipbaremobrmobrxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_comboaipbaremobrmobr.count
	Else
	Return _db.vi_comboaipbaremobrmobr.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_comboaipbaremobrmobrxidaipmanrepu(idaipmanrepu As Decimal) As List(Of vi_comboaipbaremobrmobr)
            Dim lista_vi_comboaipbaremobrmobr As List(Of vi_comboaipbaremobrmobr) = (From p In _db.vi_comboaipbaremobrmobr
                                            Where p.idaipmanrepu = idaipmanrepu
                                            Select p).ToList

            Dim vi_comboaipbaremobrmobr As New vi_comboaipbaremobrmobr
            vi_comboaipbaremobrmobr.idaipmanrepu = 0
            vi_comboaipbaremobrmobr.itipobaremobr = "SELECCIONE..."
            lista_vi_comboaipbaremobrmobr.Insert(0, vi_comboaipbaremobrmobr)

            Return lista_vi_comboaipbaremobrmobr
        End Function
End Class
End Namespace
