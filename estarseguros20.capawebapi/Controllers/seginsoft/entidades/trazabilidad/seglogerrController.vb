Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.entidades.trazabilidad
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports Oracle.ManagedDataAccess
Namespace seginsoft.entidades.controlador
    Public Class seglogerrController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selseglogerrxid(idseglogerr As Decimal) As seglogerr
            Dim seglogerr As seglogerr = (From p In _db.seglogerr
                                            Where p.idseglogerr = idseglogerr
                                            Select p).SingleOrDefault
            Return seglogerr
        End Function

        <HttpPost()> _
        Public Function selseglogerr() As List(Of seglogerr)
            Dim lista_seglogerr As List(Of seglogerr) = (From p In _db.seglogerr
                                                        Select p).ToList
            '
            Return lista_seglogerr
        End Function

        <HttpPost()> _
        Public Function selseglogerrxwheredinamicopag(petiseglogerrpaglist As petiseglogerrpaglist) As respseglogerrpaglist
            Dim sb As New StringBuilder("")
            '
            If petiseglogerrpaglist.seglogerr.idseglogerr <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogerr=")
                    sb.Append(valor_entero(petiseglogerrpaglist.seglogerr.idseglogerr))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogerr=")
                        sb.Append(valor_entero(petiseglogerrpaglist.seglogerr.idseglogerr))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiseglogerrpaglist.seglogerr.xdatoslogerr <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdatoslogerr='")
                    sb.Append(petiseglogerrpaglist.seglogerr.xdatoslogerr)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdatoslogerr='")
                        sb.Append(petiseglogerrpaglist.seglogerr.xdatoslogerr)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiseglogerrpaglist.seglogerr.flogerr > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.flogerr >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiseglogerrpaglist.seglogerr.flogerr)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.flogerr >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiseglogerrpaglist.seglogerr.flogerr)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiseglogerrpaglist.seglogerr.xexhelplink <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xexhelplink='")
                    sb.Append(petiseglogerrpaglist.seglogerr.xexhelplink)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xexhelplink='")
                        sb.Append(petiseglogerrpaglist.seglogerr.xexhelplink)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiseglogerrpaglist.seglogerr.xexinnerexception <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xexinnerexception='")
                    sb.Append(petiseglogerrpaglist.seglogerr.xexinnerexception)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xexinnerexception='")
                        sb.Append(petiseglogerrpaglist.seglogerr.xexinnerexception)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiseglogerrpaglist.seglogerr.xexmessage <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xexmessage='")
                    sb.Append(petiseglogerrpaglist.seglogerr.xexmessage)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xexmessage='")
                        sb.Append(petiseglogerrpaglist.seglogerr.xexmessage)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiseglogerrpaglist.seglogerr.xexsource <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xexsource='")
                    sb.Append(petiseglogerrpaglist.seglogerr.xexsource)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xexsource='")
                        sb.Append(petiseglogerrpaglist.seglogerr.xexsource)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiseglogerrpaglist.seglogerr.xextargetsite <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xextargetsite='")
                    sb.Append(petiseglogerrpaglist.seglogerr.xextargetsite)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xextargetsite='")
                        sb.Append(petiseglogerrpaglist.seglogerr.xextargetsite)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiseglogerrpaglist.seglogerr.xexstacktrace <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xexstacktrace='")
                    sb.Append(petiseglogerrpaglist.seglogerr.xexstacktrace)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xexstacktrace='")
                        sb.Append(petiseglogerrpaglist.seglogerr.xexstacktrace)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiseglogerrpaglist.seglogerr.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petiseglogerrpaglist.seglogerr.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petiseglogerrpaglist.seglogerr.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respseglogerrpaglist As New respseglogerrpaglist
            respseglogerrpaglist.pagseglogerr = petiseglogerrpaglist.pagseglogerr
            Dim skip = skip_paginacion(petiseglogerrpaglist.pagseglogerr.npagactual, petiseglogerrpaglist.pagseglogerr.npagtamano)

            If sb.ToString = "" Then
                respseglogerrpaglist.lista_seglogerr = _db.seglogerr.OrderBy(petiseglogerrpaglist.pagseglogerr.xcamposord & " " & petiseglogerrpaglist.pagseglogerr.idirord).Skip(skip).Take(petiseglogerrpaglist.pagseglogerr.npagtamano).ToList
            Else
                respseglogerrpaglist.lista_seglogerr = _db.seglogerr.Where(sb.ToString).OrderBy(petiseglogerrpaglist.pagseglogerr.xcamposord & " " & petiseglogerrpaglist.pagseglogerr.idirord).Skip(skip).Take(petiseglogerrpaglist.pagseglogerr.npagtamano).ToList
            End If
            '
            If (respseglogerrpaglist.lista_seglogerr.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selseglogerrxwheredinamicocount(sb)
                respseglogerrpaglist.pagseglogerr.npagcantidad = cantidad_paginas(cant_entero_reg, respseglogerrpaglist.pagseglogerr.npagtamano)
            Else
                respseglogerrpaglist.pagseglogerr.npagcantidad = 0
                respseglogerrpaglist.pagseglogerr.npagactual = 0
            End If

            Return respseglogerrpaglist
        End Function

        Public Function selseglogerrxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.seglogerr.count
            Else
                Return _db.seglogerr.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
        Public Function insseglogerr(seglogerr As seglogerr) As respopera
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
                    param3.value = "aipauto"
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
                    param8.ParameterName = "p_idseglogerr"
                    param8.Direction = ParameterDirection.Output

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.varchar
                    param9.Size = -1
                    If seglogerr.xdatoslogerr IsNot Nothing Then
                        param9.Value = seglogerr.xdatoslogerr
                    Else
                        param9.Value = ""
                    End If
                    param9.ParameterName = "p_xdatoslogerr"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.datetime
                    If seglogerr.flogerr > CDate("01-01-1900") Then
                        param10.Value = seglogerr.flogerr
                    Else
                        param10.Value = CDate("01-01-1900")
                    End If
                    param10.ParameterName = "p_flogerr"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.varchar
                    param11.Size = 500
                    If seglogerr.xexhelplink IsNot Nothing Then
                        param11.Value = seglogerr.xexhelplink
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_xexhelplink"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.varchar
                    param12.Size = -1
                    If seglogerr.xexinnerexception IsNot Nothing Then
                        param12.Value = seglogerr.xexinnerexception
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_xexinnerexception"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.varchar
                    param13.Size = -1
                    If seglogerr.xexmessage IsNot Nothing Then
                        param13.Value = seglogerr.xexmessage
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_xexmessage"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.varchar
                    param14.Size = -1
                    If seglogerr.xexsource IsNot Nothing Then
                        param14.Value = seglogerr.xexsource
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_xexsource"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.varchar
                    param15.Size = -1
                    If seglogerr.xextargetsite IsNot Nothing Then
                        param15.Value = seglogerr.xextargetsite
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xextargetsite"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.varchar
                    param16.Size = -1
                    If seglogerr.xexstacktrace IsNot Nothing Then
                        param16.Value = seglogerr.xexstacktrace
                    Else
                        param16.Value = ""
                    End If
                    param16.ParameterName = "p_xexstacktrace"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.decimal
                    param17.Precision = 18
                    param17.Scale = 0
                    param17.Value = 0
                    param17.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_seglogerr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idseglogerr output,@p_xdatoslogerr,@p_flogerr,@p_xexhelplink,@p_xexinnerexception,@p_xexmessage,@p_xexsource,@p_xextargetsite,@p_xexstacktrace,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17)

                    respopera.irespuesta = param4.Value.ToString()
                    respopera.xmsjusuario = param5.Value.ToString()
                    respopera.xmsjtecnico = param6.Value.ToString()
                    If IsNumeric(param8.Value.ToString()) = True Then
                        respopera.id = Int(param8.ToString())
                    End If

                Else

                    respopera = insseglogerroracle(seglogerr)

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
        Public Function insseglogerroracle(seglogerr As seglogerr) As respopera
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
                param8.ParameterName = "p_idseglogerr"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Varchar2
                param9.Size = 32765
                If seglogerr.xdatoslogerr IsNot Nothing Then
                    If seglogerr.xdatoslogerr <> "" Then
                        param9.Value = seglogerr.xdatoslogerr
                    Else
                        param9.Value = " "
                    End If
                Else
                    param9.Value = " "
                End If
                param9.ParameterName = "p_xdatoslogerr"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Date
                If seglogerr.flogerr > CDate("01-01-1900") Then
                    param10.Value = seglogerr.flogerr
                Else
                    param10.Value = CDate("01-01-1900")
                End If
                param10.ParameterName = "p_flogerr"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Varchar2
                param11.Size = 500
                If seglogerr.xexhelplink IsNot Nothing Then
                    If seglogerr.xexhelplink <> "" Then
                        param11.Value = seglogerr.xexhelplink
                    Else
                        param11.Value = " "
                    End If
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_xexhelplink"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 32765
                If seglogerr.xexinnerexception IsNot Nothing Then
                    If seglogerr.xexinnerexception <> "" Then
                        param12.Value = seglogerr.xexinnerexception
                    Else
                        param12.Value = " "
                    End If
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_xexinnerexception"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Varchar2
                param13.Size = 32765
                If seglogerr.xexmessage IsNot Nothing Then
                    If seglogerr.xexmessage <> "" Then
                        param13.Value = seglogerr.xexmessage
                    Else
                        param13.Value = " "
                    End If
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_xexmessage"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Varchar2
                param14.Size = 32765
                If seglogerr.xexsource IsNot Nothing Then
                    If seglogerr.xexsource <> "" Then
                        param14.Value = seglogerr.xexsource
                    Else
                        param14.Value = " "
                    End If
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_xexsource"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 32765
                If seglogerr.xextargetsite IsNot Nothing Then
                    If seglogerr.xextargetsite <> "" Then
                        param15.Value = seglogerr.xextargetsite
                    Else
                        param15.Value = " "
                    End If
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xextargetsite"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Varchar2
                param16.Size = 32765
                If seglogerr.xexstacktrace IsNot Nothing Then
                    If seglogerr.xexstacktrace <> "" Then
                        param16.Value = seglogerr.xexstacktrace
                    Else
                        param16.Value = " "
                    End If
                Else
                    param16.Value = " "
                End If
                param16.ParameterName = "p_xexstacktrace"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Decimal
                param17.Precision = 18
                param17.Scale = 0
                param17.Value = 0
                param17.ParameterName = "p_idseglogreg"
                'Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idseglogerr FLOAT; v_p_xdatoslogerr VARCHAR(232767); v_p_flogerr date; v_p_xexhelplink VARCHAR2(32767); v_p_xexinnerexception VARCHAR2(32767); v_p_xexmessage VARCHAR2(32767); v_p_xexsource VARCHAR2(32767); v_p_xextargetsite VARCHAR2(32767); v_p_xexstacktrace VARCHAR2(32767); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor;"
                Dim xdeclare As String = "DECLARE v_p_ioperacion varchar2(32767);v_p_idsegmanusulog float;v_p_xnombrecortolog varchar2(32767); v_p_irespuesta varchar2(32767);v_p_xmsjusuario varchar2(32767);v_p_xmsjtecnico varchar2(32767);  v_p_coderrorlog varchar2(32767);  v_p_idseglogerr float;  v_p_xdatoslogerr varchar2(32767);  v_p_flogerr date;  v_p_xexhelplink varchar2(32767);  v_p_xexinnerexception varchar2(32767);  v_p_xexmessage varchar2(32767);  v_p_xexsource varchar2(32767);  v_p_xextargetsite varchar2(32767);  v_p_xexstacktrace varchar2(32767);  v_p_idseglogreg float; cv_1 sys_refcursor; cv_2 sys_refcursor;"
                Dim xsp As String = "begin sp_seglogerr(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idseglogerr,:v_p_xdatoslogerr,:v_p_flogerr,:v_p_xexhelplink,:v_p_xexinnerexception,:v_p_xexmessage,:v_p_xexsource,:v_p_xextargetsite,:v_p_xexstacktrace,:v_p_idseglogreg, cv_1, cv_2); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17)

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
        Public Function modseglogerr(seglogerr As seglogerr) As respopera
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
                    param3.value = "aipauto"
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
                    param8.Value = seglogerr.idseglogerr
                    param8.ParameterName = "p_idseglogerr"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.varchar
                    param9.Size = -1
                    If seglogerr.xdatoslogerr IsNot Nothing Then
                        param9.Value = seglogerr.xdatoslogerr
                    Else
                        param9.Value = ""
                    End If
                    param9.ParameterName = "p_xdatoslogerr"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.datetime
                    If seglogerr.flogerr > CDate("01-01-1900") Then
                        param10.Value = seglogerr.flogerr
                    Else
                        param10.Value = CDate("01-01-1900")
                    End If
                    param10.ParameterName = "p_flogerr"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.varchar
                    param11.Size = 500
                    If seglogerr.xexhelplink IsNot Nothing Then
                        param11.Value = seglogerr.xexhelplink
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_xexhelplink"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.varchar
                    param12.Size = -1
                    If seglogerr.xexinnerexception IsNot Nothing Then
                        param12.Value = seglogerr.xexinnerexception
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_xexinnerexception"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.varchar
                    param13.Size = -1
                    If seglogerr.xexmessage IsNot Nothing Then
                        param13.Value = seglogerr.xexmessage
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_xexmessage"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.varchar
                    param14.Size = -1
                    If seglogerr.xexsource IsNot Nothing Then
                        param14.Value = seglogerr.xexsource
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_xexsource"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.varchar
                    param15.Size = -1
                    If seglogerr.xextargetsite IsNot Nothing Then
                        param15.Value = seglogerr.xextargetsite
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xextargetsite"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.varchar
                    param16.Size = -1
                    If seglogerr.xexstacktrace IsNot Nothing Then
                        param16.Value = seglogerr.xexstacktrace
                    Else
                        param16.Value = ""
                    End If
                    param16.ParameterName = "p_xexstacktrace"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.decimal
                    param17.Precision = 18
                    param17.Scale = 0
                    param17.Value = seglogerr.idseglogreg
                    param17.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_seglogerr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idseglogerr output,@p_xdatoslogerr,@p_flogerr,@p_xexhelplink,@p_xexinnerexception,@p_xexmessage,@p_xexsource,@p_xextargetsite,@p_xexstacktrace,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17)

                    respopera.irespuesta = param4.Value.ToString()
                    respopera.xmsjusuario = param5.Value.ToString()
                    respopera.xmsjtecnico = param6.Value.ToString()
                    If IsNumeric(param8.Value.ToString()) = True Then
                        respopera.id = Int(param8.ToString())
                    End If

                Else

                    respopera = modseglogerroracle(seglogerr)

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
        Public Function modseglogerroracle(seglogerr As seglogerr) As respopera
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
                param8.Value = seglogerr.idseglogerr
                param8.ParameterName = "p_idseglogerr"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.VARCHAR2
                param9.Size = -1
                If seglogerr.xdatoslogerr IsNot Nothing And seglogerr.xdatoslogerr <> "" Then
                    param9.Value = seglogerr.xdatoslogerr
                Else
                    param9.Value = " "
                End If
                param9.ParameterName = "p_xdatoslogerr"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Date
                If seglogerr.flogerr > CDate("01-01-1900") Then
                    param10.Value = seglogerr.flogerr
                Else
                    param10.Value = CDate("01-01-1900")
                End If
                param10.ParameterName = "p_flogerr"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.VARCHAR2
                param11.Size = 500
                If seglogerr.xexhelplink IsNot Nothing And seglogerr.xexhelplink <> "" Then
                    param11.Value = seglogerr.xexhelplink
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_xexhelplink"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.VARCHAR2
                param12.Size = -1
                If seglogerr.xexinnerexception IsNot Nothing And seglogerr.xexinnerexception <> "" Then
                    param12.Value = seglogerr.xexinnerexception
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_xexinnerexception"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = -1
                If seglogerr.xexmessage IsNot Nothing And seglogerr.xexmessage <> "" Then
                    param13.Value = seglogerr.xexmessage
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_xexmessage"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = -1
                If seglogerr.xexsource IsNot Nothing And seglogerr.xexsource <> "" Then
                    param14.Value = seglogerr.xexsource
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_xexsource"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.VARCHAR2
                param15.Size = -1
                If seglogerr.xextargetsite IsNot Nothing And seglogerr.xextargetsite <> "" Then
                    param15.Value = seglogerr.xextargetsite
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xextargetsite"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.VARCHAR2
                param16.Size = -1
                If seglogerr.xexstacktrace IsNot Nothing And seglogerr.xexstacktrace <> "" Then
                    param16.Value = seglogerr.xexstacktrace
                Else
                    param16.Value = " "
                End If
                param16.ParameterName = "p_xexstacktrace"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Decimal
                param17.Precision = 18
                param17.Scale = 0
                param17.Value = seglogerr.idseglogreg
                param17.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idseglogerr FLOAT; v_p_xdatoslogerr VARCHAR2(-1); v_p_flogerr date; v_p_xexhelplink VARCHAR2(500); v_p_xexinnerexception VARCHAR2(-1); v_p_xexmessage VARCHAR2(-1); v_p_xexsource VARCHAR2(-1); v_p_xextargetsite VARCHAR2(-1); v_p_xexstacktrace VARCHAR2(-1); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_seglogerr(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idseglogerr,:v_p_xdatoslogerr,:v_p_flogerr,:v_p_xexhelplink,:v_p_xexinnerexception,:v_p_xexmessage,:v_p_xexsource,:v_p_xextargetsite,:v_p_xexstacktrace,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17)

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
        Public Function eliseglogerr(seglogerr As seglogerr) As respopera
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
                    param3.value = "aipauto"
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
                    param8.Value = seglogerr.idseglogerr
                    param8.ParameterName = "p_idseglogerr"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.varchar
                    param9.Size = -1
                    If seglogerr.xdatoslogerr IsNot Nothing Then
                        param9.Value = seglogerr.xdatoslogerr
                    Else
                        param9.Value = ""
                    End If
                    param9.ParameterName = "p_xdatoslogerr"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.datetime
                    If seglogerr.flogerr > CDate("01-01-1900") Then
                        param10.Value = seglogerr.flogerr
                    Else
                        param10.Value = CDate("01-01-1900")
                    End If
                    param10.ParameterName = "p_flogerr"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.varchar
                    param11.Size = 500
                    If seglogerr.xexhelplink IsNot Nothing Then
                        param11.Value = seglogerr.xexhelplink
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_xexhelplink"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.varchar
                    param12.Size = -1
                    If seglogerr.xexinnerexception IsNot Nothing Then
                        param12.Value = seglogerr.xexinnerexception
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_xexinnerexception"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.varchar
                    param13.Size = -1
                    If seglogerr.xexmessage IsNot Nothing Then
                        param13.Value = seglogerr.xexmessage
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_xexmessage"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.varchar
                    param14.Size = -1
                    If seglogerr.xexsource IsNot Nothing Then
                        param14.Value = seglogerr.xexsource
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_xexsource"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.varchar
                    param15.Size = -1
                    If seglogerr.xextargetsite IsNot Nothing Then
                        param15.Value = seglogerr.xextargetsite
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xextargetsite"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.varchar
                    param16.Size = -1
                    If seglogerr.xexstacktrace IsNot Nothing Then
                        param16.Value = seglogerr.xexstacktrace
                    Else
                        param16.Value = ""
                    End If
                    param16.ParameterName = "p_xexstacktrace"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.decimal
                    param17.Precision = 18
                    param17.Scale = 0
                    param17.Value = seglogerr.idseglogreg
                    param17.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_seglogerr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idseglogerr output,@p_xdatoslogerr,@p_flogerr,@p_xexhelplink,@p_xexinnerexception,@p_xexmessage,@p_xexsource,@p_xextargetsite,@p_xexstacktrace,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17)

                    respopera.irespuesta = param4.Value.ToString()
                    respopera.xmsjusuario = param5.Value.ToString()
                    respopera.xmsjtecnico = param6.Value.ToString()
                    If IsNumeric(param8.Value.ToString()) = True Then
                        respopera.id = Int(param8.ToString())
                    End If

                Else

                    respopera = eliseglogerroracle(seglogerr)

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
        Public Function eliseglogerroracle(seglogerr As seglogerr) As respopera
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
                param8.Value = seglogerr.idseglogerr
                param8.ParameterName = "p_idseglogerr"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.VARCHAR2
                param9.Size = -1
                If seglogerr.xdatoslogerr IsNot Nothing And seglogerr.xdatoslogerr <> "" Then
                    param9.Value = seglogerr.xdatoslogerr
                Else
                    param9.Value = " "
                End If
                param9.ParameterName = "p_xdatoslogerr"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Date
                If seglogerr.flogerr > CDate("01-01-1900") Then
                    param10.Value = seglogerr.flogerr
                Else
                    param10.Value = CDate("01-01-1900")
                End If
                param10.ParameterName = "p_flogerr"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.VARCHAR2
                param11.Size = 500
                If seglogerr.xexhelplink IsNot Nothing And seglogerr.xexhelplink <> "" Then
                    param11.Value = seglogerr.xexhelplink
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_xexhelplink"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.VARCHAR2
                param12.Size = -1
                If seglogerr.xexinnerexception IsNot Nothing And seglogerr.xexinnerexception <> "" Then
                    param12.Value = seglogerr.xexinnerexception
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_xexinnerexception"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = -1
                If seglogerr.xexmessage IsNot Nothing And seglogerr.xexmessage <> "" Then
                    param13.Value = seglogerr.xexmessage
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_xexmessage"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = -1
                If seglogerr.xexsource IsNot Nothing And seglogerr.xexsource <> "" Then
                    param14.Value = seglogerr.xexsource
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_xexsource"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.VARCHAR2
                param15.Size = -1
                If seglogerr.xextargetsite IsNot Nothing And seglogerr.xextargetsite <> "" Then
                    param15.Value = seglogerr.xextargetsite
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xextargetsite"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.VARCHAR2
                param16.Size = -1
                If seglogerr.xexstacktrace IsNot Nothing And seglogerr.xexstacktrace <> "" Then
                    param16.Value = seglogerr.xexstacktrace
                Else
                    param16.Value = " "
                End If
                param16.ParameterName = "p_xexstacktrace"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Decimal
                param17.Precision = 18
                param17.Scale = 0
                param17.Value = seglogerr.idseglogreg
                param17.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idseglogerr FLOAT; v_p_xdatoslogerr VARCHAR2(-1); v_p_flogerr date; v_p_xexhelplink VARCHAR2(500); v_p_xexinnerexception VARCHAR2(-1); v_p_xexmessage VARCHAR2(-1); v_p_xexsource VARCHAR2(-1); v_p_xextargetsite VARCHAR2(-1); v_p_xexstacktrace VARCHAR2(-1); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_seglogerr(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idseglogerr,:v_p_xdatoslogerr,:v_p_flogerr,:v_p_xexhelplink,:v_p_xexinnerexception,:v_p_xexmessage,:v_p_xexsource,:v_p_xextargetsite,:v_p_xexstacktrace,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17)

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
        Public Function eliseglogerr(idseglogerr As Decimal) As respopera
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
                    param3.value = "aipauto"
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
                    param8.Value = idseglogerr
                    param8.ParameterName = "p_idseglogerr"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.varchar
                    param9.Size = -1
                    param9.Value = ""
                    param9.ParameterName = "p_xdatoslogerr"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.datetime
                    param10.Value = CDate("01-01-1900")
                    param10.ParameterName = "p_flogerr"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.varchar
                    param11.Size = 500
                    param11.Value = ""
                    param11.ParameterName = "p_xexhelplink"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.varchar
                    param12.Size = -1
                    param12.Value = ""
                    param12.ParameterName = "p_xexinnerexception"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.varchar
                    param13.Size = -1
                    param13.Value = ""
                    param13.ParameterName = "p_xexmessage"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.varchar
                    param14.Size = -1
                    param14.Value = ""
                    param14.ParameterName = "p_xexsource"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.varchar
                    param15.Size = -1
                    param15.Value = ""
                    param15.ParameterName = "p_xextargetsite"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.varchar
                    param16.Size = -1
                    param16.Value = ""
                    param16.ParameterName = "p_xexstacktrace"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.decimal
                    param17.Precision = 18
                    param17.Scale = 0
                    param17.Value = 0
                    param17.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_seglogerr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idseglogerr output,@p_xdatoslogerr,@p_flogerr,@p_xexhelplink,@p_xexinnerexception,@p_xexmessage,@p_xexsource,@p_xextargetsite,@p_xexstacktrace,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17)

                    respopera.irespuesta = param4.Value.ToString()
                    respopera.xmsjusuario = param5.Value.ToString()
                    respopera.xmsjtecnico = param6.Value.ToString()
                    If IsNumeric(param8.Value.ToString()) = True Then
                        respopera.id = Int(param8.ToString())
                    End If

                Else

                    respopera = eliseglogerroracle(idseglogerr)

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
        Public Function eliseglogerroracle(idseglogerr As Decimal) As respopera
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
                param8.Value = idseglogerr
                param8.ParameterName = "p_idseglogerr"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.VARCHAR2
                param9.Size = -1
                param9.Value = " "
                param9.ParameterName = "p_xdatoslogerr"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Date
                param10.Value = CDate("01-01-1900")
                param10.ParameterName = "p_flogerr"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.VARCHAR2
                param11.Size = 500
                param11.Value = " "
                param11.ParameterName = "p_xexhelplink"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.VARCHAR2
                param12.Size = -1
                param12.Value = " "
                param12.ParameterName = "p_xexinnerexception"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = -1
                param13.Value = " "
                param13.ParameterName = "p_xexmessage"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = -1
                param14.Value = " "
                param14.ParameterName = "p_xexsource"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.VARCHAR2
                param15.Size = -1
                param15.Value = " "
                param15.ParameterName = "p_xextargetsite"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.VARCHAR2
                param16.Size = -1
                param16.Value = " "
                param16.ParameterName = "p_xexstacktrace"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Decimal
                param17.Precision = 18
                param17.Scale = 0
                param17.Value = 0
                param17.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idseglogerr FLOAT; v_p_xdatoslogerr VARCHAR2(-1); v_p_flogerr date; v_p_xexhelplink VARCHAR2(500); v_p_xexinnerexception VARCHAR2(-1); v_p_xexmessage VARCHAR2(-1); v_p_xexsource VARCHAR2(-1); v_p_xextargetsite VARCHAR2(-1); v_p_xexstacktrace VARCHAR2(-1); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_seglogerr(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idseglogerr,:v_p_xdatoslogerr,:v_p_flogerr,:v_p_xexhelplink,:v_p_xexinnerexception,:v_p_xexmessage,:v_p_xexsource,:v_p_xextargetsite,:v_p_xexstacktrace,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17)

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
        Public Function actseglogerr(seglogerr As seglogerr) As respopera
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
                param8.Value = seglogerr.idseglogerr
                param8.ParameterName = "p_idseglogerr"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = -1
                If seglogerr.xdatoslogerr IsNot Nothing Then
                    param9.Value = seglogerr.xdatoslogerr
                Else
                    param9.Value = ""
                End If
                param9.ParameterName = "p_xdatoslogerr"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.DateTime
                If seglogerr.flogerr > CDate("01-01-1900") Then
                    param10.Value = seglogerr.flogerr
                Else
                    param10.Value = CDate("01-01-1900")
                End If
                param10.ParameterName = "p_flogerr"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 500
                If seglogerr.xexhelplink IsNot Nothing Then
                    param11.Value = seglogerr.xexhelplink
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_xexhelplink"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = -1
                If seglogerr.xexinnerexception IsNot Nothing Then
                    param12.Value = seglogerr.xexinnerexception
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_xexinnerexception"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = -1
                If seglogerr.xexmessage IsNot Nothing Then
                    param13.Value = seglogerr.xexmessage
                Else
                    param13.Value = ""
                End If
                param13.ParameterName = "p_xexmessage"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = -1
                If seglogerr.xexsource IsNot Nothing Then
                    param14.Value = seglogerr.xexsource
                Else
                    param14.Value = ""
                End If
                param14.ParameterName = "p_xexsource"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = -1
                If seglogerr.xextargetsite IsNot Nothing Then
                    param15.Value = seglogerr.xextargetsite
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_xextargetsite"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.VarChar
                param16.Size = -1
                If seglogerr.xexstacktrace IsNot Nothing Then
                    param16.Value = seglogerr.xexstacktrace
                Else
                    param16.Value = ""
                End If
                param16.ParameterName = "p_xexstacktrace"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.Decimal
                param17.Precision = 18
                param17.Scale = 0
                param17.Value = seglogerr.idseglogreg
                param17.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_seglogerr @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idseglogerr output,@p_xdatoslogerr,@p_flogerr,@p_xexhelplink,@p_xexinnerexception,@p_xexmessage,@p_xexsource,@p_xextargetsite,@p_xexstacktrace,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17)

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
        Public Function desseglogerr(seglogerr As seglogerr) As respopera
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
                param8.Value = seglogerr.idseglogerr
                param8.ParameterName = "p_idseglogerr"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.VarChar
                param9.Size = -1
                If seglogerr.xdatoslogerr IsNot Nothing Then
                    param9.Value = seglogerr.xdatoslogerr
                Else
                    param9.Value = ""
                End If
                param9.ParameterName = "p_xdatoslogerr"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.DateTime
                If seglogerr.flogerr > CDate("01-01-1900") Then
                    param10.Value = seglogerr.flogerr
                Else
                    param10.Value = CDate("01-01-1900")
                End If
                param10.ParameterName = "p_flogerr"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 500
                If seglogerr.xexhelplink IsNot Nothing Then
                    param11.Value = seglogerr.xexhelplink
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_xexhelplink"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = -1
                If seglogerr.xexinnerexception IsNot Nothing Then
                    param12.Value = seglogerr.xexinnerexception
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_xexinnerexception"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.VarChar
                param13.Size = -1
                If seglogerr.xexmessage IsNot Nothing Then
                    param13.Value = seglogerr.xexmessage
                Else
                    param13.Value = ""
                End If
                param13.ParameterName = "p_xexmessage"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.VarChar
                param14.Size = -1
                If seglogerr.xexsource IsNot Nothing Then
                    param14.Value = seglogerr.xexsource
                Else
                    param14.Value = ""
                End If
                param14.ParameterName = "p_xexsource"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = -1
                If seglogerr.xextargetsite IsNot Nothing Then
                    param15.Value = seglogerr.xextargetsite
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_xextargetsite"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.VarChar
                param16.Size = -1
                If seglogerr.xexstacktrace IsNot Nothing Then
                    param16.Value = seglogerr.xexstacktrace
                Else
                    param16.Value = ""
                End If
                param16.ParameterName = "p_xexstacktrace"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.Decimal
                param17.Precision = 18
                param17.Scale = 0
                param17.Value = seglogerr.idseglogreg
                param17.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_seglogerr @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idseglogerr output,@p_xdatoslogerr,@p_flogerr,@p_xexhelplink,@p_xexinnerexception,@p_xexmessage,@p_xexsource,@p_xextargetsite,@p_xexstacktrace,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17)

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
