@* <style>
    
    /*background: none;
    color: #008265;*/
    
    .ui-menu
    {
        overflow:hidden;
        font: 13px Segoe UI;
        margin-bottom:5px;
    }
    .ui-menu .ui-menu
    {
        overflow: visible !important;
    }
    .ui-menu ul
    {
        z-index:1000;
        padding:5px;
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
        float:none;
        clear:both;
        left: 120px !important;
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
</style>*@

@If Request.IsAuthenticated Then
    @Html.Action("MenuAutenticado", "Home")
Else
    @Html.Action("MenuAnonimos", "Home")
End If

@*<script type="text/javascript">
    $(function () {
        $("#menuprincipal").menu({ position: { at: "left bottom"} }); ;
    });
</script>*@

@*<nav>
                <ul id="menuprincipal">
                    
                    <li><a href='#'>Menu</a>
                        <ul>
                           <li class="clear-both"><a href='/Mantenimiento/ManUsuario?esvistaparcial=false'>Usuario</a></li>
                           <li class="clear-both"><a href='/Mantenimiento/ManPerfiles?esvistaparcial=false'>Perfiles</a></li>
                           <li class="clear-both"><a href='/Mantenimiento/ManAplicaciones?esvistaparcial=false'>Aplicaciones</a></li>  
                            <li class="clear-both"><a href='/Log/Log?esvistaparcial=false'>Logs</a></li>  

                        </ul>
                    </li>
                </ul>
</nav>*@
