var vi_segmanusu = function (campos_requeridos) {
    var self = this;
    self.idsegmanusu = ko.observable(0);
    self.combomanusu = ko.observableArray();
    self.idcomunmanpers = ko.observable(0);
    self.combounmanpers = ko.observableArray();
    self.xcedula = ko.observable("").extend({
        required: {
            message: "La Ced.Ident/R.U.C. es requerida",
            params: campos_requeridos
        },
        minLength: {
            message: "La Ced.Ident/R.U.C. no puede tener menos de 1 caracteres",
            params: 1
        },
        maxLength: {
            message: "La Ced.Ident/R.U.C. no puede tener mas de 20 caracteres",
            params: 20
        },
        number: {
            message: "La Ced.Ident/R.U.C. debe ser númerica."
        }
    });
    self.xnombres = ko.observable("").extend({
        required: {
            message: "El nombre es requerido",
            params: campos_requeridos
        },
        minLength: {
            message: "El nombre no puede tener menos de 1 caracter",
            params: 1
        },
        maxLength: {
            message: "El nombre no puede tener mas de 50 caracteres",
            params: 50
        }
    });
    self.xapellidos = ko.observable("").extend({
        required: {
            message: "El apellido es requerido",
            params: campos_requeridos
        },
        minLength: {
            message: "El apellido no puede tener menos de 1 caracter",
            params: 1
        },
        maxLength: {
            message: "El apellido no puede tener mas de 50 caracteres",
            params: 50
        }
    });
    self.xnombrecompleto = ko.observable("");

    self.fnacimiento = ko.observable("01/01/1900").extend({
        required: {
            message: "La fecha de nacimiento es requerida",
            params: campos_requeridos
        }
    });

    self.xsexo = ko.observable("").extend({
        required: {
            message: "El sexo es requerido",
            params: campos_requeridos
        }
    });
    self.xnacionalidad = ko.observable("").extend({
        required: {
            message: "La nacionalidad es requerida",
            params: campos_requeridos
        }
    });

    self.xestatura = ko.observable("");
    self.xmedestatura = ko.observable("");
    self.xpeso = ko.observable("");
    self.xmedpeso = ko.observable("");
    self.idcomunmancom = ko.observable(0);
    self.combounmancom = ko.observableArray();
    self.xtelfmovil1 = ko.observable("").extend({
        required: {
            message: "El telefono movil es requerido",
            params: campos_requeridos
        }
    });
    self.xtelfmovil2 = ko.observable("");
    self.xtelfoficina1 = ko.observable("");
    self.xtelfoficina2 = ko.observable("");
    self.xcorreoelectronico1 = ko.observable("").extend({
        required: {
            message: "El correo electronico es requerido",
            params: campos_requeridos
        },
        email: {
            message: "El formato de correo es invalido."
        },
        minLength: {
            message: "El correo electronico no puede tener menos de 5 caracteres",
            params: 5
        },
        maxLength: {
            message: "El correo electronico no puede tener mas de 50 caracteres",
            params: 50
        }
    });
    self.xcorreoelectronico2 = ko.observable("");
    self.xtwitter1 = ko.observable("");//.extend({
    //    minLength: {
    //        message: "La direccion url de twitter no puede tener menos de 7 caracteres",
    //        params: 7
    //    },
    //    maxLength: {
    //        message: "La direccion url de twitter no puede tener mas de 200 caracteres",
    //        params: 200
    //    }
    //});
    self.xfacebook1 = ko.observable("");//.extend({
    //    minLength: {
    //        message: "La direccion url de facebook no puede tener menos de 7 caracteres",
    //        params: 7
    //    },
    //    maxLength: {
    //        message: "La direccion url de facebook no puede tener mas de 200 caracteres",
    //        params: 200
    //    }
    //});
    self.idcomunmandir = ko.observable(0);
    self.combounmandir = ko.observableArray();
    self.idcomunmancont = ko.observable(0);
    self.combounmancont = ko.observableArray();
    self.xnombrecont = ko.observable("");
    self.idcomunmanpais = ko.observable(0);
    self.combounmanpais = ko.observableArray();
    self.xnombrepais = ko.observable("");
    self.idcomunmanestado = ko.observable(0);
    self.combounmanestado = ko.observableArray();
    self.xnombreestado = ko.observable("");
    self.idcomunmanlocalid = ko.observable(0);
    self.combounmanlocalid = ko.observableArray();
    self.xnombrelocalid = ko.observable("");
    self.xdireccion = ko.observable("");
    self.idsegmanorg = ko.observable(0);
    self.combomanorg = ko.observableArray();
    self.xnombrecomercial = ko.observable("");
    self.idsegmandep = ko.observable(0);
    self.combomandep = ko.observableArray();
    self.xnombredep = ko.observable("");
    self.idsegmancarg = ko.observable(0);
    self.combomancarg = ko.observableArray();
    self.xnombrecarg = ko.observable("");
    self.xnombreusuario = ko.observable("");
    self.xcontrasena = ko.observable("").extend({
        required: {
            message: "La contraseña es requerida",
            params: campos_requeridos
        },
        minLength: {
            message: "La contraseña no puede ser menor de 5 caracteres",
            params: 5
        },
        maxLength: {
            message: "La contraseña no puede ser mayor de 12 caracteres",
            params: 12
        }
    });
    self.fcreacion = ko.observable("");
    self.ibloqueado = ko.observable(false);
    self.fultbloqueo = ko.observable("");
    self.fultiniciosesion = ko.observable("");
    self.fultcambpass = ko.observable("");
    self.fultrecuppass = ko.observable("");
    self.xcultura = ko.observable("");
    self.idseglogreg = ko.observable(0);
}
