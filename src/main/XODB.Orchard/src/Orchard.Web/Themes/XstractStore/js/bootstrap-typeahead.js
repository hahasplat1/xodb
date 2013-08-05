!function(d){var f=function(a,b){this.$element=d(a);this.options=d.extend({},d.fn.typeahead.defaults,b);this.matcher=this.options.matcher||this.matcher;this.sorter=this.options.sorter||this.sorter;this.highlighter=this.options.highlighter||this.highlighter;this.updater=this.options.updater||this.updater;this.source=this.options.source;this.$menu=d(this.options.menu);this.shown=false;this.listen()};f.prototype={constructor:f,select:function(){var a=this.$menu.find(".active").attr("data-value");this.$element.val(this.updater(a)).change();return this.hide()},updater:function(a){return a},show:function(){var a=d.extend({},this.$element.position(),{height:this.$element[0].offsetHeight});this.$menu.insertAfter(this.$element).css({top:a.top+a.height,left:a.left}).show();this.shown=true;return this},hide:function(){this.$menu.hide();this.shown=false;return this},lookup:function(a){var b;this.query=this.$element.val();if(!this.query||this.query.length<this.options.minLength){return this.shown?this.hide():this}b=d.isFunction(this.source)?this.source(this.query,d.proxy(this.process,this)):this.source;return b?this.process(b):this},process:function(b){var a=this;b=d.grep(b,function(c){return a.matcher(c)});b=this.sorter(b);if(!b.length){return this.shown?this.hide():this}return this.render(b.slice(0,this.options.items)).show()},matcher:function(a){return ~a.toLowerCase().indexOf(this.query.toLowerCase())},sorter:function(c){var b=[],i=[],j=[],a;while(a=c.shift()){if(!a.toLowerCase().indexOf(this.query.toLowerCase())){b.push(a)}else{if(~a.indexOf(this.query)){i.push(a)}else{j.push(a)}}}return b.concat(i,j)},highlighter:function(b){var a=this.query.replace(/[\-\[\]{}()*+?.,\\\^$|#\s]/g,"\\$&");return b.replace(new RegExp("("+a+")","ig"),function(h,c){return"<strong>"+c+"</strong>"})},render:function(b){var a=this;b=d(b).map(function(h,c){h=d(a.options.item).attr("data-value",c);h.find("a").html(a.highlighter(c));return h[0]});b.first().addClass("active");this.$menu.html(b);return this},next:function(b){var a=this.$menu.find(".active").removeClass("active"),c=a.next();if(!c.length){c=d(this.$menu.find("li")[0])}c.addClass("active")},prev:function(b){var a=this.$menu.find(".active").removeClass("active"),c=a.prev();if(!c.length){c=this.$menu.find("li").last()}c.addClass("active")},listen:function(){this.$element.on("focus",d.proxy(this.focus,this)).on("blur",d.proxy(this.blur,this)).on("keypress",d.proxy(this.keypress,this)).on("keyup",d.proxy(this.keyup,this));if(this.eventSupported("keydown")){this.$element.on("keydown",d.proxy(this.keydown,this))}this.$menu.on("click",d.proxy(this.click,this)).on("mouseenter","li",d.proxy(this.mouseenter,this)).on("mouseleave","li",d.proxy(this.mouseleave,this))},eventSupported:function(b){var a=b in this.$element;if(!a){this.$element.setAttribute(b,"return;");a=typeof this.$element[b]==="function"}return a},move:function(a){if(!this.shown){return}switch(a.keyCode){case 9:case 13:case 27:a.preventDefault();break;case 38:a.preventDefault();this.prev();break;case 40:a.preventDefault();this.next();break}a.stopPropagation()},keydown:function(a){this.suppressKeyPressRepeat=~d.inArray(a.keyCode,[40,38,9,13,27]);this.move(a)},keypress:function(a){if(this.suppressKeyPressRepeat){return}this.move(a)},keyup:function(a){switch(a.keyCode){case 40:case 38:case 16:case 17:case 18:break;case 9:case 13:if(!this.shown){return}this.select();break;case 27:if(!this.shown){return}this.hide();break;default:this.lookup()}a.stopPropagation();a.preventDefault()},focus:function(a){this.focused=true},blur:function(a){this.focused=false;if(!this.mousedover&&this.shown){this.hide()}},click:function(a){a.stopPropagation();a.preventDefault();this.select();this.$element.focus()},mouseenter:function(a){this.mousedover=true;this.$menu.find(".active").removeClass("active");d(a.currentTarget).addClass("active")},mouseleave:function(a){this.mousedover=false;if(!this.focused&&this.shown){this.hide()}}};var e=d.fn.typeahead;d.fn.typeahead=function(a){return this.each(function(){var b=d(this),c=b.data("typeahead"),h=typeof a=="object"&&a;if(!c){b.data("typeahead",(c=new f(this,h)))}if(typeof a=="string"){c[a]()}})};d.fn.typeahead.defaults={source:[],items:8,menu:'<ul class="typeahead dropdown-menu"></ul>',item:'<li><a href="#"></a></li>',minLength:1};d.fn.typeahead.Constructor=f;d.fn.typeahead.noConflict=function(){d.fn.typeahead=e;return this};d(document).on("focus.typeahead.data-api",'[data-provide="typeahead"]',function(a){var b=d(this);if(b.data("typeahead")){return}b.typeahead(b.data())})}(window.jQuery);