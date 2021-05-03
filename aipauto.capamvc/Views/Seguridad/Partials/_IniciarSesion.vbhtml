<fieldset id="fs_iniciar_sesion">
    <legend>Inicio de sesi&oacute;n</legend>

    <ul id="lista_err_iniciar_sesion" style="display:none;">
        <li data-bind="validationMessage: xnombreusuario" style="color:red;"></li>
        <li data-bind="validationMessage: xcontrasena" style="color:red;"></li>
    </ul>

    <div class="editor-label">
        <label>Correo electr&oacute;nico</label>
    </div>
    <div class="editor-field">
        <input placeholder="Ej: usuario@sitfx.com" type="text" data-bind="value: xnombreusuario" />
    </div>

    <div class="editor-label">
        <label>Contrase&ntilde;a</label>
    </div>
    <div class="editor-field">
        <input type="password" data-bind="value: xcontrasena" />
    </div>

    <p>
        <input type="button" value="Comprobar identidad" data-bind="click: comprobar_identidad" />
    </p>
</fieldset>

<script type="text/javascript">
    ko.validation.configure({
        registerExtenders: true,
        messagesOnModified: false,
        insertMessages: false,
        parseInputAttributes: true,
        messageTemplate: null
    });

    var data_credenciales = {
        xnombreusuario: "",
        xcontrasena: ""
    }

    function vm_credenciales(credenciales) {
        var self = this;
        self.xnombreusuario = ko.observable(credenciales.xnombreusuario).extend({
            required: {
                message: "El nombre de usuario es requerido.",
                params: true
            },
            email: {
                message: "El formato de correo es invalido."
            }
        });
        self.xcontrasena = ko.observable(credenciales.xcontrasena).extend({
            required: {
                message: "La contraseña es requerida.",
                params: true
            }
        });
        
        self.comprobar_identidad = function () {
            self.errors = ko.validation.group(self);
            if (self.errors().length > 0) {
                generar_noty_modal($('#lista_err_iniciar_sesion').html(), "warning");
                return false;
            }
            
            postajaxjsonbasico("/Seguridad/IniciarSesion/", ko.toJSON(self), function (resp) {
                if (resp.infomodel.xtitulo == 'Ok') {
                    generar_noty_auto(resp.infomodel.xmensaje, "success");
                    window.location.href = '/Home/Index/';
                } else {
                    generar_noty_modal(resp.infomodel.xmensaje, "error");
                    ko.mapping.fromJS(resp, {}, self);
                }
            })
        }
    }
    ko.applyBindings(new vm_credenciales(data_credenciales));
</script>









@*ESTE EJEMPLO ES CON KNOCKOUT PURO*@
@*<fieldset id="fs_iniciar_sesion">
    <legend>Inicio de sesi&oacute;n</legend>

    <div class="editor-label">
        <label for="nombreusuario">Correo electr&oacute;nico</label>
    </div>
    <div class="editor-field">
        <input id="nombreusuario" type="email" data-bind="value: nombreusuario" />
        <span data-bind='visible: nombreusuario.hasError, text: nombreusuario.validationMessage'></span>
    </div>

    <div class="editor-label">
        <label for="contrasena">Contrase&ntilde;a</label>
    </div>
    <div class="editor-field">
        <input id="contrasena" type="password" data-bind="value: contrasena" />
        <span data-bind='visible: contrasena.hasError, text: contrasena.validationMessage'></span>
    </div>

    <p>
        <input id="comprobar_identidad" type="button" value="Comprobar identidad" data-bind="click: comprobar_identidad" />
    </p>
</fieldset>

http://jeffijoe.com/2013/06/validation-in-knockout-js/

