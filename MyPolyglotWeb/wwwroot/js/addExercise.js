$(document).on('click', '.unrecognized .button', function () {
    $(this).next().toggle();
});

$(document).on('change', '.unrecognized select', function () {
    if ($(this).val() == 'Verb') {
        $(this).next().attr('type', 'text');
    }
    $(this).hide();
});

$(document).on('focusout', '.unrecognized input[type=text]', function () {
    $(this).attr('type', 'hidden');
});