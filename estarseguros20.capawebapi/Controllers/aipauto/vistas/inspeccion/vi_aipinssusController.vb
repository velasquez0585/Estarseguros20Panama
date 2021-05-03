Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinssusController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinssusxid(idaipinssus As Decimal) As vi_aipinssus
            Dim vi_aipinssus As vi_aipinssus = (From p In _db.vi_aipinssus
                                            Where p.idaipinssus = idaipinssus
                                            Select p).SingleOrDefault
            Return vi_aipinssus
        End Function

	<HttpPost()> _
	Public Function selvi_aipinssus() As List(Of vi_aipinssus)
		Dim lista_vi_aipinssus As List(Of vi_aipinssus) = (From p In _db.vi_aipinssus
													Select p).ToList
		'
		Return lista_vi_aipinssus
	End Function

<HttpPost()> _
	Public Function selvi_aipinssusxwheredinamicopag(petivi_aipinssuspaglist as petivi_aipinssuspaglist) as respvi_aipinssuspaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinssuspaglist.vi_aipinssus.idaipinssus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssus=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idaipinssus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssus=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idaipinssus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
            If petivi_aipinssuspaglist.vi_aipinssus.idsegmanusuperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuperit=")
                    sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idsegmanusuperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuperit=")
                        sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idsegmanusuperit))
                        sb.Append("")
                    End If
                End If
            End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xcedula <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedula='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xcedula)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedula='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xcedula)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xnombres <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombres='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnombres)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombres='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnombres)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xapellidos <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xapellidos='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xapellidos)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xapellidos='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xapellidos)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xnombrecompleto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompleto='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnombrecompleto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompleto='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnombrecompleto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xcedpropinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedpropinsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xcedpropinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedpropinsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xcedpropinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xcedsidoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedsidoinsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xcedsidoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedsidoinsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xcedsidoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xplacinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacinsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xplacinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacinsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xplacinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xsermotinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsermotinsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xsermotinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsermotinsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xsermotinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xsercarrinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsercarrinsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xsercarrinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsercarrinsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xsercarrinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xnumpolinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumpolinsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnumpolinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumpolinsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnumpolinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xnumsininsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumsininsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnumsininsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumsininsenc='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnumsininsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xnomintinssus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomintinssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnomintinssus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomintinssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnomintinssus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xnomsolinssus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomsolinssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnomsolinssus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomsolinssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnomsolinssus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.iluginssus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iluginssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.iluginssus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iluginssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.iluginssus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.idaipmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idaipmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idaipmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.idaipmanvehmar <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idaipmanvehmar))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idaipmanvehmar))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xnommanvehmar <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmar='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnommanvehmar)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmar='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnommanvehmar)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.idaipmanvehmod <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idaipmanvehmod))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idaipmanvehmod))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xnommanvehmod <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmod='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnommanvehmod)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmod='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnommanvehmod)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.idaipmanvehver <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idaipmanvehver))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idaipmanvehver))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xnommanvehver <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehver='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnommanvehver)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehver='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xnommanvehver)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.itipotransmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipotransmanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.itipotransmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipotransmanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.itipotransmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.itipomanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipomanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.itipomanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipomanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.itipomanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.iclasemanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iclasemanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.iclasemanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iclasemanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.iclasemanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.icolormanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.icolormanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.icolormanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.icolormanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.icolormanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xplacamanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacamanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xplacamanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacamanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xplacamanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xsercarrmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsercarrmanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xsercarrmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsercarrmanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xsercarrmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xsermotmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsermotmanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xsermotmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsermotmanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xsermotmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.itraccmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itraccmanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.itraccmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itraccmanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.itraccmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.iimpmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iimpmanveh=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.iimpmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iimpmanveh=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.iimpmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.ncilinmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncilinmanveh=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.ncilinmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncilinmanveh=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.ncilinmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xcargmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcargmanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xcargmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcargmanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xcargmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xcapmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcapmanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xcapmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcapmanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xcapmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xdescmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescmanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xdescmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescmanveh='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xdescmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.nkiloinssus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nkiloinssus=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.nkiloinssus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nkiloinssus=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.nkiloinssus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xsucuinssus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsucuinssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xsucuinssus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsucuinssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xsucuinssus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.iserbodinssus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iserbodinssus=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.iserbodinssus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iserbodinssus=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.iserbodinssus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.ialarcorrinssus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ialarcorrinssus=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.ialarcorrinssus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ialarcorrinssus=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.ialarcorrinssus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xserinssus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xserinssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xserinssus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xserinssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xserinssus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xdictinssus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdictinssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xdictinssus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdictinssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xdictinssus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.xdescinssus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xdescinssus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.xdescinssus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.iestatinssus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.iestatinssus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinssus='")
				sb.Append(petivi_aipinssuspaglist.vi_aipinssus.iestatinssus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssuspaglist.vi_aipinssus.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssuspaglist.vi_aipinssus.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinssuspaglist As New respvi_aipinssuspaglist
	respvi_aipinssuspaglist.pagvi_aipinssus = petivi_aipinssuspaglist.pagvi_aipinssus
	Dim skip = skip_paginacion(petivi_aipinssuspaglist.pagvi_aipinssus.npagactual, petivi_aipinssuspaglist.pagvi_aipinssus.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinssuspaglist.lista_vi_aipinssus = _db.vi_aipinssus.OrderBy(petivi_aipinssuspaglist.pagvi_aipinssus.xcamposord & " "  & petivi_aipinssuspaglist.pagvi_aipinssus.idirord).Skip(skip).Take(petivi_aipinssuspaglist.pagvi_aipinssus.npagtamano).ToList
		Else
			respvi_aipinssuspaglist.lista_vi_aipinssus = _db.vi_aipinssus.Where(sb.ToString).OrderBy(petivi_aipinssuspaglist.pagvi_aipinssus.xcamposord & " "  & petivi_aipinssuspaglist.pagvi_aipinssus.idirord).Skip(skip).Take(petivi_aipinssuspaglist.pagvi_aipinssus.npagtamano).ToList
		End If
		'
		If (respvi_aipinssuspaglist.lista_vi_aipinssus.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinssusxwheredinamicocount(sb)
		respvi_aipinssuspaglist.pagvi_aipinssus.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinssuspaglist.pagvi_aipinssus.npagtamano)
		Else
		respvi_aipinssuspaglist.pagvi_aipinssus.npagcantidad = 0
		respvi_aipinssuspaglist.pagvi_aipinssus.npagactual = 0
		End If
	
		Return respvi_aipinssuspaglist
	End Function

	Public Function selvi_aipinssusxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinssus.count
	Else
	Return _db.vi_aipinssus.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinssusxidinsenc(idaipinsenc As Decimal) As vi_aipinssus
            Dim vi_aipinssus As vi_aipinssus = (From p In _db.vi_aipinssus
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).SingleOrDefault
            Return vi_aipinssus
        End Function
End Class
End Namespace
