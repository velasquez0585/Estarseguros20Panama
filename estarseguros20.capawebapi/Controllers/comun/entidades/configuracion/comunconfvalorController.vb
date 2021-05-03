Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.configuracion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports System.IO
Imports funciones.lib.directorios

Namespace comun.entidades.controlador
Public Class comunconfvalorController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpGet()> _
        Public Function selcomunconfvalorxid(idcomunconfvalor As Decimal) As comunconfvalor
            Dim comunconfvalor As comunconfvalor = (From p In _db.comunconfvalor
                                            Where p.idcomunconfvalor = idcomunconfvalor
                                            Select p).SingleOrDefault
            Return comunconfvalor
        End Function

        <HttpGet()> _
        Public Function selcomunconfvalor() As List(Of comunconfvalor)
            Dim lista_comunconfvalor As List(Of comunconfvalor) = (From p In _db.comunconfvalor
                                                        Select p).ToList
            '
            Return lista_comunconfvalor
        End Function

        <HttpGet()> _
        Public Function selcomunconfvalorxwheredinamico(objeto As comunconfvalor) As List(Of comunconfvalor)
            Dim sb As New StringBuilder("")
            '
            If objeto.idcomunconfvalor > 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunconfvalor=")
                    sb.Append(objeto.idcomunconfvalor)
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" AND it.idcomunconfvalor=")
                        sb.Append(objeto.idcomunconfvalor)
                        sb.Append("")
                    End If
                End If
            End If
            '
            Dim lista_comunconfvalor As List(Of comunconfvalor)
            If sb.ToString = "" Then
                lista_comunconfvalor = selcomunconfvalor()
            Else
                lista_comunconfvalor = _db.comunconfvalor.Where(sb.ToString).ToList
            End If
            '
            Return lista_comunconfvalor
        End Function

        <HttpPost()> _
        Public Function inscomunconfvalor(comunconfvalor As comunconfvalor) As respopera
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
                param3.Value = "comun"
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
                param8.ParameterName = "p_idcomunconfvalor"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 50
                param9.Value = comunconfvalor.xconcepto
                param9.ParameterName = "p_xconcepto"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 50
                param10.Value = comunconfvalor.xvalorcodigo
                param10.ParameterName = "p_xvalorcodigo"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 50
                param11.Value = comunconfvalor.xvalordescripcion
                param11.ParameterName = "p_xvalordescripcion"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                param12.Value = comunconfvalor.istatusvalor
                param12.ParameterName = "p_istatusvalor"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                param13.Value = 0
                param13.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunconfvalor @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idcomunconfvalor output,@p_xconcepto,@p_xvalorcodigo,@p_xvalordescripcion,@p_istatusvalor,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13)

                Dim respopera As New respopera
                respopera.irespuesta = param4.Value
                respopera.xmsjusuario = param5.Value
                respopera.xmsjtecnico = param6.Value

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        <HttpPut()> _
        Public Function modcomunconfvalor(comunconfvalor As comunconfvalor) As respopera
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
                param3.Value = "comun"
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
                param8.Value = comunconfvalor.idcomunconfvalor
                param8.ParameterName = "p_idcomunconfvalor"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 50
                param9.Value = comunconfvalor.xconcepto
                param9.ParameterName = "p_xconcepto"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 50
                param10.Value = comunconfvalor.xvalorcodigo
                param10.ParameterName = "p_xvalorcodigo"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 50
                param11.Value = comunconfvalor.xvalordescripcion
                param11.ParameterName = "p_xvalordescripcion"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                param12.Value = comunconfvalor.istatusvalor
                param12.ParameterName = "p_istatusvalor"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                param13.Value = comunconfvalor.idseglogreg
                param13.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunconfvalor @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idcomunconfvalor output,@p_xconcepto,@p_xvalorcodigo,@p_xvalordescripcion,@p_istatusvalor,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13)

                Dim respopera As New respopera
                respopera.irespuesta = param4.Value
                respopera.xmsjusuario = param5.Value
                respopera.xmsjtecnico = param6.Value

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        <HttpDelete()> _
        Public Function elicomunconfvalor(comunconfvalor As comunconfvalor) As respopera
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
                param3.Value = "comun"
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
                param8.Value = comunconfvalor.idcomunconfvalor
                param8.ParameterName = "p_idcomunconfvalor"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 50
                param9.Value = comunconfvalor.xconcepto
                param9.ParameterName = "p_xconcepto"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 50
                param10.Value = comunconfvalor.xvalorcodigo
                param10.ParameterName = "p_xvalorcodigo"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 50
                param11.Value = comunconfvalor.xvalordescripcion
                param11.ParameterName = "p_xvalordescripcion"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                param12.Value = comunconfvalor.istatusvalor
                param12.ParameterName = "p_istatusvalor"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                param13.Value = comunconfvalor.idseglogreg
                param13.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunconfvalor @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idcomunconfvalor output,@p_xconcepto,@p_xvalorcodigo,@p_xvalordescripcion,@p_istatusvalor,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13)

                Dim respopera As New respopera
                respopera.irespuesta = param4.Value
                respopera.xmsjusuario = param5.Value
                respopera.xmsjtecnico = param6.Value

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        <HttpDelete()> _
        Public Function elicomunconfvalor(idcomunconfvalor As Decimal) As respopera
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
                param3.Value = "comun"
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

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 50
                param9.Value = ""
                param9.ParameterName = "p_xconcepto"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 50
                param10.Value = ""
                param10.ParameterName = "p_xvalorcodigo"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 50
                param11.Value = ""
                param11.ParameterName = "p_xvalordescripcion"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                param12.Value = ""
                param12.ParameterName = "p_istatusvalor"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                param13.Value = 0
                param13.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunconfvalor @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@id_comunconfvalor  output,@p_xconcepto,@p_xvalorcodigo,@p_xvalordescripcion,@p_istatusvalor,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param7, param9, param10, param11, param12, param13)

                Dim respopera As New respopera
                respopera.irespuesta = param4.Value
                respopera.xmsjusuario = param5.Value
                respopera.xmsjtecnico = param6.Value

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        'funciones no basicas
        <HttpPost()> _
        Public Function selcomunconfvalorxconcepto(xconcepto As String) As List(Of comunconfvalor)
            Dim lista_comunconfvalor As List(Of comunconfvalor) = (From p In _db.comunconfvalor
                                            Where p.xconcepto = xconcepto
                                            Select p).ToList

            'agregar el item vacio para seleccion
            Dim comunconfvalor As New comunconfvalor
            With comunconfvalor
                .idcomunconfvalor = 0
                .idseglogreg = 0
                .istatusvalor = "ACTIVO"
                .xconcepto = xconcepto
                .xvalorcodigo = ""
                .xvalordescripcion = "SELECCIONE..."
            End With
            lista_comunconfvalor.Insert(0, comunconfvalor)

            Return lista_comunconfvalor
        End Function

        <HttpPost()> _
        Public Function selcomunconfvalorxconceptosinsel(xconcepto As String) As List(Of comunconfvalor)
            Dim lista_comunconfvalor As List(Of comunconfvalor) = (From p In _db.comunconfvalor
                                            Where p.xconcepto = xconcepto
                                            Select p).ToList

            Return lista_comunconfvalor
        End Function

        <HttpPost()> _
        Public Function selcomunconfvalorxconceptoYxvalorcodigo(xconcepto As String, xvalorcodigo As String) As comunconfvalor
            Dim comunconfvalor As comunconfvalor = (From p In _db.comunconfvalor
                                            Where p.xconcepto = xconcepto And p.xvalorcodigo = xvalorcodigo
                                            Select p).FirstOrDefault()

            Return comunconfvalor
        End Function

End Class
End Namespace
