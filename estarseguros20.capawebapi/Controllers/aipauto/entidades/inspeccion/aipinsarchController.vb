Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports Oracle.ManagedDataAccess

Namespace aipauto.entidades.controlador
    Public Class aipinsarchController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selaipinsarchxid(idaipinsarch As Decimal) As aipinsarch
            Dim aipinsarch As aipinsarch = (From p In _db.aipinsarch
                                            Where p.idaipinsarch = idaipinsarch
                                            Select p).SingleOrDefault
            Return aipinsarch
        End Function

        <HttpPost()> _
        Public Function selaipinsarch() As List(Of aipinsarch)
            Dim lista_aipinsarch As List(Of aipinsarch) = (From p In _db.aipinsarch
                                                        Select p).ToList
            '
            Return lista_aipinsarch
        End Function

        <HttpPost()> _
        Public Function selaipinsarchxwheredinamicopag(petiaipinsarchpaglist As petiaipinsarchpaglist) As respaipinsarchpaglist
            Dim sb As New StringBuilder("")
            '
            If petiaipinsarchpaglist.aipinsarch.idaipinsarch <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsarch=")
                    sb.Append(valor_entero(petiaipinsarchpaglist.aipinsarch.idaipinsarch))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsarch=")
                        sb.Append(valor_entero(petiaipinsarchpaglist.aipinsarch.idaipinsarch))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.idaipinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsenc=")
                    sb.Append(valor_entero(petiaipinsarchpaglist.aipinsarch.idaipinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsenc=")
                        sb.Append(valor_entero(petiaipinsarchpaglist.aipinsarch.idaipinsenc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.nsecinsarch <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.nsecinsarch=")
                    sb.Append(valor_entero(petiaipinsarchpaglist.aipinsarch.nsecinsarch))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.nsecinsarch=")
                        sb.Append(valor_entero(petiaipinsarchpaglist.aipinsarch.nsecinsarch))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.itipoinsarch <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.itipoinsarch='")
                    sb.Append(petiaipinsarchpaglist.aipinsarch.itipoinsarch)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itipoinsarch='")
                        sb.Append(petiaipinsarchpaglist.aipinsarch.itipoinsarch)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.xrutainsarch <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xrutainsarch='")
                    sb.Append(petiaipinsarchpaglist.aipinsarch.xrutainsarch)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xrutainsarch='")
                        sb.Append(petiaipinsarchpaglist.aipinsarch.xrutainsarch)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.xurlinsarch <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xurlinsarch='")
                    sb.Append(petiaipinsarchpaglist.aipinsarch.xurlinsarch)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xurlinsarch='")
                        sb.Append(petiaipinsarchpaglist.aipinsarch.xurlinsarch)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.xtituinsarch <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xtituinsarch='")
                    sb.Append(petiaipinsarchpaglist.aipinsarch.xtituinsarch)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xtituinsarch='")
                        sb.Append(petiaipinsarchpaglist.aipinsarch.xtituinsarch)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.xnominsarch <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnominsarch='")
                    sb.Append(petiaipinsarchpaglist.aipinsarch.xnominsarch)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnominsarch='")
                        sb.Append(petiaipinsarchpaglist.aipinsarch.xnominsarch)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.xextinsarch <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xextinsarch='")
                    sb.Append(petiaipinsarchpaglist.aipinsarch.xextinsarch)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xextinsarch='")
                        sb.Append(petiaipinsarchpaglist.aipinsarch.xextinsarch)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.xlatcinsarch <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xlatcinsarch='")
                    sb.Append(petiaipinsarchpaglist.aipinsarch.xlatcinsarch)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xlatcinsarch='")
                        sb.Append(petiaipinsarchpaglist.aipinsarch.xlatcinsarch)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.xlonginsarch <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xlonginsarch='")
                    sb.Append(petiaipinsarchpaglist.aipinsarch.xlonginsarch)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xlonginsarch='")
                        sb.Append(petiaipinsarchpaglist.aipinsarch.xlonginsarch)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.mimetypeinsarch <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.mimetypeinsarch='")
                    sb.Append(petiaipinsarchpaglist.aipinsarch.mimetypeinsarch)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.mimetypeinsarch='")
                        sb.Append(petiaipinsarchpaglist.aipinsarch.mimetypeinsarch)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.ioriginsarch <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.ioriginsarch='")
                    sb.Append(petiaipinsarchpaglist.aipinsarch.ioriginsarch)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ioriginsarch='")
                        sb.Append(petiaipinsarchpaglist.aipinsarch.ioriginsarch)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.xdescinsarch <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdescinsarch='")
                    sb.Append(petiaipinsarchpaglist.aipinsarch.xdescinsarch)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdescinsarch='")
                        sb.Append(petiaipinsarchpaglist.aipinsarch.xdescinsarch)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.iestatinsarch <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestatinsarch='")
                    sb.Append(petiaipinsarchpaglist.aipinsarch.iestatinsarch)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatinsarch='")
                        sb.Append(petiaipinsarchpaglist.aipinsarch.iestatinsarch)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.fcreaaipinsarch > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fcreaaipinsarch >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsarchpaglist.aipinsarch.fcreaaipinsarch)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fcreaaipinsarch >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsarchpaglist.aipinsarch.fcreaaipinsarch)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaipinsarchpaglist.aipinsarch.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petiaipinsarchpaglist.aipinsarch.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petiaipinsarchpaglist.aipinsarch.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respaipinsarchpaglist As New respaipinsarchpaglist
            respaipinsarchpaglist.pagaipinsarch = petiaipinsarchpaglist.pagaipinsarch
            Dim skip = skip_paginacion(petiaipinsarchpaglist.pagaipinsarch.npagactual, petiaipinsarchpaglist.pagaipinsarch.npagtamano)

            If sb.ToString = "" Then
                respaipinsarchpaglist.lista_aipinsarch = _db.aipinsarch.OrderBy(petiaipinsarchpaglist.pagaipinsarch.xcamposord & " " & petiaipinsarchpaglist.pagaipinsarch.idirord).Skip(skip).Take(petiaipinsarchpaglist.pagaipinsarch.npagtamano).ToList
            Else
                respaipinsarchpaglist.lista_aipinsarch = _db.aipinsarch.Where(sb.ToString).OrderBy(petiaipinsarchpaglist.pagaipinsarch.xcamposord & " " & petiaipinsarchpaglist.pagaipinsarch.idirord).Skip(skip).Take(petiaipinsarchpaglist.pagaipinsarch.npagtamano).ToList
            End If
            '
            If (respaipinsarchpaglist.lista_aipinsarch.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selaipinsarchxwheredinamicocount(sb)
                respaipinsarchpaglist.pagaipinsarch.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinsarchpaglist.pagaipinsarch.npagtamano)
            Else
                respaipinsarchpaglist.pagaipinsarch.npagcantidad = 0
                respaipinsarchpaglist.pagaipinsarch.npagactual = 0
            End If

            Return respaipinsarchpaglist
        End Function

        Public Function selaipinsarchxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.aipinsarch.Count
            Else
                Return _db.aipinsarch.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
        Public Function insaipinsarch(aipinsarch As aipinsarch) As respopera
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
                    param8.ParameterName = "p_idaipinsarch"
                    param8.Direction = ParameterDirection.Output

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinsarch.idaipinsenc
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Int
                    param10.Value = aipinsarch.nsecinsarch
                    param10.ParameterName = "p_nsecinsarch"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 20
                    If aipinsarch.itipoinsarch IsNot Nothing Then
                        param11.Value = aipinsarch.itipoinsarch
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_itipoinsarch"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 200
                    If aipinsarch.xrutainsarch IsNot Nothing Then
                        param12.Value = aipinsarch.xrutainsarch
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_xrutainsarch"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 200
                    If aipinsarch.xurlinsarch IsNot Nothing Then
                        param13.Value = aipinsarch.xurlinsarch
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_xurlinsarch"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 200
                    If aipinsarch.xtituinsarch IsNot Nothing Then
                        param14.Value = aipinsarch.xtituinsarch
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_xtituinsarch"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 100
                    If aipinsarch.xnominsarch IsNot Nothing Then
                        param15.Value = aipinsarch.xnominsarch
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xnominsarch"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.VarChar
                    param16.Size = 5
                    If aipinsarch.xextinsarch IsNot Nothing Then
                        param16.Value = aipinsarch.xextinsarch
                    Else
                        param16.Value = ""
                    End If
                    param16.ParameterName = "p_xextinsarch"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 50
                    If aipinsarch.xlatcinsarch IsNot Nothing Then
                        param17.Value = aipinsarch.xlatcinsarch
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xlatcinsarch"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 50
                    If aipinsarch.xlonginsarch IsNot Nothing Then
                        param18.Value = aipinsarch.xlonginsarch
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xlonginsarch"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 50
                    If aipinsarch.mimetypeinsarch IsNot Nothing Then
                        param19.Value = aipinsarch.mimetypeinsarch
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_mimetypeinsarch"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 50
                    If aipinsarch.ioriginsarch IsNot Nothing Then
                        param20.Value = aipinsarch.ioriginsarch
                    Else
                        param20.Value = ""
                    End If
                    param20.ParameterName = "p_ioriginsarch"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 500
                    If aipinsarch.xdescinsarch IsNot Nothing Then
                        param21.Value = aipinsarch.xdescinsarch
                    Else
                        param21.Value = ""
                    End If
                    param21.ParameterName = "p_xdescinsarch"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.VarChar
                    param22.Size = 20
                    If aipinsarch.iestatinsarch IsNot Nothing Then
                        param22.Value = aipinsarch.iestatinsarch
                    Else
                        param22.Value = ""
                    End If
                    param22.ParameterName = "p_iestatinsarch"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.DateTime
                    If aipinsarch.fcreaaipinsarch > CDate("01-01-1900") Then
                        param23.Value = aipinsarch.fcreaaipinsarch
                    Else
                        param23.Value = CDate("01-01-1900")
                    End If
                    param23.ParameterName = "p_fcreaaipinsarch"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.Decimal
                    param24.Precision = 18
                    param24.Scale = 0
                    param24.Value = 0
                    param24.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsarch @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsarch output,@p_idaipinsenc,@p_nsecinsarch,@p_itipoinsarch,@p_xrutainsarch,@p_xurlinsarch,@p_xtituinsarch,@p_xnominsarch,@p_xextinsarch,@p_xlatcinsarch,@p_xlonginsarch,@p_mimetypeinsarch,@p_ioriginsarch,@p_xdescinsarch,@p_iestatinsarch,@p_fcreaaipinsarch,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24)


                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If

                Else
                    respopera = insaipinsarchoracle(aipinsarch)
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
        Public Function insaipinsarchoracle(aipinsarch As aipinsarch) As respopera
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
                param8.ParameterName = "p_idaipinsarch"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsarch.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Int16
                param10.Value = aipinsarch.nsecinsarch
                param10.ParameterName = "p_nsecinsarch"


                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Varchar2
                param11.Size = 20
                If aipinsarch.itipoinsarch IsNot Nothing And aipinsarch.itipoinsarch <> "" Then
                    param11.Value = aipinsarch.itipoinsarch
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_itipoinsarch"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 200
                If aipinsarch.xrutainsarch IsNot Nothing And aipinsarch.xrutainsarch <> "" Then
                    param12.Value = aipinsarch.xrutainsarch
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_xrutainsarch"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Varchar2
                param13.Size = 200
                If aipinsarch.xurlinsarch IsNot Nothing And aipinsarch.xurlinsarch <> "" Then
                    param13.Value = aipinsarch.xurlinsarch
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_xurlinsarch"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Varchar2
                param14.Size = 100
                If aipinsarch.xtituinsarch IsNot Nothing And aipinsarch.xtituinsarch <> "" Then
                    param14.Value = aipinsarch.xtituinsarch
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_xtituinsarch"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 100
                If aipinsarch.xnominsarch IsNot Nothing And aipinsarch.xnominsarch <> "" Then
                    param15.Value = aipinsarch.xnominsarch
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xnominsarch"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Varchar2
                param16.Size = 5
                If aipinsarch.xextinsarch IsNot Nothing And aipinsarch.xextinsarch <> "" Then
                    param16.Value = aipinsarch.xextinsarch
                Else
                    param16.Value = " "
                End If
                param16.ParameterName = "p_xextinsarch"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Varchar2
                param17.Size = 50
                If aipinsarch.xlatcinsarch IsNot Nothing And aipinsarch.xlatcinsarch <> "" Then
                    param17.Value = aipinsarch.xlatcinsarch
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xlatcinsarch"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 50
                If aipinsarch.xlonginsarch IsNot Nothing And aipinsarch.xlonginsarch <> "" Then
                    param18.Value = aipinsarch.xlonginsarch
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_xlonginsarch"


                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Varchar2
                param19.Size = 50
                If aipinsarch.mimetypeinsarch IsNot Nothing And aipinsarch.mimetypeinsarch <> "" Then
                    param19.Value = aipinsarch.mimetypeinsarch
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_mimetypeinsarch"


                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Varchar2
                param20.Size = 50
                If aipinsarch.ioriginsarch IsNot Nothing And aipinsarch.ioriginsarch <> "" Then
                    param20.Value = aipinsarch.ioriginsarch
                Else
                    param20.Value = " "
                End If
                param20.ParameterName = "p_ioriginsarch"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Varchar2
                param21.Size = 500
                If aipinsarch.xdescinsarch IsNot Nothing And aipinsarch.xdescinsarch <> "" Then
                    param21.Value = aipinsarch.xdescinsarch
                Else
                    param21.Value = " "
                End If
                param21.ParameterName = "p_xdescinsarch"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.Varchar2
                param22.Size = 20
                If aipinsarch.iestatinsarch IsNot Nothing And aipinsarch.iestatinsarch <> "" Then
                    param22.Value = aipinsarch.iestatinsarch
                Else
                    param22.Value = " "
                End If
                param22.ParameterName = "p_iestatinsarch"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.Date
                If aipinsarch.fcreaaipinsarch > CDate("01-01-1900") Then
                    param23.Value = aipinsarch.fcreaaipinsarch
                Else
                    param23.Value = CDate("01-01-1900")
                End If
                param23.ParameterName = "p_fcreaaipinsarch"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.Decimal
                param24.Precision = 18
                param24.Scale = 0
                param24.Value = 0
                param24.ParameterName = "p_idseglogreg"

                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinsarch FLOAT; v_p_idaipinsenc FLOAT; v_p_nsecinsarch number; v_p_itipoinsarch VARCHAR2(20); v_p_xrutainsarch VARCHAR2(200); v_p_xurlinsarch VARCHAR2(200); v_p_xtituinsarch VARCHAR2(100); v_p_xnominsarch VARCHAR2(100); v_p_xextinsarch VARCHAR2(5); v_p_xlatcinsarch VARCHAR2(50); v_p_xlonginsarch VARCHAR2(50); v_p_mimetypeinsarch VARCHAR2(50); v_p_ioriginsarch VARCHAR2(50); v_p_xdescinsarch VARCHAR2(500); v_p_iestatinsarch VARCHAR2(20); v_p_fcreaaipinsarch date; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinsarch(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinsarch,:v_p_idaipinsenc,:v_p_nsecinsarch, :itipoinsarch,:v_p_xrutainsarch,:v_p_xurlinsarch,:v_p_xtituinsarch,:v_p_xnominsarch,:v_p_xextinsarch,:v_p_xlatcinsarch,:v_p_xlonginsarch,:v_p_ioriginsarch,:v_p_xdescinsarch, :v_p_mimetypeinsarch,:v_p_iestatinsarch,:v_p_fcreaaipinsarch,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24)

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
        Public Function modaipinsarch(aipinsarch As aipinsarch) As respopera
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
                    param8.Value = aipinsarch.idaipinsarch
                    param8.ParameterName = "p_idaipinsarch"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinsarch.idaipinsenc
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Int
                    param10.Value = aipinsarch.nsecinsarch
                    param10.ParameterName = "p_nsecinsarch"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 20
                    If aipinsarch.itipoinsarch IsNot Nothing Then
                        param11.Value = aipinsarch.itipoinsarch
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_itipoinsarch"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 200
                    If aipinsarch.xrutainsarch IsNot Nothing Then
                        param12.Value = aipinsarch.xrutainsarch
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_xrutainsarch"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 200
                    If aipinsarch.xurlinsarch IsNot Nothing Then
                        param13.Value = aipinsarch.xurlinsarch
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_xurlinsarch"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 200
                    If aipinsarch.xtituinsarch IsNot Nothing Then
                        param14.Value = aipinsarch.xtituinsarch
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_xtituinsarch"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 100
                    If aipinsarch.xnominsarch IsNot Nothing Then
                        param15.Value = aipinsarch.xnominsarch
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xnominsarch"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.VarChar
                    param16.Size = 5
                    If aipinsarch.xextinsarch IsNot Nothing Then
                        param16.Value = aipinsarch.xextinsarch
                    Else
                        param16.Value = ""
                    End If
                    param16.ParameterName = "p_xextinsarch"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 50
                    If aipinsarch.xlatcinsarch IsNot Nothing Then
                        param17.Value = aipinsarch.xlatcinsarch
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xlatcinsarch"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 50
                    If aipinsarch.xlonginsarch IsNot Nothing Then
                        param18.Value = aipinsarch.xlonginsarch
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xlonginsarch"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 50
                    If aipinsarch.mimetypeinsarch IsNot Nothing Then
                        param19.Value = aipinsarch.mimetypeinsarch
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_mimetypeinsarch"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 50
                    If aipinsarch.ioriginsarch IsNot Nothing Then
                        param20.Value = aipinsarch.ioriginsarch
                    Else
                        param20.Value = ""
                    End If
                    param20.ParameterName = "p_ioriginsarch"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 500
                    If aipinsarch.xdescinsarch IsNot Nothing Then
                        param21.Value = aipinsarch.xdescinsarch
                    Else
                        param21.Value = ""
                    End If
                    param21.ParameterName = "p_xdescinsarch"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.VarChar
                    param22.Size = 20
                    If aipinsarch.iestatinsarch IsNot Nothing Then
                        param22.Value = aipinsarch.iestatinsarch
                    Else
                        param22.Value = ""
                    End If
                    param22.ParameterName = "p_iestatinsarch"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.DateTime
                    If aipinsarch.fcreaaipinsarch > CDate("01-01-1900") Then
                        param23.Value = aipinsarch.fcreaaipinsarch
                    Else
                        param23.Value = CDate("01-01-1900")
                    End If
                    param23.ParameterName = "p_fcreaaipinsarch"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.Decimal
                    param24.Precision = 18
                    param24.Scale = 0
                    param24.Value = aipinsarch.idseglogreg
                    param24.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsarch @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsarch output,@p_idaipinsenc,@p_nsecinsarch,@p_itipoinsarch,@p_xrutainsarch,@p_xurlinsarch,@p_xtituinsarch,@p_xnominsarch,@p_xextinsarch,@p_xlatcinsarch,@p_xlonginsarch,@p_mimetypeinsarch,@p_ioriginsarch,@p_xdescinsarch,@p_iestatinsarch,@p_fcreaaipinsarch,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24)


                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = modaipinsarchoracle(aipinsarch)
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
        Public Function modaipinsarchoracle(aipinsarch As aipinsarch) As respopera
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
                param8.Value = aipinsarch.idaipinsarch
                param8.ParameterName = "p_idaipinsarch"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsarch.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Int16
                param10.Value = aipinsarch.nsecinsarch
                param10.ParameterName = "p_nsecinsarch"


                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Varchar2
                param11.Size = 20
                If aipinsarch.itipoinsarch IsNot Nothing And aipinsarch.itipoinsarch <> "" Then
                    param11.Value = aipinsarch.itipoinsarch
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_itipoinsarch"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 200
                If aipinsarch.xrutainsarch IsNot Nothing And aipinsarch.xrutainsarch <> "" Then
                    param12.Value = aipinsarch.xrutainsarch
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_xrutainsarch"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Varchar2
                param13.Size = 200
                If aipinsarch.xurlinsarch IsNot Nothing And aipinsarch.xurlinsarch <> "" Then
                    param13.Value = aipinsarch.xurlinsarch
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_xurlinsarch"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Varchar2
                param14.Size = 100
                If aipinsarch.xtituinsarch IsNot Nothing And aipinsarch.xtituinsarch <> "" Then
                    param14.Value = aipinsarch.xtituinsarch
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_xtituinsarch"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 100
                If aipinsarch.xnominsarch IsNot Nothing And aipinsarch.xnominsarch <> "" Then
                    param15.Value = aipinsarch.xnominsarch
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xnominsarch"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Varchar2
                param16.Size = 5
                If aipinsarch.xextinsarch IsNot Nothing And aipinsarch.xextinsarch <> "" Then
                    param16.Value = aipinsarch.xextinsarch
                Else
                    param16.Value = " "
                End If
                param16.ParameterName = "p_xextinsarch"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Varchar2
                param17.Size = 50
                If aipinsarch.xlatcinsarch IsNot Nothing And aipinsarch.xlatcinsarch <> "" Then
                    param17.Value = aipinsarch.xlatcinsarch
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xlatcinsarch"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 50
                If aipinsarch.xlonginsarch IsNot Nothing And aipinsarch.xlonginsarch <> "" Then
                    param18.Value = aipinsarch.xlonginsarch
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_xlonginsarch"


                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Varchar2
                param19.Size = 50
                If aipinsarch.mimetypeinsarch IsNot Nothing And aipinsarch.mimetypeinsarch <> "" Then
                    param19.Value = aipinsarch.mimetypeinsarch
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_mimetypeinsarch"


                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Varchar2
                param20.Size = 40
                If aipinsarch.ioriginsarch IsNot Nothing And aipinsarch.ioriginsarch <> "" Then
                    param20.Value = aipinsarch.ioriginsarch
                Else
                    param20.Value = " "
                End If
                param20.ParameterName = "p_ioriginsarch"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Varchar2
                param21.Size = 500
                If aipinsarch.xdescinsarch IsNot Nothing And aipinsarch.xdescinsarch <> "" Then
                    param21.Value = aipinsarch.xdescinsarch
                Else
                    param21.Value = " "
                End If
                param21.ParameterName = "p_xdescinsarch"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.Varchar2
                param22.Size = 20
                If aipinsarch.iestatinsarch IsNot Nothing And aipinsarch.iestatinsarch <> "" Then
                    param22.Value = aipinsarch.iestatinsarch
                Else
                    param22.Value = " "
                End If
                param22.ParameterName = "p_iestatinsarch"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.Date
                If aipinsarch.fcreaaipinsarch > CDate("01-01-1900") Then
                    param23.Value = aipinsarch.fcreaaipinsarch
                Else
                    param23.Value = CDate("01-01-1900")
                End If
                param23.ParameterName = "p_fcreaaipinsarch"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.Decimal
                param24.Precision = 18
                param24.Scale = 0
                param24.Value = 0
                param24.ParameterName = "p_idseglogreg"

                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinsarch FLOAT; v_p_idaipinsenc FLOAT; v_p_nsecinsarch number; v_p_itipoinsarch VARCHAR2(20); v_p_xrutainsarch VARCHAR2(200); v_p_xurlinsarch VARCHAR2(200); v_p_xtituinsarch VARCHAR2(100); v_p_xnominsarch VARCHAR2(100); v_p_xextinsarch VARCHAR2(5); v_p_xlatcinsarch VARCHAR2(50); v_p_xlonginsarch VARCHAR2(50); v_p_mimetypeinsarch VARCHAR2(50); v_p_ioriginsarch VARCHAR2(50); v_p_xdescinsarch VARCHAR2(500); v_p_iestatinsarch VARCHAR2(20); v_p_fcreaaipinsarch date; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinsarch(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinsarch,:v_p_idaipinsenc,:v_p_nsecinsarch, :itipoinsarch,:v_p_xrutainsarch,:v_p_xurlinsarch,:v_p_xtituinsarch,:v_p_xnominsarch,:v_p_xextinsarch,:v_p_xlatcinsarch,:v_p_xlonginsarch,:v_p_ioriginsarch,:v_p_xdescinsarch, :mimetypeinsarch,:v_p_iestatinsarch,:v_p_fcreaaipinsarch,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24)

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
        Public Function eliaipinsarch(aipinsarch As aipinsarch) As respopera
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
                    param8.Value = aipinsarch.idaipinsarch
                    param8.ParameterName = "p_idaipinsarch"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinsarch.idaipinsenc
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Int
                    param10.Value = aipinsarch.nsecinsarch
                    param10.ParameterName = "p_nsecinsarch"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 20
                    If aipinsarch.itipoinsarch IsNot Nothing Then
                        param11.Value = aipinsarch.itipoinsarch
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_itipoinsarch"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 200
                    If aipinsarch.xrutainsarch IsNot Nothing Then
                        param12.Value = aipinsarch.xrutainsarch
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_xrutainsarch"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 200
                    If aipinsarch.xurlinsarch IsNot Nothing Then
                        param13.Value = aipinsarch.xurlinsarch
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_xurlinsarch"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 200
                    If aipinsarch.xtituinsarch IsNot Nothing Then
                        param14.Value = aipinsarch.xtituinsarch
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_xtituinsarch"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 100
                    If aipinsarch.xnominsarch IsNot Nothing Then
                        param15.Value = aipinsarch.xnominsarch
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xnominsarch"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.VarChar
                    param16.Size = 5
                    If aipinsarch.xextinsarch IsNot Nothing Then
                        param16.Value = aipinsarch.xextinsarch
                    Else
                        param16.Value = ""
                    End If
                    param16.ParameterName = "p_xextinsarch"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 50
                    If aipinsarch.xlatcinsarch IsNot Nothing Then
                        param17.Value = aipinsarch.xlatcinsarch
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xlatcinsarch"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 50
                    If aipinsarch.xlonginsarch IsNot Nothing Then
                        param18.Value = aipinsarch.xlonginsarch
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xlonginsarch"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 50
                    If aipinsarch.mimetypeinsarch IsNot Nothing Then
                        param19.Value = aipinsarch.mimetypeinsarch
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_mimetypeinsarch"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 50
                    If aipinsarch.ioriginsarch IsNot Nothing Then
                        param20.Value = aipinsarch.ioriginsarch
                    Else
                        param20.Value = ""
                    End If
                    param20.ParameterName = "p_ioriginsarch"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 500
                    If aipinsarch.xdescinsarch IsNot Nothing Then
                        param21.Value = aipinsarch.xdescinsarch
                    Else
                        param21.Value = ""
                    End If
                    param21.ParameterName = "p_xdescinsarch"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.VarChar
                    param22.Size = 20
                    If aipinsarch.iestatinsarch IsNot Nothing Then
                        param22.Value = aipinsarch.iestatinsarch
                    Else
                        param22.Value = ""
                    End If
                    param22.ParameterName = "p_iestatinsarch"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.DateTime
                    If aipinsarch.fcreaaipinsarch > CDate("01-01-1900") Then
                        param23.Value = aipinsarch.fcreaaipinsarch
                    Else
                        param23.Value = CDate("01-01-1900")
                    End If
                    param23.ParameterName = "p_fcreaaipinsarch"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.Decimal
                    param24.Precision = 18
                    param24.Scale = 0
                    param24.Value = aipinsarch.idseglogreg
                    param24.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsarch @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsarch output,@p_idaipinsenc,@p_nsecinsarch,@p_itipoinsarch,@p_xrutainsarch,@p_xurlinsarch,@p_xtituinsarch,@p_xnominsarch,@p_xextinsarch,@p_xlatcinsarch,@p_xlonginsarch,@p_mimetypeinsarch,@p_ioriginsarch,@p_xdescinsarch,@p_iestatinsarch,@p_fcreaaipinsarch,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24)


                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipinsarchoracle(aipinsarch)
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
        Public Function eliaipinsarchoracle(aipinsarch As aipinsarch) As respopera
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
                param8.Value = aipinsarch.idaipinsarch
                param8.ParameterName = "p_idaipinsarch"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsarch.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Int16
                param10.Value = aipinsarch.nsecinsarch
                param10.ParameterName = "p_nsecinsarch"


                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Varchar2
                param11.Size = 20
                If aipinsarch.itipoinsarch IsNot Nothing And aipinsarch.itipoinsarch <> "" Then
                    param11.Value = aipinsarch.itipoinsarch
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_itipoinsarch"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 200
                If aipinsarch.xrutainsarch IsNot Nothing And aipinsarch.xrutainsarch <> "" Then
                    param12.Value = aipinsarch.xrutainsarch
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_xrutainsarch"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Varchar2
                param13.Size = 200
                If aipinsarch.xurlinsarch IsNot Nothing And aipinsarch.xurlinsarch <> "" Then
                    param13.Value = aipinsarch.xurlinsarch
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_xurlinsarch"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Varchar2
                param14.Size = 100
                If aipinsarch.xtituinsarch IsNot Nothing And aipinsarch.xtituinsarch <> "" Then
                    param14.Value = aipinsarch.xtituinsarch
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_xtituinsarch"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 100
                If aipinsarch.xnominsarch IsNot Nothing And aipinsarch.xnominsarch <> "" Then
                    param15.Value = aipinsarch.xnominsarch
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xnominsarch"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Varchar2
                param16.Size = 5
                If aipinsarch.xextinsarch IsNot Nothing And aipinsarch.xextinsarch <> "" Then
                    param16.Value = aipinsarch.xextinsarch
                Else
                    param16.Value = " "
                End If
                param16.ParameterName = "p_xextinsarch"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Varchar2
                param17.Size = 50
                If aipinsarch.xlatcinsarch IsNot Nothing And aipinsarch.xlatcinsarch <> "" Then
                    param17.Value = aipinsarch.xlatcinsarch
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xlatcinsarch"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 50
                If aipinsarch.xlonginsarch IsNot Nothing And aipinsarch.xlonginsarch <> "" Then
                    param18.Value = aipinsarch.xlonginsarch
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_xlonginsarch"


                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Varchar2
                param19.Size = 50
                If aipinsarch.mimetypeinsarch IsNot Nothing And aipinsarch.mimetypeinsarch <> "" Then
                    param19.Value = aipinsarch.mimetypeinsarch
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_mimetypeinsarch"


                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Varchar2
                param20.Size = 40
                If aipinsarch.ioriginsarch IsNot Nothing And aipinsarch.ioriginsarch <> "" Then
                    param20.Value = aipinsarch.ioriginsarch
                Else
                    param20.Value = " "
                End If
                param20.ParameterName = "p_ioriginsarch"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Varchar2
                param21.Size = 500
                If aipinsarch.xdescinsarch IsNot Nothing And aipinsarch.xdescinsarch <> "" Then
                    param21.Value = aipinsarch.xdescinsarch
                Else
                    param21.Value = " "
                End If
                param21.ParameterName = "p_xdescinsarch"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.Varchar2
                param22.Size = 20
                If aipinsarch.iestatinsarch IsNot Nothing And aipinsarch.iestatinsarch <> "" Then
                    param22.Value = aipinsarch.iestatinsarch
                Else
                    param22.Value = " "
                End If
                param22.ParameterName = "p_iestatinsarch"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.Date
                If aipinsarch.fcreaaipinsarch > CDate("01-01-1900") Then
                    param23.Value = aipinsarch.fcreaaipinsarch
                Else
                    param23.Value = CDate("01-01-1900")
                End If
                param23.ParameterName = "p_fcreaaipinsarch"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.Decimal
                param24.Precision = 18
                param24.Scale = 0
                param24.Value = 0
                param24.ParameterName = "p_idseglogreg"

                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinsarch FLOAT; v_p_idaipinsenc FLOAT; v_p_nsecinsarch number; v_p_itipoinsarch VARCHAR2(20); v_p_xrutainsarch VARCHAR2(200); v_p_xurlinsarch VARCHAR2(200); v_p_xtituinsarch VARCHAR2(100); v_p_xnominsarch VARCHAR2(100); v_p_xextinsarch VARCHAR2(5); v_p_xlatcinsarch VARCHAR2(50); v_p_xlonginsarch VARCHAR2(50); v_p_mimetypeinsarch VARCHAR2(50); v_p_ioriginsarch VARCHAR2(50); v_p_xdescinsarch VARCHAR2(500); v_p_iestatinsarch VARCHAR2(20); v_p_fcreaaipinsarch date; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinsarch(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinsarch,:v_p_idaipinsenc,:v_p_nsecinsarch, :itipoinsarch,:v_p_xrutainsarch,:v_p_xurlinsarch,:v_p_xtituinsarch,:v_p_xnominsarch,:v_p_xextinsarch,:v_p_xlatcinsarch,:v_p_xlonginsarch,:v_p_ioriginsarch,:v_p_xdescinsarch, :mimetypeinsarch,:v_p_iestatinsarch,:v_p_fcreaaipinsarch,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24)

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
        Public Function eliaipinsarch(idaipinsarch As Decimal) As respopera
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
                    param8.Value = idaipinsarch
                    param8.ParameterName = "p_idaipinsarch"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = 0
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Int
                    param10.Value = 0
                    param10.ParameterName = "p_nsecinsarch"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 20
                    param11.Value = ""
                    param11.ParameterName = "p_itipoinsarch"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 200
                    param12.Value = ""
                    param12.ParameterName = "p_xrutainsarch"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 200
                    param13.Value = ""
                    param13.ParameterName = "p_xurlinsarch"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 200
                    param14.Value = ""
                    param14.ParameterName = "p_xtituinsarch"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 100
                    param15.Value = ""
                    param15.ParameterName = "p_xnominsarch"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.VarChar
                    param16.Size = 5
                    param16.Value = ""
                    param16.ParameterName = "p_xextinsarch"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 50
                    param17.Value = ""
                    param17.ParameterName = "p_xlatcinsarch"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 50
                    param18.Value = ""
                    param18.ParameterName = "p_xlonginsarch"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 50
                    param19.Value = ""
                    param19.ParameterName = "p_mimetypeinsarch"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 50
                    param20.Value = ""
                    param20.ParameterName = "p_ioriginsarch"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 500
                    param21.Value = ""
                    param21.ParameterName = "p_xdescinsarch"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.VarChar
                    param22.Size = 20
                    param22.Value = ""
                    param22.ParameterName = "p_iestatinsarch"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.DateTime
                    param23.Value = CDate("01-01-1900")
                    param23.ParameterName = "p_fcreaaipinsarch"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.Decimal
                    param24.Precision = 18
                    param24.Scale = 0
                    param24.Value = 0
                    param24.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsarch @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsarch output,@p_idaipinsenc,@p_nsecinsarch,@p_itipoinsarch,@p_xrutainsarch,@p_xurlinsarch,@p_xtituinsarch,@p_xnominsarch,@p_xextinsarch,@p_xlatcinsarch,@p_xlonginsarch,@p_mimetypeinsarch,@p_ioriginsarch,@p_xdescinsarch,@p_iestatinsarch,@p_fcreaaipinsarch,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24)


                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipinsarchoracle(idaipinsarch)
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
        Public Function eliaipinsarchoracle(idaipinsarch As Decimal) As respopera
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
                param8.Value = idaipinsarch
                param8.ParameterName = "p_idaipinsarch"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = 0
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Int16
                param10.Value = 0
                param10.ParameterName = "p_nsecinsarch"


                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Varchar2
                param11.Size = 20
                param11.Value = " "
                param11.ParameterName = "p_itipoinsarch"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 200
                param12.Value = " "
                param12.ParameterName = "p_xrutainsarch"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Varchar2
                param13.Size = 200
                param13.Value = " "
                param13.ParameterName = "p_xurlinsarch"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Varchar2
                param14.Size = 100
                param14.Value = " "
                param14.ParameterName = "p_xtituinsarch"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 100
                param15.Value = " "
                param15.ParameterName = "p_xnominsarch"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Varchar2
                param16.Size = 5
               param16.Value = " "
               param16.ParameterName = "p_xextinsarch"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Varchar2
                param17.Size = 50
                param17.Value = " "
                param17.ParameterName = "p_xlatcinsarch"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 50
                param18.Value = " "
                param18.ParameterName = "p_xlonginsarch"


                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Varchar2
                param19.Size = 50
                param19.Value = " "
                param19.ParameterName = "p_mimetypeinsarch"


                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Varchar2
                param20.Size = 40
                param20.Value = " "
                param20.ParameterName = "p_ioriginsarch"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Varchar2
                param21.Size = 500
                param21.Value = " "
                param21.ParameterName = "p_xdescinsarch"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.Varchar2
                param22.Size = 20
                param22.Value = " "
                param22.ParameterName = "p_iestatinsarch"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.Date
                param23.Value = CDate("01-01-1900")
                param23.ParameterName = "p_fcreaaipinsarch"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.Decimal
                param24.Precision = 18
                param24.Scale = 0
                param24.Value = 0
                param24.ParameterName = "p_idseglogreg"

                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinsarch FLOAT; v_p_idaipinsenc FLOAT; v_p_nsecinsarch number; v_p_itipoinsarch VARCHAR2(20); v_p_xrutainsarch VARCHAR2(200); v_p_xurlinsarch VARCHAR2(200); v_p_xtituinsarch VARCHAR2(100); v_p_xnominsarch VARCHAR2(100); v_p_xextinsarch VARCHAR2(5); v_p_xlatcinsarch VARCHAR2(50); v_p_xlonginsarch VARCHAR2(50); v_p_mimetypeinsarch VARCHAR2(50); v_p_ioriginsarch VARCHAR2(50); v_p_xdescinsarch VARCHAR2(500); v_p_iestatinsarch VARCHAR2(20); v_p_fcreaaipinsarch date; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinsarch(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinsarch,:v_p_idaipinsenc,:v_p_nsecinsarch, :itipoinsarch,:v_p_xrutainsarch,:v_p_xurlinsarch,:v_p_xtituinsarch,:v_p_xnominsarch,:v_p_xextinsarch,:v_p_xlatcinsarch,:v_p_xlonginsarch,:v_p_ioriginsarch,:v_p_xdescinsarch, :mimetypeinsarch,:v_p_iestatinsarch,:v_p_fcreaaipinsarch,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24)

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
        Public Function actaipinsarch(aipinsarch As aipinsarch) As respopera
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
                param8.Value = aipinsarch.idaipinsarch
                param8.ParameterName = "p_idaipinsarch"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsarch.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Int
                param10.Value = aipinsarch.nsecinsarch
                param10.ParameterName = "p_nsecinsarch"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 20
                If aipinsarch.itipoinsarch IsNot Nothing Then
                    param11.Value = aipinsarch.itipoinsarch
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_itipoinsarch"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 200
                If aipinsarch.xrutainsarch IsNot Nothing Then
                    param12.Value = aipinsarch.xrutainsarch
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_xrutainsarch"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = 200
                If aipinsarch.xurlinsarch IsNot Nothing Then
                    param13.Value = aipinsarch.xurlinsarch
                Else
                    param13.Value = ""
                End If
                param13.ParameterName = "p_xurlinsarch"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = 200
                If aipinsarch.xtituinsarch IsNot Nothing Then
                    param14.Value = aipinsarch.xtituinsarch
                Else
                    param14.Value = ""
                End If
                param14.ParameterName = "p_xtituinsarch"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 100
                If aipinsarch.xnominsarch IsNot Nothing Then
                    param15.Value = aipinsarch.xnominsarch
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_xnominsarch"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.VarChar
                param16.Size = 5
                If aipinsarch.xextinsarch IsNot Nothing Then
                    param16.Value = aipinsarch.xextinsarch
                Else
                    param16.Value = ""
                End If
                param16.ParameterName = "p_xextinsarch"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.VarChar
                param17.Size = 50
                If aipinsarch.xlatcinsarch IsNot Nothing Then
                    param17.Value = aipinsarch.xlatcinsarch
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xlatcinsarch"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 50
                If aipinsarch.xlonginsarch IsNot Nothing Then
                    param18.Value = aipinsarch.xlonginsarch
                Else
                    param18.Value = ""
                End If
                param18.ParameterName = "p_xlonginsarch"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.VarChar
                param19.Size = 50
                If aipinsarch.mimetypeinsarch IsNot Nothing Then
                    param19.Value = aipinsarch.mimetypeinsarch
                Else
                    param19.Value = ""
                End If
                param19.ParameterName = "p_mimetypeinsarch"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.VarChar
                param20.Size = 50
                If aipinsarch.ioriginsarch IsNot Nothing Then
                    param20.Value = aipinsarch.ioriginsarch
                Else
                    param20.Value = ""
                End If
                param20.ParameterName = "p_ioriginsarch"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.VarChar
                param21.Size = 500
                If aipinsarch.xdescinsarch IsNot Nothing Then
                    param21.Value = aipinsarch.xdescinsarch
                Else
                    param21.Value = ""
                End If
                param21.ParameterName = "p_xdescinsarch"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.VarChar
                param22.Size = 20
                If aipinsarch.iestatinsarch IsNot Nothing Then
                    param22.Value = aipinsarch.iestatinsarch
                Else
                    param22.Value = ""
                End If
                param22.ParameterName = "p_iestatinsarch"

                Dim param23 As New SqlClient.SqlParameter
                param23.SqlDbType = SqlDbType.DateTime
                If aipinsarch.fcreaaipinsarch > CDate("01-01-1900") Then
                    param23.Value = aipinsarch.fcreaaipinsarch
                Else
                    param23.Value = CDate("01-01-1900")
                End If
                param23.ParameterName = "p_fcreaaipinsarch"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.Decimal
                param24.Precision = 18
                param24.Scale = 0
                param24.Value = aipinsarch.idseglogreg
                param24.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsarch @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsarch output,@p_idaipinsenc,@p_nsecinsarch,@p_itipoinsarch,@p_xrutainsarch,@p_xurlinsarch,@p_xtituinsarch,@p_xnominsarch,@p_xextinsarch,@p_xlatcinsarch,@p_xlonginsarch,@p_mimetypeinsarch,@p_ioriginsarch,@p_xdescinsarch,@p_iestatinsarch,@p_fcreaaipinsarch,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24)

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
        Public Function desaipinsarch(aipinsarch As aipinsarch) As respopera
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
                param8.Value = aipinsarch.idaipinsarch
                param8.ParameterName = "p_idaipinsarch"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsarch.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Int
                param10.Value = aipinsarch.nsecinsarch
                param10.ParameterName = "p_nsecinsarch"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 20
                If aipinsarch.itipoinsarch IsNot Nothing Then
                    param11.Value = aipinsarch.itipoinsarch
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_itipoinsarch"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 200
                If aipinsarch.xrutainsarch IsNot Nothing Then
                    param12.Value = aipinsarch.xrutainsarch
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_xrutainsarch"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = 200
                If aipinsarch.xurlinsarch IsNot Nothing Then
                    param13.Value = aipinsarch.xurlinsarch
                Else
                    param13.Value = ""
                End If
                param13.ParameterName = "p_xurlinsarch"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = 200
                If aipinsarch.xtituinsarch IsNot Nothing Then
                    param14.Value = aipinsarch.xtituinsarch
                Else
                    param14.Value = ""
                End If
                param14.ParameterName = "p_xtituinsarch"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 100
                If aipinsarch.xnominsarch IsNot Nothing Then
                    param15.Value = aipinsarch.xnominsarch
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_xnominsarch"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.VarChar
                param16.Size = 5
                If aipinsarch.xextinsarch IsNot Nothing Then
                    param16.Value = aipinsarch.xextinsarch
                Else
                    param16.Value = ""
                End If
                param16.ParameterName = "p_xextinsarch"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.VarChar
                param17.Size = 50
                If aipinsarch.xlatcinsarch IsNot Nothing Then
                    param17.Value = aipinsarch.xlatcinsarch
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xlatcinsarch"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 50
                If aipinsarch.xlonginsarch IsNot Nothing Then
                    param18.Value = aipinsarch.xlonginsarch
                Else
                    param18.Value = ""
                End If
                param18.ParameterName = "p_xlonginsarch"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.VarChar
                param19.Size = 50
                If aipinsarch.mimetypeinsarch IsNot Nothing Then
                    param19.Value = aipinsarch.mimetypeinsarch
                Else
                    param19.Value = ""
                End If
                param19.ParameterName = "p_mimetypeinsarch"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.VarChar
                param20.Size = 50
                If aipinsarch.ioriginsarch IsNot Nothing Then
                    param20.Value = aipinsarch.ioriginsarch
                Else
                    param20.Value = ""
                End If
                param20.ParameterName = "p_ioriginsarch"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.VarChar
                param21.Size = 500
                If aipinsarch.xdescinsarch IsNot Nothing Then
                    param21.Value = aipinsarch.xdescinsarch
                Else
                    param21.Value = ""
                End If
                param21.ParameterName = "p_xdescinsarch"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.VarChar
                param22.Size = 20
                If aipinsarch.iestatinsarch IsNot Nothing Then
                    param22.Value = aipinsarch.iestatinsarch
                Else
                    param22.Value = ""
                End If
                param22.ParameterName = "p_iestatinsarch"

                Dim param23 As New SqlClient.SqlParameter
                param23.SqlDbType = SqlDbType.DateTime
                If aipinsarch.fcreaaipinsarch > CDate("01-01-1900") Then
                    param23.Value = aipinsarch.fcreaaipinsarch
                Else
                    param23.Value = CDate("01-01-1900")
                End If
                param23.ParameterName = "p_fcreaaipinsarch"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.Decimal
                param24.Precision = 18
                param24.Scale = 0
                param24.Value = aipinsarch.idseglogreg
                param24.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsarch @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsarch output,@p_idaipinsenc,@p_nsecinsarch,@p_itipoinsarch,@p_xrutainsarch,@p_xurlinsarch,@p_xtituinsarch,@p_xnominsarch,@p_xextinsarch,@p_xlatcinsarch,@p_xlonginsarch,@p_mimetypeinsarch,@p_ioriginsarch,@p_xdescinsarch,@p_iestatinsarch,@p_fcreaaipinsarch,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24)

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
        Public Function ObtenerMaxContadorPorEncYTipo(idaipinsenc As Decimal, itipoinsarch As String) As Decimal
            Dim nsecuen As Decimal = (From p In _db.aipinsarch
                                            Where p.idaipinsenc = idaipinsenc And p.itipoinsarch = itipoinsarch
                                            Select p).DefaultIfEmpty().Max(Function(p) If(p Is Nothing, 0, p.nsecinsarch))
            Return nsecuen
        End Function

        <HttpPost()> _
        Public Function ObtenerTodosPorIdEnc(idaipinsenc As Decimal) As List(Of aipinsarch)
            Return (From p In _db.aipinsarch
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).ToList()

        End Function

    End Class
End Namespace