<script type="text/javascript">
    ko.extenders.required = function (target, overrideMessage) {
        //add some sub-observables to our observable
        target.hasError = ko.observable();
        target.validationMessage = ko.observable();

        //define a function to do validation
        function validate(newValue) {
            target.hasError(newValue ? false : true);
            target.validationMessage(newValue ? "" : overrideMessage || "This field is required");
        }

        //initial validation
        validate(target());

        //validate whenever the value changes
        target.subscribe(validate);

        //return the original observable
        return target;
    };

    function vm_credenciales(nombreusuario, contrasena) {
        this.nombreusuario = ko.observable(nombreusuario).extend({ required: "El nombre de usuario es requerido." });
        this.contrasena = ko.observable(contrasena).extend({ required: "La contraseña es requerida." });

        this.comprobar_identidad = function () {
            $.ajax({
                url: "/Seguridad/IniciarSesion/",
                type: 'POST',
                data: ko.toJSON(this),
                contentType: 'application/json',
                dataType: "json",
                cache: false,
                beforeSend: function () {
                    //alert('antes de enviar');
                },
                success: function (resp) {
                    if (resp.infomodel.xtitulo == 'Ok') {
                        window.location.href = '/Home/Index/';
                    } else {
                        ko.applyBindings(resp);
                        generar_noty(resp.infomodel.xmensaje, 'error');
                    }
                },
                complete: function () {
                    //alert('envio completado');
                },
                error: function () {
                    //alert('error en el envio');
                }
            });
        }
    }
    ko.applyBindings(new vm_credenciales("", ""));
</script>*@






















@*ESTE EJEMPLO ES CON KNOCKOUT VALIDATION*@
@*<script type="text/javascript">
    ko.validation.init({ messagesOnModified: false });
    ko.validation.init({ grouping: { deep: true, observable: true } });
    //ko.validation.init({ insertMessages: true });

    function vm_credenciales(nombreusuario, contrasena) {
        this.nombreusuario = ko.observable(nombreusuario).extend({
            required: {
                message: "El nombre de usuario es requerido.",
                params: true
            }
        });
        this.contrasena = ko.observable(contrasena).extend({ required: true });

        if (!this.isValid) {
            alert("No Valido");
            this.errors.showAllMessages();
            return false;
            //this.errors = ko.validation.group(this, { deep: true });
            //alert(this.showAllMessages());
            //var errors = ko.validation.group(this);
            //errors.showAllMessages();
            //alert(errors.showAllMessages());
        }

        this.comprobar_identidad = function () {
            $.ajax({
                url: "/Seguridad/IniciarSesion/",
                type: 'POST',
                data: ko.toJSON(this),
                contentType: 'application/json',
                dataType: "json",
                cache: false,
                beforeSend: function () {
                    //alert('antes de enviar');
                },
                success: function (resp) {
                    if (resp.infomodel.xtitulo == 'Ok') {
                        window.location.href = '/Home/Index/';
                    } else {
                        ko.applyBindings(resp);
                        generar_noty(resp.infomodel.xmensaje, 'error');
                    }
                },
                complete: function () {
                    //alert('envio completado');
                },
                error: function () {
                    //alert('error en el envio');
                }
            });
        }
    }
    ko.applyBindings(new vm_credenciales("", ""));
</script>*@























@*ESTE EJEMPLO ES CON HTML 5*@
@*<fieldset id="fs_iniciar_sesion">
    <legend>Inicio de sesi&oacute;n</legend>

    <div class="editor-label">
        <label for="nombreusuario">Correo electr&oacute;nico</label>
    </div>
    <div class="editor-field">
        <input id="nombreusuario" placeholder="Ej: usuario@sigmadental.net" type="email" data-bind="value: nombreusuario" title="El nombre de usuario es requerido." required />
    </div>

    <div class="editor-label">
        <label for="contrasena">Contrase&ntilde;a</label>
    </div>
    <div class="editor-field">
        <input id="contrasena" type="password" data-bind="value: contrasena" title="La contraseña es requerida." required />
    </div>

    <p>
        <input id="comprobar_identidad" type="button" value="Comprobar identidad" data-bind="click: comprobar_identidad" />
    </p>
</fieldset>

<script type="text/javascript">

    function vm_credenciales(nombreusuario, contrasena) {
        this.nombreusuario = ko.observable(nombreusuario);
        this.contrasena = ko.observable(contrasena);

        this.comprobar_identidad = function () {
            $.ajax({
                url: "/Seguridad/IniciarSesion/",
                type: 'POST',
                data: ko.toJSON(this),
                contentType: 'application/json',
                dataType: "json",
                cache: false,
                beforeSend: function () {
                    //alert('antes de enviar');
                },
                success: function (resp) {
                    if (resp.infomodel.xtitulo == 'Ok') {
                        window.location.href = '/Home/Index/';
                    } else {
                        ko.applyBindings(resp);
                        generar_noty(resp.infomodel.xmensaje, 'error');
                    }
                },
                complete: function () {
                    //alert('envio completado');
                },
                error: function () {
                    //alert('error en el envio');
                }
            });
        }
    }
    ko.applyBindings(new vm_credenciales("", ""));
