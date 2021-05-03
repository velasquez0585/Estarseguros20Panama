@Code
    ViewData("Title") = "Info"
    ViewData("Message") = "Acerca de AicWeb,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            AipAuto es una Aplicaci&oacute;n Web Integral de Peritaje que controla y administra todo el proceso 
            de inspecciones sobre vehiculos asegurados que realizan los peritos"
        </p>
    </div>
</section>
End Section

<article>
    <p style="text-align:justify;">
            AipAuto es una Aplicaci&oacute;n Web desarrollada con la finalidad de administrar todas 
            las inspecciones realizadas por los peritos sobre vehiculos asegurados, permitiendo el control de dichas inspecciones 
            totalmente en l&oacute;nea desde cualquier sitio con Internet brindando mayor facilidad y flexibilidad en la consecuci&oacute;n del 
            proceso.
    </p>
</article>

<aside>
    <h3>Otros enlaces</h3>
    <p>
        Enlaces locales
    </p>
    <ul>
        <li>@Html.ActionLink("Inicio", "Index", "Home")</li>
        <li>@Html.ActionLink("Contactanos", "Contactanos", "Home")</li>
    </ul>
    <p>
        Enlaces externos
    </p>
    <ul>
        <li><a href="http://www.sitfx.com" target="_blank">www.sitfx.com</a></li>
        <li><a href="http://twitter.com/sitfx" target="_blank">Twitter</a></li>
        <li><a href="http://facebook.com/sitfx" target="_blank">Facebook</a></li>
        <li><a href="https://plus.google.com/b/104643965683895370864/104643965683895370864/about/op/iph" target="_blank">Google</a></li>
    </ul>
</aside>