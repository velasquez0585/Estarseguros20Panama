<fieldset id="fs_recuperar_contrasena">
    <legend>Recuperar contrase&ntilde;a</legend>

    <ul id="lista_err_recuperar_contrasena" style="display:none;">
        <li data-bind="validationMessage: xcorreo" style="color:red;"></li>
    </ul>

    <div class="editor-label">
        <label>Correo electr&oacute;nico</label>
    </div>
    <div class="editor-field">
        <input placeholder="Ej: usuario@sigmadental.net" type="email" data-bind="value: xcorreo" />
    </div>

    <p>
        <input type="button" value="Recuperar contraseña" data-bind="click: recuperar" />
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

    var data_recuperar_contrasena = {
        xcorreo: ""
    }

    function vm_recuperar_contrasena(recuperar_contrasena) {
        var self = this;
        self.xcorreo = ko.observable(recuperar_contrasena.xcorreo).extend({
            required: {
                message: "El correo electrónico es requerido.",
                params: true
            },
            email: {
                message: "El formato de correo es invalido."
            }
        });

        self.recuperar = function () {
            self.errors = ko.validation.group(self);
            if (self.errors().length > 0) {
                generar_noty_modal($('#lista_err_recuperar_contrasena').html(), "warning");
                return false;
            }
            
            postajaxjsonbasico("/Seguridad/RecuperarContrasena/", ko.toJSON(self), function (resp) {
                if (resp.infomodel.xtitulo == 'Ok') {
                    generar_noty_auto(resp.infomodel.xmensaje, 'success');
                    ko.mapping.fromJS(resp, {}, self);
                } else {
                    generar_noty_modal(resp.infomodel.xmensaje, 'error');
                    ko.mapping.fromJS(resp, {}, self);
                }
            })
        }
    }
    ko.applyBindings(new vm_recuperar_contrasena(data_recuperar_contrasena));
</script>