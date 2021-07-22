$(document).ready(function () {
    $('.recognize input[type=button]').one('click', function () {
        var engPhrase = $('.eng-phrase input[type=text]').val();
        var url = `/Admin/Recognize?engPhrase=${engPhrase}`;
        var options = getUnrecognizableEnumOptions();
        $.get(url).done(function (unrecognizedArray) {
            saveOnPage(unrecognizedArray, options);
        });
    });
});

function saveOnPage(unrecognizedArray, options) {
    $('.unrecognized').append('Нераспознанные слова:');
    for (var i = 0; i < unrecognizedArray.length; i++) {
        $('.unrecognized').append(`<div><span class="button">${unrecognizedArray[i].text}</span>
            <select name=UnrecognizedWords[${i}].Type>${options}</select>
            <input name="UnrecognizedWords[${i}].Text" type="hidden" value="${unrecognizedArray[i].text}"/>
            </div>`);
    }
}

function getUnrecognizableEnumOptions() {
    let options = '<options>';
    let defaultOption = '<option disabled selected>Тип слова</option>';
    options += defaultOption;
    for (option in unrecognizableTypeEnum) {
        options += '<option>' + option + '</option>';
    }
    return options;
}