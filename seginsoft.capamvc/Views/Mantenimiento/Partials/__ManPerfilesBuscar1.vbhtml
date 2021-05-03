@*<fieldset>
    <legend>PAR&Aacute;METROS DE B&Uacute;SQUEDA</legend>


    <div class="form-column">
        <div class="form-field-header">
            Departamento
        </div>
        <div class="form-field-content">
            <select data-bind="options: $root.combodepartamento, optionsText: 'xnombredep', optionsValue: 'idsegmandep', value: idsegmandep"></select>
        </div>
    </div>

    <div class="form-column-button-left">
        <input type="button" value="Buscar" data-bind="click: buscar" />
    </div>
    <div class="form-column-button-left">
        <input type="button" value="Limpiar" data-bind="click: reiniciar" />
    </div>
      
</fieldset>*@

<fieldset>
    <legend>Lista de Perfiles</legend>

    
        <div class="grid-top-buttons">
            @*<div class="grid-top-button">
                <input type="button" value="Ver" data-bind="click: ir_ver, visible: boton_ver" />
            </div>*@
           <div class="grid-top-button">
                <input type="button" value="Agregar" data-bind="click: ir_agregar, visible: boton_agregar" />
            </div>
            @*<div class="grid-top-button">
                <input type="button" value="Modificar" data-bind="click: ir_modificar, visible: boton_modificar" />
            </div>*@
        </div>

       

             <div class="grid-area">
                
                <table class="grid-table" data-bind='visible: lista_segmanperf().length > 0'>
                    <thead>
                        <tr class="grid-row-header">
                            <th></th>
                            <th></th>
                            <th>Id</th>
                            <th>Nombre</th>
                            <th>Abreviatura</th>    
                            <th>Nivel</th>    
                        </tr>
                    </thead>      
                    <tbody data-bind='foreach: lista_segmanperf'>
                        <tr class="grid-row-content">
                            <td>                                
                                <input type="button" value="Ver" data-bind="click: $root.cargar_ver" />
                            </td>
                            <td>                                
                                <input type="button" value="Editar" data-bind="click: $root.cargar_editar" />
                            </td>                          
                            <td>
                                <span data-bind='text: idsegmanperf'></span>
                            </td>
                            <td>
                                <span data-bind='text: xnombreperf'></span>
                            </td>
                            <td>
                               <span data-bind='text: xabrevperf'></span>
                            </td>
                            <td>
                               <span data-bind='text: nnivelperf'></span>
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
                                <div class="info-pagination-noclear" data-bind="with: pagsegmanperf">
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
                <div class="no-grid-rows" data-bind='visible: lista_segmanperf().length == 0'>No existen Perfiles almacenados...</div>
            </div>

</fieldset>


<script type="text/javascript">

    function vmmanperfilesbuscar1(boton_ver, boton_agregar, boton_modificar) {
        var self = this;
        self.segmanperf = new segmanperf(false);
        self.vi_segappperf = new vi_segappperf(false);
        self.pagsegmanperf = new paginacion(1, 10, 0, "it.idsegmanperf", "DESC");
        self.pagvi_segappperf = new paginacion(1, 10, 0, "it.idsegappperf", "DESC");
        
        self.lista_segmanperf = ko.observableArray();
        self.boton_ver = ko.observable(boton_ver);
        self.boton_agregar = ko.observable(boton_agregar);
        self.boton_modificar = ko.observable(boton_modificar);
        self.idsegmandep = ko.observable(0);
        self.combodepartamento = ko.observableArray();

        self.cargar_ver = function (obj) {
            $("#tab-ver").removeClass("ui-state-disabled");
            postajaxjsonbasico("/Mantenimiento/ObtenerPerfilPorId/", "{'idsegmanperf':'" + obj.idsegmanperf() + "'}", function (segmanperf) {
                vmmanperfilesver1.cargar(segmanperf);                
                $(".tab").tabs("option", "active", 1);
            })            
        }

        self.cargar_editar = function (obj) {
            $("#tab-editar").removeClass("ui-state-disabled");
            postajaxjsonbasico("/Mantenimiento/ObtenerPerfilPorId/", "{'idsegmanperf':'" + obj.idsegmanperf() + "'}", function (segmanperf) {
                vmmanperfilesmodificar1.cargar(segmanperf);
                $(".tab").tabs("option", "active", 3);
            })
        }

        self.llenarcombodepartamento = function () {
            postajaxjsonbasico("/Mantenimiento/ObtenerComboDepartamentos/", "{}", function (lista_segmandep) {
                self.combodepartamento(lista_segmandep);
            })
        }


        self.buscar = function (tipo) {

            if (tipo != "MOV") {
                self.pagvi_segappperf.npagactual(1);
            }
                             
                postajaxjsonbasico("/Mantenimiento/ObtenerPerfiles/", ko.toJSON(self), function (resp_segmanperfpaglist) {
                    ko.mapping.fromJS(resp_segmanperfpaglist, {}, self);
                })
           
            
        }

        self.reiniciar = function () {
            self.segmanperf.xnombreperf("");

            self.buscar();
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
            postajaxjsonbasico("/Mantenimiento/ObtenerPerfilPorId/", "{'idsegmanperf':'" + obj.idsegmanperf() + "'}", function (segmanperf) {

                vmmanperfilesver1.cargar(segmanperf);
                vmmanperfilesmodificar1.cargar(segmanperf);
            })
        }

        self.ir_primero = function () {
            var npagactual = self.pag_segmanperf.npagactual();
            if (npagactual != 1) {
                self.pag_segmanperf.npagactual(1);
                self.buscar();
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pag_segmanperf.npagactual();
            if (npagactual != 1) {
                self.pag_segmanperf.npagactual(self.pag_segmanperf.npagactual() - 1);
                self.buscar();
            }
        }

        self.ir_siguiente = function () {
            if (self.pag_segmanperf.npagactual() != self.pag_segmanperf.npagcantidad()) {
                self.pag_segmanperf.npagactual(self.pag_segmanperf.npagactual() + 1);
                self.buscar();
            }
        }

        self.ir_ultimo = function () {
            if (self.pag_segmanperf.npagactual() != self.pag_segmanperf.npagcantidad()) {
                self.pag_segmanperf.npagactual(self.pag_segmanperf.npagcantidad);
                self.buscar();
            }
        }

    }

</script>
