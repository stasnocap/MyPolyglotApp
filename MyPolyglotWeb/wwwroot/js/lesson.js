$(document).ready(function () {
    let clickedOptionGroupsHistory = [];
    let answer = [];
    let successAlertIsShown = true;
    let feilureAlertIsShown = true;

    $(document).on('click', '.option-group .button', function () {
        hideShownAlert();

        let optionGroupDiv = saveOptionGroupToHistory();
        optionGroupDiv.empty();

        let nextOptionGroupIndex = getOptionGroupsMaxDataIndex() + 1;
        if (nextOptionGroupIndex < optionsGroupsData.length) {
            fillUpOptionGroupWithOptions({ optionGroupDiv, index: nextOptionGroupIndex });
        }

        answer.push($(this).text());
        showAnswer();
        setValueToAnswerInput();
    });

    $('.options-back.button').click(function () {
        if (clickedOptionGroupsHistory.length == 0) {
            return;
        }

        let lastClickedOptionGroup = clickedOptionGroupsHistory.pop();
        lastClickedOptionGroup.optionGroupDiv.empty();

        fillUpOptionGroupWithOptions(lastClickedOptionGroup);

        answer.pop();
        showAnswer();
    });

    $('.submit-button span').click(function () {
        $('.lesson form input[type=submit]').click();
    });

    function hideShownAlert() {
        if (successAlertIsShown) {
            $('.lesson-number .alert-success').hide();
            successAlertIsShown = false;
        }
        if (feilureAlertIsShown) {
            $('.lesson-number .alert-feilure').hide();
            feilureAlertIsShown = false;
        }
    }

    function saveOptionGroupToHistory() {
        let optionGroupDiv = $(this).closest('.option-group');
        clickedOptionGroupsHistory.push({
            optionGroupDiv,
            index: optionGroupDiv.attr('index')
        })
        return optionGroupDiv;
    }

    function setValueToAnswerInput() {
        let sentence = $('.answer').text();
        $('.lesson form input[type=text]').attr('value', sentence.substring(0, sentence.length - 1) + '.');
    }

    function showAnswer() {
        let answerDiv = $('.answer');
        if (answer.length == 0) {
            answerDiv.text('Переведите предложение');
            return;
        }

        let sentence = '';
        for (var i = 0; i < answer.length; i++) {
            sentence += answer[i].trim() + ' ';
        }

        answerDiv.text(sentence.charAt(0).toUpperCase() + sentence.substring(1));
    }

    function getOptionGroupsMaxDataIndex() {
        let indexes = $('.option-group').map(function () {
            return $(this).attr('index');
        });
        return Math.max.apply(Math, indexes.toArray());
    }

    function fillUpOptionGroupWithOptions(clickedOptionGroup) {
        for (let i = 0; i < optionsGroupsData[clickedOptionGroup.index].options.length; i++) {
            let button = $('<div>', { class: 'button' }).text(optionsGroupsData[clickedOptionGroup.index].options[i]);
            clickedOptionGroup.optionGroupDiv.append(button);
        }
        clickedOptionGroup.optionGroupDiv.attr('index', clickedOptionGroup.index);
    }
});
