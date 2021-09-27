$(document).ready(function () {
    let clickedOptionGroupsHistory = [];
    let pickedWords = [];
    let successAlertIsShown = true;
    let feilureAlertIsShown = true;

    $(document).on('click', '.option-group div', function () {
        hideShownAlert();
        let currentClickedButton = $(this);

        let optionGroupDiv = currentClickedButton.closest('.option-group');

        clickedOptionGroupsHistory.push({
            optionGroupDiv,
            index: optionGroupDiv.attr('index')
        })

        replaceOptionsWithNextOptions(optionGroupDiv);

        pickedWords.push(currentClickedButton.text());

        showPickedWords();
        setPickedWordsToAnswerInput();

        if (pickedWords.length == optionsGroupsData.length) {
            $('.exercise form button[type=submit]').click();
        }
    });

    $('.previous-options-js').click(function () {
        if (clickedOptionGroupsHistory.length == 0) {
            return;
        }

        replaceOptionsWithPreviousOptions();

        pickedWords.pop();
        showPickedWords();
    });

    function hideShownAlert() {
        if (successAlertIsShown) {
            $('.exercise__lesson-number .alert-success').hide();
            successAlertIsShown = false;
        }
        if (feilureAlertIsShown) {
            $('.exercise__lesson-number .alert-feilure').hide();
            feilureAlertIsShown = false;
        }
    }

    function replaceOptionsWithNextOptions(optionGroupDiv) {
        optionGroupDiv.empty();
        let nextOptionGroupIndex = getOptionGroupsMaxDataIndex() + 1;
        if (nextOptionGroupIndex < optionsGroupsData.length) {
            fillUpOptionGroupWithOptions({ optionGroupDiv, index: nextOptionGroupIndex });
        }
    }

    function replaceOptionsWithPreviousOptions() {
        let lastClickedOptionGroup = clickedOptionGroupsHistory.pop();
        lastClickedOptionGroup.optionGroupDiv.empty();
        fillUpOptionGroupWithOptions(lastClickedOptionGroup);
    }

    function setPickedWordsToAnswerInput() {
        let sentence = $('.exercise__eng-phrase').text();
        $('.exercise form #UserAnswer').attr('value', sentence.substring(0, sentence.length - 1));
    }

    function showPickedWords() {
        let answerDiv = $('.exercise__eng-phrase');
        if (pickedWords.length == 0) {
            answerDiv.text('Переведите предложение');
            return;
        }

        let sentence = '';
        for (var i = 0; i < pickedWords.length; i++) {
            sentence += pickedWords[i].trim() + ' ';
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
            let button = $('<div>').text(optionsGroupsData[clickedOptionGroup.index].options[i]);
            clickedOptionGroup.optionGroupDiv.append(button);
        }
        clickedOptionGroup.optionGroupDiv.attr('index', clickedOptionGroup.index);
    }
});
