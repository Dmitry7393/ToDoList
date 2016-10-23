function onSuccess() {
    $("#value_note").val("");
}
var row;
$('#table_notes').find('tr').click(function () {
    row = $(this).find('td:first').text();
});
var delayedFn, blurredFrom;
$('table tr').on('blur', 'div', function (event) {
    blurredFrom = event.delegateTarget;
    var urlEdit = $("#urlUpdateList").val();
    delayedFn = setTimeout(function () {
        var dataNewNote = document.getElementById("table_notes").rows[row].cells.item(1).textContent;
        $.ajax({
            type: "POST",
            url: urlEdit,

            data: {
                note: dataNewNote,
                rowInTable: row
            },
            dataType: "html",
            success: function (data) {
                $('#result').html(data);
            }
        });
    }, 0);
});