@Code
    ViewData("Title") = "Contactanos"
    ViewData("Message") = "Contactanos,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            En esta secci&oacute;n usted podr&aacute; consultar nuestra informaci&oacute;n de contacto, a trav&eacute;s de los 
            cuales le brindamos asistencia y ofrecemos cualquier informaci&oacute;n requerida.
        </p>
    </div>
</section>
End Section

<section class="contact">
    <header>
        <h3>Tel&eacute;fono</h3>
    </header>
    <p>
        <span class="label">Oficina:</span>
        <span>0212)400-68-11</span>
    </p>
</section>

<section class="contact">
    <header>
        <h3>Correo electr&oacute;nico</h3>
    </header>
    <p>
        <span class="label">Soporte:</span>
        <span><a href="mailto:requerimientos@sigmadental.net">requerimientos@sigmadental.net</a></span>
    </p>    
    @*<p>
        <span class="label">Informaci&oacute;n General:</span>
        <span><a href="mailto:info@sitfx.com">info@sitfx.com</a></span>
    </p>*@
</section>

<section class="contact">
    <header>
        <h3>Direcci&oacute;n</h3>
    </header>
    <p>
        Caracas - Venezuela<br />
        Altamira, La Castellana. Edificio Banco Lara ubicado entre 1era y 2da transversal. Nivel Mezzanina.
    </p>
</section>