<fieldset class="form-area" data-bind="with: vi_segusudetperf2">
    <legend>Buscar</legend>

    @*recordemos que cada vez que agreguemos parametros de busqueda nuevos debemos coordinar con el especialista de la web api
    para que configure el parametro nuevo, sino tendremos error en el query con los OrderBy y Skip*@
    <div class="form-column">
        <div class="form-field-header">
            <label>Tipo de Usuario:</label>
            <div class="form-field-content">
                <select data-bind="options: $root.cboitipoaccion, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: $root.itipoaccion, disable: $root.disabled_accion"></select>
            </div>
        </div>
    </div>
    <div class="form-column">
        <div class="form-field-header">
            <label>Sucursal</label>
            <div class="form-field-content">
                <select data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: idsegmanorg, disable: $root.disabled_sucursal"></select>
            </div>
        </div>
    </div>

    <div class="form-column">
        <div class="form-field-header">
            <label>Acción:</label>
            <div class="form-field-content">
                <select data-bind="options: $root.cboestatus, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: $root.itipoestatus"></select>

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
    <legend>Lista de Usuarios</legend>

    <div class="form-row" data-bind="visible: lista_vi_segusudetperf2().length > 0">

        <div style="float: left; margin-right: 2%;">
            <input type="button" value="Actualizar" data-bind="click: $root.actualizar" />
        </div>

        <div data-bind="visible: $root.itipoestatus() =='SUSPENDER'">
            <div style="float: left; margin-right: 3%;">
                <div class="form-field-header">
                    Inicia:
                </div>
                <div class="form-field-content">
                    <input style="width: 141px" placeholder="Ej: 17/11/1983" class="date-field" data-bind="datevalue: $root.finisusmanusuconf" />
                    <select id="comboHoraSalida" style="width: 60px" data-bind="options: $root.combohoras, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: $root.hora"></select>
                    <span>:</span>
                    <select id="comboMinutosSalida" style="width: 60px" data-bind="options: $root.combominutos, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: $root.minutos"></select>
                </div>
            </div>
            <div style="float: left; margin-right: 3%;">
                <div class="form-field-header">
                    Finaliza:
                </div>
                <div class="form-field-content">
                    <input style="width: 141px" placeholder="Ej: 17/11/1983" class="date-field" data-bind="datevalue: $root.ffinsusmanusuconf" />
                    <select id="comboHoraRegreso" style="width: 60px" data-bind="options: $root.combohoras, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: $root.horaFin"></select>
                    <span>:</span>
                    <select id="comboMinutosRegreso" style="width: 60px" data-bind="options: $root.combominutos, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: $root.minutosFin"></select>
                </div>
            </div>
        </div>
    </div>

    @* <div class="info-pagination" data-bind="with: pagvi_segusudetperf2">
        <span>P&aacute;gina </span>
        <span data-bind='text: npagactual'></span>
        <span>de </span>
        <span data-bind='text: npagcantidad'></span>
    </div>*@
    <div class="grid-area">
        <table class="grid-table" data-bind='visible: lista_vi_segusudetperf2().length > 0'>
            <thead>
                <tr class="grid-row-header">
                    <th></th>
                    <th>Nombre</th>
                    <th>Perfil</th>
                    <th>Sucursal</th>
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_vi_segusudetperf2'>
                <tr class="grid-row-content">
                    <td>
                        <input type="checkbox" data-bind="checked: check" />
                    </td>
                    <td>
                        <span data-bind='text: xnombrecompleto' />
                    </td>
                    <td>
                        <span data-bind='text: xnombreperf' />
                    </td>
                    <td>
                        <select data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: idsegmanorg" disabled></select>
                    </td>
                </tr>
            </tbody>

            @*<tfoot>
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
        <div class="no-grid-rows" data-bind='visible: lista_vi_segusudetperf2().length == 0'>No existen usuarios inactivos para esta consulta</div>
    </div>
</fieldset>

