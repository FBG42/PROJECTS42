const comida = 'Lasanha';
const agua = new String('Água');

const frase = 'A melhor comida';


// console.log(frase[frase.length - 1]);
// console.log(frase.charAt(frase.length));


const frase2 = 'A melhor linguagem é ';
const linguagem = 'Javascript';

const fraseFinal = frase.concat(linguagem, '!!');

const fruta = 'Banana';
const listaFrutas = 'Melancia, Banana, Laranja';

listaFrutas.includes(fruta); // true
fruta.includes(listaFrutas); // false


// console.log(fruta.startsWith('Ba'));
// console.log(fruta.endsWith('na'));


const transacao1 = 'Depósito de cliente';
const transacao2 = 'Depósito de fornecedor';
const transacao3 = 'Taxa de camisas';

// console.log(transacao1.slice(0, 3));
// console.log(transacao3.slice(-7));


console.log(fruta.indexOf('B'));
console.log(fruta.lastIndexOf('a'));


const preco = 'R$ 99,00'

console.log(preco.padStart(20, '@'))
console.log(preco.padEnd(20, '@'))


const listaPrecos = ['R$ 99', 'R$ 199', 'R$ 12000'];

listaPrecos.forEach((preco) => {
    console.log(preco.padStart(21, '-'));
})


const ta = 'Ta';

console.log(ta.repeat(4))
console.log(fruta.repeat(4))