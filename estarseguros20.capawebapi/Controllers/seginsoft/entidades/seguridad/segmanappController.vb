Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.entidades.seguridad
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace seginsoft.entidades.controlador
Public Class segmanappController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selsegmanappxid(idsegmanapp As Decimal) As segmanapp
		Dim segmanapp As segmanapp = (From p In _db.segmanapp
										Where p.idsegmanapp = idsegmanapp
										Select p).SingleOrDefault
		Return segmanapp
	End Function

        '<HttpPost()> _
        <HttpGet()> _
        Public Function selsegmanapp() As List(Of segmanapp)
            Dim lista_segmanapp As List(Of segmanapp) = (From p In _db.segmanapp
                                                        Select p).ToList
            '
            Return lista_segmanapp
        End Function

<HttpPost()> _
	Public Function selsegmanappxwheredinamicopag(petisegmanapppaglist as petisegmanapppaglist) as respsegmanapppaglist
		Dim sb As New StringBuilder("")
		'
		If petisegmanapppaglist.segmanapp.idsegmanapp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanapp=")
				sb.Append(valor_entero(petisegmanapppaglist.segmanapp.idsegmanapp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanapp=")
				sb.Append(valor_entero(petisegmanapppaglist.segmanapp.idsegmanapp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegmanapppaglist.segmanapp.xnombrecorto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecorto='")
				sb.Append(petisegmanapppaglist.segmanapp.xnombrecorto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecorto='")
				sb.Append(petisegmanapppaglist.segmanapp.xnombrecorto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petisegmanapppaglist.segmanapp.xnombrelargo <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrelargo='")
				sb.Append(petisegmanapppaglist.segmanapp.xnombrelargo)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrelargo='")
				sb.Append(petisegmanapppaglist.segmanapp.xnombrelargo)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petisegmanapppaglist.segmanapp.xtipoapp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xtipoapp='")
				sb.Append(petisegmanapppaglist.segmanapp.xtipoapp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xtipoapp='")
				sb.Append(petisegmanapppaglist.segmanapp.xtipoapp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petisegmanapppaglist.segmanapp.xso <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xso='")
				sb.Append(petisegmanapppaglist.segmanapp.xso)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xso='")
				sb.Append(petisegmanapppaglist.segmanapp.xso)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petisegmanapppaglist.segmanapp.xdesatec <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdesatec='")
				sb.Append(petisegmanapppaglist.segmanapp.xdesatec)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdesatec='")
				sb.Append(petisegmanapppaglist.segmanapp.xdesatec)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petisegmanapppaglist.segmanapp.fimplementacion > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.fimplementacion >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petisegmanapppaglist.segmanapp.fimplementacion)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.fimplementacion >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petisegmanapppaglist.segmanapp.fimplementacion)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petisegmanapppaglist.segmanapp.xobjetivo <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xobjetivo='")
				sb.Append(petisegmanapppaglist.segmanapp.xobjetivo)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xobjetivo='")
				sb.Append(petisegmanapppaglist.segmanapp.xobjetivo)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petisegmanapppaglist.segmanapp.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petisegmanapppaglist.segmanapp.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petisegmanapppaglist.segmanapp.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respsegmanapppaglist As New respsegmanapppaglist
	respsegmanapppaglist.pagsegmanapp = petisegmanapppaglist.pagsegmanapp
	Dim skip = skip_paginacion(petisegmanapppaglist.pagsegmanapp.npagactual, petisegmanapppaglist.pagsegmanapp.npagtamano)
	
		If sb.ToString = "" Then
			respsegmanapppaglist.lista_segmanapp = _db.segmanapp.OrderBy(petisegmanapppaglist.pagsegmanapp.xcamposord & " "  & petisegmanapppaglist.pagsegmanapp.idirord).Skip(skip).Take(petisegmanapppaglist.pagsegmanapp.npagtamano).ToList
		Else
			respsegmanapppaglist.lista_segmanapp = _db.segmanapp.Where(sb.ToString).OrderBy(petisegmanapppaglist.pagsegmanapp.xcamposord & " "  & petisegmanapppaglist.pagsegmanapp.idirord).Skip(skip).Take(petisegmanapppaglist.pagsegmanapp.npagtamano).ToList
		End If
		'
		If (respsegmanapppaglist.lista_segmanapp.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selsegmanappxwheredinamicocount(sb)
		respsegmanapppaglist.pagsegmanapp.npagcantidad = cantidad_paginas(cant_entero_reg, respsegmanapppaglist.pagsegmanapp.npagtamano)
		Else
		respsegmanapppaglist.pagsegmanapp.npagcantidad = 0
		respsegmanapppaglist.pagsegmanapp.npagactual = 0
		End If
	
		Return respsegmanapppaglist
	End Function

	Public Function selsegmanappxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.segmanapp.count
	Else
	Return _db.segmanapp.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function inssegmanapp(segmanapp as segmanapp) as respopera
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
	param3.value = "seginsoft"
                param3.ParameterName = "p_xnombrecortoapl"
	
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
	param8.ParameterName = "p_idsegmanapp"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 20
	If segmanapp.xnombrecorto IsNot Nothing Then
	param9.Value = segmanapp.xnombrecorto
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnombrecorto"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If segmanapp.xnombrelargo IsNot Nothing Then
	param10.Value = segmanapp.xnombrelargo
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnombrelargo"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If segmanapp.xtipoapp IsNot Nothing Then
	param11.Value = segmanapp.xtipoapp
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xtipoapp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 50
	If segmanapp.xso IsNot Nothing Then
	param12.Value = segmanapp.xso
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_xso"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 50
	If segmanapp.xdesatec IsNot Nothing Then
	param13.Value = segmanapp.xdesatec
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdesatec"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.datetime
	If segmanapp.fimplementacion > cdate("01-01-1900") Then
	param14.Value = segmanapp.fimplementacion
	else
	param14.Value = cdate("01-01-1900")
	end if
	param14.ParameterName = "p_fimplementacion"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 200
	If segmanapp.xobjetivo IsNot Nothing Then
	param15.Value = segmanapp.xobjetivo
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xobjetivo"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.decimal
	param16.Precision = 18
	param16.Scale = 0
	param16.Value = 0
	param16.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanapp @p_ioperacion,@p_idsegmanusu,@p_xnombrecortoapl,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanapp output,@p_xnombrecorto,@p_xnombrelargo,@p_xtipoapp,@p_xso,@p_xdesatec,@p_fimplementacion,@p_xobjetivo,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16)
	
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
	Public Function modsegmanapp(segmanapp as segmanapp) as respopera
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
	 param2.ParameterName = "p_idsegmanusu"
	
	Dim param3 As New SqlClient.SqlParameter
	param3.SqlDbType = SqlDbType.VarChar
	param3.Size = 20
	param3.value = "seginsoft"
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
	param8.SqlDbType = SqlDbType.decimal
	param8.Precision = 18
	param8.Scale = 0
	param8.Value = segmanapp.idsegmanapp
	param8.ParameterName = "p_idsegmanapp"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 20
	If segmanapp.xnombrecorto IsNot Nothing Then
	param9.Value = segmanapp.xnombrecorto
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnombrecorto"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If segmanapp.xnombrelargo IsNot Nothing Then
	param10.Value = segmanapp.xnombrelargo
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnombrelargo"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If segmanapp.xtipoapp IsNot Nothing Then
	param11.Value = segmanapp.xtipoapp
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xtipoapp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 50
	If segmanapp.xso IsNot Nothing Then
	param12.Value = segmanapp.xso
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_xso"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 50
	If segmanapp.xdesatec IsNot Nothing Then
	param13.Value = segmanapp.xdesatec
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdesatec"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.datetime
	If segmanapp.fimplementacion > cdate("01-01-1900") Then
	param14.Value = segmanapp.fimplementacion
	else
	param14.Value = cdate("01-01-1900")
	end if
	param14.ParameterName = "p_fimplementacion"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 200
	If segmanapp.xobjetivo IsNot Nothing Then
	param15.Value = segmanapp.xobjetivo
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xobjetivo"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.decimal
	param16.Precision = 18
	param16.Scale = 0
	param16.Value = segmanapp.idseglogreg
	param16.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanapp @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanapp output,@p_xnombrecorto,@p_xnombrelargo,@p_xtipoapp,@p_xso,@p_xdesatec,@p_fimplementacion,@p_xobjetivo,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16)
	
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
	Public Function elisegmanapp(segmanapp as segmanapp) as respopera
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
	param3.value = "seginsoft"
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
	param8.SqlDbType = SqlDbType.decimal
	param8.Precision = 18
	param8.Scale = 0
	param8.Value = segmanapp.idsegmanapp
	param8.ParameterName = "p_idsegmanapp"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 20
	If segmanapp.xnombrecorto IsNot Nothing Then
	param9.Value = segmanapp.xnombrecorto
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnombrecorto"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If segmanapp.xnombrelargo IsNot Nothing Then
	param10.Value = segmanapp.xnombrelargo
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnombrelargo"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If segmanapp.xtipoapp IsNot Nothing Then
	param11.Value = segmanapp.xtipoapp
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xtipoapp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 50
	If segmanapp.xso IsNot Nothing Then
	param12.Value = segmanapp.xso
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_xso"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 50
	If segmanapp.xdesatec IsNot Nothing Then
	param13.Value = segmanapp.xdesatec
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdesatec"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.datetime
	If segmanapp.fimplementacion > cdate("01-01-1900") Then
	param14.Value = segmanapp.fimplementacion
	else
	param14.Value = cdate("01-01-1900")
	end if
	param14.ParameterName = "p_fimplementacion"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 200
	If segmanapp.xobjetivo IsNot Nothing Then
	param15.Value = segmanapp.xobjetivo
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xobjetivo"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.decimal
	param16.Precision = 18
	param16.Scale = 0
	param16.Value = segmanapp.idseglogreg
	param16.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanapp @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanapp output,@p_xnombrecorto,@p_xnombrelargo,@p_xtipoapp,@p_xso,@p_xdesatec,@p_fimplementacion,@p_xobjetivo,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16)
	
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
	Public Function elisegmanapp(idsegmanapp as decimal) as respopera
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
	param3.value = "seginsoft"
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
	param8.SqlDbType = SqlDbType.decimal
	param8.Precision = 18
	param8.Scale = 0
	param8.Value = idsegmanapp
	param8.ParameterName = "p_idsegmanapp"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 20
	param9.Value = "
	param9.ParameterName = "p_xnombrecorto"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	param10.Value = "
	param10.ParameterName = "p_xnombrelargo"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	param11.Value = "
	param11.ParameterName = "p_xtipoapp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 50
	param12.Value = "
	param12.ParameterName = "p_xso"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 50
	param13.Value = "
	param13.ParameterName = "p_xdesatec"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.datetime
	param14.Value = cdate("01-01-1900")
	param14.ParameterName = "p_fimplementacion"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 200
	param15.Value = "
	param15.ParameterName = "p_xobjetivo"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.decimal
	param16.Precision = 18
	param16.Scale = 0
	param16.Value = 0
	param16.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanapp @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanapp output,@p_xnombrecorto,@p_xnombrelargo,@p_xtipoapp,@p_xso,@p_xdesatec,@p_fimplementacion,@p_xobjetivo,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16)
	
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
	Public Function actsegmanapp(segmanapp as segmanapp) as respopera
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
	param3.value = "seginsoft"
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
	param8.SqlDbType = SqlDbType.decimal
	param8.Precision = 18
	param8.Scale = 0
	param8.Value = segmanapp.idsegmanapp
	param8.ParameterName = "p_idsegmanapp"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 20
	If segmanapp.xnombrecorto IsNot Nothing Then
	param9.Value = segmanapp.xnombrecorto
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnombrecorto"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If segmanapp.xnombrelargo IsNot Nothing Then
	param10.Value = segmanapp.xnombrelargo
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnombrelargo"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If segmanapp.xtipoapp IsNot Nothing Then
	param11.Value = segmanapp.xtipoapp
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xtipoapp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 50
	If segmanapp.xso IsNot Nothing Then
	param12.Value = segmanapp.xso
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_xso"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 50
	If segmanapp.xdesatec IsNot Nothing Then
	param13.Value = segmanapp.xdesatec
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdesatec"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.datetime
	If segmanapp.fimplementacion > cdate("01-01-1900") Then
	param14.Value = segmanapp.fimplementacion
	else
	param14.Value = cdate("01-01-1900")
	end if
	param14.ParameterName = "p_fimplementacion"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 200
	If segmanapp.xobjetivo IsNot Nothing Then
	param15.Value = segmanapp.xobjetivo
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xobjetivo"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.decimal
	param16.Precision = 18
	param16.Scale = 0
	param16.Value = segmanapp.idseglogreg
	param16.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanapp @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanapp output,@p_xnombrecorto,@p_xnombrelargo,@p_xtipoapp,@p_xso,@p_xdesatec,@p_fimplementacion,@p_xobjetivo,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16)
	
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
	Public Function dessegmanapp(segmanapp as segmanapp) as respopera
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
	param3.value = "seginsoft"
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
	param8.SqlDbType = SqlDbType.decimal
	param8.Precision = 18
	param8.Scale = 0
	param8.Value = segmanapp.idsegmanapp
	param8.ParameterName = "p_idsegmanapp"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 20
	If segmanapp.xnombrecorto IsNot Nothing Then
	param9.Value = segmanapp.xnombrecorto
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnombrecorto"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If segmanapp.xnombrelargo IsNot Nothing Then
	param10.Value = segmanapp.xnombrelargo
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnombrelargo"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If segmanapp.xtipoapp IsNot Nothing Then
	param11.Value = segmanapp.xtipoapp
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xtipoapp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 50
	If segmanapp.xso IsNot Nothing Then
	param12.Value = segmanapp.xso
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_xso"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 50
	If segmanapp.xdesatec IsNot Nothing Then
	param13.Value = segmanapp.xdesatec
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdesatec"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.datetime
	If segmanapp.fimplementacion > cdate("01-01-1900") Then
	param14.Value = segmanapp.fimplementacion
	else
	param14.Value = cdate("01-01-1900")
	end if
	param14.ParameterName = "p_fimplementacion"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 200
	If segmanapp.xobjetivo IsNot Nothing Then
	param15.Value = segmanapp.xobjetivo
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xobjetivo"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.decimal
	param16.Precision = 18
	param16.Scale = 0
	param16.Value = segmanapp.idseglogreg
	param16.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanapp @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanapp output,@p_xnombrecorto,@p_xnombrelargo,@p_xtipoapp,@p_xso,@p_xdesatec,@p_fimplementacion,@p_xobjetivo,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16)
	
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

        'funciones no comunes
        <HttpGet()> _
        Public Function selsegmanapp_no_mundosigma() As List(Of segmanapp)
            Dim lista_segmanapp As List(Of segmanapp) = (From p In _db.segmanapp
                                                         Where p.idsegmanapp > 1
                                                         Select p).ToList
            '
            Return lista_segmanapp
        End Function

End Class
End Namespace
