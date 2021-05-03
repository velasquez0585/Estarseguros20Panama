var segmanperf = function (campos_requeridos) {

    var self = this;
    self.idsegmanperf = ko.observable(0);
    self.xabrevperf = ko.observable("").extend({
        required: {
            message: "La abreviatura del perfil es requerida.",
            params: campos_requeridos
        }
    });

    self.xnombreperf = ko.observable("").extend({
        required: {
            message: "El Nombre de perfil es requerido.",
            params: campos_requeridos
        }
    });
    self.nnivelperf = ko.observable("").extend({
        required: {
            message: "El Nivel de perfil es requerido.",
            params: campos_requeridos
        },
        digit: {
            message: "Ingrese solo dígitos en el nivel de perfil."
        }
    });
    self.idseglogreg = ko.observable(0);
    
}