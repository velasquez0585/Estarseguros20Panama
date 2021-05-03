﻿Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
    Public Class aipinsrestrepuestController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selaipinsrestrepuestxid(idaipinsrestrepuest As Decimal) As aipinsrestrepuest
            Dim aipinsrestrepuest As aipinsrestrepuest = (From p In _db.aipinsrestrepuest
                                            Where p.idaipinsrestrepuest = idaipinsrestrepuest
                                            Select p).SingleOrDefault
            Return aipinsrestrepuest
        End Function

        <HttpPost()> _
        Public Function selaipinsrestrepuest() As List(Of aipinsrestrepuest)
            Dim lista_aipinsrestrepuest As List(Of aipinsrestrepuest) = (From p In _db.aipinsrestrepuest
                                                        Select p).ToList
            '
            Return lista_aipinsrestrepuest
        End Function

        <HttpPost()> _
           Public Function selaipinsrestrepuestxwheredinamicopag(petiaipinsrestrepuestpaglist As petiaipinsrestrepuestpaglist) As respaipinsrestrepuestpaglist
            Dim sb As New StringBuilder("")
            '
            If petiaipinsrestrepuestpaglist.aipinsrestrepuest.idaipinsrestrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsrestrepuest=")
                    sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.idaipinsrestrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsrestrepuest=")
                        sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.idaipinsrestrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsrestrepuestpaglist.aipinsrestrepuest.idaipinsrest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsrest=")
                    sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.idaipinsrest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsrest=")
                        sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.idaipinsrest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsrestrepuestpaglist.aipinsrestrepuest.idaipmanrepu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipmanrepu=")
                    sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.idaipmanrepu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipmanrepu=")
                        sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.idaipmanrepu))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsrestrepuestpaglist.aipinsrestrepuest.xnominsrestrepuest <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnominsrestrepuest='")
                    sb.Append(petiaipinsrestrepuestpaglist.aipinsrestrepuest.xnominsrestrepuest)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnominsrestrepuest='")
                        sb.Append(petiaipinsrestrepuestpaglist.aipinsrestrepuest.xnominsrestrepuest)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsrestrepuestpaglist.aipinsrestrepuest.iexisinsrestrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.iexisinsrestrepuest=")
                    sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.iexisinsrestrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iexisinsrestrepuest=")
                        sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.iexisinsrestrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsrestrepuestpaglist.aipinsrestrepuest.ibueinsrestrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.ibueinsrestrepuest=")
                    sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.ibueinsrestrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ibueinsrestrepuest=")
                        sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.ibueinsrestrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsrestrepuestpaglist.aipinsrestrepuest.ireginsrestrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.ireginsrestrepuest=")
                    sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.ireginsrestrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ireginsrestrepuest=")
                        sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.ireginsrestrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsrestrepuestpaglist.aipinsrestrepuest.imalinsrestrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.imalinsrestrepuest=")
                    sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.imalinsrestrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.imalinsrestrepuest=")
                        sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.imalinsrestrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsrestrepuestpaglist.aipinsrestrepuest.iestinsrestrepuest <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestinsrestrepuest='")
                    sb.Append(petiaipinsrestrepuestpaglist.aipinsrestrepuest.iestinsrestrepuest)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestinsrestrepuest='")
                        sb.Append(petiaipinsrestrepuestpaglist.aipinsrestrepuest.iestinsrestrepuest)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsrestrepuestpaglist.aipinsrestrepuest.xdescinsrestrepuest <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdescinsrestrepuest='")
                    sb.Append(petiaipinsrestrepuestpaglist.aipinsrestrepuest.xdescinsrestrepuest)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdescinsrestrepuest='")
                        sb.Append(petiaipinsrestrepuestpaglist.aipinsrestrepuest.xdescinsrestrepuest)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsrestrepuestpaglist.aipinsrestrepuest.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petiaipinsrestrepuestpaglist.aipinsrestrepuest.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respaipinsrestrepuestpaglist As New respaipinsrestrepuestpaglist
            respaipinsrestrepuestpaglist.pagaipinsrestrepuest = petiaipinsrestrepuestpaglist.pagaipinsrestrepuest
            Dim skip = skip_paginacion(petiaipinsrestrepuestpaglist.pagaipinsrestrepuest.npagactual, petiaipinsrestrepuestpaglist.pagaipinsrestrepuest.npagtamano)

            If sb.ToString = "" Then
                respaipinsrestrepuestpaglist.lista_aipinsrestrepuest = _db.aipinsrestrepuest.OrderBy(petiaipinsrestrepuestpaglist.pagaipinsrestrepuest.xcamposord & " " & petiaipinsrestrepuestpaglist.pagaipinsrestrepuest.idirord).Skip(skip).Take(petiaipinsrestrepuestpaglist.pagaipinsrestrepuest.npagtamano).ToList
            Else
                respaipinsrestrepuestpaglist.lista_aipinsrestrepuest = _db.aipinsrestrepuest.Where(sb.ToString).OrderBy(petiaipinsrestrepuestpaglist.pagaipinsrestrepuest.xcamposord & " " & petiaipinsrestrepuestpaglist.pagaipinsrestrepuest.idirord).Skip(skip).Take(petiaipinsrestrepuestpaglist.pagaipinsrestrepuest.npagtamano).ToList
            End If
            '
            If (respaipinsrestrepuestpaglist.lista_aipinsrestrepuest.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selaipinsrestrepuestxwheredinamicocount(sb)
                respaipinsrestrepuestpaglist.pagaipinsrestrepuest.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinsrestrepuestpaglist.pagaipinsrestrepuest.npagtamano)
            Else
                respaipinsrestrepuestpaglist.pagaipinsrestrepuest.npagcantidad = 0
                respaipinsrestrepuestpaglist.pagaipinsrestrepuest.npagactual = 0
            End If

            Return respaipinsrestrepuestpaglist
        End Function

        Public Function selaipinsrestrepuestxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.aipinsrestrepuest.count
            Else
                Return _db.aipinsrestrepuest.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
        Public Function insaipinsrestrepuest(aipinsrestrepuest As aipinsrestrepuest) As respopera
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
                param8.Value = 0
                param8.ParameterName = "p_idaipinsrestrepuest"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsrestrepuest.idaipinsrest
                param9.ParameterName = "p_idaipinsrest"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinsrestrepuest.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.varchar
                param11.Size = 50
                If aipinsrestrepuest.xnominsrestrepuest IsNot Nothing Then
                    param11.Value = aipinsrestrepuest.xnominsrestrepuest
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_xnominsrestrepuest"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.bit
                param12.Value = aipinsrestrepuest.iexisinsrestrepuest
                param12.ParameterName = "p_iexisinsrestrepuest"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.bit
                param13.Value = aipinsrestrepuest.ibueinsrestrepuest
                param13.ParameterName = "p_ibueinsrestrepuest"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.bit
                param14.Value = aipinsrestrepuest.ireginsrestrepuest
                param14.ParameterName = "p_ireginsrestrepuest"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.bit
                param15.Value = aipinsrestrepuest.imalinsrestrepuest
                param15.ParameterName = "p_imalinsrestrepuest"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.varchar
                param16.Size = 20
                If aipinsrestrepuest.iestinsrestrepuest IsNot Nothing Then
                    param16.Value = aipinsrestrepuest.iestinsrestrepuest
                Else
                    param16.Value = ""
                End If
                param16.ParameterName = "p_iestinsrestrepuest"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.varchar
                param17.Size = 500
                If aipinsrestrepuest.xdescinsrestrepuest IsNot Nothing Then
                    param17.Value = aipinsrestrepuest.xdescinsrestrepuest
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xdescinsrestrepuest"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.decimal
                param18.Precision = 18
                param18.Scale = 0
                param18.Value = 0
                param18.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsrestrepuest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsrestrepuest output,@p_idaipinsrest,@p_idaipmanrepu,@p_xnominsrestrepuest,@p_iexisinsrestrepuest,@p_ibueinsrestrepuest,@p_ireginsrestrepuest,@p_imalinsrestrepuest,@p_iestinsrestrepuest,@p_xdescinsrestrepuest,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

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
        Public Function modaipinsrestrepuest(aipinsrestrepuest As aipinsrestrepuest) As respopera
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
                param8.Value = aipinsrestrepuest.idaipinsrestrepuest
                param8.ParameterName = "p_idaipinsrestrepuest"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsrestrepuest.idaipinsrest
                param9.ParameterName = "p_idaipinsrest"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinsrestrepuest.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.varchar
                param11.Size = 50
                If aipinsrestrepuest.xnominsrestrepuest IsNot Nothing Then
                    param11.Value = aipinsrestrepuest.xnominsrestrepuest
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_xnominsrestrepuest"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.bit
                param12.Value = aipinsrestrepuest.iexisinsrestrepuest
                param12.ParameterName = "p_iexisinsrestrepuest"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.bit
                param13.Value = aipinsrestrepuest.ibueinsrestrepuest
                param13.ParameterName = "p_ibueinsrestrepuest"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.bit
                param14.Value = aipinsrestrepuest.ireginsrestrepuest
                param14.ParameterName = "p_ireginsrestrepuest"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.bit
                param15.Value = aipinsrestrepuest.imalinsrestrepuest
                param15.ParameterName = "p_imalinsrestrepuest"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.varchar
                param16.Size = 20
                If aipinsrestrepuest.iestinsrestrepuest IsNot Nothing Then
                    param16.Value = aipinsrestrepuest.iestinsrestrepuest
                Else
                    param16.Value = ""
                End If
                param16.ParameterName = "p_iestinsrestrepuest"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.varchar
                param17.Size = 500
                If aipinsrestrepuest.xdescinsrestrepuest IsNot Nothing Then
                    param17.Value = aipinsrestrepuest.xdescinsrestrepuest
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xdescinsrestrepuest"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.decimal
                param18.Precision = 18
                param18.Scale = 0
                param18.Value = aipinsrestrepuest.idseglogreg
                param18.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsrestrepuest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsrestrepuest output,@p_idaipinsrest,@p_idaipmanrepu,@p_xnominsrestrepuest,@p_iexisinsrestrepuest,@p_ibueinsrestrepuest,@p_ireginsrestrepuest,@p_imalinsrestrepuest,@p_iestinsrestrepuest,@p_xdescinsrestrepuest,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

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
        Public Function eliaipinsrestrepuest(aipinsrestrepuest As aipinsrestrepuest) As respopera
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
                param8.Value = aipinsrestrepuest.idaipinsrestrepuest
                param8.ParameterName = "p_idaipinsrestrepuest"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsrestrepuest.idaipinsrest
                param9.ParameterName = "p_idaipinsrest"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinsrestrepuest.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.varchar
                param11.Size = 50
                If aipinsrestrepuest.xnominsrestrepuest IsNot Nothing Then
                    param11.Value = aipinsrestrepuest.xnominsrestrepuest
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_xnominsrestrepuest"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.bit
                param12.Value = aipinsrestrepuest.iexisinsrestrepuest
                param12.ParameterName = "p_iexisinsrestrepuest"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.bit
                param13.Value = aipinsrestrepuest.ibueinsrestrepuest
                param13.ParameterName = "p_ibueinsrestrepuest"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.bit
                param14.Value = aipinsrestrepuest.ireginsrestrepuest
                param14.ParameterName = "p_ireginsrestrepuest"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.bit
                param15.Value = aipinsrestrepuest.imalinsrestrepuest
                param15.ParameterName = "p_imalinsrestrepuest"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.varchar
                param16.Size = 20
                If aipinsrestrepuest.iestinsrestrepuest IsNot Nothing Then
                    param16.Value = aipinsrestrepuest.iestinsrestrepuest
                Else
                    param16.Value = ""
                End If
                param16.ParameterName = "p_iestinsrestrepuest"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.varchar
                param17.Size = 500
                If aipinsrestrepuest.xdescinsrestrepuest IsNot Nothing Then
                    param17.Value = aipinsrestrepuest.xdescinsrestrepuest
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xdescinsrestrepuest"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.decimal
                param18.Precision = 18
                param18.Scale = 0
                param18.Value = aipinsrestrepuest.idseglogreg
                param18.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsrestrepuest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsrestrepuest output,@p_idaipinsrest,@p_idaipmanrepu,@p_xnominsrestrepuest,@p_iexisinsrestrepuest,@p_ibueinsrestrepuest,@p_ireginsrestrepuest,@p_imalinsrestrepuest,@p_iestinsrestrepuest,@p_xdescinsrestrepuest,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

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
        Public Function eliaipinsrestrepuest(idaipinsrestrepuest As Decimal) As respopera
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
                param8.Value = idaipinsrestrepuest
                param8.ParameterName = "p_idaipinsrestrepuest"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = 0
                param9.ParameterName = "p_idaipinsrest"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = 0
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.varchar
                param11.Size = 50
                param11.Value = ""
                param11.ParameterName = "p_xnominsrestrepuest"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.bit
                param12.Value = 0
                param12.ParameterName = "p_iexisinsrestrepuest"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.bit
                param13.Value = 0
                param13.ParameterName = "p_ibueinsrestrepuest"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.bit
                param14.Value = 0
                param14.ParameterName = "p_ireginsrestrepuest"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.bit
                param15.Value = 0
                param15.ParameterName = "p_imalinsrestrepuest"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.varchar
                param16.Size = 20
                param16.Value = ""
                param16.ParameterName = "p_iestinsrestrepuest"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.varchar
                param17.Size = 500
                param17.Value = ""
                param17.ParameterName = "p_xdescinsrestrepuest"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.decimal
                param18.Precision = 18
                param18.Scale = 0
                param18.Value = 0
                param18.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsrestrepuest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsrestrepuest output,@p_idaipinsrest,@p_idaipmanrepu,@p_xnominsrestrepuest,@p_iexisinsrestrepuest,@p_ibueinsrestrepuest,@p_ireginsrestrepuest,@p_imalinsrestrepuest,@p_iestinsrestrepuest,@p_xdescinsrestrepuest,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

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
        Public Function actaipinsrestrepuest(aipinsrestrepuest As aipinsrestrepuest) As respopera
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
                param8.Value = aipinsrestrepuest.idaipinsrestrepuest
                param8.ParameterName = "p_idaipinsrestrepuest"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsrestrepuest.idaipinsrest
                param9.ParameterName = "p_idaipinsrest"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinsrestrepuest.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.varchar
                param11.Size = 50
                If aipinsrestrepuest.xnominsrestrepuest IsNot Nothing Then
                    param11.Value = aipinsrestrepuest.xnominsrestrepuest
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_xnominsrestrepuest"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.bit
                param12.Value = aipinsrestrepuest.iexisinsrestrepuest
                param12.ParameterName = "p_iexisinsrestrepuest"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.bit
                param13.Value = aipinsrestrepuest.ibueinsrestrepuest
                param13.ParameterName = "p_ibueinsrestrepuest"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.bit
                param14.Value = aipinsrestrepuest.ireginsrestrepuest
                param14.ParameterName = "p_ireginsrestrepuest"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.bit
                param15.Value = aipinsrestrepuest.imalinsrestrepuest
                param15.ParameterName = "p_imalinsrestrepuest"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.varchar
                param16.Size = 20
                If aipinsrestrepuest.iestinsrestrepuest IsNot Nothing Then
                    param16.Value = aipinsrestrepuest.iestinsrestrepuest
                Else
                    param16.Value = ""
                End If
                param16.ParameterName = "p_iestinsrestrepuest"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.varchar
                param17.Size = 500
                If aipinsrestrepuest.xdescinsrestrepuest IsNot Nothing Then
                    param17.Value = aipinsrestrepuest.xdescinsrestrepuest
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xdescinsrestrepuest"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.decimal
                param18.Precision = 18
                param18.Scale = 0
                param18.Value = aipinsrestrepuest.idseglogreg
                param18.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsrestrepuest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsrestrepuest output,@p_idaipinsrest,@p_idaipmanrepu,@p_xnominsrestrepuest,@p_iexisinsrestrepuest,@p_ibueinsrestrepuest,@p_ireginsrestrepuest,@p_imalinsrestrepuest,@p_iestinsrestrepuest,@p_xdescinsrestrepuest,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

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
        Public Function desaipinsrestrepuest(aipinsrestrepuest As aipinsrestrepuest) As respopera
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
                param8.Value = aipinsrestrepuest.idaipinsrestrepuest
                param8.ParameterName = "p_idaipinsrestrepuest"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsrestrepuest.idaipinsrest
                param9.ParameterName = "p_idaipinsrest"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipinsrestrepuest.idaipmanrepu
                param10.ParameterName = "p_idaipmanrepu"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.varchar
                param11.Size = 50
                If aipinsrestrepuest.xnominsrestrepuest IsNot Nothing Then
                    param11.Value = aipinsrestrepuest.xnominsrestrepuest
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_xnominsrestrepuest"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.bit
                param12.Value = aipinsrestrepuest.iexisinsrestrepuest
                param12.ParameterName = "p_iexisinsrestrepuest"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.bit
                param13.Value = aipinsrestrepuest.ibueinsrestrepuest
                param13.ParameterName = "p_ibueinsrestrepuest"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.bit
                param14.Value = aipinsrestrepuest.ireginsrestrepuest
                param14.ParameterName = "p_ireginsrestrepuest"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.bit
                param15.Value = aipinsrestrepuest.imalinsrestrepuest
                param15.ParameterName = "p_imalinsrestrepuest"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.varchar
                param16.Size = 20
                If aipinsrestrepuest.iestinsrestrepuest IsNot Nothing Then
                    param16.Value = aipinsrestrepuest.iestinsrestrepuest
                Else
                    param16.Value = ""
                End If
                param16.ParameterName = "p_iestinsrestrepuest"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.varchar
                param17.Size = 500
                If aipinsrestrepuest.xdescinsrestrepuest IsNot Nothing Then
                    param17.Value = aipinsrestrepuest.xdescinsrestrepuest
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xdescinsrestrepuest"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.decimal
                param18.Precision = 18
                param18.Scale = 0
                param18.Value = aipinsrestrepuest.idseglogreg
                param18.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsrestrepuest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsrestrepuest output,@p_idaipinsrest,@p_idaipmanrepu,@p_xnominsrestrepuest,@p_iexisinsrestrepuest,@p_ibueinsrestrepuest,@p_ireginsrestrepuest,@p_imalinsrestrepuest,@p_iestinsrestrepuest,@p_xdescinsrestrepuest,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18)

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
        Public Function selaipinsrestrepuestxidaipinsrest(idaipinsrest As Decimal) As List(Of aipinsrestrepuest)
            Dim lista_aipinsrestrepuest As List(Of aipinsrestrepuest) = (From p In _db.aipinsrestrepuest
                                            Where p.idaipinsrest = idaipinsrest
                                            Select p).ToList
            Return lista_aipinsrestrepuest
        End Function
    End Class
End Namespace
