@Code
    ViewData("Title") = "Agenda de los Peritos"
    ViewData("Message") = ""
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            Administracion y planificacion de peritajes
        </p>
    </div>
</section>
End Section 

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/agenda/aipactivperi.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/agenda/vi_aipactivperi.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/agenda/vi_aipactivperidet.js") 
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsenc.js") 
@Scripts.Render("~/publico/scripts/terceros/jquery.numeric.js") 

@*@Scripts.Render("~/publico/scripts/colorpicker.js")
@Styles.Render("~/publico/scripts/colorpicker.css")*@
@Html.Action("Agenda", "Agenda", New With {.esvistaparcial = True})
