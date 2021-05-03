$(function () {
    $.ajaxSetup({
        type: "POST",
        contentType: "application/json",
        dataType: "json",
        cache: false,
        beforeSend: function (jqXHR, settings) {
            $("#popup_cargando").show();
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert('Ha ocurrido un error crítico. (' + textStatus + ' / ' + jqXHR.status + ' / ' + errorThrown + ')');
            //if (x.status == 403) {
            //    alert("Tu sesión ha expirado. Por favor inicia sesión nuevamente para continuar.");
            //    window.location.href = "http://mundosigma.sigmadental.net/mundosigma";
            //}
            //else {
            //    alert('Ha ocurrido un error. Notifique a Sistemas. Codigo: ' + x.status);
            //}
        },
        complete: function (jqXHR, textStatus) {
            //textStatus: "success", "notmodified", "error", "timeout", "abort", or "parsererror"
            $("#popup_cargando").hide();
        }
    });
});

function postajaxjsontodo(url, data, fnbeforesend, fnsuccess, fnerror, fncomplete) {
    $.ajax({
        url: url,
        data: data,
        beforeSend: fnbeforesend,
        success: fnsuccess,
        error: fnerror,
        complete: fncomplete
    });
}

function postajaxjsontodosinerror(url, data, fnbeforesend, fnsuccess, fncomplete) {
    $.ajax({
        url: url,
        data: data,
        beforeSend: fnbeforesend,
        success: fnsuccess,
        complete: fncomplete
    });
}

function postajaxjsonbasico(url, data, fnsuccess) {
    $.ajax({
        url: url,
        data: data,
        success: fnsuccess
    });
}

function postajaxjsonpbasico(url, data, fncallback) {
    $.ajax({
        url: url,
        data: data,
        dataType: 'jsonp',
        callback: fncallback
    });
}