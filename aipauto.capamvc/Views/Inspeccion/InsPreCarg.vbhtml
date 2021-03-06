@Code
    ViewData("Title") = "Pre-Carga de siniestros y suscripciones"
    ViewData("Message") = "Pre-Carga de siniestros y suscripciones"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p> 
            Crear siniestros y suscripciones, para posteriormente poder realizar la inspección respectiva
        </p>
    </div>
</section>
End Section   
    


@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_intermediacion.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinstotalpers.js") 
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/aipinsenc.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsenc.js")   
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/agenda/aipactivperi.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/agenda/vi_aipactivperi.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/agenda/vi_aipactivperidet.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsenc.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/persaipinssinicotiz.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipextsintagenda.js")   
@Scripts.Render("~/publico/scripts/terceros/jquery.numeric.js")

 

@Html.Action("InsPreCarg", "Inspeccion", New With {.esvistaparcial = True})