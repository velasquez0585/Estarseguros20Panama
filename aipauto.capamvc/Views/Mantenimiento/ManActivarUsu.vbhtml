@Code
    ViewData("Title") = "Activar Usuarios"
    ViewData("Message") = "Activar Usuarios,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            Control y administración de Estado de Peritos y Auditores del sistema.
        </p>
    </div>
</section>
End Section

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/seguridad/vi_segusudetperf2.js")
@Html.Action("ManActivarUsu", "Mantenimiento", New With {.esvistaparcial = True})