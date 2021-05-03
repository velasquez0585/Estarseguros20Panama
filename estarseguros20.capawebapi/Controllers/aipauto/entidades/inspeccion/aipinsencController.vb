Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports Oracle.ManagedDataAccess
Namespace aipauto.entidades.controlador
Public Class aipinsencController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
           Public Function selaipinsencxid(idaipinsenc As Decimal) As aipinsenc
            Dim aipinsenc As aipinsenc = (From p In _db.aipinsenc
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).SingleOrDefault
            Return aipinsenc
        End Function

        <HttpPost()> _
        Public Function selaipinsenc() As List(Of aipinsenc)
            Dim lista_aipinsenc As List(Of aipinsenc) = (From p In _db.aipinsenc
                                                        Select p).ToList
            '
            Return lista_aipinsenc
        End Function


        <HttpPost()> _
           Public Function selaipinsencxwheredinamicopag(petiaipinsencpaglist As petiaipinsencpaglist) As respaipinsencpaglist
            Dim sb As New StringBuilder("")
            '
            If petiaipinsencpaglist.aipinsenc.idaipinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsenc=")
                    sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.idaipinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsenc=")
                        sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.idaipinsenc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.idaipactivperi <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipactivperi=")
                    sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.idaipactivperi))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipactivperi=")
                        sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.idaipactivperi))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.idaipinsintext <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsintext=")
                    sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.idaipinsintext))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsintext=")
                        sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.idaipinsintext))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.itipoinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.itipoinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.itipoinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itipoinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.itipoinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.idaipinsmotiv <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsmotiv=")
                    sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.idaipinsmotiv))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsmotiv=")
                        sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.idaipinsmotiv))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.itipoperitinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.itipoperitinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.itipoperitinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itipoperitinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.itipoperitinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.iorigeninsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iorigeninsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.iorigeninsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iorigeninsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.iorigeninsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.idsegmanusuperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuperit=")
                    sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.idsegmanusuperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuperit=")
                        sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.idsegmanusuperit))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.idsegmanusuaudit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuaudit=")
                    sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.idsegmanusuaudit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuaudit=")
                        sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.idsegmanusuaudit))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.xcedpropinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcedpropinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.xcedpropinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcedpropinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.xcedpropinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.xcedsidoinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcedsidoinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.xcedsidoinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcedsidoinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.xcedsidoinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.xplacinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xplacinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.xplacinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xplacinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.xplacinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.xsermotinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xsermotinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.xsermotinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xsermotinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.xsermotinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.xsercarrinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xsercarrinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.xsercarrinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xsercarrinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.xsercarrinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.xnumpolinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnumpolinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.xnumpolinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnumpolinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.xnumpolinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.xnumsininsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnumsininsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.xnumsininsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnumsininsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.xnumsininsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.xllavinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xllavinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.xllavinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xllavinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.xllavinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.xnomprodinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnomprodinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.xnomprodinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnomprodinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.xnomprodinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.xnomprodtorinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnomprodtorinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.xnomprodtorinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnomprodtorinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.xnomprodtorinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.xnomramopolizinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnomramopolizinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.xnomramopolizinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnomramopolizinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.xnomramopolizinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.xnomsucinsinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnomsucinsinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.xnomsucinsinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnomsucinsinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.xnomsucinsinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.fcreainsenc > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fcreainsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsencpaglist.aipinsenc.fcreainsenc)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fcreainsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsencpaglist.aipinsenc.fcreainsenc)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.fprocinsenc > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fprocinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsencpaglist.aipinsenc.fprocinsenc)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fprocinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsencpaglist.aipinsenc.fprocinsenc)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.faudinsenc > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.faudinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsencpaglist.aipinsenc.faudinsenc)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.faudinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsencpaglist.aipinsenc.faudinsenc)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.fultrechinsenc > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fultrechinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsencpaglist.aipinsenc.fultrechinsenc)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fultrechinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsencpaglist.aipinsenc.fultrechinsenc)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.irechinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.irechinsenc=")
                    sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.irechinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.irechinsenc=")
                        sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.irechinsenc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.xmotcrechinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xmotcrechinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.xmotcrechinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xmotcrechinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.xmotcrechinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.fcancinsenc > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fcancinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsencpaglist.aipinsenc.fcancinsenc)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fcancinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsencpaglist.aipinsenc.fcancinsenc)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.facepinsenc > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.facepinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsencpaglist.aipinsenc.facepinsenc)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.facepinsenc >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsencpaglist.aipinsenc.facepinsenc)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.xdescinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdescinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.xdescinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdescinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.xdescinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.icerrarinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.icerrarinsenc=")
                    sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.icerrarinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.icerrarinsenc=")
                        sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.icerrarinsenc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.iestatinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestatinsenc='")
                    sb.Append(petiaipinsencpaglist.aipinsenc.iestatinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatinsenc='")
                        sb.Append(petiaipinsencpaglist.aipinsenc.iestatinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsencpaglist.aipinsenc.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petiaipinsencpaglist.aipinsenc.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respaipinsencpaglist As New respaipinsencpaglist
            respaipinsencpaglist.pagaipinsenc = petiaipinsencpaglist.pagaipinsenc
            Dim skip = skip_paginacion(petiaipinsencpaglist.pagaipinsenc.npagactual, petiaipinsencpaglist.pagaipinsenc.npagtamano)

            If sb.ToString = "" Then
                respaipinsencpaglist.lista_aipinsenc = _db.aipinsenc.OrderBy(petiaipinsencpaglist.pagaipinsenc.xcamposord & " " & petiaipinsencpaglist.pagaipinsenc.idirord).Skip(skip).Take(petiaipinsencpaglist.pagaipinsenc.npagtamano).ToList
            Else
                respaipinsencpaglist.lista_aipinsenc = _db.aipinsenc.Where(sb.ToString).OrderBy(petiaipinsencpaglist.pagaipinsenc.xcamposord & " " & petiaipinsencpaglist.pagaipinsenc.idirord).Skip(skip).Take(petiaipinsencpaglist.pagaipinsenc.npagtamano).ToList
            End If
            '
            If (respaipinsencpaglist.lista_aipinsenc.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selaipinsencxwheredinamicocount(sb)
                respaipinsencpaglist.pagaipinsenc.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinsencpaglist.pagaipinsenc.npagtamano)
            Else
                respaipinsencpaglist.pagaipinsenc.npagcantidad = 0
                respaipinsencpaglist.pagaipinsenc.npagactual = 0
            End If

            Return respaipinsencpaglist
        End Function

        Public Function selaipinsencxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.aipinsenc.count
            Else
                Return _db.aipinsenc.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
        Public Function insaipinsenc(aipinsenc As aipinsenc) As respopera
            Try
                Dim respopera As New respopera
                If ConfigurationManager.AppSettings("motoddb") = "sql" Then
                    Dim param1 As New SqlClient.SqlParameter
                    param1.SqlDbType = SqlDbType.VarChar
                    param1.Size = 20
                    param1.Value = "insertar"
                    param1.ParameterName = "p_ioperacion"

                    Dim param2 As New SqlClient.SqlParameter
                    param2.SqlDbType = SqlDbType.Decimal
                    param2.Precision = 18
                    param2.Scale = 0
                    param2.Value = 0
                    param2.ParameterName = "p_idsegmanusulog"

                    Dim param3 As New SqlClient.SqlParameter
                    param3.SqlDbType = SqlDbType.VarChar
                    param3.Size = 20
                    param3.Value = "aipauto"
                    param3.ParameterName = "p_xnombrecortolog"

                    Dim param4 As New SqlClient.SqlParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
                    param4.SqlDbType = SqlDbType.VarChar
                    param4.Size = 1
                    param4.ParameterName = "p_irespuesta"
                    param4.Direction = ParameterDirection.Output

                    Dim param5 As New SqlClient.SqlParameter
                    param5.SqlDbType = SqlDbType.VarChar
                    param5.Size = 300
                    param5.ParameterName = "p_xmsjusuario"
                    param5.Direction = ParameterDirection.Output

                    Dim param6 As New SqlClient.SqlParameter
                    param6.SqlDbType = SqlDbType.VarChar
                    param6.Size = 300
                    param6.ParameterName = "p_xmsjtecnico"
                    param6.Direction = ParameterDirection.Output

                    Dim param7 As New SqlClient.SqlParameter
                    param7.SqlDbType = SqlDbType.VarChar
                    param7.Size = 300
                    param7.ParameterName = "p_coderrorlog"
                    param7.Direction = ParameterDirection.Output

                    'Paramestros de la tabla

                    Dim param8 As New SqlClient.SqlParameter
                    param8.SqlDbType = SqlDbType.Decimal
                    param8.Precision = 18
                    param8.Scale = 0
                    param8.Value = 0
                    param8.ParameterName = "p_idaipinsenc"
                    param8.Direction = ParameterDirection.Output

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinsenc.idaipactivperi
                    param9.ParameterName = "p_idaipactivperi"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinsenc.idaipinsintext
                    param10.ParameterName = "p_idaipinsintext"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 50
                    If aipinsenc.itipoinsenc IsNot Nothing Then
                        param11.Value = aipinsenc.itipoinsenc
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_itipoinsenc"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Decimal
                    param12.Precision = 18
                    param12.Scale = 0
                    param12.Value = aipinsenc.idaipinsmotiv
                    param12.ParameterName = "p_idaipinsmotiv"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 20
                    If aipinsenc.itipoperitinsenc IsNot Nothing Then
                        param13.Value = aipinsenc.itipoperitinsenc
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_itipoperitinsenc"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 20
                    If aipinsenc.iorigeninsenc IsNot Nothing Then
                        param14.Value = aipinsenc.iorigeninsenc
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_iorigeninsenc"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.Decimal
                    param15.Precision = 18
                    param15.Scale = 0
                    param15.Value = aipinsenc.idsegmanusuperit
                    param15.ParameterName = "p_idsegmanusuperit"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Decimal
                    param16.Precision = 18
                    param16.Scale = 0
                    param16.Value = aipinsenc.idsegmanusuaudit
                    param16.ParameterName = "p_idsegmanusuaudit"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 20
                    If aipinsenc.xcedpropinsenc IsNot Nothing Then
                        param17.Value = aipinsenc.xcedpropinsenc
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xcedpropinsenc"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 20
                    If aipinsenc.xcedsidoinsenc IsNot Nothing Then
                        param18.Value = aipinsenc.xcedsidoinsenc
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xcedsidoinsenc"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 20
                    If aipinsenc.xplacinsenc IsNot Nothing Then
                        param19.Value = aipinsenc.xplacinsenc
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_xplacinsenc"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 30
                    If aipinsenc.xsermotinsenc IsNot Nothing Then
                        param20.Value = aipinsenc.xsermotinsenc
                    Else
                        param20.Value = ""
                    End If
                    param20.ParameterName = "p_xsermotinsenc"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 30
                    If aipinsenc.xsercarrinsenc IsNot Nothing Then
                        param21.Value = aipinsenc.xsercarrinsenc
                    Else
                        param21.Value = ""
                    End If
                    param21.ParameterName = "p_xsercarrinsenc"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.VarChar
                    param22.Size = 50
                    If aipinsenc.xnumpolinsenc IsNot Nothing Then
                        param22.Value = aipinsenc.xnumpolinsenc
                    Else
                        param22.Value = ""
                    End If
                    param22.ParameterName = "p_xnumpolinsenc"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.VarChar
                    param23.Size = 50
                    If aipinsenc.xnumsininsenc IsNot Nothing Then
                        param23.Value = aipinsenc.xnumsininsenc
                    Else
                        param23.Value = ""
                    End If
                    param23.ParameterName = "p_xnumsininsenc"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.VarChar
                    param24.Size = 200
                    If aipinsenc.xllavinsenc IsNot Nothing Then
                        param24.Value = aipinsenc.xllavinsenc
                    Else
                        param24.Value = ""
                    End If
                    param24.ParameterName = "p_xllavinsenc"

                    Dim param25 As New SqlClient.SqlParameter
                    param25.SqlDbType = SqlDbType.VarChar
                    param25.Size = 100
                    If aipinsenc.xnomprodinsenc IsNot Nothing Then
                        param25.Value = aipinsenc.xnomprodinsenc
                    Else
                        param25.Value = ""
                    End If
                    param25.ParameterName = "p_xnomprodinsenc"

                    Dim param26 As New SqlClient.SqlParameter
                    param26.SqlDbType = SqlDbType.VarChar
                    param26.Size = 100
                    If aipinsenc.xnomprodtorinsenc IsNot Nothing Then
                        param26.Value = aipinsenc.xnomprodtorinsenc
                    Else
                        param26.Value = ""
                    End If
                    param26.ParameterName = "p_xnomprodtorinsenc"

                    Dim param27 As New SqlClient.SqlParameter
                    param27.SqlDbType = SqlDbType.VarChar
                    param27.Size = 100
                    If aipinsenc.xnomramopolizinsenc IsNot Nothing Then
                        param27.Value = aipinsenc.xnomramopolizinsenc
                    Else
                        param27.Value = ""
                    End If
                    param27.ParameterName = "p_xnomramopolizinsenc"

                    Dim param28 As New SqlClient.SqlParameter
                    param28.SqlDbType = SqlDbType.VarChar
                    param28.Size = 100
                    If aipinsenc.xnomsucinsinsenc IsNot Nothing Then
                        param28.Value = aipinsenc.xnomsucinsinsenc
                    Else
                        param28.Value = ""
                    End If
                    param28.ParameterName = "p_xnomsucinsinsenc"

                    Dim param29 As New SqlClient.SqlParameter
                    param29.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.fcreainsenc > CDate("01-01-1900") Then
                        param29.Value = aipinsenc.fcreainsenc
                    Else
                        param29.Value = CDate("01-01-1900")
                    End If
                    param29.ParameterName = "p_fcreainsenc"

                    Dim param30 As New SqlClient.SqlParameter
                    param30.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.fprocinsenc > CDate("01-01-1900") Then
                        param30.Value = aipinsenc.fprocinsenc
                    Else
                        param30.Value = CDate("01-01-1900")
                    End If
                    param30.ParameterName = "p_fprocinsenc"

                    Dim param31 As New SqlClient.SqlParameter
                    param31.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.faudinsenc > CDate("01-01-1900") Then
                        param31.Value = aipinsenc.faudinsenc
                    Else
                        param31.Value = CDate("01-01-1900")
                    End If
                    param31.ParameterName = "p_faudinsenc"

                    Dim param32 As New SqlClient.SqlParameter
                    param32.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.fultrechinsenc > CDate("01-01-1900") Then
                        param32.Value = aipinsenc.fultrechinsenc
                    Else
                        param32.Value = CDate("01-01-1900")
                    End If
                    param32.ParameterName = "p_fultrechinsenc"

                    Dim param33 As New SqlClient.SqlParameter
                    param33.SqlDbType = SqlDbType.Bit
                    param33.Value = aipinsenc.irechinsenc
                    param33.ParameterName = "p_irechinsenc"

                    Dim param34 As New SqlClient.SqlParameter
                    param34.SqlDbType = SqlDbType.VarChar
                    param34.Size = 500
                    If aipinsenc.xmotcrechinsenc IsNot Nothing Then
                        param34.Value = aipinsenc.xmotcrechinsenc
                    Else
                        param34.Value = ""
                    End If
                    param34.ParameterName = "p_xmotcrechinsenc"

                    Dim param35 As New SqlClient.SqlParameter
                    param35.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.fcancinsenc > CDate("01-01-1900") Then
                        param35.Value = aipinsenc.fcancinsenc
                    Else
                        param35.Value = CDate("01-01-1900")
                    End If
                    param35.ParameterName = "p_fcancinsenc"

                    Dim param36 As New SqlClient.SqlParameter
                    param36.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.facepinsenc > CDate("01-01-1900") Then
                        param36.Value = aipinsenc.facepinsenc
                    Else
                        param36.Value = CDate("01-01-1900")
                    End If
                    param36.ParameterName = "p_facepinsenc"

                    Dim param37 As New SqlClient.SqlParameter
                    param37.SqlDbType = SqlDbType.VarChar
                    param37.Size = 500
                    If aipinsenc.xdescinsenc IsNot Nothing Then
                        param37.Value = aipinsenc.xdescinsenc
                    Else
                        param37.Value = ""
                    End If
                    param37.ParameterName = "p_xdescinsenc"

                    Dim param38 As New SqlClient.SqlParameter
                    param38.SqlDbType = SqlDbType.Bit
                    param38.Value = aipinsenc.icerrarinsenc
                    param38.ParameterName = "p_icerrarinsenc"

                    Dim param39 As New SqlClient.SqlParameter
                    param39.SqlDbType = SqlDbType.VarChar
                    param39.Size = 20
                    If aipinsenc.iestatinsenc IsNot Nothing Then
                        param39.Value = aipinsenc.iestatinsenc
                    Else
                        param39.Value = ""
                    End If
                    param39.ParameterName = "p_iestatinsenc"

                    Dim param40 As New SqlClient.SqlParameter
                    param40.SqlDbType = SqlDbType.Decimal
                    param40.Precision = 18
                    param40.Scale = 0
                    param40.Value = 0
                    param40.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsenc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsenc output,@p_idaipactivperi,@p_idaipinsintext,@p_itipoinsenc,@p_idaipinsmotiv,@p_itipoperitinsenc,@p_iorigeninsenc,@p_idsegmanusuperit,@p_idsegmanusuaudit,@p_xcedpropinsenc,@p_xcedsidoinsenc,@p_xplacinsenc,@p_xsermotinsenc,@p_xsercarrinsenc,@p_xnumpolinsenc,@p_xnumsininsenc,@p_xllavinsenc,@p_xnomprodinsenc,@p_xnomprodtorinsenc,@p_xnomramopolizinsenc,@p_xnomsucinsinsenc,@p_fcreainsenc,@p_fprocinsenc,@p_faudinsenc,@p_fultrechinsenc,@p_irechinsenc,@p_xmotcrechinsenc,@p_fcancinsenc,@p_facepinsenc,@p_xdescinsenc,@p_icerrarinsenc,@p_iestatinsenc,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40)


                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = insaipinsencoracle(aipinsenc)
                End If
                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        <HttpPost()> _
           Public Function insaipinsencoracle(aipinsenc As aipinsenc) As respopera
            Try

                Dim param1 As New Client.OracleParameter
                param1.OracleDbType = Client.OracleDbType.Varchar2
                param1.Size = 20
                param1.Value = "insertar"
                param1.ParameterName = "p_ioperacion"

                Dim param2 As New Client.OracleParameter
                param2.OracleDbType = Client.OracleDbType.Decimal
                param2.Precision = 18
                param2.Scale = 0
                param2.Value = 0
                param2.ParameterName = "p_idsegmanusulog"

                Dim param3 As New Client.OracleParameter
                param3.OracleDbType = Client.OracleDbType.Varchar2
                param3.Size = 20
                param3.value = "aipauto"
                param3.ParameterName = "p_xnombrecortolog"

                Dim param4 As New Client.OracleParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
                param4.OracleDbType = Client.OracleDbType.Varchar2
                param4.Size = 1
                param4.ParameterName = "p_irespuesta"
                param4.Direction = ParameterDirection.Output

                Dim param5 As New Client.OracleParameter
                param5.OracleDbType = Client.OracleDbType.Varchar2
                param5.Size = 300
                param5.ParameterName = "p_xmsjusuario"
                param5.Direction = ParameterDirection.Output

                Dim param6 As New Client.OracleParameter
                param6.OracleDbType = Client.OracleDbType.Varchar2
                param6.Size = 300
                param6.ParameterName = "p_xmsjtecnico"
                param6.Direction = ParameterDirection.Output

                Dim param7 As New Client.OracleParameter
                param7.OracleDbType = Client.OracleDbType.Varchar2
                param7.Size = 300
                param7.ParameterName = "p_coderrorlog"
                param7.Direction = ParameterDirection.Output

                'Paramestros de la tabla

                Dim param8 As New Client.OracleParameter
                param8.OracleDbType = Client.OracleDbType.Decimal
                param8.Precision = 18
                param8.Scale = 0
                param8.Value = 0
                param8.ParameterName = "p_idaipinsenc"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsenc.idaipactivperi
                param9.ParameterName = "p_idaipactivperi"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinsenc.idaipinsintext
                param10.ParameterName = "p_idaipinsintext"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.VARCHAR2
                param11.Size = 50
                If aipinsenc.itipoinsenc IsNot Nothing And aipinsenc.itipoinsenc <> "" Then
                    param11.Value = aipinsenc.itipoinsenc
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_itipoinsenc"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = aipinsenc.idaipinsmotiv
                param12.ParameterName = "p_idaipinsmotiv"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 20
                If aipinsenc.itipoperitinsenc IsNot Nothing And aipinsenc.itipoperitinsenc <> "" Then
                    param13.Value = aipinsenc.itipoperitinsenc
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_itipoperitinsenc"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 20
                If aipinsenc.iorigeninsenc IsNot Nothing And aipinsenc.iorigeninsenc <> "" Then
                    param14.Value = aipinsenc.iorigeninsenc
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_iorigeninsenc"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = aipinsenc.idsegmanusuperit
                param15.ParameterName = "p_idsegmanusuperit"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = aipinsenc.idsegmanusuaudit
                param16.ParameterName = "p_idsegmanusuaudit"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 20
                If aipinsenc.xcedpropinsenc IsNot Nothing And aipinsenc.xcedpropinsenc <> "" Then
                    param17.Value = aipinsenc.xcedpropinsenc
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xcedpropinsenc"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.VARCHAR2
                param18.Size = 20
                If aipinsenc.xcedsidoinsenc IsNot Nothing And aipinsenc.xcedsidoinsenc <> "" Then
                    param18.Value = aipinsenc.xcedsidoinsenc
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_xcedsidoinsenc"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.VARCHAR2
                param19.Size = 20
                If aipinsenc.xplacinsenc IsNot Nothing And aipinsenc.xplacinsenc <> "" Then
                    param19.Value = aipinsenc.xplacinsenc
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_xplacinsenc"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.VARCHAR2
                param20.Size = 30
                If aipinsenc.xsermotinsenc IsNot Nothing And aipinsenc.xsermotinsenc <> "" Then
                    param20.Value = aipinsenc.xsermotinsenc
                Else
                    param20.Value = " "
                End If
                param20.ParameterName = "p_xsermotinsenc"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.VARCHAR2
                param21.Size = 30
                If aipinsenc.xsercarrinsenc IsNot Nothing And aipinsenc.xsercarrinsenc <> "" Then
                    param21.Value = aipinsenc.xsercarrinsenc
                Else
                    param21.Value = " "
                End If
                param21.ParameterName = "p_xsercarrinsenc"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.VARCHAR2
                param22.Size = 50
                If aipinsenc.xnumpolinsenc IsNot Nothing And aipinsenc.xnumpolinsenc <> "" Then
                    param22.Value = aipinsenc.xnumpolinsenc
                Else
                    param22.Value = " "
                End If
                param22.ParameterName = "p_xnumpolinsenc"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.VARCHAR2
                param23.Size = 50
                If aipinsenc.xnumsininsenc IsNot Nothing And aipinsenc.xnumsininsenc <> "" Then
                    param23.Value = aipinsenc.xnumsininsenc
                Else
                    param23.Value = " "
                End If
                param23.ParameterName = "p_xnumsininsenc"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.VARCHAR2
                param24.Size = 200
                If aipinsenc.xllavinsenc IsNot Nothing And aipinsenc.xllavinsenc <> "" Then
                    param24.Value = aipinsenc.xllavinsenc
                Else
                    param24.Value = " "
                End If
                param24.ParameterName = "p_xllavinsenc"

                Dim param25 As New Client.OracleParameter
                param25.OracleDbType = Client.OracleDbType.VARCHAR2
                param25.Size = 100
                If aipinsenc.xnomprodinsenc IsNot Nothing And aipinsenc.xnomprodinsenc <> "" Then
                    param25.Value = aipinsenc.xnomprodinsenc
                Else
                    param25.Value = " "
                End If
                param25.ParameterName = "p_xnomprodinsenc"

                Dim param26 As New Client.OracleParameter
                param26.OracleDbType = Client.OracleDbType.VARCHAR2
                param26.Size = 100
                If aipinsenc.xnomprodtorinsenc IsNot Nothing And aipinsenc.xnomprodtorinsenc <> "" Then
                    param26.Value = aipinsenc.xnomprodtorinsenc
                Else
                    param26.Value = " "
                End If
                param26.ParameterName = "p_xnomprodtorinsenc"

                Dim param27 As New Client.OracleParameter
                param27.OracleDbType = Client.OracleDbType.VARCHAR2
                param27.Size = 100
                If aipinsenc.xnomramopolizinsenc IsNot Nothing And aipinsenc.xnomramopolizinsenc <> "" Then
                    param27.Value = aipinsenc.xnomramopolizinsenc
                Else
                    param27.Value = " "
                End If
                param27.ParameterName = "p_xnomramopolizinsenc"

                Dim param28 As New Client.OracleParameter
                param28.OracleDbType = Client.OracleDbType.VARCHAR2
                param28.Size = 100
                If aipinsenc.xnomsucinsinsenc IsNot Nothing And aipinsenc.xnomsucinsinsenc <> "" Then
                    param28.Value = aipinsenc.xnomsucinsinsenc
                Else
                    param28.Value = " "
                End If
                param28.ParameterName = "p_xnomsucinsinsenc"

                Dim param29 As New Client.OracleParameter
                param29.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.fcreainsenc > CDate("01-01-1900") Then
                    param29.Value = aipinsenc.fcreainsenc
                Else
                    param29.Value = CDate("01-01-1900")
                End If
                param29.ParameterName = "p_fcreainsenc"

                Dim param30 As New Client.OracleParameter
                param30.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.fprocinsenc > CDate("01-01-1900") Then
                    param30.Value = aipinsenc.fprocinsenc
                Else
                    param30.Value = CDate("01-01-1900")
                End If
                param30.ParameterName = "p_fprocinsenc"

                Dim param31 As New Client.OracleParameter
                param31.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.faudinsenc > CDate("01-01-1900") Then
                    param31.Value = aipinsenc.faudinsenc
                Else
                    param31.Value = CDate("01-01-1900")
                End If
                param31.ParameterName = "p_faudinsenc"

                Dim param32 As New Client.OracleParameter
                param32.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.fultrechinsenc > CDate("01-01-1900") Then
                    param32.Value = aipinsenc.fultrechinsenc
                Else
                    param32.Value = CDate("01-01-1900")
                End If
                param32.ParameterName = "p_fultrechinsenc"

                Dim param33 As New Client.OracleParameter
                param33.OracleDbType = Client.OracleDbType.Int16
                param33.Value = aipinsenc.irechinsenc
                param33.ParameterName = "p_irechinsenc"

                Dim param34 As New Client.OracleParameter
                param34.OracleDbType = Client.OracleDbType.VARCHAR2
                param34.Size = 500
                If aipinsenc.xmotcrechinsenc IsNot Nothing And aipinsenc.xmotcrechinsenc <> "" Then
                    param34.Value = aipinsenc.xmotcrechinsenc
                Else
                    param34.Value = " "
                End If
                param34.ParameterName = "p_xmotcrechinsenc"

                Dim param35 As New Client.OracleParameter
                param35.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.fcancinsenc > CDate("01-01-1900") Then
                    param35.Value = aipinsenc.fcancinsenc
                Else
                    param35.Value = CDate("01-01-1900")
                End If
                param35.ParameterName = "p_fcancinsenc"

                Dim param36 As New Client.OracleParameter
                param36.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.facepinsenc > CDate("01-01-1900") Then
                    param36.Value = aipinsenc.facepinsenc
                Else
                    param36.Value = CDate("01-01-1900")
                End If
                param36.ParameterName = "p_facepinsenc"

                Dim param37 As New Client.OracleParameter
                param37.OracleDbType = Client.OracleDbType.VARCHAR2
                param37.Size = 500
                If aipinsenc.xdescinsenc IsNot Nothing And aipinsenc.xdescinsenc <> "" Then
                    param37.Value = aipinsenc.xdescinsenc
                Else
                    param37.Value = " "
                End If
                param37.ParameterName = "p_xdescinsenc"

                Dim param38 As New Client.OracleParameter
                param38.OracleDbType = Client.OracleDbType.Int16
                param38.Value = aipinsenc.icerrarinsenc
                param38.ParameterName = "p_icerrarinsenc"

                Dim param39 As New Client.OracleParameter
                param39.OracleDbType = Client.OracleDbType.VARCHAR2
                param39.Size = 20
                If aipinsenc.iestatinsenc IsNot Nothing And aipinsenc.iestatinsenc <> "" Then
                    param39.Value = aipinsenc.iestatinsenc
                Else
                    param39.Value = " "
                End If
                param39.ParameterName = "p_iestatinsenc"

                Dim param40 As New Client.OracleParameter
                param40.OracleDbType = Client.OracleDbType.Decimal
                param40.Precision = 18
                param40.Scale = 0
                param40.Value = 0
                param40.ParameterName = "p_idseglogreg"

                Dim param41 As New Client.OracleParameter
                param41.OracleDbType = Client.OracleDbType.Varchar2
                param41.Size = 50
                param41.Value = 0
                If aipinsenc.xnuminspinsenc IsNot Nothing And aipinsenc.xnuminspinsenc <> "" Then
                    param41.Value = aipinsenc.xnuminspinsenc
                Else
                    param41.Value = " "
                End If
                param41.ParameterName = "p_xnuminspinsenc"

                Dim param42 As New Client.OracleParameter
                param42.OracleDbType = Client.OracleDbType.Int16
                param42.Precision = 3
                param42.Scale = 0
                param42.Value = aipinsenc.nanexoinsenc
                param42.ParameterName = "p_nanexoinsenc"




                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinsenc FLOAT; v_p_idaipactivperi FLOAT; v_p_idaipinsintext FLOAT; v_p_itipoinsenc VARCHAR2(50); v_p_idaipinsmotiv FLOAT; v_p_itipoperitinsenc VARCHAR2(20); v_p_iorigeninsenc VARCHAR2(20); v_p_idsegmanusuperit FLOAT; v_p_idsegmanusuaudit FLOAT; v_p_xcedpropinsenc VARCHAR2(20); v_p_xcedsidoinsenc VARCHAR2(20); v_p_xplacinsenc VARCHAR2(20); v_p_xsermotinsenc VARCHAR2(30); v_p_xsercarrinsenc VARCHAR2(30); v_p_xnumpolinsenc VARCHAR2(50); v_p_xnumsininsenc VARCHAR2(50); v_p_xllavinsenc VARCHAR2(200); v_p_xnomprodinsenc VARCHAR2(100); v_p_xnomprodtorinsenc VARCHAR2(100); v_p_xnomramopolizinsenc VARCHAR2(100); v_p_xnomsucinsinsenc VARCHAR2(100); v_p_fcreainsenc date; v_p_fprocinsenc date; v_p_faudinsenc date; v_p_fultrechinsenc date; v_p_irechinsenc number; v_p_xmotcrechinsenc VARCHAR2(500); v_p_fcancinsenc date; v_p_facepinsenc date; v_p_xdescinsenc VARCHAR2(500); v_p_icerrarinsenc number; v_p_iestatinsenc VARCHAR2(20); v_p_idseglogreg FLOAT; v_p_xnuminspinsenc VARCHAR2(50); v_p_nanexoinsenc numeric(3,0); cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinsenc(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinsenc,:v_p_idaipactivperi,:v_p_idaipinsintext,:v_p_itipoinsenc,:v_p_idaipinsmotiv,:v_p_itipoperitinsenc,:v_p_iorigeninsenc,:v_p_idsegmanusuperit,:v_p_idsegmanusuaudit,:v_p_xcedpropinsenc,:v_p_xcedsidoinsenc,:v_p_xplacinsenc,:v_p_xsermotinsenc,:v_p_xsercarrinsenc,:v_p_xnumpolinsenc,:v_p_xnumsininsenc,:v_p_xllavinsenc,:v_p_xnomprodinsenc,:v_p_xnomprodtorinsenc,:v_p_xnomramopolizinsenc,:v_p_xnomsucinsinsenc,:v_p_fcreainsenc,:v_p_fprocinsenc,:v_p_faudinsenc,:v_p_fultrechinsenc,:v_p_irechinsenc,:v_p_xmotcrechinsenc,:v_p_fcancinsenc,:v_p_facepinsenc,:v_p_xdescinsenc,:v_p_icerrarinsenc,:v_p_iestatinsenc,:v_p_idseglogreg,:v_p_xnuminspinsenc,:v_p_nanexoinsenc, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40, param41, param42)

                Dim respopera As New respopera
                respopera.irespuesta = param4.Value.ToString()
                respopera.xmsjusuario = param5.Value.ToString()
                respopera.xmsjtecnico = param6.Value.ToString()
                If IsNumeric(param8.Value.ToString()) = True Then
                    respopera.id = Int(param8.Value.ToString())
                End If

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        <HttpPost()> _
        Public Function modaipinsenc(aipinsenc As aipinsenc) As respopera
            Try
                Dim respopera As New respopera
                If ConfigurationManager.AppSettings("motoddb") = "sql" Then
                    Dim param1 As New SqlClient.SqlParameter
                    param1.SqlDbType = SqlDbType.VarChar
                    param1.Size = 20
                    param1.Value = "actualizar"
                    param1.ParameterName = "p_ioperacion"

                    Dim param2 As New SqlClient.SqlParameter
                    param2.SqlDbType = SqlDbType.Decimal
                    param2.Precision = 18
                    param2.Scale = 0
                    param2.Value = 0
                    param2.ParameterName = "p_idsegmanusulog"

                    Dim param3 As New SqlClient.SqlParameter
                    param3.SqlDbType = SqlDbType.VarChar
                    param3.Size = 20
                    param3.Value = "aipauto"
                    param3.ParameterName = "p_xnombrecortolog"

                    Dim param4 As New SqlClient.SqlParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
                    param4.SqlDbType = SqlDbType.VarChar
                    param4.Size = 1
                    param4.ParameterName = "p_irespuesta"
                    param4.Direction = ParameterDirection.Output

                    Dim param5 As New SqlClient.SqlParameter
                    param5.SqlDbType = SqlDbType.VarChar
                    param5.Size = 300
                    param5.ParameterName = "p_xmsjusuario"
                    param5.Direction = ParameterDirection.Output

                    Dim param6 As New SqlClient.SqlParameter
                    param6.SqlDbType = SqlDbType.VarChar
                    param6.Size = 300
                    param6.ParameterName = "p_xmsjtecnico"
                    param6.Direction = ParameterDirection.Output

                    Dim param7 As New SqlClient.SqlParameter
                    param7.SqlDbType = SqlDbType.VarChar
                    param7.Size = 300
                    param7.ParameterName = "p_coderrorlog"
                    param7.Direction = ParameterDirection.Output

                    'Paramestros de la tabla

                    Dim param8 As New SqlClient.SqlParameter
                    param8.SqlDbType = SqlDbType.Decimal
                    param8.Precision = 18
                    param8.Scale = 0
                    param8.Value = aipinsenc.idaipinsenc
                    param8.ParameterName = "p_idaipinsenc"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinsenc.idaipactivperi
                    param9.ParameterName = "p_idaipactivperi"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinsenc.idaipinsintext
                    param10.ParameterName = "p_idaipinsintext"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 50
                    If aipinsenc.itipoinsenc IsNot Nothing Then
                        param11.Value = aipinsenc.itipoinsenc
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_itipoinsenc"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Decimal
                    param12.Precision = 18
                    param12.Scale = 0
                    param12.Value = aipinsenc.idaipinsmotiv
                    param12.ParameterName = "p_idaipinsmotiv"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 20
                    If aipinsenc.itipoperitinsenc IsNot Nothing Then
                        param13.Value = aipinsenc.itipoperitinsenc
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_itipoperitinsenc"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 20
                    If aipinsenc.iorigeninsenc IsNot Nothing Then
                        param14.Value = aipinsenc.iorigeninsenc
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_iorigeninsenc"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.Decimal
                    param15.Precision = 18
                    param15.Scale = 0
                    param15.Value = aipinsenc.idsegmanusuperit
                    param15.ParameterName = "p_idsegmanusuperit"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Decimal
                    param16.Precision = 18
                    param16.Scale = 0
                    param16.Value = aipinsenc.idsegmanusuaudit
                    param16.ParameterName = "p_idsegmanusuaudit"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 20
                    If aipinsenc.xcedpropinsenc IsNot Nothing Then
                        param17.Value = aipinsenc.xcedpropinsenc
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xcedpropinsenc"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 20
                    If aipinsenc.xcedsidoinsenc IsNot Nothing Then
                        param18.Value = aipinsenc.xcedsidoinsenc
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xcedsidoinsenc"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 20
                    If aipinsenc.xplacinsenc IsNot Nothing Then
                        param19.Value = aipinsenc.xplacinsenc
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_xplacinsenc"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 30
                    If aipinsenc.xsermotinsenc IsNot Nothing Then
                        param20.Value = aipinsenc.xsermotinsenc
                    Else
                        param20.Value = ""
                    End If
                    param20.ParameterName = "p_xsermotinsenc"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 30
                    If aipinsenc.xsercarrinsenc IsNot Nothing Then
                        param21.Value = aipinsenc.xsercarrinsenc
                    Else
                        param21.Value = ""
                    End If
                    param21.ParameterName = "p_xsercarrinsenc"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.VarChar
                    param22.Size = 50
                    If aipinsenc.xnumpolinsenc IsNot Nothing Then
                        param22.Value = aipinsenc.xnumpolinsenc
                    Else
                        param22.Value = ""
                    End If
                    param22.ParameterName = "p_xnumpolinsenc"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.VarChar
                    param23.Size = 50
                    If aipinsenc.xnumsininsenc IsNot Nothing Then
                        param23.Value = aipinsenc.xnumsininsenc
                    Else
                        param23.Value = ""
                    End If
                    param23.ParameterName = "p_xnumsininsenc"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.VarChar
                    param24.Size = 200
                    If aipinsenc.xllavinsenc IsNot Nothing Then
                        param24.Value = aipinsenc.xllavinsenc
                    Else
                        param24.Value = ""
                    End If
                    param24.ParameterName = "p_xllavinsenc"

                    Dim param25 As New SqlClient.SqlParameter
                    param25.SqlDbType = SqlDbType.VarChar
                    param25.Size = 100
                    If aipinsenc.xnomprodinsenc IsNot Nothing Then
                        param25.Value = aipinsenc.xnomprodinsenc
                    Else
                        param25.Value = ""
                    End If
                    param25.ParameterName = "p_xnomprodinsenc"

                    Dim param26 As New SqlClient.SqlParameter
                    param26.SqlDbType = SqlDbType.VarChar
                    param26.Size = 100
                    If aipinsenc.xnomprodtorinsenc IsNot Nothing Then
                        param26.Value = aipinsenc.xnomprodtorinsenc
                    Else
                        param26.Value = ""
                    End If
                    param26.ParameterName = "p_xnomprodtorinsenc"

                    Dim param27 As New SqlClient.SqlParameter
                    param27.SqlDbType = SqlDbType.VarChar
                    param27.Size = 100
                    If aipinsenc.xnomramopolizinsenc IsNot Nothing Then
                        param27.Value = aipinsenc.xnomramopolizinsenc
                    Else
                        param27.Value = ""
                    End If
                    param27.ParameterName = "p_xnomramopolizinsenc"

                    Dim param28 As New SqlClient.SqlParameter
                    param28.SqlDbType = SqlDbType.VarChar
                    param28.Size = 100
                    If aipinsenc.xnomsucinsinsenc IsNot Nothing Then
                        param28.Value = aipinsenc.xnomsucinsinsenc
                    Else
                        param28.Value = ""
                    End If
                    param28.ParameterName = "p_xnomsucinsinsenc"

                    Dim param29 As New SqlClient.SqlParameter
                    param29.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.fcreainsenc > CDate("01-01-1900") Then
                        param29.Value = aipinsenc.fcreainsenc
                    Else
                        param29.Value = CDate("01-01-1900")
                    End If
                    param29.ParameterName = "p_fcreainsenc"

                    Dim param30 As New SqlClient.SqlParameter
                    param30.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.fprocinsenc > CDate("01-01-1900") Then
                        param30.Value = aipinsenc.fprocinsenc
                    Else
                        param30.Value = CDate("01-01-1900")
                    End If
                    param30.ParameterName = "p_fprocinsenc"

                    Dim param31 As New SqlClient.SqlParameter
                    param31.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.faudinsenc > CDate("01-01-1900") Then
                        param31.Value = aipinsenc.faudinsenc
                    Else
                        param31.Value = CDate("01-01-1900")
                    End If
                    param31.ParameterName = "p_faudinsenc"

                    Dim param32 As New SqlClient.SqlParameter
                    param32.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.fultrechinsenc > CDate("01-01-1900") Then
                        param32.Value = aipinsenc.fultrechinsenc
                    Else
                        param32.Value = CDate("01-01-1900")
                    End If
                    param32.ParameterName = "p_fultrechinsenc"

                    Dim param33 As New SqlClient.SqlParameter
                    param33.SqlDbType = SqlDbType.Bit
                    param33.Value = aipinsenc.irechinsenc
                    param33.ParameterName = "p_irechinsenc"

                    Dim param34 As New SqlClient.SqlParameter
                    param34.SqlDbType = SqlDbType.VarChar
                    param34.Size = 500
                    If aipinsenc.xmotcrechinsenc IsNot Nothing Then
                        param34.Value = aipinsenc.xmotcrechinsenc
                    Else
                        param34.Value = ""
                    End If
                    param34.ParameterName = "p_xmotcrechinsenc"

                    Dim param35 As New SqlClient.SqlParameter
                    param35.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.fcancinsenc > CDate("01-01-1900") Then
                        param35.Value = aipinsenc.fcancinsenc
                    Else
                        param35.Value = CDate("01-01-1900")
                    End If
                    param35.ParameterName = "p_fcancinsenc"

                    Dim param36 As New SqlClient.SqlParameter
                    param36.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.facepinsenc > CDate("01-01-1900") Then
                        param36.Value = aipinsenc.facepinsenc
                    Else
                        param36.Value = CDate("01-01-1900")
                    End If
                    param36.ParameterName = "p_facepinsenc"

                    Dim param37 As New SqlClient.SqlParameter
                    param37.SqlDbType = SqlDbType.VarChar
                    param37.Size = 500
                    If aipinsenc.xdescinsenc IsNot Nothing Then
                        param37.Value = aipinsenc.xdescinsenc
                    Else
                        param37.Value = ""
                    End If
                    param37.ParameterName = "p_xdescinsenc"

                    Dim param38 As New SqlClient.SqlParameter
                    param38.SqlDbType = SqlDbType.Bit
                    param38.Value = aipinsenc.icerrarinsenc
                    param38.ParameterName = "p_icerrarinsenc"

                    Dim param39 As New SqlClient.SqlParameter
                    param39.SqlDbType = SqlDbType.VarChar
                    param39.Size = 20
                    If aipinsenc.iestatinsenc IsNot Nothing Then
                        param39.Value = aipinsenc.iestatinsenc
                    Else
                        param39.Value = ""
                    End If
                    param39.ParameterName = "p_iestatinsenc"

                    Dim param40 As New SqlClient.SqlParameter
                    param40.SqlDbType = SqlDbType.Decimal
                    param40.Precision = 18
                    param40.Scale = 0
                    param40.Value = aipinsenc.idseglogreg
                    param40.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsenc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsenc output,@p_idaipactivperi,@p_idaipinsintext,@p_itipoinsenc,@p_idaipinsmotiv,@p_itipoperitinsenc,@p_iorigeninsenc,@p_idsegmanusuperit,@p_idsegmanusuaudit,@p_xcedpropinsenc,@p_xcedsidoinsenc,@p_xplacinsenc,@p_xsermotinsenc,@p_xsercarrinsenc,@p_xnumpolinsenc,@p_xnumsininsenc,@p_xllavinsenc,@p_xnomprodinsenc,@p_xnomprodtorinsenc,@p_xnomramopolizinsenc,@p_xnomsucinsinsenc,@p_fcreainsenc,@p_fprocinsenc,@p_faudinsenc,@p_fultrechinsenc,@p_irechinsenc,@p_xmotcrechinsenc,@p_fcancinsenc,@p_facepinsenc,@p_xdescinsenc,@p_icerrarinsenc,@p_iestatinsenc,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = modaipinsencoracle(aipinsenc)
                End If
                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        <HttpPost()> _
        Public Function modaipinsencoracle(aipinsenc As aipinsenc) As respopera
            Try

                Dim param1 As New Client.OracleParameter
                param1.OracleDbType = Client.OracleDbType.Varchar2
                param1.Size = 20
                param1.Value = "actualizar"
                param1.ParameterName = "p_ioperacion"

                Dim param2 As New Client.OracleParameter
                param2.OracleDbType = Client.OracleDbType.Decimal
                param2.Precision = 18
                param2.Scale = 0
                param2.Value = 0
                param2.ParameterName = "p_idsegmanusulog"

                Dim param3 As New Client.OracleParameter
                param3.OracleDbType = Client.OracleDbType.Varchar2
                param3.Size = 20
                param3.value = "aipauto"
                param3.ParameterName = "p_xnombrecortolog"

                Dim param4 As New Client.OracleParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
                param4.OracleDbType = Client.OracleDbType.Varchar2
                param4.Size = 1
                param4.ParameterName = "p_irespuesta"
                param4.Direction = ParameterDirection.Output

                Dim param5 As New Client.OracleParameter
                param5.OracleDbType = Client.OracleDbType.Varchar2
                param5.Size = 300
                param5.ParameterName = "p_xmsjusuario"
                param5.Direction = ParameterDirection.Output

                Dim param6 As New Client.OracleParameter
                param6.OracleDbType = Client.OracleDbType.Varchar2
                param6.Size = 300
                param6.ParameterName = "p_xmsjtecnico"
                param6.Direction = ParameterDirection.Output

                Dim param7 As New Client.OracleParameter
                param7.OracleDbType = Client.OracleDbType.Varchar2
                param7.Size = 300
                param7.ParameterName = "p_coderrorlog"
                param7.Direction = ParameterDirection.Output

                'Paramestros de la tabla

                Dim param8 As New Client.OracleParameter
                param8.OracleDbType = Client.OracleDbType.Decimal
                param8.Precision = 18
                param8.Scale = 0
                param8.Value = aipinsenc.idaipinsenc
                param8.ParameterName = "p_idaipinsenc"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsenc.idaipactivperi
                param9.ParameterName = "p_idaipactivperi"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinsenc.idaipinsintext
                param10.ParameterName = "p_idaipinsintext"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.VARCHAR2
                param11.Size = 50
                If aipinsenc.itipoinsenc IsNot Nothing And aipinsenc.itipoinsenc <> "" Then
                    param11.Value = aipinsenc.itipoinsenc
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_itipoinsenc"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = aipinsenc.idaipinsmotiv
                param12.ParameterName = "p_idaipinsmotiv"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 20
                If aipinsenc.itipoperitinsenc IsNot Nothing And aipinsenc.itipoperitinsenc <> "" Then
                    param13.Value = aipinsenc.itipoperitinsenc
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_itipoperitinsenc"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 20
                If aipinsenc.iorigeninsenc IsNot Nothing And aipinsenc.iorigeninsenc <> "" Then
                    param14.Value = aipinsenc.iorigeninsenc
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_iorigeninsenc"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = aipinsenc.idsegmanusuperit
                param15.ParameterName = "p_idsegmanusuperit"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = aipinsenc.idsegmanusuaudit
                param16.ParameterName = "p_idsegmanusuaudit"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 20
                If aipinsenc.xcedpropinsenc IsNot Nothing And aipinsenc.xcedpropinsenc <> "" Then
                    param17.Value = aipinsenc.xcedpropinsenc
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xcedpropinsenc"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.VARCHAR2
                param18.Size = 20
                If aipinsenc.xcedsidoinsenc IsNot Nothing And aipinsenc.xcedsidoinsenc <> "" Then
                    param18.Value = aipinsenc.xcedsidoinsenc
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_xcedsidoinsenc"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.VARCHAR2
                param19.Size = 20
                If aipinsenc.xplacinsenc IsNot Nothing And aipinsenc.xplacinsenc <> "" Then
                    param19.Value = aipinsenc.xplacinsenc
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_xplacinsenc"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.VARCHAR2
                param20.Size = 30
                If aipinsenc.xsermotinsenc IsNot Nothing And aipinsenc.xsermotinsenc <> "" Then
                    param20.Value = aipinsenc.xsermotinsenc
                Else
                    param20.Value = " "
                End If
                param20.ParameterName = "p_xsermotinsenc"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.VARCHAR2
                param21.Size = 30
                If aipinsenc.xsercarrinsenc IsNot Nothing And aipinsenc.xsercarrinsenc <> "" Then
                    param21.Value = aipinsenc.xsercarrinsenc
                Else
                    param21.Value = " "
                End If
                param21.ParameterName = "p_xsercarrinsenc"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.VARCHAR2
                param22.Size = 50
                If aipinsenc.xnumpolinsenc IsNot Nothing And aipinsenc.xnumpolinsenc <> "" Then
                    param22.Value = aipinsenc.xnumpolinsenc
                Else
                    param22.Value = " "
                End If
                param22.ParameterName = "p_xnumpolinsenc"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.VARCHAR2
                param23.Size = 50
                If aipinsenc.xnumsininsenc IsNot Nothing And aipinsenc.xnumsininsenc <> "" Then
                    param23.Value = aipinsenc.xnumsininsenc
                Else
                    param23.Value = " "
                End If
                param23.ParameterName = "p_xnumsininsenc"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.VARCHAR2
                param24.Size = 200
                If aipinsenc.xllavinsenc IsNot Nothing And aipinsenc.xllavinsenc <> "" Then
                    param24.Value = aipinsenc.xllavinsenc
                Else
                    param24.Value = " "
                End If
                param24.ParameterName = "p_xllavinsenc"

                Dim param25 As New Client.OracleParameter
                param25.OracleDbType = Client.OracleDbType.VARCHAR2
                param25.Size = 100
                If aipinsenc.xnomprodinsenc IsNot Nothing And aipinsenc.xnomprodinsenc <> "" Then
                    param25.Value = aipinsenc.xnomprodinsenc
                Else
                    param25.Value = " "
                End If
                param25.ParameterName = "p_xnomprodinsenc"

                Dim param26 As New Client.OracleParameter
                param26.OracleDbType = Client.OracleDbType.VARCHAR2
                param26.Size = 100
                If aipinsenc.xnomprodtorinsenc IsNot Nothing And aipinsenc.xnomprodtorinsenc <> "" Then
                    param26.Value = aipinsenc.xnomprodtorinsenc
                Else
                    param26.Value = " "
                End If
                param26.ParameterName = "p_xnomprodtorinsenc"

                Dim param27 As New Client.OracleParameter
                param27.OracleDbType = Client.OracleDbType.VARCHAR2
                param27.Size = 100
                If aipinsenc.xnomramopolizinsenc IsNot Nothing And aipinsenc.xnomramopolizinsenc <> "" Then
                    param27.Value = aipinsenc.xnomramopolizinsenc
                Else
                    param27.Value = " "
                End If
                param27.ParameterName = "p_xnomramopolizinsenc"

                Dim param28 As New Client.OracleParameter
                param28.OracleDbType = Client.OracleDbType.VARCHAR2
                param28.Size = 100
                If aipinsenc.xnomsucinsinsenc IsNot Nothing And aipinsenc.xnomsucinsinsenc <> "" Then
                    param28.Value = aipinsenc.xnomsucinsinsenc
                Else
                    param28.Value = " "
                End If
                param28.ParameterName = "p_xnomsucinsinsenc"

                Dim param29 As New Client.OracleParameter
                param29.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.fcreainsenc > CDate("01-01-1900") Then
                    param29.Value = aipinsenc.fcreainsenc
                Else
                    param29.Value = CDate("01-01-1900")
                End If
                param29.ParameterName = "p_fcreainsenc"

                Dim param30 As New Client.OracleParameter
                param30.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.fprocinsenc > CDate("01-01-1900") Then
                    param30.Value = aipinsenc.fprocinsenc
                Else
                    param30.Value = CDate("01-01-1900")
                End If
                param30.ParameterName = "p_fprocinsenc"

                Dim param31 As New Client.OracleParameter
                param31.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.faudinsenc > CDate("01-01-1900") Then
                    param31.Value = aipinsenc.faudinsenc
                Else
                    param31.Value = CDate("01-01-1900")
                End If
                param31.ParameterName = "p_faudinsenc"

                Dim param32 As New Client.OracleParameter
                param32.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.fultrechinsenc > CDate("01-01-1900") Then
                    param32.Value = aipinsenc.fultrechinsenc
                Else
                    param32.Value = CDate("01-01-1900")
                End If
                param32.ParameterName = "p_fultrechinsenc"

                Dim param33 As New Client.OracleParameter
                param33.OracleDbType = Client.OracleDbType.Int16
                param33.Value = aipinsenc.irechinsenc
                param33.ParameterName = "p_irechinsenc"

                Dim param34 As New Client.OracleParameter
                param34.OracleDbType = Client.OracleDbType.VARCHAR2
                param34.Size = 500
                If aipinsenc.xmotcrechinsenc IsNot Nothing And aipinsenc.xmotcrechinsenc <> "" Then
                    param34.Value = aipinsenc.xmotcrechinsenc
                Else
                    param34.Value = " "
                End If
                param34.ParameterName = "p_xmotcrechinsenc"

                Dim param35 As New Client.OracleParameter
                param35.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.fcancinsenc > CDate("01-01-1900") Then
                    param35.Value = aipinsenc.fcancinsenc
                Else
                    param35.Value = CDate("01-01-1900")
                End If
                param35.ParameterName = "p_fcancinsenc"

                Dim param36 As New Client.OracleParameter
                param36.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.facepinsenc > CDate("01-01-1900") Then
                    param36.Value = aipinsenc.facepinsenc
                Else
                    param36.Value = CDate("01-01-1900")
                End If
                param36.ParameterName = "p_facepinsenc"

                Dim param37 As New Client.OracleParameter
                param37.OracleDbType = Client.OracleDbType.VARCHAR2
                param37.Size = 500
                If aipinsenc.xdescinsenc IsNot Nothing And aipinsenc.xdescinsenc <> "" Then
                    param37.Value = aipinsenc.xdescinsenc
                Else
                    param37.Value = " "
                End If
                param37.ParameterName = "p_xdescinsenc"

                Dim param38 As New Client.OracleParameter
                param38.OracleDbType = Client.OracleDbType.Int16
                param38.Value = aipinsenc.icerrarinsenc
                param38.ParameterName = "p_icerrarinsenc"

                Dim param39 As New Client.OracleParameter
                param39.OracleDbType = Client.OracleDbType.VARCHAR2
                param39.Size = 20
                If aipinsenc.iestatinsenc IsNot Nothing And aipinsenc.iestatinsenc <> "" Then
                    param39.Value = aipinsenc.iestatinsenc
                Else
                    param39.Value = " "
                End If
                param39.ParameterName = "p_iestatinsenc"

                Dim param40 As New Client.OracleParameter
                param40.OracleDbType = Client.OracleDbType.Decimal
                param40.Precision = 18
                param40.Scale = 0
                param40.Value = aipinsenc.idseglogreg
                param40.ParameterName = "p_idseglogreg"

                Dim param41 As New Client.OracleParameter
                param41.OracleDbType = Client.OracleDbType.Varchar2
                param41.Size = 50
                param41.Value = 0
                If aipinsenc.xnuminspinsenc IsNot Nothing And aipinsenc.xnuminspinsenc <> "" Then
                    param41.Value = aipinsenc.xnuminspinsenc
                Else
                    param41.Value = " "
                End If
                param41.ParameterName = "p_xnuminspinsenc"

                Dim param42 As New Client.OracleParameter
                param42.OracleDbType = Client.OracleDbType.Int16
                param42.Precision = 3
                param42.Scale = 0
                param42.Value = aipinsenc.nanexoinsenc
                param42.ParameterName = "p_nanexoinsenc"

                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinsenc FLOAT; v_p_idaipactivperi FLOAT; v_p_idaipinsintext FLOAT; v_p_itipoinsenc VARCHAR2(50); v_p_idaipinsmotiv FLOAT; v_p_itipoperitinsenc VARCHAR2(20); v_p_iorigeninsenc VARCHAR2(20); v_p_idsegmanusuperit FLOAT; v_p_idsegmanusuaudit FLOAT; v_p_xcedpropinsenc VARCHAR2(20); v_p_xcedsidoinsenc VARCHAR2(20); v_p_xplacinsenc VARCHAR2(20); v_p_xsermotinsenc VARCHAR2(30); v_p_xsercarrinsenc VARCHAR2(30); v_p_xnumpolinsenc VARCHAR2(50); v_p_xnumsininsenc VARCHAR2(50); v_p_xllavinsenc VARCHAR2(200); v_p_xnomprodinsenc VARCHAR2(100); v_p_xnomprodtorinsenc VARCHAR2(100); v_p_xnomramopolizinsenc VARCHAR2(100); v_p_xnomsucinsinsenc VARCHAR2(100); v_p_fcreainsenc date; v_p_fprocinsenc date; v_p_faudinsenc date; v_p_fultrechinsenc date; v_p_irechinsenc number; v_p_xmotcrechinsenc VARCHAR2(500); v_p_fcancinsenc date; v_p_facepinsenc date; v_p_xdescinsenc VARCHAR2(500); v_p_icerrarinsenc number; v_p_iestatinsenc VARCHAR2(20); v_p_idseglogreg FLOAT; v_p_xnuminspinsenc VARCHAR2(50); v_p_nanexoinsenc numeric(3,0);  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinsenc(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinsenc,:v_p_idaipactivperi,:v_p_idaipinsintext,:v_p_itipoinsenc,:v_p_idaipinsmotiv,:v_p_itipoperitinsenc,:v_p_iorigeninsenc,:v_p_idsegmanusuperit,:v_p_idsegmanusuaudit,:v_p_xcedpropinsenc,:v_p_xcedsidoinsenc,:v_p_xplacinsenc,:v_p_xsermotinsenc,:v_p_xsercarrinsenc,:v_p_xnumpolinsenc,:v_p_xnumsininsenc,:v_p_xllavinsenc,:v_p_xnomprodinsenc,:v_p_xnomprodtorinsenc,:v_p_xnomramopolizinsenc,:v_p_xnomsucinsinsenc,:v_p_fcreainsenc,:v_p_fprocinsenc,:v_p_faudinsenc,:v_p_fultrechinsenc,:v_p_irechinsenc,:v_p_xmotcrechinsenc,:v_p_fcancinsenc,:v_p_facepinsenc,:v_p_xdescinsenc,:v_p_icerrarinsenc,:v_p_iestatinsenc,:v_p_idseglogreg, :v_p_xnuminspinsenc,:v_p_nanexoinsenc, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40, param41, param42)

                Dim respopera As New respopera
                respopera.irespuesta = param4.Value.ToString()
                respopera.xmsjusuario = param5.Value.ToString()
                respopera.xmsjtecnico = param6.Value.ToString()
                If IsNumeric(param8.Value.ToString()) = True Then
                    respopera.id = Int(param8.Value.ToString())
                End If

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        <HttpPost()> _
        Public Function eliaipinsenc(aipinsenc As aipinsenc) As respopera
            Try
                Dim respopera As New respopera
                If ConfigurationManager.AppSettings("motoddb") = "sql" Then
                    Dim param1 As New SqlClient.SqlParameter
                    param1.SqlDbType = SqlDbType.VarChar
                    param1.Size = 20
                    param1.Value = "eliminar"
                    param1.ParameterName = "p_ioperacion"

                    Dim param2 As New SqlClient.SqlParameter
                    param2.SqlDbType = SqlDbType.Decimal
                    param2.Precision = 18
                    param2.Scale = 0
                    param2.Value = 0
                    param2.ParameterName = "p_idsegmanusulog"

                    Dim param3 As New SqlClient.SqlParameter
                    param3.SqlDbType = SqlDbType.VarChar
                    param3.Size = 20
                    param3.Value = "aipauto"
                    param3.ParameterName = "p_xnombrecortolog"

                    Dim param4 As New SqlClient.SqlParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
                    param4.SqlDbType = SqlDbType.VarChar
                    param4.Size = 1
                    param4.ParameterName = "p_irespuesta"
                    param4.Direction = ParameterDirection.Output

                    Dim param5 As New SqlClient.SqlParameter
                    param5.SqlDbType = SqlDbType.VarChar
                    param5.Size = 300
                    param5.ParameterName = "p_xmsjusuario"
                    param5.Direction = ParameterDirection.Output

                    Dim param6 As New SqlClient.SqlParameter
                    param6.SqlDbType = SqlDbType.VarChar
                    param6.Size = 300
                    param6.ParameterName = "p_xmsjtecnico"
                    param6.Direction = ParameterDirection.Output

                    Dim param7 As New SqlClient.SqlParameter
                    param7.SqlDbType = SqlDbType.VarChar
                    param7.Size = 300
                    param7.ParameterName = "p_coderrorlog"
                    param7.Direction = ParameterDirection.Output

                    'Paramestros de la tabla

                    Dim param8 As New SqlClient.SqlParameter
                    param8.SqlDbType = SqlDbType.Decimal
                    param8.Precision = 18
                    param8.Scale = 0
                    param8.Value = aipinsenc.idaipinsenc
                    param8.ParameterName = "p_idaipinsenc"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinsenc.idaipactivperi
                    param9.ParameterName = "p_idaipactivperi"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinsenc.idaipinsintext
                    param10.ParameterName = "p_idaipinsintext"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 50
                    If aipinsenc.itipoinsenc IsNot Nothing Then
                        param11.Value = aipinsenc.itipoinsenc
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_itipoinsenc"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Decimal
                    param12.Precision = 18
                    param12.Scale = 0
                    param12.Value = aipinsenc.idaipinsmotiv
                    param12.ParameterName = "p_idaipinsmotiv"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 20
                    If aipinsenc.itipoperitinsenc IsNot Nothing Then
                        param13.Value = aipinsenc.itipoperitinsenc
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_itipoperitinsenc"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 20
                    If aipinsenc.iorigeninsenc IsNot Nothing Then
                        param14.Value = aipinsenc.iorigeninsenc
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_iorigeninsenc"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.Decimal
                    param15.Precision = 18
                    param15.Scale = 0
                    param15.Value = aipinsenc.idsegmanusuperit
                    param15.ParameterName = "p_idsegmanusuperit"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Decimal
                    param16.Precision = 18
                    param16.Scale = 0
                    param16.Value = aipinsenc.idsegmanusuaudit
                    param16.ParameterName = "p_idsegmanusuaudit"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 20
                    If aipinsenc.xcedpropinsenc IsNot Nothing Then
                        param17.Value = aipinsenc.xcedpropinsenc
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xcedpropinsenc"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 20
                    If aipinsenc.xcedsidoinsenc IsNot Nothing Then
                        param18.Value = aipinsenc.xcedsidoinsenc
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xcedsidoinsenc"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 20
                    If aipinsenc.xplacinsenc IsNot Nothing Then
                        param19.Value = aipinsenc.xplacinsenc
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_xplacinsenc"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 30
                    If aipinsenc.xsermotinsenc IsNot Nothing Then
                        param20.Value = aipinsenc.xsermotinsenc
                    Else
                        param20.Value = ""
                    End If
                    param20.ParameterName = "p_xsermotinsenc"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 30
                    If aipinsenc.xsercarrinsenc IsNot Nothing Then
                        param21.Value = aipinsenc.xsercarrinsenc
                    Else
                        param21.Value = ""
                    End If
                    param21.ParameterName = "p_xsercarrinsenc"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.VarChar
                    param22.Size = 50
                    If aipinsenc.xnumpolinsenc IsNot Nothing Then
                        param22.Value = aipinsenc.xnumpolinsenc
                    Else
                        param22.Value = ""
                    End If
                    param22.ParameterName = "p_xnumpolinsenc"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.VarChar
                    param23.Size = 50
                    If aipinsenc.xnumsininsenc IsNot Nothing Then
                        param23.Value = aipinsenc.xnumsininsenc
                    Else
                        param23.Value = ""
                    End If
                    param23.ParameterName = "p_xnumsininsenc"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.VarChar
                    param24.Size = 200
                    If aipinsenc.xllavinsenc IsNot Nothing Then
                        param24.Value = aipinsenc.xllavinsenc
                    Else
                        param24.Value = ""
                    End If
                    param24.ParameterName = "p_xllavinsenc"

                    Dim param25 As New SqlClient.SqlParameter
                    param25.SqlDbType = SqlDbType.VarChar
                    param25.Size = 100
                    If aipinsenc.xnomprodinsenc IsNot Nothing Then
                        param25.Value = aipinsenc.xnomprodinsenc
                    Else
                        param25.Value = ""
                    End If
                    param25.ParameterName = "p_xnomprodinsenc"

                    Dim param26 As New SqlClient.SqlParameter
                    param26.SqlDbType = SqlDbType.VarChar
                    param26.Size = 100
                    If aipinsenc.xnomprodtorinsenc IsNot Nothing Then
                        param26.Value = aipinsenc.xnomprodtorinsenc
                    Else
                        param26.Value = ""
                    End If
                    param26.ParameterName = "p_xnomprodtorinsenc"

                    Dim param27 As New SqlClient.SqlParameter
                    param27.SqlDbType = SqlDbType.VarChar
                    param27.Size = 100
                    If aipinsenc.xnomramopolizinsenc IsNot Nothing Then
                        param27.Value = aipinsenc.xnomramopolizinsenc
                    Else
                        param27.Value = ""
                    End If
                    param27.ParameterName = "p_xnomramopolizinsenc"

                    Dim param28 As New SqlClient.SqlParameter
                    param28.SqlDbType = SqlDbType.VarChar
                    param28.Size = 100
                    If aipinsenc.xnomsucinsinsenc IsNot Nothing Then
                        param28.Value = aipinsenc.xnomsucinsinsenc
                    Else
                        param28.Value = ""
                    End If
                    param28.ParameterName = "p_xnomsucinsinsenc"

                    Dim param29 As New SqlClient.SqlParameter
                    param29.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.fcreainsenc > CDate("01-01-1900") Then
                        param29.Value = aipinsenc.fcreainsenc
                    Else
                        param29.Value = CDate("01-01-1900")
                    End If
                    param29.ParameterName = "p_fcreainsenc"

                    Dim param30 As New SqlClient.SqlParameter
                    param30.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.fprocinsenc > CDate("01-01-1900") Then
                        param30.Value = aipinsenc.fprocinsenc
                    Else
                        param30.Value = CDate("01-01-1900")
                    End If
                    param30.ParameterName = "p_fprocinsenc"

                    Dim param31 As New SqlClient.SqlParameter
                    param31.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.faudinsenc > CDate("01-01-1900") Then
                        param31.Value = aipinsenc.faudinsenc
                    Else
                        param31.Value = CDate("01-01-1900")
                    End If
                    param31.ParameterName = "p_faudinsenc"

                    Dim param32 As New SqlClient.SqlParameter
                    param32.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.fultrechinsenc > CDate("01-01-1900") Then
                        param32.Value = aipinsenc.fultrechinsenc
                    Else
                        param32.Value = CDate("01-01-1900")
                    End If
                    param32.ParameterName = "p_fultrechinsenc"

                    Dim param33 As New SqlClient.SqlParameter
                    param33.SqlDbType = SqlDbType.Bit
                    param33.Value = aipinsenc.irechinsenc
                    param33.ParameterName = "p_irechinsenc"

                    Dim param34 As New SqlClient.SqlParameter
                    param34.SqlDbType = SqlDbType.VarChar
                    param34.Size = 500
                    If aipinsenc.xmotcrechinsenc IsNot Nothing Then
                        param34.Value = aipinsenc.xmotcrechinsenc
                    Else
                        param34.Value = ""
                    End If
                    param34.ParameterName = "p_xmotcrechinsenc"

                    Dim param35 As New SqlClient.SqlParameter
                    param35.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.fcancinsenc > CDate("01-01-1900") Then
                        param35.Value = aipinsenc.fcancinsenc
                    Else
                        param35.Value = CDate("01-01-1900")
                    End If
                    param35.ParameterName = "p_fcancinsenc"

                    Dim param36 As New SqlClient.SqlParameter
                    param36.SqlDbType = SqlDbType.DateTime
                    If aipinsenc.facepinsenc > CDate("01-01-1900") Then
                        param36.Value = aipinsenc.facepinsenc
                    Else
                        param36.Value = CDate("01-01-1900")
                    End If
                    param36.ParameterName = "p_facepinsenc"

                    Dim param37 As New SqlClient.SqlParameter
                    param37.SqlDbType = SqlDbType.VarChar
                    param37.Size = 500
                    If aipinsenc.xdescinsenc IsNot Nothing Then
                        param37.Value = aipinsenc.xdescinsenc
                    Else
                        param37.Value = ""
                    End If
                    param37.ParameterName = "p_xdescinsenc"

                    Dim param38 As New SqlClient.SqlParameter
                    param38.SqlDbType = SqlDbType.Bit
                    param38.Value = aipinsenc.icerrarinsenc
                    param38.ParameterName = "p_icerrarinsenc"

                    Dim param39 As New SqlClient.SqlParameter
                    param39.SqlDbType = SqlDbType.VarChar
                    param39.Size = 20
                    If aipinsenc.iestatinsenc IsNot Nothing Then
                        param39.Value = aipinsenc.iestatinsenc
                    Else
                        param39.Value = ""
                    End If
                    param39.ParameterName = "p_iestatinsenc"

                    Dim param40 As New SqlClient.SqlParameter
                    param40.SqlDbType = SqlDbType.Decimal
                    param40.Precision = 18
                    param40.Scale = 0
                    param40.Value = aipinsenc.idseglogreg
                    param40.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsenc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsenc output,@p_idaipactivperi,@p_idaipinsintext,@p_itipoinsenc,@p_idaipinsmotiv,@p_itipoperitinsenc,@p_iorigeninsenc,@p_idsegmanusuperit,@p_idsegmanusuaudit,@p_xcedpropinsenc,@p_xcedsidoinsenc,@p_xplacinsenc,@p_xsermotinsenc,@p_xsercarrinsenc,@p_xnumpolinsenc,@p_xnumsininsenc,@p_xllavinsenc,@p_xnomprodinsenc,@p_xnomprodtorinsenc,@p_xnomramopolizinsenc,@p_xnomsucinsinsenc,@p_fcreainsenc,@p_fprocinsenc,@p_faudinsenc,@p_fultrechinsenc,@p_irechinsenc,@p_xmotcrechinsenc,@p_fcancinsenc,@p_facepinsenc,@p_xdescinsenc,@p_icerrarinsenc,@p_iestatinsenc,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipinsencoracle(aipinsenc)
                End If
                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        <HttpPost()> _
        Public Function eliaipinsencoracle(aipinsenc As aipinsenc) As respopera
            Try

                Dim param1 As New Client.OracleParameter
                param1.OracleDbType = Client.OracleDbType.Varchar2
                param1.Size = 20
                param1.Value = "eliminar"
                param1.ParameterName = "p_ioperacion"

                Dim param2 As New Client.OracleParameter
                param2.OracleDbType = Client.OracleDbType.Decimal
                param2.Precision = 18
                param2.Scale = 0
                param2.Value = 0
                param2.ParameterName = "p_idsegmanusulog"

                Dim param3 As New Client.OracleParameter
                param3.OracleDbType = Client.OracleDbType.Varchar2
                param3.Size = 20
                param3.value = "aipauto"
                param3.ParameterName = "p_xnombrecortolog"

                Dim param4 As New Client.OracleParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
                param4.OracleDbType = Client.OracleDbType.Varchar2
                param4.Size = 1
                param4.ParameterName = "p_irespuesta"
                param4.Direction = ParameterDirection.Output

                Dim param5 As New Client.OracleParameter
                param5.OracleDbType = Client.OracleDbType.Varchar2
                param5.Size = 300
                param5.ParameterName = "p_xmsjusuario"
                param5.Direction = ParameterDirection.Output

                Dim param6 As New Client.OracleParameter
                param6.OracleDbType = Client.OracleDbType.Varchar2
                param6.Size = 300
                param6.ParameterName = "p_xmsjtecnico"
                param6.Direction = ParameterDirection.Output

                Dim param7 As New Client.OracleParameter
                param7.OracleDbType = Client.OracleDbType.Varchar2
                param7.Size = 300
                param7.ParameterName = "p_coderrorlog"
                param7.Direction = ParameterDirection.Output

                'Paramestros de la tabla

                Dim param8 As New Client.OracleParameter
                param8.OracleDbType = Client.OracleDbType.Decimal
                param8.Precision = 18
                param8.Scale = 0
                param8.Value = aipinsenc.idaipinsenc
                param8.ParameterName = "p_idaipinsenc"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsenc.idaipactivperi
                param9.ParameterName = "p_idaipactivperi"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinsenc.idaipinsintext
                param10.ParameterName = "p_idaipinsintext"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.VARCHAR2
                param11.Size = 50
                If aipinsenc.itipoinsenc IsNot Nothing And aipinsenc.itipoinsenc <> "" Then
                    param11.Value = aipinsenc.itipoinsenc
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_itipoinsenc"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = aipinsenc.idaipinsmotiv
                param12.ParameterName = "p_idaipinsmotiv"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 20
                If aipinsenc.itipoperitinsenc IsNot Nothing And aipinsenc.itipoperitinsenc <> "" Then
                    param13.Value = aipinsenc.itipoperitinsenc
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_itipoperitinsenc"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 20
                If aipinsenc.iorigeninsenc IsNot Nothing And aipinsenc.iorigeninsenc <> "" Then
                    param14.Value = aipinsenc.iorigeninsenc
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_iorigeninsenc"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = aipinsenc.idsegmanusuperit
                param15.ParameterName = "p_idsegmanusuperit"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = aipinsenc.idsegmanusuaudit
                param16.ParameterName = "p_idsegmanusuaudit"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 20
                If aipinsenc.xcedpropinsenc IsNot Nothing And aipinsenc.xcedpropinsenc <> "" Then
                    param17.Value = aipinsenc.xcedpropinsenc
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xcedpropinsenc"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.VARCHAR2
                param18.Size = 20
                If aipinsenc.xcedsidoinsenc IsNot Nothing And aipinsenc.xcedsidoinsenc <> "" Then
                    param18.Value = aipinsenc.xcedsidoinsenc
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_xcedsidoinsenc"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.VARCHAR2
                param19.Size = 20
                If aipinsenc.xplacinsenc IsNot Nothing And aipinsenc.xplacinsenc <> "" Then
                    param19.Value = aipinsenc.xplacinsenc
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_xplacinsenc"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.VARCHAR2
                param20.Size = 30
                If aipinsenc.xsermotinsenc IsNot Nothing And aipinsenc.xsermotinsenc <> "" Then
                    param20.Value = aipinsenc.xsermotinsenc
                Else
                    param20.Value = " "
                End If
                param20.ParameterName = "p_xsermotinsenc"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.VARCHAR2
                param21.Size = 30
                If aipinsenc.xsercarrinsenc IsNot Nothing And aipinsenc.xsercarrinsenc <> "" Then
                    param21.Value = aipinsenc.xsercarrinsenc
                Else
                    param21.Value = " "
                End If
                param21.ParameterName = "p_xsercarrinsenc"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.VARCHAR2
                param22.Size = 50
                If aipinsenc.xnumpolinsenc IsNot Nothing And aipinsenc.xnumpolinsenc <> "" Then
                    param22.Value = aipinsenc.xnumpolinsenc
                Else
                    param22.Value = " "
                End If
                param22.ParameterName = "p_xnumpolinsenc"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.VARCHAR2
                param23.Size = 50
                If aipinsenc.xnumsininsenc IsNot Nothing And aipinsenc.xnumsininsenc <> "" Then
                    param23.Value = aipinsenc.xnumsininsenc
                Else
                    param23.Value = " "
                End If
                param23.ParameterName = "p_xnumsininsenc"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.VARCHAR2
                param24.Size = 200
                If aipinsenc.xllavinsenc IsNot Nothing And aipinsenc.xllavinsenc <> "" Then
                    param24.Value = aipinsenc.xllavinsenc
                Else
                    param24.Value = " "
                End If
                param24.ParameterName = "p_xllavinsenc"

                Dim param25 As New Client.OracleParameter
                param25.OracleDbType = Client.OracleDbType.VARCHAR2
                param25.Size = 100
                If aipinsenc.xnomprodinsenc IsNot Nothing And aipinsenc.xnomprodinsenc <> "" Then
                    param25.Value = aipinsenc.xnomprodinsenc
                Else
                    param25.Value = " "
                End If
                param25.ParameterName = "p_xnomprodinsenc"

                Dim param26 As New Client.OracleParameter
                param26.OracleDbType = Client.OracleDbType.VARCHAR2
                param26.Size = 100
                If aipinsenc.xnomprodtorinsenc IsNot Nothing And aipinsenc.xnomprodtorinsenc <> "" Then
                    param26.Value = aipinsenc.xnomprodtorinsenc
                Else
                    param26.Value = " "
                End If
                param26.ParameterName = "p_xnomprodtorinsenc"

                Dim param27 As New Client.OracleParameter
                param27.OracleDbType = Client.OracleDbType.VARCHAR2
                param27.Size = 100
                If aipinsenc.xnomramopolizinsenc IsNot Nothing And aipinsenc.xnomramopolizinsenc <> "" Then
                    param27.Value = aipinsenc.xnomramopolizinsenc
                Else
                    param27.Value = " "
                End If
                param27.ParameterName = "p_xnomramopolizinsenc"

                Dim param28 As New Client.OracleParameter
                param28.OracleDbType = Client.OracleDbType.VARCHAR2
                param28.Size = 100
                If aipinsenc.xnomsucinsinsenc IsNot Nothing And aipinsenc.xnomsucinsinsenc <> "" Then
                    param28.Value = aipinsenc.xnomsucinsinsenc
                Else
                    param28.Value = " "
                End If
                param28.ParameterName = "p_xnomsucinsinsenc"

                Dim param29 As New Client.OracleParameter
                param29.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.fcreainsenc > CDate("01-01-1900") Then
                    param29.Value = aipinsenc.fcreainsenc
                Else
                    param29.Value = CDate("01-01-1900")
                End If
                param29.ParameterName = "p_fcreainsenc"

                Dim param30 As New Client.OracleParameter
                param30.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.fprocinsenc > CDate("01-01-1900") Then
                    param30.Value = aipinsenc.fprocinsenc
                Else
                    param30.Value = CDate("01-01-1900")
                End If
                param30.ParameterName = "p_fprocinsenc"

                Dim param31 As New Client.OracleParameter
                param31.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.faudinsenc > CDate("01-01-1900") Then
                    param31.Value = aipinsenc.faudinsenc
                Else
                    param31.Value = CDate("01-01-1900")
                End If
                param31.ParameterName = "p_faudinsenc"

                Dim param32 As New Client.OracleParameter
                param32.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.fultrechinsenc > CDate("01-01-1900") Then
                    param32.Value = aipinsenc.fultrechinsenc
                Else
                    param32.Value = CDate("01-01-1900")
                End If
                param32.ParameterName = "p_fultrechinsenc"

                Dim param33 As New Client.OracleParameter
                param33.OracleDbType = Client.OracleDbType.Int16
                param33.Value = aipinsenc.irechinsenc
                param33.ParameterName = "p_irechinsenc"

                Dim param34 As New Client.OracleParameter
                param34.OracleDbType = Client.OracleDbType.VARCHAR2
                param34.Size = 500
                If aipinsenc.xmotcrechinsenc IsNot Nothing And aipinsenc.xmotcrechinsenc <> "" Then
                    param34.Value = aipinsenc.xmotcrechinsenc
                Else
                    param34.Value = " "
                End If
                param34.ParameterName = "p_xmotcrechinsenc"

                Dim param35 As New Client.OracleParameter
                param35.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.fcancinsenc > CDate("01-01-1900") Then
                    param35.Value = aipinsenc.fcancinsenc
                Else
                    param35.Value = CDate("01-01-1900")
                End If
                param35.ParameterName = "p_fcancinsenc"

                Dim param36 As New Client.OracleParameter
                param36.OracleDbType = Client.OracleDbType.Date
                If aipinsenc.facepinsenc > CDate("01-01-1900") Then
                    param36.Value = aipinsenc.facepinsenc
                Else
                    param36.Value = CDate("01-01-1900")
                End If
                param36.ParameterName = "p_facepinsenc"

                Dim param37 As New Client.OracleParameter
                param37.OracleDbType = Client.OracleDbType.VARCHAR2
                param37.Size = 500
                If aipinsenc.xdescinsenc IsNot Nothing And aipinsenc.xdescinsenc <> "" Then
                    param37.Value = aipinsenc.xdescinsenc
                Else
                    param37.Value = " "
                End If
                param37.ParameterName = "p_xdescinsenc"

                Dim param38 As New Client.OracleParameter
                param38.OracleDbType = Client.OracleDbType.Int16
                param38.Value = aipinsenc.icerrarinsenc
                param38.ParameterName = "p_icerrarinsenc"

                Dim param39 As New Client.OracleParameter
                param39.OracleDbType = Client.OracleDbType.VARCHAR2
                param39.Size = 20
                If aipinsenc.iestatinsenc IsNot Nothing And aipinsenc.iestatinsenc <> "" Then
                    param39.Value = aipinsenc.iestatinsenc
                Else
                    param39.Value = " "
                End If
                param39.ParameterName = "p_iestatinsenc"

                Dim param40 As New Client.OracleParameter
                param40.OracleDbType = Client.OracleDbType.Decimal
                param40.Precision = 18
                param40.Scale = 0
                param40.Value = aipinsenc.idseglogreg
                param40.ParameterName = "p_idseglogreg"

                Dim param41 As New Client.OracleParameter
                param41.OracleDbType = Client.OracleDbType.Varchar2
                param41.Size = 50
                param41.Value = 0
                If aipinsenc.xnuminspinsenc IsNot Nothing And aipinsenc.xnuminspinsenc <> "" Then
                    param41.Value = aipinsenc.xnuminspinsenc
                Else
                    param41.Value = " "
                End If
                param41.ParameterName = "p_xnuminspinsenc"

                Dim param42 As New Client.OracleParameter
                param42.OracleDbType = Client.OracleDbType.Int16
                param42.Precision = 3
                param42.Scale = 0
                param42.Value = aipinsenc.nanexoinsenc
                param42.ParameterName = "p_nanexoinsenc"


                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinsenc FLOAT; v_p_idaipactivperi FLOAT; v_p_idaipinsintext FLOAT; v_p_itipoinsenc VARCHAR2(50); v_p_idaipinsmotiv FLOAT; v_p_itipoperitinsenc VARCHAR2(20); v_p_iorigeninsenc VARCHAR2(20); v_p_idsegmanusuperit FLOAT; v_p_idsegmanusuaudit FLOAT; v_p_xcedpropinsenc VARCHAR2(20); v_p_xcedsidoinsenc VARCHAR2(20); v_p_xplacinsenc VARCHAR2(20); v_p_xsermotinsenc VARCHAR2(30); v_p_xsercarrinsenc VARCHAR2(30); v_p_xnumpolinsenc VARCHAR2(50); v_p_xnumsininsenc VARCHAR2(50); v_p_xllavinsenc VARCHAR2(200); v_p_xnomprodinsenc VARCHAR2(100); v_p_xnomprodtorinsenc VARCHAR2(100); v_p_xnomramopolizinsenc VARCHAR2(100); v_p_xnomsucinsinsenc VARCHAR2(100); v_p_fcreainsenc date; v_p_fprocinsenc date; v_p_faudinsenc date; v_p_fultrechinsenc date; v_p_irechinsenc number; v_p_xmotcrechinsenc VARCHAR2(500); v_p_fcancinsenc date; v_p_facepinsenc date; v_p_xdescinsenc VARCHAR2(500); v_p_icerrarinsenc number; v_p_iestatinsenc VARCHAR2(20); v_p_idseglogreg FLOAT; v_p_xnuminspinsenc VARCHAR2(50); v_p_nanexoinsenc numeric(3,0);  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinsenc(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinsenc,:v_p_idaipactivperi,:v_p_idaipinsintext,:v_p_itipoinsenc,:v_p_idaipinsmotiv,:v_p_itipoperitinsenc,:v_p_iorigeninsenc,:v_p_idsegmanusuperit,:v_p_idsegmanusuaudit,:v_p_xcedpropinsenc,:v_p_xcedsidoinsenc,:v_p_xplacinsenc,:v_p_xsermotinsenc,:v_p_xsercarrinsenc,:v_p_xnumpolinsenc,:v_p_xnumsininsenc,:v_p_xllavinsenc,:v_p_xnomprodinsenc,:v_p_xnomprodtorinsenc,:v_p_xnomramopolizinsenc,:v_p_xnomsucinsinsenc,:v_p_fcreainsenc,:v_p_fprocinsenc,:v_p_faudinsenc,:v_p_fultrechinsenc,:v_p_irechinsenc,:v_p_xmotcrechinsenc,:v_p_fcancinsenc,:v_p_facepinsenc,:v_p_xdescinsenc,:v_p_icerrarinsenc,:v_p_iestatinsenc,:v_p_idseglogreg,:v_p_xnuminspinsenc,:v_p_nanexoinsenc, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40, param41, param42)

                Dim respopera As New respopera
                respopera.irespuesta = param4.Value.ToString()
                respopera.xmsjusuario = param5.Value.ToString()
                respopera.xmsjtecnico = param6.Value.ToString()
                If IsNumeric(param8.Value.ToString()) = True Then
                    respopera.id = Int(param8.Value.ToString())
                End If

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        <HttpPost()> _
        Public Function eliaipinsenc(idaipinsenc As Decimal) As respopera
            Try
                Dim respopera As New respopera
                If ConfigurationManager.AppSettings("motoddb") = "sql" Then
                    Dim param1 As New SqlClient.SqlParameter
                    param1.SqlDbType = SqlDbType.VarChar
                    param1.Size = 20
                    param1.Value = "eliminar"
                    param1.ParameterName = "p_ioperacion"

                    Dim param2 As New SqlClient.SqlParameter
                    param2.SqlDbType = SqlDbType.Decimal
                    param2.Precision = 18
                    param2.Scale = 0
                    param2.Value = 0
                    param2.ParameterName = "p_idsegmanusulog"

                    Dim param3 As New SqlClient.SqlParameter
                    param3.SqlDbType = SqlDbType.VarChar
                    param3.Size = 20
                    param3.Value = "aipauto"
                    param3.ParameterName = "p_xnombrecortolog"

                    Dim param4 As New SqlClient.SqlParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
                    param4.SqlDbType = SqlDbType.VarChar
                    param4.Size = 1
                    param4.ParameterName = "p_irespuesta"
                    param4.Direction = ParameterDirection.Output

                    Dim param5 As New SqlClient.SqlParameter
                    param5.SqlDbType = SqlDbType.VarChar
                    param5.Size = 300
                    param5.ParameterName = "p_xmsjusuario"
                    param5.Direction = ParameterDirection.Output

                    Dim param6 As New SqlClient.SqlParameter
                    param6.SqlDbType = SqlDbType.VarChar
                    param6.Size = 300
                    param6.ParameterName = "p_xmsjtecnico"
                    param6.Direction = ParameterDirection.Output

                    Dim param7 As New SqlClient.SqlParameter
                    param7.SqlDbType = SqlDbType.VarChar
                    param7.Size = 300
                    param7.ParameterName = "p_coderrorlog"
                    param7.Direction = ParameterDirection.Output

                    'Paramestros de la tabla

                    Dim param8 As New SqlClient.SqlParameter
                    param8.SqlDbType = SqlDbType.Decimal
                    param8.Precision = 18
                    param8.Scale = 0
                    param8.Value = idaipinsenc
                    param8.ParameterName = "p_idaipinsenc"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = 0
                    param9.ParameterName = "p_idaipactivperi"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = 0
                    param10.ParameterName = "p_idaipinsintext"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 50
                    param11.Value = ""
                    param11.ParameterName = "p_itipoinsenc"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Decimal
                    param12.Precision = 18
                    param12.Scale = 0
                    param12.Value = 0
                    param12.ParameterName = "p_idaipinsmotiv"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 20
                    param13.Value = ""
                    param13.ParameterName = "p_itipoperitinsenc"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 20
                    param14.Value = ""
                    param14.ParameterName = "p_iorigeninsenc"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.Decimal
                    param15.Precision = 18
                    param15.Scale = 0
                    param15.Value = 0
                    param15.ParameterName = "p_idsegmanusuperit"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Decimal
                    param16.Precision = 18
                    param16.Scale = 0
                    param16.Value = 0
                    param16.ParameterName = "p_idsegmanusuaudit"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 20
                    param17.Value = ""
                    param17.ParameterName = "p_xcedpropinsenc"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 20
                    param18.Value = ""
                    param18.ParameterName = "p_xcedsidoinsenc"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 20
                    param19.Value = ""
                    param19.ParameterName = "p_xplacinsenc"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 30
                    param20.Value = ""
                    param20.ParameterName = "p_xsermotinsenc"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 30
                    param21.Value = ""
                    param21.ParameterName = "p_xsercarrinsenc"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.VarChar
                    param22.Size = 50
                    param22.Value = ""
                    param22.ParameterName = "p_xnumpolinsenc"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.VarChar
                    param23.Size = 50
                    param23.Value = ""
                    param23.ParameterName = "p_xnumsininsenc"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.VarChar
                    param24.Size = 200
                    param24.Value = ""
                    param24.ParameterName = "p_xllavinsenc"

                    Dim param25 As New SqlClient.SqlParameter
                    param25.SqlDbType = SqlDbType.VarChar
                    param25.Size = 100
                    param25.Value = ""
                    param25.ParameterName = "p_xnomprodinsenc"

                    Dim param26 As New SqlClient.SqlParameter
                    param26.SqlDbType = SqlDbType.VarChar
                    param26.Size = 100
                    param26.Value = ""
                    param26.ParameterName = "p_xnomprodtorinsenc"

                    Dim param27 As New SqlClient.SqlParameter
                    param27.SqlDbType = SqlDbType.VarChar
                    param27.Size = 100
                    param27.Value = ""
                    param27.ParameterName = "p_xnomramopolizinsenc"

                    Dim param28 As New SqlClient.SqlParameter
                    param28.SqlDbType = SqlDbType.VarChar
                    param28.Size = 100
                    param28.Value = ""
                    param28.ParameterName = "p_xnomsucinsinsenc"

                    Dim param29 As New SqlClient.SqlParameter
                    param29.SqlDbType = SqlDbType.DateTime
                    param29.Value = CDate("01-01-1900")
                    param29.ParameterName = "p_fcreainsenc"

                    Dim param30 As New SqlClient.SqlParameter
                    param30.SqlDbType = SqlDbType.DateTime
                    param30.Value = CDate("01-01-1900")
                    param30.ParameterName = "p_fprocinsenc"

                    Dim param31 As New SqlClient.SqlParameter
                    param31.SqlDbType = SqlDbType.DateTime
                    param31.Value = CDate("01-01-1900")
                    param31.ParameterName = "p_faudinsenc"

                    Dim param32 As New SqlClient.SqlParameter
                    param32.SqlDbType = SqlDbType.DateTime
                    param32.Value = CDate("01-01-1900")
                    param32.ParameterName = "p_fultrechinsenc"

                    Dim param33 As New SqlClient.SqlParameter
                    param33.SqlDbType = SqlDbType.Bit
                    param33.Value = 0
                    param33.ParameterName = "p_irechinsenc"

                    Dim param34 As New SqlClient.SqlParameter
                    param34.SqlDbType = SqlDbType.VarChar
                    param34.Size = 500
                    param34.Value = ""
                    param34.ParameterName = "p_xmotcrechinsenc"

                    Dim param35 As New SqlClient.SqlParameter
                    param35.SqlDbType = SqlDbType.DateTime
                    param35.Value = CDate("01-01-1900")
                    param35.ParameterName = "p_fcancinsenc"

                    Dim param36 As New SqlClient.SqlParameter
                    param36.SqlDbType = SqlDbType.DateTime
                    param36.Value = CDate("01-01-1900")
                    param36.ParameterName = "p_facepinsenc"

                    Dim param37 As New SqlClient.SqlParameter
                    param37.SqlDbType = SqlDbType.VarChar
                    param37.Size = 500
                    param37.Value = ""
                    param37.ParameterName = "p_xdescinsenc"

                    Dim param38 As New SqlClient.SqlParameter
                    param38.SqlDbType = SqlDbType.Bit
                    param38.Value = 0
                    param38.ParameterName = "p_icerrarinsenc"

                    Dim param39 As New SqlClient.SqlParameter
                    param39.SqlDbType = SqlDbType.VarChar
                    param39.Size = 20
                    param39.Value = ""
                    param39.ParameterName = "p_iestatinsenc"

                    Dim param40 As New SqlClient.SqlParameter
                    param40.SqlDbType = SqlDbType.Decimal
                    param40.Precision = 18
                    param40.Scale = 0
                    param40.Value = 0
                    param40.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsenc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsenc output,@p_idaipactivperi,@p_idaipinsintext,@p_itipoinsenc,@p_idaipinsmotiv,@p_itipoperitinsenc,@p_iorigeninsenc,@p_idsegmanusuperit,@p_idsegmanusuaudit,@p_xcedpropinsenc,@p_xcedsidoinsenc,@p_xplacinsenc,@p_xsermotinsenc,@p_xsercarrinsenc,@p_xnumpolinsenc,@p_xnumsininsenc,@p_xllavinsenc,@p_xnomprodinsenc,@p_xnomprodtorinsenc,@p_xnomramopolizinsenc,@p_xnomsucinsinsenc,@p_fcreainsenc,@p_fprocinsenc,@p_faudinsenc,@p_fultrechinsenc,@p_irechinsenc,@p_xmotcrechinsenc,@p_fcancinsenc,@p_facepinsenc,@p_xdescinsenc,@p_icerrarinsenc,@p_iestatinsenc,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipinsencoracle(idaipinsenc)
                End If
                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        <HttpPost()> _
           Public Function eliaipinsencoracle(idaipinsenc As Decimal) As respopera
            Try

                Dim param1 As New Client.OracleParameter
                param1.OracleDbType = Client.OracleDbType.Varchar2
                param1.Size = 20
                param1.Value = "eliminar"
                param1.ParameterName = "p_ioperacion"

                Dim param2 As New Client.OracleParameter
                param2.OracleDbType = Client.OracleDbType.Decimal
                param2.Precision = 18
                param2.Scale = 0
                param2.Value = 0
                param2.ParameterName = "p_idsegmanusulog"

                Dim param3 As New Client.OracleParameter
                param3.OracleDbType = Client.OracleDbType.Varchar2
                param3.Size = 20
                param3.value = "aipauto"
                param3.ParameterName = "p_xnombrecortolog"

                Dim param4 As New Client.OracleParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
                param4.OracleDbType = Client.OracleDbType.Varchar2
                param4.Size = 1
                param4.ParameterName = "p_irespuesta"
                param4.Direction = ParameterDirection.Output

                Dim param5 As New Client.OracleParameter
                param5.OracleDbType = Client.OracleDbType.Varchar2
                param5.Size = 300
                param5.ParameterName = "p_xmsjusuario"
                param5.Direction = ParameterDirection.Output

                Dim param6 As New Client.OracleParameter
                param6.OracleDbType = Client.OracleDbType.Varchar2
                param6.Size = 300
                param6.ParameterName = "p_xmsjtecnico"
                param6.Direction = ParameterDirection.Output

                Dim param7 As New Client.OracleParameter
                param7.OracleDbType = Client.OracleDbType.Varchar2
                param7.Size = 300
                param7.ParameterName = "p_coderrorlog"
                param7.Direction = ParameterDirection.Output

                'Paramestros de la tabla

                Dim param8 As New Client.OracleParameter
                param8.OracleDbType = Client.OracleDbType.Decimal
                param8.Precision = 18
                param8.Scale = 0
                param8.Value = idaipinsenc
                param8.ParameterName = "p_idaipinsenc"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = 0
                param9.ParameterName = "p_idaipactivperi"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = 0
                param10.ParameterName = "p_idaipinsintext"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.VARCHAR2
                param11.Size = 50
                param11.Value = " "
                param11.ParameterName = "p_itipoinsenc"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = 0
                param12.ParameterName = "p_idaipinsmotiv"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 20
                param13.Value = " "
                param13.ParameterName = "p_itipoperitinsenc"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 20
                param14.Value = " "
                param14.ParameterName = "p_iorigeninsenc"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = 0
                param15.ParameterName = "p_idsegmanusuperit"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = 0
                param16.ParameterName = "p_idsegmanusuaudit"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 20
                param17.Value = " "
                param17.ParameterName = "p_xcedpropinsenc"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.VARCHAR2
                param18.Size = 20
                param18.Value = " "
                param18.ParameterName = "p_xcedsidoinsenc"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.VARCHAR2
                param19.Size = 20
                param19.Value = " "
                param19.ParameterName = "p_xplacinsenc"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.VARCHAR2
                param20.Size = 30
                param20.Value = " "
                param20.ParameterName = "p_xsermotinsenc"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.VARCHAR2
                param21.Size = 30
                param21.Value = " "
                param21.ParameterName = "p_xsercarrinsenc"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.VARCHAR2
                param22.Size = 50
                param22.Value = " "
                param22.ParameterName = "p_xnumpolinsenc"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.VARCHAR2
                param23.Size = 50
                param23.Value = " "
                param23.ParameterName = "p_xnumsininsenc"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.VARCHAR2
                param24.Size = 200
                param24.Value = " "
                param24.ParameterName = "p_xllavinsenc"

                Dim param25 As New Client.OracleParameter
                param25.OracleDbType = Client.OracleDbType.VARCHAR2
                param25.Size = 100
                param25.Value = " "
                param25.ParameterName = "p_xnomprodinsenc"

                Dim param26 As New Client.OracleParameter
                param26.OracleDbType = Client.OracleDbType.VARCHAR2
                param26.Size = 100
                param26.Value = " "
                param26.ParameterName = "p_xnomprodtorinsenc"

                Dim param27 As New Client.OracleParameter
                param27.OracleDbType = Client.OracleDbType.VARCHAR2
                param27.Size = 100
                param27.Value = " "
                param27.ParameterName = "p_xnomramopolizinsenc"

                Dim param28 As New Client.OracleParameter
                param28.OracleDbType = Client.OracleDbType.VARCHAR2
                param28.Size = 100
                param28.Value = " "
                param28.ParameterName = "p_xnomsucinsinsenc"

                Dim param29 As New Client.OracleParameter
                param29.OracleDbType = Client.OracleDbType.Date
                param29.Value = CDate("01-01-1900")
                param29.ParameterName = "p_fcreainsenc"

                Dim param30 As New Client.OracleParameter
                param30.OracleDbType = Client.OracleDbType.Date
                param30.Value = CDate("01-01-1900")
                param30.ParameterName = "p_fprocinsenc"

                Dim param31 As New Client.OracleParameter
                param31.OracleDbType = Client.OracleDbType.Date
                param31.Value = CDate("01-01-1900")
                param31.ParameterName = "p_faudinsenc"

                Dim param32 As New Client.OracleParameter
                param32.OracleDbType = Client.OracleDbType.Date
                param32.Value = CDate("01-01-1900")
                param32.ParameterName = "p_fultrechinsenc"

                Dim param33 As New Client.OracleParameter
                param33.OracleDbType = Client.OracleDbType.Int16
                param33.Value = 0
                param33.ParameterName = "p_irechinsenc"

                Dim param34 As New Client.OracleParameter
                param34.OracleDbType = Client.OracleDbType.VARCHAR2
                param34.Size = 500
                param34.Value = " "
                param34.ParameterName = "p_xmotcrechinsenc"

                Dim param35 As New Client.OracleParameter
                param35.OracleDbType = Client.OracleDbType.Date
                param35.Value = CDate("01-01-1900")
                param35.ParameterName = "p_fcancinsenc"

                Dim param36 As New Client.OracleParameter
                param36.OracleDbType = Client.OracleDbType.Date
                param36.Value = CDate("01-01-1900")
                param36.ParameterName = "p_facepinsenc"

                Dim param37 As New Client.OracleParameter
                param37.OracleDbType = Client.OracleDbType.VARCHAR2
                param37.Size = 500
                param37.Value = " "
                param37.ParameterName = "p_xdescinsenc"

                Dim param38 As New Client.OracleParameter
                param38.OracleDbType = Client.OracleDbType.Int16
                param38.Value = 0
                param38.ParameterName = "p_icerrarinsenc"

                Dim param39 As New Client.OracleParameter
                param39.OracleDbType = Client.OracleDbType.VARCHAR2
                param39.Size = 20
                param39.Value = " "
                param39.ParameterName = "p_iestatinsenc"

                Dim param40 As New Client.OracleParameter
                param40.OracleDbType = Client.OracleDbType.Decimal
                param40.Precision = 18
                param40.Scale = 0
                param40.Value = 0
                param40.ParameterName = "p_idseglogreg"

                Dim param41 As New Client.OracleParameter
                param41.OracleDbType = Client.OracleDbType.Varchar2
                param41.Size = 50
                param41.Value = " "
                param41.ParameterName = "p_xnuminspinsenc"

                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinsenc FLOAT; v_p_idaipactivperi FLOAT; v_p_idaipinsintext FLOAT; v_p_itipoinsenc VARCHAR2(50); v_p_idaipinsmotiv FLOAT; v_p_itipoperitinsenc VARCHAR2(20); v_p_iorigeninsenc VARCHAR2(20); v_p_idsegmanusuperit FLOAT; v_p_idsegmanusuaudit FLOAT; v_p_xcedpropinsenc VARCHAR2(20); v_p_xcedsidoinsenc VARCHAR2(20); v_p_xplacinsenc VARCHAR2(20); v_p_xsermotinsenc VARCHAR2(30); v_p_xsercarrinsenc VARCHAR2(30); v_p_xnumpolinsenc VARCHAR2(50); v_p_xnumsininsenc VARCHAR2(50); v_p_xllavinsenc VARCHAR2(200); v_p_xnomprodinsenc VARCHAR2(100); v_p_xnomprodtorinsenc VARCHAR2(100); v_p_xnomramopolizinsenc VARCHAR2(100); v_p_xnomsucinsinsenc VARCHAR2(100); v_p_fcreainsenc date; v_p_fprocinsenc date; v_p_faudinsenc date; v_p_fultrechinsenc date; v_p_irechinsenc number; v_p_xmotcrechinsenc VARCHAR2(500); v_p_fcancinsenc date; v_p_facepinsenc date; v_p_xdescinsenc VARCHAR2(500); v_p_icerrarinsenc number; v_p_iestatinsenc VARCHAR2(20); v_p_idseglogreg FLOAT; v_p_xnuminspinsenc VARCHAR2(50);  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinsenc(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinsenc,:v_p_idaipactivperi,:v_p_idaipinsintext,:v_p_itipoinsenc,:v_p_idaipinsmotiv,:v_p_itipoperitinsenc,:v_p_iorigeninsenc,:v_p_idsegmanusuperit,:v_p_idsegmanusuaudit,:v_p_xcedpropinsenc,:v_p_xcedsidoinsenc,:v_p_xplacinsenc,:v_p_xsermotinsenc,:v_p_xsercarrinsenc,:v_p_xnumpolinsenc,:v_p_xnumsininsenc,:v_p_xllavinsenc,:v_p_xnomprodinsenc,:v_p_xnomprodtorinsenc,:v_p_xnomramopolizinsenc,:v_p_xnomsucinsinsenc,:v_p_fcreainsenc,:v_p_fprocinsenc,:v_p_faudinsenc,:v_p_fultrechinsenc,:v_p_irechinsenc,:v_p_xmotcrechinsenc,:v_p_fcancinsenc,:v_p_facepinsenc,:v_p_xdescinsenc,:v_p_icerrarinsenc,:v_p_iestatinsenc,:v_p_idseglogreg, :v_p_xnuminspinsenc, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40, param41)

                Dim respopera As New respopera
                respopera.irespuesta = param4.Value.ToString()
                respopera.xmsjusuario = param5.Value.ToString()
                respopera.xmsjtecnico = param6.Value.ToString()
                If IsNumeric(param8.Value.ToString()) = True Then
                    respopera.id = Int(param8.Value.ToString())
                End If

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function


        <HttpPost()> _
        Public Function actaipinsenc(aipinsenc As aipinsenc) As respopera
            Try

                Dim param1 As New SqlClient.SqlParameter
                param1.SqlDbType = SqlDbType.VarChar
                param1.Size = 20
                param1.Value = "activar"
                param1.ParameterName = "p_ioperacion"

                Dim param2 As New SqlClient.SqlParameter
                param2.SqlDbType = SqlDbType.Decimal
                param2.Precision = 18
                param2.Scale = 0
                param2.Value = 0
                param2.ParameterName = "p_idsegmanusulog"

                Dim param3 As New SqlClient.SqlParameter
                param3.SqlDbType = SqlDbType.VarChar
                param3.Size = 20
                param3.value = "aipauto"
                param3.ParameterName = "p_xnombrecortolog"

                Dim param4 As New SqlClient.SqlParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
                param4.SqlDbType = SqlDbType.VarChar
                param4.Size = 1
                param4.ParameterName = "p_irespuesta"
                param4.Direction = ParameterDirection.Output

                Dim param5 As New SqlClient.SqlParameter
                param5.SqlDbType = SqlDbType.VarChar
                param5.Size = 300
                param5.ParameterName = "p_xmsjusuario"
                param5.Direction = ParameterDirection.Output

                Dim param6 As New SqlClient.SqlParameter
                param6.SqlDbType = SqlDbType.VarChar
                param6.Size = 300
                param6.ParameterName = "p_xmsjtecnico"
                param6.Direction = ParameterDirection.Output

                Dim param7 As New SqlClient.SqlParameter
                param7.SqlDbType = SqlDbType.VarChar
                param7.Size = 300
                param7.ParameterName = "p_coderrorlog"
                param7.Direction = ParameterDirection.Output

                'Paramestros de la tabla

                Dim param8 As New SqlClient.SqlParameter
                param8.SqlDbType = SqlDbType.decimal
                param8.Precision = 18
                param8.Scale = 0
                param8.Value = aipinsenc.idaipinsenc
                param8.ParameterName = "p_idaipinsenc"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsenc.idaipactivperi
                param9.ParameterName = "p_idaipactivperi"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinsenc.idaipinsintext
                param10.ParameterName = "p_idaipinsintext"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.varchar
                param11.Size = 50
                If aipinsenc.itipoinsenc IsNot Nothing Then
                    param11.Value = aipinsenc.itipoinsenc
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_itipoinsenc"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = aipinsenc.idaipinsmotiv
                param12.ParameterName = "p_idaipinsmotiv"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.varchar
                param13.Size = 20
                If aipinsenc.itipoperitinsenc IsNot Nothing Then
                    param13.Value = aipinsenc.itipoperitinsenc
                Else
                    param13.Value = ""
                End If
                param13.ParameterName = "p_itipoperitinsenc"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.varchar
                param14.Size = 20
                If aipinsenc.iorigeninsenc IsNot Nothing Then
                    param14.Value = aipinsenc.iorigeninsenc
                Else
                    param14.Value = ""
                End If
                param14.ParameterName = "p_iorigeninsenc"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = aipinsenc.idsegmanusuperit
                param15.ParameterName = "p_idsegmanusuperit"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = aipinsenc.idsegmanusuaudit
                param16.ParameterName = "p_idsegmanusuaudit"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.varchar
                param17.Size = 20
                If aipinsenc.xcedpropinsenc IsNot Nothing Then
                    param17.Value = aipinsenc.xcedpropinsenc
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xcedpropinsenc"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.varchar
                param18.Size = 20
                If aipinsenc.xcedsidoinsenc IsNot Nothing Then
                    param18.Value = aipinsenc.xcedsidoinsenc
                Else
                    param18.Value = ""
                End If
                param18.ParameterName = "p_xcedsidoinsenc"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.varchar
                param19.Size = 20
                If aipinsenc.xplacinsenc IsNot Nothing Then
                    param19.Value = aipinsenc.xplacinsenc
                Else
                    param19.Value = ""
                End If
                param19.ParameterName = "p_xplacinsenc"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.varchar
                param20.Size = 30
                If aipinsenc.xsermotinsenc IsNot Nothing Then
                    param20.Value = aipinsenc.xsermotinsenc
                Else
                    param20.Value = ""
                End If
                param20.ParameterName = "p_xsermotinsenc"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.varchar
                param21.Size = 30
                If aipinsenc.xsercarrinsenc IsNot Nothing Then
                    param21.Value = aipinsenc.xsercarrinsenc
                Else
                    param21.Value = ""
                End If
                param21.ParameterName = "p_xsercarrinsenc"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.varchar
                param22.Size = 50
                If aipinsenc.xnumpolinsenc IsNot Nothing Then
                    param22.Value = aipinsenc.xnumpolinsenc
                Else
                    param22.Value = ""
                End If
                param22.ParameterName = "p_xnumpolinsenc"

                Dim param23 As New SqlClient.SqlParameter
                param23.SqlDbType = SqlDbType.varchar
                param23.Size = 50
                If aipinsenc.xnumsininsenc IsNot Nothing Then
                    param23.Value = aipinsenc.xnumsininsenc
                Else
                    param23.Value = ""
                End If
                param23.ParameterName = "p_xnumsininsenc"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.varchar
                param24.Size = 200
                If aipinsenc.xllavinsenc IsNot Nothing Then
                    param24.Value = aipinsenc.xllavinsenc
                Else
                    param24.Value = ""
                End If
                param24.ParameterName = "p_xllavinsenc"

                Dim param25 As New SqlClient.SqlParameter
                param25.SqlDbType = SqlDbType.varchar
                param25.Size = 100
                If aipinsenc.xnomprodinsenc IsNot Nothing Then
                    param25.Value = aipinsenc.xnomprodinsenc
                Else
                    param25.Value = ""
                End If
                param25.ParameterName = "p_xnomprodinsenc"

                Dim param26 As New SqlClient.SqlParameter
                param26.SqlDbType = SqlDbType.varchar
                param26.Size = 100
                If aipinsenc.xnomprodtorinsenc IsNot Nothing Then
                    param26.Value = aipinsenc.xnomprodtorinsenc
                Else
                    param26.Value = ""
                End If
                param26.ParameterName = "p_xnomprodtorinsenc"

                Dim param27 As New SqlClient.SqlParameter
                param27.SqlDbType = SqlDbType.varchar
                param27.Size = 100
                If aipinsenc.xnomramopolizinsenc IsNot Nothing Then
                    param27.Value = aipinsenc.xnomramopolizinsenc
                Else
                    param27.Value = ""
                End If
                param27.ParameterName = "p_xnomramopolizinsenc"

                Dim param28 As New SqlClient.SqlParameter
                param28.SqlDbType = SqlDbType.varchar
                param28.Size = 100
                If aipinsenc.xnomsucinsinsenc IsNot Nothing Then
                    param28.Value = aipinsenc.xnomsucinsinsenc
                Else
                    param28.Value = ""
                End If
                param28.ParameterName = "p_xnomsucinsinsenc"

                Dim param29 As New SqlClient.SqlParameter
                param29.SqlDbType = SqlDbType.datetime
                If aipinsenc.fcreainsenc > CDate("01-01-1900") Then
                    param29.Value = aipinsenc.fcreainsenc
                Else
                    param29.Value = CDate("01-01-1900")
                End If
                param29.ParameterName = "p_fcreainsenc"

                Dim param30 As New SqlClient.SqlParameter
                param30.SqlDbType = SqlDbType.datetime
                If aipinsenc.fprocinsenc > CDate("01-01-1900") Then
                    param30.Value = aipinsenc.fprocinsenc
                Else
                    param30.Value = CDate("01-01-1900")
                End If
                param30.ParameterName = "p_fprocinsenc"

                Dim param31 As New SqlClient.SqlParameter
                param31.SqlDbType = SqlDbType.datetime
                If aipinsenc.faudinsenc > CDate("01-01-1900") Then
                    param31.Value = aipinsenc.faudinsenc
                Else
                    param31.Value = CDate("01-01-1900")
                End If
                param31.ParameterName = "p_faudinsenc"

                Dim param32 As New SqlClient.SqlParameter
                param32.SqlDbType = SqlDbType.datetime
                If aipinsenc.fultrechinsenc > CDate("01-01-1900") Then
                    param32.Value = aipinsenc.fultrechinsenc
                Else
                    param32.Value = CDate("01-01-1900")
                End If
                param32.ParameterName = "p_fultrechinsenc"

                Dim param33 As New SqlClient.SqlParameter
                param33.SqlDbType = SqlDbType.bit
                param33.Value = aipinsenc.irechinsenc
                param33.ParameterName = "p_irechinsenc"

                Dim param34 As New SqlClient.SqlParameter
                param34.SqlDbType = SqlDbType.varchar
                param34.Size = 500
                If aipinsenc.xmotcrechinsenc IsNot Nothing Then
                    param34.Value = aipinsenc.xmotcrechinsenc
                Else
                    param34.Value = ""
                End If
                param34.ParameterName = "p_xmotcrechinsenc"

                Dim param35 As New SqlClient.SqlParameter
                param35.SqlDbType = SqlDbType.datetime
                If aipinsenc.fcancinsenc > CDate("01-01-1900") Then
                    param35.Value = aipinsenc.fcancinsenc
                Else
                    param35.Value = CDate("01-01-1900")
                End If
                param35.ParameterName = "p_fcancinsenc"

                Dim param36 As New SqlClient.SqlParameter
                param36.SqlDbType = SqlDbType.datetime
                If aipinsenc.facepinsenc > CDate("01-01-1900") Then
                    param36.Value = aipinsenc.facepinsenc
                Else
                    param36.Value = CDate("01-01-1900")
                End If
                param36.ParameterName = "p_facepinsenc"

                Dim param37 As New SqlClient.SqlParameter
                param37.SqlDbType = SqlDbType.varchar
                param37.Size = 500
                If aipinsenc.xdescinsenc IsNot Nothing Then
                    param37.Value = aipinsenc.xdescinsenc
                Else
                    param37.Value = ""
                End If
                param37.ParameterName = "p_xdescinsenc"

                Dim param38 As New SqlClient.SqlParameter
                param38.SqlDbType = SqlDbType.bit
                param38.Value = aipinsenc.icerrarinsenc
                param38.ParameterName = "p_icerrarinsenc"

                Dim param39 As New SqlClient.SqlParameter
                param39.SqlDbType = SqlDbType.varchar
                param39.Size = 20
                If aipinsenc.iestatinsenc IsNot Nothing Then
                    param39.Value = aipinsenc.iestatinsenc
                Else
                    param39.Value = ""
                End If
                param39.ParameterName = "p_iestatinsenc"

                Dim param40 As New SqlClient.SqlParameter
                param40.SqlDbType = SqlDbType.decimal
                param40.Precision = 18
                param40.Scale = 0
                param40.Value = aipinsenc.idseglogreg
                param40.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsenc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsenc output,@p_idaipactivperi,@p_idaipinsintext,@p_itipoinsenc,@p_idaipinsmotiv,@p_itipoperitinsenc,@p_iorigeninsenc,@p_idsegmanusuperit,@p_idsegmanusuaudit,@p_xcedpropinsenc,@p_xcedsidoinsenc,@p_xplacinsenc,@p_xsermotinsenc,@p_xsercarrinsenc,@p_xnumpolinsenc,@p_xnumsininsenc,@p_xllavinsenc,@p_xnomprodinsenc,@p_xnomprodtorinsenc,@p_xnomramopolizinsenc,@p_xnomsucinsinsenc,@p_fcreainsenc,@p_fprocinsenc,@p_faudinsenc,@p_fultrechinsenc,@p_irechinsenc,@p_xmotcrechinsenc,@p_fcancinsenc,@p_facepinsenc,@p_xdescinsenc,@p_icerrarinsenc,@p_iestatinsenc,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40)

                Dim respopera As New respopera
                respopera.irespuesta = param4.Value
                respopera.xmsjusuario = param5.Value
                respopera.xmsjtecnico = param6.Value
                If IsNumeric(param8.Value) = True Then
                    respopera.id = Int(param8.Value)
                End If

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        <HttpPost()> _
        Public Function desaipinsenc(aipinsenc As aipinsenc) As respopera
            Try

                Dim param1 As New SqlClient.SqlParameter
                param1.SqlDbType = SqlDbType.VarChar
                param1.Size = 20
                param1.Value = "desactivar"
                param1.ParameterName = "p_ioperacion"

                Dim param2 As New SqlClient.SqlParameter
                param2.SqlDbType = SqlDbType.Decimal
                param2.Precision = 18
                param2.Scale = 0
                param2.Value = 0
                param2.ParameterName = "p_idsegmanusulog"

                Dim param3 As New SqlClient.SqlParameter
                param3.SqlDbType = SqlDbType.VarChar
                param3.Size = 20
                param3.value = "aipauto"
                param3.ParameterName = "p_xnombrecortolog"

                Dim param4 As New SqlClient.SqlParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
                param4.SqlDbType = SqlDbType.VarChar
                param4.Size = 1
                param4.ParameterName = "p_irespuesta"
                param4.Direction = ParameterDirection.Output

                Dim param5 As New SqlClient.SqlParameter
                param5.SqlDbType = SqlDbType.VarChar
                param5.Size = 300
                param5.ParameterName = "p_xmsjusuario"
                param5.Direction = ParameterDirection.Output

                Dim param6 As New SqlClient.SqlParameter
                param6.SqlDbType = SqlDbType.VarChar
                param6.Size = 300
                param6.ParameterName = "p_xmsjtecnico"
                param6.Direction = ParameterDirection.Output

                Dim param7 As New SqlClient.SqlParameter
                param7.SqlDbType = SqlDbType.VarChar
                param7.Size = 300
                param7.ParameterName = "p_coderrorlog"
                param7.Direction = ParameterDirection.Output

                'Paramestros de la tabla

                Dim param8 As New SqlClient.SqlParameter
                param8.SqlDbType = SqlDbType.decimal
                param8.Precision = 18
                param8.Scale = 0
                param8.Value = aipinsenc.idaipinsenc
                param8.ParameterName = "p_idaipinsenc"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsenc.idaipactivperi
                param9.ParameterName = "p_idaipactivperi"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinsenc.idaipinsintext
                param10.ParameterName = "p_idaipinsintext"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.varchar
                param11.Size = 50
                If aipinsenc.itipoinsenc IsNot Nothing Then
                    param11.Value = aipinsenc.itipoinsenc
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_itipoinsenc"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = aipinsenc.idaipinsmotiv
                param12.ParameterName = "p_idaipinsmotiv"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.varchar
                param13.Size = 20
                If aipinsenc.itipoperitinsenc IsNot Nothing Then
                    param13.Value = aipinsenc.itipoperitinsenc
                Else
                    param13.Value = ""
                End If
                param13.ParameterName = "p_itipoperitinsenc"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.varchar
                param14.Size = 20
                If aipinsenc.iorigeninsenc IsNot Nothing Then
                    param14.Value = aipinsenc.iorigeninsenc
                Else
                    param14.Value = ""
                End If
                param14.ParameterName = "p_iorigeninsenc"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = aipinsenc.idsegmanusuperit
                param15.ParameterName = "p_idsegmanusuperit"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = aipinsenc.idsegmanusuaudit
                param16.ParameterName = "p_idsegmanusuaudit"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.varchar
                param17.Size = 20
                If aipinsenc.xcedpropinsenc IsNot Nothing Then
                    param17.Value = aipinsenc.xcedpropinsenc
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xcedpropinsenc"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.varchar
                param18.Size = 20
                If aipinsenc.xcedsidoinsenc IsNot Nothing Then
                    param18.Value = aipinsenc.xcedsidoinsenc
                Else
                    param18.Value = ""
                End If
                param18.ParameterName = "p_xcedsidoinsenc"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.varchar
                param19.Size = 20
                If aipinsenc.xplacinsenc IsNot Nothing Then
                    param19.Value = aipinsenc.xplacinsenc
                Else
                    param19.Value = ""
                End If
                param19.ParameterName = "p_xplacinsenc"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.varchar
                param20.Size = 30
                If aipinsenc.xsermotinsenc IsNot Nothing Then
                    param20.Value = aipinsenc.xsermotinsenc
                Else
                    param20.Value = ""
                End If
                param20.ParameterName = "p_xsermotinsenc"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.varchar
                param21.Size = 30
                If aipinsenc.xsercarrinsenc IsNot Nothing Then
                    param21.Value = aipinsenc.xsercarrinsenc
                Else
                    param21.Value = ""
                End If
                param21.ParameterName = "p_xsercarrinsenc"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.varchar
                param22.Size = 50
                If aipinsenc.xnumpolinsenc IsNot Nothing Then
                    param22.Value = aipinsenc.xnumpolinsenc
                Else
                    param22.Value = ""
                End If
                param22.ParameterName = "p_xnumpolinsenc"

                Dim param23 As New SqlClient.SqlParameter
                param23.SqlDbType = SqlDbType.varchar
                param23.Size = 50
                If aipinsenc.xnumsininsenc IsNot Nothing Then
                    param23.Value = aipinsenc.xnumsininsenc
                Else
                    param23.Value = ""
                End If
                param23.ParameterName = "p_xnumsininsenc"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.varchar
                param24.Size = 200
                If aipinsenc.xllavinsenc IsNot Nothing Then
                    param24.Value = aipinsenc.xllavinsenc
                Else
                    param24.Value = ""
                End If
                param24.ParameterName = "p_xllavinsenc"

                Dim param25 As New SqlClient.SqlParameter
                param25.SqlDbType = SqlDbType.varchar
                param25.Size = 100
                If aipinsenc.xnomprodinsenc IsNot Nothing Then
                    param25.Value = aipinsenc.xnomprodinsenc
                Else
                    param25.Value = ""
                End If
                param25.ParameterName = "p_xnomprodinsenc"

                Dim param26 As New SqlClient.SqlParameter
                param26.SqlDbType = SqlDbType.varchar
                param26.Size = 100
                If aipinsenc.xnomprodtorinsenc IsNot Nothing Then
                    param26.Value = aipinsenc.xnomprodtorinsenc
                Else
                    param26.Value = ""
                End If
                param26.ParameterName = "p_xnomprodtorinsenc"

                Dim param27 As New SqlClient.SqlParameter
                param27.SqlDbType = SqlDbType.varchar
                param27.Size = 100
                If aipinsenc.xnomramopolizinsenc IsNot Nothing Then
                    param27.Value = aipinsenc.xnomramopolizinsenc
                Else
                    param27.Value = ""
                End If
                param27.ParameterName = "p_xnomramopolizinsenc"

                Dim param28 As New SqlClient.SqlParameter
                param28.SqlDbType = SqlDbType.varchar
                param28.Size = 100
                If aipinsenc.xnomsucinsinsenc IsNot Nothing Then
                    param28.Value = aipinsenc.xnomsucinsinsenc
                Else
                    param28.Value = ""
                End If
                param28.ParameterName = "p_xnomsucinsinsenc"

                Dim param29 As New SqlClient.SqlParameter
                param29.SqlDbType = SqlDbType.datetime
                If aipinsenc.fcreainsenc > CDate("01-01-1900") Then
                    param29.Value = aipinsenc.fcreainsenc
                Else
                    param29.Value = CDate("01-01-1900")
                End If
                param29.ParameterName = "p_fcreainsenc"

                Dim param30 As New SqlClient.SqlParameter
                param30.SqlDbType = SqlDbType.datetime
                If aipinsenc.fprocinsenc > CDate("01-01-1900") Then
                    param30.Value = aipinsenc.fprocinsenc
                Else
                    param30.Value = CDate("01-01-1900")
                End If
                param30.ParameterName = "p_fprocinsenc"

                Dim param31 As New SqlClient.SqlParameter
                param31.SqlDbType = SqlDbType.datetime
                If aipinsenc.faudinsenc > CDate("01-01-1900") Then
                    param31.Value = aipinsenc.faudinsenc
                Else
                    param31.Value = CDate("01-01-1900")
                End If
                param31.ParameterName = "p_faudinsenc"

                Dim param32 As New SqlClient.SqlParameter
                param32.SqlDbType = SqlDbType.datetime
                If aipinsenc.fultrechinsenc > CDate("01-01-1900") Then
                    param32.Value = aipinsenc.fultrechinsenc
                Else
                    param32.Value = CDate("01-01-1900")
                End If
                param32.ParameterName = "p_fultrechinsenc"

                Dim param33 As New SqlClient.SqlParameter
                param33.SqlDbType = SqlDbType.bit
                param33.Value = aipinsenc.irechinsenc
                param33.ParameterName = "p_irechinsenc"

                Dim param34 As New SqlClient.SqlParameter
                param34.SqlDbType = SqlDbType.varchar
                param34.Size = 500
                If aipinsenc.xmotcrechinsenc IsNot Nothing Then
                    param34.Value = aipinsenc.xmotcrechinsenc
                Else
                    param34.Value = ""
                End If
                param34.ParameterName = "p_xmotcrechinsenc"

                Dim param35 As New SqlClient.SqlParameter
                param35.SqlDbType = SqlDbType.datetime
                If aipinsenc.fcancinsenc > CDate("01-01-1900") Then
                    param35.Value = aipinsenc.fcancinsenc
                Else
                    param35.Value = CDate("01-01-1900")
                End If
                param35.ParameterName = "p_fcancinsenc"

                Dim param36 As New SqlClient.SqlParameter
                param36.SqlDbType = SqlDbType.datetime
                If aipinsenc.facepinsenc > CDate("01-01-1900") Then
                    param36.Value = aipinsenc.facepinsenc
                Else
                    param36.Value = CDate("01-01-1900")
                End If
                param36.ParameterName = "p_facepinsenc"

                Dim param37 As New SqlClient.SqlParameter
                param37.SqlDbType = SqlDbType.varchar
                param37.Size = 500
                If aipinsenc.xdescinsenc IsNot Nothing Then
                    param37.Value = aipinsenc.xdescinsenc
                Else
                    param37.Value = ""
                End If
                param37.ParameterName = "p_xdescinsenc"

                Dim param38 As New SqlClient.SqlParameter
                param38.SqlDbType = SqlDbType.bit
                param38.Value = aipinsenc.icerrarinsenc
                param38.ParameterName = "p_icerrarinsenc"

                Dim param39 As New SqlClient.SqlParameter
                param39.SqlDbType = SqlDbType.varchar
                param39.Size = 20
                If aipinsenc.iestatinsenc IsNot Nothing Then
                    param39.Value = aipinsenc.iestatinsenc
                Else
                    param39.Value = ""
                End If
                param39.ParameterName = "p_iestatinsenc"

                Dim param40 As New SqlClient.SqlParameter
                param40.SqlDbType = SqlDbType.decimal
                param40.Precision = 18
                param40.Scale = 0
                param40.Value = aipinsenc.idseglogreg
                param40.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsenc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsenc output,@p_idaipactivperi,@p_idaipinsintext,@p_itipoinsenc,@p_idaipinsmotiv,@p_itipoperitinsenc,@p_iorigeninsenc,@p_idsegmanusuperit,@p_idsegmanusuaudit,@p_xcedpropinsenc,@p_xcedsidoinsenc,@p_xplacinsenc,@p_xsermotinsenc,@p_xsercarrinsenc,@p_xnumpolinsenc,@p_xnumsininsenc,@p_xllavinsenc,@p_xnomprodinsenc,@p_xnomprodtorinsenc,@p_xnomramopolizinsenc,@p_xnomsucinsinsenc,@p_fcreainsenc,@p_fprocinsenc,@p_faudinsenc,@p_fultrechinsenc,@p_irechinsenc,@p_xmotcrechinsenc,@p_fcancinsenc,@p_facepinsenc,@p_xdescinsenc,@p_icerrarinsenc,@p_iestatinsenc,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40)

                Dim respopera As New respopera
                respopera.irespuesta = param4.Value
                respopera.xmsjusuario = param5.Value
                respopera.xmsjtecnico = param6.Value
                If IsNumeric(param8.Value) = True Then
                    respopera.id = Int(param8.Value)
                End If

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selaipinsencporauditar() As List(Of aipinsenc)
            Dim lista_aipinsenc As List(Of aipinsenc) = (From p In _db.aipinsenc
                                                         Where p.iestatinsenc = "POR AUDITAR"
                                                        Select p).ToList
            '
            Return lista_aipinsenc
        End Function

        <HttpPost()> _
        Public Function selaipinsencporauditarporauditor(idsegmanusuaudit As Decimal) As List(Of aipinsenc)
            Dim lista_aipinsenc As List(Of aipinsenc) = (From p In _db.aipinsenc
                                                         Where p.idsegmanusuaudit = idsegmanusuaudit And p.iestatinsenc = "POR AUDITAR"
                                                        Select p).ToList
            '
            Return lista_aipinsenc
        End Function

        <HttpPost()> _
        Public Function selaipinsencxidporauditar(idaipinsenc As Decimal) As aipinsenc
            Dim aipinsenc As aipinsenc = (From p In _db.aipinsenc
                                                         Where p.idaipinsenc = idaipinsenc And p.iestatinsenc = "POR AUDITAR"
                                                        Select p).SingleOrDefault
            '
            Return aipinsenc
        End Function

        <HttpPost()> _
        Public Function iexisteaipinsencxidext(idaipinsintext As Decimal) As Boolean
            Dim iexsiste As Boolean = (From p In _db.aipinsenc
                                                         Where p.idaipinsintext = idaipinsintext
                                                        Select p).Any()
            '
            Return iexsiste
        End Function

        <HttpPost()> _
        Public Function ObtenerMaxIdPorNumSini(xnumsininsenc As String) As Decimal
            Dim idaipinsenc As Decimal = (From p In _db.aipinsenc
                                            Where p.xnumsininsenc = xnumsininsenc
                                            Select p).DefaultIfEmpty().Max(Function(p) If(p Is Nothing, 0, p.idaipinsenc))
            Return idaipinsenc
        End Function

        <HttpPost()> _
        Public Function ObtenerCantPorNumSini(xnumsininsenc As String) As Int16
            Dim ncant As Int16 = (From p In _db.aipinsenc
                                            Where p.xnumsininsenc = xnumsininsenc
                                            Select p).Count()
            Return ncant
        End Function

End Class
End Namespace
