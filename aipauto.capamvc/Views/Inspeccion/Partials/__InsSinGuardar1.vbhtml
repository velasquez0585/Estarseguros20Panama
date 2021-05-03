

<fieldset style="width: 930px;">
    <legend>Siniestro</legend>



    <div data-bind="with: vi_aipinsenc">
        <div class="form-row">
            <fieldset style="width: 900px;">
                <legend>Datos de Inspección</legend>
                <div class="form-row">

                    <div class="form-column">
                        <div class="form-field-header">
                            <label>N Siniestro</label>
                        </div>
                        <div class="form-field-content">
                            <input placeholder="Ej: Siniestro" type="text" data-bind="value: xnumsininsenc" disabled />
                        </div>

                    </div>

                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Inspección</label>
                        </div>
                        <div class="form-field-content">
                            <input placeholder="Ej: Inspección" type="text" data-bind="value: xnuminspinsenc" disabled />
                        </div>

                    </div>

                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Fecha de la inspección:</label>
                        </div>
                        <div class="form-field-content">
                            <input class="date-field" type="text" data-bind="datevalue: fcreainsenc" disabled />
                        </div>
                    </div>

                </div>

                <div class="form-row">

                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Cliente/Asegurado:</label>
                        </div>
                        <div class="form-field-content">
                            <input placeholder="Ej: Cliente/Asegurado" type="text" data-bind="value: xnomcliactivperi" disabled />
                        </div>
                    </div>

                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Sucursal:</label>
                        </div>
                        <div class="form-field-content">

                            <input placeholder="Ej: Sucursal" type="text" data-bind="value: xnomsucinsinsenc" disabled />
                        </div>
                    </div>

                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Ramo:</label>
                        </div>
                        <div class="form-field-content">
                            <input placeholder="Ej: Solicitante" type="text" data-bind="value: xnomramopolizinsenc" disabled />
                        </div>

                    </div>
                </div>


                <div class="form-row">

                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Nº poliza:</label>
                        </div>
                        <div class="form-field-content">

                            <input placeholder="Ej: poliza" type="text" data-bind="value: xnumpolinsenc" disabled />
                        </div>
                    </div>

                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Sucursal de la inspeccion:</label>
                        </div>
                        <div class="form-field-content">

                            <input placeholder="Ej: Sucursal" type="text" data-bind="value: xnombrecomercialperit" disabled />
                        </div>
                    </div>

                   @*<div class="form-column">
                        <div class="form-field-header">
                            <label>Nro. Inspección:</label>
                        </div>
                        <div class="form-field-content">
                            <input placeholder="Ej: 123456" type="text" data-bind="value: xnuminspinsenc" disabled />
                        </div>
                    </div>*@



                </div>

                <div class="form-row">

                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Tipo de inspección:</label>
                        </div>
                        <div class="form-field-content">
                            <div data-bind="foreach: $root.combolug">
                                <!-- ko if: xvalorcodigo != '' -->
                                <span style="display: inline" data-bind="text: xvalordescripcion"></span>
                                <input name="llugar" type="radio" data-bind="attr: { value: xvalorcodigo }, checked: $root.vi_aipinsenc.itipoperitinsenc" disabled />
                                <!-- /ko -->

                            </div>
                        </div>
                    </div>

                    <div class="form-column">
                        <div class="grid-top-button">
                            &ensp;&ensp;
                            <input type="button" value="Agenda" data-bind="click: $root.verDetallesAgenda" />                       
                            @*<input type="button" value="Agenda" data-bind="click: limpiarRepManObra" />*@                            
                        </div>
                    </div>
                </div>

            </fieldset>
        </div>

        <div data-bind="with: vi_aipinssin">
            <div class="form-row">

                <fieldset style="width: 900px;">
                    <legend>Motivo de la inspeccion</legend>
                    <div class="form-row" data-bind="foreach: $root.lista_vi_aipinssinmotiv">

                        <div class="form-column" style="width: 200px">
                            <span style="display: inline" data-bind="text: xnominsmotiv"></span>
                        </div>
                        <div class="form-column" style="width: 60px; margin-bottom: 30px;">
                            <input type="radio" name="motivoins" data-bind="attr: { value: itilinssinmotiv }, checked: IsTCheckbox, click: $root.clickM1" />
                            @* <span data-bind="text: itilinssusmotiv"></span>*@

                            @*<input type="checkbox" data-bind="checked: itilinssusmotiv" />*@
                        </div>

                    </div>
                </fieldset>

            </div>
        </div>

        <div class="form-row">

            <fieldset style="width: 900px;">
                <legend>Datos del Vehículo</legend>
                <div data-bind="with: $root.vi_aipmanveh">


                    <div class="form-row">
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Marca:</label>
                            </div>
                            <div class="form-field-content">
                                <input placeholder="Ej: placa" type="text" data-bind="value: xnommanvehmar" disabled />
                                @*<select style="display:none" data-bind="options: $root.combomanvehmar, optionsText: 'xnommanvehmar', optionsValue: 'idaipmanvehmar', value: idaipmanvehmar, event: { change: $root.llenar_lista_vi_aipmanvehmod }" disabled></select>*@
                            </div>
                        </div>
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Modelo:</label>
                            </div>
                            <div class="form-field-content">
                                <input placeholder="Ej: placa" type="text" data-bind="value: xnommanvehmod" disabled />
                                @*<select style="display:none" id="ddl_modelo" data-bind="options: $root.combomanvehmod, optionsText: 'xnommanvehmod', optionsValue: 'idaipmanvehmod', value: idaipmanvehmod, event: { change: $root.llenar_lista_vi_aipmanvehver }" disabled></select>*@
                            </div>
                        </div>
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Version</label>
                            </div>
                            <div class="form-field-content">
                                <input placeholder="Ej: placa" type="text" data-bind="value: xnommanvehver" disabled />
                                @*<select style="display:none" data-bind="options: $root.combomanvehver, optionsText: 'xnommanvehver', optionsValue: 'idaipmanvehver', value: idaipmanvehver" disabled></select>*@
                                @*<input type="button" title="Agregar versión" value="+" data-bind="click: $root.agregar_version" />*@
                            </div>

                        </div>

                    </div>

                    <div class="form-row">

                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Año:</label>
                            </div>
                            <div class="form-field-content">

                                <input type="text" data-bind="enterovalue: naniomanveh" disabled />
                            </div>
                        </div>
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Clase</label>
                            </div>
                            <div class="form-field-content">
                                <input placeholder="Ej: clase" type="text" data-bind="value: iclasemanveh" disabled />
                                @*<select style="display:none" data-bind="options: $root.comboclasemanveh, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iclasemanveh" disabled></select>*@

                            </div>
                        </div>
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Color Principal:</label>
                            </div>
                            <div class="form-field-content">
                                @*<input placeholder="Ej: color" type="text" data-bind="value: icolormanveh" disabled />*@
                                <select  data-bind="options: $root.combocolormanveh, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: icolormanveh" disabled></select>
                            </div>
                        </div>

                    </div>

                    <div class="form-row">
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Placa:</label>
                            </div>
                            <div class="form-field-content">

                                <input placeholder="Ej: placa" type="text" data-bind="value: xplacamanveh" />
                            </div>
                        </div>

                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Serial de carroceria</label>
                            </div>
                            <div class="form-field-content">
                                <input placeholder="Ej: serial" type="text" data-bind="value: xsercarrmanveh" maxlength="17" />
                            </div>
                        </div>
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Serial del motor:</label>
                            </div>
                            <div class="form-field-content">
                                <input type="text" data-bind="value: xsermotmanveh" disabled />
                            </div>
                        </div>
                    </div>

                    <div class="form-row">
                        <div data-bind="with: $root.vi_aipinssin" class="form-column">
                            <div class="form-field-header">
                                <label>Kilometraje</label>
                            </div>

                            <div class="form-field-content">
                                <input type="text" data-bind="enterovalue: nkiloinssin" />
                            </div>

                        </div>
                    </div>
                </div>


                <div class="form-row" data-bind='visible: $root.lista_aiploeve().length > 0 && $root.auditor'>
                    @*<div id="accordion-resizer" class="ui-widget-content">*@
                    <div class="accordion">
                        <h3>Modificaciones (Placa y/o Serial Carroceria)</h3>

                        <div data-bind='foreach: $root.lista_aiploeve'>
                            <ul>
                                <li>
                                    <p data-bind="text: xnomlogeve"></p>
                                </li>
                            </ul>

                        </div>

                    </div>
                    @*</div>*@
                </div>
            </fieldset>
        </div>

        <div class="form-row">

            <fieldset style="width: 900px;">
                <legend>Detalles de la declaración</legend>
                <div data-bind="with: $root.peraipdatosdeclara">
                    <div class="form-row">
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Ocurrencia del siniestro:</label>
                            </div>
                            <div class="form-field-content">                                
                                <textarea style="width: 600px" data-bind="value: xdessiniestro" disabled></textarea>                             
                            </div>
                        </div>
                    </div>
                    
                    <div class="form-row">
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Daños del Vehículo</label>
                            </div>
                            <div class="form-field-content">
                                <textarea style="width: 600px" data-bind="value: xdesobservacion" disabled></textarea>                                                                                            
                            </div>
                        </div>
                    </div>
                </div>

            </fieldset>
        </div>
    </div>
    @* ****************Grid *@
    @**************************@
    <fieldset style="width: 900px;">
        <legend>Mano de Obra</legend>
        <div class="form-row">
            <div class="form-column">
                <input type="button" value="Actualizar" data-bind="click: $root.updMobr, visible: $root.noEsConsulta" />

            </div>
        </div>
        <div data-bind="with: $root.aipinssinmobr, visible: $root.noEsConsulta" class="form-row">
            <div class="form-column">
                <input placeholder="Ej: 220" style="width:40px; float:left;"  type="text" data-bind="enterovalue: $root.idaiprepuextobra, event: { change: $root.buscar_idmanrepuobra}" />
                <input type="text" style="width: 160px; float:left;" id="autocompletado1" placeholder="Ej: Tripoide" data-bind="value: $root.xnomrepmanobra, enable: true" />
                
                <span class="icon-input-delete">
                    <img src="../../publico/imagenes/delete.png" alt="Borrar" class="img-delete" data-bind="click: $root.limpiarRepManObra">
                </span>
                @*<select style="width: 150px" data-bind="options: $root.repuestos, optionsText: 'xnommanrepu', optionsValue: 'idaipmanrepu', value: idaipmanrepu, event: { change: $root.eventoBaremo }"></select>*@
            </div>
            @*<div class="form-column">
                        <select style="width: 150px;" data-bind="options: $root.combomiorigen, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iorigrepuinssinmobr"></select>

                    </div>*@
            <div class="form-column">
                <div class="form-field-content">
                    <select style="width: 150px;" data-bind="options: $root.combotipodano, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: itidainssinmobr, event: { change: $root.eventoBaremo }"></select>
                </div>
            </div>
            <div class="form-column">
                <select style="width: 150px" data-bind="options: $root.comboitipomat, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: itipomatinssinmobr, event: { change: $root.obtener_baremomobr }"></select>
            </div>
            <div class="form-column">
                <input placeholder="Ej: Cantidad" style="width: 50px" type="text" data-bind="enterovalue: ncantinssinmobr" />
            </div>
            <div class="form-column">
                <input style="width: 100px" placeholder="Ej: Monto" data-bind="numeralvalue: nprecfininssinmobr" type="text" />
            </div>
            <div class="form-column">
                <input type="button" value="Agregar" data-bind="click: $root.addMobr" />

            </div>

        </div>
        <div class="grid-area">
            <table class="grid-table">
                <thead>
                    <tr class="grid-row-header" data-bind="foreach: $root.encabezados_aipinssinmobr">
                        <td data-bind="text: titulo"></td>
                    </tr>
                </thead>
                <tbody data-bind='foreach: $root.lista_vi_aipinssinmobr'>
                    <tr class="grid-row-content">
                        <td>
                            <span data-bind='text: xnommanrepu' />
                        </td>
                        <td>
                            <select style="width: 150px;" data-bind="options: $root.combotipodano, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: itidainssinmobr" disabled></select>
                            @*<span data-bind='text: itidainssinmobr' />*@
                        </td>
                        <td>
                            <span data-bind='text: itipomatinssinmobr' />
                        </td>
                        <td>
                            <input style="width: 50px" type="text" data-bind="enterovalue: ncantinssinmobr" />
                        </td>
                        <td>
                            <input style="width: 100px" data-bind="numeralvalue: nprecfininssinmobr" type="text" />
                        </td>
                        <td>
                            <input style="width: 80px;" type="button" value="Eliminar" data-bind="click: $root.delMobr, visible: $root.noEsConsulta" />
                        </td>
                    </tr>
                </tbody>
                <tbody data-bind='visible: lista_vi_aipinssinmobr().length > 0'>
                    <tr class="grid-row-content">
                        <td></td>
                        <td></td>
                        <td>Totales:
                        </td>
                        <td>
                            <span data-bind="enterotext: $root.ncantinssinmobrtotal" />
                        </td>
                        <td>
                            <span data-bind="numeraltext: $root.nprecfininssinmobrtotal" />
                        </td>
                        <td></td>
                    </tr>
                </tbody>

            </table>
            <div class="no-grid-rows" data-bind='visible: $root.lista_vi_aipinssinmobr().length == 0'>No existe mano de obra almacenada...</div>
        </div>


    </fieldset>
    <fieldset style="width: 900px;">
        <legend>Repuestos</legend>
        <div class="form-row">
            <div class="form-column">
                <input type="button" value="Actualizar" data-bind="click: $root.updRepuesto, visible: $root.noEsConsulta" />

            </div>
        </div>
        <div data-bind="with: $root.aipinssinrepu, visible: $root.noEsConsulta" class="form-row">
            <div class="form-column">
                @*<select style="width: 150px;" data-bind="options: $root.repuestos, optionsText: 'xnommanrepu', optionsValue: 'idaipmanrepu', value: idaipmanrepu, event: { change: $root.EventoBaremoRepuesto }"></select>*@
                <input placeholder="Ej: 220" style="width:40px; float:left;" type="text" data-bind="enterovalue: $root.idaiprepuextrepu, event: { change: $root.buscar_idmanrepurepu}" />
                <input type="text" style="width: 160px; float:left;" id="autocompletado2" placeholder="Ej: Tripoide" data-bind="value: $root.xnomreprepuesto, enable: true" />
                
                <span class="icon-input-delete">
                    <img src="../../publico/imagenes/delete.png" alt="Borrar" class="img-delete" data-bind="click: $root.limpiarRepRepuesto">
                </span>
            </div>
            <div class="form-column">
                <select style="width: 150px;" data-bind="options: $root.combomiorigen, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iorigrepuinssinrepu"></select>
            </div>
            <div class="form-column">
                <input style="width: 50px;" placeholder="Ej: Cantidad" type="text" data-bind="enterovalue: ncantinssinrepu" />
            </div>
            <div class="form-column">
                <input style="width: 100px;" placeholder="Ej: Monto" data-bind="numeralvalue: nprecfininssinrepu" type="text" />
            </div>
            <div class="form-column">
                <input type="button" value="Agregar" data-bind="click: $root.addRepuesto" />
            </div>

        </div>
        <div class="grid-area">
            <table class="grid-table">
                <thead>
                    <tr class="grid-row-header" data-bind="foreach: $root.encabezados_aipinssinrepu">
                        <td data-bind="text: titulo"></td>
                    </tr>
                </thead>
                <tbody data-bind='foreach: $root.lista_vi_aipinssinrepu'>
                    <tr class="grid-row-content">

                        <td>
                            <span data-bind="text: xnommanrepu "></span>
                            @*<select style="width: 150px" data-bind="options: $root.repuestos, optionsText: 'xnommanrepu', optionsValue: 'idaipmanrepu', value: idaipsusrepu, event: { change: $root.obtener_origen }"></select>*@
                        </td>
                        <td>
                            <span data-bind="text: iorigrepuinssinrepu "></span>
                            @*<select style="width: 150px" data-bind="options: combosusori, optionsText: 'iorigbarerepu', optionsValue: 'iorigbarerepu', value: idaipsusori, event: { change: $root.obtener_baremo_repuesto }"></select>*@
                        </td>
                        <td>
                            <input style="width: 50px;" type="text" data-bind="enterovalue: ncantinssinrepu" />
                        </td>
                        <td>
                            <input style="width: 100px;" data-bind="numeralvalue: nprecfininssinrepu" type="text" />
                        </td>
                        <td>
                            <input style="width: 80px;" type="button" value="Eliminar" data-bind="click: $root.delRepuesto, visible: $root.noEsConsulta" />
                        </td>
                        <td>
                    </tr>
                </tbody>
                <tbody data-bind='visible: lista_vi_aipinssinrepu().length > 0'>
                    <tr class="grid-row-content">
                        <td></td>
                        <td>Totales:
                        </td>
                        <td>
                            <span data-bind="enterotext: $root.ncantinssinreputotal" />
                        </td>
                        <td>
                            <span data-bind="numeraltext: $root.nprecfininssinreputotal" />
                        </td>
                        <td></td>
                    </tr>
                </tbody>

            </table>
            <div class="no-grid-rows" data-bind='visible: $root.lista_vi_aipinssinrepu().length == 0'>No existe repuestos almacenados...</div>
        </div>


    </fieldset>

    <fieldset style="width: 900px;">
        <legend>Detalle del siniestro</legend>

        <div class="form-row" data-bind="with: $root.vi_aipinssin">
            <div class="form-column">
                <div class="form-field-header">
                    <label>Observaciones</label>
                </div>
                <div class="form-field-content">
                    <textarea style="width: 600px" data-bind="value: xdescinssin"></textarea>
                </div>
            </div>
        </div>
    </fieldset>


    <div class="row" data-bind="visible: $root.perito">
        <div class="grid-top-button">
            <input type="button" value="Pendiente" data-bind="click: guardar" />
        </div>
        <div class="grid-top-button">
            <input type="button" value="Enviar" data-bind="click: enviar" />
        </div>

    </div>
    <div class="row" data-bind="visible: auditor">
        <div class="grid-top-button">
            <input type="button" value="Pendiente" data-bind="click: guardar" />
        </div>
        @*<div class="grid-top-button">
            <input type="button" value="Imprimir" data-bind="click: imprimirSinFoto" />
        </div>*@
        <div class="grid-top-button">
            <input type="button" value="Rechazar" data-bind="click: rechazar" />
        </div>
        <div class="grid-top-button" style="display: none;">
            <input type="button" value="Cancelar" data-bind="click: cancelar" />
        </div>
        <div class="grid-top-button">
            <input type="button" value="Aceptar" data-bind="click: aceptar" />
        </div>

    </div>


    <div class="row" data-bind="visible: esparaAnexo">
        <div class="grid-top-button">
            <input type="button" value="Crear anexo" data-bind="click: crearAnexoNuevo" />
        </div>
    </div>

    <div class="row" data-bind="visible: VisibleImprimirSinfoto">
        <div class="grid-top-button">
            <input type="button" value="Imprimir" data-bind="click: imprimirSinFoto" />
        </div>
    </div>

    <div class="row" data-bind="visible: imprimirfoto">
        <div class="grid-top-button">
            &ensp;&ensp;
            <input type="button" value="Imprimir con fotos" data-bind="click: imprimirConFoto" />
        </div>
    </div>
