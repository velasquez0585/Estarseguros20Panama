<fieldset style="width: 930px;">
    <legend>Par&aacute;metros de B&uacute;squeda</legend>


    <div data-bind="with: vi_aipinsenc">
        <div class="form-row">

            <div class="form-column">
                <div class="form-field-header">
                    <label>Id:</label>
                </div>
                <div class="form-field-content">
                    <input placeholder="Ej: 123" type="text" data-bind="enterovalue: idaipinsenc" />
                </div>
            </div>

            <div class="form-column">
                <div class="form-field-header">
                    <label>Sucursal:</label>
                </div>
                <div class="form-field-content">
                    <select data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: idsegmanorgperit, disable: $root.disabled_sucursal"></select>
                </div>
            </div>



            <div class="form-column">
                <div class="form-field-header">
                    <label>Perito:</label>
                </div>
                <div class="form-field-content">
                    <input placeholder="Ej: PEDRO PEREZ" type="text" data-bind="value: xnombrecompletoperit" />
                </div>
            </div>


        </div>

        <div class="form-row">

            <div class="form-column">
                <div class="form-field-header">
                    <label>Ced.Ident/R.U.C. Propietario:</label>
                </div>
                <div class="form-field-content">
                    <input placeholder="Ej: 15545789" type="text" data-bind="enterovalue: xcedpropinsenc" />
                </div>

            </div>


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

        </div>

        <div class="form-row">
            <div class="form-column">
                <div class="form-field-header">
                    <label>Serial Carroceria:</label>
                </div>
                <div class="form-field-content">
                    <input placeholder="Ej: 4546AKHJ498" type="text" data-bind="value: xsercarrinsenc" />
                </div>

            </div>

            @* <div class="form-column">
                <input type="button" value="Buscar" data-bind="click: buscar" />
                <input type="button" value="Limpiar" data-bind="click: limpiar" />
            </div>*@

        </div>

    </div>



    <div class="form-column-button-left">
        <input type="button" value="Buscar" data-bind="click: buscar" />
        <input type="button" value="Limpiar" data-bind="click: limpiar" />
    </div>
</fieldset>
<fieldset class="form-area">
    <legend>Lista de inspecciones por Auditar</legend>


    @*<input type="button" value="Aprobar Todos" data-bind="click: $root.aprobartodos, visible: lista_vi_aipinsenc().length > 0 " />*@
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
                    <tr class="grid-row-content" data-bind="attr: { class: check() == true ? 'bg-green-light' : '' }">
                        @*<td>
                            <input type="button" value="Aprobar" data-bind="click: $root.aprobar " />

                        </td>*@
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
                            <span data-bind='text: xplacinsenc' />
                        </td>

                        <td>
                            <span data-bind='text: xnumsininsenc' />
                        </td>
                        <td>
                            <span data-bind='datehtml: fcreainsenc' />
                        </td>
                        <td>
                            <span data-bind='text: xnombrecompletoperit' />
                        </td>
                        <td>
                            <select style="width: 180px;" data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: idsegmanorgperit, disable: true"></select>
                        </td>
                        <td>
                            <input type="button" value="Ir a Auditar" data-bind="click: $root.auditar " />

                        </td>
                        <td>
                            <input type="button" value="Ver Fotos" data-bind="click: $root.verfotos" />

                        </td>
                        <td>
                            <input type="button" value="Multimedia" data-bind="click: $root.verMultimedia" />
                        </td>
                        <td>
                            <input type="button" value="Subir Fotos" data-bind="click: $root.subirfotos" />

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
            <div class="no-grid-rows" data-bind='visible: lista_vi_aipinsenc().length == 0'>No existe inspecciones por auditar...</div>
        </div>
    </div>


    <div class="form-row">
        <div class="legenda" style="margin-top: 20px;">
            <div class="form-mini">
                <div class=" campo color bg-green-light" style="float: left;"></div>
                <div class="legendatext" style="width: 90%; float: left; font-size: 10pt;">Datos Modificados (Nro. Placa y/o Serial Carroceria)</div>
            </div>

        </div>
    </div>
</fieldset>

