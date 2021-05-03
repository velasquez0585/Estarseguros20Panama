Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados

Namespace comun.entidades.controlador
Public Class comunmanpersController
	Inherits ApiController

	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))

        <HttpGet()> _
        Public Function selcomunmanpersxid(idcomunmanpers As Decimal) As comunmanpers
            Dim comunmanpers As comunmanpers = (From p In _db.comunmanpers
                                            Where p.idcomunmanpers = idcomunmanpers
                                            Select p).SingleOrDefault
            Return comunmanpers
        End Function

        <HttpGet()> _
        Public Function selcomunmanpers() As List(Of comunmanpers)
            Dim lista_comunmanpers As List(Of comunmanpers) = (From p In _db.comunmanpers
                                                        Select p).ToList
            '
            Return lista_comunmanpers
        End Function

        <HttpPost()> _
        Public Function inscomunmanpers(comunmanpers As comunmanpers) As respopera
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
                param8.ParameterName = "p_idcomunmanpers"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 20
                param9.Value = comunmanpers.xcedula
                param9.ParameterName = "p_xcedula"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 50
                param10.Value = comunmanpers.xnombres
                param10.ParameterName = "p_xnombres"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 50
                param11.Value = comunmanpers.xapellidos
                param11.ParameterName = "p_xapellidos"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 100
                param12.Value = comunmanpers.xnombrecompleto
                param12.ParameterName = "p_xnombrecompleto"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.DateTime
                param13.Value = comunmanpers.fnacimiento
                param13.ParameterName = "p_fnacimiento"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = 20
                param14.Value = comunmanpers.xsexo
                param14.ParameterName = "p_xsexo"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 50
                param15.Value = comunmanpers.xnacionalidad
                param15.ParameterName = "p_xnacionalidad"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.VarChar
                param16.Size = 20
                param16.Value = comunmanpers.xestatura
                param16.ParameterName = "p_xestatura"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.VarChar
                param17.Size = 20
                param17.Value = comunmanpers.xmedestatura
                param17.ParameterName = "p_xmedestatura"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 20
                param18.Value = comunmanpers.xpeso
                param18.ParameterName = "p_xpeso"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.VarChar
                param19.Size = 20
                param19.Value = comunmanpers.xmedpeso
                param19.ParameterName = "p_xmedpeso"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmanpers @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idcomunmanpers output,@p_xcedula,@p_xnombres,@p_xapellidos,@p_xnombrecompleto,@p_fnacimiento,@p_xsexo,@p_xnacionalidad,@p_xestatura,@p_xmedestatura,@p_xpeso,@p_xmedpeso", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

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
        Public Function modcomunmanpers(comunmanpers As comunmanpers) As respopera
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
                param8.Value = comunmanpers.idcomunmanpers
                param8.ParameterName = "p_idcomunmanpers"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 20
                param9.Value = comunmanpers.xcedula
                param9.ParameterName = "p_xcedula"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 50
                param10.Value = comunmanpers.xnombres
                param10.ParameterName = "p_xnombres"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 50
                param11.Value = comunmanpers.xapellidos
                param11.ParameterName = "p_xapellidos"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 100
                param12.Value = comunmanpers.xnombrecompleto
                param12.ParameterName = "p_xnombrecompleto"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.DateTime
                param13.Value = comunmanpers.fnacimiento
                param13.ParameterName = "p_fnacimiento"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = 20
                param14.Value = comunmanpers.xsexo
                param14.ParameterName = "p_xsexo"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 50
                param15.Value = comunmanpers.xnacionalidad
                param15.ParameterName = "p_xnacionalidad"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.VarChar
                param16.Size = 20
                param16.Value = comunmanpers.xestatura
                param16.ParameterName = "p_xestatura"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.VarChar
                param17.Size = 20
                param17.Value = comunmanpers.xmedestatura
                param17.ParameterName = "p_xmedestatura"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 20
                param18.Value = comunmanpers.xpeso
                param18.ParameterName = "p_xpeso"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.VarChar
                param19.Size = 20
                param19.Value = comunmanpers.xmedpeso
                param19.ParameterName = "p_xmedpeso"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmanpers @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idcomunmanpers output,@p_xcedula,@p_xnombres,@p_xapellidos,@p_xnombrecompleto,@p_fnacimiento,@p_xsexo,@p_xnacionalidad,@p_xestatura,@p_xmedestatura,@p_xpeso,@p_xmedpeso", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

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
        Public Function elicomunmanpers(comunmanpers As comunmanpers) As respopera
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
                param8.Value = comunmanpers.idcomunmanpers
                param8.ParameterName = "p_idcomunmanpers"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 20
                param9.Value = comunmanpers.xcedula
                param9.ParameterName = "p_xcedula"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 50
                param10.Value = comunmanpers.xnombres
                param10.ParameterName = "p_xnombres"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 50
                param11.Value = comunmanpers.xapellidos
                param11.ParameterName = "p_xapellidos"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 100
                param12.Value = comunmanpers.xnombrecompleto
                param12.ParameterName = "p_xnombrecompleto"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.DateTime
                param13.Value = comunmanpers.fnacimiento
                param13.ParameterName = "p_fnacimiento"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = 20
                param14.Value = comunmanpers.xsexo
                param14.ParameterName = "p_xsexo"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 50
                param15.Value = comunmanpers.xnacionalidad
                param15.ParameterName = "p_xnacionalidad"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.VarChar
                param16.Size = 20
                param16.Value = comunmanpers.xestatura
                param16.ParameterName = "p_xestatura"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.VarChar
                param17.Size = 20
                param17.Value = comunmanpers.xmedestatura
                param17.ParameterName = "p_xmedestatura"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 20
                param18.Value = comunmanpers.xpeso
                param18.ParameterName = "p_xpeso"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.VarChar
                param19.Size = 20
                param19.Value = comunmanpers.xmedpeso
                param19.ParameterName = "p_xmedpeso"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmanpers @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idcomunmanpers output,@p_xcedula,@p_xnombres,@p_xapellidos,@p_xnombrecompleto,@p_fnacimiento,@p_xsexo,@p_xnacionalidad,@p_xestatura,@p_xmedestatura,@p_xpeso,@p_xmedpeso", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

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
        Public Function elicomunmanpers(idcomunmanpers As Decimal) As respopera
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
                param8.Value = idcomunmanpers
                param8.ParameterName = "p_idcomunmanpers"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 20
                param9.Value = ""
                param9.ParameterName = "p_xcedula"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 50
                param10.Value = ""
                param10.ParameterName = "p_xnombres"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 50
                param11.Value = ""
                param11.ParameterName = "p_xapellidos"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 100
                param12.Value = ""
                param12.ParameterName = "p_xnombrecompleto"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.DateTime
                param13.ParameterName = "p_fnacimiento"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = 20
                param14.Value = ""
                param14.ParameterName = "p_xsexo"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 50
                param15.Value = ""
                param15.ParameterName = "p_xnacionalidad"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.VarChar
                param16.Size = 20
                param16.Value = ""
                param16.ParameterName = "p_xestatura"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.VarChar
                param17.Size = 20
                param17.Value = ""
                param17.ParameterName = "p_xmedestatura"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 20
                param18.Value = ""
                param18.ParameterName = "p_xpeso"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.VarChar
                param19.Size = 20
                param19.Value = ""
                param19.ParameterName = "p_xmedpeso"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmanpers @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@id_comunmanpers  output,@p_xcedula,@p_xnombres,@p_xapellidos,@p_xnombrecompleto,@p_fnacimiento,@p_xsexo,@p_xnacionalidad,@p_xestatura,@p_xmedestatura,@p_xpeso,@p_xmedpeso", param1, param2, param3, param4, param5, param6, param7, param7, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19)

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
