Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipmanvehverController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipmanvehverxid(idaipmanvehver As Decimal) As aipmanvehver
		Dim aipmanvehver As aipmanvehver = (From p In _db.aipmanvehver
										Where p.idaipmanvehver = idaipmanvehver
										Select p).SingleOrDefault
		Return aipmanvehver
	End Function

	<HttpPost()> _
	Public Function selaipmanvehver() As List(Of aipmanvehver)
            Dim lista_aipmanvehver As List(Of aipmanvehver) = (From p In _db.aipmanvehver
                                                               Where p.idaipmanvehver > 0
                                                        Select p).ToList
            '
		Return lista_aipmanvehver
	End Function

<HttpPost()> _
	Public Function selaipmanvehverxwheredinamicopag(petiaipmanvehverpaglist as petiaipmanvehverpaglist) as respaipmanvehverpaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipmanvehverpaglist.aipmanvehver.idaipmanvehver <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehver=")
				sb.Append(valor_entero(petiaipmanvehverpaglist.aipmanvehver.idaipmanvehver))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehver=")
				sb.Append(valor_entero(petiaipmanvehverpaglist.aipmanvehver.idaipmanvehver))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehverpaglist.aipmanvehver.idaipmanvehmod <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmod=")
				sb.Append(valor_entero(petiaipmanvehverpaglist.aipmanvehver.idaipmanvehmod))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmod=")
				sb.Append(valor_entero(petiaipmanvehverpaglist.aipmanvehver.idaipmanvehmod))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehverpaglist.aipmanvehver.xnommanvehver <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehver='")
				sb.Append(petiaipmanvehverpaglist.aipmanvehver.xnommanvehver)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehver='")
				sb.Append(petiaipmanvehverpaglist.aipmanvehver.xnommanvehver)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehverpaglist.aipmanvehver.naniomanvehver <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.naniomanvehver=")
				sb.Append(valor_entero(petiaipmanvehverpaglist.aipmanvehver.naniomanvehver))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.naniomanvehver=")
				sb.Append(valor_entero(petiaipmanvehverpaglist.aipmanvehver.naniomanvehver))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehverpaglist.aipmanvehver.xdescmanvehver <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescmanvehver='")
				sb.Append(petiaipmanvehverpaglist.aipmanvehver.xdescmanvehver)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescmanvehver='")
				sb.Append(petiaipmanvehverpaglist.aipmanvehver.xdescmanvehver)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehverpaglist.aipmanvehver.iestatmanvehver <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmanvehver='")
				sb.Append(petiaipmanvehverpaglist.aipmanvehver.iestatmanvehver)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmanvehver='")
				sb.Append(petiaipmanvehverpaglist.aipmanvehver.iestatmanvehver)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehverpaglist.aipmanvehver.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipmanvehverpaglist.aipmanvehver.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipmanvehverpaglist.aipmanvehver.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipmanvehverpaglist As New respaipmanvehverpaglist
	respaipmanvehverpaglist.pagaipmanvehver = petiaipmanvehverpaglist.pagaipmanvehver
	Dim skip = skip_paginacion(petiaipmanvehverpaglist.pagaipmanvehver.npagactual, petiaipmanvehverpaglist.pagaipmanvehver.npagtamano)
	
		If sb.ToString = "" Then
			respaipmanvehverpaglist.lista_aipmanvehver = _db.aipmanvehver.OrderBy(petiaipmanvehverpaglist.pagaipmanvehver.xcamposord & " "  & petiaipmanvehverpaglist.pagaipmanvehver.idirord).Skip(skip).Take(petiaipmanvehverpaglist.pagaipmanvehver.npagtamano).ToList
		Else
			respaipmanvehverpaglist.lista_aipmanvehver = _db.aipmanvehver.Where(sb.ToString).OrderBy(petiaipmanvehverpaglist.pagaipmanvehver.xcamposord & " "  & petiaipmanvehverpaglist.pagaipmanvehver.idirord).Skip(skip).Take(petiaipmanvehverpaglist.pagaipmanvehver.npagtamano).ToList
		End If
		'
		If (respaipmanvehverpaglist.lista_aipmanvehver.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipmanvehverxwheredinamicocount(sb)
		respaipmanvehverpaglist.pagaipmanvehver.npagcantidad = cantidad_paginas(cant_entero_reg, respaipmanvehverpaglist.pagaipmanvehver.npagtamano)
		Else
		respaipmanvehverpaglist.pagaipmanvehver.npagcantidad = 0
		respaipmanvehverpaglist.pagaipmanvehver.npagactual = 0
		End If
	
		Return respaipmanvehverpaglist
	End Function

	Public Function selaipmanvehverxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipmanvehver.count
	Else
	Return _db.aipmanvehver.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipmanvehver(aipmanvehver as aipmanvehver) as respopera
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
	param8.ParameterName = "p_idaipmanvehver"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipmanvehver.idaipmanvehmod
	param9.ParameterName = "p_idaipmanvehmod"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If aipmanvehver.xnommanvehver IsNot Nothing Then
	param10.Value = aipmanvehver.xnommanvehver
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnommanvehver"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipmanvehver.naniomanvehver
	param11.ParameterName = "p_naniomanvehver"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 500
	If aipmanvehver.xdescmanvehver IsNot Nothing Then
	param12.Value = aipmanvehver.xdescmanvehver
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_xdescmanvehver"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 20
	If aipmanvehver.iestatmanvehver IsNot Nothing Then
	param13.Value = aipmanvehver.iestatmanvehver
	else
                    param13.Value = "ACTIVA"
	end if
	param13.ParameterName = "p_iestatmanvehver"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = 0
	param14.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehver @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehver output,@p_idaipmanvehmod,@p_xnommanvehver,@p_naniomanvehver,@p_xdescmanvehver,@p_iestatmanvehver,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14)
	
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
	Public Function modaipmanvehver(aipmanvehver as aipmanvehver) as respopera
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
	param8.Value = aipmanvehver.idaipmanvehver
	param8.ParameterName = "p_idaipmanvehver"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipmanvehver.idaipmanvehmod
	param9.ParameterName = "p_idaipmanvehmod"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If aipmanvehver.xnommanvehver IsNot Nothing Then
	param10.Value = aipmanvehver.xnommanvehver
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnommanvehver"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipmanvehver.naniomanvehver
	param11.ParameterName = "p_naniomanvehver"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 500
	If aipmanvehver.xdescmanvehver IsNot Nothing Then
	param12.Value = aipmanvehver.xdescmanvehver
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_xdescmanvehver"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 20
	If aipmanvehver.iestatmanvehver IsNot Nothing Then
	param13.Value = aipmanvehver.iestatmanvehver
	else
                    param13.Value = "ACTIVA"
	end if
	param13.ParameterName = "p_iestatmanvehver"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipmanvehver.idseglogreg
	param14.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehver @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehver output,@p_idaipmanvehmod,@p_xnommanvehver,@p_naniomanvehver,@p_xdescmanvehver,@p_iestatmanvehver,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14)
	
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
	Public Function eliaipmanvehver(aipmanvehver as aipmanvehver) as respopera
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
	param8.Value = aipmanvehver.idaipmanvehver
	param8.ParameterName = "p_idaipmanvehver"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipmanvehver.idaipmanvehmod
	param9.ParameterName = "p_idaipmanvehmod"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If aipmanvehver.xnommanvehver IsNot Nothing Then
	param10.Value = aipmanvehver.xnommanvehver
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnommanvehver"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipmanvehver.naniomanvehver
	param11.ParameterName = "p_naniomanvehver"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 500
	If aipmanvehver.xdescmanvehver IsNot Nothing Then
	param12.Value = aipmanvehver.xdescmanvehver
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_xdescmanvehver"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 20
	If aipmanvehver.iestatmanvehver IsNot Nothing Then
	param13.Value = aipmanvehver.iestatmanvehver
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_iestatmanvehver"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipmanvehver.idseglogreg
	param14.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehver @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehver output,@p_idaipmanvehmod,@p_xnommanvehver,@p_naniomanvehver,@p_xdescmanvehver,@p_iestatmanvehver,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14)
	
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
	Public Function eliaipmanvehver(idaipmanvehver as decimal) as respopera
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
	param8.Value = idaipmanvehver
	param8.ParameterName = "p_idaipmanvehver"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = 0
	param9.ParameterName = "p_idaipmanvehmod"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	param10.Value = "
	param10.ParameterName = "p_xnommanvehver"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = 0
	param11.ParameterName = "p_naniomanvehver"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 500
	param12.Value = "
	param12.ParameterName = "p_xdescmanvehver"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 20
	param13.Value = "
	param13.ParameterName = "p_iestatmanvehver"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = 0
	param14.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehver @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehver output,@p_idaipmanvehmod,@p_xnommanvehver,@p_naniomanvehver,@p_xdescmanvehver,@p_iestatmanvehver,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14)
	
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
	Public Function actaipmanvehver(aipmanvehver as aipmanvehver) as respopera
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
	param8.Value = aipmanvehver.idaipmanvehver
	param8.ParameterName = "p_idaipmanvehver"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipmanvehver.idaipmanvehmod
	param9.ParameterName = "p_idaipmanvehmod"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If aipmanvehver.xnommanvehver IsNot Nothing Then
	param10.Value = aipmanvehver.xnommanvehver
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnommanvehver"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipmanvehver.naniomanvehver
	param11.ParameterName = "p_naniomanvehver"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 500
	If aipmanvehver.xdescmanvehver IsNot Nothing Then
	param12.Value = aipmanvehver.xdescmanvehver
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_xdescmanvehver"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 20
	If aipmanvehver.iestatmanvehver IsNot Nothing Then
	param13.Value = aipmanvehver.iestatmanvehver
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_iestatmanvehver"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipmanvehver.idseglogreg
	param14.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehver @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehver output,@p_idaipmanvehmod,@p_xnommanvehver,@p_naniomanvehver,@p_xdescmanvehver,@p_iestatmanvehver,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14)
	
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
	Public Function desaipmanvehver(aipmanvehver as aipmanvehver) as respopera
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
	param8.Value = aipmanvehver.idaipmanvehver
	param8.ParameterName = "p_idaipmanvehver"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipmanvehver.idaipmanvehmod
	param9.ParameterName = "p_idaipmanvehmod"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If aipmanvehver.xnommanvehver IsNot Nothing Then
	param10.Value = aipmanvehver.xnommanvehver
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnommanvehver"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipmanvehver.naniomanvehver
	param11.ParameterName = "p_naniomanvehver"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 500
	If aipmanvehver.xdescmanvehver IsNot Nothing Then
	param12.Value = aipmanvehver.xdescmanvehver
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_xdescmanvehver"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 20
	If aipmanvehver.iestatmanvehver IsNot Nothing Then
	param13.Value = aipmanvehver.iestatmanvehver
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_iestatmanvehver"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipmanvehver.idseglogreg
	param14.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehver @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehver output,@p_idaipmanvehmod,@p_xnommanvehver,@p_naniomanvehver,@p_xdescmanvehver,@p_iestatmanvehver,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14)
	
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
        Public Function selaipmanvehveractivasxidmodelo(idaipmanvehmod As Decimal) As List(Of aipmanvehver)
            Dim lista_aipmanvehver As List(Of aipmanvehver) = (From p In _db.aipmanvehver
                                                               Where p.idaipmanvehver > 0 And p.idaipmanvehmod = idaipmanvehmod And p.iestatmanvehver = "ACTIVA"
                                                               Order By p.xnommanvehver
                                                        Select p).ToList

            Dim aipmanvehver As New aipmanvehver
            aipmanvehver.idaipmanvehver = 0
            aipmanvehver.idseglogreg = 0
            aipmanvehver.iestatmanvehver = ""
            aipmanvehver.xdescmanvehver = ""
            aipmanvehver.xnommanvehver = "SELECCIONE..."
            lista_aipmanvehver.Insert(0, aipmanvehver)
            '
            Return lista_aipmanvehver
        End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selaipmanvehveractivas() As List(Of aipmanvehver)
            Dim lista_aipmanvehver As List(Of aipmanvehver) = (From p In _db.aipmanvehver
                                                               Where p.idaipmanvehver > 0 And p.iestatmanvehver = "ACTIVA"
                                                               Order By p.xnommanvehver
                                                        Select p).ToList


            Dim aipmanvehver As New aipmanvehver
            aipmanvehver.idaipmanvehver = 0
            aipmanvehver.idseglogreg = 0
            aipmanvehver.iestatmanvehver = ""
            aipmanvehver.xdescmanvehver = ""
            aipmanvehver.xnommanvehver = "SELECCIONE..."
            lista_aipmanvehver.Insert(0, aipmanvehver)

            '
            Return lista_aipmanvehver
        End Function

        <HttpPost()> _
        Public Function selnaniomanvehverxid(idaipmanvehver As Decimal) As Decimal
            Dim naniomanvehver2 As Decimal = (From p In _db.aipmanvehver
                                            Where p.idaipmanvehver > 0 And p.idaipmanvehver = idaipmanvehver
                                            Select p.naniomanvehver).SingleOrDefault
            Return naniomanvehver2
        End Function
End Class
End Namespace
