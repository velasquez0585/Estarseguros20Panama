@Code
    ViewData("Title") = "Inspecciones por procesar"
    ViewData("Message") = "Inspecciones por procesar"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p> 
            Consulte todas las inspecciones almacenadas en el sistema
        </p>
    </div>
</section>
End Section

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinsajussinmobr.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinslimsinrepu.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinslimsinmobr.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinslimsin.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinslimsin.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinsajusanexrepu.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinsajusanexmobr.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsajusanex.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinsajussinrepu.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinslimsus.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinslimsus.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsajussin.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinsajussin.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsrest.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssussse.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssusssm.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssusacc.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssusrepuest.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssusmotiv.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsrestsse.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsrestssm.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsrestrepuest.js") 
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinsenc.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinslimsusmobr.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/aipmanveh.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsenc.js")   
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinslimsus.js")  
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinslimsusrepu.js")  
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssus.js")   

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/peraipdatosdeclara.js")

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinsenc.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsenc.js") 

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsfoto.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipextsintagenda.js")   

@Styles.Render("~/publico/scripts/terceros/video-js/video-js.css")
@Scripts.Render("~/publico/scripts/terceros/video-js/videojs-ie8.min.js")
@Scripts.Render("~/publico/scripts/terceros/video-js/video-js.js")

@Html.Action("InspeccionProcesar", "Inspeccion", New With {.esvistaparcial = True})