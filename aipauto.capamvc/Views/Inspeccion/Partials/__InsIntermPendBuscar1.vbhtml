<fieldset style="width: 930px;">
    <legend>Par&aacute;metros de B&uacute;squeda</legend>


    <div data-bind="with: vi_intermediacion">
        <div class="form-row">

            <div class="form-column">
                <div class="form-field-header">
                    <label>Sucursal:</label>
                </div>
                <div class="form-field-content">
                    <select data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: idsegmanorg2"></select>
                </div>
            </div>
            <div class="form-column">
                <div class="form-field-header">
                    <label>Placa:</label>
                </div>
                <div class="form-field-content">
                    <input type="text"  id="autocompletado-placa" placeholder="Ej: AAA123" data-bind="value: placa" />
                    @*<select data-bind="options: $root.cboplacas, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: placa"></select>*@
                </div>
            </div>
        </div>
        
        <div class="form-row">
            <div class="form-column">
                <div class="form-field-header">
                    <label>N° de Siniestro /Cotizaci&oacute;n:</label>
                </div>
                <div class="form-field-content">
                    <input placeholder="Ej: 12145665" type="text" data-bind="value: xnumsininsenc" />
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
    <legend>Lista de inspecciones pendientes</legend>


    <div class="form-row">
        <div class="info-pagination" data-bind="with: pagvi_intermediacion">
            <span>P&aacute;gina </span>
            <span data-bind='text: npagactual'></span>
            <span>de </span>
            <span data-bind='text: npagcantidad'></span>
        </div>

        <div class="grid-area">
            <table class="grid-table" data-bind='visible: lista_vi_intermediacion().length > 0'>
                <thead>
                    <tr class="grid-row-header" data-bind="foreach: encabezados_vi_intermediacion">
                        <td data-bind="click: $parent.ordenar_vi_intermediacion, text: titulo"></td>
                    </tr>
                </thead>
                <tbody data-bind='foreach: lista_vi_intermediacion'>
                    <tr class="grid-row-content">
                        <td>
                            <span data-bind='text: idintermediacion' />
                        </td>
                        <td>
                            <span data-bind='text: placa' />
                        </td>
                        <td>
                            <span data-bind='text: xnumsininsenc' />
                        </td>
                        <td>
                            <span data-bind='text: itipoinsenc' />
                        </td>
                        <td>
                            <span data-bind='datehtml: fecha' />
                        </td>
                        <td>
                            <span data-bind='text: xnomsucinsinsenc2' />
                        </td>
                        <td style="width: 50px;">
                            <a href='#' data-bind='click: $root.cargar_agen'>
                                <img style="width: 45px; " src="@Url.Content("~/publico/imagenes/sitfx/agenda.png")">
                            </a>
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
            <div class="no-grid-rows" data-bind='visible: lista_vi_intermediacion().length == 0'>No existe inspecciones almacenadas...</div>
        </div>
    </div>
</fieldset>

