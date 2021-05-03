function generar_noty(texto, tipo) {
    $(".noty_message").click();
    var n = noty({
        layout: 'bottom',
        theme: 'defaultTheme',
        type: tipo,
        text: texto,
        dismissQueue: false,
        template: '<div class="noty_message"><span class="noty_text"></span><div class="noty_close"></div></div>',
        animation: {
            open: { height: 'toggle' },
            close: { height: 'toggle' },
            easing: 'swing',
            speed: 500
        },
        timeout: false,
        force: false,
        modal: false,
        closeWith: ['click'], // ['click', 'button', 'hover']
        callback: {
            onShow: function () { },
            afterShow: function () { },
            onClose: function () { },
            afterClose: function () { }
        },
        buttons: false
    });
}

function generar_noty_auto(texto, tipo) {
    $(".noty_message").click();
    var n = noty({
        layout: 'bottom',
        theme: 'defaultTheme',
        type: tipo,
        text: texto,
        dismissQueue: false,
        template: '<div class="noty_message"><span class="noty_text"></span><div class="noty_close"></div></div>',
        animation: {
            open: { height: 'toggle' },
            close: { height: 'toggle' },
            easing: 'swing',
            speed: 500
        },
        timeout: 2000,
        force: false,
        modal: false,
        closeWith: ['click'], // ['click', 'button', 'hover']
        callback: {
            onShow: function () { },
            afterShow: function () { },
            onClose: function () { },
            afterClose: function () { }
        },
        buttons: false
    });
}

function generar_noty_modal(texto, tipo) {
    $(".noty_message").click();
    var n = noty({
        layout: 'bottom',
        theme: 'defaultTheme',
        type: tipo,
        text: texto,
        dismissQueue: false,
        template: '<div class="noty_message"><span class="noty_text"></span><div class="noty_close"></div></div>',
        animation: {
            open: { height: 'toggle' },
            close: { height: 'toggle' },
            easing: 'swing',
            speed: 500
        },
        timeout: false,
        force: false,
        modal: true,
        closeWith: ['click'], // ['click', 'button', 'hover']
        callback: {
            onShow: function () { },
            afterShow: function () { },
            onClose: function () { },
            afterClose: function () { }
        },
        buttons: false
    });
}

function generar_noty_confirmacion(texto, botones) {
    $(".noty_message").click();
    var n = noty({
        layout: 'bottom',
        theme: 'defaultTheme',
        text: texto,
        dismissQueue: false,
        template: '<div class="noty_message"><span class="noty_text"></span><div class="noty_close"></div></div>',
        animation: {
            open: { height: 'toggle' },
            close: { height: 'toggle' },
            easing: 'swing',
            speed: 500
        },
        timeout: false,
        force: false,
        modal: true,
        closeWith: ['click'],
        callback: {
            onShow: function () { },
            afterShow: function () { },
            onClose: function () { },
            afterClose: function () { }
        },
        buttons: botones
    });
}