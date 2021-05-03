<fieldset class="form-area" data-bind="with: persaipinssinicotiz">
    <legend>Detalle</legend>
    <ul id="lista_err_insinternamagregar1" style="display: none;">
        <li data-bind="validationMessage: idsegmanusuperit" style="color: red;"></li>
        @*<li data-bind="validationMessage: idcomunmanpais" style="color: red;"></li>*@
        <li data-bind="validationMessage: idcomunmanestado" style="color: red;"></li>
        <li data-bind="validationMessage: idcomunmanlocalid" style="color: red;"></li>
        @*<li data-bind="validationMessage: finicioinssinicotiz" style="color: red;"></li>
            <li data-bind="validationMessage: ffininssinicotiz" style="color: red;"></li>*@
        <li data-bind="validationMessage: xdireccioninssinicotiz" style="color: red;"></li>
        @*<li data-bind="validationMessage: xtelfmovilactivperi" style="color: red;"></li>*@
        @*<li data-bind="validationMessage: xcorreoelectronicoactivperi" style="color: red;"></li>*@
        @*<li data-bind="validationMessage: xtituactivperi" style="color: red;"></li>*@
    </ul>

    <fieldset class="form-area">
        <legend data-bind="text: $root.xtitulo"></legend>
        <div class="form-row">
            <div style="float: left; margin-right: 10%;">
                <div class="form-field-header">
                    Tipo de Inspección
                </div>
                <div class="form-field-content">
                    <select data-bind="options: $root.cboitipoinsinssinicotiz, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: itipoinsinssinicotiz, event: { change: $root.cargar_motivo }" ></select>
                </div>
            </div>
            <div>
                <div class="form-field-header">
                    <label>Sucursal</label>
                    <div class="form-field-content">
                        <select data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: idsegmanorg, event: { change: $root.obtener_peritos }"></select>
                    </div>
                </div>
            </div>
        </div>

        <div class="form-row">
            <div style="float: left; margin-right: 10%;">
                <div class="form-field-header">
                    Nacionalidad
                </div>
                <div class="form-field-content">
                    <select data-bind="options: $root.cbonacionalidad, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: xnacioninssinicotiz"></select>
                </div>
            </div>

            <div>
                <div class="form-field-header">
                    Cédula Cliente
                </div>
                <div class="form-field-content">
                    <input type="text" maxlength="10" placeholder="17895541" data-bind="value: xcedpropinssinicotiz" />
                </div>
            </div>
        </div>

        <div class="form-row">
            <div style="float: left; margin-right: 10%;" data-bind="visible : $root.imostrar">
                <div class="form-field-header">
                    Tipo Siniestro:
                </div>
                <div class="form-field-content">
                    <select data-bind="options: $root.combotiposini, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: itipoinssinicotiz, event: { change: $root.obtener_causa }"></select>
                </div>
            </div>

            <div data-bind="visible : $root.imostrar">
                <div class="form-field-header">
                    Causa Siniestro:
                </div>
                <div class="form-field-content">
                    <select data-bind="options: $root.combocausasini, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: icausainssinicotiz"></select>
                </div>
            </div>
        </div>

        <div class="form-row">
            <div style="float: left; margin-right: 10%;" data-bind="visible : $root.imostrar">
                <div class="form-field-header">
                    Fecha Ocurrencia:
                </div>
                <div class="form-field-content">
                    <input type="text" placeholder="17/11/1983" class="date-field" data-bind="datevalue: focurrinssinicotiz" />
                </div>
            </div>
            <div>
                <div class="form-field-header">
                    Placa
                </div>
                <div class="form-field-content">
                    <input type="text" maxlength="10" placeholder="17895541" data-bind="value: xplacainssinicotiz" />
                </div>
            </div>
        </div>

        <div class="form-row">

            <div style="float: left; margin-right: 10%;" data-bind="visible : $root.imostrar">
                <div class="form-field-header">
                    Estado
                </div>
                <div class="form-field-content">
                    <select data-bind="options: $root.cboidcomunmanestado, optionsText: 'xnombreestado', optionsValue: 'idcomunmanestado', value: idcomunmanestado, event: { change: $root.obtener_localidades }"></select>
                </div>
            </div>

            <div data-bind="visible : $root.imostrar">
                <div class="form-field-header">
                    Localidad
                </div>
                <div class="form-field-content">
                    <select data-bind="options: $root.cboidcomunmanlocalid, optionsText: 'xnombrelocalid', optionsValue: 'idcomunmanlocalid', value: idcomunmanlocalid"></select>
                </div>
            </div>

        </div>

        <div class="form-row" data-bind="visible : $root.imostrar">
            <div>
                <div class="form-field-header">
                    Dirección
                </div>
                <div class="form-field-content">
                    <textarea maxlength="100" cols="70" rows="4" data-bind="value: xdireccioninssinicotiz"></textarea>

                </div>
            </div>
        </div>


    </fieldset>

    <fieldset class="form-area">
        <legend>Datos de Inspección</legend>

        <div class="form-row">
            <div style="float: left; margin-right: 10%;">
                <div class="form-field-header">
                    Inicia:
                </div>
                <div class="form-field-content">
                    <input style="width: 141px" placeholder="Ej: 17/11/1983" class="date-field" data-bind="datevalue: finicioinssinicotiz" />
                    <select id="comboHoraSalida" style="width: 60px" data-bind="options: $root.combohoras, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: $root.hora"></select>
                    <span>:</span>
                    <select id="comboMinutosSalida" style="width: 60px" data-bind="options: $root.combominutos, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: $root.minutos"></select>
                </div>
            </div>

            <div style="float: left; margin-right: 10%;">
                <div class="form-field-header">
                    Finaliza:
                </div>
                <div class="form-field-content">
                    <input style="width: 141px" placeholder="Ej: 17/11/1983" class="date-field" data-bind="datevalue: ffininssinicotiz" />
                    <select id="comboHoraRegreso" style="width: 60px" data-bind="options: $root.combohoras, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: $root.horaFin"></select>
                    <span>:</span>
                    <select id="comboMinutosRegreso" style="width: 60px" data-bind="options: $root.combominutos, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: $root.minutosFin"></select>
                </div>
            </div>
        </div>

        <div class="form-row">

            <div style="float: left; margin-right: 10%;">
                <div class="form-field-header">
                    Perito
                </div>
                <div class="form-field-content">
                    <select data-bind="options: $root.cboperito, optionsText: 'xnombrecompleto', optionsValue: 'idsegmanusu', value: idsegmanusuperit"></select>
                </div>
            </div>

            <div>
                <div class="form-field-header">
                    Comentario
                </div>
                <div class="form-field-content">
                    <textarea maxlength="500" cols="27" rows="4" data-bind="value: xdescinssinicotiz"></textarea>
                </div>
            </div>
        </div>

    </fieldset>

    <div class="form-row">
        <div class="form-column">
            <input type="button" value="Agregar" data-bind="click: $root.agregar" />
        </div>
    </div>
