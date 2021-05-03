Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports Oracle.ManagedDataAccess
Namespace aipauto.entidades.controlador
Public Class aipinsfotoController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selaipinsfotoxid(idaipinsfoto As Decimal) As aipinsfoto
            Dim aipinsfoto As aipinsfoto = (From p In _db.aipinsfoto
                                            Where p.idaipinsfoto = idaipinsfoto
                                            Select p).SingleOrDefault
            Return aipinsfoto
        End Function

        <HttpPost()> _
        Public Function selaipinsfoto() As List(Of aipinsfoto)
            Dim lista_aipinsfoto As List(Of aipinsfoto) = (From p In _db.aipinsfoto
                                                        Select p).ToList
            '
            Return lista_aipinsfoto
        End Function

        <HttpPost()> _
           Public Function selaipinsfotoxwheredinamicopag(petiaipinsfotopaglist As petiaipinsfotopaglist) As respaipinsfotopaglist
            Dim sb As New StringBuilder("")
            '
            If petiaipinsfotopaglist.aipinsfoto.idaipinsfoto <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsfoto=")
                    sb.Append(valor_entero(petiaipinsfotopaglist.aipinsfoto.idaipinsfoto))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsfoto=")
                        sb.Append(valor_entero(petiaipinsfotopaglist.aipinsfoto.idaipinsfoto))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsfotopaglist.aipinsfoto.idaipinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsenc=")
                    sb.Append(valor_entero(petiaipinsfotopaglist.aipinsfoto.idaipinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsenc=")
                        sb.Append(valor_entero(petiaipinsfotopaglist.aipinsfoto.idaipinsenc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsfotopaglist.aipinsfoto.nsecinsfoto <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.nsecinsfoto=")
                    sb.Append(valor_entero(petiaipinsfotopaglist.aipinsfoto.nsecinsfoto))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.nsecinsfoto=")
                        sb.Append(valor_entero(petiaipinsfotopaglist.aipinsfoto.nsecinsfoto))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinsfotopaglist.aipinsfoto.xrutainsfoto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xrutainsfoto='")
                    sb.Append(petiaipinsfotopaglist.aipinsfoto.xrutainsfoto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xrutainsfoto='")
                        sb.Append(petiaipinsfotopaglist.aipinsfoto.xrutainsfoto)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsfotopaglist.aipinsfoto.xurlinsfoto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xurlinsfoto='")
                    sb.Append(petiaipinsfotopaglist.aipinsfoto.xurlinsfoto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xurlinsfoto='")
                        sb.Append(petiaipinsfotopaglist.aipinsfoto.xurlinsfoto)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsfotopaglist.aipinsfoto.xtituinsfoto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xtituinsfoto='")
                    sb.Append(petiaipinsfotopaglist.aipinsfoto.xtituinsfoto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xtituinsfoto='")
                        sb.Append(petiaipinsfotopaglist.aipinsfoto.xtituinsfoto)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsfotopaglist.aipinsfoto.xnomarchinsfoto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnomarchinsfoto='")
                    sb.Append(petiaipinsfotopaglist.aipinsfoto.xnomarchinsfoto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnomarchinsfoto='")
                        sb.Append(petiaipinsfotopaglist.aipinsfoto.xnomarchinsfoto)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsfotopaglist.aipinsfoto.xextinsfoto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xextinsfoto='")
                    sb.Append(petiaipinsfotopaglist.aipinsfoto.xextinsfoto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xextinsfoto='")
                        sb.Append(petiaipinsfotopaglist.aipinsfoto.xextinsfoto)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsfotopaglist.aipinsfoto.xlatcinsfoto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xlatcinsfoto='")
                    sb.Append(petiaipinsfotopaglist.aipinsfoto.xlatcinsfoto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xlatcinsfoto='")
                        sb.Append(petiaipinsfotopaglist.aipinsfoto.xlatcinsfoto)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsfotopaglist.aipinsfoto.xlonginsfoto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xlonginsfoto='")
                    sb.Append(petiaipinsfotopaglist.aipinsfoto.xlonginsfoto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xlonginsfoto='")
                        sb.Append(petiaipinsfotopaglist.aipinsfoto.xlonginsfoto)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsfotopaglist.aipinsfoto.xdescinsfoto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdescinsfoto='")
                    sb.Append(petiaipinsfotopaglist.aipinsfoto.xdescinsfoto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdescinsfoto='")
                        sb.Append(petiaipinsfotopaglist.aipinsfoto.xdescinsfoto)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsfotopaglist.aipinsfoto.iestatinsfoto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestatinsfoto='")
                    sb.Append(petiaipinsfotopaglist.aipinsfoto.iestatinsfoto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatinsfoto='")
                        sb.Append(petiaipinsfotopaglist.aipinsfoto.iestatinsfoto)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinsfotopaglist.aipinsfoto.fcreaaipinsfoto > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fcreaaipinsfoto >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsfotopaglist.aipinsfoto.fcreaaipinsfoto)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fcreaaipinsfoto >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipinsfotopaglist.aipinsfoto.fcreaaipinsfoto)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaipinsfotopaglist.aipinsfoto.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petiaipinsfotopaglist.aipinsfoto.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petiaipinsfotopaglist.aipinsfoto.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respaipinsfotopaglist As New respaipinsfotopaglist
            respaipinsfotopaglist.pagaipinsfoto = petiaipinsfotopaglist.pagaipinsfoto
            Dim skip = skip_paginacion(petiaipinsfotopaglist.pagaipinsfoto.npagactual, petiaipinsfotopaglist.pagaipinsfoto.npagtamano)

            If sb.ToString = "" Then
                respaipinsfotopaglist.lista_aipinsfoto = _db.aipinsfoto.OrderBy(petiaipinsfotopaglist.pagaipinsfoto.xcamposord & " " & petiaipinsfotopaglist.pagaipinsfoto.idirord).Skip(skip).Take(petiaipinsfotopaglist.pagaipinsfoto.npagtamano).ToList
            Else
                respaipinsfotopaglist.lista_aipinsfoto = _db.aipinsfoto.Where(sb.ToString).OrderBy(petiaipinsfotopaglist.pagaipinsfoto.xcamposord & " " & petiaipinsfotopaglist.pagaipinsfoto.idirord).Skip(skip).Take(petiaipinsfotopaglist.pagaipinsfoto.npagtamano).ToList
            End If
            '
            If (respaipinsfotopaglist.lista_aipinsfoto.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selaipinsfotoxwheredinamicocount(sb)
                respaipinsfotopaglist.pagaipinsfoto.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinsfotopaglist.pagaipinsfoto.npagtamano)
            Else
                respaipinsfotopaglist.pagaipinsfoto.npagcantidad = 0
                respaipinsfotopaglist.pagaipinsfoto.npagactual = 0
            End If

            Return respaipinsfotopaglist
        End Function

        Public Function selaipinsfotoxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.aipinsfoto.count
            Else
                Return _db.aipinsfoto.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
        Public Function insaipinsfoto(aipinsfoto As aipinsfoto) As respopera
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
                    param3.Value = ""
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
                    param8.ParameterName = "p_idaipinsfoto"
                    param8.Direction = ParameterDirection.Output

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinsfoto.idaipinsenc
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.SmallInt
                    param10.Value = aipinsfoto.nsecinsfoto
                    param10.ParameterName = "p_nsecinsfoto"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 200
                    If aipinsfoto.xrutainsfoto IsNot Nothing Then
                        param11.Value = aipinsfoto.xrutainsfoto
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_xrutainsfoto"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 200
                    If aipinsfoto.xurlinsfoto IsNot Nothing Then
                        param12.Value = aipinsfoto.xurlinsfoto
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_xurlinsfoto"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 100
                    If aipinsfoto.xtituinsfoto IsNot Nothing Then
                        param13.Value = aipinsfoto.xtituinsfoto
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_xtituinsfoto"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 100
                    If aipinsfoto.xnomarchinsfoto IsNot Nothing Then
                        param14.Value = aipinsfoto.xnomarchinsfoto
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_xnomarchinsfoto"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 5
                    If aipinsfoto.xextinsfoto IsNot Nothing Then
                        param15.Value = aipinsfoto.xextinsfoto
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xextinsfoto"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.VarChar
                    param16.Size = 50
                    If aipinsfoto.xlatcinsfoto IsNot Nothing Then
                        param16.Value = aipinsfoto.xlatcinsfoto
                    Else
                        param16.Value = ""
                    End If
                    param16.ParameterName = "p_xlatcinsfoto"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 50
                    If aipinsfoto.xlonginsfoto IsNot Nothing Then
                        param17.Value = aipinsfoto.xlonginsfoto
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xlonginsfoto"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 500
                    If aipinsfoto.xdescinsfoto IsNot Nothing Then
                        param18.Value = aipinsfoto.xdescinsfoto
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xdescinsfoto"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 20
                    If aipinsfoto.iestatinsfoto IsNot Nothing Then
                        param19.Value = aipinsfoto.iestatinsfoto
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_iestatinsfoto"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.DateTime
                    If aipinsfoto.fcreaaipinsfoto > CDate("01-01-1900") Then
                        param20.Value = aipinsfoto.fcreaaipinsfoto
                    Else
                        param20.Value = CDate("01-01-1900")
                    End If
                    param20.ParameterName = "p_fcreaaipinsfoto"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.Decimal
                    param21.Precision = 18
                    param21.Scale = 0
                    param21.Value = 0
                    param21.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsfoto @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsfoto output,@p_idaipinsenc,@p_nsecinsfoto,@p_xrutainsfoto,@p_xurlinsfoto,@p_xtituinsfoto,@p_xnomarchinsfoto,@p_xextinsfoto,@p_xlatcinsfoto,@p_xlonginsfoto,@p_xdescinsfoto,@p_iestatinsfoto,@p_fcreaaipinsfoto,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = insaipinsfotooracle(aipinsfoto)
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
        Public Function insaipinsfotooracle(aipinsfoto As aipinsfoto) As respopera
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
                param8.ParameterName = "p_idaipinsfoto"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsfoto.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Int16
                param10.Value = aipinsfoto.nsecinsfoto
                param10.ParameterName = "p_nsecinsfoto"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.VARCHAR2
                param11.Size = 200
                If aipinsfoto.xrutainsfoto IsNot Nothing And aipinsfoto.xrutainsfoto <> "" Then
                    param11.Value = aipinsfoto.xrutainsfoto
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_xrutainsfoto"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.VARCHAR2
                param12.Size = 200
                If aipinsfoto.xurlinsfoto IsNot Nothing And aipinsfoto.xurlinsfoto <> "" Then
                    param12.Value = aipinsfoto.xurlinsfoto
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_xurlinsfoto"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 100
                If aipinsfoto.xtituinsfoto IsNot Nothing And aipinsfoto.xtituinsfoto <> "" Then
                    param13.Value = aipinsfoto.xtituinsfoto
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_xtituinsfoto"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 100
                If aipinsfoto.xnomarchinsfoto IsNot Nothing And aipinsfoto.xnomarchinsfoto <> "" Then
                    param14.Value = aipinsfoto.xnomarchinsfoto
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_xnomarchinsfoto"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.VARCHAR2
                param15.Size = 5
                If aipinsfoto.xextinsfoto IsNot Nothing And aipinsfoto.xextinsfoto <> "" Then
                    param15.Value = aipinsfoto.xextinsfoto
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xextinsfoto"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.VARCHAR2
                param16.Size = 50
                If aipinsfoto.xlatcinsfoto IsNot Nothing And aipinsfoto.xlatcinsfoto <> "" Then
                    param16.Value = aipinsfoto.xlatcinsfoto
                Else
                    param16.Value = " "
                End If
                param16.ParameterName = "p_xlatcinsfoto"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 50
                If aipinsfoto.xlonginsfoto IsNot Nothing And aipinsfoto.xlonginsfoto <> "" Then
                    param17.Value = aipinsfoto.xlonginsfoto
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xlonginsfoto"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 40
                If aipinsfoto.ioriginsfoto IsNot Nothing And aipinsfoto.ioriginsfoto <> "" Then
                    param18.Value = aipinsfoto.ioriginsfoto
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_ioriginsfoto"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Varchar2
                param19.Size = 500
                If aipinsfoto.xdescinsfoto IsNot Nothing And aipinsfoto.xdescinsfoto <> "" Then
                    param19.Value = aipinsfoto.xdescinsfoto
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_xdescinsfoto"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Varchar2
                param20.Size = 20
                If aipinsfoto.iestatinsfoto IsNot Nothing And aipinsfoto.iestatinsfoto <> "" Then
                    param20.Value = aipinsfoto.iestatinsfoto
                Else
                    param20.Value = " "
                End If
                param20.ParameterName = "p_iestatinsfoto"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Date
                If aipinsfoto.fcreaaipinsfoto > CDate("01-01-1900") Then
                    param21.Value = aipinsfoto.fcreaaipinsfoto
                Else
                    param21.Value = CDate("01-01-1900")
                End If
                param21.ParameterName = "p_fcreaaipinsfoto"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.Decimal
                param22.Precision = 18
                param22.Scale = 0
                param22.Value = 0
                param22.ParameterName = "p_idseglogreg"

                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinsfoto FLOAT; v_p_idaipinsenc FLOAT; v_p_nsecinsfoto number; v_p_xrutainsfoto VARCHAR2(200); v_p_xurlinsfoto VARCHAR2(200); v_p_xtituinsfoto VARCHAR2(100); v_p_xnomarchinsfoto VARCHAR2(100); v_p_xextinsfoto VARCHAR2(5); v_p_xlatcinsfoto VARCHAR2(50); v_p_xlonginsfoto VARCHAR2(50); v_p_ioriginsfoto VARCHAR2(40); v_p_xdescinsfoto VARCHAR2(500); v_p_iestatinsfoto VARCHAR2(20); v_p_fcreaaipinsfoto date; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinsfoto(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinsfoto,:v_p_idaipinsenc,:v_p_nsecinsfoto,:v_p_xrutainsfoto,:v_p_xurlinsfoto,:v_p_xtituinsfoto,:v_p_xnomarchinsfoto,:v_p_xextinsfoto,:v_p_xlatcinsfoto,:v_p_xlonginsfoto,:v_p_ioriginsfoto,:v_p_xdescinsfoto,:v_p_iestatinsfoto,:v_p_fcreaaipinsfoto,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22)

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
        Public Function modaipinsfoto(aipinsfoto As aipinsfoto) As respopera
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
                    param3.Value = ""
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
                    param8.Value = aipinsfoto.idaipinsfoto
                    param8.ParameterName = "p_idaipinsfoto"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinsfoto.idaipinsenc
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.SmallInt
                    param10.Value = aipinsfoto.nsecinsfoto
                    param10.ParameterName = "p_nsecinsfoto"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 200
                    If aipinsfoto.xrutainsfoto IsNot Nothing Then
                        param11.Value = aipinsfoto.xrutainsfoto
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_xrutainsfoto"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 200
                    If aipinsfoto.xurlinsfoto IsNot Nothing Then
                        param12.Value = aipinsfoto.xurlinsfoto
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_xurlinsfoto"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 100
                    If aipinsfoto.xtituinsfoto IsNot Nothing Then
                        param13.Value = aipinsfoto.xtituinsfoto
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_xtituinsfoto"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 100
                    If aipinsfoto.xnomarchinsfoto IsNot Nothing Then
                        param14.Value = aipinsfoto.xnomarchinsfoto
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_xnomarchinsfoto"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 5
                    If aipinsfoto.xextinsfoto IsNot Nothing Then
                        param15.Value = aipinsfoto.xextinsfoto
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xextinsfoto"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.VarChar
                    param16.Size = 50
                    If aipinsfoto.xlatcinsfoto IsNot Nothing Then
                        param16.Value = aipinsfoto.xlatcinsfoto
                    Else
                        param16.Value = ""
                    End If
                    param16.ParameterName = "p_xlatcinsfoto"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 50
                    If aipinsfoto.xlonginsfoto IsNot Nothing Then
                        param17.Value = aipinsfoto.xlonginsfoto
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xlonginsfoto"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 500
                    If aipinsfoto.xdescinsfoto IsNot Nothing Then
                        param18.Value = aipinsfoto.xdescinsfoto
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xdescinsfoto"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 20
                    If aipinsfoto.iestatinsfoto IsNot Nothing Then
                        param19.Value = aipinsfoto.iestatinsfoto
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_iestatinsfoto"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.DateTime
                    If aipinsfoto.fcreaaipinsfoto > CDate("01-01-1900") Then
                        param20.Value = aipinsfoto.fcreaaipinsfoto
                    Else
                        param20.Value = CDate("01-01-1900")
                    End If
                    param20.ParameterName = "p_fcreaaipinsfoto"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.Decimal
                    param21.Precision = 18
                    param21.Scale = 0
                    param21.Value = aipinsfoto.idseglogreg
                    param21.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsfoto @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsfoto output,@p_idaipinsenc,@p_nsecinsfoto,@p_xrutainsfoto,@p_xurlinsfoto,@p_xtituinsfoto,@p_xnomarchinsfoto,@p_xextinsfoto,@p_xlatcinsfoto,@p_xlonginsfoto,@p_xdescinsfoto,@p_iestatinsfoto,@p_fcreaaipinsfoto,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = modaipinsfotooracle(aipinsfoto)
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
        Public Function modaipinsfotooracle(aipinsfoto As aipinsfoto) As respopera
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
                param8.Value = aipinsfoto.idaipinsfoto
                param8.ParameterName = "p_idaipinsfoto"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsfoto.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Int16
                param10.Value = aipinsfoto.nsecinsfoto
                param10.ParameterName = "p_nsecinsfoto"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.VARCHAR2
                param11.Size = 200
                If aipinsfoto.xrutainsfoto IsNot Nothing And aipinsfoto.xrutainsfoto <> "" Then
                    param11.Value = aipinsfoto.xrutainsfoto
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_xrutainsfoto"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.VARCHAR2
                param12.Size = 200
                If aipinsfoto.xurlinsfoto IsNot Nothing And aipinsfoto.xurlinsfoto <> "" Then
                    param12.Value = aipinsfoto.xurlinsfoto
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_xurlinsfoto"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 100
                If aipinsfoto.xtituinsfoto IsNot Nothing And aipinsfoto.xtituinsfoto <> "" Then
                    param13.Value = aipinsfoto.xtituinsfoto
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_xtituinsfoto"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 100
                If aipinsfoto.xnomarchinsfoto IsNot Nothing And aipinsfoto.xnomarchinsfoto <> "" Then
                    param14.Value = aipinsfoto.xnomarchinsfoto
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_xnomarchinsfoto"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.VARCHAR2
                param15.Size = 5
                If aipinsfoto.xextinsfoto IsNot Nothing And aipinsfoto.xextinsfoto <> "" Then
                    param15.Value = aipinsfoto.xextinsfoto
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xextinsfoto"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.VARCHAR2
                param16.Size = 50
                If aipinsfoto.xlatcinsfoto IsNot Nothing And aipinsfoto.xlatcinsfoto <> "" Then
                    param16.Value = aipinsfoto.xlatcinsfoto
                Else
                    param16.Value = " "
                End If
                param16.ParameterName = "p_xlatcinsfoto"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 50
                If aipinsfoto.xlonginsfoto IsNot Nothing And aipinsfoto.xlonginsfoto <> "" Then
                    param17.Value = aipinsfoto.xlonginsfoto
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xlonginsfoto"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 40
                If aipinsfoto.ioriginsfoto IsNot Nothing And aipinsfoto.ioriginsfoto <> "" Then
                    param18.Value = aipinsfoto.ioriginsfoto
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_ioriginsfoto"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Varchar2
                param19.Size = 500
                If aipinsfoto.xdescinsfoto IsNot Nothing And aipinsfoto.xdescinsfoto <> "" Then
                    param19.Value = aipinsfoto.xdescinsfoto
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_xdescinsfoto"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Varchar2
                param20.Size = 20
                If aipinsfoto.iestatinsfoto IsNot Nothing And aipinsfoto.iestatinsfoto <> "" Then
                    param20.Value = aipinsfoto.iestatinsfoto
                Else
                    param20.Value = " "
                End If
                param20.ParameterName = "p_iestatinsfoto"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Date
                If aipinsfoto.fcreaaipinsfoto > CDate("01-01-1900") Then
                    param21.Value = aipinsfoto.fcreaaipinsfoto
                Else
                    param21.Value = CDate("01-01-1900")
                End If
                param21.ParameterName = "p_fcreaaipinsfoto"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.Decimal
                param22.Precision = 18
                param22.Scale = 0
                param22.Value = 0
                param22.ParameterName = "p_idseglogreg"

                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinsfoto FLOAT; v_p_idaipinsenc FLOAT; v_p_nsecinsfoto number; v_p_xrutainsfoto VARCHAR2(200); v_p_xurlinsfoto VARCHAR2(200); v_p_xtituinsfoto VARCHAR2(100); v_p_xnomarchinsfoto VARCHAR2(100); v_p_xextinsfoto VARCHAR2(5); v_p_xlatcinsfoto VARCHAR2(50); v_p_xlonginsfoto VARCHAR2(50); v_p_ioriginsfoto VARCHAR2(40); v_p_xdescinsfoto VARCHAR2(500); v_p_iestatinsfoto VARCHAR2(20); v_p_fcreaaipinsfoto date; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinsfoto(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinsfoto,:v_p_idaipinsenc,:v_p_nsecinsfoto,:v_p_xrutainsfoto,:v_p_xurlinsfoto,:v_p_xtituinsfoto,:v_p_xnomarchinsfoto,:v_p_xextinsfoto,:v_p_xlatcinsfoto,:v_p_xlonginsfoto,:v_p_ioriginsfoto,:v_p_xdescinsfoto,:v_p_iestatinsfoto,:v_p_fcreaaipinsfoto,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22)

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
        Public Function eliaipinsfoto(aipinsfoto As aipinsfoto) As respopera
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
                    param3.Value = ""
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
                    param8.Value = aipinsfoto.idaipinsfoto
                    param8.ParameterName = "p_idaipinsfoto"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinsfoto.idaipinsenc
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.SmallInt
                    param10.Value = aipinsfoto.nsecinsfoto
                    param10.ParameterName = "p_nsecinsfoto"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 200
                    If aipinsfoto.xrutainsfoto IsNot Nothing Then
                        param11.Value = aipinsfoto.xrutainsfoto
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_xrutainsfoto"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 200
                    If aipinsfoto.xurlinsfoto IsNot Nothing Then
                        param12.Value = aipinsfoto.xurlinsfoto
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_xurlinsfoto"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 100
                    If aipinsfoto.xtituinsfoto IsNot Nothing Then
                        param13.Value = aipinsfoto.xtituinsfoto
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_xtituinsfoto"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 100
                    If aipinsfoto.xnomarchinsfoto IsNot Nothing Then
                        param14.Value = aipinsfoto.xnomarchinsfoto
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_xnomarchinsfoto"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 5
                    If aipinsfoto.xextinsfoto IsNot Nothing Then
                        param15.Value = aipinsfoto.xextinsfoto
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xextinsfoto"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.VarChar
                    param16.Size = 50
                    If aipinsfoto.xlatcinsfoto IsNot Nothing Then
                        param16.Value = aipinsfoto.xlatcinsfoto
                    Else
                        param16.Value = ""
                    End If
                    param16.ParameterName = "p_xlatcinsfoto"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 50
                    If aipinsfoto.xlonginsfoto IsNot Nothing Then
                        param17.Value = aipinsfoto.xlonginsfoto
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xlonginsfoto"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 500
                    If aipinsfoto.xdescinsfoto IsNot Nothing Then
                        param18.Value = aipinsfoto.xdescinsfoto
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xdescinsfoto"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 20
                    If aipinsfoto.iestatinsfoto IsNot Nothing Then
                        param19.Value = aipinsfoto.iestatinsfoto
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_iestatinsfoto"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.DateTime
                    If aipinsfoto.fcreaaipinsfoto > CDate("01-01-1900") Then
                        param20.Value = aipinsfoto.fcreaaipinsfoto
                    Else
                        param20.Value = CDate("01-01-1900")
                    End If
                    param20.ParameterName = "p_fcreaaipinsfoto"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.Decimal
                    param21.Precision = 18
                    param21.Scale = 0
                    param21.Value = aipinsfoto.idseglogreg
                    param21.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsfoto @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsfoto output,@p_idaipinsenc,@p_nsecinsfoto,@p_xrutainsfoto,@p_xurlinsfoto,@p_xtituinsfoto,@p_xnomarchinsfoto,@p_xextinsfoto,@p_xlatcinsfoto,@p_xlonginsfoto,@p_xdescinsfoto,@p_iestatinsfoto,@p_fcreaaipinsfoto,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipinsfotooracle(aipinsfoto)
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
        Public Function eliaipinsfotooracle(aipinsfoto As aipinsfoto) As respopera
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
                param8.Value = aipinsfoto.idaipinsfoto
                param8.ParameterName = "p_idaipinsfoto"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsfoto.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Int16
                param10.Value = aipinsfoto.nsecinsfoto
                param10.ParameterName = "p_nsecinsfoto"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.VARCHAR2
                param11.Size = 200
                If aipinsfoto.xrutainsfoto IsNot Nothing And aipinsfoto.xrutainsfoto <> "" Then
                    param11.Value = aipinsfoto.xrutainsfoto
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_xrutainsfoto"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.VARCHAR2
                param12.Size = 200
                If aipinsfoto.xurlinsfoto IsNot Nothing And aipinsfoto.xurlinsfoto <> "" Then
                    param12.Value = aipinsfoto.xurlinsfoto
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_xurlinsfoto"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 100
                If aipinsfoto.xtituinsfoto IsNot Nothing And aipinsfoto.xtituinsfoto <> "" Then
                    param13.Value = aipinsfoto.xtituinsfoto
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_xtituinsfoto"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 100
                If aipinsfoto.xnomarchinsfoto IsNot Nothing And aipinsfoto.xnomarchinsfoto <> "" Then
                    param14.Value = aipinsfoto.xnomarchinsfoto
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_xnomarchinsfoto"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.VARCHAR2
                param15.Size = 5
                If aipinsfoto.xextinsfoto IsNot Nothing And aipinsfoto.xextinsfoto <> "" Then
                    param15.Value = aipinsfoto.xextinsfoto
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xextinsfoto"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.VARCHAR2
                param16.Size = 50
                If aipinsfoto.xlatcinsfoto IsNot Nothing And aipinsfoto.xlatcinsfoto <> "" Then
                    param16.Value = aipinsfoto.xlatcinsfoto
                Else
                    param16.Value = " "
                End If
                param16.ParameterName = "p_xlatcinsfoto"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 50
                If aipinsfoto.xlonginsfoto IsNot Nothing And aipinsfoto.xlonginsfoto <> "" Then
                    param17.Value = aipinsfoto.xlonginsfoto
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xlonginsfoto"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 40
                If aipinsfoto.ioriginsfoto IsNot Nothing And aipinsfoto.ioriginsfoto <> "" Then
                    param18.Value = aipinsfoto.ioriginsfoto
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_ioriginsfoto"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Varchar2
                param19.Size = 500
                If aipinsfoto.xdescinsfoto IsNot Nothing And aipinsfoto.xdescinsfoto <> "" Then
                    param19.Value = aipinsfoto.xdescinsfoto
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_xdescinsfoto"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Varchar2
                param20.Size = 20
                If aipinsfoto.iestatinsfoto IsNot Nothing And aipinsfoto.iestatinsfoto <> "" Then
                    param20.Value = aipinsfoto.iestatinsfoto
                Else
                    param20.Value = " "
                End If
                param20.ParameterName = "p_iestatinsfoto"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Date
                If aipinsfoto.fcreaaipinsfoto > CDate("01-01-1900") Then
                    param21.Value = aipinsfoto.fcreaaipinsfoto
                Else
                    param21.Value = CDate("01-01-1900")
                End If
                param21.ParameterName = "p_fcreaaipinsfoto"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.Decimal
                param22.Precision = 18
                param22.Scale = 0
                param22.Value = 0
                param22.ParameterName = "p_idseglogreg"

                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinsfoto FLOAT; v_p_idaipinsenc FLOAT; v_p_nsecinsfoto number; v_p_xrutainsfoto VARCHAR2(200); v_p_xurlinsfoto VARCHAR2(200); v_p_xtituinsfoto VARCHAR2(100); v_p_xnomarchinsfoto VARCHAR2(100); v_p_xextinsfoto VARCHAR2(5); v_p_xlatcinsfoto VARCHAR2(50); v_p_xlonginsfoto VARCHAR2(50); v_p_ioriginsfoto VARCHAR2(40); v_p_xdescinsfoto VARCHAR2(500); v_p_iestatinsfoto VARCHAR2(20); v_p_fcreaaipinsfoto date; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinsfoto(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinsfoto,:v_p_idaipinsenc,:v_p_nsecinsfoto,:v_p_xrutainsfoto,:v_p_xurlinsfoto,:v_p_xtituinsfoto,:v_p_xnomarchinsfoto,:v_p_xextinsfoto,:v_p_xlatcinsfoto,:v_p_xlonginsfoto,:v_p_ioriginsfoto,:v_p_xdescinsfoto,:v_p_iestatinsfoto,:v_p_fcreaaipinsfoto,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22)

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
        Public Function eliaipinsfoto(idaipinsfoto As Decimal) As respopera
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
                    param3.Value = ""
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
                    param8.Value = idaipinsfoto
                    param8.ParameterName = "p_idaipinsfoto"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = 0
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.SmallInt
                    param10.Value = 0
                    param10.ParameterName = "p_nsecinsfoto"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 200
                    param11.Value = ""
                    param11.ParameterName = "p_xrutainsfoto"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 200
                    param12.Value = ""
                    param12.ParameterName = "p_xurlinsfoto"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.VarChar
                    param13.Size = 100
                    param13.Value = ""
                    param13.ParameterName = "p_xtituinsfoto"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.VarChar
                    param14.Size = 100
                    param14.Value = ""
                    param14.ParameterName = "p_xnomarchinsfoto"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 5
                    param15.Value = ""
                    param15.ParameterName = "p_xextinsfoto"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.VarChar
                    param16.Size = 50
                    param16.Value = ""
                    param16.ParameterName = "p_xlatcinsfoto"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 50
                    param17.Value = ""
                    param17.ParameterName = "p_xlonginsfoto"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 500
                    param18.Value = ""
                    param18.ParameterName = "p_xdescinsfoto"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 20
                    param19.Value = ""
                    param19.ParameterName = "p_iestatinsfoto"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.DateTime
                    param20.Value = CDate("01-01-1900")
                    param20.ParameterName = "p_fcreaaipinsfoto"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.Decimal
                    param21.Precision = 18
                    param21.Scale = 0
                    param21.Value = 0
                    param21.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsfoto @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsfoto output,@p_idaipinsenc,@p_nsecinsfoto,@p_xrutainsfoto,@p_xurlinsfoto,@p_xtituinsfoto,@p_xnomarchinsfoto,@p_xextinsfoto,@p_xlatcinsfoto,@p_xlonginsfoto,@p_xdescinsfoto,@p_iestatinsfoto,@p_fcreaaipinsfoto,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipinsfotooracle(idaipinsfoto)
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
        Public Function eliaipinsfotooracle(idaipinsfoto As Decimal) As respopera
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
                param8.Value = idaipinsfoto
                param8.ParameterName = "p_idaipinsfoto"
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
                param10.ParameterName = "p_nsecinsfoto"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.VARCHAR2
                param11.Size = 200
                param11.Value = " "
                param11.ParameterName = "p_xrutainsfoto"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.VARCHAR2
                param12.Size = 200
                param12.Value = " "
                param12.ParameterName = "p_xurlinsfoto"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 100
                param13.Value = " "
                param13.ParameterName = "p_xtituinsfoto"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 100
                param14.Value = " "
                param14.ParameterName = "p_xnomarchinsfoto"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.VARCHAR2
                param15.Size = 5
                param15.Value = " "
                param15.ParameterName = "p_xextinsfoto"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.VARCHAR2
                param16.Size = 50
                param16.Value = " "
                param16.ParameterName = "p_xlatcinsfoto"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 50
                param17.Value = " "
                param17.ParameterName = "p_xlonginsfoto"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 40
                param18.Value = " "
                param18.ParameterName = "p_ioriginsfoto"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Varchar2
                param19.Size = 500
                param19.Value = " "
                param19.ParameterName = "p_xdescinsfoto"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Varchar2
                param20.Size = 20
                param20.Value = " "
                param20.ParameterName = "p_iestatinsfoto"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Date
                param21.Value = CDate("01-01-1900")
                param21.ParameterName = "p_fcreaaipinsfoto"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.Decimal
                param22.Precision = 18
                param22.Scale = 0
                param22.Value = 0
                param22.ParameterName = "p_idseglogreg"

                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinsfoto FLOAT; v_p_idaipinsenc FLOAT; v_p_nsecinsfoto number; v_p_xrutainsfoto VARCHAR2(200); v_p_xurlinsfoto VARCHAR2(200); v_p_xtituinsfoto VARCHAR2(100); v_p_xnomarchinsfoto VARCHAR2(100); v_p_xextinsfoto VARCHAR2(5); v_p_xlatcinsfoto VARCHAR2(50); v_p_xlonginsfoto VARCHAR2(50); v_p_ioriginsfoto VARCHAR2(40); v_p_xdescinsfoto VARCHAR2(500); v_p_iestatinsfoto VARCHAR2(20); v_p_fcreaaipinsfoto date; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinsfoto(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinsfoto,:v_p_idaipinsenc,:v_p_nsecinsfoto,:v_p_xrutainsfoto,:v_p_xurlinsfoto,:v_p_xtituinsfoto,:v_p_xnomarchinsfoto,:v_p_xextinsfoto,:v_p_xlatcinsfoto,:v_p_xlonginsfoto,:v_p_ioriginsfoto,:v_p_xdescinsfoto,:v_p_iestatinsfoto,:v_p_fcreaaipinsfoto,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22)

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
        Public Function actaipinsfoto(aipinsfoto As aipinsfoto) As respopera
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
                param8.Value = aipinsfoto.idaipinsfoto
                param8.ParameterName = "p_idaipinsfoto"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsfoto.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.smallint
                param10.Value = aipinsfoto.nsecinsfoto
                param10.ParameterName = "p_nsecinsfoto"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.varchar
                param11.Size = 200
                If aipinsfoto.xrutainsfoto IsNot Nothing Then
                    param11.Value = aipinsfoto.xrutainsfoto
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_xrutainsfoto"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.varchar
                param12.Size = 200
                If aipinsfoto.xurlinsfoto IsNot Nothing Then
                    param12.Value = aipinsfoto.xurlinsfoto
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_xurlinsfoto"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.varchar
                param13.Size = 100
                If aipinsfoto.xtituinsfoto IsNot Nothing Then
                    param13.Value = aipinsfoto.xtituinsfoto
                Else
                    param13.Value = ""
                End If
                param13.ParameterName = "p_xtituinsfoto"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.varchar
                param14.Size = 100
                If aipinsfoto.xnomarchinsfoto IsNot Nothing Then
                    param14.Value = aipinsfoto.xnomarchinsfoto
                Else
                    param14.Value = ""
                End If
                param14.ParameterName = "p_xnomarchinsfoto"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.varchar
                param15.Size = 5
                If aipinsfoto.xextinsfoto IsNot Nothing Then
                    param15.Value = aipinsfoto.xextinsfoto
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_xextinsfoto"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.varchar
                param16.Size = 50
                If aipinsfoto.xlatcinsfoto IsNot Nothing Then
                    param16.Value = aipinsfoto.xlatcinsfoto
                Else
                    param16.Value = ""
                End If
                param16.ParameterName = "p_xlatcinsfoto"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.varchar
                param17.Size = 50
                If aipinsfoto.xlonginsfoto IsNot Nothing Then
                    param17.Value = aipinsfoto.xlonginsfoto
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xlonginsfoto"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.varchar
                param18.Size = 500
                If aipinsfoto.xdescinsfoto IsNot Nothing Then
                    param18.Value = aipinsfoto.xdescinsfoto
                Else
                    param18.Value = ""
                End If
                param18.ParameterName = "p_xdescinsfoto"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.varchar
                param19.Size = 20
                If aipinsfoto.iestatinsfoto IsNot Nothing Then
                    param19.Value = aipinsfoto.iestatinsfoto
                Else
                    param19.Value = ""
                End If
                param19.ParameterName = "p_iestatinsfoto"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.DateTime
                If aipinsfoto.fcreaaipinsfoto > CDate("01-01-1900") Then
                    param20.Value = aipinsfoto.fcreaaipinsfoto
                Else
                    param20.Value = CDate("01-01-1900")
                End If
                param20.ParameterName = "p_fcreaaipinsfoto"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.Decimal
                param21.Precision = 18
                param21.Scale = 0
                param21.Value = aipinsfoto.idseglogreg
                param21.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsfoto @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsfoto output,@p_idaipinsenc,@p_nsecinsfoto,@p_xrutainsfoto,@p_xurlinsfoto,@p_xtituinsfoto,@p_xnomarchinsfoto,@p_xextinsfoto,@p_xlatcinsfoto,@p_xlonginsfoto,@p_xdescinsfoto,@p_iestatinsfoto,@p_fcreaaipinsfoto,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21)

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
        Public Function desaipinsfoto(aipinsfoto As aipinsfoto) As respopera
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
                param8.Value = aipinsfoto.idaipinsfoto
                param8.ParameterName = "p_idaipinsfoto"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinsfoto.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.smallint
                param10.Value = aipinsfoto.nsecinsfoto
                param10.ParameterName = "p_nsecinsfoto"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.varchar
                param11.Size = 200
                If aipinsfoto.xrutainsfoto IsNot Nothing Then
                    param11.Value = aipinsfoto.xrutainsfoto
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_xrutainsfoto"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.varchar
                param12.Size = 200
                If aipinsfoto.xurlinsfoto IsNot Nothing Then
                    param12.Value = aipinsfoto.xurlinsfoto
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_xurlinsfoto"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.varchar
                param13.Size = 100
                If aipinsfoto.xtituinsfoto IsNot Nothing Then
                    param13.Value = aipinsfoto.xtituinsfoto
                Else
                    param13.Value = ""
                End If
                param13.ParameterName = "p_xtituinsfoto"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.varchar
                param14.Size = 100
                If aipinsfoto.xnomarchinsfoto IsNot Nothing Then
                    param14.Value = aipinsfoto.xnomarchinsfoto
                Else
                    param14.Value = ""
                End If
                param14.ParameterName = "p_xnomarchinsfoto"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.varchar
                param15.Size = 5
                If aipinsfoto.xextinsfoto IsNot Nothing Then
                    param15.Value = aipinsfoto.xextinsfoto
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_xextinsfoto"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.varchar
                param16.Size = 50
                If aipinsfoto.xlatcinsfoto IsNot Nothing Then
                    param16.Value = aipinsfoto.xlatcinsfoto
                Else
                    param16.Value = ""
                End If
                param16.ParameterName = "p_xlatcinsfoto"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.varchar
                param17.Size = 50
                If aipinsfoto.xlonginsfoto IsNot Nothing Then
                    param17.Value = aipinsfoto.xlonginsfoto
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xlonginsfoto"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.varchar
                param18.Size = 500
                If aipinsfoto.xdescinsfoto IsNot Nothing Then
                    param18.Value = aipinsfoto.xdescinsfoto
                Else
                    param18.Value = ""
                End If
                param18.ParameterName = "p_xdescinsfoto"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.varchar
                param19.Size = 20
                If aipinsfoto.iestatinsfoto IsNot Nothing Then
                    param19.Value = aipinsfoto.iestatinsfoto
                Else
                    param19.Value = ""
                End If
                param19.ParameterName = "p_iestatinsfoto"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.DateTime
                If aipinsfoto.fcreaaipinsfoto > CDate("01-01-1900") Then
                    param20.Value = aipinsfoto.fcreaaipinsfoto
                Else
                    param20.Value = CDate("01-01-1900")
                End If
                param20.ParameterName = "p_fcreaaipinsfoto"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.Decimal
                param21.Precision = 18
                param21.Scale = 0
                param21.Value = aipinsfoto.idseglogreg
                param21.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsfoto @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsfoto output,@p_idaipinsenc,@p_nsecinsfoto,@p_xrutainsfoto,@p_xurlinsfoto,@p_xtituinsfoto,@p_xnomarchinsfoto,@p_xextinsfoto,@p_xlatcinsfoto,@p_xlonginsfoto,@p_xdescinsfoto,@p_iestatinsfoto,@p_fcreaaipinsfoto,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21)

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
        Public Function selaipinsfotoxidaipinsencynsecinsfoto(idaipinsenc As Decimal, nsecinsfoto As Short) As aipinsfoto
            Dim aipinsfoto As aipinsfoto = (From p In _db.aipinsfoto
                                            Where p.idaipinsenc = idaipinsenc And p.nsecinsfoto = nsecinsfoto
                                            Select p).SingleOrDefault
            Return aipinsfoto
        End Function

        <HttpPost()> _
        Public Function selaipinsfotoxididaipinsenc(idaipinsenc As Decimal) As aipinsfoto
            Dim aipinsfoto As aipinsfoto = (From p In _db.aipinsfoto
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).SingleOrDefault
            Return aipinsfoto
        End Function

        <HttpPost()> _
        Public Function selaipinsfotoxidaipinsencyxnomarchinsfoto(idaipinsenc As Decimal, xnomarchinsfoto As String) As aipinsfoto
            Dim aipinsfoto As aipinsfoto = (From p In _db.aipinsfoto
                                            Where p.idaipinsenc = idaipinsenc And p.xnomarchinsfoto = xnomarchinsfoto
                                            Select p).SingleOrDefault
            Return aipinsfoto
        End Function

        <HttpPost()> _
        Public Function selaipinsfotoxidaipinsenc(idaipinsenc As Decimal) As List(Of aipinsfoto)
            Dim lista_aipinsfoto As List(Of aipinsfoto) = (From p In _db.aipinsfoto
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).ToList
            Return lista_aipinsfoto
        End Function

        <HttpPost()> _
        Public Function selaipinsfotoxidaipinsenccount(idaipinsenc As Decimal) As Decimal
            Dim cantidad As Decimal = (From p In _db.aipinsfoto
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).Count
            Return cantidad
        End Function

        <HttpPost()> _
        Public Function maxcontfotoXidaipinsenc(idaipinsenc As Decimal) As Decimal
            Dim nsecuen As Decimal = (From p In _db.aipinsfoto
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).DefaultIfEmpty().Max(Function(p) If(p Is Nothing, 0, p.nsecinsfoto))
            Return nsecuen
        End Function

End Class
End Namespace
