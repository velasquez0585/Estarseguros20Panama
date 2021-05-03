<style>
    /*background: none;
    color: #008265;*/

    .ui-menu
    {
        overflow: hidden;
        font: 13px Segoe UI;
        margin-bottom: 5px;
    }

        .ui-menu .ui-menu
        {
            overflow: visible !important;
        }

        .ui-menu ul
        {
            z-index: 1000;
            padding: 5px;
        }

        .ui-menu > li
        {
            float: left;
            display: block;
            width: auto !important;
        }

        .ui-menu ul li
        {
            display: block;
            float: none;
        }

            .ui-menu ul li ul
            {
                left: 120px !important;
                width: 100%;
            }

                .ui-menu ul li ul li
                {
                    width: auto;
                }

                    .ui-menu ul li ul li a
                    {
                        float: left;
                    }

        .ui-menu > li
        {
            margin: 5px 5px !important;
            padding: 0 0 !important;
        }

            .ui-menu > li > a
            {
                float: left;
                display: block;
                clear: both;
                overflow: hidden;
            }

        .ui-menu .ui-menu-icon
        {
            margin-top: 0.3em !important;
        }

        .ui-menu .ui-menu .ui-menu li
        {
            float: left;
            display: block;
        }
</style>

<section class="content-wrapper">
    <section class="top-header-100%">
        <div class="float-left">
            <div class="div-icon-app">
                <a href="@Url.Action("Index", "Home")" style="background: none; text-decoration:none;">
                    <img class="icon-app" src="@Url.Content("~/publico/imagenes/sigmadental.png")" alt="appicon">
                </a>
                
            </div>
        </div>
        <div class="float-left title-princ">
            <a href="@Url.Action("Index", "Home")" style="background: none; text-decoration:none;">
                <h1>Seginsoft</h1>
            </a>
        </div>
        <div class="float-left">
            <div class="site-title">
                @*@Html.ActionLink("Seginsoft", "Index", "Home")*@
            </div>
        </div>
        <div class="float-right">
             <div class="float-right">
            <section id="login">
                @Html.Partial("_LogOn")
            </section>
            <nav>
                @Html.Partial("_Menu")
            </nav>
        </div>

            @*<nav>
                <ul id="menuprincipal">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li><a href='#'>Mantenimiento</a>
                        <ul>*@
                            @*<li>@Html.ActionLink("Usuarios", "ManUsuario", "Mantenimiento")</li>
                            <li>@Html.ActionLink("Perfiles", "ManPerfiles", "Mantenimiento")</li>*@

                           @* <li><a href='/Mantenimiento/ManUsuario?esvistaparcial=false'>Usuario</a></li>
                            <li><a href='/Mantenimiento/ManPerfiles?esvistaparcial=false'>Perfiles</a></li>
                            <li><a href='/Mantenimiento/ManAplicaciones?esvistaparcial=false'>Aplicaciones</a></li>
                         
                        </ul>

                    </li>*@
                    @*<li>@Html.ActionLink("Acerca De...", "AcercaDe", "Home")</li>*@
                    @*<li>@Html.ActionLink("Contact", "Contact", "Home")</li>*@
               @* </ul>*@



                @* <ul id="menu">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("Usuarios", "ManUsuario", "Mantenimiento")</li>
                    <li>@Html.ActionLink("About", "About", "Home")</li>
                    <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
                </ul>*@
            @*</nav>*@
        </div>
    </section>
</section>

<script type="text/javascript">
    $(function () {
        $("#menuprincipal").menu({ position: { at: "left bottom" } });;
    });
</script>
