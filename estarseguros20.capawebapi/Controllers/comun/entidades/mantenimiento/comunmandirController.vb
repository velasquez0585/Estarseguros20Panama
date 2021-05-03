Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados

Namespace comun.entidades.controlador
Public Class comunmandirController
	Inherits ApiController

	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))

        <HttpGet()> _
        Public Function selcomunmandirxid(idcomunmandir As Decimal) As comunmandir
            Dim comunmandir As comunmandir = (From p In _db.comunmandir
                                            Where p.idcomunmandir = idcomunmandir
                                            Select p).SingleOrDefault
            Return comunmandir
        End Function

        <HttpGet()> _
        Public Function selcomunmandir() As List(Of comunmandir)
            Dim lista_comunmandir As List(Of comunmandir) = (From p In _db.comunmandir
                                                        Select p).ToList
            '
            Return lista_comunmandir
        End Function

        <HttpPost()> _
        Public Function inscomunmandir(comunmandir As comunmandir) As respopera
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
                param8.ParameterName = "p_idcomunmandir"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = comunmandir.idcomunmanlocalid
                param9.ParameterName = "p_idcomunmanlocalid"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = comunmandir.idcomunmanestado
                param10.ParameterName = "p_idcomunmanestado"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = comunmandir.idcomunmanpais
                param11.ParameterName = "p_idcomunmanpais"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = comunmandir.idcomunmancont
                param12.ParameterName = "p_idcomunmancont"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = 500
                param13.Value = comunmandir.xdireccion
                param13.ParameterName = "p_xdireccion"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = comunmandir.idcomunmanlocalid2
                param14.ParameterName = "p_idcomunmanlocalid2"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.Decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = comunmandir.idcomunmanestado2
                param15.ParameterName = "p_idcomunmanestado2"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.Decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = comunmandir.idcomunmanpais2
                param16.ParameterName = "p_idcomunmanpais2"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.Decimal
                param17.Precision = 18
                param17.Scale = 0
                param17.Value = comunmandir.idcomunmancont2
                param17.ParameterName = "p_idcomunmancont2"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 500
                param18.Value = comunmandir.xdireccion2
                param18.ParameterName = "p_xdireccion2"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = comunmandir.idcomunmanlocalid3
                param19.ParameterName = "p_idcomunmanlocalid3"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.Decimal
                param20.Precision = 18
                param20.Scale = 0
                param20.Value = comunmandir.idcomunmanestado3
                param20.ParameterName = "p_idcomunmanestado3"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.Decimal
                param21.Precision = 18
                param21.Scale = 0
                param21.Value = comunmandir.idcomunmanpais3
                param21.ParameterName = "p_idcomunmanpais3"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.Decimal
                param22.Precision = 18
                param22.Scale = 0
                param22.Value = comunmandir.idcomunmancont3
                param22.ParameterName = "p_idcomunmancont3"

                Dim param23 As New SqlClient.SqlParameter
                param23.SqlDbType = SqlDbType.VarChar
                param23.Size = 500
                param23.Value = comunmandir.xdireccion3
                param23.ParameterName = "p_xdireccion3"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.Decimal
                param24.Precision = 18
                param24.Scale = 0
                param24.Value = comunmandir.idcomunmanlocalid4
                param24.ParameterName = "p_idcomunmanlocalid4"

                Dim param25 As New SqlClient.SqlParameter
                param25.SqlDbType = SqlDbType.Decimal
                param25.Precision = 18
                param25.Scale = 0
                param25.Value = comunmandir.idcomunmanestado4
                param25.ParameterName = "p_idcomunmanestado4"

                Dim param26 As New SqlClient.SqlParameter
                param26.SqlDbType = SqlDbType.Decimal
                param26.Precision = 18
                param26.Scale = 0
                param26.Value = comunmandir.idcomunmanpais4
                param26.ParameterName = "p_idcomunmanpais4"

                Dim param27 As New SqlClient.SqlParameter
                param27.SqlDbType = SqlDbType.Decimal
                param27.Precision = 18
                param27.Scale = 0
                param27.Value = comunmandir.idcomunmancont4
                param27.ParameterName = "p_idcomunmancont4"

                Dim param28 As New SqlClient.SqlParameter
                param28.SqlDbType = SqlDbType.VarChar
                param28.Size = 500
                param28.Value = comunmandir.xdireccion4
                param28.ParameterName = "p_xdireccion4"

                Dim param29 As New SqlClient.SqlParameter
                param29.SqlDbType = SqlDbType.Decimal
                param29.Precision = 18
                param29.Scale = 0
                param29.Value = comunmandir.idcomunmanlocalid5
                param29.ParameterName = "p_idcomunmanlocalid5"

                Dim param30 As New SqlClient.SqlParameter
                param30.SqlDbType = SqlDbType.Decimal
                param30.Precision = 18
                param30.Scale = 0
                param30.Value = comunmandir.idcomunmanestado5
                param30.ParameterName = "p_idcomunmanestado5"

                Dim param31 As New SqlClient.SqlParameter
                param31.SqlDbType = SqlDbType.Decimal
                param31.Precision = 18
                param31.Scale = 0
                param31.Value = comunmandir.idcomunmanpais5
                param31.ParameterName = "p_idcomunmanpais5"

                Dim param32 As New SqlClient.SqlParameter
                param32.SqlDbType = SqlDbType.Decimal
                param32.Precision = 18
                param32.Scale = 0
                param32.Value = comunmandir.idcomunmancont5
                param32.ParameterName = "p_idcomunmancont5"

                Dim param33 As New SqlClient.SqlParameter
                param33.SqlDbType = SqlDbType.VarChar
                param33.Size = 500
                param33.Value = comunmandir.xdireccion5
                param33.ParameterName = "p_xdireccion5"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmandir @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idcomunmandir output,@p_idcomunmanlocalid,@p_idcomunmanestado,@p_idcomunmanpais,@p_idcomunmancont,@p_xdireccion,@p_idcomunmanlocalid2,@p_idcomunmanestado2,@p_idcomunmanpais2,@p_idcomunmancont2,@p_xdireccion2,@p_idcomunmanlocalid3,@p_idcomunmanestado3,@p_idcomunmanpais3,@p_idcomunmancont3,@p_xdireccion3,@p_idcomunmanlocalid4,@p_idcomunmanestado4,@p_idcomunmanpais4,@p_idcomunmancont4,@p_xdireccion4,@p_idcomunmanlocalid5,@p_idcomunmanestado5,@p_idcomunmanpais5,@p_idcomunmancont5,@p_xdireccion5", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33)

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
        Public Function modcomunmandir(comunmandir As comunmandir) As respopera
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
                param8.Value = comunmandir.idcomunmandir
                param8.ParameterName = "p_idcomunmandir"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = comunmandir.idcomunmanlocalid
                param9.ParameterName = "p_idcomunmanlocalid"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = comunmandir.idcomunmanestado
                param10.ParameterName = "p_idcomunmanestado"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = comunmandir.idcomunmanpais
                param11.ParameterName = "p_idcomunmanpais"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = comunmandir.idcomunmancont
                param12.ParameterName = "p_idcomunmancont"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = 500
                param13.Value = comunmandir.xdireccion
                param13.ParameterName = "p_xdireccion"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = comunmandir.idcomunmanlocalid2
                param14.ParameterName = "p_idcomunmanlocalid2"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.Decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = comunmandir.idcomunmanestado2
                param15.ParameterName = "p_idcomunmanestado2"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.Decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = comunmandir.idcomunmanpais2
                param16.ParameterName = "p_idcomunmanpais2"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.Decimal
                param17.Precision = 18
                param17.Scale = 0
                param17.Value = comunmandir.idcomunmancont2
                param17.ParameterName = "p_idcomunmancont2"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 500
                param18.Value = comunmandir.xdireccion2
                param18.ParameterName = "p_xdireccion2"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = comunmandir.idcomunmanlocalid3
                param19.ParameterName = "p_idcomunmanlocalid3"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.Decimal
                param20.Precision = 18
                param20.Scale = 0
                param20.Value = comunmandir.idcomunmanestado3
                param20.ParameterName = "p_idcomunmanestado3"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.Decimal
                param21.Precision = 18
                param21.Scale = 0
                param21.Value = comunmandir.idcomunmanpais3
                param21.ParameterName = "p_idcomunmanpais3"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.Decimal
                param22.Precision = 18
                param22.Scale = 0
                param22.Value = comunmandir.idcomunmancont3
                param22.ParameterName = "p_idcomunmancont3"

                Dim param23 As New SqlClient.SqlParameter
                param23.SqlDbType = SqlDbType.VarChar
                param23.Size = 500
                param23.Value = comunmandir.xdireccion3
                param23.ParameterName = "p_xdireccion3"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.Decimal
                param24.Precision = 18
                param24.Scale = 0
                param24.Value = comunmandir.idcomunmanlocalid4
                param24.ParameterName = "p_idcomunmanlocalid4"

                Dim param25 As New SqlClient.SqlParameter
                param25.SqlDbType = SqlDbType.Decimal
                param25.Precision = 18
                param25.Scale = 0
                param25.Value = comunmandir.idcomunmanestado4
                param25.ParameterName = "p_idcomunmanestado4"

                Dim param26 As New SqlClient.SqlParameter
                param26.SqlDbType = SqlDbType.Decimal
                param26.Precision = 18
                param26.Scale = 0
                param26.Value = comunmandir.idcomunmanpais4
                param26.ParameterName = "p_idcomunmanpais4"

                Dim param27 As New SqlClient.SqlParameter
                param27.SqlDbType = SqlDbType.Decimal
                param27.Precision = 18
                param27.Scale = 0
                param27.Value = comunmandir.idcomunmancont4
                param27.ParameterName = "p_idcomunmancont4"

                Dim param28 As New SqlClient.SqlParameter
                param28.SqlDbType = SqlDbType.VarChar
                param28.Size = 500
                param28.Value = comunmandir.xdireccion4
                param28.ParameterName = "p_xdireccion4"

                Dim param29 As New SqlClient.SqlParameter
                param29.SqlDbType = SqlDbType.Decimal
                param29.Precision = 18
                param29.Scale = 0
                param29.Value = comunmandir.idcomunmanlocalid5
                param29.ParameterName = "p_idcomunmanlocalid5"

                Dim param30 As New SqlClient.SqlParameter
                param30.SqlDbType = SqlDbType.Decimal
                param30.Precision = 18
                param30.Scale = 0
                param30.Value = comunmandir.idcomunmanestado5
                param30.ParameterName = "p_idcomunmanestado5"

                Dim param31 As New SqlClient.SqlParameter
                param31.SqlDbType = SqlDbType.Decimal
                param31.Precision = 18
                param31.Scale = 0
                param31.Value = comunmandir.idcomunmanpais5
                param31.ParameterName = "p_idcomunmanpais5"

                Dim param32 As New SqlClient.SqlParameter
                param32.SqlDbType = SqlDbType.Decimal
                param32.Precision = 18
                param32.Scale = 0
                param32.Value = comunmandir.idcomunmancont5
                param32.ParameterName = "p_idcomunmancont5"

                Dim param33 As New SqlClient.SqlParameter
                param33.SqlDbType = SqlDbType.VarChar
                param33.Size = 500
                param33.Value = comunmandir.xdireccion5
                param33.ParameterName = "p_xdireccion5"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmandir @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idcomunmandir output,@p_idcomunmanlocalid,@p_idcomunmanestado,@p_idcomunmanpais,@p_idcomunmancont,@p_xdireccion,@p_idcomunmanlocalid2,@p_idcomunmanestado2,@p_idcomunmanpais2,@p_idcomunmancont2,@p_xdireccion2,@p_idcomunmanlocalid3,@p_idcomunmanestado3,@p_idcomunmanpais3,@p_idcomunmancont3,@p_xdireccion3,@p_idcomunmanlocalid4,@p_idcomunmanestado4,@p_idcomunmanpais4,@p_idcomunmancont4,@p_xdireccion4,@p_idcomunmanlocalid5,@p_idcomunmanestado5,@p_idcomunmanpais5,@p_idcomunmancont5,@p_xdireccion5", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33)

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
        Public Function elicomunmandir(comunmandir As comunmandir) As respopera
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
                param8.Value = comunmandir.idcomunmandir
                param8.ParameterName = "p_idcomunmandir"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = comunmandir.idcomunmanlocalid
                param9.ParameterName = "p_idcomunmanlocalid"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = comunmandir.idcomunmanestado
                param10.ParameterName = "p_idcomunmanestado"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = comunmandir.idcomunmanpais
                param11.ParameterName = "p_idcomunmanpais"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = comunmandir.idcomunmancont
                param12.ParameterName = "p_idcomunmancont"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = 500
                param13.Value = comunmandir.xdireccion
                param13.ParameterName = "p_xdireccion"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = comunmandir.idcomunmanlocalid2
                param14.ParameterName = "p_idcomunmanlocalid2"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.Decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = comunmandir.idcomunmanestado2
                param15.ParameterName = "p_idcomunmanestado2"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.Decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = comunmandir.idcomunmanpais2
                param16.ParameterName = "p_idcomunmanpais2"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.Decimal
                param17.Precision = 18
                param17.Scale = 0
                param17.Value = comunmandir.idcomunmancont2
                param17.ParameterName = "p_idcomunmancont2"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 500
                param18.Value = comunmandir.xdireccion2
                param18.ParameterName = "p_xdireccion2"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = comunmandir.idcomunmanlocalid3
                param19.ParameterName = "p_idcomunmanlocalid3"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.Decimal
                param20.Precision = 18
                param20.Scale = 0
                param20.Value = comunmandir.idcomunmanestado3
                param20.ParameterName = "p_idcomunmanestado3"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.Decimal
                param21.Precision = 18
                param21.Scale = 0
                param21.Value = comunmandir.idcomunmanpais3
                param21.ParameterName = "p_idcomunmanpais3"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.Decimal
                param22.Precision = 18
                param22.Scale = 0
                param22.Value = comunmandir.idcomunmancont3
                param22.ParameterName = "p_idcomunmancont3"

                Dim param23 As New SqlClient.SqlParameter
                param23.SqlDbType = SqlDbType.VarChar
                param23.Size = 500
                param23.Value = comunmandir.xdireccion3
                param23.ParameterName = "p_xdireccion3"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.Decimal
                param24.Precision = 18
                param24.Scale = 0
                param24.Value = comunmandir.idcomunmanlocalid4
                param24.ParameterName = "p_idcomunmanlocalid4"

                Dim param25 As New SqlClient.SqlParameter
                param25.SqlDbType = SqlDbType.Decimal
                param25.Precision = 18
                param25.Scale = 0
                param25.Value = comunmandir.idcomunmanestado4
                param25.ParameterName = "p_idcomunmanestado4"

                Dim param26 As New SqlClient.SqlParameter
                param26.SqlDbType = SqlDbType.Decimal
                param26.Precision = 18
                param26.Scale = 0
                param26.Value = comunmandir.idcomunmanpais4
                param26.ParameterName = "p_idcomunmanpais4"

                Dim param27 As New SqlClient.SqlParameter
                param27.SqlDbType = SqlDbType.Decimal
                param27.Precision = 18
                param27.Scale = 0
                param27.Value = comunmandir.idcomunmancont4
                param27.ParameterName = "p_idcomunmancont4"

                Dim param28 As New SqlClient.SqlParameter
                param28.SqlDbType = SqlDbType.VarChar
                param28.Size = 500
                param28.Value = comunmandir.xdireccion4
                param28.ParameterName = "p_xdireccion4"

                Dim param29 As New SqlClient.SqlParameter
                param29.SqlDbType = SqlDbType.Decimal
                param29.Precision = 18
                param29.Scale = 0
                param29.Value = comunmandir.idcomunmanlocalid5
                param29.ParameterName = "p_idcomunmanlocalid5"

                Dim param30 As New SqlClient.SqlParameter
                param30.SqlDbType = SqlDbType.Decimal
                param30.Precision = 18
                param30.Scale = 0
                param30.Value = comunmandir.idcomunmanestado5
                param30.ParameterName = "p_idcomunmanestado5"

                Dim param31 As New SqlClient.SqlParameter
                param31.SqlDbType = SqlDbType.Decimal
                param31.Precision = 18
                param31.Scale = 0
                param31.Value = comunmandir.idcomunmanpais5
                param31.ParameterName = "p_idcomunmanpais5"

                Dim param32 As New SqlClient.SqlParameter
                param32.SqlDbType = SqlDbType.Decimal
                param32.Precision = 18
                param32.Scale = 0
                param32.Value = comunmandir.idcomunmancont5
                param32.ParameterName = "p_idcomunmancont5"

                Dim param33 As New SqlClient.SqlParameter
                param33.SqlDbType = SqlDbType.VarChar
                param33.Size = 500
                param33.Value = comunmandir.xdireccion5
                param33.ParameterName = "p_xdireccion5"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmandir @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idcomunmandir output,@p_idcomunmanlocalid,@p_idcomunmanestado,@p_idcomunmanpais,@p_idcomunmancont,@p_xdireccion,@p_idcomunmanlocalid2,@p_idcomunmanestado2,@p_idcomunmanpais2,@p_idcomunmancont2,@p_xdireccion2,@p_idcomunmanlocalid3,@p_idcomunmanestado3,@p_idcomunmanpais3,@p_idcomunmancont3,@p_xdireccion3,@p_idcomunmanlocalid4,@p_idcomunmanestado4,@p_idcomunmanpais4,@p_idcomunmancont4,@p_xdireccion4,@p_idcomunmanlocalid5,@p_idcomunmanestado5,@p_idcomunmanpais5,@p_idcomunmancont5,@p_xdireccion5", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33)

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
        Public Function elicomunmandir(idcomunmandir As Decimal) As respopera
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
                param8.Value = idcomunmandir
                param8.ParameterName = "p_idcomunmandir"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = 0
                param9.ParameterName = "p_idcomunmanlocalid"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = 0
                param10.ParameterName = "p_idcomunmanestado"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = 0
                param11.ParameterName = "p_idcomunmanpais"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = 0
                param12.ParameterName = "p_idcomunmancont"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = 500
                param13.Value = ""
                param13.ParameterName = "p_xdireccion"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = 0
                param14.ParameterName = "p_idcomunmanlocalid2"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.Decimal
                param15.Precision = 18
                param15.Scale = 0
                param15.Value = 0
                param15.ParameterName = "p_idcomunmanestado2"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.Decimal
                param16.Precision = 18
                param16.Scale = 0
                param16.Value = 0
                param16.ParameterName = "p_idcomunmanpais2"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.Decimal
                param17.Precision = 18
                param17.Scale = 0
                param17.Value = 0
                param17.ParameterName = "p_idcomunmancont2"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 500
                param18.Value = ""
                param18.ParameterName = "p_xdireccion2"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.Decimal
                param19.Precision = 18
                param19.Scale = 0
                param19.Value = 0
                param19.ParameterName = "p_idcomunmanlocalid3"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.Decimal
                param20.Precision = 18
                param20.Scale = 0
                param20.Value = 0
                param20.ParameterName = "p_idcomunmanestado3"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.Decimal
                param21.Precision = 18
                param21.Scale = 0
                param21.Value = 0
                param21.ParameterName = "p_idcomunmanpais3"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.Decimal
                param22.Precision = 18
                param22.Scale = 0
                param22.Value = 0
                param22.ParameterName = "p_idcomunmancont3"

                Dim param23 As New SqlClient.SqlParameter
                param23.SqlDbType = SqlDbType.VarChar
                param23.Size = 500
                param23.Value = ""
                param23.ParameterName = "p_xdireccion3"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.Decimal
                param24.Precision = 18
                param24.Scale = 0
                param24.Value = 0
                param24.ParameterName = "p_idcomunmanlocalid4"

                Dim param25 As New SqlClient.SqlParameter
                param25.SqlDbType = SqlDbType.Decimal
                param25.Precision = 18
                param25.Scale = 0
                param25.Value = 0
                param25.ParameterName = "p_idcomunmanestado4"

                Dim param26 As New SqlClient.SqlParameter
                param26.SqlDbType = SqlDbType.Decimal
                param26.Precision = 18
                param26.Scale = 0
                param26.Value = 0
                param26.ParameterName = "p_idcomunmanpais4"

                Dim param27 As New SqlClient.SqlParameter
                param27.SqlDbType = SqlDbType.Decimal
                param27.Precision = 18
                param27.Scale = 0
                param27.Value = 0
                param27.ParameterName = "p_idcomunmancont4"

                Dim param28 As New SqlClient.SqlParameter
                param28.SqlDbType = SqlDbType.VarChar
                param28.Size = 500
                param28.Value = ""
                param28.ParameterName = "p_xdireccion4"

                Dim param29 As New SqlClient.SqlParameter
                param29.SqlDbType = SqlDbType.Decimal
                param29.Precision = 18
                param29.Scale = 0
                param29.Value = 0
                param29.ParameterName = "p_idcomunmanlocalid5"

                Dim param30 As New SqlClient.SqlParameter
                param30.SqlDbType = SqlDbType.Decimal
                param30.Precision = 18
                param30.Scale = 0
                param30.Value = 0
                param30.ParameterName = "p_idcomunmanestado5"

                Dim param31 As New SqlClient.SqlParameter
                param31.SqlDbType = SqlDbType.Decimal
                param31.Precision = 18
                param31.Scale = 0
                param31.Value = 0
                param31.ParameterName = "p_idcomunmanpais5"

                Dim param32 As New SqlClient.SqlParameter
                param32.SqlDbType = SqlDbType.Decimal
                param32.Precision = 18
                param32.Scale = 0
                param32.Value = 0
                param32.ParameterName = "p_idcomunmancont5"

                Dim param33 As New SqlClient.SqlParameter
                param33.SqlDbType = SqlDbType.VarChar
                param33.Size = 500
                param33.Value = ""
                param33.ParameterName = "p_xdireccion5"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmandir @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@id_comunmandir  output,@p_idcomunmanlocalid,@p_idcomunmanestado,@p_idcomunmanpais,@p_idcomunmancont,@p_xdireccion,@p_idcomunmanlocalid2,@p_idcomunmanestado2,@p_idcomunmanpais2,@p_idcomunmancont2,@p_xdireccion2,@p_idcomunmanlocalid3,@p_idcomunmanestado3,@p_idcomunmanpais3,@p_idcomunmancont3,@p_xdireccion3,@p_idcomunmanlocalid4,@p_idcomunmanestado4,@p_idcomunmanpais4,@p_idcomunmancont4,@p_xdireccion4,@p_idcomunmanlocalid5,@p_idcomunmanestado5,@p_idcomunmanpais5,@p_idcomunmancont5,@p_xdireccion5", param1, param2, param3, param4, param5, param6, param7, param7, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33)

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
