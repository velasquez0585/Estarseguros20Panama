ko.validation.configure({
    registerExtenders: true,
    messagesOnModified: false,
    insertMessages: false,
    parseInputAttributes: true,
    messageTemplate: null
});

ko.bindingHandlers.stopBinding = {
    init: function () {
        return { controlsDescendantBindings: true };
    }
};

ko.virtualElements.allowedBindings.stopBinding = true;



/*
* read-only date display with momentjs
* use like this: data-bind="moment: dateVar, format: 'YYYY-MM-DD'"
* The "format" is optional and will default to "MM/DD/YYYY"
*/
ko.bindingHandlers.datevalue = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        //initialize datepicker with some optional options
        var options = allBindingsAccessor().datepickerOptions || {};
        $(element).datepicker(options);

        //handle the field changing
        ko.utils.registerEventHandler(element, "change", function () {
            var observable = valueAccessor();
            observable($(element).val());
            //if (observable.isValid()) {
                var date = moment($(element).datepicker("getDate")).format('DD/MM/YYYY');
                observable(date);
                $(element).blur();
            //}
        });

        //handle disposal (if KO removes by the template binding)
        ko.utils.domNodeDisposal.addDisposeCallback(element, function () {
            $(element).datepicker("destroy");
        });

        ko.bindingHandlers.validationCore.init(element, valueAccessor, allBindingsAccessor);
    },
    update: function (element, valueAccessor, allBindingsAccessor, viewModel) {
        var value = ko.utils.unwrapObservable(valueAccessor());
        if (value.match('T')) {
            var valueparts = value.split('T');
            var date = moment(valueparts[0]).format('DD/MM/YYYY');
            value = date;
            //alert(valueparts[0]);
            //alert(moment(valueparts[0]).format('DD/MM/YYYY'));
            //alert(valueparts[1]);
        }

        //handle date data coming via json from Microsoft
        if (String(value).indexOf('/Date(') == 0) {
            value = new Date(parseInt(value.replace(/\/Date\((.*?)\)\//gi, "$1")));
        }

        current = $(element).datepicker("getDate");

        if (value - current !== 0) {
            $(element).datepicker("setDate", value);
        }
    }
};

ko.bindingHandlers.datehtml = {
    update: function (element, valueAccessor, allBindingsAccessor, viewModel) {
        var val = valueAccessor();

        //var formatted = '**INVALID**';
        var formatted = '';
        var date = moment(ko.utils.unwrapObservable(val));

        var format = allBindingsAccessor().format || 'DD/MM/YYYY';

        if (date && date.isValid()) {
            formatted = date.format(format);
        }

        element.innerHTML = formatted;
    }
};

ko.bindingHandlers.timehtml = {
    update: function (element, valueAccessor, allBindingsAccessor, viewModel) {
        var val = valueAccessor();

        //var formatted = '**INVALID**';
        var formatted = '';
        var date = moment(ko.utils.unwrapObservable(val));

        var format = allBindingsAccessor().format || 'HH:mm a';

        if (date && date.isValid()) {
            formatted = date.format(format);
        }

        element.innerHTML = formatted;
    }
};

ko.bindingHandlers.datetimehtml = {
    update: function (element, valueAccessor, allBindingsAccessor, viewModel) {
        var val = valueAccessor();

        //var formatted = '**INVALID**';
        var formatted = '';
        var date = moment(ko.utils.unwrapObservable(val));

        var format = allBindingsAccessor().format || 'DD/MM/YYYY HH:mm a';

        if (date && date.isValid()) {
            formatted = date.format(format);
        }

        element.innerHTML = formatted;
    }
};


ko.bindingHandlers.datetext = {
    update: function (element, valueAccessor, allBindingsAccessor, viewModel) {
        var val = valueAccessor();

        //var formatted = '**INVALID**';
        var formatted = '';
        var date = moment(ko.utils.unwrapObservable(val));

        var format = allBindingsAccessor().format || 'DD/MM/YYYY';

        if (date && date.isValid()) {
            formatted = date.format(format);
        }

        element.innerText = formatted;
    }
};














var formatNumber = function (element, valueAccessor, allBindingsAccessor, format) {
    // Provide a custom text value
    var value = valueAccessor(), allBindings = allBindingsAccessor();
    //var numeralFormat = allBindingsAccessor.numeralFormat || format;
    var numeralFormat = format;
    var strNumber = ko.utils.unwrapObservable(value);
    if (strNumber) {
        return numeral(strNumber).format(numeralFormat);
    }
    return '';
};


var formatNumberDecimal = function (element, valueAccessor, allBindingsAccessor, format) {
    // Provide a custom text value
    var value = valueAccessor(), allBindings = allBindingsAccessor();
    //var numeralFormat = allBindingsAccessor.numeralFormat || format;
    var numeralFormat = format;
    var strNumber = ko.utils.unwrapObservable(value);
    if (strNumber) {
        return numeral(strNumber).format(numeralFormat);
    }
    return '0,00';
};

ko.bindingHandlers.numeraltext = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        $(element).text(formatNumber(element, valueAccessor, allBindingsAccessor, "(0,0.00)"));
    },
    update: function (element, valueAccessor, allBindingsAccessor) {
        $(element).text(formatNumber(element, valueAccessor, allBindingsAccessor, "(0,0.00)"));
    }
};
ko.bindingHandlers.enterovalue = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        $(element).val(formatNumber(element, valueAccessor, allBindingsAccessor, "(0)"));
        ko.utils.registerEventHandler(element, "change", function () {
            var observable = valueAccessor();
            observable($(element).val());
        });
    },
    update: function (element, valueAccessor, allBindingsAccessor) {
        $(element).val(formatNumber(element, valueAccessor, allBindingsAccessor, "(0)"));
        //var m = $(element).val();
        //m = m.replace(".", "#");
        //m = m.replace(",", ".");
        //m = m.replace("#", ",");
        //m = m.substring(0, m.length - 1);
        //m = m.substring(0, m.length - 1);
        //$(element).val(m);
    }
};

