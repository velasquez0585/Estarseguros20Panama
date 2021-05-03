Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados

Namespace comun.entidades.controlador
Public Class comunmanemprController
	Inherits ApiController

	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))

        <HttpGet()> _
        Public Function selcomunmanemprxid(idcomunmanempr As Decimal) As comunmanempr
            Dim comunmanempr As comunmanempr = (From p In _db.comunmanempr
                                            Where p.idcomunmanempr = idcomunmanempr
                                            Select p).SingleOrDefault
            Return comunmanempr
        End Function

        '<HttpGet()> _
        'Public Function selcomunmanempr() As List(Of comunmanempr)
        '    Dim lista_comunmanempr As List(Of comunmanempr) = (From p In _db.comunmanempr
        '                                                Select p).ToList
        '    '
        '    Return lista_comunmanempr
        'End Function

        <HttpPost()> _
        Public Function selcomunmanempr() As List(Of comunmanempr)
            Dim lista_comunmanempr As List(Of comunmanempr) = (From p In _db.comunmanempr
                                                        Select p).ToList
            'agregar el item vacio para seleccion
            Dim comunmanempr As New comunmanempr
            With comunmanempr
                .idcomunmanempr = 0
                .xnombrecomercial = "SELECCIONE"
            End With
            lista_comunmanempr.Insert(0, comunmanempr)
            Return lista_comunmanempr
        End Function

        <HttpPost()> _
        Public Function inscomunmanempr(comunmanempr As comunmanempr) As respopera
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
                param8.ParameterName = "p_idcomunmanempr"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 20
                param9.Value = comunmanempr.xrif
                param9.ParameterName = "p_xrif"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 100
                param10.Value = comunmanempr.xrazonsocial
                param10.ParameterName = "p_xrazonsocial"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 100
                param11.Value = comunmanempr.xnombrecomercial
                param11.ParameterName = "p_xnombrecomercial"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmanempr @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idcomunmanempr output,@p_xrif,@p_xrazonsocial,@p_xnombrecomercial", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11)

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
        Public Function modcomunmanempr(comunmanempr As comunmanempr) As respopera
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
                param8.Value = comunmanempr.idcomunmanempr
                param8.ParameterName = "p_idcomunmanempr"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 20
                param9.Value = comunmanempr.xrif
                param9.ParameterName = "p_xrif"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 100
                param10.Value = comunmanempr.xrazonsocial
                param10.ParameterName = "p_xrazonsocial"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 100
                param11.Value = comunmanempr.xnombrecomercial
                param11.ParameterName = "p_xnombrecomercial"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmanempr @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idcomunmanempr output,@p_xrif,@p_xrazonsocial,@p_xnombrecomercial", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11)

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
        Public Function elicomunmanempr(comunmanempr As comunmanempr) As respopera
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
                param8.Value = comunmanempr.idcomunmanempr
                param8.ParameterName = "p_idcomunmanempr"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 20
                param9.Value = comunmanempr.xrif
                param9.ParameterName = "p_xrif"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 100
                param10.Value = comunmanempr.xrazonsocial
                param10.ParameterName = "p_xrazonsocial"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 100
                param11.Value = comunmanempr.xnombrecomercial
                param11.ParameterName = "p_xnombrecomercial"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmanempr @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idcomunmanempr output,@p_xrif,@p_xrazonsocial,@p_xnombrecomercial", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11)

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
        Public Function elicomunmanempr(idcomunmanempr As Decimal) As respopera
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
                param8.Value = idcomunmanempr
                param8.ParameterName = "p_idcomunmanempr"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 20
                param9.Value = ""
                param9.ParameterName = "p_xrif"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 100
                param10.Value = ""
                param10.ParameterName = "p_xrazonsocial"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 100
                param11.Value = ""
                param11.ParameterName = "p_xnombrecomercial"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmanempr @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@id_comunmanempr  output,@p_xrif,@p_xrazonsocial,@p_xnombrecomercial", param1, param2, param3, param4, param5, param6, param7, param7, param9, param10, param11)

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

End Class
End Namespace
