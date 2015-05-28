(function ($) {
    $.fn.formSubmit = function (options) {
        this.bind('submit', function () {
            var params = $(this.elements).serializeArray();
            var self = this;
            var ID = $(this).attr('id');
            // post do form
            var divImg = document.createElement('div');
            $.ajax({
                async: options.async,
                cache: false,
                type: 'POST',
                url: options.url,
                data: params,
                beforeSend: function () {
                    if ($('#' + ID).valid()) {
                        if (options && options.beforeSend) options.beforeSend();
                        return true;
                    }
                    return false;
                },
                complete: function (request, ajaxOptions, ajaxContext) {
                    if (options && options.complete) options.complete(request, ajaxOptions, ajaxContext);

                    $(divImg).remove();
                },
                failure: function (fail) {
                    if (options && options.failure) options.failure(fail);
                },
                success: function (request, ajaxOptions, errors) {
                    if (options && options.success) options.success(request, ajaxOptions, errors);
                    if (options && options.reset) {
                        self.reset();
                    }
                },
                error: function (request, status, errorThrown) {
                    if (options && options.error) options.error(request, status, errorThrown);
                }
            });
            return false;
        });
    };
})(jQuery);