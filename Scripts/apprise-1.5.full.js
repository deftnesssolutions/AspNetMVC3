// Apprise 1.5 by Daniel Raftery
// http://thrivingkings.com/apprise
//
// Button text added by Adam Bezulski
//


//Options.string, Options.args, Options.callback
function apprise(Options) {
    var default_args =
		{
		    'confirm': false, 		        // Ok and Cancel buttons
		    'verify': false, 	            // Yes and No buttons
		    'input': false, 		        // Text input (can be true or Options.string for default text)
		    'animate': false, 	            // Groovy animation (can true or number, default is 400)
		    'semBotoes': false,             // Ajuste para criar uma popup sem botões
		    'textOk': 'Ok', 	            // Ok button default text
		    'textCancel': 'Cancelar',       // Cancel button default text
		    'textYes': 'Sim', 	            // Yes button default text
		    'textNo': 'N&atilde;o'	        // No button default text
		}

    if (Options.args) {
        for (var index in default_args)
        { if (typeof Options.args[index] == "undefined") Options.args[index] = default_args[index]; }
    }

    var aHeight = $(document).height();
    var aWidth = $(document).width();
    $('body').append('<div class="appriseOverlay" id="aOverlay"></div>');
    $('.appriseOverlay').css('height', aHeight).css('width', aWidth).fadeIn(100);
    $('body').append('<div class="appriseOuter"></div>');
    $('.appriseOuter').append('<div class="appriseInner"></div>');
    $('.appriseInner').append(Options.string);
    $('.appriseOuter').css("left", ($(window).width() - $('.appriseOuter').width()) / 2 + $(window).scrollLeft() + "px");

    if (Options.args) {
        if (Options.args['animate']) {
            var aniSpeed = Options.args['animate'];
            if (isNaN(aniSpeed)) { aniSpeed = 400; }
            $('.appriseOuter').css('top', '-200px').show().animate({ top: "100px" }, aniSpeed);
        }
        else
        { $('.appriseOuter').css('top', '300px').fadeIn(200); }
    }
    else
    { $('.appriseOuter').css('top', '300px').fadeIn(200); }

    if (Options.args) {
        if (Options.args['input']) {
            if (typeof (Options.args['input']) == 'Options.string') {
                $('.appriseInner').append('<div class="aInput"><input type="text" class="aTextbox" t="aTextbox" value="' + Options.args['input'] + '" /></div>');
            }
            else {
                $('.appriseInner').append('<div class="aInput"><input type="text" class="aTextbox" t="aTextbox" /></div>');
            }
            $('.aTextbox').focus();
        }
    }

    $('.appriseInner').append('<div class="aButtons"></div>');
    if (Options.args) {

        if (Options.args['confirm'] || Options.args['input']) {
            $('.aButtons').append('<button value="ok" onclick=>' + Options.args['textOk'] + '</button>');
            $('.aButtons').append('<button value="cancel" >' + Options.args['textCancel'] + '</button>');
        }
        else if (Options.args['verify']) {
            $('.aButtons').append('<button value="ok">' + Options.args['textYes'] + '</button>');
            $('.aButtons').append('<button value="cancel">' + Options.args['textNo'] + '</button>');
        }

        //If criado para gerar uma popup sem botões, apenas com a mensagem da Options.string enviada
        else if (Options.args['semBotoes'] == true) {
            $('.appriseOuter').css('height', 40);
        }
        //Fim do código editado

        else
        { $('.aButtons').append('<button value="ok">' + Options.args['textOk'] + '</button>'); }
    }
    else
    { $('.aButtons').append('<button value="ok">Ok</button>'); }

    $(document).keydown(function (e) {
        if ($('.appriseOverlay').is(':visible')) {
            if (e.keyCode == 13)
            { $('.aButtons > button[value="ok"]').click(); }
            if (e.keyCode == 27)
            { $('.aButtons > button[value="cancel"]').click(); }
        }
    });

    var aText = $('.aTextbox').val();
    if (!aText) { aText = false; }
    $('.aTextbox').keyup(function ()
    { aText = $(this).val(); });

    $('.aButtons > button').click(function () {
        $('.appriseOverlay').remove();
        $('.appriseOuter').remove();
        if (Options.callback) {
            var wButton = $(this).attr("value");
            if (wButton == 'ok') {
                if (Options.args) {
                    if (Options.args['input'])
                    { Options.callback(aText); }
                    else
                    { Options.callback(true); }
                }
                else
                { Options.callback(true); }
            }
            else if (wButton == 'cancel')
            { Options.callback(false); }
        }
    });
}
