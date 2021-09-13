$(document).on('click', '.unrecognized-word__header .left-side-of-header__word-name', function () {
    $(this).parents(':eq(1)').next().toggle();
});

$(document).on('change', '.add-exercise__unrecognized-words select', function () {
    if ($(this).val() == 'RegularVerb') {
        let unrecognizedWord__header = $(this).prev();
        unrecognizedWord__header.append('<p>Пожалуйста, введите базовую форму глагола.</p>');

        $(this).next().attr('type', 'text');
    }
    $(this).hide();
});

$(document).on('focusout', '.add-exercise__unrecognized-words input[type=text]', function () {
    $(this).attr('type', 'hidden');
    let unrecognizedWord = $(this).parent();
    unrecognizedWord.find('.unrecognized-word__header p').remove();

    let leftSideOfHeader = unrecognizedWord.find('.unrecognized-word__header .left-side-of-header');
    leftSideOfHeader.find('.left-side-of-header__word-name').text($(this).val());

    if (!(unrecognizedWord.attr('stress-checkbox-is-showed') == 'true')) {
        leftSideOfHeader.append(`
            <span class="left-side-of-header__stress-block">
                <input name="UnrecognizedWords[${unrecognizedWord.attr('index')}].StressOnTheFinalSyllableInRegularVerb" type="checkbox" checked="checked" value="true">
                <span class="checkmark"></span>
                <span>ударение на последний слог (у базовой формы)</span>
            </span>
        `);
        unrecognizedWord.attr('stress-checkbox-is-showed', true);
    }
});

$(document).on('click', '.left-side-of-header__stress-block', function () {
    var checkBox = $(this).find('input[type=checkbox]');
    checkBox.prop("checked", !checkBox.prop("checked"));
});