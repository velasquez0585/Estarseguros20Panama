<section class="content-wrapper">
    <section class="top-header-100%">
        <div class="float-left">
            <div class="div-icon-app" style="margin-top: 5px;">
                <a href="@Url.Action("Index", "Home")" style="background: none; text-decoration:none;">
                <img class="icon-app" style="width: 330px;" src="@Url.Content("~/publico/imagenes/sitfx/logoaipauto.png")" alt="appicon">
                    </a>
            </div>
        </div>
        <div class="float-left">
            <div class="site-title">
               @* @Html.ActionLink("AicWeb", "Index", "Home")*@
            </div>
        </div>
        <div class="float-right">
            <section id="login">
                @Html.Partial("_LogOn")
            </section>
            <nav>
                @Html.Partial("_Menu")
            </nav>
        </div>
    </section>
</section>