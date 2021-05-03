Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Threading.Tasks

'Namespace aipauto.funciones

'internal class VideoStream
'{
'    private readonly string videoName;

'    public VideoStream(string videoName)
'    {
'        this.videoName = videoName;
'    }

'    public async Task WriteToStream(Stream outputStream, HttpContent content, TransportContext context)
'    {
'        //string videoFileName = "TestData\\Videos\\" + videoName + ".mp4";
'        string videoFileName = "C:\\sitfxarchivos\\videos\\" + videoName + ".mp4";
'        try
'        {
'            var buffer = new byte[65536];

'            using (var video = File.Open(videoFileName, FileMode.Open, FileAccess.Read))
'            {
'                var length = (int)video.Length;
'                var bytesRead = 1;

'                while (length > 0 && bytesRead > 0)
'                {
'                    bytesRead = video.Read(buffer, 0, Math.Min(length, buffer.Length));
'                    await outputStream.WriteAsync(buffer, 0, bytesRead);
'                    length -= bytesRead;
'                }
'            }
'        }
'        catch (Exception ex)
'        {
'            return;
'        }
'        finally
'        {
'            outputStream.Close();
'        }
'    }
'}
'End Namespace