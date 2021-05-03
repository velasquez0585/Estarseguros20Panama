<fieldset style="width: 930px;">
    <legend>Formulario de suscripcion</legend>
    <div class="form-row" data-bind="with: vi_aipinsenc">
        <fieldset style="width: 900px;">
            <legend>Datos de Cabecera</legend>
            <div class="form-row">
               
                <div class="form-column">
                    <div class="form-field-header">
                        <label>Nº poliza:</label>
                    </div>
                    <div class="form-field-content">

                        <input placeholder="Ej: poliza" type="text" data-bind="value: xnumpolinsenc" />
                    </div>
                </div>
                 <div class="form-column">
                    <div class="form-field-header">
                        <label>Fecha de la inspeccion:</label>
                    </div>
                    <div class="form-field-content">
                        <input  class="date-field"  type="text" data-bind="datevalue: fcreainsenc" />
                    </div>
                </div>
                <div class="form-column">
                    <div class="form-field-header">
                        <label>Codigo</label>
                    </div>
                    <div class="form-field-content">
                        <input placeholder="Ej: Codigo" type="text" data-bind="value: xnumsininsenc" />
                    </div>

                </div>
            </div>
            <div class="form-row">
                <div class="form-column">
                    <div class="form-field-header">
                        <label>Cedula:</label>
                    </div>
                    <div class="form-field-content">
                        <input placeholder="Ej: 123456" type="text" data-bind="value: xcedpropinsenc" />
                    </div>
                </div>
                <div class="form-column" data-bind="with: $root.vi_aipinssus">
                    <div class="form-field-header">
                        <label>Nombre del intermediario:</label>
                    </div>
                    <div class="form-field-content">

                        <input placeholder="Ej: Nombre" type="text" data-bind="value: xnomintinssus" />
                    </div>
                </div>
                <div class="form-column" data-bind="with: $root.vi_aipinssus">
                    <div class="form-field-header">
                        <label>Solicitante:</label>
                    </div>
                    <div class="form-field-content">
                        <input placeholder="Ej: Solicitante" type="text" data-bind="value: xnomsolinssus" />
                    </div>

                </div>
            </div>

            <div class="form-row">
                <div class="form-column" data-bind="with: $root.cvi_aipinssus">
                    <div class="form-field-header">
                        <label>Lugar de inspeccion:</label>
                    </div>
                    <div class="form-field-content">
                        <div data-bind="foreach: comboluginssus">
                            <!-- ko if: xvalorcodigo != '' -->
                            <span style="display: inline" data-bind="text: xvalordescripcion">  </span>
                                <input name="llugar" type="radio" data-bind="attr: { value: xvalorcodigo }  , checked: $root.vi_aipinssus.iluginssus" />
                            <!-- /ko --> 
                          
                        </div>
                    </div>
                </div>
            </div>
        </fieldset>
    </div>

    <div data-bind="with: vi_aipinssus">
        <div class="form-row">

            <fieldset style="width: 900px;">
                <legend>Motivo de la inspeccion</legend>
                <div class="form-row" data-bind="foreach: $root.lista_aipinssusmotiv">
                    <div class="form-row" data-bind="foreach: $data">
                        <div class="form-column" style="width:200px">
                         
                            <span style="display: inline" data-bind="text: xnominsmotiv"></span>
                        </div>  
                         <div class="form-column"  style="width:80px"> 
                              <input type="checkbox" data-bind="checked: itilinssusmotiv" />
                        </div> 
                    </div>
                </div>
               </fieldset>
            <fieldset style="width: 900px;">
                <legend>Caracteristicas del vehiculo</legend>
                 <div data-bind="with: $root.aipmanveh">
                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Marca:</label>
                        </div>
                        <div class="form-field-content">
                            <select data-bind="options: $root.cvi_aipinssus.combomanvehmar, optionsText: 'xnommanvehmar', optionsValue: 'idaipmanvehmar', value: idaipmanvehmar, event: { change: $root.llenar_lista_aipmanvehmod }"></select>
                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Modelo:</label>
                        </div>
                        <div class="form-field-content">

                            <select id="ddl_modelo"  data-bind="options: $root.cvi_aipinssus.combomanvehmod, optionsText: 'xnommanvehmod', optionsValue: 'idaipmanvehmod', value: idaipmanvehmod, event: { change: $root.llenar_lista_aipmanvehver }"></select>
                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Version</label>
                        </div>
                        <div class="form-field-content">
                            <select data-bind="options: $root.cvi_aipinssus.combomanvehver, optionsText: 'xnommanvehver', optionsValue: 'idaipmanvehver', value: idaipmanvehver"></select>

                            <input type="button"  title="Agregar versión" value="+" data-bind="click: $root.agregar_version" />
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
                            <label>Tipo de transmision:</label>
                        </div>
                        <div class="form-field-content">  
                            <div data-bind="foreach: $root.cvi_aipinssus.combotipotransmanveh">
                                <!-- ko if: xvalorcodigo != '' -->
                                <span style="display: inline" data-bind="text: xvalorcodigo"> </span>
                                 
                                    <input name="transmision" type="radio" data-bind="attr: { value: xvalorcodigo }, checked: $parent.itipotransmanveh" />
                                  <!-- /ko -->    
                            </div>
                        </div>
                    </div>
                    </div><div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Clase</label>
                        </div>
                        <div class="form-field-content">
                            <select data-bind="options: $root.cvi_aipinssus.comboclasemanveh, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iclasemanveh"></select>

                        </div>

                    </div>
                </div>
                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Color Principal:</label>
                        </div>
                        <div class="form-field-content">
                            <select data-bind="options: $root.cvi_aipinssus.combocolormanveh, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: icolormanveh"></select>
                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Placa:</label>
                        </div>
                        <div class="form-field-content">

                            <input placeholder="Ej: repuesto" type="text" data-bind="value: xplacamanveh" />
                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Serial de carroceria</label>
                        </div>
                        <div class="form-field-content">
                            <input placeholder="Ej: repuesto" type="text" data-bind="value: xsercarrmanveh" />
                        </div>

                    </div>
                </div>
                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Serial del motor:</label>
                        </div>
                        <div class="form-field-content">
                            <input type="text" data-bind="value: xsermotmanveh" />
                        </div>
                    </div>
                    </div> 
                     <div class="form-column" data-bind="with: $root.vi_aipinssus">
                        <div class="form-field-header">
                            <label>Kilometraje</label>
                        </div>
                        <div class="form-field-content">
                            <input type="text" data-bind="enterovalue: nkiloinssus" />
                        </div>

                    </div>
                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Traccion:</label>
                        </div>
                        <div class="form-field-content">

                            <div data-bind="foreach: $root.cvi_aipinssus.combotraccmanveh">
                                 <!-- ko if: xvalorcodigo != '' -->
                                <span style="display: inline" data-bind="text: xvalorcodigo"> </span>
                                    <input name="tracc" type="radio" data-bind="attr: { value: xvalorcodigo }, checked: $parent.itraccmanveh" />
                                     <!-- /ko -->
                               
                            </div>

                        </div>
                    </div>
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Vehiculo importado:</label>
                        </div>
                        <div class="form-field-content">
                            <input type="checkbox" data-bind="value: iimpmanveh" />
                        </div>
                    </div>
                </div>
                </div>
            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Estado General</legend>
                 <div class="form-row"  >
                     <div class="form-column" style="width:17%"> </div> 
                     <div class="form-column" style="width:3%">B</div>
                     <div class="form-column"style="width:3%"  >R</div>
                     <div class="form-column" style="width:3%">M</div>
                     <div class="form-column" style="width:16%">  </div> 
                     <div class="form-column" style="width:3%">B </div>
                     <div class="form-column" style="width:3%">R </div> 
                     <div class="form-column" style="width:3%">M</div>
                     <div class="form-column" style="width:16%">  </div> 
                     <div class="form-column" style="width:3%">B </div>
                     <div class="form-column" style="width:3%">R </div> 
                     <div class="form-column" style="width:3%">M</div>
                </div>
                <div class="form-row" data-bind="foreach: $root.lista_aipinssusrepuest">
                    <div class="form-row" data-bind="foreach: $data">
                        <div class="form-column" style="width:150px">
                            <label style="display: none" data-bind="value: idaipinssus"></label>
                            <label style="display: none" data-bind="value: idaipmanrepu"></label>
                             <span style="display: inline"  data-bind="text: xnommanrepu"  >   </span>
                         </div > <div class="form-column"  style="width:80px">
                               <input type="radio"  value="true"  data-bind="  checked: IsBCheckbox, attr: {   'name': 'myprefix_' + idaipmanrepu() }, click: $root.clickR1" />
                            <input type="radio"    value="true" data-bind=" checked: IsRCheckbox, attr: {  'name': 'myprefix_' + idaipmanrepu() }, click: $root.clickR2" />
                            <input type="radio"   value="true" data-bind=" checked: IsMCheckbox, attr: {   'name': 'myprefix_' + idaipmanrepu() }, click: $root.clickR3" />
                        </div>
                    </div>
                </div>
                   
            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Accesorios</legend>
                <div class="form-row" data-bind="foreach: $root.lista_aipinssusacc">
                    <div class="form-row" data-bind="foreach: $data">
                        <div class="form-column" style="width:150px">
                            
                            <label style="display: none" data-bind="value: idaipinssus"></label>
                            <label style="display: none" data-bind="value: idaipmanvehacc"></label>
                             <span style="display: inline"  data-bind="text: xnommanvehacc"  > </span>
                         </div > <div class="form-column"  style="width:80px">  <input type="checkbox" data-bind="checked: iexisinssusacc" />
                        </div>
                    </div>
                </div>

            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Sistemas de seguridad electronicos</legend>
                <div class="form-row" data-bind="foreach: $root.lista_aipinssussse">
                    <div class="form-row" data-bind="foreach: $data">
                        <div class="form-column" style="width:150px">
                        
                            <label style="display: none" data-bind="value: idaipinssus"></label>
                            <label style="display: none" data-bind="value: idaipmanvehsse"></label>
                             <span style="display: inline"  data-bind="text: xnommanvehsse"  > </span>
                        </div >
                         <div class="form-column"  style="width:80px"> 
                              <input type="checkbox" data-bind="checked: iexisinssussse" />
                        </div>
                    </div>
                </div>

            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Sistemas de seguridad mecanicos</legend>
                <div class="form-row" data-bind="foreach: $root.lista_aipinssusssm">
                    <div class="form-column" data-bind="foreach: $data">
                      <div class="form-column" style="width:150px">
                        
                            <label style="display: none" data-bind="value: idaipinssus"></label>
                            <label style="display: none" data-bind="value: idaipmanvehssm"></label>
                             <span style="display: inline"  data-bind="text: xnommanvehssm"  > </span>
                        
                           </div >
                         <div class="form-column"  style="width:80px">   <input type="checkbox" data-bind="checked: iexisinssusssm" />
                        </div>
                    </div>
                </div>

            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Levantamiento del serial</legend>
                <div class="form-row">
                    <div class="form-column">
                        <span style="display: inline">Body del serial</span>
                        <input type="checkbox" data-bind="checked: iserbodinssus" />

                    </div>
                    <div class="form-column">
                        <span style="display: inline">Alarma cortacorriente</span>
                        <input type="checkbox" data-bind="checked: ialarcorrinssus" />

                    </div>
                </div>
                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Serial</label>
                        </div>
                        <div class="form-field-content">
                            <input type="text" data-bind="value: xserinssus" />
                        </div>
                    </div>
                </div>
            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Opinion del riesgo</legend>

                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Dictamen</label>
                        </div>
                        <div class="form-field-content">
                            <textarea style="width:600px" data-bind="value: xdictinssus" ></textarea>  
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
    function vmInsSusGuardar1(perito, auditor,aprobada) {
        var self = this;
        self.vi_aipinssus = new vi_aipinssus(false);
        self.cvi_aipinssus = new vi_aipinssus(false);
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.pagvi_aipinssus = new paginacion(1, 10, 0, "it.idaipinssus", "DESC");
        self.lista_vi_aipinssus = ko.observableArray();
        self.aipmanveh = new aipmanveh(false);

        self.lista_aipmanvehmar = ko.observableArray();
        self.lista_aipmanvehmod = ko.observableArray();
        self.lista_aipmanvehver = ko.observableArray();
        self.lista_aipinssusmotiv = ko.observableArray(); 
        self.lista_aipinssusrepuest = ko.observableArray();
        self.lista_aipinssusacc = ko.observableArray();
        self.lista_aipinssussse = ko.observableArray();
        self.lista_aipinssusssm = ko.observableArray();
        self.alista_aipinssusmotiv = ko.observableArray();
        self.alista_aipinssusrepuest = ko.observableArray();
        self.alista_aipinssusacc = ko.observableArray();
        self.alista_aipinssussse = ko.observableArray();
        self.alista_aipinssusssm = ko.observableArray();
        self.lista_selecaipinsmotiv = ko.observableArray();
        self.lista_selecaipinssusrepuest = ko.observableArray();
        self.lista_selecaipinssusacc = ko.observableArray();
        self.lista_selecaipinssussse = ko.observableArray();
        self.lista_selecaipinssusssm = ko.observableArray();
        self.selecaipinsmotiv = ko.observableArray();
        self.selecaipinssusrepuest = ko.observableArray();
        self.selecaipinssusacc = ko.observableArray();
        self.selecaipinssussse = ko.observableArray();
        self.selecaipinssusssm = ko.observableArray();
        self.sel_idaipinssus = ko.observable(0);
        self.perito = ko.observable(perito);
        self.auditor = ko.observable(auditor);
        self.aprobada = ko.observable(aprobada);

        //self.btn_guardar = ko.observable(false);
        //self.btn_enviar = ko.observable(false);

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

        self.llenarcombolugarins = function (onj) {
            var xconcepto = "ILUGINSSUS";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.cvi_aipinssus.comboluginssus(lista_comunconfvalor); 
            })
        }
        self.llenarcombocolor = function (obj) {
            var xconcepto = "ICOLORMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.cvi_aipinssus.combocolormanveh(lista_comunconfvalor);

                self.aipmanveh.icolormanveh(obj);
            })
        }
        self.llenarcombotipotransmision = function (obj) {
            var xconcepto = "ITIPOTRANSMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.cvi_aipinssus.combotipotransmanveh(lista_comunconfvalor); 
            })
        }
        self.llenarcomboclase = function (obj) {
            var xconcepto = "ICLASEMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.cvi_aipinssus.comboclasemanveh(lista_comunconfvalor);

                self.aipmanveh.iclasemanveh(obj);
            })
        }
        
        self.llenarcombotraccion = function (obj) {
            var xconcepto = "ITRACCMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.cvi_aipinssus.combotraccmanveh(lista_comunconfvalor); 
            })
        }
        self.llenarcomboestado = function () {
            var idcomunmanpais = 1;
            postajaxjsonbasico("/Comun/ObtenerEstadosPorPais/", "{'idcomunmanpais': '" + idcomunmanpais + "'}", function (lista_comunmanestado) {
                self.cvi_aipinssus.combomanestado(lista_comunmanestado);
            })
        } 

        self.llenar_lista_aipinsmotiv = function () {
            postajaxjsonbasico("/Inspeccion/ObtenerMotivosInspeccionSusActivos/", "{'idaipinssus': '" + self.vi_aipinssus.idaipinssus() + "'}", function (lista_aipinssusmotiv) {
                ko.mapping.fromJS(lista_aipinssusmotiv, {}, self.alista_aipinssusmotiv);
                self.lista_aipinssusmotiv(self.groupObsArray(3, self.alista_aipinssusmotiv()));
            })
        }
        self.llenar_lista_aipmanvehmar = function (obj) {
            postajaxjsonbasico("/Mantenimiento/ObtenerMarcasActivas/", "{}", function (lista_aipmanvehmar) {
                self.cvi_aipinssus.combomanvehmar(lista_aipmanvehmar);
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
                        self.cvi_aipinssus.combomanvehmod(lista_aipmanvehmod);
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
                    self.cvi_aipinssus.combomanvehver(lista_aipmanvehver);
                    self.aipmanveh.idaipmanvehver(obj.idaipmanvehver());
                })
            }  
        }
        
        self.llenar_lista_aipinssusrepuest = function (idaipinssus) {
            postajaxjsonbasico("/Inspeccion/ObtenerRepuestosSuscripcionEstadGen/", "{'idaipinssus': '" + idaipinssus + "'}", function (lista_aipinssusrepuest) {
                
                ko.mapping.fromJS(lista_aipinssusrepuest, {}, self.alista_aipinssusrepuest);
                ko.utils.arrayForEach(self.alista_aipinssusrepuest(), function (feature) {
                    feature.IsBCheckbox = ko.computed({
                        read: function () {
                            return feature.ibueinssusrepuest() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.ibueinssusrepuest(true)
                            else feature.ibueinssusrepuest(false)
                        }
                    });
                    feature.IsRCheckbox = ko.computed({
                        read: function () {
                            return feature.ireginssusrepuest() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.ireginssusrepuest(true)
                            else feature.ibueinssusrepuest(false)
                        }
                    });
                    feature.IsMCheckbox = ko.computed({
                        read: function () {
                            return feature.imalinssusrepuest() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.imalinssusrepuest(true)
                            else feature.imalinssusrepuest(false)
                        }
                    });
                });
               
                
                self.lista_aipinssusrepuest(self.groupObsArray(3, self.alista_aipinssusrepuest()));
            })
        }
        self.llenar_lista_aipinssusacc = function (idaipinssus) {
            postajaxjsonbasico("/Inspeccion/ObtenerSuscripcionAccVeh/", "{'idaipinssus': '" + idaipinssus + "'}", function (lista_aipinssusacc) {
                ko.mapping.fromJS(lista_aipinssusacc, {}, self.alista_aipinssusacc);
                self.lista_aipinssusacc(self.groupObsArray(3, self.alista_aipinssusacc()));
            })
        }
        self.llenar_lista_aipinssussse = function (idaipinssus) {
            postajaxjsonbasico("/Inspeccion/ObtenerSuscripcionSseVeh/", "{'idaipinssus': '" + idaipinssus + "'}", function (lista_aipinssussse) {
                ko.mapping.fromJS(lista_aipinssussse, {}, self.alista_aipinssussse);
                self.lista_aipinssussse(self.groupObsArray(3, self.alista_aipinssussse()));
            })
        }
        self.llenar_lista_aipinssusssm = function (idaipinssus) {
            postajaxjsonbasico("/Inspeccion/ObtenerSuscripcionSsmVeh/", "{'idaipinssus': '" + idaipinssus + "'}", function (lista_aipinssusssm) {
                ko.mapping.fromJS(lista_aipinssusssm, {}, self.alista_aipinssusssm);
                self.lista_aipinssusssm(self.groupObsArray(3, self.alista_aipinssusssm()));
            })
        }
        self.cargarVehiculo = function (idaipmanveh) {
            var auxaipmanveh = new aipmanveh(false);
            postajaxjsonbasico("/Mantenimiento/ObtenerVehiculoPorId/", "{'idaipmanveh': '" + idaipmanveh + "'}", function (aipmanveh) {
                ko.mapping.fromJS(aipmanveh, {}, auxaipmanveh);
                ko.mapping.fromJS(aipmanveh, {}, self.aipmanveh);
                self.llenar_lista_aipmanvehmar(auxaipmanveh);

                self.llenarcombotipotransmision(auxaipmanveh.itipotransmanveh());
                self.llenarcomboclase(auxaipmanveh.iclasemanveh());
                self.llenarcombotraccion(auxaipmanveh.itraccmanveh());
                self.llenarcombocolor(auxaipmanveh.icolormanveh());
            })
        }
        self.cargarSuscripcion = function (idaipinsenc) {
            postajaxjsonbasico("/Inspeccion/ObtenerInspeccionSuscripcionPorIdInsEnc/", "{'idaipinsenc': '" + idaipinsenc + "'}", function (vi_aipinssus) {
                ko.mapping.fromJS(vi_aipinssus, {}, self.vi_aipinssus);
                self.cargarVehiculo(self.vi_aipinssus.idaipmanveh());

                self.llenarcombolugarins(self.vi_aipinssus.iluginssus());
                self.llenar_lista_aipinsmotiv();
            
                self.llenar_lista_aipinssusrepuest(self.vi_aipinssus.idaipinssus());
                self.llenar_lista_aipinssusacc(self.vi_aipinssus.idaipinssus());
                self.llenar_lista_aipinssussse(self.vi_aipinssus.idaipinssus());
                self.llenar_lista_aipinssusssm(self.vi_aipinssus.idaipinssus());
            })
        }
        self.limpiar = function () {
            //self.vi_aipinssus.idaipinssus(); 
            //self.vi_aipinssus.idaipinssus(0);
            //self.vi_aipinssus.idaipinsenc(0);
            //self.vi_aipinssus.itipoinsenc("");
            //self.vi_aipinssus.idsegmanusu(0);
            //self.vi_aipinssus.xcedula("");
            //self.vi_aipinssus.xnombres("");
            //self.vi_aipinssus.xapellidos("");
            //self.vi_aipinssus.xnombrecompleto("");
            //self.vi_aipinssus.xcedpropinsenc("");
            //self.vi_aipinssus.xcedsidoinsenc("");
            //self.vi_aipinssus.xplacinsenc("");
            //self.vi_aipinssus.xsermotinsenc("");
            //self.vi_aipinssus.xsercarrinsenc("");
            //self.vi_aipinssus.xnumpolinsenc("");
            //self.vi_aipinssus.xnumsininsenc("");
            //self.vi_aipinssus.xnomintinssus("");
            //self.vi_aipinssus.xnomsolinssus("");
            //self.vi_aipinssus.iluginssus("");
            //self.vi_aipinssus.idaipmanveh(0);
            //self.vi_aipinssus.idaipmanvehmar(0);
            //self.vi_aipinssus.xnommanvehmar("");
            //self.vi_aipinssus.idaipmanvehmod(0);
            //self.vi_aipinssus.xnommanvehmod("");
            //self.vi_aipinssus.idaipmanvehver(0);
            //self.vi_aipinssus.xnommanvehver("");
            //self.vi_aipinssus.itipotransmanveh("");
            //self.vi_aipinssus.itipomanveh("");
            //self.vi_aipinssus.iclasemanveh("");
            //self.vi_aipinssus.icolormanveh("");
            //self.vi_aipinssus.xplacamanveh("");
            //self.vi_aipinssus.xsercarrmanveh("");
            //self.vi_aipinssus.xsermotmanveh("");
            //self.vi_aipinssus.itraccmanveh("");
            //self.vi_aipinssus.iimpmanveh(0);
            //self.vi_aipinssus.ncilinmanveh(0);
            //self.vi_aipinssus.xcargmanveh("");
            //self.vi_aipinssus.xcapmanveh("");
            //self.vi_aipinssus.xdescmanveh("");
            //self.vi_aipinssus.nkiloinssus(0);
            //self.vi_aipinssus.xsucuinssus("");
            //self.vi_aipinssus.iserbodinssus(0);
            //self.vi_aipinssus.ialarcorrinssus(0);
            //self.vi_aipinssus.xserinssus("");
            //self.vi_aipinssus.xdictinssus("");
            //self.vi_aipinssus.xdescinssus("");
            //self.vi_aipinssus.iestatinssus("");
            //self.vi_aipinssus.idseglogreg(0);
        }

        self.agregar_version = function () {            
            vmmanversionnuevo1.cargar();
            $("#dlg_manversionnuevo1").dialog("open");
            $("#dlg_manversionnuevo1").dialog({
                close: function (event, ui) {
                    //self.buscar();
                }
            });
        }

        self.buscar = function (tipo) {
            self.vi_aipinssus.errors = ko.validation.group(self.vi_aipinssus);
            if (self.vi_aipinssus.errors().length > 0) {
                generar_noty($('#lista_err_citapacbuscar1').html(), "warning");
                return false;
            }

            if (tipo != 'MOV') {
                self.pagvi_aipinssus.npagactual(1);
            }

            postajaxjsonbasico("/Mantenimiento/ObtenerRepuestos/", ko.toJSON(self), function (respvi_aipinssuspaglist) {
                self.lista_vi_aipinssus("");
                ko.mapping.fromJS(respvi_aipinssuspaglist, {}, self);
            })
        }
        self.iniciar = function (vi_aipinsenc) {
            ko.mapping.fromJS(vi_aipinsenc, {}, self.vi_aipinsenc);
            self.cargarSuscripcion(vi_aipinsenc.idaipinsenc());

            //self.buscar();
        }

      
        self.enviar = function () {
            postajaxjsonbasico("/Inspeccion/ProcesarInspeccionSuscripcion/", ko.toJSON(self.vi_aipinssus), function (respopera) {
                if (respopera.irespuesta == 1) {                    
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    $("#dlg_InsSusGuardar1").dialog("close");

                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        };
        self.rechazar = function () {
            postajaxjsonbasico("/Inspeccion/RechazarInspeccionSuscripcion/", ko.toJSON(self.vi_aipinssus), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    $("#dlg_InsSusGuardar1").dialog("close");
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        };
        self.cancelar = function () {
            postajaxjsonbasico("/Inspeccion/CancelarInspeccionSuscripcion/", ko.toJSON(self.vi_aipinssus), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    $("#dlg_InsSusGuardar1").dialog("close");
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        };
        self.aceptar = function () {
            postajaxjsonbasico("/Inspeccion/AceptarInspeccionSuscripcion/", ko.toJSON(self.vi_aipinssus), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    $("#dlg_InsSusGuardar1").dialog("close");
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        };
        self.imprimir = function () {
            $.fileDownload('/Inspeccion/ImprimirInspeccionSuscripcion/?fdesde=' + self.fdesde() + '&fhasta=' + self.fhasta(), {
                preparingMessageHtml: "Estamos descargando su archivo, por favor espere...",
                failMessageHtml: "Ha ocurrido un error descargando su archivo, por favor intente mas tarde."
            });
            return false;
        };

        self.guardar = function () {

            var error = false;
            postajaxjsonbasico("/Inspeccion/GuardarInspeccionSuscripcion/", ko.toJSON(self.vi_aipinssus), function (respopera) {
                if (respopera.irespuesta == 1) {
                   
                    self.limpiar();
                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusMotivos/", ko.toJSON(self.alista_aipinssusmotiv), function (respopera) {
                        if (respopera.irespuesta == 1) {
                           // generar_noty_auto(respopera.xmsjusuario, "success");
                            self.limpiar();
                        } else {
                            error = true;
                            generar_noty(respopera.xmsjusuario, "error");
                        }
                    })
                    postajaxjsonbasico("/Inspeccion/ActualizarMantVehiculo/", ko.toJSON(self.aipmanveh), function (respopera) {
                        if (respopera.irespuesta == 1) {
                          //  generar_noty_auto(respopera.xmsjusuario, "success");
                            self.limpiar();
                        } else {
                            error = true;
                            generar_noty(respopera.xmsjusuario, "error");
                        }
                    })
                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusRepuEstadGen/", ko.toJSON(self.alista_aipinssusrepuest), function (respopera) {
                        if (respopera.irespuesta == 1) {
                            //generar_noty(respopera.xmsjusuario, "success");
                            self.limpiar();
                        } else {
                            error = true;
                            generar_noty(respopera.xmsjusuario, "error");
                        }
                    })
                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusAcc/", ko.toJSON(self.alista_aipinssusacc), function (respopera) {
                        if (respopera.irespuesta == 1) {
                             generar_noty_auto(respopera.xmsjusuario, "success");
                            self.limpiar();
                             
                        } else {

                            error = true;
                            generar_noty(respopera.xmsjusuario, "error");
                        }
                    })
                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusSsm/", ko.toJSON(self.alista_aipinssusssm), function (respopera) {
                        if (respopera.irespuesta == 1) {
                         //   generar_noty_auto(respopera.xmsjusuario, "success");
                            self.limpiar();
                        } else { 
                            error = true;
                            generar_noty(respopera.xmsjusuario, "error");
                        }
                    })
                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusSse/", ko.toJSON(self.alista_aipinssussse), function (respopera) {
                        if (respopera.irespuesta == 1) {
                           // generar_noty_auto(respopera.xmsjusuario, "success");
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
                
            })
        }
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
            self.sel_idaipinssus(obj.idaipinssus());
            postajaxjsonbasico("/Cita/ObtenerVicitapacxid/", "{'idaipinssus':'" + obj.idaipinssus() + "'}", function (aipinssus) {
                vmcitapacver1.cargar(aipinssus);
                //vmcitapacmodificar1.cargar(aipinssus);
                //vmcitapaccerrar1.cargar(aipinssus);

            })
        }

        self.cargar_editar = function (obj) {
            self.sel_idaipinssus(obj.idaipinssus());
            postajaxjsonbasico("/Cita/ObtenerVicitapacxid/", "{'idaipinssus':'" + obj.idaipinssus() + "'}", function (aipinssus) {
                //vmcitapacver1.cargar(aipinssus);
                vmcitapacmodificar1.cargar(aipinssus);
                //vmcitapaccerrar1.cargar(aipinssus);

            })
        }

        self.cargar_cerrar = function (obj) {
            self.sel_idaipinssus(obj.idaipinssus());
            postajaxjsonbasico("/Cita/ObtenerVicitapacxid/", "{'idaipinssus':'" + obj.idaipinssus() + "'}", function (aipinssus) {
                //vmcitapacver1.cargar(aipinssus);
                //vmcitapacmodificar1.cargar(aipinssus);
                vmcitapaccerrar1.cargar(aipinssus);

            })
        }



        self.ir_primero = function () {
            var npagactual = self.pagvi_aipinssus.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipinssus.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_aipinssus.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipinssus.npagactual(self.pagvi_aipinssus.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_aipinssus.npagactual() != self.pagvi_aipinssus.npagcantidad()) {
                self.pagvi_aipinssus.npagactual(self.pagvi_aipinssus.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_aipinssus.npagactual() != self.pagvi_aipinssus.npagcantidad()) {
                self.pagvi_aipinssus.npagactual(self.pagvi_aipinssus.npagcantidad);
                self.buscar('MOV');
            }
        }

        self.groupObsArray = function (itemsPerGroup, observableArray) {
            return ko.computed(function () {
                var obsArrData = observableArray;
                var groupedItems = [];
                var group   = itemsPerGroup;
                var aGroup = [];
                for (var i = 0; i < obsArrData.length; i++) {
                   
                    if ((i % group === 0)&&(i!=0)) {
                        groupedItems.push(aGroup);
                        
                        aGroup = [];
                    }
                    aGroup.push(obsArrData[i])
                }
                return groupedItems;
            });
        }
        //self.enviar = function () {
        //    postajaxjsonbasico("/Inspeccion/ProcesarInspeccionSuscripcion/", ko.toJSON(self.vi_aipinssus), function (respopera) {
        //        if (respopera.irespuesta == 1) {
        //            generar_noty_auto(respopera.xmsjusuario, "success");
        //            self.limpiar();
        //        } else {
        //            generar_noty(respopera.xmsjusuario, "error");
        //        }
        //    })
        //}

        self.imprimir = function () {
            $.fileDownload('/Inspeccion/ImprimirInspeccionSuscripcion/?idaipinssus=' + self.vi_aipinssus.idaipinssus(), {
                preparingMessageHtml: "Estamos descargando su archivo, por favor espere...",
            });
        }
        self.rechazar = function () {
            postajaxjsonbasico("/Inspeccion/RechazarInspeccionSuscripcion/", ko.toJSON(self.vi_aipinssus), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }
        self.cancelar = function () {
            postajaxjsonbasico("/Inspeccion/CancelarInspeccionSuscripcion/", ko.toJSON(self.vi_aipinssus), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }
        self.aceptar = function () {
            postajaxjsonbasico("/Inspeccion/AceptarInspeccionSuscripcion/", ko.toJSON(self.vi_aipinssus), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
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
                    self.cvi_aipinssus.combomanvehver(lista_aipmanvehver);
                })
            }
        }
    }
</script>
