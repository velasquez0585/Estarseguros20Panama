

<fieldset class="form-area" data-bind="with: vi_segmanusu">
    <legend>Datos Personales</legend>

    <ul id="lista_err_segusuarioseditar1" style="display: none;">
        <li data-bind="validationMessage: xcedula" style="color: red;"></li>
        <li data-bind="validationMessage: xnombres" style="color: red;"></li>
        <li data-bind="validationMessage: xapellidos" style="color: red;"></li>
        <li data-bind="validationMessage: xtelfmovil1" style="color: red;"></li>
        <li data-bind="validationMessage: xcorreoelectronico1" style="color: red;"></li>
        @*<li data-bind="validationMessage: xtwitter1" style="color: red;"></li>
        <li data-bind="validationMessage: xfacebook1" style="color: red;"></li>*@
        <li data-bind="validationMessage: xcontrasena" style="color: red;"></li>  
    </ul>

    <div class="form-row">
        <input type="button" value="Actualizar" data-bind="click: $root.actualizar" />
    </div>



     <div class="form-row">
        <div class="form-field-header">
            Tipo de usuario
        </div>
        <div class="form-field-content">
            <select data-bind="options: $root.cboidsegmanperf, optionsText: 'xnombreperf', optionsValue: 'idsegmanperf', value: $root.idsegmanperf, event: { change: $root.evento_perfil }"></select>
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Ced.Ident/R.U.C./ Cód. Perito
        </div>
        <div class="form-field-content">
            <input type="text" placeholder="13363913" data-bind="value: xcedula" />
        </div>
    </div>
    <div class="form-row">
        <div class="form-field-header">
            Nombre
        </div>
        <div class="form-field-content">
            <input type="text" placeholder="DAVID" data-bind="value: xnombres" />
        </div>
    </div>
    <div class="form-row">
        <div class="form-field-header">
            Apellido
        </div>
        <div class="form-field-content">
            <input type="text" placeholder="GUZMAN" data-bind="value: xapellidos" />
        </div>
    </div>
    <div class="form-row">
        <div class="form-field-header">
            Fecha de Nacimiento
        </div>
        <div class="form-field-content">
            <input type="text" placeholder="17/11/1983" class="date-field" data-bind="datevalue: fnacimiento"/>
        </div>
    </div>
    <div class="form-row">
        <div class="form-field-header">
            Sexo
        </div>
        <div class="form-field-content">
            <select data-bind="options: $root.cboxsexo, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: xsexo"></select>
        </div>
    </div>
    <div class="form-row">
        <div class="form-field-header">
            Nacionalidad
        </div>
        <div class="form-field-content">
            <select data-bind="options: $root.cboxnacionalidad, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: xnacionalidad"></select>
        </div>
    </div>
</fieldset>

<fieldset class="form-area" data-bind="with: vi_segmanusu">
    <legend>Datos de Contacto</legend>

    <div class="form-row">
        <div class="form-field-header">
            Telefono Movil
        </div>
        <div class="form-field-content">
            <input type="text" placeholder="0424-3446578" data-bind="value: xtelfmovil1" />
        </div>
    </div>
    <div class="form-row">
        <div class="form-field-header">
            Correo Electronico
        </div>
        <div class="form-field-content">
            <input type="text" placeholder="usuario@sitfx.com" data-bind="value: xcorreoelectronico1" />
        </div>
    </div>
    @*<div class="form-row">
        <div class="form-field-header">
            Twitter
        </div>
        <div class="form-field-content">
            <input type="text" placeholder="http://www.twitter.com/usuario" data-bind="value: xtwitter1" />
        </div>
    </div>*@
    @*<div class="form-row">
        <div class="form-field-header">
            Facebook
        </div>
        <div class="form-field-content">
            <input type="text" placeholder="http://www.facebook.com/usuario" data-bind="value: xfacebook1" />
        </div>
    </div>*@
</fieldset>

