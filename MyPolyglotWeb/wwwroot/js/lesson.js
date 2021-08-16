$(document).ready(function () {
    let previousLinks = [];
    let nextOptionGroupIndex = 2;
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
        if (previousLinks.length == 0) {
            return;
        }
        let previousLink = previousLinks.pop();
        previousLink.empty();

        fillUpOptionGroupWithOptions(previousLink);
        nextOptionGroupIndex--;
    });

    function fillUpOptionGroupWithOptions(link) {
        for (let i = 0; i < optionGroups[nextOptionGroupIndex].options.length; i++) {
            let button = $('<div>', { class: 'button' }).text(optionGroups[nextOptionGroupIndex].options[i]);
            link.append(button);
        }
        link.attr('index', nextOptionGroupIndex);
    }
});
