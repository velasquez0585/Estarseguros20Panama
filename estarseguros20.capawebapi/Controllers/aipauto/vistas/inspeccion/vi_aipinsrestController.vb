Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsrestController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsrestxid(idaipinsrest As Decimal) As vi_aipinsrest
            Dim vi_aipinsrest As vi_aipinsrest = (From p In _db.vi_aipinsrest
                                            Where p.idaipinsrest = idaipinsrest
                                            Select p).SingleOrDefault
            Return vi_aipinsrest
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsrest() As List(Of vi_aipinsrest)
		Dim lista_vi_aipinsrest As List(Of vi_aipinsrest) = (From p In _db.vi_aipinsrest
													Select p).ToList
		'
		Return lista_vi_aipinsrest
	End Function

<HttpPost()> _
	Public Function selvi_aipinsrestxwheredinamicopag(petivi_aipinsrestpaglist as petivi_aipinsrestpaglist) as respvi_aipinsrestpaglist
		Dim sb As New StringBuilder("")
		'
            If petivi_aipinsrestpaglist.vi_aipinsrest.idaipinsrest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsrest=")
                    sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idaipinsrest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsrest=")
                        sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idaipinsrest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsrestpaglist.vi_aipinsrest.idaipinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsenc=")
                    sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idaipinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsenc=")
                        sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idaipinsenc))
                        sb.Append("")
                    End If
                End If
            End If

            '
		If petivi_aipinsrestpaglist.vi_aipinsrest.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
            If petivi_aipinsrestpaglist.vi_aipinsrest.idsegmanusuperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuperit=")
                    sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idsegmanusuperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuperit=")
                        sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idsegmanusuperit))
                        sb.Append("")
                    End If
                End If
            End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xcedula <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedula='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xcedula)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedula='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xcedula)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xnombres <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombres='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnombres)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombres='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnombres)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xapellidos <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xapellidos='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xapellidos)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xapellidos='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xapellidos)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xnombrecompleto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompleto='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnombrecompleto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompleto='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnombrecompleto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xcedpropinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedpropinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xcedpropinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedpropinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xcedpropinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xcedsidoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedsidoinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xcedsidoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedsidoinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xcedsidoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xplacinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xplacinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xplacinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xsermotinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsermotinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xsermotinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsermotinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xsermotinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xsercarrinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsercarrinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xsercarrinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsercarrinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xsercarrinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xnumpolinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumpolinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnumpolinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumpolinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnumpolinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xnumsininsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumsininsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnumsininsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumsininsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnumsininsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xllavinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xllavinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xllavinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xllavinsenc='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xllavinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.fcreainsenc > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.fcreainsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsrestpaglist.vi_aipinsrest.fcreainsenc)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.fcreainsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipinsrestpaglist.vi_aipinsrest.fcreainsenc)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.idaipmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idaipmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idaipmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.idaipmanvehmar <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idaipmanvehmar))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idaipmanvehmar))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xnommanvehmar <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmar='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnommanvehmar)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmar='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnommanvehmar)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.idaipmanvehmod <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idaipmanvehmod))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idaipmanvehmod))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xnommanvehmod <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmod='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnommanvehmod)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmod='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnommanvehmod)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.idaipmanvehver <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idaipmanvehver))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idaipmanvehver))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xnommanvehver <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehver='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnommanvehver)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehver='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnommanvehver)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.itipotransmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipotransmanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.itipotransmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipotransmanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.itipotransmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.itipomanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipomanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.itipomanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipomanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.itipomanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.iclasemanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iclasemanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.iclasemanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iclasemanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.iclasemanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.icolormanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.icolormanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.icolormanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.icolormanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.icolormanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xplacamanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacamanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xplacamanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacamanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xplacamanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xsercarrmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsercarrmanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xsercarrmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsercarrmanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xsercarrmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xsermotmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsermotmanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xsermotmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsermotmanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xsermotmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.itraccmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itraccmanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.itraccmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itraccmanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.itraccmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.iimpmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iimpmanveh=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.iimpmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iimpmanveh=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.iimpmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.ncilinmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncilinmanveh=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.ncilinmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncilinmanveh=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.ncilinmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xcargmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcargmanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xcargmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcargmanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xcargmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xcapmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcapmanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xcapmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcapmanveh='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xcapmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xsucuinsrest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsucuinsrest='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xsucuinsrest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsucuinsrest='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xsucuinsrest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.nkiloinsrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nkiloinsrest=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.nkiloinsrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nkiloinsrest=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.nkiloinsrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.idcomunmanestado <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idcomunmanestado=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idcomunmanestado))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idcomunmanestado=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idcomunmanestado))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.idcomunmanlocalid <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idcomunmanlocalid=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idcomunmanlocalid))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idcomunmanlocalid=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idcomunmanlocalid))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xdirinsrest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdirinsrest='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xdirinsrest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdirinsrest='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xdirinsrest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.msumaseginsrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.msumaseginsrest=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.msumaseginsrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.msumaseginsrest=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.msumaseginsrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.msumaseg75insrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.msumaseg75insrest=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.msumaseg75insrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.msumaseg75insrest=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.msumaseg75insrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.mvalinminsrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mvalinminsrest=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.mvalinminsrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mvalinminsrest=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.mvalinminsrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.mdanoinsrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mdanoinsrest=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.mdanoinsrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mdanoinsrest=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.mdanoinsrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.mavalinsrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mavalinsrest=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.mavalinsrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mavalinsrest=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.mavalinsrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xnomtalinsrest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomtalinsrest='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnomtalinsrest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomtalinsrest='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnomtalinsrest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xnomperinsrest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomperinsrest='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnomperinsrest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomperinsrest='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnomperinsrest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xnomjefperinsrest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomjefperinsrest='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnomjefperinsrest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomjefperinsrest='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnomjefperinsrest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xdescinsrest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsrest='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xdescinsrest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsrest='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xdescinsrest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.iestatinsrest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsrest='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.iestatinsrest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsrest='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.iestatinsrest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsrestpaglist.vi_aipinsrest.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xnombreestado <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombreestado='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnombreestado)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombreestado='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnombreestado)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsrestpaglist.vi_aipinsrest.xnombrelocalid <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrelocalid='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnombrelocalid)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrelocalid='")
				sb.Append(petivi_aipinsrestpaglist.vi_aipinsrest.xnombrelocalid)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsrestpaglist As New respvi_aipinsrestpaglist
	respvi_aipinsrestpaglist.pagvi_aipinsrest = petivi_aipinsrestpaglist.pagvi_aipinsrest
	Dim skip = skip_paginacion(petivi_aipinsrestpaglist.pagvi_aipinsrest.npagactual, petivi_aipinsrestpaglist.pagvi_aipinsrest.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsrestpaglist.lista_vi_aipinsrest = _db.vi_aipinsrest.OrderBy(petivi_aipinsrestpaglist.pagvi_aipinsrest.xcamposord & " "  & petivi_aipinsrestpaglist.pagvi_aipinsrest.idirord).Skip(skip).Take(petivi_aipinsrestpaglist.pagvi_aipinsrest.npagtamano).ToList
		Else
			respvi_aipinsrestpaglist.lista_vi_aipinsrest = _db.vi_aipinsrest.Where(sb.ToString).OrderBy(petivi_aipinsrestpaglist.pagvi_aipinsrest.xcamposord & " "  & petivi_aipinsrestpaglist.pagvi_aipinsrest.idirord).Skip(skip).Take(petivi_aipinsrestpaglist.pagvi_aipinsrest.npagtamano).ToList
		End If
		'
		If (respvi_aipinsrestpaglist.lista_vi_aipinsrest.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsrestxwheredinamicocount(sb)
		respvi_aipinsrestpaglist.pagvi_aipinsrest.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsrestpaglist.pagvi_aipinsrest.npagtamano)
		Else
		respvi_aipinsrestpaglist.pagvi_aipinsrest.npagcantidad = 0
		respvi_aipinsrestpaglist.pagvi_aipinsrest.npagactual = 0
		End If
	
		Return respvi_aipinsrestpaglist
	End Function

	Public Function selvi_aipinsrestxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsrest.count
	Else
	Return _db.vi_aipinsrest.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinsrestxidinsenc(idaipinsenc As Decimal) As vi_aipinsrest
            Dim vi_aipinsrest As vi_aipinsrest = (From p In _db.vi_aipinsrest
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).SingleOrDefault
            Return vi_aipinsrest
        End Function
End Class
End Namespace