</script>*@
































@*ESTE EJEMPLO ES CON UNOBSTRUSIVE AJAX*@
@*<form id="frm_iniciar_sesion">
    <fieldset id="fs_iniciar_sesion">
        <legend>Inicio de sesi&oacute;n</legend>

        <div id="val_iniciar_sesion" class="validation-summary-valid" style="display:none;" data-valmsg-summary="true"><ul><li style="display:none"></li></ul></div>

        <div class="editor-label">
            <label for="nombreusuario">Correo electr&oacute;nico</label>
        </div>
        <div class="editor-field">
            <input id="nombreusuario" type="email" data-bind="value: nombreusuario" data-val="true" data-val-required="El nombre de usuario es requerido." />
        </div>

        <div class="editor-label">
            <label for="contrasena">Contrase&ntilde;a</label>
        </div>
        <div class="editor-field">
            <input id="contrasena" type="password" data-bind="value: contrasena" />
        </div>

        <p>
            <input id="comprobar_identidad" type="submit" value="Comprobar identidad" data-bind="click: comprobar_identidad" />
        </p>
    </fieldset>
</form>

<script type="text/javascript">
    $(function () {
        $('#frm_iniciar_sesion').submit(function () {
            if ($(this).valid()) {
                //algo puede pasar si es valido
            } else {
                generar_noty($('#val_iniciar_sesion').html(), 'warning');
            }
        });
    });
</script>

<script type="text/javascript">
    function vm_credenciales(nombreusuario, contrasena) {
        this.nombreusuario = ko.observable(nombreusuario);
        this.contrasena = ko.observable(contrasena);

        this.comprobar_identidad = function () {
            $.ajax({
                url: "/Seguridad/IniciarSesion/",
                type: 'POST',
                data: ko.toJSON(this),
                contentType: 'application/json',
                dataType: "json",
                cache: false,
                beforeSend: function () {
                    //alert('antes de enviar');
                },
                success: function (resp) {
                    if (resp.infomodel.xtitulo == 'Ok') {
                        window.location.href = '/Home/Index/';
                    } else {
                        ko.applyBindings(resp);
                        generar_noty(resp.infomodel.xmensaje, 'error');
                    }
                },
                complete: function () {
                    //alert('envio completado');
                },
                error: function () {
                    //alert('error en el envio');
                }
            });
        }
    }
    ko.applyBindings(new vm_credenciales("", ""));
</script>*@





























@*ESTE EJEMPLO ES CON KNOCKOUT PURO EN ESPAÑOL*@
@*<fieldset id="fs_iniciar_sesion">
    <legend>Inicio de sesi&oacute;n</legend>

    <div class="editor-label">
        <label for="nombreusuario">Correo electr&oacute;nico</label>
    </div>
    <div class="editor-field">
        <input id="nombreusuario" type="email" placeholder="Ej: usuario@sigmadental.net" data-bind="value: nombreusuario" />
        <span data-bind='visible: nombreusuario.invalido, text: nombreusuario.mensajevalidacion'></span>
    </div>

    <div class="editor-label">
        <label for="contrasena">Contrase&ntilde;a</label>
    </div>
    <div class="editor-field">
        <input id="contrasena" type="password" data-bind="value: contrasena" />
        <span data-bind='visible: contrasena.invalido, text: contrasena.mensajevalidacion'></span>
    </div>

    <p>
        <input id="comprobar_identidad" type="button" value="Comprobar identidad" data-bind="click: comprobar_identidad" />
    </p>
</fieldset>

