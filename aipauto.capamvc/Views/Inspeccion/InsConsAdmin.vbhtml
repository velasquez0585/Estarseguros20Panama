@Code
    ViewData("Title") = "Consulta de Inspecciones"
    ViewData("Message") = "Consulta de Inspecciones"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p> 
            Consulte todas las inspecciones para eliminar
        </p>
    </div>
</section>
End Section

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinsenc.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/aipmanveh.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsenc.js")   
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssus.js")  
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssin.js")   
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsfoto.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipextsintagenda.js")   
@Styles.Render("~/publico/scripts/terceros/video-js/video-js.css")
@Scripts.Render("~/publico/scripts/terceros/video-js/videojs-ie8.min.js")
@Scripts.Render("~/publico/scripts/terceros/video-js/video-js.js")

@Html.Action("InspeccionConsultaAdmin", "Inspeccion", New With {.esvistaparcial = True})