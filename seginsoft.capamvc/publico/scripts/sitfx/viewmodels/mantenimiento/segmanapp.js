var segmanapp = function (campos_requeridos) {

    var self = this;

    self.idsegmanapp = ko.observable(0);

    self.xnombrecorto = ko.observable("").extend({
        required: {
            message: "El Nombre Corto es requerido.",
            params: campos_requeridos
        }
    });

    self.xnombrelargo = ko.observable("").extend({
        required: {
            message: "El Nombre Largo es requerido.",
            params: campos_requeridos
        }
    });
    self.comboaplicacion = ko.observableArray();

    self.xtipoapp = ko.observable("").extend({
        required: {
            message: "El tipo de aplicación es requerido.",
            params: campos_requeridos
        }
    });
    self.combotipoapp = ko.observableArray();

    self.xso = ko.observable("").extend({
        required: {
            message: "El Sistema operativo es requerido.",
            params: campos_requeridos
        }
    });
    self.comboso = ko.observableArray();

    self.xdesatec = ko.observable("").extend({
        required: {
            message: "La tecnología de desarrollo es requerida.",
            params: campos_requeridos
        }
    });
    self.combodesatec = ko.observableArray();

    self.fimplementacion = ko.observable("");

    self.xtipoapp = ko.observable("").extend({
        required: {
            message: "El tipo de aplicación es requerido.",
            params: campos_requeridos
        }
    });

    self.fimplementacion = ko.observable("");

    self.xobjetivo = ko.observable("").extend({
        required: {
            message: "El objetivo es requerido.",
            params: campos_requeridos
        }
    });

    self.idsegmanorg = ko.observable("");
    
    
}