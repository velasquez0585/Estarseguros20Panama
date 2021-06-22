Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.entidades.seguridad
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad
Imports estarseguros20.capawebapi.seginsoft.entidades.controlador
Imports estarseguros20.capawebapi.seginsoft.vistas.controlador
Imports estarseguros20.capawebapi.aipauto.entidades.controlador
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.log

Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capawebapi.comun.entidades.controlador
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.configuracion
Imports Oracle.ManagedDataAccess
Imports estarseguros20.capawebapi.aipauto.vistas.controlador
Imports estarseguros20.capawebapi.aipauto.modulos.controlador
Imports System.Transactions

Namespace seginsoft.modulos.controlador
    Public Class seguridadController
        Inherits ApiController

        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpGet()> _
        Public Function iniciar_sesion(xnombreusuario As String, xcontrasena As String) As Boolean
            Dim segmanusuController As New segmanusuController
            Dim segmanusu As segmanusu = segmanusuController.selsegmanusuxnomypass(xnombreusuario, xcontrasena)
            If segmanusu IsNot Nothing Then
                If segmanusu.ibloqueado Then
                    Throw New HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Unauthorized, String.Format("El usuario {0} se encuentra inactivo para iniciar sessión.", xnombreusuario)))
                Else
                    segmanusu.fultiniciosesion = Date.Now
                    segmanusu.npassintfallido = 0
                    segmanusuController.modsegmanusu(segmanusu.idsegmanusu, segmanusu.idcomunmanpers, segmanusu.idcomunmancom, _
                                                  segmanusu.idcomunmandir, segmanusu.idsegmanorg, segmanusu.idsegmandep, _
                                                  segmanusu.idsegmancarg, segmanusu.xnombreusuario, segmanusu.xcontrasena, _
                                                  segmanusu.fcreacion, segmanusu.ibloqueado, segmanusu.fultbloqueo, _
                                                  segmanusu.fultiniciosesion, segmanusu.fultcambpass, segmanusu.fultrecuppass, _
                                                  segmanusu.fultpassintfallido, segmanusu.npassintfallido, _
                                                  segmanusu.npassintfallidoacum, segmanusu.idseglogreg)
                    Return True
                End If
            Else
                If segmanusu Is Nothing Then
                    segmanusu = segmanusuController.selsegmanusuxnomusu(xnombreusuario)
                    If segmanusu IsNot Nothing Then
                        segmanusu.npassintfallido = segmanusu.npassintfallido + 1
                        segmanusu.npassintfallidoacum = segmanusu.npassintfallidoacum + 1
                        segmanusu.fultpassintfallido = Date.Now
                        If segmanusu.npassintfallido = 5 Then
                            'Dim svc_vi_segmanusu As New svc_vi_segmanusu
                            'Dim vi_segmanusu As vi_segmanusu = svc_vi_segmanusu.obtener_por_llave(segmanusu.idsegmanusu)
                            'If Not vi_segmanusu Is Nothing Then
                            '    tuloenvias.enviar_correo(1158, "INICIOS DE SESION FALLIDOS", vi_segmanusu.xcorreoelectronico1, "", "", "nombre:" & vi_segmanusu.xnombres & ",apellido:" & vi_segmanusu.xapellidos)
                            'Else
                            '    If vi_segmanusu Is Nothing Then
                            '        'si no encontramos el detalle de informacion del usuario no enviamos el correo. Esto no deberia suceder.
                            '    End If
                            'End If
                        End If
                        If segmanusu.npassintfallido >= 20 Then
                            segmanusu.ibloqueado = True
                            segmanusu.fultbloqueo = Date.Now
                        End If
                        segmanusuController.modsegmanusu(segmanusu.idsegmanusu, segmanusu.idcomunmanpers, segmanusu.idcomunmancom, _
                                                      segmanusu.idcomunmandir, segmanusu.idsegmanorg, segmanusu.idsegmandep, _
                                                      segmanusu.idsegmancarg, segmanusu.xnombreusuario, segmanusu.xcontrasena, _
                                                      segmanusu.fcreacion, segmanusu.ibloqueado, segmanusu.fultbloqueo, _
                                                      segmanusu.fultiniciosesion, segmanusu.fultcambpass, segmanusu.fultrecuppass, _
                                                      segmanusu.fultpassintfallido, segmanusu.npassintfallido, _
                                                      segmanusu.npassintfallidoacum, segmanusu.idseglogreg)
                        Return False
                    Else
                        If segmanusu Is Nothing Then
                            Return False
                        End If
                    End If
                End If
            End If
            Return False
        End Function


        <HttpGet()> _
        Public Function iniciar_sesion_bloqueo(xnombreusuario As String, xcontrasena As String) As respopera

            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            'NOTA: este aplica solo para aipauto
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()
            'FIN, aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                            


            Dim segmanusuController As New segmanusuController
            Dim respopera As New respopera
            Dim segmanusu As segmanusu = segmanusuController.selsegmanusuxnomypass(xnombreusuario, xcontrasena)
            If segmanusu IsNot Nothing Then
                If segmanusu.ibloqueado Then
                    'Throw New HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Unauthorized, String.Format("El usuario {0} se encuentra inactivo para iniciar sessión.", xnombreusuario)))
                    respopera.irespuesta = "2"
                    respopera.xmsjusuario = String.Format("El usuario {0} se encuentra inactivo para iniciar sessión.", xnombreusuario)
                    respopera.xmsjtecnico = String.Format("El usuario {0} se encuentra inactivo para iniciar sessión.", xnombreusuario)
                    Return respopera
                Else
                    segmanusu.fultiniciosesion = Date.Now
                    segmanusu.npassintfallido = 0
                    segmanusuController.modsegmanusu(segmanusu.idsegmanusu, segmanusu.idcomunmanpers, segmanusu.idcomunmancom, _
                                                  segmanusu.idcomunmandir, segmanusu.idsegmanorg, segmanusu.idsegmandep, _
                                                  segmanusu.idsegmancarg, segmanusu.xnombreusuario, segmanusu.xcontrasena, _
                                                  segmanusu.fcreacion, segmanusu.ibloqueado, segmanusu.fultbloqueo, _
                                                  segmanusu.fultiniciosesion, segmanusu.fultcambpass, segmanusu.fultrecuppass, _
                                                  segmanusu.fultpassintfallido, segmanusu.npassintfallido, _
                                                  segmanusu.npassintfallidoacum, segmanusu.idseglogreg)
                    respopera.irespuesta = "1"
                    respopera.xmsjusuario = "Credenciales correctas."

                    Return respopera

                End If
            Else
                If segmanusu Is Nothing Then
                    segmanusu = segmanusuController.selsegmanusuxnomusu(xnombreusuario)
                    If segmanusu IsNot Nothing Then
                        segmanusu.npassintfallido = segmanusu.npassintfallido + 1
                        segmanusu.npassintfallidoacum = segmanusu.npassintfallidoacum + 1
                        segmanusu.fultpassintfallido = Date.Now
                        If segmanusu.npassintfallido = 5 Then
                            segmanusu.ibloqueado = True
                            segmanusu.fultbloqueo = Date.Now
                            Dim aiplogeveController As New aiplogeveController
                            Dim aiplogeve As New aiplogeve

                            aiplogeve.iamblogeve = "SEGURIDAD SESION"
                            aiplogeve.fcrealogeve = Date.Now
                            aiplogeve.idsegmanusu = segmanusu.idsegmanusu
                            aiplogeve.xnomlogeve = "BLOQUEO DEL USUARIO " & xnombreusuario & " POR MAXIMO DE INTENTOS FALLIDOS."
                            aiplogeveController.insaiplogeve(aiplogeve)

                            'Dim svc_vi_segmanusu As New svc_vi_segmanusu
                            'Dim vi_segmanusu As vi_segmanusu = svc_vi_segmanusu.obtener_por_llave(segmanusu.idsegmanusu)
                            'If Not vi_segmanusu Is Nothing Then
                            '    tuloenvias.enviar_correo(1158, "INICIOS DE SESION FALLIDOS", vi_segmanusu.xcorreoelectronico1, "", "", "nombre:" & vi_segmanusu.xnombres & ",apellido:" & vi_segmanusu.xapellidos)
                            'Else
                            '    If vi_segmanusu Is Nothing Then
                            '        'si no encontramos el detalle de informacion del usuario no enviamos el correo. Esto no deberia suceder.
                            '    End If
                            'End If
                        End If
                        'If segmanusu.npassintfallido >= 20 Then
                        '    segmanusu.ibloqueado = True
                        '    segmanusu.fultbloqueo = Date.Now
                        'End If
                        segmanusuController.modsegmanusu(segmanusu.idsegmanusu, segmanusu.idcomunmanpers, segmanusu.idcomunmancom, _
                                                      segmanusu.idcomunmandir, segmanusu.idsegmanorg, segmanusu.idsegmandep, _
                                                      segmanusu.idsegmancarg, segmanusu.xnombreusuario, segmanusu.xcontrasena, _
                                                      segmanusu.fcreacion, segmanusu.ibloqueado, segmanusu.fultbloqueo, _
                                                      segmanusu.fultiniciosesion, segmanusu.fultcambpass, segmanusu.fultrecuppass, _
                                                      segmanusu.fultpassintfallido, segmanusu.npassintfallido, _
                                                      segmanusu.npassintfallidoacum, segmanusu.idseglogreg)
                        respopera.irespuesta = "0"
                        respopera.xmsjusuario = "Sus credenciales de usuario son incorrectas."

                        Return respopera
                    Else
                        If segmanusu Is Nothing Then
                            respopera.irespuesta = "0"
                            respopera.xmsjusuario = "Sus credenciales de usuario son incorrectas."

                            Return respopera
                        End If
                    End If
                End If
            End If
            respopera.irespuesta = "0"
            respopera.xmsjusuario = "Sus credenciales de usuario son incorrectas."

            Return respopera
        End Function


        <HttpGet()> _
        Public Function iniciar_sesion_bloqueo_movil(xnombreusuario As String, xcontrasena As String) As String
            Dim respopera As New respopera
            Dim InspeccionController As New InspeccionController
            Try


                InspeccionController.AgregarAipLogEve("usu: " & xnombreusuario & ", pass: " & xcontrasena, 0, "INICIO DE SES")
                Dim segmanusuController As New segmanusuController

                Dim segmanusu As segmanusu = segmanusuController.selsegmanusuxnomypass(xnombreusuario, xcontrasena)
                If segmanusu IsNot Nothing Then
                    InspeccionController.AgregarAipLogEve("Existe usuario id: " & segmanusu.idsegmanusu, 0, "INICIO DE SES")
                    If segmanusu.ibloqueado Then
                        InspeccionController.AgregarAipLogEve("Existe usuario id: " & segmanusu.idsegmanusu & " Bloqueado", 0, "INICIO DE SES")
                        'Throw New HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Unauthorized, String.Format("El usuario {0} se encuentra inactivo para iniciar sessión.", xnombreusuario)))
                        respopera.irespuesta = "2"
                        respopera.xmsjusuario = String.Format("El usuario {0} se encuentra inactivo para iniciar sessión.", xnombreusuario)
                        respopera.xmsjtecnico = String.Format("El usuario {0} se encuentra inactivo para iniciar sessión.", xnombreusuario)
                        Return respopera.irespuesta
                    Else
                        InspeccionController.AgregarAipLogEve("Existe usuario id: " & segmanusu.idsegmanusu & " No Bloqueado", 0, "INICIO DE SES")
                        segmanusu.fultiniciosesion = Date.Now
                        segmanusu.npassintfallido = 0
                        segmanusuController.modsegmanusu(segmanusu.idsegmanusu, segmanusu.idcomunmanpers, segmanusu.idcomunmancom, _
                                                      segmanusu.idcomunmandir, segmanusu.idsegmanorg, segmanusu.idsegmandep, _
                                                      segmanusu.idsegmancarg, segmanusu.xnombreusuario, segmanusu.xcontrasena, _
                                                      segmanusu.fcreacion, segmanusu.ibloqueado, segmanusu.fultbloqueo, _
                                                      segmanusu.fultiniciosesion, segmanusu.fultcambpass, segmanusu.fultrecuppass, _
                                                      segmanusu.fultpassintfallido, segmanusu.npassintfallido, _
                                                      segmanusu.npassintfallidoacum, segmanusu.idseglogreg)
                        respopera.irespuesta = "1"
                        respopera.xmsjusuario = "Credenciales correctas."

                        Return respopera.irespuesta

                    End If
                Else
                    If segmanusu Is Nothing Then
                        segmanusu = segmanusuController.selsegmanusuxnomusu(xnombreusuario)
                        If segmanusu IsNot Nothing Then
                            segmanusu.npassintfallido = segmanusu.npassintfallido + 1
                            segmanusu.npassintfallidoacum = segmanusu.npassintfallidoacum + 1
                            segmanusu.fultpassintfallido = Date.Now
                            If segmanusu.npassintfallido = 5 Then
                                segmanusu.ibloqueado = True
                                segmanusu.fultbloqueo = Date.Now
                                Dim aiplogeveController As New aiplogeveController
                                Dim aiplogeve As New aiplogeve

                                aiplogeve.iamblogeve = "SEGURIDAD SESION"
                                aiplogeve.fcrealogeve = Date.Now
                                aiplogeve.idsegmanusu = segmanusu.idsegmanusu
                                aiplogeve.xnomlogeve = "BLOQUEO DEL USUARIO " & xnombreusuario & " POR MAXIMO DE INTENTOS FALLIDOS."
                                aiplogeveController.insaiplogeve(aiplogeve)

                                'Dim svc_vi_segmanusu As New svc_vi_segmanusu
                                'Dim vi_segmanusu As vi_segmanusu = svc_vi_segmanusu.obtener_por_llave(segmanusu.idsegmanusu)
                                'If Not vi_segmanusu Is Nothing Then
                                '    tuloenvias.enviar_correo(1158, "INICIOS DE SESION FALLIDOS", vi_segmanusu.xcorreoelectronico1, "", "", "nombre:" & vi_segmanusu.xnombres & ",apellido:" & vi_segmanusu.xapellidos)
                                'Else
                                '    If vi_segmanusu Is Nothing Then
                                '        'si no encontramos el detalle de informacion del usuario no enviamos el correo. Esto no deberia suceder.
                                '    End If
                                'End If
                            End If
                            'If segmanusu.npassintfallido >= 20 Then
                            '    segmanusu.ibloqueado = True
                            '    segmanusu.fultbloqueo = Date.Now
                            'End If
                            segmanusuController.modsegmanusu(segmanusu.idsegmanusu, segmanusu.idcomunmanpers, segmanusu.idcomunmancom, _
                                                          segmanusu.idcomunmandir, segmanusu.idsegmanorg, segmanusu.idsegmandep, _
                                                          segmanusu.idsegmancarg, segmanusu.xnombreusuario, segmanusu.xcontrasena, _
                                                          segmanusu.fcreacion, segmanusu.ibloqueado, segmanusu.fultbloqueo, _
                                                          segmanusu.fultiniciosesion, segmanusu.fultcambpass, segmanusu.fultrecuppass, _
                                                          segmanusu.fultpassintfallido, segmanusu.npassintfallido, _
                                                          segmanusu.npassintfallidoacum, segmanusu.idseglogreg)
                            respopera.irespuesta = "0"
                            respopera.xmsjusuario = "Sus credenciales de usuario son incorrectas."

                            Return respopera.irespuesta
                        Else
                            If segmanusu Is Nothing Then
                                respopera.irespuesta = "0"
                                respopera.xmsjusuario = "Sus credenciales de usuario son incorrectas."

                                Return respopera.irespuesta
                            End If
                        End If
                    End If
                End If
                respopera.irespuesta = "0"
                respopera.xmsjusuario = "Sus credenciales de usuario son incorrectas."

                Return respopera.irespuesta

            Catch ex As Exception
                InspeccionController.AgregarAipLogEve(ex.Message, 0, "INICIO DE SES")
                respopera.irespuesta = "0"
                Return respopera.irespuesta
            End Try
        End Function



        <HttpGet()> _
        Public Function recuperar_contrasena(xnombreusuario As String) As Boolean
            Dim vi_segmanusuController As New vi_segmanusuController
            Dim vi_segmanusu As vi_segmanusu = vi_segmanusuController.selvi_segmanusuxnomusu(xnombreusuario)
            If vi_segmanusu IsNot Nothing Then
                'ir.message = tuloenvias.enviar_correo(1156, "RECUPERACION DE CONTRASEÑAS", vi_segmanusu.xcorreoelectronico1, "", "", "nombre:" & vi_segmanusu.xnombres & ",apellido:" & vi_segmanusu.xapellidos & ",pass:" & vi_segmanusu.xcontrasena)
                'If ir.message.Contains("Envio de correo creado con exito") Then
                '    'si se envio el correo satisfactoriamente lo notificamos
                '    ir.status = 1
                '    ir.message = "La contraseña se ha recuperado satisfactoriamente y se le ha enviado a su correo."
                '    'por ultimo volvemos a buscar nuevamente el usuario pero no en la vista sino en la entidad para modificar la 
                '    'fecha de ultima recuperacion de contraseña con la fecha actual. Como esta modificacion es para informacion 
                '    'referencial no pregunto si se realizo satisfactoriamente o no por ahora ya que lo esencial es recuperar la 
                '    'contraseña como tal.
                '    Dim svc_segmanusu As New svc_segmanusu
                '    Dim segmanusu As segmanusu = svc_segmanusu.obtener_por_llave(vi_segmanusu.idsegmanusu)
                '    If Not segmanusu Is Nothing Then
                '        segmanusu.fultrecuppass = Date.Now
                '        svc_segmanusu.modificar(segmanusu.idsegmanusu, segmanusu)
                '    End If
                'Else
                '    If Not ir.message.Contains("Envio de correo creado con exito") Then
                '        'si hubo problemas enviando el correo con la contraseña recuperada lo notificamos
                '        ir.status = 0
                '        ir.message = "No se pudo enviar el correo con la contraseña."
                '    End If
                'End If
                Return True
            Else
                If vi_segmanusu Is Nothing Then
                    Throw New HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.ServiceUnavailable, String.Format("La contraseña no se ha podido recuperar al correo {0}.", xnombreusuario)))
                End If
            End If
            Return False
        End Function

        <HttpGet()> _
        Public Function cambiar_contrasena(xnombreusuario As String, xcontrasena_actual As String, xcontrasena_nueva As String, _
                                           xcontrasena_confirmacion As String) As Boolean
            Dim segmanusuController As New segmanusuController
            Dim segmanusu As segmanusu = segmanusuController.selsegmanusuxnomypass(xnombreusuario, xcontrasena_actual)
            If segmanusu IsNot Nothing Then
                If xcontrasena_nueva = xcontrasena_confirmacion Then
                    segmanusu.xcontrasena = xcontrasena_nueva
                    segmanusu.fultcambpass = Date.Now
                    Dim cambio As Boolean = segmanusuController.modsegmanusu(segmanusu.idsegmanusu, segmanusu.idcomunmanpers, _
                                                                          segmanusu.idcomunmancom, _
                                                                          segmanusu.idcomunmandir, segmanusu.idsegmanorg, _
                                                                          segmanusu.idsegmandep, segmanusu.idsegmancarg, _
                                                                          segmanusu.xnombreusuario, segmanusu.xcontrasena, _
                                                                          segmanusu.fcreacion, segmanusu.ibloqueado, _
                                                                          segmanusu.fultbloqueo, segmanusu.fultiniciosesion, _
                                                                          segmanusu.fultcambpass, segmanusu.fultrecuppass, _
                                                                          segmanusu.fultpassintfallido, segmanusu.npassintfallido, _
                                                                          segmanusu.npassintfallidoacum, segmanusu.idseglogreg)
                    If cambio Then
                        ''si la modificacion es satisfactoria lo notificamos
                        'ir.status = 1
                        'ir.message = "Se ha cambiado su contraseña satisfactoriamente."
                        ''buscamos informacion de detalle del usuario para obtener ciertos datos del usuario que nos hara falta
                        'Dim svc_vi_segmanusu As New svc_vi_segmanusu
                        'Dim vi_segmanusu As vi_segmanusu = svc_vi_segmanusu.obtener_por_llave(segmanusu.idsegmanusu)
                        'If Not vi_segmanusu Is Nothing Then
                        '    tuloenvias.enviar_correo(1157, "CAMBIO DE CONTRASEÑAS", vi_segmanusu.xcorreoelectronico1, "", "", "nombre:" & vi_segmanusu.xnombres & ",apellido:" & vi_segmanusu.xapellidos)
                        'Else
                        '    If vi_segmanusu Is Nothing Then
                        '        'si no encontramos el detalle de informacion del usuario no enviamos el correo. Esto no deberia suceder.
                        '    End If
                        'End If
                        Return True
                    Else
                        Throw New HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Conflict, String.Format("Su contraseña no se pudo modificar.")))
                    End If
                Else
                    Return False
                End If
            Else
                If segmanusu Is Nothing Then
                    Throw New HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.Unauthorized, String.Format("Su contraseña actual es incorrecta.")))
                End If
            End If
            Return False
        End Function


        'Public Function AgregarUsu() As respopera
        <HttpPost()> _
        Public Function AgregarUsu(vi_segmanusu As vi_segmanusu) As respopera
            Try
                Dim respopera As New respopera
                If ConfigurationManager.AppSettings("motoddb") = "sql" Then
                    'Dim vi_segmanusu As New vi_segmanusu
                    'vi_segmanusu.idsegmanorg = 1
                    'vi_segmanusu.idsegmandep = 1
                    'vi_segmanusu.idsegmancarg = 7
                    'vi_segmanusu.xnombreusuario = "prueba@gmail.com"
                    'vi_segmanusu.xcontrasena = "1234567"
                    ''vi_segmanusu.fcreacion = Date.Now
                    'vi_segmanusu.ibloqueado = 0
                    ''vi_segmanusu.fultbloqueo = Date.Now
                    ''vi_segmanusu.fultiniciosesion = Date.Now
                    ''vi_segmanusu.fultcambpass = Date.Now
                    ''vi_segmanusu.fultrecuppass = Date.Now
                    ''vi_segmanusu.fultpassintfallido = Date.Now
                    'vi_segmanusu.npassintfallido = 0
                    'vi_segmanusu.npassintfallidoacum = 0
                    'vi_segmanusu.idseglogreg = 0
                    'vi_segmanusu.xcedula = "01234567"
                    'vi_segmanusu.xnombres = "VE"
                    'vi_segmanusu.xapellidos = "BS"
                    'vi_segmanusu.fnacimiento = "25/01/1986"
                    'vi_segmanusu.xsexo = "MASCULINO"
                    'vi_segmanusu.xnacionalidad = "LOCAL"
                    'vi_segmanusu.idcomunmanlocalid = 215
                    'vi_segmanusu.idcomunmanestado = 20
                    'vi_segmanusu.xtelfmovil1 = "416-9040694"
                    'vi_segmanusu.xtelfmovil2 = "416-3003989"
                    'vi_segmanusu.xcorreoelectronico1 = "vbolivar@prueba.net"
                    'vi_segmanusu.xtwitter1 = "@vbolivar"
                    'vi_segmanusu.xfacebook1 = "vbolivar"
                    '
                    Dim param1 As New SqlClient.SqlParameter
                    param1.SqlDbType = SqlDbType.VarChar
                    param1.Size = 20
                    param1.Value = "directo"
                    param1.ParameterName = "p_illamada"

                    Dim param2 As New SqlClient.SqlParameter
                    param2.SqlDbType = SqlDbType.Decimal
                    param2.Precision = 18
                    param2.Scale = 0
                    param2.Value = 0
                    param2.ParameterName = "p_idsegmanusuop"

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
                    param8.Value = 0
                    param8.ParameterName = "p_idsegmanusu"
                    param8.Direction = ParameterDirection.Output
                    'If vi_segmanusu.idsegmanusu IsNot Nothing Then
                    'param8.Value = vi_segmanusu.idsegmanusu
                    'Else
                    '    param8.Value = 0
                    'End If

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = 0
                    'param9.Value = vi_segmanusu.idcomunmanpers
                    param9.ParameterName = "p_idcomunmanpers"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = 0
                    'param10.Value = vi_segmanusu.idcomunmancom
                    param10.ParameterName = "p_idcomunmancom"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Decimal
                    param11.Precision = 18
                    param11.Scale = 0
                    param11.Value = 0
                    'param11.Value = vi_segmanusu.idcomunmandir
                    param11.ParameterName = "p_idcomunmandir"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Decimal
                    param12.Size = 18
                    param12.Scale = 0
                    'param12.Value = 0
                    If IsNothing(vi_segmanusu.idsegmanorg) Then
                        param12.Value = 0
                    Else
                        param12.Value = vi_segmanusu.idsegmanorg
                    End If
                    param12.ParameterName = "p_idsegmanorg"
                    'If vi_segmanusu.idsegmanorg IsNot Nothing Then
                    'param12.Value = vi_segmanusu.idsegmanorg
                    'Else
                    'param12.Value = 0
                    'End If

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Decimal
                    param13.Precision = 18
                    param13.Scale = 0
                    'param13.Value = 0
                    If IsNothing(vi_segmanusu.idsegmandep) Then
                        param13.Value = 0
                    Else
                        param13.Value = vi_segmanusu.idsegmandep
                    End If
                    param13.ParameterName = "p_idsegmandep"
                    'If vi_mant_segmanusu.idsegmandep IsNot Nothing Then
                    'param13.Value = vi_segmanusu.idsegmandep
                    'Else
                    'param13.Value = 0
                    'End If

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Decimal
                    param14.Precision = 18
                    param14.Scale = 0
                    param14.Value = vi_segmanusu.idsegmancarg
                    param14.ParameterName = "p_idsegmancarg"
                    'param14.Value = 0
                    'If vi_segmanusu.idsegmancarg IsNot Nothing Then
                    'Else
                    'param14.Value = 0
                    'End If

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 50
                    If vi_segmanusu.xnombreusuario IsNot Nothing Then
                        param15.Value = vi_segmanusu.xnombreusuario
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xnombreusuario"
                    '
                    'Dim gen_pass As New generador_password
                    'Dim password As String = Nothing
                    'Dim nchars As Integer = 10
                    ''
                    'password = gen_pass.obtener_password_nchars(nchars)
                    '
                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.VarChar
                    param16.Size = 50
                    param16.Value = vi_segmanusu.xcontrasena
                    param16.ParameterName = "p_xcontrasena"
                    'If vi_segmanusu.xcontrasena IsNot Nothing Then
                    '    param16.Value = vi_segmanusu.xcontrasena
                    'Else
                    '    'param16.Value = ""
                    '    param16.Value = password
                    'End If

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.DateTime
                    If vi_segmanusu.fcreacion > CDate("01-01-1900") Then
                        param17.Value = vi_segmanusu.fcreacion
                    Else
                        param17.Value = CDate("01-01-1900")
                    End If
                    param17.ParameterName = "p_fcreacion"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.Bit
                    param18.Value = vi_segmanusu.ibloqueado
                    param18.ParameterName = "p_ibloqueado"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.DateTime
                    If vi_segmanusu.fultbloqueo > CDate("01-01-1900") Then
                        param19.Value = vi_segmanusu.fultbloqueo
                    Else
                        param19.Value = CDate("01-01-1900")
                    End If
                    param19.ParameterName = "p_fultbloqueo"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.DateTime
                    If vi_segmanusu.fultiniciosesion > CDate("01-01-1900") Then
                        param20.Value = vi_segmanusu.fultiniciosesion
                    Else
                        param20.Value = CDate("01-01-1900")
                    End If
                    param20.ParameterName = "p_fultiniciosesion"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.DateTime
                    If vi_segmanusu.fultcambpass > CDate("01-01-1900") Then
                        param21.Value = vi_segmanusu.fultcambpass
                    Else
                        param21.Value = CDate("01-01-1900")
                    End If
                    param21.ParameterName = "p_fultcambpass"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.DateTime
                    If vi_segmanusu.fultrecuppass > CDate("01-01-1900") Then
                        param22.Value = vi_segmanusu.fultrecuppass
                    Else
                        param22.Value = CDate("01-01-1900")
                    End If
                    param22.ParameterName = "p_fultrecuppass"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.DateTime
                    param23.Value = CDate("01-01-1900")
                    param23.ParameterName = "p_fultpassintfallido"
                    'If vi_segmanusu.fultpassintfallido > CDate("01-01-1900") Then
                    'param23.Value = vi_segmanusu.fultpassintfallido
                    'Else
                    'param23.Value = CDate("01-01-1900")
                    'End If
                    'param23.ParameterName = "p_fultpassintfallido"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.BigInt
                    param24.Value = vi_segmanusu.npassintfallido
                    param24.ParameterName = "p_npassintfallido"

                    Dim param25 As New SqlClient.SqlParameter
                    param25.SqlDbType = SqlDbType.BigInt
                    param25.Value = vi_segmanusu.npassintfallidoacum
                    param25.ParameterName = "p_npassintfallidoacum"

                    Dim param26 As New SqlClient.SqlParameter
                    param26.SqlDbType = SqlDbType.Decimal
                    param26.Precision = 18
                    param26.Scale = 0
                    param26.Value = vi_segmanusu.idseglogreg
                    param26.ParameterName = "p_idseglogreg"

                    'campos de la tabla comunmanpers
                    Dim param27 As New SqlClient.SqlParameter
                    param27.SqlDbType = SqlDbType.VarChar
                    param27.Size = 20
                    If vi_segmanusu.xcedula IsNot Nothing Then
                        param27.Value = vi_segmanusu.xcedula
                    Else
                        param27.Value = ""
                    End If
                    param27.ParameterName = "p_xcedula"

                    Dim param28 As New SqlClient.SqlParameter
                    param28.SqlDbType = SqlDbType.VarChar
                    param28.Size = 50
                    param28.Value = vi_segmanusu.xnombres
                    param28.ParameterName = "p_xnombres"

                    Dim param29 As New SqlClient.SqlParameter
                    param29.SqlDbType = SqlDbType.VarChar
                    param29.Size = 50
                    param29.Value = vi_segmanusu.xapellidos
                    param29.ParameterName = "p_xapellidos"

                    Dim param30 As New SqlClient.SqlParameter
                    param30.SqlDbType = SqlDbType.VarChar
                    param30.Size = 100
                    If vi_segmanusu.xnombrecompleto IsNot Nothing Then
                        param30.Value = vi_segmanusu.xnombrecompleto
                    Else
                        param30.Value = vi_segmanusu.xnombres & " " & vi_segmanusu.xapellidos
                    End If
                    param30.ParameterName = "p_xnombrecompleto"

                    Dim param31 As New SqlClient.SqlParameter
                    param31.SqlDbType = SqlDbType.DateTime
                    If vi_segmanusu.fnacimiento > CDate("01-01-1900") Then
                        param31.Value = vi_segmanusu.fnacimiento
                    Else
                        param31.Value = CDate("01-01-1900")
                    End If
                    param31.ParameterName = "p_fnacimiento"

                    Dim param32 As New SqlClient.SqlParameter
                    param32.SqlDbType = SqlDbType.VarChar
                    param32.Size = 20
                    If vi_segmanusu.xsexo IsNot Nothing Then
                        param32.Value = vi_segmanusu.xsexo
                    Else
                        param32.Value = ""
                    End If
                    param32.ParameterName = "p_xsexo"

                    Dim param33 As New SqlClient.SqlParameter
                    param33.SqlDbType = SqlDbType.VarChar
                    param33.Size = 50
                    If vi_segmanusu.xsexo IsNot Nothing Then
                        param33.Value = vi_segmanusu.xnacionalidad
                    Else
                        param33.Value = ""
                    End If
                    param33.ParameterName = "p_xnacionalidad"

                    Dim param34 As New SqlClient.SqlParameter
                    param34.SqlDbType = SqlDbType.VarChar
                    param34.Size = 20
                    If vi_segmanusu.xestatura IsNot Nothing Then
                        param34.Value = vi_segmanusu.xestatura
                    Else
                        param34.Value = ""
                    End If
                    param34.ParameterName = "p_xestatura"

                    Dim param35 As New SqlClient.SqlParameter
                    param35.SqlDbType = SqlDbType.VarChar
                    param35.Size = 20
                    If vi_segmanusu.xestatura IsNot Nothing Then
                        param35.Value = vi_segmanusu.xmedestatura
                    Else
                        param35.Value = ""
                    End If
                    param35.ParameterName = "p_xmedestatura"

                    Dim param36 As New SqlClient.SqlParameter
                    param36.SqlDbType = SqlDbType.VarChar
                    param36.Size = 20
                    If vi_segmanusu.xpeso IsNot Nothing Then
                        param36.Value = vi_segmanusu.xpeso
                    Else
                        param36.Value = ""
                    End If
                    param36.ParameterName = "p_xpeso"

                    Dim param37 As New SqlClient.SqlParameter
                    param37.SqlDbType = SqlDbType.VarChar
                    param37.Size = 20
                    If vi_segmanusu.xpeso IsNot Nothing Then
                        param37.Value = vi_segmanusu.xmedpeso
                    Else
                        param37.Value = ""
                    End If
                    param37.ParameterName = "p_xmedpeso"

                    ''campos de la tabla comunmandir
                    Dim param38 As New SqlClient.SqlParameter
                    param38.SqlDbType = SqlDbType.Decimal
                    param38.Precision = 18
                    param38.Scale = 0
                    param38.Value = vi_segmanusu.idcomunmanlocalid
                    param38.ParameterName = "p_idcomunmanlocalid"

                    Dim param39 As New SqlClient.SqlParameter
                    param39.SqlDbType = SqlDbType.Decimal
                    param39.Precision = 18
                    param39.Scale = 0
                    param39.Value = vi_segmanusu.idcomunmanestado
                    param39.ParameterName = "p_idcomunmanestado"

                    Dim param40 As New SqlClient.SqlParameter
                    param40.SqlDbType = SqlDbType.Decimal
                    param40.Precision = 18
                    param40.Scale = 0
                    param40.Value = 9
                    param40.ParameterName = "p_idcomunmanpais"

                    Dim param41 As New SqlClient.SqlParameter
                    param41.SqlDbType = SqlDbType.Decimal
                    param41.Precision = 18
                    param41.Scale = 0
                    param41.Value = 1
                    param41.ParameterName = "p_idcomunmancont"

                    Dim param42 As New SqlClient.SqlParameter
                    param42.SqlDbType = SqlDbType.VarChar
                    param42.Size = 500
                    If vi_segmanusu.xdireccion IsNot Nothing Then
                        param42.Value = vi_segmanusu.xdireccion
                    Else
                        param42.Value = ""
                    End If
                    param42.ParameterName = "p_xdireccion"

                    Dim param43 As New SqlClient.SqlParameter
                    param43.SqlDbType = SqlDbType.Decimal
                    param43.Precision = 18
                    param43.Scale = 0
                    param43.Value = 0
                    'param43.Value = vi_segmanusu.idcomunmanlocalid2
                    param43.ParameterName = "p_idcomunmanlocalid2"

                    Dim param44 As New SqlClient.SqlParameter
                    param44.SqlDbType = SqlDbType.Decimal
                    param44.Precision = 18
                    param44.Scale = 0
                    param44.Value = 0
                    'param44.Value = vi_segmanusu.idcomunmanestado2
                    param44.ParameterName = "p_idcomunmanestado2"

                    Dim param45 As New SqlClient.SqlParameter
                    param45.SqlDbType = SqlDbType.Decimal
                    param45.Precision = 18
                    param45.Scale = 0
                    param45.Value = 9
                    param45.ParameterName = "p_idcomunmanpais2"

                    Dim param46 As New SqlClient.SqlParameter
                    param46.SqlDbType = SqlDbType.Decimal
                    param46.Precision = 18
                    param46.Scale = 0
                    param46.Value = 1
                    param46.ParameterName = "p_idcomunmancont2"

                    Dim param47 As New SqlClient.SqlParameter
                    param47.SqlDbType = SqlDbType.VarChar
                    param47.Size = 500
                    param47.Value = ""
                    param47.ParameterName = "p_xdireccion2"
                    'If vi_segmanusu.xdireccion2 IsNot Nothing Then
                    '    param47.Value = vi_segmanusu.xdireccion2
                    'Else
                    '    param47.Value = ""
                    'End If

                    Dim param48 As New SqlClient.SqlParameter
                    param48.SqlDbType = SqlDbType.Decimal
                    param48.Precision = 18
                    param48.Scale = 0
                    param48.Value = 0
                    param48.ParameterName = "p_idcomunmanlocalid3"

                    Dim param49 As New SqlClient.SqlParameter
                    param49.SqlDbType = SqlDbType.Decimal
                    param49.Precision = 18
                    param49.Scale = 0
                    param49.Value = 0
                    param49.ParameterName = "p_idcomunmanestado3"

                    Dim param50 As New SqlClient.SqlParameter
                    param50.SqlDbType = SqlDbType.Decimal
                    param50.Precision = 18
                    param50.Scale = 0
                    param50.Value = 0
                    param50.ParameterName = "p_idcomunmanpais3"

                    Dim param51 As New SqlClient.SqlParameter
                    param51.SqlDbType = SqlDbType.Decimal
                    param51.Precision = 18
                    param51.Scale = 0
                    param51.Value = 0
                    param51.ParameterName = "p_idcomunmancont3"

                    Dim param52 As New SqlClient.SqlParameter
                    param52.SqlDbType = SqlDbType.VarChar
                    param52.Size = 500
                    param52.Value = ""
                    param52.ParameterName = "p_xdireccion3"

                    Dim param53 As New SqlClient.SqlParameter
                    param53.SqlDbType = SqlDbType.Decimal
                    param53.Precision = 18
                    param53.Scale = 0
                    param53.Value = 0
                    param53.ParameterName = "p_idcomunmanlocalid4"

                    Dim param54 As New SqlClient.SqlParameter
                    param54.SqlDbType = SqlDbType.Decimal
                    param54.Precision = 18
                    param54.Scale = 0
                    param54.Value = 0
                    param54.ParameterName = "p_idcomunmanestado4"

                    Dim param55 As New SqlClient.SqlParameter
                    param55.SqlDbType = SqlDbType.Decimal
                    param55.Precision = 18
                    param55.Scale = 0
                    param55.Value = 0
                    param55.ParameterName = "p_idcomunmanpais4"

                    Dim param56 As New SqlClient.SqlParameter
                    param56.SqlDbType = SqlDbType.Decimal
                    param56.Precision = 18
                    param56.Scale = 0
                    param56.Value = 0
                    param56.ParameterName = "p_idcomunmancont4"

                    Dim param57 As New SqlClient.SqlParameter
                    param57.SqlDbType = SqlDbType.VarChar
                    param57.Size = 500
                    param57.Value = ""
                    param57.ParameterName = "p_xdireccion4"

                    Dim param58 As New SqlClient.SqlParameter
                    param58.SqlDbType = SqlDbType.Decimal
                    param58.Precision = 18
                    param58.Scale = 0
                    param58.Value = 0
                    param58.ParameterName = "p_idcomunmanlocalid5"

                    Dim param59 As New SqlClient.SqlParameter
                    param59.SqlDbType = SqlDbType.Decimal
                    param59.Precision = 18
                    param59.Scale = 0
                    param59.Value = 0
                    param59.ParameterName = "p_idcomunmanestado5"

                    Dim param60 As New SqlClient.SqlParameter
                    param60.SqlDbType = SqlDbType.Decimal
                    param60.Precision = 18
                    param60.Scale = 0
                    param60.Value = 0
                    param60.ParameterName = "p_idcomunmanpais5"

                    Dim param61 As New SqlClient.SqlParameter
                    param61.SqlDbType = SqlDbType.Decimal
                    param61.Precision = 18
                    param61.Scale = 0
                    param61.Value = 0
                    param61.ParameterName = "p_idcomunmancont5"

                    Dim param62 As New SqlClient.SqlParameter
                    param62.SqlDbType = SqlDbType.VarChar
                    param62.Size = 500
                    param62.Value = ""
                    param62.ParameterName = "p_xdireccion5"

                    'campos de la tabla comunmancom
                    Dim param63 As New SqlClient.SqlParameter
                    param63.SqlDbType = SqlDbType.VarChar
                    param63.Size = 20
                    param63.Value = ""
                    param63.ParameterName = "p_xtelfhabitacion1"

                    Dim param64 As New SqlClient.SqlParameter
                    param64.SqlDbType = SqlDbType.VarChar
                    param64.Size = 20
                    param64.Value = ""
                    param64.ParameterName = "p_xtelfhabitacion2"

                    Dim param65 As New SqlClient.SqlParameter
                    param65.SqlDbType = SqlDbType.VarChar
                    param65.Size = 20
                    param65.Value = ""
                    param65.ParameterName = "p_xtelfhabitacion3"

                    Dim param66 As New SqlClient.SqlParameter
                    param66.SqlDbType = SqlDbType.VarChar
                    param66.Size = 20
                    param66.Value = ""
                    param66.ParameterName = "p_xtelfhabitacion4"

                    Dim param67 As New SqlClient.SqlParameter
                    param67.SqlDbType = SqlDbType.VarChar
                    param67.Size = 20
                    param67.Value = ""
                    param67.ParameterName = "p_xtelfhabitacion5"
                    'estoy aqui
                    Dim param68 As New SqlClient.SqlParameter
                    param68.SqlDbType = SqlDbType.VarChar
                    param68.Size = 20
                    'param68.Value = ""
                    If vi_segmanusu.xtelfmovil1 IsNot Nothing Then
                        param68.Value = vi_segmanusu.xtelfmovil1
                    Else
                        param68.Value = ""
                    End If
                    param68.ParameterName = "p_xtelfmovil1"

                    Dim param69 As New SqlClient.SqlParameter
                    param69.SqlDbType = SqlDbType.VarChar
                    param69.Size = 20
                    'param69.Value = ""
                    If vi_segmanusu.xtelfmovil2 IsNot Nothing Then
                        param69.Value = vi_segmanusu.xtelfmovil2
                    Else
                        param69.Value = ""
                    End If
                    param69.ParameterName = "p_xtelfmovil2"

                    Dim param70 As New SqlClient.SqlParameter
                    param70.SqlDbType = SqlDbType.VarChar
                    param70.Size = 20
                    param70.Value = ""
                    param70.ParameterName = "p_xtelfmovil3"

                    Dim param71 As New SqlClient.SqlParameter
                    param71.SqlDbType = SqlDbType.VarChar
                    param71.Size = 20
                    param71.Value = ""
                    param71.ParameterName = "p_xtelfmovil4"

                    Dim param72 As New SqlClient.SqlParameter
                    param72.SqlDbType = SqlDbType.VarChar
                    param72.Size = 20
                    param72.Value = ""
                    param72.ParameterName = "p_xtelfmovil5"

                    Dim param73 As New SqlClient.SqlParameter
                    param73.SqlDbType = SqlDbType.VarChar
                    param73.Size = 20
                    If vi_segmanusu.xtelfoficina1 IsNot Nothing Then
                        param73.Value = vi_segmanusu.xtelfoficina1
                    Else
                        param73.Value = ""
                    End If
                    param73.ParameterName = "p_xtelfoficina1"

                    Dim param74 As New SqlClient.SqlParameter
                    param74.SqlDbType = SqlDbType.VarChar
                    param74.Size = 20
                    If vi_segmanusu.xtelfoficina2 IsNot Nothing Then
                        param74.Value = vi_segmanusu.xtelfoficina2
                    Else
                        param74.Value = ""
                    End If
                    param74.ParameterName = "p_xtelfoficina2"

                    Dim param75 As New SqlClient.SqlParameter
                    param75.SqlDbType = SqlDbType.VarChar
                    param75.Size = 20
                    param75.Value = ""
                    param75.ParameterName = "p_xtelfoficina3"

                    Dim param76 As New SqlClient.SqlParameter
                    param76.SqlDbType = SqlDbType.VarChar
                    param76.Size = 20
                    param76.Value = ""
                    param76.ParameterName = "p_xtelfoficina4"

                    Dim param77 As New SqlClient.SqlParameter
                    param77.SqlDbType = SqlDbType.VarChar
                    param77.Size = 20
                    param77.Value = ""
                    param77.ParameterName = "p_xtelfoficina5"

                    Dim param78 As New SqlClient.SqlParameter
                    param78.SqlDbType = SqlDbType.VarChar
                    param78.Size = 20
                    param78.Value = ""
                    param78.ParameterName = "p_xtelffax1"
                    'If vi_segmanusu.xtelffax1 IsNot Nothing Then
                    'param78.Value = vi_segmanusu.xtelffax1
                    'Else
                    'param78.Value = ""
                    'End If

                    Dim param79 As New SqlClient.SqlParameter
                    param79.SqlDbType = SqlDbType.VarChar
                    param79.Size = 20
                    param79.Value = ""
                    param79.ParameterName = "p_xtelffax2"
                    'If vi_segmanusu.xtelffax2 IsNot Nothing Then
                    '    param79.Value = vi_segmanusu.xtelffax2
                    'Else
                    '    param79.Value = ""
                    'End If

                    Dim param80 As New SqlClient.SqlParameter
                    param80.SqlDbType = SqlDbType.VarChar
                    param80.Size = 20
                    param80.Value = ""
                    param80.ParameterName = "p_xtelffax3"

                    Dim param81 As New SqlClient.SqlParameter
                    param81.SqlDbType = SqlDbType.VarChar
                    param81.Size = 20
                    param81.Value = ""
                    param81.ParameterName = "p_xtelffax4"

                    Dim param82 As New SqlClient.SqlParameter
                    param82.SqlDbType = SqlDbType.VarChar
                    param82.Size = 20
                    param82.Value = ""
                    param82.ParameterName = "p_xtelffax5"

                    Dim param83 As New SqlClient.SqlParameter
                    param83.SqlDbType = SqlDbType.VarChar
                    param83.Size = 50
                    If vi_segmanusu.xcorreoelectronico1 IsNot Nothing Then
                        param83.Value = vi_segmanusu.xcorreoelectronico1
                    Else
                        param83.Value = ""
                    End If
                    param83.ParameterName = "p_xcorreoelectronico1"

                    Dim param84 As New SqlClient.SqlParameter
                    param84.SqlDbType = SqlDbType.VarChar
                    param84.Size = 50
                    If vi_segmanusu.xcorreoelectronico2 IsNot Nothing Then
                        param84.Value = vi_segmanusu.xcorreoelectronico2
                    Else
                        param84.Value = ""
                    End If
                    param84.ParameterName = "p_xcorreoelectronico2"

                    Dim param85 As New SqlClient.SqlParameter
                    param85.SqlDbType = SqlDbType.VarChar
                    param85.Size = 50
                    param85.Value = ""
                    param85.ParameterName = "p_xcorreoelectronico3"

                    Dim param86 As New SqlClient.SqlParameter
                    param86.SqlDbType = SqlDbType.VarChar
                    param86.Size = 50
                    param86.Value = ""
                    param86.ParameterName = "p_xcorreoelectronico4"

                    Dim param87 As New SqlClient.SqlParameter
                    param87.SqlDbType = SqlDbType.VarChar
                    param87.Size = 50
                    param87.Value = ""
                    param87.ParameterName = "p_xcorreoelectronico5"

                    Dim param88 As New SqlClient.SqlParameter
                    param88.SqlDbType = SqlDbType.VarChar
                    param88.Size = 50
                    param88.Value = ""
                    param88.ParameterName = "p_xdireccionweb1"
                    'If vi_segmanusu.xdireccionweb1 IsNot Nothing Then
                    '    param88.Value = vi_segmanusu.xdireccionweb1
                    'Else
                    '    param88.Value = ""
                    'End If

                    Dim param89 As New SqlClient.SqlParameter
                    param89.SqlDbType = SqlDbType.VarChar
                    param89.Size = 50
                    param89.Value = ""
                    param89.ParameterName = "p_xdireccionweb2"
                    'If vi_segmanusu.xdireccionweb2 IsNot Nothing Then
                    '    param89.Value = vi_segmanusu.xdireccionweb2
                    'Else
                    '    param89.Value = ""
                    'End If

                    Dim param90 As New SqlClient.SqlParameter
                    param90.SqlDbType = SqlDbType.VarChar
                    param90.Size = 50
                    param90.Value = ""
                    param90.ParameterName = "p_xdireccionweb3"

                    Dim param91 As New SqlClient.SqlParameter
                    param91.SqlDbType = SqlDbType.VarChar
                    param91.Size = 50
                    param91.Value = ""
                    param91.ParameterName = "p_xdireccionweb4"

                    Dim param92 As New SqlClient.SqlParameter
                    param92.SqlDbType = SqlDbType.VarChar
                    param92.Size = 50
                    param92.Value = ""
                    param92.ParameterName = "p_xdireccionweb5"

                    Dim param93 As New SqlClient.SqlParameter
                    param93.SqlDbType = SqlDbType.VarChar
                    param93.Size = 200
                    If vi_segmanusu.xtwitter1 IsNot Nothing Then
                        param93.Value = vi_segmanusu.xtwitter1
                    Else
                        param93.Value = ""
                    End If
                    param93.ParameterName = "p_xtwitter1"

                    Dim param94 As New SqlClient.SqlParameter
                    param94.SqlDbType = SqlDbType.VarChar
                    param94.Size = 200
                    param94.Value = ""
                    param94.ParameterName = "p_xtwitter2"

                    Dim param95 As New SqlClient.SqlParameter
                    param95.SqlDbType = SqlDbType.VarChar
                    param95.Size = 200
                    param95.Value = ""
                    param95.ParameterName = "p_xtwitter3"

                    Dim param96 As New SqlClient.SqlParameter
                    param96.SqlDbType = SqlDbType.VarChar
                    param96.Size = 200
                    param96.Value = ""
                    param96.ParameterName = "p_xtwitter4"

                    Dim param97 As New SqlClient.SqlParameter
                    param97.SqlDbType = SqlDbType.VarChar
                    param97.Size = 200
                    param97.Value = ""
                    param97.ParameterName = "p_xtwitter5"

                    Dim param98 As New SqlClient.SqlParameter
                    param98.SqlDbType = SqlDbType.VarChar
                    param98.Size = 200
                    If vi_segmanusu.xfacebook1 IsNot Nothing Then
                        param98.Value = vi_segmanusu.xfacebook1
                    Else
                        param98.Value = ""
                    End If
                    param98.ParameterName = "p_xfacebook1"

                    Dim param99 As New SqlClient.SqlParameter
                    param99.SqlDbType = SqlDbType.VarChar
                    param99.Size = 200
                    param99.Value = ""
                    param99.ParameterName = "p_xfacebook2"

                    Dim param100 As New SqlClient.SqlParameter
                    param100.SqlDbType = SqlDbType.VarChar
                    param100.Size = 200
                    param100.Value = ""
                    param100.ParameterName = "p_xfacebook3"

                    Dim param101 As New SqlClient.SqlParameter
                    param101.SqlDbType = SqlDbType.VarChar
                    param101.Size = 200
                    param101.Value = ""
                    param101.ParameterName = "p_xfacebook4"

                    Dim param102 As New SqlClient.SqlParameter
                    param102.SqlDbType = SqlDbType.VarChar
                    param102.Size = 200
                    param102.Value = ""
                    param102.ParameterName = "p_xfacebook5"

                    ''campos agregados despues de crear el metodo
                    ''comunmanpers

                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_rnagregarusuario @p_illamada,@p_idsegmanusuop,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanusu  output,@p_idcomunmanpers,@p_idcomunmancom,@p_idcomunmandir,@p_idsegmanorg,@p_idsegmandep,@p_idsegmancarg,@p_xnombreusuario,@p_xcontrasena,@p_fcreacion,@p_ibloqueado,@p_fultbloqueo,@p_fultiniciosesion,@p_fultcambpass,@p_fultrecuppass,@p_fultpassintfallido,@p_npassintfallido,@p_npassintfallidoacum,@p_idseglogreg,@p_xcedula,@p_xnombres,@p_xapellidos,@p_xnombrecompleto,@p_fnacimiento,@p_xsexo,@p_xnacionalidad,@p_xestatura,@p_xmedestatura,@p_xpeso,@p_xmedpeso,@p_idcomunmanlocalid,@p_idcomunmanestado,@p_idcomunmanpais,@p_idcomunmancont,@p_xdireccion,@p_idcomunmanlocalid2,@p_idcomunmanestado2,@p_idcomunmanpais2,@p_idcomunmancont2,@p_xdireccion2,@p_idcomunmanlocalid3,@p_idcomunmanestado3,@p_idcomunmanpais3,@p_idcomunmancont3,@p_xdireccion3,@p_idcomunmanlocalid4,@p_idcomunmanestado4,@p_idcomunmanpais4,@p_idcomunmancont4,@p_xdireccion4,@p_idcomunmanlocalid5,@p_idcomunmanestado5,@p_idcomunmanpais5,@p_idcomunmancont5,@p_xdireccion5,@p_xtelfhabitacion1,@p_xtelfhabitacion2,@p_xtelfhabitacion3,@p_xtelfhabitacion4,@p_xtelfhabitacion5,@p_xtelfmovil1,@p_xtelfmovil2,@p_xtelfmovil3,@p_xtelfmovil4,@p_xtelfmovil5,@p_xtelfoficina1,@p_xtelfoficina2,@p_xtelfoficina3,@p_xtelfoficina4,@p_xtelfoficina5,@p_xtelffax1,@p_xtelffax2,@p_xtelffax3,@p_xtelffax4,@p_xtelffax5,@p_xcorreoelectronico1,@p_xcorreoelectronico2,@p_xcorreoelectronico3,@p_xcorreoelectronico4,@p_xcorreoelectronico5,@p_xdireccionweb1,@p_xdireccionweb2,@p_xdireccionweb3,@p_xdireccionweb4,@p_xdireccionweb5,@p_xtwitter1,@p_xtwitter2,@p_xtwitter3,@p_xtwitter4,@p_xtwitter5,@p_xfacebook1,@p_xfacebook2,@p_xfacebook3,@p_xfacebook4,@p_xfacebook5", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40, param41, param42, param43, param44, param45, param46, param47, param48, param49, param50, param51, param52, param53, param54, param55, param56, param57, param58, param59, param60, param61, param62, param63, param64, param65, param66, param67, param68, param69, param70, param71, param72, param73, param74, param75, param76, param77, param78, param79, param80, param81, param82, param83, param84, param85, param86, param87, param88, param89, param90, param91, param92, param93, param94, param95, param96, param97, param98, param99, param100, param101, param102)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If

                Else
                    'If ConfigurationManager.AppSettings("motoddb") = "oracle" Then
                    respopera = AgregarUsuOracle(vi_segmanusu)
                End If 'If ConfigurationManager.AppSettings("motoddb") = "sql" Then

                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        'este metodo es llemado por AgregarUsu cuando la base de datos es oracle
        <HttpPost()> _
        Public Function AgregarUsuOracle(vi_segmanusu As vi_segmanusu) As respopera
            Try

                Dim param1 As New Client.OracleParameter
                param1.OracleDbType = Client.OracleDbType.Varchar2
                param1.Size = 20
                param1.Value = "directo"
                param1.ParameterName = "p_illamada"

                Dim param2 As New Client.OracleParameter
                param2.OracleDbType = Client.OracleDbType.Decimal
                param2.Precision = 18
                param2.Scale = 0
                param2.Value = 0
                param2.ParameterName = "p_idsegmanusuop"

                Dim param3 As New Client.OracleParameter
                param3.OracleDbType = Client.OracleDbType.Varchar2
                param3.Size = 20
                param3.Value = "seginsoft"
                param3.ParameterName = "p_xnombrecorto"

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
                param8.ParameterName = "p_idsegmanusu"
                param8.Direction = ParameterDirection.Output
                'If vi_segmanusu.idsegmanusu IsNot Nothing Then
                'param8.Value = vi_segmanusu.idsegmanusu
                'Else
                '    param8.Value = 0
                'End If

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = 0
                'param9.Value = vi_segmanusu.idcomunmanpers
                param9.ParameterName = "p_idcomunmanpers"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = 0
                'param10.Value = vi_segmanusu.idcomunmancom
                param10.ParameterName = "p_idcomunmancom"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = 0
                'param11.Value = vi_segmanusu.idcomunmandir
                param11.ParameterName = "p_idcomunmandir"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Decimal
                param12.Size = 18
                param12.Scale = 0
                'param12.Value = 0
                If IsNothing(vi_segmanusu.idsegmanorg) Then
                    param12.Value = 0
                Else
                    param12.Value = vi_segmanusu.idsegmanorg
                End If
                param12.ParameterName = "p_idsegmanorg"
                'If vi_segmanusu.idsegmanorg IsNot Nothing Then
                'param12.Value = vi_segmanusu.idsegmanorg
                'Else
                'param12.Value = 0
                'End If

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                'param13.Value = 0
                If IsNothing(vi_segmanusu.idsegmandep) Then
                    param13.Value = 0
                Else
                    param13.Value = vi_segmanusu.idsegmandep
                End If
                param13.ParameterName = "p_idsegmandep"
                'If vi_mant_segmanusu.idsegmandep IsNot Nothing Then
                'param13.Value = vi_segmanusu.idsegmandep
                'Else
                'param13.Value = 0
                'End If

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = vi_segmanusu.idsegmancarg
                param14.ParameterName = "p_idsegmancarg"
                'param14.Value = 0
                'If vi_segmanusu.idsegmancarg IsNot Nothing Then
                'Else
                'param14.Value = 0
                'End If

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 50
                If vi_segmanusu.xnombreusuario IsNot Nothing Then
                    param15.Value = vi_segmanusu.xnombreusuario
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xnombreusuario"
                '
                'Dim gen_pass As New generador_password
                'Dim password As String = Nothing
                'Dim nchars As Integer = 10
                ''
                'password = gen_pass.obtener_password_nchars(nchars)
                '
                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Varchar2
                param16.Size = 50
                param16.Value = vi_segmanusu.xcontrasena
                param16.ParameterName = "p_xcontrasena"
                'If vi_segmanusu.xcontrasena IsNot Nothing Then
                '    param16.Value = vi_segmanusu.xcontrasena
                'Else
                '    'param16.Value = " "
                '    param16.Value = password
                'End If

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Date
                If vi_segmanusu.fcreacion > CDate("01-01-1900") Then
                    param17.Value = vi_segmanusu.fcreacion
                Else
                    param17.Value = CDate("01-01-1900")
                End If
                param17.ParameterName = "p_fcreacion"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Int16
                param18.Value = vi_segmanusu.ibloqueado
                param18.ParameterName = "p_ibloqueado"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Date
                If vi_segmanusu.fultbloqueo > CDate("01-01-1900") Then
                    param19.Value = vi_segmanusu.fultbloqueo
                Else
                    param19.Value = CDate("01-01-1900")
                End If
                param19.ParameterName = "p_fultbloqueo"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Date
                If vi_segmanusu.fultiniciosesion > CDate("01-01-1900") Then
                    param20.Value = vi_segmanusu.fultiniciosesion
                Else
                    param20.Value = CDate("01-01-1900")
                End If
                param20.ParameterName = "p_fultiniciosesion"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Date
                If vi_segmanusu.fultcambpass > CDate("01-01-1900") Then
                    param21.Value = vi_segmanusu.fultcambpass
                Else
                    param21.Value = CDate("01-01-1900")
                End If
                param21.ParameterName = "p_fultcambpass"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.Date
                If vi_segmanusu.fultrecuppass > CDate("01-01-1900") Then
                    param22.Value = vi_segmanusu.fultrecuppass
                Else
                    param22.Value = CDate("01-01-1900")
                End If
                param22.ParameterName = "p_fultrecuppass"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.Date
                param23.Value = CDate("01-01-1900")
                param23.ParameterName = "p_fultpassintfallido"
                'If vi_segmanusu.fultpassintfallido > CDate("01-01-1900") Then
                'param23.Value = vi_segmanusu.fultpassintfallido
                'Else
                'param23.Value = CDate("01-01-1900")
                'End If
                'param23.ParameterName = "p_fultpassintfallido"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.Long
                param24.Value = vi_segmanusu.npassintfallido
                param24.ParameterName = "p_npassintfallido"

                Dim param25 As New Client.OracleParameter
                param25.OracleDbType = Client.OracleDbType.Long
                param25.Value = vi_segmanusu.npassintfallidoacum
                param25.ParameterName = "p_npassintfallidoacum"

                Dim param26 As New Client.OracleParameter
                param26.OracleDbType = Client.OracleDbType.Decimal
                param26.Precision = 18
                param26.Scale = 0
                param26.Value = vi_segmanusu.idseglogreg
                param26.ParameterName = "p_idseglogreg"

                'campos de la tabla comunmanpers
                Dim param27 As New Client.OracleParameter
                param27.OracleDbType = Client.OracleDbType.Varchar2
                param27.Size = 20
                If vi_segmanusu.xcedula IsNot Nothing Then
                    param27.Value = vi_segmanusu.xcedula
                Else
                    param27.Value = " "
                End If
                param27.ParameterName = "p_xcedula"

                Dim param28 As New Client.OracleParameter
                param28.OracleDbType = Client.OracleDbType.Varchar2
                param28.Size = 50
                param28.Value = vi_segmanusu.xnombres
                param28.ParameterName = "p_xnombres"

                Dim param29 As New Client.OracleParameter
                param29.OracleDbType = Client.OracleDbType.Varchar2
                param29.Size = 50
                param29.Value = vi_segmanusu.xapellidos
                param29.ParameterName = "p_xapellidos"

                Dim param30 As New Client.OracleParameter
                param30.OracleDbType = Client.OracleDbType.Varchar2
                param30.Size = 100
                If vi_segmanusu.xnombrecompleto IsNot Nothing Then
                    param30.Value = vi_segmanusu.xnombrecompleto
                Else
                    param30.Value = vi_segmanusu.xnombres & " " & vi_segmanusu.xapellidos
                End If
                param30.ParameterName = "p_xnombrecompleto"

                Dim param31 As New Client.OracleParameter
                param31.OracleDbType = Client.OracleDbType.Date
                If vi_segmanusu.fnacimiento > CDate("01-01-1900") Then
                    param31.Value = vi_segmanusu.fnacimiento
                Else
                    param31.Value = CDate("01-01-1900")
                End If
                param31.ParameterName = "p_fnacimiento"

                Dim param32 As New Client.OracleParameter
                param32.OracleDbType = Client.OracleDbType.Varchar2
                param32.Size = 20
                If vi_segmanusu.xsexo IsNot Nothing Then
                    param32.Value = vi_segmanusu.xsexo
                Else
                    param32.Value = " "
                End If
                param32.ParameterName = "p_xsexo"

                Dim param33 As New Client.OracleParameter
                param33.OracleDbType = Client.OracleDbType.Varchar2
                param33.Size = 50
                If vi_segmanusu.xsexo IsNot Nothing Then
                    param33.Value = vi_segmanusu.xnacionalidad
                Else
                    param33.Value = " "
                End If
                param33.ParameterName = "p_xnacionalidad"

                Dim param34 As New Client.OracleParameter
                param34.OracleDbType = Client.OracleDbType.Varchar2
                param34.Size = 20
                If vi_segmanusu.xestatura IsNot Nothing Then
                    param34.Value = vi_segmanusu.xestatura
                Else
                    param34.Value = " "
                End If
                param34.ParameterName = "p_xestatura"

                Dim param35 As New Client.OracleParameter
                param35.OracleDbType = Client.OracleDbType.Varchar2
                param35.Size = 20
                If vi_segmanusu.xestatura IsNot Nothing Then
                    param35.Value = vi_segmanusu.xmedestatura
                Else
                    param35.Value = " "
                End If
                param35.ParameterName = "p_xmedestatura"

                Dim param36 As New Client.OracleParameter
                param36.OracleDbType = Client.OracleDbType.Varchar2
                param36.Size = 20
                If vi_segmanusu.xpeso IsNot Nothing Then
                    param36.Value = vi_segmanusu.xpeso
                Else
                    param36.Value = " "
                End If
                param36.ParameterName = "p_xpeso"

                Dim param37 As New Client.OracleParameter
                param37.OracleDbType = Client.OracleDbType.Varchar2
                param37.Size = 20
                If vi_segmanusu.xpeso IsNot Nothing Then
                    param37.Value = vi_segmanusu.xmedpeso
                Else
                    param37.Value = " "
                End If
                param37.ParameterName = "p_xmedpeso"

                ''campos de la tabla comunmandir
                Dim param38 As New Client.OracleParameter
                param38.OracleDbType = Client.OracleDbType.Decimal
                param38.Precision = 18
                param38.Scale = 0
                param38.Value = vi_segmanusu.idcomunmanlocalid
                param38.ParameterName = "p_idcomunmanlocalid"

                Dim param39 As New Client.OracleParameter
                param39.OracleDbType = Client.OracleDbType.Decimal
                param39.Precision = 18
                param39.Scale = 0
                param39.Value = vi_segmanusu.idcomunmanestado
                param39.ParameterName = "p_idcomunmanestado"

                Dim param40 As New Client.OracleParameter
                param40.OracleDbType = Client.OracleDbType.Decimal
                param40.Precision = 18
                param40.Scale = 0
                param40.Value = 9
                param40.ParameterName = "p_idcomunmanpais"

                Dim param41 As New Client.OracleParameter
                param41.OracleDbType = Client.OracleDbType.Decimal
                param41.Precision = 18
                param41.Scale = 0
                param41.Value = 1
                param41.ParameterName = "p_idcomunmancont"

                Dim param42 As New Client.OracleParameter
                param42.OracleDbType = Client.OracleDbType.Varchar2
                param42.Size = 500
                If vi_segmanusu.xdireccion IsNot Nothing Then
                    param42.Value = vi_segmanusu.xdireccion
                Else
                    param42.Value = " "
                End If
                param42.ParameterName = "p_xdireccion"

                Dim param43 As New Client.OracleParameter
                param43.OracleDbType = Client.OracleDbType.Decimal
                param43.Precision = 18
                param43.Scale = 0
                param43.Value = 0
                'param43.Value = vi_segmanusu.idcomunmanlocalid2
                param43.ParameterName = "p_idcomunmanlocalid2"

                Dim param44 As New Client.OracleParameter
                param44.OracleDbType = Client.OracleDbType.Decimal
                param44.Precision = 18
                param44.Scale = 0
                param44.Value = 0
                'param44.Value = vi_segmanusu.idcomunmanestado2
                param44.ParameterName = "p_idcomunmanestado2"

                Dim param45 As New Client.OracleParameter
                param45.OracleDbType = Client.OracleDbType.Decimal
                param45.Precision = 18
                param45.Scale = 0
                param45.Value = 9
                param45.ParameterName = "p_idcomunmanpais2"

                Dim param46 As New Client.OracleParameter
                param46.OracleDbType = Client.OracleDbType.Decimal
                param46.Precision = 18
                param46.Scale = 0
                param46.Value = 1
                param46.ParameterName = "p_idcomunmancont2"

                Dim param47 As New Client.OracleParameter
                param47.OracleDbType = Client.OracleDbType.Varchar2
                param47.Size = 500
                param47.Value = " "
                param47.ParameterName = "p_xdireccion2"
                'If vi_segmanusu.xdireccion2 IsNot Nothing Then
                '    param47.Value = vi_segmanusu.xdireccion2
                'Else
                '    param47.Value = " "
                'End If

                Dim param48 As New Client.OracleParameter
                param48.OracleDbType = Client.OracleDbType.Decimal
                param48.Precision = 18
                param48.Scale = 0
                param48.Value = 0
                param48.ParameterName = "p_idcomunmanlocalid3"

                Dim param49 As New Client.OracleParameter
                param49.OracleDbType = Client.OracleDbType.Decimal
                param49.Precision = 18
                param49.Scale = 0
                param49.Value = 0
                param49.ParameterName = "p_idcomunmanestado3"

                Dim param50 As New Client.OracleParameter
                param50.OracleDbType = Client.OracleDbType.Decimal
                param50.Precision = 18
                param50.Scale = 0
                param50.Value = 0
                param50.ParameterName = "p_idcomunmanpais3"

                Dim param51 As New Client.OracleParameter
                param51.OracleDbType = Client.OracleDbType.Decimal
                param51.Precision = 18
                param51.Scale = 0
                param51.Value = 0
                param51.ParameterName = "p_idcomunmancont3"

                Dim param52 As New Client.OracleParameter
                param52.OracleDbType = Client.OracleDbType.Varchar2
                param52.Size = 500
                param52.Value = " "
                param52.ParameterName = "p_xdireccion3"

                Dim param53 As New Client.OracleParameter
                param53.OracleDbType = Client.OracleDbType.Decimal
                param53.Precision = 18
                param53.Scale = 0
                param53.Value = 0
                param53.ParameterName = "p_idcomunmanlocalid4"

                Dim param54 As New Client.OracleParameter
                param54.OracleDbType = Client.OracleDbType.Decimal
                param54.Precision = 18
                param54.Scale = 0
                param54.Value = 0
                param54.ParameterName = "p_idcomunmanestado4"

                Dim param55 As New Client.OracleParameter
                param55.OracleDbType = Client.OracleDbType.Decimal
                param55.Precision = 18
                param55.Scale = 0
                param55.Value = 0
                param55.ParameterName = "p_idcomunmanpais4"

                Dim param56 As New Client.OracleParameter
                param56.OracleDbType = Client.OracleDbType.Decimal
                param56.Precision = 18
                param56.Scale = 0
                param56.Value = 0
                param56.ParameterName = "p_idcomunmancont4"

                Dim param57 As New Client.OracleParameter
                param57.OracleDbType = Client.OracleDbType.Varchar2
                param57.Size = 500
                param57.Value = " "
                param57.ParameterName = "p_xdireccion4"

                Dim param58 As New Client.OracleParameter
                param58.OracleDbType = Client.OracleDbType.Decimal
                param58.Precision = 18
                param58.Scale = 0
                param58.Value = 0
                param58.ParameterName = "p_idcomunmanlocalid5"

                Dim param59 As New Client.OracleParameter
                param59.OracleDbType = Client.OracleDbType.Decimal
                param59.Precision = 18
                param59.Scale = 0
                param59.Value = 0
                param59.ParameterName = "p_idcomunmanestado5"

                Dim param60 As New Client.OracleParameter
                param60.OracleDbType = Client.OracleDbType.Decimal
                param60.Precision = 18
                param60.Scale = 0
                param60.Value = 0
                param60.ParameterName = "p_idcomunmanpais5"

                Dim param61 As New Client.OracleParameter
                param61.OracleDbType = Client.OracleDbType.Decimal
                param61.Precision = 18
                param61.Scale = 0
                param61.Value = 0
                param61.ParameterName = "p_idcomunmancont5"

                Dim param62 As New Client.OracleParameter
                param62.OracleDbType = Client.OracleDbType.Varchar2
                param62.Size = 500
                param62.Value = " "
                param62.ParameterName = "p_xdireccion5"

                'campos de la tabla comunmancom
                Dim param63 As New Client.OracleParameter
                param63.OracleDbType = Client.OracleDbType.Varchar2
                param63.Size = 20
                param63.Value = " "
                param63.ParameterName = "p_xtelfhabitacion1"

                Dim param64 As New Client.OracleParameter
                param64.OracleDbType = Client.OracleDbType.Varchar2
                param64.Size = 20
                param64.Value = " "
                param64.ParameterName = "p_xtelfhabitacion2"

                Dim param65 As New Client.OracleParameter
                param65.OracleDbType = Client.OracleDbType.Varchar2
                param65.Size = 20
                param65.Value = " "
                param65.ParameterName = "p_xtelfhabitacion3"

                Dim param66 As New Client.OracleParameter
                param66.OracleDbType = Client.OracleDbType.Varchar2
                param66.Size = 20
                param66.Value = " "
                param66.ParameterName = "p_xtelfhabitacion4"

                Dim param67 As New Client.OracleParameter
                param67.OracleDbType = Client.OracleDbType.Varchar2
                param67.Size = 20
                param67.Value = " "
                param67.ParameterName = "p_xtelfhabitacion5"
                'estoy aqui
                Dim param68 As New Client.OracleParameter
                param68.OracleDbType = Client.OracleDbType.Varchar2
                param68.Size = 20
                'param68.Value = " "
                If vi_segmanusu.xtelfmovil1 IsNot Nothing Then
                    param68.Value = vi_segmanusu.xtelfmovil1
                Else
                    param68.Value = " "
                End If
                param68.ParameterName = "p_xtelfmovil1"

                Dim param69 As New Client.OracleParameter
                param69.OracleDbType = Client.OracleDbType.Varchar2
                param69.Size = 20
                'param69.Value = " "
                If vi_segmanusu.xtelfmovil2 IsNot Nothing Then
                    param69.Value = vi_segmanusu.xtelfmovil2
                Else
                    param69.Value = " "
                End If
                param69.ParameterName = "p_xtelfmovil2"

                Dim param70 As New Client.OracleParameter
                param70.OracleDbType = Client.OracleDbType.Varchar2
                param70.Size = 20
                param70.Value = " "
                param70.ParameterName = "p_xtelfmovil3"

                Dim param71 As New Client.OracleParameter
                param71.OracleDbType = Client.OracleDbType.Varchar2
                param71.Size = 20
                param71.Value = " "
                param71.ParameterName = "p_xtelfmovil4"

                Dim param72 As New Client.OracleParameter
                param72.OracleDbType = Client.OracleDbType.Varchar2
                param72.Size = 20
                param72.Value = " "
                param72.ParameterName = "p_xtelfmovil5"

                Dim param73 As New Client.OracleParameter
                param73.OracleDbType = Client.OracleDbType.Varchar2
                param73.Size = 20
                If vi_segmanusu.xtelfoficina1 IsNot Nothing Then
                    param73.Value = vi_segmanusu.xtelfoficina1
                Else
                    param73.Value = " "
                End If
                param73.ParameterName = "p_xtelfoficina1"

                Dim param74 As New Client.OracleParameter
                param74.OracleDbType = Client.OracleDbType.Varchar2
                param74.Size = 20
                If vi_segmanusu.xtelfoficina2 IsNot Nothing Then
                    param74.Value = vi_segmanusu.xtelfoficina2
                Else
                    param74.Value = " "
                End If
                param74.ParameterName = "p_xtelfoficina2"

                Dim param75 As New Client.OracleParameter
                param75.OracleDbType = Client.OracleDbType.Varchar2
                param75.Size = 20
                param75.Value = " "
                param75.ParameterName = "p_xtelfoficina3"

                Dim param76 As New Client.OracleParameter
                param76.OracleDbType = Client.OracleDbType.Varchar2
                param76.Size = 20
                param76.Value = " "
                param76.ParameterName = "p_xtelfoficina4"

                Dim param77 As New Client.OracleParameter
                param77.OracleDbType = Client.OracleDbType.Varchar2
                param77.Size = 20
                param77.Value = " "
                param77.ParameterName = "p_xtelfoficina5"

                Dim param78 As New Client.OracleParameter
                param78.OracleDbType = Client.OracleDbType.Varchar2
                param78.Size = 20
                param78.Value = " "
                param78.ParameterName = "p_xtelffax1"
                'If vi_segmanusu.xtelffax1 IsNot Nothing Then
                'param78.Value = vi_segmanusu.xtelffax1
                'Else
                'param78.Value = " "
                'End If

                Dim param79 As New Client.OracleParameter
                param79.OracleDbType = Client.OracleDbType.Varchar2
                param79.Size = 20
                param79.Value = " "
                param79.ParameterName = "p_xtelffax2"
                'If vi_segmanusu.xtelffax2 IsNot Nothing Then
                '    param79.Value = vi_segmanusu.xtelffax2
                'Else
                '    param79.Value = " "
                'End If

                Dim param80 As New Client.OracleParameter
                param80.OracleDbType = Client.OracleDbType.Varchar2
                param80.Size = 20
                param80.Value = " "
                param80.ParameterName = "p_xtelffax3"

                Dim param81 As New Client.OracleParameter
                param81.OracleDbType = Client.OracleDbType.Varchar2
                param81.Size = 20
                param81.Value = " "
                param81.ParameterName = "p_xtelffax4"

                Dim param82 As New Client.OracleParameter
                param82.OracleDbType = Client.OracleDbType.Varchar2
                param82.Size = 20
                param82.Value = " "
                param82.ParameterName = "p_xtelffax5"

                Dim param83 As New Client.OracleParameter
                param83.OracleDbType = Client.OracleDbType.Varchar2
                param83.Size = 50
                If vi_segmanusu.xcorreoelectronico1 IsNot Nothing Then
                    param83.Value = vi_segmanusu.xcorreoelectronico1
                Else
                    param83.Value = " "
                End If
                param83.ParameterName = "p_xcorreoelectronico1"

                Dim param84 As New Client.OracleParameter
                param84.OracleDbType = Client.OracleDbType.Varchar2
                param84.Size = 50
                If vi_segmanusu.xcorreoelectronico2 IsNot Nothing Then
                    param84.Value = vi_segmanusu.xcorreoelectronico2
                Else
                    param84.Value = " "
                End If
                param84.ParameterName = "p_xcorreoelectronico2"

                Dim param85 As New Client.OracleParameter
                param85.OracleDbType = Client.OracleDbType.Varchar2
                param85.Size = 50
                param85.Value = " "
                param85.ParameterName = "p_xcorreoelectronico3"

                Dim param86 As New Client.OracleParameter
                param86.OracleDbType = Client.OracleDbType.Varchar2
                param86.Size = 50
                param86.Value = " "
                param86.ParameterName = "p_xcorreoelectronico4"

                Dim param87 As New Client.OracleParameter
                param87.OracleDbType = Client.OracleDbType.Varchar2
                param87.Size = 50
                param87.Value = " "
                param87.ParameterName = "p_xcorreoelectronico5"

                Dim param88 As New Client.OracleParameter
                param88.OracleDbType = Client.OracleDbType.Varchar2
                param88.Size = 50
                param88.Value = " "
                param88.ParameterName = "p_xdireccionweb1"
                'If vi_segmanusu.xdireccionweb1 IsNot Nothing Then
                '    param88.Value = vi_segmanusu.xdireccionweb1
                'Else
                '    param88.Value = " "
                'End If

                Dim param89 As New Client.OracleParameter
                param89.OracleDbType = Client.OracleDbType.Varchar2
                param89.Size = 50
                param89.Value = " "
                param89.ParameterName = "p_xdireccionweb2"
                'If vi_segmanusu.xdireccionweb2 IsNot Nothing Then
                '    param89.Value = vi_segmanusu.xdireccionweb2
                'Else
                '    param89.Value = " "
                'End If

                Dim param90 As New Client.OracleParameter
                param90.OracleDbType = Client.OracleDbType.Varchar2
                param90.Size = 50
                param90.Value = " "
                param90.ParameterName = "p_xdireccionweb3"

                Dim param91 As New Client.OracleParameter
                param91.OracleDbType = Client.OracleDbType.Varchar2
                param91.Size = 50
                param91.Value = " "
                param91.ParameterName = "p_xdireccionweb4"

                Dim param92 As New Client.OracleParameter
                param92.OracleDbType = Client.OracleDbType.Varchar2
                param92.Size = 50
                param92.Value = " "
                param92.ParameterName = "p_xdireccionweb5"

                Dim param93 As New Client.OracleParameter
                param93.OracleDbType = Client.OracleDbType.Varchar2
                param93.Size = 200
                If vi_segmanusu.xtwitter1 IsNot Nothing Then
                    param93.Value = vi_segmanusu.xtwitter1
                Else
                    param93.Value = " "
                End If
                param93.ParameterName = "p_xtwitter1"

                Dim param94 As New Client.OracleParameter
                param94.OracleDbType = Client.OracleDbType.Varchar2
                param94.Size = 200
                param94.Value = " "
                param94.ParameterName = "p_xtwitter2"

                Dim param95 As New Client.OracleParameter
                param95.OracleDbType = Client.OracleDbType.Varchar2
                param95.Size = 200
                param95.Value = " "
                param95.ParameterName = "p_xtwitter3"

                Dim param96 As New Client.OracleParameter
                param96.OracleDbType = Client.OracleDbType.Varchar2
                param96.Size = 200
                param96.Value = " "
                param96.ParameterName = "p_xtwitter4"

                Dim param97 As New Client.OracleParameter
                param97.OracleDbType = Client.OracleDbType.Varchar2
                param97.Size = 200
                param97.Value = " "
                param97.ParameterName = "p_xtwitter5"

                Dim param98 As New Client.OracleParameter
                param98.OracleDbType = Client.OracleDbType.Varchar2
                param98.Size = 200
                If vi_segmanusu.xfacebook1 IsNot Nothing Then
                    param98.Value = vi_segmanusu.xfacebook1
                Else
                    param98.Value = " "
                End If
                param98.ParameterName = "p_xfacebook1"

                Dim param99 As New Client.OracleParameter
                param99.OracleDbType = Client.OracleDbType.Varchar2
                param99.Size = 200
                param99.Value = " "
                param99.ParameterName = "p_xfacebook2"

                Dim param100 As New Client.OracleParameter
                param100.OracleDbType = Client.OracleDbType.Varchar2
                param100.Size = 200
                param100.Value = " "
                param100.ParameterName = "p_xfacebook3"

                Dim param101 As New Client.OracleParameter
                param101.OracleDbType = Client.OracleDbType.Varchar2
                param101.Size = 200
                param101.Value = " "
                param101.ParameterName = "p_xfacebook4"

                Dim param102 As New Client.OracleParameter
                param102.OracleDbType = Client.OracleDbType.Varchar2
                param102.Size = 200
                param102.Value = " "
                param102.ParameterName = "p_xfacebook5"

                ''campos agregados despues de crear el metodo
                ''comunmanpers

                Dim xdeclare As String = "DECLARE v_p_illamada varchar2(32767);  iv_p_idsegmanusuop float;  iv_p_xnombrecorto varchar2(32767);  v_p_irespuesta varchar2(32767);  v_p_xmsjusuario varchar2(32767);  v_p_xmsjtecnico varchar2(32767);  v_p_coderrorlog varchar2(32767);  v_p_idsegmanusu float;  iv_p_idcomunmanpers float;  iv_p_idcomunmancom float;  iv_p_idcomunmandir float;  v_p_idsegmanorg float;  v_p_idsegmandep float;  v_p_idsegmancarg float;  iv_p_xnombreusuario varchar2(32767);  v_p_xcontrasena varchar2(32767);  v_p_fcreacion date;  v_p_ibloqueado number;  v_p_fultbloqueo date;  v_p_fultiniciosesion date;  v_p_fultcambpass date;  v_p_fultrecuppass date;  v_p_fultpassintfallido date;  v_p_npassintfallido number;  v_p_npassintfallidoacum number;  v_p_idseglogreg float;  v_p_xcedula varchar2(32767);  v_p_xnombres varchar2(32767);  v_p_xapellidos varchar2(32767);  v_p_xnombrecompleto varchar2(32767);  v_p_fnacimiento date;  v_p_xsexo varchar2(32767);  v_p_xnacionalidad varchar2(32767);  v_p_xestatura varchar2(32767);  v_p_xmedestatura varchar2(32767);  v_p_xpeso varchar2(32767);  v_p_xmedpeso varchar2(32767);  v_p_idcomunmanlocalid float;  v_p_idcomunmanestado float;  v_p_idcomunmanpais float;  v_p_idcomunmancont float;  v_p_xdireccion varchar2(32767);  v_p_idcomunmanlocalid2 float;  v_p_idcomunmanestado2 float;  iv_p_idcomunmanpais2 float;  iv_p_idcomunmancont2 float;  v_p_xdireccion2 varchar2(32767);  v_p_idcomunmanlocalid3 float;  v_p_idcomunmanestado3 float;  iv_p_idcomunmanpais3 float;  iv_p_idcomunmancont3 float;  v_p_xdireccion3 varchar2(32767);  v_p_idcomunmanlocalid4 float;  v_p_idcomunmanestado4 float;  iv_p_idcomunmanpais4 float;  iv_p_idcomunmancont4 float;  v_p_xdireccion4 varchar2(32767);  v_p_idcomunmanlocalid5 float;  v_p_idcomunmanestado5 float;  iv_p_idcomunmanpais5 float;  iv_p_idcomunmancont5 float;  v_p_xdireccion5 varchar2(32767);  v_p_xtelfhabitacion1 varchar2(32767);  v_p_xtelfhabitacion2 varchar2(32767);  v_p_xtelfhabitacion3 varchar2(32767);  v_p_xtelfhabitacion4 varchar2(32767);  v_p_xtelfhabitacion5 varchar2(32767);  v_p_xtelfmovil1 varchar2(32767);  v_p_xtelfmovil2 varchar2(32767);  v_p_xtelfmovil3 varchar2(32767);  v_p_xtelfmovil4 varchar2(32767);  v_p_xtelfmovil5 varchar2(32767);  v_p_xtelfoficina1 varchar2(32767);  v_p_xtelfoficina2 varchar2(32767);  v_p_xtelfoficina3 varchar2(32767);  v_p_xtelfoficina4 varchar2(32767);  v_p_xtelfoficina5 varchar2(32767);  v_p_xtelffax1 varchar2(32767);  v_p_xtelffax2 varchar2(32767);  v_p_xtelffax3 varchar2(32767);  v_p_xtelffax4 varchar2(32767);  v_p_xtelffax5 varchar2(32767);  v_p_xcorreoelectronico1 varchar2(32767);  v_p_xcorreoelectronico2 varchar2(32767);  v_p_xcorreoelectronico3 varchar2(32767);  v_p_xcorreoelectronico4 varchar2(32767);  v_p_xcorreoelectronico5 varchar2(32767);  v_p_xdireccionweb1 varchar2(32767);  v_p_xdireccionweb2 varchar2(32767);  v_p_xdireccionweb3 varchar2(32767);  v_p_xdireccionweb4 varchar2(32767);  v_p_xdireccionweb5 varchar2(32767);  v_p_xtwitter1 varchar2(32767);  v_p_xtwitter2 varchar2(32767);  v_p_xtwitter3 varchar2(32767);  v_p_xtwitter4 varchar2(32767);  v_p_xtwitter5 varchar2(32767);  v_p_xfacebook1 varchar2(32767);  v_p_xfacebook2 varchar2(32767);  v_p_xfacebook3 varchar2(32767);  v_p_xfacebook4 varchar2(32767);  v_p_xfacebook5 varchar2(32767); cv_1 sys_refcursor; cv_2 sys_refcursor;  cv_3 sys_refcursor;  cv_4 sys_refcursor;  cv_5 sys_refcursor;  cv_6 sys_refcursor;  cv_7 sys_refcursor;  cv_8 sys_refcursor;  cv_9 sys_refcursor;  cv_10 sys_refcursor;  cv_11 sys_refcursor;  cv_12 sys_refcursor;  cv_13 sys_refcursor;  cv_14 sys_refcursor;  cv_15 sys_refcursor;  cv_16 sys_refcursor;  cv_17 sys_refcursor;"
                Dim xsp As String = "begin sp_rnagregarusuario (:v_p_illamada,:v_p_idsegmanusuop,:v_p_xnombrecorto,:v_p_irespuesta ,:v_p_xmsjusuario ,:v_p_xmsjtecnico ,:v_p_coderrorlog ,:v_p_idsegmanusu  ,:v_p_idcomunmanpers,:v_p_idcomunmancom,:v_p_idcomunmandir,:v_p_idsegmanorg,:v_p_idsegmandep,:v_p_idsegmancarg,:v_p_xnombreusuario,:v_p_xcontrasena,:v_p_fcreacion,:v_p_ibloqueado,:v_p_fultbloqueo,:v_p_fultiniciosesion,:v_p_fultcambpass,:v_p_fultrecuppass,:v_p_fultpassintfallido,:v_p_npassintfallido,:v_p_npassintfallidoacum,:v_p_idseglogreg,:v_p_xcedula,:v_p_xnombres,:v_p_xapellidos,:v_p_xnombrecompleto,:v_p_fnacimiento,:v_p_xsexo,:v_p_xnacionalidad,:v_p_xestatura,:v_p_xmedestatura,:v_p_xpeso,:v_p_xmedpeso,:v_p_idcomunmanlocalid,:v_p_idcomunmanestado,:v_p_idcomunmanpais,:v_p_idcomunmancont,:v_p_xdireccion,:v_p_idcomunmanlocalid2,:v_p_idcomunmanestado2,:v_p_idcomunmanpais2,:v_p_idcomunmancont2,:v_p_xdireccion2,:v_p_idcomunmanlocalid3,:v_p_idcomunmanestado3,:v_p_idcomunmanpais3,:v_p_idcomunmancont3,:v_p_xdireccion3,:v_p_idcomunmanlocalid4,:v_p_idcomunmanestado4,:v_p_idcomunmanpais4,:v_p_idcomunmancont4,:v_p_xdireccion4,:v_p_idcomunmanlocalid5,:v_p_idcomunmanestado5,:v_p_idcomunmanpais5,:v_p_idcomunmancont5,:v_p_xdireccion5,:v_p_xtelfhabitacion1,:v_p_xtelfhabitacion2,:v_p_xtelfhabitacion3,:v_p_xtelfhabitacion4,:v_p_xtelfhabitacion5,:v_p_xtelfmovil1,:v_p_xtelfmovil2,:v_p_xtelfmovil3,:v_p_xtelfmovil4,:v_p_xtelfmovil5,:v_p_xtelfoficina1,:v_p_xtelfoficina2,:v_p_xtelfoficina3,:v_p_xtelfoficina4,:v_p_xtelfoficina5,:v_p_xtelffax1,:v_p_xtelffax2,:v_p_xtelffax3,:v_p_xtelffax4,:v_p_xtelffax5,:v_p_xcorreoelectronico1,:v_p_xcorreoelectronico2,:v_p_xcorreoelectronico3,:v_p_xcorreoelectronico4,:v_p_xcorreoelectronico5,:v_p_xdireccionweb1,:v_p_xdireccionweb2,:v_p_xdireccionweb3,:v_p_xdireccionweb4,:v_p_xdireccionweb5,:v_p_xtwitter1,:v_p_xtwitter2,:v_p_xtwitter3,:v_p_xtwitter4,:v_p_xtwitter5,:v_p_xfacebook1,:v_p_xfacebook2,:v_p_xfacebook3,:v_p_xfacebook4,:v_p_xfacebook5, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6, cv_7, cv_8, cv_9, cv_10, cv_11, cv_12, cv_13, cv_14, cv_15, cv_16, cv_17); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40, param41, param42, param43, param44, param45, param46, param47, param48, param49, param50, param51, param52, param53, param54, param55, param56, param57, param58, param59, param60, param61, param62, param63, param64, param65, param66, param67, param68, param69, param70, param71, param72, param73, param74, param75, param76, param77, param78, param79, param80, param81, param82, param83, param84, param85, param86, param87, param88, param89, param90, param91, param92, param93, param94, param95, param96, param97, param98, param99, param100, param101, param102)


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

        'Public Function AgregarUsu() As respopera
        <HttpPost()> _
        Public Function ModificarUsu(vi_segmanusu As vi_segmanusu) As respopera
            Try
                Dim respopera As New respopera
                If ConfigurationManager.AppSettings("motoddb") = "sql" Then
                    'Dim vi_segmanusu As New vi_segmanusu
                    'vi_segmanusu.idsegmanorg = 1
                    'vi_segmanusu.idsegmandep = 1
                    'vi_segmanusu.idsegmancarg = 7
                    'vi_segmanusu.xnombreusuario = "prueba@gmail.com"
                    'vi_segmanusu.xcontrasena = "1234567"
                    ''vi_segmanusu.fcreacion = Date.Now
                    'vi_segmanusu.ibloqueado = 0
                    ''vi_segmanusu.fultbloqueo = Date.Now
                    ''vi_segmanusu.fultiniciosesion = Date.Now
                    ''vi_segmanusu.fultcambpass = Date.Now
                    ''vi_segmanusu.fultrecuppass = Date.Now
                    ''vi_segmanusu.fultpassintfallido = Date.Now
                    'vi_segmanusu.npassintfallido = 0
                    'vi_segmanusu.npassintfallidoacum = 0
                    'vi_segmanusu.idseglogreg = 0
                    'vi_segmanusu.xcedula = "01234567"
                    'vi_segmanusu.xnombres = "VE"
                    'vi_segmanusu.xapellidos = "BS"
                    'vi_segmanusu.fnacimiento = "25/01/1986"
                    'vi_segmanusu.xsexo = "MASCULINO"
                    'vi_segmanusu.xnacionalidad = "LOCAL"
                    'vi_segmanusu.idcomunmanlocalid = 215
                    'vi_segmanusu.idcomunmanestado = 20
                    'vi_segmanusu.xtelfmovil1 = "416-9040694"
                    'vi_segmanusu.xtelfmovil2 = "416-3003989"
                    'vi_segmanusu.xcorreoelectronico1 = "vbolivar@prueba.net"
                    'vi_segmanusu.xtwitter1 = "@vbolivar"
                    'vi_segmanusu.xfacebook1 = "vbolivar"
                    '
                    Dim param1 As New SqlClient.SqlParameter
                    param1.SqlDbType = SqlDbType.VarChar
                    param1.Size = 20
                    param1.Value = "directo"
                    param1.ParameterName = "p_illamada"

                    Dim param2 As New SqlClient.SqlParameter
                    param2.SqlDbType = SqlDbType.Decimal
                    param2.Precision = 18
                    param2.Scale = 0
                    param2.Value = 0
                    param2.ParameterName = "p_idsegmanusuop"

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
                    param8.Value = vi_segmanusu.idsegmanusu
                    param8.ParameterName = "p_idsegmanusu"
                    param8.Direction = ParameterDirection.InputOutput
                    'If vi_segmanusu.idsegmanusu IsNot Nothing Then
                    'param8.Value = vi_segmanusu.idsegmanusu
                    'Else
                    '    param8.Value = 0
                    'End If

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    param9.Value = vi_segmanusu.idcomunmanpers
                    'param9.Value = vi_segmanusu.idcomunmanpers
                    param9.ParameterName = "p_idcomunmanpers"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    param10.Value = vi_segmanusu.idcomunmancom
                    'param10.Value = vi_segmanusu.idcomunmancom
                    param10.ParameterName = "p_idcomunmancom"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Decimal
                    param11.Precision = 18
                    param11.Scale = 0
                    param11.Value = vi_segmanusu.idcomunmandir
                    'param11.Value = vi_segmanusu.idcomunmandir
                    param11.ParameterName = "p_idcomunmandir"

                    Dim param12 As New SqlClient.SqlParameter
                    param12.SqlDbType = SqlDbType.Decimal
                    param12.Size = 18
                    param12.Scale = 0
                    'param12.Value = 0
                    If IsNothing(vi_segmanusu.idsegmanorg) Then
                        param12.Value = 0
                    Else
                        param12.Value = vi_segmanusu.idsegmanorg
                    End If
                    param12.ParameterName = "p_idsegmanorg"
                    'If vi_segmanusu.idsegmanorg IsNot Nothing Then
                    'param12.Value = vi_segmanusu.idsegmanorg
                    'Else
                    'param12.Value = 0
                    'End If

                    Dim param13 As New SqlClient.SqlParameter
                    param13.SqlDbType = SqlDbType.Decimal
                    param13.Precision = 18
                    param13.Scale = 0
                    'param13.Value = 0
                    If IsNothing(vi_segmanusu.idsegmandep) Then
                        param13.Value = 0
                    Else
                        param13.Value = vi_segmanusu.idsegmandep
                    End If
                    param13.ParameterName = "p_idsegmandep"
                    'If vi_mant_segmanusu.idsegmandep IsNot Nothing Then
                    'param13.Value = vi_segmanusu.idsegmandep
                    'Else
                    'param13.Value = 0
                    'End If

                    Dim param14 As New SqlClient.SqlParameter
                    param14.SqlDbType = SqlDbType.Decimal
                    param14.Precision = 18
                    param14.Scale = 0
                    param14.Value = vi_segmanusu.idsegmancarg
                    param14.ParameterName = "p_idsegmancarg"
                    'param14.Value = 0
                    'If vi_segmanusu.idsegmancarg IsNot Nothing Then
                    'Else
                    'param14.Value = 0
                    'End If

                    Dim param15 As New SqlClient.SqlParameter
                    param15.SqlDbType = SqlDbType.VarChar
                    param15.Size = 50
                    If vi_segmanusu.xnombreusuario IsNot Nothing Then
                        param15.Value = vi_segmanusu.xnombreusuario
                    Else
                        param15.Value = ""
                    End If
                    param15.ParameterName = "p_xnombreusuario"
                    '
                    'Dim gen_pass As New generador_password
                    'Dim password As String = Nothing
                    'Dim nchars As Integer = 10
                    ''
                    'password = gen_pass.obtener_password_nchars(nchars)
                    '
                    Dim param16 As New SqlClient.SqlParameter
                    param16.SqlDbType = SqlDbType.VarChar
                    param16.Size = 50
                    param16.Value = vi_segmanusu.xcontrasena
                    param16.ParameterName = "p_xcontrasena"
                    'If vi_segmanusu.xcontrasena IsNot Nothing Then
                    '    param16.Value = vi_segmanusu.xcontrasena
                    'Else
                    '    'param16.Value = ""
                    '    param16.Value = password
                    'End If

                    Dim param17 As New SqlClient.SqlParameter
                    param17.SqlDbType = SqlDbType.DateTime
                    If vi_segmanusu.fcreacion > CDate("01-01-1900") Then
                        param17.Value = vi_segmanusu.fcreacion
                    Else
                        param17.Value = CDate("01-01-1900")
                    End If
                    param17.ParameterName = "p_fcreacion"

                    Dim param18 As New SqlClient.SqlParameter
                    param18.SqlDbType = SqlDbType.Bit
                    param18.Value = vi_segmanusu.ibloqueado
                    param18.ParameterName = "p_ibloqueado"

                    Dim param19 As New SqlClient.SqlParameter
                    param19.SqlDbType = SqlDbType.DateTime
                    If vi_segmanusu.fultbloqueo > CDate("01-01-1900") Then
                        param19.Value = vi_segmanusu.fultbloqueo
                    Else
                        param19.Value = CDate("01-01-1900")
                    End If
                    param19.ParameterName = "p_fultbloqueo"

                    Dim param20 As New SqlClient.SqlParameter
                    param20.SqlDbType = SqlDbType.DateTime
                    If vi_segmanusu.fultiniciosesion > CDate("01-01-1900") Then
                        param20.Value = vi_segmanusu.fultiniciosesion
                    Else
                        param20.Value = CDate("01-01-1900")
                    End If
                    param20.ParameterName = "p_fultiniciosesion"

                    Dim param21 As New SqlClient.SqlParameter
                    param21.SqlDbType = SqlDbType.DateTime
                    If vi_segmanusu.fultcambpass > CDate("01-01-1900") Then
                        param21.Value = vi_segmanusu.fultcambpass
                    Else
                        param21.Value = CDate("01-01-1900")
                    End If
                    param21.ParameterName = "p_fultcambpass"

                    Dim param22 As New SqlClient.SqlParameter
                    param22.SqlDbType = SqlDbType.DateTime
                    If vi_segmanusu.fultrecuppass > CDate("01-01-1900") Then
                        param22.Value = vi_segmanusu.fultrecuppass
                    Else
                        param22.Value = CDate("01-01-1900")
                    End If
                    param22.ParameterName = "p_fultrecuppass"

                    Dim param23 As New SqlClient.SqlParameter
                    param23.SqlDbType = SqlDbType.DateTime
                    param23.Value = CDate("01-01-1900")
                    param23.ParameterName = "p_fultpassintfallido"
                    'If vi_segmanusu.fultpassintfallido > CDate("01-01-1900") Then
                    'param23.Value = vi_segmanusu.fultpassintfallido
                    'Else
                    'param23.Value = CDate("01-01-1900")
                    'End If
                    'param23.ParameterName = "p_fultpassintfallido"

                    Dim param24 As New SqlClient.SqlParameter
                    param24.SqlDbType = SqlDbType.BigInt
                    param24.Value = vi_segmanusu.npassintfallido
                    param24.ParameterName = "p_npassintfallido"

                    Dim param25 As New SqlClient.SqlParameter
                    param25.SqlDbType = SqlDbType.BigInt
                    param25.Value = vi_segmanusu.npassintfallidoacum
                    param25.ParameterName = "p_npassintfallidoacum"

                    Dim param26 As New SqlClient.SqlParameter
                    param26.SqlDbType = SqlDbType.Decimal
                    param26.Precision = 18
                    param26.Scale = 0
                    param26.Value = vi_segmanusu.idseglogreg
                    param26.ParameterName = "p_idseglogreg"

                    'campos de la tabla comunmanpers
                    Dim param27 As New SqlClient.SqlParameter
                    param27.SqlDbType = SqlDbType.VarChar
                    param27.Size = 20
                    If vi_segmanusu.xcedula IsNot Nothing Then
                        param27.Value = vi_segmanusu.xcedula
                    Else
                        param27.Value = ""
                    End If
                    param27.ParameterName = "p_xcedula"

                    Dim param28 As New SqlClient.SqlParameter
                    param28.SqlDbType = SqlDbType.VarChar
                    param28.Size = 50
                    param28.Value = vi_segmanusu.xnombres
                    param28.ParameterName = "p_xnombres"

                    Dim param29 As New SqlClient.SqlParameter
                    param29.SqlDbType = SqlDbType.VarChar
                    param29.Size = 50
                    param29.Value = vi_segmanusu.xapellidos
                    param29.ParameterName = "p_xapellidos"

                    Dim param30 As New SqlClient.SqlParameter
                    param30.SqlDbType = SqlDbType.VarChar
                    param30.Size = 100
                    If vi_segmanusu.xnombrecompleto IsNot Nothing Then
                        param30.Value = vi_segmanusu.xnombrecompleto
                    Else
                        param30.Value = vi_segmanusu.xnombres & " " & vi_segmanusu.xapellidos
                    End If
                    param30.ParameterName = "p_xnombrecompleto"

                    Dim param31 As New SqlClient.SqlParameter
                    param31.SqlDbType = SqlDbType.DateTime
                    If vi_segmanusu.fnacimiento > CDate("01-01-1900") Then
                        param31.Value = vi_segmanusu.fnacimiento
                    Else
                        param31.Value = CDate("01-01-1900")
                    End If
                    param31.ParameterName = "p_fnacimiento"

                    Dim param32 As New SqlClient.SqlParameter
                    param32.SqlDbType = SqlDbType.VarChar
                    param32.Size = 20
                    If vi_segmanusu.xsexo IsNot Nothing Then
                        param32.Value = vi_segmanusu.xsexo
                    Else
                        param32.Value = ""
                    End If
                    param32.ParameterName = "p_xsexo"

                    Dim param33 As New SqlClient.SqlParameter
                    param33.SqlDbType = SqlDbType.VarChar
                    param33.Size = 50
                    If vi_segmanusu.xsexo IsNot Nothing Then
                        param33.Value = vi_segmanusu.xnacionalidad
                    Else
                        param33.Value = ""
                    End If
                    param33.ParameterName = "p_xnacionalidad"

                    Dim param34 As New SqlClient.SqlParameter
                    param34.SqlDbType = SqlDbType.VarChar
                    param34.Size = 20
                    If vi_segmanusu.xestatura IsNot Nothing Then
                        param34.Value = vi_segmanusu.xestatura
                    Else
                        param34.Value = ""
                    End If
                    param34.ParameterName = "p_xestatura"

                    Dim param35 As New SqlClient.SqlParameter
                    param35.SqlDbType = SqlDbType.VarChar
                    param35.Size = 20
                    If vi_segmanusu.xestatura IsNot Nothing Then
                        param35.Value = vi_segmanusu.xmedestatura
                    Else
                        param35.Value = ""
                    End If
                    param35.ParameterName = "p_xmedestatura"

                    Dim param36 As New SqlClient.SqlParameter
                    param36.SqlDbType = SqlDbType.VarChar
                    param36.Size = 20
                    If vi_segmanusu.xpeso IsNot Nothing Then
                        param36.Value = vi_segmanusu.xpeso
                    Else
                        param36.Value = ""
                    End If
                    param36.ParameterName = "p_xpeso"

                    Dim param37 As New SqlClient.SqlParameter
                    param37.SqlDbType = SqlDbType.VarChar
                    param37.Size = 20
                    If vi_segmanusu.xpeso IsNot Nothing Then
                        param37.Value = vi_segmanusu.xmedpeso
                    Else
                        param37.Value = ""
                    End If
                    param37.ParameterName = "p_xmedpeso"

                    ''campos de la tabla comunmandir
                    Dim param38 As New SqlClient.SqlParameter
                    param38.SqlDbType = SqlDbType.Decimal
                    param38.Precision = 18
                    param38.Scale = 0
                    param38.Value = vi_segmanusu.idcomunmanlocalid
                    param38.ParameterName = "p_idcomunmanlocalid"

                    Dim param39 As New SqlClient.SqlParameter
                    param39.SqlDbType = SqlDbType.Decimal
                    param39.Precision = 18
                    param39.Scale = 0
                    param39.Value = vi_segmanusu.idcomunmanestado
                    param39.ParameterName = "p_idcomunmanestado"

                    Dim param40 As New SqlClient.SqlParameter
                    param40.SqlDbType = SqlDbType.Decimal
                    param40.Precision = 18
                    param40.Scale = 0
                    param40.Value = 9
                    param40.ParameterName = "p_idcomunmanpais"

                    Dim param41 As New SqlClient.SqlParameter
                    param41.SqlDbType = SqlDbType.Decimal
                    param41.Precision = 18
                    param41.Scale = 0
                    param41.Value = 1
                    param41.ParameterName = "p_idcomunmancont"

                    Dim param42 As New SqlClient.SqlParameter
                    param42.SqlDbType = SqlDbType.VarChar
                    param42.Size = 500
                    If vi_segmanusu.xdireccion IsNot Nothing Then
                        param42.Value = vi_segmanusu.xdireccion
                    Else
                        param42.Value = ""
                    End If
                    param42.ParameterName = "p_xdireccion"

                    Dim param43 As New SqlClient.SqlParameter
                    param43.SqlDbType = SqlDbType.Decimal
                    param43.Precision = 18
                    param43.Scale = 0
                    param43.Value = 0
                    'param43.Value = vi_segmanusu.idcomunmanlocalid2
                    param43.ParameterName = "p_idcomunmanlocalid2"

                    Dim param44 As New SqlClient.SqlParameter
                    param44.SqlDbType = SqlDbType.Decimal
                    param44.Precision = 18
                    param44.Scale = 0
                    param44.Value = 0
                    'param44.Value = vi_segmanusu.idcomunmanestado2
                    param44.ParameterName = "p_idcomunmanestado2"

                    Dim param45 As New SqlClient.SqlParameter
                    param45.SqlDbType = SqlDbType.Decimal
                    param45.Precision = 18
                    param45.Scale = 0
                    param45.Value = 9
                    param45.ParameterName = "p_idcomunmanpais2"

                    Dim param46 As New SqlClient.SqlParameter
                    param46.SqlDbType = SqlDbType.Decimal
                    param46.Precision = 18
                    param46.Scale = 0
                    param46.Value = 1
                    param46.ParameterName = "p_idcomunmancont2"

                    Dim param47 As New SqlClient.SqlParameter
                    param47.SqlDbType = SqlDbType.VarChar
                    param47.Size = 500
                    param47.Value = ""
                    param47.ParameterName = "p_xdireccion2"
                    'If vi_segmanusu.xdireccion2 IsNot Nothing Then
                    '    param47.Value = vi_segmanusu.xdireccion2
                    'Else
                    '    param47.Value = ""
                    'End If

                    Dim param48 As New SqlClient.SqlParameter
                    param48.SqlDbType = SqlDbType.Decimal
                    param48.Precision = 18
                    param48.Scale = 0
                    param48.Value = 0
                    param48.ParameterName = "p_idcomunmanlocalid3"

                    Dim param49 As New SqlClient.SqlParameter
                    param49.SqlDbType = SqlDbType.Decimal
                    param49.Precision = 18
                    param49.Scale = 0
                    param49.Value = 0
                    param49.ParameterName = "p_idcomunmanestado3"

                    Dim param50 As New SqlClient.SqlParameter
                    param50.SqlDbType = SqlDbType.Decimal
                    param50.Precision = 18
                    param50.Scale = 0
                    param50.Value = 0
                    param50.ParameterName = "p_idcomunmanpais3"

                    Dim param51 As New SqlClient.SqlParameter
                    param51.SqlDbType = SqlDbType.Decimal
                    param51.Precision = 18
                    param51.Scale = 0
                    param51.Value = 0
                    param51.ParameterName = "p_idcomunmancont3"

                    Dim param52 As New SqlClient.SqlParameter
                    param52.SqlDbType = SqlDbType.VarChar
                    param52.Size = 500
                    param52.Value = ""
                    param52.ParameterName = "p_xdireccion3"

                    Dim param53 As New SqlClient.SqlParameter
                    param53.SqlDbType = SqlDbType.Decimal
                    param53.Precision = 18
                    param53.Scale = 0
                    param53.Value = 0
                    param53.ParameterName = "p_idcomunmanlocalid4"

                    Dim param54 As New SqlClient.SqlParameter
                    param54.SqlDbType = SqlDbType.Decimal
                    param54.Precision = 18
                    param54.Scale = 0
                    param54.Value = 0
                    param54.ParameterName = "p_idcomunmanestado4"

                    Dim param55 As New SqlClient.SqlParameter
                    param55.SqlDbType = SqlDbType.Decimal
                    param55.Precision = 18
                    param55.Scale = 0
                    param55.Value = 0
                    param55.ParameterName = "p_idcomunmanpais4"

                    Dim param56 As New SqlClient.SqlParameter
                    param56.SqlDbType = SqlDbType.Decimal
                    param56.Precision = 18
                    param56.Scale = 0
                    param56.Value = 0
                    param56.ParameterName = "p_idcomunmancont4"

                    Dim param57 As New SqlClient.SqlParameter
                    param57.SqlDbType = SqlDbType.VarChar
                    param57.Size = 500
                    param57.Value = ""
                    param57.ParameterName = "p_xdireccion4"

                    Dim param58 As New SqlClient.SqlParameter
                    param58.SqlDbType = SqlDbType.Decimal
                    param58.Precision = 18
                    param58.Scale = 0
                    param58.Value = 0
                    param58.ParameterName = "p_idcomunmanlocalid5"

                    Dim param59 As New SqlClient.SqlParameter
                    param59.SqlDbType = SqlDbType.Decimal
                    param59.Precision = 18
                    param59.Scale = 0
                    param59.Value = 0
                    param59.ParameterName = "p_idcomunmanestado5"

                    Dim param60 As New SqlClient.SqlParameter
                    param60.SqlDbType = SqlDbType.Decimal
                    param60.Precision = 18
                    param60.Scale = 0
                    param60.Value = 0
                    param60.ParameterName = "p_idcomunmanpais5"

                    Dim param61 As New SqlClient.SqlParameter
                    param61.SqlDbType = SqlDbType.Decimal
                    param61.Precision = 18
                    param61.Scale = 0
                    param61.Value = 0
                    param61.ParameterName = "p_idcomunmancont5"

                    Dim param62 As New SqlClient.SqlParameter
                    param62.SqlDbType = SqlDbType.VarChar
                    param62.Size = 500
                    param62.Value = ""
                    param62.ParameterName = "p_xdireccion5"

                    'campos de la tabla comunmancom
                    Dim param63 As New SqlClient.SqlParameter
                    param63.SqlDbType = SqlDbType.VarChar
                    param63.Size = 20
                    param63.Value = ""
                    param63.ParameterName = "p_xtelfhabitacion1"

                    Dim param64 As New SqlClient.SqlParameter
                    param64.SqlDbType = SqlDbType.VarChar
                    param64.Size = 20
                    param64.Value = ""
                    param64.ParameterName = "p_xtelfhabitacion2"

                    Dim param65 As New SqlClient.SqlParameter
                    param65.SqlDbType = SqlDbType.VarChar
                    param65.Size = 20
                    param65.Value = ""
                    param65.ParameterName = "p_xtelfhabitacion3"

                    Dim param66 As New SqlClient.SqlParameter
                    param66.SqlDbType = SqlDbType.VarChar
                    param66.Size = 20
                    param66.Value = ""
                    param66.ParameterName = "p_xtelfhabitacion4"

                    Dim param67 As New SqlClient.SqlParameter
                    param67.SqlDbType = SqlDbType.VarChar
                    param67.Size = 20
                    param67.Value = ""
                    param67.ParameterName = "p_xtelfhabitacion5"
                    'estoy aqui
                    Dim param68 As New SqlClient.SqlParameter
                    param68.SqlDbType = SqlDbType.VarChar
                    param68.Size = 20
                    'param68.Value = ""
                    If vi_segmanusu.xtelfmovil1 IsNot Nothing Then
                        param68.Value = vi_segmanusu.xtelfmovil1
                    Else
                        param68.Value = ""
                    End If
                    param68.ParameterName = "p_xtelfmovil1"

                    Dim param69 As New SqlClient.SqlParameter
                    param69.SqlDbType = SqlDbType.VarChar
                    param69.Size = 20
                    'param69.Value = ""
                    If vi_segmanusu.xtelfmovil2 IsNot Nothing Then
                        param69.Value = vi_segmanusu.xtelfmovil2
                    Else
                        param69.Value = ""
                    End If
                    param69.ParameterName = "p_xtelfmovil2"

                    Dim param70 As New SqlClient.SqlParameter
                    param70.SqlDbType = SqlDbType.VarChar
                    param70.Size = 20
                    param70.Value = ""
                    param70.ParameterName = "p_xtelfmovil3"

                    Dim param71 As New SqlClient.SqlParameter
                    param71.SqlDbType = SqlDbType.VarChar
                    param71.Size = 20
                    param71.Value = ""
                    param71.ParameterName = "p_xtelfmovil4"

                    Dim param72 As New SqlClient.SqlParameter
                    param72.SqlDbType = SqlDbType.VarChar
                    param72.Size = 20
                    param72.Value = ""
                    param72.ParameterName = "p_xtelfmovil5"

                    Dim param73 As New SqlClient.SqlParameter
                    param73.SqlDbType = SqlDbType.VarChar
                    param73.Size = 20
                    If vi_segmanusu.xtelfoficina1 IsNot Nothing Then
                        param73.Value = vi_segmanusu.xtelfoficina1
                    Else
                        param73.Value = ""
                    End If
                    param73.ParameterName = "p_xtelfoficina1"

                    Dim param74 As New SqlClient.SqlParameter
                    param74.SqlDbType = SqlDbType.VarChar
                    param74.Size = 20
                    If vi_segmanusu.xtelfoficina2 IsNot Nothing Then
                        param74.Value = vi_segmanusu.xtelfoficina2
                    Else
                        param74.Value = ""
                    End If
                    param74.ParameterName = "p_xtelfoficina2"

                    Dim param75 As New SqlClient.SqlParameter
                    param75.SqlDbType = SqlDbType.VarChar
                    param75.Size = 20
                    param75.Value = ""
                    param75.ParameterName = "p_xtelfoficina3"

                    Dim param76 As New SqlClient.SqlParameter
                    param76.SqlDbType = SqlDbType.VarChar
                    param76.Size = 20
                    param76.Value = ""
                    param76.ParameterName = "p_xtelfoficina4"

                    Dim param77 As New SqlClient.SqlParameter
                    param77.SqlDbType = SqlDbType.VarChar
                    param77.Size = 20
                    param77.Value = ""
                    param77.ParameterName = "p_xtelfoficina5"

                    Dim param78 As New SqlClient.SqlParameter
                    param78.SqlDbType = SqlDbType.VarChar
                    param78.Size = 20
                    param78.Value = ""
                    param78.ParameterName = "p_xtelffax1"
                    'If vi_segmanusu.xtelffax1 IsNot Nothing Then
                    'param78.Value = vi_segmanusu.xtelffax1
                    'Else
                    'param78.Value = ""
                    'End If

                    Dim param79 As New SqlClient.SqlParameter
                    param79.SqlDbType = SqlDbType.VarChar
                    param79.Size = 20
                    param79.Value = ""
                    param79.ParameterName = "p_xtelffax2"
                    'If vi_segmanusu.xtelffax2 IsNot Nothing Then
                    '    param79.Value = vi_segmanusu.xtelffax2
                    'Else
                    '    param79.Value = ""
                    'End If

                    Dim param80 As New SqlClient.SqlParameter
                    param80.SqlDbType = SqlDbType.VarChar
                    param80.Size = 20
                    param80.Value = ""
                    param80.ParameterName = "p_xtelffax3"

                    Dim param81 As New SqlClient.SqlParameter
                    param81.SqlDbType = SqlDbType.VarChar
                    param81.Size = 20
                    param81.Value = ""
                    param81.ParameterName = "p_xtelffax4"

                    Dim param82 As New SqlClient.SqlParameter
                    param82.SqlDbType = SqlDbType.VarChar
                    param82.Size = 20
                    param82.Value = ""
                    param82.ParameterName = "p_xtelffax5"

                    Dim param83 As New SqlClient.SqlParameter
                    param83.SqlDbType = SqlDbType.VarChar
                    param83.Size = 50
                    If vi_segmanusu.xcorreoelectronico1 IsNot Nothing Then
                        param83.Value = vi_segmanusu.xcorreoelectronico1
                    Else
                        param83.Value = ""
                    End If
                    param83.ParameterName = "p_xcorreoelectronico1"

                    Dim param84 As New SqlClient.SqlParameter
                    param84.SqlDbType = SqlDbType.VarChar
                    param84.Size = 50
                    If vi_segmanusu.xcorreoelectronico2 IsNot Nothing Then
                        param84.Value = vi_segmanusu.xcorreoelectronico2
                    Else
                        param84.Value = ""
                    End If
                    param84.ParameterName = "p_xcorreoelectronico2"

                    Dim param85 As New SqlClient.SqlParameter
                    param85.SqlDbType = SqlDbType.VarChar
                    param85.Size = 50
                    param85.Value = ""
                    param85.ParameterName = "p_xcorreoelectronico3"

                    Dim param86 As New SqlClient.SqlParameter
                    param86.SqlDbType = SqlDbType.VarChar
                    param86.Size = 50
                    param86.Value = ""
                    param86.ParameterName = "p_xcorreoelectronico4"

                    Dim param87 As New SqlClient.SqlParameter
                    param87.SqlDbType = SqlDbType.VarChar
                    param87.Size = 50
                    param87.Value = ""
                    param87.ParameterName = "p_xcorreoelectronico5"

                    Dim param88 As New SqlClient.SqlParameter
                    param88.SqlDbType = SqlDbType.VarChar
                    param88.Size = 50
                    param88.Value = ""
                    param88.ParameterName = "p_xdireccionweb1"
                    'If vi_segmanusu.xdireccionweb1 IsNot Nothing Then
                    '    param88.Value = vi_segmanusu.xdireccionweb1
                    'Else
                    '    param88.Value = ""
                    'End If

                    Dim param89 As New SqlClient.SqlParameter
                    param89.SqlDbType = SqlDbType.VarChar
                    param89.Size = 50
                    param89.Value = ""
                    param89.ParameterName = "p_xdireccionweb2"
                    'If vi_segmanusu.xdireccionweb2 IsNot Nothing Then
                    '    param89.Value = vi_segmanusu.xdireccionweb2
                    'Else
                    '    param89.Value = ""
                    'End If

                    Dim param90 As New SqlClient.SqlParameter
                    param90.SqlDbType = SqlDbType.VarChar
                    param90.Size = 50
                    param90.Value = ""
                    param90.ParameterName = "p_xdireccionweb3"

                    Dim param91 As New SqlClient.SqlParameter
                    param91.SqlDbType = SqlDbType.VarChar
                    param91.Size = 50
                    param91.Value = ""
                    param91.ParameterName = "p_xdireccionweb4"

                    Dim param92 As New SqlClient.SqlParameter
                    param92.SqlDbType = SqlDbType.VarChar
                    param92.Size = 50
                    param92.Value = ""
                    param92.ParameterName = "p_xdireccionweb5"

                    Dim param93 As New SqlClient.SqlParameter
                    param93.SqlDbType = SqlDbType.VarChar
                    param93.Size = 200
                    If vi_segmanusu.xtwitter1 IsNot Nothing Then
                        param93.Value = vi_segmanusu.xtwitter1
                    Else
                        param93.Value = ""
                    End If
                    param93.ParameterName = "p_xtwitter1"

                    Dim param94 As New SqlClient.SqlParameter
                    param94.SqlDbType = SqlDbType.VarChar
                    param94.Size = 200
                    param94.Value = ""
                    param94.ParameterName = "p_xtwitter2"

                    Dim param95 As New SqlClient.SqlParameter
                    param95.SqlDbType = SqlDbType.VarChar
                    param95.Size = 200
                    param95.Value = ""
                    param95.ParameterName = "p_xtwitter3"

                    Dim param96 As New SqlClient.SqlParameter
                    param96.SqlDbType = SqlDbType.VarChar
                    param96.Size = 200
                    param96.Value = ""
                    param96.ParameterName = "p_xtwitter4"

                    Dim param97 As New SqlClient.SqlParameter
                    param97.SqlDbType = SqlDbType.VarChar
                    param97.Size = 200
                    param97.Value = ""
                    param97.ParameterName = "p_xtwitter5"

                    Dim param98 As New SqlClient.SqlParameter
                    param98.SqlDbType = SqlDbType.VarChar
                    param98.Size = 200
                    If vi_segmanusu.xfacebook1 IsNot Nothing Then
                        param98.Value = vi_segmanusu.xfacebook1
                    Else
                        param98.Value = ""
                    End If
                    param98.ParameterName = "p_xfacebook1"

                    Dim param99 As New SqlClient.SqlParameter
                    param99.SqlDbType = SqlDbType.VarChar
                    param99.Size = 200
                    param99.Value = ""
                    param99.ParameterName = "p_xfacebook2"

                    Dim param100 As New SqlClient.SqlParameter
                    param100.SqlDbType = SqlDbType.VarChar
                    param100.Size = 200
                    param100.Value = ""
                    param100.ParameterName = "p_xfacebook3"

                    Dim param101 As New SqlClient.SqlParameter
                    param101.SqlDbType = SqlDbType.VarChar
                    param101.Size = 200
                    param101.Value = ""
                    param101.ParameterName = "p_xfacebook4"

                    Dim param102 As New SqlClient.SqlParameter
                    param102.SqlDbType = SqlDbType.VarChar
                    param102.Size = 200
                    param102.Value = ""
                    param102.ParameterName = "p_xfacebook5"

                    ''campos agregados despues de crear el metodo
                    ''comunmanpers

                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_rnmodificarusuario @p_illamada,@p_idsegmanusuop,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanusu output,@p_idcomunmanpers,@p_idcomunmancom,@p_idcomunmandir,@p_idsegmanorg,@p_idsegmandep,@p_idsegmancarg,@p_xnombreusuario,@p_xcontrasena,@p_fcreacion,@p_ibloqueado,@p_fultbloqueo,@p_fultiniciosesion,@p_fultcambpass,@p_fultrecuppass,@p_fultpassintfallido,@p_npassintfallido,@p_npassintfallidoacum,@p_idseglogreg,@p_xcedula,@p_xnombres,@p_xapellidos,@p_xnombrecompleto,@p_fnacimiento,@p_xsexo,@p_xnacionalidad,@p_xestatura,@p_xmedestatura,@p_xpeso,@p_xmedpeso,@p_idcomunmanlocalid,@p_idcomunmanestado,@p_idcomunmanpais,@p_idcomunmancont,@p_xdireccion,@p_idcomunmanlocalid2,@p_idcomunmanestado2,@p_idcomunmanpais2,@p_idcomunmancont2,@p_xdireccion2,@p_idcomunmanlocalid3,@p_idcomunmanestado3,@p_idcomunmanpais3,@p_idcomunmancont3,@p_xdireccion3,@p_idcomunmanlocalid4,@p_idcomunmanestado4,@p_idcomunmanpais4,@p_idcomunmancont4,@p_xdireccion4,@p_idcomunmanlocalid5,@p_idcomunmanestado5,@p_idcomunmanpais5,@p_idcomunmancont5,@p_xdireccion5,@p_xtelfhabitacion1,@p_xtelfhabitacion2,@p_xtelfhabitacion3,@p_xtelfhabitacion4,@p_xtelfhabitacion5,@p_xtelfmovil1,@p_xtelfmovil2,@p_xtelfmovil3,@p_xtelfmovil4,@p_xtelfmovil5,@p_xtelfoficina1,@p_xtelfoficina2,@p_xtelfoficina3,@p_xtelfoficina4,@p_xtelfoficina5,@p_xtelffax1,@p_xtelffax2,@p_xtelffax3,@p_xtelffax4,@p_xtelffax5,@p_xcorreoelectronico1,@p_xcorreoelectronico2,@p_xcorreoelectronico3,@p_xcorreoelectronico4,@p_xcorreoelectronico5,@p_xdireccionweb1,@p_xdireccionweb2,@p_xdireccionweb3,@p_xdireccionweb4,@p_xdireccionweb5,@p_xtwitter1,@p_xtwitter2,@p_xtwitter3,@p_xtwitter4,@p_xtwitter5,@p_xfacebook1,@p_xfacebook2,@p_xfacebook3,@p_xfacebook4,@p_xfacebook5", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40, param41, param42, param43, param44, param45, param46, param47, param48, param49, param50, param51, param52, param53, param54, param55, param56, param57, param58, param59, param60, param61, param62, param63, param64, param65, param66, param67, param68, param69, param70, param71, param72, param73, param74, param75, param76, param77, param78, param79, param80, param81, param82, param83, param84, param85, param86, param87, param88, param89, param90, param91, param92, param93, param94, param95, param96, param97, param98, param99, param100, param101, param102)

                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    If IsNumeric(param8.Value) = True Then
                        respopera.id = Int(param8.Value)
                    End If
                Else
                    respopera = ModificarUsuOracle(vi_segmanusu)
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
        Public Function ModificarUsuOracle(vi_segmanusu As vi_segmanusu) As respopera
            Try
                '
                Dim param1 As New Client.OracleParameter
                param1.OracleDbType = Client.OracleDbType.Varchar2
                param1.Size = 20
                param1.Value = "directo"
                param1.ParameterName = "p_illamada"

                Dim param2 As New Client.OracleParameter
                param2.OracleDbType = Client.OracleDbType.Decimal
                param2.Precision = 18
                param2.Scale = 0
                param2.Value = 0
                param2.ParameterName = "p_idsegmanusuop"

                Dim param3 As New Client.OracleParameter
                param3.OracleDbType = Client.OracleDbType.Varchar2
                param3.Size = 20
                param3.Value = "seginsoft"
                param3.ParameterName = "p_xnombrecorto"

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
                param8.Value = vi_segmanusu.idsegmanusu
                param8.ParameterName = "p_idsegmanusu"
                param8.Direction = ParameterDirection.InputOutput
                'If vi_segmanusu.idsegmanusu IsNot Nothing Then
                'param8.Value = vi_segmanusu.idsegmanusu
                'Else
                '    param8.Value = 0
                'End If

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                param9.Value = vi_segmanusu.idcomunmanpers
                'param9.Value = vi_segmanusu.idcomunmanpers
                param9.ParameterName = "p_idcomunmanpers"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                param10.Value = vi_segmanusu.idcomunmancom
                'param10.Value = vi_segmanusu.idcomunmancom
                param10.ParameterName = "p_idcomunmancom"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = vi_segmanusu.idcomunmandir
                'param11.Value = vi_segmanusu.idcomunmandir
                param11.ParameterName = "p_idcomunmandir"

                Dim param12 As New Client.OracleParameter
                param12.OracleDbType = Client.OracleDbType.Decimal
                param12.Size = 18
                param12.Scale = 0
                'param12.Value = 0
                If IsNothing(vi_segmanusu.idsegmanorg) Then
                    param12.Value = 0
                Else
                    param12.Value = vi_segmanusu.idsegmanorg
                End If
                param12.ParameterName = "p_idsegmanorg"
                'If vi_segmanusu.idsegmanorg IsNot Nothing Then
                'param12.Value = vi_segmanusu.idsegmanorg
                'Else
                'param12.Value = 0
                'End If

                Dim param13 As New Client.OracleParameter
                param13.OracleDbType = Client.OracleDbType.Decimal
                param13.Precision = 18
                param13.Scale = 0
                'param13.Value = 0
                If IsNothing(vi_segmanusu.idsegmandep) Then
                    param13.Value = 0
                Else
                    param13.Value = vi_segmanusu.idsegmandep
                End If
                param13.ParameterName = "p_idsegmandep"
                'If vi_mant_segmanusu.idsegmandep IsNot Nothing Then
                'param13.Value = vi_segmanusu.idsegmandep
                'Else
                'param13.Value = 0
                'End If

                Dim param14 As New Client.OracleParameter
                param14.OracleDbType = Client.OracleDbType.Decimal
                param14.Precision = 18
                param14.Scale = 0
                param14.Value = vi_segmanusu.idsegmancarg
                param14.ParameterName = "p_idsegmancarg"
                'param14.Value = 0
                'If vi_segmanusu.idsegmancarg IsNot Nothing Then
                'Else
                'param14.Value = 0
                'End If

                Dim param15 As New Client.OracleParameter
                param15.OracleDbType = Client.OracleDbType.Varchar2
                param15.Size = 50
                If vi_segmanusu.xnombreusuario IsNot Nothing Then
                    param15.Value = vi_segmanusu.xnombreusuario
                Else
                    param15.Value = " "
                End If
                param15.ParameterName = "p_xnombreusuario"
                '
                'Dim gen_pass As New generador_password
                'Dim password As String = Nothing
                'Dim nchars As Integer = 10
                ''
                'password = gen_pass.obtener_password_nchars(nchars)
                '
                Dim param16 As New Client.OracleParameter
                param16.OracleDbType = Client.OracleDbType.Varchar2
                param16.Size = 50
                param16.Value = vi_segmanusu.xcontrasena
                param16.ParameterName = "p_xcontrasena"
                'If vi_segmanusu.xcontrasena IsNot Nothing Then
                '    param16.Value = vi_segmanusu.xcontrasena
                'Else
                '    'param16.Value = " "
                '    param16.Value = password
                'End If

                Dim param17 As New Client.OracleParameter
                param17.OracleDbType = Client.OracleDbType.Date
                If vi_segmanusu.fcreacion > CDate("01-01-1900") Then
                    param17.Value = vi_segmanusu.fcreacion
                Else
                    param17.Value = CDate("01-01-1900")
                End If
                param17.ParameterName = "p_fcreacion"

                Dim param18 As New Client.OracleParameter
                param18.OracleDbType = Client.OracleDbType.Int16
                param18.Value = vi_segmanusu.ibloqueado
                param18.ParameterName = "p_ibloqueado"

                Dim param19 As New Client.OracleParameter
                param19.OracleDbType = Client.OracleDbType.Date
                If vi_segmanusu.fultbloqueo > CDate("01-01-1900") Then
                    param19.Value = vi_segmanusu.fultbloqueo
                Else
                    param19.Value = CDate("01-01-1900")
                End If
                param19.ParameterName = "p_fultbloqueo"

                Dim param20 As New Client.OracleParameter
                param20.OracleDbType = Client.OracleDbType.Date
                If vi_segmanusu.fultiniciosesion > CDate("01-01-1900") Then
                    param20.Value = vi_segmanusu.fultiniciosesion
                Else
                    param20.Value = CDate("01-01-1900")
                End If
                param20.ParameterName = "p_fultiniciosesion"

                Dim param21 As New Client.OracleParameter
                param21.OracleDbType = Client.OracleDbType.Date
                If vi_segmanusu.fultcambpass > CDate("01-01-1900") Then
                    param21.Value = vi_segmanusu.fultcambpass
                Else
                    param21.Value = CDate("01-01-1900")
                End If
                param21.ParameterName = "p_fultcambpass"

                Dim param22 As New Client.OracleParameter
                param22.OracleDbType = Client.OracleDbType.Date
                If vi_segmanusu.fultrecuppass > CDate("01-01-1900") Then
                    param22.Value = vi_segmanusu.fultrecuppass
                Else
                    param22.Value = CDate("01-01-1900")
                End If
                param22.ParameterName = "p_fultrecuppass"

                Dim param23 As New Client.OracleParameter
                param23.OracleDbType = Client.OracleDbType.Date
                param23.Value = CDate("01-01-1900")
                param23.ParameterName = "p_fultpassintfallido"
                'If vi_segmanusu.fultpassintfallido > CDate("01-01-1900") Then
                'param23.Value = vi_segmanusu.fultpassintfallido
                'Else
                'param23.Value = CDate("01-01-1900")
                'End If
                'param23.ParameterName = "p_fultpassintfallido"

                Dim param24 As New Client.OracleParameter
                param24.OracleDbType = Client.OracleDbType.Long
                param24.Value = vi_segmanusu.npassintfallido
                param24.ParameterName = "p_npassintfallido"

                Dim param25 As New Client.OracleParameter
                param25.OracleDbType = Client.OracleDbType.Long
                param25.Value = vi_segmanusu.npassintfallidoacum
                param25.ParameterName = "p_npassintfallidoacum"

                Dim param26 As New Client.OracleParameter
                param26.OracleDbType = Client.OracleDbType.Decimal
                param26.Precision = 18
                param26.Scale = 0
                param26.Value = vi_segmanusu.idseglogreg
                param26.ParameterName = "p_idseglogreg"

                'campos de la tabla comunmanpers
                Dim param27 As New Client.OracleParameter
                param27.OracleDbType = Client.OracleDbType.Varchar2
                param27.Size = 20
                If vi_segmanusu.xcedula IsNot Nothing Then
                    param27.Value = vi_segmanusu.xcedula
                Else
                    param27.Value = " "
                End If
                param27.ParameterName = "p_xcedula"

                Dim param28 As New Client.OracleParameter
                param28.OracleDbType = Client.OracleDbType.Varchar2
                param28.Size = 50
                param28.Value = vi_segmanusu.xnombres
                param28.ParameterName = "p_xnombres"

                Dim param29 As New Client.OracleParameter
                param29.OracleDbType = Client.OracleDbType.Varchar2
                param29.Size = 50
                param29.Value = vi_segmanusu.xapellidos
                param29.ParameterName = "p_xapellidos"

                Dim param30 As New Client.OracleParameter
                param30.OracleDbType = Client.OracleDbType.Varchar2
                param30.Size = 100
                If vi_segmanusu.xnombrecompleto IsNot Nothing Then
                    param30.Value = vi_segmanusu.xnombrecompleto
                Else
                    param30.Value = vi_segmanusu.xnombres & " " & vi_segmanusu.xapellidos
                End If
                param30.ParameterName = "p_xnombrecompleto"

                Dim param31 As New Client.OracleParameter
                param31.OracleDbType = Client.OracleDbType.Date
                If vi_segmanusu.fnacimiento > CDate("01-01-1900") Then
                    param31.Value = vi_segmanusu.fnacimiento
                Else
                    param31.Value = CDate("01-01-1900")
                End If
                param31.ParameterName = "p_fnacimiento"

                Dim param32 As New Client.OracleParameter
                param32.OracleDbType = Client.OracleDbType.Varchar2
                param32.Size = 20
                If vi_segmanusu.xsexo IsNot Nothing Then
                    param32.Value = vi_segmanusu.xsexo
                Else
                    param32.Value = " "
                End If
                param32.ParameterName = "p_xsexo"

                Dim param33 As New Client.OracleParameter
                param33.OracleDbType = Client.OracleDbType.Varchar2
                param33.Size = 50
                If vi_segmanusu.xsexo IsNot Nothing Then
                    param33.Value = vi_segmanusu.xnacionalidad
                Else
                    param33.Value = " "
                End If
                param33.ParameterName = "p_xnacionalidad"

                Dim param34 As New Client.OracleParameter
                param34.OracleDbType = Client.OracleDbType.Varchar2
                param34.Size = 20
                If vi_segmanusu.xestatura IsNot Nothing Then
                    param34.Value = vi_segmanusu.xestatura
                Else
                    param34.Value = " "
                End If
                param34.ParameterName = "p_xestatura"

                Dim param35 As New Client.OracleParameter
                param35.OracleDbType = Client.OracleDbType.Varchar2
                param35.Size = 20
                If vi_segmanusu.xestatura IsNot Nothing Then
                    param35.Value = vi_segmanusu.xmedestatura
                Else
                    param35.Value = " "
                End If
                param35.ParameterName = "p_xmedestatura"

                Dim param36 As New Client.OracleParameter
                param36.OracleDbType = Client.OracleDbType.Varchar2
                param36.Size = 20
                If vi_segmanusu.xpeso IsNot Nothing Then
                    param36.Value = vi_segmanusu.xpeso
                Else
                    param36.Value = " "
                End If
                param36.ParameterName = "p_xpeso"

                Dim param37 As New Client.OracleParameter
                param37.OracleDbType = Client.OracleDbType.Varchar2
                param37.Size = 20
                If vi_segmanusu.xpeso IsNot Nothing Then
                    param37.Value = vi_segmanusu.xmedpeso
                Else
                    param37.Value = " "
                End If
                param37.ParameterName = "p_xmedpeso"

                ''campos de la tabla comunmandir
                Dim param38 As New Client.OracleParameter
                param38.OracleDbType = Client.OracleDbType.Decimal
                param38.Precision = 18
                param38.Scale = 0
                param38.Value = vi_segmanusu.idcomunmanlocalid
                param38.ParameterName = "p_idcomunmanlocalid"

                Dim param39 As New Client.OracleParameter
                param39.OracleDbType = Client.OracleDbType.Decimal
                param39.Precision = 18
                param39.Scale = 0
                param39.Value = vi_segmanusu.idcomunmanestado
                param39.ParameterName = "p_idcomunmanestado"

                Dim param40 As New Client.OracleParameter
                param40.OracleDbType = Client.OracleDbType.Decimal
                param40.Precision = 18
                param40.Scale = 0
                param40.Value = 9
                param40.ParameterName = "p_idcomunmanpais"

                Dim param41 As New Client.OracleParameter
                param41.OracleDbType = Client.OracleDbType.Decimal
                param41.Precision = 18
                param41.Scale = 0
                param41.Value = 1
                param41.ParameterName = "p_idcomunmancont"

                Dim param42 As New Client.OracleParameter
                param42.OracleDbType = Client.OracleDbType.Varchar2
                param42.Size = 500
                If vi_segmanusu.xdireccion IsNot Nothing Then
                    param42.Value = vi_segmanusu.xdireccion
                Else
                    param42.Value = " "
                End If
                param42.ParameterName = "p_xdireccion"

                Dim param43 As New Client.OracleParameter
                param43.OracleDbType = Client.OracleDbType.Decimal
                param43.Precision = 18
                param43.Scale = 0
                param43.Value = 0
                'param43.Value = vi_segmanusu.idcomunmanlocalid2
                param43.ParameterName = "p_idcomunmanlocalid2"

                Dim param44 As New Client.OracleParameter
                param44.OracleDbType = Client.OracleDbType.Decimal
                param44.Precision = 18
                param44.Scale = 0
                param44.Value = 0
                'param44.Value = vi_segmanusu.idcomunmanestado2
                param44.ParameterName = "p_idcomunmanestado2"

                Dim param45 As New Client.OracleParameter
                param45.OracleDbType = Client.OracleDbType.Decimal
                param45.Precision = 18
                param45.Scale = 0
                param45.Value = 9
                param45.ParameterName = "p_idcomunmanpais2"

                Dim param46 As New Client.OracleParameter
                param46.OracleDbType = Client.OracleDbType.Decimal
                param46.Precision = 18
                param46.Scale = 0
                param46.Value = 1
                param46.ParameterName = "p_idcomunmancont2"

                Dim param47 As New Client.OracleParameter
                param47.OracleDbType = Client.OracleDbType.Varchar2
                param47.Size = 500
                param47.Value = " "
                param47.ParameterName = "p_xdireccion2"
                'If vi_segmanusu.xdireccion2 IsNot Nothing Then
                '    param47.Value = vi_segmanusu.xdireccion2
                'Else
                '    param47.Value = " "
                'End If

                Dim param48 As New Client.OracleParameter
                param48.OracleDbType = Client.OracleDbType.Decimal
                param48.Precision = 18
                param48.Scale = 0
                param48.Value = 0
                param48.ParameterName = "p_idcomunmanlocalid3"

                Dim param49 As New Client.OracleParameter
                param49.OracleDbType = Client.OracleDbType.Decimal
                param49.Precision = 18
                param49.Scale = 0
                param49.Value = 0
                param49.ParameterName = "p_idcomunmanestado3"

                Dim param50 As New Client.OracleParameter
                param50.OracleDbType = Client.OracleDbType.Decimal
                param50.Precision = 18
                param50.Scale = 0
                param50.Value = 0
                param50.ParameterName = "p_idcomunmanpais3"

                Dim param51 As New Client.OracleParameter
                param51.OracleDbType = Client.OracleDbType.Decimal
                param51.Precision = 18
                param51.Scale = 0
                param51.Value = 0
                param51.ParameterName = "p_idcomunmancont3"

                Dim param52 As New Client.OracleParameter
                param52.OracleDbType = Client.OracleDbType.Varchar2
                param52.Size = 500
                param52.Value = " "
                param52.ParameterName = "p_xdireccion3"

                Dim param53 As New Client.OracleParameter
                param53.OracleDbType = Client.OracleDbType.Decimal
                param53.Precision = 18
                param53.Scale = 0
                param53.Value = 0
                param53.ParameterName = "p_idcomunmanlocalid4"

                Dim param54 As New Client.OracleParameter
                param54.OracleDbType = Client.OracleDbType.Decimal
                param54.Precision = 18
                param54.Scale = 0
                param54.Value = 0
                param54.ParameterName = "p_idcomunmanestado4"

                Dim param55 As New Client.OracleParameter
                param55.OracleDbType = Client.OracleDbType.Decimal
                param55.Precision = 18
                param55.Scale = 0
                param55.Value = 0
                param55.ParameterName = "p_idcomunmanpais4"

                Dim param56 As New Client.OracleParameter
                param56.OracleDbType = Client.OracleDbType.Decimal
                param56.Precision = 18
                param56.Scale = 0
                param56.Value = 0
                param56.ParameterName = "p_idcomunmancont4"

                Dim param57 As New Client.OracleParameter
                param57.OracleDbType = Client.OracleDbType.Varchar2
                param57.Size = 500
                param57.Value = " "
                param57.ParameterName = "p_xdireccion4"

                Dim param58 As New Client.OracleParameter
                param58.OracleDbType = Client.OracleDbType.Decimal
                param58.Precision = 18
                param58.Scale = 0
                param58.Value = 0
                param58.ParameterName = "p_idcomunmanlocalid5"

                Dim param59 As New Client.OracleParameter
                param59.OracleDbType = Client.OracleDbType.Decimal
                param59.Precision = 18
                param59.Scale = 0
                param59.Value = 0
                param59.ParameterName = "p_idcomunmanestado5"

                Dim param60 As New Client.OracleParameter
                param60.OracleDbType = Client.OracleDbType.Decimal
                param60.Precision = 18
                param60.Scale = 0
                param60.Value = 0
                param60.ParameterName = "p_idcomunmanpais5"

                Dim param61 As New Client.OracleParameter
                param61.OracleDbType = Client.OracleDbType.Decimal
                param61.Precision = 18
                param61.Scale = 0
                param61.Value = 0
                param61.ParameterName = "p_idcomunmancont5"

                Dim param62 As New Client.OracleParameter
                param62.OracleDbType = Client.OracleDbType.Varchar2
                param62.Size = 500
                param62.Value = " "
                param62.ParameterName = "p_xdireccion5"

                'campos de la tabla comunmancom
                Dim param63 As New Client.OracleParameter
                param63.OracleDbType = Client.OracleDbType.Varchar2
                param63.Size = 20
                param63.Value = " "
                param63.ParameterName = "p_xtelfhabitacion1"

                Dim param64 As New Client.OracleParameter
                param64.OracleDbType = Client.OracleDbType.Varchar2
                param64.Size = 20
                param64.Value = " "
                param64.ParameterName = "p_xtelfhabitacion2"

                Dim param65 As New Client.OracleParameter
                param65.OracleDbType = Client.OracleDbType.Varchar2
                param65.Size = 20
                param65.Value = " "
                param65.ParameterName = "p_xtelfhabitacion3"

                Dim param66 As New Client.OracleParameter
                param66.OracleDbType = Client.OracleDbType.Varchar2
                param66.Size = 20
                param66.Value = " "
                param66.ParameterName = "p_xtelfhabitacion4"

                Dim param67 As New Client.OracleParameter
                param67.OracleDbType = Client.OracleDbType.Varchar2
                param67.Size = 20
                param67.Value = " "
                param67.ParameterName = "p_xtelfhabitacion5"
                'estoy aqui
                Dim param68 As New Client.OracleParameter
                param68.OracleDbType = Client.OracleDbType.Varchar2
                param68.Size = 20
                'param68.Value = " "
                If vi_segmanusu.xtelfmovil1 IsNot Nothing Then
                    param68.Value = vi_segmanusu.xtelfmovil1
                Else
                    param68.Value = " "
                End If
                param68.ParameterName = "p_xtelfmovil1"

                Dim param69 As New Client.OracleParameter
                param69.OracleDbType = Client.OracleDbType.Varchar2
                param69.Size = 20
                'param69.Value = " "
                If vi_segmanusu.xtelfmovil2 IsNot Nothing Then
                    param69.Value = vi_segmanusu.xtelfmovil2
                Else
                    param69.Value = " "
                End If
                param69.ParameterName = "p_xtelfmovil2"

                Dim param70 As New Client.OracleParameter
                param70.OracleDbType = Client.OracleDbType.Varchar2
                param70.Size = 20
                param70.Value = " "
                param70.ParameterName = "p_xtelfmovil3"

                Dim param71 As New Client.OracleParameter
                param71.OracleDbType = Client.OracleDbType.Varchar2
                param71.Size = 20
                param71.Value = " "
                param71.ParameterName = "p_xtelfmovil4"

                Dim param72 As New Client.OracleParameter
                param72.OracleDbType = Client.OracleDbType.Varchar2
                param72.Size = 20
                param72.Value = " "
                param72.ParameterName = "p_xtelfmovil5"

                Dim param73 As New Client.OracleParameter
                param73.OracleDbType = Client.OracleDbType.Varchar2
                param73.Size = 20
                If vi_segmanusu.xtelfoficina1 IsNot Nothing Then
                    param73.Value = vi_segmanusu.xtelfoficina1
                Else
                    param73.Value = " "
                End If
                param73.ParameterName = "p_xtelfoficina1"

                Dim param74 As New Client.OracleParameter
                param74.OracleDbType = Client.OracleDbType.Varchar2
                param74.Size = 20
                If vi_segmanusu.xtelfoficina2 IsNot Nothing Then
                    param74.Value = vi_segmanusu.xtelfoficina2
                Else
                    param74.Value = " "
                End If
                param74.ParameterName = "p_xtelfoficina2"

                Dim param75 As New Client.OracleParameter
                param75.OracleDbType = Client.OracleDbType.Varchar2
                param75.Size = 20
                param75.Value = " "
                param75.ParameterName = "p_xtelfoficina3"

                Dim param76 As New Client.OracleParameter
                param76.OracleDbType = Client.OracleDbType.Varchar2
                param76.Size = 20
                param76.Value = " "
                param76.ParameterName = "p_xtelfoficina4"

                Dim param77 As New Client.OracleParameter
                param77.OracleDbType = Client.OracleDbType.Varchar2
                param77.Size = 20
                param77.Value = " "
                param77.ParameterName = "p_xtelfoficina5"

                Dim param78 As New Client.OracleParameter
                param78.OracleDbType = Client.OracleDbType.Varchar2
                param78.Size = 20
                param78.Value = " "
                param78.ParameterName = "p_xtelffax1"
                'If vi_segmanusu.xtelffax1 IsNot Nothing Then
                'param78.Value = vi_segmanusu.xtelffax1
                'Else
                'param78.Value = " "
                'End If

                Dim param79 As New Client.OracleParameter
                param79.OracleDbType = Client.OracleDbType.Varchar2
                param79.Size = 20
                param79.Value = " "
                param79.ParameterName = "p_xtelffax2"
                'If vi_segmanusu.xtelffax2 IsNot Nothing Then
                '    param79.Value = vi_segmanusu.xtelffax2
                'Else
                '    param79.Value = " "
                'End If

                Dim param80 As New Client.OracleParameter
                param80.OracleDbType = Client.OracleDbType.Varchar2
                param80.Size = 20
                param80.Value = " "
                param80.ParameterName = "p_xtelffax3"

                Dim param81 As New Client.OracleParameter
                param81.OracleDbType = Client.OracleDbType.Varchar2
                param81.Size = 20
                param81.Value = " "
                param81.ParameterName = "p_xtelffax4"

                Dim param82 As New Client.OracleParameter
                param82.OracleDbType = Client.OracleDbType.Varchar2
                param82.Size = 20
                param82.Value = " "
                param82.ParameterName = "p_xtelffax5"

                Dim param83 As New Client.OracleParameter
                param83.OracleDbType = Client.OracleDbType.Varchar2
                param83.Size = 50
                If vi_segmanusu.xcorreoelectronico1 IsNot Nothing Then
                    param83.Value = vi_segmanusu.xcorreoelectronico1
                Else
                    param83.Value = " "
                End If
                param83.ParameterName = "p_xcorreoelectronico1"

                Dim param84 As New Client.OracleParameter
                param84.OracleDbType = Client.OracleDbType.Varchar2
                param84.Size = 50
                If vi_segmanusu.xcorreoelectronico2 IsNot Nothing Then
                    param84.Value = vi_segmanusu.xcorreoelectronico2
                Else
                    param84.Value = " "
                End If
                param84.ParameterName = "p_xcorreoelectronico2"

                Dim param85 As New Client.OracleParameter
                param85.OracleDbType = Client.OracleDbType.Varchar2
                param85.Size = 50
                param85.Value = " "
                param85.ParameterName = "p_xcorreoelectronico3"

                Dim param86 As New Client.OracleParameter
                param86.OracleDbType = Client.OracleDbType.Varchar2
                param86.Size = 50
                param86.Value = " "
                param86.ParameterName = "p_xcorreoelectronico4"

                Dim param87 As New Client.OracleParameter
                param87.OracleDbType = Client.OracleDbType.Varchar2
                param87.Size = 50
                param87.Value = " "
                param87.ParameterName = "p_xcorreoelectronico5"

                Dim param88 As New Client.OracleParameter
                param88.OracleDbType = Client.OracleDbType.Varchar2
                param88.Size = 50
                param88.Value = " "
                param88.ParameterName = "p_xdireccionweb1"
                'If vi_segmanusu.xdireccionweb1 IsNot Nothing Then
                '    param88.Value = vi_segmanusu.xdireccionweb1
                'Else
                '    param88.Value = " "
                'End If

                Dim param89 As New Client.OracleParameter
                param89.OracleDbType = Client.OracleDbType.Varchar2
                param89.Size = 50
                param89.Value = " "
                param89.ParameterName = "p_xdireccionweb2"
                'If vi_segmanusu.xdireccionweb2 IsNot Nothing Then
                '    param89.Value = vi_segmanusu.xdireccionweb2
                'Else
                '    param89.Value = " "
                'End If

                Dim param90 As New Client.OracleParameter
                param90.OracleDbType = Client.OracleDbType.Varchar2
                param90.Size = 50
                param90.Value = " "
                param90.ParameterName = "p_xdireccionweb3"

                Dim param91 As New Client.OracleParameter
                param91.OracleDbType = Client.OracleDbType.Varchar2
                param91.Size = 50
                param91.Value = " "
                param91.ParameterName = "p_xdireccionweb4"

                Dim param92 As New Client.OracleParameter
                param92.OracleDbType = Client.OracleDbType.Varchar2
                param92.Size = 50
                param92.Value = " "
                param92.ParameterName = "p_xdireccionweb5"

                Dim param93 As New Client.OracleParameter
                param93.OracleDbType = Client.OracleDbType.Varchar2
                param93.Size = 200
                If vi_segmanusu.xtwitter1 IsNot Nothing Then
                    param93.Value = vi_segmanusu.xtwitter1
                Else
                    param93.Value = " "
                End If
                param93.ParameterName = "p_xtwitter1"

                Dim param94 As New Client.OracleParameter
                param94.OracleDbType = Client.OracleDbType.Varchar2
                param94.Size = 200
                param94.Value = " "
                param94.ParameterName = "p_xtwitter2"

                Dim param95 As New Client.OracleParameter
                param95.OracleDbType = Client.OracleDbType.Varchar2
                param95.Size = 200
                param95.Value = " "
                param95.ParameterName = "p_xtwitter3"

                Dim param96 As New Client.OracleParameter
                param96.OracleDbType = Client.OracleDbType.Varchar2
                param96.Size = 200
                param96.Value = " "
                param96.ParameterName = "p_xtwitter4"

                Dim param97 As New Client.OracleParameter
                param97.OracleDbType = Client.OracleDbType.Varchar2
                param97.Size = 200
                param97.Value = " "
                param97.ParameterName = "p_xtwitter5"

                Dim param98 As New Client.OracleParameter
                param98.OracleDbType = Client.OracleDbType.Varchar2
                param98.Size = 200
                If vi_segmanusu.xfacebook1 IsNot Nothing Then
                    param98.Value = vi_segmanusu.xfacebook1
                Else
                    param98.Value = " "
                End If
                param98.ParameterName = "p_xfacebook1"

                Dim param99 As New Client.OracleParameter
                param99.OracleDbType = Client.OracleDbType.Varchar2
                param99.Size = 200
                param99.Value = " "
                param99.ParameterName = "p_xfacebook2"

                Dim param100 As New Client.OracleParameter
                param100.OracleDbType = Client.OracleDbType.Varchar2
                param100.Size = 200
                param100.Value = " "
                param100.ParameterName = "p_xfacebook3"

                Dim param101 As New Client.OracleParameter
                param101.OracleDbType = Client.OracleDbType.Varchar2
                param101.Size = 200
                param101.Value = " "
                param101.ParameterName = "p_xfacebook4"

                Dim param102 As New Client.OracleParameter
                param102.OracleDbType = Client.OracleDbType.Varchar2
                param102.Size = 200
                param102.Value = " "
                param102.ParameterName = "p_xfacebook5"

                ''campos agregados despues de crear el metodo
                ''comunmanpers

                Dim xdeclare As String = "DECLARE v_p_illamada varchar2(32767);  iv_p_idsegmanusuop float;  iv_p_xnombrecorto varchar2(32767);  v_p_irespuesta varchar2(32767);  v_p_xmsjusuario varchar2(32767);  v_p_xmsjtecnico varchar2(32767);  v_p_coderrorlog varchar2(32767);  v_p_idsegmanusu float;  iv_p_idcomunmanpers float;  iv_p_idcomunmancom float;  iv_p_idcomunmandir float;  v_p_idsegmanorg float;  v_p_idsegmandep float;  v_p_idsegmancarg float;  iv_p_xnombreusuario varchar2(32767);  v_p_xcontrasena varchar2(32767);  v_p_fcreacion date;  v_p_ibloqueado number;  v_p_fultbloqueo date;  v_p_fultiniciosesion date;  v_p_fultcambpass date;  v_p_fultrecuppass date;  v_p_fultpassintfallido date;  v_p_npassintfallido number;  v_p_npassintfallidoacum number;  v_p_idseglogreg float;  v_p_xcedula varchar2(32767);  v_p_xnombres varchar2(32767);  v_p_xapellidos varchar2(32767);  v_p_xnombrecompleto varchar2(32767);  v_p_fnacimiento date;  v_p_xsexo varchar2(32767);  v_p_xnacionalidad varchar2(32767);  v_p_xestatura varchar2(32767);  v_p_xmedestatura varchar2(32767);  v_p_xpeso varchar2(32767);  v_p_xmedpeso varchar2(32767);  v_p_idcomunmanlocalid float;  v_p_idcomunmanestado float;  v_p_idcomunmanpais float;  v_p_idcomunmancont float;  v_p_xdireccion varchar2(32767);  v_p_idcomunmanlocalid2 float;  v_p_idcomunmanestado2 float;  iv_p_idcomunmanpais2 float;  iv_p_idcomunmancont2 float;  v_p_xdireccion2 varchar2(32767);  v_p_idcomunmanlocalid3 float;  v_p_idcomunmanestado3 float;  iv_p_idcomunmanpais3 float;  iv_p_idcomunmancont3 float;  v_p_xdireccion3 varchar2(32767);  v_p_idcomunmanlocalid4 float;  v_p_idcomunmanestado4 float;  iv_p_idcomunmanpais4 float;  iv_p_idcomunmancont4 float;  v_p_xdireccion4 varchar2(32767);  v_p_idcomunmanlocalid5 float;  v_p_idcomunmanestado5 float;  iv_p_idcomunmanpais5 float;  iv_p_idcomunmancont5 float;  v_p_xdireccion5 varchar2(32767);  v_p_xtelfhabitacion1 varchar2(32767);  v_p_xtelfhabitacion2 varchar2(32767);  v_p_xtelfhabitacion3 varchar2(32767);  v_p_xtelfhabitacion4 varchar2(32767);  v_p_xtelfhabitacion5 varchar2(32767);  v_p_xtelfmovil1 varchar2(32767);  v_p_xtelfmovil2 varchar2(32767);  v_p_xtelfmovil3 varchar2(32767);  v_p_xtelfmovil4 varchar2(32767);  v_p_xtelfmovil5 varchar2(32767);  v_p_xtelfoficina1 varchar2(32767);  v_p_xtelfoficina2 varchar2(32767);  v_p_xtelfoficina3 varchar2(32767);  v_p_xtelfoficina4 varchar2(32767);  v_p_xtelfoficina5 varchar2(32767);  v_p_xtelffax1 varchar2(32767);  v_p_xtelffax2 varchar2(32767);  v_p_xtelffax3 varchar2(32767);  v_p_xtelffax4 varchar2(32767);  v_p_xtelffax5 varchar2(32767);  v_p_xcorreoelectronico1 varchar2(32767);  v_p_xcorreoelectronico2 varchar2(32767);  v_p_xcorreoelectronico3 varchar2(32767);  v_p_xcorreoelectronico4 varchar2(32767);  v_p_xcorreoelectronico5 varchar2(32767);  v_p_xdireccionweb1 varchar2(32767);  v_p_xdireccionweb2 varchar2(32767);  v_p_xdireccionweb3 varchar2(32767);  v_p_xdireccionweb4 varchar2(32767);  v_p_xdireccionweb5 varchar2(32767);  v_p_xtwitter1 varchar2(32767);  v_p_xtwitter2 varchar2(32767);  v_p_xtwitter3 varchar2(32767);  v_p_xtwitter4 varchar2(32767);  v_p_xtwitter5 varchar2(32767);  v_p_xfacebook1 varchar2(32767);  v_p_xfacebook2 varchar2(32767);  v_p_xfacebook3 varchar2(32767);  v_p_xfacebook4 varchar2(32767);  v_p_xfacebook5 varchar2(32767); cv_1 sys_refcursor; cv_2 sys_refcursor;  cv_3 sys_refcursor;  cv_4 sys_refcursor;  cv_5 sys_refcursor;  cv_6 sys_refcursor;  cv_7 sys_refcursor;  cv_8 sys_refcursor;  cv_9 sys_refcursor;  cv_10 sys_refcursor;  cv_11 sys_refcursor;  cv_12 sys_refcursor;  cv_13 sys_refcursor;  cv_14 sys_refcursor;  cv_15 sys_refcursor;  cv_16 sys_refcursor;  cv_17 sys_refcursor;"
                Dim xsp As String = "begin sp_rnmodificarusuario (:v_p_illamada,:v_p_idsegmanusuop,:v_p_xnombrecorto,:v_p_irespuesta ,:v_p_xmsjusuario ,:v_p_xmsjtecnico ,:v_p_coderrorlog ,:v_p_idsegmanusu  ,:v_p_idcomunmanpers,:v_p_idcomunmancom,:v_p_idcomunmandir,:v_p_idsegmanorg,:v_p_idsegmandep,:v_p_idsegmancarg,:v_p_xnombreusuario,:v_p_xcontrasena,:v_p_fcreacion,:v_p_ibloqueado,:v_p_fultbloqueo,:v_p_fultiniciosesion,:v_p_fultcambpass,:v_p_fultrecuppass,:v_p_fultpassintfallido,:v_p_npassintfallido,:v_p_npassintfallidoacum,:v_p_idseglogreg,:v_p_xcedula,:v_p_xnombres,:v_p_xapellidos,:v_p_xnombrecompleto,:v_p_fnacimiento,:v_p_xsexo,:v_p_xnacionalidad,:v_p_xestatura,:v_p_xmedestatura,:v_p_xpeso,:v_p_xmedpeso,:v_p_idcomunmanlocalid,:v_p_idcomunmanestado,:v_p_idcomunmanpais,:v_p_idcomunmancont,:v_p_xdireccion,:v_p_idcomunmanlocalid2,:v_p_idcomunmanestado2,:v_p_idcomunmanpais2,:v_p_idcomunmancont2,:v_p_xdireccion2,:v_p_idcomunmanlocalid3,:v_p_idcomunmanestado3,:v_p_idcomunmanpais3,:v_p_idcomunmancont3,:v_p_xdireccion3,:v_p_idcomunmanlocalid4,:v_p_idcomunmanestado4,:v_p_idcomunmanpais4,:v_p_idcomunmancont4,:v_p_xdireccion4,:v_p_idcomunmanlocalid5,:v_p_idcomunmanestado5,:v_p_idcomunmanpais5,:v_p_idcomunmancont5,:v_p_xdireccion5,:v_p_xtelfhabitacion1,:v_p_xtelfhabitacion2,:v_p_xtelfhabitacion3,:v_p_xtelfhabitacion4,:v_p_xtelfhabitacion5,:v_p_xtelfmovil1,:v_p_xtelfmovil2,:v_p_xtelfmovil3,:v_p_xtelfmovil4,:v_p_xtelfmovil5,:v_p_xtelfoficina1,:v_p_xtelfoficina2,:v_p_xtelfoficina3,:v_p_xtelfoficina4,:v_p_xtelfoficina5,:v_p_xtelffax1,:v_p_xtelffax2,:v_p_xtelffax3,:v_p_xtelffax4,:v_p_xtelffax5,:v_p_xcorreoelectronico1,:v_p_xcorreoelectronico2,:v_p_xcorreoelectronico3,:v_p_xcorreoelectronico4,:v_p_xcorreoelectronico5,:v_p_xdireccionweb1,:v_p_xdireccionweb2,:v_p_xdireccionweb3,:v_p_xdireccionweb4,:v_p_xdireccionweb5,:v_p_xtwitter1,:v_p_xtwitter2,:v_p_xtwitter3,:v_p_xtwitter4,:v_p_xtwitter5,:v_p_xfacebook1,:v_p_xfacebook2,:v_p_xfacebook3,:v_p_xfacebook4,:v_p_xfacebook5, cv_1, cv_2, cv_3, cv_4, cv_5, cv_6, cv_7, cv_8, cv_9, cv_10, cv_11, cv_12, cv_13, cv_14, cv_15, cv_16, cv_17); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40, param41, param42, param43, param44, param45, param46, param47, param48, param49, param50, param51, param52, param53, param54, param55, param56, param57, param58, param59, param60, param61, param62, param63, param64, param65, param66, param67, param68, param69, param70, param71, param72, param73, param74, param75, param76, param77, param78, param79, param80, param81, param82, param83, param84, param85, param86, param87, param88, param89, param90, param91, param92, param93, param94, param95, param96, param97, param98, param99, param100, param101, param102)
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

        '<HttpGet()> _
        'Public Function ModificarUsu() As respopera
        '<HttpPost()> _
        'Public Function ModificarUsu(vi_segmanusu As vi_segmanusu) As respopera
        '    Try
        '        'Dim vi_segmanusu As New vi_segmanusu
        '        'vi_segmanusu.idsegmanusu = 15
        '        'vi_segmanusu.idcomunmanpers = 87
        '        'vi_segmanusu.idcomunmancom = 361
        '        'vi_segmanusu.idcomunmandir = 369
        '        'vi_segmanusu.idsegmanorg = 3
        '        'vi_segmanusu.idsegmandep = 3
        '        'vi_segmanusu.idsegmancarg = 3
        '        'vi_segmanusu.xnombreusuario = "dpena@sigmadental.net"
        '        'vi_segmanusu.xcontrasena = "183"
        '        ''vi_segmanusu.fcreacion = Date.Now
        '        'vi_segmanusu.ibloqueado = 0
        '        ''vi_segmanusu.fultbloqueo = Date.Now
        '        ''vi_segmanusu.fultiniciosesion = Date.Now
        '        ''vi_segmanusu.fultcambpass = Date.Now
        '        ''vi_segmanusu.fultrecuppass = Date.Now
        '        ''vi_segmanusu.fultpassintfallido = Date.Now
        '        'vi_segmanusu.npassintfallido = 0
        '        'vi_segmanusu.npassintfallidoacum = 0
        '        'vi_segmanusu.idseglogreg = 0
        '        'vi_segmanusu.xcedula = "01234567"
        '        'vi_segmanusu.xnombres = "Deivid"
        '        'vi_segmanusu.xapellidos = "Peña"
        '        'vi_segmanusu.fnacimiento = "14/08/1988"
        '        'vi_segmanusu.xsexo = "MASCULINO"
        '        'vi_segmanusu.xnacionalidad = "LOCAL"
        '        'vi_segmanusu.xtelfmovil1 = "04122345674"

        '        Dim param1 As New SqlClient.SqlParameter
        '        param1.SqlDbType = SqlDbType.VarChar
        '        param1.Size = 20
        '        param1.Value = "directo"
        '        param1.ParameterName = "p_illamada"

        '        Dim param2 As New SqlClient.SqlParameter
        '        param2.SqlDbType = SqlDbType.Decimal
        '        param2.Precision = 18
        '        param2.Scale = 0
        '        param2.Value = 0
        '        param2.ParameterName = "p_idsegmanusuop"

        '        Dim param3 As New SqlClient.SqlParameter
        '        param3.SqlDbType = SqlDbType.VarChar
        '        param3.Size = 20
        '        param3.Value = "seginsoft"
        '        param3.ParameterName = "p_xnombrecorto"

        '        Dim param4 As New SqlClient.SqlParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
        '        param4.SqlDbType = SqlDbType.VarChar
        '        param4.Size = 1
        '        param4.ParameterName = "p_irespuesta"
        '        param4.Direction = ParameterDirection.Output

        '        Dim param5 As New SqlClient.SqlParameter
        '        param5.SqlDbType = SqlDbType.VarChar
        '        param5.Size = 300
        '        param5.ParameterName = "p_xmsjusuario"
        '        param5.Direction = ParameterDirection.Output

        '        Dim param6 As New SqlClient.SqlParameter
        '        param6.SqlDbType = SqlDbType.VarChar
        '        param6.Size = 300
        '        param6.ParameterName = "p_xmsjtecnico"
        '        param6.Direction = ParameterDirection.Output

        '        Dim param7 As New SqlClient.SqlParameter
        '        param7.SqlDbType = SqlDbType.VarChar
        '        param7.Size = 300
        '        param7.ParameterName = "p_coderrorlog"
        '        param7.Direction = ParameterDirection.Output

        '        'Paramestros de la tabla
        '        Dim param8 As New SqlClient.SqlParameter
        '        param8.SqlDbType = SqlDbType.Decimal
        '        param8.Precision = 18
        '        param8.Scale = 0
        '        'param8.Value = 0
        '        param8.Value = vi_segmanusu.idsegmanusu
        '        param8.ParameterName = "p_idsegmanusu"
        '        param8.Direction = ParameterDirection.InputOutput

        '        Dim param9 As New SqlClient.SqlParameter
        '        param9.SqlDbType = SqlDbType.Decimal
        '        param9.Precision = 18
        '        param9.Scale = 0
        '        param9.Value = vi_segmanusu.idcomunmanpers
        '        'param9.Value = 0
        '        param9.ParameterName = "p_idcomunmanpers"

        '        Dim param10 As New SqlClient.SqlParameter
        '        param10.SqlDbType = SqlDbType.Decimal
        '        param10.Precision = 18
        '        param10.Scale = 0
        '        param10.Value = vi_segmanusu.idcomunmancom
        '        'param10.Value = 0
        '        param10.ParameterName = "p_idcomunmancom"

        '        Dim param11 As New SqlClient.SqlParameter
        '        param11.SqlDbType = SqlDbType.Decimal
        '        param11.Precision = 18
        '        param11.Scale = 0
        '        param11.Value = vi_segmanusu.idcomunmandir
        '        param11.ParameterName = "p_idcomunmandir"

        '        Dim param12 As New SqlClient.SqlParameter
        '        param12.SqlDbType = SqlDbType.Decimal
        '        param12.Size = 18
        '        param12.Scale = 0
        '        param12.Value = vi_segmanusu.idsegmanorg
        '        param12.ParameterName = "p_idsegmanorg"
        '        'If vi_mant_segmanusu.idsegmanorg IsNot Nothing Then
        '        'Else
        '        'param12.Value = 0
        '        'End If

        '        Dim param13 As New SqlClient.SqlParameter
        '        param13.SqlDbType = SqlDbType.Decimal
        '        param13.Precision = 18
        '        param13.Scale = 0
        '        param13.Value = vi_segmanusu.idsegmandep
        '        param13.ParameterName = "p_idsegmandep"
        '        'If vi_mant_segmanusu.idsegmandep IsNot Nothing Then
        '        'param13.Value = vi_segmanusu.idsegmandep
        '        'Else
        '        'param13.Value = 0
        '        'End If

        '        Dim param14 As New SqlClient.SqlParameter
        '        param14.SqlDbType = SqlDbType.Decimal
        '        param14.Precision = 18
        '        param14.Scale = 0
        '        param14.Value = vi_segmanusu.idsegmancarg
        '        param14.ParameterName = "p_idsegmancarg"
        '        'If vi_mant_segmanusu.idsegmancarg IsNot Nothing Then
        '        'param14.Value = vi_segmanusu.idsegmancarg
        '        'Else
        '        'param14.Value = 0
        '        'End If

        '        Dim param15 As New SqlClient.SqlParameter
        '        param15.SqlDbType = SqlDbType.VarChar
        '        param15.Size = 50
        '        If vi_segmanusu.xnombreusuario IsNot Nothing Then
        '            param15.Value = vi_segmanusu.xnombreusuario
        '        Else
        '            param15.Value = ""
        '        End If
        '        param15.ParameterName = "p_xnombreusuario"

        '        Dim param16 As New SqlClient.SqlParameter
        '        param16.SqlDbType = SqlDbType.VarChar
        '        param16.Size = 50
        '        If vi_segmanusu.xcontrasena IsNot Nothing Then
        '            param16.Value = vi_segmanusu.xcontrasena
        '        Else
        '            param16.Value = ""
        '        End If
        '        param16.ParameterName = "p_xcontrasena"
        '        param16.Direction = ParameterDirection.InputOutput

        '        Dim param17 As New SqlClient.SqlParameter
        '        param17.SqlDbType = SqlDbType.DateTime
        '        If vi_segmanusu.fcreacion > CDate("01-01-1900") Then
        '            param17.Value = vi_segmanusu.fcreacion
        '        Else
        '            param17.Value = CDate("01-01-1900")
        '        End If
        '        param17.ParameterName = "p_fcreacion"

        '        Dim param18 As New SqlClient.SqlParameter
        '        param18.SqlDbType = SqlDbType.Bit
        '        param18.Value = vi_segmanusu.ibloqueado
        '        param18.ParameterName = "p_ibloqueado"

        '        Dim param19 As New SqlClient.SqlParameter
        '        param19.SqlDbType = SqlDbType.DateTime
        '        If vi_segmanusu.fultbloqueo > CDate("01-01-1900") Then
        '            param19.Value = vi_segmanusu.fultbloqueo
        '        Else
        '            param19.Value = CDate("01-01-1900")
        '        End If
        '        param19.ParameterName = "p_fultbloqueo"

        '        Dim param20 As New SqlClient.SqlParameter
        '        param20.SqlDbType = SqlDbType.DateTime
        '        If vi_segmanusu.fultiniciosesion > CDate("01-01-1900") Then
        '            param20.Value = vi_segmanusu.fultiniciosesion
        '        Else
        '            param20.Value = CDate("01-01-1900")
        '        End If
        '        param20.ParameterName = "p_fultiniciosesion"

        '        Dim param21 As New SqlClient.SqlParameter
        '        param21.SqlDbType = SqlDbType.DateTime
        '        If vi_segmanusu.fultcambpass > CDate("01-01-1900") Then
        '            param21.Value = vi_segmanusu.fultcambpass
        '        Else
        '            param21.Value = CDate("01-01-1900")
        '        End If
        '        param21.ParameterName = "p_fultcambpass"

        '        Dim param22 As New SqlClient.SqlParameter
        '        param22.SqlDbType = SqlDbType.DateTime
        '        If vi_segmanusu.fultrecuppass > CDate("01-01-1900") Then
        '            param22.Value = vi_segmanusu.fultrecuppass
        '        Else
        '            param22.Value = CDate("01-01-1900")
        '        End If
        '        param22.ParameterName = "p_fultrecuppass"

        '        Dim param23 As New SqlClient.SqlParameter
        '        param23.SqlDbType = SqlDbType.DateTime
        '        ' If vi_segmanusu.fultpassintfallido > CDate("01-01-1900") Then
        '        'param23.Value = vi_segmanusu.fultpassintfallido
        '        'Else
        '        param23.Value = CDate("01-01-1900")
        '        'End If
        '        param23.ParameterName = "p_fultpassintfallido"

        '        Dim param24 As New SqlClient.SqlParameter
        '        param24.SqlDbType = SqlDbType.BigInt
        '        param24.Value = vi_segmanusu.npassintfallido
        '        param24.ParameterName = "p_npassintfallido"

        '        Dim param25 As New SqlClient.SqlParameter
        '        param25.SqlDbType = SqlDbType.BigInt
        '        param25.Value = vi_segmanusu.npassintfallidoacum
        '        param25.ParameterName = "p_npassintfallidoacum"

        '        Dim param26 As New SqlClient.SqlParameter
        '        param26.SqlDbType = SqlDbType.Decimal
        '        param26.Precision = 18
        '        param26.Scale = 0
        '        param26.Value = vi_segmanusu.idseglogreg
        '        param26.ParameterName = "p_idseglogreg"

        '        'campos de la tabla comunmanpers
        '        Dim param27 As New SqlClient.SqlParameter
        '        param27.SqlDbType = SqlDbType.VarChar
        '        param27.Size = 20
        '        param27.Value = vi_segmanusu.xcedula
        '        param27.ParameterName = "p_xcedula"

        '        Dim param28 As New SqlClient.SqlParameter
        '        param28.SqlDbType = SqlDbType.VarChar
        '        param28.Size = 50
        '        param28.Value = vi_segmanusu.xnombres
        '        param28.ParameterName = "p_xnombres"

        '        Dim param29 As New SqlClient.SqlParameter
        '        param29.SqlDbType = SqlDbType.VarChar
        '        param29.Size = 50
        '        param29.Value = vi_segmanusu.xapellidos
        '        param29.ParameterName = "p_xapellidos"

        '        Dim param30 As New SqlClient.SqlParameter
        '        param30.SqlDbType = SqlDbType.VarChar
        '        param30.Size = 100
        '        If vi_segmanusu.xnombrecompleto IsNot Nothing Then
        '            param30.Value = vi_segmanusu.xnombrecompleto
        '        Else
        '            param30.Value = vi_segmanusu.xnombres & " " & vi_segmanusu.xapellidos
        '        End If
        '        param30.ParameterName = "p_xnombrecompleto"

        '        Dim param31 As New SqlClient.SqlParameter
        '        param31.SqlDbType = SqlDbType.DateTime
        '        param31.Value = vi_segmanusu.fnacimiento
        '        param31.ParameterName = "p_fnacimiento"

        '        Dim param32 As New SqlClient.SqlParameter
        '        param32.SqlDbType = SqlDbType.VarChar
        '        param32.Size = 20
        '        param32.Value = vi_segmanusu.xsexo
        '        param32.ParameterName = "p_xsexo"

        '        Dim param33 As New SqlClient.SqlParameter
        '        param33.SqlDbType = SqlDbType.VarChar
        '        param33.Size = 50
        '        param33.Value = vi_segmanusu.xnacionalidad
        '        param33.ParameterName = "p_xnacionalidad"

        '        Dim param34 As New SqlClient.SqlParameter
        '        param34.SqlDbType = SqlDbType.VarChar
        '        param34.Size = 20
        '        If vi_segmanusu.xestatura IsNot Nothing Then
        '            param34.Value = vi_segmanusu.xestatura
        '        Else
        '            param34.Value = ""
        '        End If
        '        param34.ParameterName = "p_xestatura"

        '        Dim param35 As New SqlClient.SqlParameter
        '        param35.SqlDbType = SqlDbType.VarChar
        '        param35.Size = 20
        '        If vi_segmanusu.xestatura IsNot Nothing Then
        '            param35.Value = vi_segmanusu.xmedestatura
        '        Else
        '            param35.Value = ""
        '        End If
        '        param35.ParameterName = "p_xmedestatura"

        '        Dim param36 As New SqlClient.SqlParameter
        '        param36.SqlDbType = SqlDbType.VarChar
        '        param36.Size = 20
        '        If vi_segmanusu.xpeso IsNot Nothing Then
        '            param36.Value = vi_segmanusu.xpeso
        '        Else
        '            param36.Value = ""
        '        End If
        '        param36.ParameterName = "p_xpeso"

        '        Dim param37 As New SqlClient.SqlParameter
        '        param37.SqlDbType = SqlDbType.VarChar
        '        param37.Size = 20
        '        If vi_segmanusu.xpeso IsNot Nothing Then
        '            param37.Value = vi_segmanusu.xmedpeso
        '        Else
        '            param37.Value = ""
        '        End If
        '        param37.ParameterName = "p_xmedpeso"

        '        ''campos de la tabla comunmandir
        '        Dim param38 As New SqlClient.SqlParameter
        '        param38.SqlDbType = SqlDbType.Decimal
        '        param38.Precision = 18
        '        param38.Scale = 0
        '        param38.Value = vi_segmanusu.idcomunmanlocalid
        '        param38.ParameterName = "p_idcomunmanlocalid"

        '        Dim param39 As New SqlClient.SqlParameter
        '        param39.SqlDbType = SqlDbType.Decimal
        '        param39.Precision = 18
        '        param39.Scale = 0
        '        param39.Value = vi_segmanusu.idcomunmanestado
        '        param39.ParameterName = "p_idcomunmanestado"

        '        Dim param40 As New SqlClient.SqlParameter
        '        param40.SqlDbType = SqlDbType.Decimal
        '        param40.Precision = 18
        '        param40.Scale = 0
        '        param40.Value = 9
        '        param40.ParameterName = "p_idcomunmanpais"

        '        Dim param41 As New SqlClient.SqlParameter
        '        param41.SqlDbType = SqlDbType.Decimal
        '        param41.Precision = 18
        '        param41.Scale = 0
        '        param41.Value = 1
        '        param41.ParameterName = "p_idcomunmancont"

        '        Dim param42 As New SqlClient.SqlParameter
        '        param42.SqlDbType = SqlDbType.VarChar
        '        param42.Size = 500
        '        If vi_segmanusu.xdireccion IsNot Nothing Then
        '            param42.Value = vi_segmanusu.xdireccion
        '        Else
        '            param42.Value = ""
        '        End If
        '        param42.ParameterName = "p_xdireccion"

        '        Dim param43 As New SqlClient.SqlParameter
        '        param43.SqlDbType = SqlDbType.Decimal
        '        param43.Precision = 18
        '        param43.Scale = 0
        '        param43.Value = 0
        '        'param43.Value = vi_segmanusu.idcomunmanlocalid2
        '        param43.ParameterName = "p_idcomunmanlocalid2"

        '        Dim param44 As New SqlClient.SqlParameter
        '        param44.SqlDbType = SqlDbType.Decimal
        '        param44.Precision = 18
        '        param44.Scale = 0
        '        param44.Value = 0
        '        'param44.Value = vi_segmanusu.idcomunmanestado2
        '        param44.ParameterName = "p_idcomunmanestado2"

        '        Dim param45 As New SqlClient.SqlParameter
        '        param45.SqlDbType = SqlDbType.Decimal
        '        param45.Precision = 18
        '        param45.Scale = 0
        '        param45.Value = 9
        '        param45.ParameterName = "p_idcomunmanpais2"

        '        Dim param46 As New SqlClient.SqlParameter
        '        param46.SqlDbType = SqlDbType.Decimal
        '        param46.Precision = 18
        '        param46.Scale = 0
        '        param46.Value = 1
        '        param46.ParameterName = "p_idcomunmancont2"

        '        Dim param47 As New SqlClient.SqlParameter
        '        param47.SqlDbType = SqlDbType.VarChar
        '        param47.Size = 500
        '        'If vi_segmanusu.xdireccion2 IsNot Nothing Then
        '        'param47.Value = vi_segmanusu.xdireccion2
        '        'Else
        '        param47.Value = ""
        '        'End If
        '        param47.ParameterName = "p_xdireccion2"

        '        Dim param48 As New SqlClient.SqlParameter
        '        param48.SqlDbType = SqlDbType.Decimal
        '        param48.Precision = 18
        '        param48.Scale = 0
        '        param48.Value = 0
        '        param48.ParameterName = "p_idcomunmanlocalid3"

        '        Dim param49 As New SqlClient.SqlParameter
        '        param49.SqlDbType = SqlDbType.Decimal
        '        param49.Precision = 18
        '        param49.Scale = 0
        '        param49.Value = 0
        '        param49.ParameterName = "p_idcomunmanestado3"

        '        Dim param50 As New SqlClient.SqlParameter
        '        param50.SqlDbType = SqlDbType.Decimal
        '        param50.Precision = 18
        '        param50.Scale = 0
        '        param50.Value = 0
        '        param50.ParameterName = "p_idcomunmanpais3"

        '        Dim param51 As New SqlClient.SqlParameter
        '        param51.SqlDbType = SqlDbType.Decimal
        '        param51.Precision = 18
        '        param51.Scale = 0
        '        param51.Value = 0
        '        param51.ParameterName = "p_idcomunmancont3"

        '        Dim param52 As New SqlClient.SqlParameter
        '        param52.SqlDbType = SqlDbType.VarChar
        '        param52.Size = 500
        '        param52.Value = ""
        '        param52.ParameterName = "p_xdireccion3"

        '        Dim param53 As New SqlClient.SqlParameter
        '        param53.SqlDbType = SqlDbType.Decimal
        '        param53.Precision = 18
        '        param53.Scale = 0
        '        param53.Value = 0
        '        param53.ParameterName = "p_idcomunmanlocalid4"

        '        Dim param54 As New SqlClient.SqlParameter
        '        param54.SqlDbType = SqlDbType.Decimal
        '        param54.Precision = 18
        '        param54.Scale = 0
        '        param54.Value = 0
        '        param54.ParameterName = "p_idcomunmanestado4"

        '        Dim param55 As New SqlClient.SqlParameter
        '        param55.SqlDbType = SqlDbType.Decimal
        '        param55.Precision = 18
        '        param55.Scale = 0
        '        param55.Value = 0
        '        param55.ParameterName = "p_idcomunmanpais4"

        '        Dim param56 As New SqlClient.SqlParameter
        '        param56.SqlDbType = SqlDbType.Decimal
        '        param56.Precision = 18
        '        param56.Scale = 0
        '        param56.Value = 0
        '        param56.ParameterName = "p_idcomunmancont4"

        '        Dim param57 As New SqlClient.SqlParameter
        '        param57.SqlDbType = SqlDbType.VarChar
        '        param57.Size = 500
        '        param57.Value = ""
        '        param57.ParameterName = "p_xdireccion4"

        '        Dim param58 As New SqlClient.SqlParameter
        '        param58.SqlDbType = SqlDbType.Decimal
        '        param58.Precision = 18
        '        param58.Scale = 0
        '        param58.Value = 0
        '        param58.ParameterName = "p_idcomunmanlocalid5"

        '        Dim param59 As New SqlClient.SqlParameter
        '        param59.SqlDbType = SqlDbType.Decimal
        '        param59.Precision = 18
        '        param59.Scale = 0
        '        param59.Value = 0
        '        param59.ParameterName = "p_idcomunmanestado5"

        '        Dim param60 As New SqlClient.SqlParameter
        '        param60.SqlDbType = SqlDbType.Decimal
        '        param60.Precision = 18
        '        param60.Scale = 0
        '        param60.Value = 0
        '        param60.ParameterName = "p_idcomunmanpais5"

        '        Dim param61 As New SqlClient.SqlParameter
        '        param61.SqlDbType = SqlDbType.Decimal
        '        param61.Precision = 18
        '        param61.Scale = 0
        '        param61.Value = 0
        '        param61.ParameterName = "p_idcomunmancont5"

        '        Dim param62 As New SqlClient.SqlParameter
        '        param62.SqlDbType = SqlDbType.VarChar
        '        param62.Size = 500
        '        param62.Value = ""
        '        param62.ParameterName = "p_xdireccion5"

        '        'campos de la tabla comunmancom
        '        Dim param63 As New SqlClient.SqlParameter
        '        param63.SqlDbType = SqlDbType.VarChar
        '        param63.Size = 20
        '        param63.Value = ""
        '        param63.ParameterName = "p_xtelfhabitacion1"

        '        Dim param64 As New SqlClient.SqlParameter
        '        param64.SqlDbType = SqlDbType.VarChar
        '        param64.Size = 20
        '        param64.Value = ""
        '        param64.ParameterName = "p_xtelfhabitacion2"

        '        Dim param65 As New SqlClient.SqlParameter
        '        param65.SqlDbType = SqlDbType.VarChar
        '        param65.Size = 20
        '        param65.Value = ""
        '        param65.ParameterName = "p_xtelfhabitacion3"

        '        Dim param66 As New SqlClient.SqlParameter
        '        param66.SqlDbType = SqlDbType.VarChar
        '        param66.Size = 20
        '        param66.Value = ""
        '        param66.ParameterName = "p_xtelfhabitacion4"

        '        Dim param67 As New SqlClient.SqlParameter
        '        param67.SqlDbType = SqlDbType.VarChar
        '        param67.Size = 20
        '        param67.Value = ""
        '        param67.ParameterName = "p_xtelfhabitacion5"

        '        Dim param68 As New SqlClient.SqlParameter
        '        param68.SqlDbType = SqlDbType.VarChar
        '        param68.Size = 20
        '        'param68.Value = ""
        '        param68.Value = vi_segmanusu.xtelfmovil1
        '        param68.ParameterName = "p_xtelfmovil1"

        '        Dim param69 As New SqlClient.SqlParameter
        '        param69.SqlDbType = SqlDbType.VarChar
        '        param69.Size = 20
        '        'param69.Value = ""
        '        If vi_segmanusu.xtelfmovil2 IsNot Nothing Then
        '            param69.Value = vi_segmanusu.xtelfmovil2
        '        Else
        '            param69.Value = ""
        '        End If
        '        param69.ParameterName = "p_xtelfmovil2"

        '        Dim param70 As New SqlClient.SqlParameter
        '        param70.SqlDbType = SqlDbType.VarChar
        '        param70.Size = 20
        '        param70.Value = ""
        '        param70.ParameterName = "p_xtelfmovil3"

        '        Dim param71 As New SqlClient.SqlParameter
        '        param71.SqlDbType = SqlDbType.VarChar
        '        param71.Size = 20
        '        param71.Value = ""
        '        param71.ParameterName = "p_xtelfmovil4"

        '        Dim param72 As New SqlClient.SqlParameter
        '        param72.SqlDbType = SqlDbType.VarChar
        '        param72.Size = 20
        '        param72.Value = ""
        '        param72.ParameterName = "p_xtelfmovil5"

        '        Dim param73 As New SqlClient.SqlParameter
        '        param73.SqlDbType = SqlDbType.VarChar
        '        param73.Size = 20
        '        If vi_segmanusu.xtelfoficina1 IsNot Nothing Then
        '            param73.Value = vi_segmanusu.xtelfoficina1
        '        Else
        '            param73.Value = ""
        '        End If
        '        param73.ParameterName = "p_xtelfoficina1"

        '        Dim param74 As New SqlClient.SqlParameter
        '        param74.SqlDbType = SqlDbType.VarChar
        '        param74.Size = 20
        '        If vi_segmanusu.xtelfoficina2 IsNot Nothing Then
        '            param74.Value = vi_segmanusu.xtelfoficina2
        '        Else
        '            param74.Value = ""
        '        End If
        '        param74.ParameterName = "p_xtelfoficina2"

        '        Dim param75 As New SqlClient.SqlParameter
        '        param75.SqlDbType = SqlDbType.VarChar
        '        param75.Size = 20
        '        param75.Value = ""
        '        param75.ParameterName = "p_xtelfoficina3"

        '        Dim param76 As New SqlClient.SqlParameter
        '        param76.SqlDbType = SqlDbType.VarChar
        '        param76.Size = 20
        '        param76.Value = ""
        '        param76.ParameterName = "p_xtelfoficina4"

        '        Dim param77 As New SqlClient.SqlParameter
        '        param77.SqlDbType = SqlDbType.VarChar
        '        param77.Size = 20
        '        param77.Value = ""
        '        param77.ParameterName = "p_xtelfoficina5"

        '        Dim param78 As New SqlClient.SqlParameter
        '        param78.SqlDbType = SqlDbType.VarChar
        '        param78.Size = 20
        '        'If vi_segmanusu.xtelffax1 IsNot Nothing Then
        '        'param78.Value = vi_segmanusu.xtelffax1
        '        'Else
        '        param78.Value = ""
        '        'End If
        '        param78.ParameterName = "p_xtelffax1"

        '        Dim param79 As New SqlClient.SqlParameter
        '        param79.SqlDbType = SqlDbType.VarChar
        '        param79.Size = 20
        '        'If vi_segmanusu.xtelffax2 IsNot Nothing Then
        '        'param79.Value = vi_segmanusu.xtelffax2
        '        'Else
        '        param79.Value = ""
        '        'End If
        '        param79.ParameterName = "p_xtelffax2"

        '        Dim param80 As New SqlClient.SqlParameter
        '        param80.SqlDbType = SqlDbType.VarChar
        '        param80.Size = 20
        '        param80.Value = ""
        '        param80.ParameterName = "p_xtelffax3"

        '        Dim param81 As New SqlClient.SqlParameter
        '        param81.SqlDbType = SqlDbType.VarChar
        '        param81.Size = 20
        '        param81.Value = ""
        '        param81.ParameterName = "p_xtelffax4"

        '        Dim param82 As New SqlClient.SqlParameter
        '        param82.SqlDbType = SqlDbType.VarChar
        '        param82.Size = 20
        '        param82.Value = ""
        '        param82.ParameterName = "p_xtelffax5"

        '        Dim param83 As New SqlClient.SqlParameter
        '        param83.SqlDbType = SqlDbType.VarChar
        '        param83.Size = 50
        '        If vi_segmanusu.xcorreoelectronico1 IsNot Nothing Then
        '            param83.Value = vi_segmanusu.xcorreoelectronico1
        '        Else
        '            param83.Value = ""
        '        End If
        '        param83.ParameterName = "p_xcorreoelectronico1"

        '        Dim param84 As New SqlClient.SqlParameter
        '        param84.SqlDbType = SqlDbType.VarChar
        '        param84.Size = 50
        '        If vi_segmanusu.xcorreoelectronico2 IsNot Nothing Then
        '            param84.Value = vi_segmanusu.xcorreoelectronico2
        '        Else
        '            param84.Value = ""
        '        End If
        '        param84.ParameterName = "p_xcorreoelectronico2"

        '        Dim param85 As New SqlClient.SqlParameter
        '        param85.SqlDbType = SqlDbType.VarChar
        '        param85.Size = 50
        '        param85.Value = ""
        '        param85.ParameterName = "p_xcorreoelectronico3"

        '        Dim param86 As New SqlClient.SqlParameter
        '        param86.SqlDbType = SqlDbType.VarChar
        '        param86.Size = 50
        '        param86.Value = ""
        '        param86.ParameterName = "p_xcorreoelectronico4"

        '        Dim param87 As New SqlClient.SqlParameter
        '        param87.SqlDbType = SqlDbType.VarChar
        '        param87.Size = 50
        '        param87.Value = ""
        '        param87.ParameterName = "p_xcorreoelectronico5"

        '        Dim param88 As New SqlClient.SqlParameter
        '        param88.SqlDbType = SqlDbType.VarChar
        '        param88.Size = 50
        '        'If vi_segmanusu.xdireccionweb1 IsNot Nothing Then
        '        'param88.Value = vi_segmanusu.xdireccionweb1
        '        'Else
        '        param88.Value = ""
        '        'End If
        '        param88.ParameterName = "p_xdireccionweb1"

        '        Dim param89 As New SqlClient.SqlParameter
        '        param89.SqlDbType = SqlDbType.VarChar
        '        param89.Size = 50
        '        'If vi_segmanusu.xdireccionweb2 IsNot Nothing Then
        '        'param89.Value = vi_segmanusu.xdireccionweb2
        '        'Else
        '        param89.Value = ""
        '        'End If
        '        param89.ParameterName = "p_xdireccionweb2"

        '        Dim param90 As New SqlClient.SqlParameter
        '        param90.SqlDbType = SqlDbType.VarChar
        '        param90.Size = 50
        '        param90.Value = ""
        '        param90.ParameterName = "p_xdireccionweb3"

        '        Dim param91 As New SqlClient.SqlParameter
        '        param91.SqlDbType = SqlDbType.VarChar
        '        param91.Size = 50
        '        param91.Value = ""
        '        param91.ParameterName = "p_xdireccionweb4"

        '        Dim param92 As New SqlClient.SqlParameter
        '        param92.SqlDbType = SqlDbType.VarChar
        '        param92.Size = 50
        '        param92.Value = ""
        '        param92.ParameterName = "p_xdireccionweb5"

        '        Dim param93 As New SqlClient.SqlParameter
        '        param93.SqlDbType = SqlDbType.VarChar
        '        param93.Size = 200
        '        If vi_segmanusu.xtwitter1 IsNot Nothing Then
        '            param93.Value = vi_segmanusu.xtwitter1
        '        Else
        '            param93.Value = ""
        '        End If
        '        param93.ParameterName = "p_xtwitter1"

        '        Dim param94 As New SqlClient.SqlParameter
        '        param94.SqlDbType = SqlDbType.VarChar
        '        param94.Size = 200
        '        param94.Value = ""
        '        param94.ParameterName = "p_xtwitter2"

        '        Dim param95 As New SqlClient.SqlParameter
        '        param95.SqlDbType = SqlDbType.VarChar
        '        param95.Size = 200
        '        param95.Value = ""
        '        param95.ParameterName = "p_xtwitter3"

        '        Dim param96 As New SqlClient.SqlParameter
        '        param96.SqlDbType = SqlDbType.VarChar
        '        param96.Size = 200
        '        param96.Value = ""
        '        param96.ParameterName = "p_xtwitter4"

        '        Dim param97 As New SqlClient.SqlParameter
        '        param97.SqlDbType = SqlDbType.VarChar
        '        param97.Size = 200
        '        param97.Value = ""
        '        param97.ParameterName = "p_xtwitter5"

        '        Dim param98 As New SqlClient.SqlParameter
        '        param98.SqlDbType = SqlDbType.VarChar
        '        param98.Size = 200
        '        If vi_segmanusu.xfacebook1 IsNot Nothing Then
        '            param98.Value = vi_segmanusu.xfacebook1
        '        Else
        '            param98.Value = ""
        '        End If
        '        param98.ParameterName = "p_xfacebook1"

        '        Dim param99 As New SqlClient.SqlParameter
        '        param99.SqlDbType = SqlDbType.VarChar
        '        param99.Size = 200
        '        param99.Value = ""
        '        param99.ParameterName = "p_xfacebook2"

        '        Dim param100 As New SqlClient.SqlParameter
        '        param100.SqlDbType = SqlDbType.VarChar
        '        param100.Size = 200
        '        param100.Value = ""
        '        param100.ParameterName = "p_xfacebook3"

        '        Dim param101 As New SqlClient.SqlParameter
        '        param101.SqlDbType = SqlDbType.VarChar
        '        param101.Size = 200
        '        param101.Value = ""
        '        param101.ParameterName = "p_xfacebook4"

        '        Dim param102 As New SqlClient.SqlParameter
        '        param102.SqlDbType = SqlDbType.VarChar
        '        param102.Size = 200
        '        param102.Value = ""
        '        param102.ParameterName = "p_xfacebook5"

        '        ''campos agregados despues de crear el metodo
        '        ''comunmanpers

        '        Dim f As Integer = _db.ExecuteStoreCommand("exec sp_rnmodificarusuario @p_illamada,@p_idsegmanusuop,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanusu  output,@p_idcomunmanpers,@p_idcomunmancom,@p_idcomunmandir,@p_idsegmanorg,@p_idsegmandep,@p_idsegmancarg,@p_xnombreusuario,@p_xcontrasena,@p_fcreacion,@p_ibloqueado,@p_fultbloqueo,@p_fultiniciosesion,@p_fultcambpass,@p_fultrecuppass,@p_fultpassintfallido,@p_npassintfallido,@p_npassintfallidoacum,@p_idseglogreg,@p_xcedula,@p_xnombres,@p_xapellidos,@p_xnombrecompleto,@p_fnacimiento,@p_xsexo,@p_xnacionalidad,@p_xestatura,@p_xmedestatura,@p_xpeso,@p_xmedpeso,@p_idcomunmanlocalid,@p_idcomunmanestado,@p_idcomunmanpais,@p_idcomunmancont,@p_xdireccion,@p_idcomunmanlocalid2,@p_idcomunmanestado2,@p_idcomunmanpais2,@p_idcomunmancont2,@p_xdireccion2,@p_idcomunmanlocalid3,@p_idcomunmanestado3,@p_idcomunmanpais3,@p_idcomunmancont3,@p_xdireccion3,@p_idcomunmanlocalid4,@p_idcomunmanestado4,@p_idcomunmanpais4,@p_idcomunmancont4,@p_xdireccion4,@p_idcomunmanlocalid5,@p_idcomunmanestado5,@p_idcomunmanpais5,@p_idcomunmancont5,@p_xdireccion5,@p_xtelfhabitacion1,@p_xtelfhabitacion2,@p_xtelfhabitacion3,@p_xtelfhabitacion4,@p_xtelfhabitacion5,@p_xtelfmovil1,@p_xtelfmovil2,@p_xtelfmovil3,@p_xtelfmovil4,@p_xtelfmovil5,@p_xtelfoficina1,@p_xtelfoficina2,@p_xtelfoficina3,@p_xtelfoficina4,@p_xtelfoficina5,@p_xtelffax1,@p_xtelffax2,@p_xtelffax3,@p_xtelffax4,@p_xtelffax5,@p_xcorreoelectronico1,@p_xcorreoelectronico2,@p_xcorreoelectronico3,@p_xcorreoelectronico4,@p_xcorreoelectronico5,@p_xdireccionweb1,@p_xdireccionweb2,@p_xdireccionweb3,@p_xdireccionweb4,@p_xdireccionweb5,@p_xtwitter1,@p_xtwitter2,@p_xtwitter3,@p_xtwitter4,@p_xtwitter5,@p_xfacebook1,@p_xfacebook2,@p_xfacebook3,@p_xfacebook4,@p_xfacebook5", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, param16, param17, param18, param19, param20, param21, param22, param23, param24, param25, param26, param27, param28, param29, param30, param31, param32, param33, param34, param35, param36, param37, param38, param39, param40, param41, param42, param43, param44, param45, param46, param47, param48, param49, param50, param51, param52, param53, param54, param55, param56, param57, param58, param59, param60, param61, param62, param63, param64, param65, param66, param67, param68, param69, param70, param71, param72, param73, param74, param75, param76, param77, param78, param79, param80, param81, param82, param83, param84, param85, param86, param87, param88, param89, param90, param91, param92, param93, param94, param95, param96, param97, param98, param99, param100, param101, param102)


        '        Dim respopera As New respopera
        '        respopera.irespuesta = param4.Value
        '        respopera.xmsjusuario = param5.Value
        '        respopera.xmsjtecnico = param6.Value
        '        If IsNumeric(param8.Value) = True Then
        '            respopera.id = Int(param8.Value)
        '        End If

        '        Return respopera

        '    Catch ex As Exception

        '        Dim respopera As New respopera
        '        respopera.irespuesta = 0
        '        respopera.xmsjusuario = "Error Comuniquese con Sistemas"
        '        respopera.xmsjtecnico = ex.Message
        '        Return respopera
        '    End Try
        'End Function

        '<HttpGet()> _
        <HttpPost()> _
        Public Function Guardar_Perfil_Aplicacion(ByVal idsegmanusu As Decimal, ByVal idsegmanapp As Decimal, ByVal idsegmanperf As Decimal) As respopera
            Try
                Dim respopera As New respopera
                If ConfigurationManager.AppSettings("motoddb") = "sql" Then
                    Dim param1 As New SqlClient.SqlParameter
                    param1.SqlDbType = SqlDbType.VarChar
                    param1.Size = 20
                    param1.Value = "directo"
                    param1.ParameterName = "p_illamada"

                    Dim param2 As New SqlClient.SqlParameter
                    param2.SqlDbType = SqlDbType.Decimal
                    param2.Precision = 18
                    param2.Scale = 0
                    param2.Value = 0
                    param2.ParameterName = "p_idsegmanusuop"

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

                    'Paramestros para el store procedure
                    Dim param8 As New SqlClient.SqlParameter
                    param8.SqlDbType = SqlDbType.Decimal
                    param8.Precision = 18
                    param8.Scale = 0
                    If IsNothing(idsegmanusu) Then
                        param8.Value = 0
                    Else
                        param8.Value = idsegmanusu
                    End If
                    param8.ParameterName = "p_idsegmanusu"

                    Dim param9 As New SqlClient.SqlParameter
                    param9.SqlDbType = SqlDbType.Decimal
                    param9.Precision = 18
                    param9.Scale = 0
                    If IsNothing(idsegmanapp) Then
                        param9.Value = 0
                    Else
                        param9.Value = idsegmanapp
                    End If
                    param9.ParameterName = "p_idsegmanapp"

                    Dim param10 As New SqlClient.SqlParameter
                    param10.SqlDbType = SqlDbType.Decimal
                    param10.Precision = 18
                    param10.Scale = 0
                    If IsNothing(idsegmanapp) Then
                        param10.Value = 0
                    Else
                        param10.Value = idsegmanperf
                    End If
                    param10.ParameterName = "p_idsegmanperf"

                    Dim param11 As New SqlClient.SqlParameter
                    param11.SqlDbType = SqlDbType.Decimal
                    param11.Precision = 18
                    param11.Scale = 0
                    param11.Value = 0
                    param11.ParameterName = "p_idseglogreg"

                    Dim f As Integer = _db.ExecuteStoreCommand("exec sp_rnagregarsegusuperf @p_illamada,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanusu,@p_idsegmanapp,@p_idsegmanperf,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11)


                    respopera.irespuesta = param4.Value
                    respopera.xmsjusuario = param5.Value
                    respopera.xmsjtecnico = param6.Value
                    'respopera.irespuesta = "1"
                    'respopera.xmsjusuario = "Mensaje de Prueba, Verificado"
                    'respopera.xmsjtecnico = "Mensaje de Prueba, Verificado"
                Else
                    respopera = Guardar_Perfil_Aplicacion_Oracle(idsegmanusu, idsegmanapp, idsegmanperf)
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

        '<HttpGet()> _
        <HttpPost()> _
        Public Function Guardar_Perfil_Aplicacion_Oracle(ByVal idsegmanusu As Decimal, ByVal idsegmanapp As Decimal, ByVal idsegmanperf As Decimal) As respopera
            Try
                Dim respopera As New respopera
                Dim param1 As New Client.OracleParameter
                param1.OracleDbType = Client.OracleDbType.Varchar2
                param1.Size = 20
                param1.Value = "directo"
                param1.ParameterName = "p_illamada"

                Dim param2 As New Client.OracleParameter
                param2.OracleDbType = Client.OracleDbType.Decimal
                param2.Precision = 18
                param2.Scale = 0
                param2.Value = 0
                param2.ParameterName = "p_idsegmanusuop"

                Dim param3 As New Client.OracleParameter
                param3.OracleDbType = Client.OracleDbType.Varchar2
                param3.Size = 20
                param3.Value = "seginsoft"
                param3.ParameterName = "p_xnombrecorto"

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

                'Paramestros para el store procedure
                Dim param8 As New Client.OracleParameter
                param8.OracleDbType = Client.OracleDbType.Decimal
                param8.Precision = 18
                param8.Scale = 0
                If IsNothing(idsegmanusu) Then
                    param8.Value = 0
                Else
                    param8.Value = idsegmanusu
                End If
                param8.ParameterName = "p_idsegmanusu"

                Dim param9 As New Client.OracleParameter
                param9.OracleDbType = Client.OracleDbType.Decimal
                param9.Precision = 18
                param9.Scale = 0
                If IsNothing(idsegmanapp) Then
                    param9.Value = 0
                Else
                    param9.Value = idsegmanapp
                End If
                param9.ParameterName = "p_idsegmanapp"

                Dim param10 As New Client.OracleParameter
                param10.OracleDbType = Client.OracleDbType.Decimal
                param10.Precision = 18
                param10.Scale = 0
                If IsNothing(idsegmanapp) Then
                    param10.Value = 0
                Else
                    param10.Value = idsegmanperf
                End If
                param10.ParameterName = "p_idsegmanperf"

                Dim param11 As New Client.OracleParameter
                param11.OracleDbType = Client.OracleDbType.Decimal
                param11.Precision = 18
                param11.Scale = 0
                param11.Value = 0
                param11.ParameterName = "p_idseglogreg"

                Dim xdeclare As String = "DECLARE v_p_illamada varchar2(32767);  iv_p_idsegmanusuop float;  iv_p_xnombrecorto varchar2(32767);  v_p_irespuesta varchar2(32767);  v_p_xmsjusuario varchar2(32767);  v_p_xmsjtecnico varchar2(32767);  v_p_coderrorlog varchar2(32767);iv_p_idsegmanusu float;   v_p_idsegmanapp float;  v_p_idsegmanperf float;  v_p_idseglogreg float; cv_1 sys_refcursor; cv_2 sys_refcursor;  cv_3 sys_refcursor;  cv_4 sys_refcursor;  cv_5 sys_refcursor;  cv_6 sys_refcursor;  cv_7 sys_refcursor;  cv_8 sys_refcursor;  cv_9 sys_refcursor;  cv_10 sys_refcursor;  cv_11 sys_refcursor;"
                Dim xsp As String = "begin sp_rnagregarsegusuperf (:v_p_illamada,:v_p_idsegmanusuop,:v_p_xnombrecorto,:v_p_irespuesta ,:v_p_xmsjusuario ,:v_p_xmsjtecnico ,:v_p_coderrorlog,:v_p_idsegmanusu, :v_p_idsegmanapp, :v_p_idsegmanperf, :v_p_idseglogreg ,cv_1, cv_2, cv_3, cv_4, cv_5, cv_6, cv_7, cv_8, cv_9, cv_10, cv_11); end;"
                Dim f As Integer = _db.ExecuteStoreCommand(xdeclare & xsp, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11)

                respopera.irespuesta = param4.Value.ToString()
                respopera.xmsjusuario = param5.Value.ToString()
                respopera.xmsjtecnico = param6.Value.ToString()
                'respopera.irespuesta = "1"
                'respopera.xmsjusuario = "Mensaje de Prueba, Verificado"
                'respopera.xmsjtecnico = "Mensaje de Prueba, Verificado"
                Return respopera

            Catch ex As Exception

                Dim respopera As New respopera
                respopera.irespuesta = 0
                respopera.xmsjusuario = "Error Comuniquese con Sistemas"
                respopera.xmsjtecnico = ex.Message
                Return respopera
            End Try
        End Function

        'metodo que no actualiza la tabla de aipmanusuconf
        <HttpPost()> _
        Public Function ModificarusuarioPorTipoAccionMasivo(idsegmanusu As Decimal, itipoaccion As String, lista_vi_segusudetperf2 As List(Of vi_segusudetperf2)) As respopera
            Try
                Dim respopera As New respopera


                Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
                Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
                Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")
                Dim auditor As Decimal = ConfigurationManager.AppSettings("auditor")



                If (lista_vi_segusudetperf2.Count > 0) Then
                    Dim segmanusu As New segmanusu
                    Dim segmanusuController As New segmanusuController
                    Dim actualizo As Boolean = False
                    Dim contador As Integer = 0
                    Dim contador_act As Integer = 0
                    Dim contador_tarea As Integer = 0
                    Dim _msj As String = ""


                    Dim aiplogeveController As New aiplogeveController
                    Dim aiplogeve As aiplogeve

                    For i As Integer = 0 To lista_vi_segusudetperf2.Count - 1

                        If (lista_vi_segusudetperf2(i).check) Then

                            segmanusu = segmanusuController.selsegmanusuxid(lista_vi_segusudetperf2(i).idsegmanusu)

                            Dim cantidad As Decimal = 0
                            If (segmanusu IsNot Nothing) Then

                                If (itipoaccion = "INACTIVAR") Then
                                    ''si se trata de inactivar al perito se debe verificar si este posee trabajo pendisnte de ser asi no se puede inactivar
                                    ''se busca si es PERITO
                                    If (lista_vi_segusudetperf2(i).idsegmanperf = peritoint Or lista_vi_segusudetperf2(i).idsegmanperf = peritoext Or lista_vi_segusudetperf2(i).idsegmanperf = peritols) Then
                                        Dim vi_aipinsencController As New vi_aipinsencController
                                        cantidad = vi_aipinsencController.ObtenerCantViAipinsencPorPeritoYEstatus(segmanusu.idsegmanusu)
                                    End If

                                End If
                                If cantidad = 0 Then

                                    If (itipoaccion = "ACTIVAR") Then
                                        'se almacena false para activar al usuario
                                        segmanusu.ibloqueado = False
                                    ElseIf (itipoaccion = "INACTIVAR") Then
                                        'se almacena true para desactivar al usuario
                                        segmanusu.ibloqueado = True
                                    End If

                                    actualizo = segmanusuController.modsegmanusu(segmanusu.idsegmanusu, segmanusu.idcomunmanpers, segmanusu.idcomunmancom, _
                                      segmanusu.idcomunmandir, segmanusu.idsegmanorg, segmanusu.idsegmandep, _
                                      segmanusu.idsegmancarg, segmanusu.xnombreusuario, segmanusu.xcontrasena, _
                                      segmanusu.fcreacion, segmanusu.ibloqueado, segmanusu.fultbloqueo, _
                                      segmanusu.fultiniciosesion, segmanusu.fultcambpass, segmanusu.fultrecuppass, _
                                      segmanusu.fultpassintfallido, segmanusu.npassintfallido, segmanusu.npassintfallidoacum, _
                                      segmanusu.idseglogreg)

                                    If (actualizo = False) Then
                                        contador = contador + 1
                                    Else

                                        contador_act = contador_act + 1

                                        aiplogeve = New aiplogeve
                                        aiplogeve.xnomlogeve = "ACTIVACIÓN DEL " & lista_vi_segusudetperf2(i).xnombreperf & " Código usuario: " & segmanusu.idsegmanusu.ToString()
                                        aiplogeve.fcrealogeve = DateTime.Now

                                        If (lista_vi_segusudetperf2(i).idsegmanperf = peritoint Or lista_vi_segusudetperf2(i).idsegmanperf = peritoext) Then
                                            aiplogeve.iamblogeve = "SEGURIDAD PERITO"
                                        ElseIf (lista_vi_segusudetperf2(i).idsegmanperf = auditor) Then
                                            aiplogeve.iamblogeve = "SEGURIDAD AUDITOR"
                                        End If
                                        aiplogeve.idsegmanusu = idsegmanusu

                                        aiplogeveController.insaiplogeve(aiplogeve)
                                    End If

                                Else
                                    contador = contador + 1
                                    contador_tarea = contador_tarea + 1
                                End If
                            Else
                                contador = contador + 1
                            End If


                        End If
                    Next

                    If (contador > 0) Then
                        respopera.irespuesta = "1"
                        If (itipoaccion = "ACTIVAR") Then
                            _msj = "Se activaron " & contador_act.ToString() & "  usuarios con éxito y " & contador & " con error"
                        ElseIf (itipoaccion = "INACTIVAR") Then
                            _msj = "Se inactivaron " & contador_act.ToString() & "  usuarios con éxito y " & contador & " con error"
                        End If
                        If (contador_tarea > 0) Then
                            _msj = _msj & " (algunos poseen tareas pendientes por ejecutar)."
                        End If
                        respopera.xmsjusuario = _msj

                    Else
                        If (itipoaccion = "ACTIVAR") Then
                            _msj = "Se activaron " & contador_act.ToString() & "  usuarios con éxito."
                        ElseIf (itipoaccion = "INACTIVAR") Then
                            _msj = "Se inactivaron " & contador_act.ToString() & "  usuarios con éxito."
                        End If
                    End If

                    respopera.irespuesta = "1"
                    respopera.xmsjusuario = _msj
                Else
                    respopera.irespuesta = "0"
                    respopera.xmsjusuario = "Debe enviar al menos un usuario para " & itipoaccion.ToLower
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

        'metodo igual a ModificarusuarioPorTipoAccionMasivo perop adicionalmente actualiza la tabla de aipmanusuconf
        <HttpPost()> _
        Public Function ModificarusuarioPorTipoAccionMasivo2(idsegmanusu As Decimal, itipoaccion As String, xfinisusmanusuconf As String, xffinsusmanusuconf As String, lista_vi_segusudetperf2 As List(Of vi_segusudetperf2)) As respopera
            Try


                Dim respopera As New respopera


                Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
                Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
                Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")
                Dim auditor As Decimal = ConfigurationManager.AppSettings("auditor")

                Dim finisusmanusuconf, ffinsusmanusuconf As DateTime
                If IsDate(xfinisusmanusuconf) = True Then
                    finisusmanusuconf = CDate(xfinisusmanusuconf)
                End If
                If IsDate(xffinsusmanusuconf) = True Then
                    ffinsusmanusuconf = CDate(xffinsusmanusuconf)
                End If

                Using tran1 As New TransactionScope

                    If (lista_vi_segusudetperf2.Count > 0) Then
                        Dim segmanusu As New segmanusu
                        Dim segmanusuController As New segmanusuController
                        Dim actualizo As Boolean = False
                        Dim contador As Integer = 0
                        Dim contador_act As Integer = 0
                        Dim contador_tarea As Integer = 0
                        Dim _msj As String = ""


                        Dim aiplogeveController As New aiplogeveController
                        Dim aiplogeve As aiplogeve

                        If (itipoaccion = "SUSPENDER") Then

                            If (finisusmanusuconf = CDate("01/01/1900")) Then
                                respopera.irespuesta = "0"
                                respopera.xmsjusuario = "Fecha de inicio de la suspensión es requerida."
                                Return respopera
                            End If

                            If (ffinsusmanusuconf = CDate("01/01/1900")) Then
                                respopera.irespuesta = "0"
                                respopera.xmsjusuario = "Fecha de fin de la suspensión es requerida."
                                Return respopera
                            End If

                            If (finisusmanusuconf > ffinsusmanusuconf) Then
                                respopera.irespuesta = "0"
                                respopera.xmsjusuario = "Fecha de inicio de la suspensión debe ser menor a la fecha de fin de la suspensión."
                                Return respopera
                            End If

                            If (ffinsusmanusuconf <= Date.Now) Then
                                respopera.irespuesta = "0"
                                respopera.xmsjusuario = "Fecha de fin de la suspensión debe ser mayor a la fecha actual."
                                Return respopera
                            End If

                        End If

                        For i As Integer = 0 To lista_vi_segusudetperf2.Count - 1

                            If (lista_vi_segusudetperf2(i).check) Then

                                segmanusu = segmanusuController.selsegmanusuxid(lista_vi_segusudetperf2(i).idsegmanusu)

                                Dim cantidad As Decimal = 0
                                If (segmanusu IsNot Nothing) Then

                                    If (itipoaccion = "INACTIVAR") Then
                                        ''si se trata de inactivar al perito se debe verificar si este posee trabajo pendisnte de ser asi no se puede inactivar
                                        ''se busca si es PERITO
                                        If (lista_vi_segusudetperf2(i).idsegmanperf = peritoint Or lista_vi_segusudetperf2(i).idsegmanperf = peritoext Or lista_vi_segusudetperf2(i).idsegmanperf = peritols) Then
                                            Dim vi_aipinsencController As New vi_aipinsencController
                                            cantidad = vi_aipinsencController.ObtenerCantViAipinsencPorPeritoYEstatus(segmanusu.idsegmanusu)
                                        End If

                                    End If
                                    If cantidad = 0 Then

                                        If (itipoaccion = "ACTIVAR") Then
                                            'se almacena false para activar al usuario
                                            segmanusu.ibloqueado = False
                                        ElseIf (itipoaccion = "INACTIVAR" Or itipoaccion = "SUSPENDER") Then
                                            'se almacena true para desactivar al usuario
                                            segmanusu.ibloqueado = True
                                        End If

                                        'actualizo = segmanusuController.modsegmanusu(segmanusu.idsegmanusu, segmanusu.idcomunmanpers, segmanusu.idcomunmancom, _
                                        '  segmanusu.idcomunmandir, segmanusu.idsegmanorg, segmanusu.idsegmandep, _
                                        '  segmanusu.idsegmancarg, segmanusu.xnombreusuario, segmanusu.xcontrasena, _
                                        '  segmanusu.fcreacion, segmanusu.ibloqueado, segmanusu.fultbloqueo, _
                                        '  segmanusu.fultiniciosesion, segmanusu.fultcambpass, segmanusu.fultrecuppass, _
                                        '  segmanusu.fultpassintfallido, segmanusu.npassintfallido, segmanusu.npassintfallidoacum, _
                                        '  segmanusu.idseglogreg)



                                        'NOTA: agregar el metodo para la tabla de aipmanusuconf, enviar la fecha de suspension de aplicar                                       
                                        Dim inspeccionController As New InspeccionController
                                        respopera = inspeccionController.GuardarUsuarioConfiguracion(lista_vi_segusudetperf2(i).idsegmanusu, finisusmanusuconf, ffinsusmanusuconf, itipoaccion)
                                        If (respopera.irespuesta = "1") Then
                                            contador_act = contador_act + 1

                                            aiplogeve = New aiplogeve
                                            aiplogeve.xnomlogeve = "ACTIVACIÓN DEL " & lista_vi_segusudetperf2(i).xnombreperf & " Código usuario: " & segmanusu.idsegmanusu.ToString()
                                            aiplogeve.fcrealogeve = DateTime.Now

                                            If (lista_vi_segusudetperf2(i).idsegmanperf = peritoint Or lista_vi_segusudetperf2(i).idsegmanperf = peritoext) Then
                                                aiplogeve.iamblogeve = "SEGURIDAD PERITO"
                                            ElseIf (lista_vi_segusudetperf2(i).idsegmanperf = auditor) Then
                                                aiplogeve.iamblogeve = "SEGURIDAD AUDITOR"
                                            End If
                                            aiplogeve.idsegmanusu = idsegmanusu

                                            aiplogeveController.insaiplogeve(aiplogeve)
                                        Else
                                            contador = contador + 1
                                        End If


                                    Else
                                        contador = contador + 1
                                        contador_tarea = contador_tarea + 1
                                    End If
                                Else
                                    contador = contador + 1
                                End If


                            End If
                        Next

                        If (contador > 0) Then
                            If (contador_act > 0) Then
                                respopera.irespuesta = "1"
                            Else
                                respopera.irespuesta = "0"
                            End If

                            If (itipoaccion = "ACTIVAR") Then
                                _msj = "Se activaron " & contador_act.ToString() & "  usuarios con éxito y " & contador & " con error"
                            ElseIf (itipoaccion = "INACTIVAR") Then
                                _msj = "Se inactivaron " & contador_act.ToString() & "  usuarios con éxito y " & contador & " con error"
                            ElseIf (itipoaccion = "SUSPENDER") Then
                                _msj = "Se suspendieron " & contador_act.ToString() & "  usuarios con éxito y " & contador & " con error"
                            End If
                            If (contador_tarea > 0) Then
                                _msj = _msj & " (algunos poseen tareas pendientes por ejecutar)."
                            End If
                            respopera.xmsjusuario = _msj

                        Else
                            respopera.irespuesta = "1"
                            If (itipoaccion = "ACTIVAR") Then
                                _msj = "Se activaron " & contador_act.ToString() & "  usuarios con éxito."
                            ElseIf (itipoaccion = "INACTIVAR") Then
                                _msj = "Se inactivaron " & contador_act.ToString() & "  usuarios con éxito."
                            ElseIf (itipoaccion = "SUSPENDER") Then
                                _msj = "Se suspendieron " & contador_act.ToString() & "  usuarios con éxito."
                            End If
                        End If

                        'respopera.irespuesta = "1"
                        'respopera.xmsjusuario = _msj


                    Else
                        respopera.irespuesta = "0"
                        respopera.xmsjusuario = "Debe enviar al menos un usuario para " & itipoaccion.ToLower
                    End If


                    If (respopera.irespuesta = "1") Then
                        tran1.Complete()
                    End If

                End Using

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
        Public Function ObtenerCboSucursalYPrincipal() As List(Of vi_combosegmanorg)
            Try

                Dim vi_combosegmanorgController As New vi_combosegmanorgController
                Dim lista_vi_combosegmanorg As New List(Of vi_combosegmanorg)
                Dim _lista_vi_combosegmanorg1 As New List(Of vi_combosegmanorg)
                lista_vi_combosegmanorg = vi_combosegmanorgController.selvi_combosegmanorgsinsel()

                Dim vi_combosegmanorg As New vi_combosegmanorg
                With vi_combosegmanorg
                    .idsegmanorg = 0
                    .xnombrecomercial = "SELECCIONE"
                End With
                _lista_vi_combosegmanorg1.Insert(0, vi_combosegmanorg)

                Dim comunconfvalorController As New comunconfvalorController
                Dim lista_comunconfvalor As New List(Of comunconfvalor)
                lista_comunconfvalor = comunconfvalorController.selcomunconfvalorxconceptosinsel("IDSUCPRINCIPAL")

                If (lista_comunconfvalor.Count > 0) Then
                    For i As Integer = 0 To lista_comunconfvalor.Count - 1
                        vi_combosegmanorg = New vi_combosegmanorg
                        vi_combosegmanorg.idsegmanorg = lista_comunconfvalor(i).xvalorcodigo
                        vi_combosegmanorg.xnombrecomercial = lista_comunconfvalor(i).xvalordescripcion
                        _lista_vi_combosegmanorg1.Insert(i + 1, vi_combosegmanorg)
                    Next
                End If

                Dim count As Integer = _lista_vi_combosegmanorg1.Count

                If (lista_vi_combosegmanorg.Count > 0) Then
                    For i As Integer = 0 To lista_vi_combosegmanorg.Count - 1

                        vi_combosegmanorg = New vi_combosegmanorg
                        vi_combosegmanorg.idsegmanorg = lista_vi_combosegmanorg(i).idsegmanorg
                        vi_combosegmanorg.xnombrecomercial = lista_vi_combosegmanorg(i).xnombrecomercial
                        _lista_vi_combosegmanorg1.Insert(count, vi_combosegmanorg)
                        count = count + 1

                    Next
                End If


                Return _lista_vi_combosegmanorg1

            Catch ex As Exception
                Dim _lista_vi_combosegmanorg As New List(Of vi_combosegmanorg)
                Dim vi_combosegmanorg As New vi_combosegmanorg
                With vi_combosegmanorg
                    .idsegmanorg = 0
                    .xnombrecomercial = "SELECCIONE"
                End With
                _lista_vi_combosegmanorg.Insert(0, vi_combosegmanorg)
                Return _lista_vi_combosegmanorg
            End Try
        End Function

        <HttpPost()> _
        Public Function ObtenerCboSucursal() As List(Of vi_combosegmanorg)
            Try

                Dim vi_combosegmanorgController As New vi_combosegmanorgController
                Dim lista_vi_combosegmanorg As New List(Of vi_combosegmanorg)
                Dim _lista_vi_combosegmanorg1 As New List(Of vi_combosegmanorg)
                lista_vi_combosegmanorg = vi_combosegmanorgController.selvi_combosegmanorgsinsel()

                Dim vi_combosegmanorg As New vi_combosegmanorg
                With vi_combosegmanorg
                    .idsegmanorg = 0
                    .xnombrecomercial = "SELECCIONE"
                End With
                _lista_vi_combosegmanorg1.Insert(0, vi_combosegmanorg)

                Dim count As Integer = _lista_vi_combosegmanorg1.Count
                If (lista_vi_combosegmanorg.Count > 0) Then
                    For i As Integer = 0 To lista_vi_combosegmanorg.Count - 1

                        vi_combosegmanorg = New vi_combosegmanorg
                        vi_combosegmanorg.idsegmanorg = lista_vi_combosegmanorg(i).idsegmanorg
                        vi_combosegmanorg.xnombrecomercial = lista_vi_combosegmanorg(i).xnombrecomercial
                        _lista_vi_combosegmanorg1.Insert(count, vi_combosegmanorg)
                        count = count + 1

                    Next
                End If

                Return _lista_vi_combosegmanorg1

            Catch ex As Exception
                Dim _lista_vi_combosegmanorg As New List(Of vi_combosegmanorg)
                Dim vi_combosegmanorg As New vi_combosegmanorg
                With vi_combosegmanorg
                    .idsegmanorg = 0
                    .xnombrecomercial = "SELECCIONE"
                End With
                _lista_vi_combosegmanorg.Insert(0, vi_combosegmanorg)
                Return _lista_vi_combosegmanorg
            End Try
        End Function


    End Class
End Namespace

