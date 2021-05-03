@Code
    ViewData("Title") = "Log de Eventos"
    ViewData("Message") = "Log de Eventos,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            Trazabilidad de actividades de los usuarios del sistema.
        </p>
    </div>
</section>
End Section

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/log/aiplogeve.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/log/vi_aiplogeve.js") 

@Html.Action("LogEve", "Log", New With {.esvistaparcial = True})