 <div id="dlg_BareRepuModal1" class="dialognoauto" title="Crear Baremo para Repuestos">
   @Html.Partial("__BareRepuModal1")
</div> 
<div id="dlg_BareMobrModal1" class="dialognoauto" title="Crear Baremo Mano de Obra">
   @Html.Partial("__BareMobrModal1")
</div>
<div id="tab_Bare" class="tab">
    <ul>
        <li><a href="#tab-1">Mano de Obra</a></li>  
        <li><a href="#tab-2">Repuesto</a></li>     
    </ul>
    <div id="tab-1">
        <div id="div_BareMobrConfig1">
            @Html.Partial("__BareMobrConfig1")
        </div>
    </div> 
    
    <div id="tab-2">
        <div id="div_BareRepuConfig1">
            @Html.Partial("__BareRepuConfig1")
        </div>
    </div> 
</div>

<script type="text/javascript">
    var vmBareMobrConfig1 = new vmBareMobrConfig1(true, true, true);
    ko.applyBindings(vmBareMobrConfig1, $('#div_BareMobrConfig1')[0]);

    var vmBarerepuConfig1 = new vmBarerepuConfig1(true, true, true);
    ko.applyBindings(vmBarerepuConfig1, $('#div_BareRepuConfig1')[0]);

    var vmBareRepuModal1 = new vmBareRepuModal1();
    ko.applyBindings(vmBareRepuModal1, $('#dlg_BareRepuModal1')[0]);

    var vmBareMobrModal1 = new vmBareMobrModal1();
    ko.applyBindings(vmBareMobrModal1  , $('#dlg_BareMobrModal1')[0]);


    $(function () {
        //vmBareMobrConfig1.iniciar();
    });

  

   </script>