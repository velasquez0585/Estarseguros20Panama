a<fieldset style="width: 930px;">
    <legend>Inventario de restos</legend>

    <div data-bind="with: vi_aipinsenc">
        <div class="form-row">
            <fieldset style="width: 900px;">
                <legend>Datos de Cabecera</legend>
                <div class="form-row">
                   
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Nº poliza:</label>
                        </div>
                        <div class="form-field-content">

                            <input placeholder="Ej: repuesto" type="text" data-bind="value: xnumpolinsenc" />
                        </div>
                    </div>
                     <div class="form-column">
                        <div class="form-field-header">
                            <label>Fecha de la inspeccion:</label>
                        </div>
                        <div class="form-field-content">
                            <input  class="date-field"  type="text" data-bind=" datevalue: fcreainsenc" />
                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>N Siniestro</label>
                        </div>
                        <div class="form-field-content">
                            <input placeholder="Ej: repuesto" type="text" data-bind="value: xnumsininsenc" />
                        </div>

                    </div>
                </div>

            </fieldset>
        </div>
    </div>
    <div data-bind="with: vi_aipinsrest">
        <div class="form-row">

            <fieldset style="width: 900px;">
                <legend>Datos del vehiculo</legend>
                <div data-bind="with: $root.aipmanveh">
                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Sucursal:</label>
                        </div>
                        <div class="form-field-content">
                            @*<select data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: $root.idsegmanorgperit, disable: $root.disabled_sucursal"></select>*@
                            <input placeholder="Ej: sucursal" type="text" data-bind="value: $root.vi_aipinsrest.xsucuinsrest, disable: $root.disabled_sucursal" />
                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Serial de carroceria</label>
                        </div>
                        <div class="form-field-content">
                            <input placeholder="Ej: serial" type="text" data-bind="value: xsercarrmanveh" />
                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Serial del motor:</label>
                        </div>
                        <div class="form-field-content">
                            <input type="text" data-bind="value: xsermotmanveh" />
                        </div>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Marca:</label>
                        </div>
                        <div class="form-field-content">
                            <select data-bind="options: $root.cvi_aipinsrest.combomanvehmar, optionsText: 'xnommanvehmar', optionsValue: 'idaipmanvehmar', value: idaipmanvehmar, event: { change: $root.llenar_lista_aipmanvehmod }"></select>
                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Modelo:</label>
                        </div>
                        <div class="form-field-content">

                            <select id="ddl_modelo"  data-bind="options: $root.cvi_aipinsrest.combomanvehmod, optionsText: 'xnommanvehmod', optionsValue: 'idaipmanvehmod', value: idaipmanvehmod, event: { change: $root.llenar_lista_aipmanvehver }"></select>
                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Clase</label>
                        </div>
                        <div class="form-field-content">
                            <select data-bind="options: $root.cvi_aipinsrest.comboclasemanveh, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iclasemanveh "></select>

                        </div>

                    </div>

                </div>
                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Version</label>
                        </div>
                        <div class="form-field-content">
                            <select data-bind="options: $root.cvi_aipinsrest.combomanvehver, optionsText: 'xnommanvehver', optionsValue: 'idaipmanvehver', value: idaipmanvehver"></select>
                            <input type="button"  title="Agregar versión" value="+" data-bind="click: $root.agregar_version" />
                        </div>

                    </div>
                  
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Tipo de transmision:</label>
                        </div>
                        <div class="form-field-content">
                            <div data-bind="foreach: $root.cvi_aipinsrest.combotipotransmanveh">
                               <!-- ko if: xvalorcodigo != '' -->
                                  <span style="display: inline" data-bind="text: xvalorcodigo">  </span>
                                    <input name="trans" type="radio" data-bind="value: xvalorcodigo, checked: $parent.itipotransmanveh" />
                                  <!-- /ko -->    
                              
                            </div>
                        </div>
                    </div>

                </div>
                <div class="form-row">  
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Año:</label>
                        </div>
                        <div class="form-field-content">
                            
                            <input type="text" data-bind="enterovalue: naniomanveh" />
                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Cilindros</label>
                        </div>
                        <div class="form-field-content">

                            <input type="text" data-bind="numeralvalue: ncilinmanveh" />
                        </div>

                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Cap Carga (ton)</label>
                        </div>
                        <div class="form-field-content">

                            <input placeholder="Ej: Carga" type="text" data-bind="value: xcargmanveh" />
                        </div>

                    </div>
                   
                </div>
                <div class="form-row"> <div class="form-column">
                        <div class="form-field-header">
                            <label>Capacidad</label>
                        </div>
                        <div class="form-field-content">

                            <input placeholder="Ej: Capacidad" type="text" data-bind="value: xcapmanveh" />
                        </div>

                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Color Principal:</label>
                        </div>
                        <div class="form-field-content">
                            <select data-bind="options: $root.cvi_aipinsrest.combocolormanveh, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: icolormanveh"></select>
                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Placa:</label>
                        </div>
                        <div class="form-field-content">

                            <input placeholder="Ej: placa" type="text" data-bind="value: xplacamanveh" />
                        </div>
                    </div>

                </div>
                <div class="form-row">

                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Kilometraje</label>
                        </div>
                        <div class="form-field-content">
                            <input type="text" data-bind="enterovalue: $root.vi_aipinsrest.nkiloinsrest" />
                        </div>

                    </div>
                </div>
            </div></fieldset>

            <fieldset style="width: 900px;">
                <legend>Sistemas de seguridad electronicos</legend>
              <div class="form-row" data-bind="foreach: $root.lista_aipinsrestsse">
                    <div class="form-row" data-bind="foreach: $data">
                        <div class="form-column" style="width:150px">
                        
                            <label style="display: none" data-bind="value: idaipinsrest"></label>
                            <label style="display: none" data-bind="value: idaipmanvehsse"></label>
                             <span style="display: inline"  data-bind="text: xnommanvehsse"  > </span>
                        </div >
                         <div class="form-column"  style="width:80px"> 
                              <input type="checkbox" data-bind="checked: iexisinsrestsse" />
                        </div>
                    </div>
                </div>
            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Sistemas de seguridad mecanicos</legend>
                <div class="form-row" data-bind="foreach: $root.lista_aipinsrestssm">
                    <div class="form-column" data-bind="foreach: $data">
                      <div class="form-column" style="width:150px">
                        
                            <label style="display: none" data-bind="value: idaipinsrest"></label>
                            <label style="display: none" data-bind="value: idaipmanvehssm"></label>
                             <span style="display: inline"  data-bind="text: xnommanvehssm"  > </span>
                        
                           </div >
                         <div class="form-column"  style="width:80px">   <input type="checkbox" data-bind="checked: iexisinsrestssm" />
                        </div>
                    </div>
                </div>  

            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Ubicacion</legend>
                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Estado </label>
                        </div>
                        <div class="form-field-content">
                            <select data-bind="options: $root.cvi_aipinsrest.combounmanestado, optionsText: 'xnombreestado', optionsValue: 'idcomunmanestado', value: idcomunmanestado, event: { change: $root.llenarcombolocalidad }"></select>
                        </div>

                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Ciudad</label>
                        </div>
                        <div class="form-field-content">
                            <select data-bind="options: $root.cvi_aipinsrest.combounmanlocalid, optionsText: 'xnombrelocalid', optionsValue: 'idcomunmanlocalid', value: idcomunmanlocalid"></select>
                        </div>

                    </div>
                </div>
                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Direccion </label>
                        </div>
                        <div class="form-field-content">

                            <textarea style="width:850px" data-bind="value: xdirinsrest"></textarea>
                        </div>

                    </div>
                </div>
            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Repuestos</legend>
                <div class="form-row"  >
                     <div class="form-column" style="width:15%">Repuesto</div>
                     <div class="form-column" style="width:3%" >SI</div>
                     <div class="form-column" style="width:3%">B</div>
                     <div class="form-column"style="width:3%"  >R</div>
                     <div class="form-column" style="width:3%">M</div>
                     <div class="form-column" style="width:15%">  </div> 
                     <div class="form-column" style="width:2%"> </div>
                     <div class="form-column" style="width:15%">Repuesto</div>
                     <div class="form-column" style="width:3%"  >SI</div>
                     <div class="form-column" style="width:3%">B</div>
                     <div class="form-column" style="width:3%" >R</div>
                     <div class="form-column" style="width:3%">M</div>
                     <div class="form-column" style="width:15%">  </div>
                </div>
                <div class="form-row" data-bind="foreach: $root.lista_aipinsrestrepuest">
                    <div class="form-row" data-bind="foreach: $data">
                          <div class="form-column" style="width:15%">
                            <label style="display: none" data-bind="value: idaipinsrestrepuest"></label>
                            <span style="display: inline" data-bind="text: xnommanrepu"></span>
                            </div > <div class="form-column"  style="width:15%"> 
                             <input type="checkbox"    data-bind="checked: iexisinsrestrepuest " />
                             <input type="radio"   value="true"   data-bind="checked: IsBCheckbox, attr: { 'name': 'myprefix_' + idaipmanrepu() }, click: $root.clickR1" />
                            <input type="radio"   value="true"   data-bind="checked: IsRCheckbox, attr: {  'name': 'myprefix_' + idaipmanrepu() }, click: $root.clickR2" />
                            <input type="radio"  value="true"  data-bind="checked: IsMCheckbox, attr: {  'name': 'myprefix_' + idaipmanrepu() }, click: $root.clickR3" />
                             </div > <div class="form-column"  style="width:15%"> <input type="text" style="width:90%" data-bind="value: xdescinsrestrepuest" />
                        </div>
                    </div>
                </div>

            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Detalles de daños</legend>

                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Observaciones</label>
                        </div>
                        <div class="form-field-content">
                            <textarea style="width:850px" data-bind="value: xdescinsrest"></textarea> 
                        </div>
                    </div>
                </div>
            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Avaluo de restos</legend>

                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Suma asegurada:</label>
                        </div>
                        <div class="form-field-content">
                            <input type="text" data-bind="numeralvalue: msumaseginsrest" />

                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>75% suma asegurada</label>
                        </div>
                        <div class="form-field-content">
                            <input type="text" data-bind="numeralvalue: msumaseg75insrest" />

                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>valor inma</label>
                        </div>
                        <div class="form-field-content">
                            <input type="text" data-bind="numeralvalue: mvalinminsrest" />

                        </div>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Monto de daño:</label>
                        </div>
                        <div class="form-field-content">
                            <input type="text" data-bind="numeralvalue: mdanoinsrest" />

                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Monto de avaluo:</label>
                        </div>
                        <div class="form-field-content">
                            <input type="text" data-bind="numeralvalue: mavalinsrest" />

                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Nombre del taller:</label>
                        </div>
                        <div class="form-field-content">
                            <input type="text" data-bind="value: xnomtalinsrest" />

                        </div>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Nombre del perito:</label>
                        </div>
                        <div class="form-field-content">
                            <input type="text" data-bind="value: xnomperinsrest" />

                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Nombre del jefe de peritos:</label>
                        </div>
                        <div class="form-field-content">
                            <input type="text" data-bind="value: xnomjefperinsrest" />

                        </div>
                    </div>

                </div>
            </fieldset>
        </div>
    </div>
     <div class="row" data-bind="visible: perito">
        <div class="grid-top-button">
            <input type="button" value="Guardar" data-bind="click: guardar" />
        </div>
        <div class="grid-top-button">
            <input type="button" value="Enviar" data-bind="click: enviar" />
        </div>

    </div>
     <div class="row" data-bind="visible: auditor">
        <div class="grid-top-button">
            <input type="button" value="Guardar" data-bind="click: guardar" />
        </div>
        <div class="grid-top-button">
            <input type="button" value="Imprimir" data-bind="click: imprimir" />
        </div>
        <div class="grid-top-button">
            <input type="button" value="Rechazar" data-bind="click: rechazar" />
        </div>
        <div class="grid-top-button">
            <input type="button" value="Cancelar" data-bind="click: cancelar" />
        </div>
        <div class="grid-top-button">
            <input type="button" value="Aceptar" data-bind="click: aceptar" />
        </div>

    </div>
     <div class="row" data-bind="visible: aprobada">
      
        <div class="grid-top-button">
            <input type="button" value="Imprimir" data-bind="click: imprimir" />
        </div>
         

    </div>
