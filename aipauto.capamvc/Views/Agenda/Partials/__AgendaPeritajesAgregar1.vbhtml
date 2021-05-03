<fieldset class="form-area" data-bind="with: vi_aipinsenc">
    <legend>Datos de la actividad</legend>

    <ul id="lista_err_agendaperitajesagregar1" style="display: none;">
        <li data-bind="validationMessage: idsegmanusuperit" style="color: red;"></li>
        <li data-bind="validationMessage: idcomunmanpais" style="color: red;"></li>
        <li data-bind="validationMessage: idcomunmanestado" style="color: red;"></li>
        <li data-bind="validationMessage: idcomunmanlocalid" style="color: red;"></li>
        <li data-bind="validationMessage: fejecactivperi" style="color: red;"></li>
        <li data-bind="validationMessage: ffinejecactivperi" style="color: red;"></li>
        <li data-bind="validationMessage: xdireccionactivperi" style="color: red;"></li>
        <li data-bind="validationMessage: xtelfmovilactivperi" style="color: red;"></li>
        <li data-bind="validationMessage: xcorreoelectronicoactivperi" style="color: red;"></li>
        <li data-bind="validationMessage: xtituactivperi" style="color: red;"></li>
    </ul>


    <div class="form-row">

        <div style="float: left; margin-right: 10%;">
            <div class="form-field-header">
                Peritaje:
            </div>
            <div class="form-field-content">
                <input placeholder="Ej: Peritaje 001" type="text" maxlength="100" data-bind="value: xtituactivperi" />
            </div>
        </div>

    </div>

    <div class="form-row">
        <div style="float: left; margin-right: 10%;">
            <div class="form-field-header">
                Tipo de Inspección
            </div>
            <div class="form-field-content">
                <select data-bind="options: $root.cboitipoinsenc, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: itipoinsenc, event: { change: $root.cargar_motivo }"></select>
            </div>
        </div>
        <div>
            <div class="form-field-header">
                Motivo
            </div>
            <div class="form-field-content">
                <select data-bind="options: $root.cboitipomotiv, optionsText: 'xnominsmotiv', optionsValue: 'idaipinsmotiv', value: idaipinsmotiv"></select>
            </div>
        </div>

    </div>


    <div class="form-row">
        <div style="float: left; margin-right: 10%;">
            <div class="form-field-header">
                <label>Sucursal</label>
                <div class="form-field-content">
                    <select data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: $root.idsegmanorg, disable: true"></select>
                </div>
            </div>
        </div>

        <div>
            <div class="form-field-header">
                Nombre cliente
            </div>
            <div class="form-field-content">
                <input type="text" maxlength="50" placeholder="Pedro González" data-bind="value: xnomcliactivperi" />
            </div>
        </div>
        
    </div>



    <div class="form-row">
        <div style="float: left; margin-right: 10%;">
            <div class="form-field-header">
                Inicia:
            </div>
            <div class="form-field-content">
                <input style="width: 141px" placeholder="Ej: 17/11/1983" class="date-field" data-bind="datevalue: $root.fecha" />
                <select id="comboHoraSalida" style="width: 60px" data-bind="options: $root.combohoras, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: $root.hora"></select>
                <span>:</span>
                <select id="comboMinutosSalida" style="width: 60px" data-bind="options: $root.combominutos, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: $root.minutos"></select>
            </div>
        </div>
        <div>
            <div class="form-field-header">
                Correo Electrónico
            </div>
            <div class="form-field-content">
                <input type="text" maxlength="50" placeholder="usuario@sitfx.com" data-bind="value: xcorreoelectronicoactivperi" />
            </div>
        </div>
    </div>
    <div class="form-row">
        <div style="float: left; margin-right: 10%;">
            <div class="form-field-header">
                Finaliza:
            </div>
            <div class="form-field-content">
                <input style="width: 141px" placeholder="Ej: 17/11/1983" class="date-field" data-bind="datevalue: $root.fechaFin" />
                <select id="comboHoraRegreso" style="width: 60px" data-bind="options: $root.combohoras, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: $root.horaFin"></select>
                <span>:</span>
                <select id="comboMinutosRegreso" style="width: 60px" data-bind="options: $root.combominutos, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: $root.minutosFin"></select>
            </div>
        </div>
        <div>
            <div class="form-field-header">
                Cédula Propietario
            </div>
            <div class="form-field-content">
                <input type="text" maxlength="10" placeholder="17895541" data-bind="value: xcedpropinsenc" />
            </div>
        </div>
    </div>
    <div class="form-row">

        <div style="float: left; margin-right: 10%;">
            <div class="form-field-header">
                Telefono Movil
            </div>
            <div class="form-field-content">
                <input type="text" maxlength="11" placeholder="04243333333" data-bind="value: xtelfmovilactivperi" />
            </div>
        </div>

        <div class="form-field-header">
            Serial motor
        </div>
        <div class="form-field-content">
            <input id="xsermotinsenc" type="text" maxlength="30" placeholder="000000000000000" data-bind="value: xsermotinsenc" />
        </div>






        @*<div>
            <div class="form-field-header">
                Cédula Sidorista
            </div>
            <div class="form-field-content">
                <input type="text" maxlength="10" placeholder="17895541" data-bind="value: xcedsidoinsenc" />
            </div>

        </div>*@


    </div>
    <div class="form-row">

        <div style="float: left; margin-right: 10%;">
            <div class="form-field-header">
                Placa del vehículo
            </div>
            <div class="form-field-content">
                <input type="text" maxlength="7" placeholder="AB992CC" data-bind="value: xplacinsenc" />
            </div>
        </div>

        <div>
            <div class="form-field-header">
                Serial carrorecería
            </div>
            <div class="form-field-content">
                <input type="text" placeholder="000000000000000" data-bind="value: xsercarrinsenc" maxlength="17" />
            </div>
        </div>







    </div>
    <div class="form-row">

        <div style="float: left; margin-right: 10%;">
            <div class="form-field-header">
                Estado
            </div>
            <div class="form-field-content">
                <select data-bind="options: $root.cboidcomunmanestado, optionsText: 'xnombreestado', optionsValue: 'idcomunmanestado', value: idcomunmanestado, event: { change: $root.obtener_localidades }"></select>
            </div>
        </div>

        <div>
            <div class="form-field-header">
                # Póliza
            </div>
            <div class="form-field-content">
                <input id="xnumpolinsenc" type="text" maxlength="10" placeholder="AB992CC" data-bind="value: xnumpolinsenc" />
            </div>
        </div>


    </div>


    <div class="form-row">

        <div style="float: left; margin-right: 10%;">
            <div class="form-field-header">
                Localidad
            </div>
            <div class="form-field-content">
                <select data-bind="options: $root.cboidcomunmanlocalid, optionsText: 'xnombrelocalid', optionsValue: 'idcomunmanlocalid', value: idcomunmanlocalid"></select>
            </div>
        </div>


        <div>
            <div class="form-field-header">
                @*# Siniestro*@
                <div  style="font-weight:bold;" data-bind="text: $root.xtitulosinicotiz"></div>
            </div>
            <div class="form-field-content">
                <input id="xnumsininsenc" type="text" maxlength="10" placeholder="123456789" data-bind="enterovalue: xnumsininsenc" />
            </div>
        </div>



    </div>

    <div class="form-row">

        <div style="float: left; margin-right: 11%;">
            <div class="form-field-header">
                Dirección
            </div>
            <div class="form-field-content">
                <textarea maxlength="100" cols="50" rows="4" data-bind="value: xdireccionactivperi"></textarea>

            </div>
        </div>

    </div>

    @*    <div class="form-row">
        <div style="float:left; margin-right:10%;">
            
        </div>
        
        
    </div>*@
    @*    <div class="form-row">
        
    </div>
    <div class="form-row">
        
    </div>
    <div class="form-row">
        
    </div>
    <div class="form-row">
        
    </div>
    <div class="form-row">
        
    </div>
    <div class="form-row">
        
    </div>*@

    <div class="form-row">
        <div class="form-field-header">
            Informaci&oacute;n adicional:
        </div>
        <div class="form-field-content">
            <textarea maxlength="500" cols="50" rows="4" data-bind="value: xdescactivperi"></textarea>
        </div>
    </div>
    @*    <input type="text" maxlength="6" size="6" id="colorpickerField2" value="ff0000" />*@

    <div data-bind="visible: $root.visibleDivAgregar" class="form-column">
        <input type="button" value="Agregar" data-bind="click: $root.agregar" />
    </div>
    <div data-bind="visible: $root.visibleDivModificar">
        <div class="form-column">
            <input type="button" value="Modificar" data-bind="click: $root.modificar" />
        </div>
        @*<div class="form-column">
            <input type="button" value="Eliminar" data-bind="click: $root.eliminar" />
        </div>*@
    </div>

