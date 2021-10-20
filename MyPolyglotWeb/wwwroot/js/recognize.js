$(document).ready(function () {
    let options = '<option disabled selected>Тип слова</option>';
    for (option in unrecognizableTypeEnum) {
        if (option == 'Undefined') {
            continue;
        }
        options += '<option>' + option + '</option>';
    }

    $('.add-exercise__recognize-btn').on('click', function () {
        var engPhrase = $('.add-exercise__eng-phrase input[type=text]').val().trim();
        if (!engPhrase) {
            return;
        }

        $.get(`/Admin/Recognize?engPhrase=${engPhrase}`).done(function (unrecognizedArray) {
            if (unrecognizedArray.length > 0) {
                $('.unrecognized-words').empty();
                $('.add-exercise__unrecognized-block label').show();
                saveOnPage(unrecognizedArray);
            }
        });

        $('.add-exercise__submit-btn').prop('disabled', false);
    });

    function saveOnPage(unrecognizedArray) {
        for (var i = 0; i < unrecognizedArray.length; i++) {
            $('.unrecognized-words').append(`
            <div class="unrecognized-word" index="${i}">
                <div class="unrecognized-word__info">
                    <div class="left-side-of-word-info">
                        <span class="left-side-of-word-info__word-name">${unrecognizedArray[i].text}</span>
                    </div>
                </div>
                <div class="unrecognized-word__select">
                    <select name="UnrecognizedWords[${i}].Type">${options}</select>
                    <input name="UnrecognizedWords[${i}].Text" type="hidden" value="${unrecognizedArray[i].text}"/>
                </div>
            </div>`
            );
        }
    }
});
