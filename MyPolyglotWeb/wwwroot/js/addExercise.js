$(document).on('click', '.unrecognized .button', function () {
    $(this).next().toggle();
});

$(document).on('change', '.unrecognized select', function () {
    if ($(this).val() == 'Verb') {
        $(this).next().attr('type', 'text');
        $(this).parent().append('пожалуйста, введите базовую форму глагола');
    }
    $(this).hide();
});

$(document).on('focusout', '.unrecognized input[type=text]', function () {
    $(this).attr('type', 'hidden');
    $(this).parent().contents().filter(function () {
        return this.nodeType === 3;
    }).remove();
});