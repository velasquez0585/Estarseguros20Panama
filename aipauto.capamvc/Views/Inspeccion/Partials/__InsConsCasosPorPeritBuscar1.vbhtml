<fieldset class="form-area" data-bind="with: vi_aipinsperitagrup">
    <legend>Par&aacute;metros de Busqueda</legend>

    <div class="form-column">
        <div class="form-field-header">
            <label>Sucursal</label>
            <div class="form-field-content">                
                <select data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: idsegmanorgperit, disable: $root.disabled_sucursal"></select>
            </div>
        </div>
    </div>

    <div class="form-column-button-left">
        <input type="button" value="Buscar" data-bind="click: $root.buscar" />
    </div>

</fieldset>

<fieldset class="form-area">
    <legend>Lista de casos pendientes por Peritos</legend>
    <div class="form-row">
        <div class="info-pagination" data-bind="with: pagvi_aipinsperitagrup">
            <span>P&aacute;gina </span>
            <span data-bind='text: npagactual'></span>
            <span>de </span>
            <span data-bind='text: npagcantidad'></span>
        </div>
        
        <div class="grid-area">
            <table class="grid-table" data-bind='visible: lista_vi_aipinsperitagrup().length > 0'>
                <thead>
                    <tr class="grid-row-header" data-bind="foreach: encabezados_vi_aipinsperitagrup">
                        <td data-bind="click: $parent.ordenar_vi_aipinsperitagrup, text: titulo"></td>
                    </tr>
                </thead>
                <tbody data-bind='foreach: lista_vi_aipinsperitagrup'>
                    <tr class="grid-row-content">
                        <td style="text-align: center">
                            <input type="button" data-bind='click: $root.verDetalle' value="Ver detalle" />
                            
                        </td>
                        <td style="text-align: center">
                            <span data-bind='text: xnombrecompletoperit' />
                        </td>
                        <td  style="text-align: center">
                            <span data-bind='text: xnombrecomercialperit' />
                        </td>
                        <td  style="text-align: center">                            
                            <span data-bind='text: ncantreg() + " por procesar"' />
                            
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
            <div class="no-grid-rows" data-bind='visible: lista_vi_aipinsperitagrup().length == 0'>No existen casos almacenados...</div>
        </div>
    </div>

    @*<div id='map'></div>*@
</fieldset>

<script type="text/javascript">
    function vmInsConsCasosPorPeritBuscar1() {
        var self = this;
        self.vi_aipinsperitagrup = new vi_aipinsperitagrup(false);
        self.pagvi_aipinsperitagrup = new paginacion(1, 10, 0, "it.idsegmanusuperit", "ASC");
        self.lista_vi_aipinsperitagrup = ko.observableArray();
        self.cbosucursal = ko.observableArray();
        self.disabled_sucursal = ko.observable(false);


        self.encabezados_vi_aipinsperitagrup = [
            { titulo: '', campo: '' },
            { titulo: 'Perito', campo: 'it.xnombrecompletoperit' },
            { titulo: 'Sucursal', campo: 'it.xnombrecomercialperit' },
            { titulo: 'Total de casos', campo: 'it.ncantreg' }
        ];

        self.verificarUsuario = function () {
            postajaxjsonbasico("/Seguridad/ObtenerUsuarioEnSession/", "", function (vi_segusudetperf2) {
                if (vi_segusudetperf2 != null) {
                    
                    //si es Administrador
                    if (vi_segusudetperf2.idsegmanperf == 1) {
                        self.vi_aipinsperitagrup.idsegmanorgperit(0);
                        self.llenarcbosucursal(0);                        
                        self.disabled_sucursal(false);
                       
                        
                    }//auditor lider principal
                    else if (vi_segusudetperf2.idsegmanperf == 2) {
                        self.vi_aipinsperitagrup.idsegmanorgperit(0);
                        self.llenarcbosucursal(0);                       
                        self.disabled_sucursal(false);
                    }//si es Auditor Lider Sucursal                        
                    else if (vi_segusudetperf2.idsegmanperf == 3) {
                        self.vi_aipinsperitagrup.idsegmanorgperit(vi_segusudetperf2.idsegmanorg);
                        self.llenarcbosucursal(vi_segusudetperf2.idsegmanorg);                      
                        self.disabled_sucursal(true);
                    }//Perito Lider Sucursal
                    else if (vi_segusudetperf2.idsegmanperf == 7) {
                        self.vi_aipinsperitagrup.idsegmanorgperit(vi_segusudetperf2.idsegmanorg);
                        self.llenarcbosucursal(vi_segusudetperf2.idsegmanorg);
                        self.disabled_sucursal(true);
                        
                        
                    }
                    else {
                        self.disabled_sucursal(true);
                        generar_noty_modal("Disculpe, usted no puede realizar esta acción.", "warning")
                        return false;

                    }


                }
                else {
                    
                    self.disabled_sucursal(true);
                    generar_noty_modal("Disculpe no hemos podido verificar el tipo de usuario", "warning")
                }
            });
        }


        self.buscar = function (accion) {

            if (accion != 'MOV')
                self.pagvi_aipinsperitagrup.npagactual(1);

            postajaxjsonbasico("/Inspeccion/ObtenerInsCasosPeritPorProcesar/", ko.toJSON(self), function (lista_vi_aipinsperitagrup) {
                ko.mapping.fromJS(lista_vi_aipinsperitagrup, {}, self);
            })
        }


        self.iniciar = function () {
            //self.buscar();
            self.verificarUsuario();
        }

        self.llenarcbosucursal = function (idsegmanorg) {
            postajaxjsonbasico("/comun/ObtenerComboOrganizacion/", '{}', function (lista_vi_combosegmanorg) {
                self.cbosucursal(lista_vi_combosegmanorg);
                self.vi_aipinsperitagrup.idsegmanorgperit(idsegmanorg);
                self.buscar();
            });
        }
        
        self.verDetalle = function (obj) {
            vmInsPorProcPorPeritBuscar1.iniciar(obj.idsegmanusuperit());
            $("#dlg_insporprocporperitbuscar1").dialog("open");            
        }
        
        self.ir_primero = function () {
            var npagactual = self.pagvi_aipinsperitagrup.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipinsperitagrup.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_aipinsperitagrup.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipinsperitagrup.npagactual(self.pagvi_aipinsperitagrup.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_aipinsperitagrup.npagactual() != self.pagvi_aipinsperitagrup.npagcantidad()) {
                self.pagvi_aipinsperitagrup.npagactual(self.pagvi_aipinsperitagrup.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_aipinsperitagrup.npagactual() != self.pagvi_aipinsperitagrup.npagcantidad()) {
                self.pagvi_aipinsperitagrup.npagactual(self.pagvi_aipinsperitagrup.npagcantidad);
                self.buscar('MOV');
            }
        }
    }
</script>


