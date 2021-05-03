Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsfotoController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsfotoxid(idaipinsfoto As Decimal) As vi_aipinsfoto
            Dim vi_aipinsfoto As vi_aipinsfoto = (From p In _db.vi_aipinsfoto
                                        Where p.idaipinsfoto = idaipinsfoto
                                        Select p).SingleOrDefault
            Return vi_aipinsfoto
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsfoto() As List(Of vi_aipinsfoto)
		Dim lista_vi_aipinsfoto As List(Of vi_aipinsfoto) = (From p In _db.vi_aipinsfoto
													Select p).ToList
		'
		Return lista_vi_aipinsfoto
	End Function

<HttpPost()> _
	Public Function selvi_aipinsfotoxwheredinamicopag(petivi_aipinsfotopaglist as petivi_aipinsfotopaglist) as respvi_aipinsfotopaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsfotopaglist.vi_aipinsfoto.idaipinsfoto <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsfoto=")
				sb.Append(valor_entero(petivi_aipinsfotopaglist.vi_aipinsfoto.idaipinsfoto))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsfoto=")
				sb.Append(valor_entero(petivi_aipinsfotopaglist.vi_aipinsfoto.idaipinsfoto))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsfotopaglist.vi_aipinsfoto.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsfotopaglist.vi_aipinsfoto.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
            If petivi_aipinsfotopaglist.vi_aipinsfoto.idsegmanusuperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuperit=")
                    sb.Append(valor_entero(petivi_aipinsfotopaglist.vi_aipinsfoto.idsegmanusuperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuperit=")
                        sb.Append(valor_entero(petivi_aipinsfotopaglist.vi_aipinsfoto.idsegmanusuperit))
                        sb.Append("")
                    End If
                End If
            End If
	 '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.xcedpropinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedpropinsenc='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xcedpropinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedpropinsenc='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xcedpropinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.xcedsidoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedsidoinsenc='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xcedsidoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedsidoinsenc='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xcedsidoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.xplacinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacinsenc='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xplacinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacinsenc='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xplacinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.nsecinsfoto <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nsecinsfoto=")
				sb.Append(valor_entero(petivi_aipinsfotopaglist.vi_aipinsfoto.nsecinsfoto))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nsecinsfoto=")
				sb.Append(valor_entero(petivi_aipinsfotopaglist.vi_aipinsfoto.nsecinsfoto))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.xrutainsfoto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xrutainsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xrutainsfoto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xrutainsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xrutainsfoto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.xurlinsfoto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xurlinsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xurlinsfoto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xurlinsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xurlinsfoto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.xtituinsfoto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xtituinsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xtituinsfoto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xtituinsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xtituinsfoto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.xnomarchinsfoto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomarchinsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xnomarchinsfoto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomarchinsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xnomarchinsfoto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.xextinsfoto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xextinsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xextinsfoto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xextinsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xextinsfoto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.xlatcinsfoto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xlatcinsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xlatcinsfoto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xlatcinsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xlatcinsfoto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.xlonginsfoto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xlonginsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xlonginsfoto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xlonginsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xlonginsfoto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.xdescinsfoto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xdescinsfoto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.xdescinsfoto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.iestatinsfoto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.iestatinsfoto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsfoto='")
				sb.Append(petivi_aipinsfotopaglist.vi_aipinsfoto.iestatinsfoto)
				sb.Append("'")
	        End If
	    End If
	End If
            '
            If petivi_aipinsfotopaglist.vi_aipinsfoto.fcreaaipinsfoto > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fcreaaipinsfoto >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsfotopaglist.vi_aipinsfoto.fcreaaipinsfoto)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fcreaaipinsfoto >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsfotopaglist.vi_aipinsfoto.fcreaaipinsfoto)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
		If petivi_aipinsfotopaglist.vi_aipinsfoto.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsfotopaglist.vi_aipinsfoto.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsfotopaglist.vi_aipinsfoto.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsfotopaglist As New respvi_aipinsfotopaglist
	respvi_aipinsfotopaglist.pagvi_aipinsfoto = petivi_aipinsfotopaglist.pagvi_aipinsfoto
	Dim skip = skip_paginacion(petivi_aipinsfotopaglist.pagvi_aipinsfoto.npagactual, petivi_aipinsfotopaglist.pagvi_aipinsfoto.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsfotopaglist.lista_vi_aipinsfoto = _db.vi_aipinsfoto.OrderBy(petivi_aipinsfotopaglist.pagvi_aipinsfoto.xcamposord & " "  & petivi_aipinsfotopaglist.pagvi_aipinsfoto.idirord).Skip(skip).Take(petivi_aipinsfotopaglist.pagvi_aipinsfoto.npagtamano).ToList
		Else
			respvi_aipinsfotopaglist.lista_vi_aipinsfoto = _db.vi_aipinsfoto.Where(sb.ToString).OrderBy(petivi_aipinsfotopaglist.pagvi_aipinsfoto.xcamposord & " "  & petivi_aipinsfotopaglist.pagvi_aipinsfoto.idirord).Skip(skip).Take(petivi_aipinsfotopaglist.pagvi_aipinsfoto.npagtamano).ToList
		End If
		'
		If (respvi_aipinsfotopaglist.lista_vi_aipinsfoto.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsfotoxwheredinamicocount(sb)
		respvi_aipinsfotopaglist.pagvi_aipinsfoto.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsfotopaglist.pagvi_aipinsfoto.npagtamano)
		Else
		respvi_aipinsfotopaglist.pagvi_aipinsfoto.npagcantidad = 0
		respvi_aipinsfotopaglist.pagvi_aipinsfoto.npagactual = 0
		End If
	
		Return respvi_aipinsfotopaglist
	End Function

	Public Function selvi_aipinsfotoxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsfoto.count
	Else
	Return _db.vi_aipinsfoto.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinsfotoxidaipinsencynsecinsfoto(idaipinsenc As Decimal, nsecinsfoto As Short) As vi_aipinsfoto
            Dim vi_aipinsfoto As vi_aipinsfoto = (From p In _db.vi_aipinsfoto
                                            Where p.idaipinsenc = idaipinsenc And p.nsecinsfoto
                                            Select p).SingleOrDefault
            Return vi_aipinsfoto
        End Function

        <HttpPost()> _
        Public Function selvi_aipinsfotoxidaipinsenc(idaipinsenc As Decimal) As List(Of vi_aipinsfoto)
            Dim lista_vi_aipinsfoto As List(Of vi_aipinsfoto) = (From p In _db.vi_aipinsfoto
                                            Where p.idaipinsenc = idaipinsenc
                                            Order By p.nsecinsfoto
                                            Select p).ToList
            Return lista_vi_aipinsfoto
        End Function

        <HttpPost()> _
        Public Function selvi_aipinsfotoxididaipinsencandxnomarchinsfoto(idaipinsenc As Decimal, xnomarchinsfoto As String) As vi_aipinsfoto
            Dim vi_aipinsfoto As vi_aipinsfoto = (From p In _db.vi_aipinsfoto
                                            Where p.idaipinsenc = idaipinsenc And p.xnomarchinsfoto = xnomarchinsfoto
                                            Select p).SingleOrDefault
            Return vi_aipinsfoto
        End Function

        <HttpPost()> _
        Public Function selaipinsfotoxidaipinsencyxnomarchinsfoto(idaipinsenc As Decimal, xnomarchinsfoto As String) As vi_aipinsfoto
            Dim vi_aipinsfoto As vi_aipinsfoto = (From p In _db.vi_aipinsfoto
                                            Where p.idaipinsenc = idaipinsenc And p.xnomarchinsfoto = xnomarchinsfoto
                                            Select p).SingleOrDefault
            Return vi_aipinsfoto
        End Function

End Class
End Namespace
