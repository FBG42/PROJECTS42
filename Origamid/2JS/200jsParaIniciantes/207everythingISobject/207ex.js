var btn = document.querySelector(".btn");

// nomeie 3 propriedades ou métodos de strings

var umaString = "Lorem ipsum sem ideia";

var caseAlta = umaString.toLocaleUpperCase();
var caseBaixa = umaString.toLocaleLowerCase();
var corte = umaString.split(2);
// nomeie 5 propriedades ou métodos de elementos do DOM

var head = document.querySelector("head");
var header = document.querySelector(".header");
var body = document.querySelector("body");
var footer = document.querySelector(".footer");
var main = document.querySelector("#main");

// busque na web um objeto (método) capaz de interagir com o clipboard,
// clipboard é a parte do seu computador que lida com o CTRL + C e CTRL + V

var texto = document.querySelector('.texto')


btn.addEventListener("click", function copyOnClick() {
  navigator.clipboard.writeText(conteudo);
});
