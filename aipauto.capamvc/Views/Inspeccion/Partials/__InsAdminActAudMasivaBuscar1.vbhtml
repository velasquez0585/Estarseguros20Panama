<fieldset class="form-area" data-bind="with: vi_aipinsenc">
    <legend>Buscar</legend>

    @*recordemos que cada vez que agreguemos parametros de busqueda nuevos debemos coordinar con el especialista de la web api
    para que configure el parametro nuevo, sino tendremos error en el query con los OrderBy y Skip*@

    <div class="form-column">
        <div class="form-field-header">
            <label>Sucursal</label>
            <div class="form-field-content">                
                <select data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: $root.idsegmanorgperit, disable: $root.disabled_sucursal, event: { change: $root.evento_sucursal }"></select>
            </div>
        </div>
    </div>

    <div class="form-column">
        <div class="form-field-header">
            <label>Auditor:</label>
            <div class="form-field-content">                
                <select data-bind="options: $root.cbousuarios, optionsText: 'xnombrecompleto', optionsValue: 'idsegmanusu', value: idsegmanusuaudit"></select>
            </div>
        </div>
    </div>

    <div class="form-column">
        <div class="form-column-button-left">
            <input type="button" value="Buscar" data-bind="click: $root.buscar" />
        </div>
        @*<div class="form-column-button">
            <input type="button" value="Limpiar" data-bind="click: $root.limpiar" />
        </div>*@
    </div>
</fieldset>

<fieldset class="form-area">
    <legend>Lista de Inspecciones</legend>

    <div class="row">

        <div class=""  data-bind="visible: lista_vi_aipinsenc().length > 0" >

            <div class="form-field-header">
                <label>Nuevo Auditor:</label>
                <div class="form-field-content">                
                    <select data-bind="options: $root.cbousuarios, optionsText: 'xnombrecompleto', optionsValue: 'idsegmanusu', value: $root.idsegmanusuaudit"></select>
                    <input type="button" value="Actualizar" data-bind="click: $root.actualizar, visible: lista_vi_aipinsenc().length > 0" />
                </div>
            </div>
        </div>
        
        <input type="button" value="Actualizar Todo" data-bind="click: $root.actualizarTodo, visible: lista_vi_aipinsenc().length > 0" />

    </div>

    <div class="row">

    <div class="info-pagination" data-bind="with: pagvi_aipinsenc, visible: lista_vi_aipinsenc().length > 0">
        <span>P&aacute;gina </span>
        <span data-bind='text: npagactual'></span>
        <span>de </span>
        <span data-bind='text: npagcantidad'></span>
    </div>
    </div>
    <div class="grid-area">
        <table class="grid-table" data-bind='visible: lista_vi_aipinsenc().length > 0'>
            <thead>
                <tr class="grid-row-header">
                    <th></th>
                    <th>Id</th>
                    <th>Ced.Ident/R.U.C. Propietario</th>
                    <th>Tipo inspección</th>
                    <th>Fecha de creación</th>

                    
                    <th data-bind="visible: $root.itipoaccion() == 'PERITO'">Perito</th>
                    
                    <th  data-bind="visible: $root.itipoaccion() == 'AUDITOR'">Auditor</th>
                    
                    <th>Tipo Peritaje</th>  
                    <th>Origen</th>  
                    <th>Sucursal</th>  
                                        
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_vi_aipinsenc'>
                <tr class="grid-row-content">
                    <td>
                        <input type="checkbox" data-bind="checked: check" />
                       @*<input type="button" value="Seleccionar" data-bind="click: $root.seleccionar " />*@
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
                    
                    <td  data-bind="visible: $root.itipoaccion() == 'PERITO'">
                        <span data-bind='text: xnombrecompletoperit' />
                    </td>
                    
                    <td  data-bind="visible: $root.itipoaccion() == 'AUDITOR'">
                        <span data-bind='text: xnombrecompletoaudit' />
                    </td>
                    <td>
                        <span data-bind='text: itipoperitinsenc' />
                    </td>
                    <td>
                        <span data-bind='text: iorigeninsenc' />
                    </td>
                    <td>
                        <span data-bind='text: xnombrecomercialperit' />
                        
                        @*<select data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: idsegmanorgperit" disabled></select>*@
                    </td>                 
                </tr>
            </tbody>

           @* <tfoot>
                <tr class="grid-row-footer">
                    <td colspan="6">
                        <div class="grid-bottom-buttons">
                            <div class="grid-bottom-button">
                                <input type="button" class="button small info" value="Primero" data-bind="click: ir_primero" />
                            </div>
                            <div class="grid-bottom-button">
                                <input type="button" class="button small info" value="Anterior" data-bind="click: ir_anterior" />
                            </div>
                            <div class="grid-bottom-button">
                                <input type="button" class="button small info" value="Siguiente" data-bind="click: ir_siguiente" />
                            </div>
                            <div class="grid-bottom-button">
                                <input type="button" class="button small info" value="Ultimo" data-bind="click: ir_ultimo" />
                            </div>
                        </div>
                    </td>
                </tr>
            </tfoot>*@
        </table>
        <div class="no-grid-rows" data-bind='visible: lista_vi_aipinsenc().length == 0'>No existen registros para esta consulta</div>
    </div>
