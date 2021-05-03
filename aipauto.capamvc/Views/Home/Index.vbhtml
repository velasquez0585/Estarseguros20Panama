@Code
    ViewData("Title") = "Inicio"
    ViewData("Message") = "Bienvenido(a),"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            AipAuto es una Aplicaci&oacute;n Web Integral de Peritaje que controla y administra todo el proceso 
            de inspecciones sobre vehiculos asegurados que realizan los peritos.
        </p>
    </div>
</section>
End Section

@If Request.IsAuthenticated Then
    @<h3>Funci&oacute;n general de AipAuto</h3>

    @<ol class="round">
       @* "Función general de AipAuto"
"Configuracion de peritos"
"Administracion de peritos y control de gestion"
"Procesamiento de inspecciones"
"Facil almacenamiento de datos sobre la inspeccion desde cualquier parte con Internet"
"Auditoria de inspecciones"
"Seguimiento continuo de inspecciones"*@
        <li class="one">
            <h5>Configuraci&oacute;n  de peritos</h5>
            Administraci&oacute;n de peritos y control de gestion            
        </li>
        <li class="two">
            <h5>Procesamiento de inspecciones</h5>
            Facil almacenamiento de datos sobre la inspeccion desde cualquier parte con Internet.
        </li>
        <li class="three">
            <h5>Auditoria de inspecciones</h5>
            Seguimiento continuo de inspecciones.
        </li>
    </ol>
Else
    @Html.Action("IniciarSesion", "Seguridad", New With {.esvistaparcial = True})
End If