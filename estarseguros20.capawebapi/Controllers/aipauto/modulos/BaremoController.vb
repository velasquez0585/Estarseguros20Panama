Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.baremo
Imports estarseguros20.capawebapi.aipauto.vistas.controlador
Imports estarseguros20.capawebapi.aipauto.entidades.controlador
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.modulos.controlador
    Public Class BaremoController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))


        '        <HttpPost()> _  
        'metodo que es llamdo por CrearBaremoMobrPred, en este metodo llama a la regla de negocio que verifica que si no hay baremos para la fecha los cree predeterminados
        Public Function VerificaBaremoMobrPred(faplibaremobr As Date) As respopera
            Try

                Dim param1 As New SqlClient.SqlParameter
                param1.SqlDbType = SqlDbType.VarChar
                param1.Size = 20
                param1.Value = "aipauto"
                param1.ParameterName = "p_illamada"

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
                param8.SqlDbType = SqlDbType.DateTime
                If faplibaremobr > CDate("01-01-1900") Then
                    param8.Value = faplibaremobr
                Else
                    param8.Value = CDate("01-01-1900")
                End If
                param8.ParameterName = "p_faplibaremobr"

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = 0
                param9.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_rncrearbaremomobrpred @p_illamada,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_faplibaremobr,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9)

                Dim respopera As New respopera
                respopera.irespuesta = param4.Value
                respopera.xmsjusuario = param5.Value
                respopera.xmsjtecnico = param6.Value
                'If IsNumeric(param8.Value) = True Then
                '    respopera.id = Int(param8.Value)
                'End If

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        '        <HttpPost()> _  
        'metodo que es llamdo por CrearBaremoMobrPred, en este metodo llama a la regla de negocio que verifica que si no hay baremos para la fecha los cree predeterminados
        Public Function VerificaBaremoRepuPred(faplibarerepu As Date) As respopera
            Try

                Dim param1 As New SqlClient.SqlParameter
                param1.SqlDbType = SqlDbType.VarChar
                param1.Size = 20
                param1.Value = "aipauto"
                param1.ParameterName = "p_illamada"

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
                param8.SqlDbType = SqlDbType.DateTime
                If faplibarerepu > CDate("01-01-1900") Then
                    param8.Value = faplibarerepu
                Else
                    param8.Value = CDate("01-01-1900")
                End If
                param8.ParameterName = "p_faplibarerepu"

                Dim param9 As New SqlClient.SqlParameter
                param9.SqlDbType = SqlDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = 0
                param9.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_rncreabaremorepupred @p_illamada,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_faplibarerepu,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9)

                Dim respopera As New respopera
                respopera.irespuesta = param4.Value
                respopera.xmsjusuario = param5.Value
                respopera.xmsjtecnico = param6.Value
                'If IsNumeric(param8.Value) = True Then
                '    respopera.id = Int(param8.Value)
                'End If

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        'desarrollar metodo verificar
        <HttpPost()> _
        Public Function CrearBaremoMobrPred(faplibaremobr As Date) As List(Of vi_aipbaremobr)

            'antes de buscar la lista llamar al store que verifica que si no existe informacion para estan fecha la cree basia 
            VerificaBaremoMobrPred(faplibaremobr) 'no me importa lo que mande respopera porque devuelvo es una lista

            Dim vi_aipbaremobrController As New vi_aipbaremobrController
            Dim lista_vi_aipbaremobr As List(Of vi_aipbaremobr) = vi_aipbaremobrController.selvi_aipbaremobrxfapli(faplibaremobr)

            Return lista_vi_aipbaremobr
        End Function

        'desarrollar metodo verificar
        <HttpPost()> _
        Public Function VerUltimoBaremoRepu() As List(Of vi_aipbarerepu)
            Dim vi_aipbarerepuController As New vi_aipbarerepuController
            Dim faplibarerepu As Date = vi_aipbarerepuController.faplibarerepumax
            Dim lista_vi_aipbarerepu As List(Of vi_aipbarerepu) = vi_aipbarerepuController.selvi_aipbarerepuxfapli(faplibarerepu)

            Return lista_vi_aipbarerepu
        End Function
        <HttpPost()> _
        Public Function VerUltimoBaremoRepuPag(paginacion As paginacion) As respvi_aipbarerepupaglist
            Dim vi_aipbarerepuController As New vi_aipbarerepuController
            Dim faplibarerepu As Date = vi_aipbarerepuController.faplibarerepumax
            Dim respvi_aipbarerepupaglist As respvi_aipbarerepupaglist = vi_aipbarerepuController.selvi_aipbarerepuxfaplipag(faplibarerepu, paginacion)

            Return respvi_aipbarerepupaglist
        End Function


        'desarrollar metodo verificar
        <HttpPost()> _
        Public Function VerUltimoBaremoMobr() As List(Of vi_aipbaremobr)
            Dim vi_aipbaremobrController As New vi_aipbaremobrController
            Dim faplibaremobr As Date = vi_aipbaremobrController.faplibaremobrmax
            Dim lista_vi_aipbaremobr As List(Of vi_aipbaremobr) = vi_aipbaremobrController.selvi_aipbaremobrxfapli(faplibaremobr)

            Return lista_vi_aipbaremobr
        End Function

        <HttpPost()> _
        <HttpGet()> _
        Public Function VerUltimoBaremoMobrPag(paginacion As paginacion) As respvi_aipbaremobrpaglist
            'Dim paginacion As New paginacion
            'paginacion.idirord = "desc"
            'paginacion.xcamposord = "it.idaipbaremobr"
            'paginacion.npagactual = 2
            'paginacion.npagcantidad = 0
            'paginacion.npagtamano = 10
            Dim vi_aipbaremobrController As New vi_aipbaremobrController
            Dim faplibaremobr As Date = vi_aipbaremobrController.faplibaremobrmax
            Dim respvi_aipbaremobrpaglist As respvi_aipbaremobrpaglist = vi_aipbaremobrController.selvi_aipbaremobrxfaplipag(faplibaremobr, paginacion)

            Return respvi_aipbaremobrpaglist
        End Function

        'desarrollar metodo
        <HttpPost()> _
        Public Function CrearBaremoRepuPred(faplibarerepu As Date) As List(Of vi_aipbarerepu)

            'antes de buscar la lista llamar al store que verifica que si no existe informacion para estan fecha la cree basia 
            VerificaBaremoRepuPred(faplibarerepu) 'no me importa lo que mande respopera porque devuelvo es una lista


            Dim vi_aipbarerepuController As New vi_aipbarerepuController
            Dim lista_vi_aipbarerepu As List(Of vi_aipbarerepu) = vi_aipbarerepuController.selvi_aipbarerepuxfapli(faplibarerepu)

            Return lista_vi_aipbarerepu
        End Function

        'desarrollar metodo
        '<HttpGet()> _
        'Public Function CrearBaremoMobr() As respopera
        <HttpPost()> _
        Public Function CrearBaremoMobr(lista_baremobrmasivo As List(Of baremobrmasivo)) As respopera
            Try
                Dim respopera As New respopera

                'Dim baremobrmasivo As New baremobrmasivo
                'Dim lista_baremobrmasivo As New List(Of baremobrmasivo)
                '        baremobrmasivo.idaipbaremobr = 1
                '        baremobrmasivo.xconcepto = "Primero"
                '        baremobrmasivo.xvalorcodigo = "valor a1"
                ''lista_baremobrmasivo.Insert(0, baremobrmasivo) '--
                '        lista_baremobrmasivo.Add(New baremobrmasivo() With { _
                '            .idaipbaremobr = 1, _
                '        .xconcepto = baremobrmasivo.xconcepto, _
                '        .xvalorcodigo = baremobrmasivo.xvalorcodigo _
                '})

                '        baremobrmasivo.idaipbaremobr = 1
                '        baremobrmasivo.xconcepto = "Segundo"
                '        baremobrmasivo.xvalorcodigo = "valor b1"
                '        lista_baremobrmasivo.Add(New baremobrmasivo() With { _
                '            .idaipbaremobr = 1, _
                '        .xconcepto = baremobrmasivo.xconcepto, _
                '        .xvalorcodigo = baremobrmasivo.xvalorcodigo _
                '})

                '        baremobrmasivo.idaipbaremobr = 1
                '        baremobrmasivo.xconcepto = "Segundo"
                '        baremobrmasivo.xvalorcodigo = "valor b2"
                '        lista_baremobrmasivo.Add(New baremobrmasivo() With { _
                '            .idaipbaremobr = 1, _
                '        .xconcepto = baremobrmasivo.xconcepto, _
                '        .xvalorcodigo = baremobrmasivo.xvalorcodigo _
                '})

                '        baremobrmasivo.idaipbaremobr = 1
                '        baremobrmasivo.xconcepto = "Primero"
                '        baremobrmasivo.xvalorcodigo = "valor a2"
                '        lista_baremobrmasivo.Add(New baremobrmasivo() With { _
                '            .idaipbaremobr = 1, _
                '        .xconcepto = baremobrmasivo.xconcepto, _
                '        .xvalorcodigo = baremobrmasivo.xvalorcodigo _
                '})

                If lista_baremobrmasivo.Count > 0 Then

                    Dim lista_baremobrmasivo_mano = From valor In lista_baremobrmasivo
                                                    Where valor.xconcepto = "ITIPOBAREMOBR"
                                                      Order By valor.xconcepto, valor.xvalorcodigo

                    Dim lista_baremobrmasivo_mater = From valor In lista_baremobrmasivo
                                                     Where valor.xconcepto = "IMATERPIEZBAREMOBR"
                                                        Order By valor.xconcepto, valor.xvalorcodigo

                    Dim lista_baremobrmasivo_tama = From valor In lista_baremobrmasivo
                                                     Where valor.xconcepto = "ITAMAPIEZBAREMOBR"
                                                       Order By valor.xconcepto, valor.xvalorcodigo


                    Dim lista_baremobrmasivo_mano2 = From valor In lista_baremobrmasivo
                                Where valor.xconcepto = "ITIPOBAREMOBR"




                    'ITIPOBAREMOBR
                    'IMATERPIEZBAREMOBR
                    'ITAMAPIEZBAREMOBR

                    'si los tres tipos tiene informacion se realiza la operacion sino se cancela
                    If lista_baremobrmasivo_mano.Count > 0 And lista_baremobrmasivo_mater.Count > 0 And lista_baremobrmasivo_tama.Count > 0 Then
                        Dim aipbaremobrController As New aipbaremobrController
                        Dim aipbaremobr As aipbaremobr = aipbaremobrController.selaipbaremobrxid(lista_baremobrmasivo(0).idaipbaremobr)
                        Dim aipbaremobrnuevo As New aipbaremobr
                        Dim respopera2 As respopera
                        For i As Integer = 0 To lista_baremobrmasivo_mano.Count - 1 'primer nivel --itipobaremobr
                            For j As Integer = 0 To lista_baremobrmasivo_mater.Count - 1 'segundo nivel --imaterpiezbaremobr
                                For k As Integer = 0 To lista_baremobrmasivo_tama.Count - 1 'tercer nivel --itamapiezbaremobr
                                    With aipbaremobrnuevo
                                        .idaipbaremobr = 0
                                        .idaipmanrepu = aipbaremobr.idaipmanrepu
                                        .faplibaremobr = aipbaremobr.faplibaremobr
                                        .itipobaremobr = lista_baremobrmasivo_mano(i).xvalorcodigo
                                        .itamapiezbaremobr = lista_baremobrmasivo_tama(k).xvalorcodigo
                                        .imaterpiezbaremobr = lista_baremobrmasivo_mater(j).xvalorcodigo
                                        .mcostbaremobr = aipbaremobr.mcostbaremobr
                                        .xdescbaremobr = aipbaremobr.xdescbaremobr
                                        .iestatbaremobr = aipbaremobr.iestatbaremobr
                                        .idseglogreg = 0
                                    End With
                                    respopera2 = aipbaremobrController.insaipbaremobr(aipbaremobrnuevo)
                                Next
                            Next
                        Next
                        'eliminar el baremo original que estaba vacio
                        respopera2 = aipbaremobrController.eliaipbaremobr(aipbaremobr.idaipbaremobr)
                    Else
                        respopera.irespuesta = "0"
                        respopera.xmsjusuario = "No se puede realizar la operacion dado que debe Elegir por lómenos un elemento de (mano de obra, tamaño de pieza, material de pieza)"
                        respopera.xmsjtecnico = "No se puede realizar la operacion dado que debe Elegir por lómenos un elemento de (mano de obra, tamaño de pieza, material de pieza)"
                    End If

                    respopera.irespuesta = "1"
                    respopera.xmsjusuario = "Combinaciones creadas con exito"
                    respopera.xmsjtecnico = "Combinaciones creadas con exito"
                    'respopera.irespuesta = param4.Value
                    'respopera.xmsjusuario = param5.Value
                    'respopera.xmsjtecnico = param6.Value
                    'If IsNumeric(param8.Value) = True Then
                    '    respopera.id = Int(param8.Value)
                    'End If
                Else
                    respopera.irespuesta = "0"
                    respopera.xmsjusuario = "No se puede realizar la operación dado que debe Elegir por lómenos un elemento de (mano de obra, tamaño de pieza, material de pieza)"
                    respopera.xmsjtecnico = "la lista de baremos masivo esta vacia lista_baremobrmasivo"
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

        'desarrollar metodo
        <HttpPost()> _
        Public Function CrearBaremoRepu(lista_barerepumasivo As List(Of barerepumasivo)) As respopera
            Try
                Dim vi_aipbarerepuController As New vi_aipbarerepuController
                Dim respopera As New respopera

                If lista_barerepumasivo.Count > 0 Then



                    Dim aipbarerepuController As New aipbarerepuController
                    Dim aipbarerepu As aipbarerepu = aipbarerepuController.selaipbarerepuxid(lista_barerepumasivo(0).idaipbarerepu)
                    Dim aipbarerepunuevo As New aipbarerepu
                    Dim respopera2 As respopera

                    For i As Integer = 0 To lista_barerepumasivo.Count - 1
                        With aipbarerepunuevo
                            .idaipbarerepu = 0
                            .idaipmanrepu = aipbarerepu.idaipmanrepu
                            .faplibarerepu = aipbarerepu.faplibarerepu
                            .iorigbarerepu = lista_barerepumasivo(i).xvalorcodigo
                            .mcostbarerepu = aipbarerepu.mcostbarerepu
                            .xdescbarerepu = aipbarerepu.xdescbarerepu
                            .iestatbarerepu = aipbarerepu.iestatbarerepu
                            .idseglogreg = 0
                        End With
                        respopera2 = aipbarerepuController.insaipbarerepu(aipbarerepunuevo)
                    Next
                    respopera2 = aipbarerepuController.eliaipbarerepu(aipbarerepu.idaipbarerepu)
                    respopera.irespuesta = "1"
                    respopera.xmsjusuario = "Combinaciones creadas con exito"
                    respopera.xmsjtecnico = "Combinaciones creadas con exito"
                Else
                    respopera.irespuesta = "0"
                    respopera.xmsjusuario = "No se puede realizar la operación dado que debe Elegir por lómenos un elemento de (mano de obra, tamaño de pieza, material de pieza)"
                    respopera.xmsjtecnico = "la lista de baremos masivo esta vacia lista_barerepumasivo"
                End If

                'respopera.irespuesta = param4.Value
                'respopera.xmsjusuario = param5.Value
                'respopera.xmsjtecnico = param6.Value
                'If IsNumeric(param8.Value) = True Then
                '    respopera.id = Int(param8.Value)
                'End If

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function


        Public Function ActualizaAipBareMobr(vi_aipbaremobr As vi_aipbaremobr) As respopera
            Try
                Dim aipbaremobr As aipbaremobr
                Dim idaipbaremobr As Decimal = vi_aipbaremobr.idaipbaremobr
                aipbaremobr = (From p In _db.aipbaremobr
                                                Where p.idaipbaremobr = idaipbaremobr
                                                Select p).SingleOrDefault
                If aipbaremobr IsNot Nothing Then
                    With aipbaremobr
                        '.idaipbaremobr = lista_vi_aipbaremobr(i).idaipbaremobr
                        .idaipmanrepu = vi_aipbaremobr.idaipmanrepu
                        If vi_aipbaremobr.faplibaremobr >= CDate("01-01-1900") Then
                            .faplibaremobr = vi_aipbaremobr.faplibaremobr
                        Else
                            .faplibaremobr = CDate("01-01-1900")
                        End If
                        If vi_aipbaremobr.itipobaremobr IsNot Nothing Then
                            .itipobaremobr = vi_aipbaremobr.itipobaremobr
                        Else
                            .itipobaremobr = ""
                        End If
                        If vi_aipbaremobr.itamapiezbaremobr IsNot Nothing Then
                            .itamapiezbaremobr = vi_aipbaremobr.itamapiezbaremobr
                        Else
                            .itamapiezbaremobr = ""
                        End If
                        If vi_aipbaremobr.imaterpiezbaremobr IsNot Nothing Then
                            .imaterpiezbaremobr = vi_aipbaremobr.imaterpiezbaremobr
                        Else
                            .imaterpiezbaremobr = ""
                        End If
                        .mcostbaremobr = vi_aipbaremobr.mcostbaremobr
                        If vi_aipbaremobr.xdescbaremobr IsNot Nothing Then
                            .xdescbaremobr = vi_aipbaremobr.xdescbaremobr
                        Else
                            .xdescbaremobr = ""
                        End If
                        If aipbaremobr.iestatbaremobr IsNot Nothing Then
                            .iestatbaremobr = aipbaremobr.iestatbaremobr
                        Else
                            .iestatbaremobr = ""
                        End If
                        .idseglogreg = aipbaremobr.idseglogreg 'falta el campo en la vista 

                    End With
                End If

                Dim respopera As New respopera
                respopera.irespuesta = "1"
                respopera.xmsjusuario = "Operación realizada satisfactoriamente"
                respopera.xmsjtecnico = "Operación realizada satisfactoriamente"
                'If IsNumeric(param8.Value) = True Then
                '    respopera.id = Int(param8.Value)
                'End If

                Return respopera

            Catch ex As Exception
                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        Public Function ActualizaAipBareRepu(vi_aipbarerepu As vi_aipbarerepu) As respopera
            Try
                Dim aipbarerepu As aipbarerepu
                Dim idaipbarerepu As Decimal = vi_aipbarerepu.idaipbarerepu
                aipbarerepu = (From p In _db.aipbarerepu
                                                Where p.idaipbarerepu = idaipbarerepu
                                                Select p).SingleOrDefault
                If aipbarerepu IsNot Nothing Then
                    With aipbarerepu
                        '.idaipbarerepu = vi_aipbarerepu
                        .idaipmanrepu = vi_aipbarerepu.idaipmanrepu
                        If vi_aipbarerepu.faplibarerepu > CDate("01-01-1900") Then
                            .faplibarerepu = vi_aipbarerepu.faplibarerepu
                        Else
                            .faplibarerepu = CDate("01-01-1900")
                        End If
                        If vi_aipbarerepu.iorigbarerepu IsNot Nothing Then
                            .iorigbarerepu = vi_aipbarerepu.iorigbarerepu
                        Else
                            .iorigbarerepu = ""
                        End If
                        .mcostbarerepu = vi_aipbarerepu.mcostbarerepu
                        If aipbarerepu.xdescbarerepu IsNot Nothing Then
                            .xdescbarerepu = aipbarerepu.xdescbarerepu 'falta en la vista
                        Else
                            .xdescbarerepu = ""
                        End If
                        If aipbarerepu.iestatbarerepu IsNot Nothing Then
                            .iestatbarerepu = aipbarerepu.iestatbarerepu 'falta en la vista
                        Else
                            .iestatbarerepu = ""
                        End If
                        .idseglogreg = aipbarerepu.idseglogreg 'falta en la vista
                    End With
                End If

                Dim respopera As New respopera
                respopera.irespuesta = "1"
                respopera.xmsjusuario = "Operación realizada satisfactoriamente"
                respopera.xmsjtecnico = "Operación realizada satisfactoriamente"
                'If IsNumeric(param8.Value) = True Then
                '    respopera.id = Int(param8.Value)
                'End If

                Return respopera

            Catch ex As Exception
                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        'desarrollar metodo
        <HttpPost()> _
        Public Function ActualizarBaremoMobrMasivo(lista_vi_aipbaremobr As List(Of vi_aipbaremobr)) As respopera
            Try
                Dim vi_aipbaremobrController As New vi_aipbaremobrController
                Dim respopera As New respopera

                If lista_vi_aipbaremobr.Count > 0 Then
                    'Dim aipbaremobrController As New aipbaremobrController
                    'Dim aipbaremobr As New aipbaremobr
                    'Dim aipbaremobr As aipbaremobr
                    For i As Integer = 0 To lista_vi_aipbaremobr.Count - 1
                        ActualizaAipBareMobr(lista_vi_aipbaremobr(i))
                        'Dim idaipbaremobr As Decimal = lista_vi_aipbaremobr(i).idaipbaremobr
                        'aipbaremobr = (From p In _db.aipbaremobr
                        '                                Where p.idaipbaremobr = idaipbaremobr
                        '                                Select p).SingleOrDefault
                        'With aipbaremobr
                        '    '.idaipbaremobr = lista_vi_aipbaremobr(i).idaipbaremobr
                        '    .idaipmanrepu = lista_vi_aipbaremobr(i).idaipmanrepu
                        '    .faplibaremobr = lista_vi_aipbaremobr(i).faplibaremobr
                        '    .itipobaremobr = lista_vi_aipbaremobr(i).itipobaremobr
                        '    .itamapiezbaremobr = lista_vi_aipbaremobr(i).itamapiezbaremobr
                        '    .imaterpiezbaremobr = lista_vi_aipbaremobr(i).imaterpiezbaremobr
                        '    .mcostbaremobr = lista_vi_aipbaremobr(i).mcostbaremobr
                        '    .xdescbaremobr = lista_vi_aipbaremobr(i).xdescbaremobr
                        '    .iestatbaremobr = aipbaremobr.iestatbaremobr 'lista_vi_aipbaremobr(i).iestatbaremobr 'falta el campo en la vista 
                        '    .idseglogreg = aipbaremobr.idseglogreg 'falta el campo en la vista 

                        'End With
                    Next
                    _db.SaveChanges()
                End If


                respopera.irespuesta = "1"
                respopera.xmsjusuario = "Operación realizada satisfactoriamente"
                respopera.xmsjtecnico = "Operación realizada satisfactoriamente"
                'If IsNumeric(param8.Value) = True Then
                '    respopera.id = Int(param8.Value)
                'End If

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        'desarrollar metodo
        <HttpPost()> _
        Public Function ActualizarBaremoRepuMasivo(lista_vi_aipbarerepu As List(Of vi_aipbarerepu)) As respopera
            Try
                Dim vi_aipbarerepuController As New vi_aipbarerepuController
                Dim respopera As New respopera

                If lista_vi_aipbarerepu.Count > 0 Then
                    'Dim aipbaremobrController As New aipbaremobrController
                    'Dim aipbaremobr As New aipbaremobr
                    'Dim aipbaremobr As aipbaremobr
                    For i As Integer = 0 To lista_vi_aipbarerepu.Count - 1
                        ActualizaAipBareRepu(lista_vi_aipbarerepu(i))
                        'Dim idaipbaremobr As Decimal = lista_vi_aipbaremobr(i).idaipbaremobr
                        'aipbaremobr = (From p In _db.aipbaremobr
                        '                                Where p.idaipbaremobr = idaipbaremobr
                        '                                Select p).SingleOrDefault
                        'With aipbaremobr
                        '    '.idaipbaremobr = lista_vi_aipbaremobr(i).idaipbaremobr
                        '    .idaipmanrepu = lista_vi_aipbaremobr(i).idaipmanrepu
                        '    .faplibaremobr = lista_vi_aipbaremobr(i).faplibaremobr
                        '    .itipobaremobr = lista_vi_aipbaremobr(i).itipobaremobr
                        '    .itamapiezbaremobr = lista_vi_aipbaremobr(i).itamapiezbaremobr
                        '    .imaterpiezbaremobr = lista_vi_aipbaremobr(i).imaterpiezbaremobr
                        '    .mcostbaremobr = lista_vi_aipbaremobr(i).mcostbaremobr
                        '    .xdescbaremobr = lista_vi_aipbaremobr(i).xdescbaremobr
                        '    .iestatbaremobr = aipbaremobr.iestatbaremobr 'lista_vi_aipbaremobr(i).iestatbaremobr 'falta el campo en la vista 
                        '    .idseglogreg = aipbaremobr.idseglogreg 'falta el campo en la vista 

                        'End With
                    Next
                    _db.SaveChanges()
                End If


                respopera.irespuesta = "1"
                respopera.xmsjusuario = "Operación realizada satisfactoriamente"
                respopera.xmsjtecnico = "Operación realizada satisfactoriamente"
                'If IsNumeric(param8.Value) = True Then
                '    respopera.id = Int(param8.Value)
                'End If

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function


        'desarrollar metodo verificar
        <HttpPost()> _
        Public Function ObtenerOrigenBareRepu(idaipmanrepu As Decimal) As List(Of vi_comboaipbarerepuorig)
            Dim vi_comboaipbarerepuorigController As New vi_comboaipbarerepuorigController
            Dim lista_vi_comboaipbarerepuorig As List(Of vi_comboaipbarerepuorig) = vi_comboaipbarerepuorigController.selvi_comboaipbarerepuorigxidaipmanrepu(idaipmanrepu)

            Return lista_vi_comboaipbarerepuorig
        End Function

        'desarrollar metodo verificar
        <HttpPost()> _
        Public Function ObtenerTamaBareMobr(idaipmanrepu As Decimal) As List(Of vi_comboaipbaremobrtama)
            Dim vi_comboaipbaremobrtamaController As New vi_comboaipbaremobrtamaController
            Dim lista_vi_comboaipbaremobrtama As List(Of vi_comboaipbaremobrtama) = vi_comboaipbaremobrtamaController.selvi_comboaipbaremobrtamaxidaipmanrepu(idaipmanrepu)

            Return lista_vi_comboaipbaremobrtama
        End Function

        'desarrollar metodo verificar
        <HttpPost()> _
        Public Function ObtenerMaterBareMobr(idaipmanrepu As Decimal) As List(Of vi_comboaipbaremobrmater)
            Dim vi_comboaipbaremobrmaterController As New vi_comboaipbaremobrmaterController
            Dim lista_vi_comboaipbaremobrmater As List(Of vi_comboaipbaremobrmater) = vi_comboaipbaremobrmaterController.selvi_comboaipbaremobrmaterxidaipmanrepu(idaipmanrepu)

            Return lista_vi_comboaipbaremobrmater
        End Function

        'desarrollar metodo verificar
        <HttpPost()> _
        Public Function ObtenerMobrBareMobr(idaipmanrepu As Decimal) As List(Of vi_comboaipbaremobrmobr)
            Dim vi_comboaipbaremobrmobrController As New vi_comboaipbaremobrmobrController
            Dim lista_vi_comboaipbaremobrmobr As List(Of vi_comboaipbaremobrmobr) = vi_comboaipbaremobrmobrController.selvi_comboaipbaremobrmobrxidaipmanrepu(idaipmanrepu)

            Return lista_vi_comboaipbaremobrmobr
        End Function

        <HttpPost()> _
        Public Function ObtenerCostoBareRepu(idaipmanrepu As Decimal, iorigbarerepu As String) As Decimal
            Dim mcostbarerepu As Decimal = 0
            Dim vi_aipbarerepuController As New vi_aipbarerepuController
            Dim faplibarerepu As Date = vi_aipbarerepuController.faplibarerepumax
            mcostbarerepu = vi_aipbarerepuController.selmcostbarerepuxidaipmanrepuyfapliyiorig(idaipmanrepu, faplibarerepu, iorigbarerepu)

            Return mcostbarerepu
        End Function

        <HttpPost()> _
        Public Function ObtenerCostoBareMobr(idaipmanrepu As Decimal, itamapiezbaremobr As String, imaterpiezbaremobr As String, itipobaremobr As String) As Decimal
            Dim mcostbaremobr As Decimal = 0
            Dim vi_aipbaremobrController As New vi_aipbaremobrController
            Dim faplibaremobr As Date = vi_aipbaremobrController.faplibaremobrmax
            mcostbaremobr = vi_aipbaremobrController.selmcostbaremobrxidaipmanrepuyfapliytamyimatyitipo(idaipmanrepu, faplibaremobr, itamapiezbaremobr, imaterpiezbaremobr, itipobaremobr)

            Return mcostbaremobr
        End Function

        <HttpPost()> _
        Public Function ObtenerIdBareRepu(idaipmanrepu As Decimal, iorigbarerepu As String) As Decimal
            Dim idaipbarerepu As Decimal = 0
            Dim vi_aipbarerepuController As New vi_aipbarerepuController
            Dim faplibarerepu As Date = vi_aipbarerepuController.faplibarerepumax
            idaipbarerepu = vi_aipbarerepuController.selidaipbarerepuxidaipmanrepuyfapliyiorig(idaipmanrepu, faplibarerepu, iorigbarerepu)

            Return idaipbarerepu
        End Function

        <HttpPost()> _
        Public Function ObtenerIdBareMobr(idaipmanrepu As Decimal, itamapiezbaremobr As String, imaterpiezbaremobr As String, itipobaremobr As String) As Decimal
            Dim idaipbaremobr As Decimal = 0
            Dim vi_aipbaremobrController As New vi_aipbaremobrController
            Dim faplibaremobr As Date = vi_aipbaremobrController.faplibaremobrmax
            idaipbaremobr = vi_aipbaremobrController.selidaipbaremobrxidaipmanrepuyfapliytamyimatyitipo(idaipmanrepu, faplibaremobr, itamapiezbaremobr, imaterpiezbaremobr, itipobaremobr)

            Return idaipbaremobr
        End Function
    End Class
End Namespace
