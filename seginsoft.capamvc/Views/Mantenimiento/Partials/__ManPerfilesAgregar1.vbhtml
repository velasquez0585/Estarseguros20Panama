<div data-bind="with: segmanperf">
    <ul id="lista_semanperfagregar1_err" style="display: none;">
        <li data-bind="validationMessage: xabrevperf" style="color: red;"></li>
        <li data-bind="validationMessage: xnombreperf" style="color: red;"></li>
        <li data-bind="validationMessage: nnivelperf" style="color: red;"></li>
    </ul>
</div>

<fieldset class="ui-corner-all">
    <legend>Administrar Perfiles</legend>
    <div class="form-row">
        <input type="button" value="Agregar" data-bind="click: agregar" />
    </div>

    <div data-bind="with: segmanperf">
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

    <div class="form-row">
        <input type="button" value="Agregar" data-bind="click: agregar" />
    </div>
</fieldset>

<script type="text/javascript">

    function vmmanperfilesagregar1() {
        var self = this;

        self.segmanperf = new segmanperf(true);

        self.limpiar = function () {
            self.segmanperf.xabrevperf("");
            self.segmanperf.xnombreperf("");
            self.segmanperf.nnivelperf("");
        }

        self.agregar = function () {
            self.segmanperf.errors = ko.validation.group(self.segmanperf);
            if (self.segmanperf.errors().length > 0) {
                $(".noty_message").click();
                generar_noty($('#lista_semanperfagregar1_err').html(), "warning");
                return false;
            }

            postajaxjsonbasico("/Mantenimiento/AgregarPerfil/", ko.toJSON(self.segmanperf), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                    vmmanperfilesbuscar1.buscar();
                } else {
                    $(".noty_message").click();
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }

    }
</script>
