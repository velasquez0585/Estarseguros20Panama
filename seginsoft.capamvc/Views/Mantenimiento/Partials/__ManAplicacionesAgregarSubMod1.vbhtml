<fieldset>
    <legend>Mantenimiento SubModulo</legend>

<div data-bind="with: segmansubmod">
    <ul id="lista_segmanappagregarsubmod1_err" style="display: none;">
        <li data-bind="validationMessage: xnombrecorto" style="color: red;"></li>
        <li data-bind="validationMessage: xnombrelargo" style="color: red;"></li>
        <li data-bind="validationMessage: xobjetivo" style="color: red;"></li>
    </ul>
</div>

<div data-bind="with: segmansubmod">

    <div class="editor-label">
        <label>Nombre Corto<span class="importante">(*)</span></label>
    </div>
    <div class="editor-field">
        <input type="text" data-bind="value: xnombrecorto" />
    </div>

    <div class="editor-label">
        <label>Nombre Largo<span class="importante">(*)</span></label>
    </div>
    <div class="editor-field">
        <input type="text" data-bind="value: xnombrelargo" />
    </div>

    <div class="editor-label">
        <label>Objetivo<span class="importante">(*)</span></label>
    </div>
    <div class="editor-field">
        <input type="text" data-bind="value: xobjetivo" />
    </div>

</div>

<p>
    <input type="button" value="Agregar" data-bind="click: agregar" />
</p>

</fieldset>

<script type="text/javascript">

    function vmaplicacionesagregarsubmodulo1() {
        var self = this;

        self.segmansubmod = new segmansubmod(true);

        self.limpiar = function () {
            self.segmansubmod.xnombrecorto("");
            self.segmansubmod.xnombrelargo("");
            self.segmansubmod.xobjetivo("");
        }

        self.agregar = function () {
            self.segmansubmod.errors = ko.validation.group(self.segmansubmod);
            if (self.segmansubmod.errors().length > 0) {
                $(".noty_message").click();
                generar_noty($('#lista_segmanappagregarsubmod1_err').html(), "warning");
                return false;
            }

            postajaxjsonbasico("/Mantenimiento/AgregarSubModulo/", ko.toJSON(self), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                    //vmmanappagregar1.llenarcombosubmodulo();                    
                } else {
                    $(".noty_message").click();
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }
    }

</script>