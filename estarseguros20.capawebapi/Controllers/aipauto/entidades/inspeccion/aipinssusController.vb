Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports Oracle.ManagedDataAccess
Namespace aipauto.entidades.controlador
    Public Class aipinssusController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selaipinssusxid(idaipinssus As Decimal) As aipinssus
            Dim aipinssus As aipinssus = (From p In _db.aipinssus
                                            Where p.idaipinssus = idaipinssus
                                            Select p).SingleOrDefault
            Return aipinssus
        End Function

        <HttpPost()> _
        Public Function selaipinssus() As List(Of aipinssus)
            Dim lista_aipinssus As List(Of aipinssus) = (From p In _db.aipinssus
                                                        Select p).ToList
            '
            Return lista_aipinssus
        End Function

        <HttpPost()> _
           Public Function selaipinssusxwheredinamicopag(petiaipinssuspaglist As petiaipinssuspaglist) As respaipinssuspaglist
            Dim sb As New StringBuilder("")
            '
            If petiaipinssuspaglist.aipinssus.idaipinssus <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssus=")
                    sb.Append(valor_entero(petiaipinssuspaglist.aipinssus.idaipinssus))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssus=")
                        sb.Append(valor_entero(petiaipinssuspaglist.aipinssus.idaipinssus))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssuspaglist.aipinssus.idaipinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsenc=")
                    sb.Append(valor_entero(petiaipinssuspaglist.aipinssus.idaipinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsenc=")
                        sb.Append(valor_entero(petiaipinssuspaglist.aipinssus.idaipinsenc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssuspaglist.aipinssus.xnomintinssus <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnomintinssus='")
                    sb.Append(petiaipinssuspaglist.aipinssus.xnomintinssus)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnomintinssus='")
                        sb.Append(petiaipinssuspaglist.aipinssus.xnomintinssus)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssuspaglist.aipinssus.xnomsolinssus <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnomsolinssus='")
                    sb.Append(petiaipinssuspaglist.aipinssus.xnomsolinssus)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnomsolinssus='")
                        sb.Append(petiaipinssuspaglist.aipinssus.xnomsolinssus)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssuspaglist.aipinssus.iluginssus <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iluginssus='")
                    sb.Append(petiaipinssuspaglist.aipinssus.iluginssus)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iluginssus='")
                        sb.Append(petiaipinssuspaglist.aipinssus.iluginssus)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssuspaglist.aipinssus.idaipmanveh <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipmanveh=")
                    sb.Append(valor_entero(petiaipinssuspaglist.aipinssus.idaipmanveh))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipmanveh=")
                        sb.Append(valor_entero(petiaipinssuspaglist.aipinssus.idaipmanveh))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssuspaglist.aipinssus.nkiloinssus <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.nkiloinssus=")
                    sb.Append(valor_entero(petiaipinssuspaglist.aipinssus.nkiloinssus))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.nkiloinssus=")
                        sb.Append(valor_entero(petiaipinssuspaglist.aipinssus.nkiloinssus))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssuspaglist.aipinssus.xsucuinssus <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xsucuinssus='")
                    sb.Append(petiaipinssuspaglist.aipinssus.xsucuinssus)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xsucuinssus='")
                        sb.Append(petiaipinssuspaglist.aipinssus.xsucuinssus)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssuspaglist.aipinssus.iserbodinssus <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.iserbodinssus=")
                    sb.Append(valor_entero(petiaipinssuspaglist.aipinssus.iserbodinssus))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iserbodinssus=")
                        sb.Append(valor_entero(petiaipinssuspaglist.aipinssus.iserbodinssus))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssuspaglist.aipinssus.ialarcorrinssus <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.ialarcorrinssus=")
                    sb.Append(valor_entero(petiaipinssuspaglist.aipinssus.ialarcorrinssus))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ialarcorrinssus=")
                        sb.Append(valor_entero(petiaipinssuspaglist.aipinssus.ialarcorrinssus))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipinssuspaglist.aipinssus.xserinssus <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xserinssus='")
                    sb.Append(petiaipinssuspaglist.aipinssus.xserinssus)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xserinssus='")
                        sb.Append(petiaipinssuspaglist.aipinssus.xserinssus)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssuspaglist.aipinssus.xdictinssus <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdictinssus='")
                    sb.Append(petiaipinssuspaglist.aipinssus.xdictinssus)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdictinssus='")
                        sb.Append(petiaipinssuspaglist.aipinssus.xdictinssus)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssuspaglist.aipinssus.xdescinssus <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdescinssus='")
                    sb.Append(petiaipinssuspaglist.aipinssus.xdescinssus)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdescinssus='")
                        sb.Append(petiaipinssuspaglist.aipinssus.xdescinssus)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssuspaglist.aipinssus.iestatinssus <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestatinssus='")
                    sb.Append(petiaipinssuspaglist.aipinssus.iestatinssus)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatinssus='")
                        sb.Append(petiaipinssuspaglist.aipinssus.iestatinssus)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipinssuspaglist.aipinssus.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petiaipinssuspaglist.aipinssus.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petiaipinssuspaglist.aipinssus.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respaipinssuspaglist As New respaipinssuspaglist
            respaipinssuspaglist.pagaipinssus = petiaipinssuspaglist.pagaipinssus
            Dim skip = skip_paginacion(petiaipinssuspaglist.pagaipinssus.npagactual, petiaipinssuspaglist.pagaipinssus.npagtamano)

            If sb.ToString = "" Then
                respaipinssuspaglist.lista_aipinssus = _db.aipinssus.OrderBy(petiaipinssuspaglist.pagaipinssus.xcamposord & " " & petiaipinssuspaglist.pagaipinssus.idirord).Skip(skip).Take(petiaipinssuspaglist.pagaipinssus.npagtamano).ToList
            Else
                respaipinssuspaglist.lista_aipinssus = _db.aipinssus.Where(sb.ToString).OrderBy(petiaipinssuspaglist.pagaipinssus.xcamposord & " " & petiaipinssuspaglist.pagaipinssus.idirord).Skip(skip).Take(petiaipinssuspaglist.pagaipinssus.npagtamano).ToList
            End If
            '
            If (respaipinssuspaglist.lista_aipinssus.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selaipinssusxwheredinamicocount(sb)
                respaipinssuspaglist.pagaipinssus.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinssuspaglist.pagaipinssus.npagtamano)
            Else
                respaipinssuspaglist.pagaipinssus.npagcantidad = 0
                respaipinssuspaglist.pagaipinssus.npagactual = 0
            End If

            Return respaipinssuspaglist
        End Function

        Public Function selaipinssusxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.aipinssus.Count
            Else
                Return _db.aipinssus.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
        Public Function insaipinssus(aipinssus As aipinssus) As respopera
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
                    param8.ParameterName = "p_idaipinssus"
                    param8.Direction = ParameterDirection.Output

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssus.idaipinsenc
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.VarChar
                    param10.Size = 50
                    If aipinssus.xnomintinssus IsNot Nothing Then
                        param10.Value = aipinssus.xnomintinssus
                    Else
                        param10.Value = ""
                    End If
                    param10.ParameterName = "p_xnomintinssus"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 50
                    If aipinssus.xnomsolinssus IsNot Nothing Then
                        param11.Value = aipinssus.xnomsolinssus
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_xnomsolinssus"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    If aipinssus.iluginssus IsNot Nothing Then
                        param12.Value = aipinssus.iluginssus
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_iluginssus"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Decimal
                    param13.Precision = 18
                    param13.Scale = 0
                    param13.Value = aipinssus.idaipmanveh
                    param13.ParameterName = "p_idaipmanveh"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Int
                    param14.Value = aipinssus.nkiloinssus
                    param14.ParameterName = "p_nkiloinssus"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 100
                    If aipinssus.xsucuinssus IsNot Nothing Then
                        param15.Value = aipinssus.xsucuinssus
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xsucuinssus"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Bit
                    param16.Value = aipinssus.iserbodinssus
                    param16.ParameterName = "p_iserbodinssus"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.Bit
                    param17.Value = aipinssus.ialarcorrinssus
                    param17.ParameterName = "p_ialarcorrinssus"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 50
                    If aipinssus.xserinssus IsNot Nothing Then
                        param18.Value = aipinssus.xserinssus
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xserinssus"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 500
                    If aipinssus.xdictinssus IsNot Nothing Then
                        param19.Value = aipinssus.xdictinssus
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_xdictinssus"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 500
                    If aipinssus.xdescinssus IsNot Nothing Then
                        param20.Value = aipinssus.xdescinssus
                    Else
                        param20.Value = ""
                    End If
                    param20.ParameterName = "p_xdescinssus"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 20
                    If aipinssus.iestatinssus IsNot Nothing Then
                        param21.Value = aipinssus.iestatinssus
                    Else
                        param21.Value = ""
                    End If
                    param21.ParameterName = "p_iestatinssus"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.Decimal
                    param22.Precision = 18
                    param22.Scale = 0
                    param22.Value = 0
                    param22.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssus @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssus output,@p_idaipinsenc,@p_xnomintinssus,@p_xnomsolinssus,@p_iluginssus,@p_idaipmanveh,@p_nkiloinssus,@p_xsucuinssus,@p_iserbodinssus,@p_ialarcorrinssus,@p_xserinssus,@p_xdictinssus,@p_xdescinssus,@p_iestatinssus,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = insaipinssusoracle(aipinssus)
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
        Public Function insaipinssusoracle(aipinssus As aipinssus) As respopera
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
                param8.ParameterName = "p_idaipinssus"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssus.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Varchar2
                param10.Size = 50
                If aipinssus.xnomintinssus IsNot Nothing And aipinssus.xnomintinssus <> "" Then
                    param10.Value = aipinssus.xnomintinssus
                Else
                    param10.Value = " "
                End If
                param10.ParameterName = "p_xnomintinssus"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Varchar2
                param11.Size = 50
                If aipinssus.xnomsolinssus IsNot Nothing And aipinssus.xnomsolinssus <> "" Then
                    param11.Value = aipinssus.xnomsolinssus
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_xnomsolinssus"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 20
                If aipinssus.iluginssus IsNot Nothing And aipinssus.iluginssus <> "" Then
                    param12.Value = aipinssus.iluginssus
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_iluginssus"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                param13.Value = aipinssus.idaipmanveh
                param13.ParameterName = "p_idaipmanveh"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Int32
                param14.Value = aipinssus.nkiloinssus
                param14.ParameterName = "p_nkiloinssus"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 100
                If aipinssus.xsucuinssus IsNot Nothing And aipinssus.xsucuinssus <> "" Then
                    param15.Value = aipinssus.xsucuinssus
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xsucuinssus"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Int16
                param16.Value = aipinssus.iserbodinssus
                param16.ParameterName = "p_iserbodinssus"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Int16
                param17.Value = aipinssus.ialarcorrinssus
                param17.ParameterName = "p_ialarcorrinssus"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 50
                If aipinssus.xserinssus IsNot Nothing And aipinssus.xserinssus <> "" Then
                    param18.Value = aipinssus.xserinssus
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_xserinssus"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Long                
                If aipinssus.xdictinssus IsNot Nothing And aipinssus.xdictinssus <> "" Then
                    param19.Value = aipinssus.xdictinssus
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_xdictinssus"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Varchar2
                param20.Size = 500
                If aipinssus.xdescinssus IsNot Nothing And aipinssus.xdescinssus <> "" Then
                    param20.Value = aipinssus.xdescinssus
                Else
                    param20.Value = " "
                End If
                param20.ParameterName = "p_xdescinssus"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Varchar2
                param21.Size = 20
                If aipinssus.iestatinssus IsNot Nothing And aipinssus.iestatinssus <> "" Then
                    param21.Value = aipinssus.iestatinssus
                Else
                    param21.Value = " "
                End If
                param21.ParameterName = "p_iestatinssus"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.Decimal
                param22.Precision = 18
                param22.Scale = 0
                param22.Value = 0
                param22.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssus FLOAT; v_p_idaipinsenc FLOAT; v_p_xnomintinssus VARCHAR2(50); v_p_xnomsolinssus VARCHAR2(50); v_p_iluginssus VARCHAR2(20); v_p_idaipmanveh FLOAT; v_p_nkiloinssus number; v_p_xsucuinssus VARCHAR2(100); v_p_iserbodinssus number; v_p_ialarcorrinssus number; v_p_xserinssus VARCHAR2(50); v_p_xdictinssus LONG; v_p_xdescinssus VARCHAR2(500); v_p_iestatinssus VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssus(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssus,:v_p_idaipinsenc,:v_p_xnomintinssus,:v_p_xnomsolinssus,:v_p_iluginssus,:v_p_idaipmanveh,:v_p_nkiloinssus,:v_p_xsucuinssus,:v_p_iserbodinssus,:v_p_ialarcorrinssus,:v_p_xserinssus,:v_p_xdictinssus,:v_p_xdescinssus,:v_p_iestatinssus,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
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
        Public Function modaipinssus(aipinssus As aipinssus) As respopera
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
                    param8.Value = aipinssus.idaipinssus
                    param8.ParameterName = "p_idaipinssus"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssus.idaipinsenc
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.VarChar
                    param10.Size = 50
                    If aipinssus.xnomintinssus IsNot Nothing Then
                        param10.Value = aipinssus.xnomintinssus
                    Else
                        param10.Value = ""
                    End If
                    param10.ParameterName = "p_xnomintinssus"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 50
                    If aipinssus.xnomsolinssus IsNot Nothing Then
                        param11.Value = aipinssus.xnomsolinssus
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_xnomsolinssus"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    If aipinssus.iluginssus IsNot Nothing Then
                        param12.Value = aipinssus.iluginssus
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_iluginssus"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Decimal
                    param13.Precision = 18
                    param13.Scale = 0
                    param13.Value = aipinssus.idaipmanveh
                    param13.ParameterName = "p_idaipmanveh"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Int
                    param14.Value = aipinssus.nkiloinssus
                    param14.ParameterName = "p_nkiloinssus"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 100
                    If aipinssus.xsucuinssus IsNot Nothing Then
                        param15.Value = aipinssus.xsucuinssus
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xsucuinssus"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Bit
                    param16.Value = aipinssus.iserbodinssus
                    param16.ParameterName = "p_iserbodinssus"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.Bit
                    param17.Value = aipinssus.ialarcorrinssus
                    param17.ParameterName = "p_ialarcorrinssus"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 50
                    If aipinssus.xserinssus IsNot Nothing Then
                        param18.Value = aipinssus.xserinssus
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xserinssus"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 500
                    If aipinssus.xdictinssus IsNot Nothing Then
                        param19.Value = aipinssus.xdictinssus
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_xdictinssus"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 500
                    If aipinssus.xdescinssus IsNot Nothing Then
                        param20.Value = aipinssus.xdescinssus
                    Else
                        param20.Value = ""
                    End If
                    param20.ParameterName = "p_xdescinssus"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 20
                    If aipinssus.iestatinssus IsNot Nothing Then
                        param21.Value = aipinssus.iestatinssus
                    Else
                        param21.Value = ""
                    End If
                    param21.ParameterName = "p_iestatinssus"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.Decimal
                    param22.Precision = 18
                    param22.Scale = 0
                    param22.Value = aipinssus.idseglogreg
                    param22.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssus @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssus output,@p_idaipinsenc,@p_xnomintinssus,@p_xnomsolinssus,@p_iluginssus,@p_idaipmanveh,@p_nkiloinssus,@p_xsucuinssus,@p_iserbodinssus,@p_ialarcorrinssus,@p_xserinssus,@p_xdictinssus,@p_xdescinssus,@p_iestatinssus,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = modaipinssusoracle(aipinssus)
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
        Public Function modaipinssusoracle(aipinssus As aipinssus) As respopera
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
                param8.Value = aipinssus.idaipinssus
                param8.ParameterName = "p_idaipinssus"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssus.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Varchar2
                param10.Size = 50
                If aipinssus.xnomintinssus IsNot Nothing And aipinssus.xnomintinssus <> "" Then
                    param10.Value = aipinssus.xnomintinssus
                Else
                    param10.Value = " "
                End If
                param10.ParameterName = "p_xnomintinssus"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Varchar2
                param11.Size = 50
                If aipinssus.xnomsolinssus IsNot Nothing And aipinssus.xnomsolinssus <> "" Then
                    param11.Value = aipinssus.xnomsolinssus
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_xnomsolinssus"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 20
                If aipinssus.iluginssus IsNot Nothing And aipinssus.iluginssus <> "" Then
                    param12.Value = aipinssus.iluginssus
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_iluginssus"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                param13.Value = aipinssus.idaipmanveh
                param13.ParameterName = "p_idaipmanveh"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Int32
                param14.Value = aipinssus.nkiloinssus
                param14.ParameterName = "p_nkiloinssus"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 100
                If aipinssus.xsucuinssus IsNot Nothing And aipinssus.xsucuinssus <> "" Then
                    param15.Value = aipinssus.xsucuinssus
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xsucuinssus"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Int16
                param16.Value = aipinssus.iserbodinssus
                param16.ParameterName = "p_iserbodinssus"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Int16
                param17.Value = aipinssus.ialarcorrinssus
                param17.ParameterName = "p_ialarcorrinssus"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 50
                If aipinssus.xserinssus IsNot Nothing And aipinssus.xserinssus <> "" Then
                    param18.Value = aipinssus.xserinssus
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_xserinssus"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Long                
                If aipinssus.xdictinssus IsNot Nothing And aipinssus.xdictinssus <> "" Then
                    param19.Value = aipinssus.xdictinssus
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_xdictinssus"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Varchar2
                param20.Size = 500
                If aipinssus.xdescinssus IsNot Nothing And aipinssus.xdescinssus <> "" Then
                    param20.Value = aipinssus.xdescinssus
                Else
                    param20.Value = " "
                End If
                param20.ParameterName = "p_xdescinssus"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Varchar2
                param21.Size = 20
                If aipinssus.iestatinssus IsNot Nothing And aipinssus.iestatinssus <> "" Then
                    param21.Value = aipinssus.iestatinssus
                Else
                    param21.Value = " "
                End If
                param21.ParameterName = "p_iestatinssus"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.Decimal
                param22.Precision = 18
                param22.Scale = 0
                param22.Value = aipinssus.idseglogreg
                param22.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssus FLOAT; v_p_idaipinsenc FLOAT; v_p_xnomintinssus VARCHAR2(50); v_p_xnomsolinssus VARCHAR2(50); v_p_iluginssus VARCHAR2(20); v_p_idaipmanveh FLOAT; v_p_nkiloinssus number; v_p_xsucuinssus VARCHAR2(100); v_p_iserbodinssus number; v_p_ialarcorrinssus number; v_p_xserinssus VARCHAR2(50); v_p_xdictinssus LONG; v_p_xdescinssus VARCHAR2(500); v_p_iestatinssus VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssus(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssus,:v_p_idaipinsenc,:v_p_xnomintinssus,:v_p_xnomsolinssus,:v_p_iluginssus,:v_p_idaipmanveh,:v_p_nkiloinssus,:v_p_xsucuinssus,:v_p_iserbodinssus,:v_p_ialarcorrinssus,:v_p_xserinssus,:v_p_xdictinssus,:v_p_xdescinssus,:v_p_iestatinssus,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
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
        Public Function eliaipinssus(aipinssus As aipinssus) As respopera
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
                    param8.Value = aipinssus.idaipinssus
                    param8.ParameterName = "p_idaipinssus"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipinssus.idaipinsenc
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.VarChar
                    param10.Size = 50
                    If aipinssus.xnomintinssus IsNot Nothing Then
                        param10.Value = aipinssus.xnomintinssus
                    Else
                        param10.Value = ""
                    End If
                    param10.ParameterName = "p_xnomintinssus"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 50
                    If aipinssus.xnomsolinssus IsNot Nothing Then
                        param11.Value = aipinssus.xnomsolinssus
                    Else
                        param11.Value = ""
                    End If
                    param11.ParameterName = "p_xnomsolinssus"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    If aipinssus.iluginssus IsNot Nothing Then
                        param12.Value = aipinssus.iluginssus
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_iluginssus"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Decimal
                    param13.Precision = 18
                    param13.Scale = 0
                    param13.Value = aipinssus.idaipmanveh
                    param13.ParameterName = "p_idaipmanveh"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Int
                    param14.Value = aipinssus.nkiloinssus
                    param14.ParameterName = "p_nkiloinssus"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 100
                    If aipinssus.xsucuinssus IsNot Nothing Then
                        param15.Value = aipinssus.xsucuinssus
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xsucuinssus"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Bit
                    param16.Value = aipinssus.iserbodinssus
                    param16.ParameterName = "p_iserbodinssus"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.Bit
                    param17.Value = aipinssus.ialarcorrinssus
                    param17.ParameterName = "p_ialarcorrinssus"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 50
                    If aipinssus.xserinssus IsNot Nothing Then
                        param18.Value = aipinssus.xserinssus
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xserinssus"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 500
                    If aipinssus.xdictinssus IsNot Nothing Then
                        param19.Value = aipinssus.xdictinssus
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_xdictinssus"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 500
                    If aipinssus.xdescinssus IsNot Nothing Then
                        param20.Value = aipinssus.xdescinssus
                    Else
                        param20.Value = ""
                    End If
                    param20.ParameterName = "p_xdescinssus"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 20
                    If aipinssus.iestatinssus IsNot Nothing Then
                        param21.Value = aipinssus.iestatinssus
                    Else
                        param21.Value = ""
                    End If
                    param21.ParameterName = "p_iestatinssus"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.Decimal
                    param22.Precision = 18
                    param22.Scale = 0
                    param22.Value = aipinssus.idseglogreg
                    param22.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssus @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssus output,@p_idaipinsenc,@p_xnomintinssus,@p_xnomsolinssus,@p_iluginssus,@p_idaipmanveh,@p_nkiloinssus,@p_xsucuinssus,@p_iserbodinssus,@p_ialarcorrinssus,@p_xserinssus,@p_xdictinssus,@p_xdescinssus,@p_iestatinssus,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipinssusoracle(aipinssus)
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
        Public Function eliaipinssusoracle(aipinssus As aipinssus) As respopera
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
                param8.Value = aipinssus.idaipinssus
                param8.ParameterName = "p_idaipinssus"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssus.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Varchar2
                param10.Size = 50
                If aipinssus.xnomintinssus IsNot Nothing And aipinssus.xnomintinssus <> "" Then
                    param10.Value = aipinssus.xnomintinssus
                Else
                    param10.Value = " "
                End If
                param10.ParameterName = "p_xnomintinssus"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Varchar2
                param11.Size = 50
                If aipinssus.xnomsolinssus IsNot Nothing And aipinssus.xnomsolinssus <> "" Then
                    param11.Value = aipinssus.xnomsolinssus
                Else
                    param11.Value = " "
                End If
                param11.ParameterName = "p_xnomsolinssus"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 20
                If aipinssus.iluginssus IsNot Nothing And aipinssus.iluginssus <> "" Then
                    param12.Value = aipinssus.iluginssus
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_iluginssus"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                param13.Value = aipinssus.idaipmanveh
                param13.ParameterName = "p_idaipmanveh"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Int32
                param14.Value = aipinssus.nkiloinssus
                param14.ParameterName = "p_nkiloinssus"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 100
                If aipinssus.xsucuinssus IsNot Nothing And aipinssus.xsucuinssus <> "" Then
                    param15.Value = aipinssus.xsucuinssus
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xsucuinssus"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Int16
                param16.Value = aipinssus.iserbodinssus
                param16.ParameterName = "p_iserbodinssus"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Int16
                param17.Value = aipinssus.ialarcorrinssus
                param17.ParameterName = "p_ialarcorrinssus"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 50
                If aipinssus.xserinssus IsNot Nothing And aipinssus.xserinssus <> "" Then
                    param18.Value = aipinssus.xserinssus
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_xserinssus"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Long                
                If aipinssus.xdictinssus IsNot Nothing And aipinssus.xdictinssus <> "" Then
                    param19.Value = aipinssus.xdictinssus
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_xdictinssus"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Varchar2
                param20.Size = 500
                If aipinssus.xdescinssus IsNot Nothing And aipinssus.xdescinssus <> "" Then
                    param20.Value = aipinssus.xdescinssus
                Else
                    param20.Value = " "
                End If
                param20.ParameterName = "p_xdescinssus"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Varchar2
                param21.Size = 20
                If aipinssus.iestatinssus IsNot Nothing And aipinssus.iestatinssus <> "" Then
                    param21.Value = aipinssus.iestatinssus
                Else
                    param21.Value = " "
                End If
                param21.ParameterName = "p_iestatinssus"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.Decimal
                param22.Precision = 18
                param22.Scale = 0
                param22.Value = aipinssus.idseglogreg
                param22.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssus FLOAT; v_p_idaipinsenc FLOAT; v_p_xnomintinssus VARCHAR2(50); v_p_xnomsolinssus VARCHAR2(50); v_p_iluginssus VARCHAR2(20); v_p_idaipmanveh FLOAT; v_p_nkiloinssus number; v_p_xsucuinssus VARCHAR2(100); v_p_iserbodinssus number; v_p_ialarcorrinssus number; v_p_xserinssus VARCHAR2(50); v_p_xdictinssus LONG; v_p_xdescinssus VARCHAR2(500); v_p_iestatinssus VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssus(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssus,:v_p_idaipinsenc,:v_p_xnomintinssus,:v_p_xnomsolinssus,:v_p_iluginssus,:v_p_idaipmanveh,:v_p_nkiloinssus,:v_p_xsucuinssus,:v_p_iserbodinssus,:v_p_ialarcorrinssus,:v_p_xserinssus,:v_p_xdictinssus,:v_p_xdescinssus,:v_p_iestatinssus,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
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
        Public Function eliaipinssus(idaipinssus As Decimal) As respopera
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
                    param8.Value = idaipinssus
                    param8.ParameterName = "p_idaipinssus"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = 0
                    param9.ParameterName = "p_idaipinsenc"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.VarChar
                    param10.Size = 50
                    param10.Value = ""
                    param10.ParameterName = "p_xnomintinssus"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.VarChar
                    param11.Size = 50
                    param11.Value = ""
                    param11.ParameterName = "p_xnomsolinssus"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.VarChar
                    param12.Size = 20
                    param12.Value = ""
                    param12.ParameterName = "p_iluginssus"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Decimal
                    param13.Precision = 18
                    param13.Scale = 0
                    param13.Value = 0
                    param13.ParameterName = "p_idaipmanveh"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Int
                    param14.Value = 0
                    param14.ParameterName = "p_nkiloinssus"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 100
                    param15.Value = ""
                    param15.ParameterName = "p_xsucuinssus"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.Bit
                    param16.Value = 0
                    param16.ParameterName = "p_iserbodinssus"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.Bit
                    param17.Value = 0
                    param17.ParameterName = "p_ialarcorrinssus"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 50
                    param18.Value = ""
                    param18.ParameterName = "p_xserinssus"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 500
                    param19.Value = ""
                    param19.ParameterName = "p_xdictinssus"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 500
                    param20.Value = ""
                    param20.ParameterName = "p_xdescinssus"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 20
                    param21.Value = ""
                    param21.ParameterName = "p_iestatinssus"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.Decimal
                    param22.Precision = 18
                    param22.Scale = 0
                    param22.Value = 0
                    param22.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssus @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssus output,@p_idaipinsenc,@p_xnomintinssus,@p_xnomsolinssus,@p_iluginssus,@p_idaipmanveh,@p_nkiloinssus,@p_xsucuinssus,@p_iserbodinssus,@p_ialarcorrinssus,@p_xserinssus,@p_xdictinssus,@p_xdescinssus,@p_iestatinssus,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipinssusoracle(idaipinssus)
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
        Public Function eliaipinssusoracle(idaipinssus As Decimal) As respopera
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
                param8.Value = idaipinssus
                param8.ParameterName = "p_idaipinssus"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = 0
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = 0
                param10.ParameterName = "p_idaipmanveh"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Varchar2
                param11.Size = 50
                param11.Value = " "
                param11.ParameterName = "p_xnomintinssus"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Varchar2
                param12.Size = 50
                param12.Value = " "
                param12.ParameterName = "p_xnomsolinssus"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Varchar2
                param13.Size = 20
                param13.Value = " "
                param13.ParameterName = "p_iluginssus"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Int32
                param14.Value = 0
                param14.ParameterName = "p_nkiloinssus"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 100
                param15.Value = " "
                param15.ParameterName = "p_xsucuinssus"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Int16
                param16.Value = 0
                param16.ParameterName = "p_iserbodinssus"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Int16
                param17.Value = 0
                param17.ParameterName = "p_ialarcorrinssus"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Varchar2
                param18.Size = 50
                param18.Value = " "
                param18.ParameterName = "p_xserinssus"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Varchar2
                param19.Size = 500
                param19.Value = " "
                param19.ParameterName = "p_xdictinssus"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Varchar2
                param20.Size = 500
                param20.Value = " "
                param20.ParameterName = "p_xdescinssus"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Varchar2
                param21.Size = 20
                param21.Value = " "
                param21.ParameterName = "p_iestatinssus"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.Decimal
                param22.Precision = 18
                param22.Scale = 0
                param22.Value = 0
                param22.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipinssus FLOAT; v_p_idaipinsenc FLOAT; v_p_idaipmanveh FLOAT; v_p_xnomintinssus VARCHAR2(50); v_p_xnomsolinssus VARCHAR2(50); v_p_iluginssus VARCHAR2(20); v_p_nkiloinssus number; v_p_xsucuinssus VARCHAR2(100); v_p_iserbodinssus number; v_p_ialarcorrinssus number; v_p_xserinssus VARCHAR2(50); v_p_xdictinssus LONG; v_p_xdescinssus VARCHAR2(500); v_p_iestatinssus VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipinssus(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipinssus,:v_p_idaipinsenc,:v_p_idaipmanveh,:v_p_xnomintinssus,:v_p_xnomsolinssus,:v_p_iluginssus,:v_p_nkiloinssus,:v_p_xsucuinssus,:v_p_iserbodinssus,:v_p_ialarcorrinssus,:v_p_xserinssus,:v_p_xdictinssus,:v_p_xdescinssus,:v_p_iestatinssus,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
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
        Public Function actaipinssus(aipinssus As aipinssus) As respopera
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
                param8.Value = aipinssus.idaipinssus
                param8.ParameterName = "p_idaipinssus"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssus.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 50
                If aipinssus.xnomintinssus IsNot Nothing Then
                    param10.Value = aipinssus.xnomintinssus
                Else
                    param10.Value = ""
                End If
                param10.ParameterName = "p_xnomintinssus"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 50
                If aipinssus.xnomsolinssus IsNot Nothing Then
                    param11.Value = aipinssus.xnomsolinssus
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_xnomsolinssus"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                If aipinssus.iluginssus IsNot Nothing Then
                    param12.Value = aipinssus.iluginssus
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_iluginssus"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                param13.Value = aipinssus.idaipmanveh
                param13.ParameterName = "p_idaipmanveh"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.Int
                param14.Value = aipinssus.nkiloinssus
                param14.ParameterName = "p_nkiloinssus"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 100
                If aipinssus.xsucuinssus IsNot Nothing Then
                    param15.Value = aipinssus.xsucuinssus
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_xsucuinssus"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.Bit
                param16.Value = aipinssus.iserbodinssus
                param16.ParameterName = "p_iserbodinssus"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.Bit
                param17.Value = aipinssus.ialarcorrinssus
                param17.ParameterName = "p_ialarcorrinssus"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 50
                If aipinssus.xserinssus IsNot Nothing Then
                    param18.Value = aipinssus.xserinssus
                Else
                    param18.Value = ""
                End If
                param18.ParameterName = "p_xserinssus"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.VarChar
                param19.Size = 500
                If aipinssus.xdictinssus IsNot Nothing Then
                    param19.Value = aipinssus.xdictinssus
                Else
                    param19.Value = ""
                End If
                param19.ParameterName = "p_xdictinssus"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.VarChar
                param20.Size = 500
                If aipinssus.xdescinssus IsNot Nothing Then
                    param20.Value = aipinssus.xdescinssus
                Else
                    param20.Value = ""
                End If
                param20.ParameterName = "p_xdescinssus"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.VarChar
                param21.Size = 20
                If aipinssus.iestatinssus IsNot Nothing Then
                    param21.Value = aipinssus.iestatinssus
                Else
                    param21.Value = ""
                End If
                param21.ParameterName = "p_iestatinssus"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.Decimal
                param22.Precision = 18
                param22.Scale = 0
                param22.Value = aipinssus.idseglogreg
                param22.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssus @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssus output,@p_idaipinsenc,@p_xnomintinssus,@p_xnomsolinssus,@p_iluginssus,@p_idaipmanveh,@p_nkiloinssus,@p_xsucuinssus,@p_iserbodinssus,@p_ialarcorrinssus,@p_xserinssus,@p_xdictinssus,@p_xdescinssus,@p_iestatinssus,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22)

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
        Public Function desaipinssus(aipinssus As aipinssus) As respopera
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
                param8.Value = aipinssus.idaipinssus
                param8.ParameterName = "p_idaipinssus"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipinssus.idaipinsenc
                param9.ParameterName = "p_idaipinsenc"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.VarChar
                param10.Size = 50
                If aipinssus.xnomintinssus IsNot Nothing Then
                    param10.Value = aipinssus.xnomintinssus
                Else
                    param10.Value = ""
                End If
                param10.ParameterName = "p_xnomintinssus"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.VarChar
                param11.Size = 50
                If aipinssus.xnomsolinssus IsNot Nothing Then
                    param11.Value = aipinssus.xnomsolinssus
                Else
                    param11.Value = ""
                End If
                param11.ParameterName = "p_xnomsolinssus"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.VarChar
                param12.Size = 20
                If aipinssus.iluginssus IsNot Nothing Then
                    param12.Value = aipinssus.iluginssus
                Else
                    param12.Value = ""
                End If
                param12.ParameterName = "p_iluginssus"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                param13.Value = aipinssus.idaipmanveh
                param13.ParameterName = "p_idaipmanveh"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.Int
                param14.Value = aipinssus.nkiloinssus
                param14.ParameterName = "p_nkiloinssus"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.VarChar
                param15.Size = 100
                If aipinssus.xsucuinssus IsNot Nothing Then
                    param15.Value = aipinssus.xsucuinssus
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_xsucuinssus"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.Bit
                param16.Value = aipinssus.iserbodinssus
                param16.ParameterName = "p_iserbodinssus"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.Bit
                param17.Value = aipinssus.ialarcorrinssus
                param17.ParameterName = "p_ialarcorrinssus"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.VarChar
                param18.Size = 50
                If aipinssus.xserinssus IsNot Nothing Then
                    param18.Value = aipinssus.xserinssus
                Else
                    param18.Value = ""
                End If
                param18.ParameterName = "p_xserinssus"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.VarChar
                param19.Size = 500
                If aipinssus.xdictinssus IsNot Nothing Then
                    param19.Value = aipinssus.xdictinssus
                Else
                    param19.Value = ""
                End If
                param19.ParameterName = "p_xdictinssus"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.VarChar
                param20.Size = 500
                If aipinssus.xdescinssus IsNot Nothing Then
                    param20.Value = aipinssus.xdescinssus
                Else
                    param20.Value = ""
                End If
                param20.ParameterName = "p_xdescinssus"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.VarChar
                param21.Size = 20
                If aipinssus.iestatinssus IsNot Nothing Then
                    param21.Value = aipinssus.iestatinssus
                Else
                    param21.Value = ""
                End If
                param21.ParameterName = "p_iestatinssus"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.Decimal
                param22.Precision = 18
                param22.Scale = 0
                param22.Value = aipinssus.idseglogreg
                param22.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinssus @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinssus output,@p_idaipinsenc,@p_xnomintinssus,@p_xnomsolinssus,@p_iluginssus,@p_idaipmanveh,@p_nkiloinssus,@p_xsucuinssus,@p_iserbodinssus,@p_ialarcorrinssus,@p_xserinssus,@p_xdictinssus,@p_xdescinssus,@p_iestatinssus,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22)

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

        ''metodos no genericos
        'metodos no genericos
        <HttpPost()> _
        Public Function selaipinssusxidenc(idaipinsenc As Decimal) As aipinssus
            Dim aipinssus As aipinssus = (From p In _db.aipinssus
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).SingleOrDefault
            Return aipinssus
        End Function

    End Class
End Namespace
