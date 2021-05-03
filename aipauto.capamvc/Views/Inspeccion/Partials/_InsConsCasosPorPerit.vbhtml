<div id="dlg_insporprocporperitbuscar1" class="dialognoauto" title="Inspecciones por procesar">
    @Html.Partial("__InsPorProcPorPeritBuscar1")
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

<div id="tab_consperit" class="tab">
    <ul>
        <li><a href="#tab-1">Buscar</a></li>
    </ul>
    <div id="tab-1">
        <div id="div_InsConsCasosPorPeritBuscar1">
            @Html.Partial("__InsConsCasosPorPeritBuscar1")
        </div>
    </div>
</div>

<script type="text/javascript">
    var vmInsConsCasosPorPeritBuscar1 = new vmInsConsCasosPorPeritBuscar1();
    ko.applyBindings(vmInsConsCasosPorPeritBuscar1, $('#div_InsConsCasosPorPeritBuscar1')[0]);

    var vmInsPorProcPorPeritBuscar1 = new vmInsPorProcPorPeritBuscar1();
    ko.applyBindings(vmInsPorProcPorPeritBuscar1, $('#dlg_insporprocporperitbuscar1')[0]);

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
        vmInsConsCasosPorPeritBuscar1.iniciar();
    });



</script>
