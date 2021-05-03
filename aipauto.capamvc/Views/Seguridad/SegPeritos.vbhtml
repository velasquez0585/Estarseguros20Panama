@Code
    ViewData("Title") = "Mantenimiento de usuarios peritos"
    ViewData("Message") = "Mantenimiento de usuarios peritos,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            Mantenimiento de usuarios peritos.
        </p>
    </div>
</section>
End Section

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/seguridad/vi_segmanusu.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/seguridad/vi_segusudetperf2.js")
@Html.Action("SegPeritos", "Seguridad", New With {.esvistaparcial = True})