<fieldset class="form-area" data-bind="with: vi_segmanusu">
    <legend>Datos de Direccion</legend>

    @*<div class="form-row">
        <div class="form-field-header">
            Continente
        </div>
        <div class="form-field-content">
            <select data-bind="options: $root.cboidcomunmancont, optionsText: 'xnombrecont', optionsValue: 'idcomunmancont', value: idcomunmancont, event: { change: $root.obtener_paises }"></select>
        </div>
    </div>
    <div class="form-row">
        <div class="form-field-header">
            Pais
        </div>
        <div class="form-field-content">
            <select  data-bind="options: $root.cboidcomunmanpais, optionsText: 'xnombrepais', optionsValue: 'idcomunmanpais', value: idcomunmanpais, event: { change: $root.obtener_estados }"></select>
        </div>
    </div>*@
    <div class="form-row">
        <div class="form-field-header">
            Estado
        </div>
        <div class="form-field-content">
            <select  data-bind="options: $root.cboidcomunmanestado, optionsText: 'xnombreestado', optionsValue: 'idcomunmanestado', value: idcomunmanestado, event: { change: $root.obtener_localidades }"></select>
        </div>
    </div>
    <div class="form-row">
        <div class="form-field-header">
            Localidad
        </div>
        <div class="form-field-content">
            <select  data-bind="options: $root.cboidcomunmanlocalid, optionsText: 'xnombrelocalid', optionsValue: 'idcomunmanlocalid', value: idcomunmanlocalid"></select>
        </div>
    </div>
   @* <div class="form-row">
        <div class="form-field-header">
            Direccion
        </div>
        <div class="form-field-content">
            <textarea cols="50" rows="4" data-bind="value: xdireccion"></textarea>
        </div>
    </div>*@
</fieldset>

<fieldset class="form-area" data-bind="with: vi_segmanusu">
    <legend>Datos Laborales</legend>

    <div class="form-row">
        <div class="form-field-header">
            Sucursal
        </div>
        <div class="form-field-content">
            <select data-bind="options: $root.cboidsegmanorg, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: idsegmanorg"></select>
        </div>
    </div>
    <div class="form-row">
        <div class="form-field-header">
            Departamento
        </div>
        <div class="form-field-content">
            <select  data-bind="options: $root.cboidsegmandep, optionsText: 'xnombredep', optionsValue: 'idsegmandep', value: idsegmandep"></select>
        </div>
    </div>
    <div class="form-row">
        <div class="form-field-header">
            Cargo
        </div>
        <div class="form-field-content">
            <select  data-bind="options: $root.cboidsegmancarg, optionsText: 'xnombrecarg', optionsValue: 'idsegmancarg', value: idsegmancarg"></select>
        </div>
    </div>
</fieldset>

<fieldset class="form-area" data-bind="with: vi_segmanusu">
    <legend>Datos de Usuario</legend>

    <div class="form-row">
        <div class="form-field-header">
            Contraseña
        </div>
        <div class="form-field-content">
            <input type="password" data-bind="value: xcontrasena" />
        </div>
    </div>

    <div class="form-column" data-bind="visible: $root.visibleperito">
        <div class="form-field-header">
            <label>IMEI:</label>
            <div class="form-field-content">
                <input type="text" placeholder="Código IMEI" data-bind="value: $root.xcodimmandisp" />
            </div>
        </div>
    </div>

    <div class="form-row">
        <input type="button" value="Actualizar" data-bind="click: $root.actualizar" />
    </div>
</fieldset>

