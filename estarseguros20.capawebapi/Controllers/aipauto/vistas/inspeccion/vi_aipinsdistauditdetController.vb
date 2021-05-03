Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsdistauditdetController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsdistauditdetxid(idsegmanusu As Decimal) As vi_aipinsdistauditdet
            Dim vi_aipinsdistauditdet As vi_aipinsdistauditdet = (From p In _db.vi_aipinsdistauditdet
                                            Where p.idsegmanusu = idsegmanusu
                                            Select p).SingleOrDefault
            Return vi_aipinsdistauditdet
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsdistauditdet() As List(Of vi_aipinsdistauditdet)
		Dim lista_vi_aipinsdistauditdet As List(Of vi_aipinsdistauditdet) = (From p In _db.vi_aipinsdistauditdet
													Select p).ToList
		'
		Return lista_vi_aipinsdistauditdet
	End Function

<HttpPost()> _
	Public Function selvi_aipinsdistauditdetxwheredinamicopag(petivi_aipinsdistauditdetpaglist as petivi_aipinsdistauditdetpaglist) as respvi_aipinsdistauditdetpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.idsegmanusu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusu=")
				sb.Append(valor_entero(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.idsegmanusu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusu=")
				sb.Append(valor_entero(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.idsegmanusu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.xnombrecompleto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompleto='")
				sb.Append(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.xnombrecompleto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompleto='")
				sb.Append(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.xnombrecompleto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.xnombreusuario <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombreusuario='")
				sb.Append(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.xnombreusuario)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombreusuario='")
				sb.Append(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.xnombreusuario)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.idsegmanorg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanorg=")
				sb.Append(valor_entero(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.idsegmanorg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanorg=")
				sb.Append(valor_entero(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.idsegmanorg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.idsegmanapp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanapp=")
				sb.Append(valor_entero(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.idsegmanapp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanapp=")
				sb.Append(valor_entero(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.idsegmanapp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.idsegmanperf <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanperf=")
				sb.Append(valor_entero(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.idsegmanperf))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanperf=")
				sb.Append(valor_entero(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.idsegmanperf))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.xnombreperf <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombreperf='")
				sb.Append(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.xnombreperf)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombreperf='")
				sb.Append(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.xnombreperf)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.ibloqueado <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ibloqueado=")
				sb.Append(valor_entero(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.ibloqueado))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ibloqueado=")
				sb.Append(valor_entero(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.ibloqueado))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.ncantinsperit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinsperit=")
				sb.Append(valor_entero(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.ncantinsperit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinsperit=")
				sb.Append(valor_entero(petivi_aipinsdistauditdetpaglist.vi_aipinsdistauditdet.ncantinsperit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsdistauditdetpaglist As New respvi_aipinsdistauditdetpaglist
	respvi_aipinsdistauditdetpaglist.pagvi_aipinsdistauditdet = petivi_aipinsdistauditdetpaglist.pagvi_aipinsdistauditdet
	Dim skip = skip_paginacion(petivi_aipinsdistauditdetpaglist.pagvi_aipinsdistauditdet.npagactual, petivi_aipinsdistauditdetpaglist.pagvi_aipinsdistauditdet.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsdistauditdetpaglist.lista_vi_aipinsdistauditdet = _db.vi_aipinsdistauditdet.OrderBy(petivi_aipinsdistauditdetpaglist.pagvi_aipinsdistauditdet.xcamposord & " "  & petivi_aipinsdistauditdetpaglist.pagvi_aipinsdistauditdet.idirord).Skip(skip).Take(petivi_aipinsdistauditdetpaglist.pagvi_aipinsdistauditdet.npagtamano).ToList
		Else
			respvi_aipinsdistauditdetpaglist.lista_vi_aipinsdistauditdet = _db.vi_aipinsdistauditdet.Where(sb.ToString).OrderBy(petivi_aipinsdistauditdetpaglist.pagvi_aipinsdistauditdet.xcamposord & " "  & petivi_aipinsdistauditdetpaglist.pagvi_aipinsdistauditdet.idirord).Skip(skip).Take(petivi_aipinsdistauditdetpaglist.pagvi_aipinsdistauditdet.npagtamano).ToList
		End If
		'
		If (respvi_aipinsdistauditdetpaglist.lista_vi_aipinsdistauditdet.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsdistauditdetxwheredinamicocount(sb)
		respvi_aipinsdistauditdetpaglist.pagvi_aipinsdistauditdet.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsdistauditdetpaglist.pagvi_aipinsdistauditdet.npagtamano)
		Else
		respvi_aipinsdistauditdetpaglist.pagvi_aipinsdistauditdet.npagcantidad = 0
		respvi_aipinsdistauditdetpaglist.pagvi_aipinsdistauditdet.npagactual = 0
		End If
	
		Return respvi_aipinsdistauditdetpaglist
	End Function

	Public Function selvi_aipinsdistauditdetxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsdistauditdet.count
	Else
	Return _db.vi_aipinsdistauditdet.Where(sb.ToString).Count
	End If
	End Function


        'no automaticos

        ''busco todos los auditores y Lideres para mostrarlos por sucursal
        Public Function selvi_aipinsdistauditdetauditoresylideres(idsegmanorg As Decimal) As List(Of vi_aipinsdistauditdet)


            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")
            Dim auditorlp As Decimal = ConfigurationManager.AppSettings("auditorlp")
            Dim auditorls As Decimal = ConfigurationManager.AppSettings("auditorls")
            Dim auditor As Decimal = ConfigurationManager.AppSettings("auditor")

            'se buscar donde la aplicacion sea aipauto y donde el el perfil sea de auditor lider princiapal, o organizacion enviada y lider sucursal
            'o donde sea la organizacion y auditor 
            Dim lista_vi_aipinsdistauditdet As List(Of vi_aipinsdistauditdet) = (From p In _db.vi_aipinsdistauditdet
                                                                Where p.idsegmanapp = idsegmanapp And ((p.idsegmanperf = auditorlp) _
                                                                Or (p.idsegmanorg = idsegmanorg And p.idsegmanperf = auditorls) _
                                                                Or (p.idsegmanorg = idsegmanorg And p.idsegmanperf = auditor))
                        Order By p.idsegmanperf Ascending, p.ncantinsperit Ascending
                        Select p).ToList()
            Return lista_vi_aipinsdistauditdet
        End Function

        ''busco todos los auditores y Lideres para mostrarlos por sucursal
        Public Function selvi_aipinsdistauditdetauditoresyliderSuc(idsegmanorg As Decimal) As List(Of vi_aipinsdistauditdet)


            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")
            Dim auditorls As Decimal = ConfigurationManager.AppSettings("auditorls")
            Dim auditor As Decimal = ConfigurationManager.AppSettings("auditor")

            'se buscar donde la aplicacion sea aipauto y donde el el perfil sea de auditor lider princiapal, o organizacion enviada y lider sucursal
            'o donde sea la organizacion y auditor 
            Dim lista_vi_aipinsdistauditdet As List(Of vi_aipinsdistauditdet) = (From p In _db.vi_aipinsdistauditdet
                                                                Where p.idsegmanapp = idsegmanapp And p.idsegmanorg = idsegmanorg _
                                                                And (p.idsegmanperf = auditorls Or p.idsegmanperf = auditor)
                        Order By p.idsegmanperf Ascending, p.ncantinsperit Ascending
                        Select p).ToList()
            Return lista_vi_aipinsdistauditdet
        End Function

        'se buscan solo los auditores por sucursal
        Public Function selvi_aipinsdistauditdetauditores(idsegmanorg As Decimal) As List(Of vi_aipinsdistauditdet)


            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")
            Dim auditorlp As Decimal = ConfigurationManager.AppSettings("auditorlp")
            Dim auditorls As Decimal = ConfigurationManager.AppSettings("auditorls")
            Dim auditor As Decimal = ConfigurationManager.AppSettings("auditor")

            'se buscar donde la aplicacion sea aipauto y donde el el perfil sea de auditor lider princiapal, o organizacion enviada y lider sucursal
            'o donde sea la organizacion y auditor 
            Dim lista_vi_aipinsdistauditdet As List(Of vi_aipinsdistauditdet) = (From p In _db.vi_aipinsdistauditdet
                                                                Where p.idsegmanorg = idsegmanorg And p.idsegmanapp = idsegmanapp And p.idsegmanperf = auditor
                        Order By p.idsegmanperf Ascending, p.ncantinsperit Ascending
                        Select p).ToList()
            Return lista_vi_aipinsdistauditdet
        End Function
End Class
End Namespace
