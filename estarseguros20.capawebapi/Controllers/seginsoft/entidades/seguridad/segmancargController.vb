Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.entidades.seguridad

Namespace seginsoft.entidades.controlador
    Public Class segmancargController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selsegmancargxid(idsegmancarg As Decimal) As segmancarg
            Dim segmancarg As segmancarg = (From p In _db.segmancarg
                                            Where p.idsegmancarg = idsegmancarg
                                            Select p).SingleOrDefault
            Return segmancarg
        End Function

        <HttpPost()> _
        Public Function selsegmancarg() As List(Of segmancarg)
            Dim lista_segmancarg As List(Of segmancarg) = (From p In _db.segmancarg
                                                           Where p.idsegmancarg > 0
                                                           Order By p.xnombrecarg Ascending
                                                        Select p).ToList
            'agregar el item vacio para seleccion
            Dim segmancarg As New segmancarg
            With segmancarg
                .idsegmancarg = 0
                .xnombrecarg = "SELECCIONE"
            End With
            lista_segmancarg.Insert(0, segmancarg)
            Return lista_segmancarg
        End Function

        <HttpPost()> _
        Public Function selsegmancargxwheredinamicopag(petisegmancargpaglist As petisegmancargpaglist) As respsegmancargpaglist
            Dim sb As New StringBuilder("")
            '
            If petisegmancargpaglist.segmancarg.idsegmancarg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmancarg=")
                    sb.Append(valor_entero(petisegmancargpaglist.segmancarg.idsegmancarg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmancarg=")
                        sb.Append(valor_entero(petisegmancargpaglist.segmancarg.idsegmancarg))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petisegmancargpaglist.segmancarg.xnombrecarg <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecarg='")
                    sb.Append(petisegmancargpaglist.segmancarg.xnombrecarg)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecarg='")
                        sb.Append(petisegmancargpaglist.segmancarg.xnombrecarg)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petisegmancargpaglist.segmancarg.nprioridad <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.nprioridad=")
                    sb.Append(valor_entero(petisegmancargpaglist.segmancarg.nprioridad))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.nprioridad=")
                        sb.Append(valor_entero(petisegmancargpaglist.segmancarg.nprioridad))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petisegmancargpaglist.segmancarg.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petisegmancargpaglist.segmancarg.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petisegmancargpaglist.segmancarg.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respsegmancargpaglist As New respsegmancargpaglist
            respsegmancargpaglist.pagsegmancarg = petisegmancargpaglist.pagsegmancarg
            Dim skip = skip_paginacion(petisegmancargpaglist.pagsegmancarg.npagactual, petisegmancargpaglist.pagsegmancarg.npagtamano)

            If sb.ToString = "" Then
                respsegmancargpaglist.lista_segmancarg = _db.segmancarg.OrderBy(petisegmancargpaglist.pagsegmancarg.xcamposord & " " & petisegmancargpaglist.pagsegmancarg.idirord).Skip(skip).Take(petisegmancargpaglist.pagsegmancarg.npagtamano).ToList
            Else
                respsegmancargpaglist.lista_segmancarg = _db.segmancarg.Where(sb.ToString).OrderBy(petisegmancargpaglist.pagsegmancarg.xcamposord & " " & petisegmancargpaglist.pagsegmancarg.idirord).Skip(skip).Take(petisegmancargpaglist.pagsegmancarg.npagtamano).ToList
            End If
            '
            If (respsegmancargpaglist.lista_segmancarg.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selsegmancargxwheredinamicocount(sb)
                respsegmancargpaglist.pagsegmancarg.npagcantidad = cantidad_paginas(cant_entero_reg, respsegmancargpaglist.pagsegmancarg.npagtamano)
            Else
                respsegmancargpaglist.pagsegmancarg.npagcantidad = 0
                respsegmancargpaglist.pagsegmancarg.npagactual = 0
            End If

            Return respsegmancargpaglist
        End Function

        Public Function selsegmancargxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.segmancarg.count
            Else
                Return _db.segmancarg.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
        Public Function inssegmancarg(segmancarg As segmancarg) As respopera
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
                param2.ParameterName = "p_idsegmanusu"

                Dim param3 As New SqlClient.SqlParameter
                param3.SqlDbType = SqlDbType.VarChar
                param3.Size = 20
                param3.Value = "seginsoft"
                param3.ParameterName = "p_xnombrecorto"

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
                param8.ParameterName = "p_idsegmancarg"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 50
                If segmancarg.xnombrecarg IsNot Nothing Then
                    param9.Value = segmancarg.xnombrecarg
                Else
                    param9.Value = ""
                End If
                param9.ParameterName = "p_xnombrecarg"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.SmallInt
                param10.Value = segmancarg.nprioridad
                param10.ParameterName = "p_nprioridad"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = 0
                param11.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmancarg @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmancarg output,@p_xnombrecarg,@p_nprioridad,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11)

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
        Public Function modsegmancarg(segmancarg As segmancarg) As respopera
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
                param2.ParameterName = "p_idsegmanusu"

                Dim param3 As New SqlClient.SqlParameter
                param3.SqlDbType = SqlDbType.VarChar
                param3.Size = 20
                param3.Value = "seginsoft"
                param3.ParameterName = "p_xnombrecorto"

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
                param8.Value = segmancarg.idsegmancarg
                param8.ParameterName = "p_idsegmancarg"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 50
                If segmancarg.xnombrecarg IsNot Nothing Then
                    param9.Value = segmancarg.xnombrecarg
                Else
                    param9.Value = ""
                End If
                param9.ParameterName = "p_xnombrecarg"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.SmallInt
                param10.Value = segmancarg.nprioridad
                param10.ParameterName = "p_nprioridad"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = segmancarg.idseglogreg
                param11.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmancarg @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmancarg output,@p_xnombrecarg,@p_nprioridad,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11)

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
        Public Function elisegmancarg(segmancarg As segmancarg) As respopera
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
                param2.ParameterName = "p_idsegmanusu"

                Dim param3 As New SqlClient.SqlParameter
                param3.SqlDbType = SqlDbType.VarChar
                param3.Size = 20
                param3.Value = "seginsoft"
                param3.ParameterName = "p_xnombrecorto"

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
                param8.Value = segmancarg.idsegmancarg
                param8.ParameterName = "p_idsegmancarg"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 50
                If segmancarg.xnombrecarg IsNot Nothing Then
                    param9.Value = segmancarg.xnombrecarg
                Else
                    param9.Value = ""
                End If
                param9.ParameterName = "p_xnombrecarg"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.SmallInt
                param10.Value = segmancarg.nprioridad
                param10.ParameterName = "p_nprioridad"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = segmancarg.idseglogreg
                param11.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmancarg @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmancarg output,@p_xnombrecarg,@p_nprioridad,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11)

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
        Public Function elisegmancarg(idsegmancarg As Decimal) As respopera
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
                param2.ParameterName = "p_idsegmanusu"

                Dim param3 As New SqlClient.SqlParameter
                param3.SqlDbType = SqlDbType.VarChar
                param3.Size = 20
                param3.Value = "seginsoft"
                param3.ParameterName = "p_xnombrecorto"

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
                param8.Value = idsegmancarg
                param8.ParameterName = "p_idsegmancarg"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 50
                param9.Value = ""
                param9.ParameterName = "p_xnombrecarg"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.SmallInt
                param10.Value = 0
                param10.ParameterName = "p_nprioridad"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = 0
                param11.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmancarg @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmancarg output,@p_xnombrecarg,@p_nprioridad,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11)

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
        Public Function actsegmancarg(segmancarg As segmancarg) As respopera
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
                param2.ParameterName = "p_idsegmanusu"

                Dim param3 As New SqlClient.SqlParameter
                param3.SqlDbType = SqlDbType.VarChar
                param3.Size = 20
                param3.Value = "seginsoft"
                param3.ParameterName = "p_xnombrecorto"

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
                param8.Value = segmancarg.idsegmancarg
                param8.ParameterName = "p_idsegmancarg"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 50
                If segmancarg.xnombrecarg IsNot Nothing Then
                    param9.Value = segmancarg.xnombrecarg
                Else
                    param9.Value = ""
                End If
                param9.ParameterName = "p_xnombrecarg"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.SmallInt
                param10.Value = segmancarg.nprioridad
                param10.ParameterName = "p_nprioridad"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = segmancarg.idseglogreg
                param11.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmancarg @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmancarg output,@p_xnombrecarg,@p_nprioridad,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11)

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
        Public Function dessegmancarg(segmancarg As segmancarg) As respopera
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
                param2.ParameterName = "p_idsegmanusu"

                Dim param3 As New SqlClient.SqlParameter
                param3.SqlDbType = SqlDbType.VarChar
                param3.Size = 20
                param3.Value = "seginsoft"
                param3.ParameterName = "p_xnombrecorto"

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
                param8.Value = segmancarg.idsegmancarg
                param8.ParameterName = "p_idsegmancarg"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 50
                If segmancarg.xnombrecarg IsNot Nothing Then
                    param9.Value = segmancarg.xnombrecarg
                Else
                    param9.Value = ""
                End If
                param9.ParameterName = "p_xnombrecarg"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.SmallInt
                param10.Value = segmancarg.nprioridad
                param10.ParameterName = "p_nprioridad"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = segmancarg.idseglogreg
                param11.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmancarg @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmancarg output,@p_xnombrecarg,@p_nprioridad,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11)

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
