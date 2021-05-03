<div class="tab">
    <ul>
        <li><a href="#tab-1">Buscar</a></li>
        <li><a href="#tab-2">Agregar</a></li>
        <li><a href="#tab-3">Ver/Modificar</a></li>
    </ul>
    <div id="tab-1">
        <fieldset id="fs_param_busq_cotiza_indiv" style="width:930px;">
            <legend>Par&aacute;metros de B&uacute;squeda</legend>

            <ul id="lista_err_cotiza_indiv" style="display: none;">
                <li data-bind="validationMessage: xnummancotiz" style="color: red;"></li>
                <li data-bind="validationMessage: fdesdecobmancotiz" style="color: red;"></li>
                <li data-bind="validationMessage: fhastacobmancotiz" style="color: red;"></li>
            </ul>
            
            <div style="float:left;margin:1px;">
                <div class="editor-label">
                    <label>N° Cotizaci&oacute;n</label>
                </div>
                <div class="editor-field">
                    <input placeholder="Ej: 883763" type="number" data-bind="value: xnummancotiz" />
                </div>
            </div>
            <div style="float:left;margin:1px;">
                <div class="editor-label">
                    <label>Fecha desde</label>
                </div>
                <div class="editor-field">
                    <input placeholder="Ej: 01/01/2000" class="date-field" type="text" data-bind="datevalue: fdesdecobmancotiz" />
                </div>
            </div>
            <div style="float:left;margin:1px;">
                <div class="editor-label">
                    <label>Fecha hasta</label>
                </div>
                <div class="editor-field">
                    <input placeholder="Ej: 01/01/2000" class="date-field" type="text" data-bind="datevalue: fhastacobmancotiz" />
                </div>
            </div>
            <div style="float:left;margin:1px;">
                <div class="editor-label">
                    <label>Estatus</label>
                </div>
                <div class="editor-field">
                    <select data-bind="options: lista_estatus, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iestatusmancotiz"></select>
                </div>
            </div>
            <div style="float: left;margin:1px;margin-top:24px; margin-left:10px;">
                <div style="float: left;">
                    <input type="button" value="Buscar" data-bind="click: buscar_cotiza_indiv" />
                </div>
                <div style="float: left;">
                    <input type="button" value="Limpiar" data-bind="click: limpiar_cotiza_indiv" />
                </div>
            </div>
        </fieldset>

        <fieldset id="fs_lista_cotiza_indiv" style="width:930px;">
            <legend>Lista de cotizaciones individuales</legend>
            <div style="float: left;margin:1px;">
                <div style="float: left;">
                    <input type="button" value="Ver" data-bind="click: ver_cotiza_indiv" />
                </div>
                <div style="float: left;">
                    <input type="button" value="Modificar" data-bind="click: modificar_cotiza_indiv" />
                </div>
                <div style="float: left;">
                    <input type="button" value="Aceptar" data-bind="click: aceptar_cotiza_indiv" />
                </div>
                <div style="float: left;">
                    <input type="button" value="Imprimir" data-bind="click: imprimir_cotiza_indiv" />
                </div>
            </div>
            <div style="clear:both;">
                <table data-bind='visible: cotizaciones_indiv().length > 0' cellspacing="10">
                    <thead>
                        <tr>
                            <th></th>
                            <th>N° Cotizaci&oacute;n</th>
                            <th>F/Desde</th>
                            <th>F/Hasta</th>
                            <th>Estatus</th>
                        </tr>
                    </thead>
                    <tbody data-bind='foreach: cotizaciones_indiv'>
                        <tr>
                            <td>
                                <a href='#' data-bind='click: $root.seleccionar_cotiza_indiv'>Seleccionar</a>
                            </td>
                            <td>
                                <span data-bind='text: xnummancotiz, uniqueName: true' />
                            </td>
                            <td>
                                <span data-bind='text: fdesdecobmancotiz' />
                            </td>
                            <td>
                                <span data-bind='text: fhastacobmancotiz' />
                            </td>
                            <td>
                                <span data-bind='text: iestatusmancotiz' />
                            </td>
                        </tr>
                    </tbody>
                    <tfoot>
                        <tr>
                            <td colspan="5">
                                <div style="float: left; margin: 1px;">
                                    <div style="float: left;">
                                        <a href='#' data-bind='click: ir_primero_cotiza_indiv'>Primero</a>
                                    </div>
                                    <div style="float: left;">
                                        <a href='#' data-bind='click: ir_anterior_cotiza_indiv'>Anterior</a>
                                    </div>
                                    <div style="float: left;">
                                        <a href='#' data-bind='click: ir_siguiente_cotiza_indiv'>Siguiente</a>
                                    </div>
                                    <div style="float: left;">
                                        <a href='#' data-bind='click: ir_ultimo_cotiza_indiv'>Ultimo</a>
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </tfoot>
                </table>
                <div data-bind='visible: cotizaciones_indiv().length == 0'>No existen cotizaciones individuales almacenadas...</div>
            </div>
        </fieldset>
    </div>
    <div id="tab-2">
        Este es el tab 2
    </div>
    <div id="tab-3">
        Este es el tab 3
    </div>
