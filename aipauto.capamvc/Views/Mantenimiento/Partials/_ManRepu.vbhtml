
@*<div id="dlg_pactratamodificar1" class="dialognoauto" title="Modificar Atencion">
   @Html.Partial("__pactrataModificar1")
</div>
  
<div id="dlg_manpacagregar1" class="dialognoauto" title="Agregar Paciente">
    @Html.Action("__ManPacAgregar1", "Mantenimiento")
</div>
<div id="dlg_manpaclistar1" class="dialognoauto" title="Lista de pacientes">
    @Html.Action("__ManPacListar1", "Mantenimiento")
</div>
 *@
<div id="tab_ManRepu" class="tab">
    <ul>
        <li><a href="#tab-1">Buscar</a></li>
        <li><a href="#tab-2">Ver</a></li>
        <li><a href="#tab-3">Agregar</a></li>
        <li><a href="#tab-4">Editar</a></li> 
    </ul>
    <div id="tab-1">
        <div id="div_ManRepubuscar1">
            @Html.Partial("__ManRepuBuscar1")
        </div>
    </div>
    <div id="tab-2">
        <div id="div_ManRepuver1">
            @Html.Partial("__ManRepuVer1")
        </div>
    </div>
    <div id="tab-3">
        <div id="div_ManRepuagregar1">
            @Html.Partial("__ManRepuAgregar1")
        </div>
    </div>
    <div id="tab-4">
        <div id="div_ManRepumodificar1">
            @Html.Partial("__ManRepuModificar1")
        </div>
    </div>  
   
</div>

<script type="text/javascript">
    var vmManRepubuscar1 = new vmManRepubuscar1(true, true, true, false);
    ko.applyBindings(vmManRepubuscar1, $('#div_ManRepubuscar1')[0]);



    var vmManRepuver1 = new vmManRepuver1();
    ko.applyBindings(vmManRepuver1, $('#div_ManRepuver1')[0]);

    var vmManRepuagregar1 = new vmManRepuagregar1();
    ko.applyBindings(vmManRepuagregar1, $('#div_ManRepuagregar1')[0]);

    var vmManRepumodificar1 = new vmManRepumodificar1();
    ko.applyBindings(vmManRepumodificar1, $('#div_ManRepumodificar1')[0]);
    //var vmManRepucerrar1 = new vmManRepucerrar1();
    //ko.applyBindings(vmManRepucerrar1, $('#div_ManRepucerrar1')[0]);

    //////-------------------------------------------------------------------------------------------------

    //var vmpactratamodificar1 = new vmpactratamodificar1();
    //ko.applyBindings(vmpactratamodificar1, $('#dlg_pactratamodificar1')[0]);

    $(function () {
        vmManRepubuscar1.iniciar();
        vmManRepuagregar1.iniciar();
        //vmManRepumodificar1.iniciar();
        //vmManRepucerrar1.iniciar();
        vmManRepuver1.iniciar();
    });

   
     

   </script>