<script type="text/javascript">
    function vmsegusuarioseditar1() {
        var self = this;
        //en este viewmodel no excluyo los combos porque la unica vez que utilizo aqui la funcion ko.toJSON() lo hago enviando
        //directamente vi_segmanusu y no el viewmodel completo, entonces por ahora no hizo falta excluirlos.
        //este formulario "editar" lo trabajo con la vista en lugar de la entidad porque tiene muchos datos que deben ser 
        //almacenados en tablas distintas, como datos personales, datos de contacto, datos de direccion, pero normalmente se 
        //deberia utilizar la entidad
        self.vi_segmanusu = new vi_segmanusu(true);
        self.cboxsexo = ko.observableArray();
        self.cboxnacionalidad = ko.observableArray();
        self.cboidcomunmancont = ko.observableArray();
        self.cboidcomunmanpais = ko.observableArray();
        self.cboidcomunmanestado = ko.observableArray();
        self.cboidcomunmanlocalid = ko.observableArray();
        self.cboidsegmanorg = ko.observableArray();
        self.cboidsegmandep = ko.observableArray();
        self.cboidsegmancarg = ko.observableArray();
        self.cboidsegmanperf = ko.observableArray();
        self.xcodimmandisp = ko.observable("");
        self.visibleperito = ko.observable(false);
        self.idsegmanperf = ko.observable(0);

        self.cargar = function (vi_segmanusu) {
            ko.mapping.fromJS(vi_segmanusu, {}, self.vi_segmanusu);
            
            self.llenarcboxsexo(vi_segmanusu.xsexo);
            self.llenarcboxnacionalidad(vi_segmanusu.xnacionalidad);
            self.llenarcboidcmnmancontin(vi_segmanusu.idcomunmancont);
            self.llenarcboidcmnmanpais(vi_segmanusu.idcomunmancont, vi_segmanusu.idcomunmanpais);
            self.llenarcboidcmnmanestad(vi_segmanusu.idcomunmanpais, vi_segmanusu.idcomunmanestado);
            self.llenarcboidcmnmanlocalid(vi_segmanusu.idcomunmanestado, vi_segmanusu.idcomunmanlocalid);
            self.llenarcboidsegmanorg(vi_segmanusu.idsegmanorg);
            self.llenarcboidsegmandep(vi_segmanusu.idsegmandep);
            self.llenarcboidsegmancarg(vi_segmanusu.idsegmancarg);
            self.obternerDatosUsuario(vi_segmanusu.idsegmanusu);
        }

        self.obternerDatosUsuario = function (idsegmanusu) {            
            postajaxjsonbasico("/Seguridad/Obtenervi_segusudetperf2PorIdsegmanusu/?idsegmanusu=" + idsegmanusu, "", function (vi_segusudetperf2) {
                if (vi_segusudetperf2 != null)
                {                    
                    self.cargar_perfiles(vi_segusudetperf2.idsegmanperf);
                    if ((vi_segusudetperf2.idsegmanperf == 5 || vi_segusudetperf2.idsegmanperf == 6 || vi_segusudetperf2.idsegmanperf == 7 || vi_segusudetperf2.idsegmanperf == 8)) {
                        self.visibleperito(true);
                        self.obtenerCodigoPerito(idsegmanusu);
                    } else {
                        self.visibleperito(false);
                    }
                }
            });
        }

        self.cargar_perfiles = function (idsegmanperf) {
            postajaxjsonbasico("/Seguridad/ObtenerPerfilesPorAplicacion/", {}, function (lista_vi_segappperf) {
                self.cboidsegmanperf(lista_vi_segappperf);
                self.idsegmanperf(idsegmanperf);
            });
        }

        self.obtenerCodigoPerito = function (idsegmanusu) {
            postajaxjsonbasico("/Mantenimiento/ObtenerCodigoImei/", "{'idsegmanusu': " + idsegmanusu + "}", function (xcodimmandisp) {
                self.xcodimmandisp(xcodimmandisp);
            });
        }

        this.obtener_paises = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                self.cboidcomunmanpais("");
                self.vi_segmanusu.idcomunmanpais(0);
                self.cboidcomunmanestado("");
                self.vi_segmanusu.idcomunmanestado(0);
                self.cboidcomunmanlocalid("");
                self.vi_segmanusu.idcomunmanlocalid(0);
                self.llenarcboidcmnmanpais(self.vi_segmanusu.idcomunmancont(), self.vi_segmanusu.idcomunmanpais());
            } else {
                //si el programa desencadeno el evento

            }
        }

        this.obtener_estados = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                self.cboidcomunmanestado("");
                self.vi_segmanusu.idcomunmanestado(0);
                self.cboidcomunmanlocalid("");
                self.vi_segmanusu.idcomunmanlocalid(0);
                self.llenarcboidcmnmanestad(self.vi_segmanusu.idcomunmanpais(), self.vi_segmanusu.idcomunmanestado());
            } else {
                //si el programa desencadeno el evento

            }
        }

        this.obtener_localidades = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                self.cboidcomunmanlocalid("");
                self.vi_segmanusu.idcomunmanlocalid(0);
                self.llenarcboidcmnmanlocalid(self.vi_segmanusu.idcomunmanestado(), self.vi_segmanusu.idcomunmanlocalid());
            } else {
                //si el programa desencadeno el evento

            }
        }

        this.evento_perfil = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                //si no es perito se oculta el imei
                if ((self.idsegmanperf() == 5 || self.idsegmanperf() == 6 || self.idsegmanperf() == 7 || self.idsegmanperf() == 7)) {
                    self.visibleperito(true);
                } else {
                    self.visibleperito(false);
                }
            } else {
                //si el programa desencadeno el evento

            }
        }

        self.llenarcboxsexo = function (xsexo) {
            var xconcepto = "SEXO";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_cmnmanvalor) {
                self.cboxsexo(lista_cmnmanvalor);
                self.vi_segmanusu.xsexo(xsexo);
            });
        }
        self.llenarcboxnacionalidad = function (xnacionalidad) {
            var xconcepto = "NACIONALIDAD";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_cmnmanvalor) {
                self.cboxnacionalidad(lista_cmnmanvalor);
                self.vi_segmanusu.xnacionalidad(xnacionalidad);
            });
        }
        self.llenarcboidcmnmancontin = function (idcomunmancont) {
            postajaxjsonbasico("/Comun/ObtenerComboContinente/", '{}', function (lista_comunmancont) {
                self.cboidcomunmancont(lista_comunmancont);
                self.vi_segmanusu.idcomunmancont(idcomunmancont);
            });
        }
        self.llenarcboidcmnmanpais = function (idcomunmancont, idcomunmanpais) {
            postajaxjsonbasico("/Comun/ObtenerComboPais/?idcomunmancont=" + idcomunmancont, '{}', function (lista_cmnmanpais) {
                self.cboidcomunmanpais(lista_cmnmanpais);
                self.vi_segmanusu.idcomunmanpais(idcomunmanpais);
            });
        }
        self.llenarcboidcmnmanestad = function (idcomunmanpais, idcomunmanestado) {
            postajaxjsonbasico("/Comun/ObtenerComboEstado/?idcomunmanpais=" + idcomunmanpais, '{}', function (lista_comunmanestado) {
                self.cboidcomunmanestado(lista_comunmanestado);
                self.vi_segmanusu.idcomunmanestado(idcomunmanestado);
            });
        }
        self.llenarcboidcmnmanlocalid = function (idcomunmanestado, idcomunmanlocalid) {
            postajaxjsonbasico("/Comun/ObtenerComboLocalidad/?idcomunmanestado=" + idcomunmanestado, '{}', function (lista_comunmanlocalid) {
                self.cboidcomunmanlocalid(lista_comunmanlocalid);
                self.vi_segmanusu.idcomunmanlocalid(idcomunmanlocalid);
            });
        }
        self.llenarcboidsegmanorg = function (idsegmanorg) {
            postajaxjsonbasico("/Seguridad/ObtenerComboOrganizacion/", '{}', function (lista_comunmanempr) {
                self.cboidsegmanorg(lista_comunmanempr);
                self.vi_segmanusu.idsegmanorg(idsegmanorg);
            });
        }
        self.llenarcboidsegmandep = function (idsegmandep) {
            postajaxjsonbasico("/Seguridad/ObtenerComboDepartamento/", '{}', function (lista_segmandep) {
                self.cboidsegmandep(lista_segmandep);
                self.vi_segmanusu.idsegmandep(idsegmandep);
            });
        }
        self.llenarcboidsegmancarg = function (idsegmancarg) {
            postajaxjsonbasico("/Seguridad/ObtenerComboCargo/", '{}', function (lista_segmancarg) {
                self.cboidsegmancarg(lista_segmancarg);
                self.vi_segmanusu.idsegmancarg(idsegmancarg);
            });
        }

        self.actualizar = function () {
            //como el mismo usuario es el correo hago esta asignacion antes de aplicar la validacion
            self.vi_segmanusu.xnombreusuario(self.vi_segmanusu.xcorreoelectronico1());

            if (self.idsegmanperf() == 0) {
                generar_noty_modal("Debe seleccionar el tipo de usuario.", "warning");
                return false;
            }

            if ((self.idsegmanperf() == 5 || self.idsegmanperf() == 6 || self.idsegmanperf() == 7 || self.idsegmanperf() == 8)) {
                if (self.xcodimmandisp() == "") {
                    if ((self.idsegmanperf() == 5 || self.idsegmanperf() == 6 || self.idsegmanperf() == 7)) 
                        {generar_noty_modal("Debe ingresar el codigo IMEI del Perito.", "warning");}
                    if ((self.idsegmanperf() == 8 )) 
                        {generar_noty_modal("Debe ingresar el codigo IMEI del Intermediario.", "warning");}
                    return false;
                }
            }

            //este bloque me sirve para activar los errores que se generen de la validacion del formulario configurada en los
            //viewmodels de knockout
            self.vi_segmanusu.errors = ko.validation.group(self.vi_segmanusu);
            if (self.vi_segmanusu.errors().length > 0) {
                generar_noty_modal($('#lista_err_segusuarioseditar1').html(), "warning");
                return false;
            }

            postajaxjsonbasico("/Mantenimiento/ModificarUsuarioPorPerfil/?xcodimmandisp=" + self.xcodimmandisp() + "&idsegmanperf=" + self.idsegmanperf(), ko.toJSON(self.vi_segmanusu), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto("Los datos del usuario se han guardado con éxito.", "success");
                    
                    vmsegusuariosbuscar1.buscar();
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            });

            //postajaxjsonbasico("/Seguridad/ModificarUsuario/", ko.toJSON(self.vi_segmanusu), function (respopera) {
            //    if (respopera.irespuesta == 1) {
            //        generar_noty_auto("Se ha guardado la información satifactoriamente.", "success");
            //        vmsegusuariosbuscar1.buscar();
            //        //self.limpiar();
            //    } else {
            //        generar_noty_modal(respopera.xmsjusuario, "error");
            //    }
            //});
        }
    }
</script>



