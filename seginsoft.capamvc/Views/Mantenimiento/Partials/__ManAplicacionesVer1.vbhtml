<fieldset class="ui-corner-all">
    <legend>Ver Aplicaciones</legend>
   
    <div data-bind="with: vi_segappprog">
        <div class="editor-label">
            <label>Id</label>
        </div>
        <div class="editor-field">
            <input type="text" data-bind="value: idsegappprog" disabled/>
        </div>

        <div class="editor-label">
            <label>Nombre de la aplicación</label>
        </div>
        <div class="editor-field">
            <input type="text" data-bind="value: xnombrecortoapp" disabled/>
        </div>

        <div class="editor-label">
            <label>Nombre del Módulo</label>
        </div>
        <div class="editor-field">
            <input type="text" data-bind="value: xnombrecortomod" disabled/>
        </div>

        <div class="editor-label">
            <label>Nombre del SubMódulo</label>
        </div>
        <div class="editor-field">
            <input type="text" data-bind="value: xnombrecortosubmod" disabled/>
        </div>

        <div class="editor-label">
            <label>Nombre del Programa</label>
        </div>
        <div class="editor-field">
            <input type="text" data-bind="value: xnombrecortoprog" disabled/>
        </div>

        <div class="editor-label">
            <label>Nombre del Programa</label>
        </div>
        <div class="editor-field">
            <input type="text" style="width:500px;" data-bind="value: xdirurl" disabled/>
        </div>

    </div>
</fieldset>

<script type="text/javascript">

    function vmmanappver1() {
        var self = this;

        self.vi_segappprog = new vi_segappprog(true);

        self.cargar = function (vi_segappprog) {
            ko.mapping.fromJS(vi_segappprog, {}, self.vi_segappprog);
        }
    }
</script>
