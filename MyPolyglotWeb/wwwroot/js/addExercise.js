$(document).on('click', '.unrecognized .button', function () {
    $(this).next().toggle();
});

$(document).on('change', '.unrecognized select', function () {
    if ($(this).val() == 'Verb') {
        //if ($(this).parent().find('input[type=text]').length == 1)
        $(this).parent().append('<input placeholder="trstasrt" type="text" />');
    }
    $(this).hide();
});

$(document).on('focusout', '.unrecognized input[type=text]', function () {
    $(this).hide();
});