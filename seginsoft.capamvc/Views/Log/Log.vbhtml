@Code
    ViewData("Title") = "Log"
    ViewData("Message") = "Log"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
           Puede consultar todas los errores, eventos y registros realizados en las aplicaciones.
        </p>
    </div>
</section>
End Section

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/logs/seglogreg.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/logs/seglogeve.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/logs/seglogerr.js")
    
@Html.Action("Log", "Log", New With {.esvistaparcial = True})