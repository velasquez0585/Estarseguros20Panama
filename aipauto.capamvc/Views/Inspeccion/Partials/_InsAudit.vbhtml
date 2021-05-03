 <div id="dlg_InsFotoModal1" class="dialognoauto" title="Fotos">
    
</div>
 <div id="dlg_InsSusGuardar1" class="dialognoauto" title="Inspeccion Suscripcion">
    @Html.Partial("__InsSusGuardar1")
</div>
<div id="dlg_InsRestGuardar1" class="dialognoauto" title="Inspeccion Restos y Salvamento">
    @Html.Partial("__InsRestGuardar1")
</div>
<div id="dlg_InsLimDanSusGuardar1" class="dialognoauto" title="Inspeccion Limpieza de Daños por Suscripcion ">
   @Html.Partial("__InsLimDanSusGuardar1")
</div>
  <div id="dlg_InsLimDanSinGuardar1" class="dialognoauto" title="Inspeccion Limpieza de Daños por Siniestro ">
   @Html.Partial("__InsLimDanSinGuardar1")
</div>
 
 <div id="dlg_InsAjusDanSinGuardar1" class="dialognoauto" title="Inspeccion Ajustes por Siniestro">
   @Html.Partial("__InsAjusDanSinGuardar1")
</div>
 <div id="dlg_InsAjusDanAnexGuardar1" class="dialognoauto" title="Inspeccion Ajuste por Anexo">
   @Html.Partial("__InsAjusDanAnexGuardar1")
</div>

<div id="dlg_manversionnuevo1" class="dialognoauto" title="Mantenimiento de Versión">
   @Html.Action("__ManVersionNuevo1", "Mantenimiento")
</div>

<div id="dlg_InsSinGuardar1" class="dialognoauto" title="Inspeccion Siniestro ">
   @Html.Partial("__InsSinGuardar1")
</div>

<div id="dlg_InsSubirFotoModal1" class="dialognoauto" title="Subir Fotos">
     @Html.Partial("__InsSubirFotosModal1")
</div>

@*<div id="dlg_InsVideosModal1" class="dialognoauto" title="Videos">
      @Html.Partial("__InsVideosBuscar1")
</div>

<div id="dlg_InsAudiosModal1" class="dialognoauto" title="Notas de Voz">
      @Html.Partial("__InsAudiosBuscar1")
</div>*@

<div id="dlg_InsMultimModal1" class="dialognoauto" title="Multimedia">
      @Html.Partial("__InsMultimModal1")
</div>

<div id="dlg_insobservsintagenmodal1" class="dialognoauto" title="Detalles">
    @Html.Partial("__InsObservSintAgenModal1")
</div>

<div id="tab_Bare" class="tab">
    <ul>
        <li><a href="#tab-1">Buscar</a></li>    
    </ul>
    <div id="tab-1">
        <div id="div_InsPorAuditBuscar1">
            @Html.Partial("__InsPorAuditBuscar1")
        </div>
    </div> 
    
</div>

<input hidden id="idsegmanperf" value='@CInt( Session("idsegmanperf"))' />
<script type="text/javascript">
    var vmInsPorAuditBuscar1 = new vmInsPorAuditBuscar1(true, true, true);
    ko.applyBindings(vmInsPorAuditBuscar1, $('#div_InsPorAuditBuscar1')[0]);
 
     

    //var segu = $("#idsegmanperf").val();
    //if (segu == 1) {
        var vmInsRestGuardar1 = new vmInsRestGuardar1(false, true, false);
        ko.applyBindings(vmInsRestGuardar1, $('#dlg_InsRestGuardar1')[0]);
        var vmInsSusGuardar1 = new vmInsSusGuardar1(false, true, false);
        ko.applyBindings(vmInsSusGuardar1, $('#dlg_InsSusGuardar1')[0]);
        var vmInsLimDanSusGuardar1 = new vmInsLimDanSusGuardar1(false, true, false);
        ko.applyBindings(vmInsLimDanSusGuardar1, $('#dlg_InsLimDanSusGuardar1')[0]);
        var vmInsLimDanSinGuardar1 = new vmInsLimDanSinGuardar1(false, true, false);
        ko.applyBindings(vmInsLimDanSinGuardar1, $('#dlg_InsLimDanSinGuardar1')[0]);
        var vmInsAjusDanSinGuardar1 = new vmInsAjusDanSinGuardar1(false, true, false);
        ko.applyBindings(vmInsAjusDanSinGuardar1, $('#dlg_InsAjusDanSinGuardar1')[0]);
        var vmInsAjusDanAnexGuardar1 = new vmInsAjusDanAnexGuardar1(false, true, false);
        ko.applyBindings(vmInsAjusDanAnexGuardar1, $('#dlg_InsAjusDanAnexGuardar1')[0]);

        var vmInsSubirFotoModal1 = new vmInsSubirFotoModal1();
        ko.applyBindings(vmInsSubirFotoModal1, $('#dlg_InsSubirFotoModal1')[0]);

        var vmInsSinGuardar1 = new vmInsSinGuardar1(false, true, false);
        ko.applyBindings(vmInsSinGuardar1, $('#dlg_InsSinGuardar1')[0]);
   
        var vmmanversionnuevo1 = new vmmanversionnuevo1(false);
        ko.applyBindings(vmmanversionnuevo1, $('#dlg_manversionnuevo1')[0]);

        //var vmInsVideosBuscar1 = new vmInsVideosBuscar1();
        //ko.applyBindings(vmInsVideosBuscar1, $('#dlg_InsVideosModal1')[0]);

        //var vmInsAudiosBuscar1 = new vmInsAudiosBuscar1();
        //ko.applyBindings(vmInsAudiosBuscar1, $('#dlg_InsAudiosModal1')[0]);


        var vmInsMultimediaModal1 = new vmInsMultimediaModal1();
        ko.applyBindings(vmInsMultimediaModal1, $('#dlg_InsMultimModal1')[0]);

        var vminsobservsintagenmodal1 = new vminsobservsintagenmodal1();
        ko.applyBindings(vminsobservsintagenmodal1, $('#dlg_insobservsintagenmodal1')[0]);

        //var vminsobservsintagenmodal1 = new vminsobservsintagenmodal1();

    //}

    $(function () {
        vmInsPorAuditBuscar1.iniciar();

    });

  

   </script>