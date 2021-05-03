<fieldset class="ui-corner-all">
    <legend>Ver Perfiles</legend>
   
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
                <label>Abreviatura</label>
            </div>
            <div class="form-field-content">
                <input type="text" data-bind="value: xabrevperf" disabled/>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Nombre de Perfil</label>
            </div>
            <div class="form-field-content">
                <input type="text" data-bind="value: xnombreperf" disabled/>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Nivel</label>
            </div>
            <div class="form-field-content">
                <input type="text" data-bind="value: nnivelperf" disabled/>
            </div>
        </div>

    </div>
</fieldset>

<script type="text/javascript">

    function vmmanperfilesver1() {
        var self = this;

        self.segmanperf = new segmanperf(true);

        self.cargar = function (segmanperf) {
            ko.mapping.fromJS(segmanperf, {}, self.segmanperf);
        }

    }


</script>