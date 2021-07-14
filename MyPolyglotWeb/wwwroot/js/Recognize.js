$(document).ready(function () {
    $(".recognize.button").click(function () {
        var engPhrase = $(".eng-phrase").val();
        var url = `/Admin/Recognize?engPhrase=${engPhrase}`;
        $.get(url).done(function (data) {
            var a = data[0].text;
            var b = data[1].text;
        });
    });
});