Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports estarseguros20.capawebapi.seginsoft.vistas.controlador
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad

Namespace aipauto.vistas.controlador
    Public Class vi_aipinsencController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsencxid(idaipinsenc As Decimal) As vi_aipinsenc
            Dim vi_aipinsenc As vi_aipinsenc = (From p In _db.vi_aipinsenc
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).SingleOrDefault
            Return vi_aipinsenc
        End Function

        <HttpPost()> _
        Public Function selvi_aipinsenc() As List(Of vi_aipinsenc)
            Dim lista_vi_aipinsenc As List(Of vi_aipinsenc) = (From p In _db.vi_aipinsenc
                                                        Select p).ToList
            '
            Return lista_vi_aipinsenc
        End Function

        <HttpPost()> _
        Public Function selvi_aipinsencxwheredinamicopag(petivi_aipinsencpaglist As petivi_aipinsencpaglist) As respvi_aipinsencpaglist
            Dim sb As New StringBuilder("")
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idaipinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsenc=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idaipinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsenc=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idaipinsenc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.itipoinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.itipoinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itipoinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.itipoperitinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.itipoperitinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoperitinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itipoperitinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoperitinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.iorigeninsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iorigeninsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.iorigeninsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iorigeninsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.iorigeninsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuperit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuperit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xcedulaperit <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcedulaperit='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedulaperit)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcedulaperit='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedulaperit)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xnombresperit <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombresperit='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombresperit)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombresperit='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombresperit)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xapellidosperit <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xapellidosperit='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xapellidosperit)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xapellidosperit='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xapellidosperit)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompletoperit <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecompletoperit='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompletoperit)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecompletoperit='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompletoperit)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanorgperit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanorgperit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xnombrecomercialperit <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecomercialperit='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecomercialperit)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecomercialperit='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecomercialperit)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuaudit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuaudit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xcedulaaudit <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcedulaaudit='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedulaaudit)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcedulaaudit='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedulaaudit)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xnombresaudit <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombresaudit='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombresaudit)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombresaudit='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombresaudit)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xapellidosaudit <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xapellidosaudit='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xapellidosaudit)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xapellidosaudit='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xapellidosaudit)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompletoaudit <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecompletoaudit='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompletoaudit)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecompletoaudit='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompletoaudit)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgaudit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanorgaudit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgaudit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanorgaudit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgaudit))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xnombrecomercialaudit <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecomercialaudit='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecomercialaudit)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecomercialaudit='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecomercialaudit)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xcedpropinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcedpropinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedpropinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcedpropinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedpropinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xcedsidoinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcedsidoinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedsidoinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcedsidoinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedsidoinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xplacinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xplacinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xplacinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xplacinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xplacinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xsermotinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xsermotinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsermotinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xsermotinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsermotinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xsercarrinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xsercarrinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsercarrinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xsercarrinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsercarrinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xnumpolinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnumpolinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnumpolinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnumpolinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnumpolinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xnumsininsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnumsininsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnumsininsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnumsininsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnumsininsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xllavinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xllavinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xllavinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xllavinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xllavinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.fcreainsenc > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fcreainsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.fcreainsenc)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fcreainsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.fcreainsenc)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.fprocinsenc > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fprocinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.fprocinsenc)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fprocinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.fprocinsenc)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.faudinsenc > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.faudinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.faudinsenc)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.faudinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.faudinsenc)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.fultrechinsenc > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fultrechinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.fultrechinsenc)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fultrechinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.fultrechinsenc)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.fcancinsenc > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fcancinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.fcancinsenc)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fcancinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.fcancinsenc)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.facepinsenc > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.facepinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.facepinsenc)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.facepinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.facepinsenc)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xdescinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdescinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xdescinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdescinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xdescinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.iestatinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestatinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.iestatinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.iestatinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idaipactivperi <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipactivperi=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idaipactivperi))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipactivperi=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idaipactivperi))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idcomunmancont <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunmancont=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idcomunmancont))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idcomunmancont=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idcomunmancont))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idcomunmanpais <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunmanpais=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idcomunmanpais))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idcomunmanpais=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idcomunmanpais))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idcomunmanestado <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunmanestado=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idcomunmanestado))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idcomunmanestado=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idcomunmanestado))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idcomunmanlocalid <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunmanlocalid=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idcomunmanlocalid))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idcomunmanlocalid=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idcomunmanlocalid))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xdireccionactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdireccionactivperi='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xdireccionactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdireccionactivperi='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xdireccionactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xtelfmovilactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xtelfmovilactivperi='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xtelfmovilactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xtelfmovilactivperi='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xtelfmovilactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xnomcliactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnomcliactivperi='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnomcliactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnomcliactivperi='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnomcliactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xcorreoelectronicoactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcorreoelectronicoactivperi='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcorreoelectronicoactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcorreoelectronicoactivperi='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcorreoelectronicoactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xtituactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xtituactivperi='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xtituactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xtituactivperi='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xtituactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.fejecactivperi > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.fejecactivperi)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.fejecactivperi)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.ffinejecactivperi > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.ffinejecactivperi < DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.ffinejecactivperi)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.ffinejecactivperi < DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.ffinejecactivperi)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xdescactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdescactivperi='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xdescactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdescactivperi='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xdescactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.ialcanactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.ialcanactivperi='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.ialcanactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ialcanactivperi='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.ialcanactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.iestatactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestatactivperi='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.iestatactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatactivperi='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.iestatactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusucrea <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusucrea=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusucrea))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusucrea=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusucrea))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompleto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecompleto='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompleto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecompleto='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompleto)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.fcrearegactivperi > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fcrearegactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.fcrearegactivperi)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fcrearegactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.fcrearegactivperi)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '


            Dim respvi_aipinsencpaglist As New respvi_aipinsencpaglist
            respvi_aipinsencpaglist.pagvi_aipinsenc = petivi_aipinsencpaglist.pagvi_aipinsenc
            Dim skip = skip_paginacion(petivi_aipinsencpaglist.pagvi_aipinsenc.npagactual, petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano)

            If sb.ToString = "" Then
                respvi_aipinsencpaglist.lista_vi_aipinsenc = _db.vi_aipinsenc.OrderBy(petivi_aipinsencpaglist.pagvi_aipinsenc.xcamposord & " " & petivi_aipinsencpaglist.pagvi_aipinsenc.idirord).Skip(skip).Take(petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano).ToList
            Else
                respvi_aipinsencpaglist.lista_vi_aipinsenc = _db.vi_aipinsenc.Where(sb.ToString).OrderBy(petivi_aipinsencpaglist.pagvi_aipinsenc.xcamposord & " " & petivi_aipinsencpaglist.pagvi_aipinsenc.idirord).Skip(skip).Take(petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano).ToList
            End If
            '
            If (respvi_aipinsencpaglist.lista_vi_aipinsenc.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_aipinsencxwheredinamicocount(sb)
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsencpaglist.pagvi_aipinsenc.npagtamano)
            Else
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagcantidad = 0
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagactual = 0
            End If

            Return respvi_aipinsencpaglist
        End Function

        Public Function selvi_aipinsencxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.vi_aipinsenc.Count
            Else
                Return _db.vi_aipinsenc.Where(sb.ToString).Count
            End If
        End Function


        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinsencxprocpag(petivi_aipinsencpaglist As petivi_aipinsencpaglist) As respvi_aipinsencpaglist
            Dim sb As New StringBuilder("")


            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")
            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")

            Dim vi_segusudetperf2Controller As New vi_segusudetperf2Controller
            Dim vi_segusudetperf2 As New vi_segusudetperf2
            vi_segusudetperf2 = vi_segusudetperf2Controller.selvi_segusudetperf2poridsegmanusu(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit)



            If (vi_segusudetperf2 IsNot Nothing) Then
                'si es perito lider sucursal busco todos pero solo los de su sucursal
                If (vi_segusudetperf2.idsegmanperf = peritols) Then
                    petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit = 0
                    petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit = vi_segusudetperf2.idsegmanorg
                Else
                    ''si es perito externo o interno busco por sus actividades y por su sucursal
                    petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit = vi_segusudetperf2.idsegmanusu
                    petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit = vi_segusudetperf2.idsegmanorg
                End If
            End If

            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuperit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuperit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit))
                        sb.Append("")
                    End If
                End If
            End If

            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanorgperit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanorgperit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit))
                        sb.Append("")
                    End If
                End If
            End If

            '
            'If petivi_aipinsencpaglist.vi_aipinsenc.iestatinsenc <> "" Then
            If sb.Length = 0 Then
                sb.Append("it.iestatinsenc='")
                sb.Append("POR PROCESAR")
                sb.Append("'")
            Else
                If sb.Length > 0 Then
                    sb.Append(" and it.iestatinsenc='")
                    sb.Append("POR PROCESAR")
                    sb.Append("'")
                End If
            End If
            'End If
            '
            Dim respvi_aipinsencpaglist As New respvi_aipinsencpaglist
            respvi_aipinsencpaglist.pagvi_aipinsenc = petivi_aipinsencpaglist.pagvi_aipinsenc
            Dim skip = skip_paginacion(petivi_aipinsencpaglist.pagvi_aipinsenc.npagactual, petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano)

            If sb.ToString = "" Then
                respvi_aipinsencpaglist.lista_vi_aipinsenc = _db.vi_aipinsenc.OrderBy(petivi_aipinsencpaglist.pagvi_aipinsenc.xcamposord & " " & petivi_aipinsencpaglist.pagvi_aipinsenc.idirord).Skip(skip).Take(petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano).ToList
            Else
                respvi_aipinsencpaglist.lista_vi_aipinsenc = _db.vi_aipinsenc.Where(sb.ToString).OrderBy(petivi_aipinsencpaglist.pagvi_aipinsenc.xcamposord & " " & petivi_aipinsencpaglist.pagvi_aipinsenc.idirord).Skip(skip).Take(petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano).ToList
            End If
            '
            If (respvi_aipinsencpaglist.lista_vi_aipinsenc.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_aipinsencxwheredinamicocount(sb)
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsencpaglist.pagvi_aipinsenc.npagtamano)
            Else
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagcantidad = 0
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagactual = 0
            End If

            Return respvi_aipinsencpaglist
        End Function


        <HttpPost()> _
        Public Function selvi_aipinsencxauditpag(petivi_aipinsencpaglist As petivi_aipinsencpaglist) As respvi_aipinsencpaglist
            Dim sb As New StringBuilder("")


            Dim auditorlp As Decimal = ConfigurationManager.AppSettings("auditorlp")
            Dim auditorls As Decimal = ConfigurationManager.AppSettings("auditorls")
            Dim auditor As Decimal = ConfigurationManager.AppSettings("auditor")
            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")

            Dim vi_segusudetperf2Controller As New vi_segusudetperf2Controller
            Dim vi_segusudetperf2 As New vi_segusudetperf2
            vi_segusudetperf2 = vi_segusudetperf2Controller.selvi_segusudetperf2poridsegmanusu(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit)


            If (vi_segusudetperf2 IsNot Nothing) Then

                'si es auditor lider principal se deben buscar todas las inspecciones POR AUDITAR
                If (vi_segusudetperf2.idsegmanperf = auditorlp) Then
                    petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit = 0
                ElseIf (vi_segusudetperf2.idsegmanperf = auditorls) Then
                    'si es auditor lider sucursal se deben buscar todas las inspecciones de su sucursal POR AUDITAR
                    petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit = 0

                    'aqui hay que indicar que si busca por un auditor de la sucursal principal busque las inspecciones asignadas a el sin la organizacion,
                    ''se comento la siguiente linea mientras                    
                    'petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit = vi_segusudetperf2.idsegmanorg(comenta segun nota de arriba)                    
                    petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit = 0 '(esto es momentaneo)

                ElseIf (vi_segusudetperf2.idsegmanperf = auditor) Then
                    'si es un auditor se deben buscar por su usuario y por su sucursal
                    petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit = vi_segusudetperf2.idsegmanusu

                    'aqui hay que indicar que si busca por un auditor de la sucursal principal busque las inspecciones asignadas a el sin la organizacion,
                    ''se comento la siguiente linea mientras
                    'petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit = vi_segusudetperf2.idsegmanorg(comenta segun nota de arriba)
                    petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit = 0 '(esto es momentaneo)

                Else
                    'el no es auditor se devuelve en cero la respuesta lista vacia y paginacion en cero
                    Dim respvi_aipinsencpaglist1 As New respvi_aipinsencpaglist
                    respvi_aipinsencpaglist1.lista_vi_aipinsenc = New List(Of vi_aipinsenc)
                    respvi_aipinsencpaglist1.pagvi_aipinsenc = petivi_aipinsencpaglist.pagvi_aipinsenc
                    respvi_aipinsencpaglist1.pagvi_aipinsenc.npagcantidad = 0
                    respvi_aipinsencpaglist1.pagvi_aipinsenc.npagtamano = 0
                    Return respvi_aipinsencpaglist1
                End If


            End If


            If petivi_aipinsencpaglist.vi_aipinsenc.idaipinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsenc=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idaipinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsenc=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idaipinsenc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.itipoinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.itipoinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itipoinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuaudit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuaudit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit))
                        sb.Append("")
                    End If
                End If
            End If

            If petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompletoperit <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecompletoperit LIKE '%")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompletoperit)
                    sb.Append("%'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecompletoperit LIKE'%")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompletoperit)
                        sb.Append("%'")
                    End If
                End If
            End If

            'se busca por organizacion del perito ya que de el esta la sucursal de la inspeccion, no se toma en cuenta la del auditor
            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanorgperit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanorgperit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xcedpropinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcedpropinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedpropinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcedpropinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedpropinsenc)
                        sb.Append("'")
                    End If
                End If
            End If

            If petivi_aipinsencpaglist.vi_aipinsenc.xsermotinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xsermotinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsermotinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xsermotinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsermotinsenc)
                        sb.Append("'")
                    End If
                End If
            End If

            If petivi_aipinsencpaglist.vi_aipinsenc.xsercarrinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xsercarrinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsercarrinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xsercarrinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsercarrinsenc)
                        sb.Append("'")
                    End If
                End If
            End If



            '
            'If petivi_aipinsencpaglist.vi_aipinsenc.iestatinsenc <> "" Then
            If sb.Length = 0 Then
                sb.Append("it.iestatinsenc='")
                sb.Append("POR AUDITAR")
                sb.Append("'")
            Else
                If sb.Length > 0 Then
                    sb.Append(" and it.iestatinsenc='")
                    sb.Append("POR AUDITAR")
                    sb.Append("'")
                End If
            End If
            'End If
            '
            Dim respvi_aipinsencpaglist As New respvi_aipinsencpaglist
            respvi_aipinsencpaglist.pagvi_aipinsenc = petivi_aipinsencpaglist.pagvi_aipinsenc
            Dim skip = skip_paginacion(petivi_aipinsencpaglist.pagvi_aipinsenc.npagactual, petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano)

            If sb.ToString = "" Then
                respvi_aipinsencpaglist.lista_vi_aipinsenc = _db.vi_aipinsenc.OrderBy(petivi_aipinsencpaglist.pagvi_aipinsenc.xcamposord & " " & petivi_aipinsencpaglist.pagvi_aipinsenc.idirord).Skip(skip).Take(petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano).ToList
            Else
                respvi_aipinsencpaglist.lista_vi_aipinsenc = _db.vi_aipinsenc.Where(sb.ToString).OrderBy(petivi_aipinsencpaglist.pagvi_aipinsenc.xcamposord & " " & petivi_aipinsencpaglist.pagvi_aipinsenc.idirord).Skip(skip).Take(petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano).ToList
            End If
            '
            If (respvi_aipinsencpaglist.lista_vi_aipinsenc.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_aipinsencxwheredinamicocount(sb)
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsencpaglist.pagvi_aipinsenc.npagtamano)
            Else
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagcantidad = 0
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagactual = 0
            End If

            Return respvi_aipinsencpaglist
        End Function

        ''metodo para buscar las inspecciones en la pantalla de consulta 
        <HttpPost()> _
        Public Function selvi_aipinsencconsultapag(petivi_aipinsencpaglist As petivi_aipinsencpaglist) As respvi_aipinsencpaglist
            Dim sb As New StringBuilder("")


            Dim auditorlp As Decimal = ConfigurationManager.AppSettings("auditorlp")
            Dim auditorls As Decimal = ConfigurationManager.AppSettings("auditorls")
            Dim auditor As Decimal = ConfigurationManager.AppSettings("auditor")
            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")

            Dim vi_segusudetperf2Controller As New vi_segusudetperf2Controller
            Dim vi_segusudetperf2 As New vi_segusudetperf2
            vi_segusudetperf2 = vi_segusudetperf2Controller.selvi_segusudetperf2poridsegmanusu(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit)


            If (vi_segusudetperf2 IsNot Nothing) Then

                'si es auditor lider principal se deben buscar todas las inspecciones POR AUDITAR
                If (vi_segusudetperf2.idsegmanperf = auditorlp) Then
                    petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit = 0
                ElseIf (vi_segusudetperf2.idsegmanperf = auditorls) Then
                    'si es auditor lider sucursal se deben buscar todas las inspecciones de su sucursal POR AUDITAR
                    petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit = 0
                    petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit = vi_segusudetperf2.idsegmanorg

                ElseIf (vi_segusudetperf2.idsegmanperf = auditor) Then
                    'si es un auditor se deben buscar por su usuario y por su sucursal
                    petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit = vi_segusudetperf2.idsegmanusu
                    petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit = vi_segusudetperf2.idsegmanorg
                Else
                    'el no es auditor se devuelve en cero la respuesta lista vacia y paginacion en cero
                    Dim respvi_aipinsencpaglist1 As New respvi_aipinsencpaglist
                    respvi_aipinsencpaglist1.lista_vi_aipinsenc = New List(Of vi_aipinsenc)
                    respvi_aipinsencpaglist1.pagvi_aipinsenc = petivi_aipinsencpaglist.pagvi_aipinsenc
                    respvi_aipinsencpaglist1.pagvi_aipinsenc.npagcantidad = 0
                    respvi_aipinsencpaglist1.pagvi_aipinsenc.npagtamano = 0
                    Return respvi_aipinsencpaglist1
                End If


            End If


            If petivi_aipinsencpaglist.vi_aipinsenc.idaipinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsenc=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idaipinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsenc=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idaipinsenc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.itipoinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.itipoinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itipoinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuaudit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuaudit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit))
                        sb.Append("")
                    End If
                End If
            End If

            If petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompletoperit <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecompletoperit LIKE '%")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompletoperit)
                    sb.Append("%'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecompletoperit LIKE'%")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompletoperit)
                        sb.Append("%'")
                    End If
                End If
            End If

            'se busca por organizacion del perito ya que de el esta la sucursal de la inspeccion, no se toma en cuenta la del auditor
            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanorgperit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanorgperit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xcedpropinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcedpropinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedpropinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcedpropinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedpropinsenc)
                        sb.Append("'")
                    End If
                End If
            End If

            If petivi_aipinsencpaglist.vi_aipinsenc.xplacinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xplacinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xplacinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xplacinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xplacinsenc)
                        sb.Append("'")
                    End If
                End If
            End If

            If petivi_aipinsencpaglist.vi_aipinsenc.xsermotinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xsermotinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsermotinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xsermotinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsermotinsenc)
                        sb.Append("'")
                    End If
                End If
            End If

            If petivi_aipinsencpaglist.vi_aipinsenc.xsercarrinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xsercarrinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsercarrinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xsercarrinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsercarrinsenc)
                        sb.Append("'")
                    End If
                End If
            End If

            If petivi_aipinsencpaglist.vi_aipinsenc.xnumsininsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnumsininsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnumsininsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnumsininsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnumsininsenc)
                        sb.Append("'")
                    End If
                End If
            End If


            If petivi_aipinsencpaglist.vi_aipinsenc.iestatinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestatinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.iestatinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.iestatinsenc)
                        sb.Append("'")
                    End If
                End If
            End If



            'se coloca todas las inspecciones diferentes a inicializar
            '
            'If petivi_aipinsencpaglist.vi_aipinsenc.iestatinsenc <> "" Then
            If sb.Length = 0 Then
                sb.Append("it.iestatinsenc<>'")
                sb.Append("INICIALIZAR")
                sb.Append("'")
            Else
                If sb.Length > 0 Then
                    sb.Append(" and it.iestatinsenc<>'")
                    sb.Append("INICIALIZAR")
                    sb.Append("'")
                End If
            End If
            'End If
            '

            If petivi_aipinsencpaglist.vi_aipinsenc.xnuminspinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnuminspinsenc LIKE '%")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnuminspinsenc)
                    sb.Append("%'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnuminspinsenc LIKE'%")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnuminspinsenc)
                        sb.Append("%'")
                    End If
                End If
            End If

            Dim respvi_aipinsencpaglist As New respvi_aipinsencpaglist
            respvi_aipinsencpaglist.pagvi_aipinsenc = petivi_aipinsencpaglist.pagvi_aipinsenc
            Dim skip = skip_paginacion(petivi_aipinsencpaglist.pagvi_aipinsenc.npagactual, petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano)

            If sb.ToString = "" Then
                respvi_aipinsencpaglist.lista_vi_aipinsenc = _db.vi_aipinsenc.OrderBy(petivi_aipinsencpaglist.pagvi_aipinsenc.xcamposord & " " & petivi_aipinsencpaglist.pagvi_aipinsenc.idirord).Skip(skip).Take(petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano).ToList
            Else
                respvi_aipinsencpaglist.lista_vi_aipinsenc = _db.vi_aipinsenc.Where(sb.ToString).OrderBy(petivi_aipinsencpaglist.pagvi_aipinsenc.xcamposord & " " & petivi_aipinsencpaglist.pagvi_aipinsenc.idirord).Skip(skip).Take(petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano).ToList
            End If
            '
            If (respvi_aipinsencpaglist.lista_vi_aipinsenc.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_aipinsencxwheredinamicocount(sb)
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsencpaglist.pagvi_aipinsenc.npagtamano)
            Else
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagcantidad = 0
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagactual = 0
            End If

            Return respvi_aipinsencpaglist
        End Function



        ''obtener todos los eventos por fecha de inicio alcance y perito
        <HttpPost()> _
        Public Function ObtenerPorPeritoAlcanceYFechaInicio(start As Date, ialcanactivperi As String, idsegmanusuperit As String) As List(Of vi_aipinsenc)
            Dim fecha_start As New Date(start.Year, start.Month, start.Day, 0, 0, 0)
            '
            Dim lista_vi_aipinsenc As List(Of vi_aipinsenc) = (From p In _db.vi_aipinsenc
                                                         Where p.fejecactivperi >= fecha_start And p.ialcanactivperi = ialcanactivperi And p.idsegmanusuperit = idsegmanusuperit
                                                                     Select p).ToList
            '
            Return lista_vi_aipinsenc
        End Function


        'obtener la cantidad de eventos para un dia
        <HttpPost()> _
        Public Function ObtenerCantidadPorFinicioAlcanceYPerito(fejecactivperi As Date, ialcanactivperi As String, idsegmanusuperit As String) As Decimal
            Dim fecha_ini As New Date(fejecactivperi.Year, fejecactivperi.Month, fejecactivperi.Day, 0, 0, 0)
            Dim fecha_fin As New Date(fejecactivperi.Year, fejecactivperi.Month, fejecactivperi.Day, 23, 59, 59)
            Dim neventos As Decimal = 0

            neventos = (From p In _db.vi_aipinsenc
                        Where p.fejecactivperi >= fecha_ini And p.fejecactivperi <= fecha_fin And p.ialcanactivperi = ialcanactivperi And p.idsegmanusuperit = idsegmanusuperit
                        Select p).Count()
            Return neventos
        End Function


        <HttpPost()> _
        Public Function ObtenerPoridaipinsencYUsuarioCrea(idaipactivperi As Decimal, idsegmanusucrea As Decimal) As vi_aipinsenc
            Dim vi_aipinsenc As vi_aipinsenc = (From p In _db.vi_aipinsenc
                                            Where p.idaipactivperi = idaipactivperi And p.idsegmanusucrea = idsegmanusucrea
                                            Select p).SingleOrDefault
            Return vi_aipinsenc
        End Function


        ''funcion para buscar las inspecciones de acuerdo a un tipo de accion si AUDITOR o PERITO de acuerdo a esta accion se usuara algun estatus de la inspeccion
        <HttpPost()> _
        Public Function selvi_aipinsencxwheredinamicopagYTipoAccion(itipoaccion As String, petivi_aipinsencpaglist As petivi_aipinsencpaglist) As respvi_aipinsencpaglist
            Dim sb As New StringBuilder("")
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idaipinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsenc=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idaipinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsenc=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idaipinsenc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.itipoinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.itipoinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itipoinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.itipoperitinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.itipoperitinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoperitinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itipoperitinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoperitinsenc)
                        sb.Append("'")
                    End If
                End If
            End If

            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuperit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuperit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit))
                        sb.Append("")
                    End If
                End If
            End If

            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanorgperit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanorgperit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit))
                        sb.Append("")
                    End If
                End If
            End If

            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuaudit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuaudit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit))
                        sb.Append("")
                    End If
                End If
            End If

            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgaudit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanorgaudit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgaudit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanorgaudit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgaudit))
                        sb.Append("")
                    End If
                End If
            End If

            If petivi_aipinsencpaglist.vi_aipinsenc.xplacinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xplacinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xplacinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xplacinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xplacinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xsermotinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xsermotinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsermotinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xsermotinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsermotinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xsercarrinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xsercarrinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsercarrinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xsercarrinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsercarrinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xnumpolinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnumpolinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnumpolinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnumpolinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnumpolinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xnumsininsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnumsininsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnumsininsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnumsininsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnumsininsenc)
                        sb.Append("'")
                    End If
                End If
            End If

            'se realiza la verificacion por el tipo de accion 
            'Si es AUDITOR se debe realizar la busqueda de todas las inspecciones  con estatus POR AUDITAR
            'Si es PERITO se deben buscar todas las inspecciones con estatus  INICIALIZAR y POR PROCESAR
            If (itipoaccion = "AUDITOR") Then

                If sb.Length = 0 Then
                    sb.Append("it.iestatinsenc='")
                    sb.Append("POR AUDITAR")
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatinsenc='")
                        sb.Append("POR AUDITAR")
                        sb.Append("'")
                    End If
                End If

            ElseIf (itipoaccion = "PERITO") Then
                If sb.Length = 0 Then
                    sb.Append("(it.iestatinsenc='")
                    sb.Append("INICIALIZAR")
                    sb.Append("' or it.iestatinsenc='")
                    sb.Append("POR PROCESAR")
                    sb.Append("')")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and (it.iestatinsenc='")
                        sb.Append("INICIALIZAR")
                        sb.Append("' or it.iestatinsenc='")
                        sb.Append("POR PROCESAR")
                        sb.Append("')")
                    End If
                End If
            End If

            If petivi_aipinsencpaglist.vi_aipinsenc.fejecactivperi > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.fejecactivperi)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.fejecactivperi)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.ffinejecactivperi > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.ffinejecactivperi < DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.ffinejecactivperi)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.ffinejecactivperi < DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipinsencpaglist.vi_aipinsenc.ffinejecactivperi)
                        sb.Append(fecha)
                    End If
                End If
            End If
            Dim respvi_aipinsencpaglist As New respvi_aipinsencpaglist
            respvi_aipinsencpaglist.pagvi_aipinsenc = petivi_aipinsencpaglist.pagvi_aipinsenc
            Dim skip = skip_paginacion(petivi_aipinsencpaglist.pagvi_aipinsenc.npagactual, petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano)

            If sb.ToString = "" Then
                respvi_aipinsencpaglist.lista_vi_aipinsenc = _db.vi_aipinsenc.OrderBy(petivi_aipinsencpaglist.pagvi_aipinsenc.xcamposord & " " & petivi_aipinsencpaglist.pagvi_aipinsenc.idirord).Skip(skip).Take(petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano).ToList
            Else
                respvi_aipinsencpaglist.lista_vi_aipinsenc = _db.vi_aipinsenc.Where(sb.ToString).OrderBy(petivi_aipinsencpaglist.pagvi_aipinsenc.xcamposord & " " & petivi_aipinsencpaglist.pagvi_aipinsenc.idirord).Skip(skip).Take(petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano).ToList
            End If
            '
            If (respvi_aipinsencpaglist.lista_vi_aipinsenc.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_aipinsencxwheredinamicocount(sb)
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsencpaglist.pagvi_aipinsenc.npagtamano)
            Else
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagcantidad = 0
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagactual = 0
            End If

            Return respvi_aipinsencpaglist
        End Function


        <HttpPost()> _
        Public Function selvi_aipinsencxCorreoElectronicoYstart(start As Date, ialcanactivperi As String, xcorreoelectronico1 As String) As List(Of vi_aipinsenc)
            Dim fecha_start As New Date(start.Year, start.Month, start.Day, 0, 0, 0)
            '
            Dim lista_vi_aipinsenc As List(Of vi_aipinsenc) = (From p In _db.vi_aipinsenc
                                                                     Where p.fejecactivperi >= fecha_start And p.ialcanactivperi = ialcanactivperi And p.xnombreusuarioperit = xcorreoelectronico1
                                                                     Select p).ToList
            '
            Return lista_vi_aipinsenc
        End Function


        <HttpPost()> _
        Public Function selvi_aipinsencxSerialCarYFInicio(xsercarrinsenc As String, fejecactivperi As Date) As vi_aipinsenc
            Dim fejecactivperi1 As New Date(fejecactivperi.Year, fejecactivperi.Month, fejecactivperi.Day, 0, 0, 0)
            '
            Dim vi_aipinsenc As vi_aipinsenc = (From p In _db.vi_aipinsenc
                                                                     Where p.xsercarrinsenc = xsercarrinsenc And p.fejecactivperi >= fejecactivperi1
                                                                     Select p).SingleOrDefault
            '
            Return vi_aipinsenc
        End Function

        <HttpPost()> _
        Public Function ObtenerPorSerialCarYEstatus(xsercarrinsenc As String, iestatinsenc As String) As vi_aipinsenc

            Dim vi_aipinsenc As vi_aipinsenc = (From p In _db.vi_aipinsenc
                                                                     Where p.xsercarrinsenc = xsercarrinsenc And p.iestatinsenc = iestatinsenc
                                                                     Select p).SingleOrDefault
            '
            Return vi_aipinsenc
        End Function

        <HttpPost()> _
        Public Function ObtenerPorPlacaYEstatus(xplacinsenc As String, iestatinsenc As String) As vi_aipinsenc

            Dim vi_aipinsenc As vi_aipinsenc = (From p In _db.vi_aipinsenc
                                                                     Where p.xplacinsenc = xplacinsenc And p.iestatinsenc = iestatinsenc
                                                                     Select p).SingleOrDefault
            '
            Return vi_aipinsenc
        End Function

        <HttpPost()> _
        Public Function ObtenerPorSiniestroCotizYEstatus(xnumsininsenc As String, iestatinsenc As String) As vi_aipinsenc

            Dim vi_aipinsenc As vi_aipinsenc = (From p In _db.vi_aipinsenc
                                                                     Where p.xnumsininsenc = xnumsininsenc And p.iestatinsenc = iestatinsenc
                                                                     Select p).SingleOrDefault
            '
            Return vi_aipinsenc
        End Function

        'metodos para obtener inspeccion por idaipinsenc y estatus
        <HttpPost()> _
        Public Function selvi_aipinsencxIdyEstatus(idaipinsenc As Decimal, iestatinsenc As String) As vi_aipinsenc

            Dim vi_aipinsenc As vi_aipinsenc = (From p In _db.vi_aipinsenc
                                                                     Where p.idaipinsenc = idaipinsenc And p.iestatinsenc = iestatinsenc
                                                                     Select p).SingleOrDefault
            '
            Return vi_aipinsenc
        End Function

        <HttpPost()> _
        Public Function ObtenerInsEncPendPorProcYCorreoElectronico(start As Date, ialcanactivperi As String, xcorreoelectronico1 As String) As List(Of vi_aipinsenc)
            Dim fecha_start As New Date(start.Year, start.Month, start.Day, 0, 0, 0)
            '
            Dim lista_vi_aipinsenc As List(Of vi_aipinsenc) = (From p In _db.vi_aipinsenc
                                                                     Where p.xnombreusuarioperit = xcorreoelectronico1 And p.iestatinsenc = "POR PROCESAR"
                                                                     Select p).ToList
            '
            Return lista_vi_aipinsenc
        End Function

        <HttpPost()> _
        Public Function ObtenerInsEncPendPorCorreoElectronico(xcorreoelectronico1 As String) As List(Of vi_aipinsenc)
            '
            Dim lista_vi_aipinsenc As List(Of vi_aipinsenc) = (From p In _db.vi_aipinsenc
                                                                     Where p.xnombreusuarioperit = xcorreoelectronico1 And p.iestatinsenc = "POR PROCESAR"
                                                                     Order By p.fejecactivperi Ascending
                                                                     Select p).ToList
            '
            Return lista_vi_aipinsenc
        End Function

        <HttpPost()> _
        Public Function ObtenerCantViAipinsencPorPeritoYEstatus(idsegmanusuperit As Decimal) As Decimal

            Dim cantidad As Decimal = (From p In _db.vi_aipinsenc
                                      Where p.idsegmanusuperit = idsegmanusuperit And (p.iestatinsenc = "INICIALIZAR" Or p.iestatinsenc = "POR PROCESAR")
                                                                     Select p).Count
            '
            Return cantidad
        End Function

        <HttpPost()> _
        Public Function ObtenerViAipinsencPorPeritoYEstatus(idsegmanusuperit As Decimal, iestatinsenc As String) As List(Of vi_aipinsenc)

            Dim lista_vi_aipinsenc As List(Of vi_aipinsenc) = (From p In _db.vi_aipinsenc
                                      Where p.idsegmanusuperit = idsegmanusuperit And p.iestatinsenc = "POR PROCESAR"
                                                                     Select p).ToList()
            '
            Return lista_vi_aipinsenc
        End Function


        <HttpPost()> _
        Public Function ObtenerInspeccionMenosProcedentes(petivi_aipinsencpaglist As petivi_aipinsencpaglist) As respvi_aipinsencpaglist
            Dim sb As New StringBuilder("")
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idaipinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsenc=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idaipinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsenc=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idaipinsenc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.itipoinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.itipoinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itipoinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.itipoperitinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.itipoperitinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoperitinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itipoperitinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.itipoperitinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.iorigeninsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iorigeninsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.iorigeninsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iorigeninsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.iorigeninsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuperit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuperit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xcedulaperit <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcedulaperit='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedulaperit)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcedulaperit='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedulaperit)
                        sb.Append("'")
                    End If
                End If
            End If
            '

            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompletoperit <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecompletoperit LIKE '%")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompletoperit)
                    sb.Append("%'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecompletoperit LIKE '%")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnombrecompletoperit)
                        sb.Append("%'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanorgperit=")
                    sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanorgperit=")
                        sb.Append(valor_entero(petivi_aipinsencpaglist.vi_aipinsenc.idsegmanorgperit))
                        sb.Append("")
                    End If
                End If
            End If
            '


            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xcedpropinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcedpropinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedpropinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcedpropinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xcedpropinsenc)
                        sb.Append("'")
                    End If
                End If
            End If

            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xplacinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xplacinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xplacinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xplacinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xplacinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xsermotinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xsermotinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsermotinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xsermotinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsermotinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xsercarrinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xsercarrinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsercarrinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xsercarrinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xsercarrinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xnumpolinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnumpolinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnumpolinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnumpolinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnumpolinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinsencpaglist.vi_aipinsenc.xnumsininsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnumsininsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnumsininsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnumsininsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.xnumsininsenc)
                        sb.Append("'")
                    End If
                End If
            End If



            If petivi_aipinsencpaglist.vi_aipinsenc.iestatinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestatinsenc='")
                    sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.iestatinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatinsenc='")
                        sb.Append(petivi_aipinsencpaglist.vi_aipinsenc.iestatinsenc)
                        sb.Append("'")
                    End If
                End If
            End If

            ''No buscar las procedentes
            If sb.Length = 0 Then
                sb.Append("it.iestatinsenc<>'PROCEDENTE'")

            Else
                If sb.Length > 0 Then
                    sb.Append(" and it.iestatinsenc<>'PROCEDENTE'")
                End If
            End If


            Dim respvi_aipinsencpaglist As New respvi_aipinsencpaglist
            respvi_aipinsencpaglist.pagvi_aipinsenc = petivi_aipinsencpaglist.pagvi_aipinsenc
            Dim skip = skip_paginacion(petivi_aipinsencpaglist.pagvi_aipinsenc.npagactual, petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano)

            If sb.ToString = "" Then
                respvi_aipinsencpaglist.lista_vi_aipinsenc = _db.vi_aipinsenc.OrderBy(petivi_aipinsencpaglist.pagvi_aipinsenc.xcamposord & " " & petivi_aipinsencpaglist.pagvi_aipinsenc.idirord).Skip(skip).Take(petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano).ToList
            Else
                respvi_aipinsencpaglist.lista_vi_aipinsenc = _db.vi_aipinsenc.Where(sb.ToString).OrderBy(petivi_aipinsencpaglist.pagvi_aipinsenc.xcamposord & " " & petivi_aipinsencpaglist.pagvi_aipinsenc.idirord).Skip(skip).Take(petivi_aipinsencpaglist.pagvi_aipinsenc.npagtamano).ToList
            End If
            '
            If (respvi_aipinsencpaglist.lista_vi_aipinsenc.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_aipinsencxwheredinamicocount(sb)
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsencpaglist.pagvi_aipinsenc.npagtamano)
            Else
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagcantidad = 0
                respvi_aipinsencpaglist.pagvi_aipinsenc.npagactual = 0
            End If

            Return respvi_aipinsencpaglist
        End Function


    End Class
End Namespace
