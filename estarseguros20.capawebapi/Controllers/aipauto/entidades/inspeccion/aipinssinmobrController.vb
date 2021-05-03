Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports Oracle.ManagedDataAccess
Namespace aipauto.entidades.controlador
    Public Class aipinssinmobrController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selaipinssinmobrxid(idaipinssinmobr As Decimal) As aipinssinmobr
            Dim aipinssinmobr As aipinssinmobr = (From p In _db.aipinssinmobr
                                            Where p.idaipinssinmobr = idaipinssinmobr
                                            Select p).SingleOrDefault
            Return aipinssinmobr
        End Function

        <HttpPost()> _
        Public Function selaipinssinmobr() As List(Of aipinssinmobr)
            Dim lista_aipinssinmobr As List(Of aipinssinmobr) = (From p In _db.aipinssinmobr
                                                        Select p).ToList
            '
            Return lista_aipinssinmobr
        End Function


        <HttpPost()> _
        Public Function selaipinssinmobrxwheredinamicopag(petiaipinssinmobrpaglist As petiaipinssinmobrpaglist) As respaipinssinmobrpaglist
            Dim sb As New StringBuilder("")
            '
            If petiaipinssinmobrpaglist.aipinssinmobr.idaipinssinmobr <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssinmobr=")
                    sb.Append(valor_entero(petiaipinssinmobrpaglist.aipinssinmobr.idaipinssinmobr))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssinmobr=")
                        sb.Append(valor_entero(petiaipinssinmobrpaglist.aipinssinmobr.idaipinssinmobr))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinmobrpaglist.aipinssinmobr.idaipinssin <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssin=")
                    sb.Append(valor_entero(petiaipinssinmobrpaglist.aipinssinmobr.idaipinssin))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssin=")
                        sb.Append(valor_entero(petiaipinssinmobrpaglist.aipinssinmobr.idaipinssin))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinmobrpaglist.aipinssinmobr.idaipmanrepu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipmanrepu=")
                    sb.Append(valor_entero(petiaipinssinmobrpaglist.aipinssinmobr.idaipmanrepu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipmanrepu=")
                        sb.Append(valor_entero(petiaipinssinmobrpaglist.aipinssinmobr.idaipmanrepu))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinmobrpaglist.aipinssinmobr.ncantinssinmobr <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.ncantinssinmobr=")
                    sb.Append(valor_entero(petiaipinssinmobrpaglist.aipinssinmobr.ncantinssinmobr))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ncantinssinmobr=")
                        sb.Append(valor_entero(petiaipinssinmobrpaglist.aipinssinmobr.ncantinssinmobr))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinmobrpaglist.aipinssinmobr.iorigrepuinssinmobr <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iorigrepuinssinmobr='")
                    sb.Append(petiaipinssinmobrpaglist.aipinssinmobr.iorigrepuinssinmobr)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iorigrepuinssinmobr='")
                        sb.Append(petiaipinssinmobrpaglist.aipinssinmobr.iorigrepuinssinmobr)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssinmobrpaglist.aipinssinmobr.itaminssinmobr <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.itaminssinmobr='")
                    sb.Append(petiaipinssinmobrpaglist.aipinssinmobr.itaminssinmobr)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itaminssinmobr='")
                        sb.Append(petiaipinssinmobrpaglist.aipinssinmobr.itaminssinmobr)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssinmobrpaglist.aipinssinmobr.itipomatinssinmobr <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.itipomatinssinmobr='")
                    sb.Append(petiaipinssinmobrpaglist.aipinssinmobr.itipomatinssinmobr)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itipomatinssinmobr='")
                        sb.Append(petiaipinssinmobrpaglist.aipinssinmobr.itipomatinssinmobr)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssinmobrpaglist.aipinssinmobr.nprecfininssinmobr <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.nprecfininssinmobr=")
                    sb.Append(valor_entero(petiaipinssinmobrpaglist.aipinssinmobr.nprecfininssinmobr))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.nprecfininssinmobr=")
                        sb.Append(valor_entero(petiaipinssinmobrpaglist.aipinssinmobr.nprecfininssinmobr))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssinmobrpaglist.aipinssinmobr.xdescinssinmobr <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdescinssinmobr='")
                    sb.Append(petiaipinssinmobrpaglist.aipinssinmobr.xdescinssinmobr)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdescinssinmobr='")
                        sb.Append(petiaipinssinmobrpaglist.aipinssinmobr.xdescinssinmobr)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssinmobrpaglist.aipinssinmobr.iestatinssinmobr <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestatinssinmobr='")
                    sb.Append(petiaipinssinmobrpaglist.aipinssinmobr.iestatinssinmobr)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatinssinmobr='")
                        sb.Append(petiaipinssinmobrpaglist.aipinssinmobr.iestatinssinmobr)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssinmobrpaglist.aipinssinmobr.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petiaipinssinmobrpaglist.aipinssinmobr.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petiaipinssinmobrpaglist.aipinssinmobr.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respaipinssinmobrpaglist As New respaipinssinmobrpaglist
            respaipinssinmobrpaglist.pagaipinssinmobr = petiaipinssinmobrpaglist.pagaipinssinmobr
            Dim skip = skip_paginacion(petiaipinssinmobrpaglist.pagaipinssinmobr.npagactual, petiaipinssinmobrpaglist.pagaipinssinmobr.npagtamano)

            If sb.ToString = "" Then
                respaipinssinmobrpaglist.lista_aipinssinmobr = _db.aipinssinmobr.OrderBy(petiaipinssinmobrpaglist.pagaipinssinmobr.xcamposord & " " & petiaipinssinmobrpaglist.pagaipinssinmobr.idirord).Skip(skip).Take(petiaipinssinmobrpaglist.pagaipinssinmobr.npagtamano).ToList
            Else
                respaipinssinmobrpaglist.lista_aipinssinmobr = _db.aipinssinmobr.Where(sb.ToString).OrderBy(petiaipinssinmobrpaglist.pagaipinssinmobr.xcamposord & " " & petiaipinssinmobrpaglist.pagaipinssinmobr.idirord).Skip(skip).Take(petiaipinssinmobrpaglist.pagaipinssinmobr.npagtamano).ToList
            End If
            '
            If (respaipinssinmobrpaglist.lista_aipinssinmobr.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selaipinssinmobrxwheredinamicocount(sb)
                respaipinssinmobrpaglist.pagaipinssinmobr.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinssinmobrpaglist.pagaipinssinmobr.npagtamano)
            Else
                respaipinssinmobrpaglist.pagaipinssinmobr.npagcantidad = 0
                respaipinssinmobrpaglist.pagaipinssinmobr.npagactual = 0
            End If

            Return respaipinssinmobrpaglist
        End Function

        Public Function selaipinssinmobrxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.aipinssinmobr.count
            Else
                Return _db.aipinssinmobr.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
        Public Function insaipinssinmobr(aipinssinmobr As aipinssinmobr) As respopera
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
                    param8.ParameterName = "p_idaipinssinmobr"
                    param8.Direction = ParameterDirection.Output

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssinmobr.idaipinssin
                    param9.ParameterName = "p_idaipinssin"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssinmobr.idaipmanrepu
                    param10.ParameterName = "p_idaipmanrepu"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.SmallInt
                    param11.Value = aipinssinmobr.ncantinssinmobr
                    param11.ParameterName = "p_ncantinssinmobr"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    If aipinssinmobr.iorigrepuinssinmobr IsNot Nothing Then
                        param12.Value = aipinssinmobr.iorigrepuinssinmobr
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_iorigrepuinssinmobr"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 20
                    If aipinssinmobr.itaminssinmobr IsNot Nothing Then
                        param13.Value = aipinssinmobr.itaminssinmobr
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_itaminssinmobr"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 50
                    If aipinssinmobr.itipomatinssinmobr IsNot Nothing Then
                        param14.Value = aipinssinmobr.itipomatinssinmobr
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_itipomatinssinmobr"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 50
                    If aipinssinmobr.itidainssinmobr IsNot Nothing Then
                        param15.Value = aipinssinmobr.itidainssinmobr
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_itidainssinmobr"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Decimal
                    param16.Precision = 18
                    param16.Scale = 2
                    param16.Value = aipinssinmobr.nprecfininssinmobr
                    param16.ParameterName = "p_nprecfininssinmobr"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 500
                    If aipinssinmobr.xdescinssinmobr IsNot Nothing Then
                        param17.Value = aipinssinmobr.xdescinssinmobr
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xdescinssinmobr"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 20
                    If aipinssinmobr.iestatinssinmobr IsNot Nothing Then
                        param18.Value = aipinssinmobr.iestatinssinmobr
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_iestatinssinmobr"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.Decimal
                    param19.Precision = 18
                    param19.Scale = 0
                    param19.Value = 0
                    param19.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssinmobr output,@p_idaipinssin,@p_idaipmanrepu,@p_ncantinssinmobr,@p_iorigrepuinssinmobr,@p_itaminssinmobr,@p_itipomatinssinmobr, @p_itidainssinmobr,@p_nprecfininssinmobr,@p_xdescinssinmobr,@p_iestatinssinmobr,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = insaipinssinmobroracle(aipinssinmobr)
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
        Public Function insaipinssinmobroracle(aipinssinmobr As aipinssinmobr) As respopera
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
                param8.ParameterName = "p_idaipinssinmobr"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssinmobr.idaipinssin
                param9.ParameterName = "p_idaipinssin"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssinmobr.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = aipinssinmobr.ncantinssinmobr
                param11.ParameterName = "p_ncantinssinmobr"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.VARCHAR2
                param12.Size = 20
                If aipinssinmobr.iorigrepuinssinmobr IsNot Nothing And aipinssinmobr.iorigrepuinssinmobr <> "" Then
                    param12.Value = aipinssinmobr.iorigrepuinssinmobr
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_iorigrepuinssinmobr"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 20
                If aipinssinmobr.itaminssinmobr IsNot Nothing And aipinssinmobr.itaminssinmobr <> "" Then
                    param13.Value = aipinssinmobr.itaminssinmobr
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_itaminssinmobr"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 50
                If aipinssinmobr.itipomatinssinmobr IsNot Nothing And aipinssinmobr.itipomatinssinmobr <> "" Then
                    param14.Value = aipinssinmobr.itipomatinssinmobr
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_itidainssinmobr"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 50
                If aipinssinmobr.itidainssinmobr IsNot Nothing And aipinssinmobr.itidainssinmobr <> "" Then
                    param15.Value = aipinssinmobr.itidainssinmobr
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_itidainssinmobr"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Decimal
                param16.Precision = 18
                param16.Scale = 2
                param16.Value = aipinssinmobr.nprecfininssinmobr
                param16.ParameterName = "p_nprecfininssinmobr"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Varchar2
                param17.Size = 500
                If aipinssinmobr.xdescinssinmobr IsNot Nothing And aipinssinmobr.xdescinssinmobr <> "" Then
                    param17.Value = aipinssinmobr.xdescinssinmobr
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xdescinssinmobr"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 20
                If aipinssinmobr.iestatinssinmobr IsNot Nothing And aipinssinmobr.iestatinssinmobr <> "" Then
                    param18.Value = aipinssinmobr.iestatinssinmobr
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_iestatinssinmobr"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = 0
                param19.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssinmobr FLOAT; v_p_idaipinssin FLOAT; v_p_idaipmanrepu FLOAT; v_p_ncantinssinmobr number; v_p_iorigrepuinssinmobr VARCHAR2(20); v_p_itaminssinmobr VARCHAR2(20); v_p_itipomatinssinmobr VARCHAR2(50); v_p_itidainssinmobr VARCHAR2(50); v_p_nprecfininssinmobr number; v_p_xdescinssinmobr VARCHAR2(500); v_p_iestatinssinmobr VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssinmobr(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssinmobr,:v_p_idaipinssin,:v_p_idaipmanrepu,:v_p_ncantinssinmobr,:v_p_iorigrepuinssinmobr,:v_p_itaminssinmobr,:v_p_itipomatinssinmobr,:v_p_itidainssinmobr,:v_p_nprecfininssinmobr,:v_p_xdescinssinmobr,:v_p_iestatinssinmobr,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
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
        Public Function modaipinssinmobr(aipinssinmobr As aipinssinmobr) As respopera
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
                    param8.Value = aipinssinmobr.idaipinssinmobr
                    param8.ParameterName = "p_idaipinssinmobr"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssinmobr.idaipinssin
                    param9.ParameterName = "p_idaipinssin"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssinmobr.idaipmanrepu
                    param10.ParameterName = "p_idaipmanrepu"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.SmallInt
                    param11.Value = aipinssinmobr.ncantinssinmobr
                    param11.ParameterName = "p_ncantinssinmobr"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    If aipinssinmobr.iorigrepuinssinmobr IsNot Nothing Then
                        param12.Value = aipinssinmobr.iorigrepuinssinmobr
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_iorigrepuinssinmobr"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 20
                    If aipinssinmobr.itaminssinmobr IsNot Nothing Then
                        param13.Value = aipinssinmobr.itaminssinmobr
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_itaminssinmobr"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 50
                    If aipinssinmobr.itipomatinssinmobr IsNot Nothing Then
                        param14.Value = aipinssinmobr.itipomatinssinmobr
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_itipomatinssinmobr"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 50
                    If aipinssinmobr.itidainssinmobr IsNot Nothing Then
                        param15.Value = aipinssinmobr.itidainssinmobr
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_itidainssinmobr"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Decimal
                    param16.Precision = 18
                    param16.Scale = 2
                    param16.Value = aipinssinmobr.nprecfininssinmobr
                    param16.ParameterName = "p_nprecfininssinmobr"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 500
                    If aipinssinmobr.xdescinssinmobr IsNot Nothing Then
                        param17.Value = aipinssinmobr.xdescinssinmobr
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xdescinssinmobr"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 20
                    If aipinssinmobr.iestatinssinmobr IsNot Nothing Then
                        param18.Value = aipinssinmobr.iestatinssinmobr
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_iestatinssinmobr"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.Decimal
                    param19.Precision = 18
                    param19.Scale = 0
                    param19.Value = 0
                    param19.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssinmobr output,@p_idaipinssin,@p_idaipmanrepu,@p_ncantinssinmobr,@p_iorigrepuinssinmobr,@p_itaminssinmobr,@p_itipomatinssinmobr,@p_itidainssinmobr,@p_nprecfininssinmobr,@p_xdescinssinmobr,@p_iestatinssinmobr,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = modaipinssinmobroracle(aipinssinmobr)
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
        Public Function modaipinssinmobroracle(aipinssinmobr As aipinssinmobr) As respopera
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
                param8.Value = aipinssinmobr.idaipinssinmobr
                param8.ParameterName = "p_idaipinssinmobr"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssinmobr.idaipinssin
                param9.ParameterName = "p_idaipinssin"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssinmobr.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = aipinssinmobr.ncantinssinmobr
                param11.ParameterName = "p_ncantinssinmobr"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.VARCHAR2
                param12.Size = 20
                If aipinssinmobr.iorigrepuinssinmobr IsNot Nothing And aipinssinmobr.iorigrepuinssinmobr <> "" Then
                    param12.Value = aipinssinmobr.iorigrepuinssinmobr
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_iorigrepuinssinmobr"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 20
                If aipinssinmobr.itaminssinmobr IsNot Nothing And aipinssinmobr.itaminssinmobr <> "" Then
                    param13.Value = aipinssinmobr.itaminssinmobr
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_itaminssinmobr"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 50
                If aipinssinmobr.itipomatinssinmobr IsNot Nothing And aipinssinmobr.itipomatinssinmobr <> "" Then
                    param14.Value = aipinssinmobr.itipomatinssinmobr
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_itipomatinssinmobr"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 50
                If aipinssinmobr.itidainssinmobr IsNot Nothing And aipinssinmobr.itidainssinmobr <> "" Then
                    param15.Value = aipinssinmobr.itidainssinmobr
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_itidainssinmobr"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Decimal
                param16.Precision = 18
                param16.Scale = 2
                param16.Value = aipinssinmobr.nprecfininssinmobr
                param16.ParameterName = "p_nprecfininssinmobr"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Varchar2
                param17.Size = 500
                If aipinssinmobr.xdescinssinmobr IsNot Nothing And aipinssinmobr.xdescinssinmobr <> "" Then
                    param17.Value = aipinssinmobr.xdescinssinmobr
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xdescinssinmobr"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 20
                If aipinssinmobr.iestatinssinmobr IsNot Nothing And aipinssinmobr.iestatinssinmobr <> "" Then
                    param18.Value = aipinssinmobr.iestatinssinmobr
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_iestatinssinmobr"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = 0
                param19.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssinmobr FLOAT; v_p_idaipinssin FLOAT; v_p_idaipmanrepu FLOAT; v_p_ncantinssinmobr number; v_p_iorigrepuinssinmobr VARCHAR2(20); v_p_itaminssinmobr VARCHAR2(20); v_p_itipomatinssinmobr VARCHAR2(50);v_p_itidainssinmobr VARCHAR2(50); v_p_nprecfininssinmobr number; v_p_xdescinssinmobr VARCHAR2(500); v_p_iestatinssinmobr VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssinmobr(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssinmobr,:v_p_idaipinssin,:v_p_idaipmanrepu,:v_p_ncantinssinmobr,:v_p_iorigrepuinssinmobr,:v_p_itaminssinmobr,:v_p_itipomatinssinmobr,:v_p_itidainssinmobr,:v_p_nprecfininssinmobr,:v_p_xdescinssinmobr,:v_p_iestatinssinmobr,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
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
        Public Function eliaipinssinmobr(aipinssinmobr As aipinssinmobr) As respopera
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
                    param8.Value = aipinssinmobr.idaipinssinmobr
                    param8.ParameterName = "p_idaipinssinmobr"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssinmobr.idaipinssin
                    param9.ParameterName = "p_idaipinssin"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipinssinmobr.idaipmanrepu
                    param10.ParameterName = "p_idaipmanrepu"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.SmallInt
                    param11.Value = aipinssinmobr.ncantinssinmobr
                    param11.ParameterName = "p_ncantinssinmobr"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    If aipinssinmobr.iorigrepuinssinmobr IsNot Nothing Then
                        param12.Value = aipinssinmobr.iorigrepuinssinmobr
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_iorigrepuinssinmobr"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 20
                    If aipinssinmobr.itaminssinmobr IsNot Nothing Then
                        param13.Value = aipinssinmobr.itaminssinmobr
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_itaminssinmobr"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 50
                    If aipinssinmobr.itipomatinssinmobr IsNot Nothing Then
                        param14.Value = aipinssinmobr.itipomatinssinmobr
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_itipomatinssinmobr"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 50
                    If aipinssinmobr.itidainssinmobr IsNot Nothing Then
                        param15.Value = aipinssinmobr.itidainssinmobr
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_itidainssinmobr"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Decimal
                    param16.Precision = 18
                    param16.Scale = 2
                    param16.Value = aipinssinmobr.nprecfininssinmobr
                    param16.ParameterName = "p_nprecfininssinmobr"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 500
                    If aipinssinmobr.xdescinssinmobr IsNot Nothing Then
                        param17.Value = aipinssinmobr.xdescinssinmobr
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xdescinssinmobr"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 20
                    If aipinssinmobr.iestatinssinmobr IsNot Nothing Then
                        param18.Value = aipinssinmobr.iestatinssinmobr
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_iestatinssinmobr"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.Decimal
                    param19.Precision = 18
                    param19.Scale = 0
                    param19.Value = 0
                    param19.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssinmobr output,@p_idaipinssin,@p_idaipmanrepu,@p_ncantinssinmobr,@p_iorigrepuinssinmobr,@p_itaminssinmobr,@p_itipomatinssinmobr,@p_itidainssinmobr,@p_nprecfininssinmobr,@p_xdescinssinmobr,@p_iestatinssinmobr,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipinssinmobroracle(aipinssinmobr)
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
        Public Function eliaipinssinmobroracle(aipinssinmobr As aipinssinmobr) As respopera
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
                param8.Value = aipinssinmobr.idaipinssinmobr
                param8.ParameterName = "p_idaipinssinmobr"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssinmobr.idaipinssin
                param9.ParameterName = "p_idaipinssin"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssinmobr.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Int16
                param11.Value = aipinssinmobr.ncantinssinmobr
                param11.ParameterName = "p_ncantinssinmobr"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.VARCHAR2
                param12.Size = 20
                If aipinssinmobr.iorigrepuinssinmobr IsNot Nothing And aipinssinmobr.iorigrepuinssinmobr <> "" Then
                    param12.Value = aipinssinmobr.iorigrepuinssinmobr
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_iorigrepuinssinmobr"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 20
                If aipinssinmobr.itaminssinmobr IsNot Nothing And aipinssinmobr.itaminssinmobr <> "" Then
                    param13.Value = aipinssinmobr.itaminssinmobr
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_itaminssinmobr"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 50
                If aipinssinmobr.itipomatinssinmobr IsNot Nothing And aipinssinmobr.itipomatinssinmobr <> "" Then
                    param14.Value = aipinssinmobr.itipomatinssinmobr
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_itipomatinssinmobr"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 50
                If aipinssinmobr.itidainssinmobr IsNot Nothing And aipinssinmobr.itidainssinmobr <> "" Then
                    param15.Value = aipinssinmobr.itidainssinmobr
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_itidainssinmobr"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Decimal
                param16.Precision = 18
                param16.Scale = 2
                param16.Value = aipinssinmobr.nprecfininssinmobr
                param16.ParameterName = "p_nprecfininssinmobr"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Varchar2
                param17.Size = 500
                If aipinssinmobr.xdescinssinmobr IsNot Nothing And aipinssinmobr.xdescinssinmobr <> "" Then
                    param17.Value = aipinssinmobr.xdescinssinmobr
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xdescinssinmobr"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 20
                If aipinssinmobr.iestatinssinmobr IsNot Nothing And aipinssinmobr.iestatinssinmobr <> "" Then
                    param18.Value = aipinssinmobr.iestatinssinmobr
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_iestatinssinmobr"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = 0
                param19.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssinmobr FLOAT; v_p_idaipinssin FLOAT; v_p_idaipmanrepu FLOAT; v_p_ncantinssinmobr number; v_p_iorigrepuinssinmobr VARCHAR2(20); v_p_itaminssinmobr VARCHAR2(20); v_p_itipomatinssinmobr VARCHAR2(50);v_p_itidainssinmobr VARCHAR2(50); v_p_nprecfininssinmobr number; v_p_xdescinssinmobr VARCHAR2(500); v_p_iestatinssinmobr VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssinmobr(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssinmobr,:v_p_idaipinssin,:v_p_idaipmanrepu,:v_p_ncantinssinmobr,:v_p_iorigrepuinssinmobr,:v_p_itaminssinmobr,:v_p_itipomatinssinmobr,:v_p_itidainssinmobr,:v_p_nprecfininssinmobr,:v_p_xdescinssinmobr,:v_p_iestatinssinmobr,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
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
        Public Function eliaipinssinmobr(idaipinssinmobr As Decimal) As respopera
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
                    param8.Value = idaipinssinmobr
                    param8.ParameterName = "p_idaipinssinmobr"
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
                    param11.ParameterName = "p_ncantinssinmobr"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    param12.Value = ""
                    param12.ParameterName = "p_iorigrepuinssinmobr"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 20
                    param13.Value = ""
                    param13.ParameterName = "p_itaminssinmobr"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 50
                    param14.Value = ""
                    param14.ParameterName = "p_itipomatinssinmobr"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 50
                    param15.Value = ""
                    param15.ParameterName = "p_itidainssinmobr"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Decimal
                    param16.Precision = 18
                    param16.Scale = 2
                    param16.Value = 0
                    param16.ParameterName = "p_nprecfininssinmobr"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 500
                    param17.Value = ""
                    param17.ParameterName = "p_xdescinssinmobr"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 20
                    param18.Value = ""
                    param18.ParameterName = "p_iestatinssinmobr"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.Decimal
                    param19.Precision = 18
                    param19.Scale = 0
                    param19.Value = 0
                    param19.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssinmobr output,@p_idaipinssin,@p_idaipmanrepu,@p_ncantinssinmobr,@p_iorigrepuinssinmobr,@p_itaminssinmobr,@p_itipomatinssinmobr,@p_itidainssinmobr,@p_nprecfininssinmobr,@p_xdescinssinmobr,@p_iestatinssinmobr,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipinssinmobroracle(idaipinssinmobr)
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
        Public Function eliaipinssinmobroracle(idaipinssinmobr As Decimal) As respopera
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
                param8.Value = idaipinssinmobr
                param8.ParameterName = "p_idaipinssinmobr"
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
                param11.ParameterName = "p_ncantinssinmobr"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.VARCHAR2
                param12.Size = 20
                param12.Value = " "
                param12.ParameterName = "p_iorigrepuinssinmobr"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 20
                param13.Value = " "
                param13.ParameterName = "p_itaminssinmobr"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 50
                param14.Value = " "
                param14.ParameterName = "p_itipomatinssinmobr"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 50
                param15.Value = " "
                param15.ParameterName = "p_itidainssinmobr"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Decimal
                param16.Precision = 18
                param16.Scale = 2
                param16.Value = 0
                param16.ParameterName = "p_nprecfininssinmobr"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Varchar2
                param17.Size = 500
                param17.Value = " "
                param17.ParameterName = "p_xdescinssinmobr"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 20
                param18.Value = " "
                param18.ParameterName = "p_iestatinssinmobr"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = 0
                param19.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssinmobr FLOAT; v_p_idaipinssin FLOAT; v_p_idaipmanrepu FLOAT; v_p_ncantinssinmobr number; v_p_iorigrepuinssinmobr VARCHAR2(20); v_p_itaminssinmobr VARCHAR2(20); v_p_itipomatinssinmobr VARCHAR2(50);v_p_itidainssinmobr VARCHAR2(50); v_p_nprecfininssinmobr number; v_p_xdescinssinmobr VARCHAR2(500); v_p_iestatinssinmobr VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssinmobr(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssinmobr,:v_p_idaipinssin,:v_p_idaipmanrepu,:v_p_ncantinssinmobr,:v_p_iorigrepuinssinmobr,:v_p_itaminssinmobr,:v_p_itipomatinssinmobr,:v_p_itidainssinmobr,:v_p_nprecfininssinmobr,:v_p_xdescinssinmobr,:v_p_iestatinssinmobr,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
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
        Public Function actaipinssinmobr(aipinssinmobr As aipinssinmobr) As respopera
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
                param8.Value = aipinssinmobr.idaipinssinmobr
                param8.ParameterName = "p_idaipinssinmobr"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssinmobr.idaipinssin
                param9.ParameterName = "p_idaipinssin"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssinmobr.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.SmallInt
                param11.Value = aipinssinmobr.ncantinssinmobr
                param11.ParameterName = "p_ncantinssinmobr"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                If aipinssinmobr.iorigrepuinssinmobr IsNot Nothing Then
                    param12.Value = aipinssinmobr.iorigrepuinssinmobr
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_iorigrepuinssinmobr"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = 20
                If aipinssinmobr.itaminssinmobr IsNot Nothing Then
                    param13.Value = aipinssinmobr.itaminssinmobr
                Else
                    param13.Value = ""
                End If
                param13.ParameterName = "p_itaminssinmobr"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = 50
                If aipinssinmobr.itipomatinssinmobr IsNot Nothing Then
                    param14.Value = aipinssinmobr.itipomatinssinmobr
                Else
                    param14.Value = ""
                End If
                param14.ParameterName = "p_itipomatinssinmobr"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 50
                If aipinssinmobr.itidainssinmobr IsNot Nothing Then
                    param15.Value = aipinssinmobr.itidainssinmobr
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_itidainssinmobr"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.Decimal
                param16.Precision = 18
                param16.Scale = 2
                param16.Value = aipinssinmobr.nprecfininssinmobr
                param16.ParameterName = "p_nprecfininssinmobr"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.VarChar
                param17.Size = 500
                If aipinssinmobr.xdescinssinmobr IsNot Nothing Then
                    param17.Value = aipinssinmobr.xdescinssinmobr
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xdescinssinmobr"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 20
                If aipinssinmobr.iestatinssinmobr IsNot Nothing Then
                    param18.Value = aipinssinmobr.iestatinssinmobr
                Else
                    param18.Value = ""
                End If
                param18.ParameterName = "p_iestatinssinmobr"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = 0
                param19.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssinmobr output,@p_idaipinssin,@p_idaipmanrepu,@p_ncantinssinmobr,@p_iorigrepuinssinmobr,@p_itaminssinmobr,@p_itipomatinssinmobr,@p_itidainssinmobr,@p_nprecfininssinmobr,@p_xdescinssinmobr,@p_iestatinssinmobr,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

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
        Public Function desaipinssinmobr(aipinssinmobr As aipinssinmobr) As respopera
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
                param8.Value = aipinssinmobr.idaipinssinmobr
                param8.ParameterName = "p_idaipinssinmobr"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssinmobr.idaipinssin
                param9.ParameterName = "p_idaipinssin"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinssinmobr.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.SmallInt
                param11.Value = aipinssinmobr.ncantinssinmobr
                param11.ParameterName = "p_ncantinssinmobr"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                If aipinssinmobr.iorigrepuinssinmobr IsNot Nothing Then
                    param12.Value = aipinssinmobr.iorigrepuinssinmobr
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_iorigrepuinssinmobr"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = 20
                If aipinssinmobr.itaminssinmobr IsNot Nothing Then
                    param13.Value = aipinssinmobr.itaminssinmobr
                Else
                    param13.Value = ""
                End If
                param13.ParameterName = "p_itaminssinmobr"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = 50
                If aipinssinmobr.itipomatinssinmobr IsNot Nothing Then
                    param14.Value = aipinssinmobr.itipomatinssinmobr
                Else
                    param14.Value = ""
                End If
                param14.ParameterName = "p_itipomatinssinmobr"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 50
                If aipinssinmobr.itidainssinmobr IsNot Nothing Then
                    param15.Value = aipinssinmobr.itidainssinmobr
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_itidainssinmobr"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.Decimal
                param16.Precision = 18
                param16.Scale = 2
                param16.Value = aipinssinmobr.nprecfininssinmobr
                param16.ParameterName = "p_nprecfininssinmobr"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.VarChar
                param17.Size = 500
                If aipinssinmobr.xdescinssinmobr IsNot Nothing Then
                    param17.Value = aipinssinmobr.xdescinssinmobr
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xdescinssinmobr"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 20
                If aipinssinmobr.iestatinssinmobr IsNot Nothing Then
                    param18.Value = aipinssinmobr.iestatinssinmobr
                Else
                    param18.Value = ""
                End If
                param18.ParameterName = "p_iestatinssinmobr"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = 0
                param19.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssinmobr output,@p_idaipinssin,@p_idaipmanrepu,@p_ncantinssinmobr,@p_iorigrepuinssinmobr,@p_itaminssinmobr,@p_itipomatinssinmobr,@p_itidainssinmobr,@p_nprecfininssinmobr,@p_xdescinssinmobr,@p_iestatinssinmobr,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

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
