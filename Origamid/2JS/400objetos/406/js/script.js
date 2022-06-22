// const precos = [49, 99, 69, 89];

// const dados = [
//         new String('Tipo 1'),
//         ['Carro', 'Portas', {cor: 'Azul', preco: 2000}],
//         function andar(nome) { console.log(nome)}
//     ];

// const carros = new Array('Ford', 'Fiat', 'Honda');

// carros[2] = 'Ferrari';
// carros[3] = 'Kia';
// carros[20] = 'Mercedes'

// console.log(carros.length)


// const li = document.querySelectorAll('li');

// const arrayLi = Array.from(li)

// const obj = {
//     0: 'Fabrício',
//     1: 'Grigolo',
//     2: 'Teste',
//     length: 3,
// }

// const objArray = Array.from(obj)

// console.log(li);
// console.log(arrayLi);


// const frutas = ['Banana', 'Pêra', ['Uva Roxa', 'Uva Verde']];

// console.log(frutas[2][1].length);


// const instrumentos = ['Guitarra', 'Baixo', 'Violão'];
// instrumentos.sort();

// const idades = [32,21,33,43,1,12,8];
// idades.sort();

// console.log(instrumentos);
// console.log(idades);


const carros = ['Ford', 'Fiat', 'VW'];
carros.unshift('Kia', 'Ferrari');
const novaArray = carros.push('Parati', 'Gol');


// console.log(carros);
// console.log(novaArray);


// console.log(carros.shift());
// console.log(carros);
// console.log(carros.reverse());

// console.log(carros)
// console.log(carros.splice(2 , 4 , 'Fusca'))
// console.log(carros)


// console.log(['item1', 'item2', 'item3', 'item4', 'item5'].copyWithin(2, 0, 2));

// console.log(['item1', 'item2', 'item3', 'item4', 'item5'].fill('Banana', 0, 2)); 

const transporte1 = ['Barco', 'Aviao'];
const transporte2 = ['Carro', 'Moto'];

const transportes = [].concat(transporte1, transporte2, 'Jetski', 'Triciclo');

console.log(transportes);

const linguagens = ['html', 'css', 'js', 'php', 'python', 'js'];

const cloneLinguagens = linguagens.slice();

linguagens.includes('css'); // true
linguagens.includes('ruby'); // false
linguagens.indexOf('python'); // 4
linguagens.indexOf('js'); // 2
linguagens.lastIndexOf('js'); // 5


let htmlString = '<h2>Título Principal</h2>';
htmlString = htmlString.split('h2')
htmlString = htmlString.join('h1')

console.log(htmlString)