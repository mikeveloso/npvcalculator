(function($) {

    $.npvcalculator = function(el, options) {
        var defaults = {
        	resetButton: $('#reset-button'),
        	yearsDropdown:  $('#drpYears'),
            cashFlowItemsContainer: $('#cashflow-items'),            
            urls: {
            	generateCashFlows: '/home/generatecashflows',
                calculateNpv: '/home/calculatenpv',
            }
        }

        var base = this;

        base.settings = {};
        
        base.$element = $(el);
        base.element = el;
        
        base.ensureOptions = function (defaultOptions) {
        	if(base.settings.resetButton === undefined || base.settings.resetButton === null) {
            	base.settings.resetButton = defaults.resetButton;
            }

            if(base.settings.resetButton === undefined || base.settings.resetButton === null) {
            	base.settings.yearsDropdown = defaults.yearsDropdown;
            }

            if(base.settings.urls === undefined || base.settings.urls === null) {
            	base.settings.urls = defaults.urls;
            } else {
            	if(base.settings.urls.generateCashFlows === undefined || base.settings.urls.generateCashFlows === null || base.settings.urls.generateCashFlows === '') {
            		base.settings.urls.generateCashFlows = defaults.urls.generateCashFlows;
            	}

            	if(base.settings.urls.calculateNpv === undefined || base.settings.urls.calculateNpv === null || base.settings.urls.calculateNpv === '') {
            		base.settings.urls.calculateNpv = defaults.urls.calculateNpv;
            	}
            }
        }
    	
        base.getNpvValue = function (formData, key, isObject = false) {
            var itemValue;
            var itemKey1;
            var itemKey2;

            if (isObject) {
                itemKey1 = 'CASHFLOWS[' + key.toString().toUpperCase() + '].CASHFLOW.YEAR';
                itemKey2 = 'CASHFLOWS[' + key.toString().toUpperCase() + '].CASHFLOW.AMOUNT';
                itemValue = { year: null, amount: null };;
            }

            $.each(formData, function () {
                if (isObject) {
                    if (this.name.toString().toUpperCase().indexOf(itemKey1) >= 0) {
                        itemValue.year = this.value;
                    } else if (this.name.toString().toUpperCase().indexOf(itemKey2) >= 0) {
                        itemValue.amount = this.value;
                        return
                    }
                }
                else if (this.name.toString().toUpperCase().indexOf(key.toString().toUpperCase()) >= 0) {
                    itemValue = this.value;
                    return
                }
            });
                
            return itemValue;
        }

        base.prepareNpvData = function () {
            var formData = base.$element.serializeArray(); //$('#' + base.$element.attr('id')).serializeArray();
            var npvData = { lowerBoundRate: null,upperBoundRate: null, rateIncrement: null, initialValue: null, years: null, cashFlows:[] };

            npvData.lowerBoundRate = base.getNpvValue(formData, 'lowerBoundRate', false);
            npvData.upperBoundRate = base.getNpvValue(formData, 'upperBoundRate', false);
            npvData.rateIncrement = base.getNpvValue(formData, 'rateIncrement', false);
            npvData.initialValue = base.getNpvValue(formData, 'initialValue', false);
            npvData.years = base.getNpvValue(formData, 'years', false);

            $.each(formData, function () {
                if (this.name.toString().toUpperCase().indexOf('CASHFLOWS.INDEX') >= 0) {
                    var cashFlowItem = base.getNpvValue(formData, this.value.toString().toUpperCase(), true);
                         
                    npvData.cashFlows.push(cashFlowItem);
                }
            });

            return npvData;      
        }        

        base.validateNpv = function() {
            
        }

        base.resetForm = function(e) {
            e.preventDefault();
            base.showloader(true);
            window.location.reload();
        }

        base.submitForm = function(e) {
        	e.preventDefault();
            
        	var npvFormData = base.prepareNpvData();

            if (base.$element.validateNpvCalculator()) {
                base.showloader(true);

                $.ajax({
                    url: base.settings.urls.calculateNpv,
                    type: "POST",
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify(npvFormData),
                    success: function (result) {
                        console.log(result);
                        base.settings.cashFlowItemsContainer.html(result);
                        
                    },
                    complete: function (result) {
                        base.showloader(false);
                    }
                });
            }
        }

        base.generateNpvCashFlows = function() {
        	var npvFormData = base.prepareNpvData();
            
            base.showloader(true);

            $.ajax({
                type: "POST",
                url: base.settings.urls.generateCashFlows,
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify(npvFormData),
                success: function (cfItems) {
                    console.log(cfItems);
                    base.settings.cashFlowItemsContainer.html(cfItems);
                },
                complete: function (result) {
                    base.showloader(false);
                }
            });        	
            
        }

        base.createPopUpContainer = function () {
            $('body').append('<div id="popup-window" class="popup-wrapper"><div class= "popup-overlay"><div class="popup-content"></span></div></div></div>');            
        }

        base.showPopupWindow = function (showWindow) {
            if (showWindow) {
                $('#popup-window').show();
            } else {
                $('#popup-window').hide();
            }
        }

        base.showloader = function (showLoader) {
            if (showLoader) {
                $('#popup-window popup-content').html('<span class="spinner"></span>');
            } else {
                $('#popup-window popup-content').html('');
            }
            base.showPopupWindow(showLoader);
        }
        
        base.init = function() {
            base.settings = $.extend({}, defaults, options);

            base.ensureOptions(defaults);

            base.settings.resetButton.click(function(e) { 
        		base.resetForm(e);
        	});

            base.settings.yearsDropdown.change(function(){
                base.generateNpvCashFlows();
            });

            base.$element.submit(function(e) {
            	base.submitForm(e);                
            });

            base.createPopUpContainer();
            base.showPopupWindow(false);
        }

        base.init();
    }

    $.fn.npvcalculator = function(options) {
        return this.each(function() {
            if (undefined == $(this).data('npvcalculator')) {
                var base = new $.npvcalculator(this, options);
                $(this).data('npvcalculator', base);
            }
        });
    }

    $.fn.validateNpvCalculator = function () {
        return $(this).validate();
    }

       
})(jQuery);