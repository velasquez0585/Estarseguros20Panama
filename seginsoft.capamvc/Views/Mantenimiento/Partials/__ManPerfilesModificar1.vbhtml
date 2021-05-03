<div data-bind="with: segmanperf">
    <ul id="lista_semanperfmodificar1_err" style="display: none;">
        <li data-bind="validationMessage: xabrevperf" style="color: red;"></li>
        <li data-bind="validationMessage: xnombreperf" style="color: red;"></li>
        <li data-bind="validationMessage: nnivelperf" style="color: red;"></li>
    </ul>
</div>

<fieldset class="ui-corner-all">
    <legend>Administrar Perfiles</legend>
    <p>
        <input type="button" value="Modificar" data-bind="click: modificar" />
    </p>
    <div data-bind="with: segmanperf">

        <div class="form-row">
            <div class="form-field-header">
                <label>Id</label>
            </div>
            <div class="form-field-content">
                <input type="text" data-bind="value: idsegmanperf" disabled/>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Abreviatura<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input placeholder="Abreviatura Ej: ADM" type="text" data-bind="value: xabrevperf" />
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Nombre de Perfil<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input placeholder="Perfil Ej: Administración" type="text" data-bind="value: xnombreperf" />
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Nivel<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input type="text" data-bind="value: nnivelperf" />
            </div>
        </div>
    </div>

    <p>
        <input type="button" value="Modificar" data-bind="click: modificar" />
    </p>
</fieldset>

<script type="text/javascript">

    function vmmanperfilesmodificar1() {
        var self = this;

        self.segmanperf = new segmanperf(true);

        self.cargar = function (segmanperf) {
            ko.mapping.fromJS(segmanperf, {}, self.segmanperf);
        }

        self.modificar = function () {
            self.segmanperf.errors = ko.validation.group(self.segmanperf);
            if (self.segmanperf.errors().length > 0) {
                $(".noty_message").click();
                generar_noty($('#lista_semanperfmodificar1_err').html(), "warning");
                return false;
            }

            postajaxjsonbasico("/Mantenimiento/ModificarPerfil/", ko.toJSON(self), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    vmmanperfilesbuscar1.buscar();
                } else {
                    $(".noty_message").click();
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }


    }

</script>
