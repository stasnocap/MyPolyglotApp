$(document).ready(function () {
    $(".paginator_block__pages .page").click(function () {
        var pageSize = $(".paginator-block__page-size select").val();
        var page = $(this).data("page") - 0;
        var sortColumn = $("#SortColumn").val();
        var sortDirection = $("#SortDirection").val();
        updatePage(page, pageSize, sortColumn, sortDirection);
    });

    $(".paginator-block__page-size select").change(function () {
        var pageSize = $(this).val();
        var sortColumn = $("#SortColumn").val();
        var sortDirection = $("#SortDirection").val();
        updatePage(0, pageSize, sortColumn, sortDirection);
    });
});

function updatePage(page, pageSize, sortColumn, sortDirection) {
     window.location.href = paginatorUrl + `?page=${page}&pageSize=${pageSize}&sortColumn=${sortColumn}&sortDirection=${sortDirection}`;
}
