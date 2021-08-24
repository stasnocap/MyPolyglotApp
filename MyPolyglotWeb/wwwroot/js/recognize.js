$(document).ready(function () {
    $('.recognize .button').on('click', function () {
        var engPhrase = $('.eng-phrase input[type=text]').val().trim();
        if (!engPhrase) {
            return;
        }
        var submitButton = $('.add-exercise .submit-button')

        $.get(`/Admin/Recognize?engPhrase=${engPhrase}`).done(function (unrecognizedArray) {
            if (unrecognizedArray.length > 0) {
                saveOnPage(unrecognizedArray, getUnrecognizableEnumOptions());
            }
        });

        submitButton.show();
    });
});

function saveOnPage(unrecognizedArray, options) {
    $('.unrecognized').css('display', 'flex');
    for (var i = 0; i < unrecognizedArray.length; i++) {
        $('.unrecognized').append(`
            <div>
                <span class="button">${unrecognizedArray[i].text}</span>
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