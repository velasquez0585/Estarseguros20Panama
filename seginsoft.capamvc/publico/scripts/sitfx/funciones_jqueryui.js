$(function () {
    $("input[type='submit']").button();
    $("input[type='button']").button();
    $(".tab").tabs();
    $("#accordion").accordion({ heightStyle: "content", 'active': "" });
    $(".dialognoauto").dialog({
        autoOpen: false, modal: true, width: 800, show: { effect: "blind",duration: 1000  } });
    $(".dialogsiauto").dialog({ autoOpen: true });
    $("input[type='text']").addClass("ui-widget ui-widget-content ui-corner-all");
    $("input[type='email']").addClass("ui-widget ui-widget-content ui-corner-all");
    $("input[type='url']").addClass("ui-widget ui-widget-content ui-corner-all");
    $("input[type='password']").addClass("ui-widget ui-widget-content ui-corner-all");
    $("input[type='number']").addClass("ui-widget ui-widget-content ui-corner-all");
    $("input[type='date']").addClass("ui-widget ui-widget-content ui-corner-all");
    $("input[type='date']").datepicker({ dateFormat: 'dd/mm/yy' });
    $("textarea").addClass("ui-widget ui-widget-content ui-corner-all");
    $(".date-field").datepicker({ dateFormat: 'dd/mm/yy' });
    $("select").addClass("ui-widget ui-widget-content ui-corner-all");
    //$.datepicker.regional["es"]

    $(".date-field").datepicker("option", "changeMonth", true);
    $(".date-field").datepicker("option", "changeYear", true);
    $(".date-field").datepicker("option", "yearRange", "-100:+1");
});