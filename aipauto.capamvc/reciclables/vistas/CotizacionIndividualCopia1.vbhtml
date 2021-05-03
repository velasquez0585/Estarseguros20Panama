<div class="tab">
    <ul>
        <li><a href="#tab-1">Buscar</a></li>
        <li><a href="#tab-2">Agregar</a></li>
        <li><a href="#tab-3">Ver/Modificar</a></li>
    </ul>
    <div id="tab-1">
        <fieldset id="fs_param_busq_cotiza_indiv" style="width:930px;">
            <legend>Par&aacute;metros de B&uacute;squeda</legend>
            
            @*<b>Filters:</b><br />
            <div data-bind="foreach: filter.filters">
                <div>
                    <span data-bind="text: Name"></span>:<br />
                </div>
                <div data-bind="if: Type == 'select'">
                    <select data-bind="options: Options, optionsText: 'Name', value: CurrentOption"></select>
                </div>
                <div data-bind="if: Type == 'text'">
                    <input type="text" data-bind="value: Value, valueUpdate: 'afterkeydown'" />
                </div>
            </div>
            <br />*@

            <ul id="lista_err_cotiza_indiv" style="display: none;">
                <li data-bind="validationMessage: ncotizacion" style="color: red;"></li>
                <li data-bind="validationMessage: fdesde" style="color: red;"></li>
                <li data-bind="validationMessage: fhasta" style="color: red;"></li>
            </ul>
            
            <div style="float:left;margin:1px;">
                <div class="editor-label">
                    <label>N° Cotizaci&oacute;n</label>
                </div>
                <div class="editor-field">
                    <input placeholder="Ej: 883763" type="number" data-bind="value: ncotizacion" />
                </div>
            </div>
            <div style="float:left;margin:1px;">
                <div class="editor-label">
                    <label>Compa&ntilde;&iacute;a de seguros</label>
                </div>
                <div class="editor-field">
                    <select data-bind="options: lista_ciaseguros, optionsText: 'descripcion', optionsValue: 'codigo', value: xciaseguros"></select>
                </div>
            </div>
            <div style="float:left;margin:1px;">
                <div class="editor-label">
                    <label>Ramo</label>
                </div>
                <div class="editor-field">
                    <select data-bind="options: lista_ramos, optionsText: 'descripcion', optionsValue: 'codigo', value: xramo"></select>
                </div>
            </div>
            <div style="float:left;margin:1px;">
                <div class="editor-label">
                    <label>Ced.Ident/R.U.C.</label>
                </div>
                <div class="editor-field">
                    <input placeholder="Ej: 10996478" type="text" data-bind="value: xcidrifaseg" />
                </div>
            </div>
            <div style="float:left;margin:1px;">
                <div class="editor-label">
                    <label>Fecha desde</label>
                </div>
                <div class="editor-field">
                    <input placeholder="Ej: 01/01/2000" class="date-field" type="text" data-bind="datevalue: fdesde" />
                </div>
            </div>
            <div style="float:left;margin:1px;">
                <div class="editor-label">
                    <label>Fecha hasta</label>
                </div>
                <div class="editor-field">
                    <input placeholder="Ej: 01/01/2000" class="date-field" type="text" data-bind="datevalue: fhasta" />
                </div>
            </div>
            <div style="float: left;margin:1px;">
                <div style="float: left;">
                    <input type="button" value="Buscar" data-bind="click: buscar_cotiza_indiv" />
                </div>
                <div style="float: left;">
                    <input type="button" value="Limpiar" data-bind="click: limpiar_cotiza_indiv" />
                </div>
            </div>
        </fieldset>

        <fieldset id="fs_lista_cotiza_indiv" style="width:930px;">
            <legend>Lista de cotizaciones individuales</legend>
            @*<div data-bind="koGrid: { data: cotizaciones_indiv }"></div>*@

            @*<div data-bind='simpleGrid: grid_cotiza_indiv'> </div>*@

            <b>Filters:</b><br />
            <div data-bind="foreach: filter.filters">
                <div>
                    <span data-bind="text: Name"></span>:<br />
                </div>
                <div data-bind="if: Type == 'select'">
                    <select data-bind="options: Options, optionsText: 'Name', value: CurrentOption"></select>
                </div>
                <div data-bind="if: Type == 'text'">
                    <input type="text" data-bind="value: Value, valueUpdate: 'afterkeydown'" />
                </div>
            </div>
            <br />


            <b>Ordenacion:</b>
            Campo a ordenar:<br />
            <select data-bind="options: sorter.sortOptions, optionsText: 'Name', value: sorter.currentSortOption"></select>
            Tipo orden:
            <select data-bind="options: sorter.sortDirections, optionsText: 'Name', value: sorter.currentSortDirection"></select>
            <br />
            <br />
            <div class="Pager"></div>
            <div class="NoRecords"></div>
            <table data-bind='visible: cotizaciones_indiv().length > 0' cellspacing="10">
                <thead>
                    <tr>
                        <th>N° Cotizaci&oacute;n</th>
                        <th>Compa&ntilde;&iacute;a</th>
                        <th>Ramo</th>
                        <th>Ced.Ident/R.U.C.</th>
                        <th>F/Desde</th>
                        <th>F/Hasta</th>
                    </tr>
                </thead>
                <tbody data-bind='foreach: pager.currentPageRecords'> @*cotizaciones_indiv*@
                    <tr>
                        <td>
                            <span data-bind='text: ncotizacion, uniqueName: true' />
                        </td>
                        <td>
                            <span data-bind='text: xciaseguros' />
                        </td>
                        <td>
                            <span data-bind='text: xramo' />
                        </td>
                        <td>
                            <span data-bind='text: xcidrifaseg' />
                        </td>
                        <td>
                            <span data-bind='text: fdesde' />
                        </td>
                        <td>
                            <span data-bind='text: fhasta' />
                        </td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="6">
                            
                        </td>
                    </tr>
                </tfoot>
            </table>
            @*<div data-bind='visible: cotizaciones_indiv().length == 0'>No existen cotizaciones individuales almacenadas...</div>*@
        </fieldset>
    </div>
    <div id="tab-2">
        Este es el tab 2
    </div>
    <div id="tab-3">
        Este es el tab 3
    </div>
