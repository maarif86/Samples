
// Basic
$('.select').select2();

// Format icon
function iconFormat(icon) {
    var originalOption = icon.element;
    if (!icon.id) { return icon.text; }
    var $icon = "<i class='icon-" + $(icon.element).data('icon') + "'></i>" + icon.text;

    return $icon;
}

// Initialize with options
$(".select-icons").select2({
    templateResult: iconFormat,
    minimumResultsForSearch: Infinity,
    templateSelection: iconFormat,
    escapeMarkup: function (m) { return m; }
});

// Checkboxes, radios
$(".styled").uniform({ radioClass: 'choice' });

// File input
$(".file-styled").uniform({
    fileButtonHtml: '<i class="icon-googleplus5"></i>',
    wrapperClass: 'bg-warning'
});


