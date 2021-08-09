$(document).on('click', '.unrecognized .button', function () {
    $(this).next().toggle();
});

$(document).on('change', '.unrecognized select', function () {
    $(this).hide();
});