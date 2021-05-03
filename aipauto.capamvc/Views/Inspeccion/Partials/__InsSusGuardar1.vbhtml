<fieldset style="width: 930px;">
    <legend>Formulario de Suscripción</legend>
    <div class="form-row" data-bind="with: vi_aipinsenc">
        <fieldset style="width: 900px;">
            <legend>Datos basicos del cliente</legend>
            <div class="form-row">

                <div class="form-column">
                    <div class="form-field-header">
                        <label>Sucursal:</label>
                    </div>
                    <div class="form-field-content">

                        <input placeholder="Ej: Sucursal" type="text" data-bind="value: xnombrecomercialperit" disabled />
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
                        <label>Fecha de la inspeccion:</label>
                    </div>
                    <div class="form-field-content">
                        <input class="date-field" type="text" data-bind="datevalue: fcreainsenc" disabled />
                    </div>
                </div>
            </div>
            <div class="form-row">
                <div class="form-column">
                    <div class="form-field-header">
                        <label>Cliente:</label>
                    </div>
                    <div class="form-field-content">
                        <input type="text" value="V" class="input20px" disabled />
                        <input placeholder="Ej: 123456" class="input250px" type="text" data-bind="value: xcedpropinsenc" disabled />
                    </div>
                </div>
                <div class="form-column">
                    <div class="form-field-header">
                        <label>Productor:</label>
                    </div>
                    <div class="form-field-content">
                        <input placeholder="Ej: Nombre" type="text" data-bind="value: xnomprodtorinsenc" disabled />
                    </div>
                </div>
                <div class="form-column">
                    <div class="form-field-header">
                        <label>Ramo póliza:</label>
                    </div>
                    <div class="form-field-content">
                        <input placeholder="Ej: Solicitante" type="text" data-bind="value: xnomramopolizinsenc" disabled />
                    </div>

                </div>
            </div>

            <div class="form-row">

               @* <div class="form-column">
                        <div class="form-field-header">
                            <label>Nro. Inspección:</label>
                        </div>
                        <div class="form-field-content">
                            <input placeholder="Ej: Sucursal" type="text" data-bind="value: xnuminspinsenc" disabled />
                        </div>
                    </div>*@

                <div class="form-column">
                    <div class="form-field-header">
                        <label>Producto:</label>
                    </div>
                    <div class="form-field-content">
                        <input placeholder="Ej: 123456" type="text" data-bind="value: xnomprodinsenc" disabled />
                    </div>
                </div>

                <div class="form-column">
                    &nbsp;
                </div>

                <div class="form-column" data-bind="with: $root.cvi_aipinssus">
                    <div class="form-field-header">
                        <label>Tipo de inpección:</label>
                    </div>
                    <div class="form-field-content">
                        <div data-bind="foreach: comboluginssus">
                            <!-- ko if: xvalorcodigo != '' -->
                            <span style="display: inline" data-bind="text: xvalordescripcion"></span>
                            <input name="llugar" type="radio" data-bind="attr: { value: xvalorcodigo }, checked: $root.vi_aipinssus.iluginssus" disabled />
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

                    <div class="form-column font10" style="width: 200px">
                        <span style="display: inline" data-bind="text: xnominsmotiv"></span>
                    </div>
                    <div class="form-column" style="width: 60px; margin-bottom: 30px;">
                        <input type="radio" name="motivoins" data-bind="attr: { value: itilinssusmotiv }, checked: IsTCheckbox, click: $root.clickM1 " />
                        @* <span data-bind="text: itilinssusmotiv"></span>*@

                        @*<input type="checkbox" data-bind="checked: itilinssusmotiv" />*@
                    </div>

                </div>
            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Caracteristicas del vehiculo</legend>
                <div data-bind="with: $root.vi_aipmanveh">
                    <div class="form-row">
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Marca:</label>
                            </div>
                            <div class="form-field-content">
                                <input placeholder="Ej: marca " type="text" data-bind="value: xnommanvehmar" disabled />
                                @*<select style="display: none" data-bind="options: $root.cvi_aipinssus.combomanvehmar, optionsText: 'xnommanvehmar', optionsValue: 'idaipmanvehmar', value: idaipmanvehmar, event: { change: $root.llenar_lista_vi_aipmanvehmod }" disabled></select>*@
                            </div>
                        </div>
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Modelo:</label>
                            </div>
                            <div class="form-field-content">
                                <input placeholder="Ej: modelo " type="text" data-bind="value: xnommanvehmod" disabled />
                                @*<select style="display: none" id="ddl_modelo" data-bind="options: $root.cvi_aipinssus.combomanvehmod, optionsText: 'xnommanvehmod', optionsValue: 'idaipmanvehmod', value: idaipmanvehmod, event: { change: $root.llenar_lista_vi_aipmanvehver }" disabled></select>*@
                            </div>
                        </div>
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Version</label>
                            </div>
                            <div class="form-field-content">
                                <input placeholder="Ej: version " type="text" data-bind="value: xnommanvehver" disabled />
                                @*<select style="display: none" data-bind="options: $root.cvi_aipinssus.combomanvehver, optionsText: 'xnommanvehver', optionsValue: 'idaipmanvehver', value: idaipmanvehver" disabled></select>*@


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
                                <label>Clase:</label>
                            </div>
                            <div class="form-field-content">
                                <input placeholder="Ej: clase " type="text" data-bind="value: iclasemanveh" disabled />
                                @*<select style="display: none" data-bind="options: $root.cvi_aipinssus.comboclasemanveh, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iclasemanveh" disabled></select>*@

                            </div>
                        </div>
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Color Principal:</label>
                            </div>
                            <div class="form-field-content">
                                @*<input placeholder="Ej: clase " type="text" data-bind="value: icolormanveh" disabled />*@
                                <select data-bind="options: $root.cvi_aipinssus.combocolormanveh, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: icolormanveh"></select>
                            </div>
                        </div>

                    </div>

                    <div class="form-row">

                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Placa:</label>
                            </div>
                            <div class="form-field-content">

                                <input placeholder="Ej: 1234-ABCD " type="text" data-bind="value: xplacamanveh" />
                            </div>
                        </div>
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Serial de carroceria</label>
                            </div>
                            <div class="form-field-content">
                                <input placeholder="Ej: 13154ASD654687878" type="text" data-bind="value: xsercarrmanveh" maxlength="17" />
                            </div>

                        </div>
                    </div>
                    <div class="form-row">
                        <div class="form-column">
                            <div class="form-field-header">
                                <label>Serial del motor:</label>
                            </div>
                            <div class="form-field-content">
                                <input type="text" data-bind="value: xsermotmanveh" disabled />
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

                </div>
                <!-- Se muestra esta informacion solo al auditor -->
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
            <fieldset style="width: 900px;">
                <legend>Estado General</legend>
                <div class="form-row header-options" >
                    <div class="form-column" style="width: 17%"></div>
                    <div class="form-column" style="width: 3%">N</div>
                    <div class="form-column" style="width: 3%">L</div>
                    <div class="form-column" style="width: 3%">M</div>
                    <div class="form-column" style="width: 3%">F</div>
                    <div class="form-column" style="width: 3%">B</div>
                    <div class="form-column" style="width: 16%"></div>
                    <div class="form-column" style="width: 3%">N</div>
                    <div class="form-column" style="width: 3%">L</div>
                    <div class="form-column" style="width: 3%">M</div>
                    <div class="form-column" style="width: 3%">F</div>
                    <div class="form-column" style="width: 3%">B</div>
                    <div class="form-column" style="width: 16%"></div>
                    <div class="form-column" style="width: 3%">N</div>
                    <div class="form-column" style="width: 3%">L</div>
                    <div class="form-column" style="width: 3%">M</div>
                    <div class="form-column" style="width: 3%">F</div>
                    <div class="form-column" style="width: 3%">B</div>
                </div>
                <div class="form-row" data-bind="foreach: $root.lista_aipinssusrepuest">
                    <div class="form-row separador-row font10" data-bind="foreach: $data">
                        <div class="form-column" style="width: 17%">
                            <label style="display: none" data-bind="value: idaipinssus"></label>
                            <label style="display: none" data-bind="value: idaipmanrepu"></label>
                            <span style="display: inline; " data-bind="text: xnommanrepu"></span>
                        </div>
                        <div class="form-column" style="width: 15%">
                            <input type="radio" value="true" data-bind="  checked: IsNCheckbox, attr: { 'name': 'myprefix_' + idaipmanrepu() }, click: $root.clickR1, visible: xnommanrepu() != ''" />
                            <input type="radio" value="true" data-bind=" checked: IsLCheckbox, attr: { 'name': 'myprefix_' + idaipmanrepu() }, click: $root.clickR2, visible: xnommanrepu() != ''" />
                            <input type="radio" value="true" data-bind=" checked: IsMCheckbox, attr: { 'name': 'myprefix_' + idaipmanrepu() }, click: $root.clickR3, visible: xnommanrepu() != ''" />
                            <input type="radio" value="true" data-bind=" checked: IsFCheckbox, attr: { 'name': 'myprefix_' + idaipmanrepu() }, click: $root.clickR4, visible: xnommanrepu() != ''" />
                            <input type="radio" value="true" data-bind=" checked: IsBCheckbox, attr: { 'name': 'myprefix_' + idaipmanrepu() }, click: $root.clickR5, visible: xnommanrepu() != ''" />

                        </div>
                    </div>
                </div>

            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Accesorios</legend>
                <div class="form-row header-options">
                    <div class="form-column" style="width: 17%"></div>
                    <div class="form-column" style="width: 3%">N</div>
                    <div class="form-column" style="width: 3%">O</div>
                    <div class="form-column" style="width: 3%">NO</div>
                    <div class="form-column" style="width: 16%"></div>
                    <div class="form-column" style="width: 3%">N</div>
                    <div class="form-column" style="width: 3%">O</div>
                    <div class="form-column" style="width: 3%">NO</div>
                    <div class="form-column" style="width: 16%"></div>
                    <div class="form-column" style="width: 3%">N</div>
                    <div class="form-column" style="width: 3%">O</div>
                    <div class="form-column" style="width: 3%">NO</div>
                </div>
                <div class="form-row" data-bind="foreach: $root.lista_aipinssusacc">
                    <div class="form-row separador-row font10" data-bind="foreach: $data">
                        <div class="form-column" style="width: 17%">

                            <label style="display: none" data-bind="value: idaipinssus"></label>
                            <label style="display: none" data-bind="value: idaipmanvehacc"></label>
                            <span style="display: inline" data-bind="text: xnommanvehacc"></span>
                        </div>
                        <div class="form-column" style="width: 9%">
                            <input type="radio" value="true" data-bind=" checked: IsNRadio, attr: { 'name': 'myacc_' + idaipmanvehacc() }, click: $root.clickRA1" />
                            <input type="radio" value="true" data-bind=" checked: IsORadio, attr: { 'name': 'myacc_' + idaipmanvehacc() }, click: $root.clickRA2" />
                            <input type="radio" value="true" data-bind=" checked: IsNORadio, attr: { 'name': 'myacc_' + idaipmanvehacc() }, click: $root.clickRA3" />

                        </div>
                    </div>
                </div>

            </fieldset>

            <fieldset style="width: 900px;">
                <legend>Información complementaria:</legend>
                <div class="form-row " data-bind="foreach: $root.lista_vi_aipinssusinfcomp">

                    <div class="form-column font10" style="width: 200px;">
                        <span style="display: inline" data-bind="text: xnommaninfcomp"></span>
                    </div>
                    <div class="form-column" style="width: 60px; margin-bottom: 30px;">
                        <input type="checkbox" data-bind="checked: iexisinssusinfcomp" />
                    </div>

                </div>
            </fieldset>

            <fieldset style="width: 900px;">
                <legend>Sistemas de seguridad electronicos</legend>
                <div class="form-row" data-bind="foreach: $root.lista_aipinssussse">

                    <div class="form-column font10" style="width: 150px">

                        <label style="display: none" data-bind="value: idaipinssus"></label>
                        <label style="display: none" data-bind="value: idaipmanvehsse"></label>
                        <span style="display: inline" data-bind="text: xnommanvehsse"></span>
                    </div>
                    <div class="form-column" style="width: 60px; margin-bottom: 30px;">
                        <input type="checkbox" data-bind="checked: iexisinssussse" />
                    </div>

                </div>

            </fieldset>
            <fieldset style="width: 900px;">
                <legend>Sistemas de seguridad mecanicos</legend>
                <div class="form-row" data-bind="foreach: $root.lista_aipinssusssm">

                    <div class="form-column font10" style="width: 150px">

                        <label style="display: none" data-bind="value: idaipinssus"></label>
                        <label style="display: none" data-bind="value: idaipmanvehssm"></label>
                        <span style="display: inline" data-bind="text: xnommanvehssm"></span>

                    </div>
                    <div class="form-column" style="width: 60px; margin-bottom: 30px;">
                        <input type="checkbox" data-bind="checked: iexisinssusssm" />
                    </div>

                </div>

            </fieldset>
            @*<fieldset style="width: 900px;">
                <legend>Levantamiento del serial</legend>
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
            </fieldset>*@
            <fieldset style="width: 900px;">
                <legend>Opinión del riesgo</legend>

                <div class="form-row">
                    <div class="form-column">
                        <div class="form-field-header">
                            <label>Observaciones</label>
                        </div>
                        <div class="form-field-content">
                            <textarea style="width: 600px" data-bind="value: xdictinssus"></textarea>
                        </div>
                    </div>
                </div>
            </fieldset>
        </div>

    </div>
    <div class="row" data-bind="visible: perito">
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
        @* <div class="grid-top-button">
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
    <div class="row" data-bind="visible: VisibleImprimirSinfoto">
        <div class="grid-top-button">
            <input type="button" value="Imprimir" data-bind="click: imprimirSinFoto" />
        </div>
    </div>
    <div class="row" data-bind="visible: imprimirfoto">
        @*<div class="grid-top-button">
            <input type="button" value="Imprimir" data-bind="click: imprimirSinFoto" />
        </div>*@
        <div class="grid-top-button">
            &ensp;&ensp;
           <input type="button" value="Imprimir con fotos" data-bind="click: imprimirConFoto" />
        </div>


    </div>
