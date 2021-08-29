$(document).ready(function () {
    $('.add-exercise__recognize-btn').on('click', function () {
        var engPhrase = $('.add-exercise__eng-phrase input[type=text]').val().trim();
        if (!engPhrase) {
            return;
        }

        $.get(`/Admin/Recognize?engPhrase=${engPhrase}`).done(function (unrecognizedArray) {
            if (unrecognizedArray.length > 0) {
                $('.add-exercise__unrecognized-words div').empty();
                saveOnPage(unrecognizedArray, getUnrecognizableEnumOptions());
            }
        });

        $('.add-exercise__unrecognized-words label').show();
        $('.add-exercise__submit-btn').prop('disabled', false);
    });
});

function saveOnPage(unrecognizedArray, options) {
    for (var i = 0; i < unrecognizedArray.length; i++) {
        $('.unrecognized-words-js').append(`
            <div class="unrecognized-word">
                <div class="unrecognized-word__header">
                    <span>${unrecognizedArray[i].text}</span>
                </div>
                <select name=UnrecognizedWords[${i}].Type>${options}</select>
                <input name="UnrecognizedWords[${i}].Text" type="hidden" value="${unrecognizedArray[i].text}"/>
            </div>`
        );
    }
}

function getUnrecognizableEnumOptions() {
    let options = '<option disabled selected>Тип слова</option>';
    for (option in unrecognizableTypeEnum) {
        if (option == 'Undefined') {
            continue;
        }
        options += '<option>' + option + '</option>';
    }
    return options;
}