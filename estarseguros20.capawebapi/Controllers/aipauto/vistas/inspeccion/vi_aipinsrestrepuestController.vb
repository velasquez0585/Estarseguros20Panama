Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsrestrepuestController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsrestrepuestxid(idaipinsrestrepuest As Decimal) As vi_aipinsrestrepuest
            Dim vi_aipinsrestrepuest As vi_aipinsrestrepuest = (From p In _db.vi_aipinsrestrepuest
                                            Where p.idaipinsrestrepuest = idaipinsrestrepuest
                                            Select p).SingleOrDefault
            Return vi_aipinsrestrepuest
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsrestrepuest() As List(Of vi_aipinsrestrepuest)
		Dim lista_vi_aipinsrestrepuest As List(Of vi_aipinsrestrepuest) = (From p In _db.vi_aipinsrestrepuest
													Select p).ToList
		'
		Return lista_vi_aipinsrestrepuest
	End Function

<HttpPost()> _
	Public Function selvi_aipinsrestrepuestxwheredinamicopag(petivi_aipinsrestrepuestpaglist as petivi_aipinsrestrepuestpaglist) as respvi_aipinsrestrepuestpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.idaipinsrestrepuest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsrestrepuest=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.idaipinsrestrepuest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsrestrepuest=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.idaipinsrestrepuest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.idaipinsrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsrest=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.idaipinsrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsrest=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.idaipinsrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.Expr1 <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.Expr1=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.Expr1))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.Expr1=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.Expr1))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.xnominsrestrepuest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnominsrestrepuest='")
				sb.Append(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.xnominsrestrepuest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnominsrestrepuest='")
				sb.Append(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.xnominsrestrepuest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.iexisinsrestrepuest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iexisinsrestrepuest=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.iexisinsrestrepuest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iexisinsrestrepuest=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.iexisinsrestrepuest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.ibueinsrestrepuest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ibueinsrestrepuest=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.ibueinsrestrepuest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ibueinsrestrepuest=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.ibueinsrestrepuest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.ireginsrestrepuest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ireginsrestrepuest=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.ireginsrestrepuest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ireginsrestrepuest=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.ireginsrestrepuest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.imalinsrestrepuest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.imalinsrestrepuest=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.imalinsrestrepuest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.imalinsrestrepuest=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.imalinsrestrepuest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.iestinsrestrepuest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestinsrestrepuest='")
				sb.Append(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.iestinsrestrepuest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestinsrestrepuest='")
				sb.Append(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.iestinsrestrepuest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.xdescinsrestrepuest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsrestrepuest='")
				sb.Append(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.xdescinsrestrepuest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsrestrepuest='")
				sb.Append(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.xdescinsrestrepuest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsrestrepuestpaglist.vi_aipinsrestrepuest.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsrestrepuestpaglist As New respvi_aipinsrestrepuestpaglist
	respvi_aipinsrestrepuestpaglist.pagvi_aipinsrestrepuest = petivi_aipinsrestrepuestpaglist.pagvi_aipinsrestrepuest
	Dim skip = skip_paginacion(petivi_aipinsrestrepuestpaglist.pagvi_aipinsrestrepuest.npagactual, petivi_aipinsrestrepuestpaglist.pagvi_aipinsrestrepuest.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsrestrepuestpaglist.lista_vi_aipinsrestrepuest = _db.vi_aipinsrestrepuest.OrderBy(petivi_aipinsrestrepuestpaglist.pagvi_aipinsrestrepuest.xcamposord & " "  & petivi_aipinsrestrepuestpaglist.pagvi_aipinsrestrepuest.idirord).Skip(skip).Take(petivi_aipinsrestrepuestpaglist.pagvi_aipinsrestrepuest.npagtamano).ToList
		Else
			respvi_aipinsrestrepuestpaglist.lista_vi_aipinsrestrepuest = _db.vi_aipinsrestrepuest.Where(sb.ToString).OrderBy(petivi_aipinsrestrepuestpaglist.pagvi_aipinsrestrepuest.xcamposord & " "  & petivi_aipinsrestrepuestpaglist.pagvi_aipinsrestrepuest.idirord).Skip(skip).Take(petivi_aipinsrestrepuestpaglist.pagvi_aipinsrestrepuest.npagtamano).ToList
		End If
		'
		If (respvi_aipinsrestrepuestpaglist.lista_vi_aipinsrestrepuest.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsrestrepuestxwheredinamicocount(sb)
		respvi_aipinsrestrepuestpaglist.pagvi_aipinsrestrepuest.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsrestrepuestpaglist.pagvi_aipinsrestrepuest.npagtamano)
		Else
		respvi_aipinsrestrepuestpaglist.pagvi_aipinsrestrepuest.npagcantidad = 0
		respvi_aipinsrestrepuestpaglist.pagvi_aipinsrestrepuest.npagactual = 0
		End If
	
		Return respvi_aipinsrestrepuestpaglist
	End Function

	Public Function selvi_aipinsrestrepuestxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsrestrepuest.count
	Else
	Return _db.vi_aipinsrestrepuest.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinsrestrepuestxidaipinsrest(idaipinsrest As Decimal) As List(Of vi_aipinsrestrepuest)
            Dim lista_vi_aipinsrestrepuest As List(Of vi_aipinsrestrepuest) = (From p In _db.vi_aipinsrestrepuest
                                            Where p.idaipinsrest = idaipinsrest
                                            Select p).ToList
            Return lista_vi_aipinsrestrepuest
        End Function
End Class
End Namespace
