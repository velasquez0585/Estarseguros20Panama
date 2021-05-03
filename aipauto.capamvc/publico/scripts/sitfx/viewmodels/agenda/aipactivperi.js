var aipactivperi = function (campos_requeridos) {
    var self = this;
    self.idaipactivperi = ko.observable(0);
    self.idsegmanusu = ko.observable(0).extend({
        required: {
            message: "El perito es requerido",
            params: campos_requeridos
        }
    });
    self.combomanusu = ko.observableArray();
    self.idsegmanusucreaactivperi = ko.observable(0);
    self.combomanusucreaactivperi = ko.observableArray();
    self.idcomunmancont = ko.observable(0);
    self.combounmancont = ko.observableArray();
    self.idcomunmanpais = ko.observable(0).extend({
        required: {
            message: "El pais es requerido",
            params: campos_requeridos
        }
    });
    self.combounmanpais = ko.observableArray();
    self.idcomunmanestado = ko.observable(0).extend({
        required: {
            message: "El estado es requerido",
            params: campos_requeridos
        }
    });
    self.combounmanestado = ko.observableArray();
    self.idcomunmanlocalid = ko.observable(0).extend({
        required: {
            message: "La localidad es requerida",
            params: campos_requeridos
        }
    });
    self.combounmanlocalid = ko.observableArray();
    self.fejecactivperi = ko.observable("").extend({
        required: {
            message: "La fecha de la actividad es requerida",
            params: campos_requeridos
        }
    });
    self.ffinejecactivperi = ko.observable("").extend({
        required: {
            message: "La fecha de fin de la actividad es requerida",
            params: campos_requeridos
        }
    });
    self.xdireccionactivperi = ko.observable("").extend({
        required: {
            message: "La direccion del peritaje es requerida",
            params: campos_requeridos
        }
    });
    self.xtelfmovilactivperi = ko.observable("").extend({
        required: {
            message: "El telefono movil es requerido",
            params: campos_requeridos
        }
    });
    self.xcorreoelectronicoactivperi = ko.observable("").extend({
        required: {
            message: "El email es requerido",
            params: campos_requeridos
        }
    });
    self.xtituactivperi = ko.observable("").extend({
        required: {
            message: "El titulo del peritaje es requerido",
            params: campos_requeridos
        }
    });
    self.xdescactivperi = ko.observable("");
    self.ialcanactivperi = ko.observable("");
    self.comboalcanactivperi = ko.observableArray();
    self.iestatactivperi = ko.observable("");
    self.comboestatactivperi = ko.observableArray();
    self.xcoloractivperi = ko.observable("");
    self.xnomcliactivperi = ko.observable("");
    self.xcidaseactivperi = ko.observable("");
    self.xsermotactivperi = ko.observable("");
    self.xsercarractivperi = ko.observable("");
    self.xplacaactivperi = ko.observable("");
    self.idseglogreg = ko.observable(0);
}
