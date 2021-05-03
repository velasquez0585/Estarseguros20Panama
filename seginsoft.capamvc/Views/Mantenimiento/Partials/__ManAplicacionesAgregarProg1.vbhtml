<fieldset>
    <legend>Mantenimiento programas</legend>

<div data-bind="with: segmanprog">
    <ul id="lista_segmanappagregarprog1_err" style="display: none;">
        <li data-bind="validationMessage: xnombrecorto" style="color: red;"></li>
        <li data-bind="validationMessage: xnombrelargo" style="color: red;"></li>
        <li data-bind="validationMessage: xobjetivo" style="color: red;"></li>
    </ul>
</div>

<div data-bind="with: segmanprog">

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

    function vmaplicacionesagregarprog1() {
        var self = this;

        self.segmanprog = new segmanprog(true);

        self.limpiar = function () {
            self.segmanprog.xnombrecorto("");
            self.segmanprog.xnombrelargo("");
            self.segmanprog.xobjetivo("");
        }

        self.agregar = function () {
            self.segmanprog.errors = ko.validation.group(self.segmanprog);
            if (self.segmanprog.errors().length > 0) {
                $(".noty_message").click();
                generar_noty($('#lista_segmanappagregarprog1_err').html(), "warning");
                return false;
            }

            postajaxjsonbasico("/Mantenimiento/AgregarPrograma/", ko.toJSON(self), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                    //vmmanappagregar1.llenarcomboprograma();
                } else {
                    $(".noty_message").click();
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }
    }

</script>