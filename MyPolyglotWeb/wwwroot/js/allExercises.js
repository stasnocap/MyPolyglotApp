$(document).ready(function () {
    let confirmButtonIsShown = false;
    $('.exercise-info input').change(function () {
        if (!confirmButtonIsShown) {
            $('.edit-header__confirm-btn').show();
            $('.edit-header__text').hide();
            confirmButtonIsShown = true;
        }
    });

    $('.delete-btn').click(function () {
        let deleteForm = $('.delete-form');
        deleteForm.find('#exerciseId').val($(this).data('exercise-id'));
        deleteForm.find('button[type=submit]').click();
    });

    $('.unrecognized-words-unfold').click(function () {
        $(this).hide();
        $(this).next().addClass('flex-column');
    });
});