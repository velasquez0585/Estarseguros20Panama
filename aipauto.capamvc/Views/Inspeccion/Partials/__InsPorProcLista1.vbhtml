<fieldset class="form-area">
    <legend>Inspecciones por Procesar</legend>


    <div class="form-row">
        <div class="info-pagination" data-bind="with: pagvi_aipinsenc">
            <span>P&aacute;gina </span>
            <span data-bind='text: npagactual'></span>
            <span>de </span>
            <span data-bind='text: npagcantidad'></span>
        </div>

        <div class="grid-area">
            <table class="grid-table" data-bind='visible: lista_vi_aipinsenc().length > 0'>
                <thead>
                    <tr class="grid-row-header" data-bind="foreach: encabezados_vi_aipinsenc">
                        <td data-bind="click: $parent.ordenar_vi_aipinsenc, text: titulo"></td>
                    </tr>
                </thead>
                <tbody data-bind='foreach: lista_vi_aipinsenc'>
                    <tr class="grid-row-content">

                        <td>
                            <span data-bind='text: idaipinsenc' />
                        </td>
                        <td>
                            <span data-bind='text: xcedpropinsenc' />
                        </td>
                        <td>
                            <span data-bind='text: itipoinsenc' />
                        </td>
                        <td>
                            <span data-bind='text: xplacinsenc' />
                        </td>

                        <td>
                            <span data-bind='text: xnumsininsenc' />
                        </td>
                        <td>
                            <span data-bind='datehtml: fcreainsenc' />
                        </td>
                        <td>
                            <input type="button" value="Ir a Procesar" data-bind="click: $root.procesar " />

                        </td>
                        <td>
                            <input type="button" value="Ver Fotos" data-bind="click: $root.verfotos" />
                        </td>
                        @*<td>
                            <input type="button" value="Videos" data-bind="click: $root.verVideos" />
                        </td>
                        <td>
                            <input type="button" value="Notas de Voz" data-bind="click: $root.verAudios" />
                        </td>*@
                        <td>
                            <input type="button" value="Multimedia" data-bind="click: $root.verMultimedia" />
                        </td>
                        
                        <td>
                            <input type="button" value="Subir Fotos" data-bind="click: $root.subirfotos" />

                        </td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr class="grid-row-footer">
                        <td colspan="5">
                            <div class="grid-bottom-buttons">
                                <div class="grid-bottom-button">
                                    <input type="button" value="Primero" data-bind="click: ir_primero" />
                                </div>
                                <div class="grid-bottom-button">
                                    <input type="button" value="Anterior" data-bind="click: ir_anterior" />
                                </div>
                                <div class="grid-bottom-button">
                                    <input type="button" value="Siguiente" data-bind="click: ir_siguiente" />
                                </div>
                                <div class="grid-bottom-button">
                                    <input type="button" value="Ultimo" data-bind="click: ir_ultimo" />
                                </div>
                            </div>
                        </td>
                    </tr>
                </tfoot>
            </table>
            <div class="no-grid-rows" data-bind='visible: lista_vi_aipinsenc().length == 0'>No existen inspecciones almacenados...</div>
        </div>
    </div>

    @*<div id='map'></div>*@
</fieldset>