</fieldset>


<script type="text/javascript">
    function vmagendaperitajeagregar1() {
        var self = this;
        self.aipactivperi = new aipactivperi(true);
        self.vi_aipinsenc = new vi_aipinsenc(false);

        self.usuario = ko.observable("");
        self.fecha = ko.observable("");
        self.hora = ko.observable();
        self.minutos = ko.observable();
        self.fechaFin = ko.observable("");
        self.horaFin = ko.observable();
        self.minutosFin = ko.observable();
        self.combohoras = ko.observableArray();
        self.combominutos = ko.observableArray();
        self.fechaEjecucion = ko.observable("");
        self.fechaFin = ko.observable("");
        self.visibleDivModificar = ko.observable(false);
        self.visibleDivAgregar = ko.observable(false);
        self.idsegmanusuperit = ko.observable(0);
        self.idsegmanorgperit = ko.observable(0);
        self.idsegmanorg = ko.observable(0);
        self.idaipinsintext = ko.observable(0);

        self.cboidcomunmancont = ko.observableArray();
        self.cboidcomunmanpais = ko.observableArray();
        self.cboidcomunmanestado = ko.observableArray();
        self.cboidcomunmanlocalid = ko.observableArray();
        self.cboitipoinsenc = ko.observableArray();
        self.cbosucursal = ko.observableArray();
        self.cboitipomotiv = ko.observableArray();
        self.xtitulosinicotiz = ko.observable("# Siniestro");


        self.limpiar = function () {
            self.vi_aipinsenc.idaipinsenc(0);
            self.vi_aipinsenc.idsegmanusuperit(0);
            self.vi_aipinsenc.idaipinsintext(0);
            self.vi_aipinsenc.xtituactivperi("");
            self.vi_aipinsenc.xnomcliactivperi("");
            self.vi_aipinsenc.idcomunmancont(0);
            self.vi_aipinsenc.idcomunmanpais(0);
            self.vi_aipinsenc.idcomunmanestado(0);
            self.vi_aipinsenc.idcomunmanlocalid(0);
            self.vi_aipinsenc.fejecactivperi("");
            self.vi_aipinsenc.ffinejecactivperi("");
            self.vi_aipinsenc.xdireccionactivperi("");
            self.vi_aipinsenc.xtelfmovilactivperi("");
            self.vi_aipinsenc.xcorreoelectronicoactivperi("");
            self.vi_aipinsenc.xdescactivperi("");
            self.vi_aipinsenc.ialcanactivperi("");
            self.vi_aipinsenc.iestatactivperi("");
            self.vi_aipinsenc.xnumpolinsenc("");
            self.vi_aipinsenc.xnumsininsenc("");

            self.vi_aipinsenc.xcedpropinsenc("");
            self.vi_aipinsenc.xcedsidoinsenc("");
            self.vi_aipinsenc.itipoinsenc("");

            self.fecha("");
            self.hora(0);
            self.minutos(0);
            self.fechaFin("");
            self.horaFin(0);
            self.minutosFin(0);

            self.vi_aipinsenc.xsermotinsenc("");
            self.vi_aipinsenc.xsercarrinsenc("");
            self.vi_aipinsenc.xplacinsenc("");
            self.vi_aipinsenc.idseglogreg(0);
        }

        //

        self.ObtenerDatosPendiente = function (idsegmanorg, idaipinsintext) {
            if (idaipinsintext > 0) {
                self.idaipinsintext(idaipinsintext);
                postajaxjsonbasico("/Inspeccion/ObtenerDatosInspeccionRector/?idaipinsintext=" + idaipinsintext, '{}', function (vi_aipinsenc) {
                    ko.mapping.fromJS(vi_aipinsenc, {}, self.vi_aipinsenc);
                    //para cambiar el titulo de el campo de la tabla de siniestro para que diga cotizacion o siniestro
                    if (vi_aipinsenc.itipoinsenc == "SINIESTRO") {
                        self.xtitulosinicotiz("# Siniestro");
                    }
                    else { self.xtitulosinicotiz("# Cotización"); }
                    self.llenarcbotipoinsenc(vi_aipinsenc.itipoinsenc);
                    self.llenarcbosucursal(idsegmanorg);
                });
            }
            else
            {
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

                self.idsegmanorg(idsegmanorg);
            });
        }

        this.obtener_paises = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                self.cboidcomunmanpais("");
                self.vi_aipinsenc.idcomunmanpais(0);
                self.cboidcomunmanestado("");
                self.vi_aipinsenc.idcomunmanestado(0);
                self.cboidcomunmanlocalid("");
                self.vi_aipinsenc.idcomunmanlocalid(0);
                self.llenarcboidcmnmanpais(self.vi_aipinsenc.idcomunmancont(), self.vi_aipinsenc.idcomunmanpais());
            } else {
                //si el programa desencadeno el evento

            }
        }

        this.obtener_estados = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                self.cboidcomunmanestado("");
                self.vi_aipinsenc.idcomunmanestado(0);
                self.cboidcomunmanlocalid("");
                self.vi_aipinsenc.idcomunmanlocalid(0);
                self.llenarcboidcmnmanestad(self.vi_aipinsenc.idcomunmanpais(), self.vi_aipinsenc.idcomunmanestado());
            } else {
                //si el programa desencadeno el evento

            }
        }

        this.obtener_localidades = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                self.cboidcomunmanlocalid("");
                self.vi_aipinsenc.idcomunmanlocalid(0);
                self.llenarcboidcmnmanlocalid(self.vi_aipinsenc.idcomunmanestado(), self.vi_aipinsenc.idcomunmanlocalid());
            } else {
                //si el programa desencadeno el evento

            }
        }

        self.llenarcboidcmnmancontin = function () {
            postajaxjsonbasico("/Comun/ObtenerComboContinente/", '{}', function (lista_comunmancont) {
                self.cboidcomunmancont(lista_comunmancont);
            });
        }
        self.llenarcboidcmnmanpais = function (idcomunmancont) {
            postajaxjsonbasico("/Comun/ObtenerComboPais/?idcomunmancont=" + idcomunmancont, '{}', function (lista_cmnmanpais) {
                self.cboidcomunmanpais(lista_cmnmanpais);
            });
        }
        self.llenarcboidcmnmanestad = function (idcomunmanpais, idcomunmanestado) {
            postajaxjsonbasico("/Comun/ObtenerComboEstado/?idcomunmanpais=" + idcomunmanpais, '{}', function (lista_comunmanestado) {
                self.cboidcomunmanestado(lista_comunmanestado);
                self.vi_aipinsenc.idcomunmanestado(idcomunmanestado);
            });
        }
        self.llenarcboidcmnmanlocalid = function (idcomunmanestado, idcomunmanlocalid) {
            postajaxjsonbasico("/Comun/ObtenerComboLocalidad/?idcomunmanestado=" + idcomunmanestado, '{}', function (lista_comunmanlocalid) {
                self.cboidcomunmanlocalid(lista_comunmanlocalid);
                self.vi_aipinsenc.idcomunmanlocalid(idcomunmanlocalid);
            });
        }

        self.llenarcbotipoinsenc = function (itipoinsenc) {

            var xconcepto = "ITIPOINSENC";
            postajaxjsonbasico("/Comun/ObtenerValores/?xconcepto=" + xconcepto, '{}', function (lista_comunconfvalor) {
                self.cboitipoinsenc(lista_comunconfvalor);
                self.vi_aipinsenc.itipoinsenc(itipoinsenc);
                if (itipoinsenc != "")
                {
                    self.llenarcbotipomotiv(self.vi_aipinsenc.idaipinsmotiv(),itipoinsenc);
                }
            });
        }

        self.llenarcbotipomotiv = function (idaipinsmotiv, itipoinsenc) {

            if (itipoinsenc != "" || itipoinsenc != undefined)
            {
                postajaxjsonbasico("/Inspeccion/ObtenerComboMotivosActivosPorTipoIns/?itipoinsmotiv=" + itipoinsenc, '{}', function (lista_aipinsmotiv) {
                    self.cboitipomotiv(lista_aipinsmotiv);
                    self.vi_aipinsenc.idaipinsmotiv(idaipinsmotiv);
                });
            }
        }

        this.cargar_motivo = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                self.llenarcbotipomotiv(self.vi_aipinsenc.idaipinsmotiv(), self.vi_aipinsenc.itipoinsenc());

                //para cambiar el titulo de el campo de la tabla de siniestro para que diga cotizacion o siniestro
                if (self.vi_aipinsenc.itipoinsenc() == "SINIESTRO") {
                    self.xtitulosinicotiz("# Siniestro");
                }
                else { self.xtitulosinicotiz("# Cotización"); }                
            } else {
                //si el programa desencadeno el evento

            }
        }




        self.cargar = function (vi_aipinsenc) {            
            ko.mapping.fromJS(vi_aipinsenc, {}, self.vi_aipinsenc);            
            self.llenarcboidcmnmanestad(9, vi_aipinsenc.idcomunmanestado);
            self.llenarcboidcmnmanlocalid(vi_aipinsenc.idcomunmanestado, vi_aipinsenc.idcomunmanlocalid);
            self.llenarcbotipoinsenc(vi_aipinsenc.itipoinsenc);
            self.llenarcbosucursal(vi_aipinsenc.idsegmanorgperit);
            //self.llenarcbotipomotiv(vi_aipinsenc.idaipinsmotiv, vi_aipinsenc.itipoinsenc);

            var date = new Date(self.vi_aipinsenc.fejecactivperi());
            var dia = date.getDate();
            var mes = parseInt(date.getMonth()) + 1;
            var anio = date.getFullYear();
            //self.fecha(dia + "/" + mes + "/" + anio);
            var hora = date.getHours();
            var minutos = date.getMinutes();
            if (minutos < 10)
                minutos = "0" + minutos;
            //self.llenarcombohoras(hora, horaFin);
            var dateFin = new Date(self.vi_aipinsenc.ffinejecactivperi());
            var diaRegreso = dateFin.getDate();
            var mesRegreso = parseInt(dateFin.getMonth()) + 1;
            var anioRegreso = dateFin.getFullYear();
            //self.fechaFin(diaRegreso + "/" + mesRegreso + "/" + anioRegreso);
            var horaFin = dateFin.getHours();
            var minutosFin = dateFin.getMinutes();
            if (minutosFin < 10)
                minutosFin = "0" + minutosFin;
            //self.llenarcombominutos(minutos, minutosFin);
            self.visibleDivModificar(true);
        }


        self.formatearfecha = function (fejecucion) {


            self.fecha(fejecucion);
            self.fechaFin(fejecucion);
        }

        self.eliminar = function (obj) {
            var botones = [
                {
                    addClass: 'btn btn-primary', text: 'Si', onClick: function ($noty) {
                        $noty.close();
                        postajaxjsonbasico("/Agenda/EliminarPeritajePorId/?idaipinsenc=" + self.vi_aipinsenc.idaipinsenc(), "", function (respopera) {
                            var tipo = "MOV"
                            if (respopera.irespuesta == 1) {
                                $('#dlg_agendaperitajeagregar1').dialog("close");
                                $('#dlg_agendaperitajesmodal1').dialog("close");
                                var tipo = "MOV";
                                vmagendaperitajesgrid1.buscar_peritajes(tipo, self.fechaEjecucion());
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
            self.vi_aipinsenc.xsercarrinsenc(self.vi_aipinsenc.xsercarrinsenc().trim());
            if (self.vi_aipinsenc.xsercarrinsenc().length > 17)
            {
                generar_noty("El serial de la carroceria debe contener máximo 17 carácteres(digitos)", "error");
                return false;
            }

            self.vi_aipinsenc.idsegmanusuperit(self.idsegmanusuperit());
            self.vi_aipinsenc.idaipinsintext(self.idaipinsintext());


            self.fullFecha = ko.computed(function () {
                return self.fecha() + " " + self.hora() + ":" + self.minutos() + ":00";
            }, this);
            self.fullFechaFin = ko.computed(function () {
                return self.fechaFin() + " " + self.horaFin() + ":" + self.minutosFin() + ":00";
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
                    generar_noty_auto("La hora de fin debe ser mayor que la hora de inicio", "warning");
                    return false;
                }
                // si es 0 es porque ambas fechas fechas son iguales
                //si es 1 es porque la fecha fin es menor a la fecha inicio
            }
            self.vi_aipinsenc.fejecactivperi(self.fullFecha());
            self.vi_aipinsenc.ffinejecactivperi(self.fullFechaFin());
            self.vi_aipinsenc.ialcanactivperi("PUBLICA");
            self.vi_aipinsenc.errors = ko.validation.group(self.vi_aipinsenc);
            self.vi_aipinsenc.xcedsidoinsenc(self.vi_aipinsenc.xcedpropinsenc());

            if (self.vi_aipinsenc.errors().length > 0) {
                generar_noty_modal($('#lista_err_agendaperitajesagregar1').html(), "warning");
                return false;
            }

            if (self.vi_aipinsenc.idaipinsmotiv() == 0 || self.vi_aipinsenc.idaipinsmotiv() == undefined) {
                generar_noty_modal("El motivo de la inspección es requerido", "warning");
                return false;
            }

            //alert(self.aipactivperi.xcidaseactivperi());
            //alert(self.aipactivperi.xsermotactivperi());
            //alert(self.aipactivperi.xsercarractivperi());
            //alert(self.aipactivperi.xplacaactivperi());
            //alert(self.aipactivperi.xnomcliactivperi());
            postajaxjsonbasico("/Agenda/AgregarInspeccionActividad/", ko.toJSON(self.vi_aipinsenc), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto("La actividad se ha agendado satisfactoriamente.", "success");
                    postajaxjsonbasico("/Inspeccion/ObtenerInspeccionPorId/", "{'idaipinsenc':'" + respopera.id + "'}", function (vi_aipinsenc) {
                        self.cargar(vi_aipinsenc);
                        self.visibleDivModificar(true);
                        self.visibleDivAgregar(false);
                    });
                    var tipo = "MOV";
                    vmagendaperitajesgrid1.buscar_peritajes(tipo, self.fechaEjecucion());
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            });

        }

        self.modificar = function () {
            self.vi_aipinsenc.xsercarrinsenc(self.vi_aipinsenc.xsercarrinsenc().trim());
            if (self.vi_aipinsenc.xsercarrinsenc().length > 17 ) {
                generar_noty("El serial de la carroceria debe contener máximo 17 carácteres(digitos)", "error");
                return false;
            }

            self.vi_aipinsenc.ialcanactivperi("PUBLICA");
            self.fullFecha = ko.computed(function () {
                return self.fecha() + " " + self.hora() + ":" + self.minutos() + ":00";
            }, this);
            self.fullFechaFin = ko.computed(function () {
                return self.fechaFin() + " " + self.horaFin() + ":" + self.minutosFin() + ":00";
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
                    generar_noty_auto("La hora de fin debe ser mayor que la hora de inicio", "warning");
                    return false;
                }
            }
            self.vi_aipinsenc.xcedsidoinsenc(self.vi_aipinsenc.xcedpropinsenc());
            self.vi_aipinsenc.fejecactivperi(self.fullFecha());
            self.vi_aipinsenc.ffinejecactivperi(self.fullFechaFin());
            postajaxjsonbasico("/Agenda/ModificarInspeccionYActividad/", ko.toJSON(self.vi_aipinsenc), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto("La actividad se ha modificado satisfactoriamente.", "success");
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
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

    vmagendaperitajeagregar1.prototype.toJSON = function () {
        var copia = ko.toJS(this);
        delete copia.combohoras;
        delete copia.combominutos;
        delete copia.cboidcomunmancont;
        delete copia.cboidcomunmanpais;
        delete copia.cboidcomunmanestado;
        delete copia.cboidcomunmanlocalid;
        delete copia.cboitipoinsenc;
        delete copia.cbosucursal;
        delete copia.cboitipomotiv;
        return copia;
    }
</script>
