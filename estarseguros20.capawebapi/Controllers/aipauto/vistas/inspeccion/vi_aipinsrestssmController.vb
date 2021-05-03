Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsrestssmController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsrestssmxid(idaipinsrestssm As Decimal) As vi_aipinsrestssm
            Dim vi_aipinsrestssm As vi_aipinsrestssm = (From p In _db.vi_aipinsrestssm
                                            Where p.idaipinsrestssm = idaipinsrestssm
                                            Select p).SingleOrDefault
            Return vi_aipinsrestssm
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsrestssm() As List(Of vi_aipinsrestssm)
		Dim lista_vi_aipinsrestssm As List(Of vi_aipinsrestssm) = (From p In _db.vi_aipinsrestssm
													Select p).ToList
		'
		Return lista_vi_aipinsrestssm
	End Function

<HttpPost()> _
	Public Function selvi_aipinsrestssmxwheredinamicopag(petivi_aipinsrestssmpaglist as petivi_aipinsrestssmpaglist) as respvi_aipinsrestssmpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsrestssmpaglist.vi_aipinsrestssm.idaipinsrestssm <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsrestssm=")
				sb.Append(valor_entero(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.idaipinsrestssm))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsrestssm=")
				sb.Append(valor_entero(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.idaipinsrestssm))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestssmpaglist.vi_aipinsrestssm.idaipinsrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsrest=")
				sb.Append(valor_entero(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.idaipinsrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsrest=")
				sb.Append(valor_entero(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.idaipinsrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestssmpaglist.vi_aipinsrestssm.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestssmpaglist.vi_aipinsrestssm.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestssmpaglist.vi_aipinsrestssm.idaipmanvehssm <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehssm=")
				sb.Append(valor_entero(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.idaipmanvehssm))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehssm=")
				sb.Append(valor_entero(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.idaipmanvehssm))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestssmpaglist.vi_aipinsrestssm.xnommanvehssm <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehssm='")
				sb.Append(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.xnommanvehssm)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehssm='")
				sb.Append(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.xnommanvehssm)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestssmpaglist.vi_aipinsrestssm.iexisinsrestssm <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iexisinsrestssm=")
				sb.Append(valor_entero(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.iexisinsrestssm))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iexisinsrestssm=")
				sb.Append(valor_entero(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.iexisinsrestssm))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestssmpaglist.vi_aipinsrestssm.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsrestssmpaglist.vi_aipinsrestssm.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsrestssmpaglist As New respvi_aipinsrestssmpaglist
	respvi_aipinsrestssmpaglist.pagvi_aipinsrestssm = petivi_aipinsrestssmpaglist.pagvi_aipinsrestssm
	Dim skip = skip_paginacion(petivi_aipinsrestssmpaglist.pagvi_aipinsrestssm.npagactual, petivi_aipinsrestssmpaglist.pagvi_aipinsrestssm.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsrestssmpaglist.lista_vi_aipinsrestssm = _db.vi_aipinsrestssm.OrderBy(petivi_aipinsrestssmpaglist.pagvi_aipinsrestssm.xcamposord & " "  & petivi_aipinsrestssmpaglist.pagvi_aipinsrestssm.idirord).Skip(skip).Take(petivi_aipinsrestssmpaglist.pagvi_aipinsrestssm.npagtamano).ToList
		Else
			respvi_aipinsrestssmpaglist.lista_vi_aipinsrestssm = _db.vi_aipinsrestssm.Where(sb.ToString).OrderBy(petivi_aipinsrestssmpaglist.pagvi_aipinsrestssm.xcamposord & " "  & petivi_aipinsrestssmpaglist.pagvi_aipinsrestssm.idirord).Skip(skip).Take(petivi_aipinsrestssmpaglist.pagvi_aipinsrestssm.npagtamano).ToList
		End If
		'
		If (respvi_aipinsrestssmpaglist.lista_vi_aipinsrestssm.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsrestssmxwheredinamicocount(sb)
		respvi_aipinsrestssmpaglist.pagvi_aipinsrestssm.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsrestssmpaglist.pagvi_aipinsrestssm.npagtamano)
		Else
		respvi_aipinsrestssmpaglist.pagvi_aipinsrestssm.npagcantidad = 0
		respvi_aipinsrestssmpaglist.pagvi_aipinsrestssm.npagactual = 0
		End If
	
		Return respvi_aipinsrestssmpaglist
	End Function

	Public Function selvi_aipinsrestssmxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsrestssm.count
	Else
	Return _db.vi_aipinsrestssm.Where(sb.ToString).Count
	End If
	End Function


        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinsrestssmxidaipinsrest(idaipinsrest As Decimal) As List(Of vi_aipinsrestssm)

            Dim lista_vi_aipinsrestssm As List(Of vi_aipinsrestssm) = (From p In _db.vi_aipinsrestssm
                                            Where p.idaipinsrest = idaipinsrest
                                            Select p).ToList
            Return lista_vi_aipinsrestssm
        End Function

End Class
End Namespace
