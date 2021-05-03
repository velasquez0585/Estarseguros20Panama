<fieldset class="ui-corner-all">
    <legend>DATOS PERSONALES</legend>

    <div data-bind="with: vi_segmanusu">

        <div class="form-row">
            <div class="form-field-header">
                <label>C&eacute;dula<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input placeholder="Cedula Ej: 12345678" type="text" data-bind="value: xcedula" disabled/>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Nombres<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input placeholder="Nombre" type="text" data-bind="value: xnombres" disabled/>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Apellidos<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input placeholder="Apellidos" type="text" data-bind="value: xapellidos" disabled/>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Fecha de nacimiento</label>
            </div>
            <div class="form-field-content">
                <input placeholder="Ej: 01/01/1900" class="date-field" type="text" data-bind="datevalue: fnacimiento" disabled/>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Sexo<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">               
                <input type="text" data-bind="value: xsexo" disabled/>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Nacionalidad<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input type="text" data-bind="value: xnacionalidad" disabled/>                
            </div>
        </div>

    </div>
</fieldset>

<fieldset>
    <legend>DATOS DE CONTACTO</legend>


    <div data-bind="with: vi_segmanusu">

        <div class="form-row">
            <div class="form-field-header">
                <label>Tel&eacute;fono 1<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input placeholder="Ej: 0212-4456721" type="text" data-bind="value: xtelfoficina1" />
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Tel&eacute;fono 2</label>
            </div>
            <div class="form-field-content">
                <input placeholder="Ej: 0414-4456721" type="text" data-bind="value: xtelfmovil1" />
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Correo electr&oacute;nico 1<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input placeholder="Ej: usuario@dominio.com" type="email" data-bind="value: xcorreoelectronico1" />
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Correo electr&oacute;nico 2</label>
            </div>
            <div class="form-field-content">
                <input placeholder="Ej: usuario@dominio.com" type="email" data-bind="value: xcorreoelectronico2" />
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Facebook</label>
            </div>
            <div class="form-field-content">
                <input placeholder="Facebook" type="text" data-bind="value: xfacebook1" />
            </div>
        </div>

    </div>
</fieldset>

<fieldset>
    <legend>DATOS DE UBICACI&Oacute;N</legend>
    <div data-bind="with: vi_segmanusu">

        <div class="form-row">
            <div class="form-field-header">
                <label>Continente<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input type="text" data-bind="value: xnombrecont" disabled/>                    
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Pa&iacute;s<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">              
                <input type="text" data-bind="value: xnombrepais" disabled/>      
                
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Estado<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
             
                <input type="text" data-bind="value: xnombreestado" disabled/>    
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Localidad<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input type="text" data-bind="value: xnombrelocalid" disabled/>

            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Direcci&oacute;n<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <textarea placeholder="Direccion" cols="5" rows="3" data-bind="value: xdireccion"></textarea>
            </div>
        </div>
    </div>
</fieldset>

<fieldset>
    <legend>DATOS LABORALES</legend>
    <div data-bind="with: vi_segmanusu">

        <div class="form-row">
            <div class="form-field-header">
                <label>Organizaci&oacute;n donde trabaja<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input type="text" data-bind="value: xnombrecomercial" disabled/>
                
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Departamento donde trabaja <span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input type="text" data-bind="value: xnombredep" disabled/>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Cargo que desempeña<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input type="text" data-bind="value: xnombrecarg" disabled/>                
            </div>
        </div>
    </div>
</fieldset>


<script type="text/javascript">

  
    function vmmanusuariover1() {
        var self = this;

        self.vi_segmanusu = new vi_segmanusu(false);

        self.cargar = function (vi_segmanusu) {
            ko.mapping.fromJS(vi_segmanusu, {}, self.vi_segmanusu);
        }

    }
</script>
