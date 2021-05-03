Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_intermediacionController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_intermediacionxid(idintermediacion As Decimal) As vi_intermediacion
            Dim vi_intermediacion As vi_intermediacion = (From p In _db.vi_intermediacion
                                            Where p.idintermediacion = idintermediacion
                                            Select p).SingleOrDefault
            Return vi_intermediacion
        End Function

	<HttpPost()> _
	Public Function selvi_intermediacion() As List(Of vi_intermediacion)
		Dim lista_vi_intermediacion As List(Of vi_intermediacion) = (From p In _db.vi_intermediacion
													Select p).ToList
		'
		Return lista_vi_intermediacion
	End Function

<HttpPost()> _
	Public Function selvi_intermediacionxwheredinamicopag(petivi_intermediacionpaglist as petivi_intermediacionpaglist) as respvi_intermediacionpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_intermediacionpaglist.vi_intermediacion.idintermediacion <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idintermediacion=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.idintermediacion))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idintermediacion=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.idintermediacion))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnominsmotiv <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnominsmotiv='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnominsmotiv)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnominsmotiv='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnominsmotiv)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.iorigeninsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iorigeninsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.iorigeninsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iorigeninsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.iorigeninsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.idsegmanusuperit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusuperit=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.idsegmanusuperit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusuperit=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.idsegmanusuperit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xcedulaperit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedulaperit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xcedulaperit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedulaperit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xcedulaperit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnombresperit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombresperit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombresperit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombresperit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombresperit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xapellidosperit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xapellidosperit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xapellidosperit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xapellidosperit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xapellidosperit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnombrecompletoperit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompletoperit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombrecompletoperit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompletoperit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombrecompletoperit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnombreusuarioperit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombreusuarioperit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombreusuarioperit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombreusuarioperit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombreusuarioperit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.idsegmanorgperit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanorgperit=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.idsegmanorgperit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanorgperit=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.idsegmanorgperit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnombrecomercialperit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecomercialperit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombrecomercialperit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecomercialperit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombrecomercialperit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.idsegmanusuaudit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusuaudit=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.idsegmanusuaudit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusuaudit=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.idsegmanusuaudit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xcedulaaudit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedulaaudit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xcedulaaudit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedulaaudit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xcedulaaudit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnombresaudit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombresaudit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombresaudit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombresaudit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombresaudit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xapellidosaudit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xapellidosaudit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xapellidosaudit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xapellidosaudit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xapellidosaudit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnombrecompletoaudit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompletoaudit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombrecompletoaudit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompletoaudit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombrecompletoaudit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnombreusuarioaudit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombreusuarioaudit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombreusuarioaudit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombreusuarioaudit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombreusuarioaudit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.idsegmanorgaudit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanorgaudit=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.idsegmanorgaudit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanorgaudit=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.idsegmanorgaudit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnombrecomercialaudit <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecomercialaudit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombrecomercialaudit)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecomercialaudit='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnombrecomercialaudit)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xcedpropinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedpropinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xcedpropinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedpropinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xcedpropinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xcedsidoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedsidoinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xcedsidoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedsidoinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xcedsidoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xplacinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xplacinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xplacinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xsermotinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsermotinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xsermotinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsermotinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xsermotinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xsercarrinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsercarrinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xsercarrinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsercarrinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xsercarrinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnumpolinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumpolinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnumpolinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumpolinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnumpolinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnumsininsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumsininsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnumsininsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumsininsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnumsininsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnomprodinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomprodinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnomprodinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomprodinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnomprodinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnomprodtorinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomprodtorinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnomprodtorinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomprodtorinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnomprodtorinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnomramopolizinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomramopolizinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnomramopolizinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomramopolizinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnomramopolizinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnomsucinsinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomsucinsinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnomsucinsinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomsucinsinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnomsucinsinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.fcreainsenc > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.fcreainsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_intermediacionpaglist.vi_intermediacion.fcreainsenc)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.fcreainsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_intermediacionpaglist.vi_intermediacion.fcreainsenc)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.fprocinsenc > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.fprocinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_intermediacionpaglist.vi_intermediacion.fprocinsenc)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.fprocinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_intermediacionpaglist.vi_intermediacion.fprocinsenc)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.faudinsenc > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.faudinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_intermediacionpaglist.vi_intermediacion.faudinsenc)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.faudinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_intermediacionpaglist.vi_intermediacion.faudinsenc)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.fultrechinsenc > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.fultrechinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_intermediacionpaglist.vi_intermediacion.fultrechinsenc)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.fultrechinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_intermediacionpaglist.vi_intermediacion.fultrechinsenc)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.fcancinsenc > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.fcancinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_intermediacionpaglist.vi_intermediacion.fcancinsenc)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.fcancinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_intermediacionpaglist.vi_intermediacion.fcancinsenc)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.facepinsenc > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.facepinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_intermediacionpaglist.vi_intermediacion.facepinsenc)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.facepinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_intermediacionpaglist.vi_intermediacion.facepinsenc)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.iestatinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.iestatinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsenc='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.iestatinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xnomcliactivperi <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomcliactivperi='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnomcliactivperi)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomcliactivperi='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnomcliactivperi)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.xcorreoelectronicoactivperi <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcorreoelectronicoactivperi='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xcorreoelectronicoactivperi)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcorreoelectronicoactivperi='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xcorreoelectronicoactivperi)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.nu_ticket <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nu_ticket=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.nu_ticket))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nu_ticket=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.nu_ticket))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.tipo_operacion <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.tipo_operacion='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.tipo_operacion)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.tipo_operacion='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.tipo_operacion)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.tipo_inspeccion <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.tipo_inspeccion='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.tipo_inspeccion)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.tipo_inspeccion='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.tipo_inspeccion)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
            If petivi_intermediacionpaglist.vi_intermediacion.sucursal <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.sucursal=")
                    sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.sucursal))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.sucursal=")
                        sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.sucursal))
                        sb.Append("")
                    End If
                End If
            End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.siniestro <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.siniestro=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.siniestro))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.siniestro=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.siniestro))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.placa <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.placa='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.placa)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.placa='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.placa)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.serialmotor <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.serialmotor=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.serialmotor))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.serialmotor=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.serialmotor))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.fecha > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.fecha >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_intermediacionpaglist.vi_intermediacion.fecha)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.fecha >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_intermediacionpaglist.vi_intermediacion.fecha)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.estatus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.estatus='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.estatus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.estatus='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.estatus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.usuario <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.usuario='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.usuario)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.usuario='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.usuario)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.origen <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.origen='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.origen)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.origen='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.origen)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.perito <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.perito='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.perito)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.perito='")
				sb.Append(petivi_intermediacionpaglist.vi_intermediacion.perito)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_intermediacionpaglist.vi_intermediacion.nu_cotiza <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nu_cotiza=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.nu_cotiza))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nu_cotiza=")
				sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.nu_cotiza))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_intermediacionpaglist As New respvi_intermediacionpaglist
	respvi_intermediacionpaglist.pagvi_intermediacion = petivi_intermediacionpaglist.pagvi_intermediacion
	Dim skip = skip_paginacion(petivi_intermediacionpaglist.pagvi_intermediacion.npagactual, petivi_intermediacionpaglist.pagvi_intermediacion.npagtamano)
	
		If sb.ToString = "" Then
			respvi_intermediacionpaglist.lista_vi_intermediacion = _db.vi_intermediacion.OrderBy(petivi_intermediacionpaglist.pagvi_intermediacion.xcamposord & " "  & petivi_intermediacionpaglist.pagvi_intermediacion.idirord).Skip(skip).Take(petivi_intermediacionpaglist.pagvi_intermediacion.npagtamano).ToList
		Else
			respvi_intermediacionpaglist.lista_vi_intermediacion = _db.vi_intermediacion.Where(sb.ToString).OrderBy(petivi_intermediacionpaglist.pagvi_intermediacion.xcamposord & " "  & petivi_intermediacionpaglist.pagvi_intermediacion.idirord).Skip(skip).Take(petivi_intermediacionpaglist.pagvi_intermediacion.npagtamano).ToList
		End If
		'
		If (respvi_intermediacionpaglist.lista_vi_intermediacion.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_intermediacionxwheredinamicocount(sb)
		respvi_intermediacionpaglist.pagvi_intermediacion.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_intermediacionpaglist.pagvi_intermediacion.npagtamano)
		Else
		respvi_intermediacionpaglist.pagvi_intermediacion.npagcantidad = 0
		respvi_intermediacionpaglist.pagvi_intermediacion.npagactual = 0
		End If
	
		Return respvi_intermediacionpaglist
	End Function

	Public Function selvi_intermediacionxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_intermediacion.count
	Else
	Return _db.vi_intermediacion.Where(sb.ToString).Count
	End If
        End Function

        'metodos no genericos

        <HttpPost()> _
        Public Function seltotalpend() As Integer
            Dim ntotal As Integer = (From p In _db.vi_intermediacion
                                            Where p.estatus = "AGENDAR" And p.nu_ticket = " "
                                            Select p).ToList().Count()
            Return ntotal
        End Function

        <HttpPost()> _
        Public Function seltotalasig() As Integer
            Dim ntotal As Integer = (From p In _db.vi_intermediacion
                                            Where p.estatus <> "AGENDAR"
                                            Select p).ToList().Count()
            Return ntotal
        End Function


        <HttpPost()> _
        Public Function selexistepend(idintermediacion As Decimal) As Boolean
            Dim iexiste As Boolean = (From p In _db.vi_intermediacion
                                            Where p.idintermediacion = idintermediacion And p.estatus = "AGENDAR" And p.nu_ticket = " "
                                            Select p).Any()
            Return iexiste
        End Function

        <HttpPost()> _
        Public Function selvi_intermediacionpendientepag(petivi_intermediacionpaglist As petivi_intermediacionpaglist) As respvi_intermediacionpaglist
            Dim sb As New StringBuilder("")

            If petivi_intermediacionpaglist.vi_intermediacion.idsegmanorg2 <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanorg2=")
                    sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.idsegmanorg2))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanorg2=")
                        sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.idsegmanorg2))
                        sb.Append("")
                    End If
                End If
            End If
            '
            'If petivi_intermediacionpaglist.vi_intermediacion.siniestro <> 0 Then
            '    If sb.Length = 0 Then
            '        sb.Append("it.siniestro=")
            '        sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.siniestro))
            '        sb.Append("")
            '    Else
            '        If sb.Length > 0 Then
            '            sb.Append(" and it.siniestro=")
            '            sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.siniestro))
            '            sb.Append("")
            '        End If
            '    End If
            'End If
            '
            If petivi_intermediacionpaglist.vi_intermediacion.placa <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.placa='")
                    sb.Append(petivi_intermediacionpaglist.vi_intermediacion.placa)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.placa='")
                        sb.Append(petivi_intermediacionpaglist.vi_intermediacion.placa)
                        sb.Append("'")
                    End If
                End If
            End If

            If sb.Length = 0 Then
                sb.Append("it.nu_ticket='")
                sb.Append(" ")
                sb.Append("'")
            Else
                If sb.Length > 0 Then
                    sb.Append(" and it.nu_ticket='")
                    sb.Append(" ")
                    sb.Append("'")
                End If
            End If

            '
            If sb.Length = 0 Then
                sb.Append("it.estatus='")
                sb.Append("AGENDAR")
                sb.Append("'")
            Else
                If sb.Length > 0 Then
                    sb.Append(" and it.estatus='")
                    sb.Append("AGENDAR")
                    sb.Append("'")
                End If
            End If
            '
            If petivi_intermediacionpaglist.vi_intermediacion.xnumsininsenc <> "" Then
                If IsNumeric(petivi_intermediacionpaglist.vi_intermediacion.xnumsininsenc) Then
                    If sb.Length = 0 Then
                        sb.Append("(it.nu_cotiza=")
                        sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnumsininsenc)
                        sb.Append("")

                        sb.Append(" or it.siniestro=")
                        sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnumsininsenc)
                        sb.Append(" )")

                    Else
                        If sb.Length > 0 Then
                            sb.Append(" and (it.nu_cotiza=")
                            sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnumsininsenc)
                            sb.Append("")

                            sb.Append(" or it.siniestro=")
                            sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnumsininsenc)
                            sb.Append(" )")

                        End If
                    End If
                End If
            End If

            Dim respvi_intermediacionpaglist As New respvi_intermediacionpaglist
            respvi_intermediacionpaglist.pagvi_intermediacion = petivi_intermediacionpaglist.pagvi_intermediacion
            Dim skip = skip_paginacion(petivi_intermediacionpaglist.pagvi_intermediacion.npagactual, petivi_intermediacionpaglist.pagvi_intermediacion.npagtamano)

            If sb.ToString = "" Then
                respvi_intermediacionpaglist.lista_vi_intermediacion = _db.vi_intermediacion.OrderBy(petivi_intermediacionpaglist.pagvi_intermediacion.xcamposord & " " & petivi_intermediacionpaglist.pagvi_intermediacion.idirord).Skip(skip).Take(petivi_intermediacionpaglist.pagvi_intermediacion.npagtamano).ToList
            Else
                respvi_intermediacionpaglist.lista_vi_intermediacion = _db.vi_intermediacion.Where(sb.ToString).OrderBy(petivi_intermediacionpaglist.pagvi_intermediacion.xcamposord & " " & petivi_intermediacionpaglist.pagvi_intermediacion.idirord).Skip(skip).Take(petivi_intermediacionpaglist.pagvi_intermediacion.npagtamano).ToList
            End If
            '
            If (respvi_intermediacionpaglist.lista_vi_intermediacion.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_intermediacionxwheredinamicocount(sb)
                respvi_intermediacionpaglist.pagvi_intermediacion.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_intermediacionpaglist.pagvi_intermediacion.npagtamano)
            Else
                respvi_intermediacionpaglist.pagvi_intermediacion.npagcantidad = 0
                respvi_intermediacionpaglist.pagvi_intermediacion.npagactual = 0
            End If

            Return respvi_intermediacionpaglist
        End Function

        <HttpPost()> _
        Public Function selvi_intermediacionasignadapag(petivi_intermediacionpaglist As petivi_intermediacionpaglist) As respvi_intermediacionpaglist
            Dim sb As New StringBuilder("")

            If petivi_intermediacionpaglist.vi_intermediacion.idsegmanorg2 <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanorg2=")
                    sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.idsegmanorg2))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanorg2=")
                        sb.Append(valor_entero(petivi_intermediacionpaglist.vi_intermediacion.idsegmanorg2))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_intermediacionpaglist.vi_intermediacion.xnumsininsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnumsininsenc='")
                    sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnumsininsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnumsininsenc='")
                        sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xnumsininsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_intermediacionpaglist.vi_intermediacion.xplacinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xplacinsenc='")
                    sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xplacinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xplacinsenc='")
                        sb.Append(petivi_intermediacionpaglist.vi_intermediacion.xplacinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If sb.Length = 0 Then
                sb.Append("it.estatus<>'")
                sb.Append("AGENDAR")
                sb.Append("'")
            Else
                If sb.Length > 0 Then
                    sb.Append(" and it.estatus<>'")
                    sb.Append("AGENDAR")
                    sb.Append("'")
                End If
            End If            

            Dim respvi_intermediacionpaglist As New respvi_intermediacionpaglist
            respvi_intermediacionpaglist.pagvi_intermediacion = petivi_intermediacionpaglist.pagvi_intermediacion
            Dim skip = skip_paginacion(petivi_intermediacionpaglist.pagvi_intermediacion.npagactual, petivi_intermediacionpaglist.pagvi_intermediacion.npagtamano)

            If sb.ToString = "" Then
                respvi_intermediacionpaglist.lista_vi_intermediacion = _db.vi_intermediacion.OrderBy(petivi_intermediacionpaglist.pagvi_intermediacion.xcamposord & " " & petivi_intermediacionpaglist.pagvi_intermediacion.idirord).Skip(skip).Take(petivi_intermediacionpaglist.pagvi_intermediacion.npagtamano).ToList
            Else
                respvi_intermediacionpaglist.lista_vi_intermediacion = _db.vi_intermediacion.Where(sb.ToString).OrderBy(petivi_intermediacionpaglist.pagvi_intermediacion.xcamposord & " " & petivi_intermediacionpaglist.pagvi_intermediacion.idirord).Skip(skip).Take(petivi_intermediacionpaglist.pagvi_intermediacion.npagtamano).ToList
            End If
            '
            If (respvi_intermediacionpaglist.lista_vi_intermediacion.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_intermediacionxwheredinamicocount(sb)
                respvi_intermediacionpaglist.pagvi_intermediacion.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_intermediacionpaglist.pagvi_intermediacion.npagtamano)
            Else
                respvi_intermediacionpaglist.pagvi_intermediacion.npagcantidad = 0
                respvi_intermediacionpaglist.pagvi_intermediacion.npagactual = 0
            End If

            Return respvi_intermediacionpaglist
        End Function

        <HttpPost()> _
        Public Function sellistaxplacapend() As List(Of String)
            Dim lista_placa As List(Of String) = (From p In _db.vi_intermediacion
                                            Where p.estatus = "AGENDAR" And p.nu_ticket = " "
                                            Select p.placa).ToList()
            Return lista_placa
        End Function

End Class
End Namespace
