 
<fieldset style="width: 930px;">
    <legend>Par&aacute;metros de B&uacute;squeda</legend>

    
    <div data-bind="with: vi_aipinsenc">
            <div class="form-row">

            <div class="form-column">
                <div class="form-field-header">
                    <label>Id:</label>
                </div>
                <div class="form-field-content">
                    <input placeholder="Ej: 123" type="text" data-bind="value: idaipinsenc" />
                </div>
            </div>
            <div class="form-column">
                <div class="form-field-header">
                    <label>Perito:</label>
                </div>
                <div class="form-field-content">
                    <input placeholder="Ej: 123" type="text" data-bind="value: xnombrecompleto" />
              </div>
            </div>
            <div class="form-column">
                <div class="form-field-header">
                    <label>Ced.Ident/R.U.C. Propietario:</label>
                </div>
                <div class="form-field-content">
                    <input placeholder="Ej: repuesto" type="text" data-bind="numeralvalue: xcedsidoinsenc" />
                </div>
                
            </div>
        
    </div>
        
            <div class="form-row">
                 <div class="form-column">
                <div class="form-field-header">
                    <label>Tipo de Inspeccion:</label>
                </div>
                <div class="form-field-content">
                       <select data-bind="options: combotipoinsenc, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: itipoinsenc"></select>
                </div>
            </div>
            <div class="form-column">
                <div class="form-field-header">
                    <label>Serial Motor:</label>
                </div>
                <div class="form-field-content">
                    <input placeholder="Ej: 123" type="text" data-bind="value: xsermotinsenc" />
              </div>
            </div>
            <div class="form-column">
                <div class="form-field-header">
                    <label>Serial Carroceria:</label>
                </div>
                <div class="form-field-content">
                    <input placeholder="Ej: repuesto" type="text" data-bind="value: xsercarrinsenc" />
                </div>
                
            </div>
                </div>
</div> 
        <div class="form-column-button-left">
                <input type="button" value="Buscar" data-bind="click: buscar" />
                <input type="button" value="Limpiar" data-bind="click: limpiar" />
        </div>
</fieldset>
<fieldset class="form-area">
    <legend>Lista de inspecciones </legend>
 
     
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
                          <input type="button" value="Documento" data-bind="click: $root.documento " /> 
        
                    </td><td> 
            <input type="button" value="Ver Fotos" data-bind="click: $root.verfotos" /> 
        
                    </td>
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
        <div class="no-grid-rows" data-bind='visible: lista_vi_aipinsenc().length == 0'>No existe inspecciones...</div>
    </div>
        </div>
</fieldset>

<script type="text/javascript">
    function vmInsConsPtoBuscar1(boton_ver, boton_agregar, boton_modificar) {
        var self = this;
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.pagvi_aipinsenc = new paginacion(1, 10, 0, "it.idaipinsenc", "DESC");
        self.lista_vi_aipinsenc = ko.observableArray();
        self.sel_idaipinsenc = ko.observable(0);
        self.boton_ver = ko.observable(boton_ver);
        self.boton_agregar = ko.observable(boton_agregar);
        self.boton_modificar = ko.observable(boton_modificar);
        self.limpiar = function () {
            self.vi_aipinsenc.idaipinsenc(0);
            self.vi_aipinsenc.xcedsidoinsenc("");
            self.vi_aipinsenc.itipoinsenc("");
            self.vi_aipinsenc.fcreainsenc("");
            self.vi_aipinsenc.xnombrecompleto("");
            self.vi_aipinsenc.xsermotinsenc("");
            self.vi_aipinsenc.xsercarrinsenc("");
        }
        self.encabezados_vi_aipinsenc = [
            { titulo: '', campo: '' },
            { titulo: '', campo: '' },
            { titulo: 'Id', campo: 'it.xnommanrepu' },
            { titulo: 'Ced.Ident/R.U.C. Propietario', campo: 'it.xcedpropinsenc' },
            { titulo: 'Tipo', campo: 'it.imaterpiezbaremobr' },
            { titulo: 'F/Creacion', campo: 'it.itamapiezbaremobr' }
         
        ];
        self.buscar = function () {
            postajaxjsonbasico("/Inspeccion/ObtenerInspecciones/", ko.toJSON(self), function (peti) {
                ko.mapping.fromJS(peti, {}, self); 
            })
        }
        
        self.llenarcombotipo = function () {
            var xconcepto = "ITIPOINSENC";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.vi_aipinsenc.combotipoinsenc(lista_comunconfvalor);

            })
        }
        self.iniciar=function()
        {
            self.buscar();
            self.llenarcombotipo();

        }
        self.documento = function (obj) { 
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
                    vmInsSinGuardar1.iniciar(obj);
                    $("#dlg_InsSinGuardar1").dialog({
                        close: function (event, ui) {
                            self.buscar();

                        }
                    });
                    break;
                case "RESTOS Y SALVAMENTO":
                    vmInsRestGuardar1.iniciar(obj);
                    $("#dlg_InsRestGuardar1").dialog("open");
                    $("#dlg_InsRestGuardar1").dialog({
                        close: function (event, ui) {
                            self.buscar();
                        }
                    });
                    break;
                case "LIMPIEZA DE DAÑOS POR SUSCRIPCION":
                    $("#dlg_InsLimDanSusGuardar1").dialog("open");
                    vmInsLimDanSusGuardar1.iniciar(obj);
                    $("#dlg_InsLimDanSusGuardar1").dialog({
                        close: function (event, ui) {
                            self.buscar();
                        }
                    });
                    break;
                case "LIMPIEZA DE DAÑOS POR SINIESTRO":
                    $("#dlg_InsLimDanSinGuardar1").dialog("open");
                    vmInsLimDanSinGuardar1.iniciar(obj);
                    $("#dlg_InsLimDanSinGuardar1").dialog({
                        close: function (event, ui) {
                            self.buscar();
                        }
                    });
                    break;
                case "AJUSTES POR SINIESTRO":
                    vmInsAjusDanSinGuardar1.iniciar(obj);
                    $("#dlg_InsAjusDanSinGuardar1").dialog("open");
                    $("#dlg_InsAjusDanSinGuardar1").dialog({
                        close: function (event, ui) {
                            self.buscar();
                        }
                    });
                    break;
                case "AJUSTES POR ANEXO":
                    vmInsAjusDanAnexGuardar1.iniciar(obj);
                    $("#dlg_InsAjusDanAnexGuardar1").dialog("open");
                    $("#dlg_InsAjusDanAnexGuardar1").dialog({
                        close: function (event, ui) {
                            self.buscar();
                        }
                    });
                    break;
                default:
                    break;
            }
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

                }
            });



        }
    }
</script>