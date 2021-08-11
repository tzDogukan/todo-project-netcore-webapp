
////////////////////////////////////////////////////////////////

$.getJSON("https://api.ipify.org/?format=json", function (e) {
    $("#clientadress").val(e.ip);
});
$(document).ready(function () {
    console.log("ready!");
});
$(document).ready(function () {
    $.getJSON("https://api.ipify.org/?format=json", function (e) {
        $("#clientadress").val(e.ip);
    });
});


$(document).ready(function () {
    $.getJSON("https://api.ipify.org/?format=json", function (e) {
        $("#clientadress").val(e.ip);
    });
});

/////////////////////////////////////////////////////////////////////////////////////////
$(document).ready(function () {
    $('.summernote').summernote();
});

$(document).ready(function () {

    var textarea = $(".charactercounter");

    textarea.keydown(function (event) {

        var numbOfchars = textarea.val();
        var len = numbOfchars.length;
        $(".chars-counter").text(len);


    });
});
/////////////////////////////////////////////
$(document).ready(function () {

    var textarea = $(".charactercounter2");

    textarea.keydown(function (event) {

        var numbOfchars = textarea.val();
        var len = numbOfchars.length;
        $(".chars-counter2").text(len);


    });
});

$('#checkAll').change(function () {
    $('.cb-element').prop('checked', this.checked);
});
/////////////////////////////////////////////
$('.cb-element').change(function () {
    if ($('.cb-element:checked').length == $('.cb-element').length) {
        $('#checkAll').prop('checked', true);
    }
    else {
        $('#checkAll').prop('checked', false);
    }
});
/////////////////////////////////////////////
$(document).ready(function () {
    $(".alfa select").on("change", function () {
        var selVal = $(this).val();
        $('#input04').val(selVal);
    });

});
/////////////////////////////////////////////
$(".dropdown-menu li a").click(function () {
    $(this).parents(".dropdown").find('.btn').html($(this).text() + ' <span class="caret"></span>');
    $(this).parents(".dropdown").find('.btn').val($(this).data('value'));
});

function mySelect1(e) {
    document.getElementById("select1").value = e.target.value
}
function mySelect2(e) {
    document.getElementById("select2").value = e.target.value
}
function mySelect3(e) {
    document.getElementById("select3").value = e.target.value
}
function mySelect4(e) {
    document.getElementById("select4").value = e.target.value
}
/////////////////////////////////////////////
$('#DefaultMetaIndexStatus').on('change', function () {
    if ($(this).is(':checked')) {
        $("#defaultMetaIndexStatus").val($(this).val());
    }
    else { $("#defaultMetaIndexStatus").val("noindex,nofollow"); }
});

//////////////////////////////////

function validateForImages(input) {
    const fileSize = input.files[0].size / 1024 / 1024;
    var fileName = input.files[0].name;
    var fileExtension = fileName.split('.').pop();

    switch (fileExtension) {
        case 'jpg':
            break;
        case 'JPG':
            break;
        case 'JPEG':
            break;
        case 'jpeg':
            break;
        default:
            alert('Dosya biçimi doğru değil');
            $(input).val('');
            break;
    }

    if (fileSize > 2) {
        alert('Dosya boyutu 2mb dan büyük olamaz');
        $(input).val('');
        // $(file).val(''); //for clearing with Jquery
    } else {
    }
}

function validateForFiles(input) {
    const fileSize = input.files[0].size / 1024 / 1024;
    var fileName = input.files[0].name;
    var fileExtension = fileName.split('.').pop();

    switch (fileExtension) {
        case 'doc':
            break;
        case 'docx':
            break;
        case 'pdf':
            break;
        case 'ppt':
            break;
        case 'pptx':
            break;
        case 'xls':
            break;
        case 'xlsx':
            break;
        case 'csv':
            break;
        default:
            alert('Dosya biçimi doğru değil');
            $(input).val('');
            break;
    }

    if (fileSize > 5) {
        alert('Dosya boyutu 5Mb dan büyük olamaz');
        $(input).val('');
        // $(file).val(''); //for clearing with Jquery
    } else {
    }
}

function validateForFilesMultiple(input) {
    const fileSize = input.files[0].size / 1024 / 1024;
    var fileName = input.files[0].name;
    var fileExtension = fileName.split('.').pop();

    switch (fileExtension) {
        case 'doc':
            break;
        case 'docx':
            break;
        case 'pdf':
            break;
        case 'ppt':
            break;
        case 'pptx':
            break;
        case 'xls':
            break;
        case 'xlsx':
            break;
        case 'csv':
            break;
        case 'jpg':
            break;
        case 'JPG':
            break;
        case 'JPEG':
            break;
        case 'jpeg':
            break;
        default:
            alert('Dosya biçimi doğru değil');
            $(input).val('');
            break;
    }

    if (fileSize > 5) {
        alert('Dosya boyutu 5Mb dan büyük olamaz');
        $(input).val('');
        // $(file).val(''); //for clearing with Jquery
    } else {
    }
}