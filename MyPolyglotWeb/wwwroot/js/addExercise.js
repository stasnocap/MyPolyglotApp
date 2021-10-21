$(document).on('click', '.left-side-of-word-info__word-name', function () {
    $(this).parents('.unrecognized-word').find('select').toggle();
});

$(document).on('change', '.add-exercise__unrecognized-block select', function () {
    let unrecognizedWord = $(this).parents('.unrecognized-word');
    unrecognizedWord.find('.left-side-of-word-info__word-name').next().remove();
    unrecognizedWord.find('.right-side-of-word-info').remove();

    if ($(this).val() == 'RegularVerb') {
        appendToRightSideOfWordInfo(unrecognizedWord, `
            <div class="right-side-of-word-info">
                Пожалуйста, введите базовую форму глагола.
            </div>
        `);
    } else if ($(this).val() == 'RegularComparisonAdjective') {
        appendToRightSideOfWordInfo(unrecognizedWord, `
            <div class="right-side-of-word-info">
                Пожалуйста, введите базовую форму прилагательного.
            </div>
        `);
    } else if ($(this).val() == 'Noun') {
        unrecognizedWord.find('.left-side-of-word-info').append(`
            <span class="left-side-of-word-info__plural-block checkmark-block">
                <input name="UnrecognizedWords[${unrecognizedWord.attr('index')}].WasRecognizedFromPluralForm" type="checkbox" value="true">
                <span class="checkmark"></span>
                <span>множественная форма</span>
            </span>
        `);
    }

    $(this).hide();
});

function appendToRightSideOfWordInfo(unrecognizedWord, div) {
    unrecognizedWord.find('.unrecognized-word__select input').attr('type', 'text');
    unrecognizedWord.find('.unrecognized-word__info').append(div);
}

$(document).on('focusout', '.add-exercise__unrecognized-block input[type=text]', function () {
    let unrecognizedWord = $(this).parents('.unrecognized-word');
    let select = unrecognizedWord.find('select');

    $(this).attr('type', 'hidden');
    unrecognizedWord.find('.right-side-of-word-info').remove();

    let leftSideOfWordInfo = unrecognizedWord.find('.left-side-of-word-info');
    let unrecognizedWordIndex = unrecognizedWord.attr('index');
    if (select.val() == 'RegularVerb') {
        leftSideOfWordInfo.append(`
            <span class="left-side-of-word-info__stress-block checkmark-block">
                <input name="UnrecognizedWords[${unrecognizedWordIndex}].StressOnTheFinalSyllableInRegularVerb" type="checkbox" checked="checked" value="true">
                <span class="checkmark"></span>
                <span>ударение на последний слог (у базовой формы)</span>
            </span>
        `);
    } else if (select.val() == 'RegularComparisonAdjective') {
        leftSideOfWordInfo.append(`
            <span class="left-side-of-word-info__syllable-radio-block">
                <span class="syllable-radio-button radio-block">
                    <input name="UnrecognizedWords[${unrecognizedWordIndex}].SyllablesInRegularComparisonAdjective" type="radio" checked="checked" value="1" />
                    <span>1 слог</span>
                    <span class="checkmark"></span>
                </span>
                <span class="syllable-radio-button radio-block">
                    <input name="UnrecognizedWords[${unrecognizedWordIndex}].SyllablesInRegularComparisonAdjective" type="radio" value="2" />
                    <span>2 слога</span>
                    <span class="checkmark"></span>
                </span>
                <span class="syllable-radio-button radio-block">
                    <input name="UnrecognizedWords[${unrecognizedWordIndex}].SyllablesInRegularComparisonAdjective" type="radio" value="3" />
                    <span>3 и более слогов</span>
                    <span class="checkmark"></span>
                </span>
            </span>
        `);
    } 

    unrecognizedWord.find('.left-side-of-word-info__word-name').text($(this).val());
});

$(document).on('click', '.checkmark-block', function () {
    var checkBox = $(this).find('input[type=checkbox]');
    checkBox.prop("checked", !checkBox.prop("checked"));
});

$(document).on('click', '.left-side-of-word-info__syllable-radio-block .syllable-radio-button', function () {
    var checkBox = $(this).find('input[type=radio]');
    checkBox.prop("checked", true);
});