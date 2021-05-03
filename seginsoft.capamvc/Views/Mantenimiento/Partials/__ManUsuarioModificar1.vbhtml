  <div data-bind="with: vi_segmanusu">
        <ul id="lista_vi_segmanusumodificar_err" style="display: none;">
            <li data-bind="validationMessage: xnombres" style="color: red;"></li>
            <li data-bind="validationMessage: xapellidos" style="color: red;"></li>
            <li data-bind="validationMessage: xsexo" style="color: red;"></li>
            <li data-bind="validationMessage: xnacionalidad" style="color: red;"></li>
            <li data-bind="validationMessage: xtelfoficina1" style="color: red;"></li>
            <li data-bind="validationMessage: xtelfoficina2" style="color: red;"></li> 
            <li data-bind="validationMessage: xtelfmovil1" style="color: red;"></li>           
            <li data-bind="validationMessage: xtelfmovil2" style="color: red;"></li>
            <li data-bind="validationMessage: xcorreoelectronico1" style="color: red;"></li>
            <li data-bind="validationMessage: xcorreoelectronico2" style="color: red;"></li>
            <li data-bind="validationMessage: idcomunmancont" style="color: red;"></li>
            <li data-bind="validationMessage: idcomunmanpais" style="color: red;"></li>
            <li data-bind="validationMessage: idcomunmanestado" style="color: red;"></li>
            <li data-bind="validationMessage: idcomunmanlocalid" style="color: red;"></li>
            <li data-bind="validationMessage: xdireccion" style="color: red;"></li>
            <li data-bind="validationMessage: idsegmanorg" style="color: red;"></li>
            <li data-bind="validationMessage: idsegmandep" style="color: red;"></li>
            <li data-bind="validationMessage: idsegmancarg" style="color: red;"></li>
        </ul>
    </div>

    <fieldset class="ui-corner-all">
        <legend>DATOS PERSONALES</legend>
        <p>
            <input type="button" value="Modificar" data-bind="click: actualizar" />
        </p>
        <div data-bind="with: vi_segmanusu">

        <div class="form-row">
            <div class="form-field-header">
                <label>C&eacute;dula<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input placeholder="Cedula Ej: 12345678" type="text" data-bind="value: xcedula" />
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Nombres<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input placeholder="Nombre" type="text" data-bind="value: xnombres" />
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Apellidos<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input placeholder="Apellidos" type="text" data-bind="value: xapellidos" />
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Fecha de nacimiento</label>
            </div>
            <div class="form-field-content">
                <input placeholder="Ej: 01/01/1900" class="date-field" type="text" data-bind="datevalue: fnacimiento" />
            </div>
        </div>

       <div class="form-row">
            <div class="form-field-header">
                <label>Sexo<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <select data-bind="options: $root.combosexo, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: xsexo"></select>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Nacionalidad<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <select data-bind="options: $root.combonacionalidad, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: xnacionalidad"></select>
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
                <label>Tel&eacute;fono movil 1</label>
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
                <select data-bind="options: $root.combocontinente, optionsText: 'xnombrecont', optionsValue: 'idcomunmancont', value: idcomunmancont"></select>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Pa&iacute;s<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <select data-bind=" options: $root.combopais, optionsText: 'xnombrepais', optionsValue: 'idcomunmanpais', value: idcomunmanpais"></select>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Estado<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <select data-bind="options: $root.comboestado, optionsText: 'xnombreestado', optionsValue: 'idcomunmanestado', value: idcomunmanestado"></select>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Localidad<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <select data-bind="options: $root.combolocalidad, optionsText: 'xnombrelocalid', optionsValue: 'idcomunmanlocalid', value: idcomunmanlocalid"></select>
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
                <select data-bind="options: $root.comboorganizacion, optionsText: 'xnombrecomercial', optionsValue: 'idcomunmanempr', value: idsegmanorg"></select>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Departamento donde trabaja <span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <select data-bind="options: $root.combodepartamento, optionsText: 'xnombredep', optionsValue: 'idsegmandep', value: idsegmandep"></select>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Cargo que desempeña<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <select data-bind="options: $root.combocargo, optionsText: 'xnombrecarg', optionsValue: 'idsegmancarg', value: idsegmancarg"></select>
            </div>
        </div>
    </div>

        <p>
            <input type="button" value="Modificar" data-bind="click: actualizar" />
        </p>
    </fieldset>

