$(document).ready(function () {
    let clickedOptionGroupsHistory = [];
    let answer = [];

    $(document).on('click', '.option-group .button', function () {
        let optionGroupDiv = $(this).closest('.option-group');
        clickedOptionGroupsHistory.push({
            optionGroupDiv,
            index: optionGroupDiv.data('index')
        })
        optionGroupDiv.empty();

        let nextOptionGroupIndex = GetOptionGroupsMaxDataIndex() + 1;
        if (nextOptionGroupIndex < optionsGroupsData.length) {
            fillUpOptionGroupWithOptions({ optionGroupDiv, index: nextOptionGroupIndex });
        }

        answer.push($(this).text());
        ShowAnswer();
        SetAnswerToInput();
    });

    $('.options-back.button').click(function () {
        if (clickedOptionGroupsHistory.length == 0) {
            return;
        }

        let lastClickedOptionGroup = clickedOptionGroupsHistory.pop();
        lastClickedOptionGroup.optionGroupDiv.empty();

        fillUpOptionGroupWithOptions(lastClickedOptionGroup);

        answer.pop();
        ShowAnswer();
    });

    function SetAnswerToInput() {
        let sentence = $('.answer').text();
        $('.answer-input input').attr('value', sentence.substring(0, sentence.length - 1) + '.');
    }

    function ShowAnswer() {
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

    function GetOptionGroupsMaxDataIndex() {
        let indexes = $('.option-group').map(function () {
            return $(this).data("index");
        });
        return Math.max.apply(Math, indexes.toArray());
    }

    function fillUpOptionGroupWithOptions(clickedOptionGroup) {
        for (let i = 0; i < optionsGroupsData[clickedOptionGroup.index].options.length; i++) {
            let button = $('<div>', { class: 'button' }).text(optionsGroupsData[clickedOptionGroup.index].options[i]);
            clickedOptionGroup.optionGroupDiv.append(button);
        }
        clickedOptionGroup.optionGroupDiv.data('index', clickedOptionGroup.index);
    }
});
