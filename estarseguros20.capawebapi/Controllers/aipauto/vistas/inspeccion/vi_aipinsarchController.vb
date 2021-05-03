Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsarchController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsarchxid(idaipinsarch As Decimal) As vi_aipinsarch
            Dim vi_aipinsarch As vi_aipinsarch = (From p In _db.vi_aipinsarch
                                            Where p.idaipinsarch = idaipinsarch
                                            Select p).SingleOrDefault
            Return vi_aipinsarch
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsarch() As List(Of vi_aipinsarch)
		Dim lista_vi_aipinsarch As List(Of vi_aipinsarch) = (From p In _db.vi_aipinsarch
													Select p).ToList
		'
		Return lista_vi_aipinsarch
	End Function

<HttpPost()> _
	Public Function selvi_aipinsarchxwheredinamicopag(petivi_aipinsarchpaglist as petivi_aipinsarchpaglist) as respvi_aipinsarchpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsarchpaglist.vi_aipinsarch.idaipinsarch <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsarch=")
				sb.Append(valor_entero(petivi_aipinsarchpaglist.vi_aipinsarch.idaipinsarch))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsarch=")
				sb.Append(valor_entero(petivi_aipinsarchpaglist.vi_aipinsarch.idaipinsarch))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsarchpaglist.vi_aipinsarch.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsarchpaglist.vi_aipinsarch.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.idsegmanusuperit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusuperit=")
				sb.Append(valor_entero(petivi_aipinsarchpaglist.vi_aipinsarch.idsegmanusuperit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusuperit=")
				sb.Append(valor_entero(petivi_aipinsarchpaglist.vi_aipinsarch.idsegmanusuperit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.xcedpropinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedpropinsenc='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xcedpropinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedpropinsenc='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xcedpropinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.xcedsidoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedsidoinsenc='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xcedsidoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedsidoinsenc='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xcedsidoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.xplacinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacinsenc='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xplacinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacinsenc='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xplacinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.nsecinsarch <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nsecinsarch=")
				sb.Append(valor_entero(petivi_aipinsarchpaglist.vi_aipinsarch.nsecinsarch))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nsecinsarch=")
				sb.Append(valor_entero(petivi_aipinsarchpaglist.vi_aipinsarch.nsecinsarch))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.itipoinsarch <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.itipoinsarch)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.itipoinsarch)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.xrutainsarch <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xrutainsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xrutainsarch)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xrutainsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xrutainsarch)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.xurlinsarch <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xurlinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xurlinsarch)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xurlinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xurlinsarch)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.xtituinsarch <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xtituinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xtituinsarch)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xtituinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xtituinsarch)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.xnominsarch <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnominsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xnominsarch)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnominsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xnominsarch)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.xextinsarch <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xextinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xextinsarch)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xextinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xextinsarch)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.xlatcinsarch <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xlatcinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xlatcinsarch)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xlatcinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xlatcinsarch)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.xlonginsarch <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xlonginsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xlonginsarch)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xlonginsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xlonginsarch)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.mimetypeinsarch <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.mimetypeinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.mimetypeinsarch)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mimetypeinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.mimetypeinsarch)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.ioriginsarch <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.ioriginsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.ioriginsarch)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ioriginsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.ioriginsarch)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.xdescinsarch <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xdescinsarch)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.xdescinsarch)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.iestatinsarch <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.iestatinsarch)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsarch='")
				sb.Append(petivi_aipinsarchpaglist.vi_aipinsarch.iestatinsarch)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.fcreaaipinsarch > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.fcreaaipinsarch >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsarchpaglist.vi_aipinsarch.fcreaaipinsarch)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.fcreaaipinsarch >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsarchpaglist.vi_aipinsarch.fcreaaipinsarch)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aipinsarchpaglist.vi_aipinsarch.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsarchpaglist.vi_aipinsarch.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsarchpaglist.vi_aipinsarch.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsarchpaglist As New respvi_aipinsarchpaglist
	respvi_aipinsarchpaglist.pagvi_aipinsarch = petivi_aipinsarchpaglist.pagvi_aipinsarch
	Dim skip = skip_paginacion(petivi_aipinsarchpaglist.pagvi_aipinsarch.npagactual, petivi_aipinsarchpaglist.pagvi_aipinsarch.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsarchpaglist.lista_vi_aipinsarch = _db.vi_aipinsarch.OrderBy(petivi_aipinsarchpaglist.pagvi_aipinsarch.xcamposord & " "  & petivi_aipinsarchpaglist.pagvi_aipinsarch.idirord).Skip(skip).Take(petivi_aipinsarchpaglist.pagvi_aipinsarch.npagtamano).ToList
		Else
			respvi_aipinsarchpaglist.lista_vi_aipinsarch = _db.vi_aipinsarch.Where(sb.ToString).OrderBy(petivi_aipinsarchpaglist.pagvi_aipinsarch.xcamposord & " "  & petivi_aipinsarchpaglist.pagvi_aipinsarch.idirord).Skip(skip).Take(petivi_aipinsarchpaglist.pagvi_aipinsarch.npagtamano).ToList
		End If
		'
		If (respvi_aipinsarchpaglist.lista_vi_aipinsarch.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsarchxwheredinamicocount(sb)
		respvi_aipinsarchpaglist.pagvi_aipinsarch.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsarchpaglist.pagvi_aipinsarch.npagtamano)
		Else
		respvi_aipinsarchpaglist.pagvi_aipinsarch.npagcantidad = 0
		respvi_aipinsarchpaglist.pagvi_aipinsarch.npagactual = 0
		End If
	
		Return respvi_aipinsarchpaglist
	End Function

	Public Function selvi_aipinsarchxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsarch.count
	Else
	Return _db.vi_aipinsarch.Where(sb.ToString).Count
	End If
	End Function


        ''no personalizados
        <HttpPost()> _
        Public Function ObtenerListaPorEncYTipo(idaipinsenc As Decimal, itipoinsarch As String) As List(Of vi_aipinsarch)
            Dim lista_vi_aipinsarch As List(Of vi_aipinsarch) = (From p In _db.vi_aipinsarch
                                                                 Where p.idaipinsenc = idaipinsenc And p.itipoinsarch = itipoinsarch
                                                                 Order By p.nsecinsarch Ascending
                                                                Select p).ToList
            '
            Return lista_vi_aipinsarch
        End Function

        <HttpPost()> _
        Public Function ObtenerListaPorEncYTipoActivos(idaipinsenc As Decimal, itipoinsarch As String) As List(Of vi_aipinsarch)
            Dim lista_vi_aipinsarch As List(Of vi_aipinsarch) = (From p In _db.vi_aipinsarch
                                                                 Where p.idaipinsenc = idaipinsenc And p.itipoinsarch = itipoinsarch And p.iestatinsarch = "ACTIVO"
                                                                  Order By p.nsecinsarch Ascending
                                                        Select p).ToList
            '
            Return lista_vi_aipinsarch
        End Function

        <HttpPost()> _
        Public Function ExistePorEncActivos(idaipinsenc As Decimal) As Boolean
            Dim existe As Boolean = (From p In _db.vi_aipinsarch
                                                                 Where p.idaipinsenc = idaipinsenc And p.iestatinsarch = "ACTIVO"
                                                        Select p).Any()
            '
            Return existe
        End Function

End Class
End Namespace