<script type="text/javascript">
    function vmInsPorProcLista1(boton_ver, boton_agregar, boton_modificar) {
        var self = this;
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.pagvi_aipinsenc = new paginacion(1, 10, 0, "it.idaipinsenc", "DESC");
        self.lista_vi_aipinsenc = ko.observableArray();
        self.sel_idaipinsenc = ko.observable(0);
        self.boton_ver = ko.observable(boton_ver);
        self.boton_agregar = ko.observable(boton_agregar);
        self.boton_modificar = ko.observable(boton_modificar);
        self.lat = ko.observable("");
        self.lon = ko.observable("");

        self.encabezados_vi_aipinsenc = [

            { titulo: 'Id', campo: 'it.idaipinsenc' },
            { titulo: 'Cédula Propietario', campo: 'it.xcedsidoinsenc' },
            { titulo: 'Tipo', campo: 'it.itipoinsenc' },
            { titulo: 'Placa', campo: 'it.xplacinsenc' },
{ titulo: 'Siniestro o Cotización ', campo: 'it.xnumsininsenc' },
            { titulo: 'F/Creacion', campo: 'it.fcreainsenc' },
        { titulo: '', campo: '' },
        { titulo: '', campo: '' },
        { titulo: '', campo: '' },
        { titulo: '', campo: '' },
        { titulo: '', campo: '' }
        ];
        self.buscar = function () {
            postajaxjsonbasico("/Inspeccion/ObtenerInspeccionesPorProcesar/", ko.toJSON(self), function (lista_vi_aipinsenc) {
                ko.mapping.fromJS(lista_vi_aipinsenc, {}, self);
            })
        }


        self.iniciar = function () {
            self.buscar();
        }
        self.procesar = function (obj) {
            var segu = $("#idsegmanperf").val();
            switch (obj.itipoinsenc()) {
                case "SUSCRIPCION":

                    vmInsSusGuardar1.iniciar(obj);
                    $("#dlg_InsSusGuardar1").dialog("open");
                    $("#dlg_InsSusGuardar1").dialog({
                        close: function (event, ui) {
                            self.buscar();
                        }
                    });

                    break;
                    //case "RESTOS Y SALVAMENTO":
                    //    vmInsRestGuardar1.iniciar(obj);
                    //    $("#dlg_InsRestGuardar1").dialog("open");
                    //    $("#dlg_InsRestGuardar1").dialog({
                    //        close: function (event, ui) {
                    //            self.buscar();
                    //        }
                    //    });
                    //    break;
                    //case "LIMPIEZA DE DAÑOS POR SUSCRIPCION":
                    //    $("#dlg_InsLimDanSusGuardar1").dialog("open");
                    //    vmInsLimDanSusGuardar1.iniciar(obj);
                    //    $("#dlg_InsLimDanSusGuardar1").dialog({
                    //        close: function (event, ui) {
                    //            self.buscar();
                    //        }
                    //    });
                    //    break;
                case "SINIESTRO":
                    $("#dlg_InsSinGuardar1").dialog("open");
                    vmInsSinGuardar1.iniciar(obj, true);
                    $("#dlg_InsSinGuardar1").dialog({
                        close: function (event, ui) {
                            self.buscar();

                        }
                    });
                    break;
                    //case "AJUSTES POR SINIESTRO":
                    //    vmInsAjusDanSinGuardar1.iniciar(obj);
                    //    $("#dlg_InsAjusDanSinGuardar1").dialog("open");
                    //    $("#dlg_InsAjusDanSinGuardar1").dialog({
                    //        close: function (event, ui) {
                    //            self.buscar();
                    //        }
                    //    });
                    //    break;
                    //case "AJUSTES POR ANEXO":
                    //    vmInsAjusDanAnexGuardar1.iniciar(obj);
                    //    $("#dlg_InsAjusDanAnexGuardar1").dialog("open");
                    //    $("#dlg_InsAjusDanAnexGuardar1").dialog({
                    //        close: function (event, ui) {
                    //            self.buscar();
                    //        }
                    //    });
                    //    break;
                default:
                    break;
            }

        }
        self.verfotos = function (obj) {


            var $detailDiv = $('#dlg_InsFotoModal1');
            $detailDiv.html("");
            url = "/Inspeccion/InspeccionFoto/";
            $.ajax({
                type: "POST",
                url: url,
                data: "{}",
                async: true,
                dataType: "html",
                success: function (data) {
                    $detailDiv.html(data);

                    vmInsFotoModal1 = new vmInsFotoModal1();
                    ko.applyBindings(vmInsFotoModal1, $('#dlg_InsFotoModal1')[0]);
                    vmInsFotoModal1.iniciar(obj, obj.itipoinsenc);
                    $("#dlg_InsFotoModal1").dialog("open");

                    //$('#mymodal').dialog({ width: 335, height: 355 });

                    //$(function () {
                    //    $('[u=arrowright],[u=arrowleft]').click(function () {
                    //        alert("asdadas");
                    //    });
                    //});               
                }
            });



        }

        self.verVideos = function (obj) {
            
            vmInsVideosBuscar1.cargar(obj, "VIDEO");
            $("#dlg_InsVideosModal1").dialog("open");
        }


        self.verAudios = function (obj) {
            vmInsAudiosBuscar1.cargar(obj, "AUDIO");
            $("#dlg_InsAudiosModal1").dialog("open");
        }

        self.verMultimedia = function (obj)
        {
            
            //vmInsMultimediaModal1.iniciar(obj, obj.itipoinsenc);
            vmInsMultimediaModal1.cargarMultimedia(obj);            
            $("#dlg_InsMultimModal1").dialog("open");
            
        }

        

        self.subirfotos = function (obj) {
            vmInsSubirFotoModal1.iniciar(obj);
            $("#dlg_InsSubirFotoModal1").dialog("open");
        }
        self.ir_primero = function () {
            var npagactual = self.pagvi_aipinsenc.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipinsenc.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_aipinsenc.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipinsenc.npagactual(self.pagvi_aipinsenc.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_aipinsenc.npagactual() != self.pagvi_aipinsenc.npagcantidad()) {
                self.pagvi_aipinsenc.npagactual(self.pagvi_aipinsenc.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_aipinsenc.npagactual() != self.pagvi_aipinsenc.npagcantidad()) {
                self.pagvi_aipinsenc.npagactual(self.pagvi_aipinsenc.npagcantidad);
                self.buscar('MOV');
            }
        }
    }

    
    

    vmInsPorProcLista1.prototype.toJSON = function () {
        var copia = ko.toJS(this);
        delete copia.encabezados_vi_aipinsenc;
        delete copia.lista_vi_aipinsenc;        
        return copia;
    }
</script>


