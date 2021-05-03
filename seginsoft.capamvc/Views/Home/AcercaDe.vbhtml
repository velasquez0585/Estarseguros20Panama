@Code
    ViewData("Title") = "AcercaDe"
    ViewData("Message") = "Acerca De..."
End Code

@section featured

    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>@ViewData("Message")</h1>
            </hgroup>
            
                <h3>Nombre corto:</h3>
                    <p>SEGINSOFT</p>

                <h3>Nombre completo:</h3>
                    <p>SEGURIDAD INTEGRADA DE APLICACIONES</p>
            
                <h3>Objetivo:</h3>
                    <p>Integrar y administrar el modulo de seguridad de todas las aplicaciones en un único producto que permita establecer los niveles respectivos de autenticación y autorización.</p>

                <h3>Año de creación:</h3>
                        <p>2012</p>

            <h3>Tecnología:</h3>
                        <p>ASP.NET </p>
        </div>
    </section>
End Section



