</fieldset>

<script type="text/javascript">
    function vminsadminactaudmasivabuscar1() {
        var self = this;
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.pagvi_aipinsenc = new paginacion(1, 200, 0, "it.idaipinsenc", "DESC");
        self.lista_vi_aipinsenc = ko.observableArray();

        self.cboitipoaccion = ko.observableArray();
        self.cbosucursal = ko.observableArray();
        self.cbousuarios = ko.observableArray();
        self.cbousuariosmod = ko.observableArray();

        self.itipoaccion = ko.observable("AUDITOR");
        self.disabled_accion = ko.observable(true);
        self.disabled_sucursal = ko.observable(true);
        
        self.idsegmanusu = ko.observable(0);
        self.idsegmanusuaudit = ko.observable(0);
        self.idsegmanorgperit = ko.observable(0);
        self.valido = ko.observable(false);
        self.cargar = function () {
            //self.buscar();
            self.verificarUsuario();
            //self.llenarcboitipoaccion();
            self.llenarcbosucursal();
            self.llenarcbousuarios();
            self.itipoaccion("AUDITOR");
            
        }

        self.verificarUsuario = function () {
            postajaxjsonbasico("/Seguridad/ObtenerUsuarioEnSession/", "", function (vi_segusudetperf2) {
                if (vi_segusudetperf2 != null)
                {
                    self.idsegmanusu(vi_segusudetperf2.idsegmanusu);
                    //self.idsegmanorgperit(vi_segusudetperf2.idsegmanorg);

                    //si es Administrador
                    if (vi_segusudetperf2.idsegmanperf == 1)
                    {
                        //self.llenarcboitipoaccion("");
                        self.llenarcbosucursal(0);
                        self.disabled_accion(false);
                        self.disabled_sucursal(false);
                        self.valido(false);
                    }//auditor lider principal
                    else if (vi_segusudetperf2.idsegmanperf == 2)
                    {
                        //self.llenarcboitipoaccion("");
                        self.llenarcbosucursal(0);
                        self.disabled_accion(false);
                        self.disabled_sucursal(false);
                        self.valido(true);

                    }//si es Auditor Lider Sucursal                        
                    else if (vi_segusudetperf2.idsegmanperf == 3)
                    {
                        //self.llenarcboitipoaccion("");
                        self.llenarcbosucursal(vi_segusudetperf2.idsegmanorg);
                        self.disabled_accion(false);
                        self.disabled_sucursal(true);
                        self.valido(true);

                    }//Perito Lider Sucursal
                    else if (vi_segusudetperf2.idsegmanperf == 7) {
                        //self.llenarcboitipoaccion("PERITO");
                        self.llenarcbosucursal(vi_segusudetperf2.idsegmanorg);
                        self.valido(false);
                        //self.disabled_accion(true);
                        //self.disabled_sucursal(true);
                        //self.buscar();
                        generar_noty_modal("Disculpe, usted no puede realizar esta acción.", "warning")
                        return false;
                    } else {
                        self.valido(false);
                        self.disabled_accion(true);
                        self.disabled_sucursal(true);
                        generar_noty_modal("Disculpe, usted no puede realizar esta acción.", "warning")
                        return false;

                    }
                    
                    
                }
                else
                {
                    self.disabled_accion(true);
                    self.disabled_sucursal(true);
                    generar_noty_modal("Disculpe no hemos podido verificar el tipo de usuario", "warning")
                }
            });
        }



        self.buscar = function (tipo) {


            if (self.valido()) {
                
                //esto siempre lo evaluamos para cualquier busqueda con paginacion para poder distinguir si dicha busqueda la 
                //hacemos por movimiento de registros o por hacer click en buscar.
                //Si no es por movimiento de registros entonces volvemos a la pagina uno
                if (tipo != 'MOV') {
                    self.pagvi_aipinsenc.npagactual(1);
                }

                //if (self.itipoaccion() == "") {
                //    generar_noty_modal("Debe seleccionar el 'Tipo de Acción'", "warning");
                //    return false;
                //}

                if (self.idsegmanorgperit() == 0) {
                    generar_noty_modal("Debe seleccionar la 'Sucursal'", "warning");
                    return false;
                }

                if (self.vi_aipinsenc.idsegmanusuaudit() == 0) {
                    generar_noty_modal("Debe seleccionar el 'Auditor'", "warning");
                    return false;
                }


                self.lista_vi_aipinsenc("");
                postajaxjsonbasico("/Inspeccion/ObtenerInspeccionesPorTipo/?itipoaccion=AUDITOR", ko.toJSON(self), function (respvi_aipinsencpaglist) {
                    ko.mapping.fromJS(respvi_aipinsencpaglist, {}, self);
                });
            } else {
                generar_noty_modal("Disculpe, usted no tiene acceso para realizar esta acción.", "warning");
                return false;
            }
        }

        self.limpiar = function () {
            self.idsegmanorgperit(0);
            //self.itipoaccion("");            
        }

        //self.llenarcboitipoaccion = function (itipoaccion) {
        //    var accion = [
        //        { 'xvalorcodigo': '', 'xvalordescripcion': 'SELECCIONE...' },
        //        { 'xvalorcodigo': 'AUDITOR', 'xvalordescripcion': 'AUDITOR' },
        //        { 'xvalorcodigo': 'PERITO', 'xvalordescripcion': 'PERITO' }
        //    ];

        //    self.cboitipoaccion(accion);
        //    self.itipoaccion(itipoaccion);
            
        //}

        self.llenarcbosucursal = function (idsegmanorg) {
            postajaxjsonbasico("/comun/ObtenerComboOrganizacion/", '{}', function (lista_vi_combosegmanorg) {
                self.cbosucursal(lista_vi_combosegmanorg);
                
                self.idsegmanorgperit(idsegmanorg);
            });
        }

        self.llenarcbousuarios = function () {
            var lista = [
                { 'idsegmanusu': '0', 'xnombrecompleto': 'SELECCIONE...' }                
            ];
            
            if (self.idsegmanorgperit() > 0)
            {
                postajaxjsonbasico("/Seguridad/ObtenerComboUsuariosPorAccionYSuc/?idsegmanorg= " + self.idsegmanorgperit() + "&itipoaccion=AUDITOR", '{}', function (lista_vi_segusudetperf2) {
                    self.cbousuarios(lista_vi_segusudetperf2);
                });
            }
            else {                
                self.cbousuarios(lista);                
            }           
        }
                                
        self.seleccionar = function (obj) {
            
            postajaxjsonbasico("/Inspeccion/ObtenerInspeccionPorId/?idaipinsenc=" + obj.idaipinsenc(), "", function (vi_aipinsenc) {
                if (vi_aipinsenc != null) {
                    
                    if (self.itipoaccion() == "AUDITOR") {
                        vminsmodificarauditormodal1.cargar(vi_aipinsenc);
                        //$('#dlg_insmodificarauditormodal1').dialog({
                        //    width: "55%"
                        //});
                        $("#dlg_insmodificarauditormodal1").dialog("open");
                    }
                    else if (self.itipoaccion() == "PERITO") {                        
                        vminsmodificarperitomodal1.cargar(vi_aipinsenc);
                        //$('#dlg_insmodificarperitomodal1').dialog({
                        //    width: "55%"
                        //});
                        $("#dlg_insmodificarperitomodal1").dialog("open");
                    }
                }
                else
                    generar_noty_auto("Disculpe, ha ocurrido un error al intentar consultar esta inspección", "warning")

            })
        }

        self.actualizar = function () {

            if (self.idsegmanusuaudit() == self.vi_aipinsenc.idsegmanusuaudit()) {
                generar_noty_modal("Debe seleccionar un Auditor distinto para la actualización.", "warning")
                return false;
            }

            if (self.idsegmanusuaudit() == 0) {
                generar_noty_modal("Debe seleccionar el Auditor de Destino para la actualización.", "warning")
                return false;
            }

            postajaxjsonbasico("/Inspeccion/ModificarAuditorMasivo/?idsegmanusuaudit=" + self.idsegmanusuaudit(), ko.toJSON(self.lista_vi_aipinsenc()), function (respopera) {
                
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.buscar();
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }

            });
        }

        self.actualizarTodo = function () {
            if (self.lista_vi_aipinsenc().length > 0) {
                //for (i = 0; i < self.lista_vi_aipinsenc().length; i++)
                //{
                //    self.lista_vi_aipinsenc()[i].check(true);
                //}

                if (self.idsegmanusuaudit() == self.vi_aipinsenc.idsegmanusuaudit()) {
                    generar_noty_modal("Debe seleccionar un Auditor distinto para la actualización.", "warning")
                    return false;
                }

                if (self.idsegmanusuaudit() == 0) {
                    generar_noty_modal("Debe seleccionar el Auditor de Destino para la actualización.", "warning")
                    return false;
                }

                var botones = [
                {
                    addClass: 'btn btn-primary', text: 'Si', onClick: function ($noty) {
                        $noty.close();
                        
                        postajaxjsonbasico("/Inspeccion/ModificarAuditorInspeccionTodo/?idsegmanusuaudit=" + self.idsegmanusuaudit(), ko.toJSON(self.lista_vi_aipinsenc()), function (respopera) {

                            if (respopera.irespuesta == 1) {
                                generar_noty_auto(respopera.xmsjusuario, "success");
                                self.buscar();
                            } else {
                                generar_noty(respopera.xmsjusuario, "error");
                            }

                        });

                    }
                },
                {
                    addClass: 'btn btn-danger', text: 'No', onClick: function ($noty) {
                        $noty.close();
                    }
                }
                ];
                generar_noty_confirmacion("¿Está seguro que desea actualizar todas las inspecciones al nuevo auditor?", botones);
            } else {

            }
        }


       
        this.evento_itipoaccion = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                self.lista_vi_aipinsenc("");
                self.pagvi_aipinsenc.npagactual(1);
                self.llenarcbousuarios();
            } else {
                //si el programa desencadeno el evento

            }
        }

        this.evento_sucursal = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                self.lista_vi_aipinsenc("");
                self.pagvi_aipinsenc.npagactual(1);
                self.llenarcbousuarios();
            } else {
                //si el programa desencadeno el evento

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
    }

    //recordemos siempre excluir del viewmodel aquellos objetos que no deseamos enviar serializados con la funcion ko.toJSON()
    //con la finalidad de que la peticion no sea tan pesada y no estemos ocupando el ancho de banda innecesariamente
    vminsadminactaudmasivabuscar1.prototype.toJSON = function () {
        var copia = ko.toJS(this);
        //delete copia.lista_vi_aipinsenc;        
        return copia;
    }
</script>
