function format_date(jdate) {
    var milli = jdate.replace(/\/Date\((-?\d+)\)\//, '$1');
    var d = new Date(parseInt(milli));

    var dia = d.getDate();
    var mes = d.getMonth() + 1;
    var anio = d.getFullYear();

    if (dia < 10) {
        dia = "0" + dia
    }

    if (mes < 10) {
        mes = "0" + mes
    }

    return dia + "/" + mes + "/" + anio;
}