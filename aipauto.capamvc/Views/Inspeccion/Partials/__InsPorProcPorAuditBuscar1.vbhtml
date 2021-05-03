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
                            <span data-bind='datehtml: fcreainsenc' />
                        </td>
                        <td>
                            <input type="button" value="Ir a Procesar" data-bind="click: $root.procesar " />

                        </td>
                        <td>
                            <input type="button" value="Ver Fotos" data-bind="click: $root.verfotos" />

                        </td>
                        <td>
                            <input type="button" value="Multimedia" data-bind="click: $root.verMultimedia" />
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
    function vmInsPorProcPorAuditBuscar1() {
        var self = this;
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.pagvi_aipinsenc = new paginacion(1, 10, 0, "it.idaipinsenc", "DESC");
        self.lista_vi_aipinsenc = ko.observableArray();

        //variables
        self.idsegmanusuperit = ko.observable(0);

        self.encabezados_vi_aipinsenc = [

            { titulo: 'Id', campo: 'it.idaipinsenc' },
            { titulo: 'Cédula Propietario', campo: 'it.xcedsidoinsenc' },
            { titulo: 'Tipo', campo: 'it.itipoinsenc' },
            { titulo: 'F/Creacion', campo: 'it.fcreainsenc' },
        { titulo: '', campo: '' },
        { titulo: '', campo: '' },
        { titulo: '', campo: '' }
        ];

        self.buscar = function () {
            if (self.vi_aipinsenc.idsegmanusuaudit() > 0) {                
                postajaxjsonbasico("/Inspeccion/ObtenerInspeccionesPorProcesarPorAuditor/", ko.toJSON(self), function (respvi_aipinsencpaglist) {
                    ko.mapping.fromJS(respvi_aipinsencpaglist, {}, self);
                })
            }
            else {
                generar_noty_modal("Ha ocurrido un error con el auditor seleccionado", "warning");
            }
        }


        self.iniciar = function (idsegmanusuaudit) {
            self.vi_aipinsenc.idsegmanusuaudit(idsegmanusuaudit);
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
                case "SINIESTRO":
                    $("#dlg_InsSinGuardar1").dialog("open");
                    vmInsSinGuardar1.iniciar(obj, false);
                    $("#dlg_InsSinGuardar1").dialog({
                        close: function (event, ui) {
                            self.buscar();

                        }
                    });
                    break;
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
                    vmInsFotoModal1.iniciar(obj, obj.itipoinsenc, true);
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

        self.verMultimedia = function (obj) {

            //vmInsMultimediaModal1.iniciar(obj, obj.itipoinsenc);
            vmInsMultimediaModal1.cargarMultimedia(obj);
            $("#dlg_InsMultimModal1").dialog("open");

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
</script>


