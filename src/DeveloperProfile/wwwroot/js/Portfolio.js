$(document).ready(function () {
    $.ajax({
        url: "/Home/GitHubGetHub/",
        type: "GET",
        data: $(this).serialize(),
        datatype: 'json',
        success: function (project) {
            
            //$.each(result, function (eachOne, project) {
            for(i = 0; i<3; i++ ){  
                $("#starred").append("<div class='col s12 m5 colors'><div class='card-panel transparent '><span class='white-text'><h5>Project Name: " + project[i].name + "</h5><p>Description: " + project[i].description +"<p>Stars: " + project[i].stargazers_count + "<p><a href='https://github.com/" + project[i].full_name + "'>Project Repo</a></p></span></div></div>");
            };
        }
    }).error(function(){alert("There was a problem processing your request.");});
});

