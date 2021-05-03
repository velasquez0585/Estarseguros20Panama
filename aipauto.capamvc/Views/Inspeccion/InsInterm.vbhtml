@Code
    ViewData("Title") = "Últimas inspecciones solicitadas"
    ViewData("Message") = "Últimas inspecciones solicitadas"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p> 
            Verifica las ultimas inspección solicitadas, tanto siniestros como suscripción.            
            Crea siniestros, que serán agregados de forma automática como Inspecciones.
        </p>
    </div>
</section>
End Section   
    


@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_intermediacion.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinstotalpers.js") 
@*@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinsajussin.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsrest.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssussse.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssusssm.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssusacc.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssusrepuest.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssusmotiv.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsrestsse.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsrestssm.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsrestrepuest.js")*@ 
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinsenc.js")
@*@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/aipmanveh.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/vi_aipmanveh.js")*@
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsenc.js")   
@*@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinslimsus.js")  
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinslimsusrepu.js")  
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssus.js")   
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsfoto.js")*@ 


@*@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinssinmotiv.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinssinmobr.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinssinrepu.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinssin.js")*@


@*@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssin.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssinmobr.js") 
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssinmotiv.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinssinrepu.js")

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/aipmanvehver.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/vi_aipmanvehver.js")*@


@Scripts.Render("~/publico/scripts/sitfx/viewmodels/agenda/aipactivperi.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/agenda/vi_aipactivperi.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/agenda/vi_aipactivperidet.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsenc.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/persaipinssinicotiz.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipextsintagenda.js")   
@Scripts.Render("~/publico/scripts/terceros/jquery.numeric.js")

 

@Html.Action("InsIntermediacion", "Inspeccion", New With {.esvistaparcial = True})