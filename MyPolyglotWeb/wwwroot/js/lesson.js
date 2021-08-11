$(document).ready(function () {
    var nextWordOptionsIndex = 2;
    $(document).on('click', '.button', function () {
        var group = $(this).closest('.options-group');

        group.empty();

        if (nextWordOptionsIndex < groupOptions.length) {
            for (var i = 0; i < groupOptions[nextWordOptionsIndex].options.length; i++) {
                var button = $('<div>', { class: 'button' }).text(groupOptions[nextWordOptionsIndex].options[i]);
                group.append(button);
            }
            nextWordOptionsIndex++;
        }
    });
});