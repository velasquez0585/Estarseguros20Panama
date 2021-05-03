<div id="dlg_insporprocporauditbuscar1" class="dialognoauto" title="Inspecciones por procesar">
    @Html.Partial("__InsPorProcPorAuditBuscar1")
</div>

<div id="dlg_InsSusGuardar1" class="dialognoauto" title="Inspeccion Suscripcion">
    @Html.Partial("__InsSusGuardar1")
</div>

<div id="dlg_InsSinGuardar1" class="dialognoauto" title="Inspeccion Siniestro ">
    @Html.Partial("__InsSinGuardar1")
</div>

<div id="dlg_InsFotoModal1" class="dialognoauto" title="Fotos">
     
</div>

<div id="dlg_InsMultimModal1" class="dialognoauto" title="Multimedia">
      @Html.Partial("__InsMultimModal1")
</div>

<div id="dlg_insobservsintagenmodal1" class="dialognoauto" title="Detalles">
    @Html.Partial("__InsObservSintAgenModal1")
</div>

<div id="tab_consauditt" class="tab">
    <ul>
        <li><a href="#tab-1">Buscar</a></li>
    </ul>
    <div id="tab-1">
        <div id="div_InsConsCasosPorAuditBuscar1">
            @Html.Partial("__InsConsCasosPorAuditBuscar1")
        </div>
    </div>


</div>

<script type="text/javascript">
    var vmInsConsCasosPorAuditBuscar1 = new vmInsConsCasosPorAuditBuscar1(true, true, true);
    ko.applyBindings(vmInsConsCasosPorAuditBuscar1, $('#div_InsConsCasosPorAuditBuscar1')[0]);

    var vmInsPorProcPorAuditBuscar1 = new vmInsPorProcPorAuditBuscar1();
    ko.applyBindings(vmInsPorProcPorAuditBuscar1, $('#dlg_insporprocporauditbuscar1')[0]);

    var vmInsSusGuardar1 = new vmInsSusGuardar1(false, false, false);
    ko.applyBindings(vmInsSusGuardar1, $('#dlg_InsSusGuardar1')[0]);

    var vmInsSinGuardar1 = new vmInsSinGuardar1(false, false, false);
    ko.applyBindings(vmInsSinGuardar1, $('#dlg_InsSinGuardar1')[0]);

  

    var vmInsMultimediaModal1 = new vmInsMultimediaModal1();
    ko.applyBindings(vmInsMultimediaModal1, $('#dlg_InsMultimModal1')[0]);

    var vminsobservsintagenmodal1 = new vminsobservsintagenmodal1();
    ko.applyBindings(vminsobservsintagenmodal1, $('#dlg_insobservsintagenmodal1')[0]);

    //var vminsobservsintagenmodal1 = new vminsobservsintagenmodal1();

    $(function () {
        vmInsConsCasosPorAuditBuscar1.iniciar();
    });
    


</script>