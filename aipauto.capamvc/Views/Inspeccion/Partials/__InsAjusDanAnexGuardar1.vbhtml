<fieldset style="width: 930px;">
    <legend>Ajuste de Daños</legend>

    <div data-bind="with: vi_aipinsajusanex">
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
                            <input class="date-field"  disabled type="text" data-bind="datevalue: fcreainsenc" />
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
                    @*<div class="form-column">
                        <div class="form-field-header">
                            <label>Tipo de Ajuste:</label>
                        </div>
                        <div class="form-field-content">
                            <input type="text" data-bind="value: nfactinsajusanex" />
                        </div>
                    </div>*@
                     
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Nombre completo del Cliente/Asegurado</label>
                        </div>
                        <div class="form-field-content">
                            <input placeholder="Ej: Nombre" type="text" data-bind="value: xnomaseginsajusanex" />
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
                        <div data-bind="with: $root.vi_aipinsajusanex" class="form-column">
                            <div class="form-field-header">
                                <label>Sucursal:</label>
                            </div>                            
                            <div class="form-field-content">
                                @*<select data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: $root.idsegmanorgperit, disable: $root.disabled_sucursal"></select>*@
                                <input placeholder="Ej: sucursal" type="text" data-bind="value: xsucuinsajusanex, disable: $root.disabled_sucursal" />
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
                                <select data-bind="options: $root.combomanvehmar, optionsText: 'xnommanvehmar', optionsValue: 'idaipmanvehmar', value: idaipmanvehmar, event: { change: $root.llenar_lista_aipmanvehmod }"></select>
                            </div>
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

                                <input type="button"  title="Agregar versión" value="+" data-bind="click: $root.agregar_version" />
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

                        <div data-bind="with: $root.vi_aipinsajusanex" class="form-column">
                            <div class="form-field-header">
                                <label>Kilometraje</label>
                            </div>
                            <div class="form-field-content">
                                <input type="text" data-bind="enterovalue: nkiloinsajusanex" />
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
                </div><div data-bind="with: $root.aipinsajusanexrepu" class="form-row">
                    <div class="form-column">
                        <input style="width: 50px;" type="text" data-bind="enterovalue: ncantinsajusanexrepu" />


                    </div>
                    <div class="form-column">
                        <select data-bind="options: $root.repuestos, optionsText: 'xnommanrepu', optionsValue: 'idaipmanrepu', value: idaipsusrepu, event: { change: $root.obtener_origen }"></select>

                    </div>
                    <div class="form-column">
                        <select data-bind="options: combosusori, optionsText: 'iorigbarerepu', optionsValue: 'iorigbarerepu', value: idaipsusori, event: { change: $root.obtener_baremo_repuesto }"></select>

                    </div>
                    <div class="form-column">
                        <input style="width: 50px;" data-bind="numeralvalue: nprecfininsajusanexrepu" type="text" />

                    </div>
                    <div class="form-column">
                        <input type="button" value="Agregar" data-bind="click: $root.addRepuesto" />

                    </div>
                   
                </div>
                <div class="grid-area">
                    <table class="grid-table">
                        <thead>
                            <tr class="grid-row-header" data-bind="foreach: $root.encabezados_aipinsajusanex">
                                <td data-bind="text: titulo"></td>
                            </tr>
                        </thead>
                        <tbody data-bind='foreach: $root.lista_vi_aipinsajusanexrepu'>
                            <tr class="grid-row-content">

                                <td>
                                    <input style="width: 50px;" type="text" data-bind="enterovalue: ncantinsajusanexrepu" />

                                </td>
                                <td>
                                    <select    data-bind="options: $root.repuestos, optionsText: 'xnommanrepu', optionsValue: 'idaipmanrepu', value: idaipsusrepu, event: { change: $root.obtener_origen }"></select>
                                </td>
                                <td>
                                    <select  data-bind="options: combosusori, optionsText: 'iorigbarerepu', optionsValue: 'iorigbarerepu', value: idaipsusori, event: { change: $root.obtener_baremo_repuesto }"></select>
                                </td>
                                <td>
                                    <input style="width: 50px;" data-bind="numeralvalue: nprecfininsajusanexrepu" type="text" />
                                </td>
                                <td>
                                    <input type="button" value="Eliminar" data-bind="click: $root.delRepuesto" /></td>
                                <td>
                            </tr>
                        </tbody>

                    </table>
                    <div class="no-grid-rows" data-bind='visible: $root.lista_vi_aipinsajusanexrepu().length == 0'>No existe repuestos almacenados...</div>
                </div>


            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Mano de Obra</legend>
                 <div class="form-row">
                    <div class="form-column">
                        <input type="button" value="Actualizar" data-bind="click: $root.updMobr" />

                    </div>
                </div><div data-bind="with: $root.aipinsajusanexmobr" class="form-row">
                    <div class="form-column">
                        <input style="width: 50px" type="text" data-bind="enterovalue: ncantinsajusanexmobr" />
                    </div>
                    <div class="form-column">
                        
                        <input style="width: 50px" hidden data-bind="value: idaipbaremobr" type="text" />
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
                        <input style="width: 50px" data-bind="numeralvalue: nprecfininsajusanexmobr" type="text" />

                    </div>
                    <div class="form-column">
                        <input type="button" value="Agregar" data-bind="click: $root.addMobr" />

                    </div> 
                    
                </div>
                <div class="grid-area">
                    <table class="grid-table">
                        <thead>
                            <tr class="grid-row-header" data-bind="foreach: $root.encabezados_aipinsajusanexmobr">
                                <td data-bind="text: titulo"></td>
                            </tr>
                        </thead>
                        <tbody data-bind='foreach: $root.lista_vi_aipinsajusanexmobr'>
                            <tr class="grid-row-content">

                                <td>
                        <input style="width: 50px" hidden data-bind="value: idaipbaremobr" type="text" />
                                    <input style="width: 50px"  type="text" data-bind="enterovalue: ncantinsajusanexmobr" />
                                </td>
                                <td>
                                    @*<select style="width: 150px" data-bind="options: $root.repuestos, optionsText: 'xnommanrepu', optionsValue: 'idaipmanrepu', value: idaipsusrepu, event: { change: $root.obtener_campos }"></select>*@
                                    <span data-bind='text: xnommanrepu' />
                                </td>
                                @*****************************************************************************************************@
                                @*SE COMENTARON ESTOS DOS TD PARA QUITAR LOS COMBOS DE TIPO DE MATERIAL Y TAMAÑO DE LA PIEZA*@
                                <td>
                                    @*<select style="width: 150px" data-bind="options: combosustam, optionsText: 'itamapiezbaremobr', optionsValue: 'itamapiezbaremobr', value: idaipsustam, event: { change: $root.obtener_baremomobr }"></select>*@
                                    <span data-bind="text: itamapiezbaremobr"></span>
                                </td>
                                @*<td>
                                    <select style="width: 150px" data-bind="options: combosusmat, optionsText: 'imaterpiezbaremobr', optionsValue: 'imaterpiezbaremobr', value: idaipsusmat, event: { change: $root.obtener_baremomobr }"></select>
                                </td>*@  
                                @*****************************************************************************************************@
                                <td>
                                    @*<select  style="width: 150px" data-bind="options: combosusmobr, optionsText: 'itipobaremobr', optionsValue: 'itipobaremobr', value: idaipsusmobr, event: { change: $root.obtener_baremomobr }"></select>*@
                                    <span data-bind='text: itipobaremobr' />
                                </td>
                                <td>
                                    <input style="width: 50px" data-bind="numeralvalue: nprecfininsajusanexmobr" type="text" />

                                </td>
                                <td>    <input type="button" value="Eliminar" data-bind="click: $root.delMobr" /></td>
                             

                            </tr>
                        </tbody>

                    </table>
                    <div class="no-grid-rows" data-bind='visible: $root.lista_vi_aipinsajusanexmobr().length == 0'>No existe mano de obra almacenada...</div>
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
                            <textarea style="width: 600px" data-bind="value: xdescinsajusanex"></textarea>
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
    function vmInsAjusDanAnexGuardar1(perito, auditor, aprobada) {
        var self = this;
        self.vi_aipinsajusanex = new vi_aipinsajusanex(false);
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.pagvi_aipinsajusanex = new paginacion(1, 10, 0, "it.idaipinsajusanex", "DESC");
        self.lista_vi_aipinsajusanex = ko.observableArray();
        self.aipinsajusanexrepu = new aipinsajusanexrepu(false);
        self.aipinsajusanexmobr = new aipinsajusanexmobr(false);
        self.aipmanveh = new aipmanveh(false);
        self.lista_vi_aipinsajusanexrepu = ko.observableArray();
        self.lista_vi_aipinsajusanexmobr = ko.observableArray(); 
        self.sel_idaipinsajusanex = ko.observable(0);
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
        

        self.llenarrepuestos = function () {
            postajaxjsonbasico("/Mantenimiento/ObtenerRepuestosActivos/", "{}", function (lista_aipmanrepu) {
                self.repuestos(lista_aipmanrepu);
                self.llenar_lista_vi_aipinsajusanexrepu(self.vi_aipinsajusanex.idaipinsajusanex());

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

        self.llenarcbosucursal = function (idsegmanorg) {
            postajaxjsonbasico("/comun/ObtenerComboOrganizacion/", '{}', function (lista_vi_combosegmanorg) {
                //self.cbosucursal(lista_vi_combosegmanorg);                
                //self.idsegmanorgperit(idsegmanorg);

                for (i = 0; i < lista_vi_combosegmanorg.length; i++) {
                    if (lista_vi_combosegmanorg[i].idsegmanorg == idsegmanorg) {
                        self.vi_aipinsajusanex.xsucuinsajusanex(lista_vi_combosegmanorg[i].xnombrecomercial);
                    }

                }
            });
        }
         
        self.encabezados_aipinsajusanex = [
          { titulo: 'Cantidad', campo: 'it.ncantinsajusanexrepu' },
          { titulo: 'Repuesto', campo: 'it.idaipsusrepu' },
          { titulo: 'Origen', campo: 'it.idaipsusori' },
          { titulo: 'Precio', campo: 'it.nprecfininsajusanexrepu' }
        ];
        self.encabezados_aipinsajusanexmobr = [
           { titulo: 'Cantidad', campo: 'it.ncantinsajusanexrepu' },
           { titulo: 'Repuesto', campo: 'it.idaipsusrepu' },
           { titulo: 'Tamaño', campo: 'it.idaipsustam' },
           //{ titulo: 'Material', campo: 'it.idaipsusmat' },
        { titulo: 'Mano de Obra', campo: 'it.idaipsusmobr' },
        { titulo: 'Precio', campo: 'it.nprecfininsajusanexmobr' }
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
            if (typeof obj.idaipmanvehmod() !== "undefined") {
                postajaxjsonbasico("/Mantenimiento/ObtenerVersionesActivasPorModelo/", "{'idaipmanvehmod': '" + obj.idaipmanvehmod() + "'}", function (lista_aipmanvehver) {
                    self.combomanvehver(lista_aipmanvehver);
                    self.aipmanveh.idaipmanvehver(obj.idaipmanvehver());
                })
            }
        }

        self.limpiar = function () {
            
        }
        self.buscar = function (tipo) {
            self.vi_aipinsajusanex.errors = ko.validation.group(self.vi_aipinsajusanex);
            if (self.vi_aipinsajusanex.errors().length > 0) {
                generar_noty($('#lista_err_citapacbuscar1').html(), "warning");
                return false;
            }

            if (tipo != 'MOV') {
                self.pagvi_aipinsajusanex.npagactual(1);
            }

            postajaxjsonbasico("/Mantenimiento/ObtenerRepuestos/", ko.toJSON(self), function (respvi_aipinsajusanexpaglist) {
                self.lista_vi_aipinsajusanex("");
                ko.mapping.fromJS(respvi_aipinsajusanexpaglist, {}, self);
                self.llenarcbosucursal(self.vi_aipinsenc.idsegmanorgperit());
            })
        }
        self.cargarSuscripcion = function (idaipinsenc) {
            postajaxjsonbasico("/Inspeccion/ObtenerInspeccionAjusteAnexoPorIdInsEnc/", "{'idaipinsenc': '" + idaipinsenc + "'}", function (vi_aipinsajusanex) {
                ko.mapping.fromJS(vi_aipinsajusanex, {}, self.vi_aipinsajusanex);
                self.cargarVehiculo(self.vi_aipinsajusanex.idaipmanveh());
 
                self.llenarrepuestos();
                   })
        }
        self.llenar_lista_vi_aipinsajusanexrepu = function (idaipinsajusanex) {
                 postajaxjsonbasico("/Inspeccion/ObtenerRepuestosAjusteAnexo/", "{'idaipinsajusanex': '" + idaipinsajusanex + "'}", function (lista_vi_aipinsajusanexrepu1) {
                    lista_vi_aipinsajusanexrepu1.forEach(function (e) {
                        e.idaipsusrepu = ko.observable(e.idaipmanrepu);
                        e.combosusrepu = ko.observableArray();
                        e.idaipsusori = e.iorigbarerepu;
                        e.combosusori = ko.observableArray();
                        e.aidaipsusori = ko.observable(e.iorigbarerepu);
                    });
                    ko.mapping.fromJS(lista_vi_aipinsajusanexrepu1, {}, self.lista_vi_aipinsajusanexrepu);
                    lista_vi_aipinsajusanexrepu1.forEach(function (e) {
                        e.idaipsusrepu(e.idaipsusrepu);

                    })
                    self.llenar_lista_vi_aipinssusmobr(self.vi_aipinsajusanex.idaipinsajusanex());

                })  
        }
        self.llenar_lista_vi_aipinssusmobr = function (idaipinsajusanex) {
            postajaxjsonbasico("/Inspeccion/ObtenerMobrAjusteAnexo/", "{'idaipinsajusanex': '" + idaipinsajusanex + "'}", function (lista_vi_aipinsajusanexmobr1) {
                lista_vi_aipinsajusanexmobr1.forEach(function (e) {
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
                ko.mapping.fromJS(lista_vi_aipinsajusanexmobr1, {}, self.lista_vi_aipinsajusanexmobr);
                lista_vi_aipinsajusanexmobr1.forEach(function (e, i) {
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
      

        self.ir_ver = function () {
            $("#tab_citapac").tabs("option", "active", 1);
        }

        self.ir_agregar = function () {
            $("#tab_citapac").tabs("option", "active", 2);
        }

        self.ir_modificar = function () {
            $("#tab_citapac").tabs("option", "active", 3);
        } 
        self.ir_primero = function () {
            var npagactual = self.pagvi_aipinsajusanex.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipinsajusanex.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_aipinsajusanex.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipinsajusanex.npagactual(self.pagvi_aipinsajusanex.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_aipinsajusanex.npagactual() != self.pagvi_aipinsajusanex.npagcantidad()) {
                self.pagvi_aipinsajusanex.npagactual(self.pagvi_aipinsajusanex.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_aipinsajusanex.npagactual() != self.pagvi_aipinsajusanex.npagcantidad()) {
                self.pagvi_aipinsajusanex.npagactual(self.pagvi_aipinsajusanex.npagcantidad);
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
                    ////alert(obj.combosustam().length);                              //INICIO BLOQUE DE CODIGO SOLICITADO POR EL CIENTE 1.1
                    //if (lista_vi_comboaipbaremobrtama.length == 1) {                //ESTE BLOQUE DE CODIGO FUE APETICION DE CLIENTE PARA ELIMINAR
                    //    self.aipinsajusanexmobr.idaipsustam("");                    //EL COMBO DE TAMAÑO DE LA PIEZA Y TIPO DE MATERIAL, DE MODO QUE SE
                    //    //alert(self.aipinsajusanexmobr.idaipsustam());             //SELECCIONA DE MANERA AUTOMATICA DEPENDIENDO DE LA CANTIDAD DE 
                    //}                                                               //REGISTROS QUE TENGA LA LISTA (1,2,3 O 4)
                    //else if (lista_vi_comboaipbaremobrtama.length == 2) {           //SON DOS BLOQUES 1.1 Y 1.2
                    //    self.aipinsajusanexmobr.idaipsustam(lista_vi_comboaipbaremobrtama[1].itamapiezbaremobr);
                    //    //alert(self.aipinsajusanexmobr.idaipsustam());
                    //}
                    //else if (lista_vi_comboaipbaremobrtama.length == 3) {
                    //    self.aipinsajusanexmobr.idaipsustam(lista_vi_comboaipbaremobrtama[2].itamapiezbaremobr);
                    //    //alert(self.aipinsajusanexmobr.idaipsustam());
                    //}
                    //else if (lista_vi_comboaipbaremobrtama.length == 4) {
                    //    self.aipinsajusanexmobr.idaipsustam(lista_vi_comboaipbaremobrtama[2].itamapiezbaremobr);
                    //    //alert(self.aipinsajusanexmobr.idaipsustam());
                    //}                                                               //FIN BLOQUE 1.1
                    if (enter) {
                        obj.idaipsustam(eidaipsustam());
                    }
                    postajaxjsonbasico("/Baremo/ObtenerMaterBareMobr/?idaipmanrepu=" + obj.idaipsusrepu(), '{}', function (lista_vi_comboaipbaremobrmater) {
                        obj.combosusmat(lista_vi_comboaipbaremobrmater);
                        //alert(obj.combosusmat().length);                         //INICIO BLOQUE 1.2
                        if (lista_vi_comboaipbaremobrmater.length == 1) {
                            self.aipinsajusanexmobr.idaipsusmat("");
                            //alert(self.aipinsajusanexmobr.idaipsusmat());
                        }
                        else if (lista_vi_comboaipbaremobrmater.length == 2) {
                            self.aipinsajusanexmobr.idaipsusmat(lista_vi_comboaipbaremobrmater[1].imaterpiezbaremobr);
                            //alert(self.aipinsajusanexmobr.idaipsusmat());
                        }
                        else if (lista_vi_comboaipbaremobrmater.length == 3) {
                            self.aipinsajusanexmobr.idaipsusmat(lista_vi_comboaipbaremobrmater[2].imaterpiezbaremobr);
                            //alert(self.aipinsajusanexmobr.idaipsusmat());
                        }
                        else if (lista_vi_comboaipbaremobrmater.length == 4) {
                            self.aipinsajusanexmobr.idaipsusmat(lista_vi_comboaipbaremobrmater[2].imaterpiezbaremobr);
                            //alert(self.aipinsajusanexmobr.idaipsusmat());
                        }                                                       //FIN DE BLOQUE DE CODIGO SOLICITADO POR EL CLIENTE 1.2
                        if (enter) {
                            obj.idaipsusmat(eidaipsusmat());
                        }
                        postajaxjsonbasico("/Baremo/ObtenerMobrBareMobr/?idaipmanrepu=" + obj.idaipsusrepu(), '{}', function (lista_vi_comboaipbaremobrmobr) {
                            obj.combosusmobr(lista_vi_comboaipbaremobrmobr);
                            if (enter) {
                                obj.idaipsusmobr(eidaipsusmobr());
                            }
                        });
                    });
                });
               
               
            } else {
                //si el programa desencadeno el evento

            }
        }

        self.obtener_campos2 = function () {
            var xconcepto = "ITAMAPIEZBAREMOBR";
            postajaxjsonbasico("/Comun/ObtenerValores/?xconcepto=" + xconcepto, '{}', function (lista_comunconfvalor) {
                self.aipinsajusanexmobr.combosustam(lista_comunconfvalor);
            });
            xconcepto = "ITIPOBAREMOBR";
            postajaxjsonbasico("/Comun/ObtenerValores/?xconcepto=" + xconcepto, '{}', function (lista_comunconfvalor) {
                self.aipinsajusanexmobr.combosusmobr(lista_comunconfvalor);
            });
            xconcepto = "IMATERPIEZBAREMOBR";
            postajaxjsonbasico("/Comun/ObtenerValores/?xconcepto=" + xconcepto, '{}', function (lista_comunconfvalor) {
                self.aipinsajusanexmobr.combosusmat(lista_comunconfvalor);
                self.aipinsajusanexmobr.idaipsusmat(lista_comunconfvalor[1].xvalordescripcion);
            });
        }

        self.obtener_baremo_repuesto = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                postajaxjsonbasico("/Baremo/ObtenerCostoBareRepu/?idaipmanrepu=" + obj.idaipsusrepu() + "&iorigbarerepu=" + obj.idaipsusori(), '{}', function (mcostbarerepu) {
                    obj.nprecfininsajusanexrepu(mcostbarerepu);
                    postajaxjsonbasico("/Baremo/ObtenerIdBareRepu/?idaipmanrepu=" + obj.idaipsusrepu() + "&iorigbarerepu=" + obj.idaipsusori(), '{}', function (idaipbarerepu) {
                        obj.idaipbarerepu(idaipbarerepu);
                    });
                });
               
            } else {
                //si el programa desencadeno el evento

            }
        }
        self.obtener_baremomobr = function (obj, event) {
            if (event.originalEvent) {
                if ((obj.idaipsusmobr() != "SELECCIONE...") && (obj.idaipsustam() != "SELECCIONE...") && (obj.idaipsusmat() != "SELECCIONE...")) {
                    //si el usuario desencadeno el evento
                    postajaxjsonbasico("/Baremo/ObtenerCostoBareMobr/?idaipmanrepu=" + obj.idaipsusrepu() + "&itamapiezbaremobr=" + obj.idaipsustam() + "&imaterpiezbaremobr=" + obj.idaipsusmat() + "&itipobaremobr=" + obj.idaipsusmobr(), '{}', function (costo) {
                        obj.nprecfininsajusanexmobr(costo);
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

            self.aipinsajusanexrepu.idaipinsajusanex(self.vi_aipinsajusanex.idaipinsajusanex())
            postajaxjsonbasico("/Inspeccion/AgregarRepuestoAjusteAnexo/", ko.toJSON(self.aipinsajusanexrepu), function (respopera) {
                if (respopera.irespuesta == 1) {
                    self.aipinsajusanexrepu.idaipinsajusanexrepu(respopera.id)
                    var obj = ko.mapping.fromJS(ko.mapping.toJS(self.aipinsajusanexrepu));
                    self.lista_vi_aipinsajusanexrepu.push(obj);
                    self.aipinsajusanexrepu.idaipinsajusanexrepu(0);
                    self.aipinsajusanexrepu.idaipinsajusanex(0);
                    self.aipinsajusanexrepu.idaipbarerepu(0);
                    self.aipinsajusanexrepu.idaipsusrepu(0);
                    self.aipinsajusanexrepu.idaipsusori("SELECCIONE...");
                    self.aipinsajusanexrepu.nprecfininsajusanexrepu(0);
                    generar_noty_auto(respopera.xmsjusuario, "success");
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            });
        }
        self.delRepuesto = function (obj) {
            postajaxjsonbasico("/Inspeccion/EliminarRepuestoAjusteAnexo/?idaipinsajusanexrepu=" + obj.idaipinsajusanexrepu(), "{}", function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            });
        }
        self.updRepuesto = function () {
            postajaxjsonbasico("/Inspeccion/ActualizarRepuestosAjusteAnexo/", ko.toJSON(self.lista_vi_aipinsajusanexrepu), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            });
        }
        self.addMobr = function (obj) {
            self.aipinsajusanexmobr.idaipinsajusanex(self.vi_aipinsajusanex.idaipinsajusanex())
            //self.aipinsajusanexmobr.idaipsusmat("METAL");
            //alert(self.aipinsajusanexmobr.idaipsusrepu());
            //alert(self.aipinsajusanexmobr.idaipsustam());
            //alert(self.aipinsajusanexmobr.idaipsusmobr());
            //alert(self.aipinsajusanexmobr.idaipsusmat());
            postajaxjsonbasico("/Inspeccion/AgregarMobrAjusteAnexo/?idaipmanrepu=" + self.aipinsajusanexmobr.idaipsusrepu() + "&itipobaremobr=" + self.aipinsajusanexmobr.idaipsusmobr() + "&itamapiezbaremobr=" + self.aipinsajusanexmobr.idaipsustam() + "&imaterpiezbaremobr=METAL", ko.toJSON(self.aipinsajusanexmobr), function (respopera) {
                if (respopera.irespuesta == 1) {
                    self.aipinsajusanexmobr.idaipinsajusanexmobr(respopera.id)
                    //var obj = ko.mapping.fromJS(ko.mapping.toJS(self.aipinsajusanexmobr));
                    //alert(obj.xnommanrepu);                   
                    //self.lista_vi_aipinsajusanexmobr.push(obj);
                    self.llenar_lista_vi_aipinssusmobr(self.vi_aipinsajusanex.idaipinsajusanex());
                    self.aipinsajusanexmobr.idaipinsajusanexmobr(0)
                    self.aipinsajusanexmobr.idaipinsajusanex(0)
                    self.aipinsajusanexmobr.idaipbaremobr(0);
                    self.aipinsajusanexmobr.idaipsusrepu(0);
                    self.aipinsajusanexmobr.idaipsustam(0);
                    self.aipinsajusanexmobr.idaipsusmat(0);
                    self.aipinsajusanexmobr.idaipsusmobr(0);
                    self.aipinsajusanexmobr.nprecfininsajusanexmobr(0);
                    generar_noty_auto(respopera.xmsjusuario, "success");
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            });
        }
        self.delMobr = function (obj) {
            postajaxjsonbasico("/Inspeccion/EliminarMobrAjusteAnexo/?idaipinsajusanexmobr=" + obj.idaipinsajusanexmobr(), "{}", function (respopera) {
                if (respopera.irespuesta == 1) {
                    self.llenar_lista_vi_aipinssusmobr(self.vi_aipinsajusanex.idaipinsajusanex());
                    generar_noty_auto(respopera.xmsjusuario, "success");
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            });
        }
        self.updMobr = function () {
            postajaxjsonbasico("/Inspeccion/ActualizarMobrsAjusteAnexo/", ko.toJSON(self.lista_vi_aipinsajusanexmobr), function (respopera) {
                if (respopera.irespuesta == 1) {
                    self.llenar_lista_vi_aipinssusmobr(self.vi_aipinsajusanex.idaipinsajusanex());
                    generar_noty_auto(respopera.xmsjusuario, "success");
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            });
        }
        self.guardar = function () {
            var error = false;
            postajaxjsonbasico("/Inspeccion/GuardarInspeccionAjusteAnexo/", ko.toJSON(self.vi_aipinsajusanex), function (respopera) {
                if (respopera.irespuesta == 1) {
                      self.limpiar();

                    postajaxjsonbasico("/Inspeccion/ActualizarMantVehiculo/", ko.toJSON(self.aipmanveh), function (respopera) {
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
            postajaxjsonbasico("/Inspeccion/ProcesarInspeccionAjusteAnexo/", ko.toJSON(self.vi_aipinsajusanex), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    $("#dlg_InsAjusDanAnexGuardar1").dialog("close");
                    self.limpiar();
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }

        self.imprimir = function () {
            $.fileDownload('/Inspeccion/ImprimirInspeccionAjusteAnexo?idaipinsajusanex=' + self.vi_aipinsajusanex.idaipinsajusanex(), {
                preparingMessageHtml: "Estamos descargando su archivo, por favor espere...",
            });
        }
        self.rechazar = function () {
            postajaxjsonbasico("/Inspeccion/RechazarInspeccionAjusteAnexo/", ko.toJSON(self.vi_aipinsajusanex), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                    $("#dlg_InsAjusDanAnexGuardar1").dialog("close");
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }
        self.cancelar = function () {
            postajaxjsonbasico("/Inspeccion/CancelarInspeccionAjusteAnexo/", ko.toJSON(self.vi_aipinsajusanex), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    $("#dlg_InsAjusDanAnexGuardar1").dialog("close");
                    self.limpiar();
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }
        self.aceptar = function () {
            postajaxjsonbasico("/Inspeccion/AceptarInspeccionAjusteAnexo/", ko.toJSON(self.vi_aipinsajusanex), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    $("#dlg_InsAjusDanAnexGuardar1").dialog("close");
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
                    self.combomanvehver(lista_aipmanvehver);
                })
            }
        }
    }
</script>
