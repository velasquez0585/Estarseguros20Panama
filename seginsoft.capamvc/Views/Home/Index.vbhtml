@Code
    ViewData("Title") = "Inicio"
    ViewData("Message") = "¡Bienvenido!"
    
End Code

@section featured
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
               
                <h2>@ViewData("Message")</h2>
            </hgroup>
            <p>
                 A través de este módulo de seguridad integrado, usted podrá configurar usuarios, perfiles, niveles de autenticación y autorización para cualquier aplicación.</p>
            <p>
Adicionalmente, cuenta con un módulo de trazabilidad para realizar el debido seguimiento a los eventos, errores y registros que se administran a través de las distintas aplicaciones. 
            </p>
        </div>
    </section>
End Section

@If Request.IsAuthenticated Then
    @<h3>Funci&oacute;n general de Seginsoft</h3>

    @<ol class="round">
        <li class="one">
            <h5>Usuarios</h5>
            Crear y administrar perfiles de usuarios por aplicaci&oacute;n.
        </li>
        <li class="two">
            <h5>Aplicaciones</h5>
            Crear y configurar aplicaciones.
        </li>
        <li class="three">
            <h5>Perfiles</h5>
            Crear y configuarar perfiles por aplicacion.
        </li>
    </ol>
Else
    @Html.Action("IniciarSesion", "Seguridad", New With {.esvistaparcial = True})
End If
