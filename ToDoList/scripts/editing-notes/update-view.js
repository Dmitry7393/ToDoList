function init() {
    var urlInit = $("#urlInit").val();
    $.ajax({
        type: "GET",
        url: urlInit,
        dataType: "html",
        success: function (data) {
            $('div#partial_view').html(data);
        }
    });
}