<fieldset >
    <legend>Mantenimiento Modulo</legend>

<div data-bind="with: segmanmod">
    <ul id="lista_segmanappagregarmod1_err" style="display: none;">
        <li data-bind="validationMessage: xnombrecorto" style="color: red;"></li>
        <li data-bind="validationMessage: xnombrelargo" style="color: red;"></li>
        <li data-bind="validationMessage: xobjetivo" style="color: red;"></li>
    </ul>
</div>

<div data-bind="with: segmanmod">
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
        <textarea data-bind="value: xobjetivo"></textarea>
    </div>
</div>

<p>
    <input type="button" value="Agregar" data-bind="click: agregarmod" />
</p>
</fieldset>

<script type="text/javascript">

    function vmmanaplicacionesagregarmodulo1() {

        self = this;

        self.segmanmod = new segmanmod(true);

        self.limpiar = function () {
            self.segmanmod.xnombrecorto("");
            self.segmanmod.xnombrelargo("");
            self.segmanmod.xobjetivo("");
        }

        self.agregarmod = function () {
            self.segmanmod.errors = ko.validation.group(self.segmanmod);
            if (self.segmanmod.errors().length > 0) {
                $(".noty_message").click();
                generar_noty($('#lista_segmanappagregarmod1_err').html(), "warning");
                return false;
            }


            postajaxjsonbasico("/Mantenimiento/AgregarModulo/", ko.toJSON(self), function (respopera) {
                if (respopera.irespuesta == 1) {                    
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                    //vmmanappagregar1.llenarcombomodulo();

                } else {
                    $(".noty_message").click();
                    generar_noty(respopera.xmsjusuario, "error");
                }

            })
        }
    }
</script>