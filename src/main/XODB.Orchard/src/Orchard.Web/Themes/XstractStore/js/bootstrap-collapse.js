!function(d){var f=function(a,b){this.$element=d(a);this.options=d.extend({},d.fn.collapse.defaults,b);if(this.options.parent){this.$parent=d(this.options.parent)}this.options.toggle&&this.toggle()};f.prototype={constructor:f,dimension:function(){var a=this.$element.hasClass("width");return a?"width":"height"},show:function(){var a,h,b,c;if(this.transitioning||this.$element.hasClass("in")){return}a=this.dimension();h=d.camelCase(["scroll",a].join("-"));b=this.$parent&&this.$parent.find("> .accordion-group > .in");if(b&&b.length){c=b.data("collapse");if(c&&c.transitioning){return}b.collapse("hide");c||b.data("collapse",null)}this.$element[a](0);this.transition("addClass",d.Event("show"),"shown");d.support.transition&&this.$element[a](this.$element[0][h])},hide:function(){var a;if(this.transitioning||!this.$element.hasClass("in")){return}a=this.dimension();this.reset(this.$element[a]());this.transition("removeClass",d.Event("hide"),"hidden");this.$element[a](0)},reset:function(b){var a=this.dimension();this.$element.removeClass("collapse")[a](b||"auto")[0].offsetWidth;this.$element[b!==null?"addClass":"removeClass"]("collapse");return this},transition:function(a,i,c){var b=this,j=function(){if(i.type=="show"){b.reset()}b.transitioning=0;b.$element.trigger(c)};this.$element.trigger(i);if(i.isDefaultPrevented()){return}this.transitioning=1;this.$element[a]("in");d.support.transition&&this.$element.hasClass("collapse")?this.$element.one(d.support.transition.end,j):j()},toggle:function(){this[this.$element.hasClass("in")?"hide":"show"]()}};var e=d.fn.collapse;d.fn.collapse=function(a){return this.each(function(){var b=d(this),c=b.data("collapse"),h=d.extend({},d.fn.collapse.defaults,b.data(),typeof a=="object"&&a);if(!c){b.data("collapse",(c=new f(this,h)))}if(typeof a=="string"){c[a]()}})};d.fn.collapse.defaults={toggle:true};d.fn.collapse.Constructor=f;d.fn.collapse.noConflict=function(){d.fn.collapse=e;return this};d(document).on("click.collapse.data-api","[data-toggle=collapse]",function(a){var b=d(this),k,c=b.attr("data-target")||a.preventDefault()||(k=b.attr("href"))&&k.replace(/.*(?=#[^\s]+$)/,""),j=d(c).data("collapse")?"toggle":b.data();b[d(c).hasClass("in")?"addClass":"removeClass"]("collapsed");d(c).collapse(j)})}(window.jQuery);