</fieldset>


<script type="text/javascript">
    function vmInsRestGuardar1(perito, auditor, aprobada) {
        var self = this;
        self.vi_aipinsrest = new vi_aipinsrest(false);
        self.cvi_aipinsrest = new vi_aipinsrest(false);
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.pagvi_aipinsrest = new paginacion(1, 10, 0, "it.idaipinsrest", "DESC");
        self.lista_vi_aipinsrest = ko.observableArray();
        self.aipmanveh = new aipmanveh(false);

        self.lista_aipinsrestrepuest = ko.observableArray();
        self.lista_aipinsrestsse = ko.observableArray();
        self.lista_aipinsrestssm = ko.observableArray();
        self.alista_aipinsrestrepuest = ko.observableArray();
        self.alista_aipinsrestsse = ko.observableArray();
        self.alista_aipinsrestssm = ko.observableArray();
        self.sel_idaipinsrest = ko.observable(0);
         self.perito = ko.observable(perito);
        self.auditor = ko.observable(auditor);
        self.aprobada = ko.observable(aprobada);

        self.cbosucursal = ko.observableArray();
        self.idsegmanorgperit = ko.observable(0);
        self.disabled_sucursal = ko.observable(true);

        self.llenarcbosucursal = function (idsegmanorg) {
            postajaxjsonbasico("/comun/ObtenerComboOrganizacion/", '{}', function (lista_vi_combosegmanorg) {
                //self.cbosucursal(lista_vi_combosegmanorg);                
                //self.idsegmanorgperit(idsegmanorg);                
                for (i = 0; i < lista_vi_combosegmanorg.length; i++) {
                    if (lista_vi_combosegmanorg[i].idsegmanorg == idsegmanorg) {
                        self.vi_aipinsrest.xsucuinsrest(lista_vi_combosegmanorg[i].xnombrecomercial);
                    }

                }
            });
        }

        self.clickR1 = function (obj) {
            //$('input[name=myprefix_' + obj.idaipmanrepu() +']').attr('checked', true);
            //$("#myprefix_" + obj.idaipmanrepu()).prop("checked", true)
            obj.ibueinssusrepuest(true);
            obj.ireginssusrepuest(false);
            obj.imalinssusrepuest(false);
            //alert("ibueinssusrepuest: " + obj.ibueinssusrepuest() + " ireginssusrepuest: " + obj.ireginssusrepuest() + " imalinssusrepuest: " + obj.imalinssusrepuest());
            return true;

        }
        self.clickR2 = function (obj) {
            obj.ibueinssusrepuest(false);
            obj.ireginssusrepuest(true);
            obj.imalinssusrepuest(false);
            //alert("ibueinssusrepuest: " + obj.ibueinssusrepuest() + " ireginssusrepuest: " + obj.ireginssusrepuest() + " imalinssusrepuest: " + obj.imalinssusrepuest());
            return true;
        }
        self.clickR3 = function (obj) {
            obj.ibueinssusrepuest(false);
            obj.ireginssusrepuest(false);
            obj.imalinssusrepuest(true);
            //alert("ibueinssusrepuest: " + obj.ibueinssusrepuest() + " ireginssusrepuest: " + obj.ireginssusrepuest() + " imalinssusrepuest: " + obj.imalinssusrepuest());
            return true;
        }

        self.llenarcombocolor = function (obj) {
            var xconcepto = "ICOLORMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.cvi_aipinsrest.combocolormanveh(lista_comunconfvalor);

                self.aipmanveh.icolormanveh(obj.icolormanveh());
            })
        }
        self.llenarcombotipotransmision = function () {
            var xconcepto = "ITIPOTRANSMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.cvi_aipinsrest.combotipotransmanveh(lista_comunconfvalor);
            })
        }
        self.llenarcomboclase = function (obj) {
            var xconcepto = "ICLASEMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.cvi_aipinsrest.comboclasemanveh(lista_comunconfvalor);

                self.aipmanveh.iclasemanveh(obj.iclasemanveh());
            })
        }
       
        self.llenarcombotraccion = function () {
            var xconcepto = "ITRACCMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.cvi_aipinsrest.combotraccmanveh(lista_comunconfvalor);
            })
        }

       
        self.llenar_lista_aipmanvehmar = function (obj) {
            postajaxjsonbasico("/Mantenimiento/ObtenerMarcasActivas/", "{}", function (lista_aipmanvehmar) {
                self.cvi_aipinsrest.combomanvehmar(lista_aipmanvehmar);
                self.aipmanveh.idaipmanvehmar(obj.idaipmanvehmar());
                if (typeof self.aipmanveh.idaipmanvehmar() !== "undefined") {
                    if (self.aipmanveh.idaipmanvehmar() != 0) {
                        self.llenar_lista_aipmanvehmod(obj);
                    }
                }
            })
        }
        self.llenar_lista_aipmanvehmod = function (obj) {
            if (typeof obj.idaipmanvehmar() !== "undefined") {
                if (obj.idaipmanvehmar() != 0) {
                    postajaxjsonbasico("/Mantenimiento/ObtenerModelosActivosPorMarca/", "{'idaipmanvehmar': '" + obj.idaipmanvehmar() + "'}", function (lista_aipmanvehmod) {
                        self.cvi_aipinsrest.combomanvehmod(lista_aipmanvehmod);
                        self.aipmanveh.idaipmanvehmod(obj.idaipmanvehmod());
                        if (typeof obj.idaipmanvehver() !== "undefined") {
                            if (obj.idaipmanvehver() != 0) {
                                self.llenar_lista_aipmanvehver(obj);
                            }
                        }
                    })
                }
            }

        }
        self.llenar_lista_aipmanvehver = function (obj) {
            if (typeof obj.idaipmanvehmod() !== "undefined") {
                postajaxjsonbasico("/Mantenimiento/ObtenerVersionesActivasPorModelo/", "{'idaipmanvehmod': '" + obj.idaipmanvehmod() + "'}", function (lista_aipmanvehver) {
                    self.cvi_aipinsrest.combomanvehver(lista_aipmanvehver);
                    self.aipmanveh.idaipmanvehver(obj.idaipmanvehver());
                })
            }
        } 
   
        self.llenar_lista_aipinsrestrepuest = function (idaipinsrest) {
            postajaxjsonbasico("/Inspeccion/ObtenerRepuestosRestosEstado/", "{'idaipinsrest': '" + idaipinsrest + "'}", function (lista_aipinsrestrepuest) {
                ko.mapping.fromJS(lista_aipinsrestrepuest, {}, self.alista_aipinsrestrepuest);
                ko.utils.arrayForEach(self.alista_aipinsrestrepuest(), function (feature) {
                    feature.IsBCheckbox = ko.computed({
                        read: function () {
                            return feature.ibueinsrestrepuest() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.ibueinsrestrepuest(true)
                            else feature.ibueinsrestrepuest(false)
                        }
                    });
                    feature.IsRCheckbox = ko.computed({
                        read: function () {
                            return feature.ireginsrestrepuest() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.ireginsrestrepuest(true)
                            else feature.ibueinsrestrepuest(false)
                        }
                    });
                    feature.IsMCheckbox = ko.computed({
                        read: function () {
                            return feature.imalinsrestrepuest() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.imalinsrestrepuest(true)
                            else feature.imalinsrestrepuest(false)
                        }
                    });
                });

              
                self.lista_aipinsrestrepuest(self.groupObsArray(2, self.alista_aipinsrestrepuest()));
                 
            })
        }

        self.llenar_lista_aipinsrestsse = function (idaipinsrest) {
            postajaxjsonbasico("/Inspeccion/ObtenerSseRestos/", "{'idaipinsrest': '" + idaipinsrest + "'}", function (lista_aipinsrestsse) {
                ko.mapping.fromJS(lista_aipinsrestsse, {}, self.alista_aipinsrestsse);
                self.lista_aipinsrestsse(self.groupObsArray(3, self.alista_aipinsrestsse())); 
            })
        }
        self.llenar_lista_aipinsrestssm = function (idaipinsrest) {
            postajaxjsonbasico("/Inspeccion/ObtenerSsmRestos/", "{'idaipinsrest': '" + idaipinsrest + "'}", function (lista_aipinsrestssm) {
                ko.mapping.fromJS(lista_aipinsrestssm, {}, self.alista_aipinsrestssm);
                self.lista_aipinsrestssm(self.groupObsArray(3, self.alista_aipinsrestssm())); 
            })
        }

        self.limpiar = function () {
           
        }
        self.buscar = function (tipo) {
            self.vi_aipinsrest.errors = ko.validation.group(self.vi_aipinsrest);
            if (self.vi_aipinsrest.errors().length > 0) {
                generar_noty($('#lista_err_citapacbuscar1').html(), "warning");
                return false;
            }

            if (tipo != 'MOV') {
                self.pagvi_aipinsrest.npagactual(1);
            }

            postajaxjsonbasico("/Mantenimiento/ObtenerRepuestos/", ko.toJSON(self), function (respvi_aipinsrestpaglist) {
                self.lista_vi_aipinsrest("");
                ko.mapping.fromJS(respvi_aipinsrestpaglist, {}, self);
            })
        }
        self.llenarcombolocalidad = function (obj,event) {
            if (event.originalEvent) {
                postajaxjsonbasico("/Comun/ObtenerLocalidadesPorEstado/", "{'idcomunmanestado': '" + obj.idcomunmanestado() + "'}", function (lista_comunmanlocalid) {
                    self.cvi_aipinsrest.combounmanlocalid(lista_comunmanlocalid); 
                })
            }
        }
        self.allenarcombolocalidad = function (comunestado, comunloca) {
            postajaxjsonbasico("/Comun/ObtenerLocalidadesPorEstado/", "{'idcomunmanestado': '" + comunestado + "'}", function (lista_comunmanlocalid) {
                    self.cvi_aipinsrest.combounmanlocalid(lista_comunmanlocalid);
                    self.vi_aipinsrest.idcomunmanlocalid(comunloca);
                })
        }
        self.llenarcomboestado = function (comunestado, comunloca) {
            var idcomunmanpais = 9;
            postajaxjsonbasico("/Comun/ObtenerEstadosPorPais/", "{'idcomunmanpais': '" + idcomunmanpais + "'}", function (lista_comunmanestado) {
                self.cvi_aipinsrest.combounmanestado(lista_comunmanestado);
                self.vi_aipinsrest.idcomunmanestado(comunestado);
                if (comunestado != 0) {
                      
                    self.allenarcombolocalidad(comunestado, comunloca);
                    }
            })
        }
        self.cargarVehiculo = function (idaipmanveh) {
            var auxaipmanveh = new aipmanveh(false);
            postajaxjsonbasico("/Mantenimiento/ObtenerVehiculoPorId/", "{'idaipmanveh': '" + idaipmanveh + "'}", function (aipmanveh) {
                ko.mapping.fromJS(aipmanveh, {}, auxaipmanveh);
                ko.mapping.fromJS(aipmanveh, {}, self.aipmanveh);
                self.llenar_lista_aipmanvehmar(auxaipmanveh);

                self.llenarcombotipotransmision(auxaipmanveh);
                self.llenarcomboclase(auxaipmanveh);
                self.llenarcombotraccion(auxaipmanveh);
                self.llenarcombocolor(auxaipmanveh);
            })
        }
        self.cargarInspeccion = function (idaipinsenc) {
            postajaxjsonbasico("/Inspeccion/ObtenerInspeccionRestosPorIdInsEnc/", "{'idaipinsenc': '" + idaipinsenc + "'}", function (vi_aipinsrest) {
                ko.mapping.fromJS(vi_aipinsrest, {}, self.vi_aipinsrest);
                self.cargarVehiculo(self.vi_aipinsrest.idaipmanveh());

                self.llenarcomboestado(vi_aipinsrest.idcomunmanestado, vi_aipinsrest.idcomunmanlocalid);
               
                self.llenar_lista_aipinsrestrepuest(self.vi_aipinsrest.idaipinsrest()); 
                self.llenar_lista_aipinsrestsse(self.vi_aipinsrest.idaipinsrest());
                self.llenar_lista_aipinsrestssm(self.vi_aipinsrest.idaipinsrest());
                self.llenarcbosucursal(self.vi_aipinsenc.idsegmanorgperit());
               
            
            })
        }

        self.iniciar = function (vi_aipinsenc) {
            ko.mapping.fromJS(vi_aipinsenc, {}, self.vi_aipinsenc);
            self.cargarInspeccion(vi_aipinsenc.idaipinsenc());
            //self.llenarcbosucursal(vi_aipinsenc.idsegmanorgperit());
           //self.buscar();
        }
        //self.vi_aipinsrest.idaipmanvehmar.subscribe(function (idaipmanvehmar) {
        //    if (idaipmanvehmar!=undefined)
        //    self.llenar_lista_aipmanvehmod(idaipmanvehmar);
        //});
        //self.vi_aipinsrest.idaipmanvehmod.subscribe(function (idaipmanvehmod) {
        //    if (idaipmanvehmod != undefined)
        //        self.llenar_lista_aipmanvehver(idaipmanvehmod);
        //});


        self.ir_ver = function () {
            $("#tab_citapac").tabs("option", "active", 1);
        }

        self.ir_agregar = function () {
            $("#tab_citapac").tabs("option", "active", 2);
        }

        self.ir_modificar = function () {
            $("#tab_citapac").tabs("option", "active", 3);
        }


        self.cargar_ver = function (obj) {
            self.sel_idaipinsrest(obj.idaipinsrest());
            postajaxjsonbasico("/Cita/ObtenerVicitapacxid/", "{'idaipinsrest':'" + obj.idaipinsrest() + "'}", function (aipinsrest) {
                vmcitapacver1.cargar(aipinsrest);
                //vmcitapacmodificar1.cargar(aipinsrest);
                //vmcitapaccerrar1.cargar(aipinsrest);

            })
        }

        self.cargar_editar = function (obj) {
            self.sel_idaipinsrest(obj.idaipinsrest());
            postajaxjsonbasico("/Cita/ObtenerVicitapacxid/", "{'idaipinsrest':'" + obj.idaipinsrest() + "'}", function (aipinsrest) {
                //vmcitapacver1.cargar(aipinsrest);
                vmcitapacmodificar1.cargar(aipinsrest);
                //vmcitapaccerrar1.cargar(aipinsrest);

            })
        }

        self.cargar_cerrar = function (obj) {
            self.sel_idaipinsrest(obj.idaipinsrest());
            postajaxjsonbasico("/Cita/ObtenerVicitapacxid/", "{'idaipinsrest':'" + obj.idaipinsrest() + "'}", function (aipinsrest) {
                //vmcitapacver1.cargar(aipinsrest);
                //vmcitapacmodificar1.cargar(aipinsrest);
                vmcitapaccerrar1.cargar(aipinsrest);

            })
        }



        self.ir_primero = function () {
            var npagactual = self.pagvi_aipinsrest.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipinsrest.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_aipinsrest.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipinsrest.npagactual(self.pagvi_aipinsrest.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_aipinsrest.npagactual() != self.pagvi_aipinsrest.npagcantidad()) {
                self.pagvi_aipinsrest.npagactual(self.pagvi_aipinsrest.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_aipinsrest.npagactual() != self.pagvi_aipinsrest.npagcantidad()) {
                self.pagvi_aipinsrest.npagactual(self.pagvi_aipinsrest.npagcantidad);
                self.buscar('MOV');
            }
        }

        self.groupObsArray = function (itemsPerGroup, observableArray) {
            return ko.computed(function () {
                var obsArrData = observableArray;
                var groupedItems = [];
                var aGroup = [];
                for (var i = 0; i < obsArrData.length; i++) {
                    if ((i % itemsPerGroup === 0)&&(i!=0)) {
                        groupedItems.push(aGroup);
                        aGroup = [];
                    }
                    aGroup.push(obsArrData[i])

                }
                return groupedItems;
            });
        }
        self.guardar = function () {
             
            var error = false;
            postajaxjsonbasico("/Inspeccion/GuardarInspeccionRestos/", ko.toJSON(self.vi_aipinsrest), function (respopera) {
                if (respopera.irespuesta == 1) {
                     self.limpiar();
                   
                    postajaxjsonbasico("/Inspeccion/ActualizarMantVehiculo/", ko.toJSON(self.aipmanveh), function (respopera) {
                        if (respopera.irespuesta == 1) {
                             self.limpiar();
                        } else {
                            error = true; 
                        }
                    })
                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionRestSsm/", ko.toJSON(self.alista_aipinsrestssm), function (respopera) {
                        if (respopera.irespuesta == 1) {
                             self.limpiar();
                        } else {
                            error = true;
                            generar_noty(respopera.xmsjusuario, "error");
                        }
                    })
                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionRestSse/", ko.toJSON(self.alista_aipinsrestsse), function (respopera) {
                        if (respopera.irespuesta == 1) {
                              self.limpiar();
                        } else {
                            error = true;
                            generar_noty(respopera.xmsjusuario, "error");
                        }
                    })
                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionRestRepuEstadGen/", ko.toJSON(self.alista_aipinsrestrepuest), function (respopera) {
                        if (respopera.irespuesta == 1) {
                            self.limpiar(); 
                        } else {
                            error = true;
                            generar_noty(respopera.xmsjusuario, "error");
                        }
                    })
                   
                } else {
                    error = true;
                    generar_noty(respopera.xmsjusuario, "error");
                }
                if (!error) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                }
            })
        }
        self.enviar = function () {
            postajaxjsonbasico("/Inspeccion/ProcesarInspeccionRestos/", ko.toJSON(self.vi_aipinsrest), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    $("#dlg_InsRestGuardar1").dialog("close");
                    self.limpiar();
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }

        self.imprimir = function () {
            $.fileDownload('/Inspeccion/ImprimirInspeccionRestos/?idaipinsrest=' + self.vi_aipinsrest.idaipinsrest(), {
                preparingMessageHtml: "Estamos descargando su archivo, por favor espere...",
                failMessageHtml: "Ha ocurrido un error descargando su archivo, por favor intente mas tarde."
            });
        }
        self.rechazar = function () {
            postajaxjsonbasico("/Inspeccion/RechazarInspeccionRestos/", ko.toJSON(self.vi_aipinsrest), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                    $("#dlg_InsRestGuardar1").dialog("close");
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }
        self.cancelar = function () {
            postajaxjsonbasico("/Inspeccion/CancelarInspeccionRestos/", ko.toJSON(self.vi_aipinsrest), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                    $("#dlg_InsRestGuardar1").dialog("close");
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }
        self.aceptar = function () {
            postajaxjsonbasico("/Inspeccion/AceptarInspeccionRestos/", ko.toJSON(self.vi_aipinsrest), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                    $("#dlg_InsRestGuardar1").dialog("close");
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }

        self.agregar_version = function () {

            if (self.aipmanveh.idaipmanvehmar() != 0 && self.aipmanveh.idaipmanvehmod() != 0) {

                vmmanversionnuevo1.cargar();
                $("#dlg_manversionnuevo1").dialog("open");
                $("#dlg_manversionnuevo1").dialog({
                    close: function (event, ui) {
                        self.actualizar_lista_aipmanvehver(self.aipmanveh.idaipmanvehmod());
                    }
                });

            } else {
                generar_noty_modal("Disculpe, Debe seleccionar la marca y modelo para agregar versiones.", "information");
            }
        }

        self.actualizar_lista_aipmanvehver = function (idaipmanvehmod) {
            if (idaipmanvehmod !== "undefined") {
                postajaxjsonbasico("/Mantenimiento/ObtenerVersionesActivasPorModelo/", "{'idaipmanvehmod': '" + idaipmanvehmod + "'}", function (lista_aipmanvehver) {
                    self.cvi_aipinsrest.combomanvehver(lista_aipmanvehver);
                })
            }
        }

    }
</script>
