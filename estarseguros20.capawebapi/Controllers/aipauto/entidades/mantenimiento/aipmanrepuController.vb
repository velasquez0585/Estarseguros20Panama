Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipmanrepuController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipmanrepuxid(idaipmanrepu As Decimal) As aipmanrepu
		Dim aipmanrepu As aipmanrepu = (From p In _db.aipmanrepu
										Where p.idaipmanrepu = idaipmanrepu
										Select p).SingleOrDefault
		Return aipmanrepu
	End Function

	<HttpPost()> _
	Public Function selaipmanrepu() As List(Of aipmanrepu)
            Dim lista_aipmanrepu As List(Of aipmanrepu) = (From p In _db.aipmanrepu
                Where p.idaipmanrepu > 0
                                                        Select p).ToList
		'
		Return lista_aipmanrepu
	End Function

<HttpPost()> _
	Public Function selaipmanrepuxwheredinamicopag(petiaipmanrepupaglist as petiaipmanrepupaglist) as respaipmanrepupaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipmanrepupaglist.aipmanrepu.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanrepupaglist.aipmanrepu.xnommanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanrepu='")
				sb.Append(petiaipmanrepupaglist.aipmanrepu.xnommanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanrepu='")
				sb.Append(petiaipmanrepupaglist.aipmanrepu.xnommanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanrepupaglist.aipmanrepu.ipartextdelmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ipartextdelmanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.ipartextdelmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ipartextdelmanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.ipartextdelmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanrepupaglist.aipmanrepu.ipartextmedmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ipartextmedmanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.ipartextmedmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ipartextmedmanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.ipartextmedmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanrepupaglist.aipmanrepu.ipartexttrasmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ipartexttrasmanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.ipartexttrasmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ipartexttrasmanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.ipartexttrasmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanrepupaglist.aipmanrepu.ipartintmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ipartintmanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.ipartintmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ipartintmanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.ipartintmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanrepupaglist.aipmanrepu.iposdermanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iposdermanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.iposdermanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iposdermanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.iposdermanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanrepupaglist.aipmanrepu.iposizqmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iposizqmanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.iposizqmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iposizqmanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.iposizqmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanrepupaglist.aipmanrepu.iposfronmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.iposfronmanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.iposfronmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iposfronmanrepu=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.iposfronmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanrepupaglist.aipmanrepu.xdescmanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescmanrepu='")
				sb.Append(petiaipmanrepupaglist.aipmanrepu.xdescmanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescmanrepu='")
				sb.Append(petiaipmanrepupaglist.aipmanrepu.xdescmanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanrepupaglist.aipmanrepu.iestatmanrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmanrepu='")
				sb.Append(petiaipmanrepupaglist.aipmanrepu.iestatmanrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmanrepu='")
				sb.Append(petiaipmanrepupaglist.aipmanrepu.iestatmanrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanrepupaglist.aipmanrepu.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipmanrepupaglist.aipmanrepu.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipmanrepupaglist As New respaipmanrepupaglist
	respaipmanrepupaglist.pagaipmanrepu = petiaipmanrepupaglist.pagaipmanrepu
	Dim skip = skip_paginacion(petiaipmanrepupaglist.pagaipmanrepu.npagactual, petiaipmanrepupaglist.pagaipmanrepu.npagtamano)
	
		If sb.ToString = "" Then
			respaipmanrepupaglist.lista_aipmanrepu = _db.aipmanrepu.OrderBy(petiaipmanrepupaglist.pagaipmanrepu.xcamposord & " "  & petiaipmanrepupaglist.pagaipmanrepu.idirord).Skip(skip).Take(petiaipmanrepupaglist.pagaipmanrepu.npagtamano).ToList
		Else
			respaipmanrepupaglist.lista_aipmanrepu = _db.aipmanrepu.Where(sb.ToString).OrderBy(petiaipmanrepupaglist.pagaipmanrepu.xcamposord & " "  & petiaipmanrepupaglist.pagaipmanrepu.idirord).Skip(skip).Take(petiaipmanrepupaglist.pagaipmanrepu.npagtamano).ToList
		End If
		'
		If (respaipmanrepupaglist.lista_aipmanrepu.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipmanrepuxwheredinamicocount(sb)
		respaipmanrepupaglist.pagaipmanrepu.npagcantidad = cantidad_paginas(cant_entero_reg, respaipmanrepupaglist.pagaipmanrepu.npagtamano)
		Else
		respaipmanrepupaglist.pagaipmanrepu.npagcantidad = 0
		respaipmanrepupaglist.pagaipmanrepu.npagactual = 0
		End If
	
		Return respaipmanrepupaglist
	End Function

	Public Function selaipmanrepuxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipmanrepu.count
	Else
	Return _db.aipmanrepu.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipmanrepu(aipmanrepu as aipmanrepu) as respopera
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
	param8.ParameterName = "p_idaipmanrepu"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanrepu.xnommanrepu IsNot Nothing Then
	param9.Value = aipmanrepu.xnommanrepu
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = aipmanrepu.ipartextdelmanrepu
	param10.ParameterName = "p_ipartextdelmanrepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipmanrepu.ipartextmedmanrepu
	param11.ParameterName = "p_ipartextmedmanrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipmanrepu.ipartexttrasmanrepu
	param12.ParameterName = "p_ipartexttrasmanrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.bit
	param13.Value = aipmanrepu.ipartintmanrepu
	param13.ParameterName = "p_ipartintmanrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.bit
	param14.Value = aipmanrepu.iposdermanrepu
	param14.ParameterName = "p_iposdermanrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.bit
	param15.Value = aipmanrepu.iposizqmanrepu
	param15.ParameterName = "p_iposizqmanrepu"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.bit
	param16.Value = aipmanrepu.iposfronmanrepu
	param16.ParameterName = "p_iposfronmanrepu"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipmanrepu.xdescmanrepu IsNot Nothing Then
	param17.Value = aipmanrepu.xdescmanrepu
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescmanrepu"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipmanrepu.iestatmanrepu IsNot Nothing Then
	param18.Value = aipmanrepu.iestatmanrepu
	else
                    param18.Value = "ACTIVO"
	end if
	param18.ParameterName = "p_iestatmanrepu"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = 0
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanrepu output,@p_xnommanrepu,@p_ipartextdelmanrepu,@p_ipartextmedmanrepu,@p_ipartexttrasmanrepu,@p_ipartintmanrepu,@p_iposdermanrepu,@p_iposizqmanrepu,@p_iposfronmanrepu,@p_xdescmanrepu,@p_iestatmanrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function modaipmanrepu(aipmanrepu as aipmanrepu) as respopera
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
	param2.Value  = 0
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
	param8.Value = aipmanrepu.idaipmanrepu
	param8.ParameterName = "p_idaipmanrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanrepu.xnommanrepu IsNot Nothing Then
	param9.Value = aipmanrepu.xnommanrepu
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = aipmanrepu.ipartextdelmanrepu
	param10.ParameterName = "p_ipartextdelmanrepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipmanrepu.ipartextmedmanrepu
	param11.ParameterName = "p_ipartextmedmanrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipmanrepu.ipartexttrasmanrepu
	param12.ParameterName = "p_ipartexttrasmanrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.bit
	param13.Value = aipmanrepu.ipartintmanrepu
	param13.ParameterName = "p_ipartintmanrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.bit
	param14.Value = aipmanrepu.iposdermanrepu
	param14.ParameterName = "p_iposdermanrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.bit
	param15.Value = aipmanrepu.iposizqmanrepu
	param15.ParameterName = "p_iposizqmanrepu"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.bit
	param16.Value = aipmanrepu.iposfronmanrepu
	param16.ParameterName = "p_iposfronmanrepu"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipmanrepu.xdescmanrepu IsNot Nothing Then
	param17.Value = aipmanrepu.xdescmanrepu
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescmanrepu"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipmanrepu.iestatmanrepu IsNot Nothing Then
	param18.Value = aipmanrepu.iestatmanrepu
	else
                    param18.Value = "ACTIVO"
	end if
	param18.ParameterName = "p_iestatmanrepu"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipmanrepu.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanrepu output,@p_xnommanrepu,@p_ipartextdelmanrepu,@p_ipartextmedmanrepu,@p_ipartexttrasmanrepu,@p_ipartintmanrepu,@p_iposdermanrepu,@p_iposizqmanrepu,@p_iposfronmanrepu,@p_xdescmanrepu,@p_iestatmanrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function eliaipmanrepu(aipmanrepu as aipmanrepu) as respopera
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
	param8.Value = aipmanrepu.idaipmanrepu
	param8.ParameterName = "p_idaipmanrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanrepu.xnommanrepu IsNot Nothing Then
	param9.Value = aipmanrepu.xnommanrepu
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = aipmanrepu.ipartextdelmanrepu
	param10.ParameterName = "p_ipartextdelmanrepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipmanrepu.ipartextmedmanrepu
	param11.ParameterName = "p_ipartextmedmanrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipmanrepu.ipartexttrasmanrepu
	param12.ParameterName = "p_ipartexttrasmanrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.bit
	param13.Value = aipmanrepu.ipartintmanrepu
	param13.ParameterName = "p_ipartintmanrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.bit
	param14.Value = aipmanrepu.iposdermanrepu
	param14.ParameterName = "p_iposdermanrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.bit
	param15.Value = aipmanrepu.iposizqmanrepu
	param15.ParameterName = "p_iposizqmanrepu"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.bit
	param16.Value = aipmanrepu.iposfronmanrepu
	param16.ParameterName = "p_iposfronmanrepu"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipmanrepu.xdescmanrepu IsNot Nothing Then
	param17.Value = aipmanrepu.xdescmanrepu
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescmanrepu"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipmanrepu.iestatmanrepu IsNot Nothing Then
	param18.Value = aipmanrepu.iestatmanrepu
	else
                    param18.Value = "ACTIVO"
	end if
	param18.ParameterName = "p_iestatmanrepu"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipmanrepu.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanrepu output,@p_xnommanrepu,@p_ipartextdelmanrepu,@p_ipartextmedmanrepu,@p_ipartexttrasmanrepu,@p_ipartintmanrepu,@p_iposdermanrepu,@p_iposizqmanrepu,@p_iposfronmanrepu,@p_xdescmanrepu,@p_iestatmanrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function eliaipmanrepu(idaipmanrepu as decimal) as respopera
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
	param8.Value = idaipmanrepu
	param8.ParameterName = "p_idaipmanrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	param9.Value = "
	param9.ParameterName = "p_xnommanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = 0
	param10.ParameterName = "p_ipartextdelmanrepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = 0
	param11.ParameterName = "p_ipartextmedmanrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = 0
	param12.ParameterName = "p_ipartexttrasmanrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.bit
	param13.Value = 0
	param13.ParameterName = "p_ipartintmanrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.bit
	param14.Value = 0
	param14.ParameterName = "p_iposdermanrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.bit
	param15.Value = 0
	param15.ParameterName = "p_iposizqmanrepu"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.bit
	param16.Value = 0
	param16.ParameterName = "p_iposfronmanrepu"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	param17.Value = "
	param17.ParameterName = "p_xdescmanrepu"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
                param18.Value = "ACTIVO"
	param18.ParameterName = "p_iestatmanrepu"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = 0
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanrepu output,@p_xnommanrepu,@p_ipartextdelmanrepu,@p_ipartextmedmanrepu,@p_ipartexttrasmanrepu,@p_ipartintmanrepu,@p_iposdermanrepu,@p_iposizqmanrepu,@p_iposfronmanrepu,@p_xdescmanrepu,@p_iestatmanrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function actaipmanrepu(aipmanrepu as aipmanrepu) as respopera
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
	param8.Value = aipmanrepu.idaipmanrepu
	param8.ParameterName = "p_idaipmanrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanrepu.xnommanrepu IsNot Nothing Then
	param9.Value = aipmanrepu.xnommanrepu
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = aipmanrepu.ipartextdelmanrepu
	param10.ParameterName = "p_ipartextdelmanrepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipmanrepu.ipartextmedmanrepu
	param11.ParameterName = "p_ipartextmedmanrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipmanrepu.ipartexttrasmanrepu
	param12.ParameterName = "p_ipartexttrasmanrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.bit
	param13.Value = aipmanrepu.ipartintmanrepu
	param13.ParameterName = "p_ipartintmanrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.bit
	param14.Value = aipmanrepu.iposdermanrepu
	param14.ParameterName = "p_iposdermanrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.bit
	param15.Value = aipmanrepu.iposizqmanrepu
	param15.ParameterName = "p_iposizqmanrepu"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.bit
	param16.Value = aipmanrepu.iposfronmanrepu
	param16.ParameterName = "p_iposfronmanrepu"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipmanrepu.xdescmanrepu IsNot Nothing Then
	param17.Value = aipmanrepu.xdescmanrepu
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescmanrepu"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipmanrepu.iestatmanrepu IsNot Nothing Then
	param18.Value = aipmanrepu.iestatmanrepu
	else
                    param18.Value = "ACTIVO"
	end if
	param18.ParameterName = "p_iestatmanrepu"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipmanrepu.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanrepu output,@p_xnommanrepu,@p_ipartextdelmanrepu,@p_ipartextmedmanrepu,@p_ipartexttrasmanrepu,@p_ipartintmanrepu,@p_iposdermanrepu,@p_iposizqmanrepu,@p_iposfronmanrepu,@p_xdescmanrepu,@p_iestatmanrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function desaipmanrepu(aipmanrepu as aipmanrepu) as respopera
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
	param8.Value = aipmanrepu.idaipmanrepu
	param8.ParameterName = "p_idaipmanrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanrepu.xnommanrepu IsNot Nothing Then
	param9.Value = aipmanrepu.xnommanrepu
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = aipmanrepu.ipartextdelmanrepu
	param10.ParameterName = "p_ipartextdelmanrepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipmanrepu.ipartextmedmanrepu
	param11.ParameterName = "p_ipartextmedmanrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipmanrepu.ipartexttrasmanrepu
	param12.ParameterName = "p_ipartexttrasmanrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.bit
	param13.Value = aipmanrepu.ipartintmanrepu
	param13.ParameterName = "p_ipartintmanrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.bit
	param14.Value = aipmanrepu.iposdermanrepu
	param14.ParameterName = "p_iposdermanrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.bit
	param15.Value = aipmanrepu.iposizqmanrepu
	param15.ParameterName = "p_iposizqmanrepu"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.bit
	param16.Value = aipmanrepu.iposfronmanrepu
	param16.ParameterName = "p_iposfronmanrepu"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipmanrepu.xdescmanrepu IsNot Nothing Then
	param17.Value = aipmanrepu.xdescmanrepu
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescmanrepu"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipmanrepu.iestatmanrepu IsNot Nothing Then
	param18.Value = aipmanrepu.iestatmanrepu
	else
                    param18.Value = "ACTIVO"
	end if
	param18.ParameterName = "p_iestatmanrepu"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipmanrepu.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanrepu output,@p_xnommanrepu,@p_ipartextdelmanrepu,@p_ipartextmedmanrepu,@p_ipartexttrasmanrepu,@p_ipartintmanrepu,@p_iposdermanrepu,@p_iposizqmanrepu,@p_iposfronmanrepu,@p_xdescmanrepu,@p_iestatmanrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
        <HttpGet()> _
        Public Function selaipmanrepuactivos() As List(Of aipmanrepu)
            Dim lista_aipmanrepu As List(Of aipmanrepu) = (From p In _db.aipmanrepu
                                                           Where p.idaipmanrepu > 0 And p.iestatmanrepu = "ACTIVO"
                                                            Order By p.xnommanrepu
                                                        Select p).ToList

            Dim aipmanrepu As New aipmanrepu

            With aipmanrepu
                .idaipmanrepu = 0
                .xnommanrepu = "SELECCIONE..."
                .ipartextdelmanrepu = False
                .ipartextmedmanrepu = False
                .ipartexttrasmanrepu = False
                .ipartintmanrepu = False
                .iposdermanrepu = False
                .iposizqmanrepu = False
                .iposfronmanrepu = False
                .xdescmanrepu = ""
                .iestatmanrepu = ""
                .idseglogreg = 0

            End With
            lista_aipmanrepu.Insert(0, aipmanrepu)
            '
            Return lista_aipmanrepu
        End Function

        <HttpPost()> _
        <HttpGet()> _
        Public Function selaipmanrepuactivosbaremo() As List(Of aipmanrepu)
            Dim lista_aipmanrepu As List(Of aipmanrepu) = (From p In _db.aipmanrepu
                                                           Where p.idaipmanrepu > 0 And p.iestatmanrepu = "ACTIVO BAREMO"
                                                            Order By p.xnommanrepu
                                                        Select p).ToList

            Dim aipmanrepu As New aipmanrepu

            With aipmanrepu
                .idaipmanrepu = 0
                .xnommanrepu = "SELECCIONE..."
                .ipartextdelmanrepu = False
                .ipartextmedmanrepu = False
                .ipartexttrasmanrepu = False
                .ipartintmanrepu = False
                .iposdermanrepu = False
                .iposizqmanrepu = False
                .iposfronmanrepu = False
                .xdescmanrepu = ""
                .iestatmanrepu = ""
                .idseglogreg = 0

            End With
            lista_aipmanrepu.Insert(0, aipmanrepu)
            '
            Return lista_aipmanrepu
        End Function

        <HttpPost()> _
        <HttpGet()> _
        Public Function SeleccionarRepuestosConCodigoExterno() As List(Of aipgenobj)
            Dim lista_aipgenobj As List(Of aipgenobj) = (From p In _db.aipgenobj
            Where p.id > 0
                                                            Order By p.xnombre
                                                        Select p).ToList

            Dim aipgenobj As New aipgenobj

            With aipgenobj
                .id = 0
                .id2 = 0
                .xnombre = "SELECCIONE..."
                .xnombre2 = "SELECCIONE..."
                End With
            lista_aipgenobj.Insert(0, aipgenobj)
            '
            Return lista_aipgenobj
        End Function
End Class
End Namespace
