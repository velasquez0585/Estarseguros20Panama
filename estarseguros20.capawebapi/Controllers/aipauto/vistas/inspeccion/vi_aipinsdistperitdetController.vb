Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsdistperitdetController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsdistperitdetxid(idsegmanusu As Decimal) As vi_aipinsdistperitdet
            Dim vi_aipinsdistperitdet As vi_aipinsdistperitdet = (From p In _db.vi_aipinsdistperitdet
                                            Where p.idsegmanusu = idsegmanusu
                                            Select p).SingleOrDefault
            Return vi_aipinsdistperitdet
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsdistperitdet() As List(Of vi_aipinsdistperitdet)
		Dim lista_vi_aipinsdistperitdet As List(Of vi_aipinsdistperitdet) = (From p In _db.vi_aipinsdistperitdet
													Select p).ToList
		'
		Return lista_vi_aipinsdistperitdet
	End Function

<HttpPost()> _
	Public Function selvi_aipinsdistperitdetxwheredinamicopag(petivi_aipinsdistperitdetpaglist as petivi_aipinsdistperitdetpaglist) as respvi_aipinsdistperitdetpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.idsegmanusu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusu=")
				sb.Append(valor_entero(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.idsegmanusu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusu=")
				sb.Append(valor_entero(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.idsegmanusu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.xnombrecompleto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompleto='")
				sb.Append(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.xnombrecompleto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompleto='")
				sb.Append(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.xnombrecompleto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.xnombreusuario <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombreusuario='")
				sb.Append(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.xnombreusuario)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombreusuario='")
				sb.Append(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.xnombreusuario)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.idsegmanorg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanorg=")
				sb.Append(valor_entero(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.idsegmanorg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanorg=")
				sb.Append(valor_entero(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.idsegmanorg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.idsegmanapp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanapp=")
				sb.Append(valor_entero(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.idsegmanapp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanapp=")
				sb.Append(valor_entero(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.idsegmanapp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.idsegmanperf <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanperf=")
				sb.Append(valor_entero(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.idsegmanperf))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanperf=")
				sb.Append(valor_entero(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.idsegmanperf))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.xnombreperf <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombreperf='")
				sb.Append(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.xnombreperf)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombreperf='")
				sb.Append(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.xnombreperf)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.ibloqueado <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ibloqueado=")
				sb.Append(valor_entero(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.ibloqueado))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ibloqueado=")
				sb.Append(valor_entero(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.ibloqueado))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.ncantinsperit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinsperit=")
				sb.Append(valor_entero(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.ncantinsperit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinsperit=")
				sb.Append(valor_entero(petivi_aipinsdistperitdetpaglist.vi_aipinsdistperitdet.ncantinsperit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsdistperitdetpaglist As New respvi_aipinsdistperitdetpaglist
	respvi_aipinsdistperitdetpaglist.pagvi_aipinsdistperitdet = petivi_aipinsdistperitdetpaglist.pagvi_aipinsdistperitdet
	Dim skip = skip_paginacion(petivi_aipinsdistperitdetpaglist.pagvi_aipinsdistperitdet.npagactual, petivi_aipinsdistperitdetpaglist.pagvi_aipinsdistperitdet.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsdistperitdetpaglist.lista_vi_aipinsdistperitdet = _db.vi_aipinsdistperitdet.OrderBy(petivi_aipinsdistperitdetpaglist.pagvi_aipinsdistperitdet.xcamposord & " "  & petivi_aipinsdistperitdetpaglist.pagvi_aipinsdistperitdet.idirord).Skip(skip).Take(petivi_aipinsdistperitdetpaglist.pagvi_aipinsdistperitdet.npagtamano).ToList
		Else
			respvi_aipinsdistperitdetpaglist.lista_vi_aipinsdistperitdet = _db.vi_aipinsdistperitdet.Where(sb.ToString).OrderBy(petivi_aipinsdistperitdetpaglist.pagvi_aipinsdistperitdet.xcamposord & " "  & petivi_aipinsdistperitdetpaglist.pagvi_aipinsdistperitdet.idirord).Skip(skip).Take(petivi_aipinsdistperitdetpaglist.pagvi_aipinsdistperitdet.npagtamano).ToList
		End If
		'
		If (respvi_aipinsdistperitdetpaglist.lista_vi_aipinsdistperitdet.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsdistperitdetxwheredinamicocount(sb)
		respvi_aipinsdistperitdetpaglist.pagvi_aipinsdistperitdet.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsdistperitdetpaglist.pagvi_aipinsdistperitdet.npagtamano)
		Else
		respvi_aipinsdistperitdetpaglist.pagvi_aipinsdistperitdet.npagcantidad = 0
		respvi_aipinsdistperitdetpaglist.pagvi_aipinsdistperitdet.npagactual = 0
		End If
	
		Return respvi_aipinsdistperitdetpaglist
	End Function

	Public Function selvi_aipinsdistperitdetxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsdistperitdet.count
	Else
	Return _db.vi_aipinsdistperitdet.Where(sb.ToString).Count
	End If
	End Function


        'no automaticos

        ''busco todos los peritos Interno y Lider Sucursal para mostrarlos por sucursal
        <HttpPost()> _
        Public Function selvi_aipinsdistperitdetxperitosinternosylidersuc(idsegmanorg As Decimal) As List(Of vi_aipinsdistperitdet)


            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")
            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")


            Dim lista_vi_aipinsdistperitdet As List(Of vi_aipinsdistperitdet) = (From p In _db.vi_aipinsdistperitdet
                                            Where p.idsegmanorg = idsegmanorg And p.idsegmanapp = idsegmanapp And (p.idsegmanperf = peritols Or p.idsegmanperf = peritoint)
                                            Order By p.idsegmanperf Descending, p.ncantinsperit Ascending
                                            Select p).ToList()
            Return lista_vi_aipinsdistperitdet
        End Function

        ''busco todos los peritos Externos y Lider Sucursal para mostrarlos por sucursal
        <HttpPost()> _
        Public Function selvi_aipinsdistperitdetxperitosexternosylidersuc(idsegmanorg As Decimal) As List(Of vi_aipinsdistperitdet)


            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")
            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")

            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")


            Dim lista_vi_aipinsdistperitdet As List(Of vi_aipinsdistperitdet) = (From p In _db.vi_aipinsdistperitdet
                                            Where p.idsegmanorg = idsegmanorg And p.idsegmanapp = idsegmanapp And (p.idsegmanperf = peritols Or p.idsegmanperf = peritoext)
                                            Order By p.idsegmanperf Descending, p.ncantinsperit Ascending
                                            Select p).ToList()
            Return lista_vi_aipinsdistperitdet
        End Function

        ''busco todos los peritos Externos para mostrarlos por sucursal
        <HttpPost()> _
        Public Function selvi_aipinsdistperitdetxperitosexternos(idsegmanorg As Decimal) As List(Of vi_aipinsdistperitdet)


            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")
            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")

            Dim lista_vi_aipinsdistperitdet As List(Of vi_aipinsdistperitdet) = (From p In _db.vi_aipinsdistperitdet
                                            Where p.idsegmanorg = idsegmanorg And p.idsegmanapp = idsegmanapp And p.idsegmanperf = peritoext
                                            Order By p.idsegmanperf Descending, p.ncantinsperit Ascending
                                            Select p).ToList()
            Return lista_vi_aipinsdistperitdet
        End Function

        ''busco todos los peritos Interno para mostrarlos por sucursal
        <HttpPost()> _
        Public Function selvi_aipinsdistperitdetxperitosinternos(idsegmanorg As Decimal) As List(Of vi_aipinsdistperitdet)


            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")
            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")

            Dim lista_vi_aipinsdistperitdet As List(Of vi_aipinsdistperitdet) = (From p In _db.vi_aipinsdistperitdet
                                            Where p.idsegmanorg = idsegmanorg And p.idsegmanapp = idsegmanapp And p.idsegmanperf = peritoint
                                            Order By p.idsegmanperf Descending, p.ncantinsperit Ascending
                                            Select p).ToList()
            Return lista_vi_aipinsdistperitdet
        End Function

End Class
End Namespace