</fieldset>


<script type="text/javascript">
    function vmInsSinGuardar1(perito, auditor, aprobada) {

        var self = this;
        self.vi_aipinssin = new vi_aipinssin(false);
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.pagvi_aipinssin = new paginacion(1, 10, 0, "it.idaipinssin", "DESC");
        self.lista_vi_aipinssin = ko.observableArray();
        self.aipinssinrepu = new aipinssinrepu(false);
        self.aipinssinmobr = new aipinssinmobr(false);
        self.vi_aipmanveh = new vi_aipmanveh(false);
        self.peraipdatosdeclara = new peraipdatosdeclara(false);

        self.lista_vi_aipinssinrepu = ko.observableArray();
        self.lista_vi_aipinssinmobr = ko.observableArray();
        self.alista_vi_aipinssinmotiv = ko.observableArray();
        self.lista_vi_aipinssinmotiv = ko.observableArray();

        self.sel_idaipinslimsin = ko.observable(0);
        self.repuestos = ko.observableArray();
        self.perito = ko.observable(perito);
        self.auditor = ko.observable(auditor);
        self.aprobada = ko.observable(aprobada);
        self.imprimirfoto = ko.observable(false);
        self.combotraccmanveh = ko.observableArray();
        self.combocolormanveh = ko.observableArray();
        self.combotipotransmanveh = ko.observableArray();
        self.comboclasemanveh = ko.observableArray();
        self.combotraccmanveh = ko.observableArray();
        self.combomanvehmar = ko.observableArray();
        self.combomanvehmod = ko.observableArray();
        self.combomanvehver = ko.observableArray();
        self.combomiorigen = ko.observableArray();
        self.combolug = ko.observableArray();
        self.combotamano = ko.observableArray();
        self.comboitipomat = ko.observableArray();
        self.combotipodano = ko.observableArray();

        self.xnomrepmanobra = ko.observable("");
        self.xnomreprepuesto = ko.observable("");
        
        self.idaiprepuextobra = ko.observable(0);
        self.idaiprepuextrepu = ko.observable(0);
        



        self.cbosucursal = ko.observableArray();
        self.idsegmanorgperit = ko.observable(0);
        self.disabled_sucursal = ko.observable(true);
        self.noEsConsulta = ko.observable(false);
        self.esparaAnexo = ko.observable(false);
        self.ncantinssinmobrtotal = ko.observable(0);
        self.nprecfininssinmobrtotal = ko.observable(0);
        self.ncantinssinreputotal = ko.observable(0);
        self.nprecfininssinreputotal = ko.observable(0);

        self.lista_aiploeve = ko.observableArray();
        self.VisibleImprimirSinfoto = ko.observable(false);

        //$root.ncantinssinmobrtotal
        //$root.nprecfininssinmobrtotal


        self.iniciar = function (vi_aipinsenc, noEsConsulta, esparaAnexo) {            
            self.verificarUsuario();

            if (noEsConsulta == false)
                self.noEsConsulta(false);
            else
                self.noEsConsulta(true);

            //se hace asi para si es null el parametro sea falso la variable
            //alert(esparaAnexo);
            if (esparaAnexo == false)
                self.esparaAnexo(false);
            else
                if (esparaAnexo == true)
                    self.esparaAnexo(true);
                else
                    self.esparaAnexo(false);
            

            //quiere decir que es una consulta
            //if (noEsConsulta == false) {

                postajaxjsonbasico("/Mantenimiento/ObtenerRepuestosActivosBaremo/", "{}", function (lista_aipmanrepu) {

                    var lista = [];
                    var obj = {};
                    for (var i = 0; i < lista_aipmanrepu.length; i++) {
                        obj = { label: lista_aipmanrepu[i].xnommanrepu, value: lista_aipmanrepu[i].idaipmanrepu };
                        lista.push(obj);
                    }

                    $("#autocompletado1").autocomplete({
                        source: lista,

                        //response(lista);
                        //postajaxjsonbasico("/Mantenimiento/ObtenerRepuestosActivosBaremo/", "{}", function (lista_aipmanrepu) {
                        //    response(lista_aipmanrepu);
                        //});
                        //alert($(".autocompletado").val());
                        //alert("prueba")
                        //},
                        minLength: 1,
                        select: function (event, ui) {
                            event.preventDefault();
                            //$(this).val(ui.item.label);
                            self.xnomrepmanobra(ui.item.label);

                            self.buscar_idaiprepuextobra(ui.item.value);
                            self.aipinssinmobr.idaipmanrepu(ui.item.value);                            
                            self.verificarBaremo();
                            //$("#autocomplete2-value").val(ui.item.value);
                        }
                    });

                    $("#autocompletado2").autocomplete({
                        source: lista,
                        minLength: 1,
                        select: function (event, ui) {
                            event.preventDefault();
                            //$(this).val(ui.item.label);
                            self.xnomreprepuesto(ui.item.label);
                            self.buscar_idaiprepuextrepu(ui.item.value);
                            self.aipinssinrepu.idaipmanrepu(ui.item.value);
                            self.verificarBaremoRepuesto();
                        }
                    });
                });

                //var lista = [{ label: 'Option 1', value: 8 }, { label: 'Option 2', value: 5 }];
                //$(".autocompletado").autocomplete({
                //    source: lista,
                //        //console.log(request);
                //        //console.log(request.term);

                //        //var lista = [{ label: 'Option 1', value: 1 }, { label: 'Option 2', value: 2 }];
                //        //response(lista);
                //        //postajaxjsonbasico("/Mantenimiento/ObtenerRepuestosActivosBaremo/", "{}", function (lista_aipmanrepu) {
                //        //    response(lista_aipmanrepu);
                //        //});
                //        //alert($(".autocompletado").val());
                //        //alert("prueba")
                //    //},
                //    minLength: 1,
                //    select: function (event, ui) {
                //        console.log(ui);
                //    }
                //});

            //}
            //else {
            //    //quiere decir que no es consulta
            //}                

            self.limpiar();
            ko.mapping.fromJS(vi_aipinsenc, {}, self.vi_aipinsenc);
            self.cargarSiniestro(vi_aipinsenc.idaipinsenc());
            self.llenarcombomiorigen();
            self.llenarcomboitipomat();
            //self.llenarcombotamano();
            self.llenarcombotipodano();
            self.limpiarRepuesto();
            self.limpiarManoObra();

            self.BuscarModificacionesLogEve(vi_aipinsenc.idaipinsenc());

            //self.obtener_campos2();
            //self.llenarcbosucursal(vi_aipinsenc.idsegmanorgperit());
            //self.buscar();
        }

        self.limpiarRepManObra = function () {
            self.xnomrepmanobra("");
            self.aipinssinmobr.idaipmanrepu(0);
            self.idaiprepuextobra(0);            
        }

        self.limpiarRepRepuesto = function () {
            self.xnomreprepuesto("");
            self.aipinssinrepu.idaipmanrepu(0);            
            self.idaiprepuextrepu(0);
        }


        self.clickM1 = function (obj) {

            for (var i = 0; i < self.lista_vi_aipinssinmotiv().length; i++) {
                if (self.lista_vi_aipinssinmotiv()[i].idaipinssinmotiv() == obj.idaipinssinmotiv()) {
                    self.lista_vi_aipinssinmotiv()[i].itilinssinmotiv(true);
                    obj.itilinssinmotiv(true);
                }
                else
                    self.lista_vi_aipinssinmotiv()[i].itilinssinmotiv(false);

            }



            return true;
        }

        self.llenarcombolugarins = function (itipoperitinsenc) {
            var xconcepto = "ILUGINSSUS";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.combolug(lista_comunconfvalor);

            })
        }


        self.buscar_idaiprepuextobra = function (idaipmanrepu) {
            postajaxjsonbasico("/Inspeccion/ObtenerIdExternoPorIdManRepuestoInterno/?idaipmanrepu=" + idaipmanrepu, "{}", function (idaiprepuext) {
                self.idaiprepuextobra(idaiprepuext);                
            })
        }

        self.buscar_idaiprepuextrepu = function (idaipmanrepu) {
            postajaxjsonbasico("/Inspeccion/ObtenerIdExternoPorIdManRepuestoInterno/?idaipmanrepu=" + idaipmanrepu, "{}", function (idaiprepuext) {
                self.idaiprepuextrepu(idaiprepuext);
            })
        }

        self.buscar_idmanrepuobra = function (obj, event) {
            if (self.idaiprepuextobra() > 0) {
                postajaxjsonbasico("/Inspeccion/ObtenerRepuestoPorIdExterno/?idrepuext=" + self.idaiprepuextobra(), "{}", function (aipmanrepu) {
                    self.xnomrepmanobra(aipmanrepu.xnommanrepu);
                    self.aipinssinmobr.idaipmanrepu(aipmanrepu.idaipmanrepu);
                    self.verificarBaremo();
                })
            }
            else
            {
                self.xnomrepmanobra("");
                self.aipinssinmobr.idaipmanrepu(0);
            }
        }

        self.buscar_idmanrepurepu = function (obj, event) {
            if (self.idaiprepuextrepu() > 0) {
                postajaxjsonbasico("/Inspeccion/ObtenerRepuestoPorIdExterno/?idrepuext=" + self.idaiprepuextrepu(), "{}", function (aipmanrepu) {
                    self.xnomreprepuesto(aipmanrepu.xnommanrepu);
                    self.aipinssinrepu.idaipmanrepu(aipmanrepu.idaipmanrepu);
                    self.verificarBaremoRepuesto();
                })
            }
            else
            {
                self.xnomreprepuesto("");
                self.aipinssinrepu.idaipmanrepu(0);
            }
        }


        self.llenarrepuestos = function () {
            postajaxjsonbasico("/Mantenimiento/ObtenerRepuestosActivosBaremo/", "{}", function (lista_aipmanrepu) {
                self.repuestos(lista_aipmanrepu);
                if (self.vi_aipinssin.idaipinssin() > 0)
                    self.llenar_lista_vi_aipinssinrepu(self.vi_aipinssin.idaipinssin());



            })
        }
        self.llenarcombocolor = function (icolormanveh) {
            var xconcepto = "ICOLORMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.combocolormanveh(lista_comunconfvalor);
                self.vi_aipmanveh.icolormanveh(icolormanveh);
            })
        }
        self.cargarVehiculo = function (idaipmanveh) {
            var auxvi_aipmanveh = new vi_aipmanveh(false);
            postajaxjsonbasico("/Mantenimiento/ObtenerVehiculoPorId/", "{'idaipmanveh': '" + idaipmanveh + "'}", function (vi_aipmanveh) {
                ko.mapping.fromJS(vi_aipmanveh, {}, auxvi_aipmanveh);
                ko.mapping.fromJS(vi_aipmanveh, {}, self.vi_aipmanveh);
                //self.llenar_lista_vi_aipmanvehmar(auxvi_aipmanveh);

                //self.llenarcombotipotransmision(auxvi_aipmanveh);
                //self.llenarcomboclase(auxvi_aipmanveh);
                //self.llenarcombotraccion(auxvi_aipmanveh);
                self.llenarcombocolor(vi_aipmanveh.icolormanveh);
            })
        }

        self.obtdeclaracion = function (idaipinsenc) {
            //var auxperaipdatosdeclara = new peraipdatosdeclara(false);
            postajaxjsonbasico("/Inspeccion/Sp_ObtenerDatosDeclaracion/", "{'idaipinsenc': '" + idaipinsenc + "'}", function (peraipdatosdeclara) {
                //ko.mapping.fromJS(peraipdatosdeclara, {}, auxperaipdatosdeclara);
                ko.mapping.fromJS(peraipdatosdeclara, {}, self.peraipdatosdeclara);                
            })
        }

        self.llenarcombotipotransmision = function (obj) {
            var xconcepto = "ITIPOTRANSMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.combotipotransmanveh(lista_comunconfvalor);
                self.vi_aipmanveh.itipotransmanveh(obj.itipotransmanveh());
            })
        }
        self.llenarcomboclase = function (obj) {
            var xconcepto = "ICLASEMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.comboclasemanveh(lista_comunconfvalor);
                self.vi_aipmanveh.iclasemanveh(obj.iclasemanveh());
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

        self.obtenertotalesmanoobra = function (idaipinssin) {
            postajaxjsonbasico("/Inspeccion/TotalPrecioManoObraSinistroPorIdSin/", "{'idaipinssin': '" + idaipinssin + "'}", function (nprecfininssinmobr) {
                self.nprecfininssinmobrtotal(nprecfininssinmobr);
            });
            postajaxjsonbasico("/Inspeccion/TotalCantidadManoObraSinistroPorIdSin/", "{'idaipinssin': '" + idaipinssin + "'}", function (ncantinssinmobrtotal) {
                self.ncantinssinmobrtotal(ncantinssinmobrtotal);
            });
        }

        self.obtenertotalesrepuesto = function (idaipinssin) {
            postajaxjsonbasico("/Inspeccion/TotalPrecioRepuestoSinistroPorIdSin/", "{'idaipinssin': '" + idaipinssin + "'}", function (nprecfininssinrepu) {
                self.nprecfininssinreputotal(nprecfininssinrepu);
            });
            postajaxjsonbasico("/Inspeccion/TotalCantidadRepuestoSinistroPorIdSin/", "{'idaipinssin': '" + idaipinssin + "'}", function (ncantinssinreputotal) {
                self.ncantinssinreputotal(ncantinssinreputotal);
            });
        }


        self.llenar_lista_vi_aipmanvehmar = function (obj) {
            postajaxjsonbasico("/Mantenimiento/ObtenerMarcasActivas/", "{}", function (lista_vi_aipmanvehmar) {
                self.combomanvehmar(lista_vi_aipmanvehmar);
                self.vi_aipmanveh.idaipmanvehmar(obj.idaipmanvehmar());
                if (typeof self.vi_aipmanveh.idaipmanvehmar() !== "undefined") {
                    if (self.vi_aipmanveh.idaipmanvehmar() != 0) {
                        self.llenar_lista_vi_aipmanvehmod(obj);
                    }
                }
            })
        }
        self.llenar_lista_vi_aipmanvehmod = function (obj) {
            if (typeof obj.idaipmanvehmar() !== "undefined") {
                if (obj.idaipmanvehmar() != 0) {
                    postajaxjsonbasico("/Mantenimiento/ObtenerModelosActivosPorMarca/", "{'idaipmanvehmar': '" + obj.idaipmanvehmar() + "'}", function (lista_vi_aipmanvehmod) {
                        self.combomanvehmod(lista_vi_aipmanvehmod);
                        self.vi_aipmanveh.idaipmanvehmod(obj.idaipmanvehmod());
                        if (typeof obj.idaipmanvehver() !== "undefined") {
                            if (obj.idaipmanvehver() != 0) {
                                self.llenar_lista_vi_aipmanvehver(obj);
                            }
                        }
                    })
                }
            }
        }
        self.llenar_lista_vi_aipmanvehver = function (obj) {
            if (typeof obj.idaipmanvehmod() !== "undefined") {
                postajaxjsonbasico("/Mantenimiento/ObtenerVersionesActivasPorModelo/", "{'idaipmanvehmod': '" + obj.idaipmanvehmod() + "'}", function (lista_vi_aipmanvehver) {
                    self.combomanvehver(lista_vi_aipmanvehver);
                    self.vi_aipmanveh.idaipmanvehver(obj.idaipmanvehver());
                })
            }
        }

        //origen del repuesto
        self.llenarcombomiorigen = function () {
            var xconcepto = "IORIGBAREREPU";
            postajaxjsonbasico("/Comun/ObtenerValores/?xconcepto=" + xconcepto, '{}', function (lista_comunconfvalor) {
                self.combomiorigen(lista_comunconfvalor);
            });
        }

        //tipo material
        self.llenarcomboitipomat = function () {
            var xconcepto = "ITIPOBAREMOBR";
            postajaxjsonbasico("/Comun/ObtenerValores/?xconcepto=" + xconcepto, '{}', function (lista_comunconfvalor) {
                self.comboitipomat(lista_comunconfvalor);
            });
        }

        //tamaño
        self.llenarcombotamano = function () {
            var xconcepto = "ITAMAPIEZBAREMOBR";
            postajaxjsonbasico("/Comun/ObtenerValores/?xconcepto=" + xconcepto, '{}', function (lista_comunconfvalor) {
                self.combotamano(lista_comunconfvalor);
            });
        }

        //tipo de daño
        self.llenarcombotipodano = function () {
            var xconcepto = "ITIDAINSSINMOBR";
            postajaxjsonbasico("/Comun/ObtenerValores/?xconcepto=" + xconcepto, '{}', function (lista_comunconfvalor) {
                self.combotipodano(lista_comunconfvalor);

                if (self.vi_aipinssin.idaipinssin() > 0)
                    self.llenar_lista_vi_aipinssinmobr(self.vi_aipinssin.idaipinssin());
            });
        }


        self.llenar_lista_aipinsmotiv = function (idaipinssin) {
            postajaxjsonbasico("/Inspeccion/ObtenerMotivosInspeccionSinActivos/", "{'idaipinssin': '" + idaipinssin + "'}", function (lista_vi_aipinssinmotiv) {
                ko.mapping.fromJS(lista_vi_aipinssinmotiv, {}, self.alista_vi_aipinssinmotiv);

                ko.utils.arrayForEach(self.alista_vi_aipinssinmotiv(), function (feature) {
                    feature.IsTCheckbox = ko.computed({
                        read: function () {
                            return feature.itilinssinmotiv() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.itilinssinmotiv(true)
                            else feature.itilinssinmotiv(false)
                        }
                    });

                });
                ko.mapping.fromJS(self.alista_vi_aipinssinmotiv, {}, self.lista_vi_aipinssinmotiv);

                //self.lista_aipinssusmotiv(self.groupObsArray(3, self.alista_aipinssusmotiv()));
            })
        }

        self.encabezados_aipinssinrepu = [
        { titulo: 'Repuesto', campo: 'it.idaipmanrepu' },
        { titulo: 'Origen', campo: 'it.iorigrepuinssinrepu' },
        { titulo: 'Cantidad', campo: 'it.ncantinslimsinrepu' },
        { titulo: 'Precio', campo: 'it.nprecfininssinrepu' }
        ];
        self.encabezados_aipinssinmobr = [
           { titulo: 'Repuesto', campo: 'it.idaipmanrepu' },
           { titulo: 'Tipo de Daño', campo: 'it.itaminssinmobr' },
           { titulo: 'Material', campo: 'it.itipomatinssinmobr' },
            //{ titulo: 'Mano de Obra', campo: 'it.iorigrepuinssinmobr' },
            { titulo: 'Cantidad', campo: 'it.ncantinssinmobr' },
            { titulo: 'Precio', campo: 'it.nprecfininssinmobr' }
        ];

        self.BuscarModificacionesLogEve = function (idaipinsenc) {

            postajaxjsonbasico("/Inspeccion/ObtenerLogEvePorEnc/", "{'idaipinsenc': '" + idaipinsenc + "'}", function (lista_aiploeve) {
                ko.mapping.fromJS(lista_aiploeve, {}, self.lista_aiploeve);
            })
        }

        self.limpiar = function () {
            self.aipinssinrepu.ncantinssinrepu(1);
            self.aipinssinmobr.ncantinssinmobr(1);

        }

        self.cargarSiniestro = function (idaipinsenc) {
            postajaxjsonbasico("/Inspeccion/ObtenerInspeccionSiniestroPorIdInsEnc/", "{'idaipinsenc': '" + idaipinsenc + "'}", function (vi_aipinssin) {
                ko.mapping.fromJS(vi_aipinssin, {}, self.vi_aipinssin);
                self.cargarVehiculo(self.vi_aipinssin.idaipmanveh());
                self.obtdeclaracion(self.vi_aipinssin.idaipinsenc());
                self.llenar_lista_aipinsmotiv(self.vi_aipinssin.idaipinssin());
                //self.llenarcbosucursal(self.vi_aipinsenc.idsegmanorgperit());
                self.llenarrepuestos();
                self.llenarcombolugarins("");
                self.llenar_lista_vi_aipinssinrepu(vi_aipinssin.idaipinssin);
                self.llenar_lista_vi_aipinssinmobr(vi_aipinssin.idaipinssin);
                //  self.llenar_lista_aipinssussse(self.vi_aipinssin.idaipinslimsin());
                //self.llenar_lista_aipinssusssm(self.vi_aipinssin.idaipinslimsin());
            })
        }
        self.llenar_lista_vi_aipinssinrepu = function (idaipinssin) {
            postajaxjsonbasico("/Inspeccion/ObtenerRepuestosSiniestro/", "{'idaipinssin': '" + idaipinssin + "'}", function (lista_vi_aipinssinrepu1) {
                ko.mapping.fromJS(lista_vi_aipinssinrepu1, {}, self.lista_vi_aipinssinrepu);
                self.obtenertotalesrepuesto(self.vi_aipinssin.idaipinssin())
            })

        }
        self.llenar_lista_vi_aipinssinmobr = function (idaipinssin) {
            postajaxjsonbasico("/Inspeccion/ObtenerMobrSiniestro/", "{'idaipinssin': '" + idaipinssin + "'}", function (lista_vi_aipinssinmobr1) {
                ko.mapping.fromJS(lista_vi_aipinssinmobr1, {}, self.lista_vi_aipinssinmobr);
                self.obtenertotalesmanoobra(idaipinssin);
            })

        }


        self.obtener_baremo_repuesto = function (obj, event) {
            if (event.originalEvent) {

                //if ((obj.idaipsusori() != "SELECCIONE...")) {
                //    //si el usuario desencadeno el evento
                //    postajaxjsonbasico("/Baremo/ObtenerCostoBareRepu/?idaipmanrepu=" + obj.idaipsusrepu() + "&iorigbarerepu=" + obj.idaipsusori(), '{}', function (mcostbarerepu) {
                //        obj.nprecfininslimsinrepu(mcostbarerepu);
                //        postajaxjsonbasico("/Baremo/ObtenerIdBareRepu/?idaipmanrepu=" + obj.idaipsusrepu() + "&iorigbarerepu=" + obj.idaipsusori(), '{}', function (idaipbarerepu) {
                //            obj.idaipbarerepu(idaipbarerepu);
                //        });
                //    });

                //}
            } else {
                //si el programa desencadeno el evento

            }
        }
        self.obtener_baremomobr = function (obj, event) {
            if (event.originalEvent) {
                //if ((obj.idaipsusmobr() != "SELECCIONE...") && (obj.idaipsustam() != "SELECCIONE...") && (obj.idaipsusmat() != "SELECCIONE...")) {
                //    //si el usuario desencadeno el evento
                //    postajaxjsonbasico("/Baremo/ObtenerCostoBareMobr/?idaipmanrepu=" + obj.idaipsusrepu() + "&itamapiezbaremobr=" + obj.idaipsustam() + "&imaterpiezbaremobr=" + obj.idaipsusmat() + "&itipobaremobr=" + obj.idaipsusmobr(), '{}', function (costo) {
                //        obj.nprecfininslimsinmobr(costo);

                //    });
                //    postajaxjsonbasico("/Baremo/ObtenerIdBareMobr/?idaipmanrepu=" + obj.idaipsusrepu() + "&itamapiezbaremobr=" + obj.idaipsustam() + "&imaterpiezbaremobr=" + obj.idaipsusmat() + "&itipobaremobr=" + obj.idaipsusmobr(), '{}', function (idaipbaremobr) {

                //        obj.idaipbaremobr(idaipbaremobr);

                //    });
                //}
            } else {
                //si el programa desencadeno el evento

            }
        }


        self.limpiarRepuesto = function () {
            self.aipinssinrepu.idaipmanrepu(0);
            self.aipinssinrepu.iorigrepuinssinrepu(0);
            self.aipinssinrepu.ncantinssinrepu(1);
            self.aipinssinrepu.idaipinssin(0)
            self.aipinssinrepu.nprecfininssinrepu(0);
        }

        self.limpiarManoObra = function () {
            self.aipinssinmobr.idaipmanrepu(0);
            self.aipinssinmobr.ncantinssinmobr(1);
            self.aipinssinmobr.iorigrepuinssinmobr("");
            self.aipinssinmobr.itaminssinmobr("");
            self.aipinssinmobr.itipomatinssinmobr("");
            self.aipinssinmobr.nprecfininssinmobr(0);
        }

        self.addRepuesto = function (obj) {

            if (self.aipinssinrepu.idaipmanrepu() == 0) {
                generar_noty_modal("Debe seleccionar el repuesto.", "warning");
                return false;
            }

            if (self.aipinssinrepu.iorigrepuinssinrepu() == "") {
                generar_noty_modal("Debe seleccionar el origen del repuesto.", "warning");
                return false;
            }

            if (self.aipinssinrepu.ncantinssinrepu() == 0) {
                generar_noty_modal("Debe ingresar la cantidad del repuesto.", "warning");
                return false;
            }

            if (self.aipinssinrepu.nprecfininssinrepu() == 0) {
                generar_noty_modal("Debe ingresar el monto del repuesto.", "warning");
                return false;
            }

            self.aipinssinrepu.idaipinssin(self.vi_aipinssin.idaipinssin())
            self.aipinssinrepu.iestatinssinrepu("ACTIVO");
            postajaxjsonbasico("/Inspeccion/AgregarRepuestoSiniestro/", ko.toJSON(self.aipinssinrepu), function (respopera) {
                if (respopera.irespuesta == 1) {
                    self.llenar_lista_vi_aipinssinrepu(self.vi_aipinssin.idaipinssin());
                    //self.aipinssinrepu.idaipinssinrepu(respopera.id)
                    //var obj = ko.mapping.fromJS(ko.mapping.toJS(self.aipinssinrepu));
                    //self.lista_vi_aipinssinrepu.push(obj);
                    //self.aipinssinrepu.idaipinssinrepu(0)
                    self.aipinssinrepu.idaipmanrepu(0);
                    self.aipinssinrepu.iorigrepuinssinrepu(0);
                    self.aipinssinrepu.ncantinssinrepu(1);
                    self.aipinssinrepu.idaipinssin(0)
                    self.aipinssinrepu.nprecfininssinrepu(0);
                    self.idaiprepuextrepu("");
                    generar_noty_auto(respopera.xmsjusuario, "success");
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            });
        }
        self.delRepuesto = function (obj) {
            postajaxjsonbasico("/Inspeccion/EliminarRepuestoSiniestro/?idaipinssinrepu=" + obj.idaipinssinrepu(), "{}", function (respopera) {
                if (respopera.irespuesta == 1) {
                    self.llenar_lista_vi_aipinssinrepu(self.vi_aipinssin.idaipinssin());
                    generar_noty_auto(respopera.xmsjusuario, "success");

                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            });
        }
        self.updRepuesto = function (imensaje) {
            postajaxjsonbasico("/Inspeccion/ActualizarRepuestosSiniestro/", ko.toJSON(self.lista_vi_aipinssinrepu), function (respopera) {
                if (respopera.irespuesta == 1) {
                    if (imensaje != 'NO') {
                        generar_noty_auto(respopera.xmsjusuario, "success");
                        self.obtenertotalesrepuesto(self.vi_aipinssin.idaipinssin());
                    }
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            });
        }

        self.addMobr = function (obj) {

            if (self.aipinssinmobr.idaipmanrepu() == 0) {
                generar_noty_modal("Debe seleccionar el repuesto de la mano de obra.", "warning");
                return false;
            }

            if (self.aipinssinmobr.itidainssinmobr() == "") {
                generar_noty_modal("Debe seleccionar el tipo de daño de la mano de obra.", "warning");
                return false;
            }

            if (self.aipinssinmobr.itipomatinssinmobr() == 0) {
                generar_noty_modal("Debe ingresar el tipo de material de la mano de obra.", "warning");
                return false;
            }

            if (self.aipinssinmobr.ncantinssinmobr() == 0) {
                generar_noty_modal("Debe ingresar la cantidad de la mano de obra.", "warning");
                return false;
            }

            if (self.aipinssinmobr.nprecfininssinmobr() == 0) {
                generar_noty_modal("Debe ingresar el monto de la mano de obra.", "warning");
                return false;
            }
            self.aipinssinmobr.itaminssinmobr("");

            self.aipinssinmobr.idaipinssin(self.vi_aipinssin.idaipinssin())
            self.aipinssinmobr.iestatinssinmobr("ACTIVO");
            postajaxjsonbasico("/Inspeccion/AgregarMobrSiniestro/", ko.toJSON(self.aipinssinmobr), function (respopera) {
                if (respopera.irespuesta == 1) {
                    self.llenar_lista_vi_aipinssinmobr(self.vi_aipinssin.idaipinssin());
                    self.aipinssinmobr.idaipmanrepu(0);
                    self.aipinssinmobr.ncantinssinmobr(1);
                    self.aipinssinmobr.iorigrepuinssinmobr("");
                    self.aipinssinmobr.itaminssinmobr("");
                    self.aipinssinmobr.itipomatinssinmobr("");
                    self.aipinssinmobr.nprecfininssinmobr(0);
                    self.aipinssinmobr.itidainssinmobr("");
                    self.xnomrepmanobra("");
                    self.idaiprepuextobra("");

                    generar_noty_auto(respopera.xmsjusuario, "success");
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            });
        }
        self.delMobr = function (obj) {
            postajaxjsonbasico("/Inspeccion/EliminarMobrSiniestro/?idaipinssinmobr=" + obj.idaipinssinmobr(), "{}", function (respopera) {
                if (respopera.irespuesta == 1) {
                    self.llenar_lista_vi_aipinssinmobr(self.vi_aipinssin.idaipinssin());
                    generar_noty_auto(respopera.xmsjusuario, "success");

                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            });
        }
        self.updMobr = function (imensaje) {
            postajaxjsonbasico("/Inspeccion/ActualizarManoObraSiniestro/", ko.toJSON(self.lista_vi_aipinssinmobr), function (respopera) {
                if (respopera.irespuesta == 1) {
                    if (imensaje != 'NO') {
                        generar_noty_auto(respopera.xmsjusuario, "success");
                        self.obtenertotalesmanoobra(self.vi_aipinssin.idaipinssin());
                    }
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            });
        }

        self.verificarBaremo = function () {

            if (self.aipinssinmobr.idaipmanrepu() != 0 && self.aipinssinmobr.itidainssinmobr() != "") {
                self.buscarBaremoManoObra("MANOOBRA", self.aipinssinmobr.idaipmanrepu(), self.aipinssinmobr.itidainssinmobr());
            }


        }

        

        this.eventoBaremo = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                if (self.aipinssinmobr.idaipmanrepu() != 0 && self.aipinssinmobr.itidainssinmobr() != "") {
                    self.buscarBaremoManoObra("MANOOBRA", self.aipinssinmobr.idaipmanrepu(), self.aipinssinmobr.itidainssinmobr());
                }


            } else {
                //si el programa desencadeno el evento

            }
        }

        self.verificarBaremoRepuesto = function () {

            if (self.aipinssinrepu.idaipmanrepu() != 0) {
                self.buscarBaremoManoObra("REPUESTO", self.aipinssinrepu.idaipmanrepu(), "");
            }


        }

        this.EventoBaremoRepuesto = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento

                if (self.aipinssinrepu.idaipmanrepu() != 0) {
                    self.buscarBaremoManoObra("REPUESTO", self.aipinssinrepu.idaipmanrepu(), "");
                }


            } else {
                //si el programa desencadeno el evento

            }
        }




        self.buscarBaremoManoObra = function (itipobaremo, idaipmanrepu, itidainssinmobr) {

            postajaxjsonbasico("/Inspeccion/ObtenerBaremoManoDeObra/?idaipinsenc=" + self.vi_aipinssin.idaipinsenc() + "&idaipmanrepu=" + idaipmanrepu + "&itidainssinmobr=" + itidainssinmobr, "", function (respopera) {
                if (respopera.irespuesta == 1) {
                    if (itipobaremo == "REPUESTO") {
                        self.aipinssinrepu.nprecfininssinrepu(respopera.id);
                    }
                    else {
                        self.aipinssinmobr.nprecfininssinmobr(respopera.id);
                    }



                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            });
        }

        self.guardar = function (imensaje) {
            self.vi_aipmanveh.xsercarrmanveh(self.vi_aipmanveh.xsercarrmanveh().trim());
            if (self.vi_aipmanveh.xsercarrmanveh().length > 17) {
                generar_noty("El serial de la carroceria debe contener máximo 17 carácteres(digitos)", "error");
                return false;
            }


            var error = false;
            //le agregar los campos del vehiculo.
            postajaxjsonbasico("/Inspeccion/GuardarInspeccionSiniestro/", ko.toJSON(self.vi_aipinssin), function (respopera) {
                if (respopera.irespuesta == 1) {
                    self.limpiar();

                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSinMotivos/", ko.toJSON(self.lista_vi_aipinssinmotiv), function (respopera) {
                        if (respopera.irespuesta == 1) {
                            // generar_noty_auto(respopera.xmsjusuario, "success");
                            self.limpiar();
                        } else {
                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })

                    postajaxjsonbasico("/Inspeccion/ActualizarMantVehiculoYLog/?idaipinsenc=" + self.vi_aipinssin.idaipinsenc(), ko.toJSON(self.vi_aipmanveh), function (respopera) {
                        if (respopera.irespuesta == 1) {
                            self.limpiar();
                        } else {
                            error = true;
                            //alert("Error ActualizarMantVehiculo")
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })

                } else {
                    error = true;
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
                if (!error) {
                    if (imensaje != 'NO') {
                        generar_noty_auto(respopera.xmsjusuario, "success");
                    }
                }
            })
        }
        self.enviar = function () {
            self.vi_aipmanveh.xsercarrmanveh(self.vi_aipmanveh.xsercarrmanveh().trim());
            if (self.vi_aipmanveh.xsercarrmanveh().length > 17) {
                generar_noty_modal("El serial de la carroceria debe contener máximo 17 carácteres(digitos)", "error");
                return false;
            }

            if (self.vi_aipinssin.xdescinssin() == " " || self.vi_aipinssin.xdescinssin() == "") {
                generar_noty_modal("No puede enviar la inspección al auditor sin indicar la observación.", "error");
                return false;
            }            

            postajaxjsonbasico("/Inspeccion/ActualizarMantVehiculoYLog/?idaipinsenc=" + self.vi_aipinssin.idaipinsenc(), ko.toJSON(self.vi_aipmanveh), function (respopera) {
                if (respopera.irespuesta == 1) {

                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSinMotivos/", ko.toJSON(self.lista_vi_aipinssinmotiv), function (respopera) {
                        if (respopera.irespuesta == 1) {

                            postajaxjsonbasico("/Inspeccion/ProcesarInspeccionSiniestro/", ko.toJSON(self.vi_aipinssin), function (respopera) {
                                if (respopera.irespuesta == 1) {
                                    generar_noty_auto(respopera.xmsjusuario, "success");
                                    $("#dlg_InsSinGuardar1").dialog("close");
                                    self.limpiar();
                                } else {
                                    generar_noty_modal(respopera.xmsjusuario, "error");
                                }
                            })

                        } else {
                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })

                } else {
                    error = true;
                    //alert("Error ActualizarMantVehiculo")
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            })



        }

        self.verificarUsuario = function () {            
            postajaxjsonbasico("/Seguridad/ObtenerUsuarioEnSession/", "", function (vi_segusudetperf2) {
                if (vi_segusudetperf2 != null) {                    
                    //si es Administrador
                    if (vi_segusudetperf2.idsegmanperf == 1) {
                        self.llenarcbosucursal(0);
                        self.imprimirfoto(true);
                        self.VisibleImprimirSinfoto(true);

                    }//auditor lider principal
                    else if (vi_segusudetperf2.idsegmanperf == 2) {
                        self.imprimirfoto(true);
                        self.VisibleImprimirSinfoto(true);

                    }//si es Auditor Lider Sucursal                        
                    else
                    {                        
                        self.imprimirfoto(false);
                        if (self.auditor() == true)
                            self.VisibleImprimirSinfoto(true);
                    }
                }
                else {
                    self.imprimirfoto(false);
                    if (self.auditor() == true)
                        self.VisibleImprimirSinfoto(true);
                }
            });            
        }
        


        self.imprimirSinFoto = function () {

            $.fileDownload('/Inspeccion/ImprimirInspeccionSiniestro/?idaipinssin=' + self.vi_aipinssin.idaipinssin() + "&iimprifoto=false", {
                preparingMessageHtml: "Estamos descargando su archivo, por favor espere...",
            });
        }

        self.imprimirConFoto = function () {

            $.fileDownload('/Inspeccion/ImprimirInspeccionSiniestro/?idaipinssin=' + self.vi_aipinssin.idaipinssin() + "&iimprifoto=true", {
                preparingMessageHtml: "Estamos descargando su archivo, por favor espere...",
            });
        }

        self.rechazar = function () {
            postajaxjsonbasico("/Inspeccion/RechazarInspeccionSiniestro/", ko.toJSON(self.vi_aipinssin), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    $("#dlg_InsSinGuardar1").dialog("close");
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            })
        }
        self.cancelar = function () {
            self.guardar('NO');
            self.updMobr('NO');
            self.updRepuesto('NO');
            postajaxjsonbasico("/Inspeccion/CancelarInspeccionSiniestro/", ko.toJSON(self.vi_aipinssin), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    $("#dlg_InsSinGuardar1").dialog("close");
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            })
        }
        self.aceptar = function () {
            self.guardar('NO');
            self.updMobr('NO');
            self.updRepuesto('NO');
            postajaxjsonbasico("/Inspeccion/AceptarInspeccionSiniestro/", ko.toJSON(self.vi_aipinssin), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    $("#dlg_InsSinGuardar1").dialog("close");
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            })
        }

        self.actualizar_lista_vi_aipmanvehver = function (idaipmanvehmod) {
            if (idaipmanvehmod !== "undefined") {
                postajaxjsonbasico("/Mantenimiento/ObtenerVersionesActivasPorModelo/", "{'idaipmanvehmod': '" + idaipmanvehmod + "'}", function (lista_vi_aipmanvehver) {
                    self.combomanvehver(lista_vi_aipmanvehver);
                })
            }
        }

        self.verDetallesAgenda = function () {
            vminsobservsintagenmodal1.cargar(self.vi_aipinsenc.idsegmanorgperit(), self.vi_aipinsenc.xnumsininsenc());
            $("#dlg_insobservsintagenmodal1").dialog("open");
        }

        self.crearAnexoNuevo = function () {

            postajaxjsonbasico("/Inspeccion/VerificarSiEsUltimaInspeccionDelSiniestro//?idaipinsencComparar=" + self.vi_aipinsenc.idaipinsenc() + "&xnumsininsenc=" + self.vi_aipinsenc.xnumsininsenc(), '{}', function (respopera) {
                if (respopera.irespuesta == "1") {
                    vmInsSinAnexGuardarModal1.cargar(self.vi_aipinsenc);
                    $("#dlg_InsSinAnexGuardarModal1").dialog("open");
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            })
        }

        self.ocultarAnexo = function () {
            self.esparaAnexo(false);
        }

    }
</script>
