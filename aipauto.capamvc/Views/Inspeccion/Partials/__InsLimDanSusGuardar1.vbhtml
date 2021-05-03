<fieldset style="width: 930px;">
    <legend>Limpieza de Daños</legend>

    <div data-bind="with: vi_aipinslimsus">
        <div class="form-row">
            <fieldset style="width: 900px;">
                <legend>Datos de Cabecera</legend>
                <div class="form-row">
                   
                    <div data-bind="with: $root.vi_aipinsenc" class="form-column">
                        <div class="form-field-header">
                            <label>Nº poliza:</label>
                        </div>
                        <div class="form-field-content">

                            <input placeholder="Ej: poliza" type="text" data-bind="value: xnumpolinsenc" />
                        </div>
                    </div>
                    <div data-bind="with: $root.vi_aipinsenc" class="form-column">
                        <div class="form-field-header">
                            <label>Fecha:</label>
                        </div>
                        <div class="form-field-content">
                            <input class="date-field" type="text" disabled data-bind="datevalue: fcreainsenc" />
                        </div>
                    </div>
                     <div data-bind="with: $root.vi_aipinsenc" class="form-column">
                        <div class="form-field-header">
                            <label>N Siniestro</label>
                        </div>
                        <div class="form-field-content">
                            <input placeholder="Ej: Siniestro" type="text" data-bind="value: xnumsininsenc" />
                        </div>

                    </div>
                </div>
                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Nº factura:</label>
                        </div>
                        <div class="form-field-content">
                            <input type="text" data-bind="enterovalue: nfactinslimsus" />
                        </div>
                    </div>
                  @*  <div class="form-column">
                        <div class="form-field-header">
                            <label>Medio:</label>
                        </div>
                        <div class="form-field-content">

                            <input placeholder="Ej: Medio" type="text" data-bind="value: xnomaseginslimsus " />
                        </div>
                    </div>*@
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Nombre completo del Cliente/Asegurado</label>
                        </div>
                       <div class="form-field-content">
                            <input placeholder="Ej: Nombre" type="text" data-bind="value: xnomaseginslimsus" />
                        </div>

                    </div>
                </div>
                <div class="form-row">
          
                     
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Código del perito</label>
                        </div>
                        <div class="form-field-content">
                            <input placeholder="Ej: Codigo" type="text" />
                        </div>

                    </div>
                      <div class="form-column">
                        <div class="form-field-header">
                            <label>Nombre completo del perito</label>
                        </div>
                        <div class="form-field-content">
                            <input placeholder="Ej: Nombre" type="text" data-bind="value: xnombrecompleto" />
                        </div>

                    </div>
                </div>
            </fieldset>
        </div>
        <div class="form-row">

            <fieldset style="width: 900px;">
                <legend>Datos del vehiculo</legend>
                <div data-bind="with: $root.aipmanveh">
                    <div class="form-row">
                        <div data-bind="with: $root.vi_aipinslimsus" class="form-column">
                            <div class="form-field-header">
                                <label>Sucursal:</label>
                            </div>
                            <div class="form-field-content">
                                @*<select data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: $root.idsegmanorgperit, disable: $root.disabled_sucursal"></select>*@
                                <input placeholder="Ej: sucursal" type="text" data-bind="value: xsucuinslimsus, disable: $root.disabled_sucursal" />
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
                          <select data-bind="populateInitialValue: true, options: $root.combomanvehmar, optionsText: 'xnommanvehmar', optionsValue: 'idaipmanvehmar', value: $root.aipmanveh.idaipmanvehmar, event: { change: $root.llenar_lista_aipmanvehmod } "></select>  </div>
                        </div>
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Modelo:</label>
                            </div>
                            <div class="form-field-content">

                                <select id="ddl_modelo" data-bind="options: $root.combomanvehmod, optionsText: 'xnommanvehmod', optionsValue: 'idaipmanvehmod', value: idaipmanvehmod, event: { change: $root.llenar_lista_aipmanvehver }"></select>
                            </div>
                        </div>
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Clase</label>
                            </div>
                            <div class="form-field-content">
                                <select data-bind="options: $root.comboclasemanveh, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iclasemanveh"></select>

                            </div>

                        </div>

                    </div>
                    <div class="form-row">
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Version</label>
                            </div>
                            <div class="form-field-content">
                                <select data-bind="options: $root.combomanvehver, optionsText: 'xnommanvehver', optionsValue: 'idaipmanvehver', value: idaipmanvehver"></select>

                                <input type="button" title="Agregar versión" value="+" data-bind="click: $root.agregar_version" />
                            </div>

                        </div>
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
                                <div data-bind="foreach: $root.combotipotransmanveh">
                                    <!-- ko if: xvalorcodigo != '' -->
                                    <span style="display: inline" data-bind="text: xvalorcodigo"></span>
                                    <input name="linspeccion" type="radio" data-bind="value: xvalorcodigo, checked: $parent.itipotransmanveh" />

                                    <!-- /ko -->
                                </div>
                            </div>
                        </div>

                    </div>
                    <div class="form-row">
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
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Capacidad</label>
                            </div>
                            <div class="form-field-content">

                                <input placeholder="Ej: Capacidad" type="text" data-bind="value: xcapmanveh" />
                            </div>

                        </div>
                    </div>
                    <div class="form-row">
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Color Principal:</label>
                            </div>
                            <div class="form-field-content">
                                <select data-bind="options: $root.combocolormanveh, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: icolormanveh"></select>
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

                        <div data-bind="with: $root.vi_aipinslimsus" class="form-column">
                            <div class="form-field-header">
                                <label>Kilometraje</label>
                            </div>
                            <div class="form-field-content">
                                <input type="text" data-bind="enterovalue: nkiloinslimsus" />
                            </div>

                        </div>
                    </div>
                </div>
            </fieldset>

            <fieldset style="width: 900px;">
                <legend>Repuestos</legend>
                 <div class="form-row">
                    <div class="form-column">
                        <input type="button" value="Actualizar" data-bind="click: $root.updRepuesto" />

                    </div>
                </div><div data-bind="with: $root.aipinslimsusrepu" class="form-row">
                    <div class="form-column">
                        <input style="width: 50px;" type="text" data-bind="enterovalue: ncantinslimsusrepu" />


                    </div>
                    <div class="form-column">
                        <select data-bind="options: $root.repuestos, optionsText: 'xnommanrepu', optionsValue: 'idaipmanrepu', value: idaipsusrepu, event: { change: $root.obtener_origen }"></select>

                    </div>
                    <div class="form-column">
                        <select data-bind="options: combosusori, optionsText: 'iorigbarerepu', optionsValue: 'iorigbarerepu', value: idaipsusori, event: { change: $root.obtener_baremo_repuesto }"></select>

                    </div>
                    <div class="form-column">
                        <input style="width: 50px;" data-bind="numeralvalue: nprecfininslimsusrepu" type="text" />

                    </div>
                    <div class="form-column">
                        <input type="button" value="Agregar" data-bind="click: $root.addRepuesto" />

                    </div>
                     
                </div>
                <div class="grid-area">
                    <table class="grid-table">
                        <thead>
                            <tr class="grid-row-header" data-bind="foreach: $root.encabezados_aipinslimsusrepu">
                                <td data-bind="text: titulo"></td>
                            </tr>
                        </thead>
                        <tbody data-bind='foreach: $root.lista_vi_aipinslimsusrepu'>
                            <tr class="grid-row-content">

                                <td>
                                    <input style="width: 50px;" type="text" data-bind="enterovalue: ncantinslimsusrepu" />

                                </td>
                                <td>
                                    <select data-bind="options: $root.repuestos, optionsText: 'xnommanrepu', optionsValue: 'idaipmanrepu', value: idaipsusrepu, event: { change: $root.obtener_origen }"></select>
                                </td>
                                <td>
                                    <select data-bind="options: combosusori, optionsText: 'iorigbarerepu', optionsValue: 'iorigbarerepu', value: idaipsusori, event: { change: $root.obtener_baremo_repuesto }"></select>
                                </td>
                                <td>
                                    <input style="width: 50px;" data-bind="numeralvalue: nprecfininslimsusrepu" type="text" />
                                </td>
                                <td>
                                    <input type="button" value="Eliminar" data-bind="click: $root.delRepuesto" /></td>
                                <td>
                            </tr>
                        </tbody>

                    </table>
                    <div class="no-grid-rows" data-bind='visible: $root.lista_vi_aipinslimsusrepu().length == 0'>No existe repuestos almacenados...</div>
                </div>


            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Mano de Obra</legend>
                <div class="form-row">
                    <div class="form-column">
                        <input type="button" value="Actualizar" data-bind="click: $root.updMobr" />

                    </div>
                </div> <div data-bind="with: $root.aipinslimsusmobr" class="form-row">
                    <div class="form-column">
                        <input style="width: 50px" hidden  data-bind="value: idaipbaremobr" type="text" />
                       
                        <input style="width: 50px" type="text" data-bind="enterovalue: ncantinslimsusmobr" />
                    </div>
                    <div class="form-column">
                        <select style="width: 150px" data-bind="options: $root.repuestos, optionsText: 'xnommanrepu', optionsValue: 'idaipmanrepu', value: idaipsusrepu/*, event: { change: $root.obtener_campos }*/"></select>

                    </div>
                    <div class="form-column">
                        <select style="width: 150px" data-bind="options: combosustam, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: idaipsustam/*, event: { change: $root.obtener_baremomobr }*/"></select>
                        @*****************************************************************************@
                        @*SE COLOCO HIDDEN ESTE COMBO DE TAMAÑO DE LA PIEZA A PETICION DEL CLIENTE*@
                        @*****************************************************************************@
                    </div>
                    <div class="form-column">
                        <select style="width: 150px" hidden data-bind="options: combosusmat, optionsText: 'imaterpiezbaremobr', optionsValue: 'imaterpiezbaremobr', value: idaipsusmat, event: { change: $root.obtener_baremomobr }"></select>
                        @*****************************************************************************@
                        @*SE COLOCO HIDDEN ESTE COMBO DE MATERIAL DE LA PIEZA A PETICION DEL CLIENTE*@
                        @*****************************************************************************@
                    </div>
                    <div class="form-column">
                        <select style="width: 150px" data-bind="options: combosusmobr, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: idaipsusmobr, event: { change: $root.obtener_baremomobr }"></select>

                    </div>
                    <div class="form-column">
                        <input style="width: 50px" data-bind="numeralvalue: nprecfininslimsusmobr" type="text" />

                    </div>
                    <div class="form-column">
                        <input type="button" value="Agregar" data-bind="click: $root.addMobr" />

                    </div>    
                     
                </div>
                <div class="grid-area">
                    <table class="grid-table">
                        <thead>
                            <tr class="grid-row-header" data-bind="foreach: $root.encabezados_aipinslimsusmobr">
                                <td data-bind="text: titulo"></td>
                            </tr>
                        </thead>
                        <tbody data-bind='foreach: $root.lista_vi_aipinslimsusmobr'>
                            <tr class="grid-row-content">

                                <td>
                        <input style="width: 50px" hidden data-bind="value: idaipbaremobr" type="text" />
                                    <input  style="width: 50px" type="text" data-bind="enterovalue: ncantinslimsusmobr" />
                                </td>
                                <td>
                                    @*<select style="width: 150px" data-bind="options: $root.repuestos, optionsText: 'xnommanrepu', optionsValue: 'idaipmanrepu', value: idaipsusrepu, event: { change: $root.obtener_campos }"></select>*@
                                    <span data-bind='text: xnommanrepu' />
                                </td>
                                @*****************************************************************************************************@
                                @*SE COMENTARON ESTOS DOS TD PARA QUITAR LOS COMBOS DE TIPO DE MATERIAL Y TAMAÑO DE LA PIEZA*@
                                <td>
                                    @*<select style="width: 150px" data-bind="options: combosustam, optionsText: 'itamapiezbaremobr', optionsValue: 'itamapiezbaremobr', value: idaipsustam, event: { change: $root.obtener_baremomobr }"></select>*@
                                    <span data-bind='text: itamapiezbaremobr' />
                                </td>
                                @* <td>
                                    <select style="width: 150px" data-bind="options: combosusmat, optionsText: 'imaterpiezbaremobr', optionsValue: 'imaterpiezbaremobr', value: idaipsusmat, event: { change: $root.obtener_baremomobr }"></select>
                                </td>*@
                                @*****************************************************************************************************@
                                <td>
                                   @* <select style="width: 150px" data-bind="options: combosusmobr, optionsText: 'itipobaremobr', optionsValue: 'itipobaremobr', value: idaipsusmobr, event: { change: $root.obtener_baremomobr }"></select>*@
                                    <span data-bind='text: itipobaremobr' />
                                </td>
                                <td>
                                    <input style="width: 50px" data-bind="numeralvalue: nprecfininslimsusmobr" type="text" />

                                </td>
                                <td>    <input type="button" value="Eliminar" data-bind="click: $root.delMobr" /></td>
                             

                            </tr>
                        </tbody>

                    </table>
                    <div class="no-grid-rows" data-bind='visible: $root.lista_vi_aipinslimsusmobr().length == 0'>No existe mano de obra almacenada...</div>
                </div>


            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Detalle de limpieza</legend>

                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Observaciones</label>
                        </div>
                        <div class="form-field-content">
                            <textarea style="width: 600px" data-bind="value: xdescinslimsus"></textarea>
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
    function vmInsLimDanSusGuardar1(perito, auditor, aprobada) {
        var self = this;
        self.vi_aipinslimsus = new vi_aipinslimsus(false);
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.pagvi_aipinslimsus = new paginacion(1, 10, 0, "it.idaipinslimsus", "DESC");
        self.lista_vi_aipinslimsus = ko.observableArray();
        self.aipinslimsusrepu = new aipinslimsusrepu(false);
        self.aipinslimsusmobr = new aipinslimsusmobr(false);
        self.aipmanveh = new aipmanveh(false);
        self.lista_vi_aipinslimsusrepu = ko.observableArray();
        self.lista_vi_aipinslimsusmobr = ko.observableArray(); 
        self.sel_idaipinslimsus = ko.observable(0);
        self.repuestos = ko.observableArray();
        self.perito = ko.observable(perito);
        self.auditor = ko.observable(auditor);
        self.aprobada = ko.observable(aprobada);
        self.combotraccmanveh = ko.observableArray();
        self.combocolormanveh = ko.observableArray();
        self.combotipotransmanveh = ko.observableArray();
        self.comboclasemanveh = ko.observableArray();
        self.combotraccmanveh = ko.observableArray();
        self.combomanvehmar = ko.observableArray();
        self.combomanvehmod = ko.observableArray();
        self.combomanvehver = ko.observableArray();

        self.cbosucursal = ko.observableArray();
        self.idsegmanorgperit = ko.observable(0);
        self.disabled_sucursal = ko.observable(true);

        self.llenarcbosucursal = function (idsegmanorg) {
            postajaxjsonbasico("/comun/ObtenerComboOrganizacion/", '{}', function (lista_vi_combosegmanorg) {
                //self.cbosucursal(lista_vi_combosegmanorg);
                
                //self.idsegmanorgperit(idsegmanorg);
                for (i = 0; i < lista_vi_combosegmanorg.length; i++) {
                    if (lista_vi_combosegmanorg[i].idsegmanorg == idsegmanorg) {
                        self.vi_aipinslimsus.xsucuinslimsus(lista_vi_combosegmanorg[i].xnombrecomercial);
                    }

                }
                
            });
        }

        self.llenarrepuestos = function () {
            postajaxjsonbasico("/Mantenimiento/ObtenerRepuestosActivos/", "{}", function (lista_aipmanrepu) {
                self.repuestos(lista_aipmanrepu);
                self.llenar_lista_vi_aipinslimsusrepu(self.vi_aipinslimsus.idaipinslimsus());

            })
        }
        self.llenarcombocolor = function (obj) {
            var xconcepto = "ICOLORMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.combocolormanveh(lista_comunconfvalor);

                self.aipmanveh.icolormanveh(obj.icolormanveh());
            })
        }
        self.cargarVehiculo = function (idaipmanveh) {
            var auxaipmanveh = new aipmanveh(false);
            postajaxjsonbasico("/Mantenimiento/ObtenerVehiculoPorId/", "{'idaipmanveh': '" + idaipmanveh + "'}", function (aipmanvehr) {
                ko.mapping.fromJS(aipmanvehr, {}, auxaipmanveh);
                ko.mapping.fromJS(aipmanvehr, {}, self.aipmanveh);
                self.llenar_lista_aipmanvehmar(auxaipmanveh);

                self.llenarcombotipotransmision(auxaipmanveh);
                 self.llenarcomboclase(auxaipmanveh);
                 self.llenarcombotraccion(auxaipmanveh);
                 self.llenarcombocolor(auxaipmanveh);
            })
        }
         
        self.encabezados_aipinslimsusrepu = [
          { titulo: 'Cantidad', campo: 'it.ncantinslimsusrepu' },
          { titulo: 'Repuesto', campo: 'it.idaipsusrepu' },
          { titulo: 'Origen', campo: 'it.idaipsusori' },
          { titulo: 'Precio', campo: 'it.nprecfininslimsusrepu' }
        ];
        self.encabezados_aipinslimsusmobr = [
           { titulo: 'Cantidad', campo: 'it.ncantinslimsusrepu' },
           { titulo: 'Repuesto', campo: 'it.idaipsusrepu' },
           { titulo: 'Tamaño', campo: 'it.idaipsustam' },
           //{ titulo: 'Material', campo: 'it.idaipsusmat' },
        { titulo: 'Mano de Obra', campo: 'it.idaipsusmobr' },
        { titulo: 'Precio', campo: 'it.nprecfininslimsusmobr' }
        ];
        self.llenarcombotipotransmision = function (obj) {
            var xconcepto = "ITIPOTRANSMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.combotipotransmanveh(lista_comunconfvalor); 
                self.aipmanveh.itipotransmanveh(obj.itipotransmanveh());
            })
        }
        self.llenarcomboclase = function (obj) {
            var xconcepto = "ICLASEMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.comboclasemanveh(lista_comunconfvalor);
                self.aipmanveh.iclasemanveh(obj.iclasemanveh());
            })
        }

        self.llenarcombotraccion = function () {
            var xconcepto = "ITRACCMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.combotraccmanveh(lista_comunconfvalor); 
            })
        }

        self.llenarcomboestado = function () {
            var idcomunmanpais = 9;
            postajaxjsonbasico("/Comun/ObtenerEstadosPorPais/", "{'idcomunmanpais': '" + idcomunmanpais + "'}", function (lista_comunmanestado) {
                self.vi_mant_aicmancia.combomanestado(lista_comunmanestado);
            })
        }
        
        self.llenar_lista_aipmanvehmar = function (obj) {
            postajaxjsonbasico("/Mantenimiento/ObtenerMarcasActivas/", "{}", function (lista_aipmanvehmar) {
                self.combomanvehmar(lista_aipmanvehmar);
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
                        self.combomanvehmod(lista_aipmanvehmod);
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
            if (typeof obj.idaipmanvehmod() !== "undefined"){
                postajaxjsonbasico("/Mantenimiento/ObtenerVersionesActivasPorModelo/", "{'idaipmanvehmod': '" + obj.idaipmanvehmod() + "'}", function (lista_aipmanvehver) {
                    self.combomanvehver(lista_aipmanvehver);
                    self.aipmanveh.idaipmanvehver(obj.idaipmanvehver());
                })
            }
        }

       

        self.limpiar = function () {
           
        }
        self.buscar = function (tipo) {
            self.vi_aipinslimsus.errors = ko.validation.group(self.vi_aipinslimsus);
            if (self.vi_aipinslimsus.errors().length > 0) {
                generar_noty_auto($('#lista_err_citapacbuscar1').html(), "warning");
                return false;
            }

            if (tipo != 'MOV') {
                self.pagvi_aipinslimsus.npagactual(1);
            }
           
            postajaxjsonbasico("/Mantenimiento/ObtenerRepuestos/", ko.toJSON(self), function (respvi_aipinslimsuspaglist) {
                self.lista_vi_aipinslimsus("");
                ko.mapping.fromJS(respvi_aipinslimsuspaglist, {}, self);
            })
        }
        self.cargarSuscripcion = function (idaipinsenc) {
            postajaxjsonbasico("/Inspeccion/ObtenerInspeccionLimpiezaSuscripcionPorIdInsEnc/", "{'idaipinsenc': '" + idaipinsenc + "'}", function (vi_aipinslimsus) {
                ko.mapping.fromJS(vi_aipinslimsus, {}, self.vi_aipinslimsus);
                self.cargarVehiculo(self.vi_aipinslimsus.idaipmanveh());

                self.llenarcbosucursal(self.vi_aipinsenc.idsegmanorgperit());
                self.llenarrepuestos();
                 //  self.llenar_lista_aipinssussse(self.vi_aipinslimsus.idaipinslimsus());
                //self.llenar_lista_aipinssusssm(self.vi_aipinslimsus.idaipinslimsus());
            })
        }
        self.llenar_lista_vi_aipinslimsusrepu = function (idaipinslimsus) {
            postajaxjsonbasico("/Inspeccion/ObtenerRepuestosLimpiezaSuscripcion/", "{'idaipinslimsus': '" + idaipinslimsus + "'}", function (lista_vi_aipinslimsusrepu1) {
                lista_vi_aipinslimsusrepu1.forEach(function (e) {
                    e.idaipsusrepu = ko.observable(e.idaipmanrepu);
                    e.combosusrepu = ko.observableArray();
                    e.idaipsusori = e.iorigbarerepu;
                    e.combosusori = ko.observableArray();
                    e.aidaipsusori = ko.observable(e.iorigbarerepu);
                });
                ko.mapping.fromJS(lista_vi_aipinslimsusrepu1, {}, self.lista_vi_aipinslimsusrepu); 
                lista_vi_aipinslimsusrepu1.forEach(function (e, i) {
                    e.idaipsusrepu(e.idaipsusrepu);

                })
                self.llenar_lista_vi_aipinssusmobr(self.vi_aipinslimsus.idaipinslimsus());

            })
        }
        self.llenar_lista_vi_aipinssusmobr = function (idaipinslimsus) {
            postajaxjsonbasico("/Inspeccion/ObtenerMobrLimpiezaSuscripcion/", "{'idaipinslimsus': '" + idaipinslimsus + "'}", function (lista_vi_aipinslimsusmobr1) {
                lista_vi_aipinslimsusmobr1.forEach(function (e) {
                    e.idaipsusrepu = ko.observable(e.idaipmanrepu);
                    e.combosusrepu = ko.observableArray();
                    e.idaipsustam = e.itamapiezbaremobr;
                    e.combosustam = ko.observableArray();
                    e.idaipsusmat = e.imaterpiezbaremobr;
                    e.combosusmat = ko.observableArray();
                    e.idaipsusmobr = e.itipobaremobr;
                    e.combosusmobr = ko.observableArray();
                    e.aidaipsustam = ko.observable(e.itamapiezbaremobr);
                    e.aidaipsusmat = ko.observable(e.imaterpiezbaremobr);
                    e.aidaipsusmobr = ko.observable(e.itipobaremobr);

                });
                ko.mapping.fromJS(lista_vi_aipinslimsusmobr1, {}, self.lista_vi_aipinslimsusmobr);
                lista_vi_aipinslimsusmobr1.forEach(function (e,i) {
                    e.idaipsusrepu(e.idaipsusrepu); 

                });
            })
        }
        self.iniciar = function (vi_aipinsenc) {

             ko.mapping.fromJS(vi_aipinsenc, {}, self.vi_aipinsenc);
             self.cargarSuscripcion(vi_aipinsenc.idaipinsenc());
             self.obtener_campos2();
             //self.llenarcbosucursal(vi_aipinsenc.idsegmanorgperit());
            //self.buscar();
        }
     
        self.ir_primero = function () {
            var npagactual = self.pagvi_aipinslimsus.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipinslimsus.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_aipinslimsus.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipinslimsus.npagactual(self.pagvi_aipinslimsus.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_aipinslimsus.npagactual() != self.pagvi_aipinslimsus.npagcantidad()) {
                self.pagvi_aipinslimsus.npagactual(self.pagvi_aipinslimsus.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_aipinslimsus.npagactual() != self.pagvi_aipinslimsus.npagcantidad()) {
                self.pagvi_aipinslimsus.npagactual(self.pagvi_aipinslimsus.npagcantidad);
                self.buscar('MOV');
            }
        }

        self.groupObsArray = function (itemsPerGroup, observableArray) {
            return ko.computed(function () {
                var obsArrData = observableArray;
                var groupedItems = [];
                var group = itemsPerGroup;
                var aGroup = [];
                for (var i = 0; i < obsArrData.length; i++) {

                    if ((i % group === 0) && (i != 0)) {
                        groupedItems.push(aGroup);

                        aGroup = [];
                    }
                    aGroup.push(obsArrData[i])
                }
                return groupedItems;
            });
        }

        self.obtener_origen = function (obj, event) {
            if (typeof obj.idaipsusrepu() !== "undefined") {
                var enter = false;
                var eidaipsusori = obj.aidaipsusori;
                if (typeof obj.aidaipsusori !== "undefined") {
                    if ((obj.aidaipsusori() != "SELECCIONE...")) {
                        enter = true;
                    }
                }
                postajaxjsonbasico("/Baremo/ObtenerOrigenBareRepu/?idaipmanrepu=" + obj.idaipsusrepu(), '{}', function (lista_vi_comboaipbarerepuorig) {
                    obj.combosusori(lista_vi_comboaipbarerepuorig);
                    if (enter) {
                        obj.idaipsusori(eidaipsusori());
                    }
                });
            } else {

            }

        }
        self.obtener_campos = function (obj, event) {
            if (typeof obj.idaipsusrepu() !== "undefined") {
                var enter = false;
                var eidaipsustam = obj.aidaipsustam;
                var eidaipsusmat = obj.aidaipsusmat;
                var eidaipsusmobr = obj.aidaipsusmobr;
                if (typeof obj.aidaipsusmat !== "undefined") {
                    if ((obj.aidaipsusmobr() != "SELECCIONE...") && (obj.aidaipsustam() != "SELECCIONE...") && (obj.aidaipsusmat() != "SELECCIONE...")) {
                        enter = true;
                        //eidaipsustam = obj.idaipsustam  ;
                        //eidaipsusmat = obj.idaipsusmat ;
                        //eidaipsusmobr = obj.idaipsusmobr;
                    }
                }
                    //si el usuario desencadeno el evento
                postajaxjsonbasico("/Baremo/ObtenerTamaBareMobr/?idaipmanrepu=" + obj.idaipsusrepu(), '{}', function (lista_vi_comboaipbaremobrtama) {
                    obj.combosustam(lista_vi_comboaipbaremobrtama);
                    ////alert(obj.combosustam().length);                          //INICIO BLOQUE DE CODIGO SOLICITADO POR EL CIENTE 1.1
                    //if (lista_vi_comboaipbaremobrtama.length == 1) {            //ESTE BLOQUE DE CODIGO FUE APETICION DE CLIENTE PARA ELIMINAR
                    //    self.aipinslimsusmobr.idaipsustam("");                  //EL COMBO DE TAMAÑO DE LA PIEZA Y TIPO DE MATERIAL, DE MODO QUE SE
                    //    //alert(self.aipinslimsusmobr.idaipsustam());           //SELECCIONA DE MANERA AUTOMATICA DEPENDIENDO DE LA CANTIDAD DE
                    //}                                                           //REGISTROS QUE TENGA LA LISTA (1,2,3 O 4)
                    //else if (lista_vi_comboaipbaremobrtama.length == 2) {       //SON DOS BLOQUES 1.1 Y 1.2
                    //    self.aipinslimsusmobr.idaipsustam(lista_vi_comboaipbaremobrtama[1].itamapiezbaremobr);
                    //    //alert(self.aipinslimsusmobr.idaipsustam());
                    //}
                    //else if (lista_vi_comboaipbaremobrtama.length == 3) {
                    //    self.aipinslimsusmobr.idaipsustam(lista_vi_comboaipbaremobrtama[2].itamapiezbaremobr);
                    //    //alert(self.aipinslimsusmobr.idaipsustam());
                    //}
                    //else if (lista_vi_comboaipbaremobrtama.length == 4) {
                    //    self.aipinslimsusmobr.idaipsustam(lista_vi_comboaipbaremobrtama[2].itamapiezbaremobr);
                    //    //alert(self.aipinslimsusmobr.idaipsustam());
                    //}                                                           //FIN BLOQUE 1.1
                    if (enter) {
                        obj.idaipsustam(eidaipsustam());
                    }
                    postajaxjsonbasico("/Baremo/ObtenerMaterBareMobr/?idaipmanrepu=" + obj.idaipsusrepu(), '{}', function (lista_vi_comboaipbaremobrmater) {
                        obj.combosusmat(lista_vi_comboaipbaremobrmater);
                        //alert(obj.combosusmat().length);                      //INICIO BLOQUE 1.2
                        if (lista_vi_comboaipbaremobrmater.length == 1) {
                            self.aipinslimsusmobr.idaipsusmat("");
                            //alert(self.aipinslimsusmobr.idaipsusmat());
                        }
                        else if (lista_vi_comboaipbaremobrmater.length == 2) {
                            self.aipinslimsusmobr.idaipsusmat(lista_vi_comboaipbaremobrmater[1].imaterpiezbaremobr);
                            //alert(self.aipinslimsusmobr.idaipsusmat());
                        }
                        else if (lista_vi_comboaipbaremobrmater.length == 3) {
                            self.aipinslimsusmobr.idaipsusmat(lista_vi_comboaipbaremobrmater[2].imaterpiezbaremobr);
                            //alert(self.aipinslimsusmobr.idaipsusmat());
                        }
                        else if (lista_vi_comboaipbaremobrmater.length == 4) {
                            self.aipinslimsusmobr.idaipsusmat(lista_vi_comboaipbaremobrmater[2].imaterpiezbaremobr);
                            //alert(self.aipinslimsusmobr.idaipsusmat());
                        }                                                      //FIN DE BLOQUE DE CODIGO SOLICITADO POR EL CLIENTE 1.2
                        if (enter) {
                            obj.idaipsusmat(eidaipsusmat());
                        }
                    });
                    postajaxjsonbasico("/Baremo/ObtenerMobrBareMobr/?idaipmanrepu=" + obj.idaipsusrepu(), '{}', function (lista_vi_comboaipbaremobrmobr) {
                        obj.combosusmobr(lista_vi_comboaipbaremobrmobr);
                        if (enter) {
                            obj.idaipsusmobr(eidaipsusmobr());
                        }
                    });
                });
              
              
            } else {
                //si el programa desencadeno el evento
             
            }
        }

        self.obtener_campos2 = function ()
        {
            var xconcepto = "ITAMAPIEZBAREMOBR";
            postajaxjsonbasico("/Comun/ObtenerValores/?xconcepto=" + xconcepto, '{}', function (lista_comunconfvalor) {
                self.aipinslimsusmobr.combosustam(lista_comunconfvalor);
            });
            xconcepto = "ITIPOBAREMOBR";
            postajaxjsonbasico("/Comun/ObtenerValores/?xconcepto=" + xconcepto, '{}', function (lista_comunconfvalor) {
                self.aipinslimsusmobr.combosusmobr(lista_comunconfvalor);
            });
            xconcepto = "IMATERPIEZBAREMOBR";
            postajaxjsonbasico("/Comun/ObtenerValores/?xconcepto=" + xconcepto, '{}', function (lista_comunconfvalor) {
                self.aipinslimsusmobr.combosusmat(lista_comunconfvalor);
                self.aipinslimsusmobr.idaipsusmat(lista_comunconfvalor[1].xvalordescripcion);
            });
        }

        self.obtener_baremo_repuesto = function (obj, event) {
            if (event.originalEvent) {

                if ((obj.idaipsusori() != "SELECCIONE...")) {
                    //si el usuario desencadeno el evento
                    postajaxjsonbasico("/Baremo/ObtenerCostoBareRepu/?idaipmanrepu=" + obj.idaipsusrepu() + "&iorigbarerepu=" + obj.idaipsusori(), '{}', function (mcostbarerepu) {
                        obj.nprecfininslimsusrepu(mcostbarerepu);
                        postajaxjsonbasico("/Baremo/ObtenerIdBareRepu/?idaipmanrepu=" + obj.idaipsusrepu() + "&iorigbarerepu=" + obj.idaipsusori(), '{}', function (idaipbarerepu) {
                            obj.idaipbarerepu(idaipbarerepu);
                        });
                    });
                   
                }
            } else {
                //si el programa desencadeno el evento

            }
        }
        self.obtener_baremomobr = function (obj, event) {
            if (event.originalEvent) {
                if ((obj.idaipsusmobr() != "SELECCIONE...") && (obj.idaipsustam() != "SELECCIONE...") && (obj.idaipsusmat() != "SELECCIONE...")) {
                    //si el usuario desencadeno el evento
                    postajaxjsonbasico("/Baremo/ObtenerCostoBareMobr/?idaipmanrepu=" + obj.idaipsusrepu() + "&itamapiezbaremobr=" + obj.idaipsustam() + "&imaterpiezbaremobr=" + obj.idaipsusmat() + "&itipobaremobr=" + obj.idaipsusmobr(), '{}', function (costo) {
                        obj.nprecfininslimsusmobr(costo);
                        postajaxjsonbasico("/Baremo/ObtenerIdBareMobr/?idaipmanrepu=" + obj.idaipsusrepu() + "&itamapiezbaremobr=" + obj.idaipsustam() + "&imaterpiezbaremobr=" + obj.idaipsusmat() + "&itipobaremobr=" + obj.idaipsusmobr(), '{}', function (idaipbaremobr) {

                            obj.idaipbaremobr(idaipbaremobr);

                        });
                    }); 
                   
                }
            } else {
                //si el programa desencadeno el evento
                 
            }
        }
        self.addRepuesto = function (obj) {
            self.aipinslimsusrepu.idaipinslimsus(self.vi_aipinslimsus.idaipinslimsus())

            postajaxjsonbasico("/Inspeccion/AgregarRepuestoLimpiezaSuscripcion/", ko.toJSON(self.aipinslimsusrepu), function (respopera) {
                if (respopera.irespuesta == 1) {
                       self.aipinslimsusrepu.idaipinslimsusrepu(respopera.id)
                    var obj = ko.mapping.fromJS(ko.mapping.toJS(self.aipinslimsusrepu));
                    self.lista_vi_aipinslimsusrepu.push(obj);
                    self.aipinslimsusrepu.idaipinslimsusrepu(0);
                    self.aipinslimsusrepu.idaipinslimsus(0);
                    self.aipinslimsusrepu.idaipbarerepu(0);
                    self.aipinslimsusrepu.idaipsusrepu(0);
                    self.aipinslimsusrepu.idaipsusori("SELECCIONE...");
                    self.aipinslimsusrepu.nprecfininslimsusrepu(0); 
                    generar_noty_auto(respopera.xmsjusuario, "success");
                } else {
                    generar_noty_auto(respopera.xmsjusuario, "error");
                }
            });
        }
        self.delRepuesto = function (obj) {
            postajaxjsonbasico("/Inspeccion/EliminarRepuestoLimpiezaSuscripcion/?idaipinslimsusrepu=" + obj.idaipinslimsusrepu(), "{}", function (respopera) {
                if (respopera.irespuesta == 1) {
                    self.lista_vi_aipinslimsusrepu.destroy(obj);
                    generar_noty_auto(respopera.xmsjusuario, "success");
                } else {
                    generar_noty_auto(respopera.xmsjusuario, "error");
                }
            });
        }
        self.updRepuesto = function () {
            postajaxjsonbasico("/Inspeccion/ActualizarRepuestosLimpiezaSuscripcion/", ko.toJSON(self.lista_vi_aipinslimsusrepu), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                } else {
                    generar_noty_auto(respopera.xmsjusuario, "error");
                }
            });
        }
        self.addMobr = function (obj) {
            self.aipinslimsusmobr.idaipinslimsus(self.vi_aipinslimsus.idaipinslimsus())
            postajaxjsonbasico("/Inspeccion/AgregarMobrLimpiezaSuscripcion/?idaipmanrepu=" + self.aipinslimsusmobr.idaipsusrepu() + "&itipobaremobr=" + self.aipinslimsusmobr.idaipsusmobr() + "&itamapiezbaremobr=" + self.aipinslimsusmobr.idaipsustam() + "&imaterpiezbaremobr=METAL", ko.toJSON(self.aipinslimsusmobr), function (respopera) {
                if (respopera.irespuesta == 1) {
                    self.aipinslimsusmobr.idaipinslimsusmobr(respopera.id)
                    //var obj = ko.mapping.fromJS(ko.mapping.toJS(self.aipinslimsusmobr));
                    //self.lista_vi_aipinslimsusmobr.push(obj);
                    self.llenar_lista_vi_aipinssusmobr(self.vi_aipinslimsus.idaipinslimsus());
                    self.aipinslimsusmobr.idaipinslimsusmobr(0)
                    self.aipinslimsusmobr.idaipinslimsus(0)
                    self.aipinslimsusmobr.idaipbaremobr(0);
                    self.aipinslimsusmobr.idaipsusrepu(0);
                    self.aipinslimsusmobr.idaipsustam(0);
                    self.aipinslimsusmobr.idaipsusmat(0);
                    self.aipinslimsusmobr.idaipsusmobr(0);
                    self.aipinslimsusmobr.nprecfininslimsusmobr(0);  
                    generar_noty_auto(respopera.xmsjusuario, "success");
                } else {
                    generar_noty_auto(respopera.xmsjusuario, "error");
                }
            });
        }
        self.delMobr = function (obj) {
            postajaxjsonbasico("/Inspeccion/EliminarMobrLimpiezaSuscripcion/?idaipinslimsusmobr=" + obj.idaipinslimsusmobr(), "{}", function (respopera) {
                if (respopera.irespuesta == 1) {
                    self.llenar_lista_vi_aipinssusmobr(self.vi_aipinslimsus.idaipinslimsus());
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.lista_vi_aipinslimsusmobr.destroy(obj);

                } else {
                    generar_noty_auto(respopera.xmsjusuario, "error");
                }
            });
        }
        self.updMobr = function () {
            postajaxjsonbasico("/Inspeccion/ActualizarMobrsLimpiezaSuscripcion/", ko.toJSON(self.lista_vi_aipinslimsusmobr), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                } else {
                    generar_noty_auto(respopera.xmsjusuario, "error");
                }
            });
        }
        self.guardar = function () {
            var error = false;
            postajaxjsonbasico("/Inspeccion/GuardarInspeccionLimpiezaSuscripcion/", ko.toJSON(self.vi_aipinslimsus), function (respopera) {
                if (respopera.irespuesta == 1) {
                     self.limpiar();

                    postajaxjsonbasico("/Inspeccion/ActualizarMantVehiculo/", ko.toJSON(self.aipmanveh), function (respopera) {
                        if (respopera.irespuesta == 1) {
                            self.limpiar(); 
                        } else {
                            error = true;
                            generar_noty_auto(respopera.xmsjusuario, "error");
                        }
                    })

                } else {
                    error = true;
                    generar_noty_auto(respopera.xmsjusuario, "error");
                }
                if (!error) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                }
            })
        }
        self.enviar = function () {
            postajaxjsonbasico("/Inspeccion/ProcesarInspeccionLimpiezaSuscripcion/", ko.toJSON(self.vi_aipinslimsus), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    $("#dlg_InsLimDanSusGuardar1").dialog("close");
                    self.limpiar();
                } else {
                    generar_noty_auto(respopera.xmsjusuario, "error");
                }
            })
        }

        self.imprimir = function () {
            $.fileDownload('/Inspeccion/ImprimirInspeccionLimpiezaSuscripcion?idaipinslimsus=' + self.vi_aipinslimsus.idaipinslimsus(), {
                preparingMessageHtml: "Estamos descargando su archivo, por favor espere...",
            });
        }
        self.rechazar = function () {
            postajaxjsonbasico("/Inspeccion/RechazarInspeccionLimpiezaSuscripcion/", ko.toJSON(self.vi_aipinslimsus), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                    $("#dlg_InsLimDanSusGuardar1").dialog("close");
                } else {
                    generar_noty_auto(respopera.xmsjusuario, "error");
                }
            })
        }
        self.cancelar = function () {
            postajaxjsonbasico("/Inspeccion/CancelarInspeccionLimpiezaSuscripcion/", ko.toJSON(self.vi_aipinslimsus), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                    $("#dlg_InsLimDanSusGuardar1").dialog("close");
                } else {
                    generar_noty_auto(respopera.xmsjusuario, "error");
                }
            })
        }
        self.aceptar = function () {
            postajaxjsonbasico("/Inspeccion/AceptarInspeccionLimpiezaSuscripcion/", ko.toJSON(self.vi_aipinslimsus), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                    $("#dlg_InsLimDanSusGuardar1").dialog("close");
                } else {
                    generar_noty_auto(respopera.xmsjusuario, "error");
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
                    self.combomanvehver(lista_aipmanvehver);
                })
            }
        }
    }
</script>
