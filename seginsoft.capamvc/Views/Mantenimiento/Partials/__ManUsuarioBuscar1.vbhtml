    <fieldset>
        <legend>PAR&Aacute;METROS DE B&Uacute;SQUEDA</legend>

        <div class="form-column">
            <div class="form-field-header">
                Departamento
            </div>
            <div class="form-field-content" data-bind="with: vi_segmanusu">
                <select data-bind="options: $root.combodepartamento, optionsText: 'xnombredep', optionsValue: 'idsegmandep', value: idsegmandep"></select>
            </div>
        </div>

        <div class="form-column-button-left">
                <input type="button" value="Buscar" data-bind="click: buscar" />
        </div>
        <div class="form-column-button-left">
            <input type="button" value="Limpiar" data-bind="click: reiniciar" />
        </div>
       
        
    </fieldset>

    <fieldset>
        <legend>Lista de usuarios</legend>
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
                
                <table class="grid-table" data-bind='visible: lista_vi_segmanusu().length > 0'>
                    <thead>
                        <tr class="grid-row-header">
                            <th></th>
                            <th></th>
                            <th></th>
                            <th>Id</th>
                            <th>Nombre</th>
                            <th>Correo</th>    
                        </tr>
                    </thead>
                    <tbody data-bind='foreach: lista_vi_segmanusu'>
                        <tr class="grid-row-content">
                            <td>                                
                                <input type="button" value="Ver" data-bind="click: $root.cargar_ver" />
                            </td>
                            <td>                                
                                <input type="button" value="Editar" data-bind="click: $root.cargar_editar" />
                            </td>

                            <td>                               
                                <input type="button" value="Perfil" data-bind="click: $root.perfil" />
                            </td>
                            <td>
                                <span data-bind='text: idsegmanusu'></span>
                            </td>
                            <td>
                                <span data-bind='text: xnombrecompleto'></span>
                            </td>
                            <td>
                               <span data-bind='text: xcorreoelectronico1'></span>
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
                                <div class="info-pagination-noclear" data-bind="with: pagvi_segmanusu">
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
                <div class="no-grid-rows" data-bind='visible: lista_vi_segmanusu().length == 0'>No existen Usuarios almacenados...</div>
            </div>

    </fieldset>

<script type="text/javascript">

    function vmmanusuariobuscar1(boton_ver, boton_agregar, boton_modificar) {
        var self = this;
        self.vi_segmanusu = new vi_segmanusu(true);

        self.pagvi_segmanusu = new paginacion(1, 10, 0, "it.idsegmanusu", "DESC");
        self.lista_vi_segmanusu = ko.observableArray();
        self.boton_ver = ko.observable(boton_ver);
        self.boton_agregar = ko.observable(boton_agregar);
        self.boton_modificar = ko.observable(boton_modificar);
        self.combodepartamento = ko.observableArray();

        self.cargar_ver = function (obj) {
            $("#tab-ver").removeClass("ui-state-disabled");
            postajaxjsonbasico("/Mantenimiento/ObtenerUsuarioPorId/", "{'idsegmanusu':'" + obj.idsegmanusu() + "'}", function (vi_segmanusu) {
                vmmanusuariover1.cargar(vi_segmanusu);
                $(".tab").tabs("option", "active", 1);
            })
        }

        self.cargar_editar = function (obj) {
            $("#tab-editar").removeClass("ui-state-disabled");
            postajaxjsonbasico("/Mantenimiento/ObtenerUsuarioPorId/", "{'idsegmanusu':'" + obj.idsegmanusu() + "'}", function (vi_segmanusu) {                
                vmmanusuariomodificar1.cargar(vi_segmanusu);
                $(".tab").tabs("option", "active", 3);
            })
        }



        self.llenarcombodepartamento = function () {          
            postajaxjsonbasico("/Mantenimiento/ObtenerComboDepartamentos/", "{}", function (lista_segmandep) {

                self.combodepartamento(lista_segmandep);
            })
        }
        
        self.buscar = function (tipo) {
            if (tipo != 'MOV') {
                self.pagvi_segmanusu.npagactual(1);
            }
            self.lista_vi_segmanusu("");
            postajaxjsonbasico("/Mantenimiento/ObtenerUsuarios/", ko.toJSON(self), function (respvi_segmanusupaglist) {
                
                ko.mapping.fromJS(respvi_segmanusupaglist, {}, self);
            })


            //postajaxjsonbasico("/Mantenimiento/ObtenerUsuarioXDep/", ko.toJSON(self), function (respvi_segmanusupaglist) {
            //    self.lista_vi_segmanusu("");
            //    ko.mapping.fromJS(respvi_segmanusupaglist, {}, self);
            //})
        }

        self.reiniciar = function () {
            self.vi_segmanusu.idsegmandep("");
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
            postajaxjsonbasico("/Mantenimiento/ObtenerUsuarioPorId/", "{'idsegmanusu':'" + obj.idsegmanusu() + "'}", function (vi_segmanusu)        {
           
                vmmanusuariover1.cargar(vi_segmanusu);
                vmmanusuariomodificar1.cargar(vi_segmanusu);
            })
        }

        self.perfil = function (obj) {
            postajaxjsonbasico("/Mantenimiento/ObtenerUsuarioPorId/", "{'idsegmanusu':'" + obj.idsegmanusu() + "'}", function (vi_segmanusu)        {
                vmmanusuarioconfigurarperf1.cargar(vi_segmanusu);

            })
        }

        self.ir_primero = function () {
            var npagactual = self.pagvi_segmanusu.npagactual();
            if (npagactual != 1) {
                self.pagvi_segmanusu.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_segmanusu.npagactual();
            if (npagactual != 1) {
                self.pagvi_segmanusu.npagactual(self.pagvi_segmanusu.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_segmanusu.npagactual() != self.pagvi_segmanusu.npagcantidad()) {
                self.pagvi_segmanusu.npagactual(self.pagvi_segmanusu.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_segmanusu.npagactual() != self.pagvi_segmanusu.npagcantidad()) {
                self.pagvi_segmanusu.npagactual(self.pagvi_segmanusu.npagcantidad);
                self.buscar('MOV');
            }
        }

    }
</script>
