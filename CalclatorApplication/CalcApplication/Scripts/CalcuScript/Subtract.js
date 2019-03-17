
function calcuFunc(url) {
    var num1 = $("#Num1").val();
    var num2 = $("#Num2").val();

    $.ajax({
        url: url,
        data: {
            'Num1': num1,
            'Num2': num2
        },
        type: "post",
        success: function (data) {
            $("#Answer").val(data);

            //console.log(data);
        },
        error: function (jqXHR, exception) {
            console.log(jqXHR);
            console.log(exception);
        }


    });
}