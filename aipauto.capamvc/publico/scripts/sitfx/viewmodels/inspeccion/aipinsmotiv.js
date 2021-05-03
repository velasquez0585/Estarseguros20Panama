var aipinsmotiv = function (campos_requeridos) {
    var self = this;
    self.idaipinsmotiv = ko.observable(0);
    self.xnominsmotiv = ko.observable("");
    self.xdescinsmotiv = ko.observable("");
    self.iestatinsmotiv = ko.observable("");
    self.comboestatinsmotiv = ko.observableArray();
    self.idseglogreg = ko.observable(0);

    self.isel = ko.observable(false);
}