<script type="text/javascript">

  

    function vmmanusuariomodificar1() {
        var self = this;

        self.vi_segmanusu = new vi_segmanusu(true);
        self.combosexo = ko.observableArray();
        self.combonacionalidad = ko.observableArray();
        self.combocontinente = ko.observableArray();
        self.combopais = ko.observableArray();
        self.comboestado = ko.observableArray();
        self.combolocalidad = ko.observableArray();
        self.comboorganizacion = ko.observableArray();
        self.combodepartamento = ko.observableArray();
        self.combocargo = ko.observableArray();

        self.cargar = function (vi_segmanusu) {
            ko.mapping.fromJS(vi_segmanusu, {}, self.vi_segmanusu);

            self.llenarcombosexo(vi_segmanusu.xsexo);
            self.llenarcombonacionalidad(vi_segmanusu.xnacionalidad);
            self.llenarcombocontinente(vi_segmanusu.idcomunmancont);
            self.llenarcombopais(vi_segmanusu.idcomunmanpais);
            self.llenarcomboestado(vi_segmanusu.idcomunmanestado);
            self.llenarcombolocalidad(vi_segmanusu.idcomunmanlocalid)
            self.llenarcomboorganizacion(vi_segmanusu.idsegmanorg);
            self.llenarcombodepartamento(vi_segmanusu.idsegmandep);
            self.llenarcombocargo(vi_segmanusu.idsegmancarg);
        }

        //evento de cambio en los combos para realizar la llamada a la funcion para cargar el combo que dependiente
        //self.vi_segmanusu.idcomunmancont.subscribe(function (idcomunmancont) {
        //    var idcomunmancont = 1
        //    self.llenarcombopais(idcomunmancont)
        //});

        //self.vi_segmanusu.idcomunmanpais.subscribe(function (idcomunmanpais) {
        //    var idcomunmanpais = 1
        //    self.llenarcomboestado(idcomunmanpais)
        //});

        //self.vi_segmanusu.idcomunmanestado.subscribe(function (idcomunmanestado) {
        //    self.llenarcombolocalidad(idcomunmanestado)
        //});

        //self.vi_segmanusu.idsegmanorg.subscribe(function (idsegmanorg) {
        //    self.llenarcombodepartamento(idsegmanorg)
        //});

        //self.vi_segmanusu.idsegmandep.subscribe(function (idsegmandep) {
        //    self.llenarcombocargo(idsegmandep)
        //});


        //funciones para cargar cada combo con sus llamadas ajax
        self.llenarcombosexo = function (xsexo) {
            var xconcepto = "SEXO";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.combosexo(lista_comunconfvalor);
                self.vi_segmanusu.xsexo(xsexo);
            })
        }

        self.llenarcombonacionalidad = function (xnacionalidad) {
            var xconcepto = "NACIONALIDAD";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.combonacionalidad(lista_comunconfvalor);
                
                self.vi_segmanusu.xnacionalidad(xnacionalidad);
            })
        }

        self.llenarcombocontinente = function (idcomunmancont) {
            postajaxjsonbasico("/Comun/ObtenerContienentes/", "", function (lista_comunmancont) {
                self.combocontinente(lista_comunmancont);                
                self.vi_segmanusu.idcomunmancont(idcomunmancont);
            })
        }

        self.llenarcombopais = function (idcomunmanpais) {            
            postajaxjsonbasico("/Comun/ObtenerComboPais/", "{}", function (lista_combopais) {                
                self.combopais(lista_combopais);
                self.vi_segmanusu.idcomunmanpais(idcomunmanpais);
            });
        }
        self.llenarcomboestado = function (idcomunmanestado) {
            postajaxjsonbasico("/Comun/ObtenerComboEstado/", {}, function (lista_comboestado) {
               self.comboestado(lista_comboestado);
                self.vi_segmanusu.idcomunmanestado(idcomunmanestado);
            });
        }
        self.llenarcombolocalidad = function (idcomunmanlocalid) {
            postajaxjsonbasico("/Comun/ObtenerComboLocalidad/", {}, function (lista_combolocalidad) {
                self.combolocalidad(lista_combolocalidad);
                self.vi_segmanusu.idcomunmanlocalid(idcomunmanlocalid);
            });
        }
        self.llenarcomboorganizacion = function (idsegmanorg) {
            postajaxjsonbasico("/Comun/ObtenerComboComercial/", {}, function (lista_comboorganizacion) {
                self.comboorganizacion(lista_comboorganizacion);
                self.vi_segmanusu.idsegmanorg(idsegmanorg);
            });
        }
        self.llenarcombodepartamento = function (idsegmandep) {
            postajaxjsonbasico("/Comun/ObtenerComboNombreDep/", {}, function (lista_combodep) {
                self.combodepartamento(lista_combodep);
                self.vi_segmanusu.idsegmandep(idsegmandep);
            });
        }
        self.llenarcombocargo = function (idsegmancarg) {
            postajaxjsonbasico("/Comun/ObtenerComboNombreCarg/", {}, function (lista_combocarg) {
                self.combocargo(lista_combocarg);
                self.vi_segmanusu.idsegmancarg(idsegmancarg);
            });
        }
        
  
        self.actualizar = function () {
            self.vi_segmanusu.errors = ko.validation.group(self.vi_segmanusu);
            if (self.vi_segmanusu.errors().length > 0) {
                $(".noty_message").click();
                generar_noty($('#lista_vi_segmanusumodificar_err').html(), "warning");
                return false;
            }

            postajaxjsonbasico("/Mantenimiento/ModificarUsuario/", ko.toJSON(self.vi_segmanusu), function (respopera) {
               
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    vmmanusuariobuscar1.buscar();
                } else {
                    $(".noty_message").click();
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }

    }

</script>