<script type="text/javascript">
    ko.extenders.requerido = function (campo, mensaje) {
        //extendemos dos propiedades mas para cada campo con la finalidad de almacenar su informacion de validacion
        campo.invalido = ko.observable();
        campo.mensajevalidacion = ko.observable();
        //definimos una funcion que nos indica si el campo es valido o no de acuerdo a la regla aplicada
        function validar(valor) {
            if (valor == '') {
                campo.invalido(true);
                campo.mensajevalidacion(mensaje);
            } else {
                campo.invalido(false);
                campo.mensajevalidacion('');
            }
        }
        //establecemos una validacion inicial que valide el campo al cargar
        validar(campo());
        //registramos la funcion validar para que cada vez que el valor del campo cambie se realice la validacion
        campo.subscribe(validar);
        //retornamos el campo
        return campo;
    };

    function vm_credenciales(nombreusuario, contrasena) {
        this.nombreusuario = ko.observable(nombreusuario).extend({ requerido: { mensaje: "El nombre de usuario es requerido." } });
        this.contrasena = ko.observable(contrasena).extend({ requerido: "La contraseña es requerida." });

        this.comprobar_identidad = function () {
            if (this.nombreusuario.hasError) {
                generar_noty('Modelo invalido', 'warning');
            }

            $.ajax({
                url: "/Seguridad/IniciarSesion/",
                type: 'POST',
                data: ko.toJSON(this),
                contentType: 'application/json',
                dataType: "json",
                cache: false,
                beforeSend: function () {
                    //alert('antes de enviar');
                },
                success: function (resp) {
                    if (resp.infomodel.xtitulo == 'Ok') {
                        window.location.href = '/Home/Index/';
                    } else {
                        ko.applyBindings(resp);
                        generar_noty(resp.infomodel.xmensaje, 'error');
                    }
                },
                complete: function () {
                    //alert('envio completado');
                },
                error: function () {
                    //alert('error en el envio');
                }
            });
        }
    }
    ko.applyBindings(new vm_credenciales("", ""));
</script>*@






























@*KNOCKOUT VALIDATION PRIMERA VERSION*@
@*<fieldset id="fs_iniciar_sesion">
    <legend>Inicio de sesi&oacute;n</legend>

    <ul id="lista_err_iniciar_sesion" style="display:none;">
        <li data-bind="validationMessage: nombreusuario" style="color:red;"></li>
        <li data-bind="validationMessage: contrasena" style="color:red;"></li>
    </ul>

    <div class="editor-label">
        <label for="nombreusuario">Correo electr&oacute;nico</label>
    </div>
    <div class="editor-field">
        <input id="nombreusuario" placeholder="Ej: usuario@sigmadental.net" type="email" data-bind="value: nombreusuario" />
    </div>

    <div class="editor-label">
        <label for="contrasena">Contrase&ntilde;a</label>
    </div>
    <div class="editor-field">
        <input id="contrasena" type="password" data-bind="value: contrasena" />
    </div>

    <p>
        <input id="btn_comprobar_identidad" type="button" value="Comprobar identidad" data-bind="click: comprobar_identidad" />
    </p>
</fieldset>

<script type="text/javascript">
    //viewModel.errors.showAllMessages();
    ko.validation.configure({
        registerExtenders: true,
        messagesOnModified: false,
        insertMessages: false,
        parseInputAttributes: true,
        messageTemplate: null
    });

    function vm_credenciales(nombreusuario, contrasena) {
        this.nombreusuario = ko.observable(nombreusuario).extend({
            required: {
                message: "El nombre de usuario es requerido.",
                params: true
            },
            email: {
                message: "El formato de correo es invalido."
            }
        });
        this.contrasena = ko.observable(contrasena).extend({
            required: {
                message: "La contraseña es requerida.",
                params: true
            }
        });

        this.comprobar_identidad = function () {
            this.errors = ko.validation.group(this);
            if (this.errors().length > 0) {
                generar_noty($('#lista_err_iniciar_sesion').html(), "warning");
                return false;
            }

            $.ajax({
                url: "/Seguridad/IniciarSesion/",
                type: 'POST',
                data: ko.toJSON(this),
                contentType: 'application/json',
                dataType: "json",
                cache: false,
                beforeSend: function () {
                    //alert('antes de enviar');
                },
                success: function (resp) {
                    if (resp.infomodel.xtitulo == 'Ok') {
                        generar_noty(resp.infomodel.xmensaje, "success");
                        window.location.href = '/Home/Index/';
                    } else {
                        generar_noty(resp.infomodel.xmensaje, "error");
                        ko.applyBindings(new vm_credenciales(resp.nombreusuario, resp.contrasena));
                    }
                },
                complete: function () {
                    //alert('envio completado');
                },
                error: function () {
                    //alert('error en el envio');
                }
            });
        }
    }
    ko.applyBindings(new vm_credenciales("", ""));
</script>*@