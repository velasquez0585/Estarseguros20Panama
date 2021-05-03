var paginacion = function (npagactual, npagtamano, npagcantidad, xcamposord, idirord) {
    var self = this;
    self.npagactual = ko.observable(npagactual);
    self.npagtamano = ko.observable(npagtamano);
    self.npagcantidad = ko.observable(npagcantidad);
    self.xcamposord = ko.observable(xcamposord);
    self.idirord = ko.observable(idirord);
}