$(document).off('click').on('click', '.btnRemoveNote', function () {
    var urlDelete = $("#urlRemoveNote").val();
    var $index = $(this).closest("tr")[0].rowIndex;
    $.ajax({
        type: "POST",
        url: urlDelete,
        data: {
            rowInTable: $index
        },
        dataType: "html",
        success: function (data) {
            $('div#partial_view').html(data);
        }
    });
});