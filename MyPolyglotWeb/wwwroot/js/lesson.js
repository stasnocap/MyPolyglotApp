$(document).ready(function () {
    let nextOptionGroupIndex = 2;
    let previousLinks = [];
    let previousOptionGrout = [];
    $(document).on('click', '.option-group .button', function () {
        let divLink = $(this).closest('.option-group');
        previousLinks.push(divLink);

        divLink.empty();

        if (nextOptionGroupIndex < optionGroups.length) {
            fillUpOptionGroupWithOptions(divLink);
            nextOptionGroupIndex++;
        }
    });

    $('.options-back.button').click(function () {
        nextOptionGroupIndex--;
        fillUpOptionGroupWithOptions(previousLinks.pop());
    });

    function fillUpOptionGroupWithOptions(link) {
        for (let i = 0; i < optionGroups[nextOptionGroupIndex].options.length; i++) {
            let button = $('<div>', { class: 'button' }).text(optionGroups[nextOptionGroupIndex].options[i]);
            link.append(button);
        }
    }
});
