var vi_aipbaremobr = function (campos_requeridos) {
    var self = this;
    self.idaipbaremobr = ko.observable(0);
    self.combobaremobr = ko.observableArray();
    self.idaipmanrepu = ko.observable(0);
    self.combomanrepu = ko.observableArray();
    self.xnommanrepu = ko.observable("");
    self.faplibaremobr = ko.observable("") ;
    self.itipobaremobr = ko.observable("").extend({
       
        required: {
            message: "Tipo mano de obra es requerido.",
        }
    });
    self.combotipobaremobr = ko.observableArray();
    self.itamapiezbaremobr = ko.observable("").extend({

        required: {
            message: "Tamaño de la pieza es requerido.",
        }
    });
    self.combotamapiezbaremobr = ko.observableArray();
    self.imaterpiezbaremobr = ko.observable("").extend({

        required: {
            message: "Material de la pieza es requerido.",
        }
    });;
    self.combomaterpiezbaremobr = ko.observableArray();
    self.mcostbaremobr = ko.observable(0);
    self.xdescbaremobr = ko.observable("");
}