</fieldset>


<script type="text/javascript">
    function vmInsSusGuardar1(perito, auditor, aprobada) {
        var self = this;
        self.vi_aipinssus = new vi_aipinssus(false);
        self.cvi_aipinssus = new vi_aipinssus(false);
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.pagvi_aipinssus = new paginacion(1, 10, 0, "it.idaipinssus", "DESC");
        self.lista_vi_aipinssus = ko.observableArray();
        self.vi_aipmanveh = new vi_aipmanveh(false);

        self.lista_vi_aipmanvehmar = ko.observableArray();
        self.lista_vi_aipmanvehmod = ko.observableArray();
        self.lista_vi_aipmanvehver = ko.observableArray();
        self.lista_aipinssusmotiv = ko.observableArray();
        self.lista_aipinssusrepuest = ko.observableArray();
        self.lista_aipinssusacc = ko.observableArray();
        self.lista_aipinssussse = ko.observableArray();
        self.lista_aipinssusssm = ko.observableArray();
        self.lista_vi_aipinssusinfcomp = ko.observableArray();
        self.alista_vi_aipinssusinfcomp = ko.observableArray();
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
        self.imprimirfoto = ko.observable(false);
        self.VisibleImprimirSinfoto = ko.observable(false);

        self.lista_aiploeve = ko.observableArray();

        //self.btn_guardar = ko.observable(false);
        //self.btn_enviar = ko.observable(false);

        self.clickR1 = function (obj) {
            //$('input[name=myprefix_' + obj.idaipmanrepu() +']').attr('checked', true);
            //$("#myprefix_" + obj.idaipmanrepu()).prop("checked", true)

            obj.inoapliinssusrepuest(true);
            obj.ileveinssusrepuest(false);
            obj.imedinssusrepuest(false);
            obj.ifueinssusrepuest(false);
            obj.ibueestinssusrepuest(false);

            return true;

        }
        self.clickR2 = function (obj) {
            obj.inoapliinssusrepuest(false);
            obj.ileveinssusrepuest(true);
            obj.imedinssusrepuest(false);
            obj.ifueinssusrepuest(false);
            obj.ibueestinssusrepuest(false);
            return true;
        }
        self.clickR3 = function (obj) {
            obj.inoapliinssusrepuest(false);
            obj.ileveinssusrepuest(false);
            obj.imedinssusrepuest(true);
            obj.ifueinssusrepuest(false);
            obj.ibueestinssusrepuest(false);
            return true;
        }

        self.clickR4 = function (obj) {
            obj.inoapliinssusrepuest(false);
            obj.ileveinssusrepuest(false);
            obj.imedinssusrepuest(false);
            obj.ifueinssusrepuest(true);
            obj.ibueestinssusrepuest(false);
            return true;
        }

        self.clickR5 = function (obj) {
            obj.inoapliinssusrepuest(false);
            obj.ileveinssusrepuest(false);
            obj.imedinssusrepuest(false);
            obj.ifueinssusrepuest(false);
            obj.ibueestinssusrepuest(true);
            return true;
        }

        self.clickRA1 = function (obj) {

            //obj.ioriginssusacc(true);
            //obj.inoexistinssusacc(false);
            //obj.inooriginssusacc(false);

            obj.ioriginssusacc(false);
            obj.inoexistinssusacc(true);
            obj.inooriginssusacc(false);

            return true;
        }

        self.clickRA2 = function (obj) {

            //obj.ioriginssusacc(false);
            //obj.inoexistinssusacc(true);
            //obj.inooriginssusacc(false);

            obj.ioriginssusacc(true);
            obj.inoexistinssusacc(false);
            obj.inooriginssusacc(false);

            return true;
        }

        self.clickRA3 = function (obj) {

            obj.ioriginssusacc(false);
            obj.inoexistinssusacc(false);
            obj.inooriginssusacc(true);

            return true;
        }

        self.clickM1 = function (obj) {


            for (var i = 0; i < self.lista_aipinssusmotiv().length; i++) {
                if (self.lista_aipinssusmotiv()[i].idaipinssusmotiv() == obj.idaipinssusmotiv()) {
                    self.lista_aipinssusmotiv()[i].itilinssusmotiv(true);
                    obj.itilinssusmotiv(true);
                }
                else
                    self.lista_aipinssusmotiv()[i].itilinssusmotiv(false);

            }

            return true;
        }





        self.llenarcombolugarins = function (onj) {
            var xconcepto = "ILUGINSSUS";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.cvi_aipinssus.comboluginssus(lista_comunconfvalor);
            })
        }
        self.llenarcombocolor = function (icolormanveh) {
            var xconcepto = "ICOLORMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.cvi_aipinssus.combocolormanveh(lista_comunconfvalor);
               
                self.vi_aipmanveh.icolormanveh(icolormanveh);
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

                //self.vi_aipmanveh.iclasemanveh(obj);
            })
        }




        self.llenarcombotraccion = function (obj) {
            var xconcepto = "ITRACCMANVEH";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.cvi_aipinssus.combotraccmanveh(lista_comunconfvalor);
            })
        }
        self.llenarcomboestado = function () {
            var idcomunmanpais = 9;
            postajaxjsonbasico("/Comun/ObtenerEstadosPorPais/", "{'idcomunmanpais': '" + idcomunmanpais + "'}", function (lista_comunmanestado) {
                self.cvi_aipinssus.combomanestado(lista_comunmanestado);
            })
        }

        self.llenar_lista_aipinsmotiv = function () {
            postajaxjsonbasico("/Inspeccion/ObtenerMotivosInspeccionSusActivos/", "{'idaipinssus': '" + self.vi_aipinssus.idaipinssus() + "'}", function (lista_aipinssusmotiv) {
                ko.mapping.fromJS(lista_aipinssusmotiv, {}, self.alista_aipinssusmotiv);

                ko.utils.arrayForEach(self.alista_aipinssusmotiv(), function (feature) {
                    feature.IsTCheckbox = ko.computed({
                        read: function () {
                            return feature.itilinssusmotiv() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.itilinssusmotiv(true)
                            else feature.itilinssusmotiv(false)
                        }
                    });

                });
                ko.mapping.fromJS(self.alista_aipinssusmotiv, {}, self.lista_aipinssusmotiv);

                //self.lista_aipinssusmotiv(self.groupObsArray(3, self.alista_aipinssusmotiv()));
            })
        }
        self.llenar_lista_vi_aipmanvehmar = function (obj) {
            postajaxjsonbasico("/Mantenimiento/ObtenerMarcasActivas/", "{}", function (lista_vi_aipmanvehmar) {
                self.cvi_aipinssus.combomanvehmar(lista_vi_aipmanvehmar);
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
                        self.cvi_aipinssus.combomanvehmod(lista_vi_aipmanvehmod);
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
                    self.cvi_aipinssus.combomanvehver(lista_vi_aipmanvehver);
                    self.vi_aipmanveh.idaipmanvehver(obj.idaipmanvehver());
                })
            }
        }

        self.llenar_lista_aipinssusrepuest = function (idaipinssus) {
            //postajaxjsonbasico("/Inspeccion/ObtenerRepuestosSuscripcionEstadGen/", "{'idaipinssus': '" + idaipinssus + "'}", function (lista_aipinssusrepuest) {

            postajaxjsonbasico("/Inspeccion/ObtenerRepuestosSuscripcionEstadGenPorColum/", "{'idaipinssus': '" + idaipinssus + "', 'numColum':3}", function (lista_aipinssusrepuest) {
                ko.mapping.fromJS(lista_aipinssusrepuest, {}, self.alista_aipinssusrepuest);
                ko.utils.arrayForEach(self.alista_aipinssusrepuest(), function (feature) {
                    feature.IsNCheckbox = ko.computed({
                        read: function () {
                            return feature.inoapliinssusrepuest() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.inoapliinssusrepuest(true)
                            else feature.inoapliinssusrepuest(false)
                        }
                    });
                    feature.IsLCheckbox = ko.computed({
                        read: function () {
                            return feature.ileveinssusrepuest() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.ileveinssusrepuest(true)
                            else feature.ileveinssusrepuest(false)
                        }
                    });
                    feature.IsMCheckbox = ko.computed({
                        read: function () {
                            return feature.imedinssusrepuest() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.imedinssusrepuest(true)
                            else feature.imedinssusrepuest(false)
                        }
                    });
                    feature.IsFCheckbox = ko.computed({
                        read: function () {
                            return feature.ifueinssusrepuest() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.ifueinssusrepuest(true)
                            else feature.ifueinssusrepuest(false)
                        }
                    });
                    feature.IsBCheckbox = ko.computed({
                        read: function () {
                            return feature.ibueestinssusrepuest() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.ibueestinssusrepuest(true)
                            else feature.ibueestinssusrepuest(false)
                        }
                    });
                });


                self.lista_aipinssusrepuest(self.groupObsArray(3, self.alista_aipinssusrepuest()));
            })
        }
        self.llenar_lista_aipinssusacc = function (idaipinssus) {
            postajaxjsonbasico("/Inspeccion/ObtenerSuscripcionAccVeh/", "{'idaipinssus': '" + idaipinssus + "'}", function (lista_aipinssusacc) {
                ko.mapping.fromJS(lista_aipinssusacc, {}, self.alista_aipinssusacc);


                ko.utils.arrayForEach(self.alista_aipinssusacc(), function (feature) {
                    feature.IsORadio = ko.computed({
                        read: function () {
                            return feature.ioriginssusacc() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.ioriginssusacc(true)
                            else feature.ioriginssusacc(false)
                        }
                    });
                    feature.IsNRadio = ko.computed({
                        read: function () {
                            return feature.inoexistinssusacc() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.inoexistinssusacc(true)
                            else feature.inoexistinssusacc(false)
                        }
                    });
                    feature.IsNORadio = ko.computed({
                        read: function () {
                            return feature.inooriginssusacc() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.inooriginssusacc(true)
                            else feature.inooriginssusacc(false)
                        }
                    });

                });


                self.lista_aipinssusacc(self.groupObsArray(3, self.alista_aipinssusacc()));
            })
        }

        self.llenar_lista_vi_aipinssusinfcomp = function (idaipinssus) {
            postajaxjsonbasico("/Inspeccion/ObtenerSuscripcionInfComplementaria/", "{'idaipinssus': '" + idaipinssus + "'}", function (lista_vi_aipinssusinfcomp) {
                ko.mapping.fromJS(lista_vi_aipinssusinfcomp, {}, self.alista_vi_aipinssusinfcomp);
                self.lista_vi_aipinssusinfcomp(lista_vi_aipinssusinfcomp);
                //self.lista_vi_aipinssusinfcomp(self.groupObsArray(4, self.alista_vi_aipinssusinfcomp()));
            })
        }


        self.llenar_lista_aipinssussse = function (idaipinssus) {
            postajaxjsonbasico("/Inspeccion/ObtenerSuscripcionSseVeh/", "{'idaipinssus': '" + idaipinssus + "'}", function (lista_aipinssussse) {
                ko.mapping.fromJS(lista_aipinssussse, {}, self.alista_aipinssussse);
                self.lista_aipinssussse(lista_aipinssussse);
                //self.lista_aipinssussse(self.groupObsArray(3, self.alista_aipinssussse()));
            })
        }
        self.llenar_lista_aipinssusssm = function (idaipinssus) {
            postajaxjsonbasico("/Inspeccion/ObtenerSuscripcionSsmVeh/", "{'idaipinssus': '" + idaipinssus + "'}", function (lista_aipinssusssm) {
                ko.mapping.fromJS(lista_aipinssusssm, {}, self.alista_aipinssusssm);
                self.lista_aipinssusssm(lista_aipinssusssm);
                //self.lista_aipinssusssm(self.groupObsArray(3, self.alista_aipinssusssm()));
            })
        }
        self.cargarVehiculo = function (idaipmanveh) {
            var auxvi_aipmanveh = new vi_aipmanveh(false);
            postajaxjsonbasico("/Mantenimiento/ObtenerVehiculoPorId/", "{'idaipmanveh': '" + idaipmanveh + "'}", function (vi_aipmanveh) {
                ko.mapping.fromJS(vi_aipmanveh, {}, auxvi_aipmanveh);
                ko.mapping.fromJS(vi_aipmanveh, {}, self.vi_aipmanveh);
                //self.llenar_lista_vi_aipmanvehmar(auxvi_aipmanveh);

                //self.llenarcombotipotransmision(auxvi_aipmanveh.itipotransmanveh());
                //self.llenarcomboclase(auxvi_aipmanveh.iclasemanveh());
                //self.llenarcombotraccion(auxvi_aipmanveh.itraccmanveh());
                self.llenarcombocolor(vi_aipmanveh.icolormanveh);
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

                self.llenar_lista_vi_aipinssusinfcomp(self.vi_aipinssus.idaipinssus());

            })
        }

        self.BuscarModificacionesLogEve = function (idaipinsenc) {
            postajaxjsonbasico("/Inspeccion/ObtenerLogEvePorEnc/", "{'idaipinsenc': '" + idaipinsenc + "'}", function (lista_aiploeve) {
                ko.mapping.fromJS(lista_aiploeve, {}, self.lista_aiploeve);
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
            self.verificarUsuario();
            ko.mapping.fromJS(vi_aipinsenc, {}, self.vi_aipinsenc);
            self.cargarSuscripcion(vi_aipinsenc.idaipinsenc());
            self.BuscarModificacionesLogEve(vi_aipinsenc.idaipinsenc());

            //self.buscar();
        }


        self.enviar = function () {
            self.vi_aipmanveh.xsercarrmanveh(self.vi_aipmanveh.xsercarrmanveh().trim());
            if (self.vi_aipmanveh.xsercarrmanveh().length > 17) {
                generar_noty_modal("El serial de la carroceria debe contener máximo 17 carácteres(digitos)", "error");
                return false;
            }

            if (self.vi_aipmanveh.xsercarrmanveh() == "") {
                generar_noty_modal("El serial de la carroceria no puede estar vacio.", "error");
                return false;
            }

            if (self.vi_aipmanveh.xplacamanveh() == "") {
                generar_noty_modal("La placa no puede estar vacia.", "error");
                return false;
            }

            if (self.vi_aipinssus.xdictinssus() == " " || self.vi_aipinssus.xdictinssus() == "") {
                generar_noty_modal("No puede enviar la inspección al auditor sin indicar la observación.", "error");
                return false;
            }

            postajaxjsonbasico("/Inspeccion/ActualizarMantVehiculoYLog/?idaipinsenc=" + self.vi_aipinssus.idaipinsenc(), ko.toJSON(self.vi_aipmanveh), function (respopera) {
                if (respopera.irespuesta == 1) {

                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusMotivos/", ko.toJSON(self.lista_aipinssusmotiv), function (respopera) {
                        if (respopera.irespuesta == 1) {

                            postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusRepuEstadGen/", ko.toJSON(self.alista_aipinssusrepuest), function (respopera) {
                                if (respopera.irespuesta == 1) {


                                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusAcc/", ko.toJSON(self.alista_aipinssusacc), function (respopera) {
                                        if (respopera.irespuesta == 1) {
                                            //generar_noty_auto(respopera.xmsjusuario, "success");
                                            //self.limpiar();

                                        } else {

                                            error = true;
                                            generar_noty_modal(respopera.xmsjusuario, "error");
                                        }
                                    })

                                    postajaxjsonbasico("/Inspeccion/ProcesarInspeccionSuscripcion/", ko.toJSON(self.vi_aipinssus), function (respopera) {
                                        if (respopera.irespuesta == 1) {
                                            generar_noty_auto(respopera.xmsjusuario, "success");
                                            $("#dlg_InsSusGuardar1").dialog("close");

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
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })

                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusAcc/", ko.toJSON(self.alista_aipinssusacc), function (respopera) {
                        if (respopera.irespuesta == 1) {

                        } else {

                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })


                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionInfoComplementaria/", ko.toJSON(self.lista_vi_aipinssusinfcomp), function (respopera) {
                        if (respopera.irespuesta == 1) {


                        } else {

                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })


                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusSsm/", ko.toJSON(self.lista_aipinssusssm), function (respopera) {
                        if (respopera.irespuesta == 1) {

                        } else {
                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })
                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusSse/", ko.toJSON(self.lista_aipinssussse), function (respopera) {
                        if (respopera.irespuesta == 1) {

                        } else {
                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })



                }//vehiculo
                else {
                    error = true;
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            })//vehiculo
        };
        self.rechazar = function () {
            postajaxjsonbasico("/Inspeccion/RechazarInspeccionSuscripcion/", ko.toJSON(self.vi_aipinssus), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    $("#dlg_InsSusGuardar1").dialog("close");
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            })
        };
        self.cancelar = function () {
            postajaxjsonbasico("/Inspeccion/CancelarInspeccionSuscripcion/", ko.toJSON(self.vi_aipinssus), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    $("#dlg_InsSusGuardar1").dialog("close");
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            })
        };



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
                    else {
                        self.imprimirfoto(false);
                        if(self.auditor() == true)
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
            $.fileDownload('/Inspeccion/ImprimirInspeccionSuscripcion/?idaipinssus=' + self.vi_aipinssus.idaipinssus() + "&iimprifoto=false", {
                preparingMessageHtml: "Estamos descargando su archivo, por favor espere...",
                failMessageHtml: "Ha ocurrido un error descargando su archivo, por favor intente mas tarde."
            });
        }

        self.imprimirConFoto = function () {
            $.fileDownload('/Inspeccion/ImprimirInspeccionSuscripcion/?idaipinssus=' + self.vi_aipinssus.idaipinssus() + "&iimprifoto=true", {
                preparingMessageHtml: "Estamos descargando su archivo, por favor espere...",
                failMessageHtml: "Ha ocurrido un error descargando su archivo, por favor intente mas tarde."
            });
        }

        self.aceptar = function () {
            self.vi_aipmanveh.xsercarrmanveh(self.vi_aipmanveh.xsercarrmanveh().trim());
            if (self.vi_aipmanveh.xsercarrmanveh().length > 17) {
                generar_noty_modal("El serial de la carroceria debe contener máximo 17 carácteres(digitos)", "error");
                return false;
            }

            if (self.vi_aipinssus.xdictinssus() == " " || self.vi_aipinssus.xdictinssus() == "") {
                generar_noty_modal("No puede enviar la inspección al sir sin indicar la observación.", "error");
                return false;
            }

            postajaxjsonbasico("/Inspeccion/ActualizarMantVehiculoYLog/?idaipinsenc=" + self.vi_aipinssus.idaipinsenc(), ko.toJSON(self.vi_aipmanveh), function (respopera) {
                if (respopera.irespuesta == 1) {

                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusMotivos/", ko.toJSON(self.lista_aipinssusmotiv), function (respopera) {
                        if (respopera.irespuesta == 1) {

                            postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusRepuEstadGen/", ko.toJSON(self.alista_aipinssusrepuest), function (respopera) {
                                if (respopera.irespuesta == 1) {

                                   // alert('guardo informacion general');
                                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusAcc/", ko.toJSON(self.alista_aipinssusacc), function (respopera) {
                                        if (respopera.irespuesta == 1) {
                                            //generar_noty_auto(respopera.xmsjusuario, "success");
                                            //self.limpiar();                                            
                                        } else {

                                            error = true;
                                            generar_noty_modal(respopera.xmsjusuario, "error");
                                        }
                                    })

                                    postajaxjsonbasico("/Inspeccion/AceptarInspeccionSuscripcion/", ko.toJSON(self.vi_aipinssus), function (respopera) {
                                        if (respopera.irespuesta == 1) {
                                            //alert('metodo de aceptar');
                                            generar_noty_auto(respopera.xmsjusuario, "success");
                                            $("#dlg_InsSusGuardar1").dialog("close");
                                        } else {
                                           // alert('metodo de aceptar error');
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
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })

                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusAcc/", ko.toJSON(self.alista_aipinssusacc), function (respopera) {
                        if (respopera.irespuesta == 1) {

                        } else {

                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })


                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionInfoComplementaria/", ko.toJSON(self.lista_vi_aipinssusinfcomp), function (respopera) {
                        if (respopera.irespuesta == 1) {


                        } else {

                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })


                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusSsm/", ko.toJSON(self.lista_aipinssusssm), function (respopera) {
                        if (respopera.irespuesta == 1) {

                        } else {
                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })
                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusSse/", ko.toJSON(self.lista_aipinssussse), function (respopera) {
                        if (respopera.irespuesta == 1) {

                        } else {
                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })



                }//vehiculo
                else {
                    error = true;
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            })//vehiculo

        };
        //self.imprimir = function () {
        //    $.fileDownload('/Inspeccion/ImprimirInspeccionSuscripcion/?fdesde=' + self.fdesde() + '&fhasta=' + self.fhasta(), {
        //        preparingMessageHtml: "Estamos descargando su archivo, por favor espere...",
        //        failMessageHtml: "Ha ocurrido un error descargando su archivo, por favor intente mas tarde."
        //    });
        //    return false;
        //};

        self.guardar = function () {
            self.vi_aipmanveh.xsercarrmanveh(self.vi_aipmanveh.xsercarrmanveh().trim());
            if (self.vi_aipmanveh.xsercarrmanveh().length > 17) {
                generar_noty_modal("El serial de la carroceria debe contener máximo 17 carácteres(digitos)", "error");
                return false;
            }

            var error = false;
            postajaxjsonbasico("/Inspeccion/GuardarInspeccionSuscripcion/", ko.toJSON(self.vi_aipinssus), function (respopera) {
                if (respopera.irespuesta == 1) {

                    self.limpiar();
                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusMotivos/", ko.toJSON(self.lista_aipinssusmotiv), function (respopera) {
                        if (respopera.irespuesta == 1) {
                            // generar_noty_auto(respopera.xmsjusuario, "success");
                            self.limpiar();
                        } else {
                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })
                    postajaxjsonbasico("/Inspeccion/ActualizarMantVehiculoYLog/?idaipinsenc=" + self.vi_aipinssus.idaipinsenc(), ko.toJSON(self.vi_aipmanveh), function (respopera) {
                        if (respopera.irespuesta == 1) {
                            //  generar_noty_auto(respopera.xmsjusuario, "success");
                            self.limpiar();
                        } else {
                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })
                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusRepuEstadGen/", ko.toJSON(self.alista_aipinssusrepuest), function (respopera) {
                        if (respopera.irespuesta == 1) {
                            //generar_noty(respopera.xmsjusuario, "success");
                            self.limpiar();
                        } else {
                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })
                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusAcc/", ko.toJSON(self.alista_aipinssusacc), function (respopera) {
                        if (respopera.irespuesta == 1) {
                            generar_noty_auto(respopera.xmsjusuario, "success");
                            self.limpiar();

                        } else {

                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })


                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionInfoComplementaria/", ko.toJSON(self.lista_vi_aipinssusinfcomp), function (respopera) {
                        if (respopera.irespuesta == 1) {
                            generar_noty_auto(respopera.xmsjusuario, "success");
                            self.limpiar();

                        } else {

                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })


                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusSsm/", ko.toJSON(self.lista_aipinssusssm), function (respopera) {
                        if (respopera.irespuesta == 1) {
                            //   generar_noty_auto(respopera.xmsjusuario, "success");
                            self.limpiar();
                        } else {
                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })
                    postajaxjsonbasico("/Inspeccion/ActualizarInspeccionSusSse/", ko.toJSON(self.lista_aipinssussse), function (respopera) {
                        if (respopera.irespuesta == 1) {
                            // generar_noty_auto(respopera.xmsjusuario, "success");
                            self.limpiar();
                        } else {
                            error = true;
                            generar_noty_modal(respopera.xmsjusuario, "error");
                        }
                    })
                } else {
                    error = true;
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }

            })
        }


        self.groupObsArray = function (itemsPerGroup, observableArray) {
            console.log(observableArray);
            return ko.computed(function () {
                var obsArrData = observableArray;
                var groupedItems = [];
                var group = itemsPerGroup;
                var ngroup = 0;//para saber cual es la ultima lista de grupos y hacerlo fuera del for
                var aGroup = [];
                
                for (var i = 0; i < obsArrData.length; i++) {                   

                    aGroup.push(obsArrData[i]);
                    ngroup = ngroup + 1;
                    if (ngroup == group)
                    {
                        groupedItems.push(aGroup);
                        aGroup = [];
                        ngroup = 0;
                    }
                    
                    /*
                    if ((i % group === 0) && (i != 0) && (ngroup < group)) {
                        groupedItems.push(aGroup);                        
                        aGroup = [];                        
                    }
                    aGroup.push(obsArrData[i]);*/
                }
                if (ngroup < group)
                {
                    groupedItems.push(aGroup);
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



        self.agregar_version = function () {

            if (self.vi_aipmanveh.idaipmanvehmar() != 0 && self.vi_aipmanveh.idaipmanvehmod() != 0) {

                vmmanversionnuevo1.cargar();
                $("#dlg_manversionnuevo1").dialog("open");
                $("#dlg_manversionnuevo1").dialog({
                    close: function (event, ui) {
                        self.actualizar_lista_vi_aipmanvehver(self.vi_aipmanveh.idaipmanvehmod());
                    }
                });

            } else {
                generar_noty_modal("Disculpe, Debe seleccionar la marca y modelo para agregar versiones.", "information");
            }
        }

        self.actualizar_lista_vi_aipmanvehver = function (idaipmanvehmod) {
            if (idaipmanvehmod !== "undefined") {
                postajaxjsonbasico("/Mantenimiento/ObtenerVersionesActivasPorModelo/", "{'idaipmanvehmod': '" + idaipmanvehmod + "'}", function (lista_vi_aipmanvehver) {
                    self.cvi_aipinssus.combomanvehver(lista_vi_aipmanvehver);
                })
            }
        }
    }
</script>
