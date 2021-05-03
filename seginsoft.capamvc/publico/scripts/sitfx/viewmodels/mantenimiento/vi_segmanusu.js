var vi_segmanusu = function (campos_requeridos) {

    var self = this;
    self.idsegmanusu = ko.observable(0);
    self.idcomunmanpers = ko.observable(0);
    self.xcedula = ko.observable("").extend({
        required: {
            message: "La cedula del usuario es requerida.",
            params: campos_requeridos
        }
    })/*.extend({
            number: {
                message: "La cédula debe ser númerica."
            }
        })*/.extend({
            minLength: {
                message: "La cédula no puede tener menos de 3 caracteres",
                params: 3
            }
        }).extend({
            maxLength: {
                message: "La cédula no puede exceder los 12 caracteres",
                params: 12
            }
     });

    self.xnombres = ko.observable("").extend({
        required: {
            message: "El nombre del usuario es requerido.",
            params: campos_requeridos
        }
    }).extend({
        maxLength: {
            message: "El nombre no puede exceder los 50 caracteres",
            params: 50
        }
    });
    self.xapellidos = ko.observable("").extend({
        required: {
            message: "El apellido del usuario es requerido.",
            params: campos_requeridos
        }
    }).extend({
        maxLength: {
            message: "El apellido no puede exceder los 50 caracteres",
            params: 50
        }
    });
    self.xnombrecompleto = ko.observable("");
    self.fnacimiento = ko.observable("").extend({
        date: {
            message: "Ingrese una fecha valida"
        }
    });

    self.combosexo = ko.observableArray();
    self.xsexo = ko.observable("").extend({
        required: {
            message: "El sexo es requerido.",
            params: campos_requeridos
        }
    });

    self.combonacionalidad = ko.observableArray();
    self.xnacionalidad = ko.observable("").extend({
        required: {
            message: "La nacionalidad es requerida.",
            params: campos_requeridos
        }
    });

    self.xestatura = ko.observable("");
    self.xmedestatura = ko.observable("");
    self.xpeso = ko.observable("");
    self.xmedpeso = ko.observable("");
    self.idcomunmancom = ko.observable(0);

    self.xtelfoficina1 = ko.observable("").extend({
        required: {
            message: "El telefono 1 es requerido.",
            params: campos_requeridos
        }
    });

    self.xtelfoficina2 = ko.observable("").extend({
        minLength: {
            message: "El telefono de oficina 2 no puede tener menos de 12 caracteres",
            params: 12
        }
    }).extend({
        maxLength: {
            message: "El telefono de oficina 2 no puede exceder de 12 caracteres",
            params: 12
        }
    });

    self.xtelfmovil1 = ko.observable("").extend({
        minLength: {
            message: "El telefono movil 1 no puede tener menos de 12 caracteres",
            params: 12
        }
    }).extend({
        maxLength: {
            message: "El telefono movil 1 no puede exceder de 12 caracteres",
            params: 12
        }
    });

    self.xtelfmovil2 = ko.observable("").extend({
        minLength: {
            message: "El telefono movil 2 no puede tener menos de 12 caracteres",
            params: 12
        }
    }).extend({
        maxLength: {
            message: "El telefono movil 2 no puede exceder de 12 caracteres",
            params: 12
        }
    });


    self.xcorreoelectronico1 = ko.observable("").extend({
        required: {
            message: "El correo electronico 1 es requerido.",
            params: campos_requeridos
        }
    }).extend({
        email: {
            message: "El formato de correo electronico 1 es invalido",
            params: campos_requeridos
        }
    }).extend({
        maxLength: {
            message: "El correo electronico 1 no puede exceder de 50 caracteres",
            params: 50
        }
    });

    self.xcorreoelectronico2 = ko.observable("").extend({
        email: {
            message: "El formato de correo electronico 2 es invalido",
            params: campos_requeridos
        }
    }).extend({
        maxLength: {
            message: "El correo electronico 2 no puede exceder de 50 caracteres",
            params: 50
        }
    });

    self.xtwitter1 = ko.observable("").extend({
        maxLength: {
            message: "El twitter no puede exceder de 50 caracteres",
            params: 50
        }
    });

    self.xfacebook1 = ko.observable("").extend({
        maxLength: {
            message: "El facebook no puede exceder de 50 caracteres",
            params: 50
        }
    });

    self.idcomunmandir = ko.observable(0);

    self.combocontinente = ko.observableArray();
    self.idcomunmancont = ko.observable(0).extend({
        required: {
            message: "El Continente es requerido.",
            params: campos_requeridos
        }
    });

    self.xnombrecont = ko.observable("");

    self.combopais = ko.observableArray();
    self.idcomunmanpais = ko.observable(0).extend({
        required: {
            message: "El Pais es requerido.",
            params: campos_requeridos
        }
    });

    self.xnombrepais = ko.observable("");

    self.comboestado = ko.observableArray();
    self.idcomunmanestado = ko.observable(0).extend({
        required: {
            message: "El Estado es requerido.",
            params: campos_requeridos
        }
    });

    self.xnombreestado = ko.observable("");

    self.combolocalidad = ko.observableArray();
    self.idcomunmanlocalid = ko.observable(0).extend({
        required: {
            message: "La localidad es requerida.",
            params: campos_requeridos
        }
    });

    self.xnombrelocalid = ko.observable("");

    self.xdireccion = ko.observable("").extend({
        required: {
            message: "La direccion es requerida.",
            params: campos_requeridos
        }
    });

    self.comboorganizacion = ko.observableArray();
    self.idsegmanorg = ko.observable(0).extend({
        required: {
            message: "La organizacion es requerida.",
            params: campos_requeridos
        }
    });

    self.xnombrecomercial = ko.observable("");

    self.combodepartamento = ko.observableArray();
    self.idsegmandep = ko.observable(0).extend({
        required: {
            message: "El departamento es requerido.",
            params: campos_requeridos
        }
    });

    self.xnombredep = ko.observable("");

    self.combocargo = ko.observableArray();
    self.idsegmancarg = ko.observable(0).extend({
        required: {
            message: "El cargo es requerido.",
            params: campos_requeridos
        }
    });


    self.xnombrecarg = ko.observable("");
    self.xnombreusuario = ko.observable("");
    self.xcontrasena = ko.observable("");
    self.fcreacion = ko.observable("");
    self.ibloqueado = ko.observable(0);
    self.fultbloqueo = ko.observable("");
    self.fultiniciosesion = ko.observable("");
    self.fultcambpass = ko.observable("");
    self.fultrecuppass = ko.observable("");
    self.xcultura = ko.observable("");
    self.idseglogreg = ko.observable(0);
    self.idsegappperf = ko.observable(0);
}