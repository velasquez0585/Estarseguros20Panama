Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.baremo
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_comboaipbaremobrmaterController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        'en este caso no hay por id porque esta vista no tiene un id unico que lo identifique
        '<HttpPost()> _
        'Public Function selvi_comboaipbaremobrmaterxid(idaipmanrepu As Decimal) As vi_comboaipbaremobrmater
        '    Dim vi_comboaipbaremobrmater As vi_comboaipbaremobrmater = (From p In _db.vi_comboaipbaremobrmater
        '                                    Where p.idaipmanrepu = idaipmanrepu
        '                                    Select p).SingleOrDefault
        '    Return vi_comboaipbaremobrmater
        'End Function

	<HttpPost()> _
	Public Function selvi_comboaipbaremobrmater() As List(Of vi_comboaipbaremobrmater)
		Dim lista_vi_comboaipbaremobrmater As List(Of vi_comboaipbaremobrmater) = (From p In _db.vi_comboaipbaremobrmater
													Select p).ToList
		'
		Return lista_vi_comboaipbaremobrmater
	End Function

<HttpPost()> _
	Public Function selvi_comboaipbaremobrmaterxwheredinamicopag(petivi_comboaipbaremobrmaterpaglist as petivi_comboaipbaremobrmaterpaglist) as respvi_comboaipbaremobrmaterpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_comboaipbaremobrmaterpaglist.vi_comboaipbaremobrmater.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_comboaipbaremobrmaterpaglist.vi_comboaipbaremobrmater.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_comboaipbaremobrmaterpaglist.vi_comboaipbaremobrmater.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_comboaipbaremobrmaterpaglist.vi_comboaipbaremobrmater.imaterpiezbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.imaterpiezbaremobr='")
				sb.Append(petivi_comboaipbaremobrmaterpaglist.vi_comboaipbaremobrmater.imaterpiezbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.imaterpiezbaremobr='")
				sb.Append(petivi_comboaipbaremobrmaterpaglist.vi_comboaipbaremobrmater.imaterpiezbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_comboaipbaremobrmaterpaglist As New respvi_comboaipbaremobrmaterpaglist
	respvi_comboaipbaremobrmaterpaglist.pagvi_comboaipbaremobrmater = petivi_comboaipbaremobrmaterpaglist.pagvi_comboaipbaremobrmater
	Dim skip = skip_paginacion(petivi_comboaipbaremobrmaterpaglist.pagvi_comboaipbaremobrmater.npagactual, petivi_comboaipbaremobrmaterpaglist.pagvi_comboaipbaremobrmater.npagtamano)
	
		If sb.ToString = "" Then
			respvi_comboaipbaremobrmaterpaglist.lista_vi_comboaipbaremobrmater = _db.vi_comboaipbaremobrmater.OrderBy(petivi_comboaipbaremobrmaterpaglist.pagvi_comboaipbaremobrmater.xcamposord & " "  & petivi_comboaipbaremobrmaterpaglist.pagvi_comboaipbaremobrmater.idirord).Skip(skip).Take(petivi_comboaipbaremobrmaterpaglist.pagvi_comboaipbaremobrmater.npagtamano).ToList
		Else
			respvi_comboaipbaremobrmaterpaglist.lista_vi_comboaipbaremobrmater = _db.vi_comboaipbaremobrmater.Where(sb.ToString).OrderBy(petivi_comboaipbaremobrmaterpaglist.pagvi_comboaipbaremobrmater.xcamposord & " "  & petivi_comboaipbaremobrmaterpaglist.pagvi_comboaipbaremobrmater.idirord).Skip(skip).Take(petivi_comboaipbaremobrmaterpaglist.pagvi_comboaipbaremobrmater.npagtamano).ToList
		End If
		'
		If (respvi_comboaipbaremobrmaterpaglist.lista_vi_comboaipbaremobrmater.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_comboaipbaremobrmaterxwheredinamicocount(sb)
		respvi_comboaipbaremobrmaterpaglist.pagvi_comboaipbaremobrmater.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_comboaipbaremobrmaterpaglist.pagvi_comboaipbaremobrmater.npagtamano)
		Else
		respvi_comboaipbaremobrmaterpaglist.pagvi_comboaipbaremobrmater.npagcantidad = 0
		respvi_comboaipbaremobrmaterpaglist.pagvi_comboaipbaremobrmater.npagactual = 0
		End If
	
		Return respvi_comboaipbaremobrmaterpaglist
	End Function

	Public Function selvi_comboaipbaremobrmaterxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_comboaipbaremobrmater.count
	Else
	Return _db.vi_comboaipbaremobrmater.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automatico
        <HttpPost()> _
        Public Function selvi_comboaipbaremobrmaterxidaipmanrepu(idaipmanrepu As Decimal) As List(Of vi_comboaipbaremobrmater)
            Dim lista_vi_comboaipbaremobrmater As List(Of vi_comboaipbaremobrmater) = (From p In _db.vi_comboaipbaremobrmater
                                            Where p.idaipmanrepu = idaipmanrepu
                                            Select p).ToList

            Dim vi_comboaipbaremobrmater As New vi_comboaipbaremobrmater
            vi_comboaipbaremobrmater.idaipmanrepu = 0
            vi_comboaipbaremobrmater.imaterpiezbaremobr = "SELECCIONE..."
            lista_vi_comboaipbaremobrmater.Insert(0, vi_comboaipbaremobrmater)

            Return lista_vi_comboaipbaremobrmater
        End Function

End Class
End Namespace
