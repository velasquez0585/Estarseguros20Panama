Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports Oracle.ManagedDataAccess
Namespace aipauto.entidades.controlador
    Public Class aipinssusaccController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selaipinssusaccxid(idaipinssusacc As Decimal) As aipinssusacc
            Dim aipinssusacc As aipinssusacc = (From p In _db.aipinssusacc
                                            Where p.idaipinssusacc = idaipinssusacc
                                            Select p).SingleOrDefault
            Return aipinssusacc
        End Function

        <HttpPost()> _
        Public Function selaipinssusacc() As List(Of aipinssusacc)
            Dim lista_aipinssusacc As List(Of aipinssusacc) = (From p In _db.aipinssusacc
                                                        Select p).ToList
            '
            Return lista_aipinssusacc
        End Function


        <HttpPost()> _
        Public Function selaipinssusaccxwheredinamicopag(petiaipinssusaccpaglist As petiaipinssusaccpaglist) As respaipinssusaccpaglist
            Dim sb As New StringBuilder("")
            '
            If petiaipinssusaccpaglist.aipinssusacc.idaipinssusacc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssusacc=")
                    sb.Append(valor_entero(petiaipinssusaccpaglist.aipinssusacc.idaipinssusacc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssusacc=")
                        sb.Append(valor_entero(petiaipinssusaccpaglist.aipinssusacc.idaipinssusacc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusaccpaglist.aipinssusacc.idaipinssus <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssus=")
                    sb.Append(valor_entero(petiaipinssusaccpaglist.aipinssusacc.idaipinssus))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssus=")
                        sb.Append(valor_entero(petiaipinssusaccpaglist.aipinssusacc.idaipinssus))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusaccpaglist.aipinssusacc.idaipmanvehacc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipmanvehacc=")
                    sb.Append(valor_entero(petiaipinssusaccpaglist.aipinssusacc.idaipmanvehacc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipmanvehacc=")
                        sb.Append(valor_entero(petiaipinssusaccpaglist.aipinssusacc.idaipmanvehacc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusaccpaglist.aipinssusacc.ioriginssusacc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.ioriginssusacc=")
                    sb.Append(valor_entero(petiaipinssusaccpaglist.aipinssusacc.ioriginssusacc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ioriginssusacc=")
                        sb.Append(valor_entero(petiaipinssusaccpaglist.aipinssusacc.ioriginssusacc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusaccpaglist.aipinssusacc.inoexistinssusacc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.inoexistinssusacc=")
                    sb.Append(valor_entero(petiaipinssusaccpaglist.aipinssusacc.inoexistinssusacc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.inoexistinssusacc=")
                        sb.Append(valor_entero(petiaipinssusaccpaglist.aipinssusacc.inoexistinssusacc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusaccpaglist.aipinssusacc.inooriginssusacc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.inooriginssusacc=")
                    sb.Append(valor_entero(petiaipinssusaccpaglist.aipinssusacc.inooriginssusacc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.inooriginssusacc=")
                        sb.Append(valor_entero(petiaipinssusaccpaglist.aipinssusacc.inooriginssusacc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusaccpaglist.aipinssusacc.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petiaipinssusaccpaglist.aipinssusacc.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petiaipinssusaccpaglist.aipinssusacc.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respaipinssusaccpaglist As New respaipinssusaccpaglist
            respaipinssusaccpaglist.pagaipinssusacc = petiaipinssusaccpaglist.pagaipinssusacc
            Dim skip = skip_paginacion(petiaipinssusaccpaglist.pagaipinssusacc.npagactual, petiaipinssusaccpaglist.pagaipinssusacc.npagtamano)

            If sb.ToString = "" Then
                respaipinssusaccpaglist.lista_aipinssusacc = _db.aipinssusacc.OrderBy(petiaipinssusaccpaglist.pagaipinssusacc.xcamposord & " " & petiaipinssusaccpaglist.pagaipinssusacc.idirord).Skip(skip).Take(petiaipinssusaccpaglist.pagaipinssusacc.npagtamano).ToList
            Else
                respaipinssusaccpaglist.lista_aipinssusacc = _db.aipinssusacc.Where(sb.ToString).OrderBy(petiaipinssusaccpaglist.pagaipinssusacc.xcamposord & " " & petiaipinssusaccpaglist.pagaipinssusacc.idirord).Skip(skip).Take(petiaipinssusaccpaglist.pagaipinssusacc.npagtamano).ToList
            End If
            '
            If (respaipinssusaccpaglist.lista_aipinssusacc.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selaipinssusaccxwheredinamicocount(sb)
                respaipinssusaccpaglist.pagaipinssusacc.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinssusaccpaglist.pagaipinssusacc.npagtamano)
            Else
                respaipinssusaccpaglist.pagaipinssusacc.npagcantidad = 0
                respaipinssusaccpaglist.pagaipinssusacc.npagactual = 0
            End If

            Return respaipinssusaccpaglist
        End Function

        Public Function selaipinssusaccxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.aipinssusacc.Count
            Else
                Return _db.aipinssusacc.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
        Public Function insaipinssusacc(aipinssusacc As aipinssusacc) As respopera
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
                    param8.ParameterName = "p_idaipinssusacc"
                    param8.Direction = ParameterDirection.Output

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssusacc.idaipinssus
                    param9.ParameterName = "p_idaipinssus"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssusacc.idaipmanvehacc
                    param10.ParameterName = "p_idaipmanvehacc"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Bit
                    param11.Value = aipinssusacc.ioriginssusacc
                    param11.ParameterName = "p_ioriginssusacc"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Bit
                    param12.Value = aipinssusacc.inoexistinssusacc
                    param12.ParameterName = "p_inoexistinssusacc"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Bit
                    param13.Value = aipinssusacc.inooriginssusacc
                    param13.ParameterName = "p_inooriginssusacc"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Decimal
                    param14.Precision = 18
                    param14.Scale = 0
                    param14.Value = 0
                    param14.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusacc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusacc output,@p_idaipinssus,@p_idaipmanvehacc,@p_ioriginssusacc,@p_inoexistinssusacc,@p_inooriginssusacc,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else

                    respopera = insaipinssusaccoracle(aipinssusacc)

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
        Public Function insaipinssusaccoracle(aipinssusacc As aipinssusacc) As respopera
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
                param8.ParameterName = "p_idaipinssusacc"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssusacc.idaipinssus
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssusacc.idaipmanvehacc
                param10.ParameterName = "p_idaipmanvehacc"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = aipinssusacc.ioriginssusacc
                param11.ParameterName = "p_ioriginssusacc"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Int16
                param12.Value = aipinssusacc.inoexistinssusacc
                param12.ParameterName = "p_inoexistinssusacc"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Int16
                param13.Value = aipinssusacc.inooriginssusacc
                param13.ParameterName = "p_inooriginssusacc"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = 0
                param14.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssusacc FLOAT; v_p_idaipinssus FLOAT; v_p_idaipmanvehacc FLOAT; v_p_ioriginssusacc number; v_p_inoexistinssusacc number; v_p_inooriginssusacc number; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssusacc(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssusacc,:v_p_idaipinssus,:v_p_idaipmanvehacc,:v_p_ioriginssusacc,:v_p_inoexistinssusacc,:v_p_inooriginssusacc,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14)

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
        Public Function modaipinssusacc(aipinssusacc As aipinssusacc) As respopera
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
                    param8.Value = aipinssusacc.idaipinssusacc
                    param8.ParameterName = "p_idaipinssusacc"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssusacc.idaipinssus
                    param9.ParameterName = "p_idaipinssus"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssusacc.idaipmanvehacc
                    param10.ParameterName = "p_idaipmanvehacc"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Bit
                    param11.Value = aipinssusacc.ioriginssusacc
                    param11.ParameterName = "p_ioriginssusacc"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Bit
                    param12.Value = aipinssusacc.inoexistinssusacc
                    param12.ParameterName = "p_inoexistinssusacc"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Bit
                    param13.Value = aipinssusacc.inooriginssusacc
                    param13.ParameterName = "p_inooriginssusacc"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Decimal
                    param14.Precision = 18
                    param14.Scale = 0
                    param14.Value = aipinssusacc.idseglogreg
                    param14.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusacc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusacc output,@p_idaipinssus,@p_idaipmanvehacc,@p_ioriginssusacc,@p_inoexistinssusacc,@p_inooriginssusacc,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If

                Else
                    respopera = modaipinssusaccoracle(aipinssusacc)
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
        Public Function modaipinssusaccoracle(aipinssusacc As aipinssusacc) As respopera
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
                param8.Value = aipinssusacc.idaipinssusacc
                param8.ParameterName = "p_idaipinssusacc"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssusacc.idaipinssus
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssusacc.idaipmanvehacc
                param10.ParameterName = "p_idaipmanvehacc"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = aipinssusacc.ioriginssusacc
                param11.ParameterName = "p_ioriginssusacc"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Int16
                param12.Value = aipinssusacc.inoexistinssusacc
                param12.ParameterName = "p_inoexistinssusacc"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Int16
                param13.Value = aipinssusacc.inooriginssusacc
                param13.ParameterName = "p_inooriginssusacc"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = aipinssusacc.idseglogreg
                param14.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssusacc FLOAT; v_p_idaipinssus FLOAT; v_p_idaipmanvehacc FLOAT; v_p_ioriginssusacc number; v_p_inoexistinssusacc number; v_p_inooriginssusacc number; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssusacc(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssusacc,:v_p_idaipinssus,:v_p_idaipmanvehacc,:v_p_ioriginssusacc,:v_p_inoexistinssusacc,:v_p_inooriginssusacc,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14)

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
        Public Function eliaipinssusacc(aipinssusacc As aipinssusacc) As respopera
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
                    param8.Value = aipinssusacc.idaipinssusacc
                    param8.ParameterName = "p_idaipinssusacc"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssusacc.idaipinssus
                    param9.ParameterName = "p_idaipinssus"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssusacc.idaipmanvehacc
                    param10.ParameterName = "p_idaipmanvehacc"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Bit
                    param11.Value = aipinssusacc.ioriginssusacc
                    param11.ParameterName = "p_ioriginssusacc"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Bit
                    param12.Value = aipinssusacc.inoexistinssusacc
                    param12.ParameterName = "p_inoexistinssusacc"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Bit
                    param13.Value = aipinssusacc.inooriginssusacc
                    param13.ParameterName = "p_inooriginssusacc"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Decimal
                    param14.Precision = 18
                    param14.Scale = 0
                    param14.Value = aipinssusacc.idseglogreg
                    param14.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusacc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusacc output,@p_idaipinssus,@p_idaipmanvehacc,@p_ioriginssusacc,@p_inoexistinssusacc,@p_inooriginssusacc,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If

                Else
                    respopera = eliaipinssusaccoracle(aipinssusacc)
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
        Public Function eliaipinssusaccoracle(aipinssusacc As aipinssusacc) As respopera
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
                param8.Value = aipinssusacc.idaipinssusacc
                param8.ParameterName = "p_idaipinssusacc"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssusacc.idaipinssus
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssusacc.idaipmanvehacc
                param10.ParameterName = "p_idaipmanvehacc"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = aipinssusacc.ioriginssusacc
                param11.ParameterName = "p_ioriginssusacc"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Int16
                param12.Value = aipinssusacc.inoexistinssusacc
                param12.ParameterName = "p_inoexistinssusacc"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Int16
                param13.Value = aipinssusacc.inooriginssusacc
                param13.ParameterName = "p_inooriginssusacc"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = aipinssusacc.idseglogreg
                param14.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssusacc FLOAT; v_p_idaipinssus FLOAT; v_p_idaipmanvehacc FLOAT; v_p_ioriginssusacc number; v_p_inoexistinssusacc number; v_p_inooriginssusacc number; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssusacc(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssusacc,:v_p_idaipinssus,:v_p_idaipmanvehacc,:v_p_ioriginssusacc,:v_p_inoexistinssusacc,:v_p_inooriginssusacc,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14)

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
        Public Function eliaipinssusacc(idaipinssusacc As Decimal) As respopera
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
                    param8.Value = idaipinssusacc
                    param8.ParameterName = "p_idaipinssusacc"
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
                    param10.ParameterName = "p_idaipmanvehacc"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Bit
                    param11.Value = 0
                    param11.ParameterName = "p_ioriginssusacc"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Bit
                    param12.Value = 0
                    param12.ParameterName = "p_inoexistinssusacc"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Bit
                    param13.Value = 0
                    param13.ParameterName = "p_inooriginssusacc"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Decimal
                    param14.Precision = 18
                    param14.Scale = 0
                    param14.Value = 0
                    param14.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusacc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusacc output,@p_idaipinssus,@p_idaipmanvehacc,@p_ioriginssusacc,@p_inoexistinssusacc,@p_inooriginssusacc,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipinssusaccoracle(idaipinssusacc)
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
        Public Function eliaipinssusaccoracle(idaipinssusacc As Decimal) As respopera
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
                param8.Value = idaipinssusacc
                param8.ParameterName = "p_idaipinssusacc"
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
                param10.ParameterName = "p_idaipmanvehacc"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = 0
                param11.ParameterName = "p_ioriginssusacc"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Int16
                param12.Value = 0
                param12.ParameterName = "p_inoexistinssusacc"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Int16
                param13.Value = 0
                param13.ParameterName = "p_inooriginssusacc"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = 0
                param14.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssusacc FLOAT; v_p_idaipinssus FLOAT; v_p_idaipmanvehacc FLOAT; v_p_ioriginssusacc number; v_p_inoexistinssusacc number; v_p_inooriginssusacc number; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssusacc(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssusacc,:v_p_idaipinssus,:v_p_idaipmanvehacc,:v_p_ioriginssusacc,:v_p_inoexistinssusacc,:v_p_inooriginssusacc,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14)

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
        Public Function actaipinssusacc(aipinssusacc As aipinssusacc) As respopera
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
                param8.Value = aipinssusacc.idaipinssusacc
                param8.ParameterName = "p_idaipinssusacc"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssusacc.idaipinssus
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssusacc.idaipmanvehacc
                param10.ParameterName = "p_idaipmanvehacc"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.Bit
                param11.Value = aipinssusacc.ioriginssusacc
                param11.ParameterName = "p_ioriginssusacc"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.Bit
                param12.Value = aipinssusacc.inoexistinssusacc
                param12.ParameterName = "p_inoexistinssusacc"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.Bit
                param13.Value = aipinssusacc.inooriginssusacc
                param13.ParameterName = "p_inooriginssusacc"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = aipinssusacc.idseglogreg
                param14.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusacc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusacc output,@p_idaipinssus,@p_idaipmanvehacc,@p_ioriginssusacc,@p_inoexistinssusacc,@p_inooriginssusacc,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14)

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
        Public Function desaipinssusacc(aipinssusacc As aipinssusacc) As respopera
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
                param8.Value = aipinssusacc.idaipinssusacc
                param8.ParameterName = "p_idaipinssusacc"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssusacc.idaipinssus
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssusacc.idaipmanvehacc
                param10.ParameterName = "p_idaipmanvehacc"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.Bit
                param11.Value = aipinssusacc.ioriginssusacc
                param11.ParameterName = "p_ioriginssusacc"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.Bit
                param12.Value = aipinssusacc.inoexistinssusacc
                param12.ParameterName = "p_inoexistinssusacc"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.Bit
                param13.Value = aipinssusacc.inooriginssusacc
                param13.ParameterName = "p_inooriginssusacc"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = aipinssusacc.idseglogreg
                param14.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusacc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusacc output,@p_idaipinssus,@p_idaipmanvehacc,@p_ioriginssusacc,@p_inoexistinssusacc,@p_inooriginssusacc,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14)

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
        Public Function selaipinssusaccxidaipinssus(idaipinssus As Decimal) As List(Of aipinssusacc)
            Dim lista_aipinssusacc As List(Of aipinssusacc) = (From p In _db.aipinssusacc
                                            Where p.idaipinssus = idaipinssus
                                            Select p).ToList
            Return lista_aipinssusacc
        End Function

    End Class
End Namespace
