Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinssusssmController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinssusssmxid(idaipinssusssm As Decimal) As vi_aipinssusssm
            Dim vi_aipinssusssm As vi_aipinssusssm = (From p In _db.vi_aipinssusssm
                                            Where p.idaipinssusssm = idaipinssusssm
                                            Select p).SingleOrDefault
            Return vi_aipinssusssm
        End Function

	<HttpPost()> _
	Public Function selvi_aipinssusssm() As List(Of vi_aipinssusssm)
		Dim lista_vi_aipinssusssm As List(Of vi_aipinssusssm) = (From p In _db.vi_aipinssusssm
													Select p).ToList
		'
		Return lista_vi_aipinssusssm
	End Function

<HttpPost()> _
	Public Function selvi_aipinssusssmxwheredinamicopag(petivi_aipinssusssmpaglist as petivi_aipinssusssmpaglist) as respvi_aipinssusssmpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinssusssmpaglist.vi_aipinssusssm.idaipinssusssm <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssusssm=")
				sb.Append(valor_entero(petivi_aipinssusssmpaglist.vi_aipinssusssm.idaipinssusssm))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssusssm=")
				sb.Append(valor_entero(petivi_aipinssusssmpaglist.vi_aipinssusssm.idaipinssusssm))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusssmpaglist.vi_aipinssusssm.idaipinssus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssus=")
				sb.Append(valor_entero(petivi_aipinssusssmpaglist.vi_aipinssusssm.idaipinssus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssus=")
				sb.Append(valor_entero(petivi_aipinssusssmpaglist.vi_aipinssusssm.idaipinssus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusssmpaglist.vi_aipinssusssm.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssusssmpaglist.vi_aipinssusssm.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssusssmpaglist.vi_aipinssusssm.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusssmpaglist.vi_aipinssusssm.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinssusssmpaglist.vi_aipinssusssm.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinssusssmpaglist.vi_aipinssusssm.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusssmpaglist.vi_aipinssusssm.idaipmanvehssm <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehssm=")
				sb.Append(valor_entero(petivi_aipinssusssmpaglist.vi_aipinssusssm.idaipmanvehssm))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehssm=")
				sb.Append(valor_entero(petivi_aipinssusssmpaglist.vi_aipinssusssm.idaipmanvehssm))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusssmpaglist.vi_aipinssusssm.xnommanvehssm <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehssm='")
				sb.Append(petivi_aipinssusssmpaglist.vi_aipinssusssm.xnommanvehssm)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehssm='")
				sb.Append(petivi_aipinssusssmpaglist.vi_aipinssusssm.xnommanvehssm)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusssmpaglist.vi_aipinssusssm.iexisinssusssm <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iexisinssusssm=")
				sb.Append(valor_entero(petivi_aipinssusssmpaglist.vi_aipinssusssm.iexisinssusssm))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iexisinssusssm=")
				sb.Append(valor_entero(petivi_aipinssusssmpaglist.vi_aipinssusssm.iexisinssusssm))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssusssmpaglist.vi_aipinssusssm.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssusssmpaglist.vi_aipinssusssm.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssusssmpaglist.vi_aipinssusssm.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinssusssmpaglist As New respvi_aipinssusssmpaglist
	respvi_aipinssusssmpaglist.pagvi_aipinssusssm = petivi_aipinssusssmpaglist.pagvi_aipinssusssm
	Dim skip = skip_paginacion(petivi_aipinssusssmpaglist.pagvi_aipinssusssm.npagactual, petivi_aipinssusssmpaglist.pagvi_aipinssusssm.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinssusssmpaglist.lista_vi_aipinssusssm = _db.vi_aipinssusssm.OrderBy(petivi_aipinssusssmpaglist.pagvi_aipinssusssm.xcamposord & " "  & petivi_aipinssusssmpaglist.pagvi_aipinssusssm.idirord).Skip(skip).Take(petivi_aipinssusssmpaglist.pagvi_aipinssusssm.npagtamano).ToList
		Else
			respvi_aipinssusssmpaglist.lista_vi_aipinssusssm = _db.vi_aipinssusssm.Where(sb.ToString).OrderBy(petivi_aipinssusssmpaglist.pagvi_aipinssusssm.xcamposord & " "  & petivi_aipinssusssmpaglist.pagvi_aipinssusssm.idirord).Skip(skip).Take(petivi_aipinssusssmpaglist.pagvi_aipinssusssm.npagtamano).ToList
		End If
		'
		If (respvi_aipinssusssmpaglist.lista_vi_aipinssusssm.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinssusssmxwheredinamicocount(sb)
		respvi_aipinssusssmpaglist.pagvi_aipinssusssm.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinssusssmpaglist.pagvi_aipinssusssm.npagtamano)
		Else
		respvi_aipinssusssmpaglist.pagvi_aipinssusssm.npagcantidad = 0
		respvi_aipinssusssmpaglist.pagvi_aipinssusssm.npagactual = 0
		End If
	
		Return respvi_aipinssusssmpaglist
	End Function

	Public Function selvi_aipinssusssmxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinssusssm.count
	Else
	Return _db.vi_aipinssusssm.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinssusssmxidaipinssus(idaipinssus As Decimal) As List(Of vi_aipinssusssm)
            Dim lista_vi_aipinssusssm As List(Of vi_aipinssusssm) = (From p In _db.vi_aipinssusssm
                                            Where p.idaipinssus = idaipinssus
                                            Select p).ToList
            Return lista_vi_aipinssusssm
        End Function

End Class
End Namespace
