$(document).ready(function () {
    $('[data-index-controller]').on('click', function(e){
        e.preventDefault();
        $('#StateSelector').val($(this).data('index-controller'));
        $('form').submit();
    })

    
})