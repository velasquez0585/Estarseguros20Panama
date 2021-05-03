Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports Oracle.ManagedDataAccess
Namespace aipauto.entidades.controlador
Public Class aipmanvehController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipmanvehxid(idaipmanveh As Decimal) As aipmanveh
		Dim aipmanveh As aipmanveh = (From p In _db.aipmanveh
										Where p.idaipmanveh = idaipmanveh
										Select p).SingleOrDefault
		Return aipmanveh
	End Function

	<HttpPost()> _
	Public Function selaipmanveh() As List(Of aipmanveh)
            Dim lista_aipmanveh As List(Of aipmanveh) = (From p In _db.aipmanveh
                                                         Where p.idaipmanveh > 0
                                                        Select p).ToList
		'
		Return lista_aipmanveh
	End Function

<HttpPost()> _
	Public Function selaipmanvehxwheredinamicopag(petiaipmanvehpaglist as petiaipmanvehpaglist) as respaipmanvehpaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipmanvehpaglist.aipmanveh.idaipmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanveh=")
				sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.idaipmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanveh=")
				sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.idaipmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.idaipmanvehmar <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmar=")
				sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.idaipmanvehmar))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmar=")
				sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.idaipmanvehmar))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.idaipmanvehmod <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmod=")
				sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.idaipmanvehmod))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmod=")
				sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.idaipmanvehmod))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.idaipmanvehver <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehver=")
				sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.idaipmanvehver))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehver=")
				sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.idaipmanvehver))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.itipotransmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipotransmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.itipotransmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipotransmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.itipotransmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.itipomanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipomanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.itipomanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipomanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.itipomanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.iclasemanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iclasemanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.iclasemanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iclasemanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.iclasemanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.icolormanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.icolormanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.icolormanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.icolormanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.icolormanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.xplacamanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacamanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.xplacamanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacamanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.xplacamanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.xsercarrmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsercarrmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.xsercarrmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsercarrmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.xsercarrmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.xsermotmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsermotmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.xsermotmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsermotmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.xsermotmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.itraccmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itraccmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.itraccmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itraccmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.itraccmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.iimpmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iimpmanveh=")
				sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.iimpmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iimpmanveh=")
				sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.iimpmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.ncilinmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncilinmanveh=")
				sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.ncilinmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncilinmanveh=")
				sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.ncilinmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.xcargmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcargmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.xcargmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcargmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.xcargmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.xcapmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcapmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.xcapmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcapmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.xcapmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
            '
            If petiaipmanvehpaglist.aipmanveh.naniomanveh <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.naniomanveh=")
                    sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.naniomanveh))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.naniomanveh=")
                        sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.naniomanveh))
                        sb.Append("")
                    End If
                End If
            End If
            '
		If petiaipmanvehpaglist.aipmanveh.xdescmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.xdescmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.xdescmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.iestatmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.iestatmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmanveh='")
				sb.Append(petiaipmanvehpaglist.aipmanveh.iestatmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehpaglist.aipmanveh.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipmanvehpaglist.aipmanveh.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipmanvehpaglist As New respaipmanvehpaglist
	respaipmanvehpaglist.pagaipmanveh = petiaipmanvehpaglist.pagaipmanveh
	Dim skip = skip_paginacion(petiaipmanvehpaglist.pagaipmanveh.npagactual, petiaipmanvehpaglist.pagaipmanveh.npagtamano)
	
		If sb.ToString = "" Then
			respaipmanvehpaglist.lista_aipmanveh = _db.aipmanveh.OrderBy(petiaipmanvehpaglist.pagaipmanveh.xcamposord & " "  & petiaipmanvehpaglist.pagaipmanveh.idirord).Skip(skip).Take(petiaipmanvehpaglist.pagaipmanveh.npagtamano).ToList
		Else
			respaipmanvehpaglist.lista_aipmanveh = _db.aipmanveh.Where(sb.ToString).OrderBy(petiaipmanvehpaglist.pagaipmanveh.xcamposord & " "  & petiaipmanvehpaglist.pagaipmanveh.idirord).Skip(skip).Take(petiaipmanvehpaglist.pagaipmanveh.npagtamano).ToList
		End If
		'
		If (respaipmanvehpaglist.lista_aipmanveh.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipmanvehxwheredinamicocount(sb)
		respaipmanvehpaglist.pagaipmanveh.npagcantidad = cantidad_paginas(cant_entero_reg, respaipmanvehpaglist.pagaipmanveh.npagtamano)
		Else
		respaipmanvehpaglist.pagaipmanveh.npagcantidad = 0
		respaipmanvehpaglist.pagaipmanveh.npagactual = 0
		End If
	
		Return respaipmanvehpaglist
	End Function

	Public Function selaipmanvehxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipmanveh.count
	Else
	Return _db.aipmanveh.Where(sb.ToString).Count
	End If
	End Function

        <HttpPost()> _
        Public Function insaipmanveh(aipmanveh As aipmanveh) As respopera
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
                    param8.ParameterName = "p_idaipmanveh"
                    param8.Direction = ParameterDirection.Output

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipmanveh.idaipmanvehmar
                    param9.ParameterName = "p_idaipmanvehmar"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipmanveh.idaipmanvehmod
                    param10.ParameterName = "p_idaipmanvehmod"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.decimal
                    param11.Precision = 18
                    param11.Scale = 0
                    param11.Value = aipmanveh.idaipmanvehver
                    param11.ParameterName = "p_idaipmanvehver"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.varchar
                    param12.Size = 20
                    If aipmanveh.itipotransmanveh IsNot Nothing Then
                        param12.Value = aipmanveh.itipotransmanveh
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_itipotransmanveh"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.varchar
                    param13.Size = 20
                    If aipmanveh.itipomanveh IsNot Nothing Then
                        param13.Value = aipmanveh.itipomanveh
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_itipomanveh"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.varchar
                    param14.Size = 20
                    If aipmanveh.iclasemanveh IsNot Nothing Then
                        param14.Value = aipmanveh.iclasemanveh
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_iclasemanveh"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.varchar
                    param15.Size = 20
                    If aipmanveh.icolormanveh IsNot Nothing Then
                        param15.Value = aipmanveh.icolormanveh
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_icolormanveh"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.varchar
                    param16.Size = 20
                    If aipmanveh.xplacamanveh IsNot Nothing Then
                        param16.Value = aipmanveh.xplacamanveh
                    Else
                        param16.Value = ""
                    End If
                    param16.ParameterName = "p_xplacamanveh"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.varchar
                    param17.Size = 30
                    If aipmanveh.xsercarrmanveh IsNot Nothing Then
                        param17.Value = aipmanveh.xsercarrmanveh
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xsercarrmanveh"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.varchar
                    param18.Size = 30
                    If aipmanveh.xsermotmanveh IsNot Nothing Then
                        param18.Value = aipmanveh.xsermotmanveh
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xsermotmanveh"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.varchar
                    param19.Size = 20
                    If aipmanveh.itraccmanveh IsNot Nothing Then
                        param19.Value = aipmanveh.itraccmanveh
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_itraccmanveh"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.bit
                    param20.Value = aipmanveh.iimpmanveh
                    param20.ParameterName = "p_iimpmanveh"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.smallint
                    param21.Value = aipmanveh.ncilinmanveh
                    param21.ParameterName = "p_ncilinmanveh"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.varchar
                    param22.Size = 10
                    If aipmanveh.xcargmanveh IsNot Nothing Then
                        param22.Value = aipmanveh.xcargmanveh
                    Else
                        param22.Value = ""
                    End If
                    param22.ParameterName = "p_xcargmanveh"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.varchar
                    param23.Size = 10
                    If aipmanveh.xcapmanveh IsNot Nothing Then
                        param23.Value = aipmanveh.xcapmanveh
                    Else
                        param23.Value = ""
                    End If
                    param23.ParameterName = "p_xcapmanveh"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.smallint
                    param24.Value = aipmanveh.naniomanveh
                    param24.ParameterName = "p_naniomanveh"

                    Dim param25 As New SqlClient.SqlParameter
                    param25.SqlDbType = SqlDbType.varchar
                    param25.Size = 500
                    If aipmanveh.xdescmanveh IsNot Nothing Then
                        param25.Value = aipmanveh.xdescmanveh
                    Else
                        param25.Value = ""
                    End If
                    param25.ParameterName = "p_xdescmanveh"

                    Dim param26 As New SqlClient.SqlParameter
                    param26.SqlDbType = SqlDbType.varchar
                    param26.Size = 20
                    If aipmanveh.iestatmanveh IsNot Nothing Then
                        param26.Value = aipmanveh.iestatmanveh
                    Else
                        param26.Value = ""
                    End If
                    param26.ParameterName = "p_iestatmanveh"

                    Dim param27 As New SqlClient.SqlParameter
                    param27.SqlDbType = SqlDbType.decimal
                    param27.Precision = 18
                    param27.Scale = 0
                    param27.Value = 0
                    param27.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanveh @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanveh output,@p_idaipmanvehmar,@p_idaipmanvehmod,@p_idaipmanvehver,@p_itipotransmanveh,@p_itipomanveh,@p_iclasemanveh,@p_icolormanveh,@p_xplacamanveh,@p_xsercarrmanveh,@p_xsermotmanveh,@p_itraccmanveh,@p_iimpmanveh,@p_ncilinmanveh,@p_xcargmanveh,@p_xcapmanveh,@p_naniomanveh,@p_xdescmanveh,@p_iestatmanveh,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27)

                    respopera.irespuesta = param4.Value.ToString()
                    respopera.xmsjusuario = param5.Value.ToString()
                    respopera.xmsjtecnico = param6.Value.ToString()
                    If IsNumeric(param8.Value.ToString()) = True Then
                        respopera.id = Int(param8.Value.ToString())
                    End If

                Else

                    respopera = insaipmanvehoracle(aipmanveh)

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
        Public Function insaipmanvehoracle(aipmanveh As aipmanveh) As respopera
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
                param8.ParameterName = "p_idaipmanveh"
                param8.Direction = ParameterDirection.Output

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipmanveh.idaipmanvehmar
                param9.ParameterName = "p_idaipmanvehmar"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipmanveh.idaipmanvehmod
                param10.ParameterName = "p_idaipmanvehmod"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = aipmanveh.idaipmanvehver
                param11.ParameterName = "p_idaipmanvehver"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.VARCHAR2
                param12.Size = 20
                If aipmanveh.itipotransmanveh IsNot Nothing And aipmanveh.itipotransmanveh <> "" Then
                    param12.Value = aipmanveh.itipotransmanveh
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_itipotransmanveh"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 20
                If aipmanveh.itipomanveh IsNot Nothing And aipmanveh.itipomanveh <> "" Then
                    param13.Value = aipmanveh.itipomanveh
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_itipomanveh"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 20
                If aipmanveh.iclasemanveh IsNot Nothing And aipmanveh.iclasemanveh <> "" Then
                    param14.Value = aipmanveh.iclasemanveh
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_iclasemanveh"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.VARCHAR2
                param15.Size = 20
                If aipmanveh.icolormanveh IsNot Nothing And aipmanveh.icolormanveh <> "" Then
                    param15.Value = aipmanveh.icolormanveh
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_icolormanveh"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.VARCHAR2
                param16.Size = 20
                If aipmanveh.xplacamanveh IsNot Nothing And aipmanveh.xplacamanveh <> "" Then
                    param16.Value = aipmanveh.xplacamanveh
                Else
                    param16.Value = " "
                End If
                param16.ParameterName = "p_xplacamanveh"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 30
                If aipmanveh.xsercarrmanveh IsNot Nothing And aipmanveh.xsercarrmanveh <> "" Then
                    param17.Value = aipmanveh.xsercarrmanveh
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xsercarrmanveh"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.VARCHAR2
                param18.Size = 30
                If aipmanveh.xsermotmanveh IsNot Nothing And aipmanveh.xsermotmanveh <> "" Then
                    param18.Value = aipmanveh.xsermotmanveh
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_xsermotmanveh"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.VARCHAR2
                param19.Size = 20
                If aipmanveh.itraccmanveh IsNot Nothing And aipmanveh.itraccmanveh <> "" Then
                    param19.Value = aipmanveh.itraccmanveh
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_itraccmanveh"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Int16
                param20.Value = aipmanveh.iimpmanveh
                param20.ParameterName = "p_iimpmanveh"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Int16
                param21.Value = aipmanveh.ncilinmanveh
                param21.ParameterName = "p_ncilinmanveh"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.VARCHAR2
                param22.Size = 10
                If aipmanveh.xcargmanveh IsNot Nothing And aipmanveh.xcargmanveh <> "" Then
                    param22.Value = aipmanveh.xcargmanveh
                Else
                    param22.Value = " "
                End If
                param22.ParameterName = "p_xcargmanveh"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.VARCHAR2
                param23.Size = 10
                If aipmanveh.xcapmanveh IsNot Nothing And aipmanveh.xcapmanveh <> "" Then
                    param23.Value = aipmanveh.xcapmanveh
                Else
                    param23.Value = " "
                End If
                param23.ParameterName = "p_xcapmanveh"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.Int16
                param24.Value = aipmanveh.naniomanveh
                param24.ParameterName = "p_naniomanveh"

                Dim param25 As New Client.OracleParameter
                param25.OracleDbType = Client.OracleDbType.VARCHAR2
                param25.Size = 500
                If aipmanveh.xdescmanveh IsNot Nothing And aipmanveh.xdescmanveh <> "" Then
                    param25.Value = aipmanveh.xdescmanveh
                Else
                    param25.Value = " "
                End If
                param25.ParameterName = "p_xdescmanveh"

                Dim param26 As New Client.OracleParameter
                param26.OracleDbType = Client.OracleDbType.VARCHAR2
                param26.Size = 20
                If aipmanveh.iestatmanveh IsNot Nothing And aipmanveh.iestatmanveh <> "" Then
                    param26.Value = aipmanveh.iestatmanveh
                Else
                    param26.Value = " "
                End If
                param26.ParameterName = "p_iestatmanveh"

                Dim param27 As New Client.OracleParameter
                param27.OracleDbType = Client.OracleDbType.Decimal
                param27.Precision = 18
                param27.Scale = 0
                param27.Value = 0
                param27.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipmanveh FLOAT; v_p_idaipmanvehmar FLOAT; v_p_idaipmanvehmod FLOAT; v_p_idaipmanvehver FLOAT; v_p_itipotransmanveh VARCHAR2(20); v_p_itipomanveh VARCHAR2(20); v_p_iclasemanveh VARCHAR2(20); v_p_icolormanveh VARCHAR2(20); v_p_xplacamanveh VARCHAR2(20); v_p_xsercarrmanveh VARCHAR2(30); v_p_xsermotmanveh VARCHAR2(30); v_p_itraccmanveh VARCHAR2(20); v_p_iimpmanveh number; v_p_ncilinmanveh number; v_p_xcargmanveh VARCHAR2(10); v_p_xcapmanveh VARCHAR2(10); v_p_naniomanveh number; v_p_xdescmanveh VARCHAR2(500); v_p_iestatmanveh VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipmanveh(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipmanveh,:v_p_idaipmanvehmar,:v_p_idaipmanvehmod,:v_p_idaipmanvehver,:v_p_itipotransmanveh,:v_p_itipomanveh,:v_p_iclasemanveh,:v_p_icolormanveh,:v_p_xplacamanveh,:v_p_xsercarrmanveh,:v_p_xsermotmanveh,:v_p_itraccmanveh,:v_p_iimpmanveh,:v_p_ncilinmanveh,:v_p_xcargmanveh,:v_p_xcapmanveh,:v_p_naniomanveh,:v_p_xdescmanveh,:v_p_iestatmanveh,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27)

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
        Public Function modaipmanveh(aipmanveh As aipmanveh) As respopera
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
                    param8.Value = aipmanveh.idaipmanveh
                    param8.ParameterName = "p_idaipmanveh"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipmanveh.idaipmanvehmar
                    param9.ParameterName = "p_idaipmanvehmar"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipmanveh.idaipmanvehmod
                    param10.ParameterName = "p_idaipmanvehmod"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.decimal
                    param11.Precision = 18
                    param11.Scale = 0
                    param11.Value = aipmanveh.idaipmanvehver
                    param11.ParameterName = "p_idaipmanvehver"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.varchar
                    param12.Size = 20
                    If aipmanveh.itipotransmanveh IsNot Nothing Then
                        param12.Value = aipmanveh.itipotransmanveh
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_itipotransmanveh"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.varchar
                    param13.Size = 20
                    If aipmanveh.itipomanveh IsNot Nothing Then
                        param13.Value = aipmanveh.itipomanveh
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_itipomanveh"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.varchar
                    param14.Size = 20
                    If aipmanveh.iclasemanveh IsNot Nothing Then
                        param14.Value = aipmanveh.iclasemanveh
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_iclasemanveh"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.varchar
                    param15.Size = 20
                    If aipmanveh.icolormanveh IsNot Nothing Then
                        param15.Value = aipmanveh.icolormanveh
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_icolormanveh"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.varchar
                    param16.Size = 20
                    If aipmanveh.xplacamanveh IsNot Nothing Then
                        param16.Value = aipmanveh.xplacamanveh
                    Else
                        param16.Value = ""
                    End If
                    param16.ParameterName = "p_xplacamanveh"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.varchar
                    param17.Size = 30
                    If aipmanveh.xsercarrmanveh IsNot Nothing Then
                        param17.Value = aipmanveh.xsercarrmanveh
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xsercarrmanveh"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.varchar
                    param18.Size = 30
                    If aipmanveh.xsermotmanveh IsNot Nothing Then
                        param18.Value = aipmanveh.xsermotmanveh
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xsermotmanveh"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.varchar
                    param19.Size = 20
                    If aipmanveh.itraccmanveh IsNot Nothing Then
                        param19.Value = aipmanveh.itraccmanveh
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_itraccmanveh"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.bit
                    param20.Value = aipmanveh.iimpmanveh
                    param20.ParameterName = "p_iimpmanveh"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.smallint
                    param21.Value = aipmanveh.ncilinmanveh
                    param21.ParameterName = "p_ncilinmanveh"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.varchar
                    param22.Size = 10
                    If aipmanveh.xcargmanveh IsNot Nothing Then
                        param22.Value = aipmanveh.xcargmanveh
                    Else
                        param22.Value = ""
                    End If
                    param22.ParameterName = "p_xcargmanveh"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.varchar
                    param23.Size = 10
                    If aipmanveh.xcapmanveh IsNot Nothing Then
                        param23.Value = aipmanveh.xcapmanveh
                    Else
                        param23.Value = ""
                    End If
                    param23.ParameterName = "p_xcapmanveh"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.smallint
                    param24.Value = aipmanveh.naniomanveh
                    param24.ParameterName = "p_naniomanveh"

                    Dim param25 As New SqlClient.SqlParameter
                    param25.SqlDbType = SqlDbType.varchar
                    param25.Size = 500
                    If aipmanveh.xdescmanveh IsNot Nothing Then
                        param25.Value = aipmanveh.xdescmanveh
                    Else
                        param25.Value = ""
                    End If
                    param25.ParameterName = "p_xdescmanveh"

                    Dim param26 As New SqlClient.SqlParameter
                    param26.SqlDbType = SqlDbType.varchar
                    param26.Size = 20
                    If aipmanveh.iestatmanveh IsNot Nothing Then
                        param26.Value = aipmanveh.iestatmanveh
                    Else
                        param26.Value = ""
                    End If
                    param26.ParameterName = "p_iestatmanveh"

                    Dim param27 As New SqlClient.SqlParameter
                    param27.SqlDbType = SqlDbType.decimal
                    param27.Precision = 18
                    param27.Scale = 0
                    param27.Value = aipmanveh.idseglogreg
                    param27.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanveh @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanveh output,@p_idaipmanvehmar,@p_idaipmanvehmod,@p_idaipmanvehver,@p_itipotransmanveh,@p_itipomanveh,@p_iclasemanveh,@p_icolormanveh,@p_xplacamanveh,@p_xsercarrmanveh,@p_xsermotmanveh,@p_itraccmanveh,@p_iimpmanveh,@p_ncilinmanveh,@p_xcargmanveh,@p_xcapmanveh,@p_naniomanveh,@p_xdescmanveh,@p_iestatmanveh,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27)

                    respopera.irespuesta = param4.Value.ToString()
                    respopera.xmsjusuario = param5.Value.ToString()
                    respopera.xmsjtecnico = param6.Value.ToString()
                    If IsNumeric(param8.Value.ToString()) = True Then
                        respopera.id = Int(param8.Value.ToString())
                    End If

                Else

                    respopera = modaipmanvehoracle(aipmanveh)

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
        Public Function modaipmanvehoracle(aipmanveh As aipmanveh) As respopera
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
                param8.Value = aipmanveh.idaipmanveh
                param8.ParameterName = "p_idaipmanveh"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipmanveh.idaipmanvehmar
                param9.ParameterName = "p_idaipmanvehmar"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipmanveh.idaipmanvehmod
                param10.ParameterName = "p_idaipmanvehmod"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = aipmanveh.idaipmanvehver
                param11.ParameterName = "p_idaipmanvehver"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.VARCHAR2
                param12.Size = 20
                If aipmanveh.itipotransmanveh IsNot Nothing And aipmanveh.itipotransmanveh <> "" Then
                    param12.Value = aipmanveh.itipotransmanveh
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_itipotransmanveh"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 20
                If aipmanveh.itipomanveh IsNot Nothing And aipmanveh.itipomanveh <> "" Then
                    param13.Value = aipmanveh.itipomanveh
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_itipomanveh"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 20
                If aipmanveh.iclasemanveh IsNot Nothing And aipmanveh.iclasemanveh <> "" Then
                    param14.Value = aipmanveh.iclasemanveh
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_iclasemanveh"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.VARCHAR2
                param15.Size = 20
                If aipmanveh.icolormanveh IsNot Nothing And aipmanveh.icolormanveh <> "" Then
                    param15.Value = aipmanveh.icolormanveh
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_icolormanveh"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.VARCHAR2
                param16.Size = 20
                If aipmanveh.xplacamanveh IsNot Nothing And aipmanveh.xplacamanveh <> "" Then
                    param16.Value = aipmanveh.xplacamanveh
                Else
                    param16.Value = " "
                End If
                param16.ParameterName = "p_xplacamanveh"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 30
                If aipmanveh.xsercarrmanveh IsNot Nothing And aipmanveh.xsercarrmanveh <> "" Then
                    param17.Value = aipmanveh.xsercarrmanveh
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xsercarrmanveh"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.VARCHAR2
                param18.Size = 30
                If aipmanveh.xsermotmanveh IsNot Nothing And aipmanveh.xsermotmanveh <> "" Then
                    param18.Value = aipmanveh.xsermotmanveh
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_xsermotmanveh"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.VARCHAR2
                param19.Size = 20
                If aipmanveh.itraccmanveh IsNot Nothing And aipmanveh.itraccmanveh <> "" Then
                    param19.Value = aipmanveh.itraccmanveh
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_itraccmanveh"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Int16
                param20.Value = aipmanveh.iimpmanveh
                param20.ParameterName = "p_iimpmanveh"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Int16
                param21.Value = aipmanveh.ncilinmanveh
                param21.ParameterName = "p_ncilinmanveh"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.VARCHAR2
                param22.Size = 10
                If aipmanveh.xcargmanveh IsNot Nothing And aipmanveh.xcargmanveh <> "" Then
                    param22.Value = aipmanveh.xcargmanveh
                Else
                    param22.Value = " "
                End If
                param22.ParameterName = "p_xcargmanveh"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.VARCHAR2
                param23.Size = 10
                If aipmanveh.xcapmanveh IsNot Nothing And aipmanveh.xcapmanveh <> "" Then
                    param23.Value = aipmanveh.xcapmanveh
                Else
                    param23.Value = " "
                End If
                param23.ParameterName = "p_xcapmanveh"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.Int16
                param24.Value = aipmanveh.naniomanveh
                param24.ParameterName = "p_naniomanveh"

                Dim param25 As New Client.OracleParameter
                param25.OracleDbType = Client.OracleDbType.VARCHAR2
                param25.Size = 500
                If aipmanveh.xdescmanveh IsNot Nothing And aipmanveh.xdescmanveh <> "" Then
                    param25.Value = aipmanveh.xdescmanveh
                Else
                    param25.Value = " "
                End If
                param25.ParameterName = "p_xdescmanveh"

                Dim param26 As New Client.OracleParameter
                param26.OracleDbType = Client.OracleDbType.VARCHAR2
                param26.Size = 20
                If aipmanveh.iestatmanveh IsNot Nothing And aipmanveh.iestatmanveh <> "" Then
                    param26.Value = aipmanveh.iestatmanveh
                Else
                    param26.Value = " "
                End If
                param26.ParameterName = "p_iestatmanveh"

                Dim param27 As New Client.OracleParameter
                param27.OracleDbType = Client.OracleDbType.Decimal
                param27.Precision = 18
                param27.Scale = 0
                param27.Value = aipmanveh.idseglogreg
                param27.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipmanveh FLOAT; v_p_idaipmanvehmar FLOAT; v_p_idaipmanvehmod FLOAT; v_p_idaipmanvehver FLOAT; v_p_itipotransmanveh VARCHAR2(20); v_p_itipomanveh VARCHAR2(20); v_p_iclasemanveh VARCHAR2(20); v_p_icolormanveh VARCHAR2(20); v_p_xplacamanveh VARCHAR2(20); v_p_xsercarrmanveh VARCHAR2(30); v_p_xsermotmanveh VARCHAR2(30); v_p_itraccmanveh VARCHAR2(20); v_p_iimpmanveh number; v_p_ncilinmanveh number; v_p_xcargmanveh VARCHAR2(10); v_p_xcapmanveh VARCHAR2(10); v_p_naniomanveh number; v_p_xdescmanveh VARCHAR2(500); v_p_iestatmanveh VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipmanveh(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipmanveh,:v_p_idaipmanvehmar,:v_p_idaipmanvehmod,:v_p_idaipmanvehver,:v_p_itipotransmanveh,:v_p_itipomanveh,:v_p_iclasemanveh,:v_p_icolormanveh,:v_p_xplacamanveh,:v_p_xsercarrmanveh,:v_p_xsermotmanveh,:v_p_itraccmanveh,:v_p_iimpmanveh,:v_p_ncilinmanveh,:v_p_xcargmanveh,:v_p_xcapmanveh,:v_p_naniomanveh,:v_p_xdescmanveh,:v_p_iestatmanveh,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27)

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
        Public Function eliaipmanveh(aipmanveh As aipmanveh) As respopera
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
                    param8.Value = aipmanveh.idaipmanveh
                    param8.ParameterName = "p_idaipmanveh"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = aipmanveh.idaipmanvehmar
                    param9.ParameterName = "p_idaipmanvehmar"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = aipmanveh.idaipmanvehmod
                    param10.ParameterName = "p_idaipmanvehmod"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.decimal
                    param11.Precision = 18
                    param11.Scale = 0
                    param11.Value = aipmanveh.idaipmanvehver
                    param11.ParameterName = "p_idaipmanvehver"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.varchar
                    param12.Size = 20
                    If aipmanveh.itipotransmanveh IsNot Nothing Then
                        param12.Value = aipmanveh.itipotransmanveh
                    Else
                        param12.Value = ""
                    End If
                    param12.ParameterName = "p_itipotransmanveh"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.varchar
                    param13.Size = 20
                    If aipmanveh.itipomanveh IsNot Nothing Then
                        param13.Value = aipmanveh.itipomanveh
                    Else
                        param13.Value = ""
                    End If
                    param13.ParameterName = "p_itipomanveh"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.varchar
                    param14.Size = 20
                    If aipmanveh.iclasemanveh IsNot Nothing Then
                        param14.Value = aipmanveh.iclasemanveh
                    Else
                        param14.Value = ""
                    End If
                    param14.ParameterName = "p_iclasemanveh"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.varchar
                    param15.Size = 20
                    If aipmanveh.icolormanveh IsNot Nothing Then
                        param15.Value = aipmanveh.icolormanveh
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_icolormanveh"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.varchar
                    param16.Size = 20
                    If aipmanveh.xplacamanveh IsNot Nothing Then
                        param16.Value = aipmanveh.xplacamanveh
                    Else
                        param16.Value = ""
                    End If
                    param16.ParameterName = "p_xplacamanveh"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.varchar
                    param17.Size = 30
                    If aipmanveh.xsercarrmanveh IsNot Nothing Then
                        param17.Value = aipmanveh.xsercarrmanveh
                    Else
                        param17.Value = ""
                    End If
                    param17.ParameterName = "p_xsercarrmanveh"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.varchar
                    param18.Size = 30
                    If aipmanveh.xsermotmanveh IsNot Nothing Then
                        param18.Value = aipmanveh.xsermotmanveh
                    Else
                        param18.Value = ""
                    End If
                    param18.ParameterName = "p_xsermotmanveh"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.varchar
                    param19.Size = 20
                    If aipmanveh.itraccmanveh IsNot Nothing Then
                        param19.Value = aipmanveh.itraccmanveh
                    Else
                        param19.Value = ""
                    End If
                    param19.ParameterName = "p_itraccmanveh"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.bit
                    param20.Value = aipmanveh.iimpmanveh
                    param20.ParameterName = "p_iimpmanveh"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.smallint
                    param21.Value = aipmanveh.ncilinmanveh
                    param21.ParameterName = "p_ncilinmanveh"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.varchar
                    param22.Size = 10
                    If aipmanveh.xcargmanveh IsNot Nothing Then
                        param22.Value = aipmanveh.xcargmanveh
                    Else
                        param22.Value = ""
                    End If
                    param22.ParameterName = "p_xcargmanveh"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.varchar
                    param23.Size = 10
                    If aipmanveh.xcapmanveh IsNot Nothing Then
                        param23.Value = aipmanveh.xcapmanveh
                    Else
                        param23.Value = ""
                    End If
                    param23.ParameterName = "p_xcapmanveh"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.smallint
                    param24.Value = aipmanveh.naniomanveh
                    param24.ParameterName = "p_naniomanveh"

                    Dim param25 As New SqlClient.SqlParameter
                    param25.SqlDbType = SqlDbType.varchar
                    param25.Size = 500
                    If aipmanveh.xdescmanveh IsNot Nothing Then
                        param25.Value = aipmanveh.xdescmanveh
                    Else
                        param25.Value = ""
                    End If
                    param25.ParameterName = "p_xdescmanveh"

                    Dim param26 As New SqlClient.SqlParameter
                    param26.SqlDbType = SqlDbType.varchar
                    param26.Size = 20
                    If aipmanveh.iestatmanveh IsNot Nothing Then
                        param26.Value = aipmanveh.iestatmanveh
                    Else
                        param26.Value = ""
                    End If
                    param26.ParameterName = "p_iestatmanveh"

                    Dim param27 As New SqlClient.SqlParameter
                    param27.SqlDbType = SqlDbType.decimal
                    param27.Precision = 18
                    param27.Scale = 0
                    param27.Value = aipmanveh.idseglogreg
                    param27.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanveh @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanveh output,@p_idaipmanvehmar,@p_idaipmanvehmod,@p_idaipmanvehver,@p_itipotransmanveh,@p_itipomanveh,@p_iclasemanveh,@p_icolormanveh,@p_xplacamanveh,@p_xsercarrmanveh,@p_xsermotmanveh,@p_itraccmanveh,@p_iimpmanveh,@p_ncilinmanveh,@p_xcargmanveh,@p_xcapmanveh,@p_naniomanveh,@p_xdescmanveh,@p_iestatmanveh,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27)

                    respopera.irespuesta = param4.Value.ToString()
                    respopera.xmsjusuario = param5.Value.ToString()
                    respopera.xmsjtecnico = param6.Value.ToString()
                    If IsNumeric(param8.Value.ToString()) = True Then
                        respopera.id = Int(param8.Value.ToString())
                    End If

                Else

                    respopera = eliaipmanvehoracle(aipmanveh)

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
        Public Function eliaipmanvehoracle(aipmanveh As aipmanveh) As respopera
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
                param8.Value = aipmanveh.idaipmanveh
                param8.ParameterName = "p_idaipmanveh"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = aipmanveh.idaipmanvehmar
                param9.ParameterName = "p_idaipmanvehmar"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = aipmanveh.idaipmanvehmod
                param10.ParameterName = "p_idaipmanvehmod"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = aipmanveh.idaipmanvehver
                param11.ParameterName = "p_idaipmanvehver"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.VARCHAR2
                param12.Size = 20
                If aipmanveh.itipotransmanveh IsNot Nothing And aipmanveh.itipotransmanveh <> "" Then
                    param12.Value = aipmanveh.itipotransmanveh
                Else
                    param12.Value = " "
                End If
                param12.ParameterName = "p_itipotransmanveh"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 20
                If aipmanveh.itipomanveh IsNot Nothing And aipmanveh.itipomanveh <> "" Then
                    param13.Value = aipmanveh.itipomanveh
                Else
                    param13.Value = " "
                End If
                param13.ParameterName = "p_itipomanveh"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 20
                If aipmanveh.iclasemanveh IsNot Nothing And aipmanveh.iclasemanveh <> "" Then
                    param14.Value = aipmanveh.iclasemanveh
                Else
                    param14.Value = " "
                End If
                param14.ParameterName = "p_iclasemanveh"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.VARCHAR2
                param15.Size = 20
                If aipmanveh.icolormanveh IsNot Nothing And aipmanveh.icolormanveh <> "" Then
                    param15.Value = aipmanveh.icolormanveh
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_icolormanveh"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.VARCHAR2
                param16.Size = 20
                If aipmanveh.xplacamanveh IsNot Nothing And aipmanveh.xplacamanveh <> "" Then
                    param16.Value = aipmanveh.xplacamanveh
                Else
                    param16.Value = " "
                End If
                param16.ParameterName = "p_xplacamanveh"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 30
                If aipmanveh.xsercarrmanveh IsNot Nothing And aipmanveh.xsercarrmanveh <> "" Then
                    param17.Value = aipmanveh.xsercarrmanveh
                Else
                    param17.Value = " "
                End If
                param17.ParameterName = "p_xsercarrmanveh"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.VARCHAR2
                param18.Size = 30
                If aipmanveh.xsermotmanveh IsNot Nothing And aipmanveh.xsermotmanveh <> "" Then
                    param18.Value = aipmanveh.xsermotmanveh
                Else
                    param18.Value = " "
                End If
                param18.ParameterName = "p_xsermotmanveh"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.VARCHAR2
                param19.Size = 20
                If aipmanveh.itraccmanveh IsNot Nothing And aipmanveh.itraccmanveh <> "" Then
                    param19.Value = aipmanveh.itraccmanveh
                Else
                    param19.Value = " "
                End If
                param19.ParameterName = "p_itraccmanveh"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Int16
                param20.Value = aipmanveh.iimpmanveh
                param20.ParameterName = "p_iimpmanveh"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Int16
                param21.Value = aipmanveh.ncilinmanveh
                param21.ParameterName = "p_ncilinmanveh"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.VARCHAR2
                param22.Size = 10
                If aipmanveh.xcargmanveh IsNot Nothing And aipmanveh.xcargmanveh <> "" Then
                    param22.Value = aipmanveh.xcargmanveh
                Else
                    param22.Value = " "
                End If
                param22.ParameterName = "p_xcargmanveh"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.VARCHAR2
                param23.Size = 10
                If aipmanveh.xcapmanveh IsNot Nothing And aipmanveh.xcapmanveh <> "" Then
                    param23.Value = aipmanveh.xcapmanveh
                Else
                    param23.Value = " "
                End If
                param23.ParameterName = "p_xcapmanveh"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.Int16
                param24.Value = aipmanveh.naniomanveh
                param24.ParameterName = "p_naniomanveh"

                Dim param25 As New Client.OracleParameter
                param25.OracleDbType = Client.OracleDbType.VARCHAR2
                param25.Size = 500
                If aipmanveh.xdescmanveh IsNot Nothing And aipmanveh.xdescmanveh <> "" Then
                    param25.Value = aipmanveh.xdescmanveh
                Else
                    param25.Value = " "
                End If
                param25.ParameterName = "p_xdescmanveh"

                Dim param26 As New Client.OracleParameter
                param26.OracleDbType = Client.OracleDbType.VARCHAR2
                param26.Size = 20
                If aipmanveh.iestatmanveh IsNot Nothing And aipmanveh.iestatmanveh <> "" Then
                    param26.Value = aipmanveh.iestatmanveh
                Else
                    param26.Value = " "
                End If
                param26.ParameterName = "p_iestatmanveh"

                Dim param27 As New Client.OracleParameter
                param27.OracleDbType = Client.OracleDbType.Decimal
                param27.Precision = 18
                param27.Scale = 0
                param27.Value = aipmanveh.idseglogreg
                param27.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipmanveh FLOAT; v_p_idaipmanvehmar FLOAT; v_p_idaipmanvehmod FLOAT; v_p_idaipmanvehver FLOAT; v_p_itipotransmanveh VARCHAR2(20); v_p_itipomanveh VARCHAR2(20); v_p_iclasemanveh VARCHAR2(20); v_p_icolormanveh VARCHAR2(20); v_p_xplacamanveh VARCHAR2(20); v_p_xsercarrmanveh VARCHAR2(30); v_p_xsermotmanveh VARCHAR2(30); v_p_itraccmanveh VARCHAR2(20); v_p_iimpmanveh number; v_p_ncilinmanveh number; v_p_xcargmanveh VARCHAR2(10); v_p_xcapmanveh VARCHAR2(10); v_p_naniomanveh number; v_p_xdescmanveh VARCHAR2(500); v_p_iestatmanveh VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipmanveh(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipmanveh,:v_p_idaipmanvehmar,:v_p_idaipmanvehmod,:v_p_idaipmanvehver,:v_p_itipotransmanveh,:v_p_itipomanveh,:v_p_iclasemanveh,:v_p_icolormanveh,:v_p_xplacamanveh,:v_p_xsercarrmanveh,:v_p_xsermotmanveh,:v_p_itraccmanveh,:v_p_iimpmanveh,:v_p_ncilinmanveh,:v_p_xcargmanveh,:v_p_xcapmanveh,:v_p_naniomanveh,:v_p_xdescmanveh,:v_p_iestatmanveh,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27)

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
        Public Function eliaipmanveh(idaipmanveh As Decimal) As respopera
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
                    param8.Value = idaipmanveh
                    param8.ParameterName = "p_idaipmanveh"
                    param8.Direction = ParameterDirection.InputOutput

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = 0
                    param9.ParameterName = "p_idaipmanvehmar"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = 0
                    param10.ParameterName = "p_idaipmanvehmod"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.decimal
                    param11.Precision = 18
                    param11.Scale = 0
                    param11.Value = 0
                    param11.ParameterName = "p_idaipmanvehver"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.varchar
                    param12.Size = 20
                    param12.Value = ""
                    param12.ParameterName = "p_itipotransmanveh"

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.varchar
                    param13.Size = 20
                    param13.Value = ""
                    param13.ParameterName = "p_itipomanveh"

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.varchar
                    param14.Size = 20
                    param14.Value = ""
                    param14.ParameterName = "p_iclasemanveh"

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.varchar
                    param15.Size = 20
                    param15.Value = ""
                    param15.ParameterName = "p_icolormanveh"

                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.varchar
                    param16.Size = 20
                    param16.Value = ""
                    param16.ParameterName = "p_xplacamanveh"

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.varchar
                    param17.Size = 30
                    param17.Value = ""
                    param17.ParameterName = "p_xsercarrmanveh"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.varchar
                    param18.Size = 30
                    param18.Value = ""
                    param18.ParameterName = "p_xsermotmanveh"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.varchar
                    param19.Size = 20
                    param19.Value = ""
                    param19.ParameterName = "p_itraccmanveh"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.bit
                    param20.Value = 0
                    param20.ParameterName = "p_iimpmanveh"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.smallint
                    param21.Value = 0
                    param21.ParameterName = "p_ncilinmanveh"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.varchar
                    param22.Size = 10
                    param22.Value = ""
                    param22.ParameterName = "p_xcargmanveh"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.varchar
                    param23.Size = 10
                    param23.Value = ""
                    param23.ParameterName = "p_xcapmanveh"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.smallint
                    param24.Value = 0
                    param24.ParameterName = "p_naniomanveh"

                    Dim param25 As New SqlClient.SqlParameter
                    param25.SqlDbType = SqlDbType.varchar
                    param25.Size = 500
                    param25.Value = ""
                    param25.ParameterName = "p_xdescmanveh"

                    Dim param26 As New SqlClient.SqlParameter
                    param26.SqlDbType = SqlDbType.varchar
                    param26.Size = 20
                    param26.Value = ""
                    param26.ParameterName = "p_iestatmanveh"

                    Dim param27 As New SqlClient.SqlParameter
                    param27.SqlDbType = SqlDbType.decimal
                    param27.Precision = 18
                    param27.Scale = 0
                    param27.Value = 0
                    param27.ParameterName = "p_idseglogreg"
                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanveh @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanveh output,@p_idaipmanvehmar,@p_idaipmanvehmod,@p_idaipmanvehver,@p_itipotransmanveh,@p_itipomanveh,@p_iclasemanveh,@p_icolormanveh,@p_xplacamanveh,@p_xsercarrmanveh,@p_xsermotmanveh,@p_itraccmanveh,@p_iimpmanveh,@p_ncilinmanveh,@p_xcargmanveh,@p_xcapmanveh,@p_naniomanveh,@p_xdescmanveh,@p_iestatmanveh,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27)

                    respopera.irespuesta = param4.Value.ToString()
                    respopera.xmsjusuario = param5.Value.ToString()
                    respopera.xmsjtecnico = param6.Value.ToString()
                    If IsNumeric(param8.Value.ToString()) = True Then
                        respopera.id = Int(param8.Value.ToString())
                    End If

                Else

                    respopera = eliaipmanvehoracle(idaipmanveh)

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
        Public Function eliaipmanvehoracle(idaipmanveh As Decimal) As respopera
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
                param8.Value = idaipmanveh
                param8.ParameterName = "p_idaipmanveh"
                param8.Direction = ParameterDirection.InputOutput

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = 0
                param9.ParameterName = "p_idaipmanvehmar"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = 0
                param10.ParameterName = "p_idaipmanvehmod"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = 0
                param11.ParameterName = "p_idaipmanvehver"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.VARCHAR2
                param12.Size = 20
                param12.Value = " "
                param12.ParameterName = "p_itipotransmanveh"

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.VARCHAR2
                param13.Size = 20
                param13.Value = " "
                param13.ParameterName = "p_itipomanveh"

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.VARCHAR2
                param14.Size = 20
                param14.Value = " "
                param14.ParameterName = "p_iclasemanveh"

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.VARCHAR2
                param15.Size = 20
                param15.Value = " "
                param15.ParameterName = "p_icolormanveh"

                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.VARCHAR2
                param16.Size = 20
                param16.Value = " "
                param16.ParameterName = "p_xplacamanveh"

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.VARCHAR2
                param17.Size = 30
                param17.Value = " "
                param17.ParameterName = "p_xsercarrmanveh"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.VARCHAR2
                param18.Size = 30
                param18.Value = " "
                param18.ParameterName = "p_xsermotmanveh"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.VARCHAR2
                param19.Size = 20
                param19.Value = " "
                param19.ParameterName = "p_itraccmanveh"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Int16
                param20.Value = 0
                param20.ParameterName = "p_iimpmanveh"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Int16
                param21.Value = 0
                param21.ParameterName = "p_ncilinmanveh"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.VARCHAR2
                param22.Size = 10
                param22.Value = " "
                param22.ParameterName = "p_xcargmanveh"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.VARCHAR2
                param23.Size = 10
                param23.Value = " "
                param23.ParameterName = "p_xcapmanveh"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.Int16
                param24.Value = 0
                param24.ParameterName = "p_naniomanveh"

                Dim param25 As New Client.OracleParameter
                param25.OracleDbType = Client.OracleDbType.VARCHAR2
                param25.Size = 500
                param25.Value = " "
                param25.ParameterName = "p_xdescmanveh"

                Dim param26 As New Client.OracleParameter
                param26.OracleDbType = Client.OracleDbType.VARCHAR2
                param26.Size = 20
                param26.Value = " "
                param26.ParameterName = "p_iestatmanveh"

                Dim param27 As New Client.OracleParameter
                param27.OracleDbType = Client.OracleDbType.Decimal
                param27.Precision = 18
                param27.Scale = 0
                param27.Value = 0
                param27.ParameterName = "p_idseglogreg"
                Dim xdeclare As String = "DECLARE v_p_ioperacion VARCHAR2(32767); v_p_idsegmanusulog FLOAT; v_p_xnombrecortolog VARCHAR2(32767); v_p_irespuesta VARCHAR2(32767); v_p_xmsjusuario VARCHAR2(32767); v_p_xmsjtecnico VARCHAR2(32767); v_p_coderrorlog VARCHAR2(32767); v_p_idaipmanveh FLOAT; v_p_idaipmanvehmar FLOAT; v_p_idaipmanvehmod FLOAT; v_p_idaipmanvehver FLOAT; v_p_itipotransmanveh VARCHAR2(20); v_p_itipomanveh VARCHAR2(20); v_p_iclasemanveh VARCHAR2(20); v_p_icolormanveh VARCHAR2(20); v_p_xplacamanveh VARCHAR2(20); v_p_xsercarrmanveh VARCHAR2(30); v_p_xsermotmanveh VARCHAR2(30); v_p_itraccmanveh VARCHAR2(20); v_p_iimpmanveh number; v_p_ncilinmanveh number; v_p_xcargmanveh VARCHAR2(10); v_p_xcapmanveh VARCHAR2(10); v_p_naniomanveh number; v_p_xdescmanveh VARCHAR2(500); v_p_iestatmanveh VARCHAR2(20); v_p_idseglogreg FLOAT;  cv_1 sys_refcursor; cv_2 sys_refcursor; cv_3 sys_refcursor; cv_4 sys_refcursor; cv_5 sys_refcursor; cv_6 sys_refcursor;"
                Dim xsp As String = "begin sp_aipmanveh(:v_p_ioperacion,:v_p_idsegmanusulog,:v_p_xnombrecortolog,:v_p_irespuesta,:v_p_xmsjusuario,:v_p_xmsjtecnico,:v_p_coderrorlog,:v_p_idaipmanveh,:v_p_idaipmanvehmar,:v_p_idaipmanvehmod,:v_p_idaipmanvehver,:v_p_itipotransmanveh,:v_p_itipomanveh,:v_p_iclasemanveh,:v_p_icolormanveh,:v_p_xplacamanveh,:v_p_xsercarrmanveh,:v_p_xsermotmanveh,:v_p_itraccmanveh,:v_p_iimpmanveh,:v_p_ncilinmanveh,:v_p_xcargmanveh,:v_p_xcapmanveh,:v_p_naniomanveh,:v_p_xdescmanveh,:v_p_iestatmanveh,:v_p_idseglogreg, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27)

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
	Public Function actaipmanveh(aipmanveh as aipmanveh) as respopera
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
	param8.Value = aipmanveh.idaipmanveh
	param8.ParameterName = "p_idaipmanveh"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipmanveh.idaipmanvehmar
	param9.ParameterName = "p_idaipmanvehmar"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipmanveh.idaipmanvehmod
	param10.ParameterName = "p_idaipmanvehmod"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.decimal
	param11.Precision = 18
	param11.Scale = 0
	param11.Value = aipmanveh.idaipmanvehver
	param11.ParameterName = "p_idaipmanvehver"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmanveh.itipotransmanveh IsNot Nothing Then
	param12.Value = aipmanveh.itipotransmanveh
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_itipotransmanveh"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 20
	If aipmanveh.itipomanveh IsNot Nothing Then
	param13.Value = aipmanveh.itipomanveh
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_itipomanveh"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipmanveh.iclasemanveh IsNot Nothing Then
	param14.Value = aipmanveh.iclasemanveh
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iclasemanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 20
	If aipmanveh.icolormanveh IsNot Nothing Then
	param15.Value = aipmanveh.icolormanveh
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_icolormanveh"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.varchar
	param16.Size = 20
	If aipmanveh.xplacamanveh IsNot Nothing Then
	param16.Value = aipmanveh.xplacamanveh
	else
	param16.Value = ""
	end if
	param16.ParameterName = "p_xplacamanveh"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 30
	If aipmanveh.xsercarrmanveh IsNot Nothing Then
	param17.Value = aipmanveh.xsercarrmanveh
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xsercarrmanveh"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 30
	If aipmanveh.xsermotmanveh IsNot Nothing Then
	param18.Value = aipmanveh.xsermotmanveh
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_xsermotmanveh"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.varchar
	param19.Size = 20
	If aipmanveh.itraccmanveh IsNot Nothing Then
	param19.Value = aipmanveh.itraccmanveh
	else
	param19.Value = ""
	end if
	param19.ParameterName = "p_itraccmanveh"
	
	Dim param20 As New SqlClient.SqlParameter
	param20.SqlDbType = SqlDbType.bit
	param20.Value = aipmanveh.iimpmanveh
	param20.ParameterName = "p_iimpmanveh"
	
	Dim param21 As New SqlClient.SqlParameter
	param21.SqlDbType = SqlDbType.smallint
	param21.Value = aipmanveh.ncilinmanveh
	param21.ParameterName = "p_ncilinmanveh"
	
	Dim param22 As New SqlClient.SqlParameter
	param22.SqlDbType = SqlDbType.varchar
	param22.Size = 10
	If aipmanveh.xcargmanveh IsNot Nothing Then
	param22.Value = aipmanveh.xcargmanveh
	else
	param22.Value = ""
	end if
	param22.ParameterName = "p_xcargmanveh"
	
	Dim param23 As New SqlClient.SqlParameter
	param23.SqlDbType = SqlDbType.varchar
	param23.Size = 10
	If aipmanveh.xcapmanveh IsNot Nothing Then
	param23.Value = aipmanveh.xcapmanveh
	else
	param23.Value = ""
	end if
	param23.ParameterName = "p_xcapmanveh"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.SmallInt
                param24.Value = aipmanveh.naniomanveh
                param24.ParameterName = "p_naniomanveh"

                Dim param25 As New SqlClient.SqlParameter
                param25.SqlDbType = SqlDbType.VarChar
                param25.Size = 500
                If aipmanveh.xdescmanveh IsNot Nothing Then
                    param25.Value = aipmanveh.xdescmanveh
                Else
                    param25.Value = ""
                End If
                param25.ParameterName = "p_xdescmanveh"

                Dim param26 As New SqlClient.SqlParameter
                param26.SqlDbType = SqlDbType.VarChar
                param26.Size = 20
                If aipmanveh.iestatmanveh IsNot Nothing Then
                    param26.Value = aipmanveh.iestatmanveh
                Else
                    param26.Value = ""
                End If
                param26.ParameterName = "p_iestatmanveh"

                Dim param27 As New SqlClient.SqlParameter
                param27.SqlDbType = SqlDbType.Decimal
                param27.Precision = 18
                param27.Scale = 0
                param27.Value = aipmanveh.idseglogreg
                param27.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanveh @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanveh output,@p_idaipmanvehmar,@p_idaipmanvehmod,@p_idaipmanvehver,@p_itipotransmanveh,@p_itipomanveh,@p_iclasemanveh,@p_icolormanveh,@p_xplacamanveh,@p_xsercarrmanveh,@p_xsermotmanveh,@p_itraccmanveh,@p_iimpmanveh,@p_ncilinmanveh,@p_xcargmanveh,@p_xcapmanveh,@p_naniomanveh,@p_xdescmanveh,@p_iestatmanveh,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27)
	
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
	Public Function desaipmanveh(aipmanveh as aipmanveh) as respopera
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
	param8.Value = aipmanveh.idaipmanveh
	param8.ParameterName = "p_idaipmanveh"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipmanveh.idaipmanvehmar
	param9.ParameterName = "p_idaipmanvehmar"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipmanveh.idaipmanvehmod
	param10.ParameterName = "p_idaipmanvehmod"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.decimal
	param11.Precision = 18
	param11.Scale = 0
	param11.Value = aipmanveh.idaipmanvehver
	param11.ParameterName = "p_idaipmanvehver"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmanveh.itipotransmanveh IsNot Nothing Then
	param12.Value = aipmanveh.itipotransmanveh
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_itipotransmanveh"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 20
	If aipmanveh.itipomanveh IsNot Nothing Then
	param13.Value = aipmanveh.itipomanveh
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_itipomanveh"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipmanveh.iclasemanveh IsNot Nothing Then
	param14.Value = aipmanveh.iclasemanveh
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iclasemanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 20
	If aipmanveh.icolormanveh IsNot Nothing Then
	param15.Value = aipmanveh.icolormanveh
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_icolormanveh"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.varchar
	param16.Size = 20
	If aipmanveh.xplacamanveh IsNot Nothing Then
	param16.Value = aipmanveh.xplacamanveh
	else
	param16.Value = ""
	end if
	param16.ParameterName = "p_xplacamanveh"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 30
	If aipmanveh.xsercarrmanveh IsNot Nothing Then
	param17.Value = aipmanveh.xsercarrmanveh
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xsercarrmanveh"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 30
	If aipmanveh.xsermotmanveh IsNot Nothing Then
	param18.Value = aipmanveh.xsermotmanveh
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_xsermotmanveh"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.varchar
	param19.Size = 20
	If aipmanveh.itraccmanveh IsNot Nothing Then
	param19.Value = aipmanveh.itraccmanveh
	else
	param19.Value = ""
	end if
	param19.ParameterName = "p_itraccmanveh"
	
	Dim param20 As New SqlClient.SqlParameter
	param20.SqlDbType = SqlDbType.bit
	param20.Value = aipmanveh.iimpmanveh
	param20.ParameterName = "p_iimpmanveh"
	
	Dim param21 As New SqlClient.SqlParameter
	param21.SqlDbType = SqlDbType.smallint
	param21.Value = aipmanveh.ncilinmanveh
	param21.ParameterName = "p_ncilinmanveh"
	
	Dim param22 As New SqlClient.SqlParameter
	param22.SqlDbType = SqlDbType.varchar
	param22.Size = 10
	If aipmanveh.xcargmanveh IsNot Nothing Then
	param22.Value = aipmanveh.xcargmanveh
	else
	param22.Value = ""
	end if
	param22.ParameterName = "p_xcargmanveh"
	
	Dim param23 As New SqlClient.SqlParameter
	param23.SqlDbType = SqlDbType.varchar
	param23.Size = 10
	If aipmanveh.xcapmanveh IsNot Nothing Then
	param23.Value = aipmanveh.xcapmanveh
	else
	param23.Value = ""
	end if
	param23.ParameterName = "p_xcapmanveh"

                Dim param24 As New SqlClient.SqlParameter
                param24.SqlDbType = SqlDbType.SmallInt
                param24.Value = aipmanveh.naniomanveh
                param24.ParameterName = "p_naniomanveh"

                Dim param25 As New SqlClient.SqlParameter
                param25.SqlDbType = SqlDbType.VarChar
                param25.Size = 500
                If aipmanveh.xdescmanveh IsNot Nothing Then
                    param25.Value = aipmanveh.xdescmanveh
                Else
                    param25.Value = ""
                End If
                param25.ParameterName = "p_xdescmanveh"

                Dim param26 As New SqlClient.SqlParameter
                param26.SqlDbType = SqlDbType.VarChar
                param26.Size = 20
                If aipmanveh.iestatmanveh IsNot Nothing Then
                    param26.Value = aipmanveh.iestatmanveh
                Else
                    param26.Value = ""
                End If
                param26.ParameterName = "p_iestatmanveh"

                Dim param27 As New SqlClient.SqlParameter
                param27.SqlDbType = SqlDbType.Decimal
                param27.Precision = 18
                param27.Scale = 0
                param27.Value = aipmanveh.idseglogreg
                param27.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanveh @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanveh output,@p_idaipmanvehmar,@p_idaipmanvehmod,@p_idaipmanvehver,@p_itipotransmanveh,@p_itipomanveh,@p_iclasemanveh,@p_icolormanveh,@p_xplacamanveh,@p_xsercarrmanveh,@p_xsermotmanveh,@p_itraccmanveh,@p_iimpmanveh,@p_ncilinmanveh,@p_xcargmanveh,@p_xcapmanveh,@p_naniomanveh,@p_xdescmanveh,@p_iestatmanveh,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27)
	
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
