$(document).on('click', '.unrecognized-word__header span', function () {
    $(this).parent().next().toggle();
});

$(document).on('change', '.add-exercise__unrecognized-words select', function () {
    if ($(this).val() == 'Verb') {
        let unrecognizedWord__header = $(this).prev();
        unrecognizedWord__header.append('<p>Пожалуйста, введите базовую форму глагола.</p>');

        $(this).next().attr('type', 'text');
    }
    $(this).hide();
});

$(document).on('focusout', '.add-exercise__unrecognized-words input[type=text]', function () {
    $(this).attr('type', 'hidden');
    $(this).parent().find('.unrecognized-word__header p').remove();
});