</div>

<script type="text/javascript">
    ko.validation.configure({
        registerExtenders: true,
        messagesOnModified: false,
        insertMessages: false,
        parseInputAttributes: true,
        messageTemplate: null
    });

    var data_lista_estatus = ([
        { xvalorcodigo: "", xvalordescripcion: "SELECCIONAR..." },
        { xvalorcodigo: "PENDIENTE", xvalordescripcion: "PENDIENTE" },
        { xvalorcodigo: "ANULADA", xvalordescripcion: "ANULADA" },
        { xvalorcodigo: "APROBADA", xvalordescripcion: "APROBADA" }
    ])

    var data_param_busq_cotiza_indiv = {
        xnummancotiz: "",
        fdesdecobmancotiz: "",
        fhastacobmancotiz: "",
        iestatusmancotiz: ""
    }

    function vm_param_busq_cotiza_indiv(param_busq_cotiza_indiv, lista_estatus) {
        var self = this;
        self.xnummancotiz = ko.observable(param_busq_cotiza_indiv.xnummancotiz).extend({
            number: { message: "La cotización debe ser númerica." }
        });
        self.fdesdecobmancotiz = ko.observable(param_busq_cotiza_indiv.fdesdecobmancotiz).extend({
            date: { message: "La fecha desde es inválida" }
        });
        self.fhastacobmancotiz = ko.observable(param_busq_cotiza_indiv.fhastacobmancotiz).extend({
            date: { message: "La fecha hasta es inválida" }
        });
        self.iestatusmancotiz = ko.observable(param_busq_cotiza_indiv.iestatusmancotiz);
        self.lista_estatus = ko.observableArray(lista_estatus);

        self.limpiar_cotiza_indiv = function () {
            ko.mapping.fromJS(data_param_busq_cotiza_indiv, {}, self);
        }

        self.buscar_cotiza_indiv = function () {
            self.errors = ko.validation.group(this);
            if (self.errors().length > 0) {
                generar_noty($('#lista_err_cotiza_indiv').html(), "warning");
                return false;
            }
            
            llamar_ajax_basico("/Cotizacion/Buscar/", ko.toJSON(self), function (resp) {
                if (resp.infomodel.xtitulo == 'Ok') {
                    generar_noty(resp.infomodel.xmensaje, 'success');
                } else {
                    generar_noty(resp.infomodel.xmensaje, 'error');
                }
            })
        }
    }
    ko.applyBindings(new vm_param_busq_cotiza_indiv(data_param_busq_cotiza_indiv, data_lista_estatus), $('#fs_param_busq_cotiza_indiv')[0]);


    //-------------------------------------------------------------------------------------------------------------------


    var data_lista_cotiza_indiv = ([
        { xnummancotiz: "248856", fdesdecobmancotiz: "01/07/2013", fhastacobmancotiz: "10/11/2013", iestatusmancotiz: "PENDIENTE" },
        { xnummancotiz: "250090", fdesdecobmancotiz: "15/04/2013", fhastacobmancotiz: "25/09/2013", iestatusmancotiz: "APROBADA" }
    ])

    function vm_lista_cotiza_indiv(lista_cotiza_indiv) {
        var self = this;
        self.cotizaciones_indiv = ko.observableArray(lista_cotiza_indiv);

        self.seleccionar_cotiza_indiv = function (cotiza_indiv) {
            alert(cotiza_indiv.xnummancotiz);
        }

        self.ver_cotiza_indiv = function () {
            
        }

        self.modificar_cotiza_indiv = function () {

        }

        self.aceptar_cotiza_indiv = function () {

        }

        self.imprimir_cotiza_indiv = function () {

        }

        self.ir_primero_cotiza_indiv = function () {

        }

        self.ir_anterior_cotiza_indiv = function () {

        }

        self.ir_siguiente_cotiza_indiv = function () {

        }

        self.ir_ultimo_cotiza_indiv = function () {

        }
    }

    ko.applyBindings(new vm_lista_cotiza_indiv(data_lista_cotiza_indiv), $('#fs_lista_cotiza_indiv')[0]);
</script>