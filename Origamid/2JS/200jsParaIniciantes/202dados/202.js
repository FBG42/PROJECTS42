var nome = 'Fabrício'; // String
var idade = 20;
var semValor;
var Nulo = null;
var simbolo = Symbol();
console.log(typeof nome,
            typeof idade,
            typeof semValor,
            typeof Nulo,
            typeof simbolo);


var sobrenome = 'Grigolo';

var nomeCompleto = `${nome} + ${sobrenome}`;

console.log(nomeCompleto);


var gols = 1000;
var frase = `Romário fez ${gols} gols`;
console.log(frase)


var ano = "2018";
var mes = 8;
console.log( ano + mes)


var frase1 = 'Esse é uma frase com `"uma"` aspas'
var frase2 = 'Esse é uma frase com \'uma\' aspas'
var frase3 = "Esse é uma frase com `'duas'` aspas"
var frase4 = `Esse é uma frase com "'duas'" aspas`
var frase5 = `Esse é uma frase com "'duas'" aspas`


var gols = 1000;
var frase6 = 'Romário fez ' + gols + ' gols';
var frase7 = `Romário fez ${gols} gols`; 