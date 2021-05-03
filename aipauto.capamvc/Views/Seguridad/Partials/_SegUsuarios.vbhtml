@*siempre creamos un tab en la vista parcial, asi tenga una sola ficha, es importante que nos fijemos en la estructura del tab
para hacerlo siempre igual y bajo las mismas convenciones*@
<div id="tab_segusuarios" class="tab">
    <ul>
        @*aqui van los titulos de cada tab con la referencia de su contenido*@
        <li ><a href="#tab-1">Buscar</a></li>
        <li id="tab-ver"><a href="#tab-2">Ver</a></li>
        <li ><a href="#tab-3">Nuevo</a></li>
        <li id="tab-editar"><a href="#tab-4">Editar</a></li>
        <li id="tab-perfil"><a href="#tab-5">Perfil</a></li>
    </ul>
    <div id="tab-1">
        @*el contenido de un tab normalmente es un div que tiene dentro una mini vista parcial con un formulario*@
        <div id="div_segusuariosbuscar1">
            @Html.Partial("__SegUsuariosBuscar1")
        </div>
    </div>
    <div id="tab-2">
        <div id="div_segusuariosver1">
            @Html.Partial("__SegUsuariosVer1")
        </div>
    </div>
    <div id="tab-3">
        <div id="div_segusuariosnuevo1">
            @Html.Partial("__SegUsuariosNuevo1")
        </div>
    </div>
    <div id="tab-4">
        <div id="div_segusuarioseditar1">
            @Html.Partial("__SegUsuariosEditar1")
        </div>
    </div>
    <div id="tab-5">
        <div id="div_segusuariosperfil1">
            @Html.Partial("__SegUsuariosPerfil1")
        </div>
    </div>
</div>

<script type="text/javascript">
    //en esta seccion siempre vamos a instanciar y enlazar los viewmodels de todas las mini vistas parciales
    var vmsegusuariosbuscar1 = new vmsegusuariosbuscar1();
    ko.applyBindings(vmsegusuariosbuscar1, $('#div_segusuariosbuscar1')[0]);
    $(function () { 
        //los metodos cargar de un viewmodel normalmente inicializan al mismo con alguna accion
        //en este caso, el formulario buscar, ejecuta un metodo "cargar" apenas es instanciado porque esta habilitado
        //al cargar la pagina y debe inicializar sus acciones y valores de uso
        vmsegusuariosbuscar1.cargar();
    });
    //------------------------------------------------------------------------------------------
    //como el formulario ver no esta habilitado desde que carga la pagina no se ejecuta su metodo cargar
    var vmsegusuariosver1 = new vmsegusuariosver1();
    ko.applyBindings(vmsegusuariosver1, $('#div_segusuariosver1')[0]);
    //------------------------------------------------------------------------------------------
    var vmsegusuariosnuevo1 = new vmsegusuariosnuevo1();
    ko.applyBindings(vmsegusuariosnuevo1, $('#div_segusuariosnuevo1')[0]);
    $(function () {
        //los metodos cargar de un viewmodel normalmente inicializan al mismo con alguna accion
        //en este caso, el formulario nuevo, ejecuta un metodo "cargar" apenas es instanciado porque esta habilitado
        //al cargar la pagina y debe inicializar sus acciones y valores de uso
        vmsegusuariosnuevo1.cargar();
    });
    //-------------------------------------------------------------------------------------------
    //como el formulario editar no esta habilitado desde que carga la pagina no se ejecuta su metodo cargar
    var vmsegusuarioseditar1 = new vmsegusuarioseditar1();
    ko.applyBindings(vmsegusuarioseditar1, $('#div_segusuarioseditar1')[0]);
    //-------------------------------------------------------------------------------------------
    //como el formulario de perfiles no esta habilitado desde que carga la pagina no se ejecuta su metodo cargar
    var vmsegusuariosperfil1 = new vmsegusuariosperfil1();
    ko.applyBindings(vmsegusuariosperfil1, $('#div_segusuariosperfil1')[0]);

    $(function () {
        //al cargar la pagina se deshabilitan los tabs de ver, editar y perfil para ser habilitados en una 
        //accion posterior por demanda del usuario
        $("#tab_segusuarios").tabs({ disabled: [1, 3] });

        //al hacer click en los tabs buscar y nuevo se deshabilitan los tabs ver, editar y perfil
        $(".tab-static").click(function () {
            $("#tab-ver, #tab-editar, #tab-perfil").addClass("ui-state-disabled");
        });
    });
    
</script>