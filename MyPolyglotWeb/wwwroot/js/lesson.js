$(document).ready(function () {
    var nextWordOptionsIndex = 2;
    var lastGroupLink;
    var lastGroupData;
    $(document).on('click', '.options-group .button', function () {
        let group = $(this).closest('.options-group');
        lastGroupLink = group;
        lastGroupData = group.clone();

        group.empty();

        if (nextWordOptionsIndex < dataOptions.length) {
            for (var i = 0; i < dataOptions[nextWordOptionsIndex].options.length; i++) {
                var button = $('<div>', { class: 'button' }).text(dataOptions[nextWordOptionsIndex].options[i]);
                group.append(button);
            }
            nextWordOptionsIndex++;
        }
    });

    $('.options-back.button').click(function () {
        lastGroupLink.replaceWith(lastGroupData);
        --nextWordOptionsIndex;
    });
});