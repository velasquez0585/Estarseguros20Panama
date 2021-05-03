Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports Oracle.ManagedDataAccess
Namespace aipauto.entidades.controlador
    Public Class aipinssusmotivController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selaipinssusmotivxid(idaipinssusmotiv As Decimal) As aipinssusmotiv
            Dim aipinssusmotiv As aipinssusmotiv = (From p In _db.aipinssusmotiv
                                            Where p.idaipinssusmotiv = idaipinssusmotiv
                                            Select p).SingleOrDefault
            Return aipinssusmotiv
        End Function

        <HttpPost()> _
        Public Function selaipinssusmotiv() As List(Of aipinssusmotiv)
            Dim lista_aipinssusmotiv As List(Of aipinssusmotiv) = (From p In _db.aipinssusmotiv
                                                        Select p).ToList
            '
            Return lista_aipinssusmotiv
        End Function

        <HttpPost()> _
           Public Function selaipinssusmotivxwheredinamicopag(petiaipinssusmotivpaglist As petiaipinssusmotivpaglist) As respaipinssusmotivpaglist
            Dim sb As New StringBuilder("")
            '
            If petiaipinssusmotivpaglist.aipinssusmotiv.idaipinssusmotiv <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssusmotiv=")
                    sb.Append(valor_entero(petiaipinssusmotivpaglist.aipinssusmotiv.idaipinssusmotiv))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssusmotiv=")
                        sb.Append(valor_entero(petiaipinssusmotivpaglist.aipinssusmotiv.idaipinssusmotiv))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusmotivpaglist.aipinssusmotiv.idaipinssus <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssus=")
                    sb.Append(valor_entero(petiaipinssusmotivpaglist.aipinssusmotiv.idaipinssus))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssus=")
                        sb.Append(valor_entero(petiaipinssusmotivpaglist.aipinssusmotiv.idaipinssus))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusmotivpaglist.aipinssusmotiv.idaipinsmotiv <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsmotiv=")
                    sb.Append(valor_entero(petiaipinssusmotivpaglist.aipinssusmotiv.idaipinsmotiv))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsmotiv=")
                        sb.Append(valor_entero(petiaipinssusmotivpaglist.aipinssusmotiv.idaipinsmotiv))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusmotivpaglist.aipinssusmotiv.itilinssusmotiv <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.itilinssusmotiv=")
                    sb.Append(valor_entero(petiaipinssusmotivpaglist.aipinssusmotiv.itilinssusmotiv))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itilinssusmotiv=")
                        sb.Append(valor_entero(petiaipinssusmotivpaglist.aipinssusmotiv.itilinssusmotiv))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusmotivpaglist.aipinssusmotiv.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petiaipinssusmotivpaglist.aipinssusmotiv.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petiaipinssusmotivpaglist.aipinssusmotiv.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respaipinssusmotivpaglist As New respaipinssusmotivpaglist
            respaipinssusmotivpaglist.pagaipinssusmotiv = petiaipinssusmotivpaglist.pagaipinssusmotiv
            Dim skip = skip_paginacion(petiaipinssusmotivpaglist.pagaipinssusmotiv.npagactual, petiaipinssusmotivpaglist.pagaipinssusmotiv.npagtamano)

            If sb.ToString = "" Then
                respaipinssusmotivpaglist.lista_aipinssusmotiv = _db.aipinssusmotiv.OrderBy(petiaipinssusmotivpaglist.pagaipinssusmotiv.xcamposord & " " & petiaipinssusmotivpaglist.pagaipinssusmotiv.idirord).Skip(skip).Take(petiaipinssusmotivpaglist.pagaipinssusmotiv.npagtamano).ToList
            Else
                respaipinssusmotivpaglist.lista_aipinssusmotiv = _db.aipinssusmotiv.Where(sb.ToString).OrderBy(petiaipinssusmotivpaglist.pagaipinssusmotiv.xcamposord & " " & petiaipinssusmotivpaglist.pagaipinssusmotiv.idirord).Skip(skip).Take(petiaipinssusmotivpaglist.pagaipinssusmotiv.npagtamano).ToList
            End If
            '
            If (respaipinssusmotivpaglist.lista_aipinssusmotiv.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selaipinssusmotivxwheredinamicocount(sb)
                respaipinssusmotivpaglist.pagaipinssusmotiv.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinssusmotivpaglist.pagaipinssusmotiv.npagtamano)
            Else
                respaipinssusmotivpaglist.pagaipinssusmotiv.npagcantidad = 0
                respaipinssusmotivpaglist.pagaipinssusmotiv.npagactual = 0
            End If

            Return respaipinssusmotivpaglist
        End Function

        Public Function selaipinssusmotivxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.aipinssusmotiv.count
            Else
                Return _db.aipinssusmotiv.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
        Public Function insaipinssusmotiv(aipinssusmotiv As aipinssusmotiv) As respopera
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
                    param3.Value = ""
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
                    param8.ParameterName = "p_idaipinssusmotiv"
                    param8.Direction = ParameterDirection.Output

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssusmotiv.idaipinssus
                    param9.ParameterName = "p_idaipinssus"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssusmotiv.idaipinsmotiv
                    param10.ParameterName = "p_idaipinsmotiv"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Bit
                    param11.Value = aipinssusmotiv.itilinssusmotiv
                    param11.ParameterName = "p_itilinssusmotiv"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Decimal
                    param12.Precision = 18
                    param12.Scale = 0
                    param12.Value = 0
                    param12.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusmotiv @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusmotiv output,@p_idaipinssus,@p_idaipinsmotiv,@p_itilinssusmotiv,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If

                Else

                    respopera = insaipinssusmotivoracle(aipinssusmotiv)                    

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
        Public Function insaipinssusmotivoracle(aipinssusmotiv As aipinssusmotiv) As respopera
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
                param8.ParameterName = "p_idaipinssusmotiv"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssusmotiv.idaipinssus
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssusmotiv.idaipinsmotiv
                param10.ParameterName = "p_idaipinsmotiv"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = aipinssusmotiv.itilinssusmotiv
                param11.ParameterName = "p_itilinssusmotiv"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = 0
                param12.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssusmotiv FLOAT; v_p_idaipinssus FLOAT; v_p_idaipinsmotiv FLOAT; v_p_itilinssusmotiv number; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssusmotiv(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssusmotiv,:v_p_idaipinssus,:v_p_idaipinsmotiv,:v_p_itilinssusmotiv,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12)

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
        Public Function modaipinssusmotiv(aipinssusmotiv As aipinssusmotiv) As respopera
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
                    param3.Value = ""
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
                    param8.Value = aipinssusmotiv.idaipinssusmotiv
                    param8.ParameterName = "p_idaipinssusmotiv"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssusmotiv.idaipinssus
                    param9.ParameterName = "p_idaipinssus"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssusmotiv.idaipinsmotiv
                    param10.ParameterName = "p_idaipinsmotiv"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Bit
                    param11.Value = aipinssusmotiv.itilinssusmotiv
                    param11.ParameterName = "p_itilinssusmotiv"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Decimal
                    param12.Precision = 18
                    param12.Scale = 0
                    param12.Value = aipinssusmotiv.idseglogreg
                    param12.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusmotiv @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusmotiv output,@p_idaipinssus,@p_idaipinsmotiv,@p_itilinssusmotiv,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If

                Else

                    respopera = modaipinssusmotivoracle(aipinssusmotiv)

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
        Public Function modaipinssusmotivoracle(aipinssusmotiv As aipinssusmotiv) As respopera
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
                param8.Value = aipinssusmotiv.idaipinssusmotiv
                param8.ParameterName = "p_idaipinssusmotiv"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssusmotiv.idaipinssus
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssusmotiv.idaipinsmotiv
                param10.ParameterName = "p_idaipinsmotiv"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = aipinssusmotiv.itilinssusmotiv
                param11.ParameterName = "p_itilinssusmotiv"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = aipinssusmotiv.idseglogreg
                param12.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssusmotiv FLOAT; v_p_idaipinssus FLOAT; v_p_idaipinsmotiv FLOAT; v_p_itilinssusmotiv number; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssusmotiv(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssusmotiv,:v_p_idaipinssus,:v_p_idaipinsmotiv,:v_p_itilinssusmotiv,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12)

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
        Public Function eliaipinssusmotiv(aipinssusmotiv As aipinssusmotiv) As respopera
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
                    param3.Value = ""
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
                    param8.Value = aipinssusmotiv.idaipinssusmotiv
                    param8.ParameterName = "p_idaipinssusmotiv"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssusmotiv.idaipinssus
                    param9.ParameterName = "p_idaipinssus"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssusmotiv.idaipinsmotiv
                    param10.ParameterName = "p_idaipinsmotiv"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Bit
                    param11.Value = aipinssusmotiv.itilinssusmotiv
                    param11.ParameterName = "p_itilinssusmotiv"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Decimal
                    param12.Precision = 18
                    param12.Scale = 0
                    param12.Value = aipinssusmotiv.idseglogreg
                    param12.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusmotiv @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusmotiv output,@p_idaipinssus,@p_idaipinsmotiv,@p_itilinssusmotiv,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else

                    respopera = eliaipinssusmotivoracle(aipinssusmotiv)

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
        Public Function eliaipinssusmotivoracle(aipinssusmotiv As aipinssusmotiv) As respopera
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
                param8.Value = aipinssusmotiv.idaipinssusmotiv
                param8.ParameterName = "p_idaipinssusmotiv"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssusmotiv.idaipinssus
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssusmotiv.idaipinsmotiv
                param10.ParameterName = "p_idaipinsmotiv"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = aipinssusmotiv.itilinssusmotiv
                param11.ParameterName = "p_itilinssusmotiv"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = aipinssusmotiv.idseglogreg
                param12.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssusmotiv FLOAT; v_p_idaipinssus FLOAT; v_p_idaipinsmotiv FLOAT; v_p_itilinssusmotiv number; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssusmotiv(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssusmotiv,:v_p_idaipinssus,:v_p_idaipinsmotiv,:v_p_itilinssusmotiv,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12)

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
        Public Function eliaipinssusmotiv(idaipinssusmotiv As Decimal) As respopera
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
                    param3.Value = ""
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
                    param8.Value = idaipinssusmotiv
                    param8.ParameterName = "p_idaipinssusmotiv"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = 0
                    param9.ParameterName = "p_idaipinssus"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = 0
                    param10.ParameterName = "p_idaipinsmotiv"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Bit
                    param11.Value = 0
                    param11.ParameterName = "p_itilinssusmotiv"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Decimal
                    param12.Precision = 18
                    param12.Scale = 0
                    param12.Value = 0
                    param12.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusmotiv @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusmotiv output,@p_idaipinssus,@p_idaipinsmotiv,@p_itilinssusmotiv,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else

                    respopera = eliaipinssusmotivoracle(idaipinssusmotiv)
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
        Public Function eliaipinssusmotivoracle(idaipinssusmotiv As Decimal) As respopera
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
                param8.Value = idaipinssusmotiv
                param8.ParameterName = "p_idaipinssusmotiv"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = 0
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = 0
                param10.ParameterName = "p_idaipinsmotiv"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = 0
                param11.ParameterName = "p_itilinssusmotiv"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = 0
                param12.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssusmotiv FLOAT; v_p_idaipinssus FLOAT; v_p_idaipinsmotiv FLOAT; v_p_itilinssusmotiv number; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssusmotiv(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssusmotiv,:v_p_idaipinssus,:v_p_idaipinsmotiv,:v_p_itilinssusmotiv,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12)

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
        Public Function actaipinssusmotiv(aipinssusmotiv As aipinssusmotiv) As respopera
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
                param3.value = ""
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
                param8.Value = aipinssusmotiv.idaipinssusmotiv
                param8.ParameterName = "p_idaipinssusmotiv"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssusmotiv.idaipinssus
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssusmotiv.idaipinsmotiv
                param10.ParameterName = "p_idaipinsmotiv"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.bit
                param11.Value = aipinssusmotiv.itilinssusmotiv
                param11.ParameterName = "p_itilinssusmotiv"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = aipinssusmotiv.idseglogreg
                param12.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusmotiv @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusmotiv output,@p_idaipinssus,@p_idaipinsmotiv,@p_itilinssusmotiv,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12)

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
        Public Function desaipinssusmotiv(aipinssusmotiv As aipinssusmotiv) As respopera
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
                param3.value = ""
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
                param8.Value = aipinssusmotiv.idaipinssusmotiv
                param8.ParameterName = "p_idaipinssusmotiv"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssusmotiv.idaipinssus
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssusmotiv.idaipinsmotiv
                param10.ParameterName = "p_idaipinsmotiv"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.bit
                param11.Value = aipinssusmotiv.itilinssusmotiv
                param11.ParameterName = "p_itilinssusmotiv"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = aipinssusmotiv.idseglogreg
                param12.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusmotiv @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusmotiv output,@p_idaipinssus,@p_idaipinsmotiv,@p_itilinssusmotiv,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12)

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
        Public Function selaipinssusmotivxidaipinssus(idaipinssus As Decimal) As List(Of aipinssusmotiv)
            Dim lista_aipinssusmotiv As List(Of aipinssusmotiv) = (From p In _db.aipinssusmotiv
                                            Where p.idaipinssus = idaipinssus
                                            Select p).ToList
            Return lista_aipinssusmotiv
        End Function
    End Class
End Namespace
