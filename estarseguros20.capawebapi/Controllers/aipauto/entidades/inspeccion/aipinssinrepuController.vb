Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports Oracle.ManagedDataAccess
Namespace aipauto.entidades.controlador
    Public Class aipinssinrepuController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selaipinssinrepuxid(idaipinssinrepu As Decimal) As aipinssinrepu
            Dim aipinssinrepu As aipinssinrepu = (From p In _db.aipinssinrepu
                                            Where p.idaipinssinrepu = idaipinssinrepu
                                            Select p).SingleOrDefault
            Return aipinssinrepu
        End Function

        <HttpPost()> _
        Public Function selaipinssinrepu() As List(Of aipinssinrepu)
            Dim lista_aipinssinrepu As List(Of aipinssinrepu) = (From p In _db.aipinssinrepu
                                                        Select p).ToList
            '
            Return lista_aipinssinrepu
        End Function

        <HttpPost()> _
        Public Function selaipinssinrepuxwheredinamicopag(petiaipinssinrepupaglist As petiaipinssinrepupaglist) As respaipinssinrepupaglist
            Dim sb As New StringBuilder("")
            '
            If petiaipinssinrepupaglist.aipinssinrepu.idaipinssinrepu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssinrepu=")
                    sb.Append(valor_entero(petiaipinssinrepupaglist.aipinssinrepu.idaipinssinrepu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssinrepu=")
                        sb.Append(valor_entero(petiaipinssinrepupaglist.aipinssinrepu.idaipinssinrepu))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinrepupaglist.aipinssinrepu.idaipinssin <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssin=")
                    sb.Append(valor_entero(petiaipinssinrepupaglist.aipinssinrepu.idaipinssin))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssin=")
                        sb.Append(valor_entero(petiaipinssinrepupaglist.aipinssinrepu.idaipinssin))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinrepupaglist.aipinssinrepu.idaipmanrepu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipmanrepu=")
                    sb.Append(valor_entero(petiaipinssinrepupaglist.aipinssinrepu.idaipmanrepu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipmanrepu=")
                        sb.Append(valor_entero(petiaipinssinrepupaglist.aipinssinrepu.idaipmanrepu))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinrepupaglist.aipinssinrepu.ncantinssinrepu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.ncantinssinrepu=")
                    sb.Append(valor_entero(petiaipinssinrepupaglist.aipinssinrepu.ncantinssinrepu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ncantinssinrepu=")
                        sb.Append(valor_entero(petiaipinssinrepupaglist.aipinssinrepu.ncantinssinrepu))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinrepupaglist.aipinssinrepu.iorigrepuinssinrepu <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iorigrepuinssinrepu='")
                    sb.Append(petiaipinssinrepupaglist.aipinssinrepu.iorigrepuinssinrepu)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iorigrepuinssinrepu='")
                        sb.Append(petiaipinssinrepupaglist.aipinssinrepu.iorigrepuinssinrepu)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssinrepupaglist.aipinssinrepu.nprecfininssinrepu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.nprecfininssinrepu=")
                    sb.Append(valor_entero(petiaipinssinrepupaglist.aipinssinrepu.nprecfininssinrepu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.nprecfininssinrepu=")
                        sb.Append(valor_entero(petiaipinssinrepupaglist.aipinssinrepu.nprecfininssinrepu))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinrepupaglist.aipinssinrepu.xdescinssinrepu <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdescinssinrepu='")
                    sb.Append(petiaipinssinrepupaglist.aipinssinrepu.xdescinssinrepu)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdescinssinrepu='")
                        sb.Append(petiaipinssinrepupaglist.aipinssinrepu.xdescinssinrepu)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssinrepupaglist.aipinssinrepu.iestatinssinrepu <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestatinssinrepu='")
                    sb.Append(petiaipinssinrepupaglist.aipinssinrepu.iestatinssinrepu)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatinssinrepu='")
                        sb.Append(petiaipinssinrepupaglist.aipinssinrepu.iestatinssinrepu)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssinrepupaglist.aipinssinrepu.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petiaipinssinrepupaglist.aipinssinrepu.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petiaipinssinrepupaglist.aipinssinrepu.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respaipinssinrepupaglist As New respaipinssinrepupaglist
            respaipinssinrepupaglist.pagaipinssinrepu = petiaipinssinrepupaglist.pagaipinssinrepu
            Dim skip = skip_paginacion(petiaipinssinrepupaglist.pagaipinssinrepu.npagactual, petiaipinssinrepupaglist.pagaipinssinrepu.npagtamano)

            If sb.ToString = "" Then
                respaipinssinrepupaglist.lista_aipinssinrepu = _db.aipinssinrepu.OrderBy(petiaipinssinrepupaglist.pagaipinssinrepu.xcamposord & " " & petiaipinssinrepupaglist.pagaipinssinrepu.idirord).Skip(skip).Take(petiaipinssinrepupaglist.pagaipinssinrepu.npagtamano).ToList
            Else
                respaipinssinrepupaglist.lista_aipinssinrepu = _db.aipinssinrepu.Where(sb.ToString).OrderBy(petiaipinssinrepupaglist.pagaipinssinrepu.xcamposord & " " & petiaipinssinrepupaglist.pagaipinssinrepu.idirord).Skip(skip).Take(petiaipinssinrepupaglist.pagaipinssinrepu.npagtamano).ToList
            End If
            '
            If (respaipinssinrepupaglist.lista_aipinssinrepu.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selaipinssinrepuxwheredinamicocount(sb)
                respaipinssinrepupaglist.pagaipinssinrepu.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinssinrepupaglist.pagaipinssinrepu.npagtamano)
            Else
                respaipinssinrepupaglist.pagaipinssinrepu.npagcantidad = 0
                respaipinssinrepupaglist.pagaipinssinrepu.npagactual = 0
            End If

            Return respaipinssinrepupaglist
        End Function

        Public Function selaipinssinrepuxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.aipinssinrepu.Count
            Else
                Return _db.aipinssinrepu.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
        Public Function insaipinssinrepu(aipinssinrepu As aipinssinrepu) As respopera
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
                    param8.ParameterName = "p_idaipinssinrepu"
                    param8.Direction = ParameterDirection.Output

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssinrepu.idaipinssin
                    param9.ParameterName = "p_idaipinssin"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssinrepu.idaipmanrepu
                    param10.ParameterName = "p_idaipmanrepu"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.SmallInt
                    param11.Value = aipinssinrepu.ncantinssinrepu
                    param11.ParameterName = "p_ncantinssinrepu"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    If aipinssinrepu.iorigrepuinssinrepu IsNot Nothing Then
                        param12.Value = aipinssinrepu.iorigrepuinssinrepu
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_iorigrepuinssinrepu"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Decimal
                    param13.Precision = 18
                    param13.Scale = 2
                    param13.Value = aipinssinrepu.nprecfininssinrepu
                    param13.ParameterName = "p_nprecfininssinrepu"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 500
                    If aipinssinrepu.xdescinssinrepu IsNot Nothing Then
                        param14.Value = aipinssinrepu.xdescinssinrepu
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_xdescinssinrepu"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 20
                    If aipinssinrepu.iestatinssinrepu IsNot Nothing Then
                        param15.Value = aipinssinrepu.iestatinssinrepu
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_iestatinssinrepu"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Decimal
                    param16.Precision = 18
                    param16.Scale = 0
                    param16.Value = 0
                    param16.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssinrepu output,@p_idaipinssin,@p_idaipmanrepu,@p_ncantinssinrepu,@p_iorigrepuinssinrepu,@p_nprecfininssinrepu,@p_xdescinssinrepu,@p_iestatinssinrepu,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = insaipinssinrepuoracle(aipinssinrepu)
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
        Public Function insaipinssinrepuoracle(aipinssinrepu As aipinssinrepu) As respopera
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
                param3.Value = "aipauto"
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
                param8.ParameterName = "p_idaipinssinrepu"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssinrepu.idaipinssin
                param9.ParameterName = "p_idaipinssin"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssinrepu.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = aipinssinrepu.ncantinssinrepu
                param11.ParameterName = "p_ncantinssinrepu"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 20
                If aipinssinrepu.iorigrepuinssinrepu IsNot Nothing And aipinssinrepu.iorigrepuinssinrepu <> "" Then
                    param12.Value = aipinssinrepu.iorigrepuinssinrepu
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_iorigrepuinssinrepu"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Decimal
                param13.Precision = 18
                param13.Scale = 2
                param13.Value = aipinssinrepu.nprecfininssinrepu
                param13.ParameterName = "p_nprecfininssinrepu"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Varchar2
                param14.Size = 500
                If aipinssinrepu.xdescinssinrepu IsNot Nothing And aipinssinrepu.xdescinssinrepu <> "" Then
                    param14.Value = aipinssinrepu.xdescinssinrepu
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_xdescinssinrepu"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 20
                If aipinssinrepu.iestatinssinrepu IsNot Nothing And aipinssinrepu.iestatinssinrepu <> "" Then
                    param15.Value = aipinssinrepu.iestatinssinrepu
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_iestatinssinrepu"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = 0
                param16.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssinrepu FLOAT; v_p_idaipinssin FLOAT; v_p_idaipmanrepu FLOAT; v_p_ncantinssinrepu number; v_p_iorigrepuinssinrepu VARCHAR2(20); v_p_nprecfininssinrepu number; v_p_xdescinssinrepu VARCHAR2(500); v_p_iestatinssinrepu VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssinrepu(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssinrepu,:v_p_idaipinssin,:v_p_idaipmanrepu,:v_p_ncantinssinrepu,:v_p_iorigrepuinssinrepu,:v_p_nprecfininssinrepu,:v_p_xdescinssinrepu,:v_p_iestatinssinrepu,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16)

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
        Public Function modaipinssinrepu(aipinssinrepu As aipinssinrepu) As respopera
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
                    param8.Value = aipinssinrepu.idaipinssinrepu
                    param8.ParameterName = "p_idaipinssinrepu"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssinrepu.idaipinssin
                    param9.ParameterName = "p_idaipinssin"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssinrepu.idaipmanrepu
                    param10.ParameterName = "p_idaipmanrepu"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.SmallInt
                    param11.Value = aipinssinrepu.ncantinssinrepu
                    param11.ParameterName = "p_ncantinssinrepu"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    If aipinssinrepu.iorigrepuinssinrepu IsNot Nothing Then
                        param12.Value = aipinssinrepu.iorigrepuinssinrepu
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_iorigrepuinssinrepu"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Decimal
                    param13.Precision = 18
                    param13.Scale = 2
                    param13.Value = aipinssinrepu.nprecfininssinrepu
                    param13.ParameterName = "p_nprecfininssinrepu"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 500
                    If aipinssinrepu.xdescinssinrepu IsNot Nothing Then
                        param14.Value = aipinssinrepu.xdescinssinrepu
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_xdescinssinrepu"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 20
                    If aipinssinrepu.iestatinssinrepu IsNot Nothing Then
                        param15.Value = aipinssinrepu.iestatinssinrepu
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_iestatinssinrepu"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Decimal
                    param16.Precision = 18
                    param16.Scale = 0
                    param16.Value = aipinssinrepu.idseglogreg
                    param16.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssinrepu output,@p_idaipinssin,@p_idaipmanrepu,@p_ncantinssinrepu,@p_iorigrepuinssinrepu,@p_nprecfininssinrepu,@p_xdescinssinrepu,@p_iestatinssinrepu,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = modaipinssinrepuoracle(aipinssinrepu)
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
        Public Function modaipinssinrepuoracle(aipinssinrepu As aipinssinrepu) As respopera
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
                param3.Value = "aipauto"
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
                param8.Value = aipinssinrepu.idaipinssinrepu
                param8.ParameterName = "p_idaipinssinrepu"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssinrepu.idaipinssin
                param9.ParameterName = "p_idaipinssin"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssinrepu.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = aipinssinrepu.ncantinssinrepu
                param11.ParameterName = "p_ncantinssinrepu"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 20
                If aipinssinrepu.iorigrepuinssinrepu IsNot Nothing And aipinssinrepu.iorigrepuinssinrepu <> "" Then
                    param12.Value = aipinssinrepu.iorigrepuinssinrepu
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_iorigrepuinssinrepu"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Decimal
                param13.Precision = 18
                param13.Scale = 2
                param13.Value = aipinssinrepu.nprecfininssinrepu
                param13.ParameterName = "p_nprecfininssinrepu"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Varchar2
                param14.Size = 500
                If aipinssinrepu.xdescinssinrepu IsNot Nothing And aipinssinrepu.xdescinssinrepu <> "" Then
                    param14.Value = aipinssinrepu.xdescinssinrepu
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_xdescinssinrepu"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 20
                If aipinssinrepu.iestatinssinrepu IsNot Nothing And aipinssinrepu.iestatinssinrepu <> "" Then
                    param15.Value = aipinssinrepu.iestatinssinrepu
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_iestatinssinrepu"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = aipinssinrepu.idseglogreg
                param16.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssinrepu FLOAT; v_p_idaipinssin FLOAT; v_p_idaipmanrepu FLOAT; v_p_ncantinssinrepu number; v_p_iorigrepuinssinrepu VARCHAR2(20); v_p_nprecfininssinrepu number; v_p_xdescinssinrepu VARCHAR2(500); v_p_iestatinssinrepu VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssinrepu(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssinrepu,:v_p_idaipinssin,:v_p_idaipmanrepu,:v_p_ncantinssinrepu,:v_p_iorigrepuinssinrepu,:v_p_nprecfininssinrepu,:v_p_xdescinssinrepu,:v_p_iestatinssinrepu,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16)

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
        Public Function eliaipinssinrepu(aipinssinrepu As aipinssinrepu) As respopera
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
                    param8.Value = aipinssinrepu.idaipinssinrepu
                    param8.ParameterName = "p_idaipinssinrepu"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssinrepu.idaipinssin
                    param9.ParameterName = "p_idaipinssin"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssinrepu.idaipmanrepu
                    param10.ParameterName = "p_idaipmanrepu"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.SmallInt
                    param11.Value = aipinssinrepu.ncantinssinrepu
                    param11.ParameterName = "p_ncantinssinrepu"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    If aipinssinrepu.iorigrepuinssinrepu IsNot Nothing Then
                        param12.Value = aipinssinrepu.iorigrepuinssinrepu
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_iorigrepuinssinrepu"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Decimal
                    param13.Precision = 18
                    param13.Scale = 2
                    param13.Value = aipinssinrepu.nprecfininssinrepu
                    param13.ParameterName = "p_nprecfininssinrepu"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 500
                    If aipinssinrepu.xdescinssinrepu IsNot Nothing Then
                        param14.Value = aipinssinrepu.xdescinssinrepu
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_xdescinssinrepu"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 20
                    If aipinssinrepu.iestatinssinrepu IsNot Nothing Then
                        param15.Value = aipinssinrepu.iestatinssinrepu
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_iestatinssinrepu"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Decimal
                    param16.Precision = 18
                    param16.Scale = 0
                    param16.Value = aipinssinrepu.idseglogreg
                    param16.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssinrepu output,@p_idaipinssin,@p_idaipmanrepu,@p_ncantinssinrepu,@p_iorigrepuinssinrepu,@p_nprecfininssinrepu,@p_xdescinssinrepu,@p_iestatinssinrepu,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipinssinrepuoracle(aipinssinrepu)
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
        Public Function eliaipinssinrepuoracle(aipinssinrepu As aipinssinrepu) As respopera
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
                param3.Value = "aipauto"
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
                param8.Value = aipinssinrepu.idaipinssinrepu
                param8.ParameterName = "p_idaipinssinrepu"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssinrepu.idaipinssin
                param9.ParameterName = "p_idaipinssin"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssinrepu.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = aipinssinrepu.ncantinssinrepu
                param11.ParameterName = "p_ncantinssinrepu"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 20
                If aipinssinrepu.iorigrepuinssinrepu IsNot Nothing And aipinssinrepu.iorigrepuinssinrepu <> "" Then
                    param12.Value = aipinssinrepu.iorigrepuinssinrepu
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_iorigrepuinssinrepu"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Decimal
                param13.Precision = 18
                param13.Scale = 2
                param13.Value = aipinssinrepu.nprecfininssinrepu
                param13.ParameterName = "p_nprecfininssinrepu"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Varchar2
                param14.Size = 500
                If aipinssinrepu.xdescinssinrepu IsNot Nothing And aipinssinrepu.xdescinssinrepu <> "" Then
                    param14.Value = aipinssinrepu.xdescinssinrepu
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_xdescinssinrepu"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 20
                If aipinssinrepu.iestatinssinrepu IsNot Nothing And aipinssinrepu.iestatinssinrepu <> "" Then
                    param15.Value = aipinssinrepu.iestatinssinrepu
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_iestatinssinrepu"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = aipinssinrepu.idseglogreg
                param16.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssinrepu FLOAT; v_p_idaipinssin FLOAT; v_p_idaipmanrepu FLOAT; v_p_ncantinssinrepu number; v_p_iorigrepuinssinrepu VARCHAR2(20); v_p_nprecfininssinrepu number; v_p_xdescinssinrepu VARCHAR2(500); v_p_iestatinssinrepu VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssinrepu(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssinrepu,:v_p_idaipinssin,:v_p_idaipmanrepu,:v_p_ncantinssinrepu,:v_p_iorigrepuinssinrepu,:v_p_nprecfininssinrepu,:v_p_xdescinssinrepu,:v_p_iestatinssinrepu,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16)

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
        Public Function eliaipinssinrepu(idaipinssinrepu As Decimal) As respopera
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
                    param8.Value = idaipinssinrepu
                    param8.ParameterName = "p_idaipinssinrepu"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = 0
                    param9.ParameterName = "p_idaipinssin"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = 0
                    param10.ParameterName = "p_idaipmanrepu"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.SmallInt
                    param11.Value = 0
                    param11.ParameterName = "p_ncantinssinrepu"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    param12.Value = ""
                    param12.ParameterName = "p_iorigrepuinssinrepu"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Decimal
                    param13.Precision = 18
                    param13.Scale = 2
                    param13.Value = 0
                    param13.ParameterName = "p_nprecfininssinrepu"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 500
                    param14.Value = ""
                    param14.ParameterName = "p_xdescinssinrepu"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 20
                    param15.Value = ""
                    param15.ParameterName = "p_iestatinssinrepu"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Decimal
                    param16.Precision = 18
                    param16.Scale = 0
                    param16.Value = 0
                    param16.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssinrepu output,@p_idaipinssin,@p_idaipmanrepu,@p_ncantinssinrepu,@p_iorigrepuinssinrepu,@p_nprecfininssinrepu,@p_xdescinssinrepu,@p_iestatinssinrepu,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipinssinrepuoracle(idaipinssinrepu)
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
        Public Function eliaipinssinrepuoracle(idaipinssinrepu As Decimal) As respopera
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
                param3.Value = "aipauto"
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
                param8.Value = idaipinssinrepu
                param8.ParameterName = "p_idaipinssinrepu"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = 0
                param9.ParameterName = "p_idaipinssin"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = 0
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = 0
                param11.ParameterName = "p_ncantinssinrepu"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 20
                param12.Value = " "
                param12.ParameterName = "p_iorigrepuinssinrepu"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Decimal
                param13.Precision = 18
                param13.Scale = 2
                param13.Value = 0
                param13.ParameterName = "p_nprecfininssinrepu"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Varchar2
                param14.Size = 500
                param14.Value = " "
                param14.ParameterName = "p_xdescinssinrepu"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 20
                param15.Value = " "
                param15.ParameterName = "p_iestatinssinrepu"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = 0
                param16.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssinrepu FLOAT; v_p_idaipinssin FLOAT; v_p_idaipmanrepu FLOAT; v_p_ncantinssinrepu number; v_p_iorigrepuinssinrepu VARCHAR2(20); v_p_nprecfininssinrepu number; v_p_xdescinssinrepu VARCHAR2(500); v_p_iestatinssinrepu VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssinrepu(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssinrepu,:v_p_idaipinssin,:v_p_idaipmanrepu,:v_p_ncantinssinrepu,:v_p_iorigrepuinssinrepu,:v_p_nprecfininssinrepu,:v_p_xdescinssinrepu,:v_p_iestatinssinrepu,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16)

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
        Public Function actaipinssinrepu(aipinssinrepu As aipinssinrepu) As respopera
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
                param8.Value = aipinssinrepu.idaipinssinrepu
                param8.ParameterName = "p_idaipinssinrepu"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssinrepu.idaipinssin
                param9.ParameterName = "p_idaipinssin"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssinrepu.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.SmallInt
                param11.Value = aipinssinrepu.ncantinssinrepu
                param11.ParameterName = "p_ncantinssinrepu"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                If aipinssinrepu.iorigrepuinssinrepu IsNot Nothing Then
                    param12.Value = aipinssinrepu.iorigrepuinssinrepu
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_iorigrepuinssinrepu"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.Decimal
                param13.Precision = 18
                param13.Scale = 2
                param13.Value = aipinssinrepu.nprecfininssinrepu
                param13.ParameterName = "p_nprecfininssinrepu"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = 500
                If aipinssinrepu.xdescinssinrepu IsNot Nothing Then
                    param14.Value = aipinssinrepu.xdescinssinrepu
                Else
                    param14.Value = ""
                End If
                param14.ParameterName = "p_xdescinssinrepu"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 20
                If aipinssinrepu.iestatinssinrepu IsNot Nothing Then
                    param15.Value = aipinssinrepu.iestatinssinrepu
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_iestatinssinrepu"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.Decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = aipinssinrepu.idseglogreg
                param16.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssinrepu output,@p_idaipinssin,@p_idaipmanrepu,@p_ncantinssinrepu,@p_iorigrepuinssinrepu,@p_nprecfininssinrepu,@p_xdescinssinrepu,@p_iestatinssinrepu,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16)

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
        Public Function desaipinssinrepu(aipinssinrepu As aipinssinrepu) As respopera
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
                param8.Value = aipinssinrepu.idaipinssinrepu
                param8.ParameterName = "p_idaipinssinrepu"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssinrepu.idaipinssin
                param9.ParameterName = "p_idaipinssin"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssinrepu.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.SmallInt
                param11.Value = aipinssinrepu.ncantinssinrepu
                param11.ParameterName = "p_ncantinssinrepu"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                If aipinssinrepu.iorigrepuinssinrepu IsNot Nothing Then
                    param12.Value = aipinssinrepu.iorigrepuinssinrepu
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_iorigrepuinssinrepu"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.Decimal
                param13.Precision = 18
                param13.Scale = 2
                param13.Value = aipinssinrepu.nprecfininssinrepu
                param13.ParameterName = "p_nprecfininssinrepu"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = 500
                If aipinssinrepu.xdescinssinrepu IsNot Nothing Then
                    param14.Value = aipinssinrepu.xdescinssinrepu
                Else
                    param14.Value = ""
                End If
                param14.ParameterName = "p_xdescinssinrepu"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 20
                If aipinssinrepu.iestatinssinrepu IsNot Nothing Then
                    param15.Value = aipinssinrepu.iestatinssinrepu
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_iestatinssinrepu"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.Decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = aipinssinrepu.idseglogreg
                param16.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssinrepu output,@p_idaipinssin,@p_idaipmanrepu,@p_ncantinssinrepu,@p_iorigrepuinssinrepu,@p_nprecfininssinrepu,@p_xdescinssinrepu,@p_iestatinssinrepu,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16)

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
