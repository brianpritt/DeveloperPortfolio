$(document).ready(function () {
    $.ajax({
        url: "/Home/GitHubGetHub/",
        type: "GET",
        data: $(this).serialize(),
        datatype: 'json',
        success: function (result) {
            $.each(result, function (eachOne, project){
                $("#starred").append("<p>" + project.name + "</p>")
            });
        }
    });
});