<script type="text/javascript">
    function vmmanactivarusubuscar1() {
        var self = this;
        self.vi_segusudetperf2 = new vi_segusudetperf2(false);
        self.pagvi_segusudetperf2 = new paginacion(1, 1000, 0, "it.idsegmanusu", "DESC");
        self.lista_vi_segusudetperf2 = ko.observableArray();

        self.cboitipoaccion = ko.observableArray();
        self.cbosucursal = ko.observableArray();
        self.cboestatus = ko.observableArray();

        self.itipoaccion = ko.observable("");
        self.disabled_accion = ko.observable(true);
        self.disabled_sucursal = ko.observable(true);

        self.idsegmanusu = ko.observable(0);
        self.idsegmanorg = ko.observable(0);
        self.itipoestatus = ko.observable("");

        self.combohoras = ko.observableArray();
        self.combominutos = ko.observableArray();
        self.hora = ko.observable();
        self.minutos = ko.observable();        
        self.horaFin = ko.observable();
        self.minutosFin = ko.observable();
        self.finisusmanusuconf = ko.observable("");
        self.ffinsusmanusuconf = ko.observable("");
        self.fechainicio = ko.observable("");
        self.fechafin = ko.observable("");


        self.cargar = function () {
            //self.buscar();
            self.verificarUsuario();
            self.llenarcboitipoaccion();
            self.llenarcbosucursal();
            self.llenarcboestatus();


            var date = new Date(self.finisusmanusuconf());
            var dia = date.getDate();
            var mes = parseInt(date.getMonth()) + 1;
            var anio = date.getFullYear();
            //self.finisusmanusuconf(dia + "/" + mes + "/" + anio);
            var hora = date.getHours();
            var minutos = date.getMinutes();
            if (minutos < 10)
                minutos = "0" + minutos;
            self.llenarcombohoras(hora, horaFin);
            var dateFin = new Date(self.ffinsusmanusuconf());
            var diaRegreso = dateFin.getDate();
            var mesRegreso = parseInt(dateFin.getMonth()) + 1;
            var anioRegreso = dateFin.getFullYear();
            //self.ffinsusmanusuconf(diaRegreso + "/" + mesRegreso + "/" + anioRegreso);
            var horaFin = dateFin.getHours();
            var minutosFin = dateFin.getMinutes();
            if (minutosFin < 10)
                minutosFin = "0" + minutosFin;
            self.llenarcombominutos(minutos, minutosFin);

        }

        self.limpiarHoras = function () {
            self.hora(0);
            self.minutos(0);
            self.horaFin(0);
            self.minutosFin(0);
            self.finisusmanusuconf("");
            self.ffinsusmanusuconf("");
        }

        self.verificarUsuario = function () {
            postajaxjsonbasico("/Seguridad/ObtenerUsuarioEnSession/", "", function (vi_segusudetperf2) {
                if (vi_segusudetperf2 != null) {
                    self.idsegmanusu(vi_segusudetperf2.idsegmanusu);
                    self.idsegmanorg(vi_segusudetperf2.idsegmanorg);

                    //si es Administrador
                    if (vi_segusudetperf2.idsegmanperf == 1) {
                        self.llenarcboitipoaccion("");
                        self.llenarcbosucursal(0);
                        self.disabled_accion(false);
                        self.disabled_sucursal(false);
                    }
                    else if (vi_segusudetperf2.idsegmanperf == 2) {
                        self.llenarcboitipoaccion("");
                        self.llenarcbosucursal(0);
                        self.disabled_accion(false);
                        self.disabled_sucursal(false);
                    }//si es Auditor Lider Sucursal                        
                    else if (vi_segusudetperf2.idsegmanperf == 3) {
                        self.llenarcboitipoaccion("");
                        self.llenarcbosucursal(vi_segusudetperf2.idsegmanorg);
                        self.disabled_accion(false);
                        self.disabled_sucursal(true);
                    }//Perito Lider Sucursal
                    else if (vi_segusudetperf2.idsegmanperf == 7) {
                        self.llenarcboitipoaccion("PERITO");
                        self.llenarcbosucursal(vi_segusudetperf2.idsegmanorg);
                        self.disabled_accion(true);
                        self.disabled_sucursal(true);
                        self.buscar();
                    }


                }
                else {
                    self.disabled_accion(true);
                    self.disabled_sucursal(true);
                    generar_noty_modal("Disculpe no hemos podido verificar el tipo de usuario", "warning")
                }
            });
        }

        self.llenarcombohoras = function (hora, horaF) {
            var xconcepto = "HORA";
            postajaxjsonbasico("/Agenda/ObtenerComboComunconfvalor/", "{'xconcepto': '" + xconcepto + "'}", function (lista_combocomunconfvalor) {
                self.combohoras(lista_combocomunconfvalor);
                self.hora(hora);
                self.horaFin(horaF);
            });
        }

        self.llenarcombominutos = function (minutos, minutosF) {
            var xconcepto = "MINUTOS";
            postajaxjsonbasico("/Agenda/ObtenerComboComunconfvalor/", "{'xconcepto': '" + xconcepto + "'}", function (lista_combocomunconfvalor) {
                self.combominutos(lista_combocomunconfvalor);
                self.minutos(minutos);
                self.minutosFin(minutosF);
            });
        }


        self.buscar = function (tipo) {
            //esto siempre lo evaluamos para cualquier busqueda con paginacion para poder distinguir si dicha busqueda la 
            //hacemos por movimiento de registros o por hacer click en buscar.
            //Si no es por movimiento de registros entonces volvemos a la pagina uno
            if (tipo != 'MOV') {
                self.pagvi_segusudetperf2.npagactual(1);
            }

            if (self.itipoaccion() == "") {
                generar_noty_modal("Debe seleccionar el 'Tipo de Usuario' a activar", "warning");
                return false;
            }

            if (self.itipoestatus() == "") {
                generar_noty_modal("Debe seleccionar el 'Tipo de acción' a realizar", "warning");
                return false;
            }
            if (self.itipoestatus() == "ACTIVAR") {
                self.vi_segusudetperf2.ibloqueado(true);
            }
            else {
                self.vi_segusudetperf2.ibloqueado(false);
            }

            self.lista_vi_segusudetperf2("");
            postajaxjsonbasico("/Seguridad/ObtenerUsuariosPorTipoMenosBloq/?itipoaccion=" + self.itipoaccion(), ko.toJSON(self), function (respvi_segusudetperf2paglist) {
                ko.mapping.fromJS(respvi_segusudetperf2paglist, {}, self);
            });
        }

        self.limpiar = function () {
            self.vi_segusudetperf2.idsegmanorg(0);
            self.itipoaccion("");
        }


        self.llenarcboestatus = function () {
            var accion = [
                { 'xvalorcodigo': '', 'xvalordescripcion': 'SELECCIONE...' },
                { 'xvalorcodigo': 'ACTIVAR', 'xvalordescripcion': 'ACTIVAR' },
                { 'xvalorcodigo': 'INACTIVAR', 'xvalordescripcion': 'INACTIVAR' },
                { 'xvalorcodigo': 'SUSPENDER', 'xvalordescripcion': 'SUSPENDER' }
            ];

            self.cboestatus(accion);


        }

        self.llenarcboitipoaccion = function (itipoaccion) {
            var accion = [
                { 'xvalorcodigo': '', 'xvalordescripcion': 'SELECCIONE...' },
                { 'xvalorcodigo': 'AUDITOR', 'xvalordescripcion': 'AUDITOR' },
                { 'xvalorcodigo': 'PERITO', 'xvalordescripcion': 'PERITO' }
            ];

            self.cboitipoaccion(accion);
            self.itipoaccion(itipoaccion);

        }

        self.llenarcbosucursal = function (idsegmanorg) {
            postajaxjsonbasico("/comun/ObtenerComboOrganizacion/", '{}', function (lista_vi_combosegmanorg) {
                self.cbosucursal(lista_vi_combosegmanorg);
                self.vi_segusudetperf2.idsegmanorg(idsegmanorg);
            });
        }

        self.FechaEnvio = function () {
            self.fullFecha = ko.computed(function () {
                return self.finisusmanusuconf() + " " + self.hora() + ":" + self.minutos() + ":00";
            }, this);
            self.fullFechaFin = ko.computed(function () {
                return self.ffinsusmanusuconf() + " " + self.horaFin() + ":" + self.minutosFin() + ":00";
            }, this);
            if (Dates.compare(self.fullFechaFin(), self.fullFecha()) == -1 || Dates.compare(self.fullFechaFin(), self.fullFecha()) == 0) {
                var lengthFin = self.fullFechaFin().length;
                var lengthInicio = self.fullFecha().length;
                if (lengthFin == 19) {
                    var monthFin = self.fullFechaFin().substring(3, 5);
                    var yearFin = self.fullFechaFin().substring(6, 10);
                }
                else {
                    var monthFin = self.fullFechaFin().substring(2, 3);
                    var yearFin = self.fullFechaFin().substring(4, 8);
                }
                if (lengthInicio == 19) {
                    var monthInicio = self.fullFecha().substring(3, 5);
                    var yearInicio = self.fullFecha().substring(6, 10);
                }
                else {
                    var monthInicio = self.fullFecha().substring(2, 3);
                    var yearInicio = self.fullFecha().substring(4, 8);
                }

                //alert("monthFin: " + monthFin + " monthInicio: " + monthInicio + " yearInicio: " + yearInicio + " yearFin: " + yearFin);
                //if ((monthFin > monthInicio) || ((monthFin < monthInicio) && (yearFin > yearInicio))) {

                //}
                //else {
                //    generar_noty_auto("La hora en que finaliza debe ser mayor a la hora en que inicia", "warning");
                //    //aqui no le pongo la fecha de inicio y fin porque todavia no le agrego lA HORA
                //    return false;
                //}
                // si es 0 es porque ambas finisusmanusuconfs finisusmanusuconfs son iguales
                //si es 1 es porque la finisusmanusuconf fin es menor a la finisusmanusuconf inicio
            }

            //estas fechas son para mantener las fechas de inicio y fin de la pantalla sin las horas
            self.fechainicio(self.finisusmanusuconf());
            self.fechafin(self.ffinsusmanusuconf());

            self.finisusmanusuconf(self.fullFecha());
            self.ffinsusmanusuconf(self.fullFechaFin());
            //if (self.finisusmanusuconf() > self.ffinsusmanusuconf()) {
            //    generar_noty_auto("La hora en que finaliza debe ser mayor a la hora en que inicia", "warning");
            //    //para ponerle al objeto la fecha de inicio y fin sin horas
            //    self.finisusmanusuconf(self.fechainicio());
            //    self.ffinsusmanusuconf(self.fechafin());
            //    return false;
            //}

        }

        self.actualizar = function () {
            //alert(self.itipoestatus());
            //self.fechainicio("");
            //self.fechafin("");

            if (self.itipoestatus() != "") {

                //proceso para tener las fechas de inicioi y fin
                if (self.itipoestatus() == 'SUSPENDER') {
                    self.FechaEnvio()
                    if (self.finisusmanusuconf() > self.ffinsusmanusuconf()) {
                        generar_noty_auto("La hora en que finaliza debe ser mayor a la hora en que inicia", "warning");
                        //para ponerle al objeto la fecha de inicio y fin sin horas
                        self.finisusmanusuconf(self.fechainicio());
                        self.ffinsusmanusuconf(self.fechafin());                        
                        return false;                        
                    }
                }
                else
                {
                    //alert("prueba");
                    self.finisusmanusuconf("01-01-1900");
                    self.ffinsusmanusuconf("01-01-1900");
                }
                

                //en este caso, aqui es donde activaremos el tab "editar"
                postajaxjsonbasico("/Seguridad/ModificarUsuariosLista2/?itipoaccion=" + self.itipoestatus() + "&xfinisusmanusuconf=" + self.finisusmanusuconf() + "&xffinsusmanusuconf=" + self.ffinsusmanusuconf(), ko.toJSON(self.lista_vi_segusudetperf2), function (resopera) {
                    if (resopera.irespuesta == "1") {
                        generar_noty_modal(resopera.xmsjusuario, "success")
                        self.limpiarHoras();
                        self.buscar()
                    }
                    else {
                        generar_noty_modal(resopera.xmsjusuario, "error")
                    }
                })



            }
            else {
                generar_noty_modal("Debe seleccionar el 'Tipo de acción'", "warning");
                return false;
            }
        }

        self.ir_primero = function () {
            var npagactual = self.pagvi_segusudetperf2.npagactual();
            if (npagactual != 1) {
                self.pagvi_segusudetperf2.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_segusudetperf2.npagactual();
            if (npagactual != 1) {
                self.pagvi_segusudetperf2.npagactual(self.pagvi_segusudetperf2.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_segusudetperf2.npagactual() != self.pagvi_segusudetperf2.npagcantidad()) {
                self.pagvi_segusudetperf2.npagactual(self.pagvi_segusudetperf2.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_segusudetperf2.npagactual() != self.pagvi_segusudetperf2.npagcantidad()) {
                self.pagvi_segusudetperf2.npagactual(self.pagvi_segusudetperf2.npagcantidad);
                self.buscar('MOV');
            }
        }
    }

    //recordemos siempre excluir del viewmodel aquellos objetos que no deseamos enviar serializados con la funcion ko.toJSON()
    //con la finalidad de que la peticion no sea tan pesada y no estemos ocupando el ancho de banda innecesariamente
    vmmanactivarusubuscar1.prototype.toJSON = function () {
        var copia = ko.toJS(this);
        delete copia.lista_vi_segusudetperf2;
        delete copia.combohoras;
        delete copia.combominutos;
        return copia;
    }
</script>