</div>

<script type="text/javascript">
    ko.validation.configure({
        registerExtenders: true,
        messagesOnModified: false,
        insertMessages: false,
        parseInputAttributes: true,
        messageTemplate: null
    });

    var data_lista_ciaseguros = ([
        { codigo: "", descripcion: "SELECCIONAR..." },
        { codigo: "4132", descripcion: "RONTARCA" },
        { codigo: "7366", descripcion: "UNISEGUROS" },
        { codigo: "3213", descripcion: "CONSTITUCION" }
    ])

    var data_lista_ramos = ([
        { codigo: "", descripcion: "SELECCIONAR..." },
        { codigo: "5774", descripcion: "VEHICULO" },
        { codigo: "8622", descripcion: "HCM" },
        { codigo: "8711", descripcion: "INCENDIO" }
    ])

    var data_param_busq_cotiza_indiv = {
        ncotizacion: "",
        xciaseguros: "",
        xramo: "",
        xcidrifaseg: "",
        fdesde: "",
        fhasta: ""
    }

    function vm_param_busq_cotiza_indiv(param_busq_cotiza_indiv, lista_ciaseguros, lista_ramos) {
        var self = this;
        self.ncotizacion = ko.observable(param_busq_cotiza_indiv.ncotizacion).extend({
            number: { message: "La cotización debe ser númerica." }
        });
        self.xciaseguros = ko.observable(param_busq_cotiza_indiv.xciaseguros);
        self.lista_ciaseguros = ko.observableArray(lista_ciaseguros);
        self.xramo = ko.observable(param_busq_cotiza_indiv.xramo);
        self.lista_ramos = ko.observableArray(lista_ramos);
        self.xcidrifaseg = ko.observable(param_busq_cotiza_indiv.xcidrifaseg);
        self.fdesde = ko.observable(param_busq_cotiza_indiv.fdesde).extend({
            date: { message: "La fecha desde es inválida" }
        });
        self.fhasta = ko.observable(param_busq_cotiza_indiv.fhasta).extend({
            date: { message: "La fecha hasta es inválida" }
        });

        self.limpiar_cotiza_indiv = function () {
            ko.mapping.fromJS(data_param_busq_cotiza_indiv, {}, self);
        }

        self.buscar_cotiza_indiv = function () {
            self.errors = ko.validation.group(this);
            if (self.errors().length > 0) {
                generar_noty($('#lista_err_cotiza_indiv').html(), "warning");
                return false;
            }
            
            llamar_ajax_basico("/Cotizacion/Buscar/", ko.toJSON(self), function (resp) {
                if (resp.infomodel.xtitulo == 'Ok') {
                    generar_noty(resp.infomodel.xmensaje, 'success');
                } else {
                    generar_noty(resp.infomodel.xmensaje, 'error');
                }
            })
        }
    }
    ko.applyBindings(new vm_param_busq_cotiza_indiv(data_param_busq_cotiza_indiv, data_lista_ciaseguros, data_lista_ramos), $('#fs_param_busq_cotiza_indiv')[0]);


    //--------------------------------------------------------------------------------------------------------------------
    //http://jsfiddle.net/JTimperley/pyCTN/13/





    //var data_lista_cotiza_indiv = ([
    //    { ncotizacion: "248856", xciaseguros: "Rontarca", xramo: "Vehiculo", xcidrifaseg: "6452212", fdesde: "01/07/2013", fhasta: "10/11/2013" },
    //    { ncotizacion: "250090", xciaseguros: "Uniseguros", xramo: "Vehiculo", xcidrifaseg: "J-57484112-8", fdesde: "15/04/2013", fhasta: "25/09/2013" }
    //])

    //var data_lista_cotiza_indiv = ([])

    //function vm_lista_cotiza_indiv(lista_cotiza_indiv) {
    //    var self = this;
    //    self.cotizaciones_indiv = ko.observableArray(lista_cotiza_indiv);
    //}

    //ko.applyBindings(new vm_lista_cotiza_indiv(data_lista_cotiza_indiv), $('#fs_lista_cotiza_indiv')[0]);






    //--------------------------------------------------------------------------------------------------------------------



    //KO GRID SIMPLE GRID
    //var data_lista_cotiza_indiv = ([
    //    { ncotizacion: "248856", xciaseguros: "Rontarca", xramo: "Vehiculo", xcidrifaseg: "6452212", fdesde: "01/07/2013", fhasta: "10/11/2013" },
    //    { ncotizacion: "250090", xciaseguros: "Uniseguros", xramo: "Vehiculo", xcidrifaseg: "J-57484112-8", fdesde: "15/04/2013", fhasta: "25/09/2013" }
    //])

    //var data_lista_cotiza_indiv = ([])

    //function vm_lista_cotiza_indiv(lista_cotiza_indiv) {
    //    var self = this;
    //    self.cotizaciones_indiv = ko.observableArray(lista_cotiza_indiv);
    //    this.grid_cotiza_indiv = new ko.simpleGrid.viewModel({
    //        data: self.cotizaciones_indiv,
    //        columns: [
    //             { headerText: "N° Cotización", rowText: "ncotizacion" },
    //             { headerText: "Compañía", rowText: "xciaseguros" },
    //             { headerText: "Ramo", rowText: "xramo" },
    //             { headerText: "Cédula/Rif", rowText: "xcidrifaseg" },
    //             { headerText: "Fecha Desde", rowText: "fdesde" },
    //             { headerText: "Fecha Hasta", rowText: "fhasta" }
    //        ],
    //        pageSize: 1
    //    });
    //}
    //ko.applyBindings(new vm_lista_cotiza_indiv(data_lista_cotiza_indiv), $('#fs_lista_cotiza_indiv')[0]);




    //--------------------------------------------------------------------------------------------------------------------

    //KO GRID MANUAL
    //var data_lista_cotiza_indiv = ([
    //    { ncotizacion: "248856", xciaseguros: "Rontarca", xramo: "Vehiculo", xcidrifaseg: "6452212", fdesde: "01/07/2013", fhasta: "10/11/2013" },
    //    { ncotizacion: "250090", xciaseguros: "Uniseguros", xramo: "Vehiculo", xcidrifaseg: "J-57484112-8", fdesde: "15/04/2013", fhasta: "25/09/2013" }
    //])

    //var data_lista_cotiza_indiv = ([])

    //function vm_lista_cotiza_indiv(lista_cotiza_indiv) {
    //    var self = this;
    //    self.cotizaciones_indiv = ko.observableArray(lista_cotiza_indiv);

    //    //this.buscar_cotiza_indiv = function () {
    //    //    this.errors = ko.validation.group(this);
    //    //    if (this.errors().length > 0) {
    //    //        generar_noty($('#lista_err_recuperar_contrasena').html(), "warning");
    //    //        return false;
    //    //    }

    //    //    llamar_ajax("/Seguridad/RecuperarContrasena/", ko.toJSON(this), function (resp) {
    //    //        if (resp.infomodel.xtitulo == 'Ok') {
    //    //            generar_noty(resp.infomodel.xmensaje, 'success');
    //    //            ko.applyBindings(new vm_recuperar(resp.correo));
    //    //        } else {
    //    //            generar_noty(resp.infomodel.xmensaje, 'error');
    //    //            ko.applyBindings(new vm_recuperar(resp.correo));
    //    //        }
    //    //    })
    //    //}
    //}
    //ko.applyBindings(new vm_lista_cotiza_indiv(data_lista_cotiza_indiv), $('#fs_lista_cotiza_indiv')[0]);





    //------------------------------------------------------------------------------------------------------





    //KO GRID AVANZADO A MANO

    









    function PagerModel(records) {
        var self = this;
        self.pageSizeOptions = ko.observableArray([1, 5, 25, 50, 100, 250, 500]);

        self.records = GetObservableArray(records);
        self.currentPageIndex = ko.observable(self.records().length > 0 ? 0 : -1);
        self.currentPageSize = ko.observable(25);
        self.recordCount = ko.computed(function () {
            return self.records().length;
        });
        self.maxPageIndex = ko.computed(function () {
            return Math.ceil(self.records().length / self.currentPageSize()) - 1;
        });
        self.currentPageRecords = ko.computed(function () {
            var newPageIndex = -1;
            var pageIndex = self.currentPageIndex();
            var maxPageIndex = self.maxPageIndex();
            if (pageIndex > maxPageIndex) {
                newPageIndex = maxPageIndex;
            }
            else if (pageIndex == -1) {
                if (maxPageIndex > -1) {
                    newPageIndex = 0;
                }
                else {
                    newPageIndex = -2;
                }
            }
            else {
                newPageIndex = pageIndex;
            }

            if (newPageIndex != pageIndex) {
                if (newPageIndex >= -1) {
                    self.currentPageIndex(newPageIndex);
                }

                return [];
            }

            var pageSize = self.currentPageSize();
            var startIndex = pageIndex * pageSize;
            var endIndex = startIndex + pageSize;
            return self.records().slice(startIndex, endIndex);
        }).extend({ throttle: 5 });
        self.moveFirst = function () {
            self.changePageIndex(0);
        };
        self.movePrevious = function () {
            self.changePageIndex(self.currentPageIndex() - 1);
        };
        self.moveNext = function () {
            self.changePageIndex(self.currentPageIndex() + 1);
        };
        self.moveLast = function () {
            self.changePageIndex(self.maxPageIndex());
        };
        self.changePageIndex = function (newIndex) {
            if (newIndex < 0
                || newIndex == self.currentPageIndex()
                || newIndex > self.maxPageIndex()) {
                return;
            }

            self.currentPageIndex(newIndex);
        };
        self.onPageSizeChange = function () {
            self.currentPageIndex(0);
        };
        self.renderPagers = function () {
            var pager = "<div><a href=\"#\" data-bind=\"click: pager.moveFirst, enable: pager.currentPageIndex() > 0\">&lt;&lt;</a><a href=\"#\" data-bind=\"click: pager.movePrevious, enable: pager.currentPageIndex() > 0\">&lt;</a>Pagina <span data-bind=\"text: pager.currentPageIndex() + 1\"></span> de <span data-bind=\"text: pager.maxPageIndex() + 1\"></span> [<span data-bind=\"text: pager.recordCount\"></span> Registro(s)]<select data-bind=\"options: pager.pageSizeOptions, value: pager.currentPageSize, event: { change: pager.onPageSizeChange }\"></select><a href=\"#\" data-bind=\"click: pager.moveNext, enable: pager.currentPageIndex() < pager.maxPageIndex()\">&gt;</a><a href=\"#\" data-bind=\"click: pager.moveLast, enable: pager.currentPageIndex() < pager.maxPageIndex()\">&gt;&gt;</a></div>";
            $("div.Pager").html(pager);
        };
        self.renderNoRecords = function () {
            var message = "<span data-bind=\"visible: pager.recordCount() == 0\">No se encontraron registros.</span>";
            $("div.NoRecords").html(message);
        };

        self.renderPagers();
        self.renderNoRecords();
    }

    function SorterModel(sortOptions, records) {
        var self = this;
        self.records = GetObservableArray(records);
        self.sortOptions = ko.observableArray(sortOptions);
        self.sortDirections = ko.observableArray([
            {
                Name: "Asc",
                Value: "Asc",
                Sort: false
            },
            {
                Name: "Desc",
                Value: "Desc",
                Sort: true
            }]);
        self.currentSortOption = ko.observable(self.sortOptions()[0]);
        self.currentSortDirection = ko.observable(self.sortDirections()[0]);
        self.orderedRecords = ko.computed(function () {
            var records = self.records();
            var sortOption = self.currentSortOption();
            var sortDirection = self.currentSortDirection();
            if (sortOption == null || sortDirection == null) {
                return records;
            }

            var sortedRecords = records.slice(0, records.length);
            SortArray(sortedRecords, sortDirection.Sort, sortOption.Sort);
            return sortedRecords;
        }).extend({ throttle: 5 });
    }

    function FilterModel(filters, records) {
        var self = this;
        self.records = GetObservableArray(records);
        self.filters = ko.observableArray(filters);
        self.activeFilters = ko.computed(function () {
            var filters = self.filters();
            var activeFilters = [];
            for (var index = 0; index < filters.length; index++) {
                var filter = filters[index];
                if (filter.CurrentOption) {
                    var filterOption = filter.CurrentOption();
                    if (filterOption && filterOption.FilterValue != null) {
                        var activeFilter = {
                            Filter: filter,
                            IsFiltered: function (filter, record) {
                                var filterOption = filter.CurrentOption();
                                if (!filterOption) {
                                    return;
                                }

                                var recordValue = filter.RecordValue(record);
                                return recordValue != filterOption.FilterValue; NoMat
                            }
                        };
                        activeFilters.push(activeFilter);
                    }
                }
                else if (filter.Value) {
                    var filterValue = filter.Value();
                    if (filterValue && filterValue != "") {
                        var activeFilter = {
                            Filter: filter,
                            IsFiltered: function (filter, record) {
                                var filterValue = filter.Value();
                                filterValue = filterValue.toUpperCase();

                                var recordValue = filter.RecordValue(record);
                                recordValue = recordValue.toUpperCase();
                                return recordValue.indexOf(filterValue) == -1;
                            }
                        };
                        activeFilters.push(activeFilter);
                    }
                }
            }

            return activeFilters;
        });
        self.filteredRecords = ko.computed(function () {
            var records = self.records();
            var filters = self.activeFilters();
            if (filters.length == 0) {
                return records;
            }

            var filteredRecords = [];
            for (var rIndex = 0; rIndex < records.length; rIndex++) {
                var isIncluded = true;
                var record = records[rIndex];
                for (var fIndex = 0; fIndex < filters.length; fIndex++) {
                    var filter = filters[fIndex];
                    var isFiltered = filter.IsFiltered(filter.Filter, record);
                    if (isFiltered) {
                        isIncluded = false;
                        break;
                    }
                }

                if (isIncluded) {
                    filteredRecords.push(record);
                }
            }

            return filteredRecords;
        }).extend({ throttle: 200 });
    }

    function ExtractModels(parent, data, constructor) {
        var models = [];
        if (data == null) {
            return models;
        }

        for (var index = 0; index < data.length; index++) {
            var row = data[index];
            var model = new constructor(row, parent);
            models.push(model);
        }

        return models;
    }

    function GetObservableArray(array) {
        if (typeof (array) == 'function') {
            return array;
        }

        return ko.observableArray(array);
    }

    function CompareCaseInsensitive(left, right) {
        if (left == null) {
            return right == null;
        }
        else if (right == null) {
            return false;
        }

        return left.toUpperCase() <= right.toUpperCase();
    }

    function GetOption(name, value, filterValue) {
        var option = {
            Name: name,
            Value: value,
            FilterValue: filterValue
        };
        return option;
    }

    function SortArray(array, direction, comparison) {
        if (array == null) {
            return [];
        }

        for (var oIndex = 0; oIndex < array.length; oIndex++) {
            var oItem = array[oIndex];
            for (var iIndex = oIndex + 1; iIndex < array.length; iIndex++) {
                var iItem = array[iIndex];
                var isOrdered = comparison(oItem, iItem);
                if (isOrdered == direction) {
                    array[iIndex] = oItem;
                    array[oIndex] = iItem;
                    oItem = iItem;
                }
            }
        }

        return array;
    }







    var data_lista_cotiza_indiv = ([
        { ncotizacion: "248856", xciaseguros: "Rontarca", xramo: "Vehiculo", xcidrifaseg: "6452212", fdesde: "01/07/2013", fhasta: "10/11/2013" },
        { ncotizacion: "250090", xciaseguros: "Uniseguros", xramo: "Vehiculo", xcidrifaseg: "J-57484112-8", fdesde: "15/04/2013", fhasta: "25/09/2013" }
    ])

    function vm_lista_cotiza_indiv(lista_cotiza_indiv) {
        var self = this;
        self.cotizaciones_indiv = ko.observableArray(lista_cotiza_indiv);

        var filters = [
            {
                Type: "text",
                Name: "Numero Cotizacion",
                Value: ko.observable(""),
                RecordValue: function (record) { return record.ncotizacion; }
            }
        ];

        var sortOptions = [
            {
                Name: "Compañia",
                Value: "Compañia",
                Sort: function (left, right) { return CompareCaseInsensitive(left.xciaseguros, right.xciaseguros); }
            }
        ];

        self.filter = new FilterModel(filters, self.cotizaciones_indiv);
        self.sorter = new SorterModel(sortOptions, self.filter.filteredRecords);
        self.pager = new PagerModel(self.sorter.orderedRecords);
    }
    ko.applyBindings(new vm_lista_cotiza_indiv(data_lista_cotiza_indiv), $('#fs_lista_cotiza_indiv')[0]);
