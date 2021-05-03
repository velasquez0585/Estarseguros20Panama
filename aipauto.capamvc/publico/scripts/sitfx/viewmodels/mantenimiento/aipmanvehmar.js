var aipmanvehmar = function (campos_requeridos) {
    var self = this;
    self.idaipmanvehmar = ko.observable(0);
    self.xnommanvehmar = ko.observable("").extend({
        required: {
            message: "El nombre de la marca es requerido",
            params: campos_requeridos
        }
    });
    self.xdescmanvehmar = ko.observable("");
    self.iestatmanvehmar = ko.observable("");
    self.comboestatmanvehmar = ko.observableArray();
    self.idseglogreg = ko.observable(0);
}
