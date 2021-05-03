@* <fieldset>
    <legend>PAR&Aacute;METROS DE B&Uacute;SQUEDA</legend>


   <div class="editor-label">
        <label>Aplicaci&oacute;n</label>
    </div>
    <div class="editor-field" data-bind="with: segmanperf">
            <select data-bind="options: combo_departamento, optionsText: 'xnombredep', optionsValue: 'idsegmandep', value: idsegmandep, optionsCaption: 'SELECCIONE...'"></select>
        </div>
    <div class="editor-field" data-bind="with: vi_segappprog">
        <input type="text" data-bind="value: xnombreperf" />
    </div>


   <div style="float: left; margin: 1px; margin-top: 24px; margin-left: 10px;">
        <div style="float: left;">
            <input type="button" value="Buscar" data-bind="click: buscar" />
        </div>
        <div style="float: left;">
            <input type="button" value="Reiniciar" data-bind="click: reiniciar" />
        </div>
    </div>
</fieldset>*@

<fieldset>
    <legend>Lista de Aplicaciones</legend>

    <div class="grid-top-buttons">
        <div class="grid-top-button">
            <input type="button" value="Ver" data-bind="click: ir_ver, visible: boton_ver" />
        </div>
        <div class="grid-top-button">
            <input type="button" value="Agregar" data-bind="click: ir_agregar, visible: boton_agregar" />
        </div>
        <div class="grid-top-button">
            <input type="button" value="Modificar" data-bind="click: ir_modificar, visible: boton_modificar" />
        </div>
    </div>

    <div class="grid-area">

        <table class="grid-table" data-bind='visible: lista_vi_segappprog().length > 0'>
            <thead>
                <tr class="grid-row-header">
                    <th></th>
                    <th></th>
                    <th>Aplicaci&oacute;n</th>
                    <th>Modulo</th>
                    <th>SubModulo</th>
                    <th>Programa</th>
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_vi_segappprog'>
                <tr class="grid-row-content">
                    <td>
                        <input type="button" value="Ver" data-bind="click: $root.cargar_ver" />
                    </td>
                    <td>
                        <input type="button" value="Editar" data-bind="click: $root.cargar_editar" />
                    </td>
                    <td>
                        <span data-bind='text: xnombrecortoapp'></span>
                    </td>
                    <td>
                        <span data-bind='text: xnombrecortomod'></span>
                    </td>
                    <td>
                        <span data-bind='text: xnombrecortosubmod'></span>
                    </td>
                    <td>
                        <span data-bind='text: xnombrecortoprog'></span>
                    </td>
                </tr>
            </tbody>
            <tfoot>
                <tr class="grid-row-footer">
                    <td colspan="6">
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

                            <div class="info-pagination-noclear" data-bind="with: pagvi_segappprog">
                                <span>P&aacute;gina </span>
                                <span data-bind='text: npagactual'></span>
                                <span>de </span>
                                <span data-bind='text: npagcantidad'></span>
                            </div>
                        </div>
                    </td>
                </tr>
            </tfoot>
        </table>
        <div class="no-grid-rows" data-bind='visible: lista_vi_segappprog().length == 0'>No existen Aplicaciones almacenados...</div>
    </div>

    @*/grid con div*@

    @*        <div class="grid" data-bind='visible: lista_vi_segappprog().length > 0'>
            <div class="header">
                <span class="medium">>>></span>
                <span class="medium">Aplicaci&oacute;n</span>
                <span class="medium">Modulo</span>
                <span class="medium">SubModulo</span>
                <span class="medium">Programa</span>
            </div>
            <div class="content" data-bind='foreach: lista_vi_segappprog'>
                <div class="item">
                    <a class="medium" data-bind='click: $root.seleccionar'>Seleccionar</a>
                    <span class="medium" data-bind='text: xnombrecortoapp'></span>
                    <span class="medium" data-bind='text: xnombrecortomod '></span>
                    <span class="medium" data-bind='text: xnombrecortosubmod'></span>
                    <span class="medium" data-bind='text: xnombrecortoprog '></span>
                </div>
            </div>

            <div style="float: left; margin: 1px;">
                <div style="float: left;">
                    <input type="button" value="Primero" data-bind="click: ir_primero" />
                </div>
                <div style="float: left;">
                    <input type="button" value="Anterior" data-bind="click: ir_anterior" />
                </div>
                <div style="float: left;">
                    <input type="button" value="Siguiente" data-bind="click: ir_siguiente" />
                </div>
                <div style="float: left;">
                    <input type="button" value="Ultimo" data-bind="click: ir_ultimo" />
                </div>
            </div>
        </div>

        <div data-bind='visible: lista_vi_segappprog().length == 0'>No existen Usuarios almacenados...</div>
    </div>*@
