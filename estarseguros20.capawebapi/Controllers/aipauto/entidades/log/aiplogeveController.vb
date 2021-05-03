Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.log
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports Oracle.ManagedDataAccess

Namespace aipauto.entidades.controlador
Public Class aiplogeveController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selaiplogevexid(idaiplogeve As Decimal) As aiplogeve
            Dim aiplogeve As aiplogeve = (From p In _db.aiplogeve
                                            Where p.idaiplogeve = idaiplogeve
                                            Select p).SingleOrDefault
            Return aiplogeve
        End Function

        <HttpPost()> _
        Public Function selaiplogeve() As List(Of aiplogeve)
            Dim lista_aiplogeve As List(Of aiplogeve) = (From p In _db.aiplogeve
                                                        Select p).ToList
            '
            Return lista_aiplogeve
        End Function

        <HttpPost()> _
           Public Function selaiplogevexwheredinamicopag(petiaiplogevepaglist As petiaiplogevepaglist) As respaiplogevepaglist
            Dim sb As New StringBuilder("")
            '
            If petiaiplogevepaglist.aiplogeve.idaiplogeve <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaiplogeve=")
                    sb.Append(valor_entero(petiaiplogevepaglist.aiplogeve.idaiplogeve))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaiplogeve=")
                        sb.Append(valor_entero(petiaiplogevepaglist.aiplogeve.idaiplogeve))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaiplogevepaglist.aiplogeve.xnomlogeve <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnomlogeve='")
                    sb.Append(petiaiplogevepaglist.aiplogeve.xnomlogeve)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnomlogeve='")
                        sb.Append(petiaiplogevepaglist.aiplogeve.xnomlogeve)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaiplogevepaglist.aiplogeve.idsegmanusu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusu=")
                    sb.Append(valor_entero(petiaiplogevepaglist.aiplogeve.idsegmanusu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusu=")
                        sb.Append(valor_entero(petiaiplogevepaglist.aiplogeve.idsegmanusu))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaiplogevepaglist.aiplogeve.fcrealogeve > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fcrealogeve >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaiplogevepaglist.aiplogeve.fcrealogeve)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fcrealogeve >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaiplogevepaglist.aiplogeve.fcrealogeve)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaiplogevepaglist.aiplogeve.iamblogeve <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iamblogeve='")
                    sb.Append(petiaiplogevepaglist.aiplogeve.iamblogeve)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iamblogeve='")
                        sb.Append(petiaiplogevepaglist.aiplogeve.iamblogeve)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaiplogevepaglist.aiplogeve.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petiaiplogevepaglist.aiplogeve.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petiaiplogevepaglist.aiplogeve.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respaiplogevepaglist As New respaiplogevepaglist
            respaiplogevepaglist.pagaiplogeve = petiaiplogevepaglist.pagaiplogeve
            Dim skip = skip_paginacion(petiaiplogevepaglist.pagaiplogeve.npagactual, petiaiplogevepaglist.pagaiplogeve.npagtamano)

            If sb.ToString = "" Then
                respaiplogevepaglist.lista_aiplogeve = _db.aiplogeve.OrderBy(petiaiplogevepaglist.pagaiplogeve.xcamposord & " " & petiaiplogevepaglist.pagaiplogeve.idirord).Skip(skip).Take(petiaiplogevepaglist.pagaiplogeve.npagtamano).ToList
            Else
                respaiplogevepaglist.lista_aiplogeve = _db.aiplogeve.Where(sb.ToString).OrderBy(petiaiplogevepaglist.pagaiplogeve.xcamposord & " " & petiaiplogevepaglist.pagaiplogeve.idirord).Skip(skip).Take(petiaiplogevepaglist.pagaiplogeve.npagtamano).ToList
            End If
            '
            If (respaiplogevepaglist.lista_aiplogeve.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selaiplogevexwheredinamicocount(sb)
                respaiplogevepaglist.pagaiplogeve.npagcantidad = cantidad_paginas(cant_entero_reg, respaiplogevepaglist.pagaiplogeve.npagtamano)
            Else
                respaiplogevepaglist.pagaiplogeve.npagcantidad = 0
                respaiplogevepaglist.pagaiplogeve.npagactual = 0
            End If

            Return respaiplogevepaglist
        End Function

        Public Function selaiplogevexwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.aiplogeve.Count
            Else
                Return _db.aiplogeve.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
        Public Function insaiplogeve(aiplogeve As aiplogeve) As respopera
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

                    param2.Value = aiplogeve.idsegmanusu
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
                    param8.ParameterName = "p_idaiplogeve"
                    param8.Direction = ParameterDirection.Output

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.VarChar
                    param9.Size = 200
                    If aiplogeve.xnomlogeve IsNot Nothing Then
                        param9.Value = aiplogeve.xnomlogeve
                    Else
                        param9.Value = ""
                    End If
                    param9.ParameterName = "p_xnomlogeve"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aiplogeve.idsegmanusu
                    param10.ParameterName = "p_idsegmanusu"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.DateTime
                    If aiplogeve.fcrealogeve > CDate("01-01-1900") Then
                        param11.Value = aiplogeve.fcrealogeve
                    Else
                        param11.Value = CDate("01-01-1900")
                    End If
                    param11.ParameterName = "p_fcrealogeve"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    If aiplogeve.iamblogeve IsNot Nothing Then
                        param12.Value = aiplogeve.iamblogeve
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_iamblogeve"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Decimal
                    param13.Precision = 18
                    param13.Scale = 0
                    param13.Value = 0
                    param13.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aiplogeve @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaiplogeve output,@p_xnomlogeve,@p_idsegmanusu,@p_fcrealogeve,@p_iamblogeve,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If

                Else
                    respopera = insaiplogeveoracle(aiplogeve)

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
        Public Function insaiplogeveoracle(aiplogeve As aiplogeve) As respopera
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
                param8.ParameterName = "p_idaiplogeve"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Varchar2
                param9.Size = 200
                If aiplogeve.xnomlogeve IsNot Nothing AND aiplogeve.xnomlogeve <> "" Then
                    param9.Value = aiplogeve.xnomlogeve
                Else
                    param9.Value = " "
                End If
                param9.ParameterName = "p_xnomlogeve"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aiplogeve.idsegmanusu
                param10.ParameterName = "p_idsegmanusu"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Date
                If aiplogeve.fcrealogeve > CDate("01-01-1900") Then
                    param11.Value = aiplogeve.fcrealogeve
                Else
                    param11.Value = CDate("01-01-1900")
                End If
                param11.ParameterName = "p_fcrealogeve"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 20
                If aiplogeve.iamblogeve IsNot Nothing AND aiplogeve.iamblogeve <> "" Then
                    param12.Value = aiplogeve.iamblogeve
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_iamblogeve"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                param13.Value = 0
                param13.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaiplogeve FLOAT; v_p_xnomlogeve VARCHAR2(200); v_p_idsegmanusu FLOAT; v_p_fcrealogeve date; v_p_iamblogeve VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aiplogeve(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaiplogeve,:v_p_xnomlogeve,:v_p_idsegmanusu,:v_p_fcrealogeve,:v_p_iamblogeve,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13)

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
        Public Function modaiplogeve(aiplogeve As aiplogeve) As respopera
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
                    param8.Value = aiplogeve.idaiplogeve
                    param8.ParameterName = "p_idaiplogeve"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.VarChar
                    param9.Size = 200
                    If aiplogeve.xnomlogeve IsNot Nothing Then
                        param9.Value = aiplogeve.xnomlogeve
                    Else
                        param9.Value = ""
                    End If
                    param9.ParameterName = "p_xnomlogeve"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aiplogeve.idsegmanusu
                    param10.ParameterName = "p_idsegmanusu"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.DateTime
                    If aiplogeve.fcrealogeve > CDate("01-01-1900") Then
                        param11.Value = aiplogeve.fcrealogeve
                    Else
                        param11.Value = CDate("01-01-1900")
                    End If
                    param11.ParameterName = "p_fcrealogeve"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    If aiplogeve.iamblogeve IsNot Nothing Then
                        param12.Value = aiplogeve.iamblogeve
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_iamblogeve"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Decimal
                    param13.Precision = 18
                    param13.Scale = 0
                    param13.Value = aiplogeve.idseglogreg
                    param13.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aiplogeve @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaiplogeve output,@p_xnomlogeve,@p_idsegmanusu,@p_fcrealogeve,@p_iamblogeve,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else

                    respopera = modaiplogeveoracle(aiplogeve)

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
        Public Function modaiplogeveoracle(aiplogeve As aiplogeve) As respopera
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
                param8.Value = aiplogeve.idaiplogeve
                param8.ParameterName = "p_idaiplogeve"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Varchar2
                param9.Size = 200
                If aiplogeve.xnomlogeve IsNot Nothing AND aiplogeve.xnomlogeve <> "" Then
                    param9.Value = aiplogeve.xnomlogeve
                Else
                    param9.Value = " "
                End If
                param9.ParameterName = "p_xnomlogeve"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aiplogeve.idsegmanusu
                param10.ParameterName = "p_idsegmanusu"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Date
                If aiplogeve.fcrealogeve > CDate("01-01-1900") Then
                    param11.Value = aiplogeve.fcrealogeve
                Else
                    param11.Value = CDate("01-01-1900")
                End If
                param11.ParameterName = "p_fcrealogeve"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 20
                If aiplogeve.iamblogeve IsNot Nothing AND aiplogeve.iamblogeve <> "" Then
                    param12.Value = aiplogeve.iamblogeve
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_iamblogeve"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                param13.Value = aiplogeve.idseglogreg
                param13.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaiplogeve FLOAT; v_p_xnomlogeve VARCHAR2(200); v_p_idsegmanusu FLOAT; v_p_fcrealogeve date; v_p_iamblogeve VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aiplogeve(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaiplogeve,:v_p_xnomlogeve,:v_p_idsegmanusu,:v_p_fcrealogeve,:v_p_iamblogeve,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13)

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
        Public Function eliaiplogeve(aiplogeve As aiplogeve) As respopera
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
                    param8.Value = aiplogeve.idaiplogeve
                    param8.ParameterName = "p_idaiplogeve"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.VarChar
                    param9.Size = 200
                    If aiplogeve.xnomlogeve IsNot Nothing Then
                        param9.Value = aiplogeve.xnomlogeve
                    Else
                        param9.Value = ""
                    End If
                    param9.ParameterName = "p_xnomlogeve"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aiplogeve.idsegmanusu
                    param10.ParameterName = "p_idsegmanusu"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.DateTime
                    If aiplogeve.fcrealogeve > CDate("01-01-1900") Then
                        param11.Value = aiplogeve.fcrealogeve
                    Else
                        param11.Value = CDate("01-01-1900")
                    End If
                    param11.ParameterName = "p_fcrealogeve"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    If aiplogeve.iamblogeve IsNot Nothing Then
                        param12.Value = aiplogeve.iamblogeve
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_iamblogeve"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Decimal
                    param13.Precision = 18
                    param13.Scale = 0
                    param13.Value = aiplogeve.idseglogreg
                    param13.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aiplogeve @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaiplogeve output,@p_xnomlogeve,@p_idsegmanusu,@p_fcrealogeve,@p_iamblogeve,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else

                    respopera = eliaiplogeveoracle(aiplogeve)

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
        Public Function eliaiplogeveoracle(aiplogeve As aiplogeve) As respopera
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
                param8.Value = aiplogeve.idaiplogeve
                param8.ParameterName = "p_idaiplogeve"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Varchar2
                param9.Size = 200
                If aiplogeve.xnomlogeve IsNot Nothing AND aiplogeve.xnomlogeve <> "" Then
                    param9.Value = aiplogeve.xnomlogeve
                Else
                    param9.Value = " "
                End If
                param9.ParameterName = "p_xnomlogeve"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aiplogeve.idsegmanusu
                param10.ParameterName = "p_idsegmanusu"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Date
                If aiplogeve.fcrealogeve > CDate("01-01-1900") Then
                    param11.Value = aiplogeve.fcrealogeve
                Else
                    param11.Value = CDate("01-01-1900")
                End If
                param11.ParameterName = "p_fcrealogeve"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 20
                If aiplogeve.iamblogeve IsNot Nothing AND aiplogeve.iamblogeve <> "" Then
                    param12.Value = aiplogeve.iamblogeve
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_iamblogeve"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                param13.Value = aiplogeve.idseglogreg
                param13.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaiplogeve FLOAT; v_p_xnomlogeve VARCHAR2(200); v_p_idsegmanusu FLOAT; v_p_fcrealogeve date; v_p_iamblogeve VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aiplogeve(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaiplogeve,:v_p_xnomlogeve,:v_p_idsegmanusu,:v_p_fcrealogeve,:v_p_iamblogeve,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13)

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
        Public Function eliaiplogeve(idaiplogeve As Decimal) As respopera
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
                    param8.Value = idaiplogeve
                    param8.ParameterName = "p_idaiplogeve"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.VarChar
                    param9.Size = 200
                    param9.Value = ""
                    param9.ParameterName = "p_xnomlogeve"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = 0
                    param10.ParameterName = "p_idsegmanusu"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.DateTime
                    param11.Value = CDate("01-01-1900")
                    param11.ParameterName = "p_fcrealogeve"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    param12.Value = ""
                    param12.ParameterName = "p_iamblogeve"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Decimal
                    param13.Precision = 18
                    param13.Scale = 0
                    param13.Value = 0
                    param13.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aiplogeve @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaiplogeve output,@p_xnomlogeve,@p_idsegmanusu,@p_fcrealogeve,@p_iamblogeve,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If

                Else

                    respopera = eliaiplogeveoracle(idaiplogeve)

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
        Public Function eliaiplogeveoracle(idaiplogeve As Decimal) As respopera
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
                param8.Value = idaiplogeve
                param8.ParameterName = "p_idaiplogeve"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Varchar2
                param9.Size = 200
                param9.Value = " "
                param9.ParameterName = "p_xnomlogeve"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = 0
                param10.ParameterName = "p_idsegmanusu"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Date
                param11.Value = CDate("01-01-1900")
                param11.ParameterName = "p_fcrealogeve"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 20
                param12.Value = " "
                param12.ParameterName = "p_iamblogeve"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                param13.Value = 0
                param13.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaiplogeve FLOAT; v_p_xnomlogeve VARCHAR2(200); v_p_idsegmanusu FLOAT; v_p_fcrealogeve date; v_p_iamblogeve VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aiplogeve(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaiplogeve,:v_p_xnomlogeve,:v_p_idsegmanusu,:v_p_fcrealogeve,:v_p_iamblogeve,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13)

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
        Public Function actaiplogeve(aiplogeve As aiplogeve) As respopera
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
                param8.Value = aiplogeve.idaiplogeve
                param8.ParameterName = "p_idaiplogeve"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 200
                If aiplogeve.xnomlogeve IsNot Nothing Then
                    param9.Value = aiplogeve.xnomlogeve
                Else
                    param9.Value = ""
                End If
                param9.ParameterName = "p_xnomlogeve"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aiplogeve.idsegmanusu
                param10.ParameterName = "p_idsegmanusu"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.DateTime
                If aiplogeve.fcrealogeve > CDate("01-01-1900") Then
                    param11.Value = aiplogeve.fcrealogeve
                Else
                    param11.Value = CDate("01-01-1900")
                End If
                param11.ParameterName = "p_fcrealogeve"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                If aiplogeve.iamblogeve IsNot Nothing Then
                    param12.Value = aiplogeve.iamblogeve
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_iamblogeve"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                param13.Value = aiplogeve.idseglogreg
                param13.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aiplogeve @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaiplogeve output,@p_xnomlogeve,@p_idsegmanusu,@p_fcrealogeve,@p_iamblogeve,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13)

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
        Public Function desaiplogeve(aiplogeve As aiplogeve) As respopera
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
                param8.Value = aiplogeve.idaiplogeve
                param8.ParameterName = "p_idaiplogeve"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = 200
                If aiplogeve.xnomlogeve IsNot Nothing Then
                    param9.Value = aiplogeve.xnomlogeve
                Else
                    param9.Value = ""
                End If
                param9.ParameterName = "p_xnomlogeve"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aiplogeve.idsegmanusu
                param10.ParameterName = "p_idsegmanusu"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.DateTime
                If aiplogeve.fcrealogeve > CDate("01-01-1900") Then
                    param11.Value = aiplogeve.fcrealogeve
                Else
                    param11.Value = CDate("01-01-1900")
                End If
                param11.ParameterName = "p_fcrealogeve"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                If aiplogeve.iamblogeve IsNot Nothing Then
                    param12.Value = aiplogeve.iamblogeve
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_iamblogeve"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                param13.Value = aiplogeve.idseglogreg
                param13.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aiplogeve @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaiplogeve output,@p_xnomlogeve,@p_idsegmanusu,@p_fcrealogeve,@p_iamblogeve,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13)

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


        ''personalizados
        <HttpPost()> _
        Public Function ObtenerCantidadPorIamblogeve(iamblogeve As String) As Decimal
            Dim cantidad As Decimal = (From p In _db.aiplogeve
                                                         Where p.iamblogeve = iamblogeve
                                                        Select p).Count
            '
            Return cantidad
        End Function

        <HttpPost()> _
        Public Function ObtenerPorIamblogeve(iamblogeve As String) As List(Of aiplogeve)
            Dim lista_aiplogeve As List(Of aiplogeve) = (From p In _db.aiplogeve
                                                         Where p.iamblogeve = iamblogeve
                                                        Select p).ToList
            '
            Return lista_aiplogeve
        End Function


End Class
End Namespace
