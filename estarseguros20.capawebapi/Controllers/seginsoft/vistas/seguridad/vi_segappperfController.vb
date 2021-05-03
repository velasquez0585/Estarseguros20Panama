Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace seginsoft.vistas.controlador
Public Class vi_segappperfController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_segappperfxidsegmanapp(idsegmanapp As Decimal) As List(Of vi_segappperf)
            Dim lista_vi_segappperf As List(Of vi_segappperf) = (From p In _db.vi_segappperf
                                                Where p.idsegmanapp = idsegmanapp
                                                Select p).ToList()
            '
            Dim vi_segappperf As New vi_segappperf
            vi_segappperf.idsegappperf = 0
            vi_segappperf.xnombreperf = "SELECCIONE..."

            lista_vi_segappperf.Insert(0, vi_segappperf)
            '
            Return lista_vi_segappperf
        End Function
        
        Public Function selvi_segappperfxid(idsegappperf As Decimal) As vi_segappperf
            Dim vi_segappperf As vi_segappperf = (From p In _db.vi_segappperf
                                            Where p.idsegappperf = idsegappperf
                                            Select p).SingleOrDefault
            Return vi_segappperf
        End Function

	<HttpPost()> _
	Public Function selvi_segappperf() As List(Of vi_segappperf)
		Dim lista_vi_segappperf As List(Of vi_segappperf) = (From p In _db.vi_segappperf
													Select p).ToList
		'
		Return lista_vi_segappperf
	End Function

