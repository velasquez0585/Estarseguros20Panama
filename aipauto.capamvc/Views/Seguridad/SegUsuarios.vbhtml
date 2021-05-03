@Code
    ViewData("Title") = "Mantenimiento de usuarios"
    ViewData("Message") = "Mantenimiento de usuarios,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            Control y administracion de usuarios del sistema.
        </p>
    </div>
</section>
End Section

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/seguridad/vi_segmanusu.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/seguridad/vi_segusudetperf2.js")
@Html.Action("SegUsuarios", "Seguridad", New With {.esvistaparcial = True})