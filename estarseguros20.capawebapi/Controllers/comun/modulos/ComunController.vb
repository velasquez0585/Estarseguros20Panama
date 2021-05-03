Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.configuracion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports System.IO
Imports funciones.lib.directorios

Public Class ComunController
    Inherits ApiController

    '
    ' GET: /Comun
    <HttpPost()> _
    Public Function RedimensionarImagen(nuevo_ancho As Integer, nueva_altura As Integer, imagen_bytes As Byte()) As Byte()

        Try
            'declaro variables a utilizar
            Dim respuesta As Boolean = False
            'Dim nancho_nuevo As Integer = nuevo_ancho 'nuevo ancho de imagen
            'Dim naltura_nueva As Integer = nueva_altura 'nuevo alto de imagen
            Dim ruta_guardar As String = ""
            Dim nuevo_x As Integer = 0
            Dim nuevo_y As Integer = 0
            Dim exite_directorio As String = False

            Dim ruta_dir As String = HttpContext.Current.Server.MapPath("~/tmp")

            exite_directorio = crear(ruta_dir)

            If exite_directorio Then
                'Establezco la ruta donde se guardara la nueva imagen
                ruta_guardar = HttpContext.Current.Server.MapPath("~/tmp/") & "tmp.jpg"
            End If

            'se convierte los bytes a system io stream
            Dim imagen_stream As System.IO.Stream = New System.IO.MemoryStream(imagen_bytes)

            'Para obtener la altura proporcional al ancho requerido se realiza la siguiente operacion
            '(ancho_deseado * alto_original) / ancho_original
            'lo que daria la altura prorporcional al alto de la imagen
            Dim imagen_subida As System.Drawing.Bitmap = System.Drawing.Bitmap.FromStream(imagen_stream)
            Dim imagen_subida_ancho As Integer = imagen_subida.Width
            Dim imagen_subida_alto As Integer = imagen_subida.Height


            If nuevo_ancho < nueva_altura Then
                'se obtiene la nueva dimension de la altura
                nueva_altura = (nuevo_ancho * imagen_subida_alto) / imagen_subida_ancho
            Else
                'se obtiene la nueva dimension del ancho
                nuevo_ancho = (nueva_altura * imagen_subida_ancho) / imagen_subida_alto
            End If

            'Creo una nueva imagen basada en la que se esta subiendo
            'Establezco la resolucion a 100 pixeles por pulgada
            Dim imagen_nueva As System.Drawing.Bitmap = New System.Drawing.Bitmap(nuevo_ancho, nueva_altura, System.Drawing.Imaging.PixelFormat.Format24bppRgb)
            imagen_nueva.SetResolution(100, 100)


            'Centro la imagen en coordenada X,Y
            nuevo_y = Int((nueva_altura - nueva_altura) / 2)
            nuevo_x = Int((nuevo_ancho - nuevo_ancho) / 2)


            Dim nuevo_grafico As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(imagen_nueva)
            Try
                nuevo_grafico.Clear(System.Drawing.Color.White)
                nuevo_grafico.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
                nuevo_grafico.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                nuevo_grafico.DrawImage(imagen_subida, nuevo_x, nuevo_y, nuevo_ancho, nueva_altura)
                imagen_nueva.Save(ruta_guardar, System.Drawing.Imaging.ImageFormat.Jpeg)
            Catch ex As Exception
                'lbl_error.Text = ex.ToString
            Finally
                'Liberamos los recursos de todas las clases utilizadas
                imagen_subida.Dispose()
                imagen_nueva.Dispose()
                nuevo_grafico.Dispose()
            End Try


            Dim imagen_resp As Byte()
            If File.Exists(ruta_guardar) Then
                respuesta = True
                imagen_resp = System.IO.File.ReadAllBytes(ruta_guardar)
            Else
                imagen_resp = Convert.FromBase64String("")
            End If

            Return imagen_resp

        Catch ex As Exception
            Return Convert.FromBase64String("")
        End Try
    End Function

    <HttpPost()> _
    Public Function GirarImagen(grados As Decimal, imagen_bytes As Byte()) As Byte()
        'Grados se envia -90 si se quiere girar a la derecha
        'Grados se envia 90 si se quiere girar a la izquierda
        Try
            Dim exite_directorio As String = False
            Dim ruta_guardar As String = ""

            Dim ruta_dir As String = HttpContext.Current.Server.MapPath("~/tmp")
            exite_directorio = crear(ruta_dir)

            If exite_directorio Then
                'Establezco la ruta donde se guardara la nueva imagen
                ruta_guardar = HttpContext.Current.Server.MapPath("~/tmp/") & "tmp.jpg"

                'variables de verificacion de existencia de imagenes giradas
                Dim existe_original As Boolean = False

                'Dim img_byte As Byte() = File.ReadAllBytes(ruta_img_original)

                'Asignamos imagen original
                Dim imagen_stream As System.IO.Stream = New System.IO.MemoryStream(imagen_bytes)
                Dim bmp As System.Drawing.Bitmap = System.Drawing.Bitmap.FromStream(imagen_stream)


                'Serie de Puntos para conocer las esquinas de la imagen
                Dim lrg As Single = bmp.Width
                Dim alt As Single = bmp.Height
                Dim esq As System.Drawing.Point() = {New System.Drawing.Point(0, 0), New System.Drawing.Point(lrg, 0), New System.Drawing.Point(0, alt), New System.Drawing.Point(lrg, alt)}

                ' Establece centro del Rectangulo
                Dim cx As Single = lrg / 2
                Dim cy As Single = alt / 2
                Dim i As Long

                For i = 0 To 3
                    esq(i).X -= cx
                    esq(i).Y -= cy
                Next i

                Dim PI As Decimal = 3.1416

                ' Rotacion.
                Dim angtheta As Single = Single.Parse(grados) * PI / 180.0
                Dim sintheta As Single = Math.Sin(angtheta)
                Dim costheta As Single = Math.Cos(angtheta)
                Dim X As Single
                Dim Y As Single

                For i = 0 To 3
                    X = esq(i).X
                    Y = esq(i).Y
                    esq(i).X = X * costheta + Y * sintheta
                    esq(i).Y = -X * sintheta + Y * costheta
                Next i

                ' Translacion X >= 0 and Y >=0 para todas las esquinas.

                Dim xmin As Single = esq(0).X
                Dim ymin As Single = esq(0).Y
                For i = 1 To 3
                    If xmin > esq(i).X Then xmin = esq(i).X
                    If ymin > esq(i).Y Then ymin = esq(i).Y
                Next i
                For i = 0 To 3
                    esq(i).X -= xmin
                    esq(i).Y -= ymin
                Next i

                ' Crear bitmap de salida y objetco graphics.
                Dim bmpSalida As New System.Drawing.Bitmap(CInt(-2 * xmin), CInt(-2 * ymin), System.Drawing.Imaging.PixelFormat.Format24bppRgb)
                bmpSalida.SetResolution(100, 100)
                Dim grSalida As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(bmpSalida)

                'Preservar Ultima Esquina
                ReDim Preserve esq(2)

                'Pintamos resultado de imagen Girada.
                grSalida.DrawImage(bmp, esq)
                bmpSalida.Save(ruta_guardar, System.Drawing.Imaging.ImageFormat.Jpeg)

                'se verifica si cada imagen esta existente y se valida la posicion de la lista para 
                'alamacenar true o false en la variable perteneciente
                'se verifica si existe la imagen para devolver sus bytes
                Dim ArchivoByte As Byte() = Nothing
                If File.Exists(ruta_guardar) Then
                    existe_original = True
                    ArchivoByte = File.ReadAllBytes(ruta_guardar)
                End If

                Return ArchivoByte
            End If

            Return Nothing

        Catch ex As Exception

            Return Convert.FromBase64String("")

        End Try

    End Function

    <HttpGet()> _
        <HttpPost()> _
    Public Function ObtenerConexionApiPorNombre(xnombreconexion As String) As String
        Dim xruta As String = ""
        Try
            xruta = ConfigurationManager.AppSettings(xnombreconexion)

            Return xruta
        Catch ex As Exception
            xruta = ""
            Return xruta
        End Try

    End Function


End Class