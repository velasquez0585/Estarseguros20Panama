Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace seginsoft.vistas.controlador
Public Class vi_combosegmanusuController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_combosegmanusuxid(idsegmanusu As Decimal) As vi_combosegmanusu
            Dim vi_combosegmanusu As vi_combosegmanusu = (From p In _db.vi_combosegmanusu
                                            Where p.idsegmanusu = idsegmanusu
                                            Select p).SingleOrDefault
            Return vi_combosegmanusu
        End Function

	<HttpPost()> _
	Public Function selvi_combosegmanusu() As List(Of vi_combosegmanusu)
            Dim lista_vi_combosegmanusu As List(Of vi_combosegmanusu) = (From p In _db.vi_combosegmanusu
                                                        Select p).ToList
            Dim vi_combosegmanusu As New vi_combosegmanusu
            vi_combosegmanusu.idsegmanusu = 0
            vi_combosegmanusu.xnombrecompleto = "SELECCIONE..."


            lista_vi_combosegmanusu.Insert(0, vi_combosegmanusu)
		'
		Return lista_vi_combosegmanusu
	End Function

<HttpPost()> _
	Public Function selvi_combosegmanusuxwheredinamicopag(petivi_combosegmanusupaglist as petivi_combosegmanusupaglist) as respvi_combosegmanusupaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_combosegmanusupaglist.vi_combosegmanusu.idsegmanusu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusu=")
				sb.Append(valor_entero(petivi_combosegmanusupaglist.vi_combosegmanusu.idsegmanusu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusu=")
				sb.Append(valor_entero(petivi_combosegmanusupaglist.vi_combosegmanusu.idsegmanusu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_combosegmanusupaglist.vi_combosegmanusu.xnombrecompleto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompleto='")
				sb.Append(petivi_combosegmanusupaglist.vi_combosegmanusu.xnombrecompleto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompleto='")
				sb.Append(petivi_combosegmanusupaglist.vi_combosegmanusu.xnombrecompleto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_combosegmanusupaglist As New respvi_combosegmanusupaglist
	respvi_combosegmanusupaglist.pagvi_combosegmanusu = petivi_combosegmanusupaglist.pagvi_combosegmanusu
	Dim skip = skip_paginacion(petivi_combosegmanusupaglist.pagvi_combosegmanusu.npagactual, petivi_combosegmanusupaglist.pagvi_combosegmanusu.npagtamano)
	
		If sb.ToString = "" Then
			respvi_combosegmanusupaglist.lista_vi_combosegmanusu = _db.vi_combosegmanusu.OrderBy(petivi_combosegmanusupaglist.pagvi_combosegmanusu.xcamposord & " "  & petivi_combosegmanusupaglist.pagvi_combosegmanusu.idirord).Skip(skip).Take(petivi_combosegmanusupaglist.pagvi_combosegmanusu.npagtamano).ToList
		Else
			respvi_combosegmanusupaglist.lista_vi_combosegmanusu = _db.vi_combosegmanusu.Where(sb.ToString).OrderBy(petivi_combosegmanusupaglist.pagvi_combosegmanusu.xcamposord & " "  & petivi_combosegmanusupaglist.pagvi_combosegmanusu.idirord).Skip(skip).Take(petivi_combosegmanusupaglist.pagvi_combosegmanusu.npagtamano).ToList
		End If
		'
		If (respvi_combosegmanusupaglist.lista_vi_combosegmanusu.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_combosegmanusuxwheredinamicocount(sb)
		respvi_combosegmanusupaglist.pagvi_combosegmanusu.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_combosegmanusupaglist.pagvi_combosegmanusu.npagtamano)
		Else
		respvi_combosegmanusupaglist.pagvi_combosegmanusu.npagcantidad = 0
		respvi_combosegmanusupaglist.pagvi_combosegmanusu.npagactual = 0
		End If
	
		Return respvi_combosegmanusupaglist
	End Function

	Public Function selvi_combosegmanusuxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_combosegmanusu.count
	Else
	Return _db.vi_combosegmanusu.Where(sb.ToString).Count
	End If
	End Function

End Class
End Namespace
