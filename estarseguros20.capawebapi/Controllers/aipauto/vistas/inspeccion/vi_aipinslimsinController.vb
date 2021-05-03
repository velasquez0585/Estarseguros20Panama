Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinslimsinController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinslimsinxid(idaipinslimsin As Decimal) As vi_aipinslimsin
            Dim vi_aipinslimsin As vi_aipinslimsin = (From p In _db.vi_aipinslimsin
                                            Where p.idaipinslimsin = idaipinslimsin
                                            Select p).SingleOrDefault
            Return vi_aipinslimsin
        End Function

	<HttpPost()> _
	Public Function selvi_aipinslimsin() As List(Of vi_aipinslimsin)
		Dim lista_vi_aipinslimsin As List(Of vi_aipinslimsin) = (From p In _db.vi_aipinslimsin
													Select p).ToList
		'
		Return lista_vi_aipinslimsin
	End Function

<HttpPost()> _
	Public Function selvi_aipinslimsinxwheredinamicopag(petivi_aipinslimsinpaglist as petivi_aipinslimsinpaglist) as respvi_aipinslimsinpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipinslimsin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsin=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipinslimsin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsin=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipinslimsin))
				sb.Append("")
	        End If
	    End If
            End If
            '
            If petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsenc=")
                    sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsenc=")
                        sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipinsenc))
                        sb.Append("")
                    End If
                End If
            End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
            If petivi_aipinslimsinpaglist.vi_aipinslimsin.idsegmanusuperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuperit=")
                    sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idsegmanusuperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuperit=")
                        sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idsegmanusuperit))
                        sb.Append("")
                    End If
                End If
            End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xcedula <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedula='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xcedula)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedula='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xcedula)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xnombres <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombres='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnombres)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombres='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnombres)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xapellidos <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xapellidos='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xapellidos)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xapellidos='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xapellidos)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xnombrecompleto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompleto='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnombrecompleto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompleto='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnombrecompleto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xcedpropinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedpropinsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xcedpropinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedpropinsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xcedpropinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xcedsidoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedsidoinsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xcedsidoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedsidoinsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xcedsidoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xplacinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacinsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xplacinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacinsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xplacinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xsermotinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsermotinsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xsermotinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsermotinsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xsermotinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xsercarrinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsercarrinsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xsercarrinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsercarrinsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xsercarrinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xnumpolinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumpolinsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnumpolinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumpolinsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnumpolinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xnumsininsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumsininsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnumsininsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumsininsenc='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnumsininsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.nfactinslimsin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nfactinslimsin=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.nfactinslimsin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nfactinslimsin=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.nfactinslimsin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.irepuinslimsin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.irepuinslimsin=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.irepuinslimsin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.irepuinslimsin=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.irepuinslimsin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.imobrinslimsin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.imobrinslimsin=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.imobrinslimsin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.imobrinslimsin=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.imobrinslimsin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xnomaseginslimsin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomaseginslimsin='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnomaseginslimsin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomaseginslimsin='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnomaseginslimsin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipmanvehmar <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipmanvehmar))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipmanvehmar))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xnommanvehmar <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmar='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnommanvehmar)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmar='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnommanvehmar)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipmanvehmod <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipmanvehmod))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipmanvehmod))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xnommanvehmod <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmod='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnommanvehmod)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmod='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnommanvehmod)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipmanvehver <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipmanvehver))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idaipmanvehver))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xnommanvehver <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehver='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnommanvehver)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehver='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xnommanvehver)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.itipotransmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipotransmanveh='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.itipotransmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipotransmanveh='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.itipotransmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.itipomanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipomanveh='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.itipomanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipomanveh='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.itipomanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.iclasemanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iclasemanveh='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.iclasemanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iclasemanveh='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.iclasemanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.icolormanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.icolormanveh='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.icolormanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.icolormanveh='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.icolormanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xplacamanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacamanveh='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xplacamanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacamanveh='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xplacamanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xsercarrmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsercarrmanveh='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xsercarrmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsercarrmanveh='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xsercarrmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xsermotmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsermotmanveh='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xsermotmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsermotmanveh='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xsermotmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xsucuinslimsin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsucuinslimsin='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xsucuinslimsin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsucuinslimsin='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xsucuinslimsin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.nkiloinslimsin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nkiloinslimsin=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.nkiloinslimsin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nkiloinslimsin=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.nkiloinslimsin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.xdescinslimsin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinslimsin='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xdescinslimsin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinslimsin='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.xdescinslimsin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.iestatinslimsin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinslimsin='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.iestatinslimsin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinslimsin='")
				sb.Append(petivi_aipinslimsinpaglist.vi_aipinslimsin.iestatinslimsin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsinpaglist.vi_aipinslimsin.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinslimsinpaglist.vi_aipinslimsin.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinslimsinpaglist As New respvi_aipinslimsinpaglist
	respvi_aipinslimsinpaglist.pagvi_aipinslimsin = petivi_aipinslimsinpaglist.pagvi_aipinslimsin
	Dim skip = skip_paginacion(petivi_aipinslimsinpaglist.pagvi_aipinslimsin.npagactual, petivi_aipinslimsinpaglist.pagvi_aipinslimsin.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinslimsinpaglist.lista_vi_aipinslimsin = _db.vi_aipinslimsin.OrderBy(petivi_aipinslimsinpaglist.pagvi_aipinslimsin.xcamposord & " "  & petivi_aipinslimsinpaglist.pagvi_aipinslimsin.idirord).Skip(skip).Take(petivi_aipinslimsinpaglist.pagvi_aipinslimsin.npagtamano).ToList
		Else
			respvi_aipinslimsinpaglist.lista_vi_aipinslimsin = _db.vi_aipinslimsin.Where(sb.ToString).OrderBy(petivi_aipinslimsinpaglist.pagvi_aipinslimsin.xcamposord & " "  & petivi_aipinslimsinpaglist.pagvi_aipinslimsin.idirord).Skip(skip).Take(petivi_aipinslimsinpaglist.pagvi_aipinslimsin.npagtamano).ToList
		End If
		'
		If (respvi_aipinslimsinpaglist.lista_vi_aipinslimsin.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinslimsinxwheredinamicocount(sb)
		respvi_aipinslimsinpaglist.pagvi_aipinslimsin.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinslimsinpaglist.pagvi_aipinslimsin.npagtamano)
		Else
		respvi_aipinslimsinpaglist.pagvi_aipinslimsin.npagcantidad = 0
		respvi_aipinslimsinpaglist.pagvi_aipinslimsin.npagactual = 0
		End If
	
		Return respvi_aipinslimsinpaglist
	End Function

	Public Function selvi_aipinslimsinxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinslimsin.count
	Else
	Return _db.vi_aipinslimsin.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinslimsinxidinsenc(idaipinsenc As Decimal) As vi_aipinslimsin
            Dim vi_aipinslimsis As vi_aipinslimsin = (From p In _db.vi_aipinslimsin
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).SingleOrDefault
            Return vi_aipinslimsis
        End Function
End Class
End Namespace
