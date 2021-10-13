$(document).on('click', '.unrecognized-word__header .left-side-of-header__word-name', function () {
    $(this).parents(':eq(1)').next().toggle();
});

$(document).on('change', '.add-exercise__unrecognized-block select', function () {
    if ($(this).val() == 'RegularVerb') {
        $(this).prev().append('<p>Пожалуйста, введите базовую форму глагола.</p>');

        $(this).next().attr('type', 'text');
    }

    if ($(this).val() == 'RegularComparisonAdjective') {
        $(this).prev().append('<p>Пожалуйста, введите базовую форму прилагательного.</p>');

        $(this).next().attr('type', 'text');
    }

    $(this).hide();
});

$(document).on('focusout', '.add-exercise__unrecognized-block input[type=text]', function () {
    let select = $(this).prev();

    if (select.val() == 'RegularVerb') {
        let leftSideOfHeader = PrepareLeftSideOfHeader($(this));
        let unrecognizedWordIndex = $(this).parent().attr('index');
        leftSideOfHeader.append(`
            <span class="left-side-of-header__stress-block">
                <input name="UnrecognizedWords[${unrecognizedWordIndex}].StressOnTheFinalSyllableInRegularVerb" type="checkbox" checked="checked" value="true">
                <span class="checkmark"></span>
                <span>ударение на последний слог (у базовой формы)</span>
            </span>
        `);
    }

    if (select.val() == 'RegularComparisonAdjective') {
        let leftSideOfHeader = PrepareLeftSideOfHeader($(this));
        let unrecognizedWordIndex = $(this).parent().attr('index');
        leftSideOfHeader.append(`
            <span class="left-side-of-header__syllable-radio-block">
                <span class="syllable-radio-button">
                    <input name="UnrecognizedWords[${unrecognizedWordIndex}].SyllablesInRegularComparisonAdjective" type="radio" checked="checked" value="1" />
                    <span>1 слог</span>
                    <span class="checkmark"></span>
                </span>
                <span class="syllable-radio-button">
                    <input name="UnrecognizedWords[${unrecognizedWordIndex}].SyllablesInRegularComparisonAdjective" type="radio" value="2" />
                    <span>2 слога</span>
                    <span class="checkmark"></span>
                </span>
                <span class="syllable-radio-button">
                    <input name="UnrecognizedWords[${unrecognizedWordIndex}].SyllablesInRegularComparisonAdjective" type="radio" value="3" />
                    <span>3 и более слогов</span>
                    <span class="checkmark"></span>
                </span>
            </span>
        `);
    }
});

function PrepareLeftSideOfHeader(input) {
    input.attr('type', 'hidden');
    let unrecognizedWord = input.parent();
    unrecognizedWord.find('.unrecognized-word__header p').remove();

    let leftSideOfHeader = unrecognizedWord.find('.unrecognized-word__header .left-side-of-header');
    let wordName = leftSideOfHeader.find('.left-side-of-header__word-name');

    wordName.text(input.val());
    wordName.next().remove();
    return leftSideOfHeader;
}

$(document).on('click', '.left-side-of-header__stress-block', function () {
    var checkBox = $(this).find('input[type=checkbox]');
    checkBox.prop("checked", !checkBox.prop("checked"));
});

$(document).on('click', '.left-side-of-header__syllable-radio-block .syllable-radio-button', function () {
    var checkBox = $(this).find('input[type=radio]');
    checkBox.prop("checked", true);
});