Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
    Public Class aipmanusuconfController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selaipmanusuconfxid(idaipmanusuconf As Decimal) As aipmanusuconf
            Dim aipmanusuconf As aipmanusuconf = (From p In _db.aipmanusuconf
                                            Where p.idaipmanusuconf = idaipmanusuconf
                                            Select p).SingleOrDefault
            Return aipmanusuconf
        End Function

        <HttpPost()> _
        Public Function selaipmanusuconf() As List(Of aipmanusuconf)
            Dim lista_aipmanusuconf As List(Of aipmanusuconf) = (From p In _db.aipmanusuconf
                                                           Where p.idaipmanusuconf > 0
                                                        Select p).ToList
            '
            Return lista_aipmanusuconf
        End Function

        <HttpPost()> _
           Public Function selaipmanusuconfxwheredinamicopag(petiaipmanusuconfpaglist As petiaipmanusuconfpaglist) As respaipmanusuconfpaglist
            Dim sb As New StringBuilder("")
            '
            If petiaipmanusuconfpaglist.aipmanusuconf.idaipmanusuconf <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipmanusuconf=")
                    sb.Append(valor_entero(petiaipmanusuconfpaglist.aipmanusuconf.idaipmanusuconf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipmanusuconf=")
                        sb.Append(valor_entero(petiaipmanusuconfpaglist.aipmanusuconf.idaipmanusuconf))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipmanusuconfpaglist.aipmanusuconf.idsegmanusu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusu=")
                    sb.Append(petiaipmanusuconfpaglist.aipmanusuconf.idsegmanusu)
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusu=")
                        sb.Append(petiaipmanusuconfpaglist.aipmanusuconf.idsegmanusu)
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipmanusuconfpaglist.aipmanusuconf.finisusmanusuconf > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.finisusmanusuconf >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipmanusuconfpaglist.aipmanusuconf.finisusmanusuconf)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.finisusmanusuconf >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipmanusuconfpaglist.aipmanusuconf.finisusmanusuconf)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaipmanusuconfpaglist.aipmanusuconf.ffinsusmanusuconf > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.ffinsusmanusuconf >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipmanusuconfpaglist.aipmanusuconf.ffinsusmanusuconf)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.ffinsusmanusuconf >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipmanusuconfpaglist.aipmanusuconf.ffinsusmanusuconf)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaipmanusuconfpaglist.aipmanusuconf.iestatmanusuconf <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestatmanusuconf='")
                    sb.Append(petiaipmanusuconfpaglist.aipmanusuconf.iestatmanusuconf)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatmanusuconf='")
                        sb.Append(petiaipmanusuconfpaglist.aipmanusuconf.iestatmanusuconf)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipmanusuconfpaglist.aipmanusuconf.fcreamanusuconf > CDate("01-01-1920") Then

                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fcreamanusuconf >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipmanusuconfpaglist.aipmanusuconf.fcreamanusuconf)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fcreamanusuconf >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipmanusuconfpaglist.aipmanusuconf.fcreamanusuconf)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaipmanusuconfpaglist.aipmanusuconf.fmodmanusuconf > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fmodmanusuconf >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipmanusuconfpaglist.aipmanusuconf.fmodmanusuconf)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fmodmanusuconf >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipmanusuconfpaglist.aipmanusuconf.fmodmanusuconf)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaipmanusuconfpaglist.aipmanusuconf.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petiaipmanusuconfpaglist.aipmanusuconf.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petiaipmanusuconfpaglist.aipmanusuconf.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respaipmanusuconfpaglist As New respaipmanusuconfpaglist
            respaipmanusuconfpaglist.pagaipmanusuconf = petiaipmanusuconfpaglist.pagaipmanusuconf
            Dim skip = skip_paginacion(petiaipmanusuconfpaglist.pagaipmanusuconf.npagactual, petiaipmanusuconfpaglist.pagaipmanusuconf.npagtamano)

            If sb.ToString = "" Then
                respaipmanusuconfpaglist.lista_aipmanusuconf = _db.aipmanusuconf.OrderBy(petiaipmanusuconfpaglist.pagaipmanusuconf.xcamposord & " " & petiaipmanusuconfpaglist.pagaipmanusuconf.idirord).Skip(skip).Take(petiaipmanusuconfpaglist.pagaipmanusuconf.npagtamano).ToList
            Else
                respaipmanusuconfpaglist.lista_aipmanusuconf = _db.aipmanusuconf.Where(sb.ToString).OrderBy(petiaipmanusuconfpaglist.pagaipmanusuconf.xcamposord & " " & petiaipmanusuconfpaglist.pagaipmanusuconf.idirord).Skip(skip).Take(petiaipmanusuconfpaglist.pagaipmanusuconf.npagtamano).ToList
            End If
            '
            If (respaipmanusuconfpaglist.lista_aipmanusuconf.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selaipmanusuconfxwheredinamicocount(sb)
                respaipmanusuconfpaglist.pagaipmanusuconf.npagcantidad = cantidad_paginas(cant_entero_reg, respaipmanusuconfpaglist.pagaipmanusuconf.npagtamano)
            Else
                respaipmanusuconfpaglist.pagaipmanusuconf.npagcantidad = 0
                respaipmanusuconfpaglist.pagaipmanusuconf.npagactual = 0
            End If

            Return respaipmanusuconfpaglist
        End Function

        Public Function selaipmanusuconfxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.aipmanusuconf.count
            Else
                Return _db.aipmanusuconf.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
        Public Function insaipmanusuconf(aipmanusuconf As aipmanusuconf) As respopera
            Try

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
                param8.Value = 0
                param8.ParameterName = "p_idaipmanusuconf"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param8.Precision = 18
                param8.Scale = 0
                param9.Value = aipmanusuconf.idsegmanusu
                param9.ParameterName = "p_idsegmanusu"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.DateTime
                If aipmanusuconf.finisusmanusuconf > CDate("01-01-1900") Then
                    param10.Value = aipmanusuconf.finisusmanusuconf
                Else
                    param10.Value = CDate("01-01-1900")
                End If
                param10.ParameterName = "p_finisusmanusuconf"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.DateTime
                If aipmanusuconf.ffinsusmanusuconf > CDate("01-01-1900") Then
                    param11.Value = aipmanusuconf.ffinsusmanusuconf
                Else
                    param11.Value = CDate("01-01-1900")
                End If
                param11.ParameterName = "p_ffinsusmanusuconf"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                If aipmanusuconf.iestatmanusuconf IsNot Nothing Then
                    param12.Value = aipmanusuconf.iestatmanusuconf
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_iestatmanusuconf"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.DateTime
                If aipmanusuconf.fcreamanusuconf > CDate("01-01-1900") Then
                    param13.Value = aipmanusuconf.fcreamanusuconf
                Else
                    param13.Value = CDate("01-01-1900")
                End If
                param13.ParameterName = "p_fcreamanusuconf"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.DateTime
                param14.Size = 20
                If aipmanusuconf.fmodmanusuconf > CDate("01-01-1900") Then
                    param14.Value = aipmanusuconf.fmodmanusuconf
                Else
                    param14.Value = CDate("01-01-1900")
                End If
                param14.ParameterName = "p_fmodmanusuconf"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.Decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = 0
                param15.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanusuconf @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanusuconf output,@p_idsegmanusu,@p_finisusmanusuconf,@p_ffinsusmanusuconf,@p_iestatmanusuconf,@p_fcreamanusuconf,@p_fmodmanusuconf,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15)

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
        Public Function modaipmanusuconf(aipmanusuconf As aipmanusuconf) As respopera
            Try

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
                param8.Value = aipmanusuconf.idaipmanusuconf
                param8.ParameterName = "p_idaipmanusuconf"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param8.Precision = 18
                param8.Scale = 0
                param9.Value = aipmanusuconf.idsegmanusu
                param9.ParameterName = "p_idsegmanusu"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.DateTime
                If aipmanusuconf.finisusmanusuconf > CDate("01-01-1900") Then
                    param10.Value = aipmanusuconf.finisusmanusuconf
                Else
                    param10.Value = CDate("01-01-1900")
                End If
                param10.ParameterName = "p_finisusmanusuconf"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.DateTime
                If aipmanusuconf.ffinsusmanusuconf > CDate("01-01-1900") Then
                    param11.Value = aipmanusuconf.ffinsusmanusuconf
                Else
                    param11.Value = CDate("01-01-1900")
                End If
                param11.ParameterName = "p_ffinsusmanusuconf"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                If aipmanusuconf.iestatmanusuconf IsNot Nothing Then
                    param12.Value = aipmanusuconf.iestatmanusuconf
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_iestatmanusuconf"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.DateTime
                If aipmanusuconf.fcreamanusuconf > CDate("01-01-1900") Then
                    param13.Value = aipmanusuconf.fcreamanusuconf
                Else
                    param13.Value = CDate("01-01-1900")
                End If
                param13.ParameterName = "p_fcreamanusuconf"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.DateTime
                param14.Size = 20
                If aipmanusuconf.fmodmanusuconf > CDate("01-01-1900") Then
                    param14.Value = aipmanusuconf.fmodmanusuconf
                Else
                    param14.Value = CDate("01-01-1900")
                End If
                param14.ParameterName = "p_fmodmanusuconf"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = aipmanusuconf.idseglogreg
                param15.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanusuconf @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanusuconf output,@p_idsegmanusu,@p_finisusmanusuconf,@p_ffinsusmanusuconf,@p_iestatmanusuconf,@p_fcreamanusuconf,@p_fmodmanusuconf,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15)

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
        Public Function eliaipmanusuconf(aipmanusuconf As aipmanusuconf) As respopera
            Try

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
                param8.Value = aipmanusuconf.idaipmanusuconf
                param8.ParameterName = "p_idaipmanusuconf"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param8.Precision = 18
                param8.Scale = 0
                param9.Value = aipmanusuconf.idsegmanusu
                param9.ParameterName = "p_idsegmanusu"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.DateTime
                If aipmanusuconf.finisusmanusuconf > CDate("01-01-1900") Then
                    param10.Value = aipmanusuconf.finisusmanusuconf
                Else
                    param10.Value = CDate("01-01-1900")
                End If
                param10.ParameterName = "p_finisusmanusuconf"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.DateTime
                If aipmanusuconf.ffinsusmanusuconf > CDate("01-01-1900") Then
                    param11.Value = aipmanusuconf.ffinsusmanusuconf
                Else
                    param11.Value = CDate("01-01-1900")
                End If
                param11.ParameterName = "p_ffinsusmanusuconf"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                If aipmanusuconf.iestatmanusuconf IsNot Nothing Then
                    param12.Value = aipmanusuconf.iestatmanusuconf
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_iestatmanusuconf"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.DateTime
                If aipmanusuconf.fcreamanusuconf > CDate("01-01-1900") Then
                    param13.Value = aipmanusuconf.fcreamanusuconf
                Else
                    param13.Value = CDate("01-01-1900")
                End If
                param13.ParameterName = "p_fcreamanusuconf"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.DateTime
                param14.Size = 20
                If aipmanusuconf.fmodmanusuconf > CDate("01-01-1900") Then
                    param14.Value = aipmanusuconf.fmodmanusuconf
                Else
                    param14.Value = CDate("01-01-1900")
                End If
                param14.ParameterName = "p_fmodmanusuconf"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = aipmanusuconf.idseglogreg
                param15.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanusuconf @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanusuconf output,@p_idsegmanusu,@p_finisusmanusuconf,@p_ffinsusmanusuconf,@p_iestatmanusuconf,@p_fcreamanusuconf,@p_fmodmanusuconf,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15)

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
        Public Function eliaipmanusuconf(idaipmanusuconf As Decimal) As respopera
            Try

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
                param8.Value = idaipmanusuconf
                param8.ParameterName = "p_idaipmanusuconf"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param8.Precision = 18
                param8.Scale = 0
                param9.Value = 0
                param9.ParameterName = "p_idsegmanusu"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.DateTime
                param10.Value = CDate("01-01-1900")
                param10.ParameterName = "p_finisusmanusuconf"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.DateTime
                param11.Value = CDate("01-01-1900")
                param11.ParameterName = "p_ffinsusmanusuconf"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                param12.Value = " "
                param12.ParameterName = "p_iestatmanusuconf"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.DateTime
                param13.Value = CDate("01-01-1900")
                param13.ParameterName = "p_fcreamanusuconf"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.DateTime
                param14.Size = 20
                param14.Value = CDate("01-01-1900")
                param14.ParameterName = "p_fmodmanusuconf"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.Decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = 0
                param15.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanusuconf @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanusuconf output,@p_idsegmanusu,@p_finisusmanusuconf,@p_ffinsusmanusuconf,@p_iestatmanusuconf,@p_fcreamanusuconf,@p_fmodmanusuconf,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15)

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
        Public Function actaipmanusuconf(aipmanusuconf As aipmanusuconf) As respopera
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
                param8.Value = aipmanusuconf.idaipmanusuconf
                param8.ParameterName = "p_idaipmanusuconf"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param8.Precision = 18
                param8.Scale = 0
                param9.Value = aipmanusuconf.idsegmanusu
                param9.ParameterName = "p_idsegmanusu"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.DateTime
                If aipmanusuconf.finisusmanusuconf > CDate("01-01-1900") Then
                    param10.Value = aipmanusuconf.finisusmanusuconf
                Else
                    param10.Value = CDate("01-01-1900")
                End If
                param10.ParameterName = "p_finisusmanusuconf"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.DateTime
                If aipmanusuconf.ffinsusmanusuconf > CDate("01-01-1900") Then
                    param11.Value = aipmanusuconf.ffinsusmanusuconf
                Else
                    param11.Value = CDate("01-01-1900")
                End If
                param11.ParameterName = "p_ffinsusmanusuconf"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                If aipmanusuconf.iestatmanusuconf IsNot Nothing Then
                    param12.Value = aipmanusuconf.iestatmanusuconf
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_iestatmanusuconf"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.DateTime
                If aipmanusuconf.fcreamanusuconf > CDate("01-01-1900") Then
                    param13.Value = aipmanusuconf.fcreamanusuconf
                Else
                    param13.Value = CDate("01-01-1900")
                End If
                param13.ParameterName = "p_fcreamanusuconf"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.DateTime
                param14.Size = 20
                If aipmanusuconf.fmodmanusuconf > CDate("01-01-1900") Then
                    param14.Value = aipmanusuconf.fmodmanusuconf
                Else
                    param14.Value = CDate("01-01-1900")
                End If
                param14.ParameterName = "p_fmodmanusuconf"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.Decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = aipmanusuconf.idseglogreg
                param15.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanusuconf @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanusuconf output,@p_idsegmanusu,@p_finisusmanusuconf,@p_ffinsusmanusuconf,@p_iestatmanusuconf,@p_fcreamanusuconf,@p_fmodmanusuconf,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15)

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
        Public Function desaipmanusuconf(aipmanusuconf As aipmanusuconf) As respopera
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
                param8.Value = aipmanusuconf.idaipmanusuconf
                param8.ParameterName = "p_idaipmanusuconf"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param8.Precision = 18
                param8.Scale = 0
                param9.Value = aipmanusuconf.idsegmanusu
                param9.ParameterName = "p_idsegmanusu"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.DateTime
                If aipmanusuconf.finisusmanusuconf > CDate("01-01-1900") Then
                    param10.Value = aipmanusuconf.finisusmanusuconf
                Else
                    param10.Value = CDate("01-01-1900")
                End If
                param10.ParameterName = "p_finisusmanusuconf"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.DateTime
                If aipmanusuconf.ffinsusmanusuconf > CDate("01-01-1900") Then
                    param11.Value = aipmanusuconf.ffinsusmanusuconf
                Else
                    param11.Value = CDate("01-01-1900")
                End If
                param11.ParameterName = "p_ffinsusmanusuconf"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                If aipmanusuconf.iestatmanusuconf IsNot Nothing Then
                    param12.Value = aipmanusuconf.iestatmanusuconf
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_iestatmanusuconf"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.DateTime
                If aipmanusuconf.fcreamanusuconf > CDate("01-01-1900") Then
                    param13.Value = aipmanusuconf.fcreamanusuconf
                Else
                    param13.Value = CDate("01-01-1900")
                End If
                param13.ParameterName = "p_fcreamanusuconf"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.DateTime
                param14.Size = 20
                If aipmanusuconf.fmodmanusuconf > CDate("01-01-1900") Then
                    param14.Value = aipmanusuconf.fmodmanusuconf
                Else
                    param14.Value = CDate("01-01-1900")
                End If
                param14.ParameterName = "p_fmodmanusuconf"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = aipmanusuconf.idseglogreg
                param15.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanusuconf @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanusuconf output,@p_idsegmanusu,@p_finisusmanusuconf,@p_ffinsusmanusuconf,@p_iestatmanusuconf,@p_fcreamanusuconf,@p_fmodmanusuconf,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15)

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

    End Class
End Namespace
