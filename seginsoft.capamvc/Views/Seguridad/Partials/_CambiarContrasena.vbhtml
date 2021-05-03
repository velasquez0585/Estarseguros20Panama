<fieldset id="fs_cambiar_contrasena">
    <legend>Cambiar contrase&ntilde;a</legend>

    <ul id="lista_err_cambiar_contrasena" style="display:none;">
        <li data-bind="validationMessage: xcontrasena_actual" style="color:red;"></li>
        <li data-bind="validationMessage: xcontrasena_nueva" style="color:red;"></li>
        <li data-bind="validationMessage: xcontrasena_confirmacion" style="color:red;"></li>
    </ul>

    <div class="editor-label">
        <label>Contrase&ntilde;a actual</label>
    </div>
    <div class="editor-field">
        <input type="password" data-bind="value: xcontrasena_actual" />
    </div>

    <div class="editor-label">
        <label>Contrase&ntilde;a nueva</label>
    </div>
    <div class="editor-field">
        <input type="password" data-bind="value: xcontrasena_nueva" />
    </div>

    <div class="editor-label">
        <label>Confirmaci&oacute;n de contrase&ntilde;a</label>
    </div>
    <div class="editor-field">
        <input type="password" data-bind="value: xcontrasena_confirmacion" />
    </div>

    <p>
        <input type="button" value="Cambiar contraseña" data-bind="click: cambiar_contrasena" />
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

    var data_cambiar_contrasena = {
        xcontrasena_actual: "",
        xcontrasena_nueva: "",
        xcontrasena_confirmacion: ""
    }

    function vm_cambiar_contrasena(cambiar_contrasena) {
        var self = this;
        self.xcontrasena_actual = ko.observable(cambiar_contrasena.xcontrasena_actual).extend({
            required: {
                message: "La contraseña actual es requerida.",
                params: true
            }
        });
        self.xcontrasena_nueva = ko.observable(cambiar_contrasena.xcontrasena_nueva).extend({
            required: {
                message: "La contraseña nueva es requerida.",
                params: true
            }
        });
        self.xcontrasena_confirmacion = ko.observable(cambiar_contrasena.xcontrasena_confirmacion).extend({
            required: {
                message: "La confirmacion de la contraseña es requerida.",
                params: true
            },
            areSame: {
                message: "La confirmacion de la contraseña debe ser igual a la nueva contraseña.",
                params: this.xcontrasena_nueva
            }
        });

        self.cambiar_contrasena = function () {
            self.errors = ko.validation.group(self);
            if (self.errors().length > 0) {
                generar_noty_modal($('#lista_err_cambiar_contrasena').html(), "warning");
                return false;
            }

            var botones = [
                {
                    addClass: 'btn btn-primary', text: 'Si', onClick: function ($noty) {
                        $noty.close();
                        postajaxjsonbasico("/Seguridad/CambiarContrasena/", ko.toJSON(self), function (resp) {
                            if (resp.infomodel.xtitulo == 'Ok') {
                                generar_noty_auto(resp.infomodel.xmensaje, 'success');
                                ko.mapping.fromJS(resp, {}, self);
                            } else {
                                generar_noty_modal(resp.infomodel.xmensaje, 'error');
                                ko.mapping.fromJS(resp, {}, self);
                            }
                        })
                    }
                },
                {
                    addClass: 'btn btn-danger', text: 'No', onClick: function ($noty) {
                        $noty.close();
                    }
                }
            ];
            generar_noty_confirmacion("¿Está seguro que desea cambiar la contraseña?", botones);
        }
    }
    ko.applyBindings(new vm_cambiar_contrasena(data_cambiar_contrasena));
</script>