</fieldset>


<script type="text/javascript">
    function vmInsIntermAgregar1() {
        var self = this;
        self.aipactivperi = new aipactivperi(true);
        self.persaipinssinicotiz = new persaipinssinicotiz(false);
        self.usuario = ko.observable("");
        self.persaipinssinicotiz.finicioinssinicotiz = ko.observable("");
        self.hora = ko.observable();
        self.minutos = ko.observable();
        self.persaipinssinicotiz.ffininssinicotiz = ko.observable("");
        self.horaFin = ko.observable();
        self.minutosFin = ko.observable();
        self.combohoras = ko.observableArray();
        self.combominutos = ko.observableArray();
        self.persaipinssinicotiz.finicioinssinicotiz = ko.observable("");
        self.persaipinssinicotiz.ffininssinicotiz = ko.observable("");
        self.idsegmanorgperit = ko.observable(0);
        self.idaipinsintext = ko.observable(0);

        self.cboidcomunmancont = ko.observableArray();
        //self.cboidcomunmanpais = ko.observableArray();
        self.cboidcomunmanestado = ko.observableArray();
        self.cboidcomunmanlocalid = ko.observableArray();
        self.cboperito = ko.observableArray();
        self.cboitipoinsinssinicotiz = ko.observableArray();
        self.cbonacionalidad = ko.observableArray();
        self.cbosucursal = ko.observableArray();
        self.combotiposini = ko.observableArray();
        self.combocausasini = ko.observableArray();
        self.fechainicio = ko.observable("");
        self.fechafin = ko.observable("");
        self.imostrar = ko.observable(true);
        self.xtitulo = ko.observable("Datos del siniestro");
        //self.itipoinssinicotiz = ko.observable("");
        //self.icausainssinicotiz = ko.observable("");
        //self.cboitipomotiv = ko.observableArray();
        //self.xtitulosinicotiz = ko.observable("# Siniestro");

        self.cargar = function () {

            //ko.mapping.fromJS(persaipinssinicotiz, {}, self.persaipinssinicotiz);
            self.llenarcboidcmnmanestad(9);
            //self.llenarcboidcmnmanlocalid(persaipinssinicotiz.idcomunmanestado, persaipinssinicotiz.idcomunmanlocalid);
            self.llenarcbotipoinsenc("SINIESTRO");
            self.llenarcbonacionalidad("V");
            self.llenarcbosucursal();
            //para el siniestro(no aplica para nuestras tablas)
            self.llenarcbotiposini();
            //self.llenarcbocausasini();//depende del tipo
            //self.llenarcbotipomotiv(persaipinssinicotiz.idaipinsmotiv, persaipinssinicotiz.itipoinsinssinicotiz);

            var date = new Date(self.persaipinssinicotiz.finicioinssinicotiz());
            var dia = date.getDate();
            var mes = parseInt(date.getMonth()) + 1;
            var anio = date.getFullYear();
            //self.persaipinssinicotiz.finicioinssinicotiz(dia + "/" + mes + "/" + anio);
            var hora = date.getHours();
            var minutos = date.getMinutes();
            if (minutos < 10)
                minutos = "0" + minutos;
            self.llenarcombohoras(hora, horaFin);
            var dateFin = new Date(self.persaipinssinicotiz.ffininssinicotiz());
            var diaRegreso = dateFin.getDate();
            var mesRegreso = parseInt(dateFin.getMonth()) + 1;
            var anioRegreso = dateFin.getFullYear();
            //self.persaipinssinicotiz.ffininssinicotiz(diaRegreso + "/" + mesRegreso + "/" + anioRegreso);
            var horaFin = dateFin.getHours();
            var minutosFin = dateFin.getMinutes();
            if (minutosFin < 10)
                minutosFin = "0" + minutosFin;
            self.llenarcombominutos(minutos, minutosFin);
        }

        self.limpiar = function () {
            self.persaipinssinicotiz.idsegmanorg(0);
            self.persaipinssinicotiz.idsegmanusuperit(0);
            self.persaipinssinicotiz.idcomunmanestado(0);
            self.persaipinssinicotiz.idcomunmanlocalid(0);
            self.persaipinssinicotiz.itipoinsinssinicotiz("SINIESTRO");
            self.imostrar(true);
            self.xtitulo("Datos del siniestro");
            self.persaipinssinicotiz.xnacioninssinicotiz("V");
            self.persaipinssinicotiz.xcedpropinssinicotiz("");
            self.persaipinssinicotiz.finicioinssinicotiz("");
            self.persaipinssinicotiz.itipoinssinicotiz("");
            self.persaipinssinicotiz.ffininssinicotiz("");
            self.persaipinssinicotiz.icausainssinicotiz("");
            self.persaipinssinicotiz.focurrinssinicotiz("");
            self.persaipinssinicotiz.fdeclarinssinicotiz("");
            self.persaipinssinicotiz.fnotifinssinicotiz("");
            self.persaipinssinicotiz.xnuminssinicotiz("");
            self.persaipinssinicotiz.xdireccioninssinicotiz("");
            self.persaipinssinicotiz.xdescinssinicotiz("");

            self.fechainicio("");
            self.fechafin("");

            /*self.hora(0);
            self.minutos(0);
            self.horaFin(0);
            self.minutosFin(0);*/
            self.limpiarHoras();
        }

        self.limpiarHoras = function () {
            self.hora(0);
            self.minutos(0);
            self.horaFin(0);
            self.minutosFin(0);
        }

        //

        self.ObtenerDatosPendiente = function (idsegmanorg, idaipinsintext) {
            if (idaipinsintext > 0) {
                self.idaipinsintext(idaipinsintext);
                postajaxjsonbasico("/Inspeccion/ObtenerDatosInspeccionRector/?idaipinsintext=" + idaipinsintext, '{}', function (persaipinssinicotiz) {
                    ko.mapping.fromJS(persaipinssinicotiz, {}, self.persaipinssinicotiz);
                    self.llenarcbotipoinsenc(persaipinssinicotiz.itipoinsinssinicotiz);
                    self.llenarcbosucursal(idsegmanorg);
                });
            }
            else {
                self.llenarcbotipoinsenc("");
                self.llenarcbosucursal(idsegmanorg);
            }
        }


        self.ObtenerSucursalUsuario = function (idsegmanusu) {
            postajaxjsonbasico("/Seguridad/Obtenervi_segusudetperf2PorIdsegmanusu/?idsegmanusu=" + idsegmanusu, '{}', function (vi_segusudetperf2) {
                //if (vi_segusudetperf2 != null) {
                //    self.llenarcbosucursal(self.idsegmanorgperit());
                //} else {
                //    self.llenarcbosucursal(0);
                //}
            });
        }

        self.llenarcbosucursal = function (idsegmanorg) {
            postajaxjsonbasico("/comun/ObtenerComboOrganizacion/", '{}', function (lista_vi_combosegmanorg) {
                self.cbosucursal(lista_vi_combosegmanorg);
                self.persaipinssinicotiz.idsegmanorg(idsegmanorg);
                // self.llenarcboperito(idsegmanorg);
            });
        }

        /*
        this.obtener_paises = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                self.cboidcomunmanpais("");
                self.persaipinssinicotiz.idcomunmanpais(0);
                self.cboidcomunmanestado("");
                self.persaipinssinicotiz.idcomunmanestado(0);
                self.cboidcomunmanlocalid("");
                self.persaipinssinicotiz.idcomunmanlocalid(0);
                self.llenarcboidcmnmanpais(self.persaipinssinicotiz.idcomunmancont(), self.persaipinssinicotiz.idcomunmanpais());
            } else {
                //si el programa desencadeno el evento

            }
        }*/

        this.obtener_estados = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                self.cboidcomunmanestado("");
                self.persaipinssinicotiz.idcomunmanestado(0);
                self.cboidcomunmanlocalid("");
                self.persaipinssinicotiz.idcomunmanlocalid(0);
                self.llenarcboidcmnmanestad(9, self.persaipinssinicotiz.idcomunmanestado());
            } else {
                //si el programa desencadeno el evento

            }
        }

        this.obtener_localidades = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                self.cboidcomunmanlocalid("");
                self.persaipinssinicotiz.idcomunmanlocalid(0);
                self.llenarcboidcmnmanlocalid(self.persaipinssinicotiz.idcomunmanestado(), self.persaipinssinicotiz.idcomunmanlocalid());
            } else {
                //si el programa desencadeno el evento

            }
        }

        this.obtener_peritos = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                self.cboperito("");
                //alert(self.idsegmanorg());
                //                self.persaipinssinicotiz.idsegmanusuperit(0);
                self.llenarcboperito(self.persaipinssinicotiz.idsegmanorg(), self.persaipinssinicotiz.idsegmanusuperit());
            } else {
                //si el programa desencadeno el evento

            }
        }

        self.llenarcboidcmnmancontin = function () {
            postajaxjsonbasico("/Comun/ObtenerComboContinente/", '{}', function (lista_comunmancont) {
                self.cboidcomunmancont(lista_comunmancont);
            });
        }
        //self.llenarcboidcmnmanpais = function (idcomunmancont) {
        //    postajaxjsonbasico("/Comun/ObtenerComboPais/?idcomunmancont=" + idcomunmancont, '{}', function (lista_cmnmanpais) {
        //        self.cboidcomunmanpais(lista_cmnmanpais);
        //    });
        //}
        self.llenarcboidcmnmanestad = function (idcomunmanpais, idcomunmanestado) {
            postajaxjsonbasico("/Comun/ObtenerComboEstado/?idcomunmanpais=" + idcomunmanpais, '{}', function (lista_comunmanestado) {
                self.cboidcomunmanestado(lista_comunmanestado);
                self.persaipinssinicotiz.idcomunmanestado(idcomunmanestado);
            });
        }
        self.llenarcboidcmnmanlocalid = function (idcomunmanestado, idcomunmanlocalid) {
            postajaxjsonbasico("/Comun/ObtenerComboLocalidad/?idcomunmanestado=" + idcomunmanestado, '{}', function (lista_comunmanlocalid) {
                self.cboidcomunmanlocalid(lista_comunmanlocalid);
                self.persaipinssinicotiz.idcomunmanlocalid(idcomunmanlocalid);
            });
        }

        self.llenarcboperito = function (idsegmanorg, idsegmanusuperit) {
            postajaxjsonbasico("/Agenda/ObtenerComboPeritosPorUsuarioYOrg/?idsegmanorg=" + idsegmanorg, '{}', function (lista_segmanusuperit) {
                self.cboperito(lista_segmanusuperit);
                //self.persaipinssinicotiz.idsegmanusuperit(idsegmanusuperit);
            });
        }

        self.llenarcbotipoinsenc = function (itipoinsinssinicotiz) {
            var xconcepto = "ITIPOINSENC";
            postajaxjsonbasico("/Comun/ObtenerValores/?xconcepto=" + xconcepto, '{}', function (lista_comunconfvalor) {
                self.cboitipoinsinssinicotiz(lista_comunconfvalor);
                self.persaipinssinicotiz.itipoinsinssinicotiz(itipoinsinssinicotiz);
            });
        }

        self.llenarcbonacionalidad = function (xnacioninssinicotiz) {
            var xconcepto = "NACIONALEXT";
            postajaxjsonbasico("/Comun/ObtenerValores/?xconcepto=" + xconcepto, '{}', function (lista_comunconfvalor) {
                self.cbonacionalidad(lista_comunconfvalor);
                self.persaipinssinicotiz.xnacioninssinicotiz(xnacioninssinicotiz);
            });
        }

        //para el siniestro, no aplica en cuentras tablas
        self.llenarcbotiposini = function () {
            var xconcepto = "ITIPOSINI";
            postajaxjsonbasico("/Comun/ObtenerValores/?xconcepto=" + xconcepto, '{}', function (lista_comunconfvalor) {
                self.combotiposini(lista_comunconfvalor);
            });
        }
        self.llenarcbocausasini = function () {
            var xconcepto = "ICAUSASINI" + self.persaipinssinicotiz.itipoinssinicotiz(); //se le concatena el tipo dado que la causa esta atada al tipo
            postajaxjsonbasico("/Comun/ObtenerValores/?xconcepto=" + xconcepto, '{}', function (lista_comunconfvalor) {
                self.combocausasini(lista_comunconfvalor);
            });
        }

        this.obtener_causa = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                self.combocausasini("");
                self.llenarcbocausasini();
            } else {
                //si el programa desencadeno el evento

            }
        }
        //Fin para el siniestro, no aplica en cuentras tablas

        self.llenarcbotipomotiv = function (idaipinsmotiv, itipoinsinssinicotiz) {

            if (itipoinsinssinicotiz != "" || itipoinsinssinicotiz != undefined) {
                postajaxjsonbasico("/Inspeccion/ObtenerComboMotivosActivosPorTipoIns/?itipoinsmotiv=" + itipoinsinssinicotiz, '{}', function (lista_aipinsmotiv) {
                    self.cboitipomotiv(lista_aipinsmotiv);
                    self.persaipinssinicotiz.idaipinsmotiv(idaipinsmotiv);
                });
            }
        }

        this.cargar_motivo = function (obj, event) {
            if (event.originalEvent) {
                //para cambiar el titulo de el campo de la tabla de siniestro para que diga cotizacion o siniestro
                if (self.persaipinssinicotiz.itipoinsinssinicotiz() == "SINIESTRO") {
                    //self.xtitulosinicotiz("# Siniestro");
                    self.xtitulo("Datos del siniestro");
                    self.imostrar(true);
                }
                else
                {
                    //self.xtitulosinicotiz("# Cotización");
                    self.xtitulo("Datos de la cotización");
                    self.imostrar(false);
                }
            } else {
                //si el programa desencadeno el evento

            }
        }


        self.formatearfechaini = function (fejecucion) {


            self.persaipinssinicotiz.finicioinssinicotiz(fejecucion);
            self.persaipinssinicotiz.ffininssinicotiz(fejecucion);
        }

        self.eliminar = function (obj) {
            var botones = [
                {
                    addClass: 'btn btn-primary', text: 'Si', onClick: function ($noty) {
                        $noty.close();
                        postajaxjsonbasico("/Agenda/EliminarPeritajePorId/?idaipinsenc=" + self.persaipinssinicotiz.idaipinsenc(), "", function (respopera) {
                            var tipo = "MOV"
                            if (respopera.irespuesta == 1) {
                                $('#dlg_agendaperitajeagregar1').dialog("close");
                                $('#dlg_agendaperitajesmodal1').dialog("close");
                                var tipo = "MOV";
                                vmagendaperitajesgrid1.buscar_peritajes(tipo, self.persaipinssinicotiz.finicioinssinicotiz());
                                generar_noty_auto("La actividad se ha eliminado satisfactoriamente.", "success");
                            } else {
                                generar_noty_modal(respopera.xmsjusuario, "error");
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
            generar_noty_confirmacion("¿Está seguro que desea eliminar esta actividad?", botones);
        }

        self.obtenerusuarioconectado = function () {
            postajaxjsonbasico("/Agenda/ObtenerUsuarioConectado/", {}, function (usuario) {
                var nombre = ucWords(usuario);
                self.usuario(nombre);
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


        self.agregar = function () {

            self.fullFecha = ko.computed(function () {
                return self.persaipinssinicotiz.finicioinssinicotiz() + " " + self.hora() + ":" + self.minutos() + ":00";
            }, this);
            self.fullFechaFin = ko.computed(function () {
                return self.persaipinssinicotiz.ffininssinicotiz() + " " + self.horaFin() + ":" + self.minutosFin() + ":00";
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
                if ((monthFin > monthInicio) || ((monthFin < monthInicio) && (yearFin > yearInicio))) {

                }
                else {
                    generar_noty_auto("La hora en que finaliza debe ser mayor a la hora en que inicia", "warning");
                    //aqui no le pongo la fecha de inicio y fin porque todavia no le agrego lA HORA
                    return false;
                }
                // si es 0 es porque ambas persaipinssinicotiz.finicioinssinicotizs persaipinssinicotiz.finicioinssinicotizs son iguales
                //si es 1 es porque la persaipinssinicotiz.finicioinssinicotiz fin es menor a la persaipinssinicotiz.finicioinssinicotiz inicio
            }

            //alert(self.fullFecha());
            //alert(self.fullFechaFin());

            //alert(self.persaipinssinicotiz.finicioinssinicotiz());
            //alert(self.persaipinssinicotiz.ffininssinicotiz());

            //estas fechas son para mantener las fechas de inicio y fin de la pantalla sin las horas
            self.fechainicio(self.persaipinssinicotiz.finicioinssinicotiz());
            self.fechafin(self.persaipinssinicotiz.ffininssinicotiz());

            self.persaipinssinicotiz.finicioinssinicotiz(self.fullFecha());
            self.persaipinssinicotiz.ffininssinicotiz(self.fullFechaFin());
            if (self.persaipinssinicotiz.finicioinssinicotiz() > self.persaipinssinicotiz.ffininssinicotiz())
            {
                generar_noty_auto("La hora en que finaliza debe ser mayor a la hora en que inicia", "warning");
                //para ponerle al objeto la fecha de inicio y fin sin horas
                self.persaipinssinicotiz.finicioinssinicotiz(self.fechainicio());
                self.persaipinssinicotiz.ffininssinicotiz(self.fechafin());
                return false;
            }

            self.persaipinssinicotiz.errors = ko.validation.group(self.persaipinssinicotiz);

            if (self.persaipinssinicotiz.errors().length > 0) {
                generar_noty_modal($('#lista_err_insinternamagregar1').html(), "warning");
                //para ponerle al objeto la fecha de inicio y fin sin horas
                self.persaipinssinicotiz.finicioinssinicotiz(self.fechainicio());
                self.persaipinssinicotiz.ffininssinicotiz(self.fechafin());
                return false;
            }

            //alert(self.aipactivperi.xcidaseactivperi());
            //alert(self.aipactivperi.xsermotactivperi());
            //alert(self.aipactivperi.xsercarractivperi());
            //alert(self.aipactivperi.xplacaactivperi());
            //alert(self.aipactivperi.xnacioninssinicotiz());
            postajaxjsonbasico("/Inspeccion/GuardarSiniestroSuscripcion/", ko.toJSON(self.persaipinssinicotiz), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                    //para ponerle al objeto la fecha de inicio y fin sin horas
                    self.persaipinssinicotiz.finicioinssinicotiz(self.fechainicio());
                    self.persaipinssinicotiz.ffininssinicotiz(self.fechafin());
                }
            });

        }



        $(function () {
            //$('#colorpickerField2').ColorPicker({ r: 255, r: 0, b: 0 });
            $("#xsermotinsenc").numeric();
            $("#xnumpolinsenc").numeric();
            $("#xnumsininsenc").numeric();
        });
    }

    vmInsIntermAgregar1.prototype.toJSON = function () {
        var copia = ko.toJS(this);
        delete copia.combohoras;
        delete copia.combominutos;
        delete copia.cboidcomunmancont;
        //delete copia.cboidcomunmanpais;
        delete copia.cboidcomunmanestado;
        delete copia.cboidcomunmanlocalid;
        delete copia.cboitipoinsenc;
        delete copia.cbosucursal;
        //delete copia.cboitipomotiv;
        return copia;
    }

</script>