<script type="text/javascript">
    function vmInsPorAuditBuscar1() {
        var self = this;
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.pagvi_aipinsenc = new paginacion(1, 10, 0, "it.idaipinsenc", "DESC");
        self.lista_vi_aipinsenc = ko.observableArray();
        self.sel_idaipinsenc = ko.observable(0);

        self.cbosucursal = ko.observableArray();
        self.idsegmanorgperit = ko.observable(0);
        self.disabled_sucursal = ko.observable(true);
        self.auditor = ko.observable(false);

        

        self.encabezados_vi_aipinsenc = [
            //{ titulo: '', campo: '' },
            { titulo: 'Id', campo: 'it.idaipinsenc' },
            { titulo: 'Ced.Ident/R.U.C. Propietario', campo: 'it.xcedpropinsenc' },
            { titulo: 'Tipo', campo: 'it.itipoinsenc' },
            { titulo: 'Placa', campo: 'it.xplacinsenc' },
{ titulo: 'Siniestro o Cotización ', campo: 'it.xnumsininsenc' },
            { titulo: 'F/Creacion', campo: 'it.fcreainsenc' },
        { titulo: 'Perito', campo: 'it.xnombrecompleto' },
        { titulo: 'Sucursal', campo: 'it.idsegmanorgperit' },
        { titulo: '', campo: '' },
        { titulo: '', campo: '' },
        { titulo: '', campo: '' },
        { titulo: '', campo: '' }
        ];

        self.llenarcbosucursal = function (idsegmanorgperit) {
            postajaxjsonbasico("/comun/ObtenerComboOrganizacion/", '{}', function (lista_vi_combosegmanorg) {

                self.cbosucursal(lista_vi_combosegmanorg);
                self.vi_aipinsenc.idsegmanorgperit(idsegmanorgperit);
                self.buscar();
            });
        }
        self.buscar = function () {


            postajaxjsonbasico("/Inspeccion/ObtenerInspeccionesPorAuditar/", ko.toJSON(self), function (lista_vi_aipinsenc) {
                ko.mapping.fromJS(lista_vi_aipinsenc, {}, self);
            })
        }

        self.llenarcombotipo = function () {
            var xconcepto = "ITIPOINSENC";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.vi_aipinsenc.combotipoinsenc(lista_comunconfvalor);

            })
        }

        self.subirfotos = function (obj) {
            vmInsSubirFotoModal1.iniciar(obj);
            $("#dlg_InsSubirFotoModal1").dialog("open");
        }

        self.verMultimedia = function (obj) {

            //vmInsMultimediaModal1.iniciar(obj, obj.itipoinsenc);
            vmInsMultimediaModal1.cargarMultimedia(obj);
            $("#dlg_InsMultimModal1").dialog("open");

        }

        self.limpiar = function () {
            self.vi_aipinsenc.idaipinsenc(0);
            self.vi_aipinsenc.xcedsidoinsenc("");
            self.vi_aipinsenc.xcedpropinsenc("");
            self.vi_aipinsenc.itipoinsenc("");
            self.vi_aipinsenc.xnombrecompletoperit("");

            if (self.auditor() == false) self.vi_aipinsenc.idsegmanorgperit(0);
            self.vi_aipinsenc.fcreainsenc("");
            self.vi_aipinsenc.xnombrecompleto("");
            self.vi_aipinsenc.xsermotinsenc("");
            self.vi_aipinsenc.xsercarrinsenc("");
        }
        self.iniciar = function () {
            //self.buscar();
            self.llenarcbosucursal();
            self.llenarcombotipo();
            self.verificarUsuario();

        }
        self.aprobartodos = function () {
            //metodo para aprobar todas las inspecciones por el auditor que esta en sesion
            postajaxjsonbasico("/Inspeccion/AprobarTodasInspeccionesPorAuditar/", "{}", function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.buscar();
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }

        self.aprobar = function (obj) {
            postajaxjsonbasico("/Inspeccion/ModificarInspeccionEstatusYTipoAccion/?idaipinsenc=" + obj.idaipinsenc() + "&iestatinsenc=PROCEDENTE&itipoaccion=ACEPTAR", "", function (respopera) {

                if (respopera != null) {
                    if (respopera.irespuesta == 1) {
                        generar_noty_auto(respopera.xmsjusuario, "success");
                        self.buscar();
                    } else {
                        generar_noty(respopera.xmsjusuario, "error");
                    }
                }
            });

            //postajaxjsonbasico("/Inspeccion/AprobarInspeccionPorAuditar/", "{'idaipinsenc': '" + obj.idaipinsenc() + "'}", function (respopera) {
            //    if (respopera.irespuesta == 1) {
            //        generar_noty_auto(respopera.xmsjusuario, "success");
            //        self.buscar();
            //    } else {
            //        generar_noty(respopera.xmsjusuario, "error");
            //    }
            //})
        }
        self.auditar = function (obj) {
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
                    vmInsSinGuardar1.iniciar(obj, true);
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


        self.verificarUsuario = function () {
            postajaxjsonbasico("/Seguridad/ObtenerUsuarioEnSession/", "", function (vi_segusudetperf2) {
                if (vi_segusudetperf2 != null) {

                    //si es Administrador
                    if (vi_segusudetperf2.idsegmanperf == 1) {
                        self.llenarcbosucursal(0);
                        self.disabled_sucursal(false);
                        self.auditor(false);

                    }//auditor lider principal
                    else if (vi_segusudetperf2.idsegmanperf == 2) {

                        self.llenarcbosucursal(0);
                        self.disabled_sucursal(false);
                        self.auditor(false);

                    }//si es Auditor Lider Sucursal                        
                    else if (vi_segusudetperf2.idsegmanperf == 3) {

                        self.llenarcbosucursal(vi_segusudetperf2.idsegmanorg);
                        self.disabled_sucursal(true);
                        self.auditor(false);

                    }//Perito Lider Sucursal
                    else if (vi_segusudetperf2.idsegmanperf == 4) {
                        self.llenarcbosucursal(vi_segusudetperf2.idsegmanorg);
                        self.disabled_sucursal(true);
                        self.auditor(true);
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

    vmInsPorAuditBuscar1.prototype.toJSON = function () {
        var copia = ko.toJS(this);        
        delete copia.lista_vi_aipinsenc;
        delete copia.cbosucursal;
        delete copia.encabezados_vi_aipinsenc;
        return copia;
    }
</script>
