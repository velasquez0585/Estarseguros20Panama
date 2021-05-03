var aipmanvehmod = function (campos_requeridos) {
    var self = this;
    self.idaipmanvehmod = ko.observable(0);
    self.idaipmanvehmar = ko.observable(0).extend({
        required: {
            message: "El tipo de marca es requerido",
            params: campos_requeridos
        }
    });
    self.combomanvehmar = ko.observableArray();
    self.xnommanvehmod = ko.observable("").extend({
        required: {
            message: "El nombre del modelo es requerido",
            params: campos_requeridos
        }
    });
    self.xdescmanvehmod = ko.observable("");
    self.iestatmanvehmod = ko.observable("");
    self.comboestatmanvehmod = ko.observableArray();
    self.idseglogreg = ko.observable(0);
}