ko.bindingHandlers.enterotext = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        $(element).text(formatNumber(element, valueAccessor, allBindingsAccessor, "(0)"));
    },
    update: function (element, valueAccessor, allBindingsAccessor) {
        $(element).text(formatNumber(element, valueAccessor, allBindingsAccessor, "(0)"));
    }
};

ko.bindingHandlers.numeralvalue = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        $(element).val(formatNumberDecimal(element, valueAccessor, allBindingsAccessor, "(0,0.00)"));
        ko.utils.registerEventHandler(element, "change", function () {
            var observable = valueAccessor();
            observable($(element).val());
        });
    },
    update: function (element, valueAccessor, allBindingsAccessor) {
        $(element).val(formatNumberDecimal(element, valueAccessor, allBindingsAccessor, "(0,0.00)"));
        //var m = $(element).val();
        //m = m.replace(".", "#");
        //m = m.replace(",", ".");
        //m = m.replace("#", ",");
        //m = m.substring(0, m.length - 1);
        //m = m.substring(0, m.length - 1);
        //$(element).val(m);
    }
};

ko.bindingHandlers.percenttext = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        $(element).text(formatNumberDecimal(element, valueAccessor, allBindingsAccessor, "(0.00 %)"));
    },
    update: function (element, valueAccessor, allBindingsAccessor) {
        $(element).text(formatNumberDecimal(element, valueAccessor, allBindingsAccessor, "(0.00 %)"));
    }
};

ko.bindingHandlers.percentvalue = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        $(element).val(formatNumberDecimal(element, valueAccessor, allBindingsAccessor, "(0.00 %)"));

        //handle the field changing
        ko.utils.registerEventHandler(element, "change", function () {
            var observable = valueAccessor();
            observable($(element).val());
        });
    },
    update: function (element, valueAccessor, allBindingsAccessor) {
        $(element).val(formatNumberDecimal(element, valueAccessor, allBindingsAccessor, "(0.00 %)"));
    }
};
ko.bindingHandlers.populateInitialValue = {
    init: function (element, valueAccessor, allBindingsAccessor) {
        var bindings = allBindingsAccessor(),
            options = ko.utils.unwrapObservable(bindings.options),
            optionsValue = bindings.optionsValue,
            value = ko.utils.unwrapObservable(bindings.value),
            initialValue;

        if (options && !options.length) {
            if (optionsValue) {
                initialValue = {};
                initialValue[optionsValue] = value;
            }
            else {
                initialValue = value;
            }

            bindings.options.push(initialValue);
        }
    }
};

ko.extenders["booleanValue"] = function (target) {
    target.formattedValue = ko.computed({
        read: function () {
            if (target() === true) return "True";
            else if (target() === false) return "False";
        },
        write: function (newValue) {
            if (newValue) {
                if (newValue === "False") target(false);
                else if (newValue === "True") target(true);
            }
        }
    });

    target.formattedValue(target());
    return target;
};