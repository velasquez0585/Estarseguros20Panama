$(function () {
    // el elemento al que queremos hacer scroll automatico
    var $elem = $('#sitiocompleto');

    // mostrar los botones
    $('#nav_up').fadeIn('slow');
    $('#nav_down').fadeIn('slow');

    // cuando estemos haciendo scroll los botones desapareceran
    $(window).bind('scrollstart', function () {
        $('#nav_up,#nav_down').stop().animate({ 'opacity': '0.2' });
    });
    // ... y cuando paremos de hacer scroll volveran a aparecer
    $(window).bind('scrollstop', function () {
        $('#nav_up,#nav_down').stop().animate({ 'opacity': '1' });
    });

    // si hacemos click en la flechita hacia abajo la pantalla bajara por completo
    $('#nav_down').click(
        function (e) {
            $('html, body').animate({ scrollTop: $elem.height() }, 800);
        }
    );
    // si hacemos click en la flechita hacia arriba la pantalla subira por completo
    $('#nav_up').click(
        function (e) {
            $('html, body').animate({ scrollTop: '0px' }, 800);
        }
    );
});