<script type="text/javascript">
    function vmInsIntermPendBuscar1() {
        var self = this;
        self.vi_intermediacion = new vi_intermediacion(false);
        self.pagvi_intermediacion = new paginacion(1, 10, 0, "it.idintermediacion", "DESC");
        self.lista_vi_intermediacion = ko.observableArray();
        self.sel_idaipinsenc = ko.observable(0);
        self.cbosucursal = ko.observableArray();
        self.combomanusuperit = ko.observableArray();
        self.idsegmanorgperit = ko.observable(0);
        self.disabled_sucursal = ko.observable(true);
        self.ninsppend = ko.observable(0);
        self.ninspasig = ko.observable(0);
        self.cboplacas = ko.observableArray();


        self.llenarcbosucursal = function (idsegmanorgperit) {
            postajaxjsonbasico("/comun/ObtenerComboOrganizacion/", '{}', function (lista_vi_combosegmanorg) {
                self.cbosucursal(lista_vi_combosegmanorg);
                self.vi_intermediacion.idsegmanorgperit(idsegmanorgperit);
                self.buscar();
            });
        }

        self.llenarperito = function (obj, event) {            
            postajaxjsonbasico("/Agenda/ObtenerComboPeritosPorUsuarioYOrg/?idsegmanorg=" + obj.idsegmanorg2(), {}, function (lista_vi_segusudetperf2) {                
                self.combomanusuperit(lista_vi_segusudetperf2);
            });
        }

        


        self.llenarplacas = function () {            
            postajaxjsonbasico("/Inspeccion/ObtenerPlacasIntermediacionPendiente/", '{}',function (lista_comunconfvalor) {
                self.cboplacas(lista_comunconfvalor);
            })
        }
        self.encabezados_vi_intermediacion = [
            { titulo: 'N°', campo: 'it.idintermediacion' },
            { titulo: 'Placa', campo: 'it.placa' },
            { titulo: 'N° de Siniestro /Cotización', campo: 'it.' },
            { titulo: 'Tipo de Inspección', campo: 'it.' },
            { titulo: 'Fecha', campo: 'it.fecha' },
            { titulo: 'Sucursal', campo: 'it.xnomsucinsinsenc2' },            
            { titulo: 'Agendar', campo: 'it.' },
            //{ titulo: 'Perito', campo: 'it.xnombrecompleto' },                                                                                         
        ];

        self.ordenar_vi_intermediacion = function (encabezado) {
            if (encabezado.campo != "it.") {
                self.pagvi_intermediacion.xcamposord(encabezado.campo);
                if (self.pagvi_intermediacion.idirord() == 'ASC') {
                    self.pagvi_intermediacion.idirord('DESC');
                } else {
                    self.pagvi_intermediacion.idirord('ASC');
                }
                self.buscar();
            }
        };

        self.buscar = function () {
            self.lista_vi_intermediacion("");
            postajaxjsonbasico("/Inspeccion/ObtenerInpeccionesIntermediacionPendiente/", ko.toJSON(self), function (lista_vi_intermediacion) {
                ko.mapping.fromJS(lista_vi_intermediacion, {}, self);
            })
        }

        self.cargar_agen = function (obj) {
            if (obj.idsegmanorg2() > 0) {
                postajaxjsonbasico("/Inspeccion/ExisteInspeccionPorAgendar/?idintermediacion=" + obj.idintermediacion(), {}, function (respopera) {
                    if (respopera.irespuesta == "1") {
                        @* ESTA PANTALLA SE LLAMA DE FORMA DIRECTA para asi poder tener los valores del querystring dado que la pantalla de agenda trabaja diferente alresto *@
                        obj.idsegmanusuperit(0);
                        window.open("../Agenda/Agenda/?esvistaparcial=false&id=" + obj.idsegmanorg2() + "&id2=" + obj.idsegmanusuperit() + "&id3=" + obj.idintermediacion());
                    }
                    else {
                        generar_noty_modal(respopera.xmsjusuario, "error");
                        self.buscar();
                    }

                })
            }
            else
            {
                generar_noty_modal("No se puede agendar dado que el registro se creó sin sucursal, verificar con sistemas.", "error");
            }
        }

        self.limpiar = function () {
            self.vi_intermediacion.placa("");
            self.vi_intermediacion.xnumsininsenc("");
            self.vi_intermediacion.idsegmanorg2 (0);
        }

        self.iniciar = function () {
            self.verificarUsuario();
            //self.llenarplacas();
            self.buscar();

            postajaxjsonbasico("/Inspeccion/ObtenerPlacasIntermediacionPendiente/", '{}', function (lista_comunconfvalor) {

                var lista = [];
                var obj = {}; 
                
                for (var i = 0; i < lista_comunconfvalor.length; i++) {
                    if (lista_comunconfvalor[i].xvalorcodigo != "") {
                        obj = { label: lista_comunconfvalor[i].xvalordescripcion, value: lista_comunconfvalor[i].xvalorcodigo };
                        lista.push(obj);
                    }
                }

                $("#autocompletado-placa").autocomplete({
                    source: lista,
                    minLength: 1,
                    select: function (event, ui) {
                        event.preventDefault();
                        
                        self.vi_intermediacion.placa(ui.item.value);
                    }
                });
            });

        }

        self.verificarUsuario = function () {
            postajaxjsonbasico("/Seguridad/ObtenerUsuarioEnSession/", "", function (vi_segusudetperf2) {
                if (vi_segusudetperf2 != null) {

                    //si es Administrador
                    if (vi_segusudetperf2.idsegmanperf == 1) {
                        self.llenarcbosucursal(0);
                        self.disabled_sucursal(false);

                    }//auditor lider principal
                    else if (vi_segusudetperf2.idsegmanperf == 2) {

                        self.llenarcbosucursal(0);
                        self.disabled_sucursal(false);

                    }//si es Auditor Lider Sucursal
                    else if (vi_segusudetperf2.idsegmanperf == 3) {

                        self.llenarcbosucursal(vi_segusudetperf2.idsegmanorg);
                        self.disabled_sucursal(true);

                    }//Perito Lider Sucursal
                    else if (vi_segusudetperf2.idsegmanperf == 7) {
                        generar_noty_modal("Disculpe, usted no puede realizar esta acción.", "warning")
                        return false;
                    }


                }
                else {
                    self.disabled_accion(true);
                    self.disabled_sucursal(true);
                    generar_noty_modal("Disculpe no hemos podido verificar el tipo de usuario", "warning")
                }
            });
        }


        self.ir_primero = function () {
            var npagactual = self.pagvi_intermediacion.npagactual();
            if (npagactual != 1) {
                self.pagvi_intermediacion.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_intermediacion.npagactual();
            if (npagactual != 1) {
                self.pagvi_intermediacion.npagactual(self.pagvi_intermediacion.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_intermediacion.npagactual() != self.pagvi_intermediacion.npagcantidad()) {
                self.pagvi_intermediacion.npagactual(self.pagvi_intermediacion.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_intermediacion.npagactual() != self.pagvi_intermediacion.npagcantidad()) {
                self.pagvi_intermediacion.npagactual(self.pagvi_intermediacion.npagcantidad);
                self.buscar('MOV');
            }
        }
    }

    vmInsIntermPendBuscar1.prototype.toJSON = function () {
        var copia = ko.toJS(this);
        delete copia.lista_vi_intermediacion;
        delete copia.cbosucursal;
        delete copia.combomanusuperit;
        return copia;
    }

</script>