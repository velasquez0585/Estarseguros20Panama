@*siempre creamos un tab en la vista parcial, asi tenga una sola ficha, es importante que nos fijemos en la estructura del tab
para hacerlo siempre igual y bajo las mismas convenciones*@
<div id="tab_manactivarusu" class="tab">
    <ul>
        @*aqui van los titulos de cada tab con la referencia de su contenido*@
        <li ><a href="#tab-1" class="tab-static">Buscar</a></li>
        @*<li id="tab-ver"><a href="#tab-2">Ver</a></li>
        <li ><a href="#tab-3"  class="tab-static">Nuevo</a></li>
        <li id="tab-editar"><a href="#tab-4">Editar</a></li>*@
    </ul>
    <div id="tab-1">
        @*el contenido de un tab normalmente es un div que tiene dentro una mini vista parcial con un formulario*@
        <div id="div_manactivarusubuscar1">
            @Html.Partial("__ManActivarUsuBuscar1")
        </div>
    </div>
    
</div>

<script type="text/javascript">
    //en esta seccion siempre vamos a instanciar y enlazar los viewmodels de todas las mini vistas parciales
    var vmmanactivarusubuscar1 = new vmmanactivarusubuscar1();
    ko.applyBindings(vmmanactivarusubuscar1, $('#div_manactivarusubuscar1')[0]);
    $(function () { 
        //los metodos cargar de un viewmodel normalmente inicializan al mismo con alguna accion
        //en este caso, el formulario buscar, ejecuta un metodo "cargar" apenas es instanciado porque esta habilitado
        //al cargar la pagina y debe inicializar sus acciones y valores de uso
        vmmanactivarusubuscar1.cargar();
    });
    
    $(function () {
        //al cargar la pagina se deshabilitan los tabs de ver, editar y perfil para ser habilitados en una 
        //accion posterior por demanda del usuario
        $("#tab_manactivarusu").tabs({ disabled: [1, 3] });

        //al hacer click en los tabs buscar y nuevo se deshabilitan los tabs ver, editar y perfil
        $(".tab-static").click(function () {
            $("#tab-ver, #tab-editar").addClass("ui-state-disabled");
        });
    });
</script>