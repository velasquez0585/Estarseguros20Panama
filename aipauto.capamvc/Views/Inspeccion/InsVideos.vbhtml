@Code
    ViewData("Title") = "Inspecciones Videos"
    ViewData("Message") = "Inspecciones Videos"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p> 
            Visualizar Videos cargado desde la aplicación Móvil
        </p>
    </div>
</section>
End Section 

@Styles.Render("~/publico/scripts/terceros/video-js/video-js.css")
@Scripts.Render("~/publico/scripts/terceros/video-js/videojs-ie8.min.js")
@Scripts.Render("~/publico/scripts/terceros/video-js/video-js.js")

@Html.Action("InspeccionVideos", "Inspeccion", New With {.esvistaparcial = True})