</script>




























































@*<div class="tab">
    <ul>
        <li><a href="#tab-1">Buscar</a></li>
        <li><a href="#tab-2">Agregar</a></li>
        <li><a href="#tab-3">Ver/Modificar</a></li>
    </ul>
    <div id="tab-1">
        <fieldset id="fs_param_busq_cotiza_indiv" style="width:940px;">
            <legend>Par&aacute;metros de B&uacute;squeda</legend>
            <div style="float:left;">
                <div class="editor-label">
                    <label for="nro_cotizacion">N° Cotizaci&oacute;n</label>
                </div>
                <div class="editor-field">
                    <input id="nro_cotizacion" type="text" data-bind="value: nro_cotizacion" />
                </div>
            </div>
            <div style="float:left;">
                <div class="editor-label">
                    <label for="ciaseguros">Compa&ntilde;&iacute;a de seguros</label>
                </div>
                <div class="editor-field">
                    <input id="ciaseguros" type="text" data-bind="value: ciaseguros" />
                </div>
            </div>
            <div style="float:left;">
                <div class="editor-label">
                    <label for="ramo">Ramo</label>
                </div>
                <div class="editor-field">
                    <input id="ramo" type="text" data-bind="value: ramo" />
                </div>
            </div>
            <div style="float:left;">
                <div class="editor-label">
                    <label for="asegurado">Asegurado</label>
                </div>
                <div class="editor-field">
                    <input id="asegurado" type="text" data-bind="value: asegurado" />
                </div>
            </div>
            <div style="float:left;">
                <div class="editor-label">
                    <label for="fecha_desde">Fecha desde</label>
                </div>
                <div class="editor-field">
                    <input id="fecha_desde" type="text" data-bind="value: fecha_desde" />
                </div>
            </div>
            <div style="float:left;">
                <div class="editor-label">
                    <label for="fecha_hasta">Fecha hasta</label>
                </div>
                <div class="editor-field">
                    <input id="fecha_hasta" type="text" data-bind="value: fecha_hasta" />
                </div>
            </div>
            <div style="float:left;">
                <p>
                    <input id="btn_buscar" type="button" value="Buscar" data-bind="click: buscar_cotiza_indiv" />
                </p>
            </div>
        </fieldset>

        <fieldset id="fs_lista_cotiza_indiv" style="width:940px;">
            <legend>Lista de cotizaciones individuales</legend>
            
            <table data-bind='visible: productos().length > 0'>
                <thead>
                    <tr>
                        <th>Producto</th>
                        <th>Precio</th>
                    </tr>
                </thead>
                <tbody data-bind='foreach: productos'>
                    <tr>
                        <td>
                            <span data-bind='text: name' />
                        </td>
                        <td>
                            <span data-bind='text: price' />
                        </td>
                    </tr>
                </tbody>
            </table>

        </fieldset>
    </div>
    <div id="tab-2">
        Este es el tab 2
    </div>
    <div id="tab-3">
        Este es el tab 3
    </div>
