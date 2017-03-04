$(document).ready(function () {
    $.ajax({
        url: "/Home/GitHubGetHub/",
        type: "GET",
        data: $(this).serialize(),
        datatype: 'json',
        success: function (result) {
            
            $.each(result, function (eachOne, project) {
                
                $("#starred").append("<div class='col s12 m5 colors'><div class='card-panel transparent '><span class='white-text'><h5>Project Name: " + project.name + "</h5><p>Description: " + project.description +"<p>Stars: " + project.stargazers_count + "<p><a href='https://github.com/" + project.full_name + "'>Project Repo</a></p></span></div></div>");
            });
        }
    }).error(function(){alert("There was a problem processing your request.");});
});

