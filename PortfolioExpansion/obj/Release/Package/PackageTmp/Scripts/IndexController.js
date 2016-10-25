$(document).ready(function () {
    $('[data-index-controller]').on('click', function (e) {
        e.preventDefault();
        $('#StateSelector').val($(this).data('index-controller'));
        $('form').submit();
    })

    $('.submitClick').on('click', function (e) {
        var viewSelect = $(this).data('submit-action');
        var controller = $('#StateSelector').val();

        $.ajax({
            url: "/" + controller + "/Partial",
            type: "POST",
            data:{ 'viewSelect' : viewSelect }
        })
        .done(function (partialViewResult) {
            $("#currPartial").html(partialViewResult);
            Prism.highlightAll();
        });
    });
});