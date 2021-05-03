@Code
    ViewData("Title") = "Administrar actividades de Peritos"
    ViewData("Message") = "Administrar actividades de Peritos,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            Administración de Actividades de Peritos.
        </p>
    </div>
</section>
End Section

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/inspeccion/vi_aipinsenc.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/seguridad/vi_segusudetperf2.js")
@Html.Action("InsAdminActiPeritMasiva", "Inspeccion", New With {.esvistaparcial = True})