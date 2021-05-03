Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports Oracle.ManagedDataAccess
Namespace aipauto.entidades.controlador
    Public Class aipinssinController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selaipinssinxid(idaipinssin As Decimal) As aipinssin
            Dim aipinssin As aipinssin = (From p In _db.aipinssin
                                            Where p.idaipinssin = idaipinssin
                                            Select p).SingleOrDefault
            Return aipinssin
        End Function

        <HttpPost()> _
        Public Function selaipinssin() As List(Of aipinssin)
            Dim lista_aipinssin As List(Of aipinssin) = (From p In _db.aipinssin
                                                        Select p).ToList
            '
            Return lista_aipinssin
        End Function

        <HttpPost()> _
           Public Function selaipinssinxwheredinamicopag(petiaipinssinpaglist As petiaipinssinpaglist) As respaipinssinpaglist
            Dim sb As New StringBuilder("")
            '
            If petiaipinssinpaglist.aipinssin.idaipinssin <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssin=")
                    sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.idaipinssin))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssin=")
                        sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.idaipinssin))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinpaglist.aipinssin.idaipinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsenc=")
                    sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.idaipinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsenc=")
                        sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.idaipinsenc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinpaglist.aipinssin.nfactinssin <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.nfactinssin=")
                    sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.nfactinssin))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.nfactinssin=")
                        sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.nfactinssin))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinpaglist.aipinssin.irepuinssin <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.irepuinssin=")
                    sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.irepuinssin))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.irepuinssin=")
                        sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.irepuinssin))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinpaglist.aipinssin.imobrinssin <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.imobrinssin=")
                    sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.imobrinssin))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.imobrinssin=")
                        sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.imobrinssin))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinpaglist.aipinssin.xnomaseginssin <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnomaseginssin='")
                    sb.Append(petiaipinssinpaglist.aipinssin.xnomaseginssin)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnomaseginssin='")
                        sb.Append(petiaipinssinpaglist.aipinssin.xnomaseginssin)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssinpaglist.aipinssin.idaipmanveh <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipmanveh=")
                    sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.idaipmanveh))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipmanveh=")
                        sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.idaipmanveh))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinpaglist.aipinssin.xsucuinssin <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xsucuinssin='")
                    sb.Append(petiaipinssinpaglist.aipinssin.xsucuinssin)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xsucuinssin='")
                        sb.Append(petiaipinssinpaglist.aipinssin.xsucuinssin)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssinpaglist.aipinssin.nkiloinssin <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.nkiloinssin=")
                    sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.nkiloinssin))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.nkiloinssin=")
                        sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.nkiloinssin))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinpaglist.aipinssin.xdescinssin <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdescinssin='")
                    sb.Append(petiaipinssinpaglist.aipinssin.xdescinssin)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdescinssin='")
                        sb.Append(petiaipinssinpaglist.aipinssin.xdescinssin)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssinpaglist.aipinssin.iestatinssin <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestatinssin='")
                    sb.Append(petiaipinssinpaglist.aipinssin.iestatinssin)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatinssin='")
                        sb.Append(petiaipinssinpaglist.aipinssin.iestatinssin)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssinpaglist.aipinssin.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petiaipinssinpaglist.aipinssin.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respaipinssinpaglist As New respaipinssinpaglist
            respaipinssinpaglist.pagaipinssin = petiaipinssinpaglist.pagaipinssin
            Dim skip = skip_paginacion(petiaipinssinpaglist.pagaipinssin.npagactual, petiaipinssinpaglist.pagaipinssin.npagtamano)

            If sb.ToString = "" Then
                respaipinssinpaglist.lista_aipinssin = _db.aipinssin.OrderBy(petiaipinssinpaglist.pagaipinssin.xcamposord & " " & petiaipinssinpaglist.pagaipinssin.idirord).Skip(skip).Take(petiaipinssinpaglist.pagaipinssin.npagtamano).ToList
            Else
                respaipinssinpaglist.lista_aipinssin = _db.aipinssin.Where(sb.ToString).OrderBy(petiaipinssinpaglist.pagaipinssin.xcamposord & " " & petiaipinssinpaglist.pagaipinssin.idirord).Skip(skip).Take(petiaipinssinpaglist.pagaipinssin.npagtamano).ToList
            End If
            '
            If (respaipinssinpaglist.lista_aipinssin.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selaipinssinxwheredinamicocount(sb)
                respaipinssinpaglist.pagaipinssin.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinssinpaglist.pagaipinssin.npagtamano)
            Else
                respaipinssinpaglist.pagaipinssin.npagcantidad = 0
                respaipinssinpaglist.pagaipinssin.npagactual = 0
            End If

            Return respaipinssinpaglist
        End Function

        Public Function selaipinssinxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.aipinssin.Count
            Else
                Return _db.aipinssin.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
        Public Function insaipinssin(aipinssin As aipinssin) As respopera
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
                    param8.ParameterName = "p_idaipinssin"
                    param8.Direction = ParameterDirection.Output

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssin.idaipinsenc
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssin.nfactinssin
                    param10.ParameterName = "p_nfactinssin"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Bit
                    param11.Value = aipinssin.irepuinssin
                    param11.ParameterName = "p_irepuinssin"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Bit
                    param12.Value = aipinssin.imobrinssin
                    param12.ParameterName = "p_imobrinssin"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 100
                    If aipinssin.xnomaseginssin IsNot Nothing Then
                        param13.Value = aipinssin.xnomaseginssin
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_xnomaseginssin"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Decimal
                    param14.Precision = 18
                    param14.Scale = 0
                    param14.Value = aipinssin.idaipmanveh
                    param14.ParameterName = "p_idaipmanveh"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 100
                    If aipinssin.xsucuinssin IsNot Nothing Then
                        param15.Value = aipinssin.xsucuinssin
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xsucuinssin"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Int
                    param16.Value = aipinssin.nkiloinssin
                    param16.ParameterName = "p_nkiloinssin"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 500
                    If aipinssin.xdescinssin IsNot Nothing Then
                        param17.Value = aipinssin.xdescinssin
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xdescinssin"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 20
                    If aipinssin.iestatinssin IsNot Nothing Then
                        param18.Value = aipinssin.iestatinssin
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_iestatinssin"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.Decimal
                    param19.Precision = 18
                    param19.Scale = 0
                    param19.Value = 0
                    param19.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssin output,@p_idaipinsenc,@p_nfactinssin,@p_irepuinssin,@p_imobrinssin,@p_xnomaseginssin,@p_idaipmanveh,@p_xsucuinssin,@p_nkiloinssin,@p_xdescinssin,@p_iestatinssin,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = insaipinssinoracle(aipinssin)
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
        Public Function insaipinssinoracle(aipinssin As aipinssin) As respopera
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
                param8.ParameterName = "p_idaipinssin"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssin.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssin.nfactinssin
                param10.ParameterName = "p_nfactinssin"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = aipinssin.irepuinssin
                param11.ParameterName = "p_irepuinssin"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Int16
                param12.Value = aipinssin.imobrinssin
                param12.ParameterName = "p_imobrinssin"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Varchar2
                param13.Size = 100
                If aipinssin.xnomaseginssin IsNot Nothing And aipinssin.xnomaseginssin <> "" Then
                    param13.Value = aipinssin.xnomaseginssin
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_xnomaseginssin"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = aipinssin.idaipmanveh
                param14.ParameterName = "p_idaipmanveh"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 100
                If aipinssin.xsucuinssin IsNot Nothing And aipinssin.xsucuinssin <> "" Then
                    param15.Value = aipinssin.xsucuinssin
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xsucuinssin"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Int32
                param16.Value = aipinssin.nkiloinssin
                param16.ParameterName = "p_nkiloinssin"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Long                
                If aipinssin.xdescinssin IsNot Nothing And aipinssin.xdescinssin <> "" Then
                    param17.Value = aipinssin.xdescinssin
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xdescinssin"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 20
                If aipinssin.iestatinssin IsNot Nothing And aipinssin.iestatinssin <> "" Then
                    param18.Value = aipinssin.iestatinssin
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_iestatinssin"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = 0
                param19.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssin FLOAT; v_p_idaipinsenc FLOAT; v_p_nfactinssin FLOAT; v_p_irepuinssin number; v_p_imobrinssin number; v_p_xnomaseginssin VARCHAR2(100); v_p_idaipmanveh FLOAT; v_p_xsucuinssin VARCHAR2(100); v_p_nkiloinssin number; v_p_xdescinssin LONG; v_p_iestatinssin VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssin(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssin,:v_p_idaipinsenc,:v_p_nfactinssin,:v_p_irepuinssin,:v_p_imobrinssin,:v_p_xnomaseginssin,:v_p_idaipmanveh,:v_p_xsucuinssin,:v_p_nkiloinssin,:v_p_xdescinssin,:v_p_iestatinssin,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

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
        Public Function modaipinssin(aipinssin As aipinssin) As respopera
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
                    param8.Value = aipinssin.idaipinssin
                    param8.ParameterName = "p_idaipinssin"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssin.idaipinsenc
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssin.nfactinssin
                    param10.ParameterName = "p_nfactinssin"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Bit
                    param11.Value = aipinssin.irepuinssin
                    param11.ParameterName = "p_irepuinssin"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Bit
                    param12.Value = aipinssin.imobrinssin
                    param12.ParameterName = "p_imobrinssin"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 100
                    If aipinssin.xnomaseginssin IsNot Nothing Then
                        param13.Value = aipinssin.xnomaseginssin
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_xnomaseginssin"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Decimal
                    param14.Precision = 18
                    param14.Scale = 0
                    param14.Value = aipinssin.idaipmanveh
                    param14.ParameterName = "p_idaipmanveh"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 100
                    If aipinssin.xsucuinssin IsNot Nothing Then
                        param15.Value = aipinssin.xsucuinssin
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xsucuinssin"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Int
                    param16.Value = aipinssin.nkiloinssin
                    param16.ParameterName = "p_nkiloinssin"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 500
                    If aipinssin.xdescinssin IsNot Nothing Then
                        param17.Value = aipinssin.xdescinssin
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xdescinssin"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 20
                    If aipinssin.iestatinssin IsNot Nothing Then
                        param18.Value = aipinssin.iestatinssin
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_iestatinssin"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.Decimal
                    param19.Precision = 18
                    param19.Scale = 0
                    param19.Value = aipinssin.idseglogreg
                    param19.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssin output,@p_idaipinsenc,@p_nfactinssin,@p_irepuinssin,@p_imobrinssin,@p_xnomaseginssin,@p_idaipmanveh,@p_xsucuinssin,@p_nkiloinssin,@p_xdescinssin,@p_iestatinssin,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = modaipinssinoracle(aipinssin)
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
        Public Function modaipinssinoracle(aipinssin As aipinssin) As respopera
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
                param8.Value = aipinssin.idaipinssin
                param8.ParameterName = "p_idaipinssin"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssin.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssin.nfactinssin
                param10.ParameterName = "p_nfactinssin"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = aipinssin.irepuinssin
                param11.ParameterName = "p_irepuinssin"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Int16
                param12.Value = aipinssin.imobrinssin
                param12.ParameterName = "p_imobrinssin"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Varchar2
                param13.Size = 100
                If aipinssin.xnomaseginssin IsNot Nothing And aipinssin.xnomaseginssin <> "" Then
                    param13.Value = aipinssin.xnomaseginssin
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_xnomaseginssin"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = aipinssin.idaipmanveh
                param14.ParameterName = "p_idaipmanveh"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 100
                If aipinssin.xsucuinssin IsNot Nothing And aipinssin.xsucuinssin <> "" Then
                    param15.Value = aipinssin.xsucuinssin
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xsucuinssin"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Int32
                param16.Value = aipinssin.nkiloinssin
                param16.ParameterName = "p_nkiloinssin"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Long
                If aipinssin.xdescinssin IsNot Nothing And aipinssin.xdescinssin <> "" Then
                    param17.Value = aipinssin.xdescinssin
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xdescinssin"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 20
                If aipinssin.iestatinssin IsNot Nothing And aipinssin.iestatinssin <> "" Then
                    param18.Value = aipinssin.iestatinssin
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_iestatinssin"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = aipinssin.idseglogreg
                param19.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssin FLOAT; v_p_idaipinsenc FLOAT; v_p_nfactinssin FLOAT; v_p_irepuinssin number; v_p_imobrinssin number; v_p_xnomaseginssin VARCHAR2(100); v_p_idaipmanveh FLOAT; v_p_xsucuinssin VARCHAR2(100); v_p_nkiloinssin number; v_p_xdescinssin LONG; v_p_iestatinssin VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssin(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssin,:v_p_idaipinsenc,:v_p_nfactinssin,:v_p_irepuinssin,:v_p_imobrinssin,:v_p_xnomaseginssin,:v_p_idaipmanveh,:v_p_xsucuinssin,:v_p_nkiloinssin,:v_p_xdescinssin,:v_p_iestatinssin,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

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
        Public Function eliaipinssin(aipinssin As aipinssin) As respopera
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
                    param8.Value = aipinssin.idaipinssin
                    param8.ParameterName = "p_idaipinssin"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssin.idaipinsenc
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssin.nfactinssin
                    param10.ParameterName = "p_nfactinssin"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Bit
                    param11.Value = aipinssin.irepuinssin
                    param11.ParameterName = "p_irepuinssin"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Bit
                    param12.Value = aipinssin.imobrinssin
                    param12.ParameterName = "p_imobrinssin"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 100
                    If aipinssin.xnomaseginssin IsNot Nothing Then
                        param13.Value = aipinssin.xnomaseginssin
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_xnomaseginssin"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Decimal
                    param14.Precision = 18
                    param14.Scale = 0
                    param14.Value = aipinssin.idaipmanveh
                    param14.ParameterName = "p_idaipmanveh"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 100
                    If aipinssin.xsucuinssin IsNot Nothing Then
                        param15.Value = aipinssin.xsucuinssin
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xsucuinssin"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Int
                    param16.Value = aipinssin.nkiloinssin
                    param16.ParameterName = "p_nkiloinssin"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 500
                    If aipinssin.xdescinssin IsNot Nothing Then
                        param17.Value = aipinssin.xdescinssin
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xdescinssin"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 20
                    If aipinssin.iestatinssin IsNot Nothing Then
                        param18.Value = aipinssin.iestatinssin
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_iestatinssin"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.Decimal
                    param19.Precision = 18
                    param19.Scale = 0
                    param19.Value = aipinssin.idseglogreg
                    param19.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssin output,@p_idaipinsenc,@p_nfactinssin,@p_irepuinssin,@p_imobrinssin,@p_xnomaseginssin,@p_idaipmanveh,@p_xsucuinssin,@p_nkiloinssin,@p_xdescinssin,@p_iestatinssin,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipinssinoracle(aipinssin)
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
        Public Function eliaipinssinoracle(aipinssin As aipinssin) As respopera
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
                param8.Value = aipinssin.idaipinssin
                param8.ParameterName = "p_idaipinssin"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssin.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssin.nfactinssin
                param10.ParameterName = "p_nfactinssin"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = aipinssin.irepuinssin
                param11.ParameterName = "p_irepuinssin"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Int16
                param12.Value = aipinssin.imobrinssin
                param12.ParameterName = "p_imobrinssin"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Varchar2
                param13.Size = 100
                If aipinssin.xnomaseginssin IsNot Nothing And aipinssin.xnomaseginssin <> "" Then
                    param13.Value = aipinssin.xnomaseginssin
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_xnomaseginssin"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = aipinssin.idaipmanveh
                param14.ParameterName = "p_idaipmanveh"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 100
                If aipinssin.xsucuinssin IsNot Nothing And aipinssin.xsucuinssin <> "" Then
                    param15.Value = aipinssin.xsucuinssin
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xsucuinssin"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Int32
                param16.Value = aipinssin.nkiloinssin
                param16.ParameterName = "p_nkiloinssin"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Long                
                If aipinssin.xdescinssin IsNot Nothing And aipinssin.xdescinssin <> "" Then
                    param17.Value = aipinssin.xdescinssin
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xdescinssin"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 20
                If aipinssin.iestatinssin IsNot Nothing And aipinssin.iestatinssin <> "" Then
                    param18.Value = aipinssin.iestatinssin
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_iestatinssin"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = aipinssin.idseglogreg
                param19.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssin FLOAT; v_p_idaipinsenc FLOAT; v_p_nfactinssin FLOAT; v_p_irepuinssin number; v_p_imobrinssin number; v_p_xnomaseginssin VARCHAR2(100); v_p_idaipmanveh FLOAT; v_p_xsucuinssin VARCHAR2(100); v_p_nkiloinssin number; v_p_xdescinssin LONG; v_p_iestatinssin VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssin(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssin,:v_p_idaipinsenc,:v_p_nfactinssin,:v_p_irepuinssin,:v_p_imobrinssin,:v_p_xnomaseginssin,:v_p_idaipmanveh,:v_p_xsucuinssin,:v_p_nkiloinssin,:v_p_xdescinssin,:v_p_iestatinssin,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

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
        Public Function eliaipinssin(idaipinssin As Decimal) As respopera
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
                    param8.Value = idaipinssin
                    param8.ParameterName = "p_idaipinssin"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = 0
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = 0
                    param10.ParameterName = "p_nfactinssin"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Bit
                    param11.Value = 0
                    param11.ParameterName = "p_irepuinssin"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Bit
                    param12.Value = 0
                    param12.ParameterName = "p_imobrinssin"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 100
                    param13.Value = ""
                    param13.ParameterName = "p_xnomaseginssin"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Decimal
                    param14.Precision = 18
                    param14.Scale = 0
                    param14.Value = 0
                    param14.ParameterName = "p_idaipmanveh"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 100
                    param15.Value = ""
                    param15.ParameterName = "p_xsucuinssin"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Int
                    param16.Value = 0
                    param16.ParameterName = "p_nkiloinssin"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 500
                    param17.Value = ""
                    param17.ParameterName = "p_xdescinssin"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 20
                    param18.Value = ""
                    param18.ParameterName = "p_iestatinssin"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.Decimal
                    param19.Precision = 18
                    param19.Scale = 0
                    param19.Value = 0
                    param19.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssin output,@p_idaipinsenc,@p_nfactinssin,@p_irepuinssin,@p_imobrinssin,@p_xnomaseginssin,@p_idaipmanveh,@p_xsucuinssin,@p_nkiloinssin,@p_xdescinssin,@p_iestatinssin,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipinssinoracle(idaipinssin)
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
        Public Function eliaipinssinoracle(idaipinssin As Decimal) As respopera
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
                param8.Value = idaipinssin
                param8.ParameterName = "p_idaipinssin"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = 0
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = 0
                param10.ParameterName = "p_nfactinssin"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = 0
                param11.ParameterName = "p_irepuinssin"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Int16
                param12.Value = 0
                param12.ParameterName = "p_imobrinssin"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Varchar2
                param13.Size = 100
                param13.Value = " "
                param13.ParameterName = "p_xnomaseginssin"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = 0
                param14.ParameterName = "p_idaipmanveh"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 100
                param15.Value = " "
                param15.ParameterName = "p_xsucuinssin"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Int32
                param16.Value = 0
                param16.ParameterName = "p_nkiloinssin"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Varchar2
                param17.Size = 500
                param17.Value = " "
                param17.ParameterName = "p_xdescinssin"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 20
                param18.Value = " "
                param18.ParameterName = "p_iestatinssin"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = 0
                param19.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssin FLOAT; v_p_idaipinsenc FLOAT; v_p_nfactinssin FLOAT; v_p_irepuinssin number; v_p_imobrinssin number; v_p_xnomaseginssin VARCHAR2(100); v_p_idaipmanveh FLOAT; v_p_xsucuinssin VARCHAR2(100); v_p_nkiloinssin number; v_p_xdescinssin VARCHAR2(500); v_p_iestatinssin VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssin(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssin,:v_p_idaipinsenc,:v_p_nfactinssin,:v_p_irepuinssin,:v_p_imobrinssin,:v_p_xnomaseginssin,:v_p_idaipmanveh,:v_p_xsucuinssin,:v_p_nkiloinssin,:v_p_xdescinssin,:v_p_iestatinssin,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

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
        Public Function actaipinssin(aipinssin As aipinssin) As respopera
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
                param8.Value = aipinssin.idaipinssin
                param8.ParameterName = "p_idaipinssin"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssin.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssin.nfactinssin
                param10.ParameterName = "p_nfactinssin"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.Bit
                param11.Value = aipinssin.irepuinssin
                param11.ParameterName = "p_irepuinssin"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.Bit
                param12.Value = aipinssin.imobrinssin
                param12.ParameterName = "p_imobrinssin"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = 100
                If aipinssin.xnomaseginssin IsNot Nothing Then
                    param13.Value = aipinssin.xnomaseginssin
                Else
                    param13.Value = ""
                End If
                param13.ParameterName = "p_xnomaseginssin"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = aipinssin.idaipmanveh
                param14.ParameterName = "p_idaipmanveh"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 100
                If aipinssin.xsucuinssin IsNot Nothing Then
                    param15.Value = aipinssin.xsucuinssin
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_xsucuinssin"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.Int
                param16.Value = aipinssin.nkiloinssin
                param16.ParameterName = "p_nkiloinssin"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.VarChar
                param17.Size = 500
                If aipinssin.xdescinssin IsNot Nothing Then
                    param17.Value = aipinssin.xdescinssin
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xdescinssin"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 20
                If aipinssin.iestatinssin IsNot Nothing Then
                    param18.Value = aipinssin.iestatinssin
                Else
                    param18.Value = ""
                End If
                param18.ParameterName = "p_iestatinssin"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = aipinssin.idseglogreg
                param19.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssin output,@p_idaipinsenc,@p_nfactinssin,@p_irepuinssin,@p_imobrinssin,@p_xnomaseginssin,@p_idaipmanveh,@p_xsucuinssin,@p_nkiloinssin,@p_xdescinssin,@p_iestatinssin,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

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
        Public Function desaipinssin(aipinssin As aipinssin) As respopera
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
                param8.Value = aipinssin.idaipinssin
                param8.ParameterName = "p_idaipinssin"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssin.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssin.nfactinssin
                param10.ParameterName = "p_nfactinssin"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.Bit
                param11.Value = aipinssin.irepuinssin
                param11.ParameterName = "p_irepuinssin"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.Bit
                param12.Value = aipinssin.imobrinssin
                param12.ParameterName = "p_imobrinssin"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = 100
                If aipinssin.xnomaseginssin IsNot Nothing Then
                    param13.Value = aipinssin.xnomaseginssin
                Else
                    param13.Value = ""
                End If
                param13.ParameterName = "p_xnomaseginssin"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = aipinssin.idaipmanveh
                param14.ParameterName = "p_idaipmanveh"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 100
                If aipinssin.xsucuinssin IsNot Nothing Then
                    param15.Value = aipinssin.xsucuinssin
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_xsucuinssin"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.Int
                param16.Value = aipinssin.nkiloinssin
                param16.ParameterName = "p_nkiloinssin"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.VarChar
                param17.Size = 500
                If aipinssin.xdescinssin IsNot Nothing Then
                    param17.Value = aipinssin.xdescinssin
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xdescinssin"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 20
                If aipinssin.iestatinssin IsNot Nothing Then
                    param18.Value = aipinssin.iestatinssin
                Else
                    param18.Value = ""
                End If
                param18.ParameterName = "p_iestatinssin"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = aipinssin.idseglogreg
                param19.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssin output,@p_idaipinsenc,@p_nfactinssin,@p_irepuinssin,@p_imobrinssin,@p_xnomaseginssin,@p_idaipmanveh,@p_xsucuinssin,@p_nkiloinssin,@p_xdescinssin,@p_iestatinssin,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

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

        'metodos no genericos
        <HttpPost()> _
        Public Function selaipinssinxidenc(idaipinsenc As Decimal) As aipinssin
            Dim aipinssin As aipinssin = (From p In _db.aipinssin
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).SingleOrDefault
            Return aipinssin
        End Function

    End Class
End Namespace