</div>

<script type="text/javascript">
    ko.validation.configure({
        registerExtenders: true,
        messagesOnModified: false,
        insertMessages: false,
        parseInputAttributes: true,
        messageTemplate: null
    });

    var vm_producto = function (productos) {
        this.productos = ko.observableArray(productos);
    };

    var vm_lista_cotiza_indiv = new vm_producto([
        { name: "Tall Hat", price: "39.95" },
        { name: "Long Cloak", price: "120.00" }
    ]);

    ko.applyBindings(vm_lista_cotiza_indiv);
</script>*@




















@*<th data-bind="sort: { arr: cotizaciones_indiv, prop: 'ncotizacion' }">N° Cotizaci&oacute;n</th>
                        <th data-bind="sort: { arr: cotizaciones_indiv, prop: 'xciaseguros' }">Compa&ntilde;&iacute;a</th>
                        <th data-bind="sort: { arr: cotizaciones_indiv, prop: 'xramo' }">Ramo</th>
                        <th data-bind="sort: { arr: cotizaciones_indiv, prop: 'xcidrifaseg' }">C&eacute;dula/Rif</th>
                        <th data-bind="sort: { arr: cotizaciones_indiv, prop: 'fdesde' }">F/Desde</th>
                        <th data-bind="sort: { arr: cotizaciones_indiv, prop: 'fhasta' }">F/Hasta</th>
                        <th data-bind="sort: { arr: cotizaciones_indiv, prop: 'iestatus' }">Estatus</th>*@


@*ko.bindingHandlers.sort = {
        init: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
            var asc = false;
            element.style.cursor = 'pointer';

            element.onclick = function () {
                var value = valueAccessor();
                var prop = value.prop;
                var data = value.arr;

                asc = !asc;
                if (asc) {
                    data.sort(function (left, right) {
                        return left[prop] == right[prop] ? 0 : left[prop] < right[prop] ? -1 : 1;
                    });
                } else {
                    data.sort(function (left, right) {
                        return left[prop] == right[prop] ? 0 : left[prop] > right[prop] ? -1 : 1;
                    });
                }
            }
        }
    };*@