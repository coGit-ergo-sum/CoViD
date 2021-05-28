(function(){/*

 Copyright The Closure Library Authors.
 SPDX-License-Identifier: Apache-2.0
*/
'use strict';var m;function aa(a){var b=0;return function(){return b<a.length?{done:!1,value:a[b++]}:{done:!0}}}
var ba="function"==typeof Object.defineProperties?Object.defineProperty:function(a,b,c){if(a==Array.prototype||a==Object.prototype)return a;a[b]=c.value;return a};
function ca(a){a=["object"==typeof globalThis&&globalThis,a,"object"==typeof window&&window,"object"==typeof self&&self,"object"==typeof global&&global];for(var b=0;b<a.length;++b){var c=a[b];if(c&&c.Math==Math)return c}throw Error("Cannot find global object");}
var da=ca(this);function r(a,b){if(b)a:{var c=da;a=a.split(".");for(var d=0;d<a.length-1;d++){var e=a[d];if(!(e in c))break a;c=c[e]}a=a[a.length-1];d=c[a];b=b(d);b!=d&&null!=b&&ba(c,a,{configurable:!0,writable:!0,value:b})}}
r("Symbol",function(a){function b(f){if(this instanceof b)throw new TypeError("Symbol is not a constructor");return new c(d+(f||"")+"_"+e++,f)}
function c(f,g){this.h=f;ba(this,"description",{configurable:!0,writable:!0,value:g})}
if(a)return a;c.prototype.toString=function(){return this.h};
var d="jscomp_symbol_"+(1E9*Math.random()>>>0)+"_",e=0;return b});
r("Symbol.iterator",function(a){if(a)return a;a=Symbol("Symbol.iterator");for(var b="Array Int8Array Uint8Array Uint8ClampedArray Int16Array Uint16Array Int32Array Uint32Array Float32Array Float64Array".split(" "),c=0;c<b.length;c++){var d=da[b[c]];"function"===typeof d&&"function"!=typeof d.prototype[a]&&ba(d.prototype,a,{configurable:!0,writable:!0,value:function(){return ea(aa(this))}})}return a});
function ea(a){a={next:a};a[Symbol.iterator]=function(){return this};
return a}
function u(a){var b="undefined"!=typeof Symbol&&Symbol.iterator&&a[Symbol.iterator];return b?b.call(a):{next:aa(a)}}
function fa(a){for(var b,c=[];!(b=a.next()).done;)c.push(b.value);return c}
var ha="function"==typeof Object.create?Object.create:function(a){function b(){}
b.prototype=a;return new b},ia=function(){function a(){function c(){}
new c;Reflect.construct(c,[],function(){});
return new c instanceof c}
if("undefined"!=typeof Reflect&&Reflect.construct){if(a())return Reflect.construct;var b=Reflect.construct;return function(c,d,e){c=b(c,d);e&&Reflect.setPrototypeOf(c,e.prototype);return c}}return function(c,d,e){void 0===e&&(e=c);
e=ha(e.prototype||Object.prototype);return Function.prototype.apply.call(c,e,d)||e}}(),ja;
if("function"==typeof Object.setPrototypeOf)ja=Object.setPrototypeOf;else{var ka;a:{var la={a:!0},ma={};try{ma.__proto__=la;ka=ma.a;break a}catch(a){}ka=!1}ja=ka?function(a,b){a.__proto__=b;if(a.__proto__!==b)throw new TypeError(a+" is not extensible");return a}:null}var na=ja;
function v(a,b){a.prototype=ha(b.prototype);a.prototype.constructor=a;if(na)na(a,b);else for(var c in b)if("prototype"!=c)if(Object.defineProperties){var d=Object.getOwnPropertyDescriptor(b,c);d&&Object.defineProperty(a,c,d)}else a[c]=b[c];a.N=b.prototype}
function oa(){this.o=!1;this.l=null;this.i=void 0;this.h=1;this.u=this.m=0;this.C=this.j=null}
function pa(a){if(a.o)throw new TypeError("Generator is already running");a.o=!0}
oa.prototype.B=function(a){this.i=a};
function qa(a,b){a.j={Ga:b,Ha:!0};a.h=a.m||a.u}
oa.prototype.return=function(a){this.j={return:a};this.h=this.u};
function w(a,b,c){a.h=c;return{value:b}}
oa.prototype.A=function(a){this.h=a};
function ra(a,b,c){a.m=b;void 0!=c&&(a.u=c)}
function sa(a){a.m=0;var b=a.j.Ga;a.j=null;return b}
function ta(a){a.C=[a.j];a.m=0;a.u=0}
function ua(a){var b=a.C.splice(0)[0];(b=a.j=a.j||b)?b.Ha?a.h=a.m||a.u:void 0!=b.A&&a.u<b.A?(a.h=b.A,a.j=null):a.h=a.u:a.h=0}
function va(a){this.h=new oa;this.i=a}
function wa(a,b){pa(a.h);var c=a.h.l;if(c)return xa(a,"return"in c?c["return"]:function(d){return{value:d,done:!0}},b,a.h.return);
a.h.return(b);return ya(a)}
function xa(a,b,c,d){try{var e=b.call(a.h.l,c);if(!(e instanceof Object))throw new TypeError("Iterator result "+e+" is not an object");if(!e.done)return a.h.o=!1,e;var f=e.value}catch(g){return a.h.l=null,qa(a.h,g),ya(a)}a.h.l=null;d.call(a.h,f);return ya(a)}
function ya(a){for(;a.h.h;)try{var b=a.i(a.h);if(b)return a.h.o=!1,{value:b.value,done:!1}}catch(c){a.h.i=void 0,qa(a.h,c)}a.h.o=!1;if(a.h.j){b=a.h.j;a.h.j=null;if(b.Ha)throw b.Ga;return{value:b.return,done:!0}}return{value:void 0,done:!0}}
function za(a){this.next=function(b){pa(a.h);a.h.l?b=xa(a,a.h.l.next,b,a.h.B):(a.h.B(b),b=ya(a));return b};
this.throw=function(b){pa(a.h);a.h.l?b=xa(a,a.h.l["throw"],b,a.h.B):(qa(a.h,b),b=ya(a));return b};
this.return=function(b){return wa(a,b)};
this[Symbol.iterator]=function(){return this}}
function x(a,b){b=new za(new va(b));na&&a.prototype&&na(b,a.prototype);return b}
r("Reflect",function(a){return a?a:{}});
r("Reflect.construct",function(){return ia});
r("Reflect.setPrototypeOf",function(a){return a?a:na?function(b,c){try{return na(b,c),!0}catch(d){return!1}}:null});
function Aa(a,b){return Object.prototype.hasOwnProperty.call(a,b)}
r("WeakMap",function(a){function b(k){this.h=(h+=Math.random()+1).toString();if(k){k=u(k);for(var l;!(l=k.next()).done;)l=l.value,this.set(l[0],l[1])}}
function c(){}
function d(k){var l=typeof k;return"object"===l&&null!==k||"function"===l}
function e(k){if(!Aa(k,g)){var l=new c;ba(k,g,{value:l})}}
function f(k){var l=Object[k];l&&(Object[k]=function(p){if(p instanceof c)return p;Object.isExtensible(p)&&e(p);return l(p)})}
if(function(){if(!a||!Object.seal)return!1;try{var k=Object.seal({}),l=Object.seal({}),p=new a([[k,2],[l,3]]);if(2!=p.get(k)||3!=p.get(l))return!1;p.delete(k);p.set(l,4);return!p.has(k)&&4==p.get(l)}catch(n){return!1}}())return a;
var g="$jscomp_hidden_"+Math.random();f("freeze");f("preventExtensions");f("seal");var h=0;b.prototype.set=function(k,l){if(!d(k))throw Error("Invalid WeakMap key");e(k);if(!Aa(k,g))throw Error("WeakMap key fail: "+k);k[g][this.h]=l;return this};
b.prototype.get=function(k){return d(k)&&Aa(k,g)?k[g][this.h]:void 0};
b.prototype.has=function(k){return d(k)&&Aa(k,g)&&Aa(k[g],this.h)};
b.prototype.delete=function(k){return d(k)&&Aa(k,g)&&Aa(k[g],this.h)?delete k[g][this.h]:!1};
return b});
r("Map",function(a){function b(){var h={};return h.previous=h.next=h.head=h}
function c(h,k){var l=h.h;return ea(function(){if(l){for(;l.head!=h.h;)l=l.previous;for(;l.next!=l.head;)return l=l.next,{done:!1,value:k(l)};l=null}return{done:!0,value:void 0}})}
function d(h,k){var l=k&&typeof k;"object"==l||"function"==l?f.has(k)?l=f.get(k):(l=""+ ++g,f.set(k,l)):l="p_"+k;var p=h.data_[l];if(p&&Aa(h.data_,l))for(h=0;h<p.length;h++){var n=p[h];if(k!==k&&n.key!==n.key||k===n.key)return{id:l,list:p,index:h,H:n}}return{id:l,list:p,index:-1,H:void 0}}
function e(h){this.data_={};this.h=b();this.size=0;if(h){h=u(h);for(var k;!(k=h.next()).done;)k=k.value,this.set(k[0],k[1])}}
if(function(){if(!a||"function"!=typeof a||!a.prototype.entries||"function"!=typeof Object.seal)return!1;try{var h=Object.seal({x:4}),k=new a(u([[h,"s"]]));if("s"!=k.get(h)||1!=k.size||k.get({x:4})||k.set({x:4},"t")!=k||2!=k.size)return!1;var l=k.entries(),p=l.next();if(p.done||p.value[0]!=h||"s"!=p.value[1])return!1;p=l.next();return p.done||4!=p.value[0].x||"t"!=p.value[1]||!l.next().done?!1:!0}catch(n){return!1}}())return a;
var f=new WeakMap;e.prototype.set=function(h,k){h=0===h?0:h;var l=d(this,h);l.list||(l.list=this.data_[l.id]=[]);l.H?l.H.value=k:(l.H={next:this.h,previous:this.h.previous,head:this.h,key:h,value:k},l.list.push(l.H),this.h.previous.next=l.H,this.h.previous=l.H,this.size++);return this};
e.prototype.delete=function(h){h=d(this,h);return h.H&&h.list?(h.list.splice(h.index,1),h.list.length||delete this.data_[h.id],h.H.previous.next=h.H.next,h.H.next.previous=h.H.previous,h.H.head=null,this.size--,!0):!1};
e.prototype.clear=function(){this.data_={};this.h=this.h.previous=b();this.size=0};
e.prototype.has=function(h){return!!d(this,h).H};
e.prototype.get=function(h){return(h=d(this,h).H)&&h.value};
e.prototype.entries=function(){return c(this,function(h){return[h.key,h.value]})};
e.prototype.keys=function(){return c(this,function(h){return h.key})};
e.prototype.values=function(){return c(this,function(h){return h.value})};
e.prototype.forEach=function(h,k){for(var l=this.entries(),p;!(p=l.next()).done;)p=p.value,h.call(k,p[1],p[0],this)};
e.prototype[Symbol.iterator]=e.prototype.entries;var g=0;return e});
function Ba(a,b,c){if(null==a)throw new TypeError("The 'this' value for String.prototype."+c+" must not be null or undefined");if(b instanceof RegExp)throw new TypeError("First argument to String.prototype."+c+" must not be a regular expression");return a+""}
r("String.prototype.endsWith",function(a){return a?a:function(b,c){var d=Ba(this,b,"endsWith");b+="";void 0===c&&(c=d.length);c=Math.max(0,Math.min(c|0,d.length));for(var e=b.length;0<e&&0<c;)if(d[--c]!=b[--e])return!1;return 0>=e}});
r("String.prototype.startsWith",function(a){return a?a:function(b,c){var d=Ba(this,b,"startsWith");b+="";var e=d.length,f=b.length;c=Math.max(0,Math.min(c|0,d.length));for(var g=0;g<f&&c<e;)if(d[c++]!=b[g++])return!1;return g>=f}});
r("Object.setPrototypeOf",function(a){return a||na});
var Ca="function"==typeof Object.assign?Object.assign:function(a,b){for(var c=1;c<arguments.length;c++){var d=arguments[c];if(d)for(var e in d)Aa(d,e)&&(a[e]=d[e])}return a};
r("Object.assign",function(a){return a||Ca});
r("Promise",function(a){function b(g){this.h=0;this.j=void 0;this.i=[];this.o=!1;var h=this.l();try{g(h.resolve,h.reject)}catch(k){h.reject(k)}}
function c(){this.h=null}
function d(g){return g instanceof b?g:new b(function(h){h(g)})}
if(a)return a;c.prototype.i=function(g){if(null==this.h){this.h=[];var h=this;this.j(function(){h.u()})}this.h.push(g)};
var e=da.setTimeout;c.prototype.j=function(g){e(g,0)};
c.prototype.u=function(){for(;this.h&&this.h.length;){var g=this.h;this.h=[];for(var h=0;h<g.length;++h){var k=g[h];g[h]=null;try{k()}catch(l){this.l(l)}}}this.h=null};
c.prototype.l=function(g){this.j(function(){throw g;})};
b.prototype.l=function(){function g(l){return function(p){k||(k=!0,l.call(h,p))}}
var h=this,k=!1;return{resolve:g(this.K),reject:g(this.u)}};
b.prototype.K=function(g){if(g===this)this.u(new TypeError("A Promise cannot resolve to itself"));else if(g instanceof b)this.P(g);else{a:switch(typeof g){case "object":var h=null!=g;break a;case "function":h=!0;break a;default:h=!1}h?this.J(g):this.m(g)}};
b.prototype.J=function(g){var h=void 0;try{h=g.then}catch(k){this.u(k);return}"function"==typeof h?this.ba(h,g):this.m(g)};
b.prototype.u=function(g){this.B(2,g)};
b.prototype.m=function(g){this.B(1,g)};
b.prototype.B=function(g,h){if(0!=this.h)throw Error("Cannot settle("+g+", "+h+"): Promise already settled in state"+this.h);this.h=g;this.j=h;2===this.h&&this.L();this.C()};
b.prototype.L=function(){var g=this;e(function(){if(g.F()){var h=da.console;"undefined"!==typeof h&&h.error(g.j)}},1)};
b.prototype.F=function(){if(this.o)return!1;var g=da.CustomEvent,h=da.Event,k=da.dispatchEvent;if("undefined"===typeof k)return!0;"function"===typeof g?g=new g("unhandledrejection",{cancelable:!0}):"function"===typeof h?g=new h("unhandledrejection",{cancelable:!0}):(g=da.document.createEvent("CustomEvent"),g.initCustomEvent("unhandledrejection",!1,!0,g));g.promise=this;g.reason=this.j;return k(g)};
b.prototype.C=function(){if(null!=this.i){for(var g=0;g<this.i.length;++g)f.i(this.i[g]);this.i=null}};
var f=new c;b.prototype.P=function(g){var h=this.l();g.ia(h.resolve,h.reject)};
b.prototype.ba=function(g,h){var k=this.l();try{g.call(h,k.resolve,k.reject)}catch(l){k.reject(l)}};
b.prototype.then=function(g,h){function k(t,q){return"function"==typeof t?function(D){try{l(t(D))}catch(K){p(K)}}:q}
var l,p,n=new b(function(t,q){l=t;p=q});
this.ia(k(g,l),k(h,p));return n};
b.prototype.catch=function(g){return this.then(void 0,g)};
b.prototype.ia=function(g,h){function k(){switch(l.h){case 1:g(l.j);break;case 2:h(l.j);break;default:throw Error("Unexpected state: "+l.h);}}
var l=this;null==this.i?f.i(k):this.i.push(k);this.o=!0};
b.resolve=d;b.reject=function(g){return new b(function(h,k){k(g)})};
b.race=function(g){return new b(function(h,k){for(var l=u(g),p=l.next();!p.done;p=l.next())d(p.value).ia(h,k)})};
b.all=function(g){var h=u(g),k=h.next();return k.done?d([]):new b(function(l,p){function n(D){return function(K){t[D]=K;q--;0==q&&l(t)}}
var t=[],q=0;do t.push(void 0),q++,d(k.value).ia(n(t.length-1),p),k=h.next();while(!k.done)})};
return b});
function Da(a,b){a instanceof String&&(a+="");var c=0,d=!1,e={next:function(){if(!d&&c<a.length){var f=c++;return{value:b(f,a[f]),done:!1}}d=!0;return{done:!0,value:void 0}}};
e[Symbol.iterator]=function(){return e};
return e}
r("Array.prototype.entries",function(a){return a?a:function(){return Da(this,function(b,c){return[b,c]})}});
r("Object.entries",function(a){return a?a:function(b){var c=[],d;for(d in b)Aa(b,d)&&c.push([d,b[d]]);return c}});
r("Array.prototype.keys",function(a){return a?a:function(){return Da(this,function(b){return b})}});
r("Array.prototype.values",function(a){return a?a:function(){return Da(this,function(b,c){return c})}});
r("Array.from",function(a){return a?a:function(b,c,d){c=null!=c?c:function(h){return h};
var e=[],f="undefined"!=typeof Symbol&&Symbol.iterator&&b[Symbol.iterator];if("function"==typeof f){b=f.call(b);for(var g=0;!(f=b.next()).done;)e.push(c.call(d,f.value,g++))}else for(f=b.length,g=0;g<f;g++)e.push(c.call(d,b[g],g));return e}});
r("Number.isNaN",function(a){return a?a:function(b){return"number"===typeof b&&isNaN(b)}});
r("Number.MAX_SAFE_INTEGER",function(){return 9007199254740991});
r("Object.is",function(a){return a?a:function(b,c){return b===c?0!==b||1/b===1/c:b!==b&&c!==c}});
r("Array.prototype.includes",function(a){return a?a:function(b,c){var d=this;d instanceof String&&(d=String(d));var e=d.length;c=c||0;for(0>c&&(c=Math.max(c+e,0));c<e;c++){var f=d[c];if(f===b||Object.is(f,b))return!0}return!1}});
r("String.prototype.includes",function(a){return a?a:function(b,c){return-1!==Ba(this,b,"includes").indexOf(b,c||0)}});
r("Set",function(a){function b(c){this.h=new Map;if(c){c=u(c);for(var d;!(d=c.next()).done;)this.add(d.value)}this.size=this.h.size}
if(function(){if(!a||"function"!=typeof a||!a.prototype.entries||"function"!=typeof Object.seal)return!1;try{var c=Object.seal({x:4}),d=new a(u([c]));if(!d.has(c)||1!=d.size||d.add(c)!=d||1!=d.size||d.add({x:4})!=d||2!=d.size)return!1;var e=d.entries(),f=e.next();if(f.done||f.value[0]!=c||f.value[1]!=c)return!1;f=e.next();return f.done||f.value[0]==c||4!=f.value[0].x||f.value[1]!=f.value[0]?!1:e.next().done}catch(g){return!1}}())return a;
b.prototype.add=function(c){c=0===c?0:c;this.h.set(c,c);this.size=this.h.size;return this};
b.prototype.delete=function(c){c=this.h.delete(c);this.size=this.h.size;return c};
b.prototype.clear=function(){this.h.clear();this.size=0};
b.prototype.has=function(c){return this.h.has(c)};
b.prototype.entries=function(){return this.h.entries()};
b.prototype.values=function(){return this.h.values()};
b.prototype.keys=b.prototype.values;b.prototype[Symbol.iterator]=b.prototype.values;b.prototype.forEach=function(c,d){var e=this;this.h.forEach(function(f){return c.call(d,f,f,e)})};
return b});
r("Object.values",function(a){return a?a:function(b){var c=[],d;for(d in b)Aa(b,d)&&c.push(b[d]);return c}});
var y=this||self;function z(a,b,c){a=a.split(".");c=c||y;a[0]in c||"undefined"==typeof c.execScript||c.execScript("var "+a[0]);for(var d;a.length&&(d=a.shift());)a.length||void 0===b?c[d]&&c[d]!==Object.prototype[d]?c=c[d]:c=c[d]={}:c[d]=b}
function A(a,b){a=a.split(".");b=b||y;for(var c=0;c<a.length;c++)if(b=b[a[c]],null==b)return null;return b}
function Ea(){}
function Fa(a){a.va=void 0;a.getInstance=function(){return a.va?a.va:a.va=new a}}
function Ga(a){var b=typeof a;return"object"!=b?b:a?Array.isArray(a)?"array":b:"null"}
function Ha(a){var b=Ga(a);return"array"==b||"object"==b&&"number"==typeof a.length}
function Ia(a){var b=typeof a;return"object"==b&&null!=a||"function"==b}
function Ja(a){return Object.prototype.hasOwnProperty.call(a,Ka)&&a[Ka]||(a[Ka]=++La)}
var Ka="closure_uid_"+(1E9*Math.random()>>>0),La=0;function Ma(a,b,c){return a.call.apply(a.bind,arguments)}
function Na(a,b,c){if(!a)throw Error();if(2<arguments.length){var d=Array.prototype.slice.call(arguments,2);return function(){var e=Array.prototype.slice.call(arguments);Array.prototype.unshift.apply(e,d);return a.apply(b,e)}}return function(){return a.apply(b,arguments)}}
function Oa(a,b,c){Function.prototype.bind&&-1!=Function.prototype.bind.toString().indexOf("native code")?Oa=Ma:Oa=Na;return Oa.apply(null,arguments)}
function Pa(a,b){var c=Array.prototype.slice.call(arguments,1);return function(){var d=c.slice();d.push.apply(d,arguments);return a.apply(this,d)}}
function Qa(a,b){z(a,b,void 0)}
function B(a,b){function c(){}
c.prototype=b.prototype;a.N=b.prototype;a.prototype=new c;a.prototype.constructor=a;a.Rk=function(d,e,f){for(var g=Array(arguments.length-2),h=2;h<arguments.length;h++)g[h-2]=arguments[h];return b.prototype[e].apply(d,g)}}
function Ra(a){return a}
;function Sa(a,b){if(Error.captureStackTrace)Error.captureStackTrace(this,Sa);else{var c=Error().stack;c&&(this.stack=c)}a&&(this.message=String(a));b&&(this.Pa=b)}
B(Sa,Error);Sa.prototype.name="CustomError";function Ta(a){a=a.url;var b=/[?&]dsh=1(&|$)/.test(a);this.j=!b&&/[?&]ae=1(&|$)/.test(a);this.l=!b&&/[?&]ae=2(&|$)/.test(a);if((this.h=/[?&]adurl=([^&]*)/.exec(a))&&this.h[1]){try{var c=decodeURIComponent(this.h[1])}catch(d){c=null}this.i=c}}
;function Va(a){var b=!1,c;return function(){b||(c=a(),b=!0);return c}}
;var Wa=Array.prototype.indexOf?function(a,b){return Array.prototype.indexOf.call(a,b,void 0)}:function(a,b){if("string"===typeof a)return"string"!==typeof b||1!=b.length?-1:a.indexOf(b,0);
for(var c=0;c<a.length;c++)if(c in a&&a[c]===b)return c;return-1},C=Array.prototype.forEach?function(a,b,c){Array.prototype.forEach.call(a,b,c)}:function(a,b,c){for(var d=a.length,e="string"===typeof a?a.split(""):a,f=0;f<d;f++)f in e&&b.call(c,e[f],f,a)},Xa=Array.prototype.filter?function(a,b){return Array.prototype.filter.call(a,b,void 0)}:function(a,b){for(var c=a.length,d=[],e=0,f="string"===typeof a?a.split(""):a,g=0;g<c;g++)if(g in f){var h=f[g];
b.call(void 0,h,g,a)&&(d[e++]=h)}return d},Ya=Array.prototype.map?function(a,b){return Array.prototype.map.call(a,b,void 0)}:function(a,b){for(var c=a.length,d=Array(c),e="string"===typeof a?a.split(""):a,f=0;f<c;f++)f in e&&(d[f]=b.call(void 0,e[f],f,a));
return d},Za=Array.prototype.reduce?function(a,b,c){return Array.prototype.reduce.call(a,b,c)}:function(a,b,c){var d=c;
C(a,function(e,f){d=b.call(void 0,d,e,f,a)});
return d};
function $a(a,b){a:{for(var c=a.length,d="string"===typeof a?a.split(""):a,e=0;e<c;e++)if(e in d&&b.call(void 0,d[e],e,a)){b=e;break a}b=-1}return 0>b?null:"string"===typeof a?a.charAt(b):a[b]}
function ab(a,b){b=Wa(a,b);var c;(c=0<=b)&&Array.prototype.splice.call(a,b,1);return c}
function bb(a){var b=a.length;if(0<b){for(var c=Array(b),d=0;d<b;d++)c[d]=a[d];return c}return[]}
function cb(a,b){for(var c=1;c<arguments.length;c++){var d=arguments[c];if(Ha(d)){var e=a.length||0,f=d.length||0;a.length=e+f;for(var g=0;g<f;g++)a[e+g]=d[g]}else a.push(d)}}
;function db(a,b){for(var c in a)b.call(void 0,a[c],c,a)}
function eb(a){var b=fb,c;for(c in b)if(a.call(void 0,b[c],c,b))return c}
function gb(a){for(var b in a)return!1;return!0}
function hb(a,b){if(null!==a&&b in a)throw Error('The object already contains the key "'+b+'"');a[b]=!0}
function ib(){var a=E("PLAYER_VARS",{});return null!==a&&"privembed"in a?a.privembed:!1}
function jb(a,b){for(var c in a)if(!(c in b)||a[c]!==b[c])return!1;for(var d in b)if(!(d in a))return!1;return!0}
function kb(a){var b={},c;for(c in a)b[c]=a[c];return b}
function lb(a){if(!a||"object"!==typeof a)return a;if("function"===typeof a.clone)return a.clone();if("undefined"!==typeof Map&&a instanceof Map)return new Map(a);if("undefined"!==typeof Set&&a instanceof Set)return new Set(a);var b=Array.isArray(a)?[]:"function"!==typeof ArrayBuffer||"function"!==typeof ArrayBuffer.isView||!ArrayBuffer.isView(a)||a instanceof DataView?{}:new a.constructor(a.length),c;for(c in a)b[c]=lb(a[c]);return b}
var mb="constructor hasOwnProperty isPrototypeOf propertyIsEnumerable toLocaleString toString valueOf".split(" ");function nb(a,b){for(var c,d,e=1;e<arguments.length;e++){d=arguments[e];for(c in d)a[c]=d[c];for(var f=0;f<mb.length;f++)c=mb[f],Object.prototype.hasOwnProperty.call(d,c)&&(a[c]=d[c])}}
;var ob;function pb(){if(void 0===ob){var a=null,b=y.trustedTypes;if(b&&b.createPolicy){try{a=b.createPolicy("goog#html",{createHTML:Ra,createScript:Ra,createScriptURL:Ra})}catch(c){y.console&&y.console.error(c.message)}ob=a}else ob=a}return ob}
;var qb={};function rb(a){this.h=qb===qb?a:"";this.Y=!0}
rb.prototype.X=function(){return this.h.toString()};
rb.prototype.toString=function(){return this.h.toString()};function sb(a,b){this.h=b===tb?a:""}
m=sb.prototype;m.Y=!0;m.X=function(){return this.h.toString()};
m.ta=!0;m.qa=function(){return 1};
m.toString=function(){return this.h+""};
function ub(a){if(a instanceof sb&&a.constructor===sb)return a.h;Ga(a);return"type_error:TrustedResourceUrl"}
var tb={};function vb(a){var b=pb();a=b?b.createScriptURL(a):a;return new sb(a,tb)}
;var wb=String.prototype.trim?function(a){return a.trim()}:function(a){return/^[\s\xa0]*([\s\S]*?)[\s\xa0]*$/.exec(a)[1]};
function xb(a,b){if(b)a=a.replace(yb,"&amp;").replace(zb,"&lt;").replace(Ab,"&gt;").replace(Bb,"&quot;").replace(Cb,"&#39;").replace(Db,"&#0;");else{if(!Eb.test(a))return a;-1!=a.indexOf("&")&&(a=a.replace(yb,"&amp;"));-1!=a.indexOf("<")&&(a=a.replace(zb,"&lt;"));-1!=a.indexOf(">")&&(a=a.replace(Ab,"&gt;"));-1!=a.indexOf('"')&&(a=a.replace(Bb,"&quot;"));-1!=a.indexOf("'")&&(a=a.replace(Cb,"&#39;"));-1!=a.indexOf("\x00")&&(a=a.replace(Db,"&#0;"))}return a}
var yb=/&/g,zb=/</g,Ab=/>/g,Bb=/"/g,Cb=/'/g,Db=/\x00/g,Eb=/[\x00&<>"']/;function Fb(a,b){this.h=b===Gb?a:""}
m=Fb.prototype;m.Y=!0;m.X=function(){return this.h.toString()};
m.ta=!0;m.qa=function(){return 1};
m.toString=function(){return this.h.toString()};
function Hb(a){if(a instanceof Fb&&a.constructor===Fb)return a.h;Ga(a);return"type_error:SafeUrl"}
var Ib=/^(?:audio\/(?:3gpp2|3gpp|aac|L16|midi|mp3|mp4|mpeg|oga|ogg|opus|x-m4a|x-matroska|x-wav|wav|webm)|font\/\w+|image\/(?:bmp|gif|jpeg|jpg|png|tiff|webp|x-icon)|video\/(?:mpeg|mp4|ogg|webm|quicktime|x-matroska))(?:;\w+=(?:\w+|"[\w;,= ]+"))*$/i,Jb=/^data:(.*);base64,[a-z0-9+\/]+=*$/i,Kb=/^(?:(?:https?|mailto|ftp):|[^:/?#]*(?:[/?#]|$))/i;function Lb(a){if(a instanceof Fb)return a;a="object"==typeof a&&a.Y?a.X():String(a);Kb.test(a)||(a="about:invalid#zClosurez");return new Fb(a,Gb)}
var Gb={},Mb=new Fb("about:invalid#zClosurez",Gb);var Nb;a:{var Ob=y.navigator;if(Ob){var Pb=Ob.userAgent;if(Pb){Nb=Pb;break a}}Nb=""}function F(a){return-1!=Nb.indexOf(a)}
;function Qb(a,b,c){this.h=c===Rb?a:"";this.i=b}
m=Qb.prototype;m.ta=!0;m.qa=function(){return this.i};
m.Y=!0;m.X=function(){return this.h.toString()};
m.toString=function(){return this.h.toString()};
var Rb={};function Sb(a,b){var c=pb();a=c?c.createHTML(a):a;return new Qb(a,b,Rb)}
;function Tb(a,b){b=b instanceof Fb?b:Lb(b);a.href=Hb(b)}
function Ub(a,b){a.rel="stylesheet";a.href=ub(b).toString();(b=Vb('style[nonce],link[rel="stylesheet"][nonce]',a.ownerDocument&&a.ownerDocument.defaultView))&&a.setAttribute("nonce",b)}
function Wb(){return Vb("script[nonce]",void 0)}
var Xb=/^[\w+/_-]+[=]{0,2}$/;function Vb(a,b){b=(b||y).document;return b.querySelector?(a=b.querySelector(a))&&(a=a.nonce||a.getAttribute("nonce"))&&Xb.test(a)?a:"":""}
;function Yb(a){return a=xb(a,void 0)}
function Zb(a){for(var b=0,c=0;c<a.length;++c)b=31*b+a.charCodeAt(c)>>>0;return b}
;var $b=/^(?:([^:/?#.]+):)?(?:\/\/(?:([^\\/?#]*)@)?([^\\/?#]*?)(?::([0-9]+))?(?=[\\/?#]|$))?([^?#]+)?(?:\?([^#]*))?(?:#([\s\S]*))?$/;function ac(a){return a?decodeURI(a):a}
function bc(a){return ac(a.match($b)[3]||null)}
function cc(a,b,c){if(Array.isArray(b))for(var d=0;d<b.length;d++)cc(a,String(b[d]),c);else null!=b&&c.push(a+(""===b?"":"="+encodeURIComponent(String(b))))}
function dc(a){var b=[],c;for(c in a)cc(c,a[c],b);return b.join("&")}
function ec(a,b){b=dc(b);if(b){var c=a.indexOf("#");0>c&&(c=a.length);var d=a.indexOf("?");if(0>d||d>c){d=c;var e=""}else e=a.substring(d+1,c);a=[a.substr(0,d),e,a.substr(c)];c=a[1];a[1]=b?c?c+"&"+b:b:c;b=a[0]+(a[1]?"?"+a[1]:"")+a[2]}else b=a;return b}
var fc=/#|$/;function G(a,b){var c=void 0;return new (c||(c=Promise))(function(d,e){function f(k){try{h(b.next(k))}catch(l){e(l)}}
function g(k){try{h(b["throw"](k))}catch(l){e(l)}}
function h(k){k.done?d(k.value):(new c(function(l){l(k.value)})).then(f,g)}
h((b=b.apply(a,void 0)).next())})}
;function gc(){return F("iPhone")&&!F("iPod")&&!F("iPad")}
;function hc(a){hc[" "](a);return a}
hc[" "]=Ea;var ic=F("Opera"),jc=F("Trident")||F("MSIE"),kc=F("Edge"),lc=F("Gecko")&&!(-1!=Nb.toLowerCase().indexOf("webkit")&&!F("Edge"))&&!(F("Trident")||F("MSIE"))&&!F("Edge"),mc=-1!=Nb.toLowerCase().indexOf("webkit")&&!F("Edge");function nc(){var a=y.document;return a?a.documentMode:void 0}
var oc;a:{var pc="",qc=function(){var a=Nb;if(lc)return/rv:([^\);]+)(\)|;)/.exec(a);if(kc)return/Edge\/([\d\.]+)/.exec(a);if(jc)return/\b(?:MSIE|rv)[: ]([^\);]+)(\)|;)/.exec(a);if(mc)return/WebKit\/(\S+)/.exec(a);if(ic)return/(?:Version)[ \/]?(\S+)/.exec(a)}();
qc&&(pc=qc?qc[1]:"");if(jc){var rc=nc();if(null!=rc&&rc>parseFloat(pc)){oc=String(rc);break a}}oc=pc}var sc=oc,tc;if(y.document&&jc){var uc=nc();tc=uc?uc:parseInt(sc,10)||void 0}else tc=void 0;var vc=tc;var wc=gc()||F("iPod"),xc=F("iPad"),yc=F("Safari")&&!((F("Chrome")||F("CriOS"))&&!F("Edge")||F("Coast")||F("Opera")||F("Edge")||F("Edg/")||F("OPR")||F("Firefox")||F("FxiOS")||F("Silk")||F("Android"))&&!(gc()||F("iPad")||F("iPod"));var zc={},Ac=null;
function Bc(a){var b=3;Ha(a);void 0===b&&(b=0);if(!Ac){Ac={};for(var c="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".split(""),d=["+/=","+/","-_=","-_.","-_"],e=0;5>e;e++){var f=c.concat(d[e].split(""));zc[e]=f;for(var g=0;g<f.length;g++){var h=f[g];void 0===Ac[h]&&(Ac[h]=g)}}}b=zc[b];c=[];for(d=0;d<a.length;d+=3){var k=a[d],l=(e=d+1<a.length)?a[d+1]:0;h=(f=d+2<a.length)?a[d+2]:0;g=k>>2;k=(k&3)<<4|l>>4;l=(l&15)<<2|h>>6;h&=63;f||(h=64,e||(l=64));c.push(b[g],b[k],b[l]||"",b[h]||"")}return c.join("")}
;var H=window;var Cc=!jc||9<=Number(vc);function Dc(a,b){this.x=void 0!==a?a:0;this.y=void 0!==b?b:0}
m=Dc.prototype;m.clone=function(){return new Dc(this.x,this.y)};
m.equals=function(a){return a instanceof Dc&&(this==a?!0:this&&a?this.x==a.x&&this.y==a.y:!1)};
m.ceil=function(){this.x=Math.ceil(this.x);this.y=Math.ceil(this.y);return this};
m.floor=function(){this.x=Math.floor(this.x);this.y=Math.floor(this.y);return this};
m.round=function(){this.x=Math.round(this.x);this.y=Math.round(this.y);return this};function Ec(a,b){this.width=a;this.height=b}
m=Ec.prototype;m.clone=function(){return new Ec(this.width,this.height)};
m.aspectRatio=function(){return this.width/this.height};
m.isEmpty=function(){return!(this.width*this.height)};
m.ceil=function(){this.width=Math.ceil(this.width);this.height=Math.ceil(this.height);return this};
m.floor=function(){this.width=Math.floor(this.width);this.height=Math.floor(this.height);return this};
m.round=function(){this.width=Math.round(this.width);this.height=Math.round(this.height);return this};function Fc(a){var b=document;return"string"===typeof a?b.getElementById(a):a}
function Gc(a,b){db(b,function(c,d){c&&"object"==typeof c&&c.Y&&(c=c.X());"style"==d?a.style.cssText=c:"class"==d?a.className=c:"for"==d?a.htmlFor=c:Hc.hasOwnProperty(d)?a.setAttribute(Hc[d],c):0==d.lastIndexOf("aria-",0)||0==d.lastIndexOf("data-",0)?a.setAttribute(d,c):a[d]=c})}
var Hc={cellpadding:"cellPadding",cellspacing:"cellSpacing",colspan:"colSpan",frameborder:"frameBorder",height:"height",maxlength:"maxLength",nonce:"nonce",role:"role",rowspan:"rowSpan",type:"type",usemap:"useMap",valign:"vAlign",width:"width"};
function Ic(a,b,c){var d=arguments,e=document,f=String(d[0]),g=d[1];if(!Cc&&g&&(g.name||g.type)){f=["<",f];g.name&&f.push(' name="',Yb(g.name),'"');if(g.type){f.push(' type="',Yb(g.type),'"');var h={};nb(h,g);delete h.type;g=h}f.push(">");f=f.join("")}f=Jc(e,f);g&&("string"===typeof g?f.className=g:Array.isArray(g)?f.className=g.join(" "):Gc(f,g));2<d.length&&Kc(e,f,d);return f}
function Kc(a,b,c){function d(h){h&&b.appendChild("string"===typeof h?a.createTextNode(h):h)}
for(var e=2;e<c.length;e++){var f=c[e];if(!Ha(f)||Ia(f)&&0<f.nodeType)d(f);else{a:{if(f&&"number"==typeof f.length){if(Ia(f)){var g="function"==typeof f.item||"string"==typeof f.item;break a}if("function"===typeof f){g="function"==typeof f.item;break a}}g=!1}C(g?bb(f):f,d)}}}
function Jc(a,b){b=String(b);"application/xhtml+xml"===a.contentType&&(b=b.toLowerCase());return a.createElement(b)}
function Lc(a,b){for(var c=0;a;){if(b(a))return a;a=a.parentNode;c++}return null}
;function Mc(a){var b=Nc;if(b)for(var c in b)Object.prototype.hasOwnProperty.call(b,c)&&a.call(void 0,b[c],c,b)}
function Oc(){var a=[];Mc(function(b){a.push(b)});
return a}
var Nc={Hb:"allow-forms",Ib:"allow-modals",Jb:"allow-orientation-lock",Kb:"allow-pointer-lock",Lb:"allow-popups",Mb:"allow-popups-to-escape-sandbox",Nb:"allow-presentation",Ob:"allow-same-origin",Pb:"allow-scripts",Qb:"allow-top-navigation",Rb:"allow-top-navigation-by-user-activation"},Pc=Va(function(){return Oc()});
function Qc(){var a=Jc(document,"IFRAME"),b={};C(Pc(),function(c){a.sandbox&&a.sandbox.supports&&a.sandbox.supports(c)&&(b[c]=!0)});
return b}
;function Rc(a,b){a.src=ub(b);var c;b=(a.ownerDocument&&a.ownerDocument.defaultView||window).document;(c=(b=null===(c=b.querySelector)||void 0===c?void 0:c.call(b,"script[nonce]"))?b.nonce||b.getAttribute("nonce")||"":"")&&a.setAttribute("nonce",c)}
;function Sc(a){Tc();return vb(a)}
var Tc=Ea;function Uc(a){"number"==typeof a&&(a=Math.round(a)+"px");return a}
;var Vc=(new Date).getTime();function Wc(a){if(!a)return"";a=a.split("#")[0].split("?")[0];a=a.toLowerCase();0==a.indexOf("//")&&(a=window.location.protocol+a);/^[\w\-]*:\/\//.test(a)||(a=window.location.href);var b=a.substring(a.indexOf("://")+3),c=b.indexOf("/");-1!=c&&(b=b.substring(0,c));c=a.substring(0,a.indexOf("://"));if(!c)throw Error("URI is missing protocol: "+a);if("http"!==c&&"https"!==c&&"chrome-extension"!==c&&"moz-extension"!==c&&"file"!==c&&"android-app"!==c&&"chrome-search"!==c&&"chrome-untrusted"!==c&&"chrome"!==
c&&"app"!==c&&"devtools"!==c)throw Error("Invalid URI scheme in origin: "+c);a="";var d=b.indexOf(":");if(-1!=d){var e=b.substring(d+1);b=b.substring(0,d);if("http"===c&&"80"!==e||"https"===c&&"443"!==e)a=":"+e}return c+"://"+b+a}
;function Xc(){function a(){e[0]=1732584193;e[1]=4023233417;e[2]=2562383102;e[3]=271733878;e[4]=3285377520;p=l=0}
function b(n){for(var t=g,q=0;64>q;q+=4)t[q/4]=n[q]<<24|n[q+1]<<16|n[q+2]<<8|n[q+3];for(q=16;80>q;q++)n=t[q-3]^t[q-8]^t[q-14]^t[q-16],t[q]=(n<<1|n>>>31)&4294967295;n=e[0];var D=e[1],K=e[2],N=e[3],X=e[4];for(q=0;80>q;q++){if(40>q)if(20>q){var Y=N^D&(K^N);var I=1518500249}else Y=D^K^N,I=1859775393;else 60>q?(Y=D&K|N&(D|K),I=2400959708):(Y=D^K^N,I=3395469782);Y=((n<<5|n>>>27)&4294967295)+Y+X+I+t[q]&4294967295;X=N;N=K;K=(D<<30|D>>>2)&4294967295;D=n;n=Y}e[0]=e[0]+n&4294967295;e[1]=e[1]+D&4294967295;e[2]=
e[2]+K&4294967295;e[3]=e[3]+N&4294967295;e[4]=e[4]+X&4294967295}
function c(n,t){if("string"===typeof n){n=unescape(encodeURIComponent(n));for(var q=[],D=0,K=n.length;D<K;++D)q.push(n.charCodeAt(D));n=q}t||(t=n.length);q=0;if(0==l)for(;q+64<t;)b(n.slice(q,q+64)),q+=64,p+=64;for(;q<t;)if(f[l++]=n[q++],p++,64==l)for(l=0,b(f);q+64<t;)b(n.slice(q,q+64)),q+=64,p+=64}
function d(){var n=[],t=8*p;56>l?c(h,56-l):c(h,64-(l-56));for(var q=63;56<=q;q--)f[q]=t&255,t>>>=8;b(f);for(q=t=0;5>q;q++)for(var D=24;0<=D;D-=8)n[t++]=e[q]>>D&255;return n}
for(var e=[],f=[],g=[],h=[128],k=1;64>k;++k)h[k]=0;var l,p;a();return{reset:a,update:c,digest:d,Qa:function(){for(var n=d(),t="",q=0;q<n.length;q++)t+="0123456789ABCDEF".charAt(Math.floor(n[q]/16))+"0123456789ABCDEF".charAt(n[q]%16);return t}}}
;function Yc(a,b,c){var d=String(y.location.href);return d&&a&&b?[b,Zc(Wc(d),a,c||null)].join(" "):null}
function Zc(a,b,c){var d=[],e=[];if(1==(Array.isArray(c)?2:1))return e=[b,a],C(d,function(h){e.push(h)}),$c(e.join(" "));
var f=[],g=[];C(c,function(h){g.push(h.key);f.push(h.value)});
c=Math.floor((new Date).getTime()/1E3);e=0==f.length?[c,b,a]:[f.join(":"),c,b,a];C(d,function(h){e.push(h)});
a=$c(e.join(" "));a=[c,a];0==g.length||a.push(g.join(""));return a.join("_")}
function $c(a){var b=Xc();b.update(a);return b.Qa().toLowerCase()}
;var ad={};function bd(a){this.h=a||{cookie:""}}
m=bd.prototype;m.isEnabled=function(){if(!y.navigator.cookieEnabled)return!1;if(!this.isEmpty())return!0;this.set("TESTCOOKIESENABLED","1",{wa:60});if("1"!==this.get("TESTCOOKIESENABLED"))return!1;this.remove("TESTCOOKIESENABLED");return!0};
m.set=function(a,b,c){var d=!1;if("object"===typeof c){var e=c.Yk;d=c.secure||!1;var f=c.domain||void 0;var g=c.path||void 0;var h=c.wa}if(/[;=\s]/.test(a))throw Error('Invalid cookie name "'+a+'"');if(/[;\r\n]/.test(b))throw Error('Invalid cookie value "'+b+'"');void 0===h&&(h=-1);this.h.cookie=a+"="+b+(f?";domain="+f:"")+(g?";path="+g:"")+(0>h?"":0==h?";expires="+(new Date(1970,1,1)).toUTCString():";expires="+(new Date(Date.now()+1E3*h)).toUTCString())+(d?";secure":"")+(null!=e?";samesite="+e:"")};
m.get=function(a,b){for(var c=a+"=",d=(this.h.cookie||"").split(";"),e=0,f;e<d.length;e++){f=wb(d[e]);if(0==f.lastIndexOf(c,0))return f.substr(c.length);if(f==a)return""}return b};
m.remove=function(a,b,c){var d=void 0!==this.get(a);this.set(a,"",{wa:0,path:b,domain:c});return d};
m.isEmpty=function(){return!this.h.cookie};
m.clear=function(){for(var a=(this.h.cookie||"").split(";"),b=[],c=[],d,e,f=0;f<a.length;f++)e=wb(a[f]),d=e.indexOf("="),-1==d?(b.push(""),c.push(e)):(b.push(e.substring(0,d)),c.push(e.substring(d+1)));for(a=b.length-1;0<=a;a--)this.remove(b[a])};
var cd=new bd("undefined"==typeof document?null:document);function dd(a){return!!ad.FPA_SAMESITE_PHASE2_MOD||!(void 0===a||!a)}
function ed(a){a=void 0===a?!1:a;var b=y.__SAPISID||y.__APISID||y.__3PSAPISID||y.__OVERRIDE_SID;dd(a)&&(b=b||y.__1PSAPISID);if(b)return!0;var c=new bd(document);b=c.get("SAPISID")||c.get("APISID")||c.get("__Secure-3PAPISID")||c.get("SID");dd(a)&&(b=b||c.get("__Secure-1PAPISID"));return!!b}
function fd(a,b,c,d){(a=y[a])||(a=(new bd(document)).get(b));return a?Yc(a,c,d):null}
function gd(a){var b=void 0===b?!1:b;var c=Wc(String(y.location.href)),d=[];if(ed(b)){c=0==c.indexOf("https:")||0==c.indexOf("chrome-extension:")||0==c.indexOf("moz-extension:");var e=c?y.__SAPISID:y.__APISID;e||(e=new bd(document),e=e.get(c?"SAPISID":"APISID")||e.get("__Secure-3PAPISID"));(e=e?Yc(e,c?"SAPISIDHASH":"APISIDHASH",a):null)&&d.push(e);c&&dd(b)&&((b=fd("__1PSAPISID","__Secure-1PAPISID","SAPISID1PHASH",a))&&d.push(b),(a=fd("__3PSAPISID","__Secure-3PAPISID","SAPISID3PHASH",a))&&d.push(a))}return 0==
d.length?null:d.join(" ")}
;function hd(){this.data_=[];this.h=-1}
hd.prototype.set=function(a,b){b=void 0===b?!0:b;0<=a&&52>a&&0===a%1&&this.data_[a]!=b&&(this.data_[a]=b,this.h=-1)};
hd.prototype.get=function(a){return!!this.data_[a]};
function id(a){-1==a.h&&(a.h=Za(a.data_,function(b,c,d){return c?b+Math.pow(2,d):b},0));
return a.h}
;function jd(a,b){this.j=a;this.l=b;this.i=0;this.h=null}
jd.prototype.get=function(){if(0<this.i){this.i--;var a=this.h;this.h=a.next;a.next=null}else a=this.j();return a};
function kd(a,b){a.l(b);100>a.i&&(a.i++,b.next=a.h,a.h=b)}
;var ld;
function md(){var a=y.MessageChannel;"undefined"===typeof a&&"undefined"!==typeof window&&window.postMessage&&window.addEventListener&&!F("Presto")&&(a=function(){var e=Jc(document,"IFRAME");e.style.display="none";document.documentElement.appendChild(e);var f=e.contentWindow;e=f.document;e.open();e.close();var g="callImmediate"+Math.random(),h="file:"==f.location.protocol?"*":f.location.protocol+"//"+f.location.host;e=Oa(function(k){if(("*"==h||k.origin==h)&&k.data==g)this.port1.onmessage()},this);
f.addEventListener("message",e,!1);this.port1={};this.port2={postMessage:function(){f.postMessage(g,h)}}});
if("undefined"!==typeof a&&!F("Trident")&&!F("MSIE")){var b=new a,c={},d=c;b.port1.onmessage=function(){if(void 0!==c.next){c=c.next;var e=c.Da;c.Da=null;e()}};
return function(e){d.next={Da:e};d=d.next;b.port2.postMessage(0)}}return function(e){y.setTimeout(e,0)}}
;function nd(a){y.setTimeout(function(){throw a;},0)}
;function od(){this.i=this.h=null}
od.prototype.add=function(a,b){var c=pd.get();c.set(a,b);this.i?this.i.next=c:this.h=c;this.i=c};
od.prototype.remove=function(){var a=null;this.h&&(a=this.h,this.h=this.h.next,this.h||(this.i=null),a.next=null);return a};
var pd=new jd(function(){return new qd},function(a){return a.reset()});
function qd(){this.next=this.scope=this.h=null}
qd.prototype.set=function(a,b){this.h=a;this.scope=b;this.next=null};
qd.prototype.reset=function(){this.next=this.scope=this.h=null};function rd(a,b){sd||td();ud||(sd(),ud=!0);vd.add(a,b)}
var sd;function td(){if(y.Promise&&y.Promise.resolve){var a=y.Promise.resolve(void 0);sd=function(){a.then(wd)}}else sd=function(){var b=wd;
"function"!==typeof y.setImmediate||y.Window&&y.Window.prototype&&!F("Edge")&&y.Window.prototype.setImmediate==y.setImmediate?(ld||(ld=md()),ld(b)):y.setImmediate(b)}}
var ud=!1,vd=new od;function wd(){for(var a;a=vd.remove();){try{a.h.call(a.scope)}catch(b){nd(b)}kd(pd,a)}ud=!1}
;function xd(){this.blockSize=-1}
;function yd(){this.blockSize=-1;this.blockSize=64;this.h=[];this.u=[];this.m=[];this.j=[];this.j[0]=128;for(var a=1;a<this.blockSize;++a)this.j[a]=0;this.l=this.i=0;this.reset()}
B(yd,xd);yd.prototype.reset=function(){this.h[0]=1732584193;this.h[1]=4023233417;this.h[2]=2562383102;this.h[3]=271733878;this.h[4]=3285377520;this.l=this.i=0};
function zd(a,b,c){c||(c=0);var d=a.m;if("string"===typeof b)for(var e=0;16>e;e++)d[e]=b.charCodeAt(c)<<24|b.charCodeAt(c+1)<<16|b.charCodeAt(c+2)<<8|b.charCodeAt(c+3),c+=4;else for(e=0;16>e;e++)d[e]=b[c]<<24|b[c+1]<<16|b[c+2]<<8|b[c+3],c+=4;for(e=16;80>e;e++){var f=d[e-3]^d[e-8]^d[e-14]^d[e-16];d[e]=(f<<1|f>>>31)&4294967295}b=a.h[0];c=a.h[1];var g=a.h[2],h=a.h[3],k=a.h[4];for(e=0;80>e;e++){if(40>e)if(20>e){f=h^c&(g^h);var l=1518500249}else f=c^g^h,l=1859775393;else 60>e?(f=c&g|h&(c|g),l=2400959708):
(f=c^g^h,l=3395469782);f=(b<<5|b>>>27)+f+k+l+d[e]&4294967295;k=h;h=g;g=(c<<30|c>>>2)&4294967295;c=b;b=f}a.h[0]=a.h[0]+b&4294967295;a.h[1]=a.h[1]+c&4294967295;a.h[2]=a.h[2]+g&4294967295;a.h[3]=a.h[3]+h&4294967295;a.h[4]=a.h[4]+k&4294967295}
yd.prototype.update=function(a,b){if(null!=a){void 0===b&&(b=a.length);for(var c=b-this.blockSize,d=0,e=this.u,f=this.i;d<b;){if(0==f)for(;d<=c;)zd(this,a,d),d+=this.blockSize;if("string"===typeof a)for(;d<b;){if(e[f]=a.charCodeAt(d),++f,++d,f==this.blockSize){zd(this,e);f=0;break}}else for(;d<b;)if(e[f]=a[d],++f,++d,f==this.blockSize){zd(this,e);f=0;break}}this.i=f;this.l+=b}};
yd.prototype.digest=function(){var a=[],b=8*this.l;56>this.i?this.update(this.j,56-this.i):this.update(this.j,this.blockSize-(this.i-56));for(var c=this.blockSize-1;56<=c;c--)this.u[c]=b&255,b/=256;zd(this,this.u);for(c=b=0;5>c;c++)for(var d=24;0<=d;d-=8)a[b]=this.h[c]>>d&255,++b;return a};function Ad(a){var b=A("window.location.href");null==a&&(a='Unknown Error of type "null/undefined"');if("string"===typeof a)return{message:a,name:"Unknown error",lineNumber:"Not available",fileName:b,stack:"Not available"};var c=!1;try{var d=a.lineNumber||a.line||"Not available"}catch(g){d="Not available",c=!0}try{var e=a.fileName||a.filename||a.sourceURL||y.$googDebugFname||b}catch(g){e="Not available",c=!0}b=Bd(a);if(!(!c&&a.lineNumber&&a.fileName&&a.stack&&a.message&&a.name)){c=a.message;if(null==
c){if(a.constructor&&a.constructor instanceof Function){if(a.constructor.name)c=a.constructor.name;else if(c=a.constructor,Cd[c])c=Cd[c];else{c=String(c);if(!Cd[c]){var f=/function\s+([^\(]+)/m.exec(c);Cd[c]=f?f[1]:"[Anonymous]"}c=Cd[c]}c='Unknown Error of type "'+c+'"'}else c="Unknown Error of unknown type";"function"===typeof a.toString&&Object.prototype.toString!==a.toString&&(c+=": "+a.toString())}return{message:c,name:a.name||"UnknownError",lineNumber:d,fileName:e,stack:b||"Not available"}}a.stack=
b;return{message:a.message,name:a.name,lineNumber:a.lineNumber,fileName:a.fileName,stack:a.stack}}
function Bd(a,b){b||(b={});b[Dd(a)]=!0;var c=a.stack||"";(a=a.Pa)&&!b[Dd(a)]&&(c+="\nCaused by: ",a.stack&&0==a.stack.indexOf(a.toString())||(c+="string"===typeof a?a:a.message+"\n"),c+=Bd(a,b));return c}
function Dd(a){var b="";"function"===typeof a.toString&&(b=""+a);return b+a.stack}
var Cd={};function Ed(a){a&&"function"==typeof a.dispose&&a.dispose()}
;function Fd(a){for(var b=0,c=arguments.length;b<c;++b){var d=arguments[b];Ha(d)?Fd.apply(null,d):Ed(d)}}
;function J(){this.h=this.h;this.u=this.u}
J.prototype.h=!1;J.prototype.dispose=function(){this.h||(this.h=!0,this.D())};
function Gd(a,b){a.h?b():(a.u||(a.u=[]),a.u.push(b))}
J.prototype.D=function(){if(this.u)for(;this.u.length;)this.u.shift()()};function Hd(a){return"string"==typeof a.className?a.className:a.getAttribute&&a.getAttribute("class")||""}
function Id(a,b){"string"==typeof a.className?a.className=b:a.setAttribute&&a.setAttribute("class",b)}
function Jd(a,b){a.classList?b=a.classList.contains(b):(a=a.classList?a.classList:Hd(a).match(/\S+/g)||[],b=0<=Wa(a,b));return b}
function Kd(){var a=document.body;a.classList?a.classList.remove("inverted-hdpi"):Jd(a,"inverted-hdpi")&&Id(a,Xa(a.classList?a.classList:Hd(a).match(/\S+/g)||[],function(b){return"inverted-hdpi"!=b}).join(" "))}
;var Ld="StopIteration"in y?y.StopIteration:{message:"StopIteration",stack:""};function Md(){}
Md.prototype.next=function(){throw Ld;};
Md.prototype.O=function(){return this};function Nd(a,b){this.i={};this.h=[];this.V=this.j=0;var c=arguments.length;if(1<c){if(c%2)throw Error("Uneven number of arguments");for(var d=0;d<c;d+=2)this.set(arguments[d],arguments[d+1])}else if(a)if(a instanceof Nd)for(c=Od(a),d=0;d<c.length;d++)this.set(c[d],a.get(c[d]));else for(d in a)this.set(d,a[d])}
function Od(a){Pd(a);return a.h.concat()}
m=Nd.prototype;m.equals=function(a,b){if(this===a)return!0;if(this.j!=a.j)return!1;b=b||Qd;Pd(this);for(var c,d=0;c=this.h[d];d++)if(!b(this.get(c),a.get(c)))return!1;return!0};
function Qd(a,b){return a===b}
m.isEmpty=function(){return 0==this.j};
m.clear=function(){this.i={};this.V=this.j=this.h.length=0};
m.remove=function(a){return Object.prototype.hasOwnProperty.call(this.i,a)?(delete this.i[a],this.j--,this.V++,this.h.length>2*this.j&&Pd(this),!0):!1};
function Pd(a){if(a.j!=a.h.length){for(var b=0,c=0;b<a.h.length;){var d=a.h[b];Object.prototype.hasOwnProperty.call(a.i,d)&&(a.h[c++]=d);b++}a.h.length=c}if(a.j!=a.h.length){var e={};for(c=b=0;b<a.h.length;)d=a.h[b],Object.prototype.hasOwnProperty.call(e,d)||(a.h[c++]=d,e[d]=1),b++;a.h.length=c}}
m.get=function(a,b){return Object.prototype.hasOwnProperty.call(this.i,a)?this.i[a]:b};
m.set=function(a,b){Object.prototype.hasOwnProperty.call(this.i,a)||(this.j++,this.h.push(a),this.V++);this.i[a]=b};
m.forEach=function(a,b){for(var c=Od(this),d=0;d<c.length;d++){var e=c[d],f=this.get(e);a.call(b,f,e,this)}};
m.clone=function(){return new Nd(this)};
m.O=function(a){Pd(this);var b=0,c=this.V,d=this,e=new Md;e.next=function(){if(c!=d.V)throw Error("The map has changed since the iterator was created");if(b>=d.h.length)throw Ld;var f=d.h[b++];return a?f:d.i[f]};
return e};var Rd=function(){if(!y.addEventListener||!Object.defineProperty)return!1;var a=!1,b=Object.defineProperty({},"passive",{get:function(){a=!0}});
try{y.addEventListener("test",Ea,b),y.removeEventListener("test",Ea,b)}catch(c){}return a}();function Sd(a,b){this.type=a;this.h=this.target=b;this.defaultPrevented=this.j=!1}
Sd.prototype.stopPropagation=function(){this.j=!0};
Sd.prototype.preventDefault=function(){this.defaultPrevented=!0};function Td(a,b){Sd.call(this,a?a.type:"");this.relatedTarget=this.h=this.target=null;this.button=this.screenY=this.screenX=this.clientY=this.clientX=0;this.key="";this.charCode=this.keyCode=0;this.metaKey=this.shiftKey=this.altKey=this.ctrlKey=!1;this.state=null;this.pointerId=0;this.pointerType="";this.i=null;a&&this.init(a,b)}
B(Td,Sd);var Ud={2:"touch",3:"pen",4:"mouse"};
Td.prototype.init=function(a,b){var c=this.type=a.type,d=a.changedTouches&&a.changedTouches.length?a.changedTouches[0]:null;this.target=a.target||a.srcElement;this.h=b;if(b=a.relatedTarget){if(lc){a:{try{hc(b.nodeName);var e=!0;break a}catch(f){}e=!1}e||(b=null)}}else"mouseover"==c?b=a.fromElement:"mouseout"==c&&(b=a.toElement);this.relatedTarget=b;d?(this.clientX=void 0!==d.clientX?d.clientX:d.pageX,this.clientY=void 0!==d.clientY?d.clientY:d.pageY,this.screenX=d.screenX||0,this.screenY=d.screenY||
0):(this.clientX=void 0!==a.clientX?a.clientX:a.pageX,this.clientY=void 0!==a.clientY?a.clientY:a.pageY,this.screenX=a.screenX||0,this.screenY=a.screenY||0);this.button=a.button;this.keyCode=a.keyCode||0;this.key=a.key||"";this.charCode=a.charCode||("keypress"==c?a.keyCode:0);this.ctrlKey=a.ctrlKey;this.altKey=a.altKey;this.shiftKey=a.shiftKey;this.metaKey=a.metaKey;this.pointerId=a.pointerId||0;this.pointerType="string"===typeof a.pointerType?a.pointerType:Ud[a.pointerType]||"";this.state=a.state;
this.i=a;a.defaultPrevented&&Td.N.preventDefault.call(this)};
Td.prototype.stopPropagation=function(){Td.N.stopPropagation.call(this);this.i.stopPropagation?this.i.stopPropagation():this.i.cancelBubble=!0};
Td.prototype.preventDefault=function(){Td.N.preventDefault.call(this);var a=this.i;a.preventDefault?a.preventDefault():a.returnValue=!1};var Vd="closure_listenable_"+(1E6*Math.random()|0);var Wd=0;function Xd(a,b,c,d,e){this.listener=a;this.h=null;this.src=b;this.type=c;this.capture=!!d;this.la=e;this.key=++Wd;this.ea=this.ha=!1}
function Yd(a){a.ea=!0;a.listener=null;a.h=null;a.src=null;a.la=null}
;function Zd(a){this.src=a;this.listeners={};this.h=0}
Zd.prototype.add=function(a,b,c,d,e){var f=a.toString();a=this.listeners[f];a||(a=this.listeners[f]=[],this.h++);var g=$d(a,b,d,e);-1<g?(b=a[g],c||(b.ha=!1)):(b=new Xd(b,this.src,f,!!d,e),b.ha=c,a.push(b));return b};
Zd.prototype.remove=function(a,b,c,d){a=a.toString();if(!(a in this.listeners))return!1;var e=this.listeners[a];b=$d(e,b,c,d);return-1<b?(Yd(e[b]),Array.prototype.splice.call(e,b,1),0==e.length&&(delete this.listeners[a],this.h--),!0):!1};
function ae(a,b){var c=b.type;c in a.listeners&&ab(a.listeners[c],b)&&(Yd(b),0==a.listeners[c].length&&(delete a.listeners[c],a.h--))}
function $d(a,b,c,d){for(var e=0;e<a.length;++e){var f=a[e];if(!f.ea&&f.listener==b&&f.capture==!!c&&f.la==d)return e}return-1}
;var be="closure_lm_"+(1E6*Math.random()|0),ce={},de=0;function ee(a,b,c,d,e){if(d&&d.once)fe(a,b,c,d,e);else if(Array.isArray(b))for(var f=0;f<b.length;f++)ee(a,b[f],c,d,e);else c=ge(c),a&&a[Vd]?a.ca(b,c,Ia(d)?!!d.capture:!!d,e):he(a,b,c,!1,d,e)}
function he(a,b,c,d,e,f){if(!b)throw Error("Invalid event type");var g=Ia(e)?!!e.capture:!!e,h=ie(a);h||(a[be]=h=new Zd(a));c=h.add(b,c,d,g,f);if(!c.h){d=je();c.h=d;d.src=a;d.listener=c;if(a.addEventListener)Rd||(e=g),void 0===e&&(e=!1),a.addEventListener(b.toString(),d,e);else if(a.attachEvent)a.attachEvent(ke(b.toString()),d);else if(a.addListener&&a.removeListener)a.addListener(d);else throw Error("addEventListener and attachEvent are unavailable.");de++}}
function je(){function a(c){return b.call(a.src,a.listener,c)}
var b=le;return a}
function fe(a,b,c,d,e){if(Array.isArray(b))for(var f=0;f<b.length;f++)fe(a,b[f],c,d,e);else c=ge(c),a&&a[Vd]?a.j.add(String(b),c,!0,Ia(d)?!!d.capture:!!d,e):he(a,b,c,!0,d,e)}
function me(a,b,c,d,e){if(Array.isArray(b))for(var f=0;f<b.length;f++)me(a,b[f],c,d,e);else(d=Ia(d)?!!d.capture:!!d,c=ge(c),a&&a[Vd])?a.j.remove(String(b),c,d,e):a&&(a=ie(a))&&(b=a.listeners[b.toString()],a=-1,b&&(a=$d(b,c,d,e)),(c=-1<a?b[a]:null)&&ne(c))}
function ne(a){if("number"!==typeof a&&a&&!a.ea){var b=a.src;if(b&&b[Vd])ae(b.j,a);else{var c=a.type,d=a.h;b.removeEventListener?b.removeEventListener(c,d,a.capture):b.detachEvent?b.detachEvent(ke(c),d):b.addListener&&b.removeListener&&b.removeListener(d);de--;(c=ie(b))?(ae(c,a),0==c.h&&(c.src=null,b[be]=null)):Yd(a)}}}
function ke(a){return a in ce?ce[a]:ce[a]="on"+a}
function le(a,b){if(a.ea)a=!0;else{b=new Td(b,this);var c=a.listener,d=a.la||a.src;a.ha&&ne(a);a=c.call(d,b)}return a}
function ie(a){a=a[be];return a instanceof Zd?a:null}
var oe="__closure_events_fn_"+(1E9*Math.random()>>>0);function ge(a){if("function"===typeof a)return a;a[oe]||(a[oe]=function(b){return a.handleEvent(b)});
return a[oe]}
;function pe(){J.call(this);this.j=new Zd(this);this.P=this;this.F=null}
B(pe,J);pe.prototype[Vd]=!0;pe.prototype.addEventListener=function(a,b,c,d){ee(this,a,b,c,d)};
pe.prototype.removeEventListener=function(a,b,c,d){me(this,a,b,c,d)};
function qe(a,b){var c=a.F;if(c){var d=[];for(var e=1;c;c=c.F)d.push(c),++e}a=a.P;c=b.type||b;"string"===typeof b?b=new Sd(b,a):b instanceof Sd?b.target=b.target||a:(e=b,b=new Sd(c,a),nb(b,e));e=!0;if(d)for(var f=d.length-1;!b.j&&0<=f;f--){var g=b.h=d[f];e=re(g,c,!0,b)&&e}b.j||(g=b.h=a,e=re(g,c,!0,b)&&e,b.j||(e=re(g,c,!1,b)&&e));if(d)for(f=0;!b.j&&f<d.length;f++)g=b.h=d[f],e=re(g,c,!1,b)&&e}
pe.prototype.D=function(){pe.N.D.call(this);if(this.j){var a=this.j,b=0,c;for(c in a.listeners){for(var d=a.listeners[c],e=0;e<d.length;e++)++b,Yd(d[e]);delete a.listeners[c];a.h--}}this.F=null};
pe.prototype.ca=function(a,b,c,d){return this.j.add(String(a),b,!1,c,d)};
function re(a,b,c,d){b=a.j.listeners[String(b)];if(!b)return!0;b=b.concat();for(var e=!0,f=0;f<b.length;++f){var g=b[f];if(g&&!g.ea&&g.capture==c){var h=g.listener,k=g.la||g.src;g.ha&&ae(a.j,g);e=!1!==h.call(k,d)&&e}}return e&&!d.defaultPrevented}
;function se(a){if(a instanceof te||a instanceof ue||a instanceof ve)return a;if("function"==typeof a.next)return new te(function(){return we(a)});
if("function"==typeof a[Symbol.iterator])return new te(function(){return a[Symbol.iterator]()});
if("function"==typeof a.O)return new te(function(){return we(a.O())});
throw Error("Not an iterator or iterable.");}
function we(a){if(!(a instanceof Md))return a;var b=!1;return{next:function(){for(var c;!b;)try{c=a.next();break}catch(d){if(d!==Ld)throw d;b=!0}return{value:c,done:b}}}}
function te(a){this.h=a}
te.prototype.O=function(){return new ue(this.h())};
te.prototype[Symbol.iterator]=function(){return new ve(this.h())};
te.prototype.i=function(){return new ve(this.h())};
function ue(a){this.h=a}
v(ue,Md);ue.prototype.next=function(){var a=this.h.next();if(a.done)throw Ld;return a.value};
ue.prototype[Symbol.iterator]=function(){return new ve(this.h)};
ue.prototype.i=function(){return new ve(this.h)};
function ve(a){te.call(this,function(){return a});
this.j=a}
v(ve,te);ve.prototype.next=function(){return this.j.next()};function xe(a){var b=[];ye(new ze,a,b);return b.join("")}
function ze(){}
function ye(a,b,c){if(null==b)c.push("null");else{if("object"==typeof b){if(Array.isArray(b)){var d=b;b=d.length;c.push("[");for(var e="",f=0;f<b;f++)c.push(e),ye(a,d[f],c),e=",";c.push("]");return}if(b instanceof String||b instanceof Number||b instanceof Boolean)b=b.valueOf();else{c.push("{");e="";for(d in b)Object.prototype.hasOwnProperty.call(b,d)&&(f=b[d],"function"!=typeof f&&(c.push(e),Ae(d,c),c.push(":"),ye(a,f,c),e=","));c.push("}");return}}switch(typeof b){case "string":Ae(b,c);break;case "number":c.push(isFinite(b)&&
!isNaN(b)?String(b):"null");break;case "boolean":c.push(String(b));break;case "function":c.push("null");break;default:throw Error("Unknown type: "+typeof b);}}}
var Be={'"':'\\"',"\\":"\\\\","/":"\\/","\b":"\\b","\f":"\\f","\n":"\\n","\r":"\\r","\t":"\\t","\x0B":"\\u000b"},Ce=/\uffff/.test("\uffff")?/[\\"\x00-\x1f\x7f-\uffff]/g:/[\\"\x00-\x1f\x7f-\xff]/g;function Ae(a,b){b.push('"',a.replace(Ce,function(c){var d=Be[c];d||(d="\\u"+(c.charCodeAt(0)|65536).toString(16).substr(1),Be[c]=d);return d}),'"')}
;function De(a){if(!a)return!1;try{return!!a.$goog_Thenable}catch(b){return!1}}
;function Ee(a){this.h=0;this.o=void 0;this.l=this.i=this.j=null;this.u=this.m=!1;if(a!=Ea)try{var b=this;a.call(void 0,function(c){Fe(b,2,c)},function(c){Fe(b,3,c)})}catch(c){Fe(this,3,c)}}
function Ge(){this.next=this.context=this.onRejected=this.i=this.h=null;this.j=!1}
Ge.prototype.reset=function(){this.context=this.onRejected=this.i=this.h=null;this.j=!1};
var He=new jd(function(){return new Ge},function(a){a.reset()});
function Ie(a,b,c){var d=He.get();d.i=a;d.onRejected=b;d.context=c;return d}
function Je(a){return new Ee(function(b,c){c(a)})}
Ee.prototype.then=function(a,b,c){return Ke(this,"function"===typeof a?a:null,"function"===typeof b?b:null,c)};
Ee.prototype.$goog_Thenable=!0;function Le(a,b){return Ke(a,null,b,void 0)}
Ee.prototype.cancel=function(a){if(0==this.h){var b=new Me(a);rd(function(){Ne(this,b)},this)}};
function Ne(a,b){if(0==a.h)if(a.j){var c=a.j;if(c.i){for(var d=0,e=null,f=null,g=c.i;g&&(g.j||(d++,g.h==a&&(e=g),!(e&&1<d)));g=g.next)e||(f=g);e&&(0==c.h&&1==d?Ne(c,b):(f?(d=f,d.next==c.l&&(c.l=d),d.next=d.next.next):Oe(c),Pe(c,e,3,b)))}a.j=null}else Fe(a,3,b)}
function Qe(a,b){a.i||2!=a.h&&3!=a.h||Re(a);a.l?a.l.next=b:a.i=b;a.l=b}
function Ke(a,b,c,d){var e=Ie(null,null,null);e.h=new Ee(function(f,g){e.i=b?function(h){try{var k=b.call(d,h);f(k)}catch(l){g(l)}}:f;
e.onRejected=c?function(h){try{var k=c.call(d,h);void 0===k&&h instanceof Me?g(h):f(k)}catch(l){g(l)}}:g});
e.h.j=a;Qe(a,e);return e.h}
Ee.prototype.C=function(a){this.h=0;Fe(this,2,a)};
Ee.prototype.F=function(a){this.h=0;Fe(this,3,a)};
function Fe(a,b,c){if(0==a.h){a===c&&(b=3,c=new TypeError("Promise cannot resolve to itself"));a.h=1;a:{var d=c,e=a.C,f=a.F;if(d instanceof Ee){Qe(d,Ie(e||Ea,f||null,a));var g=!0}else if(De(d))d.then(e,f,a),g=!0;else{if(Ia(d))try{var h=d.then;if("function"===typeof h){Se(d,h,e,f,a);g=!0;break a}}catch(k){f.call(a,k);g=!0;break a}g=!1}}g||(a.o=c,a.h=b,a.j=null,Re(a),3!=b||c instanceof Me||Te(a,c))}}
function Se(a,b,c,d,e){function f(k){h||(h=!0,d.call(e,k))}
function g(k){h||(h=!0,c.call(e,k))}
var h=!1;try{b.call(a,g,f)}catch(k){f(k)}}
function Re(a){a.m||(a.m=!0,rd(a.B,a))}
function Oe(a){var b=null;a.i&&(b=a.i,a.i=b.next,b.next=null);a.i||(a.l=null);return b}
Ee.prototype.B=function(){for(var a;a=Oe(this);)Pe(this,a,this.h,this.o);this.m=!1};
function Pe(a,b,c,d){if(3==c&&b.onRejected&&!b.j)for(;a&&a.u;a=a.j)a.u=!1;if(b.h)b.h.j=null,Ue(b,c,d);else try{b.j?b.i.call(b.context):Ue(b,c,d)}catch(e){Ve.call(null,e)}kd(He,b)}
function Ue(a,b,c){2==b?a.i.call(a.context,c):a.onRejected&&a.onRejected.call(a.context,c)}
function Te(a,b){a.u=!0;rd(function(){a.u&&Ve.call(null,b)})}
var Ve=nd;function Me(a){Sa.call(this,a)}
B(Me,Sa);Me.prototype.name="cancel";function L(a){J.call(this);this.o=1;this.l=[];this.m=0;this.i=[];this.j={};this.B=!!a}
B(L,J);m=L.prototype;m.subscribe=function(a,b,c){var d=this.j[a];d||(d=this.j[a]=[]);var e=this.o;this.i[e]=a;this.i[e+1]=b;this.i[e+2]=c;this.o=e+3;d.push(e);return e};
function We(a,b,c,d){if(b=a.j[b]){var e=a.i;(b=$a(b,function(f){return e[f+1]==c&&e[f+2]==d}))&&a.da(b)}}
m.da=function(a){var b=this.i[a];if(b){var c=this.j[b];0!=this.m?(this.l.push(a),this.i[a+1]=Ea):(c&&ab(c,a),delete this.i[a],delete this.i[a+1],delete this.i[a+2])}return!!b};
m.W=function(a,b){var c=this.j[a];if(c){for(var d=Array(arguments.length-1),e=1,f=arguments.length;e<f;e++)d[e-1]=arguments[e];if(this.B)for(e=0;e<c.length;e++){var g=c[e];Xe(this.i[g+1],this.i[g+2],d)}else{this.m++;try{for(e=0,f=c.length;e<f;e++)g=c[e],this.i[g+1].apply(this.i[g+2],d)}finally{if(this.m--,0<this.l.length&&0==this.m)for(;c=this.l.pop();)this.da(c)}}return 0!=e}return!1};
function Xe(a,b,c){rd(function(){a.apply(b,c)})}
m.clear=function(a){if(a){var b=this.j[a];b&&(C(b,this.da,this),delete this.j[a])}else this.i.length=0,this.j={}};
m.D=function(){L.N.D.call(this);this.clear();this.l.length=0};function Ye(a){this.h=a}
Ye.prototype.set=function(a,b){void 0===b?this.h.remove(a):this.h.set(a,xe(b))};
Ye.prototype.get=function(a){try{var b=this.h.get(a)}catch(c){return}if(null!==b)try{return JSON.parse(b)}catch(c){throw"Storage: Invalid value was encountered";}};
Ye.prototype.remove=function(a){this.h.remove(a)};function Ze(a){this.h=a}
B(Ze,Ye);function $e(a){this.data=a}
function af(a){return void 0===a||a instanceof $e?a:new $e(a)}
Ze.prototype.set=function(a,b){Ze.N.set.call(this,a,af(b))};
Ze.prototype.i=function(a){a=Ze.N.get.call(this,a);if(void 0===a||a instanceof Object)return a;throw"Storage: Invalid value was encountered";};
Ze.prototype.get=function(a){if(a=this.i(a)){if(a=a.data,void 0===a)throw"Storage: Invalid value was encountered";}else a=void 0;return a};function bf(a){this.h=a}
B(bf,Ze);bf.prototype.set=function(a,b,c){if(b=af(b)){if(c){if(c<Date.now()){bf.prototype.remove.call(this,a);return}b.expiration=c}b.creation=Date.now()}bf.N.set.call(this,a,b)};
bf.prototype.i=function(a){var b=bf.N.i.call(this,a);if(b){var c=b.creation,d=b.expiration;if(d&&d<Date.now()||c&&c>Date.now())bf.prototype.remove.call(this,a);else return b}};function cf(){}
;function df(){}
B(df,cf);df.prototype[Symbol.iterator]=function(){return se(this.O(!0)).i()};
df.prototype.clear=function(){var a=Array.from(this);a=u(a);for(var b=a.next();!b.done;b=a.next())this.remove(b.value)};function ef(a){this.h=a}
B(ef,df);m=ef.prototype;m.isAvailable=function(){if(!this.h)return!1;try{return this.h.setItem("__sak","1"),this.h.removeItem("__sak"),!0}catch(a){return!1}};
m.set=function(a,b){try{this.h.setItem(a,b)}catch(c){if(0==this.h.length)throw"Storage mechanism: Storage disabled";throw"Storage mechanism: Quota exceeded";}};
m.get=function(a){a=this.h.getItem(a);if("string"!==typeof a&&null!==a)throw"Storage mechanism: Invalid value was encountered";return a};
m.remove=function(a){this.h.removeItem(a)};
m.O=function(a){var b=0,c=this.h,d=new Md;d.next=function(){if(b>=c.length)throw Ld;var e=c.key(b++);if(a)return e;e=c.getItem(e);if("string"!==typeof e)throw"Storage mechanism: Invalid value was encountered";return e};
return d};
m.clear=function(){this.h.clear()};
m.key=function(a){return this.h.key(a)};function ff(){var a=null;try{a=window.localStorage||null}catch(b){}this.h=a}
B(ff,ef);function gf(a,b){this.i=a;this.h=null;if(jc&&!(9<=Number(vc))){hf||(hf=new Nd);this.h=hf.get(a);this.h||(b?this.h=document.getElementById(b):(this.h=document.createElement("userdata"),this.h.addBehavior("#default#userData"),document.body.appendChild(this.h)),hf.set(a,this.h));try{this.h.load(this.i)}catch(c){this.h=null}}}
B(gf,df);var jf={".":".2E","!":".21","~":".7E","*":".2A","'":".27","(":".28",")":".29","%":"."},hf=null;function kf(a){return"_"+encodeURIComponent(a).replace(/[.!~*'()%]/g,function(b){return jf[b]})}
m=gf.prototype;m.isAvailable=function(){return!!this.h};
m.set=function(a,b){this.h.setAttribute(kf(a),b);lf(this)};
m.get=function(a){a=this.h.getAttribute(kf(a));if("string"!==typeof a&&null!==a)throw"Storage mechanism: Invalid value was encountered";return a};
m.remove=function(a){this.h.removeAttribute(kf(a));lf(this)};
m.O=function(a){var b=0,c=this.h.XMLDocument.documentElement.attributes,d=new Md;d.next=function(){if(b>=c.length)throw Ld;var e=c[b++];if(a)return decodeURIComponent(e.nodeName.replace(/\./g,"%")).substr(1);e=e.nodeValue;if("string"!==typeof e)throw"Storage mechanism: Invalid value was encountered";return e};
return d};
m.clear=function(){for(var a=this.h.XMLDocument.documentElement,b=a.attributes.length;0<b;b--)a.removeAttribute(a.attributes[b-1].nodeName);lf(this)};
function lf(a){try{a.h.save(a.i)}catch(b){throw"Storage mechanism: Quota exceeded";}}
;function mf(a,b){this.i=a;this.h=b+"::"}
B(mf,df);mf.prototype.set=function(a,b){this.i.set(this.h+a,b)};
mf.prototype.get=function(a){return this.i.get(this.h+a)};
mf.prototype.remove=function(a){this.i.remove(this.h+a)};
mf.prototype.O=function(a){var b=this.i.O(!0),c=this,d=new Md;d.next=function(){for(var e=b.next();e.substr(0,c.h.length)!=c.h;)e=b.next();return a?e.substr(c.h.length):c.i.get(e)};
return d};function nf(a,b){1<b.length?a[b[0]]=b[1]:1===b.length&&Object.assign(a,b[0])}
;var of,pf,qf=y.window,rf=(null===(of=null===qf||void 0===qf?void 0:qf.yt)||void 0===of?void 0:of.config_)||(null===(pf=null===qf||void 0===qf?void 0:qf.ytcfg)||void 0===pf?void 0:pf.data_)||{};z("yt.config_",rf,void 0);function M(a){for(var b=0;b<arguments.length;++b);nf(rf,arguments)}
function E(a,b){return a in rf?rf[a]:b}
;var sf=[];function tf(a){sf.forEach(function(b){return b(a)})}
function uf(a){return a&&window.yterr?function(){try{return a.apply(this,arguments)}catch(b){vf(b)}}:a}
function vf(a){var b=A("yt.logging.errors.log");b?b(a,"ERROR",void 0,void 0,void 0):(b=E("ERRORS",[]),b.push([a,"ERROR",void 0,void 0,void 0]),M("ERRORS",b));tf(a)}
function wf(a){var b=A("yt.logging.errors.log");b?b(a,"WARNING",void 0,void 0,void 0):(b=E("ERRORS",[]),b.push([a,"WARNING",void 0,void 0,void 0]),M("ERRORS",b))}
;var xf=window.yt&&window.yt.msgs_||window.ytcfg&&window.ytcfg.msgs||{};z("yt.msgs_",xf,void 0);function yf(a){nf(xf,arguments)}
;function O(a){a=zf(a);return"string"===typeof a&&"false"===a?!1:!!a}
function Af(a,b){a=zf(a);return void 0===a&&void 0!==b?b:Number(a||0)}
function zf(a){var b=E("EXPERIMENTS_FORCED_FLAGS",{});return void 0!==b[a]?b[a]:E("EXPERIMENT_FLAGS",{})[a]}
;var Bf=0,Cf=mc?"webkit":lc?"moz":jc?"ms":ic?"o":"";z("ytDomDomGetNextId",A("ytDomDomGetNextId")||function(){return++Bf},void 0);var Df={stopImmediatePropagation:1,stopPropagation:1,preventMouseEvent:1,preventManipulation:1,preventDefault:1,layerX:1,layerY:1,screenX:1,screenY:1,scale:1,rotation:1,webkitMovementX:1,webkitMovementY:1};
function Ef(a){this.type="";this.state=this.source=this.data=this.currentTarget=this.relatedTarget=this.target=null;this.charCode=this.keyCode=0;this.metaKey=this.shiftKey=this.ctrlKey=this.altKey=!1;this.rotation=this.clientY=this.clientX=0;this.changedTouches=this.touches=null;try{if(a=a||window.event){this.event=a;for(var b in a)b in Df||(this[b]=a[b]);this.rotation=a.rotation;var c=a.target||a.srcElement;c&&3==c.nodeType&&(c=c.parentNode);this.target=c;var d=a.relatedTarget;if(d)try{d=d.nodeName?
d:null}catch(e){d=null}else"mouseover"==this.type?d=a.fromElement:"mouseout"==this.type&&(d=a.toElement);this.relatedTarget=d;this.clientX=void 0!=a.clientX?a.clientX:a.pageX;this.clientY=void 0!=a.clientY?a.clientY:a.pageY;this.keyCode=a.keyCode?a.keyCode:a.which;this.charCode=a.charCode||("keypress"==this.type?this.keyCode:0);this.altKey=a.altKey;this.ctrlKey=a.ctrlKey;this.shiftKey=a.shiftKey;this.metaKey=a.metaKey;this.h=a.pageX;this.i=a.pageY}}catch(e){}}
function Ff(a){if(document.body&&document.documentElement){var b=document.body.scrollTop+document.documentElement.scrollTop;a.h=a.clientX+(document.body.scrollLeft+document.documentElement.scrollLeft);a.i=a.clientY+b}}
Ef.prototype.preventDefault=function(){this.event&&(this.event.returnValue=!1,this.event.preventDefault&&this.event.preventDefault())};
Ef.prototype.stopPropagation=function(){this.event&&(this.event.cancelBubble=!0,this.event.stopPropagation&&this.event.stopPropagation())};
Ef.prototype.stopImmediatePropagation=function(){this.event&&(this.event.cancelBubble=!0,this.event.stopImmediatePropagation&&this.event.stopImmediatePropagation())};var fb=y.ytEventsEventsListeners||{};z("ytEventsEventsListeners",fb,void 0);var Gf=y.ytEventsEventsCounter||{count:0};z("ytEventsEventsCounter",Gf,void 0);
function Hf(a,b,c,d){d=void 0===d?{}:d;a.addEventListener&&("mouseenter"!=b||"onmouseenter"in document?"mouseleave"!=b||"onmouseenter"in document?"mousewheel"==b&&"MozBoxSizing"in document.documentElement.style&&(b="MozMousePixelScroll"):b="mouseout":b="mouseover");return eb(function(e){var f="boolean"===typeof e[4]&&e[4]==!!d,g=Ia(e[4])&&Ia(d)&&jb(e[4],d);return!!e.length&&e[0]==a&&e[1]==b&&e[2]==c&&(f||g)})}
var If=Va(function(){var a=!1;try{var b=Object.defineProperty({},"capture",{get:function(){a=!0}});
window.addEventListener("test",null,b)}catch(c){}return a});
function Jf(a,b,c,d){d=void 0===d?{}:d;if(!a||!a.addEventListener&&!a.attachEvent)return"";var e=Hf(a,b,c,d);if(e)return e;e=++Gf.count+"";var f=!("mouseenter"!=b&&"mouseleave"!=b||!a.addEventListener||"onmouseenter"in document);var g=f?function(h){h=new Ef(h);if(!Lc(h.relatedTarget,function(k){return k==a}))return h.currentTarget=a,h.type=b,c.call(a,h)}:function(h){h=new Ef(h);
h.currentTarget=a;return c.call(a,h)};
g=uf(g);a.addEventListener?("mouseenter"==b&&f?b="mouseover":"mouseleave"==b&&f?b="mouseout":"mousewheel"==b&&"MozBoxSizing"in document.documentElement.style&&(b="MozMousePixelScroll"),If()||"boolean"===typeof d?a.addEventListener(b,g,d):a.addEventListener(b,g,!!d.capture)):a.attachEvent("on"+b,g);fb[e]=[a,b,c,g,d];return e}
function Kf(a){a&&("string"==typeof a&&(a=[a]),C(a,function(b){if(b in fb){var c=fb[b],d=c[0],e=c[1],f=c[3];c=c[4];d.removeEventListener?If()||"boolean"===typeof c?d.removeEventListener(e,f,c):d.removeEventListener(e,f,!!c.capture):d.detachEvent&&d.detachEvent("on"+e,f);delete fb[b]}}))}
;var Lf=window.ytcsi&&window.ytcsi.now?window.ytcsi.now:window.performance&&window.performance.timing&&window.performance.now&&window.performance.timing.navigationStart?function(){return window.performance.timing.navigationStart+window.performance.now()}:function(){return(new Date).getTime()};function Mf(a,b){"function"===typeof a&&(a=uf(a));return window.setTimeout(a,b)}
function Nf(a){window.clearTimeout(a)}
;function Of(a){this.C=a;this.i=null;this.m=0;this.B=null;this.o=0;this.j=[];for(a=0;4>a;a++)this.j.push(0);this.l=0;this.J=Jf(window,"mousemove",Oa(this.K,this));a=Oa(this.F,this);"function"===typeof a&&(a=uf(a));this.L=window.setInterval(a,25)}
B(Of,J);Of.prototype.K=function(a){void 0===a.h&&Ff(a);var b=a.h;void 0===a.i&&Ff(a);this.i=new Dc(b,a.i)};
Of.prototype.F=function(){if(this.i){var a=Lf();if(0!=this.m){var b=this.B,c=this.i,d=b.x-c.x;b=b.y-c.y;d=Math.sqrt(d*d+b*b)/(a-this.m);this.j[this.l]=.5<Math.abs((d-this.o)/this.o)?1:0;for(c=b=0;4>c;c++)b+=this.j[c]||0;3<=b&&this.C();this.o=d}this.m=a;this.B=this.i;this.l=(this.l+1)%4}};
Of.prototype.D=function(){window.clearInterval(this.L);Kf(this.J)};function Pf(){}
function Qf(a,b){return Rf(a,0,b)}
function Sf(a,b){return Rf(a,1,b)}
;function Tf(){Pf.apply(this,arguments)}
v(Tf,Pf);function Rf(a,b,c){void 0!==c&&Number.isNaN(Number(c))&&(c=void 0);var d=A("yt.scheduler.instance.addJob");return d?d(a,b,c):void 0===c?(a(),NaN):Mf(a,c||0)}
function Uf(a){if(void 0===a||!Number.isNaN(Number(a))){var b=A("yt.scheduler.instance.cancelJob");b?b(a):Nf(a)}}
Tf.prototype.start=function(){var a=A("yt.scheduler.instance.start");a&&a()};
Tf.prototype.pause=function(){var a=A("yt.scheduler.instance.pause");a&&a()};Tf.h||(Tf.h=new Tf);var Vf={};
function Wf(a){var b=void 0===a?{}:a;a=void 0===b.Va?!0:b.Va;b=void 0===b.jb?!1:b.jb;if(null==A("_lact",window)){var c=parseInt(E("LACT"),10);c=isFinite(c)?Date.now()-Math.max(c,0):-1;z("_lact",c,window);z("_fact",c,window);-1==c&&Xf();Jf(document,"keydown",Xf);Jf(document,"keyup",Xf);Jf(document,"mousedown",Xf);Jf(document,"mouseup",Xf);a&&(b?Jf(window,"touchmove",function(){Yf("touchmove",200)},{passive:!0}):(Jf(window,"resize",function(){Yf("resize",200)}),Jf(window,"scroll",function(){Yf("scroll",200)})));
new Of(function(){Yf("mouse",100)});
Jf(document,"touchstart",Xf,{passive:!0});Jf(document,"touchend",Xf,{passive:!0})}}
function Yf(a,b){Vf[a]||(Vf[a]=!0,Sf(function(){Xf();Vf[a]=!1},b))}
function Xf(){null==A("_lact",window)&&Wf();var a=Date.now();z("_lact",a,window);-1==A("_fact",window)&&z("_fact",a,window);(a=A("ytglobal.ytUtilActivityCallback_"))&&a()}
function Zf(){var a=A("_lact",window);return null==a?-1:Math.max(Date.now()-a,0)}
;function $f(){var a=ag;A("yt.ads.biscotti.getId_")||z("yt.ads.biscotti.getId_",a,void 0)}
function bg(a){z("yt.ads.biscotti.lastId_",a,void 0)}
;var cg=/^[\w.]*$/,dg={q:!0,search_query:!0};function eg(a,b){b=a.split(b);for(var c={},d=0,e=b.length;d<e;d++){var f=b[d].split("=");if(1==f.length&&f[0]||2==f.length)try{var g=fg(f[0]||""),h=fg(f[1]||"");g in c?Array.isArray(c[g])?cb(c[g],h):c[g]=[c[g],h]:c[g]=h}catch(n){var k=n,l=f[0],p=String(eg);k.args=[{key:l,value:f[1],query:a,method:gg==p?"unchanged":p}];dg.hasOwnProperty(l)||wf(k)}}return c}
var gg=String(eg);function hg(a){var b=[];db(a,function(c,d){var e=encodeURIComponent(String(d)),f;Array.isArray(c)?f=c:f=[c];C(f,function(g){""==g?b.push(e):b.push(e+"="+encodeURIComponent(String(g)))})});
return b.join("&")}
function ig(a){"?"==a.charAt(0)&&(a=a.substr(1));return eg(a,"&")}
function jg(){var a=window.location.href;return-1!=a.indexOf("?")?(a=(a||"").split("#")[0],a=a.split("?",2),ig(1<a.length?a[1]:a[0])):{}}
function kg(a,b,c){var d=a.split("#",2);a=d[0];d=1<d.length?"#"+d[1]:"";var e=a.split("?",2);a=e[0];e=ig(e[1]||"");for(var f in b)!c&&null!==e&&f in e||(e[f]=b[f]);return ec(a,e)+d}
function lg(a){if(!b)var b=window.location.href;var c=a.match($b)[1]||null,d=bc(a);c&&d?(a=a.match($b),b=b.match($b),a=a[3]==b[3]&&a[1]==b[1]&&a[4]==b[4]):a=d?bc(b)==d&&(Number(b.match($b)[4]||null)||null)==(Number(a.match($b)[4]||null)||null):!0;return a}
function fg(a){return a&&a.match(cg)?a:decodeURIComponent(a.replace(/\+/g," "))}
;function mg(a){var b=ng;a=void 0===a?A("yt.ads.biscotti.lastId_")||"":a;var c=Object,d=c.assign,e={};e.dt=Vc;e.flash="0";a:{try{var f=b.h.top.location.href}catch(Ua){f=2;break a}f=f?f===b.i.location.href?0:1:2}e=(e.frm=f,e);e.u_tz=-(new Date).getTimezoneOffset();var g=void 0===g?H:g;try{var h=g.history.length}catch(Ua){h=0}e.u_his=h;e.u_java=!!H.navigator&&"unknown"!==typeof H.navigator.javaEnabled&&!!H.navigator.javaEnabled&&H.navigator.javaEnabled();H.screen&&(e.u_h=H.screen.height,e.u_w=H.screen.width,
e.u_ah=H.screen.availHeight,e.u_aw=H.screen.availWidth,e.u_cd=H.screen.colorDepth);H.navigator&&H.navigator.plugins&&(e.u_nplug=H.navigator.plugins.length);H.navigator&&H.navigator.mimeTypes&&(e.u_nmime=H.navigator.mimeTypes.length);h=b.h;try{var k=h.screenX;var l=h.screenY}catch(Ua){}try{var p=h.outerWidth;var n=h.outerHeight}catch(Ua){}try{var t=h.innerWidth;var q=h.innerHeight}catch(Ua){}try{var D=h.screenLeft;var K=h.screenTop}catch(Ua){}try{t=h.innerWidth,q=h.innerHeight}catch(Ua){}try{var N=
h.screen.availWidth;var X=h.screen.availTop}catch(Ua){}k=[D,K,k,l,N,X,p,n,t,q];l=b.h.top;try{var Y=(l||window).document,I="CSS1Compat"==Y.compatMode?Y.documentElement:Y.body;var T=(new Ec(I.clientWidth,I.clientHeight)).round()}catch(Ua){T=new Ec(-12245933,-12245933)}Y=T;T={};I=new hd;y.SVGElement&&y.document.createElementNS&&I.set(0);l=Qc();l["allow-top-navigation-by-user-activation"]&&I.set(1);l["allow-popups-to-escape-sandbox"]&&I.set(2);y.crypto&&y.crypto.subtle&&I.set(3);y.TextDecoder&&y.TextEncoder&&
I.set(4);I=id(I);T.bc=I;T.bih=Y.height;T.biw=Y.width;T.brdim=k.join();b=b.i;b=(T.vis={visible:1,hidden:2,prerender:3,preview:4,unloaded:5}[b.visibilityState||b.webkitVisibilityState||b.mozVisibilityState||""]||0,T.wgl=!!H.WebGLRenderingContext,T);c=d.call(c,e,b);c.ca_type="image";a&&(c.bid=a);return c}
var ng=new function(){var a=window.document;this.h=window;this.i=a};
z("yt.ads_.signals_.getAdSignalsString",function(a){return hg(mg(a))},void 0);var og="XMLHttpRequest"in y?function(){return new XMLHttpRequest}:null;
function pg(){if(!og)return null;var a=og();return"open"in a?a:null}
function qg(a){switch(a&&"status"in a?a.status:-1){case 200:case 201:case 202:case 203:case 204:case 205:case 206:case 304:return!0;default:return!1}}
;var rg={Authorization:"AUTHORIZATION","X-Goog-Visitor-Id":"SANDBOXED_VISITOR_ID","X-Youtube-Chrome-Connected":"CHROME_CONNECTED_HEADER","X-YouTube-Client-Name":"INNERTUBE_CONTEXT_CLIENT_NAME","X-YouTube-Client-Version":"INNERTUBE_CONTEXT_CLIENT_VERSION","X-YouTube-Delegation-Context":"INNERTUBE_CONTEXT_SERIALIZED_DELEGATION_CONTEXT","X-YouTube-Device":"DEVICE","X-Youtube-Identity-Token":"ID_TOKEN","X-YouTube-Page-CL":"PAGE_CL","X-YouTube-Page-Label":"PAGE_BUILD_LABEL","X-YouTube-Variants-Checksum":"VARIANTS_CHECKSUM"},
sg="app debugcss debugjs expflag force_ad_params force_ad_encrypted force_viral_ad_response_params forced_experiments innertube_snapshots innertube_goldens internalcountrycode internalipoverride absolute_experiments conditional_experiments sbb sr_bns_address client_dev_root_url".split(" "),tg=!1;
function ug(a,b){b=void 0===b?{}:b;var c=lg(a),d=O("web_ajax_ignore_global_headers_if_set"),e;for(e in rg){var f=E(rg[e]);!f||!c&&bc(a)||d&&void 0!==b[e]||(b[e]=f)}if(c||!bc(a))b["X-YouTube-Utc-Offset"]=String(-(new Date).getTimezoneOffset());if(c||!bc(a)){try{var g=(new Intl.DateTimeFormat).resolvedOptions().timeZone}catch(h){}g&&(b["X-YouTube-Time-Zone"]=g)}if(c||!bc(a))b["X-YouTube-Ad-Signals"]=hg(mg(void 0));return b}
function vg(a){var b=window.location.search,c=bc(a);O("debug_handle_relative_url_for_query_forward_killswitch")||c||!lg(a)||(c=document.location.hostname);var d=ac(a.match($b)[5]||null);d=(c=c&&(c.endsWith("youtube.com")||c.endsWith("youtube-nocookie.com")))&&d&&d.startsWith("/api/");if(!c||d)return a;var e=ig(b),f={};C(sg,function(g){e[g]&&(f[g]=e[g])});
return kg(a,f||{},!1)}
function wg(a,b){var c=b.format||"JSON";a=xg(a,b);var d=yg(a,b),e=!1,f=zg(a,function(k){if(!e){e=!0;h&&Nf(h);var l=qg(k),p=null,n=400<=k.status&&500>k.status,t=500<=k.status&&600>k.status;if(l||n||t)p=Ag(a,c,k,b.convertToSafeHtml);if(l)a:if(k&&204==k.status)l=!0;else{switch(c){case "XML":l=0==parseInt(p&&p.return_code,10);break a;case "RAW":l=!0;break a}l=!!p}p=p||{};n=b.context||y;l?b.onSuccess&&b.onSuccess.call(n,k,p):b.onError&&b.onError.call(n,k,p);b.onFinish&&b.onFinish.call(n,k,p)}},b.method,
d,b.headers,b.responseType,b.withCredentials);
if(b.onTimeout&&0<b.timeout){var g=b.onTimeout;var h=Mf(function(){e||(e=!0,f.abort(),Nf(h),g.call(b.context||y,f))},b.timeout)}return f}
function xg(a,b){b.includeDomain&&(a=document.location.protocol+"//"+document.location.hostname+(document.location.port?":"+document.location.port:"")+a);var c=E("XSRF_FIELD_NAME",void 0);if(b=b.urlParams)b[c]&&delete b[c],a=kg(a,b||{},!0);return a}
function yg(a,b){var c=E("XSRF_FIELD_NAME",void 0),d=E("XSRF_TOKEN",void 0),e=b.postBody||"",f=b.postParams,g=E("XSRF_FIELD_NAME",void 0),h;b.headers&&(h=b.headers["Content-Type"]);b.excludeXsrf||bc(a)&&!b.withCredentials&&bc(a)!=document.location.hostname||"POST"!=b.method||h&&"application/x-www-form-urlencoded"!=h||b.postParams&&b.postParams[g]||(f||(f={}),f[c]=d);f&&"string"===typeof e&&(e=ig(e),nb(e,f),e=b.postBodyFormat&&"JSON"==b.postBodyFormat?JSON.stringify(e):dc(e));f=e||f&&!gb(f);!tg&&f&&
"POST"!=b.method&&(tg=!0,vf(Error("AJAX request with postData should use POST")));return e}
function Ag(a,b,c,d){var e=null;switch(b){case "JSON":try{var f=c.responseText}catch(g){throw d=Error("Error reading responseText"),d.params=a,wf(d),g;}a=c.getResponseHeader("Content-Type")||"";f&&0<=a.indexOf("json")&&(")]}'\n"===f.substring(0,5)&&(f=f.substring(5)),e=JSON.parse(f));break;case "XML":if(a=(a=c.responseXML)?Bg(a):null)e={},C(a.getElementsByTagName("*"),function(g){e[g.tagName]=Cg(g)})}d&&Dg(e);
return e}
function Dg(a){if(Ia(a))for(var b in a){var c;(c="html_content"==b)||(c=b.length-5,c=0<=c&&b.indexOf("_html",c)==c);if(c){c=b;var d=Sb(a[b],null);a[c]=d}else Dg(a[b])}}
function Bg(a){return a?(a=("responseXML"in a?a.responseXML:a).getElementsByTagName("root"))&&0<a.length?a[0]:null:null}
function Cg(a){var b="";C(a.childNodes,function(c){b+=c.nodeValue});
return b}
function zg(a,b,c,d,e,f,g){function h(){4==(k&&"readyState"in k?k.readyState:0)&&b&&uf(b)(k)}
c=void 0===c?"GET":c;d=void 0===d?"":d;var k=pg();if(!k)return null;"onloadend"in k?k.addEventListener("loadend",h,!1):k.onreadystatechange=h;O("debug_forward_web_query_parameters")&&(a=vg(a));k.open(c,a,!0);f&&(k.responseType=f);g&&(k.withCredentials=!0);c="POST"==c&&(void 0===window.FormData||!(d instanceof FormData));if(e=ug(a,e))for(var l in e)k.setRequestHeader(l,e[l]),"content-type"==l.toLowerCase()&&(c=!1);c&&k.setRequestHeader("Content-Type","application/x-www-form-urlencoded");k.send(d);
return k}
;var Eg=wc||xc;function Fg(a){var b=Nb;return b?0<=b.toLowerCase().indexOf(a):!1}
;var Gg={},Hg=0;
function Ig(a,b,c,d,e){e=void 0===e?"":e;if(a)if(c&&!Fg("cobalt")){if(a){a instanceof Fb||(a="object"==typeof a&&a.Y?a.X():String(a),Kb.test(a)?a=new Fb(a,Gb):(a=String(a),a=a.replace(/(%0A|%0D)/g,""),a=(b=a.match(Jb))&&Ib.test(b[1])?new Fb(a,Gb):null));a=Hb(a||Mb);if("about:invalid#zClosurez"===a||a.startsWith("data"))a="";else{if(!(a instanceof Qb)){b="object"==typeof a;var f=null;b&&a.ta&&(f=a.qa());a=Sb(xb(b&&a.Y?a.X():String(a)),f)}a instanceof Qb&&a.constructor===Qb?a=a.h:(Ga(a),a="type_error:SafeHtml");
a=encodeURIComponent(String(xe(a.toString())))}/^[\s\xa0]*$/.test(a)||(a=Ic("IFRAME",{src:'javascript:"<body><img src=\\""+'+a+'+"\\"></body>"',style:"display:none"}),(9==a.nodeType?a:a.ownerDocument||a.document).body.appendChild(a))}}else if(e)zg(a,b,"POST",e,d);else if(E("USE_NET_AJAX_FOR_PING_TRANSPORT",!1)||d)zg(a,b,"GET","",d);else{b:{try{var g=new Ta({url:a});if(g.j&&g.i||g.l){var h=ac(a.match($b)[5]||null),k;if(!(k=!h||!h.endsWith("/aclk"))){var l=a.search(fc);d:{for(c=0;0<=(c=a.indexOf("ri",
c))&&c<l;){var p=a.charCodeAt(c-1);if(38==p||63==p){var n=a.charCodeAt(c+2);if(!n||61==n||38==n||35==n){var t=c;break d}}c+=3}t=-1}if(0>t)var q=null;else{var D=a.indexOf("&",t);if(0>D||D>l)D=l;t+=3;q=decodeURIComponent(a.substr(t,D-t).replace(/\+/g," "))}k="1"!==q}f=!k;break b}}catch(K){}f=!1}f?Jg(a)?(b&&b(),f=!0):f=!1:f=!1;f||Kg(a,b)}}
function Lg(a,b,c){c=void 0===c?"":c;Jg(a,c)?b&&b():Ig(a,b,void 0,void 0,c)}
function Jg(a,b){try{if(window.navigator&&window.navigator.sendBeacon&&window.navigator.sendBeacon(a,void 0===b?"":b))return!0}catch(c){}return!1}
function Kg(a,b){var c=new Image,d=""+Hg++;Gg[d]=c;c.onload=c.onerror=function(){b&&Gg[d]&&b();delete Gg[d]};
c.src=a}
;var Mg=y.ytPubsubPubsubInstance||new L,Ng=y.ytPubsubPubsubSubscribedKeys||{},Og=y.ytPubsubPubsubTopicToKeys||{},Pg=y.ytPubsubPubsubIsSynchronous||{};function Qg(a,b){var c=Rg();if(c&&b){var d=c.subscribe(a,function(){var e=arguments;var f=function(){Ng[d]&&b.apply&&"function"==typeof b.apply&&b.apply(window,e)};
try{Pg[a]?f():Mf(f,0)}catch(g){vf(g)}},void 0);
Ng[d]=!0;Og[a]||(Og[a]=[]);Og[a].push(d);return d}return 0}
function Sg(a){var b=Rg();b&&("number"===typeof a?a=[a]:"string"===typeof a&&(a=[parseInt(a,10)]),C(a,function(c){b.unsubscribeByKey(c);delete Ng[c]}))}
function Tg(a,b){var c=Rg();c&&c.publish.apply(c,arguments)}
function Ug(a){var b=Rg();if(b)if(b.clear(a),a)Vg(a);else for(var c in Og)Vg(c)}
function Rg(){return y.ytPubsubPubsubInstance}
function Vg(a){Og[a]&&(a=Og[a],C(a,function(b){Ng[b]&&delete Ng[b]}),a.length=0)}
L.prototype.subscribe=L.prototype.subscribe;L.prototype.unsubscribeByKey=L.prototype.da;L.prototype.publish=L.prototype.W;L.prototype.clear=L.prototype.clear;z("ytPubsubPubsubInstance",Mg,void 0);z("ytPubsubPubsubTopicToKeys",Og,void 0);z("ytPubsubPubsubIsSynchronous",Pg,void 0);z("ytPubsubPubsubSubscribedKeys",Ng,void 0);var Wg=window,P=Wg.ytcsi&&Wg.ytcsi.now?Wg.ytcsi.now:Wg.performance&&Wg.performance.timing&&Wg.performance.now&&Wg.performance.timing.navigationStart?function(){return Wg.performance.timing.navigationStart+Wg.performance.now()}:function(){return(new Date).getTime()};var Xg=Af("initial_gel_batch_timeout",2E3),Yg=Math.pow(2,16)-1,Zg=null,$g=0,ah=void 0,bh=0,ch=0,dh=0,eh=!0,fh=y.ytLoggingTransportGELQueue_||new Map;z("ytLoggingTransportGELQueue_",fh,void 0);var gh=y.ytLoggingTransportTokensToCttTargetIds_||{};z("ytLoggingTransportTokensToCttTargetIds_",gh,void 0);
function hh(a,b){if("log_event"===a.endpoint){var c="";a.ja?c="visitorOnlyApprovedKey":a.G&&(gh[a.G.token]=ih(a.G),c=a.G.token);var d=fh.get(c)||[];fh.set(c,d);d.push(a.payload);b&&(ah=new b);a=Af("tvhtml5_logging_max_batch")||Af("web_logging_max_batch")||100;b=P();d.length>=a?jh({writeThenSend:!0}):10<=b-dh&&(kh(),dh=b)}}
function lh(a,b){if("log_event"===a.endpoint){var c="";a.ja?c="visitorOnlyApprovedKey":a.G&&(gh[a.G.token]=ih(a.G),c=a.G.token);var d=new Map;d.set(c,[a.payload]);b&&(ah=new b);return new Ee(function(e){ah&&ah.isReady()?mh(d,e,{bypassNetworkless:!0}):e()})}}
function jh(a){a=void 0===a?{}:a;new Ee(function(b){Nf(bh);Nf(ch);ch=0;ah&&ah.isReady()?(mh(fh,b,a),fh.clear()):(kh(),b())})}
function kh(){O("web_gel_timeout_cap")&&!ch&&(ch=Mf(function(){jh({writeThenSend:!0})},6E4));
Nf(bh);var a=E("LOGGING_BATCH_TIMEOUT",Af("web_gel_debounce_ms",1E4));O("shorten_initial_gel_batch_timeout")&&eh&&(a=Xg);bh=Mf(function(){jh({writeThenSend:!0})},a)}
function mh(a,b,c){var d=ah;c=void 0===c?{}:c;var e=Math.round(P()),f=a.size;a=u(a);for(var g=a.next();!g.done;g=a.next()){var h=u(g.value);g=h.next().value;var k=h.next().value;h=lb({context:nh(d.config_||oh())});h.events=k;(k=gh[g])&&ph(h,g,k);delete gh[g];g="visitorOnlyApprovedKey"===g;qh(h,e,g);O("send_beacon_before_gel")&&window.navigator&&window.navigator.sendBeacon&&!c.writeThenSend&&Lg("/generate_204");rh(d,"log_event",h,{retry:!0,onSuccess:function(){f--;f||b();$g=Math.round(P()-e)},
onError:function(){f--;f||b()},
Ka:c,ja:g});eh=!1}}
function qh(a,b,c){a.requestTimeMs=String(b);O("unsplit_gel_payloads_in_logs")&&(a.unsplitGelPayloadsInLogs=!0);!c&&(b=E("EVENT_ID",void 0))&&((c=E("BATCH_CLIENT_COUNTER",void 0)||0)||(c=Math.floor(Math.random()*Yg/2)),c++,c>Yg&&(c=1),M("BATCH_CLIENT_COUNTER",c),b={serializedEventId:b,clientCounter:String(c)},a.serializedClientEventId=b,Zg&&$g&&O("log_gel_rtt_web")&&(a.previousBatchInfo={serializedClientEventId:Zg,roundtripMs:String($g)}),Zg=b,$g=0)}
function ph(a,b,c){if(c.videoId)var d="VIDEO";else if(c.playlistId)d="PLAYLIST";else return;a.credentialTransferTokenTargetId=c;a.context=a.context||{};a.context.user=a.context.user||{};a.context.user.credentialTransferTokens=[{token:b,scope:d}]}
function ih(a){var b={};a.videoId?b.videoId=a.videoId:a.playlistId&&(b.playlistId=a.playlistId);return b}
;var sh=y.ytLoggingGelSequenceIdObj_||{};z("ytLoggingGelSequenceIdObj_",sh,void 0);function th(a,b,c,d){d=void 0===d?{}:d;var e={},f=Math.round(d.timestamp||P());e.eventTimeMs=f<Number.MAX_SAFE_INTEGER?f:0;e[a]=b;a=Zf();e.context={lastActivityMs:String(d.timestamp||!isFinite(a)?-1:a)};O("log_sequence_info_on_gel_web")&&d.U&&(a=e.context,b=d.U,sh[b]=b in sh?sh[b]+1:0,a.sequence={index:sh[b],groupKey:b},d.Ta&&delete sh[d.U]);(d.Zk?lh:hh)({endpoint:"log_event",payload:e,G:d.G,ja:d.ja},c)}
;function uh(){if(!y.matchMedia)return"WEB_DISPLAY_MODE_UNKNOWN";try{return y.matchMedia("(display-mode: standalone)").matches?"WEB_DISPLAY_MODE_STANDALONE":y.matchMedia("(display-mode: minimal-ui)").matches?"WEB_DISPLAY_MODE_MINIMAL_UI":y.matchMedia("(display-mode: fullscreen)").matches?"WEB_DISPLAY_MODE_FULLSCREEN":y.matchMedia("(display-mode: browser)").matches?"WEB_DISPLAY_MODE_BROWSER":"WEB_DISPLAY_MODE_UNKNOWN"}catch(a){return"WEB_DISPLAY_MODE_UNKNOWN"}}
;function vh(a,b,c,d,e){cd.set(""+a,b,{wa:c,path:"/",domain:void 0===d?"youtube.com":d,secure:void 0===e?!1:e})}
;var wh=A("ytglobal.prefsUserPrefsPrefs_")||{};z("ytglobal.prefsUserPrefsPrefs_",wh,void 0);function xh(){this.h=E("ALT_PREF_COOKIE_NAME","PREF");this.i=E("ALT_PREF_COOKIE_DOMAIN","youtube.com");var a=cd.get(""+this.h,void 0);if(a){a=decodeURIComponent(a).split("&");for(var b=0;b<a.length;b++){var c=a[b].split("="),d=c[0];(c=c[1])&&(wh[d]=c.toString())}}}
xh.prototype.get=function(a,b){yh(a);zh(a);a=void 0!==wh[a]?wh[a].toString():null;return null!=a?a:b?b:""};
xh.prototype.set=function(a,b){yh(a);zh(a);if(null==b)throw Error("ExpectedNotNull");wh[a]=b.toString()};
xh.prototype.remove=function(a){yh(a);zh(a);delete wh[a]};
xh.prototype.clear=function(){for(var a in wh)delete wh[a]};
function zh(a){if(/^f([1-9][0-9]*)$/.test(a))throw Error("ExpectedRegexMatch: "+a);}
function yh(a){if(!/^\w+$/.test(a))throw Error("ExpectedRegexMismatch: "+a);}
function Ah(a){a=void 0!==wh[a]?wh[a].toString():null;return null!=a&&/^[A-Fa-f0-9]+$/.test(a)?parseInt(a,16):null}
Fa(xh);var Bh={bluetooth:"CONN_DISCO",cellular:"CONN_CELLULAR_UNKNOWN",ethernet:"CONN_WIFI",none:"CONN_NONE",wifi:"CONN_WIFI",wimax:"CONN_CELLULAR_4G",other:"CONN_UNKNOWN",unknown:"CONN_UNKNOWN","slow-2g":"CONN_CELLULAR_2G","2g":"CONN_CELLULAR_2G","3g":"CONN_CELLULAR_3G","4g":"CONN_CELLULAR_4G"},Ch={"slow-2g":"EFFECTIVE_CONNECTION_TYPE_SLOW_2G","2g":"EFFECTIVE_CONNECTION_TYPE_2G","3g":"EFFECTIVE_CONNECTION_TYPE_3G","4g":"EFFECTIVE_CONNECTION_TYPE_4G"};
function Dh(){var a=y.navigator;return a?a.connection:void 0}
;function Eh(){return"INNERTUBE_API_KEY"in rf&&"INNERTUBE_API_VERSION"in rf}
function oh(){return{innertubeApiKey:E("INNERTUBE_API_KEY",void 0),innertubeApiVersion:E("INNERTUBE_API_VERSION",void 0),Wa:E("INNERTUBE_CONTEXT_CLIENT_CONFIG_INFO"),Xa:E("INNERTUBE_CONTEXT_CLIENT_NAME","WEB"),innertubeContextClientVersion:E("INNERTUBE_CONTEXT_CLIENT_VERSION",void 0),Za:E("INNERTUBE_CONTEXT_HL",void 0),Ya:E("INNERTUBE_CONTEXT_GL",void 0),ab:E("INNERTUBE_HOST_OVERRIDE",void 0)||"",cb:!!E("INNERTUBE_USE_THIRD_PARTY_AUTH",!1),bb:!!E("INNERTUBE_OMIT_API_KEY_WHEN_AUTH_HEADER_IS_PRESENT",
!1),appInstallData:E("SERIALIZED_CLIENT_CONFIG_DATA",void 0)}}
function nh(a){var b={client:{hl:a.Za,gl:a.Ya,clientName:a.Xa,clientVersion:a.innertubeContextClientVersion,configInfo:a.Wa}},c=y.devicePixelRatio;c&&1!=c&&(b.client.screenDensityFloat=String(c));c=E("EXPERIMENTS_TOKEN","");""!==c&&(b.client.experimentsToken=c);c=[];var d=E("EXPERIMENTS_FORCED_FLAGS",{});for(e in d)c.push({key:e,value:String(d[e])});var e=E("EXPERIMENT_FLAGS",{});for(var f in e)f.startsWith("force_")&&void 0===d[f]&&c.push({key:f,value:String(e[f])});0<c.length&&(b.request={internalExperimentFlags:c});
f=b.client.clientName;if("WEB"===f||"MWEB"===f||1===f||2===f){if(!O("web_include_display_mode_killswitch")){var g;b.client.mainAppWebInfo=null!=(g=b.client.mainAppWebInfo)?g:{};b.client.mainAppWebInfo.webDisplayMode=uh()}}else if(g=b.client.clientName,("WEB_REMIX"===g||76===g)&&!O("music_web_display_mode_killswitch")){var h;b.client.Ja=null!=(h=b.client.Ja)?h:{};b.client.Ja.webDisplayMode=uh()}a.appInstallData&&(b.client.configInfo=b.client.configInfo||{},b.client.configInfo.appInstallData=a.appInstallData);
E("DELEGATED_SESSION_ID")&&!O("pageid_as_header_web")&&(b.user={onBehalfOfUser:E("DELEGATED_SESSION_ID")});a:{if(h=Dh()){a=Bh[h.type||"unknown"]||"CONN_UNKNOWN";h=Bh[h.effectiveType||"unknown"]||"CONN_UNKNOWN";"CONN_CELLULAR_UNKNOWN"===a&&"CONN_UNKNOWN"!==h&&(a=h);if("CONN_UNKNOWN"!==a)break a;if("CONN_UNKNOWN"!==h){a=h;break a}}a=void 0}a&&(b.client.connectionType=a);O("web_log_effective_connection_type")&&(a=Dh(),a=null!==a&&void 0!==a&&a.effectiveType?Ch.hasOwnProperty(a.effectiveType)?Ch[a.effectiveType]:
"EFFECTIVE_CONNECTION_TYPE_UNKNOWN":void 0,a&&(b.client.effectiveConnectionType=a));a=Object;h=a.assign;g=b.client;f={};e=u(Object.entries(ig(E("DEVICE",""))));for(c=e.next();!c.done;c=e.next())d=u(c.value),c=d.next().value,d=d.next().value,"cbrand"===c?f.deviceMake=d:"cmodel"===c?f.deviceModel=d:"cbr"===c?f.browserName=d:"cbrver"===c?f.browserVersion=d:"cos"===c?f.osName=d:"cosver"===c?f.osVersion=d:"cplatform"===c&&(f.platform=d);b.client=h.call(a,g,f);return b}
function Fh(a,b,c){c=void 0===c?{}:c;var d={"X-Goog-Visitor-Id":c.visitorData||E("VISITOR_DATA","")};if(b&&b.includes("www.youtube-nocookie.com"))return d;(b=c.Qk||E("AUTHORIZATION"))||(a?b="Bearer "+A("gapi.auth.getToken")().Pk:b=gd([]));b&&(d.Authorization=b,d["X-Goog-AuthUser"]=E("SESSION_INDEX",0),O("pageid_as_header_web")&&(d["X-Goog-PageId"]=E("DELEGATED_SESSION_ID")));return d}
;function Gh(a){a=Object.assign({},a);delete a.Authorization;var b=gd();if(b){var c=new yd;c.update(E("INNERTUBE_API_KEY",void 0));c.update(b);a.hash=Bc(c.digest())}return a}
;function Hh(a){var b=new ff;(b=b.isAvailable()?a?new mf(b,a):b:null)||(a=new gf(a||"UserDataSharedStore"),b=a.isAvailable()?a:null);this.h=(a=b)?new bf(a):null;this.i=document.domain||window.location.hostname}
Hh.prototype.set=function(a,b,c,d){c=c||31104E3;this.remove(a);if(this.h)try{this.h.set(a,b,Date.now()+1E3*c);return}catch(f){}var e="";if(d)try{e=escape(xe(b))}catch(f){return}else e=escape(b);vh(a,e,c,this.i)};
Hh.prototype.get=function(a,b){var c=void 0,d=!this.h;if(!d)try{c=this.h.get(a)}catch(e){d=!0}if(d&&(c=cd.get(""+a,void 0))&&(c=unescape(c),b))try{c=JSON.parse(c)}catch(e){this.remove(a),c=void 0}return c};
Hh.prototype.remove=function(a){this.h&&this.h.remove(a);var b=this.i;cd.remove(""+a,"/",void 0===b?"youtube.com":b)};var Ih;function Jh(){Ih||(Ih=new Hh("yt.innertube"));return Ih}
function Kh(a,b,c,d){if(d)return null;d=Jh().get("nextId",!0)||1;var e=Jh().get("requests",!0)||{};e[d]={method:a,request:b,authState:Gh(c),requestTime:Math.round(P())};Jh().set("nextId",d+1,86400,!0);Jh().set("requests",e,86400,!0);return d}
function Lh(a){var b=Jh().get("requests",!0)||{};delete b[a];Jh().set("requests",b,86400,!0)}
function Mh(a){var b=Jh().get("requests",!0);if(b){for(var c in b){var d=b[c];if(!(6E4>Math.round(P())-d.requestTime)){var e=d.authState,f=Gh(Fh(!1));jb(e,f)&&(e=d.request,"requestTimeMs"in e&&(e.requestTimeMs=Math.round(P())),rh(a,d.method,e,{}));delete b[c]}}Jh().set("requests",b,86400,!0)}}
;function Nh(a,b){this.version=a;this.args=b}
;function Oh(a,b){this.topic=a;this.h=b}
Oh.prototype.toString=function(){return this.topic};var Ph=A("ytPubsub2Pubsub2Instance")||new L;L.prototype.subscribe=L.prototype.subscribe;L.prototype.unsubscribeByKey=L.prototype.da;L.prototype.publish=L.prototype.W;L.prototype.clear=L.prototype.clear;z("ytPubsub2Pubsub2Instance",Ph,void 0);var Qh=A("ytPubsub2Pubsub2SubscribedKeys")||{};z("ytPubsub2Pubsub2SubscribedKeys",Qh,void 0);var Rh=A("ytPubsub2Pubsub2TopicToKeys")||{};z("ytPubsub2Pubsub2TopicToKeys",Rh,void 0);var Sh=A("ytPubsub2Pubsub2IsAsync")||{};z("ytPubsub2Pubsub2IsAsync",Sh,void 0);
z("ytPubsub2Pubsub2SkipSubKey",null,void 0);function Th(a,b){var c=Uh();c&&c.publish.call(c,a.toString(),a,b)}
function Vh(a){var b=Wh,c=Uh();if(!c)return 0;var d=c.subscribe(b.toString(),function(e,f){var g=A("ytPubsub2Pubsub2SkipSubKey");g&&g==d||(g=function(){if(Qh[d])try{if(f&&b instanceof Oh&&b!=e)try{var h=b.h,k=f;if(!k.args||!k.version)throw Error("yt.pubsub2.Data.deserialize(): serializedData is incomplete.");try{if(!h.V){var l=new h;h.V=l.version}var p=h.V}catch(n){}if(!p||k.version!=p)throw Error("yt.pubsub2.Data.deserialize(): serializedData version is incompatible.");try{f=Reflect.construct(h,
bb(k.args))}catch(n){throw n.message="yt.pubsub2.Data.deserialize(): "+n.message,n;}}catch(n){throw n.message="yt.pubsub2.pubsub2 cross-binary conversion error for "+b.toString()+": "+n.message,n;}a.call(window,f)}catch(n){vf(n)}},Sh[b.toString()]?A("yt.scheduler.instance")?Sf(g):Mf(g,0):g())});
Qh[d]=!0;Rh[b.toString()]||(Rh[b.toString()]=[]);Rh[b.toString()].push(d);return d}
function Xh(){var a=Yh,b=Vh(function(c){a.apply(void 0,arguments);Zh(b)});
return b}
function Zh(a){var b=Uh();b&&("number"===typeof a&&(a=[a]),C(a,function(c){b.unsubscribeByKey(c);delete Qh[c]}))}
function Uh(){return A("ytPubsub2Pubsub2Instance")}
;function $h(){}
;var ai=function(){var a;return function(){a||(a=new Hh("ytidb"));return a}}();
function bi(){var a;return null===(a=ai())||void 0===a?void 0:a.get("LAST_RESULT_ENTRY_KEY",!0)}
function ci(a){this.h=void 0===a?!1:a;(a=bi())||(a={hasSucceededOnce:this.h});this.i=a;var b,c;O("ytidb_analyze_is_supported")&&(null===(c=ai())||void 0===c?0:c.h)&&(c={hasSucceededOnce:this.i.hasSucceededOnce||this.h},null===(b=ai())||void 0===b?void 0:b.set("LAST_RESULT_ENTRY_KEY",c,2592E3,!0))}
ci.prototype.isSupported=function(){return this.h};var di=[],ei=!1;function fi(a){ei||(di.push({type:"ERROR",payload:a}),10<di.length&&di.shift())}
function gi(a,b){ei||(di.push({type:"EVENT",eventType:a,payload:b}),10<di.length&&di.shift())}
;function hi(a,b){for(var c=[],d=1;d<arguments.length;++d)c[d-1]=arguments[d];d=Error.call(this,a);this.message=d.message;"stack"in d&&(this.stack=d.stack);this.args=[].concat(c instanceof Array?c:fa(u(c)))}
v(hi,Error);function ii(){if(void 0!==E("DATASYNC_ID",void 0))return E("DATASYNC_ID",void 0);throw new hi("Datasync ID not set","unknown");}
;function ji(a){if(0<=a.indexOf(":"))throw Error("Database name cannot contain ':'");}
function ki(a){return a.substr(0,a.indexOf(":"))||a}
;var li={},mi=(li.AUTH_INVALID="No user identifier specified.",li.EXPLICIT_ABORT="Transaction was explicitly aborted.",li.IDB_NOT_SUPPORTED="IndexedDB is not supported.",li.MISSING_OBJECT_STORE="Object store not created.",li.UNKNOWN_ABORT="Transaction was aborted for unknown reasons.",li.QUOTA_EXCEEDED="The current transaction exceeded its quota limitations.",li.QUOTA_MAYBE_EXCEEDED="The current transaction may have failed because of exceeding quota limitations.",li.EXECUTE_TRANSACTION_ON_CLOSED_DB=
"Can't start a transaction on a closed database",li),ni={},oi=(ni.AUTH_INVALID="ERROR",ni.EXECUTE_TRANSACTION_ON_CLOSED_DB="WARNING",ni.EXPLICIT_ABORT="IGNORED",ni.IDB_NOT_SUPPORTED="ERROR",ni.MISSING_OBJECT_STORE="ERROR",ni.QUOTA_EXCEEDED="WARNING",ni.QUOTA_MAYBE_EXCEEDED="WARNING",ni.UNKNOWN_ABORT="WARNING",ni),pi={},qi=(pi.AUTH_INVALID=!1,pi.EXECUTE_TRANSACTION_ON_CLOSED_DB=!1,pi.EXPLICIT_ABORT=!1,pi.IDB_NOT_SUPPORTED=!1,pi.MISSING_OBJECT_STORE=!1,pi.QUOTA_EXCEEDED=!1,pi.QUOTA_MAYBE_EXCEEDED=!0,
pi.UNKNOWN_ABORT=!0,pi);function Q(a,b,c,d,e){b=void 0===b?{}:b;c=void 0===c?mi[a]:c;d=void 0===d?oi[a]:d;e=void 0===e?qi[a]:e;hi.call(this,c,Object.assign({name:"YtIdbKnownError",isSw:void 0===self.document,isIframe:self!==self.top,type:a},b));this.type=a;this.message=c;this.level=d;this.h=e;Object.setPrototypeOf(this,Q.prototype)}
v(Q,hi);function ri(a){Q.call(this,"MISSING_OBJECT_STORE",{Uk:a},mi.MISSING_OBJECT_STORE);Object.setPrototypeOf(this,ri.prototype)}
v(ri,Q);var si=["The database connection is closing","Can't start a transaction on a closed database","A mutation operation was attempted on a database that did not allow mutations"];
function ti(a,b,c){b=ki(b);var d=a instanceof Error?a:Error("Unexpected error: "+a);if(d instanceof Q)return d;if("QuotaExceededError"===d.name)return new Q("QUOTA_EXCEEDED",{objectStoreNames:c,dbName:b});if(yc&&"UnknownError"===d.name)return new Q("QUOTA_MAYBE_EXCEEDED",{objectStoreNames:c,dbName:b});if("InvalidStateError"===d.name&&si.some(function(e){return d.message.includes(e)}))return new Q("EXECUTE_TRANSACTION_ON_CLOSED_DB",{objectStoreNames:c,
dbName:b});if("AbortError"===d.name)return new Q("UNKNOWN_ABORT",{objectStoreNames:c,dbName:b},d.message);d.args=[{name:"IdbError",Vk:d.name,dbName:b,objectStoreNames:c}];d.level="WARNING";return d}
;function ui(a){if(!a)throw Error();throw a;}
function vi(a){return a}
function R(a){function b(e){if("PENDING"===d.state.status){d.state={status:"REJECTED",reason:e};e=u(d.onRejected);for(var f=e.next();!f.done;f=e.next())f=f.value,f()}}
function c(e){if("PENDING"===d.state.status){d.state={status:"FULFILLED",value:e};e=u(d.h);for(var f=e.next();!f.done;f=e.next())f=f.value,f()}}
var d=this;this.i=a;this.state={status:"PENDING"};this.h=[];this.onRejected=[];try{this.i(c,b)}catch(e){b(e)}}
R.all=function(a){return new R(function(b,c){var d=[],e=a.length;0===e&&b(d);for(var f={aa:0};f.aa<a.length;f={aa:f.aa},++f.aa)wi(R.resolve(a[f.aa]).then(function(g){return function(h){d[g.aa]=h;e--;0===e&&b(d)}}(f)),function(g){c(g)})})};
R.resolve=function(a){return new R(function(b,c){a instanceof R?a.then(b,c):b(a)})};
R.reject=function(a){return new R(function(b,c){c(a)})};
R.prototype.then=function(a,b){var c=this,d=null!==a&&void 0!==a?a:vi,e=null!==b&&void 0!==b?b:ui;return new R(function(f,g){"PENDING"===c.state.status?(c.h.push(function(){xi(c,c,d,f,g)}),c.onRejected.push(function(){yi(c,c,e,f,g)})):"FULFILLED"===c.state.status?xi(c,c,d,f,g):"REJECTED"===c.state.status&&yi(c,c,e,f,g)})};
function wi(a,b){a.then(void 0,b)}
function xi(a,b,c,d,e){try{if("FULFILLED"!==a.state.status)throw Error("calling handleResolve before the promise is fulfilled.");var f=c(a.state.value);f instanceof R?zi(a,b,f,d,e):d(f)}catch(g){e(g)}}
function yi(a,b,c,d,e){try{if("REJECTED"!==a.state.status)throw Error("calling handleReject before the promise is rejected.");var f=c(a.state.reason);f instanceof R?zi(a,b,f,d,e):d(f)}catch(g){e(g)}}
function zi(a,b,c,d,e){b===c?e(new TypeError("Circular promise chain detected.")):c.then(function(f){f instanceof R?zi(a,b,f,d,e):d(f)},function(f){e(f)})}
;function Ai(a,b,c){function d(){c(a.error);f()}
function e(){b(a.result);f()}
function f(){try{a.removeEventListener("success",e),a.removeEventListener("error",d)}catch(g){}}
a.addEventListener("success",e);a.addEventListener("error",d)}
function Bi(a){return new Promise(function(b,c){Ai(a,b,c)})}
function Ci(a){return new R(function(b,c){Ai(a,b,c)})}
;function Di(a,b){return new R(function(c,d){function e(){var f=a?b(a):null;f?f.then(function(g){a=g;e()},d):c()}
e()})}
;function Ei(a,b){this.h=a;this.options=b;this.transactionCount=0;this.j=Math.round(P());this.i=!1}
m=Ei.prototype;m.add=function(a,b,c){return Fi(this,[a],{mode:"readwrite",I:!0},function(d){return Gi(d,a).add(b,c)})};
m.clear=function(a){return Fi(this,[a],{mode:"readwrite",I:!0},function(b){return Gi(b,a).clear()})};
m.close=function(){var a;this.h.close();(null===(a=this.options)||void 0===a?0:a.closed)&&this.options.closed()};
m.count=function(a,b){return Fi(this,[a],{mode:"readonly",I:!0},function(c){return Gi(c,a).count(b)})};
function Hi(a,b,c){a=a.h.createObjectStore(b,c);return new Ii(a)}
m.delete=function(a,b){return Fi(this,[a],{mode:"readwrite",I:!0},function(c){return Gi(c,a).delete(b)})};
m.get=function(a,b){return Fi(this,[a],{mode:"readonly",I:!0},function(c){return Gi(c,a).get(b)})};
function Ji(a,b,c,d){return Fi(a,[b],{mode:"readwrite",I:!0},function(e){e=Gi(e,b);return Ci(e.h.put(c,d))})}
function Fi(a,b,c,d){return G(a,function f(){var g=this,h,k,l,p,n,t,q,D,K,N,X,Y;return x(f,function(I){switch(I.h){case 1:var T={mode:"readonly",I:!1};"string"===typeof c?T.mode=c:T=c;h=T;g.transactionCount++;k=h.I?Af("ytidb_transaction_try_count",1):1;l=0;case 2:if(p){I.A(3);break}l++;n=Math.round(P());ra(I,4);t=g.h.transaction(b,h.mode);T=new Ki(t);T=Li(T,d);return w(I,T,6);case 6:return q=I.i,D=Math.round(P()),Mi(g,n,D,l,void 0,b.join(),h),I.return(q);case 4:K=sa(I);N=Math.round(P());X=ti(K,g.h.name,
b.join());if((Y=X instanceof Q&&!X.h)||l>=k)Mi(g,n,N,l,X,b.join(),h),p=X;I.A(2);break;case 3:return I.return(Promise.reject(p))}})})}
function Mi(a,b,c,d,e,f,g){b=c-b;e?(e instanceof Q&&("QUOTA_EXCEEDED"===e.type||"QUOTA_MAYBE_EXCEEDED"===e.type)&&gi("QUOTA_EXCEEDED",{dbName:ki(a.h.name),objectStoreNames:f,transactionCount:a.transactionCount,transactionMode:g.mode}),e instanceof Q&&"UNKNOWN_ABORT"===e.type&&(gi("TRANSACTION_UNEXPECTEDLY_ABORTED",{objectStoreNames:f,transactionDuration:b,transactionCount:a.transactionCount,dbDuration:c-a.j}),a.i=!0),Ni(a,!1,d,f,b),fi(e)):Ni(a,!0,d,f,b)}
function Ni(a,b,c,d,e){gi("TRANSACTION_ENDED",{objectStoreNames:d,connectionHasUnknownAbortedTransaction:a.i,duration:e,isSuccessful:b,tryCount:c})}
function Ii(a){this.h=a}
m=Ii.prototype;m.add=function(a,b){return Ci(this.h.add(a,b))};
m.clear=function(){return Ci(this.h.clear()).then(function(){})};
m.count=function(a){return Ci(this.h.count(a))};
function Oi(a,b){return Pi(a,{query:b},function(c){return c.delete().then(function(){return c.continue()})}).then(function(){})}
m.delete=function(a){return a instanceof IDBKeyRange?Oi(this,a):Ci(this.h.delete(a))};
m.get=function(a){return Ci(this.h.get(a))};
m.index=function(a){return new Qi(this.h.index(a))};
m.getName=function(){return this.h.name};
function Pi(a,b,c){a=a.h.openCursor(b.query,b.direction);return Ri(a).then(function(d){return Di(d,c)})}
function Ki(a){var b=this;this.h=a;this.i=new Map;this.aborted=!1;this.done=new Promise(function(c,d){b.h.addEventListener("complete",function(){c()});
b.h.addEventListener("error",function(e){e.currentTarget===e.target&&d(b.h.error)});
b.h.addEventListener("abort",function(){var e=b.h.error;if(e)d(e);else if(!b.aborted){e=Q;for(var f=b.h.objectStoreNames,g=[],h=0;h<f.length;h++){var k=f.item(h);if(null===k)throw Error("Invariant: item in DOMStringList is null");g.push(k)}e=new e("UNKNOWN_ABORT",{objectStoreNames:g.join(),dbName:b.h.db.name,mode:b.h.mode});d(e)}})})}
function Li(a,b){var c=new Promise(function(d,e){try{wi(b(a).then(function(f){d(f)}),e)}catch(f){e(f),a.abort()}});
return Promise.all([c,a.done]).then(function(d){return u(d).next().value})}
Ki.prototype.abort=function(){this.h.abort();this.aborted=!0;throw new Q("EXPLICIT_ABORT");};
function Gi(a,b){b=a.h.objectStore(b);var c=a.i.get(b);c||(c=new Ii(b),a.i.set(b,c));return c}
function Qi(a){this.h=a}
Qi.prototype.count=function(a){return Ci(this.h.count(a))};
Qi.prototype.delete=function(a){return Si(this,{query:a},function(b){return b.delete().then(function(){return b.continue()})})};
Qi.prototype.get=function(a){return Ci(this.h.get(a))};
Qi.prototype.getKey=function(a){return Ci(this.h.getKey(a))};
function Si(a,b,c){a=a.h.openCursor(void 0===b.query?null:b.query,void 0===b.direction?"next":b.direction);return Ri(a).then(function(d){return Di(d,c)})}
function Ti(a,b){this.request=a;this.cursor=b}
function Ri(a){return Ci(a).then(function(b){return null===b?null:new Ti(a,b)})}
m=Ti.prototype;m.advance=function(a){this.cursor.advance(a);return Ri(this.request)};
m.continue=function(a){this.cursor.continue(a);return Ri(this.request)};
m.delete=function(){return Ci(this.cursor.delete()).then(function(){})};
m.getKey=function(){return this.cursor.key};
m.getValue=function(){return this.cursor.value};
m.update=function(a){return Ci(this.cursor.update(a))};function Ui(a,b,c){return new Promise(function(d,e){function f(){t||(t=new Ei(g.result,{closed:n}));return t}
var g=self.indexedDB.open(a,b),h=c.blocked,k=c.blocking,l=c.ub,p=c.upgrade,n=c.closed,t;g.addEventListener("upgradeneeded",function(q){try{if(null===q.newVersion)throw Error("Invariant: newVersion on IDbVersionChangeEvent is null");if(null===g.transaction)throw Error("Invariant: transaction on IDbOpenDbRequest is null");q.dataLoss&&"none"!==q.dataLoss&&gi("IDB_DATA_CORRUPTED",{reason:q.dataLossMessage||"unknown reason",dbName:ki(a)});var D=f(),K=new Ki(g.transaction);p&&p(D,q.oldVersion,q.newVersion,
K);K.done.catch(function(N){e(N)})}catch(N){e(N)}});
g.addEventListener("success",function(){var q=g.result;k&&q.addEventListener("versionchange",function(){k(f())});
q.addEventListener("close",function(){gi("IDB_UNEXPECTEDLY_CLOSED",{dbName:ki(a),dbVersion:q.version});l&&l()});
d(f())});
g.addEventListener("error",function(){e(g.error)});
h&&g.addEventListener("blocked",function(){h()})})}
function Vi(a,b,c){c=void 0===c?{}:c;return Ui(a,b,c)}
function Wi(a,b){b=void 0===b?{}:b;return G(this,function d(){var e,f,g;return x(d,function(h){e=self.indexedDB.deleteDatabase(a);f=b;(g=f.blocked)&&e.addEventListener("blocked",function(){g()});
return w(h,Bi(e),0)})})}
;function Xi(a,b){this.name=a;this.options=b;this.j=!1}
Xi.prototype.i=function(a,b,c){c=void 0===c?{}:c;return Vi(a,b,c)};
Xi.prototype.delete=function(a){a=void 0===a?{}:a;return Wi(this.name,a)};
Xi.prototype.open=function(){var a=this;if(!this.h){var b,c=function(){a.h===b&&(a.h=void 0)},d={blocking:function(f){f.close()},
closed:c,ub:c,upgrade:this.options.upgrade},e=function(){return G(a,function g(){var h=this,k,l,p;return x(g,function(n){switch(n.h){case 1:return ra(n,2),w(n,h.i(h.name,h.options.version,d),4);case 4:k=n.i;a:{var t=u(Object.keys(h.options.xa));for(var q=t.next();!q.done;q=t.next())if(q=q.value,!k.h.objectStoreNames.contains(q)){t=q;break a}t=void 0}l=t;if(void 0===l){n.A(5);break}if(h.j){n.A(6);break}h.j=!0;return w(n,h.delete(),7);case 7:return n.return(e());case 6:throw new ri(l);case 5:return n.return(k);
case 2:p=sa(n);if(p instanceof DOMException?"VersionError"===p.name:"DOMError"in self&&p instanceof DOMError?"VersionError"===p.name:p instanceof Object&&"message"in p&&"An attempt was made to open a database using a lower version than the existing version."===p.message)return n.return(h.i(h.name,void 0,Object.assign(Object.assign({},d),{upgrade:void 0})));c();throw p;}})})};
this.h=b=e()}return this.h};var Yi=new Xi("YtIdbMeta",{xa:{databases:!0},upgrade:function(a,b){1>b&&Hi(a,"databases",{keyPath:"actualName"})}});
function Zi(a){return G(this,function c(){var d;return x(c,function(e){if(1==e.h)return w(e,Yi.open(),2);d=e.i;return e.return(Fi(d,["databases"],{I:!0,mode:"readwrite"},function(f){var g=Gi(f,"databases");return g.get(a.actualName).then(function(h){if(h?a.actualName!==h.actualName||a.publicName!==h.publicName||a.userIdentifier!==h.userIdentifier||a.clearDataOnAuthChange!==h.clearDataOnAuthChange:1)return Ci(g.h.put(a,void 0)).then(function(){})})}))})})}
function $i(a){return G(this,function c(){var d;return x(c,function(e){if(1==e.h)return w(e,Yi.open(),2);d=e.i;return e.return(d.delete("databases",a))})})}
function aj(a){return G(this,function c(){var d,e;return x(c,function(f){return 1==f.h?(d=[],w(f,Yi.open(),2)):3!=f.h?(e=f.i,w(f,Fi(e,["databases"],{I:!0,mode:"readonly"},function(g){d.length=0;return Pi(Gi(g,"databases"),{},function(h){a(h.getValue())&&d.push(h.getValue());return h.continue()})}),3)):f.return(d)})})}
function bj(){return aj(function(a){return"LogsDatabaseV2"===a.publicName&&void 0!==a.userIdentifier})}
;var cj;
function dj(){return G(this,function b(){var c,d,e;return x(b,function(f){switch(f.h){case 1:if(O("ytidb_is_supported_cache_success_result")&&(c=bi(),null===c||void 0===c?0:c.hasSucceededOnce))return f.return(new ci(!0));var g;if(g=Eg)g=/WebKit\/([0-9]+)/.exec(Nb),g=!!(g&&600<=parseInt(g[1],10));g&&(g=/WebKit\/([0-9]+)/.exec(Nb),g=!(g&&602<=parseInt(g[1],10)));if(g||kc)return f.return(new ci(!1));try{if(d=self,!(d.indexedDB&&d.IDBIndex&&d.IDBKeyRange&&d.IDBObjectStore))return f.return(new ci(!1))}catch(h){return f.return(new ci(!1))}if(!("IDBTransaction"in self&&
"objectStoreNames"in IDBTransaction.prototype))return f.return(new ci(!1));ra(f,2);e={actualName:"yt-idb-test-do-not-use",publicName:"yt-idb-test-do-not-use",userIdentifier:void 0};return w(f,Zi(e),4);case 4:return w(f,$i("yt-idb-test-do-not-use"),5);case 5:return f.return(new ci(!0));case 2:return sa(f),f.return(new ci(!1))}})})}
function ej(){if(void 0!==cj)return cj;ei=!0;return cj=dj().then(function(a){ei=!1;return a.isSupported()})}
;function fj(a){try{ii();var b=!0}catch(c){b=!1}if(!b)throw a=new Q("AUTH_INVALID"),fi(a),a;b=ii();return{actualName:a+":"+b,publicName:a,userIdentifier:b}}
function gj(a,b,c,d){var e;return G(this,function g(){var h,k;return x(g,function(l){switch(l.h){case 1:return w(l,hj({caller:"openDbImpl",publicName:a,version:b}),2);case 2:return ji(a),h=c?{actualName:a,publicName:a,userIdentifier:void 0}:fj(a),h.clearDataOnAuthChange=null!==(e=d.clearDataOnAuthChange)&&void 0!==e?e:!1,ra(l,3),w(l,Zi(h),5);case 5:return w(l,Vi(h.actualName,b,d),6);case 6:return l.return(l.i);case 3:return k=sa(l),ra(l,7),w(l,$i(h.actualName),9);case 9:l.h=8;l.m=0;break;case 7:sa(l);
case 8:throw k;}})})}
function hj(a){return G(this,function c(){var d;return x(c,function(e){if(1==e.h)return w(e,ej(),2);if(!e.i)throw d=new Q("IDB_NOT_SUPPORTED",{context:a}),fi(d),d;e.h=0})})}
function ij(a,b,c){c=void 0===c?{}:c;return gj(a,b,!1,c)}
function jj(a,b,c){c=void 0===c?{}:c;return gj(a,b,!0,c)}
function kj(a,b){b=void 0===b?{}:b;return G(this,function d(){var e;return x(d,function(f){if(1==f.h)return w(f,ej(),2);if(3!=f.h){if(!f.i)return f.return();ji(a);e=fj(a);return w(f,Wi(e.actualName,b),3)}return w(f,$i(e.actualName),0)})})}
function lj(a,b){var c=this;a=a.map(function(d){return G(c,function f(){return x(f,function(g){return 1==g.h?w(g,Wi(d.actualName,b),2):w(g,$i(d.actualName),0)})})});
return Promise.all(a).then(function(){})}
function mj(){var a=void 0===a?{}:a;return G(this,function c(){var d;return x(c,function(e){if(1==e.h)return w(e,ej(),2);if(3!=e.h){if(!e.i)return e.return();ji("LogsDatabaseV2");return w(e,bj(),3)}d=e.i;return w(e,lj(d,a),0)})})}
function nj(a,b){b=void 0===b?{}:b;return G(this,function d(){return x(d,function(e){if(1==e.h)return w(e,ej(),2);if(3!=e.h){if(!e.i)return e.return();ji(a);return w(e,Wi(a,b),3)}return w(e,$i(a),0)})})}
;function oj(a,b){Xi.call(this,a,b);this.options=b;ji(a)}
v(oj,Xi);oj.prototype.i=function(a,b,c){c=void 0===c?{}:c;return(this.options.za?jj:ij)(a,b,Object.assign(Object.assign({},c),{clearDataOnAuthChange:this.options.clearDataOnAuthChange}))};
oj.prototype.delete=function(a){a=void 0===a?{}:a;return(this.options.za?nj:kj)(this.name,a)};
function pj(a,b){var c;return function(){c||(c=new oj(a,b));return c}}
;function qj(){R.call(this,function(){});
throw Error("Not allowed to instantiate the thennable outside of the core library.");}
v(qj,R);qj.reject=R.reject;qj.resolve=R.resolve;qj.all=R.all;var rj;function sj(){if(!rj){var a={};rj=pj("LogsDatabaseV2",{xa:(a.LogsRequestsStore=!0,a.sapisid=!0,a.SWHealthLog=!0,a),za:!O("nwl_use_ytidb_partitioning"),upgrade:function(b,c){2>c&&(Hi(b,"LogsRequestsStore",{keyPath:"id",autoIncrement:!0}).h.createIndex("newRequest",["status","authHash","interface","timestamp"],{unique:!1}),Hi(b,"sapisid"));3>c&&Hi(b,"SWHealthLog",{keyPath:"id",autoIncrement:!0}).h.createIndex("swHealthNewRequest",["interface","timestamp"],{unique:!1})},
version:3})}return rj().open()}
function tj(a){return G(this,function c(){var d,e,f,g,h;return x(c,function(k){switch(k.h){case 1:return d={startTime:P(),transactionType:"YT_IDB_TRANSACTION_TYPE_WRITE"},w(k,uj(),2);case 2:return e=k.i,w(k,sj(),3);case 3:return f=k.i,g=Object.assign(Object.assign({},a),{options:JSON.parse(JSON.stringify(a.options)),authHash:e,interface:E("INNERTUBE_CONTEXT_CLIENT_NAME",0)}),w(k,Ji(f,"LogsRequestsStore",g),4);case 4:return h=k.i,d.vb=P(),vj(d),k.return(h)}})})}
function wj(a){return G(this,function c(){var d,e,f,g,h,k,l,p;return x(c,function(n){switch(n.h){case 1:return d={startTime:P(),transactionType:"YT_IDB_TRANSACTION_TYPE_READ"},w(n,uj(),2);case 2:return e=n.i,f=E("INNERTUBE_CONTEXT_CLIENT_NAME",0),g=[a,e,f,0],h=[a,e,f,P()],k=IDBKeyRange.bound(g,h),w(n,sj(),3);case 3:return l=n.i,p=void 0,w(n,Fi(l,["LogsRequestsStore"],{mode:"readwrite",I:!0},function(t){return Si(Gi(t,"LogsRequestsStore").index("newRequest"),{query:k,direction:"prev"},function(q){q.getValue()&&
(p=q.getValue(),"NEW"===a&&(p.status="QUEUED",q.update(p)))})}),4);
case 4:return d.vb=P(),vj(d),n.return(p)}})})}
function xj(a){return G(this,function c(){var d;return x(c,function(e){if(1==e.h)return w(e,sj(),2);d=e.i;return e.return(Fi(d,["LogsRequestsStore"],{mode:"readwrite",I:!0},function(f){var g=Gi(f,"LogsRequestsStore");return g.get(a).then(function(h){if(h)return h.status="QUEUED",Ci(g.h.put(h,void 0)).then(function(){return h})})}))})})}
function yj(a){return G(this,function c(){var d;return x(c,function(e){if(1==e.h)return w(e,sj(),2);d=e.i;return e.return(Fi(d,["LogsRequestsStore"],{mode:"readwrite",I:!0},function(f){var g=Gi(f,"LogsRequestsStore");return g.get(a).then(function(h){return h?(h.status="NEW",h.sendCount+=1,Ci(g.h.put(h,void 0)).then(function(){return h})):qj.resolve(void 0)})}))})})}
function zj(a){return G(this,function c(){var d;return x(c,function(e){if(1==e.h)return w(e,sj(),2);d=e.i;return e.return(d.delete("LogsRequestsStore",a))})})}
function Aj(){return G(this,function b(){var c;return x(b,function(d){if(1==d.h)return w(d,sj(),2);c=d.i;return d.return(c.clear("LogsRequestsStore"))})})}
function Bj(){return G(this,function b(){var c,d;return x(b,function(e){if(1==e.h)return w(e,sj(),2);c=e.i;d=P()-2592E6;return w(e,Fi(c,["LogsRequestsStore"],{mode:"readwrite",I:!0},function(f){return Pi(Gi(f,"LogsRequestsStore"),{},function(g){if(g.getValue().timestamp<=d)return g.delete().then(function(){return g.continue()})})}),0)})})}
function Cj(){return G(this,function b(){return x(b,function(c){return 1==c.h?w(c,mj(),2):w(c,nj("LogsDatabaseV2"),0)})})}
function uj(){return G(this,function b(){var c;return x(b,function(d){if(1==d.h){$h.h||($h.h=new $h);var e={};var f=gd([]);f&&(e.Authorization=f,f=void 0,void 0===f&&(f=Number(E("SESSION_INDEX",0)),f=isNaN(f)?0:f),e["X-Goog-AuthUser"]=f,"INNERTUBE_HOST_OVERRIDE"in rf||(e["X-Origin"]=window.location.origin),O("pageid_as_header_web")&&"DELEGATED_SESSION_ID"in rf&&(e["X-Goog-PageId"]=E("DELEGATED_SESSION_ID")));e instanceof Ee||(f=new Ee(Ea),Fe(f,2,e),e=f);return w(d,e,2)}c=d.i;e=d.return;f=Gh(c);var g=
new yd;g.update(JSON.stringify(f,Object.keys(f).sort()));f=g.digest();g="";for(var h=0;h<f.length;h++)g+="0123456789ABCDEF".charAt(Math.floor(f[h]/16))+"0123456789ABCDEF".charAt(f[h]%16);return e.call(d,g)})})}
function Dj(a){return G(this,function c(){var d;return x(c,function(e){if(1==e.h)return w(e,sj(),2);d=e.i;return w(e,Ji(d,"sapisid",a,"sapisid"),0)})})}
function Ej(){return G(this,function b(){var c,d;return x(b,function(e){if(1==e.h)return w(e,sj(),2);if(3!=e.h)return c=e.i,w(e,c.get("sapisid","sapisid"),3);d=e.i;return e.return(d||"")})})}
function vj(a){var b=Af("nwl_latency_sampling_rate",.01);.02<b||Math.random()<=b&&Th("nwl_transaction_latency_payload",a)}
;var Fj;function Gj(){if(!Fj){var a={};Fj=pj("ServiceWorkerLogsDatabase",{xa:(a.SWHealthLog=!0,a),za:!0,upgrade:function(b,c,d){1>c&&1<=d&&Hi(b,"SWHealthLog",{keyPath:"id",autoIncrement:!0}).h.createIndex("swHealthNewRequest",["interface","timestamp"],{unique:!1})},
version:1})}return Fj().open()}
function Hj(){return G(this,function b(){var c,d;return x(b,function(e){if(1==e.h)return O("web_clean_sw_logs_store")?w(e,Gj(),3):e.A(0);c=e.i;d=P()-2592E6;return w(e,Fi(c,["SWHealthLog"],{mode:"readwrite",I:!0},function(f){return Pi(Gi(f,"SWHealthLog"),{},function(g){if(g.getValue().timestamp<=d)return g.delete().then(function(){return g.continue()})})}),0)})})}
function Ij(){return G(this,function b(){var c,d;return x(b,function(e){switch(e.h){case 1:return w(e,Gj(),2);case 2:return c=e.i,w(e,c.clear("SWHealthLog"),3);case 3:return w(e,sj(),4);case 4:return d=e.i,e.return(d.clear("SWHealthLog"))}})})}
;var Jj=["__Secure-1PAPISID","SAPISID","__Secure-3PAPISID"];function Kj(){for(var a=u(Jj),b=a.next();!b.done;b=a.next())if(b=cd.get(b.value))return b;return"LOGGED_OUT"}
function Lj(){pe.call(this);this.pollingInterval=3E3;this.i=[null,null,null];this.m=!1;Mj(this)}
v(Lj,pe);function Nj(){Lj.h||(Lj.h=new Lj);var a=Lj.h;a.m=!0;a.verifyUser();Oj(a)}
Lj.prototype.verifyUser=function(){var a=Mj(this),b=a.fb;if(!a.tb)return Oj(this),!0;qe(this,"ytsessionchange");b&&qe(this,"ytuserinvalid");Oj(this);return!1};
function Mj(a){var b=Jj.map(function(e){var f;return null!==(f=cd.get(e))&&void 0!==f?f:""}),c=b.some(function(e,f){return a.i&&""!==a.i[f]&&""===e}),d=b.some(function(e,f){return a.i&&a.i[f]!==e});
a.i=b;return{fb:c,tb:d}}
function Oj(a){a.m&&(Pj(a),a.l=Qf(function(){a.verifyUser()},a.pollingInterval))}
function Pj(a){a.l&&(Uf(a.l),a.l=void 0)}
;var Qj;function Rj(){Qj||(Qj=new Hh("yt.offline"));return Qj}
function Sj(a){if(O("offline_error_handling")){var b=Rj().get("errors",!0)||{};b[a.message]={name:a.name,stack:a.stack};a.level&&(b[a.message].level=a.level);Rj().set("errors",b,2592E3,!0)}}
function Tj(){if(O("offline_error_handling")){var a=Rj().get("errors",!0);if(a){for(var b in a)if(a[b]){var c=new hi(b,"sent via offline_errors");c.name=a[b].name;c.stack=a[b].stack;c.level=a[b].level;vf(c)}Rj().set("errors",{},2592E3,!0)}}}
;var Uj=Af("network_polling_interval",3E4);function S(){pe.call(this);this.L=0;this.o=this.l=!1;this.B=0;this.m=this.J=!1;this.i=this.ka();this.m=O("validate_network_status");Vj(this);Wj(this)}
v(S,pe);function Xj(){if(!S.h){var a=A("yt.networkStatusManager.instance")||new S;z("yt.networkStatusManager.instance",a,void 0);S.h=a}return S.h}
m=S.prototype;m.M=function(){this.m||this.i===this.ka()||wf(new hi("NetworkStatusManager isOnline does not match window status"));return this.i};
m.gb=function(a){this.l=!0;if(void 0===a?0:a)this.L||Yj(this)};
m.ka=function(){var a=window.navigator.onLine;return void 0===a?!0:a};
m.Ra=function(){this.J=!0};
m.ca=function(a,b){return pe.prototype.ca.call(this,a,b)};
function Wj(a){window.addEventListener("online",function(){return G(a,function c(){var d=this;return x(c,function(e){if(1==e.h)return d.m?w(e,d.T(),2):(d.i=!0,d.l&&qe(d,"ytnetworkstatus-online"),e.A(2));Zj(d);d.J&&Tj();e.h=0})})})}
function Vj(a){window.addEventListener("offline",function(){return G(a,function c(){var d=this;return x(c,function(e){if(1==e.h)return d.m?w(e,d.T(),2):(d.i=!1,d.l&&qe(d,"ytnetworkstatus-offline"),e.A(2));Zj(d);e.h=0})})})}
function Yj(a){a.L=Qf(function(){return G(a,function c(){var d=this;return x(c,function(e){if(1==e.h){if(O("trigger_nsm_validation_checks_with_nwl")&&!d.i)return w(e,d.T(),3);if(d.ka()){if(!1!==d.i)return e.A(3);d.o=!0;d.B=P();return d.l?d.m?w(e,d.T(),11):(d.i=!0,qe(d,"ytnetworkstatus-online"),e.A(11)):e.A(11)}if(!0!==d.i)return e.A(3);d.o=!0;d.B=P();return d.l?d.m?w(e,d.T(),3):(d.i=!1,qe(d,"ytnetworkstatus-offline"),e.A(3)):e.A(3)}if(3!=e.h)return d.J&&Tj(),e.A(3);Yj(d);e.h=0})})},Uj)}
function Zj(a){a.o&&(wf(new hi("NetworkStatusManager state did not match poll",P()-a.B)),a.o=!1)}
m.T=function(a){var b=this;return this.C?this.C:this.C=new Promise(function(c){return G(b,function e(){var f,g,h,k=this;return x(e,function(l){switch(l.h){case 1:return f=window.AbortController?new window.AbortController:void 0,g=null===f||void 0===f?void 0:f.signal,h=!1,ra(l,2,3),f&&(k.K=Sf(function(){f.abort()},a||2E4)),w(l,fetch("/generate_204",{method:"HEAD",
signal:g}),5);case 5:h=!0;case 3:ta(l);k.C=void 0;k.K&&Uf(k.K);h!==k.i&&(k.i=h,k.i&&k.l?qe(k,"ytnetworkstatus-online"):k.l&&qe(k,"ytnetworkstatus-offline"));c(h);ua(l);break;case 2:sa(l),h=!1,l.A(3)}})})})};
S.prototype.sendNetworkCheckRequest=S.prototype.T;S.prototype.listen=S.prototype.ca;S.prototype.enableErrorFlushing=S.prototype.Ra;S.prototype.getWindowStatus=S.prototype.ka;S.prototype.monitorNetworkStatusChange=S.prototype.gb;S.prototype.isNetworkAvailable=S.prototype.M;S.getInstance=Xj;function ak(a){a=void 0===a?{}:a;pe.call(this);var b=this;this.l=this.o=0;this.i=Xj();var c=A("yt.networkStatusManager.instance.monitorNetworkStatusChange").bind(this.i);c&&c(a.Sa);a.eb&&(c=A("yt.networkStatusManager.instance.enableErrorFlushing").bind(this.i))&&c();if(c=A("yt.networkStatusManager.instance.listen").bind(this.i))a.ma?(this.ma=a.ma,c("ytnetworkstatus-online",function(){bk(b,"publicytnetworkstatus-online")}),c("ytnetworkstatus-offline",function(){bk(b,"publicytnetworkstatus-offline")})):
(c("ytnetworkstatus-online",function(){qe(b,"publicytnetworkstatus-online")}),c("ytnetworkstatus-offline",function(){qe(b,"publicytnetworkstatus-offline")}))}
v(ak,pe);ak.prototype.M=function(){var a=A("yt.networkStatusManager.instance.isNetworkAvailable").bind(this.i);return a?a():!0};
ak.prototype.T=function(a){return G(this,function c(){var d=this,e;return x(c,function(f){return(e=A("yt.networkStatusManager.instance.sendNetworkCheckRequest").bind(d.i))?f.return(e(a)):f.return(!0)})})};
function bk(a,b){a.ma?a.l?(Uf(a.o),a.o=Sf(function(){a.m!==b&&(qe(a,b),a.m=b,a.l=P())},a.ma-(P()-a.l))):(qe(a,b),a.m=b,a.l=P()):qe(a,b)}
;var ck=!1,dk=!1,ek=0,fk=0,gk,hk=y.ytNetworklessLoggingInitializationOptions||{isNwlInitialized:ck,isIdbSupported:dk,potentialEsfErrorCounter:fk};O("export_networkless_options")&&z("ytNetworklessLoggingInitializationOptions",hk,void 0);
function ik(){G(this,function b(){var c,d,e,f;return x(b,function(g){switch(g.h){case 1:return w(g,ej(),2);case 2:(c=g.i)&&(dk=!0);d=O("networkless_logging");if(c&&d)return O("nwl_use_ytidb_partitioning")?w(g,nj("LogsDatabaseV2"),8):w(g,mj(),8);if(!c){g.A(0);break}return w(g,Cj(),0);case 8:return Nj(),document.addEventListener("ytsessionchange",function(){jk()}),w(g,Ej(),11);
case 11:e=g.i;f=Kj();if(e===f){g.A(12);break}jk();return w(g,Dj(f),12);case 12:if(!(O("enable_nwl_cleaning_logic")&&Math.random()<=Af("nwl_cleaning_rate",.1))){g.A(14);break}return w(g,Bj(),15);case 15:return w(g,Hj(),14);case 14:ck=!0;kk();lk().M()&&mk();lk().ca("publicytnetworkstatus-online",mk);lk().ca("publicytnetworkstatus-offline",nk);if(!O("networkless_immediately_drop_sw_health_store")){g.A(17);break}return w(g,ok(),17);case 17:if(!O("networkless_immediately_drop_all_requests")){g.A(19);break}return w(g,
Cj(),19);case 19:O("export_networkless_options")&&(hk.isNwlInitialized=ck,hk.isIdbSupported=dk),g.h=0}})})}
function pk(a,b){function c(d){var e=lk().M();if(!qk()||!d||e&&O("vss_networkless_bypass_write"))rk(a,b);else{var f={url:a,options:b,timestamp:P(),status:"NEW",sendCount:0};tj(f).then(function(g){f.id=g;(lk().M()||O("networkless_always_online"))&&sk(f)}).catch(function(g){sk(f);
lk().M()?vf(g):Sj(g)})}}
b=void 0===b?{}:b;O("skip_is_supported_killswitch")?ej().then(function(d){c(d)}):c(tk())}
function uk(a,b){function c(d){if(qk()&&d){var e={url:a,options:b,timestamp:P(),status:"NEW",sendCount:0},f=!1,g=b.onSuccess?b.onSuccess:function(){};
e.options.onSuccess=function(h,k){void 0!==e.id?zj(e.id):f=!0;g(h,k)};
rk(e.url,e.options);tj(e).then(function(h){e.id=h;f&&zj(e.id)}).catch(function(h){lk().M()?vf(h):Sj(h)})}else rk(a,b)}
b=void 0===b?{}:b;O("skip_is_supported_killswitch")?ej().then(function(d){c(d)}):c(tk())}
function mk(){var a=this;ek||(ek=Sf(function(){return G(a,function c(){var d;return x(c,function(e){if(1==e.h)return w(e,wj("NEW"),2);if(3!=e.h)return d=e.i,d?w(e,sk(d),3):(nk(),e.return());if(!O("nwl_throttling_race_fix")||ek)ek=0,mk();e.h=0})})},100))}
function nk(){Uf(ek);ek=0}
function sk(a){return G(this,function c(){var d;return x(c,function(e){switch(e.h){case 1:if(void 0===a.id){e.A(2);break}return w(e,xj(a.id),3);case 3:(d=e.i)?a=d:wf(Error("The request cannot be found in the database."));case 2:if(vk(a,2592E6)){e.A(4);break}wf(Error("Networkless Logging: Stored logs request expired age limit"));if(void 0===a.id){e.A(5);break}return w(e,zj(a.id),5);case 5:return e.return();case 4:var f=a=wk(a),g,h;if(null===(h=null===(g=null===f||void 0===f?void 0:f.options)||void 0===
g?void 0:g.postParams)||void 0===h?0:h.requestTimeMs)f.options.postParams.requestTimeMs=Math.round(P());(a=f)&&rk(a.url,a.options);e.h=0}})})}
function wk(a){var b=this,c=a.options.onError?a.options.onError:function(){};
a.options.onError=function(e,f){return G(b,function h(){return x(h,function(k){switch(k.h){case 1:if(!(O("trigger_nsm_validation_checks_with_nwl")&&(A("ytNetworklessLoggingInitializationOptions")?hk.potentialEsfErrorCounter:fk)<=Af("potential_esf_error_limit",10))){k.A(2);break}return w(k,lk().T(),3);case 3:if(lk().M())A("ytNetworklessLoggingInitializationOptions")&&hk.potentialEsfErrorCounter++,fk++;else return c(e,f),k.return();case 2:if(void 0===(null===a||void 0===a?void 0:a.id)){k.A(4);break}return 1>
a.sendCount?w(k,yj(a.id),8):w(k,zj(a.id),4);case 8:Sf(function(){lk().M()&&mk()},5E3);
case 4:c(e,f),k.h=0}})})};
var d=a.options.onSuccess?a.options.onSuccess:function(){};
a.options.onSuccess=function(e,f){return G(b,function h(){return x(h,function(k){if(1==k.h)return void 0===(null===a||void 0===a?void 0:a.id)?k.A(2):w(k,zj(a.id),2);d(e,f);k.h=0})})};
return a}
function vk(a,b){a=a.timestamp;return P()-a>=b?!1:!0}
function kk(){var a=this;wj("QUEUED").then(function(b){b&&!vk(b,12E4)?Sf(function(){return G(a,function d(){return x(d,function(e){if(1==e.h)return void 0===b.id?e.A(2):w(e,yj(b.id),2);kk();e.h=0})})}):O("nwl_trigger_throttle_after_reset")&&lk().M()&&mk()})}
function jk(){Aj().catch(function(a){vf(a)})}
function ok(){return G(this,function b(){return x(b,function(c){return c.return(Ij().catch(function(d){vf(d)}))})})}
function lk(){gk||(gk=new ak({eb:!0,Sa:O("trigger_nsm_validation_checks_with_nwl")}));return gk}
function rk(a,b){if(O("networkless_with_beacon")){var c=["method","postBody"];if(Object.keys(b).length>c.length)var d=!0;else{d=0;c=u(c);for(var e=c.next();!e.done;e=c.next())b.hasOwnProperty(e.value)&&d++;d=Object.keys(b).length!==d}d?wg(a,b):Lg(a,void 0,b.postBody)}else wg(a,b)}
function qk(){return A("ytNetworklessLoggingInitializationOptions")?hk.isNwlInitialized:ck}
function tk(){return A("ytNetworklessLoggingInitializationOptions")?hk.isIdbSupported:dk}
;function xk(a){var b=this;this.config_=null;a?this.config_=a:Eh()&&(this.config_=oh());Qf(function(){Mh(b)},5E3)}
xk.prototype.isReady=function(){!this.config_&&Eh()&&(this.config_=oh());return!!this.config_};
function rh(a,b,c,d){function e(t){t=void 0===t?!1:t;var q;if(d.retry&&"www.youtube-nocookie.com"!=h&&(t||(q=Kh(b,c,l,k)),q)){var D=g.onSuccess,K=g.onFetchSuccess;g.onSuccess=function(N,X){Lh(q);D(N,X)};
c.onFetchSuccess=function(N,X){Lh(q);K(N,X)}}try{t&&d.retry&&!d.Ka.bypassNetworkless?(g.method="POST",!d.Ka.writeThenSend&&O("nwl_send_fast_on_unload")?uk(n,g):pk(n,g)):(g.method="POST",g.postParams||(g.postParams={}),wg(n,g))}catch(N){if("InvalidAccessError"==N.name)q&&(Lh(q),q=0),wf(Error("An extension is blocking network request."));
else throw N;}q&&Qf(function(){Mh(a)},5E3)}
!E("VISITOR_DATA")&&"visitor_id"!==b&&.01>Math.random()&&wf(new hi("Missing VISITOR_DATA when sending innertube request.",b,c,d));if(!a.isReady()){var f=new hi("innertube xhrclient not ready",b,c,d);vf(f);throw f;}var g={headers:{"Content-Type":"application/json"},method:"POST",postParams:c,postBodyFormat:"JSON",onTimeout:function(){d.onTimeout()},
onFetchTimeout:d.onTimeout,onSuccess:function(t,q){if(d.onSuccess)d.onSuccess(q)},
onFetchSuccess:function(t){if(d.onSuccess)d.onSuccess(t)},
onError:function(t,q){if(d.onError)d.onError(q)},
onFetchError:function(t){if(d.onError)d.onError(t)},
timeout:d.timeout,withCredentials:!0},h="";(f=a.config_.ab)&&(h=f);var k=a.config_.cb||!1,l=Fh(k,h,d);Object.assign(g.headers,l);g.headers.Authorization&&!h&&(g.headers["x-origin"]=window.location.origin);f="/youtubei/"+a.config_.innertubeApiVersion+"/"+b;var p={alt:"json"};a.config_.bb&&g.headers.Authorization||(p.key=a.config_.innertubeApiKey);var n=kg(""+h+f,p||{},!0);qk()?ej().then(function(t){e(t)}):e(!1)}
;function yk(a,b,c){c=void 0===c?{}:c;var d=xk;E("ytLoggingEventsDefaultDisabled",!1)&&xk==xk&&(d=null);th(a,b,d,c)}
;var zk=[{Ia:function(a){return"Cannot read property '"+a.key+"'"},
ya:{TypeError:[{regexp:/Cannot read property '([^']+)' of (null|undefined)/,groups:["key","value"]},{regexp:/\u65e0\u6cd5\u83b7\u53d6\u672a\u5b9a\u4e49\u6216 (null|undefined) \u5f15\u7528\u7684\u5c5e\u6027\u201c([^\u201d]+)\u201d/,groups:["value","key"]},{regexp:/\uc815\uc758\ub418\uc9c0 \uc54a\uc74c \ub610\ub294 (null|undefined) \ucc38\uc870\uc778 '([^']+)' \uc18d\uc131\uc744 \uac00\uc838\uc62c \uc218 \uc5c6\uc2b5\ub2c8\ub2e4./,groups:["value","key"]},{regexp:/No se puede obtener la propiedad '([^']+)' de referencia nula o sin definir/,
groups:["key"]},{regexp:/Unable to get property '([^']+)' of (undefined or null) reference/,groups:["key","value"]}],Error:[{regexp:/(Permission denied) to access property "([^']+)"/,groups:["reason","key"]}]}},{Ia:function(a){return"Cannot call '"+a.key+"'"},
ya:{TypeError:[{regexp:/(?:([^ ]+)?\.)?([^ ]+) is not a function/,groups:["base","key"]},{regexp:/([^ ]+) called on (null or undefined)/,groups:["key","value"]},{regexp:/Object (.*) has no method '([^ ]+)'/,groups:["base","key"]},{regexp:/Object doesn't support property or method '([^ ]+)'/,groups:["key"]},{regexp:/\u30aa\u30d6\u30b8\u30a7\u30af\u30c8\u306f '([^']+)' \u30d7\u30ed\u30d1\u30c6\u30a3\u307e\u305f\u306f\u30e1\u30bd\u30c3\u30c9\u3092\u30b5\u30dd\u30fc\u30c8\u3057\u3066\u3044\u307e\u305b\u3093/,
groups:["key"]},{regexp:/\uac1c\uccb4\uac00 '([^']+)' \uc18d\uc131\uc774\ub098 \uba54\uc11c\ub4dc\ub97c \uc9c0\uc6d0\ud558\uc9c0 \uc54a\uc2b5\ub2c8\ub2e4./,groups:["key"]}]}}];var Bk={S:[],R:[{Ca:Ak,weight:500}]};function Ak(a){a=a.stack;return a.includes("chrome://")||a.includes("chrome-extension://")||a.includes("moz-extension://")}
;function Ck(){this.R=[];this.S=[]}
var Dk;function Ek(){if(!Dk){var a=Dk=new Ck;a.S.length=0;a.R.length=0;Bk.S&&a.S.push.apply(a.S,Bk.S);Bk.R&&a.R.push.apply(a.R,Bk.R)}return Dk}
;var Fk=new L;function Gk(a){function b(){return a.charCodeAt(d++)}
var c=a.length,d=0;do{var e=Hk(b);if(Infinity===e)break;var f=e>>3;switch(e&7){case 0:e=Hk(b);if(2===f)return e;break;case 1:if(2===f)return;d+=8;break;case 2:e=Hk(b);if(2===f)return a.substr(d,e);d+=e;break;case 5:if(2===f)return;d+=4;break;default:return}}while(d<c)}
function Hk(a){var b=a(),c=b&127;if(128>b)return c;b=a();c|=(b&127)<<7;if(128>b)return c;b=a();c|=(b&127)<<14;if(128>b)return c;b=a();return 128>b?c|(b&127)<<21:Infinity}
;function Ik(a,b,c,d){if(a)if(Array.isArray(a)){var e=d;for(d=0;d<a.length&&!(a[d]&&(e+=Jk(d,a[d],b,c),500<e));d++);d=e}else if("object"===typeof a)for(e in a){if(a[e]){var f=e;var g=a[e],h=b,k=c;f="string"!==typeof g||"clickTrackingParams"!==f&&"trackingParams"!==f?0:(g=Gk(atob(g.replace(/-/g,"+").replace(/_/g,"/"))))?Jk(f+".ve",g,h,k):0;d+=f;d+=Jk(e,a[e],b,c);if(500<d)break}}else c[b]=Kk(a),d+=c[b].length;else c[b]=Kk(a),d+=c[b].length;return d}
function Jk(a,b,c,d){c+="."+a;a=Kk(b);d[c]=a;return c.length+a.length}
function Kk(a){return("string"===typeof a?a:String(JSON.stringify(a))).substr(0,500)}
;var Lk=new Set,Mk=0,Nk=0,Ok=0,Pk=[],Qk=["PhantomJS","Googlebot","TO STOP THIS SECURITY SCAN go/scan"];function Rk(a){Sk(a,"WARNING")}
function Sk(a,b,c,d,e,f){f=void 0===f?{}:f;f.name=c||E("INNERTUBE_CONTEXT_CLIENT_NAME",1);f.version=d||E("INNERTUBE_CONTEXT_CLIENT_VERSION",void 0);c=f||{};b=void 0===b?"ERROR":b;b=void 0===b?"ERROR":b;if(a&&(a.hasOwnProperty("level")&&a.level&&(b=a.level),O("console_log_js_exceptions")&&(d=[],d.push("Name: "+a.name),d.push("Message: "+a.message),a.hasOwnProperty("params")&&d.push("Error Params: "+JSON.stringify(a.params)),a.hasOwnProperty("args")&&d.push("Error args: "+JSON.stringify(a.args)),d.push("File name: "+
a.fileName),d.push("Stacktrace: "+a.stack),window.console.log(d.join("\n"),a)),!(5<=Mk))){var g=Ad(a);d=g.message||"Unknown Error";e=g.name||"UnknownError";var h=g.stack||a.i||"Not available";h.startsWith(e+": "+d)&&(f=h.split("\n"),f.shift(),h=f.join("\n"));f=g.lineNumber||"Not available";g=g.fileName||"Not available";var k=0;if(a.hasOwnProperty("args")&&a.args&&a.args.length)for(var l=0;l<a.args.length&&!(k=Ik(a.args[l],"params."+l,c,k),500<=k);l++);else if(a.hasOwnProperty("params")&&a.params){var p=
a.params;if("object"===typeof a.params)for(l in p){if(p[l]){var n="params."+l,t=Kk(p[l]);c[n]=t;k+=n.length+t.length;if(500<k)break}}else c.params=Kk(p)}if(Pk.length)for(l=0;l<Pk.length&&!(k=Ik(Pk[l],"params.context."+l,c,k),500<=k);l++);navigator.vendor&&!c.hasOwnProperty("vendor")&&(c["device.vendor"]=navigator.vendor);l={message:d,name:e,lineNumber:f,fileName:g,stack:h,params:c,sampleWeight:1};c=Number(a.columnNumber);isNaN(c)||(l.lineNumber=l.lineNumber+":"+c);if("IGNORED"===a.level)a=0;else a:{a=
Ek();c=u(a.S);for(d=c.next();!d.done;d=c.next())if(d=d.value,l.message&&l.message.match(d.Tk)){a=d.weight;break a}a=u(a.R);for(c=a.next();!c.done;c=a.next())if(c=c.value,c.Ca(l)){a=c.weight;break a}a=1}l.sampleWeight=a;a=u(zk);for(c=a.next();!c.done;c=a.next())if(c=c.value,c.ya[l.name])for(e=u(c.ya[l.name]),d=e.next();!d.done;d=e.next())if(f=d.value,d=l.message.match(f.regexp)){l.params["params.error.original"]=d[0];e=f.groups;f={};for(g=0;g<e.length;g++)f[e[g]]=d[g+1],l.params["params.error."+e[g]]=
d[g+1];l.message=c.Ia(f);break}l.params||(l.params={});a=Ek();l.params["params.errorServiceSignature"]="msg="+a.S.length+"&cb="+a.R.length;l.params["params.serviceWorker"]="false";y.document&&y.document.querySelectorAll&&(l.params["params.fscripts"]=String(document.querySelectorAll("script:not([nonce])").length));window.yterr&&"function"===typeof window.yterr&&window.yterr(l);if(0!==l.sampleWeight&&!Lk.has(l.message)){"ERROR"===b?(Fk.W("handleError",l),O("record_app_crashed_web")&&0===Ok&&1===l.sampleWeight&&
(Ok++,yk("appCrashed",{appCrashType:"APP_CRASH_TYPE_BREAKPAD"})),Nk++):"WARNING"===b&&Fk.W("handleWarning",l);if(O("kevlar_gel_error_routing")){a=b;b:{c=u(Qk);for(d=c.next();!d.done;d=c.next())if(Fg(d.value.toLowerCase())){c=!0;break b}c=!1}if(c)c=void 0;else{d={stackTrace:l.stack};l.fileName&&(d.filename=l.fileName);c=l.lineNumber&&l.lineNumber.split?l.lineNumber.split(":"):[];0!==c.length&&(1!==c.length||isNaN(Number(c[0]))?2!==c.length||isNaN(Number(c[0]))||isNaN(Number(c[1]))||(d.lineNumber=Number(c[0]),
d.columnNumber=Number(c[1])):d.lineNumber=Number(c[0]));c={level:"ERROR_LEVEL_UNKNOWN",message:l.message,errorClassName:l.name,sampleWeight:l.sampleWeight};"ERROR"===a?c.level="ERROR_LEVEL_ERROR":"WARNING"===a&&(c.level="ERROR_LEVEL_WARNNING");d={isObfuscated:!0,browserStackInfo:d};e={pageUrl:window.location.href,kvPairs:[]};E("FEXP_EXPERIMENTS")&&(e.experimentIds=E("FEXP_EXPERIMENTS"));if(f=l.params)for(g=u(Object.keys(f)),h=g.next();!h.done;h=g.next())h=h.value,e.kvPairs.push({key:"client."+h,value:String(f[h])});
f=E("SERVER_NAME",void 0);g=E("SERVER_VERSION",void 0);f&&g&&(e.kvPairs.push({key:"server.name",value:f}),e.kvPairs.push({key:"server.version",value:g}));c={errorMetadata:e,stackTrace:d,logMessage:c}}c&&(yk("clientError",c),("ERROR"===a||O("errors_flush_gel_always_killswitch"))&&jh())}if(!O("suppress_error_204_logging")){a=l.params||{};b={urlParams:{a:"logerror",t:"jserror",type:l.name,msg:l.message.substr(0,250),line:l.lineNumber,level:b,"client.name":a.name},postParams:{url:E("PAGE_NAME",window.location.href),
file:l.fileName},method:"POST"};a.version&&(b["client.version"]=a.version);if(b.postParams){l.stack&&(b.postParams.stack=l.stack);c=u(Object.keys(a));for(d=c.next();!d.done;d=c.next())d=d.value,b.postParams["client."+d]=a[d];if(a=E("LATEST_ECATCHER_SERVICE_TRACKING_PARAMS",void 0))for(c=u(Object.keys(a)),d=c.next();!d.done;d=c.next())d=d.value,b.postParams[d]=a[d];a=E("SERVER_NAME",void 0);c=E("SERVER_VERSION",void 0);a&&c&&(b.postParams["server.name"]=a,b.postParams["server.version"]=c)}wg(E("ECATCHER_REPORT_HOST",
"")+"/error_204",b)}Lk.add(l.message);Mk++}}}
function Tk(a,b){for(var c=[],d=1;d<arguments.length;++d)c[d-1]=arguments[d];a.args||(a.args=[]);a.args.push.apply(a.args,c instanceof Array?c:fa(u(c)))}
;var Uk={hc:3611,wb:27686,xb:85013,yb:23462,Ab:42016,Bb:62407,Cb:26926,zb:43781,Db:51236,Eb:79148,Fb:50160,Gb:77504,Sb:87907,Tb:18630,Ub:54445,Vb:80935,Wb:105675,Xb:37521,Yb:47786,Zb:98349,ac:123695,cc:6827,dc:29434,ec:7282,fc:124448,kc:32276,jc:76278,lc:93911,mc:106531,nc:27259,oc:27262,pc:27263,sc:21759,tc:27107,uc:62936,wc:49568,xc:38408,yc:80637,zc:68727,Ac:68728,Bc:80353,Cc:80356,Dc:74610,Ec:45707,Fc:83962,Gc:83970,Hc:46713,Ic:89711,Jc:74612,Kc:93265,Lc:74611,Nc:113533,Oc:93252,Pc:99357,Rc:94521,
Sc:114252,Tc:113532,Uc:94522,Qc:94583,Vc:88E3,Wc:93253,Xc:93254,Yc:94387,Zc:94388,bd:93255,cd:97424,Mc:72502,dd:110111,ed:76019,gd:117092,hd:117093,fd:89431,jd:110466,kd:77240,ld:60508,md:105350,nd:73393,od:113534,pd:92098,qd:84517,rd:83759,sd:80357,td:86113,ud:72598,vd:72733,wd:107349,xd:124275,yd:118203,zd:117431,Ad:117429,Bd:117430,Cd:117432,Dd:120080,Ed:117259,Fd:121692,Gd:97615,Hd:31402,Id:84774,Jd:95117,Kd:98930,Ld:98931,Md:98932,Nd:43347,Od:45474,Pd:100352,Qd:84758,Rd:98443,Sd:117985,Td:74613,
Ud:74614,Vd:64502,Wd:74615,Xd:74616,Yd:122224,Zd:74617,ae:77820,be:74618,ce:93278,de:93274,ee:93275,ge:93276,he:22110,ie:29433,ke:120541,me:82047,ne:113550,oe:75836,pe:75837,qe:42352,re:84512,se:76065,te:75989,ue:16623,we:32594,xe:27240,ye:32633,ze:74858,Be:3945,Ae:16989,Ce:45520,De:25488,Ee:25492,Fe:25494,Ge:55760,He:14057,Ie:18451,Je:57204,Ke:57203,Le:17897,Me:57205,Ne:18198,Oe:17898,Pe:17909,Qe:43980,Re:46220,Se:11721,Te:49954,Ue:96369,Ve:3854,We:56251,Xe:25624,Ye:16906,Ze:99999,af:68172,bf:27068,
cf:47973,df:72773,ef:26970,ff:26971,gf:96805,hf:17752,jf:73233,kf:109512,lf:22256,mf:14115,nf:22696,pf:89278,qf:89277,rf:109513,sf:43278,tf:43459,uf:43464,vf:89279,wf:43717,xf:55764,yf:22255,zf:89281,Af:40963,Bf:43277,Cf:43442,Df:91824,Ef:120137,Ff:96367,Gf:36850,Hf:72694,If:37414,Jf:36851,Lf:124863,Kf:121343,Mf:73491,Nf:54473,Of:43375,Pf:46674,Qf:32473,Rf:72901,Sf:72906,Tf:50947,Uf:50612,Vf:50613,Wf:50942,Xf:84938,Yf:84943,Zf:84939,ag:84941,cg:84944,dg:84940,eg:84942,fg:35585,gg:51926,hg:79983,ig:63238,
jg:18921,kg:63241,lg:57893,mg:41182,ng:33424,og:22207,pg:42993,qg:36229,rg:22206,sg:22205,tg:18993,ug:19001,vg:18990,wg:18991,xg:18997,yg:18725,zg:19003,Ag:36874,Bg:44763,Cg:33427,Dg:67793,Eg:22182,Fg:37091,Gg:34650,Hg:50617,Ig:47261,Jg:22287,Kg:25144,Lg:97917,Mg:62397,Ng:125598,Og:36961,Pg:108035,Qg:27426,Rg:27857,Sg:27846,Tg:27854,Ug:69692,Vg:61411,Wg:39299,Xg:38696,Yg:62520,Zg:36382,ah:108701,bh:50663,dh:36387,eh:14908,fh:37533,gh:105443,hh:61635,ih:62274,jh:65702,kh:65703,lh:65701,mh:76256,nh:37671,
oh:49953,qh:36216,rh:28237,sh:39553,th:29222,uh:26107,vh:38050,wh:26108,yh:120745,xh:26109,zh:26110,Ah:66881,Bh:28236,Ch:14586,Dh:57929,Eh:74723,Fh:44098,Gh:44099,Hh:23528,Ih:61699,Jh:59149,Kh:101951,Lh:97346,Mh:118051,Nh:95102,Oh:64882,Ph:119505,Qh:63595,Rh:63349,Sh:95101,Th:75240,Uh:27039,Vh:68823,Wh:21537,Xh:83464,Yh:75707,Zh:83113,ai:101952,bi:101953,di:79610,fi:24402,gi:24400,hi:32925,ii:57173,ji:122502,ki:64423,li:64424,mi:33986,ni:100828,oi:21409,ri:11070,si:11074,ti:17880,vi:14001,xi:30709,
yi:30707,zi:30711,Ai:30710,Bi:30708,wi:26984,Ci:63648,Di:63649,Ei:51879,Fi:111059,Gi:5754,Hi:20445,Ii:110386,Ji:113746,Ki:66557,Li:17310,Mi:28631,Ni:21589,Oi:68012,Pi:60480,Qi:31571,Ri:76980,Si:41577,Ti:45469,Ui:38669,Vi:13768,Wi:13777,Xi:62985,Yi:4724,Zi:59369,aj:43927,bj:43928,cj:12924,dj:100355,gj:56219,hj:27669,ij:10337,fj:47896,jj:122629,kj:121258,lj:107598,mj:96639,nj:107536,oj:96661,pj:96658,qj:116646,rj:121122,sj:96660,tj:104443,uj:96659,vj:106442,wj:63667,xj:63668,yj:63669,zj:78314,Aj:55761,
Bj:96368,Cj:67374,Dj:48992,Ej:49956,Fj:31961,Gj:26388,Hj:23811,Ij:5E4,Jj:126250,Kj:96370,Lj:47355,Mj:47356,Nj:37935,Oj:45521,Pj:21760,Qj:83769,Rj:49977,Sj:49974,Tj:93497,Uj:93498,Vj:34325,Wj:115803,Xj:123707,Yj:100081,Zj:35309,ak:68314,bk:25602,ck:100339,dk:59018,ek:18248,fk:50625,gk:9729,hk:37168,ik:37169,jk:21667,kk:16749,lk:18635,mk:39305,nk:18046,pk:53969,qk:8213,rk:93926,sk:102852,tk:110099,uk:22678,vk:69076,xk:100856,yk:17736,zk:3832,Ak:55759,Bk:64031,Ck:93044,Dk:93045,Ek:34388,Fk:17657,Gk:17655,
Hk:39579,Ik:39578,Jk:77448,Kk:8196,Lk:11357,Mk:69877,Nk:8197,Ok:82039};function Vk(){var a=kb(Wk),b;return Le(new Ee(function(c,d){a.onSuccess=function(e){qg(e)?c(new Xk(e)):d(new Yk("Request failed, status="+(e&&"status"in e?e.status:-1),"net.badstatus",e))};
a.onError=function(e){d(new Yk("Unknown request error","net.unknown",e))};
a.onTimeout=function(e){d(new Yk("Request timed out","net.timeout",e))};
b=wg("//googleads.g.doubleclick.net/pagead/id",a)}),function(c){c instanceof Me&&b.abort();
return Je(c)})}
function Yk(a,b,c){Sa.call(this,a+", errorCode="+b);this.errorCode=b;this.xhr=c;this.name="PromiseAjaxError"}
v(Yk,Sa);function Xk(a){this.xhr=a}
;function Zk(){this.i=0;this.h=null}
Zk.prototype.then=function(a,b,c){return 1===this.i&&a?(a=a.call(c,this.h),De(a)?a:$k(a)):2===this.i&&b?(a=b.call(c,this.h),De(a)?a:al(a)):this};
Zk.prototype.getValue=function(){return this.h};
Zk.prototype.$goog_Thenable=!0;function al(a){var b=new Zk;a=void 0===a?null:a;b.i=2;b.h=void 0===a?null:a;return b}
function $k(a){var b=new Zk;a=void 0===a?null:a;b.i=1;b.h=void 0===a?null:a;return b}
;function bl(a){Sa.call(this,a.message||a.description||a.name);this.isMissing=a instanceof cl;this.isTimeout=a instanceof Yk&&"net.timeout"==a.errorCode;this.isCanceled=a instanceof Me}
v(bl,Sa);bl.prototype.name="BiscottiError";function cl(){Sa.call(this,"Biscotti ID is missing from server")}
v(cl,Sa);cl.prototype.name="BiscottiMissingError";var Wk={format:"RAW",method:"GET",timeout:5E3,withCredentials:!0},dl=null;function ag(){if(O("condition_biscotti_fetch_on_consent_cookie_html5_clients")&&!cd.get("CONSENT","").startsWith("YES+"))return Je(Error("User has not consented - not fetching biscotti id."));if("1"==ib())return Je(Error("Biscotti ID is not available in private embed mode"));dl||(dl=Le(Vk().then(el),function(a){return fl(2,a)}));
return dl}
function el(a){a=a.xhr.responseText;if(0!=a.lastIndexOf(")]}'",0))throw new cl;a=JSON.parse(a.substr(4));if(1<(a.type||1))throw new cl;a=a.id;bg(a);dl=$k(a);gl(18E5,2);return a}
function fl(a,b){b=new bl(b);bg("");dl=al(b);0<a&&gl(12E4,a-1);throw b;}
function gl(a,b){Mf(function(){Le(Vk().then(el,function(c){return fl(b,c)}),Ea)},a)}
function hl(){try{var a=A("yt.ads.biscotti.getId_");return a?a():ag()}catch(b){return Je(b)}}
;function il(a){if("1"!=ib()){a&&$f();try{hl().then(function(){},function(){}),Mf(il,18E5)}catch(b){vf(b)}}}
;var jl=Date.now().toString();
function kl(){a:{if(window.crypto&&window.crypto.getRandomValues)try{var a=Array(16),b=new Uint8Array(16);window.crypto.getRandomValues(b);for(var c=0;c<a.length;c++)a[c]=b[c];var d=a;break a}catch(e){}d=Array(16);for(a=0;16>a;a++){b=Date.now();for(c=0;c<b%23;c++)d[a]=Math.random();d[a]=Math.floor(256*Math.random())}if(jl)for(a=1,b=0;b<jl.length;b++)d[a%16]=d[a%16]^d[(a-1)%16]/4^jl.charCodeAt(b),a++}a=[];for(b=0;b<d.length;b++)a.push("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_".charAt(d[b]&63));
return a.join("")}
;var ll,ml=y.ytLoggingDocDocumentNonce_;ml||(ml=kl(),Qa("ytLoggingDocDocumentNonce_",ml));ll=ml;var nl={je:0,ic:1,qc:2,ph:3,le:4,wk:5,ci:6,ej:7,0:"DEFAULT",1:"CHAT",2:"CONVERSATIONS",3:"MINIPLAYER",4:"DIALOG",5:"VOZ",6:"MUSIC_WATCH_TABS",7:"SHARE"};function ol(a){this.h=a}
function pl(a){return new ol({trackingParams:a})}
ol.prototype.getAsJson=function(){var a={};void 0!==this.h.trackingParams?a.trackingParams=this.h.trackingParams:(a.veType=this.h.veType,void 0!==this.h.veCounter&&(a.veCounter=this.h.veCounter),void 0!==this.h.elementIndex&&(a.elementIndex=this.h.elementIndex));void 0!==this.h.dataElement&&(a.dataElement=this.h.dataElement.getAsJson());void 0!==this.h.youtubeData&&(a.youtubeData=this.h.youtubeData);return a};
ol.prototype.toString=function(){return JSON.stringify(this.getAsJson())};
ol.prototype.isClientVe=function(){return!this.h.trackingParams&&!!this.h.veType};function ql(a){a=void 0===a?0:a;return 0==a?"client-screen-nonce":"client-screen-nonce."+a}
function rl(a){a=void 0===a?0:a;return 0==a?"ROOT_VE_TYPE":"ROOT_VE_TYPE."+a}
function sl(a){return E(rl(void 0===a?0:a),void 0)}
z("yt_logging_screen.getRootVeType",sl,void 0);function tl(a){return(a=sl(void 0===a?0:a))?new ol({veType:a,youtubeData:void 0}):null}
function ul(){var a=E("csn-to-ctt-auth-info");a||(a={},M("csn-to-ctt-auth-info",a));return a}
function vl(a){a=void 0===a?0:a;var b=E(ql(a));if(!b&&!E("USE_CSN_FALLBACK",!0))return null;b||0!=a||(b="UNDEFINED_CSN");return b?b:null}
z("yt_logging_screen.getCurrentCsn",vl,void 0);function wl(a,b,c){var d=ul();(c=vl(c))&&delete d[c];b&&(d[a]=b)}
function xl(a){return ul()[a]}
z("yt_logging_screen.getCttAuthInfo",xl,void 0);function yl(a,b,c,d){c=void 0===c?0:c;if(a!==E(ql(c))||b!==E(rl(c)))wl(a,d,c),M(ql(c),a),M(rl(c),b),b=function(){setTimeout(function(){a&&th("foregroundHeartbeatScreenAssociated",{clientDocumentNonce:ll,clientScreenNonce:a},xk)},0)},"requestAnimationFrame"in window?window.requestAnimationFrame(b):b()}
z("yt_logging_screen.setCurrentScreen",yl,void 0);function zl(a){Nh.call(this,1,arguments);this.csn=a}
v(zl,Nh);var Wh=new Oh("screen-created",zl),Al=[],Cl=Bl,Dl=0;function El(a,b,c,d){var e=d.filter(function(f){f.csn!==b?(f.csn=b,f=!0):f=!1;return f});
c={csn:b,parentVe:c.getAsJson(),childVes:Ya(e,function(f){return f.getAsJson()})};
d=u(d);for(e=d.next();!e.done;e=d.next())e=e.value.getAsJson(),(gb(e)||!e.trackingParams&&!e.veType)&&Rk(Error("Child VE logged with no data"));d={G:xl(b),U:b};"UNDEFINED_CSN"==b?Fl("visualElementAttached",c,d):a?th("visualElementAttached",c,a,d):yk("visualElementAttached",c,d)}
function Bl(){for(var a=Math.random()+"",b=[],c=0,d=0;d<a.length;d++){var e=a.charCodeAt(d);255<e&&(b[c++]=e&255,e>>=8);b[c++]=e}return Bc(b)}
function Fl(a,b,c){Al.push({payloadName:a,payload:b,options:c});Dl||(Dl=Xh())}
function Yh(a){if(Al){for(var b=u(Al),c=b.next();!c.done;c=b.next())c=c.value,c.payload&&(c.payload.csn=a.csn,th(c.payloadName,c.payload,null,c.options));Al.length=0}Dl=0}
;function Gl(){this.i=new Set;this.h=new Set;this.j=new Map}
Gl.prototype.clear=function(){this.i.clear();this.h.clear();this.j.clear()};
Fa(Gl);function Hl(a,b){for(var c=[],d=1;d<arguments.length;++d)c[d-1]=arguments[d];if(!Il(a)||c.some(function(e){return!Il(e)}))throw Error("Only objects may be merged.");
c=u(c);for(d=c.next();!d.done;d=c.next())Jl(a,d.value);return a}
function Jl(a,b){for(var c in b)if(Il(b[c])){if(c in a&&!Il(a[c]))throw Error("Cannot merge an object into a non-object.");c in a||(a[c]={});Jl(a[c],b[c])}else if(Kl(b[c])){if(c in a&&!Kl(a[c]))throw Error("Cannot merge an array into a non-array.");c in a||(a[c]=[]);Ll(a[c],b[c])}else a[c]=b[c];return a}
function Ll(a,b){b=u(b);for(var c=b.next();!c.done;c=b.next())c=c.value,Il(c)?a.push(Jl({},c)):Kl(c)?a.push(Ll([],c)):a.push(c);return a}
function Il(a){return"object"===typeof a&&!Array.isArray(a)}
function Kl(a){return"object"===typeof a&&Array.isArray(a)}
;function Ml(a,b){Nh.call(this,1,arguments)}
v(Ml,Nh);function Nl(a,b){Nh.call(this,1,arguments)}
v(Nl,Nh);var Ol=new Oh("aft-recorded",Ml),Pl=new Oh("timing-sent",Nl);var Ql=window;function Rl(){this.timing={};this.clearResourceTimings=function(){};
this.webkitClearResourceTimings=function(){};
this.mozClearResourceTimings=function(){};
this.msClearResourceTimings=function(){};
this.oClearResourceTimings=function(){}}
var U=Ql.performance||Ql.mozPerformance||Ql.msPerformance||Ql.webkitPerformance||new Rl;var Sl=!1,Tl={'script[name="scheduler/scheduler"]':"sj",'script[name="player/base"]':"pj",'link[rel="stylesheet"][name="www-player"]':"pc",'link[rel="stylesheet"][name="player/www-player"]':"pc",'script[name="desktop_polymer/desktop_polymer"]':"dpj",'link[rel="import"][name="desktop_polymer"]':"dph",'script[name="mobile-c3/mobile-c3"]':"mcj",'link[rel="stylesheet"][name="mobile-c3"]':"mcc",'script[name="player-plasma-ias-phone/base"]':"mcppj",'script[name="player-plasma-ias-tablet/base"]':"mcptj",
'link[rel="stylesheet"][name="mobile-polymer-player-ias"]':"mcpc",'link[rel="stylesheet"][name="mobile-polymer-player-svg-ias"]':"mcpsc",'script[name="mobile_blazer_core_mod"]':"mbcj",'link[rel="stylesheet"][name="mobile_blazer_css"]':"mbc",'script[name="mobile_blazer_logged_in_users_mod"]':"mbliuj",'script[name="mobile_blazer_logged_out_users_mod"]':"mblouj",'script[name="mobile_blazer_noncore_mod"]':"mbnj","#player_css":"mbpc",'script[name="mobile_blazer_desktopplayer_mod"]':"mbpj",'link[rel="stylesheet"][name="mobile_blazer_tablet_css"]':"mbtc",
'script[name="mobile_blazer_watch_mod"]':"mbwj"};Oa(U.clearResourceTimings||U.webkitClearResourceTimings||U.mozClearResourceTimings||U.msClearResourceTimings||U.oClearResourceTimings||Ea,U);function Ul(a){var b=Vl(a);if(b.aft)return b.aft;a=E((a||"")+"TIMING_AFT_KEYS",["ol"]);for(var c=a.length,d=0;d<c;d++){var e=b[a[d]];if(e)return e}return NaN}
function Wl(){var a;if(O("csi_use_performance_navigation_timing")){var b,c,d,e=null===(d=null===(c=null===(b=null===(a=null===U||void 0===U?void 0:U.getEntriesByType)||void 0===a?void 0:a.call(U,"navigation"))||void 0===b?void 0:b[0])||void 0===c?void 0:c.toJSON)||void 0===d?void 0:d.call(c);e?(e.requestStart=Xl(e.requestStart),e.responseEnd=Xl(e.responseEnd),e.redirectStart=Xl(e.redirectStart),e.redirectEnd=Xl(e.redirectEnd),e.domainLookupEnd=Xl(e.domainLookupEnd),e.connectStart=Xl(e.connectStart),
e.connectEnd=Xl(e.connectEnd),e.responseStart=Xl(e.responseStart),e.secureConnectionStart=Xl(e.secureConnectionStart),e.domainLookupStart=Xl(e.domainLookupStart),e.isPerformanceNavigationTiming=!0,a=e):a=U.timing}else a=U.timing;return a}
function Yl(){return O("csi_use_time_origin")&&U.timeOrigin?Math.floor(U.timeOrigin):U.timing.navigationStart}
function Xl(a){return Math.round(Yl()+a)}
function Zl(a){var b;(b=A("ytcsi."+(a||"")+"data_"))||(b={tick:{},info:{}},Qa("ytcsi."+(a||"")+"data_",b));return b}
function $l(a){a=Zl(a);a.info||(a.info={});return a.info}
function Vl(a){a=Zl(a);a.tick||(a.tick={});return a.tick}
function am(a){var b=Zl(a).nonce;b||(b=kl(),Zl(a).nonce=b);return b}
function bm(a){var b=Vl(a||""),c=Ul(a);c&&!Sl&&(Th(Ol,new Ml(Math.round(c-b._start),a)),Sl=!0)}
;function cm(){if(U.getEntriesByType){var a=U.getEntriesByType("paint");if(a=$a(a,function(b){return"first-paint"===b.name}))return Xl(a.startTime)}a=U.timing;
return a.hb?Math.max(0,a.hb):0}
;function dm(){var a=A("ytcsi.debug");a||(a=[],z("ytcsi.debug",a,void 0),z("ytcsi.reference",{},void 0));return a}
function em(a){a=a||"";var b=A("ytcsi.reference");b||(dm(),b=A("ytcsi.reference"));if(b[a])return b[a];var c=dm(),d={timerName:a,info:{},tick:{},span:{}};c.push(d);return b[a]=d}
;var fm=y.ytLoggingLatencyUsageStats_||{};z("ytLoggingLatencyUsageStats_",fm,void 0);function gm(){this.h=0}
function hm(){gm.h||(gm.h=new gm);return gm.h}
gm.prototype.tick=function(a,b,c){im(this,"tick_"+a+"_"+b)||yk("latencyActionTicked",{tickName:a,clientActionNonce:b},{timestamp:c})};
gm.prototype.info=function(a,b){var c=Object.keys(a).join("");im(this,"info_"+c+"_"+b)||(a=Object.assign({},a),a.clientActionNonce=b,yk("latencyActionInfo",a))};
gm.prototype.span=function(a,b){var c=Object.keys(a).join("");im(this,"span_"+c+"_"+b)||(a.clientActionNonce=b,yk("latencyActionSpan",a))};
function im(a,b){fm[b]=fm[b]||{count:0};var c=fm[b];c.count++;c.time=P();a.h||(a.h=Qf(function(){var d=P(),e;for(e in fm)fm[e]&&6E4<d-fm[e].time&&delete fm[e];a&&(a.h=0)},5E3));
return 5<c.count?(6===c.count&&1>1E5*Math.random()&&(c=new hi("CSI data exceeded logging limit with key",b.split("_")),0<=b.indexOf("plev")||Rk(c)),!0):!1}
;var V={},jm=(V.auto_search="LATENCY_ACTION_AUTO_SEARCH",V.ad_to_ad="LATENCY_ACTION_AD_TO_AD",V.ad_to_video="LATENCY_ACTION_AD_TO_VIDEO",V.app_startup="LATENCY_ACTION_APP_STARTUP",V["artist.analytics"]="LATENCY_ACTION_CREATOR_ARTIST_ANALYTICS",V["artist.events"]="LATENCY_ACTION_CREATOR_ARTIST_CONCERTS",V["artist.presskit"]="LATENCY_ACTION_CREATOR_ARTIST_PROFILE",V.browse="LATENCY_ACTION_BROWSE",V.channels="LATENCY_ACTION_CHANNELS",V.creator_channel_dashboard="LATENCY_ACTION_CREATOR_CHANNEL_DASHBOARD",
V["channel.analytics"]="LATENCY_ACTION_CREATOR_CHANNEL_ANALYTICS",V["channel.comments"]="LATENCY_ACTION_CREATOR_CHANNEL_COMMENTS",V["channel.content"]="LATENCY_ACTION_CREATOR_POST_LIST",V["channel.copyright"]="LATENCY_ACTION_CREATOR_CHANNEL_COPYRIGHT",V["channel.editing"]="LATENCY_ACTION_CREATOR_CHANNEL_EDITING",V["channel.monetization"]="LATENCY_ACTION_CREATOR_CHANNEL_MONETIZATION",V["channel.music"]="LATENCY_ACTION_CREATOR_CHANNEL_MUSIC",V["channel.translations"]="LATENCY_ACTION_CREATOR_CHANNEL_TRANSLATIONS",
V["channel.videos"]="LATENCY_ACTION_CREATOR_CHANNEL_VIDEOS",V["channel.live_streaming"]="LATENCY_ACTION_CREATOR_LIVE_STREAMING",V.chips="LATENCY_ACTION_CHIPS",V["dialog.copyright_strikes"]="LATENCY_ACTION_CREATOR_DIALOG_COPYRIGHT_STRIKES",V["dialog.uploads"]="LATENCY_ACTION_CREATOR_DIALOG_UPLOADS",V.embed="LATENCY_ACTION_EMBED",V.entity_key_serialization_perf="LATENCY_ACTION_ENTITY_KEY_SERIALIZATION_PERF",V.entity_key_deserialization_perf="LATENCY_ACTION_ENTITY_KEY_DESERIALIZATION_PERF",V.home="LATENCY_ACTION_HOME",
V.library="LATENCY_ACTION_LIBRARY",V.live="LATENCY_ACTION_LIVE",V.live_pagination="LATENCY_ACTION_LIVE_PAGINATION",V.onboarding="LATENCY_ACTION_KIDS_ONBOARDING",V.parent_profile_settings="LATENCY_ACTION_KIDS_PARENT_PROFILE_SETTINGS",V.parent_tools_collection="LATENCY_ACTION_PARENT_TOOLS_COLLECTION",V.parent_tools_dashboard="LATENCY_ACTION_PARENT_TOOLS_DASHBOARD",V.player_att="LATENCY_ACTION_PLAYER_ATTESTATION",V["post.comments"]="LATENCY_ACTION_CREATOR_POST_COMMENTS",V["post.edit"]="LATENCY_ACTION_CREATOR_POST_EDIT",
V.prebuffer="LATENCY_ACTION_PREBUFFER",V.prefetch="LATENCY_ACTION_PREFETCH",V.profile_settings="LATENCY_ACTION_KIDS_PROFILE_SETTINGS",V.profile_switcher="LATENCY_ACTION_KIDS_PROFILE_SWITCHER",V.reel_watch="LATENCY_ACTION_REEL_WATCH",V.results="LATENCY_ACTION_RESULTS",V.search_ui="LATENCY_ACTION_SEARCH_UI",V.search_suggest="LATENCY_ACTION_SUGGEST",V.search_zero_state="LATENCY_ACTION_SEARCH_ZERO_STATE",V.secret_code="LATENCY_ACTION_KIDS_SECRET_CODE",V.seek="LATENCY_ACTION_PLAYER_SEEK",V.settings="LATENCY_ACTION_SETTINGS",
V.tenx="LATENCY_ACTION_TENX",V.video_to_ad="LATENCY_ACTION_VIDEO_TO_AD",V.watch="LATENCY_ACTION_WATCH",V.watch_it_again="LATENCY_ACTION_KIDS_WATCH_IT_AGAIN",V["watch,watch7"]="LATENCY_ACTION_WATCH",V["watch,watch7_html5"]="LATENCY_ACTION_WATCH",V["watch,watch7ad"]="LATENCY_ACTION_WATCH",V["watch,watch7ad_html5"]="LATENCY_ACTION_WATCH",V.wn_comments="LATENCY_ACTION_LOAD_COMMENTS",V.ww_rqs="LATENCY_ACTION_WHO_IS_WATCHING",V["video.analytics"]="LATENCY_ACTION_CREATOR_VIDEO_ANALYTICS",V["video.comments"]=
"LATENCY_ACTION_CREATOR_VIDEO_COMMENTS",V["video.edit"]="LATENCY_ACTION_CREATOR_VIDEO_EDIT",V["video.translations"]="LATENCY_ACTION_CREATOR_VIDEO_TRANSLATIONS",V["video.video_editor"]="LATENCY_ACTION_CREATOR_VIDEO_VIDEO_EDITOR",V["video.video_editor_async"]="LATENCY_ACTION_CREATOR_VIDEO_VIDEO_EDITOR_ASYNC",V["video.monetization"]="LATENCY_ACTION_CREATOR_VIDEO_MONETIZATION",V.voice_assistant="LATENCY_ACTION_VOICE_ASSISTANT",V.cast_load_by_entity_to_watch="LATENCY_ACTION_CAST_LOAD_BY_ENTITY_TO_WATCH",
V.networkless_performance="LATENCY_ACTION_NETWORKLESS_PERFORMANCE",V),W={},km=(W.ad_allowed="adTypesAllowed",W.yt_abt="adBreakType",W.ad_cpn="adClientPlaybackNonce",W.ad_docid="adVideoId",W.yt_ad_an="adNetworks",W.ad_at="adType",W.aida="appInstallDataAgeMs",W.browse_id="browseId",W.p="httpProtocol",W.t="transportProtocol",W.cpn="clientPlaybackNonce",W.ccs="creatorInfo.creatorCanaryState",W.csn="clientScreenNonce",W.docid="videoId",W.GetHome_rid="requestIds",W.GetSearch_rid="requestIds",W.GetPlayer_rid=
"requestIds",W.GetWatchNext_rid="requestIds",W.GetBrowse_rid="requestIds",W.GetLibrary_rid="requestIds",W.is_continuation="isContinuation",W.is_nav="isNavigation",W.b_p="kabukiInfo.browseParams",W.is_prefetch="kabukiInfo.isPrefetch",W.is_secondary_nav="kabukiInfo.isSecondaryNav",W.prev_browse_id="kabukiInfo.prevBrowseId",W.query_source="kabukiInfo.querySource",W.voz_type="kabukiInfo.vozType",W.yt_lt="loadType",W.mver="creatorInfo.measurementVersion",W.yt_ad="isMonetized",W.nr="webInfo.navigationReason",
W.nrsu="navigationRequestedSameUrl",W.ncnp="webInfo.nonPreloadedNodeCount",W.pnt="performanceNavigationTiming",W.prt="playbackRequiresTap",W.plt="playerInfo.playbackType",W.pis="playerInfo.playerInitializedState",W.paused="playerInfo.isPausedOnLoad",W.yt_pt="playerType",W.fmt="playerInfo.itag",W.yt_pl="watchInfo.isPlaylist",W.yt_pre="playerInfo.preloadType",W.yt_ad_pr="prerollAllowed",W.pa="previousAction",W.yt_red="isRedSubscriber",W.rce="mwebInfo.responseContentEncoding",W.scrh="screenHeight",W.scrw=
"screenWidth",W.st="serverTimeMs",W.ssdm="shellStartupDurationMs",W.br_trs="tvInfo.bedrockTriggerState",W.kebqat="kabukiInfo.earlyBrowseRequestInfo.abandonmentType",W.kebqa="kabukiInfo.earlyBrowseRequestInfo.adopted",W.label="tvInfo.label",W.is_mdx="tvInfo.isMdx",W.preloaded="tvInfo.isPreloaded",W.upg_player_vis="playerInfo.visibilityState",W.query="unpluggedInfo.query",W.upg_chip_ids_string="unpluggedInfo.upgChipIdsString",W.yt_vst="videoStreamType",W.vph="viewportHeight",W.vpw="viewportWidth",W.yt_vis=
"isVisible",W.rcl="mwebInfo.responseContentLength",W.GetSettings_rid="requestIds",W.GetTrending_rid="requestIds",W.GetMusicSearchSuggestions_rid="requestIds",W.REQUEST_ID="requestIds",W),lm="isContinuation isNavigation kabukiInfo.earlyBrowseRequestInfo.adopted kabukiInfo.isPrefetch kabukiInfo.isSecondaryNav isMonetized navigationRequestedSameUrl performanceNavigationTiming playerInfo.isPausedOnLoad prerollAllowed isRedSubscriber tvInfo.isMdx tvInfo.isPreloaded isVisible watchInfo.isPlaylist playbackRequiresTap".split(" "),
mm={},nm=(mm.ccs="CANARY_STATE_",mm.mver="MEASUREMENT_VERSION_",mm.pis="PLAYER_INITIALIZED_STATE_",mm.yt_pt="LATENCY_PLAYER_",mm.pa="LATENCY_ACTION_",mm.yt_vst="VIDEO_STREAM_TYPE_",mm),om="all_vc ap aq c cver cbrand cmodel cplatform ctheme ei l_an l_mm plid srt yt_fss yt_li vpst vpni2 vpil2 icrc icrt pa GetAccountOverview_rid GetHistory_rid cmt d_vpct d_vpnfi d_vpni nsru pc pfa pfeh pftr pnc prerender psc rc start tcrt tcrc ssr vpr vps yt_abt yt_fn yt_fs yt_pft yt_pre yt_pt yt_pvis ytu_pvis yt_ref yt_sts tds".split(" ");
function pm(a){return!!E("FORCE_CSI_ON_GEL",!1)||O("csi_on_gel")||!!Zl(a).useGel}
function qm(a,b,c){var d=rm(c);d.gelTicks&&(d.gelTicks["tick_"+a]=!0);c||b||P();return pm(c)?(em(c||"").tick[a]=b||P(),d=am(c),"_start"===a?(a=hm(),im(a,"baseline_"+d)||yk("latencyActionBaselined",{clientActionNonce:d},{timestamp:b})):hm().tick(a,d,b),bm(c),!0):!1}
function sm(a,b,c){c=rm(c);if(c.gelInfos)c.gelInfos["info_"+a]=!0;else{var d={};c.gelInfos=(d["info_"+a]=!0,d)}if(a.match("_rid")){var e=a.split("_rid")[0];a="REQUEST_ID"}if(a in km){c=km[a];0<=Wa(lm,c)&&(b=!!b);a in nm&&"string"===typeof b&&(b=nm[a]+b.toUpperCase());a=b;b=c.split(".");for(var f=d={},g=0;g<b.length-1;g++){var h=b[g];f[h]={};f=f[h]}f[b[b.length-1]]="requestIds"===c?[{id:a,endpoint:e}]:a;return Hl({},d)}0<=Wa(om,a)||Rk(new hi("Unknown label logged with GEL CSI",a))}
function rm(a){a=Zl(a);if(a.gel){var b=a.gel;b.gelInfos||(b.gelInfos={});b.gelTicks||(b.gelTicks={})}else a.gel={gelTicks:{},gelInfos:{}};return a.gel}
function tm(a){a=rm(a);a.gelInfos||(a.gelInfos={});return a.gelInfos}
;function um(a,b,c){null!==b&&($l(c)[a]=b,pm(c)?(a=sm(a,b,c))&&pm(c)&&(b=em(c||""),Hl(b.info,a),Hl(tm(c),a),c=am(c),hm().info(a,c)):em(c||"").info[a]=b)}
function Z(a,b,c){var d=Vl(c);if(!b&&"_"!==a[0]){var e=a;U.mark&&(0==e.lastIndexOf("mark_",0)||(e="mark_"+e),c&&(e+=" ("+c+")"),U.mark(e))}e=b||P();d[a]=e;qm(a,b,c)||(vm(c),em(c||"").tick[a]=b||P());return d[a]}
function wm(a,b){if(pm(void 0)){var c=rm(void 0);if(c.gelSpans)c.gelSpans[a]=!0;else{var d={};c.gelSpans=(d[a]=!0,d)}a={spanName:a,spanLengthUsec:String(Math.round(1E3*b))};em("").span[String(a.spanName)]=a;b=rm(void 0);b.gelSpans||(b.gelSpans={});Hl(b.gelSpans,a);b=am(void 0);hm().span(a,b)}}
function xm(){var a=am(void 0);requestAnimationFrame(function(){setTimeout(function(){a===am(void 0)&&Z("ol",void 0,void 0)},0)})}
function vm(a){if(!A("yt.timing."+(a||"")+"pingSent_")){var b=E((a||"")+"TIMING_ACTION",void 0),c=Vl(a);if(b=!!A("ytglobal.timing"+(a||"")+"ready_")&&b)b="_start"in Vl(void 0);if(b&&Ul(a))if(bm(a),a)ym(a);else{b=!0;var d=E("TIMING_WAIT",[]);if(d.length)for(var e=0,f=d.length;e<f;++e)if(!(d[e]in c)){b=!1;break}b&&ym(a)}}}
function zm(){var a=document;if("visibilityState"in a)a=a.visibilityState;else{var b=Cf+"VisibilityState";a=b in a?a[b]:void 0}switch(a){case "hidden":return 0;case "visible":return 1;case "prerender":return 2;case "unloaded":return 3;default:return-1}}
function ym(a){if(!pm(a)){var b=Vl(a),c=$l(a),d=b._start,e=E("CSI_SERVICE_NAME","youtube"),f={v:2,s:e,action:E((a||"")+"TIMING_ACTION",void 0)},g=c.srt;void 0!==b.srt&&delete c.srt;b.aft=Ul(a);var h=Vl(a),k=h.pbr,l=h.vc;h=h.pbs;k&&l&&h&&k<l&&l<h&&$l(a).yt_pvis&&"youtube"===e&&(um("yt_lt","hot_bg",a),e=b.vc,k=b.pbs,delete b.aft,c.aft=Math.round(k-e));for(var p in c)"_"!==p.charAt(0)&&(f[p]=c[p]);b.ps=P();p={};e=[];for(var n in b)"_"!==n.charAt(0)&&(k=Math.round(b[n]-d),p[n]=k,e.push(n+"."+k));f.rt=
e.join(",");b=!!c.ap;c="";for(var t in f)f.hasOwnProperty(t)&&(c+="&"+t+"="+f[t]);f="/csi_204?"+c.substring(1);window.navigator&&window.navigator.sendBeacon&&(b||O("always_send_csi_204_with_beacon"))?Lg(f):Ig(f);z("yt.timing."+(a||"")+"pingSent_",!0,void 0);Th(Pl,new Nl(p.aft+(Number(g)||0),a))}}
function Am(a,b){a=document.querySelector(a);if(!a)return!1;var c="",d=a.nodeName;"SCRIPT"===d?(c=a.src,c||(c=a.getAttribute("data-timing-href"))&&(c=window.location.protocol+c)):"LINK"===d&&(c=a.href);Wb()&&a.setAttribute("nonce",Wb());return c?(a=U.getEntriesByName(c))&&a[0]&&(a=a[0],c=Yl(),Z("rsf_"+b,c+Math.round(a.fetchStart)),Z("rse_"+b,c+Math.round(a.responseEnd)),void 0!==a.transferSize&&(b=$l(void 0),c=tm(void 0),"rc"in b||"rc"in c||um("rc",""),0===a.transferSize))?!0:!1:!1}
function Bm(){var a=window.location.protocol,b=U.getEntriesByType("resource");b=Xa(b,function(c){return 0===c.name.indexOf(a+"//fonts.gstatic.com/s/")});
(b=Za(b,function(c,d){return d.duration>c.duration?d:c},{duration:0}))&&0<b.startTime&&0<b.responseEnd&&(Z("wffs",Xl(b.startTime)),Z("wffe",Xl(b.responseEnd)))}
var Cm=window;Cm.ytcsi&&(Cm.ytcsi.info=um,Cm.ytcsi.tick=Z);function Dm(){this.l=[];this.u=[];this.h=[];this.i=new Set;this.m=new Map}
function Em(a,b,c){c=void 0===c?0:c;b.then(function(d){var e,f;a.i.has(c)&&a.j&&a.j();var g=vl(c),h=tl(c);g&&h&&(d.csn=g,(null===(e=d.response)||void 0===e?0:e.trackingParams)&&El(a.client,g,h,[pl(d.response.trackingParams)]),(null===(f=d.playerResponse)||void 0===f?0:f.trackingParams)&&El(a.client,g,h,[pl(d.playerResponse.trackingParams)]))})}
function Fm(a,b,c,d){d=void 0===d?0:d;if(a.i.has(d))a.l.push([b,c]);else{var e=vl(d);c=c||tl(d);e&&c&&El(a.client,e,c,[b])}}
Dm.prototype.clickCommand=function(a,b,c){c=vl(void 0===c?0:c);if(!a.clickTrackingParams||!c)return!1;var d=this.client;var e="INTERACTION_LOGGING_GESTURE_TYPE_GENERIC_CLICK";a={csn:c,ve:pl(a.clickTrackingParams).getAsJson(),gestureType:e};b&&(a.clientData=b);b={G:xl(c),U:c};"UNDEFINED_CSN"==c?Fl("visualElementGestured",a,b):d?th("visualElementGestured",a,d,b):yk("visualElementGestured",a,b);return!0};
function Gm(a,b,c){c=void 0===c?{}:c;a.i.add(c.layer||0);a.j=function(){Hm(a,b,c);var f=tl(c.layer);if(f){for(var g=u(a.l),h=g.next();!h.done;h=g.next())h=h.value,Fm(a,h[0],h[1]||f,c.layer);f=u(a.u);for(g=f.next();!g.done;g=f.next()){var k=g.value;g=void 0;g=void 0===g?0:g;h=vl(g);var l=k[0]||tl(g);h&&l&&(g=a.client,k=k[1],k={csn:h,ve:l.getAsJson(),clientData:k},l={G:xl(h),U:h},"UNDEFINED_CSN"==h?Fl("visualElementStateChanged",k,l):g?th("visualElementStateChanged",k,g,l):yk("visualElementStateChanged",
k,l))}}};
vl(c.layer)||a.j();if(c.Fa)for(var d=u(c.Fa),e=d.next();!e.done;e=d.next())Em(a,e.value,c.layer);else Sk(Error("Delayed screen needs a data promise."))}
function Hm(a,b,c){c=void 0===c?{}:c;c.layer||(c.layer=0);var d=void 0!==c.ib?c.ib:c.layer;var e=vl(d);d=tl(d);var f;d&&(void 0!==c.parentCsn?f={clientScreenNonce:c.parentCsn,visualElement:d}:e&&"UNDEFINED_CSN"!==e&&(f={clientScreenNonce:e,visualElement:d}));var g,h=E("EVENT_ID");O("screen_manager_log_servlet_ei")&&"UNDEFINED_CSN"===e&&h&&(g={servletData:{serializedServletEventId:h}});try{var k=a.client;h=f;var l=c.Ea,p=c.G,n=Cl(),t={csn:n,pageVe:(new ol({veType:b,youtubeData:g})).getAsJson()};h&&
h.visualElement?t.implicitGesture={parentCsn:h.clientScreenNonce,gesturedVe:h.visualElement.getAsJson()}:h&&Rk(new hi("newScreen() parent element does not have a VE - rootVe",b));l&&(t.cloneCsn=l);l={G:p,U:n};k?th("screenCreated",t,k,l):yk("screenCreated",t,l);Th(Wh,new zl(n));var q=n}catch(D){Tk(D,{Xk:b,rootVe:d,parentVisualElement:void 0,Sk:e,Wk:f,Ea:c.Ea});Sk(D);return}yl(q,b,c.layer,c.G);if((b=e&&"UNDEFINED_CSN"!==e&&d)&&!(b=O("screen_manager_skip_hide_killswitch"))){a:{b=u(Object.values(nl));
for(f=b.next();!f.done;f=b.next())if(vl(f.value)==e){b=!0;break a}b=!1}b=!b}b&&(b=a.client,f=!0,k=(f=void 0===f?!1:f)?16:8,d={csn:e,ve:d.getAsJson(),eventType:k},f={G:xl(e),U:e,Ta:f},"UNDEFINED_CSN"==e?Fl("visualElementHidden",d,f):b?th("visualElementHidden",d,b,f):yk("visualElementHidden",d,f));a.h[a.h.length-1]&&!a.h[a.h.length-1].csn&&(a.h[a.h.length-1].csn=q||"");um("csn",q);Gl.getInstance().clear();d=tl(c.layer);e&&"UNDEFINED_CSN"!==e&&d&&(O("web_mark_root_visible")||O("music_web_mark_root_visible"))&&
(e=q,q=O("use_default_events_client")?void 0:xk,b={csn:e,ve:d.getAsJson(),eventType:1},f={G:xl(e),U:e},"UNDEFINED_CSN"==e?Fl("visualElementShown",b,f):q?th("visualElementShown",b,q,f):yk("visualElementShown",b,f));a.i.delete(c.layer||0);a.j=void 0;e=u(a.m);for(q=e.next();!q.done;q=e.next())q=u(q.value),b=q.next().value,q.next().value.has(c.layer)&&d&&Fm(a,b,d,c.layer)}
;function Im(a){a&&(a.dataset?a.dataset[Jm("loaded")]="true":a.setAttribute("data-loaded","true"))}
function Km(a,b){return a?a.dataset?a.dataset[Jm(b)]:a.getAttribute("data-"+b):null}
var Lm={};function Jm(a){return Lm[a]||(Lm[a]=String(a).replace(/\-([a-z])/g,function(b,c){return c.toUpperCase()}))}
;var Mm=/\.vflset|-vfl[a-zA-Z0-9_+=-]+/,Nm=/-[a-zA-Z]{2,3}_[a-zA-Z]{2,3}(?=(\/|$))/;function Om(a,b,c){c=void 0===c?null:c;if(window.spf&&spf.script){c="";if(a){var d=a.indexOf("jsbin/"),e=a.lastIndexOf(".js"),f=d+6;-1<d&&-1<e&&e>f&&(c=a.substring(f,e),c=c.replace(Mm,""),c=c.replace(Nm,""),c=c.replace("debug-",""),c=c.replace("tracing-",""))}spf.script.load(a,c,b)}else Pm(a,b,c)}
function Pm(a,b,c){c=void 0===c?null:c;var d=Qm(a),e=document.getElementById(d),f=e&&Km(e,"loaded"),g=e&&!f;f?b&&b():(b&&(f=Qg(d,b),b=""+Ja(b),Rm[b]=f),g||(e=Sm(a,d,function(){Km(e,"loaded")||(Im(e),Tg(d),Mf(Pa(Ug,d),0))},c)))}
function Sm(a,b,c,d){d=void 0===d?null:d;var e=Jc(document,"SCRIPT");e.id=b;e.onload=function(){c&&setTimeout(c,0)};
e.onreadystatechange=function(){switch(e.readyState){case "loaded":case "complete":e.onload()}};
d&&e.setAttribute("nonce",d);Rc(e,Sc(a));a=document.getElementsByTagName("head")[0]||document.body;a.insertBefore(e,a.firstChild);return e}
function Tm(a){a=Qm(a);var b=document.getElementById(a);b&&(Ug(a),b.parentNode.removeChild(b))}
function Um(a,b){a&&b&&(a=""+Ja(b),(a=Rm[a])&&Sg(a))}
function Qm(a){var b=document.createElement("a");Tb(b,a);a=b.href.replace(/^[a-zA-Z]+:\/\//,"//");return"js-"+Zb(a)}
var Rm={};var Vm=[],Wm=!1;function Xm(){if((!O("condition_ad_status_fetch_on_consent_cookie_html5_clients")||cd.get("CONSENT","").startsWith("YES+"))&&"1"!=ib()){var a=function(){Wm=!0;"google_ad_status"in window?M("DCLKSTAT",1):M("DCLKSTAT",2)};
try{Om("//static.doubleclick.net/instream/ad_status.js",a)}catch(b){}Vm.push(Sf(function(){if(!(Wm||"google_ad_status"in window)){try{Um("//static.doubleclick.net/instream/ad_status.js",a)}catch(b){}Wm=!0;M("DCLKSTAT",3)}},5E3))}}
function Ym(){var a=Number(E("DCLKSTAT",0));return isNaN(a)?0:a}
;function Zm(){this.i=!1;this.h=null}
Zm.prototype.initialize=function(a,b,c,d){d=void 0===d?!1:d;var e,f;if(a.program){var g=null!==(e=a.interpreterScript)&&void 0!==e?e:null,h=null!==(f=a.interpreterUrl)&&void 0!==f?f:null;if(a.interpreterSafeScript){g=a.interpreterSafeScript.privateDoNotAccessOrElseSafeScriptWrappedValue||"";var k=pb();g=k?k.createScript(g):g;g=(new rb(g)).toString()}a.interpreterSafeUrl&&(h=vb(a.interpreterSafeUrl.privateDoNotAccessOrElseTrustedResourceUrlWrappedValue||"").toString());$m(this,g,h,a.program,b,c,d)}else Rk(Error("Cannot initialize botguard without program"))};
function $m(a,b,c,d,e,f,g){g=void 0===g?!1:g;c?(a.i=!0,Om(c,function(){a.i=!1;var h=0<=c.indexOf("/th/");(h?window.trayride:window.botguard)?an(a,d,!!g,h,e):(Tm(c),Rk(new hi("Unable to load Botguard","from "+c)))},f)):b&&(f=Jc(document,"SCRIPT"),f.textContent=b,f.nonce=Wb(),document.head.appendChild(f),document.head.removeChild(f),((b=b.includes("trayride"))?window.trayride:window.botguard)?an(a,d,!!g,b,e):Rk(Error("Unable to load Botguard from JS")))}
function an(a,b,c,d,e){var f,g;if(d=d?null===(f=window.trayride)||void 0===f?void 0:f.ad:null===(g=window.botguard)||void 0===g?void 0:g.bg)if(c)try{bn(a,new d(b,e?function(){return e(b)}:Ea))}catch(h){h instanceof Error&&Rk(h)}else{try{bn(a,new d(b))}catch(h){h instanceof Error&&Rk(h)}e&&e(b)}else Rk(Error("Failed to finish initializing VM"))}
Zm.prototype.invoke=function(a){a=void 0===a?{}:a;return this.h?this.h.hasOwnProperty("hot")?this.h.hot(void 0,void 0,a):this.h.invoke(void 0,void 0,a):null};
Zm.prototype.dispose=function(){this.h=null};
function bn(a,b){a.h=b}
;var cn=new Zm;function dn(){return!!cn.h}
function en(a){a=void 0===a?{}:a;return cn.invoke(a)}
;var fn=window,gn=/[A-Za-z]+\/[0-9.]+/g;function hn(a,b){if(a.replace(gn,"")!==b.replace(gn,""))return!1;a=a.match(gn);b=b.match(gn);if(a.length!==b.length)return!1;for(var c=0;c<a.length;c++){var d=a[c],e=b[c];if(!d.startsWith(e)&&!e.startsWith(d))return!1}return!0}
function jn(){var a=fn.uaChPolyfill.state;if(0===a.type)yk("clientHintsPolyfillEvent",{clientHintsSupported:!1});else{var b=navigator.userAgent,c=void 0!==a.syntheticUa&&hn(a.syntheticUa,b);yk("clientHintsPolyfillEvent",{clientHintsSupported:!0,uaAccessedBeforePolyfill:a.didAccessUaBeforePolyfillAvailable,syntheticUaMatches:c});c||(b={syntheticUa:a.syntheticUa,ua:b},b.brand=a.data.brands.map(function(d){return'"'+d.brand+'"; v="'+d.version+'"'}),b.mobileness=a.data.mobile,a=a.data.values,a.architecture&&
(b.platformArchitecture=a.architecture),a.model&&(b.model=a.model),a.platform&&(b.platformBrand=a.platform),a.platformVersion&&(b.platformVersion=a.platformVersion),a.uaFullVersion&&(b.fullVersion=a.uaFullVersion),yk("clientHintsPolyfillDiagnostics",b))}}
var kn=!1;function ln(){var a;1===(null===(a=fn.uaChPolyfill)||void 0===a?void 0:a.state.type)?kn||(fn.uaChPolyfill.onReady=ln,kn=!0):fn.uaChPolyfill&&jn()}
;function mn(a,b,c){J.call(this);var d=this;c=c||E("POST_MESSAGE_ORIGIN",void 0)||window.document.location.protocol+"//"+window.document.location.hostname;this.j=b||null;this.C="*";this.l=c;this.sessionId=null;this.channel="widget";this.F=!!a;this.B=function(e){a:if(!("*"!=d.l&&e.origin!=d.l||d.j&&e.source!=d.j||"string"!==typeof e.data)){try{var f=JSON.parse(e.data)}catch(g){break a}if(!(null==f||d.F&&(d.sessionId&&d.sessionId!=f.id||d.channel&&d.channel!=f.channel))&&f)switch(f.event){case "listening":"null"!=
e.origin&&(d.l=d.C=e.origin);d.j=e.source;d.sessionId=f.id;d.i&&(d.i(),d.i=null);break;case "command":d.m&&(!d.o||0<=Wa(d.o,f.func))&&d.m(f.func,f.args,e.origin)}}};
this.o=this.i=this.m=null;window.addEventListener("message",this.B)}
v(mn,J);mn.prototype.sendMessage=function(a,b){if(b=b||this.j){this.sessionId&&(a.id=this.sessionId);this.channel&&(a.channel=this.channel);try{var c=JSON.stringify(a);b.postMessage(c,this.C)}catch(d){wf(d)}}};
mn.prototype.D=function(){window.removeEventListener("message",this.B);J.prototype.D.call(this)};function nn(){this.i=[];this.isReady=!1;this.j={};var a=this.h=new mn(!!E("WIDGET_ID_ENFORCE")),b=this.kb.bind(this);a.m=b;a.o=null;this.h.channel="widget";if(a=E("WIDGET_ID"))this.h.sessionId=a}
m=nn.prototype;m.kb=function(a,b,c){"addEventListener"===a&&b?(a=b[0],this.j[a]||"onReady"===a||(this.addEventListener(a,on(this,a)),this.j[a]=!0)):this.Aa(a,b,c)};
m.Aa=function(){};
function on(a,b){return function(c){return a.sendMessage(b,c)}}
m.addEventListener=function(){};
m.Ua=function(){this.isReady=!0;this.sendMessage("initialDelivery",this.sa());this.sendMessage("onReady");C(this.i,this.Ma,this);this.i=[]};
m.sa=function(){return null};
function pn(a,b){a.sendMessage("infoDelivery",b)}
m.Ma=function(a){this.isReady?this.h.sendMessage(a):this.i.push(a)};
m.sendMessage=function(a,b){this.Ma({event:a,info:void 0===b?null:b})};
m.dispose=function(){this.h=null};function qn(a){return(0===a.search("cue")||0===a.search("load"))&&"loadModule"!==a}
function rn(a,b,c){if("string"===typeof a)return{videoId:a,startSeconds:b,suggestedQuality:c};b=["endSeconds","startSeconds","mediaContentUrl","suggestedQuality","videoId"];c={};for(var d=0;d<b.length;d++){var e=b[d];a[e]&&(c[e]=a[e])}return c}
function sn(a,b,c,d){if(Ia(a)&&!Array.isArray(a)){b="playlist list listType index startSeconds suggestedQuality".split(" ");c={};for(d=0;d<b.length;d++){var e=b[d];a[e]&&(c[e]=a[e])}return c}b={index:b,startSeconds:c,suggestedQuality:d};"string"===typeof a&&16===a.length?b.list="PL"+a:b.playlist=a;return b}
;function tn(a){nn.call(this);this.listeners=[];this.api=a;this.addEventListener("onReady",this.onReady.bind(this));this.addEventListener("onVideoProgress",this.qb.bind(this));this.addEventListener("onVolumeChange",this.rb.bind(this));this.addEventListener("onApiChange",this.lb.bind(this));this.addEventListener("onPlaybackQualityChange",this.nb.bind(this));this.addEventListener("onPlaybackRateChange",this.ob.bind(this));this.addEventListener("onStateChange",this.pb.bind(this));this.addEventListener("onWebglSettingsChanged",
this.sb.bind(this))}
v(tn,nn);m=tn.prototype;
m.Aa=function(a,b,c){if(this.api.isExternalMethodAvailable(a,c)){b=b||[];if(0<b.length&&qn(a)){var d=b;if(Ia(d[0])&&!Array.isArray(d[0]))var e=d[0];else switch(e={},a){case "loadVideoById":case "cueVideoById":e=rn(d[0],void 0!==d[1]?Number(d[1]):void 0,d[2]);break;case "loadVideoByUrl":case "cueVideoByUrl":e=d[0];"string"===typeof e&&(e={mediaContentUrl:e,startSeconds:void 0!==d[1]?Number(d[1]):void 0,suggestedQuality:d[2]});b:{if((d=e.mediaContentUrl)&&(d=/\/([ve]|embed)\/([^#?]+)/.exec(d))&&d[2]){d=
d[2];break b}d=null}e.videoId=d;e=rn(e);break;case "loadPlaylist":case "cuePlaylist":e=sn(d[0],d[1],d[2],d[3])}b.length=1;b[0]=e}this.api.handleExternalCall(a,b,c);qn(a)&&pn(this,this.sa())}};
m.onReady=function(){var a=this.Ua.bind(this);this.h.i=a};
m.addEventListener=function(a,b){this.listeners.push({eventType:a,listener:b});this.api.addEventListener(a,b)};
m.sa=function(){if(!this.api)return null;var a=this.api.getApiInterface();ab(a,"getVideoData");for(var b={apiInterface:a},c=0,d=a.length;c<d;c++){var e=a[c];if(0===e.search("get")||0===e.search("is")){var f=0;0===e.search("get")?f=3:0===e.search("is")&&(f=2);f=e.charAt(f).toLowerCase()+e.substr(f+1);try{var g=this.api[e]();b[f]=g}catch(h){}}}b.videoData=this.api.getVideoData();b.currentTimeLastUpdated_=Date.now()/1E3;return b};
m.pb=function(a){a={playerState:a,currentTime:this.api.getCurrentTime(),duration:this.api.getDuration(),videoData:this.api.getVideoData(),videoStartBytes:0,videoBytesTotal:this.api.getVideoBytesTotal(),videoLoadedFraction:this.api.getVideoLoadedFraction(),playbackQuality:this.api.getPlaybackQuality(),availableQualityLevels:this.api.getAvailableQualityLevels(),currentTimeLastUpdated_:Date.now()/1E3,playbackRate:this.api.getPlaybackRate(),mediaReferenceTime:this.api.getMediaReferenceTime()};this.api.getVideoUrl&&
(a.videoUrl=this.api.getVideoUrl());this.api.getVideoContentRect&&(a.videoContentRect=this.api.getVideoContentRect());this.api.getProgressState&&(a.progressState=this.api.getProgressState());this.api.getPlaylist&&(a.playlist=this.api.getPlaylist());this.api.getPlaylistIndex&&(a.playlistIndex=this.api.getPlaylistIndex());this.api.getStoryboardFormat&&(a.storyboardFormat=this.api.getStoryboardFormat());pn(this,a)};
m.nb=function(a){pn(this,{playbackQuality:a})};
m.ob=function(a){pn(this,{playbackRate:a})};
m.lb=function(){for(var a=this.api.getOptions(),b={namespaces:a},c=0,d=a.length;c<d;c++){var e=a[c],f=this.api.getOptions(e);b[e]={options:f};for(var g=0,h=f.length;g<h;g++){var k=f[g],l=this.api.getOption(e,k);b[e][k]=l}}this.sendMessage("apiInfoDelivery",b)};
m.rb=function(){pn(this,{muted:this.api.isMuted(),volume:this.api.getVolume()})};
m.qb=function(a){a={currentTime:a,videoBytesLoaded:this.api.getVideoBytesLoaded(),videoLoadedFraction:this.api.getVideoLoadedFraction(),currentTimeLastUpdated_:Date.now()/1E3,playbackRate:this.api.getPlaybackRate(),mediaReferenceTime:this.api.getMediaReferenceTime()};this.api.getProgressState&&(a.progressState=this.api.getProgressState());pn(this,a)};
m.sb=function(){var a={sphericalProperties:this.api.getSphericalProperties()};pn(this,a)};
m.dispose=function(){nn.prototype.dispose.call(this);for(var a=0;a<this.listeners.length;a++){var b=this.listeners[a];this.api.removeEventListener(b.eventType,b.listener)}this.listeners=[]};function un(a){J.call(this);this.i={};this.started=!1;this.connection=a;this.connection.subscribe("command",this.La,this)}
v(un,J);m=un.prototype;m.start=function(){this.started||this.h||(this.started=!0,this.connection.Z("RECEIVING"))};
m.Z=function(a,b){this.started&&!this.h&&this.connection.Z(a,b)};
m.La=function(a,b,c){if(this.started&&!this.h){var d=b||{};switch(a){case "addEventListener":"string"===typeof d.event&&this.addListener(d.event);break;case "removeEventListener":"string"===typeof d.event&&this.removeListener(d.event);break;default:this.api.isReady()&&this.api.isExternalMethodAvailable(a,c||null)&&(b=vn(a,b||{}),c=this.api.handleExternalCall(a,b,c||null),(c=wn(a,c))&&this.Z(a,c))}}};
m.addListener=function(a){if(!(a in this.i)){var b=this.mb.bind(this,a);this.i[a]=b;this.addEventListener(a,b)}};
m.mb=function(a,b){this.started&&!this.h&&this.connection.Z(a,this.ra(a,b))};
m.ra=function(a,b){if(null!=b)return{value:b}};
m.removeListener=function(a){a in this.i&&(this.removeEventListener(a,this.i[a]),delete this.i[a])};
m.D=function(){var a=this.connection;a.h||We(a.i,"command",this.La,this);this.connection=null;for(var b in this.i)this.i.hasOwnProperty(b)&&this.removeListener(b);J.prototype.D.call(this)};function xn(a,b){un.call(this,b);this.api=a;this.start()}
v(xn,un);xn.prototype.addEventListener=function(a,b){this.api.addEventListener(a,b)};
xn.prototype.removeEventListener=function(a,b){this.api.removeEventListener(a,b)};
function vn(a,b){switch(a){case "loadVideoById":return a=rn(b),[a];case "cueVideoById":return a=rn(b),[a];case "loadVideoByPlayerVars":return[b];case "cueVideoByPlayerVars":return[b];case "loadPlaylist":return a=sn(b),[a];case "cuePlaylist":return a=sn(b),[a];case "seekTo":return[b.seconds,b.allowSeekAhead];case "playVideoAt":return[b.index];case "setVolume":return[b.volume];case "setPlaybackQuality":return[b.suggestedQuality];case "setPlaybackRate":return[b.suggestedRate];case "setLoop":return[b.loopPlaylists];
case "setShuffle":return[b.shufflePlaylist];case "getOptions":return[b.module];case "getOption":return[b.module,b.option];case "setOption":return[b.module,b.option,b.value];case "handleGlobalKeyDown":return[b.keyCode,b.shiftKey,b.ctrlKey,b.altKey,b.metaKey,b.key,b.code]}return[]}
function wn(a,b){switch(a){case "isMuted":return{muted:b};case "getVolume":return{volume:b};case "getPlaybackRate":return{playbackRate:b};case "getAvailablePlaybackRates":return{availablePlaybackRates:b};case "getVideoLoadedFraction":return{videoLoadedFraction:b};case "getPlayerState":return{playerState:b};case "getCurrentTime":return{currentTime:b};case "getPlaybackQuality":return{playbackQuality:b};case "getAvailableQualityLevels":return{availableQualityLevels:b};case "getDuration":return{duration:b};
case "getVideoUrl":return{videoUrl:b};case "getVideoEmbedCode":return{videoEmbedCode:b};case "getPlaylist":return{playlist:b};case "getPlaylistIndex":return{playlistIndex:b};case "getOptions":return{options:b};case "getOption":return{option:b}}}
xn.prototype.ra=function(a,b){switch(a){case "onReady":return;case "onStateChange":return{playerState:b};case "onPlaybackQualityChange":return{playbackQuality:b};case "onPlaybackRateChange":return{playbackRate:b};case "onError":return{errorCode:b}}return un.prototype.ra.call(this,a,b)};
xn.prototype.D=function(){un.prototype.D.call(this);delete this.api};function yn(a){a=void 0===a?!1:a;J.call(this);this.i=new L(a);Gd(this,Pa(Ed,this.i))}
B(yn,J);yn.prototype.subscribe=function(a,b,c){return this.h?0:this.i.subscribe(a,b,c)};
yn.prototype.l=function(a,b){this.h||this.i.W.apply(this.i,arguments)};function zn(a,b,c){yn.call(this);this.j=a;this.destination=b;this.id=c}
v(zn,yn);zn.prototype.Z=function(a,b){this.h||this.j.Z(this.destination,this.id,a,b)};
zn.prototype.D=function(){this.destination=this.j=null;yn.prototype.D.call(this)};function An(a,b,c){J.call(this);this.destination=a;this.origin=c;this.i=Jf(window,"message",this.j.bind(this));this.connection=new zn(this,a,b);Gd(this,Pa(Ed,this.connection))}
v(An,J);An.prototype.Z=function(a,b,c,d){this.h||a!==this.destination||(a={id:b,command:c},d&&(a.data=d),this.destination.postMessage(xe(a),this.origin))};
An.prototype.j=function(a){var b;if(b=!this.h)if(b=a.origin===this.origin)a:{b=this.destination;do{b:{var c=a.source;do{if(c===b){c=!0;break b}if(c===c.parent)break;c=c.parent}while(null!=c);c=!1}if(c){b=!0;break a}b=b.opener}while(null!=b);b=!1}if(b&&(b=a.data,"string"===typeof b)){try{b=JSON.parse(b)}catch(d){return}b.command&&(c=this.connection,c.h||c.l("command",b.command,b.data,a.origin))}};
An.prototype.D=function(){Kf(this.i);this.destination=null;J.prototype.D.call(this)};function Bn(){J.call(this);this.i=[]}
v(Bn,J);Bn.prototype.D=function(){for(;this.i.length;){var a=this.i.pop();a.target.removeEventListener(a.name,a.Ca)}J.prototype.D.call(this)};function Cn(a){a=a||{};var b={},c={};this.url=a.url||"";this.args=a.args||kb(b);this.assets=a.assets||{};this.attrs=a.attrs||kb(c);this.fallback=a.fallback||null;this.fallbackMessage=a.fallbackMessage||null;this.html5=!!a.html5;this.disable=a.disable||{};this.loaded=!!a.loaded;this.messages=a.messages||{}}
Cn.prototype.clone=function(){var a=new Cn,b;for(b in this)if(this.hasOwnProperty(b)){var c=this[b];"object"==Ga(c)?a[b]=kb(c):a[b]=c}return a};var Dn=/cssbin\/(?:debug-)?([a-zA-Z0-9_-]+?)(?:-2x|-web|-rtl|-vfl|.css)/;function En(a){a=a||"";if(window.spf){var b=a.match(Dn);spf.style.load(a,b?b[1]:"",void 0)}else Fn(a)}
function Fn(a){var b=Gn(a),c=document.getElementById(b),d=c&&Km(c,"loaded");d||c&&!d||(c=Hn(a,b,function(){Km(c,"loaded")||(Im(c),Tg(b),Mf(Pa(Ug,b),0))}))}
function Hn(a,b,c){var d=document.createElement("link");d.id=b;d.onload=function(){c&&setTimeout(c,0)};
a=Sc(a);Ub(d,a);(document.getElementsByTagName("head")[0]||document.body).appendChild(d);return d}
function Gn(a){var b=Jc(document,"A");Tb(b,new Fb(a,Gb));a=b.href.replace(/^[a-zA-Z]+:\/\//,"//");return"css-"+Zb(a)}
;function In(a,b,c,d){J.call(this);var e=this;this.F=b;this.webPlayerContextConfig=d;this.na=!1;this.api={};this.ba=this.m=null;this.J=new L;this.i={};this.L=this.fa=this.elementId=this.oa=this.config=null;this.K=!1;this.l=this.B=null;this.ga={};this.Na=["onReady"];this.lastError=null;this.Ba=NaN;this.C={};this.Oa=new Bn(this);this.P=0;this.j=this.o=a;Gd(this,Pa(Ed,this.J));Jn(this);Kn(this);Gd(this,Pa(Ed,this.Oa));c?this.P=Mf(function(){e.loadNewVideoConfig(c)},0):d&&(Ln(this),Mn(this))}
v(In,J);m=In.prototype;m.getId=function(){return this.F};
m.loadNewVideoConfig=function(a){if(!this.h){this.P&&(Nf(this.P),this.P=0);var b=a||{};b instanceof Cn||(b=new Cn(b));this.config=b;this.setConfig(a);Mn(this);this.isReady()&&Nn(this)}};
function Ln(a){var b,c;a.webPlayerContextConfig?c=a.webPlayerContextConfig.rootElementId:c=a.config.attrs.id;a.elementId=c||a.elementId;"video-player"===a.elementId&&(a.elementId=a.F,a.webPlayerContextConfig?a.webPlayerContextConfig.rootElementId=a.F:a.config.attrs.id=a.F);(null===(b=a.j)||void 0===b?void 0:b.id)===a.elementId&&(a.elementId+="-player",a.webPlayerContextConfig?a.webPlayerContextConfig.rootElementId=a.elementId:a.config.attrs.id=a.elementId)}
m.setConfig=function(a){var b;this.oa=a;this.config=On(a);Ln(this);this.fa||(this.fa=Pn(this,(null===(b=this.config.args)||void 0===b?void 0:b.jsapicallback)||"onYouTubePlayerReady"));this.config.args?this.config.args.jsapicallback=null:this.config.args={jsapicallback:null};var c;if(null===(c=this.config)||void 0===c?0:c.attrs)a=this.config.attrs,(c=a.width)&&this.j&&(this.j.style.width=Uc(Number(c)||c)),(a=a.height)&&this.j&&(this.j.style.height=Uc(Number(a)||a))};
function Nn(a){var b;a.config&&!0!==a.config.loaded&&(a.config.loaded=!0,!a.config.args||"0"!==a.config.args.autoplay&&0!==a.config.args.autoplay&&!1!==a.config.args.autoplay?a.api.loadVideoByPlayerVars(null!==(b=a.config.args)&&void 0!==b?b:null):a.api.cueVideoByPlayerVars(a.config.args))}
function Qn(a){var b=!0,c=Rn(a);c&&a.config&&(a=Sn(a),b=Km(c,"version")===a);return b&&!!A("yt.player.Application.create")}
function Mn(a){if(!a.h&&!a.K){var b=Qn(a);if(b&&"html5"===(Rn(a)?"html5":null))a.L="html5",a.isReady()||Tn(a);else if(Un(a),a.L="html5",b&&a.l&&a.o)a.o.appendChild(a.l),Tn(a);else{a.config&&(a.config.loaded=!0);var c=!1;a.B=function(){c=!0;var d=Vn(a,"player_bootstrap_method")?A("yt.player.Application.createAlternate")||A("yt.player.Application.create"):A("yt.player.Application.create");var e=a.config?On(a.config):void 0;d&&d(a.o,e,a.webPlayerContextConfig);Tn(a)};
a.K=!0;b?a.B():(Om(Sn(a),a.B),(b=Wn(a))&&En(b),Xn(a)&&!c&&z("yt.player.Application.create",null,void 0))}}}
function Rn(a){var b=Fc(a.elementId);!b&&a.j&&a.j.querySelector&&(b=a.j.querySelector("#"+a.elementId));return b}
function Tn(a){var b;if(!a.h){var c=Rn(a),d=!1;c&&c.getApiInterface&&c.getApiInterface()&&(d=!0);d?(a.K=!1,!Vn(a,"html5_remove_not_servable_check_killswitch")&&(null===c||void 0===c?0:c.isNotServable)&&a.config&&(null===c||void 0===c?0:c.isNotServable(null===(b=a.config.args)||void 0===b?void 0:b.video_id))||Yn(a)):a.Ba=Mf(function(){Tn(a)},50)}}
function Yn(a){Jn(a);a.na=!0;var b=Rn(a);if(b){a.m=Zn(a,b,"addEventListener");a.ba=Zn(a,b,"removeEventListener");var c=b.getApiInterface();c=c.concat(b.getInternalApiInterface());for(var d=a.api,e=0;e<c.length;e++){var f=c[e];d[f]||(d[f]=Zn(a,b,f))}}for(var g in a.i)a.i.hasOwnProperty(g)&&a.m&&a.m(g,a.i[g]);Nn(a);a.fa&&a.fa(a.api);a.J.W("onReady",a.api)}
function Zn(a,b,c){var d=b[c];return function(e){for(var f=[],g=0;g<arguments.length;++g)f[g-0]=arguments[g];try{return a.lastError=null,d.apply(b,f)}catch(h){"sendAbandonmentPing"!==c&&(h.params=c,a.lastError=h,Rk(h))}}}
function Jn(a){a.na=!1;if(a.ba)for(var b in a.i)a.i.hasOwnProperty(b)&&a.ba(b,a.i[b]);for(var c in a.C)a.C.hasOwnProperty(c)&&Nf(Number(c));a.C={};a.m=null;a.ba=null;b=a.api;for(var d in b)b.hasOwnProperty(d)&&(b[d]=null);b.addEventListener=function(e,f){a.addEventListener(e,f)};
b.removeEventListener=function(e,f){a.removeEventListener(e,f)};
b.destroy=function(){a.dispose()};
b.getLastError=function(){return a.getLastError()};
b.getPlayerType=function(){return a.getPlayerType()};
b.getCurrentVideoConfig=function(){return a.oa};
b.loadNewVideoConfig=function(e){a.loadNewVideoConfig(e)};
b.isReady=function(){return a.isReady()}}
m.isReady=function(){return this.na};
function Kn(a){a.addEventListener("WATCH_LATER_VIDEO_ADDED",function(b){Tg("WATCH_LATER_VIDEO_ADDED",b)});
a.addEventListener("WATCH_LATER_VIDEO_REMOVED",function(b){Tg("WATCH_LATER_VIDEO_REMOVED",b)});
a.addEventListener("onAdAnnounce",function(b){Tg("a11y-announce",b)})}
m.addEventListener=function(a,b){var c=this,d=Pn(this,b);d&&(0<=Wa(this.Na,a)||this.i[a]||(b=$n(this,a),this.m&&this.m(a,b)),this.J.subscribe(a,d),"onReady"===a&&this.isReady()&&Mf(function(){d(c.api)},0))};
m.removeEventListener=function(a,b){this.h||(b=Pn(this,b))&&We(this.J,a,b)};
function Pn(a,b){var c=b;if("string"===typeof b){if(a.ga[b])return a.ga[b];c=function(d){for(var e=[],f=0;f<arguments.length;++f)e[f-0]=arguments[f];if(f=A(b))try{f.apply(y,e)}catch(g){Sk(g)}};
a.ga[b]=c}return c?c:null}
function $n(a,b){var c="ytPlayer"+b+a.F;a.i[b]=c;y[c]=function(d){var e=Mf(function(){if(!a.h){a.J.W(b,d);var f=a.C,g=String(e);g in f&&delete f[g]}},0);
hb(a.C,String(e))};
return c}
m.getPlayerType=function(){return this.L||(Rn(this)?"html5":null)};
m.getLastError=function(){return this.lastError};
function Un(a){a.cancel();Jn(a);a.L=null;a.config&&(a.config.loaded=!1);var b=Rn(a);b&&(Qn(a)||!Xn(a)?a.l=b:(b&&b.destroy&&b.destroy(),a.l=null));if(a.o)for(a=a.o;b=a.firstChild;)a.removeChild(b)}
m.cancel=function(){this.B&&Um(Sn(this),this.B);Nf(this.Ba);this.K=!1};
m.D=function(){Un(this);if(this.l&&this.config&&this.l.destroy)try{this.l.destroy()}catch(b){Sk(b)}this.ga=null;for(var a in this.i)this.i.hasOwnProperty(a)&&(y[this.i[a]]=null);this.oa=this.config=this.api=null;delete this.o;delete this.j;J.prototype.D.call(this)};
function Xn(a){var b,c;a=null===(c=null===(b=a.config)||void 0===b?void 0:b.args)||void 0===c?void 0:c.fflags;return!!a&&-1!==a.indexOf("player_destroy_old_version=true")}
function Sn(a){return a.webPlayerContextConfig?a.webPlayerContextConfig.jsUrl:(a=a.config.assets)?a.js:""}
function Wn(a){return a.webPlayerContextConfig?a.webPlayerContextConfig.cssUrl:(a=a.config.assets)?a.css:""}
function Vn(a,b){var c;if(a.webPlayerContextConfig)var d=a.webPlayerContextConfig.serializedExperimentFlags;else if(null===(c=a.config)||void 0===c?0:c.args)d=a.config.args.fflags;return"true"===eg(d||"","&")[b]}
function On(a){for(var b={},c=u(Object.keys(a)),d=c.next();!d.done;d=c.next()){d=d.value;var e=a[d];b[d]="object"===typeof e?kb(e):e}return b}
;var ao={},bo="player_uid_"+(1E9*Math.random()>>>0);function co(a,b,c){var d="player";c=void 0===c?!0:c;d="string"===typeof d?Fc(d):d;var e=bo+"_"+Ja(d),f=ao[e];if(f&&c)return eo(a,b)?f.api.loadVideoByPlayerVars(a.args||null):f.loadNewVideoConfig(a),f.api;f=new In(d,e,a,b);ao[e]=f;Tg("player-added",f.api);Gd(f,function(){delete ao[f.getId()]});
return f.api}
function eo(a,b){return b&&b.serializedExperimentFlags?b.serializedExperimentFlags.includes("web_player_remove_playerproxy=true"):a&&a.args&&a.args.fflags?a.args.fflags.includes("web_player_remove_playerproxy=true"):!1}
;var fo=null,go=null,ho=null;function io(){var a=fo.getVideoData(1);a=a.title?a.title+" - YouTube":"YouTube";document.title!==a&&(document.title=a)}
;function jo(){if(ed())return!0;var a=E("INNERTUBE_CLIENT_NAME");return!a||"WEB"!==a&&"MWEB"!==a?!0:(a=cd.get("CONSENT",void 0))?a.startsWith("YES+"):!0}
;function ko(a,b,c){a="ST-"+Zb(a).toString(36);b=b?dc(b):"";c=c||5;O("drop_st_cookie_before_cb")&&!jo()||vh(a,b,c)}
;function lo(a,b,c){b=void 0===b?{}:b;c=void 0===c?!1:c;var d=E("EVENT_ID");d&&(b.ei||(b.ei=d));if(b){d=a;var e=void 0===e?!0:e;var f=E("VALID_SESSION_TEMPDATA_DOMAINS",[]),g=bc(window.location.href);g&&f.push(g);g=bc(d);if(0<=Wa(f,g)||!g&&0==d.lastIndexOf("/",0))if(O("autoescape_tempdata_url")&&(f=document.createElement("a"),Tb(f,d),d=f.href),d){g=d.match($b);d=g[5];f=g[6];g=g[7];var h="";d&&(h+=d);f&&(h+="?"+f);g&&(h+="#"+g);d=h;f=d.indexOf("#");if(d=0>f?d:d.substr(0,f))if(e&&!b.csn&&(b.itct||b.ved)&&
(b=Object.assign({csn:vl()},b)),k){var k=parseInt(k,10);isFinite(k)&&0<k&&ko(d,b,k)}else ko(d,b)}}if(c)return!1;if((window.ytspf||{}).enabled)spf.navigate(a);else{var l=void 0===l?{}:l;var p=void 0===p?"":p;var n=void 0===n?window:n;c=n.location;a=ec(a,l)+p;a=a instanceof Fb?a:Lb(a);c.href=Hb(a)}return!0}
;z("yt.setConfig",M,void 0);z("yt.config.set",M,void 0);z("yt.setMsg",yf,void 0);z("yt.msgs.set",yf,void 0);z("yt.logging.errors.log",Sk,void 0);
z("writeEmbed",function(){var a=E("PLAYER_CONFIG",void 0);if(!a){var b=E("PLAYER_VARS",void 0);b&&(a={args:b})}il(!0);"gvn"===a.args.ps&&(document.body.style.backgroundColor="transparent");a.attrs||(a.attrs={width:"100%",height:"100%",id:"video-player"});var c=document.referrer;b=E("POST_MESSAGE_ORIGIN");window!==window.top&&c&&c!==document.URL&&(a.args.loaderUrl=c);O("embeds_js_api_set_1p_cookie")&&(c=jg(),c.embedsTokenValue&&(a.args.embedsTokenValue=c.embedsTokenValue));M("FORCE_CSI_ON_GEL",!0);
c=["ol"];em("").info.actionType="embed";c&&M("TIMING_AFT_KEYS",c);M("TIMING_ACTION","embed");c=E("TIMING_INFO",{});for(var d in c)c.hasOwnProperty(d)&&um(d,c[d]);um("is_nav",1);(d=vl())&&um("csn",d);(d=E("PREVIOUS_ACTION",void 0))&&!pm()&&um("pa",d);d=$l();c=E("CLIENT_PROTOCOL");var e=E("CLIENT_TRANSPORT");c&&um("p",c);e&&um("t",e);um("yt_vis",zm());um("yt_lt","cold");c=Wl();if(e=Yl())Z("srt",c.responseStart),1!==d.prerender&&(um("yt_sts","n",void 0),Z("_start",e,void 0));d=cm();0<d&&Z("fpt",d);if(!O("log_deltas_killswitch")){var f,
g,h,k;U&&U.timing&&(U.timeOrigin&&U.timing.navigationStart&&wm("startTimeDelta",Math.floor(U.timeOrigin)-U.timing.navigationStart),(d=null===(k=null===(h=null===(g=null===(f=U.getEntriesByType)||void 0===f?void 0:f.call(U,"navigation"))||void 0===g?void 0:g[0])||void 0===h?void 0:h.toJSON)||void 0===k?void 0:k.call(h))&&d.responseEnd&&U.timing.responseEnd&&wm("responseEndDelta",Xl(d.responseEnd)-U.timing.responseEnd))}f=Wl();f.isPerformanceNavigationTiming&&um("pnt",1,void 0);Z("nreqs",f.requestStart,
void 0);Z("nress",f.responseStart,void 0);Z("nrese",f.responseEnd,void 0);0<f.redirectEnd-f.redirectStart&&(Z("nrs",f.redirectStart,void 0),Z("nre",f.redirectEnd,void 0));0<f.domainLookupEnd-f.domainLookupStart&&(Z("ndnss",f.domainLookupStart,void 0),Z("ndnse",f.domainLookupEnd,void 0));0<f.connectEnd-f.connectStart&&(Z("ntcps",f.connectStart,void 0),Z("ntcpe",f.connectEnd,void 0));f.secureConnectionStart>=Yl()&&0<f.connectEnd-f.secureConnectionStart&&(Z("nstcps",f.secureConnectionStart,void 0),Z("ntcpe",
f.connectEnd,void 0));U&&U.getEntriesByType&&Bm();f=[];if(document.querySelector&&U&&U.getEntriesByName)for(var l in Tl)Tl.hasOwnProperty(l)&&(g=Tl[l],Am(l,g)&&f.push(g));f.length&&um("rc",f.join(","));if(pm(void 0)){l={actionType:jm[E("TIMING_ACTION",void 0)]||"LATENCY_ACTION_UNKNOWN",previousAction:jm[E("PREVIOUS_ACTION",void 0)]||"LATENCY_ACTION_UNKNOWN"};if(f=vl())l.clientScreenNonce=f;f=am(void 0);hm().info(l,f)}l=$l();g=Vl();if("cold"===l.yt_lt&&(f=rm(),h=f.gelTicks?f.gelTicks:f.gelTicks={},
f=f.gelInfos?f.gelInfos:f.gelInfos={},pm())){for(var p in g)"tick_"+p in h||qm(p,g[p]);p=tm();g=am();h={};for(var n in l)"info_"+n in f||!(k=sm(n,l[n]))||(Hl(p,k),Hl(h,k));hm().info(h,g)}z("ytglobal.timingready_",!0,void 0);vm();(n=E("WEB_PLAYER_CONTEXT_CONFIGS",void 0))&&"WEB_PLAYER_CONTEXT_CONFIG_ID_EMBEDDED_PLAYER"in n?(n=n.WEB_PLAYER_CONTEXT_CONFIG_ID_EMBEDDED_PLAYER,n.serializedForcedExperimentIds||(p=jg(),p.forced_experiments&&(n.serializedForcedExperimentIds=p.forced_experiments)),fo=co(a,
n,!1)):fo=co(a);fo.addEventListener("onVideoDataChange",io);a=E("POST_MESSAGE_ID","player");E("ENABLE_JS_API")?ho=new tn(fo):E("ENABLE_POST_API")&&"string"===typeof a&&"string"===typeof b&&(go=new An(window.parent,a,b),ho=new xn(fo,go.connection));Xm();O("networkless_logging_web_embedded")&&ik();O("embeds_enable_ua_ch_polyfill")&&ln()},void 0);
var mo=uf(function(){xm();var a=xh.getInstance(),b=!!((Ah("f"+(Math.floor(119/31)+1))||0)&67108864),c=1<window.devicePixelRatio;if(document.body&&Jd(document.body,"exp-invert-logo"))if(c&&!Jd(document.body,"inverted-hdpi")){var d=document.body;if(d.classList)d.classList.add("inverted-hdpi");else if(!Jd(d,"inverted-hdpi")){var e=Hd(d);Id(d,e+(0<e.length?" inverted-hdpi":"inverted-hdpi"))}}else!c&&Jd(document.body,"inverted-hdpi")&&Kd();if(b!=c){b="f"+(Math.floor(119/31)+1);d=Ah(b)||0;d=c?d|67108864:
d&-67108865;0==d?delete wh[b]:(c=d.toString(16),wh[b]=c.toString());c=!0;O("web_secure_pref_cookie_killswitch")&&(c=!1);b=a.h;d=[];for(var f in wh)d.push(f+"="+encodeURIComponent(String(wh[f])));vh(b,d.join("&"),63072E3,a.i,c)}Dm.h||(Dm.h=new Dm);a=Dm.h;f=16623;var g=void 0===g?{}:g;Object.values(Uk).includes(f)||(Rk(new hi("createClientScreen() called with a non-page VE",f)),f=83769);g.isHistoryNavigation||a.h.push({rootVe:f,key:g.key||""});a.l=[];a.u=[];g.Fa?Gm(a,f,g):Hm(a,f,g)}),no=uf(function(){fo&&
fo.sendAbandonmentPing&&fo.sendAbandonmentPing();
E("PL_ATT")&&cn.dispose();for(var a=0,b=Vm.length;a<b;a++)Uf(Vm[a]);Vm.length=0;Tm("//static.doubleclick.net/instream/ad_status.js");Wm=!1;M("DCLKSTAT",0);Fd(ho,go);fo&&(fo.removeEventListener("onVideoDataChange",io),fo.destroy())});
window.addEventListener?(window.addEventListener("load",mo),window.addEventListener("unload",no)):window.attachEvent&&(window.attachEvent("onload",mo),window.attachEvent("onunload",no));Qa("yt.abuse.player.botguardInitialized",A("yt.abuse.player.botguardInitialized")||dn);Qa("yt.abuse.player.invokeBotguard",A("yt.abuse.player.invokeBotguard")||en);Qa("yt.abuse.dclkstatus.checkDclkStatus",A("yt.abuse.dclkstatus.checkDclkStatus")||Ym);
Qa("yt.player.exports.navigate",A("yt.player.exports.navigate")||lo);Qa("yt.util.activity.init",A("yt.util.activity.init")||Wf);Qa("yt.util.activity.getTimeSinceActive",A("yt.util.activity.getTimeSinceActive")||Zf);Qa("yt.util.activity.setTimestamp",A("yt.util.activity.setTimestamp")||Xf);}).call(this);
