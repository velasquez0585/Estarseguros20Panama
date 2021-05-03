Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados

Namespace comun.entidades.controlador
Public Class comunmancomController
	Inherits ApiController

	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))

        <HttpGet()> _
        Public Function selcomunmancomxid(idcomunmancom As Decimal) As comunmancom
            Dim comunmancom As comunmancom = (From p In _db.comunmancom
                                            Where p.idcomunmancom = idcomunmancom
                                            Select p).SingleOrDefault
            Return comunmancom
        End Function

        <HttpGet()> _
        Public Function selcomunmancom() As List(Of comunmancom)
            Dim lista_comunmancom As List(Of comunmancom) = (From p In _db.comunmancom
                                                        Select p).ToList
            '
            Return lista_comunmancom
        End Function

        <HttpPost()> _
        Public Function inscomunmancom(comunmancom As comunmancom) As respopera
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
                param8.ParameterName = "p_idcomunmancom"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 20
                param9.Value = comunmancom.xtelfhabitacion1
                param9.ParameterName = "p_xtelfhabitacion1"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 20
                param10.Value = comunmancom.xtelfhabitacion2
                param10.ParameterName = "p_xtelfhabitacion2"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 20
                param11.Value = comunmancom.xtelfhabitacion3
                param11.ParameterName = "p_xtelfhabitacion3"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                param12.Value = comunmancom.xtelfhabitacion4
                param12.ParameterName = "p_xtelfhabitacion4"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = 20
                param13.Value = comunmancom.xtelfhabitacion5
                param13.ParameterName = "p_xtelfhabitacion5"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = 20
                param14.Value = comunmancom.xtelfmovil1
                param14.ParameterName = "p_xtelfmovil1"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 20
                param15.Value = comunmancom.xtelfmovil2
                param15.ParameterName = "p_xtelfmovil2"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.VarChar
                param16.Size = 20
                param16.Value = comunmancom.xtelfmovil3
                param16.ParameterName = "p_xtelfmovil3"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.VarChar
                param17.Size = 20
                param17.Value = comunmancom.xtelfmovil4
                param17.ParameterName = "p_xtelfmovil4"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 20
                param18.Value = comunmancom.xtelfmovil5
                param18.ParameterName = "p_xtelfmovil5"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.VarChar
                param19.Size = 20
                param19.Value = comunmancom.xtelfoficina1
                param19.ParameterName = "p_xtelfoficina1"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.VarChar
                param20.Size = 20
                param20.Value = comunmancom.xtelfoficina2
                param20.ParameterName = "p_xtelfoficina2"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.VarChar
                param21.Size = 20
                param21.Value = comunmancom.xtelfoficina3
                param21.ParameterName = "p_xtelfoficina3"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.VarChar
                param22.Size = 20
                param22.Value = comunmancom.xtelfoficina4
                param22.ParameterName = "p_xtelfoficina4"

                Dim param23 As New SqlClient.SqlParameter
                param23.SqlDbType = SqlDbType.VarChar
                param23.Size = 20
                param23.Value = comunmancom.xtelfoficina5
                param23.ParameterName = "p_xtelfoficina5"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.VarChar
                param24.Size = 20
                param24.Value = comunmancom.xtelffax1
                param24.ParameterName = "p_xtelffax1"

                Dim param25 As New SqlClient.SqlParameter
                param25.SqlDbType = SqlDbType.VarChar
                param25.Size = 20
                param25.Value = comunmancom.xtelffax2
                param25.ParameterName = "p_xtelffax2"

                Dim param26 As New SqlClient.SqlParameter
                param26.SqlDbType = SqlDbType.VarChar
                param26.Size = 20
                param26.Value = comunmancom.xtelffax3
                param26.ParameterName = "p_xtelffax3"

                Dim param27 As New SqlClient.SqlParameter
                param27.SqlDbType = SqlDbType.VarChar
                param27.Size = 20
                param27.Value = comunmancom.xtelffax4
                param27.ParameterName = "p_xtelffax4"

                Dim param28 As New SqlClient.SqlParameter
                param28.SqlDbType = SqlDbType.VarChar
                param28.Size = 20
                param28.Value = comunmancom.xtelffax5
                param28.ParameterName = "p_xtelffax5"

                Dim param29 As New SqlClient.SqlParameter
                param29.SqlDbType = SqlDbType.VarChar
                param29.Size = 50
                param29.Value = comunmancom.xcorreoelectronico1
                param29.ParameterName = "p_xcorreoelectronico1"

                Dim param30 As New SqlClient.SqlParameter
                param30.SqlDbType = SqlDbType.VarChar
                param30.Size = 50
                param30.Value = comunmancom.xcorreoelectronico2
                param30.ParameterName = "p_xcorreoelectronico2"

                Dim param31 As New SqlClient.SqlParameter
                param31.SqlDbType = SqlDbType.VarChar
                param31.Size = 50
                param31.Value = comunmancom.xcorreoelectronico3
                param31.ParameterName = "p_xcorreoelectronico3"

                Dim param32 As New SqlClient.SqlParameter
                param32.SqlDbType = SqlDbType.VarChar
                param32.Size = 50
                param32.Value = comunmancom.xcorreoelectronico4
                param32.ParameterName = "p_xcorreoelectronico4"

                Dim param33 As New SqlClient.SqlParameter
                param33.SqlDbType = SqlDbType.VarChar
                param33.Size = 50
                param33.Value = comunmancom.xcorreoelectronico5
                param33.ParameterName = "p_xcorreoelectronico5"

                Dim param34 As New SqlClient.SqlParameter
                param34.SqlDbType = SqlDbType.VarChar
                param34.Size = 50
                param34.Value = comunmancom.xdireccionweb1
                param34.ParameterName = "p_xdireccionweb1"

                Dim param35 As New SqlClient.SqlParameter
                param35.SqlDbType = SqlDbType.VarChar
                param35.Size = 50
                param35.Value = comunmancom.xdireccionweb2
                param35.ParameterName = "p_xdireccionweb2"

                Dim param36 As New SqlClient.SqlParameter
                param36.SqlDbType = SqlDbType.VarChar
                param36.Size = 50
                param36.Value = comunmancom.xdireccionweb3
                param36.ParameterName = "p_xdireccionweb3"

                Dim param37 As New SqlClient.SqlParameter
                param37.SqlDbType = SqlDbType.VarChar
                param37.Size = 50
                param37.Value = comunmancom.xdireccionweb4
                param37.ParameterName = "p_xdireccionweb4"

                Dim param38 As New SqlClient.SqlParameter
                param38.SqlDbType = SqlDbType.VarChar
                param38.Size = 50
                param38.Value = comunmancom.xdireccionweb5
                param38.ParameterName = "p_xdireccionweb5"

                Dim param39 As New SqlClient.SqlParameter
                param39.SqlDbType = SqlDbType.VarChar
                param39.Size = 200
                param39.Value = comunmancom.xtwitter1
                param39.ParameterName = "p_xtwitter1"

                Dim param40 As New SqlClient.SqlParameter
                param40.SqlDbType = SqlDbType.VarChar
                param40.Size = 200
                param40.Value = comunmancom.xtwitter2
                param40.ParameterName = "p_xtwitter2"

                Dim param41 As New SqlClient.SqlParameter
                param41.SqlDbType = SqlDbType.VarChar
                param41.Size = 200
                param41.Value = comunmancom.xtwitter3
                param41.ParameterName = "p_xtwitter3"

                Dim param42 As New SqlClient.SqlParameter
                param42.SqlDbType = SqlDbType.VarChar
                param42.Size = 200
                param42.Value = comunmancom.xtwitter4
                param42.ParameterName = "p_xtwitter4"

                Dim param43 As New SqlClient.SqlParameter
                param43.SqlDbType = SqlDbType.VarChar
                param43.Size = 200
                param43.Value = comunmancom.xtwitter5
                param43.ParameterName = "p_xtwitter5"

                Dim param44 As New SqlClient.SqlParameter
                param44.SqlDbType = SqlDbType.VarChar
                param44.Size = 200
                param44.Value = comunmancom.xfacebook1
                param44.ParameterName = "p_xfacebook1"

                Dim param45 As New SqlClient.SqlParameter
                param45.SqlDbType = SqlDbType.VarChar
                param45.Size = 200
                param45.Value = comunmancom.xfacebook2
                param45.ParameterName = "p_xfacebook2"

                Dim param46 As New SqlClient.SqlParameter
                param46.SqlDbType = SqlDbType.VarChar
                param46.Size = 200
                param46.Value = comunmancom.xfacebook3
                param46.ParameterName = "p_xfacebook3"

                Dim param47 As New SqlClient.SqlParameter
                param47.SqlDbType = SqlDbType.VarChar
                param47.Size = 200
                param47.Value = comunmancom.xfacebook4
                param47.ParameterName = "p_xfacebook4"

                Dim param48 As New SqlClient.SqlParameter
                param48.SqlDbType = SqlDbType.VarChar
                param48.Size = 200
                param48.Value = comunmancom.xfacebook5
                param48.ParameterName = "p_xfacebook5"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmancom @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idcomunmancom output,@p_xtelfhabitacion1,@p_xtelfhabitacion2,@p_xtelfhabitacion3,@p_xtelfhabitacion4,@p_xtelfhabitacion5,@p_xtelfmovil1,@p_xtelfmovil2,@p_xtelfmovil3,@p_xtelfmovil4,@p_xtelfmovil5,@p_xtelfoficina1,@p_xtelfoficina2,@p_xtelfoficina3,@p_xtelfoficina4,@p_xtelfoficina5,@p_xtelffax1,@p_xtelffax2,@p_xtelffax3,@p_xtelffax4,@p_xtelffax5,@p_xcorreoelectronico1,@p_xcorreoelectronico2,@p_xcorreoelectronico3,@p_xcorreoelectronico4,@p_xcorreoelectronico5,@p_xdireccionweb1,@p_xdireccionweb2,@p_xdireccionweb3,@p_xdireccionweb4,@p_xdireccionweb5,@p_xtwitter1,@p_xtwitter2,@p_xtwitter3,@p_xtwitter4,@p_xtwitter5,@p_xfacebook1,@p_xfacebook2,@p_xfacebook3,@p_xfacebook4,@p_xfacebook5", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40, param41, param42, param43, param44, param45, param46, param47, param48)

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
        Public Function modcomunmancom(comunmancom As comunmancom) As respopera
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
                param8.Value = comunmancom.idcomunmancom
                param8.ParameterName = "p_idcomunmancom"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 20
                param9.Value = comunmancom.xtelfhabitacion1
                param9.ParameterName = "p_xtelfhabitacion1"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 20
                param10.Value = comunmancom.xtelfhabitacion2
                param10.ParameterName = "p_xtelfhabitacion2"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 20
                param11.Value = comunmancom.xtelfhabitacion3
                param11.ParameterName = "p_xtelfhabitacion3"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                param12.Value = comunmancom.xtelfhabitacion4
                param12.ParameterName = "p_xtelfhabitacion4"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = 20
                param13.Value = comunmancom.xtelfhabitacion5
                param13.ParameterName = "p_xtelfhabitacion5"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = 20
                param14.Value = comunmancom.xtelfmovil1
                param14.ParameterName = "p_xtelfmovil1"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 20
                param15.Value = comunmancom.xtelfmovil2
                param15.ParameterName = "p_xtelfmovil2"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.VarChar
                param16.Size = 20
                param16.Value = comunmancom.xtelfmovil3
                param16.ParameterName = "p_xtelfmovil3"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.VarChar
                param17.Size = 20
                param17.Value = comunmancom.xtelfmovil4
                param17.ParameterName = "p_xtelfmovil4"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 20
                param18.Value = comunmancom.xtelfmovil5
                param18.ParameterName = "p_xtelfmovil5"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.VarChar
                param19.Size = 20
                param19.Value = comunmancom.xtelfoficina1
                param19.ParameterName = "p_xtelfoficina1"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.VarChar
                param20.Size = 20
                param20.Value = comunmancom.xtelfoficina2
                param20.ParameterName = "p_xtelfoficina2"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.VarChar
                param21.Size = 20
                param21.Value = comunmancom.xtelfoficina3
                param21.ParameterName = "p_xtelfoficina3"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.VarChar
                param22.Size = 20
                param22.Value = comunmancom.xtelfoficina4
                param22.ParameterName = "p_xtelfoficina4"

                Dim param23 As New SqlClient.SqlParameter
                param23.SqlDbType = SqlDbType.VarChar
                param23.Size = 20
                param23.Value = comunmancom.xtelfoficina5
                param23.ParameterName = "p_xtelfoficina5"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.VarChar
                param24.Size = 20
                param24.Value = comunmancom.xtelffax1
                param24.ParameterName = "p_xtelffax1"

                Dim param25 As New SqlClient.SqlParameter
                param25.SqlDbType = SqlDbType.VarChar
                param25.Size = 20
                param25.Value = comunmancom.xtelffax2
                param25.ParameterName = "p_xtelffax2"

                Dim param26 As New SqlClient.SqlParameter
                param26.SqlDbType = SqlDbType.VarChar
                param26.Size = 20
                param26.Value = comunmancom.xtelffax3
                param26.ParameterName = "p_xtelffax3"

                Dim param27 As New SqlClient.SqlParameter
                param27.SqlDbType = SqlDbType.VarChar
                param27.Size = 20
                param27.Value = comunmancom.xtelffax4
                param27.ParameterName = "p_xtelffax4"

                Dim param28 As New SqlClient.SqlParameter
                param28.SqlDbType = SqlDbType.VarChar
                param28.Size = 20
                param28.Value = comunmancom.xtelffax5
                param28.ParameterName = "p_xtelffax5"

                Dim param29 As New SqlClient.SqlParameter
                param29.SqlDbType = SqlDbType.VarChar
                param29.Size = 50
                param29.Value = comunmancom.xcorreoelectronico1
                param29.ParameterName = "p_xcorreoelectronico1"

                Dim param30 As New SqlClient.SqlParameter
                param30.SqlDbType = SqlDbType.VarChar
                param30.Size = 50
                param30.Value = comunmancom.xcorreoelectronico2
                param30.ParameterName = "p_xcorreoelectronico2"

                Dim param31 As New SqlClient.SqlParameter
                param31.SqlDbType = SqlDbType.VarChar
                param31.Size = 50
                param31.Value = comunmancom.xcorreoelectronico3
                param31.ParameterName = "p_xcorreoelectronico3"

                Dim param32 As New SqlClient.SqlParameter
                param32.SqlDbType = SqlDbType.VarChar
                param32.Size = 50
                param32.Value = comunmancom.xcorreoelectronico4
                param32.ParameterName = "p_xcorreoelectronico4"

                Dim param33 As New SqlClient.SqlParameter
                param33.SqlDbType = SqlDbType.VarChar
                param33.Size = 50
                param33.Value = comunmancom.xcorreoelectronico5
                param33.ParameterName = "p_xcorreoelectronico5"

                Dim param34 As New SqlClient.SqlParameter
                param34.SqlDbType = SqlDbType.VarChar
                param34.Size = 50
                param34.Value = comunmancom.xdireccionweb1
                param34.ParameterName = "p_xdireccionweb1"

                Dim param35 As New SqlClient.SqlParameter
                param35.SqlDbType = SqlDbType.VarChar
                param35.Size = 50
                param35.Value = comunmancom.xdireccionweb2
                param35.ParameterName = "p_xdireccionweb2"

                Dim param36 As New SqlClient.SqlParameter
                param36.SqlDbType = SqlDbType.VarChar
                param36.Size = 50
                param36.Value = comunmancom.xdireccionweb3
                param36.ParameterName = "p_xdireccionweb3"

                Dim param37 As New SqlClient.SqlParameter
                param37.SqlDbType = SqlDbType.VarChar
                param37.Size = 50
                param37.Value = comunmancom.xdireccionweb4
                param37.ParameterName = "p_xdireccionweb4"

                Dim param38 As New SqlClient.SqlParameter
                param38.SqlDbType = SqlDbType.VarChar
                param38.Size = 50
                param38.Value = comunmancom.xdireccionweb5
                param38.ParameterName = "p_xdireccionweb5"

                Dim param39 As New SqlClient.SqlParameter
                param39.SqlDbType = SqlDbType.VarChar
                param39.Size = 200
                param39.Value = comunmancom.xtwitter1
                param39.ParameterName = "p_xtwitter1"

                Dim param40 As New SqlClient.SqlParameter
                param40.SqlDbType = SqlDbType.VarChar
                param40.Size = 200
                param40.Value = comunmancom.xtwitter2
                param40.ParameterName = "p_xtwitter2"

                Dim param41 As New SqlClient.SqlParameter
                param41.SqlDbType = SqlDbType.VarChar
                param41.Size = 200
                param41.Value = comunmancom.xtwitter3
                param41.ParameterName = "p_xtwitter3"

                Dim param42 As New SqlClient.SqlParameter
                param42.SqlDbType = SqlDbType.VarChar
                param42.Size = 200
                param42.Value = comunmancom.xtwitter4
                param42.ParameterName = "p_xtwitter4"

                Dim param43 As New SqlClient.SqlParameter
                param43.SqlDbType = SqlDbType.VarChar
                param43.Size = 200
                param43.Value = comunmancom.xtwitter5
                param43.ParameterName = "p_xtwitter5"

                Dim param44 As New SqlClient.SqlParameter
                param44.SqlDbType = SqlDbType.VarChar
                param44.Size = 200
                param44.Value = comunmancom.xfacebook1
                param44.ParameterName = "p_xfacebook1"

                Dim param45 As New SqlClient.SqlParameter
                param45.SqlDbType = SqlDbType.VarChar
                param45.Size = 200
                param45.Value = comunmancom.xfacebook2
                param45.ParameterName = "p_xfacebook2"

                Dim param46 As New SqlClient.SqlParameter
                param46.SqlDbType = SqlDbType.VarChar
                param46.Size = 200
                param46.Value = comunmancom.xfacebook3
                param46.ParameterName = "p_xfacebook3"

                Dim param47 As New SqlClient.SqlParameter
                param47.SqlDbType = SqlDbType.VarChar
                param47.Size = 200
                param47.Value = comunmancom.xfacebook4
                param47.ParameterName = "p_xfacebook4"

                Dim param48 As New SqlClient.SqlParameter
                param48.SqlDbType = SqlDbType.VarChar
                param48.Size = 200
                param48.Value = comunmancom.xfacebook5
                param48.ParameterName = "p_xfacebook5"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmancom @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idcomunmancom output,@p_xtelfhabitacion1,@p_xtelfhabitacion2,@p_xtelfhabitacion3,@p_xtelfhabitacion4,@p_xtelfhabitacion5,@p_xtelfmovil1,@p_xtelfmovil2,@p_xtelfmovil3,@p_xtelfmovil4,@p_xtelfmovil5,@p_xtelfoficina1,@p_xtelfoficina2,@p_xtelfoficina3,@p_xtelfoficina4,@p_xtelfoficina5,@p_xtelffax1,@p_xtelffax2,@p_xtelffax3,@p_xtelffax4,@p_xtelffax5,@p_xcorreoelectronico1,@p_xcorreoelectronico2,@p_xcorreoelectronico3,@p_xcorreoelectronico4,@p_xcorreoelectronico5,@p_xdireccionweb1,@p_xdireccionweb2,@p_xdireccionweb3,@p_xdireccionweb4,@p_xdireccionweb5,@p_xtwitter1,@p_xtwitter2,@p_xtwitter3,@p_xtwitter4,@p_xtwitter5,@p_xfacebook1,@p_xfacebook2,@p_xfacebook3,@p_xfacebook4,@p_xfacebook5", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40, param41, param42, param43, param44, param45, param46, param47, param48)

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
        Public Function elicomunmancom(comunmancom As comunmancom) As respopera
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
                param8.Value = comunmancom.idcomunmancom
                param8.ParameterName = "p_idcomunmancom"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 20
                param9.Value = comunmancom.xtelfhabitacion1
                param9.ParameterName = "p_xtelfhabitacion1"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 20
                param10.Value = comunmancom.xtelfhabitacion2
                param10.ParameterName = "p_xtelfhabitacion2"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 20
                param11.Value = comunmancom.xtelfhabitacion3
                param11.ParameterName = "p_xtelfhabitacion3"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                param12.Value = comunmancom.xtelfhabitacion4
                param12.ParameterName = "p_xtelfhabitacion4"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = 20
                param13.Value = comunmancom.xtelfhabitacion5
                param13.ParameterName = "p_xtelfhabitacion5"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = 20
                param14.Value = comunmancom.xtelfmovil1
                param14.ParameterName = "p_xtelfmovil1"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 20
                param15.Value = comunmancom.xtelfmovil2
                param15.ParameterName = "p_xtelfmovil2"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.VarChar
                param16.Size = 20
                param16.Value = comunmancom.xtelfmovil3
                param16.ParameterName = "p_xtelfmovil3"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.VarChar
                param17.Size = 20
                param17.Value = comunmancom.xtelfmovil4
                param17.ParameterName = "p_xtelfmovil4"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 20
                param18.Value = comunmancom.xtelfmovil5
                param18.ParameterName = "p_xtelfmovil5"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.VarChar
                param19.Size = 20
                param19.Value = comunmancom.xtelfoficina1
                param19.ParameterName = "p_xtelfoficina1"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.VarChar
                param20.Size = 20
                param20.Value = comunmancom.xtelfoficina2
                param20.ParameterName = "p_xtelfoficina2"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.VarChar
                param21.Size = 20
                param21.Value = comunmancom.xtelfoficina3
                param21.ParameterName = "p_xtelfoficina3"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.VarChar
                param22.Size = 20
                param22.Value = comunmancom.xtelfoficina4
                param22.ParameterName = "p_xtelfoficina4"

                Dim param23 As New SqlClient.SqlParameter
                param23.SqlDbType = SqlDbType.VarChar
                param23.Size = 20
                param23.Value = comunmancom.xtelfoficina5
                param23.ParameterName = "p_xtelfoficina5"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.VarChar
                param24.Size = 20
                param24.Value = comunmancom.xtelffax1
                param24.ParameterName = "p_xtelffax1"

                Dim param25 As New SqlClient.SqlParameter
                param25.SqlDbType = SqlDbType.VarChar
                param25.Size = 20
                param25.Value = comunmancom.xtelffax2
                param25.ParameterName = "p_xtelffax2"

                Dim param26 As New SqlClient.SqlParameter
                param26.SqlDbType = SqlDbType.VarChar
                param26.Size = 20
                param26.Value = comunmancom.xtelffax3
                param26.ParameterName = "p_xtelffax3"

                Dim param27 As New SqlClient.SqlParameter
                param27.SqlDbType = SqlDbType.VarChar
                param27.Size = 20
                param27.Value = comunmancom.xtelffax4
                param27.ParameterName = "p_xtelffax4"

                Dim param28 As New SqlClient.SqlParameter
                param28.SqlDbType = SqlDbType.VarChar
                param28.Size = 20
                param28.Value = comunmancom.xtelffax5
                param28.ParameterName = "p_xtelffax5"

                Dim param29 As New SqlClient.SqlParameter
                param29.SqlDbType = SqlDbType.VarChar
                param29.Size = 50
                param29.Value = comunmancom.xcorreoelectronico1
                param29.ParameterName = "p_xcorreoelectronico1"

                Dim param30 As New SqlClient.SqlParameter
                param30.SqlDbType = SqlDbType.VarChar
                param30.Size = 50
                param30.Value = comunmancom.xcorreoelectronico2
                param30.ParameterName = "p_xcorreoelectronico2"

                Dim param31 As New SqlClient.SqlParameter
                param31.SqlDbType = SqlDbType.VarChar
                param31.Size = 50
                param31.Value = comunmancom.xcorreoelectronico3
                param31.ParameterName = "p_xcorreoelectronico3"

                Dim param32 As New SqlClient.SqlParameter
                param32.SqlDbType = SqlDbType.VarChar
                param32.Size = 50
                param32.Value = comunmancom.xcorreoelectronico4
                param32.ParameterName = "p_xcorreoelectronico4"

                Dim param33 As New SqlClient.SqlParameter
                param33.SqlDbType = SqlDbType.VarChar
                param33.Size = 50
                param33.Value = comunmancom.xcorreoelectronico5
                param33.ParameterName = "p_xcorreoelectronico5"

                Dim param34 As New SqlClient.SqlParameter
                param34.SqlDbType = SqlDbType.VarChar
                param34.Size = 50
                param34.Value = comunmancom.xdireccionweb1
                param34.ParameterName = "p_xdireccionweb1"

                Dim param35 As New SqlClient.SqlParameter
                param35.SqlDbType = SqlDbType.VarChar
                param35.Size = 50
                param35.Value = comunmancom.xdireccionweb2
                param35.ParameterName = "p_xdireccionweb2"

                Dim param36 As New SqlClient.SqlParameter
                param36.SqlDbType = SqlDbType.VarChar
                param36.Size = 50
                param36.Value = comunmancom.xdireccionweb3
                param36.ParameterName = "p_xdireccionweb3"

                Dim param37 As New SqlClient.SqlParameter
                param37.SqlDbType = SqlDbType.VarChar
                param37.Size = 50
                param37.Value = comunmancom.xdireccionweb4
                param37.ParameterName = "p_xdireccionweb4"

                Dim param38 As New SqlClient.SqlParameter
                param38.SqlDbType = SqlDbType.VarChar
                param38.Size = 50
                param38.Value = comunmancom.xdireccionweb5
                param38.ParameterName = "p_xdireccionweb5"

                Dim param39 As New SqlClient.SqlParameter
                param39.SqlDbType = SqlDbType.VarChar
                param39.Size = 200
                param39.Value = comunmancom.xtwitter1
                param39.ParameterName = "p_xtwitter1"

                Dim param40 As New SqlClient.SqlParameter
                param40.SqlDbType = SqlDbType.VarChar
                param40.Size = 200
                param40.Value = comunmancom.xtwitter2
                param40.ParameterName = "p_xtwitter2"

                Dim param41 As New SqlClient.SqlParameter
                param41.SqlDbType = SqlDbType.VarChar
                param41.Size = 200
                param41.Value = comunmancom.xtwitter3
                param41.ParameterName = "p_xtwitter3"

                Dim param42 As New SqlClient.SqlParameter
                param42.SqlDbType = SqlDbType.VarChar
                param42.Size = 200
                param42.Value = comunmancom.xtwitter4
                param42.ParameterName = "p_xtwitter4"

                Dim param43 As New SqlClient.SqlParameter
                param43.SqlDbType = SqlDbType.VarChar
                param43.Size = 200
                param43.Value = comunmancom.xtwitter5
                param43.ParameterName = "p_xtwitter5"

                Dim param44 As New SqlClient.SqlParameter
                param44.SqlDbType = SqlDbType.VarChar
                param44.Size = 200
                param44.Value = comunmancom.xfacebook1
                param44.ParameterName = "p_xfacebook1"

                Dim param45 As New SqlClient.SqlParameter
                param45.SqlDbType = SqlDbType.VarChar
                param45.Size = 200
                param45.Value = comunmancom.xfacebook2
                param45.ParameterName = "p_xfacebook2"

                Dim param46 As New SqlClient.SqlParameter
                param46.SqlDbType = SqlDbType.VarChar
                param46.Size = 200
                param46.Value = comunmancom.xfacebook3
                param46.ParameterName = "p_xfacebook3"

                Dim param47 As New SqlClient.SqlParameter
                param47.SqlDbType = SqlDbType.VarChar
                param47.Size = 200
                param47.Value = comunmancom.xfacebook4
                param47.ParameterName = "p_xfacebook4"

                Dim param48 As New SqlClient.SqlParameter
                param48.SqlDbType = SqlDbType.VarChar
                param48.Size = 200
                param48.Value = comunmancom.xfacebook5
                param48.ParameterName = "p_xfacebook5"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmancom @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idcomunmancom output,@p_xtelfhabitacion1,@p_xtelfhabitacion2,@p_xtelfhabitacion3,@p_xtelfhabitacion4,@p_xtelfhabitacion5,@p_xtelfmovil1,@p_xtelfmovil2,@p_xtelfmovil3,@p_xtelfmovil4,@p_xtelfmovil5,@p_xtelfoficina1,@p_xtelfoficina2,@p_xtelfoficina3,@p_xtelfoficina4,@p_xtelfoficina5,@p_xtelffax1,@p_xtelffax2,@p_xtelffax3,@p_xtelffax4,@p_xtelffax5,@p_xcorreoelectronico1,@p_xcorreoelectronico2,@p_xcorreoelectronico3,@p_xcorreoelectronico4,@p_xcorreoelectronico5,@p_xdireccionweb1,@p_xdireccionweb2,@p_xdireccionweb3,@p_xdireccionweb4,@p_xdireccionweb5,@p_xtwitter1,@p_xtwitter2,@p_xtwitter3,@p_xtwitter4,@p_xtwitter5,@p_xfacebook1,@p_xfacebook2,@p_xfacebook3,@p_xfacebook4,@p_xfacebook5", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40, param41, param42, param43, param44, param45, param46, param47, param48)

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
        Public Function elicomunmancom(idcomunmancom As Decimal) As respopera
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
                param8.Value = idcomunmancom
                param8.ParameterName = "p_idcomunmancom"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 20
                param9.Value = ""
                param9.ParameterName = "p_xtelfhabitacion1"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 20
                param10.Value = ""
                param10.ParameterName = "p_xtelfhabitacion2"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 20
                param11.Value = ""
                param11.ParameterName = "p_xtelfhabitacion3"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                param12.Value = ""
                param12.ParameterName = "p_xtelfhabitacion4"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = 20
                param13.Value = ""
                param13.ParameterName = "p_xtelfhabitacion5"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = 20
                param14.Value = ""
                param14.ParameterName = "p_xtelfmovil1"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 20
                param15.Value = ""
                param15.ParameterName = "p_xtelfmovil2"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.VarChar
                param16.Size = 20
                param16.Value = ""
                param16.ParameterName = "p_xtelfmovil3"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.VarChar
                param17.Size = 20
                param17.Value = ""
                param17.ParameterName = "p_xtelfmovil4"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 20
                param18.Value = ""
                param18.ParameterName = "p_xtelfmovil5"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.VarChar
                param19.Size = 20
                param19.Value = ""
                param19.ParameterName = "p_xtelfoficina1"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.VarChar
                param20.Size = 20
                param20.Value = ""
                param20.ParameterName = "p_xtelfoficina2"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.VarChar
                param21.Size = 20
                param21.Value = ""
                param21.ParameterName = "p_xtelfoficina3"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.VarChar
                param22.Size = 20
                param22.Value = ""
                param22.ParameterName = "p_xtelfoficina4"

                Dim param23 As New SqlClient.SqlParameter
                param23.SqlDbType = SqlDbType.VarChar
                param23.Size = 20
                param23.Value = ""
                param23.ParameterName = "p_xtelfoficina5"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.VarChar
                param24.Size = 20
                param24.Value = ""
                param24.ParameterName = "p_xtelffax1"

                Dim param25 As New SqlClient.SqlParameter
                param25.SqlDbType = SqlDbType.VarChar
                param25.Size = 20
                param25.Value = ""
                param25.ParameterName = "p_xtelffax2"

                Dim param26 As New SqlClient.SqlParameter
                param26.SqlDbType = SqlDbType.VarChar
                param26.Size = 20
                param26.Value = ""
                param26.ParameterName = "p_xtelffax3"

                Dim param27 As New SqlClient.SqlParameter
                param27.SqlDbType = SqlDbType.VarChar
                param27.Size = 20
                param27.Value = ""
                param27.ParameterName = "p_xtelffax4"

                Dim param28 As New SqlClient.SqlParameter
                param28.SqlDbType = SqlDbType.VarChar
                param28.Size = 20
                param28.Value = ""
                param28.ParameterName = "p_xtelffax5"

                Dim param29 As New SqlClient.SqlParameter
                param29.SqlDbType = SqlDbType.VarChar
                param29.Size = 50
                param29.Value = ""
                param29.ParameterName = "p_xcorreoelectronico1"

                Dim param30 As New SqlClient.SqlParameter
                param30.SqlDbType = SqlDbType.VarChar
                param30.Size = 50
                param30.Value = ""
                param30.ParameterName = "p_xcorreoelectronico2"

                Dim param31 As New SqlClient.SqlParameter
                param31.SqlDbType = SqlDbType.VarChar
                param31.Size = 50
                param31.Value = ""
                param31.ParameterName = "p_xcorreoelectronico3"

                Dim param32 As New SqlClient.SqlParameter
                param32.SqlDbType = SqlDbType.VarChar
                param32.Size = 50
                param32.Value = ""
                param32.ParameterName = "p_xcorreoelectronico4"

                Dim param33 As New SqlClient.SqlParameter
                param33.SqlDbType = SqlDbType.VarChar
                param33.Size = 50
                param33.Value = ""
                param33.ParameterName = "p_xcorreoelectronico5"

                Dim param34 As New SqlClient.SqlParameter
                param34.SqlDbType = SqlDbType.VarChar
                param34.Size = 50
                param34.Value = ""
                param34.ParameterName = "p_xdireccionweb1"

                Dim param35 As New SqlClient.SqlParameter
                param35.SqlDbType = SqlDbType.VarChar
                param35.Size = 50
                param35.Value = ""
                param35.ParameterName = "p_xdireccionweb2"

                Dim param36 As New SqlClient.SqlParameter
                param36.SqlDbType = SqlDbType.VarChar
                param36.Size = 50
                param36.Value = ""
                param36.ParameterName = "p_xdireccionweb3"

                Dim param37 As New SqlClient.SqlParameter
                param37.SqlDbType = SqlDbType.VarChar
                param37.Size = 50
                param37.Value = ""
                param37.ParameterName = "p_xdireccionweb4"

                Dim param38 As New SqlClient.SqlParameter
                param38.SqlDbType = SqlDbType.VarChar
                param38.Size = 50
                param38.Value = ""
                param38.ParameterName = "p_xdireccionweb5"

                Dim param39 As New SqlClient.SqlParameter
                param39.SqlDbType = SqlDbType.VarChar
                param39.Size = 200
                param39.Value = ""
                param39.ParameterName = "p_xtwitter1"

                Dim param40 As New SqlClient.SqlParameter
                param40.SqlDbType = SqlDbType.VarChar
                param40.Size = 200
                param40.Value = ""
                param40.ParameterName = "p_xtwitter2"

                Dim param41 As New SqlClient.SqlParameter
                param41.SqlDbType = SqlDbType.VarChar
                param41.Size = 200
                param41.Value = ""
                param41.ParameterName = "p_xtwitter3"

                Dim param42 As New SqlClient.SqlParameter
                param42.SqlDbType = SqlDbType.VarChar
                param42.Size = 200
                param42.Value = ""
                param42.ParameterName = "p_xtwitter4"

                Dim param43 As New SqlClient.SqlParameter
                param43.SqlDbType = SqlDbType.VarChar
                param43.Size = 200
                param43.Value = ""
                param43.ParameterName = "p_xtwitter5"

                Dim param44 As New SqlClient.SqlParameter
                param44.SqlDbType = SqlDbType.VarChar
                param44.Size = 200
                param44.Value = ""
                param44.ParameterName = "p_xfacebook1"

                Dim param45 As New SqlClient.SqlParameter
                param45.SqlDbType = SqlDbType.VarChar
                param45.Size = 200
                param45.Value = ""
                param45.ParameterName = "p_xfacebook2"

                Dim param46 As New SqlClient.SqlParameter
                param46.SqlDbType = SqlDbType.VarChar
                param46.Size = 200
                param46.Value = ""
                param46.ParameterName = "p_xfacebook3"

                Dim param47 As New SqlClient.SqlParameter
                param47.SqlDbType = SqlDbType.VarChar
                param47.Size = 200
                param47.Value = ""
                param47.ParameterName = "p_xfacebook4"

                Dim param48 As New SqlClient.SqlParameter
                param48.SqlDbType = SqlDbType.VarChar
                param48.Size = 200
                param48.Value = ""
                param48.ParameterName = "p_xfacebook5"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_comunmancom @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@id_comunmancom  output,@p_xtelfhabitacion1,@p_xtelfhabitacion2,@p_xtelfhabitacion3,@p_xtelfhabitacion4,@p_xtelfhabitacion5,@p_xtelfmovil1,@p_xtelfmovil2,@p_xtelfmovil3,@p_xtelfmovil4,@p_xtelfmovil5,@p_xtelfoficina1,@p_xtelfoficina2,@p_xtelfoficina3,@p_xtelfoficina4,@p_xtelfoficina5,@p_xtelffax1,@p_xtelffax2,@p_xtelffax3,@p_xtelffax4,@p_xtelffax5,@p_xcorreoelectronico1,@p_xcorreoelectronico2,@p_xcorreoelectronico3,@p_xcorreoelectronico4,@p_xcorreoelectronico5,@p_xdireccionweb1,@p_xdireccionweb2,@p_xdireccionweb3,@p_xdireccionweb4,@p_xdireccionweb5,@p_xtwitter1,@p_xtwitter2,@p_xtwitter3,@p_xtwitter4,@p_xtwitter5,@p_xfacebook1,@p_xfacebook2,@p_xfacebook3,@p_xfacebook4,@p_xfacebook5", param1, param2, param3, param4, param5, param6, param7, param7, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40, param41, param42, param43, param44, param45, param46, param47, param48)

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
