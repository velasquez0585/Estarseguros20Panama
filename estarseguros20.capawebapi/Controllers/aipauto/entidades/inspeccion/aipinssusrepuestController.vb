Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports Oracle.ManagedDataAccess
Namespace aipauto.entidades.controlador
    Public Class aipinssusrepuestController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selaipinssusrepuestxid(idaipinssusrepuest As Decimal) As aipinssusrepuest
            Dim aipinssusrepuest As aipinssusrepuest = (From p In _db.aipinssusrepuest
                                            Where p.idaipinssusrepuest = idaipinssusrepuest
                                            Select p).SingleOrDefault
            Return aipinssusrepuest
        End Function

        <HttpPost()> _
        Public Function selaipinssusrepuest() As List(Of aipinssusrepuest)
            Dim lista_aipinssusrepuest As List(Of aipinssusrepuest) = (From p In _db.aipinssusrepuest
                                                        Select p).ToList
            '
            Return lista_aipinssusrepuest
        End Function

        <HttpPost()> _
           Public Function selaipinssusrepuestxwheredinamicopag(petiaipinssusrepuestpaglist As petiaipinssusrepuestpaglist) As respaipinssusrepuestpaglist
            Dim sb As New StringBuilder("")
            '
            If petiaipinssusrepuestpaglist.aipinssusrepuest.idaipinssusrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssusrepuest=")
                    sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.idaipinssusrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssusrepuest=")
                        sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.idaipinssusrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusrepuestpaglist.aipinssusrepuest.idaipinssus <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssus=")
                    sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.idaipinssus))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssus=")
                        sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.idaipinssus))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusrepuestpaglist.aipinssusrepuest.idaipmanrepu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipmanrepu=")
                    sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.idaipmanrepu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipmanrepu=")
                        sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.idaipmanrepu))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusrepuestpaglist.aipinssusrepuest.xnominssusrepuest <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnominssusrepuest='")
                    sb.Append(petiaipinssusrepuestpaglist.aipinssusrepuest.xnominssusrepuest)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnominssusrepuest='")
                        sb.Append(petiaipinssusrepuestpaglist.aipinssusrepuest.xnominssusrepuest)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssusrepuestpaglist.aipinssusrepuest.inoapliinssusrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.inoapliinssusrepuest=")
                    sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.inoapliinssusrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.inoapliinssusrepuest=")
                        sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.inoapliinssusrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusrepuestpaglist.aipinssusrepuest.ileveinssusrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.ileveinssusrepuest=")
                    sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.ileveinssusrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ileveinssusrepuest=")
                        sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.ileveinssusrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusrepuestpaglist.aipinssusrepuest.imedinssusrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.imedinssusrepuest=")
                    sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.imedinssusrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.imedinssusrepuest=")
                        sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.imedinssusrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusrepuestpaglist.aipinssusrepuest.ifueinssusrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.ifueinssusrepuest=")
                    sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.ifueinssusrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ifueinssusrepuest=")
                        sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.ifueinssusrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusrepuestpaglist.aipinssusrepuest.ibueestinssusrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.ibueestinssusrepuest=")
                    sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.ibueestinssusrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ibueestinssusrepuest=")
                        sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.ibueestinssusrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssusrepuestpaglist.aipinssusrepuest.iestinssusrepuest <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestinssusrepuest='")
                    sb.Append(petiaipinssusrepuestpaglist.aipinssusrepuest.iestinssusrepuest)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestinssusrepuest='")
                        sb.Append(petiaipinssusrepuestpaglist.aipinssusrepuest.iestinssusrepuest)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssusrepuestpaglist.aipinssusrepuest.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petiaipinssusrepuestpaglist.aipinssusrepuest.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respaipinssusrepuestpaglist As New respaipinssusrepuestpaglist
            respaipinssusrepuestpaglist.pagaipinssusrepuest = petiaipinssusrepuestpaglist.pagaipinssusrepuest
            Dim skip = skip_paginacion(petiaipinssusrepuestpaglist.pagaipinssusrepuest.npagactual, petiaipinssusrepuestpaglist.pagaipinssusrepuest.npagtamano)

            If sb.ToString = "" Then
                respaipinssusrepuestpaglist.lista_aipinssusrepuest = _db.aipinssusrepuest.OrderBy(petiaipinssusrepuestpaglist.pagaipinssusrepuest.xcamposord & " " & petiaipinssusrepuestpaglist.pagaipinssusrepuest.idirord).Skip(skip).Take(petiaipinssusrepuestpaglist.pagaipinssusrepuest.npagtamano).ToList
            Else
                respaipinssusrepuestpaglist.lista_aipinssusrepuest = _db.aipinssusrepuest.Where(sb.ToString).OrderBy(petiaipinssusrepuestpaglist.pagaipinssusrepuest.xcamposord & " " & petiaipinssusrepuestpaglist.pagaipinssusrepuest.idirord).Skip(skip).Take(petiaipinssusrepuestpaglist.pagaipinssusrepuest.npagtamano).ToList
            End If
            '
            If (respaipinssusrepuestpaglist.lista_aipinssusrepuest.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selaipinssusrepuestxwheredinamicocount(sb)
                respaipinssusrepuestpaglist.pagaipinssusrepuest.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinssusrepuestpaglist.pagaipinssusrepuest.npagtamano)
            Else
                respaipinssusrepuestpaglist.pagaipinssusrepuest.npagcantidad = 0
                respaipinssusrepuestpaglist.pagaipinssusrepuest.npagactual = 0
            End If

            Return respaipinssusrepuestpaglist
        End Function

        Public Function selaipinssusrepuestxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.aipinssusrepuest.count
            Else
                Return _db.aipinssusrepuest.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
           Public Function insaipinssusrepuest(aipinssusrepuest As aipinssusrepuest) As respopera
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
                    param8.ParameterName = "p_idaipinssusrepuest"
                    param8.Direction = ParameterDirection.Output

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssusrepuest.idaipinssus
                    param9.ParameterName = "p_idaipinssus"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssusrepuest.idaipmanrepu
                    param10.ParameterName = "p_idaipmanrepu"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 50
                    If aipinssusrepuest.xnominssusrepuest IsNot Nothing Then
                        param11.Value = aipinssusrepuest.xnominssusrepuest
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_xnominssusrepuest"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Bit
                    param12.Value = aipinssusrepuest.inoapliinssusrepuest
                    param12.ParameterName = "p_inoapliinssusrepuest"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Bit
                    param13.Value = aipinssusrepuest.ileveinssusrepuest
                    param13.ParameterName = "p_ileveinssusrepuest"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Bit
                    param14.Value = aipinssusrepuest.imedinssusrepuest
                    param14.ParameterName = "p_imedinssusrepuest"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.Bit
                    param15.Value = aipinssusrepuest.ifueinssusrepuest
                    param15.ParameterName = "p_ifueinssusrepuest"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Bit
                    param16.Value = aipinssusrepuest.ibueestinssusrepuest
                    param16.ParameterName = "p_ibueestinssusrepuest"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 20
                    If aipinssusrepuest.iestinssusrepuest IsNot Nothing Then
                        param17.Value = aipinssusrepuest.iestinssusrepuest
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_iestinssusrepuest"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.Decimal
                    param18.Precision = 18
                    param18.Scale = 0
                    param18.Value = 0
                    param18.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusrepuest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusrepuest output,@p_idaipinssus,@p_idaipmanrepu,@p_xnominssusrepuest,@p_inoapliinssusrepuest,@p_ileveinssusrepuest,@p_imedinssusrepuest,@p_ifueinssusrepuest,@p_ibueestinssusrepuest,@p_iestinssusrepuest,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else

                    respopera = insaipinssusrepuestoracle(aipinssusrepuest)

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
        Public Function insaipinssusrepuestoracle(aipinssusrepuest As aipinssusrepuest) As respopera
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
                param8.ParameterName = "p_idaipinssusrepuest"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssusrepuest.idaipinssus
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssusrepuest.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.VARCHAR2
                param11.Size = 50
                If aipinssusrepuest.xnominssusrepuest IsNot Nothing And aipinssusrepuest.xnominssusrepuest <> "" Then
                    param11.Value = aipinssusrepuest.xnominssusrepuest
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_xnominssusrepuest"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Int16
                param12.Value = aipinssusrepuest.inoapliinssusrepuest
                param12.ParameterName = "p_inoapliinssusrepuest"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Int16
                param13.Value = aipinssusrepuest.ileveinssusrepuest
                param13.ParameterName = "p_ileveinssusrepuest"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Int16
                param14.Value = aipinssusrepuest.imedinssusrepuest
                param14.ParameterName = "p_imedinssusrepuest"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Int16
                param15.Value = aipinssusrepuest.ifueinssusrepuest
                param15.ParameterName = "p_ifueinssusrepuest"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Int16
                param16.Value = aipinssusrepuest.ibueestinssusrepuest
                param16.ParameterName = "p_ibueestinssusrepuest"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 20
                If aipinssusrepuest.iestinssusrepuest IsNot Nothing And aipinssusrepuest.iestinssusrepuest <> "" Then
                    param17.Value = aipinssusrepuest.iestinssusrepuest
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_iestinssusrepuest"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Decimal
                param18.Precision = 18
                param18.Scale = 0
                param18.Value = 0
                param18.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssusrepuest FLOAT; v_p_idaipinssus FLOAT; v_p_idaipmanrepu FLOAT; v_p_xnominssusrepuest VARCHAR2(50); v_p_inoapliinssusrepuest number; v_p_ileveinssusrepuest number; v_p_imedinssusrepuest number; v_p_ifueinssusrepuest number; v_p_ibueestinssusrepuest number; v_p_iestinssusrepuest VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssusrepuest(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssusrepuest,:v_p_idaipinssus,:v_p_idaipmanrepu,:v_p_xnominssusrepuest,:v_p_inoapliinssusrepuest,:v_p_ileveinssusrepuest,:v_p_imedinssusrepuest,:v_p_ifueinssusrepuest,:v_p_ibueestinssusrepuest,:v_p_iestinssusrepuest,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

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
        Public Function modaipinssusrepuest(aipinssusrepuest As aipinssusrepuest) As respopera
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
                    param8.Value = aipinssusrepuest.idaipinssusrepuest
                    param8.ParameterName = "p_idaipinssusrepuest"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssusrepuest.idaipinssus
                    param9.ParameterName = "p_idaipinssus"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssusrepuest.idaipmanrepu
                    param10.ParameterName = "p_idaipmanrepu"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 50
                    If aipinssusrepuest.xnominssusrepuest IsNot Nothing Then
                        param11.Value = aipinssusrepuest.xnominssusrepuest
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_xnominssusrepuest"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Bit
                    param12.Value = aipinssusrepuest.inoapliinssusrepuest
                    param12.ParameterName = "p_inoapliinssusrepuest"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Bit
                    param13.Value = aipinssusrepuest.ileveinssusrepuest
                    param13.ParameterName = "p_ileveinssusrepuest"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Bit
                    param14.Value = aipinssusrepuest.imedinssusrepuest
                    param14.ParameterName = "p_imedinssusrepuest"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.Bit
                    param15.Value = aipinssusrepuest.ifueinssusrepuest
                    param15.ParameterName = "p_ifueinssusrepuest"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Bit
                    param16.Value = aipinssusrepuest.ibueestinssusrepuest
                    param16.ParameterName = "p_ibueestinssusrepuest"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 20
                    If aipinssusrepuest.iestinssusrepuest IsNot Nothing Then
                        param17.Value = aipinssusrepuest.iestinssusrepuest
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_iestinssusrepuest"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.Decimal
                    param18.Precision = 18
                    param18.Scale = 0
                    param18.Value = aipinssusrepuest.idseglogreg
                    param18.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusrepuest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusrepuest output,@p_idaipinssus,@p_idaipmanrepu,@p_xnominssusrepuest,@p_inoapliinssusrepuest,@p_ileveinssusrepuest,@p_imedinssusrepuest,@p_ifueinssusrepuest,@p_ibueestinssusrepuest,@p_iestinssusrepuest,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else

                    respopera = modaipinssusrepuestoracle(aipinssusrepuest)

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
        Public Function modaipinssusrepuestoracle(aipinssusrepuest As aipinssusrepuest) As respopera
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
                param8.Value = aipinssusrepuest.idaipinssusrepuest
                param8.ParameterName = "p_idaipinssusrepuest"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssusrepuest.idaipinssus
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssusrepuest.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.VARCHAR2
                param11.Size = 50
                If aipinssusrepuest.xnominssusrepuest IsNot Nothing And aipinssusrepuest.xnominssusrepuest <> "" Then
                    param11.Value = aipinssusrepuest.xnominssusrepuest
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_xnominssusrepuest"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Int16
                param12.Value = aipinssusrepuest.inoapliinssusrepuest
                param12.ParameterName = "p_inoapliinssusrepuest"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Int16
                param13.Value = aipinssusrepuest.ileveinssusrepuest
                param13.ParameterName = "p_ileveinssusrepuest"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Int16
                param14.Value = aipinssusrepuest.imedinssusrepuest
                param14.ParameterName = "p_imedinssusrepuest"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Int16
                param15.Value = aipinssusrepuest.ifueinssusrepuest
                param15.ParameterName = "p_ifueinssusrepuest"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Int16
                param16.Value = aipinssusrepuest.ibueestinssusrepuest
                param16.ParameterName = "p_ibueestinssusrepuest"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 20
                If aipinssusrepuest.iestinssusrepuest IsNot Nothing And aipinssusrepuest.iestinssusrepuest <> "" Then
                    param17.Value = aipinssusrepuest.iestinssusrepuest
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_iestinssusrepuest"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Decimal
                param18.Precision = 18
                param18.Scale = 0
                param18.Value = aipinssusrepuest.idseglogreg
                param18.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssusrepuest FLOAT; v_p_idaipinssus FLOAT; v_p_idaipmanrepu FLOAT; v_p_xnominssusrepuest VARCHAR2(50); v_p_inoapliinssusrepuest number; v_p_ileveinssusrepuest number; v_p_imedinssusrepuest number; v_p_ifueinssusrepuest number; v_p_ibueestinssusrepuest number; v_p_iestinssusrepuest VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssusrepuest(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssusrepuest,:v_p_idaipinssus,:v_p_idaipmanrepu,:v_p_xnominssusrepuest,:v_p_inoapliinssusrepuest,:v_p_ileveinssusrepuest,:v_p_imedinssusrepuest,:v_p_ifueinssusrepuest,:v_p_ibueestinssusrepuest,:v_p_iestinssusrepuest,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

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
        Public Function eliaipinssusrepuest(aipinssusrepuest As aipinssusrepuest) As respopera
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
                    param8.Value = aipinssusrepuest.idaipinssusrepuest
                    param8.ParameterName = "p_idaipinssusrepuest"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssusrepuest.idaipinssus
                    param9.ParameterName = "p_idaipinssus"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssusrepuest.idaipmanrepu
                    param10.ParameterName = "p_idaipmanrepu"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 50
                    If aipinssusrepuest.xnominssusrepuest IsNot Nothing Then
                        param11.Value = aipinssusrepuest.xnominssusrepuest
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_xnominssusrepuest"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Bit
                    param12.Value = aipinssusrepuest.inoapliinssusrepuest
                    param12.ParameterName = "p_inoapliinssusrepuest"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Bit
                    param13.Value = aipinssusrepuest.ileveinssusrepuest
                    param13.ParameterName = "p_ileveinssusrepuest"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Bit
                    param14.Value = aipinssusrepuest.imedinssusrepuest
                    param14.ParameterName = "p_imedinssusrepuest"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.Bit
                    param15.Value = aipinssusrepuest.ifueinssusrepuest
                    param15.ParameterName = "p_ifueinssusrepuest"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Bit
                    param16.Value = aipinssusrepuest.ibueestinssusrepuest
                    param16.ParameterName = "p_ibueestinssusrepuest"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 20
                    If aipinssusrepuest.iestinssusrepuest IsNot Nothing Then
                        param17.Value = aipinssusrepuest.iestinssusrepuest
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_iestinssusrepuest"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.Decimal
                    param18.Precision = 18
                    param18.Scale = 0
                    param18.Value = aipinssusrepuest.idseglogreg
                    param18.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusrepuest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusrepuest output,@p_idaipinssus,@p_idaipmanrepu,@p_xnominssusrepuest,@p_inoapliinssusrepuest,@p_ileveinssusrepuest,@p_imedinssusrepuest,@p_ifueinssusrepuest,@p_ibueestinssusrepuest,@p_iestinssusrepuest,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else

                    respopera = eliaipinssusrepuestoracle(aipinssusrepuest)

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
        Public Function eliaipinssusrepuestoracle(aipinssusrepuest As aipinssusrepuest) As respopera
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
                param8.Value = aipinssusrepuest.idaipinssusrepuest
                param8.ParameterName = "p_idaipinssusrepuest"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssusrepuest.idaipinssus
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssusrepuest.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.VARCHAR2
                param11.Size = 50
                If aipinssusrepuest.xnominssusrepuest IsNot Nothing And aipinssusrepuest.xnominssusrepuest <> "" Then
                    param11.Value = aipinssusrepuest.xnominssusrepuest
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_xnominssusrepuest"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Int16
                param12.Value = aipinssusrepuest.inoapliinssusrepuest
                param12.ParameterName = "p_inoapliinssusrepuest"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Int16
                param13.Value = aipinssusrepuest.ileveinssusrepuest
                param13.ParameterName = "p_ileveinssusrepuest"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Int16
                param14.Value = aipinssusrepuest.imedinssusrepuest
                param14.ParameterName = "p_imedinssusrepuest"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Int16
                param15.Value = aipinssusrepuest.ifueinssusrepuest
                param15.ParameterName = "p_ifueinssusrepuest"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Int16
                param16.Value = aipinssusrepuest.ibueestinssusrepuest
                param16.ParameterName = "p_ibueestinssusrepuest"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 20
                If aipinssusrepuest.iestinssusrepuest IsNot Nothing And aipinssusrepuest.iestinssusrepuest <> "" Then
                    param17.Value = aipinssusrepuest.iestinssusrepuest
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_iestinssusrepuest"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Decimal
                param18.Precision = 18
                param18.Scale = 0
                param18.Value = aipinssusrepuest.idseglogreg
                param18.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssusrepuest FLOAT; v_p_idaipinssus FLOAT; v_p_idaipmanrepu FLOAT; v_p_xnominssusrepuest VARCHAR2(50); v_p_inoapliinssusrepuest number; v_p_ileveinssusrepuest number; v_p_imedinssusrepuest number; v_p_ifueinssusrepuest number; v_p_ibueestinssusrepuest number; v_p_iestinssusrepuest VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssusrepuest(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssusrepuest,:v_p_idaipinssus,:v_p_idaipmanrepu,:v_p_xnominssusrepuest,:v_p_inoapliinssusrepuest,:v_p_ileveinssusrepuest,:v_p_imedinssusrepuest,:v_p_ifueinssusrepuest,:v_p_ibueestinssusrepuest,:v_p_iestinssusrepuest,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

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
        Public Function eliaipinssusrepuest(idaipinssusrepuest As Decimal) As respopera
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
                    param8.Value = idaipinssusrepuest
                    param8.ParameterName = "p_idaipinssusrepuest"
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
                    param10.ParameterName = "p_idaipmanrepu"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 50
                    param11.Value = ""
                    param11.ParameterName = "p_xnominssusrepuest"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Bit
                    param12.Value = 0
                    param12.ParameterName = "p_inoapliinssusrepuest"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Bit
                    param13.Value = 0
                    param13.ParameterName = "p_ileveinssusrepuest"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Bit
                    param14.Value = 0
                    param14.ParameterName = "p_imedinssusrepuest"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.Bit
                    param15.Value = 0
                    param15.ParameterName = "p_ifueinssusrepuest"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Bit
                    param16.Value = 0
                    param16.ParameterName = "p_ibueestinssusrepuest"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 20
                    param17.Value = ""
                    param17.ParameterName = "p_iestinssusrepuest"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.Decimal
                    param18.Precision = 18
                    param18.Scale = 0
                    param18.Value = 0
                    param18.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusrepuest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusrepuest output,@p_idaipinssus,@p_idaipmanrepu,@p_xnominssusrepuest,@p_inoapliinssusrepuest,@p_ileveinssusrepuest,@p_imedinssusrepuest,@p_ifueinssusrepuest,@p_ibueestinssusrepuest,@p_iestinssusrepuest,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else

                    respopera = eliaipinssusrepuestoracle(idaipinssusrepuest)

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
        Public Function eliaipinssusrepuestoracle(idaipinssusrepuest As Decimal) As respopera
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
                param8.Value = idaipinssusrepuest
                param8.ParameterName = "p_idaipinssusrepuest"
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
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.VARCHAR2
                param11.Size = 50
                param11.Value = " "
                param11.ParameterName = "p_xnominssusrepuest"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Int16
                param12.Value = 0
                param12.ParameterName = "p_inoapliinssusrepuest"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Int16
                param13.Value = 0
                param13.ParameterName = "p_ileveinssusrepuest"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Int16
                param14.Value = 0
                param14.ParameterName = "p_imedinssusrepuest"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Int16
                param15.Value = 0
                param15.ParameterName = "p_ifueinssusrepuest"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Int16
                param16.Value = 0
                param16.ParameterName = "p_ibueestinssusrepuest"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 20
                param17.Value = " "
                param17.ParameterName = "p_iestinssusrepuest"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Decimal
                param18.Precision = 18
                param18.Scale = 0
                param18.Value = 0
                param18.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssusrepuest FLOAT; v_p_idaipinssus FLOAT; v_p_idaipmanrepu FLOAT; v_p_xnominssusrepuest VARCHAR2(50); v_p_inoapliinssusrepuest number; v_p_ileveinssusrepuest number; v_p_imedinssusrepuest number; v_p_ifueinssusrepuest number; v_p_ibueestinssusrepuest number; v_p_iestinssusrepuest VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssusrepuest(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssusrepuest,:v_p_idaipinssus,:v_p_idaipmanrepu,:v_p_xnominssusrepuest,:v_p_inoapliinssusrepuest,:v_p_ileveinssusrepuest,:v_p_imedinssusrepuest,:v_p_ifueinssusrepuest,:v_p_ibueestinssusrepuest,:v_p_iestinssusrepuest,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

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
        Public Function actaipinssusrepuest(aipinssusrepuest As aipinssusrepuest) As respopera
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
                param8.Value = aipinssusrepuest.idaipinssusrepuest
                param8.ParameterName = "p_idaipinssusrepuest"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssusrepuest.idaipinssus
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssusrepuest.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.varchar
                param11.Size = 50
                If aipinssusrepuest.xnominssusrepuest IsNot Nothing Then
                    param11.Value = aipinssusrepuest.xnominssusrepuest
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_xnominssusrepuest"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.bit
                param12.Value = aipinssusrepuest.inoapliinssusrepuest
                param12.ParameterName = "p_inoapliinssusrepuest"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.bit
                param13.Value = aipinssusrepuest.ileveinssusrepuest
                param13.ParameterName = "p_ileveinssusrepuest"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.bit
                param14.Value = aipinssusrepuest.imedinssusrepuest
                param14.ParameterName = "p_imedinssusrepuest"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.bit
                param15.Value = aipinssusrepuest.ifueinssusrepuest
                param15.ParameterName = "p_ifueinssusrepuest"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.bit
                param16.Value = aipinssusrepuest.ibueestinssusrepuest
                param16.ParameterName = "p_ibueestinssusrepuest"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.varchar
                param17.Size = 20
                If aipinssusrepuest.iestinssusrepuest IsNot Nothing Then
                    param17.Value = aipinssusrepuest.iestinssusrepuest
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_iestinssusrepuest"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.decimal
                param18.Precision = 18
                param18.Scale = 0
                param18.Value = aipinssusrepuest.idseglogreg
                param18.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusrepuest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusrepuest output,@p_idaipinssus,@p_idaipmanrepu,@p_xnominssusrepuest,@p_inoapliinssusrepuest,@p_ileveinssusrepuest,@p_imedinssusrepuest,@p_ifueinssusrepuest,@p_ibueestinssusrepuest,@p_iestinssusrepuest,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

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
        Public Function desaipinssusrepuest(aipinssusrepuest As aipinssusrepuest) As respopera
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
                param8.Value = aipinssusrepuest.idaipinssusrepuest
                param8.ParameterName = "p_idaipinssusrepuest"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssusrepuest.idaipinssus
                param9.ParameterName = "p_idaipinssus"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssusrepuest.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.varchar
                param11.Size = 50
                If aipinssusrepuest.xnominssusrepuest IsNot Nothing Then
                    param11.Value = aipinssusrepuest.xnominssusrepuest
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_xnominssusrepuest"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.bit
                param12.Value = aipinssusrepuest.inoapliinssusrepuest
                param12.ParameterName = "p_inoapliinssusrepuest"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.bit
                param13.Value = aipinssusrepuest.ileveinssusrepuest
                param13.ParameterName = "p_ileveinssusrepuest"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.bit
                param14.Value = aipinssusrepuest.imedinssusrepuest
                param14.ParameterName = "p_imedinssusrepuest"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.bit
                param15.Value = aipinssusrepuest.ifueinssusrepuest
                param15.ParameterName = "p_ifueinssusrepuest"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.bit
                param16.Value = aipinssusrepuest.ibueestinssusrepuest
                param16.ParameterName = "p_ibueestinssusrepuest"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.varchar
                param17.Size = 20
                If aipinssusrepuest.iestinssusrepuest IsNot Nothing Then
                    param17.Value = aipinssusrepuest.iestinssusrepuest
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_iestinssusrepuest"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.decimal
                param18.Precision = 18
                param18.Scale = 0
                param18.Value = aipinssusrepuest.idseglogreg
                param18.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssusrepuest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssusrepuest output,@p_idaipinssus,@p_idaipmanrepu,@p_xnominssusrepuest,@p_inoapliinssusrepuest,@p_ileveinssusrepuest,@p_imedinssusrepuest,@p_ifueinssusrepuest,@p_ibueestinssusrepuest,@p_iestinssusrepuest,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

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
        Public Function selaipinssusrepuestxidaipinssus(idaipinssus As Decimal) As List(Of aipinssusrepuest)
            Dim lista_aipinssusrepuest As List(Of aipinssusrepuest) = (From p In _db.aipinssusrepuest
                                            Where p.idaipinssus = idaipinssus
                                            Select p).ToList
            Return lista_aipinssusrepuest
        End Function

        <HttpPost()> _
        Public Function iexistexidaipinssus(idaipinssus As Decimal) As Boolean
            Dim id() As Decimal = {1, 2, 3}
            Dim iexiste As Boolean = (From p In _db.aipinssusrepuest
            Where p.idaipinssus = idaipinssus And p.inoapliinssusrepuest = True And Not id.Contains(p.idaipmanrepu)
                                            Select p).Any()
            Return iexiste
        End Function


        <HttpPost()> _
        Public Function iexistexidaipinssusConExclusion(idaipinssus As Decimal, lista_idaipmanrepu As List(Of Decimal)) As Boolean

            Dim iexiste As Boolean = (From p In _db.aipinssusrepuest
            Where p.idaipinssus = idaipinssus And p.inoapliinssusrepuest = True And Not lista_idaipmanrepu.Contains(p.idaipmanrepu)
                                            Select p).Any()
            Return iexiste
        End Function

    End Class
End Namespace
