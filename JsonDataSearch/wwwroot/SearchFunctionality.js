

$(document).ready(function () {
   
    $.ajaxSetup({ cache: false });
    $('#search').keyup(function () {
        $('#result').html('');
        $('#state').val('');
        var searchField = $('#search').val();
        var expression = new RegExp(searchField, "i");
        $.getJSON('rapunzelproducts.json', function (data) { 
            $.each(data, function (key, value) {
                if (value.name.search(expression) != -1) { 
                    $('#result').append(+ value.name + ' | <span>' + value.color - calc + '</span> '
                        + ' | <span>' + value.color_caption - calc +  '</span></li>');
                }
            });
        });
    });

    $('#result').on('click', 'li', function () {
        var click_text = $(this).text().split('|');
        $('#search').val($.trim(click_text[0]));
        $("#result").html('');
    });
});
