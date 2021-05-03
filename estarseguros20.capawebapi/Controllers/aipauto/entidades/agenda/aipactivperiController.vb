Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.agenda
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports Oracle.ManagedDataAccess
Namespace aipauto.entidades.controlador
    Public Class aipactivperiController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selaipactivperixid(idaipactivperi As Decimal) As aipactivperi
            Dim aipactivperi As aipactivperi = (From p In _db.aipactivperi
                                            Where p.idaipactivperi = idaipactivperi
                                            Select p).SingleOrDefault
            Return aipactivperi
        End Function

        <HttpPost()> _
        Public Function selaipactivperi() As List(Of aipactivperi)
            Dim lista_aipactivperi As List(Of aipactivperi) = (From p In _db.aipactivperi
                                                        Select p).ToList
            '
            Return lista_aipactivperi
        End Function

        <HttpPost()> _
           Public Function selaipactivperixwheredinamicopag(petiaipactivperipaglist As petiaipactivperipaglist) As respaipactivperipaglist
            Dim sb As New StringBuilder("")
            '
            If petiaipactivperipaglist.aipactivperi.idaipactivperi <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipactivperi=")
                    sb.Append(valor_entero(petiaipactivperipaglist.aipactivperi.idaipactivperi))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipactivperi=")
                        sb.Append(valor_entero(petiaipactivperipaglist.aipactivperi.idaipactivperi))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.idcomunmancont <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunmancont=")
                    sb.Append(valor_entero(petiaipactivperipaglist.aipactivperi.idcomunmancont))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idcomunmancont=")
                        sb.Append(valor_entero(petiaipactivperipaglist.aipactivperi.idcomunmancont))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.idcomunmanpais <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunmanpais=")
                    sb.Append(valor_entero(petiaipactivperipaglist.aipactivperi.idcomunmanpais))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idcomunmanpais=")
                        sb.Append(valor_entero(petiaipactivperipaglist.aipactivperi.idcomunmanpais))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.idcomunmanestado <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunmanestado=")
                    sb.Append(valor_entero(petiaipactivperipaglist.aipactivperi.idcomunmanestado))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idcomunmanestado=")
                        sb.Append(valor_entero(petiaipactivperipaglist.aipactivperi.idcomunmanestado))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.idcomunmanlocalid <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunmanlocalid=")
                    sb.Append(valor_entero(petiaipactivperipaglist.aipactivperi.idcomunmanlocalid))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idcomunmanlocalid=")
                        sb.Append(valor_entero(petiaipactivperipaglist.aipactivperi.idcomunmanlocalid))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.fejecactivperi > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipactivperipaglist.aipactivperi.fejecactivperi)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipactivperipaglist.aipactivperi.fejecactivperi)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.ffinejecactivperi > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.ffinejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipactivperipaglist.aipactivperi.ffinejecactivperi)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.ffinejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipactivperipaglist.aipactivperi.ffinejecactivperi)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.xdireccionactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdireccionactivperi='")
                    sb.Append(petiaipactivperipaglist.aipactivperi.xdireccionactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdireccionactivperi='")
                        sb.Append(petiaipactivperipaglist.aipactivperi.xdireccionactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.xtelfmovilactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xtelfmovilactivperi='")
                    sb.Append(petiaipactivperipaglist.aipactivperi.xtelfmovilactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xtelfmovilactivperi='")
                        sb.Append(petiaipactivperipaglist.aipactivperi.xtelfmovilactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.xnomcliactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnomcliactivperi='")
                    sb.Append(petiaipactivperipaglist.aipactivperi.xnomcliactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnomcliactivperi='")
                        sb.Append(petiaipactivperipaglist.aipactivperi.xnomcliactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.xcorreoelectronicoactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcorreoelectronicoactivperi='")
                    sb.Append(petiaipactivperipaglist.aipactivperi.xcorreoelectronicoactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcorreoelectronicoactivperi='")
                        sb.Append(petiaipactivperipaglist.aipactivperi.xcorreoelectronicoactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.xtituactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xtituactivperi='")
                    sb.Append(petiaipactivperipaglist.aipactivperi.xtituactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xtituactivperi='")
                        sb.Append(petiaipactivperipaglist.aipactivperi.xtituactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.xdescactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdescactivperi='")
                    sb.Append(petiaipactivperipaglist.aipactivperi.xdescactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdescactivperi='")
                        sb.Append(petiaipactivperipaglist.aipactivperi.xdescactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.ialcanactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.ialcanactivperi='")
                    sb.Append(petiaipactivperipaglist.aipactivperi.ialcanactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ialcanactivperi='")
                        sb.Append(petiaipactivperipaglist.aipactivperi.ialcanactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.iestatactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestatactivperi='")
                    sb.Append(petiaipactivperipaglist.aipactivperi.iestatactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatactivperi='")
                        sb.Append(petiaipactivperipaglist.aipactivperi.iestatactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.idsegmanusucrea <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusucrea=")
                    sb.Append(valor_entero(petiaipactivperipaglist.aipactivperi.idsegmanusucrea))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusucrea=")
                        sb.Append(valor_entero(petiaipactivperipaglist.aipactivperi.idsegmanusucrea))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.fcrearegactivperi > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fcrearegactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipactivperipaglist.aipactivperi.fcrearegactivperi)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fcrearegactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petiaipactivperipaglist.aipactivperi.fcrearegactivperi)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petiaipactivperipaglist.aipactivperi.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petiaipactivperipaglist.aipactivperi.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petiaipactivperipaglist.aipactivperi.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respaipactivperipaglist As New respaipactivperipaglist
            respaipactivperipaglist.pagaipactivperi = petiaipactivperipaglist.pagaipactivperi
            Dim skip = skip_paginacion(petiaipactivperipaglist.pagaipactivperi.npagactual, petiaipactivperipaglist.pagaipactivperi.npagtamano)

            If sb.ToString = "" Then
                respaipactivperipaglist.lista_aipactivperi = _db.aipactivperi.OrderBy(petiaipactivperipaglist.pagaipactivperi.xcamposord & " " & petiaipactivperipaglist.pagaipactivperi.idirord).Skip(skip).Take(petiaipactivperipaglist.pagaipactivperi.npagtamano).ToList
            Else
                respaipactivperipaglist.lista_aipactivperi = _db.aipactivperi.Where(sb.ToString).OrderBy(petiaipactivperipaglist.pagaipactivperi.xcamposord & " " & petiaipactivperipaglist.pagaipactivperi.idirord).Skip(skip).Take(petiaipactivperipaglist.pagaipactivperi.npagtamano).ToList
            End If
            '
            If (respaipactivperipaglist.lista_aipactivperi.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selaipactivperixwheredinamicocount(sb)
                respaipactivperipaglist.pagaipactivperi.npagcantidad = cantidad_paginas(cant_entero_reg, respaipactivperipaglist.pagaipactivperi.npagtamano)
            Else
                respaipactivperipaglist.pagaipactivperi.npagcantidad = 0
                respaipactivperipaglist.pagaipactivperi.npagactual = 0
            End If

            Return respaipactivperipaglist
        End Function

        Public Function selaipactivperixwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.aipactivperi.count
            Else
                Return _db.aipactivperi.Where(sb.ToString).Count
            End If
        End Function

        <HttpPost()> _
        Public Function insaipactivperi(aipactivperi As aipactivperi) As respopera
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
                    param2.Value = aipactivperi.idsegmanusucrea
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
                    param8.ParameterName = "p_idaipactivperi"
                    param8.Direction = ParameterDirection.Output

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipactivperi.idcomunmancont
                    param9.ParameterName = "p_idcomunmancont"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipactivperi.idcomunmanpais
                    param10.ParameterName = "p_idcomunmanpais"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Decimal
                    param11.Precision = 18
                    param11.Scale = 0
                    param11.Value = aipactivperi.idcomunmanestado
                    param11.ParameterName = "p_idcomunmanestado"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Decimal
                    param12.Precision = 18
                    param12.Scale = 0
                    param12.Value = aipactivperi.idcomunmanlocalid
                    param12.ParameterName = "p_idcomunmanlocalid"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.DateTime
                    If aipactivperi.fejecactivperi > CDate("01-01-1900") Then
                        param13.Value = aipactivperi.fejecactivperi
                    Else
                        param13.Value = CDate("01-01-1900")
                    End If
                    param13.ParameterName = "p_fejecactivperi"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.DateTime
                    If aipactivperi.ffinejecactivperi > CDate("01-01-1900") Then
                        param14.Value = aipactivperi.ffinejecactivperi
                    Else
                        param14.Value = CDate("01-01-1900")
                    End If
                    param14.ParameterName = "p_ffinejecactivperi"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 50
                    If aipactivperi.xdireccionactivperi IsNot Nothing Then
                        param15.Value = aipactivperi.xdireccionactivperi
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xdireccionactivperi"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.VarChar
                    param16.Size = 20
                    If aipactivperi.xtelfmovilactivperi IsNot Nothing Then
                        param16.Value = aipactivperi.xtelfmovilactivperi
                    Else
                        param16.Value = ""
                    End If
                    param16.ParameterName = "p_xtelfmovilactivperi"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 100
                    If aipactivperi.xnomcliactivperi IsNot Nothing Then
                        param17.Value = aipactivperi.xnomcliactivperi
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xnomcliactivperi"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 50
                    If aipactivperi.xcorreoelectronicoactivperi IsNot Nothing Then
                        param18.Value = aipactivperi.xcorreoelectronicoactivperi
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xcorreoelectronicoactivperi"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 100
                    If aipactivperi.xtituactivperi IsNot Nothing Then
                        param19.Value = aipactivperi.xtituactivperi
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_xtituactivperi"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 500
                    If aipactivperi.xdescactivperi IsNot Nothing Then
                        param20.Value = aipactivperi.xdescactivperi
                    Else
                        param20.Value = ""
                    End If
                    param20.ParameterName = "p_xdescactivperi"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 20
                    If aipactivperi.ialcanactivperi IsNot Nothing Then
                        param21.Value = aipactivperi.ialcanactivperi
                    Else
                        param21.Value = ""
                    End If
                    param21.ParameterName = "p_ialcanactivperi"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.VarChar
                    param22.Size = 20
                    If aipactivperi.iestatactivperi IsNot Nothing Then
                        param22.Value = aipactivperi.iestatactivperi
                    Else
                        param22.Value = ""
                    End If
                    param22.ParameterName = "p_iestatactivperi"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.Decimal
                    param23.Precision = 18
                    param23.Scale = 0
                    param23.Value = aipactivperi.idsegmanusucrea
                    param23.ParameterName = "p_idsegmanusucrea"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.DateTime
                    If aipactivperi.fcrearegactivperi > CDate("01-01-1900") Then
                        param24.Value = aipactivperi.fcrearegactivperi
                    Else
                        param24.Value = CDate("01-01-1900")
                    End If
                    param24.ParameterName = "p_fcrearegactivperi"

                    Dim param25 As New SqlClient.SqlParameter
                    param25.SqlDbType = SqlDbType.Decimal
                    param25.Precision = 18
                    param25.Scale = 0
                    param25.Value = 0
                    param25.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipactivperi @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipactivperi output,@p_idcomunmancont,@p_idcomunmanpais,@p_idcomunmanestado,@p_idcomunmanlocalid,@p_fejecactivperi,@p_ffinejecactivperi,@p_xdireccionactivperi,@p_xtelfmovilactivperi,@p_xnomcliactivperi,@p_xcorreoelectronicoactivperi,@p_xtituactivperi,@p_xdescactivperi,@p_ialcanactivperi,@p_iestatactivperi,@p_idsegmanusucrea,@p_fcrearegactivperi,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = insaipactivperioracle(aipactivperi)
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
           Public Function insaipactivperioracle(aipactivperi As aipactivperi) As respopera
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
                param8.ParameterName = "p_idaipactivperi"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipactivperi.idcomunmancont
                param9.ParameterName = "p_idcomunmancont"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipactivperi.idcomunmanpais
                param10.ParameterName = "p_idcomunmanpais"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = aipactivperi.idcomunmanestado
                param11.ParameterName = "p_idcomunmanestado"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = aipactivperi.idcomunmanlocalid
                param12.ParameterName = "p_idcomunmanlocalid"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Date
                If aipactivperi.fejecactivperi > CDate("01-01-1900") Then
                    param13.Value = aipactivperi.fejecactivperi
                Else
                    param13.Value = CDate("01-01-1900")
                End If
                param13.ParameterName = "p_fejecactivperi"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Date
                If aipactivperi.ffinejecactivperi > CDate("01-01-1900") Then
                    param14.Value = aipactivperi.ffinejecactivperi
                Else
                    param14.Value = CDate("01-01-1900")
                End If
                param14.ParameterName = "p_ffinejecactivperi"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.VARCHAR2
                param15.Size = 50
                If aipactivperi.xdireccionactivperi IsNot Nothing And aipactivperi.xdireccionactivperi <> "" Then
                    param15.Value = aipactivperi.xdireccionactivperi
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xdireccionactivperi"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.VARCHAR2
                param16.Size = 20
                If aipactivperi.xtelfmovilactivperi IsNot Nothing And aipactivperi.xtelfmovilactivperi <> "" Then
                    param16.Value = aipactivperi.xtelfmovilactivperi
                Else
                    param16.Value = " "
                End If
                param16.ParameterName = "p_xtelfmovilactivperi"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 100
                If aipactivperi.xnomcliactivperi IsNot Nothing And aipactivperi.xnomcliactivperi <> "" Then
                    param17.Value = aipactivperi.xnomcliactivperi
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xnomcliactivperi"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.VARCHAR2
                param18.Size = 50
                If aipactivperi.xcorreoelectronicoactivperi IsNot Nothing And aipactivperi.xcorreoelectronicoactivperi <> "" Then
                    param18.Value = aipactivperi.xcorreoelectronicoactivperi
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_xcorreoelectronicoactivper"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.VARCHAR2
                param19.Size = 100
                If aipactivperi.xtituactivperi IsNot Nothing And aipactivperi.xtituactivperi <> "" Then
                    param19.Value = aipactivperi.xtituactivperi
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_xtituactivperi"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.VARCHAR2
                param20.Size = 500
                If aipactivperi.xdescactivperi IsNot Nothing And aipactivperi.xdescactivperi <> "" Then
                    param20.Value = aipactivperi.xdescactivperi
                Else
                    param20.Value = " "
                End If
                param20.ParameterName = "p_xdescactivperi"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.VARCHAR2
                param21.Size = 20
                If aipactivperi.ialcanactivperi IsNot Nothing And aipactivperi.ialcanactivperi <> "" Then
                    param21.Value = aipactivperi.ialcanactivperi
                Else
                    param21.Value = " "
                End If
                param21.ParameterName = "p_ialcanactivperi"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.VARCHAR2
                param22.Size = 20
                If aipactivperi.iestatactivperi IsNot Nothing And aipactivperi.iestatactivperi <> "" Then
                    param22.Value = aipactivperi.iestatactivperi
                Else
                    param22.Value = " "
                End If
                param22.ParameterName = "p_iestatactivperi"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.Decimal
                param23.Precision = 18
                param23.Scale = 0
                param23.Value = aipactivperi.idsegmanusucrea
                param23.ParameterName = "p_idsegmanusucrea"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.Date
                If aipactivperi.fcrearegactivperi > CDate("01-01-1900") Then
                    param24.Value = aipactivperi.fcrearegactivperi
                Else
                    param24.Value = CDate("01-01-1900")
                End If
                param24.ParameterName = "p_fcrearegactivperi"

                Dim param25 As New Client.OracleParameter
                param25.OracleDbType = Client.OracleDbType.Decimal
                param25.Precision = 18
                param25.Scale = 0
                param25.Value = 0
                param25.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipactivperi FLOAT; v_p_idcomunmancont FLOAT; v_p_idcomunmanpais FLOAT; v_p_idcomunmanestado FLOAT; v_p_idcomunmanlocalid FLOAT; v_p_fejecactivperi date; v_p_ffinejecactivperi date; v_p_xdireccionactivperi VARCHAR2(50); v_p_xtelfmovilactivperi VARCHAR2(20); v_p_xnomcliactivperi VARCHAR2(100); v_p_xcorreoelectronicoactivper VARCHAR2(50); v_p_xtituactivperi VARCHAR2(100); v_p_xdescactivperi VARCHAR2(500); v_p_ialcanactivperi VARCHAR2(20); v_p_iestatactivperi VARCHAR2(20); v_p_idsegmanusucrea FLOAT; v_p_fcrearegactivperi date; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipactivperi(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipactivperi,:v_p_idcomunmancont,:v_p_idcomunmanpais,:v_p_idcomunmanestado,:v_p_idcomunmanlocalid,:v_p_fejecactivperi,:v_p_ffinejecactivperi,:v_p_xdireccionactivperi,:v_p_xtelfmovilactivperi,:v_p_xnomcliactivperi,:v_p_xcorreoelectronicoactivper,:v_p_xtituactivperi,:v_p_xdescactivperi,:v_p_ialcanactivperi,:v_p_iestatactivperi,:v_p_idsegmanusucrea,:v_p_fcrearegactivperi,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25)

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
        Public Function modaipactivperi(aipactivperi As aipactivperi) As respopera
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
                    param8.Value = aipactivperi.idaipactivperi
                    param8.ParameterName = "p_idaipactivperi"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipactivperi.idcomunmancont
                    param9.ParameterName = "p_idcomunmancont"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipactivperi.idcomunmanpais
                    param10.ParameterName = "p_idcomunmanpais"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Decimal
                    param11.Precision = 18
                    param11.Scale = 0
                    param11.Value = aipactivperi.idcomunmanestado
                    param11.ParameterName = "p_idcomunmanestado"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Decimal
                    param12.Precision = 18
                    param12.Scale = 0
                    param12.Value = aipactivperi.idcomunmanlocalid
                    param12.ParameterName = "p_idcomunmanlocalid"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.DateTime
                    If aipactivperi.fejecactivperi > CDate("01-01-1900") Then
                        param13.Value = aipactivperi.fejecactivperi
                    Else
                        param13.Value = CDate("01-01-1900")
                    End If
                    param13.ParameterName = "p_fejecactivperi"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.DateTime
                    If aipactivperi.ffinejecactivperi > CDate("01-01-1900") Then
                        param14.Value = aipactivperi.ffinejecactivperi
                    Else
                        param14.Value = CDate("01-01-1900")
                    End If
                    param14.ParameterName = "p_ffinejecactivperi"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 50
                    If aipactivperi.xdireccionactivperi IsNot Nothing Then
                        param15.Value = aipactivperi.xdireccionactivperi
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xdireccionactivperi"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.VarChar
                    param16.Size = 20
                    If aipactivperi.xtelfmovilactivperi IsNot Nothing Then
                        param16.Value = aipactivperi.xtelfmovilactivperi
                    Else
                        param16.Value = ""
                    End If
                    param16.ParameterName = "p_xtelfmovilactivperi"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 100
                    If aipactivperi.xnomcliactivperi IsNot Nothing Then
                        param17.Value = aipactivperi.xnomcliactivperi
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xnomcliactivperi"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 50
                    If aipactivperi.xcorreoelectronicoactivperi IsNot Nothing Then
                        param18.Value = aipactivperi.xcorreoelectronicoactivperi
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xcorreoelectronicoactivperi"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 100
                    If aipactivperi.xtituactivperi IsNot Nothing Then
                        param19.Value = aipactivperi.xtituactivperi
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_xtituactivperi"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 500
                    If aipactivperi.xdescactivperi IsNot Nothing Then
                        param20.Value = aipactivperi.xdescactivperi
                    Else
                        param20.Value = ""
                    End If
                    param20.ParameterName = "p_xdescactivperi"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 20
                    If aipactivperi.ialcanactivperi IsNot Nothing Then
                        param21.Value = aipactivperi.ialcanactivperi
                    Else
                        param21.Value = ""
                    End If
                    param21.ParameterName = "p_ialcanactivperi"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.VarChar
                    param22.Size = 20
                    If aipactivperi.iestatactivperi IsNot Nothing Then
                        param22.Value = aipactivperi.iestatactivperi
                    Else
                        param22.Value = ""
                    End If
                    param22.ParameterName = "p_iestatactivperi"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.Decimal
                    param23.Precision = 18
                    param23.Scale = 0
                    param23.Value = aipactivperi.idsegmanusucrea
                    param23.ParameterName = "p_idsegmanusucrea"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.DateTime
                    If aipactivperi.fcrearegactivperi > CDate("01-01-1900") Then
                        param24.Value = aipactivperi.fcrearegactivperi
                    Else
                        param24.Value = CDate("01-01-1900")
                    End If
                    param24.ParameterName = "p_fcrearegactivperi"

                    Dim param25 As New SqlClient.SqlParameter
                    param25.SqlDbType = SqlDbType.Decimal
                    param25.Precision = 18
                    param25.Scale = 0
                    param25.Value = aipactivperi.idseglogreg
                    param25.ParameterName = "p_idseglogreg"

                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipactivperi @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipactivperi output,@p_idcomunmancont,@p_idcomunmanpais,@p_idcomunmanestado,@p_idcomunmanlocalid,@p_fejecactivperi,@p_ffinejecactivperi,@p_xdireccionactivperi,@p_xtelfmovilactivperi,@p_xnomcliactivperi,@p_xcorreoelectronicoactivperi,@p_xtituactivperi,@p_xdescactivperi,@p_ialcanactivperi,@p_iestatactivperi,@p_idsegmanusucrea,@p_fcrearegactivperi,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = modaipactivperioracle(aipactivperi)
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
           Public Function modaipactivperioracle(aipactivperi As aipactivperi) As respopera
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
                param8.Value = aipactivperi.idaipactivperi
                param8.ParameterName = "p_idaipactivperi"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipactivperi.idcomunmancont
                param9.ParameterName = "p_idcomunmancont"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipactivperi.idcomunmanpais
                param10.ParameterName = "p_idcomunmanpais"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = aipactivperi.idcomunmanestado
                param11.ParameterName = "p_idcomunmanestado"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = aipactivperi.idcomunmanlocalid
                param12.ParameterName = "p_idcomunmanlocalid"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Date
                If aipactivperi.fejecactivperi > CDate("01-01-1900") Then
                    param13.Value = aipactivperi.fejecactivperi
                Else
                    param13.Value = CDate("01-01-1900")
                End If
                param13.ParameterName = "p_fejecactivperi"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Date
                If aipactivperi.ffinejecactivperi > CDate("01-01-1900") Then
                    param14.Value = aipactivperi.ffinejecactivperi
                Else
                    param14.Value = CDate("01-01-1900")
                End If
                param14.ParameterName = "p_ffinejecactivperi"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.VARCHAR2
                param15.Size = 50
                If aipactivperi.xdireccionactivperi IsNot Nothing And aipactivperi.xdireccionactivperi <> "" Then
                    param15.Value = aipactivperi.xdireccionactivperi
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xdireccionactivperi"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.VARCHAR2
                param16.Size = 20
                If aipactivperi.xtelfmovilactivperi IsNot Nothing And aipactivperi.xtelfmovilactivperi <> "" Then
                    param16.Value = aipactivperi.xtelfmovilactivperi
                Else
                    param16.Value = " "
                End If
                param16.ParameterName = "p_xtelfmovilactivperi"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 100
                If aipactivperi.xnomcliactivperi IsNot Nothing And aipactivperi.xnomcliactivperi <> "" Then
                    param17.Value = aipactivperi.xnomcliactivperi
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xnomcliactivperi"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.VARCHAR2
                param18.Size = 50
                If aipactivperi.xcorreoelectronicoactivperi IsNot Nothing And aipactivperi.xcorreoelectronicoactivperi <> "" Then
                    param18.Value = aipactivperi.xcorreoelectronicoactivperi
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_xcorreoelectronicoactivper"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.VARCHAR2
                param19.Size = 100
                If aipactivperi.xtituactivperi IsNot Nothing And aipactivperi.xtituactivperi <> "" Then
                    param19.Value = aipactivperi.xtituactivperi
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_xtituactivperi"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.VARCHAR2
                param20.Size = 500
                If aipactivperi.xdescactivperi IsNot Nothing And aipactivperi.xdescactivperi <> "" Then
                    param20.Value = aipactivperi.xdescactivperi
                Else
                    param20.Value = " "
                End If
                param20.ParameterName = "p_xdescactivperi"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.VARCHAR2
                param21.Size = 20
                If aipactivperi.ialcanactivperi IsNot Nothing And aipactivperi.ialcanactivperi <> "" Then
                    param21.Value = aipactivperi.ialcanactivperi
                Else
                    param21.Value = " "
                End If
                param21.ParameterName = "p_ialcanactivperi"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.VARCHAR2
                param22.Size = 20
                If aipactivperi.iestatactivperi IsNot Nothing And aipactivperi.iestatactivperi <> "" Then
                    param22.Value = aipactivperi.iestatactivperi
                Else
                    param22.Value = " "
                End If
                param22.ParameterName = "p_iestatactivperi"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.Decimal
                param23.Precision = 18
                param23.Scale = 0
                param23.Value = aipactivperi.idsegmanusucrea
                param23.ParameterName = "p_idsegmanusucrea"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.Date
                If aipactivperi.fcrearegactivperi > CDate("01-01-1900") Then
                    param24.Value = aipactivperi.fcrearegactivperi
                Else
                    param24.Value = CDate("01-01-1900")
                End If
                param24.ParameterName = "p_fcrearegactivperi"

                Dim param25 As New Client.OracleParameter
                param25.OracleDbType = Client.OracleDbType.Decimal
                param25.Precision = 18
                param25.Scale = 0
                param25.Value = aipactivperi.idseglogreg
                param25.ParameterName = "p_idseglogreg"

                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipactivperi FLOAT; v_p_idcomunmancont FLOAT; v_p_idcomunmanpais FLOAT; v_p_idcomunmanestado FLOAT; v_p_idcomunmanlocalid FLOAT; v_p_fejecactivperi date; v_p_ffinejecactivperi date; v_p_xdireccionactivperi VARCHAR2(50); v_p_xtelfmovilactivperi VARCHAR2(20); v_p_xnomcliactivperi VARCHAR2(100); v_p_xcorreoelectronicoactivper VARCHAR2(50); v_p_xtituactivperi VARCHAR2(100); v_p_xdescactivperi VARCHAR2(500); v_p_ialcanactivperi VARCHAR2(20); v_p_iestatactivperi VARCHAR2(20); v_p_idsegmanusucrea FLOAT; v_p_fcrearegactivperi date; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipactivperi(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipactivperi,:v_p_idcomunmancont,:v_p_idcomunmanpais,:v_p_idcomunmanestado,:v_p_idcomunmanlocalid,:v_p_fejecactivperi,:v_p_ffinejecactivperi,:v_p_xdireccionactivperi,:v_p_xtelfmovilactivperi,:v_p_xnomcliactivperi,:v_p_xcorreoelectronicoactivper,:v_p_xtituactivperi,:v_p_xdescactivperi,:v_p_ialcanactivperi,:v_p_iestatactivperi,:v_p_idsegmanusucrea,:v_p_fcrearegactivperi,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"                
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25)

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
        Public Function eliaipactivperi(aipactivperi As aipactivperi) As respopera
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
                    param8.Value = aipactivperi.idaipactivperi
                    param8.ParameterName = "p_idaipactivperi"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipactivperi.idcomunmancont
                    param9.ParameterName = "p_idcomunmancont"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipactivperi.idcomunmanpais
                    param10.ParameterName = "p_idcomunmanpais"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Decimal
                    param11.Precision = 18
                    param11.Scale = 0
                    param11.Value = aipactivperi.idcomunmanestado
                    param11.ParameterName = "p_idcomunmanestado"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Decimal
                    param12.Precision = 18
                    param12.Scale = 0
                    param12.Value = aipactivperi.idcomunmanlocalid
                    param12.ParameterName = "p_idcomunmanlocalid"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.DateTime
                    If aipactivperi.fejecactivperi > CDate("01-01-1900") Then
                        param13.Value = aipactivperi.fejecactivperi
                    Else
                        param13.Value = CDate("01-01-1900")
                    End If
                    param13.ParameterName = "p_fejecactivperi"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.DateTime
                    If aipactivperi.ffinejecactivperi > CDate("01-01-1900") Then
                        param14.Value = aipactivperi.ffinejecactivperi
                    Else
                        param14.Value = CDate("01-01-1900")
                    End If
                    param14.ParameterName = "p_ffinejecactivperi"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 50
                    If aipactivperi.xdireccionactivperi IsNot Nothing Then
                        param15.Value = aipactivperi.xdireccionactivperi
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xdireccionactivperi"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.VarChar
                    param16.Size = 20
                    If aipactivperi.xtelfmovilactivperi IsNot Nothing Then
                        param16.Value = aipactivperi.xtelfmovilactivperi
                    Else
                        param16.Value = ""
                    End If
                    param16.ParameterName = "p_xtelfmovilactivperi"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 100
                    If aipactivperi.xnomcliactivperi IsNot Nothing Then
                        param17.Value = aipactivperi.xnomcliactivperi
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xnomcliactivperi"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 50
                    If aipactivperi.xcorreoelectronicoactivperi IsNot Nothing Then
                        param18.Value = aipactivperi.xcorreoelectronicoactivperi
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xcorreoelectronicoactivperi"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 100
                    If aipactivperi.xtituactivperi IsNot Nothing Then
                        param19.Value = aipactivperi.xtituactivperi
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_xtituactivperi"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 500
                    If aipactivperi.xdescactivperi IsNot Nothing Then
                        param20.Value = aipactivperi.xdescactivperi
                    Else
                        param20.Value = ""
                    End If
                    param20.ParameterName = "p_xdescactivperi"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 20
                    If aipactivperi.ialcanactivperi IsNot Nothing Then
                        param21.Value = aipactivperi.ialcanactivperi
                    Else
                        param21.Value = ""
                    End If
                    param21.ParameterName = "p_ialcanactivperi"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.VarChar
                    param22.Size = 20
                    If aipactivperi.iestatactivperi IsNot Nothing Then
                        param22.Value = aipactivperi.iestatactivperi
                    Else
                        param22.Value = ""
                    End If
                    param22.ParameterName = "p_iestatactivperi"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.Decimal
                    param23.Precision = 18
                    param23.Scale = 0
                    param23.Value = aipactivperi.idsegmanusucrea
                    param23.ParameterName = "p_idsegmanusucrea"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.DateTime
                    If aipactivperi.fcrearegactivperi > CDate("01-01-1900") Then
                        param24.Value = aipactivperi.fcrearegactivperi
                    Else
                        param24.Value = CDate("01-01-1900")
                    End If
                    param24.ParameterName = "p_fcrearegactivperi"

                    Dim param25 As New SqlClient.SqlParameter
                    param25.SqlDbType = SqlDbType.Decimal
                    param25.Precision = 18
                    param25.Scale = 0
                    param25.Value = aipactivperi.idseglogreg
                    param25.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipactivperi @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipactivperi output,@p_idcomunmancont,@p_idcomunmanpais,@p_idcomunmanestado,@p_idcomunmanlocalid,@p_fejecactivperi,@p_ffinejecactivperi,@p_xdireccionactivperi,@p_xtelfmovilactivperi,@p_xnomcliactivperi,@p_xcorreoelectronicoactivperi,@p_xtituactivperi,@p_xdescactivperi,@p_ialcanactivperi,@p_iestatactivperi,@p_idsegmanusucrea,@p_fcrearegactivperi,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipactivperioracle(aipactivperi)
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
           Public Function eliaipactivperioracle(aipactivperi As aipactivperi) As respopera
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
                param8.Value = aipactivperi.idaipactivperi
                param8.ParameterName = "p_idaipactivperi"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipactivperi.idcomunmancont
                param9.ParameterName = "p_idcomunmancont"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipactivperi.idcomunmanpais
                param10.ParameterName = "p_idcomunmanpais"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = aipactivperi.idcomunmanestado
                param11.ParameterName = "p_idcomunmanestado"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = aipactivperi.idcomunmanlocalid
                param12.ParameterName = "p_idcomunmanlocalid"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Date
                If aipactivperi.fejecactivperi > CDate("01-01-1900") Then
                    param13.Value = aipactivperi.fejecactivperi
                Else
                    param13.Value = CDate("01-01-1900")
                End If
                param13.ParameterName = "p_fejecactivperi"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Date
                If aipactivperi.ffinejecactivperi > CDate("01-01-1900") Then
                    param14.Value = aipactivperi.ffinejecactivperi
                Else
                    param14.Value = CDate("01-01-1900")
                End If
                param14.ParameterName = "p_ffinejecactivperi"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.VARCHAR2
                param15.Size = 50
                If aipactivperi.xdireccionactivperi IsNot Nothing And aipactivperi.xdireccionactivperi <> "" Then
                    param15.Value = aipactivperi.xdireccionactivperi
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xdireccionactivperi"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.VARCHAR2
                param16.Size = 20
                If aipactivperi.xtelfmovilactivperi IsNot Nothing And aipactivperi.xtelfmovilactivperi <> "" Then
                    param16.Value = aipactivperi.xtelfmovilactivperi
                Else
                    param16.Value = " "
                End If
                param16.ParameterName = "p_xtelfmovilactivperi"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 100
                If aipactivperi.xnomcliactivperi IsNot Nothing And aipactivperi.xnomcliactivperi <> "" Then
                    param17.Value = aipactivperi.xnomcliactivperi
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xnomcliactivperi"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.VARCHAR2
                param18.Size = 50
                If aipactivperi.xcorreoelectronicoactivperi IsNot Nothing And aipactivperi.xcorreoelectronicoactivperi <> "" Then
                    param18.Value = aipactivperi.xcorreoelectronicoactivperi
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_xcorreoelectronicoactivper"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.VARCHAR2
                param19.Size = 100
                If aipactivperi.xtituactivperi IsNot Nothing And aipactivperi.xtituactivperi <> "" Then
                    param19.Value = aipactivperi.xtituactivperi
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_xtituactivperi"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.VARCHAR2
                param20.Size = 500
                If aipactivperi.xdescactivperi IsNot Nothing And aipactivperi.xdescactivperi <> "" Then
                    param20.Value = aipactivperi.xdescactivperi
                Else
                    param20.Value = " "
                End If
                param20.ParameterName = "p_xdescactivperi"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.VARCHAR2
                param21.Size = 20
                If aipactivperi.ialcanactivperi IsNot Nothing And aipactivperi.ialcanactivperi <> "" Then
                    param21.Value = aipactivperi.ialcanactivperi
                Else
                    param21.Value = " "
                End If
                param21.ParameterName = "p_ialcanactivperi"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.VARCHAR2
                param22.Size = 20
                If aipactivperi.iestatactivperi IsNot Nothing And aipactivperi.iestatactivperi <> "" Then
                    param22.Value = aipactivperi.iestatactivperi
                Else
                    param22.Value = " "
                End If
                param22.ParameterName = "p_iestatactivperi"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.Decimal
                param23.Precision = 18
                param23.Scale = 0
                param23.Value = aipactivperi.idsegmanusucrea
                param23.ParameterName = "p_idsegmanusucrea"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.Date
                If aipactivperi.fcrearegactivperi > CDate("01-01-1900") Then
                    param24.Value = aipactivperi.fcrearegactivperi
                Else
                    param24.Value = CDate("01-01-1900")
                End If
                param24.ParameterName = "p_fcrearegactivperi"

                Dim param25 As New Client.OracleParameter
                param25.OracleDbType = Client.OracleDbType.Decimal
                param25.Precision = 18
                param25.Scale = 0
                param25.Value = aipactivperi.idseglogreg
                param25.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipactivperi FLOAT; v_p_idcomunmancont FLOAT; v_p_idcomunmanpais FLOAT; v_p_idcomunmanestado FLOAT; v_p_idcomunmanlocalid FLOAT; v_p_fejecactivperi date; v_p_ffinejecactivperi date; v_p_xdireccionactivperi VARCHAR2(50); v_p_xtelfmovilactivperi VARCHAR2(20); v_p_xnomcliactivperi VARCHAR2(100); v_p_xcorreoelectronicoactivper VARCHAR2(50); v_p_xtituactivperi VARCHAR2(100); v_p_xdescactivperi VARCHAR2(500); v_p_ialcanactivperi VARCHAR2(20); v_p_iestatactivperi VARCHAR2(20); v_p_idsegmanusucrea FLOAT; v_p_fcrearegactivperi date; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipactivperi(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipactivperi,:v_p_idcomunmancont,:v_p_idcomunmanpais,:v_p_idcomunmanestado,:v_p_idcomunmanlocalid,:v_p_fejecactivperi,:v_p_ffinejecactivperi,:v_p_xdireccionactivperi,:v_p_xtelfmovilactivperi,:v_p_xnomcliactivperi,:v_p_xcorreoelectronicoactivper,:v_p_xtituactivperi,:v_p_xdescactivperi,:v_p_ialcanactivperi,:v_p_iestatactivperi,:v_p_idsegmanusucrea,:v_p_fcrearegactivperi,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25)

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
        Public Function eliaipactivperi(idaipactivperi As Decimal) As respopera
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
                    param8.Value = idaipactivperi
                    param8.ParameterName = "p_idaipactivperi"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = 0
                    param9.ParameterName = "p_idcomunmancont"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = 0
                    param10.ParameterName = "p_idcomunmanpais"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Decimal
                    param11.Precision = 18
                    param11.Scale = 0
                    param11.Value = 0
                    param11.ParameterName = "p_idcomunmanestado"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Decimal
                    param12.Precision = 18
                    param12.Scale = 0
                    param12.Value = 0
                    param12.ParameterName = "p_idcomunmanlocalid"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.DateTime
                    param13.Value = CDate("01-01-1900")
                    param13.ParameterName = "p_fejecactivperi"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.DateTime
                    param14.Value = CDate("01-01-1900")
                    param14.ParameterName = "p_ffinejecactivperi"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 50
                    param15.Value = ""
                    param15.ParameterName = "p_xdireccionactivperi"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.VarChar
                    param16.Size = 20
                    param16.Value = ""
                    param16.ParameterName = "p_xtelfmovilactivperi"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.VarChar
                    param17.Size = 100
                    param17.Value = ""
                    param17.ParameterName = "p_xnomcliactivperi"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.VarChar
                    param18.Size = 50
                    param18.Value = ""
                    param18.ParameterName = "p_xcorreoelectronicoactivperi"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.VarChar
                    param19.Size = 100
                    param19.Value = ""
                    param19.ParameterName = "p_xtituactivperi"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.VarChar
                    param20.Size = 500
                    param20.Value = ""
                    param20.ParameterName = "p_xdescactivperi"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.VarChar
                    param21.Size = 20
                    param21.Value = ""
                    param21.ParameterName = "p_ialcanactivperi"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.VarChar
                    param22.Size = 20
                    param22.Value = ""
                    param22.ParameterName = "p_iestatactivperi"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.Decimal
                    param23.Precision = 18
                    param23.Scale = 0
                    param23.Value = 0
                    param23.ParameterName = "p_idsegmanusucrea"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.DateTime
                    param24.Value = CDate("01-01-1900")
                    param24.ParameterName = "p_fcrearegactivperi"

                    Dim param25 As New SqlClient.SqlParameter
                    param25.SqlDbType = SqlDbType.Decimal
                    param25.Precision = 18
                    param25.Scale = 0
                    param25.Value = 0
                    param25.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipactivperi @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipactivperi output,@p_idcomunmancont,@p_idcomunmanpais,@p_idcomunmanestado,@p_idcomunmanlocalid,@p_fejecactivperi,@p_ffinejecactivperi,@p_xdireccionactivperi,@p_xtelfmovilactivperi,@p_xnomcliactivperi,@p_xcorreoelectronicoactivperi,@p_xtituactivperi,@p_xdescactivperi,@p_ialcanactivperi,@p_iestatactivperi,@p_idsegmanusucrea,@p_fcrearegactivperi,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = eliaipactivperioracle(idaipactivperi)
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
           Public Function eliaipactivperioracle(idaipactivperi As Decimal) As respopera
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
                param8.Value = idaipactivperi
                param8.ParameterName = "p_idaipactivperi"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = 0
                param9.ParameterName = "p_idcomunmancont"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = 0
                param10.ParameterName = "p_idcomunmanpais"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = 0
                param11.ParameterName = "p_idcomunmanestado"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = 0
                param12.ParameterName = "p_idcomunmanlocalid"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Date
                param13.Value = CDate("01-01-1900")
                param13.ParameterName = "p_fejecactivperi"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Date
                param14.Value = CDate("01-01-1900")
                param14.ParameterName = "p_ffinejecactivperi"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.VARCHAR2
                param15.Size = 50
                param15.Value = " "
                param15.ParameterName = "p_xdireccionactivperi"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.VARCHAR2
                param16.Size = 20
                param16.Value = " "
                param16.ParameterName = "p_xtelfmovilactivperi"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 100
                param17.Value = " "
                param17.ParameterName = "p_xnomcliactivperi"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.VARCHAR2
                param18.Size = 50
                param18.Value = " "
                param18.ParameterName = "p_xcorreoelectronicoactivper"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.VARCHAR2
                param19.Size = 100
                param19.Value = " "
                param19.ParameterName = "p_xtituactivperi"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.VARCHAR2
                param20.Size = 500
                param20.Value = " "
                param20.ParameterName = "p_xdescactivperi"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.VARCHAR2
                param21.Size = 20
                param21.Value = " "
                param21.ParameterName = "p_ialcanactivperi"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.VARCHAR2
                param22.Size = 20
                param22.Value = " "
                param22.ParameterName = "p_iestatactivperi"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.Decimal
                param23.Precision = 18
                param23.Scale = 0
                param23.Value = 0
                param23.ParameterName = "p_idsegmanusucrea"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.Date
                param24.Value = CDate("01-01-1900")
                param24.ParameterName = "p_fcrearegactivperi"

                Dim param25 As New Client.OracleParameter
                param25.OracleDbType = Client.OracleDbType.Decimal
                param25.Precision = 18
                param25.Scale = 0
                param25.Value = 0
                param25.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipactivperi FLOAT; v_p_idcomunmancont FLOAT; v_p_idcomunmanpais FLOAT; v_p_idcomunmanestado FLOAT; v_p_idcomunmanlocalid FLOAT; v_p_fejecactivperi date; v_p_ffinejecactivperi date; v_p_xdireccionactivperi VARCHAR2(50); v_p_xtelfmovilactivperi VARCHAR2(20); v_p_xnomcliactivperi VARCHAR2(100); v_p_xcorreoelectronicoactivper VARCHAR2(50); v_p_xtituactivperi VARCHAR2(100); v_p_xdescactivperi VARCHAR2(500); v_p_ialcanactivperi VARCHAR2(20); v_p_iestatactivperi VARCHAR2(20); v_p_idsegmanusucrea FLOAT; v_p_fcrearegactivperi date; v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipactivperi(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipactivperi,:v_p_idcomunmancont,:v_p_idcomunmanpais,:v_p_idcomunmanestado,:v_p_idcomunmanlocalid,:v_p_fejecactivperi,:v_p_ffinejecactivperi,:v_p_xdireccionactivperi,:v_p_xtelfmovilactivperi,:v_p_xnomcliactivperi,:v_p_xcorreoelectronicoactivper,:v_p_xtituactivperi,:v_p_xdescactivperi,:v_p_ialcanactivperi,:v_p_iestatactivperi,:v_p_idsegmanusucrea,:v_p_fcrearegactivperi,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25)

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
        Public Function actaipactivperi(aipactivperi As aipactivperi) As respopera
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
                param8.Value = aipactivperi.idaipactivperi
                param8.ParameterName = "p_idaipactivperi"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipactivperi.idcomunmancont
                param9.ParameterName = "p_idcomunmancont"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipactivperi.idcomunmanpais
                param10.ParameterName = "p_idcomunmanpais"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = aipactivperi.idcomunmanestado
                param11.ParameterName = "p_idcomunmanestado"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = aipactivperi.idcomunmanlocalid
                param12.ParameterName = "p_idcomunmanlocalid"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.datetime
                If aipactivperi.fejecactivperi > CDate("01-01-1900") Then
                    param13.Value = aipactivperi.fejecactivperi
                Else
                    param13.Value = CDate("01-01-1900")
                End If
                param13.ParameterName = "p_fejecactivperi"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.datetime
                If aipactivperi.ffinejecactivperi > CDate("01-01-1900") Then
                    param14.Value = aipactivperi.ffinejecactivperi
                Else
                    param14.Value = CDate("01-01-1900")
                End If
                param14.ParameterName = "p_ffinejecactivperi"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.varchar
                param15.Size = 50
                If aipactivperi.xdireccionactivperi IsNot Nothing Then
                    param15.Value = aipactivperi.xdireccionactivperi
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_xdireccionactivperi"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.varchar
                param16.Size = 20
                If aipactivperi.xtelfmovilactivperi IsNot Nothing Then
                    param16.Value = aipactivperi.xtelfmovilactivperi
                Else
                    param16.Value = ""
                End If
                param16.ParameterName = "p_xtelfmovilactivperi"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.varchar
                param17.Size = 100
                If aipactivperi.xnomcliactivperi IsNot Nothing Then
                    param17.Value = aipactivperi.xnomcliactivperi
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xnomcliactivperi"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.varchar
                param18.Size = 50
                If aipactivperi.xcorreoelectronicoactivperi IsNot Nothing Then
                    param18.Value = aipactivperi.xcorreoelectronicoactivperi
                Else
                    param18.Value = ""
                End If
                param18.ParameterName = "p_xcorreoelectronicoactivperi"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.varchar
                param19.Size = 100
                If aipactivperi.xtituactivperi IsNot Nothing Then
                    param19.Value = aipactivperi.xtituactivperi
                Else
                    param19.Value = ""
                End If
                param19.ParameterName = "p_xtituactivperi"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.varchar
                param20.Size = 500
                If aipactivperi.xdescactivperi IsNot Nothing Then
                    param20.Value = aipactivperi.xdescactivperi
                Else
                    param20.Value = ""
                End If
                param20.ParameterName = "p_xdescactivperi"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.varchar
                param21.Size = 20
                If aipactivperi.ialcanactivperi IsNot Nothing Then
                    param21.Value = aipactivperi.ialcanactivperi
                Else
                    param21.Value = ""
                End If
                param21.ParameterName = "p_ialcanactivperi"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.varchar
                param22.Size = 20
                If aipactivperi.iestatactivperi IsNot Nothing Then
                    param22.Value = aipactivperi.iestatactivperi
                Else
                    param22.Value = ""
                End If
                param22.ParameterName = "p_iestatactivperi"

                Dim param23 As New SqlClient.SqlParameter
                param23.SqlDbType = SqlDbType.decimal
                param23.Precision = 18
                param23.Scale = 0
                param23.Value = aipactivperi.idsegmanusucrea
                param23.ParameterName = "p_idsegmanusucrea"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.datetime
                If aipactivperi.fcrearegactivperi > CDate("01-01-1900") Then
                    param24.Value = aipactivperi.fcrearegactivperi
                Else
                    param24.Value = CDate("01-01-1900")
                End If
                param24.ParameterName = "p_fcrearegactivperi"

                Dim param25 As New SqlClient.SqlParameter
                param25.SqlDbType = SqlDbType.decimal
                param25.Precision = 18
                param25.Scale = 0
                param25.Value = aipactivperi.idseglogreg
                param25.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipactivperi @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipactivperi output,@p_idcomunmancont,@p_idcomunmanpais,@p_idcomunmanestado,@p_idcomunmanlocalid,@p_fejecactivperi,@p_ffinejecactivperi,@p_xdireccionactivperi,@p_xtelfmovilactivperi,@p_xnomcliactivperi,@p_xcorreoelectronicoactivperi,@p_xtituactivperi,@p_xdescactivperi,@p_ialcanactivperi,@p_iestatactivperi,@p_idsegmanusucrea,@p_fcrearegactivperi,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25)

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
        Public Function desaipactivperi(aipactivperi As aipactivperi) As respopera
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
                param8.Value = aipactivperi.idaipactivperi
                param8.ParameterName = "p_idaipactivperi"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipactivperi.idcomunmancont
                param9.ParameterName = "p_idcomunmancont"

                Dim param10 As New SqlClient.SqlParameter
                param10.SqlDbType = SqlDbType.decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipactivperi.idcomunmanpais
                param10.ParameterName = "p_idcomunmanpais"

                Dim param11 As New SqlClient.SqlParameter
                param11.SqlDbType = SqlDbType.decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = aipactivperi.idcomunmanestado
                param11.ParameterName = "p_idcomunmanestado"

                Dim param12 As New SqlClient.SqlParameter
                param12.SqlDbType = SqlDbType.decimal
                param12.Precision = 18
                param12.Scale = 0
                param12.Value = aipactivperi.idcomunmanlocalid
                param12.ParameterName = "p_idcomunmanlocalid"

                Dim param13 As New SqlClient.SqlParameter
                param13.SqlDbType = SqlDbType.datetime
                If aipactivperi.fejecactivperi > CDate("01-01-1900") Then
                    param13.Value = aipactivperi.fejecactivperi
                Else
                    param13.Value = CDate("01-01-1900")
                End If
                param13.ParameterName = "p_fejecactivperi"

                Dim param14 As New SqlClient.SqlParameter
                param14.SqlDbType = SqlDbType.datetime
                If aipactivperi.ffinejecactivperi > CDate("01-01-1900") Then
                    param14.Value = aipactivperi.ffinejecactivperi
                Else
                    param14.Value = CDate("01-01-1900")
                End If
                param14.ParameterName = "p_ffinejecactivperi"

                Dim param15 As New SqlClient.SqlParameter
                param15.SqlDbType = SqlDbType.varchar
                param15.Size = 50
                If aipactivperi.xdireccionactivperi IsNot Nothing Then
                    param15.Value = aipactivperi.xdireccionactivperi
                Else
                    param15.Value = ""
                End If
                param15.ParameterName = "p_xdireccionactivperi"

                Dim param16 As New SqlClient.SqlParameter
                param16.SqlDbType = SqlDbType.varchar
                param16.Size = 20
                If aipactivperi.xtelfmovilactivperi IsNot Nothing Then
                    param16.Value = aipactivperi.xtelfmovilactivperi
                Else
                    param16.Value = ""
                End If
                param16.ParameterName = "p_xtelfmovilactivperi"

                Dim param17 As New SqlClient.SqlParameter
                param17.SqlDbType = SqlDbType.varchar
                param17.Size = 100
                If aipactivperi.xnomcliactivperi IsNot Nothing Then
                    param17.Value = aipactivperi.xnomcliactivperi
                Else
                    param17.Value = ""
                End If
                param17.ParameterName = "p_xnomcliactivperi"

                Dim param18 As New SqlClient.SqlParameter
                param18.SqlDbType = SqlDbType.varchar
                param18.Size = 50
                If aipactivperi.xcorreoelectronicoactivperi IsNot Nothing Then
                    param18.Value = aipactivperi.xcorreoelectronicoactivperi
                Else
                    param18.Value = ""
                End If
                param18.ParameterName = "p_xcorreoelectronicoactivperi"

                Dim param19 As New SqlClient.SqlParameter
                param19.SqlDbType = SqlDbType.varchar
                param19.Size = 100
                If aipactivperi.xtituactivperi IsNot Nothing Then
                    param19.Value = aipactivperi.xtituactivperi
                Else
                    param19.Value = ""
                End If
                param19.ParameterName = "p_xtituactivperi"

                Dim param20 As New SqlClient.SqlParameter
                param20.SqlDbType = SqlDbType.varchar
                param20.Size = 500
                If aipactivperi.xdescactivperi IsNot Nothing Then
                    param20.Value = aipactivperi.xdescactivperi
                Else
                    param20.Value = ""
                End If
                param20.ParameterName = "p_xdescactivperi"

                Dim param21 As New SqlClient.SqlParameter
                param21.SqlDbType = SqlDbType.varchar
                param21.Size = 20
                If aipactivperi.ialcanactivperi IsNot Nothing Then
                    param21.Value = aipactivperi.ialcanactivperi
                Else
                    param21.Value = ""
                End If
                param21.ParameterName = "p_ialcanactivperi"

                Dim param22 As New SqlClient.SqlParameter
                param22.SqlDbType = SqlDbType.varchar
                param22.Size = 20
                If aipactivperi.iestatactivperi IsNot Nothing Then
                    param22.Value = aipactivperi.iestatactivperi
                Else
                    param22.Value = ""
                End If
                param22.ParameterName = "p_iestatactivperi"

                Dim param23 As New SqlClient.SqlParameter
                param23.SqlDbType = SqlDbType.decimal
                param23.Precision = 18
                param23.Scale = 0
                param23.Value = aipactivperi.idsegmanusucrea
                param23.ParameterName = "p_idsegmanusucrea"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.datetime
                If aipactivperi.fcrearegactivperi > CDate("01-01-1900") Then
                    param24.Value = aipactivperi.fcrearegactivperi
                Else
                    param24.Value = CDate("01-01-1900")
                End If
                param24.ParameterName = "p_fcrearegactivperi"

                Dim param25 As New SqlClient.SqlParameter
                param25.SqlDbType = SqlDbType.decimal
                param25.Precision = 18
                param25.Scale = 0
                param25.Value = aipactivperi.idseglogreg
                param25.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipactivperi @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipactivperi output,@p_idcomunmancont,@p_idcomunmanpais,@p_idcomunmanestado,@p_idcomunmanlocalid,@p_fejecactivperi,@p_ffinejecactivperi,@p_xdireccionactivperi,@p_xtelfmovilactivperi,@p_xnomcliactivperi,@p_xcorreoelectronicoactivperi,@p_xtituactivperi,@p_xdescactivperi,@p_ialcanactivperi,@p_iestatactivperi,@p_idsegmanusucrea,@p_fcrearegactivperi,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25)

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
        '<HttpPost()> _
        'Public Function countaipactivperixidsegmanusuejec_fejecactenc_y_ialcanactenc(fejecactivperi As Date, ialcanactivperi As String, idsegmanusu As String) As Decimal
        '    Dim fecha_ini As New Date(fejecactivperi.Year, fejecactivperi.Month, fejecactivperi.Day, 0, 0, 0)
        '    Dim fecha_fin As New Date(fejecactivperi.Year, fejecactivperi.Month, fejecactivperi.Day, 23, 59, 59)
        '    Dim neventos As Decimal = 0
        '    neventos = (From p In _db.aipactivperi
        '                Where p.fejecactivperi >= fecha_ini And p.fejecactivperi <= fecha_fin And p.ialcanactivperi = ialcanactivperi And p.idsegmanusu = idsegmanusu
        '                Select p).Count()
        '    Return neventos
        'End Function

        '<HttpPost()> _
        'Public Function countragactencxidsegmanusuejecdif_fejecactenc_y_ialcanactenc(idsegmanusu As Decimal, fejecactivperi As Date, ialcanactivperi As String) As Decimal
        '    Dim fecha_ini As New Date(fejecactivperi.Year, fejecactivperi.Month, fejecactivperi.Day, 0, 0, 0)
        '    Dim fecha_fin As New Date(fejecactivperi.Year, fejecactivperi.Month, fejecactivperi.Day, 23, 59, 59)
        '    Dim neventos As Decimal = (From p In _db.aipactivperi
        '                               Where p.idsegmanusu <> idsegmanusu And p.fejecactivperi >= fecha_ini And p.fejecactivperi <= fecha_fin And p.ialcanactivperi = ialcanactivperi
        '                               Select p).Count()
        '    Return neventos
        'End Function


        '<HttpPost()> _
        'Public Function selaipactivperixidsegmanusucreaactivperi(idaipactivperi As Decimal, idsegmanusucreaactivperi As Decimal) As aipactivperi
        '    Dim aipactivperi As aipactivperi = (From p In _db.aipactivperi
        '                                    Where p.idaipactivperi = idaipactivperi And p.idsegmanusucreaactivperi = idsegmanusucreaactivperi
        '                                    Select p).SingleOrDefault
        '    Return aipactivperi
        'End Function
    End Class
End Namespace