</fieldset>

<script type="text/javascript">

    function vmmanappbuscar1(boton_ver, boton_agregar, boton_modificar) {
        var self = this;
        self.vi_segappprog = new vi_segappprog(true);

        self.pagvi_segappprog = new paginacion(1, 10, 0, "it.idsegappprog", "DESC");
        self.lista_vi_segappprog = ko.observableArray();
        self.boton_ver = ko.observable(boton_ver);
        self.boton_agregar = ko.observable(boton_agregar);
        self.boton_modificar = ko.observable(boton_modificar);
        
        self.cargar_ver = function (obj) {
            $("#tab-ver").removeClass("ui-state-disabled");
            postajaxjsonbasico("/Mantenimiento/ObtenerConfAppProgPorId/", "{'idsegappprog':'" + obj.idsegappprog() + "'}", function (vi_segappprog) {
                vmmanappver1.cargar(vi_segappprog);
                $(".tab").tabs("option", "active", 1);
                
            })
        }

        self.cargar_editar = function (obj) {
            $("#tab-editar").removeClass("ui-state-disabled");
            postajaxjsonbasico("/Mantenimiento/ObtenerConfAppProgPorId/", "{'idsegappprog':'" + obj.idsegappprog() + "'}", function (vi_segappprog) {
                vmmanappmodificar1.cargar(vi_segappprog);
                $(".tab").tabs("option", "active", 3);
            })
        }


        self.buscar = function () {

            postajaxjsonbasico("/Mantenimiento/ObtenerConfAppProg/", ko.toJSON(self), function (respvi_segappprogpaglist) {
                ko.mapping.fromJS(respvi_segappprogpaglist, {}, self);
            })
        }

        self.reiniciar = function () {
            self.vi_segappprog.idsegmanapp("");
        }

        self.ir_ver = function () {
            $(".tab").tabs("option", "active", 1);
        }

        self.ir_agregar = function () {
            $(".tab").tabs("option", "active", 2);
        }

        self.ir_modificar = function () {
            $(".tab").tabs("option", "active", 3);
        }

        self.seleccionar = function (obj) {
            postajaxjsonbasico("/Mantenimiento/ObtenerConfAppProgPorId/", "{'idsegappprog':'" + obj.idsegappprog() + "'}", function (vi_segappprog) {

                vmmanappver1.cargar(vi_segappprog);
                vmmanappmodificar1.cargar(vi_segappprog);

            })
        }

        self.ir_primero = function () {
            var npagactual = self.pagvi_segappprog.npagactual();
            if (npagactual != 1) {
                self.pagvi_segappprog.npagactual(1);
                self.buscar();
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_segappprog.npagactual();
            if (npagactual != 1) {
                self.pagvi_segappprog.npagactual(self.pagvi_segappprog.npagactual() - 1);
                self.buscar();
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_segappprog.npagactual() != self.pagvi_segappprog.npagcantidad()) {
                self.pagvi_segappprog.npagactual(self.pagvi_segappprog.npagactual() + 1);
                self.buscar();
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_segappprog.npagactual() != self.pagvi_segappprog.npagcantidad()) {
                self.pagvi_segappprog.npagactual(self.pagvi_segappprog.npagcantidad);
                self.buscar();
            }
        }

    }

</script>