<HttpPost()> _
	Public Function selvi_segappperfxwheredinamicopag(petivi_segappperfpaglist as petivi_segappperfpaglist) as respvi_segappperfpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_segappperfpaglist.vi_segappperf.idsegappperf <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegappperf=")
				sb.Append(valor_entero(petivi_segappperfpaglist.vi_segappperf.idsegappperf))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegappperf=")
				sb.Append(valor_entero(petivi_segappperfpaglist.vi_segappperf.idsegappperf))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_segappperfpaglist.vi_segappperf.idsegmanapp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanapp=")
				sb.Append(valor_entero(petivi_segappperfpaglist.vi_segappperf.idsegmanapp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanapp=")
				sb.Append(valor_entero(petivi_segappperfpaglist.vi_segappperf.idsegmanapp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_segappperfpaglist.vi_segappperf.xnombrecorto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecorto='")
				sb.Append(petivi_segappperfpaglist.vi_segappperf.xnombrecorto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecorto='")
				sb.Append(petivi_segappperfpaglist.vi_segappperf.xnombrecorto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_segappperfpaglist.vi_segappperf.idsegmanperf <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanperf=")
				sb.Append(valor_entero(petivi_segappperfpaglist.vi_segappperf.idsegmanperf))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanperf=")
				sb.Append(valor_entero(petivi_segappperfpaglist.vi_segappperf.idsegmanperf))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_segappperfpaglist.vi_segappperf.xabrevperf <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xabrevperf='")
				sb.Append(petivi_segappperfpaglist.vi_segappperf.xabrevperf)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xabrevperf='")
				sb.Append(petivi_segappperfpaglist.vi_segappperf.xabrevperf)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_segappperfpaglist.vi_segappperf.xnombreperf <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombreperf='")
				sb.Append(petivi_segappperfpaglist.vi_segappperf.xnombreperf)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombreperf='")
				sb.Append(petivi_segappperfpaglist.vi_segappperf.xnombreperf)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_segappperfpaglist.vi_segappperf.nnivelperf <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nnivelperf=")
				sb.Append(valor_entero(petivi_segappperfpaglist.vi_segappperf.nnivelperf))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nnivelperf=")
				sb.Append(valor_entero(petivi_segappperfpaglist.vi_segappperf.nnivelperf))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_segappperfpaglist.vi_segappperf.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_segappperfpaglist.vi_segappperf.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_segappperfpaglist.vi_segappperf.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_segappperfpaglist As New respvi_segappperfpaglist
	respvi_segappperfpaglist.pagvi_segappperf = petivi_segappperfpaglist.pagvi_segappperf
	Dim skip = skip_paginacion(petivi_segappperfpaglist.pagvi_segappperf.npagactual, petivi_segappperfpaglist.pagvi_segappperf.npagtamano)
	
		If sb.ToString = "" Then
			respvi_segappperfpaglist.lista_vi_segappperf = _db.vi_segappperf.OrderBy(petivi_segappperfpaglist.pagvi_segappperf.xcamposord & " "  & petivi_segappperfpaglist.pagvi_segappperf.idirord).Skip(skip).Take(petivi_segappperfpaglist.pagvi_segappperf.npagtamano).ToList
		Else
			respvi_segappperfpaglist.lista_vi_segappperf = _db.vi_segappperf.Where(sb.ToString).OrderBy(petivi_segappperfpaglist.pagvi_segappperf.xcamposord & " "  & petivi_segappperfpaglist.pagvi_segappperf.idirord).Skip(skip).Take(petivi_segappperfpaglist.pagvi_segappperf.npagtamano).ToList
		End If
		'
		If (respvi_segappperfpaglist.lista_vi_segappperf.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_segappperfxwheredinamicocount(sb)
		respvi_segappperfpaglist.pagvi_segappperf.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_segappperfpaglist.pagvi_segappperf.npagtamano)
		Else
		respvi_segappperfpaglist.pagvi_segappperf.npagcantidad = 0
		respvi_segappperfpaglist.pagvi_segappperf.npagactual = 0
		End If
	
		Return respvi_segappperfpaglist
	End Function

	Public Function selvi_segappperfxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_segappperf.count
	Else
	Return _db.vi_segappperf.Where(sb.ToString).Count
	End If
        End Function

        Public Function selvi_segappperfxapp(ByVal idsegmanapp As Decimal) As List(Of vi_segappperf)
            Dim lista_vi_segappperf As List(Of vi_segappperf) = (From p In _db.vi_segappperf
                                                                 Where p.idsegmanapp = idsegmanapp
                                                                 Order By p.idsegmanperf Ascending
                                                                 Select p).ToList
            '
            Return lista_vi_segappperf
        End Function

        Public Function selvi_segappperfxperf(ByVal idsegmanperf As Decimal) As List(Of vi_segappperf)
            Dim lista_vi_segappperf As List(Of vi_segappperf) = (From p In _db.vi_segappperf
                                                                 Where p.idsegmanperf = idsegmanperf
                                                                 Order By p.idsegmanapp Ascending
                                                                 Select p).ToList
            '
            Return lista_vi_segappperf
        End Function

        Public Function selvi_segappperf_appyperf(ByVal idsegmanapp As Decimal, ByVal idsegmanperf As Decimal) As vi_segappperf
            Dim vi_segappperf As vi_segappperf = (From p In _db.vi_segappperf
                                      Where p.idsegmanapp = idsegmanapp _
                                      And p.idsegmanperf = idsegmanperf
                                      Select p).SingleOrDefault
            '
            Return vi_segappperf
        End Function

        Public Function obtenerperfxapp_count(ByVal idsegmanapp As Decimal) As Decimal
            Dim cantidad As Decimal = (From p In _db.vi_segappperf
                           Where p.idsegmanapp = idsegmanapp
                           Select p).Count()
            '
            Return cantidad
        End Function

        Public Function obtenerperfxapp_pag(skip As Integer, take As Integer, ByVal idsegmanapp As Decimal) As List(Of vi_segappperf)
            Dim lista_vi_segappperf As List(Of vi_segappperf) = (From p In _db.vi_segappperf
                                                     Where p.idsegmanapp = idsegmanapp
                                                     Order By p.idsegmanperf Ascending
                                                     Select p).Skip(skip).Take(take).ToList
            '
            Return lista_vi_segappperf
        End Function


        ''buscar perfiles menos los peritos
        <HttpPost()> _
        Public Function selvi_segappperfxidsegmanappMenosPeritos(idsegmanapp As Decimal) As List(Of vi_segappperf)

            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")
            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")

            Dim lista_vi_segappperf As List(Of vi_segappperf) = (From p In _db.vi_segappperf
                                                Where p.idsegmanapp = idsegmanapp And p.idsegmanperf <> peritoint And p.idsegmanperf <> peritoext
                                                Select p).ToList()
            '
            Dim vi_segappperf As New vi_segappperf
            vi_segappperf.idsegappperf = 0
            vi_segappperf.xnombreperf = "SELECCIONE..."

            lista_vi_segappperf.Insert(0, vi_segappperf)
            '
            Return lista_vi_segappperf
        End Function
    End Class
End Namespace
