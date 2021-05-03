<fieldset class="fs_mini" id="fs_iniciar_sesion">
    <legend>Inicio de sesi&oacute;n</legend>

    <ul id="lista_err_iniciar_sesion" style="display:none;">
        <li data-bind="validationMessage: xnombreusuario" style="color:red;"></li>
        <li data-bind="validationMessage: xcontrasena" style="color:red;"></li>
    </ul>

    <div class="editor-label">
        <label>Correo electr&oacute;nico</label>
    </div>
    <div class="editor-field">
        <input placeholder="Ej: usuario@sigmadental.net" type="email" data-bind="value: xnombreusuario" />
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


