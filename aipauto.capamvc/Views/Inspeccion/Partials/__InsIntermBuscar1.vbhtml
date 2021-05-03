<fieldset class="form-area">
    
    <div class="form-column" style="margin-top: 60px; width: 250px" data-bind="with: vi_intermediacion">
        <a href='#' data-bind='click: $root.cargar_pendiente' style="overflow:visible; ">
            <div class=" form-row">
                <div class="form-field-content">
                    <section class="featured" style="width:210px;">
                            <div class="content-wrapper">
                                <div>
                                    <span data-bind='text: $root.ninsppend' />
                                </div>
                                <div>
                                    <span>Inspecciones</span>
                                    <br />
                                    <span>Pendientes</span>
                                    <img class="icon-app" style="width: 30%; float:right; margin-top:-30px" src="@Url.Content("~/publico/imagenes/sitfx/Info.png")" alt="appicon">
                                </div>
                            </div>                        
                    </section>
                </div>
            </div>
        </a>        
        <a href='#' data-bind='click: $root.cargar_asignada' style="overflow:visible; ">
            <div class="form-row">
                <div class="form-field-content">
                    <section class="featured" style="width: 210px;">
                        <div class="content-wrapper" style="background-color: #5F5C0C;">
                            <div>
                                <span data-bind='text: $root.ninspasig' />
                            </div>
                            <div>
                                <span>Inspecciones</span>
                                <br />
                                <span>Asignadas.</span>
                                <img class="icon-app" style="width: 30%; float:right; margin-top:-30px" src="@Url.Content("~/publico/imagenes/sitfx/check.png")" alt="appicon">
                            </div>
                        </div>
                    </section>
                </div>
            </div>
        </a>     
</div>


        <div class="form-column">
            <legend>Lista de &Uacute;ltimas inspecciones solicitadas</legend>
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
                                    <span data-bind='text: xnombrecompletoperit' />
                                </td>
                                <td>
                                    <span data-bind='text: itipoinsenc' />
                                </td>
                                <td>
                                    <span data-bind='datehtml: fcreainsenc' />
                                </td>
                                <td>
                                    <span data-bind='text: iestatinsenc' />
                                </td>
                                @*<td>
                                        <select style="width: 180px;" data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: idsegmanorgperit, disable: true"></select>
                                    </td>*@

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
        </div>

</fieldset>

<script type="text/javascript">
    function vmInsIntermBuscar1() {
        var self = this;
        self.vi_intermediacion = new vi_intermediacion(false);
        self.pagvi_intermediacion = new paginacion(1, 10, 0, "it.fecha", "DESC");
        self.lista_vi_intermediacion = ko.observableArray();
        self.sel_idaipinsenc = ko.observable(0);
        self.cbosucursal = ko.observableArray();
        self.idsegmanorgperit = ko.observable(0);
        self.disabled_sucursal = ko.observable(true);
        self.ninsppend = ko.observable(0);
        self.ninspasig = ko.observable(0);        

        self.llenarcbosucursal = function (idsegmanorgperit) {
            postajaxjsonbasico("/comun/ObtenerComboOrganizacion/", '{}', function (lista_vi_combosegmanorg) {
                self.cbosucursal(lista_vi_combosegmanorg);
                self.vi_intermediacion.idsegmanorgperit(idsegmanorgperit);
                self.buscar();
            });
        }

        self.llenarcombotipo = function () {
            var xconcepto = "ITIPOINSENC";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.vi_intermediacion.combotipoinsenc(lista_comunconfvalor);

            })
        }
        self.encabezados_vi_intermediacion = [
            { titulo: 'N°', campo: 'it.idintermediacion' },
            { titulo: 'Perito', campo: 'it.xnombrecompleto' },
            { titulo: 'Tipo de Inspección', campo: 'it.itipoinsenc' },
            { titulo: 'Fecha', campo: 'it.fcreainsenc' },                                                  
            { titulo: 'Estatus', campo: 'it.iestatinsenc' },        
        ];

        self.ordenar_vi_intermediacion = function (encabezado) {
            self.pagvi_intermediacion.xcamposord(encabezado.campo);
            if (self.pagvi_intermediacion.idirord() == 'ASC') {
                self.pagvi_intermediacion.idirord('DESC');
            } else {
                self.pagvi_intermediacion.idirord('ASC');
            }
            self.buscar();
        };

        self.buscar = function () {
            postajaxjsonbasico("/Inspeccion/ObtenerInspeccionesIntermediacion/", ko.toJSON(self), function (lista_vi_intermediacion) {
                ko.mapping.fromJS(lista_vi_intermediacion, {}, self);
                postajaxjsonbasico("/Inspeccion/ObtenerTotalInspecionesIntermediacion/", ko.toJSON(), function (aipinstotalpers) {
                    self.ninsppend(aipinstotalpers.ninstotalperspend);
                    self.ninspasig(aipinstotalpers.ninstotalpersasig);
                })
            })
        }

        self.cargar_pendiente = function () {
            vmInsIntermPendBuscar1.iniciar();
            //al hacer click en "ver" habilitamos el tab "pendiente"
            $("#tab-pen").removeClass("ui-state-disabled");
            //ahora nos movemos hacia el tab "pendiente"
            $("#tab_inspinter").tabs("option", "active", 1);
        }

        self.cargar_asignada = function () {
            vmInsIntermAsigBuscar1.iniciar();
            //al hacer click en "ver" habilitamos el tab "pendiente"
            $("#tab-asig").removeClass("ui-state-disabled");
            //ahora nos movemos hacia el tab "pendiente"
            $("#tab_inspinter").tabs("option", "active", 2);
        }

        self.limpiar = function () {
            self.vi_intermediacion.idaipinsenc(0);
            self.vi_intermediacion.xcedsidoinsenc("");
            self.vi_intermediacion.itipoinsenc("");
            self.vi_intermediacion.fcreainsenc("");
            self.vi_intermediacion.xnombrecompleto("");
            self.vi_intermediacion.xsermotinsenc("");
            self.vi_intermediacion.xsercarrinsenc("");
        }

        self.iniciar = function () {
            self.verificarUsuario();
            self.llenarcombotipo();
            self.buscar();

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

    vmInsIntermBuscar1.prototype.toJSON = function () {
        var copia = ko.toJS(this);
        delete copia.lista_vi_intermediacion;
        delete copia.cbosucursal;
        return copia;
    }

</script>