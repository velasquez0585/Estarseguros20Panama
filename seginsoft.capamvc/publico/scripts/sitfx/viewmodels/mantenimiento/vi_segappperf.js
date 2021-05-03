var vi_segappperf = function (campos_requeridos) {

    var self = this;
    self.idsegappperf = ko.observable(0);
    self.idsegmanapp = ko.observable(0);
    self.idsegmanperf = ko.observable(0);
    
    self.xnombrecorto = ko.observable("").extend({
        required: {
            message: "El nombre corto es requerido.",
            params: campos_requeridos
        }
    });

    self.xabrevperf = ko.observable("").extend({
        required: {
            message: "La abreviatura del perfil es requerido.",
            params: campos_requeridos
        }
    });
    self.xnombreperf = ko.observable("").extend({
        required: {
            message: "El nombre del perfil es requerido.",
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