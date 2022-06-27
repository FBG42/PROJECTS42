// const carros = ['Ford', 'Fiat', 'Honda'];

// carros.forEach((item, index, array) => {
//     array[index] = 'Teste'
//     console.log(item, index, array);
// })

// console.log(carros);

// //

// const li = document.querySelectorAll('li');

// li.forEach((i, index) => i.classList.add('ativa'));

// li.forEach(function(item) {
//     item.classList.add('ativa');
// });

// const carros = ['Ford', 'Fiat', 'Honda'];

// carros.forEach((item, index, array) => {
//     array[index] = 'Carro ' + item;
//     console.log(carros)
// });

// // console.log(carros);

// const carros = ['Ford', 'Fiat', 'Honda'];

// const novaArray = carros.map((item, index, array) => {
//     return 'Carro ' + item;
// });

// const numeros = [2, 4, 5, 6, 78];
// const numerosX2 = numeros.map(n => n * 2);

// console.log(numerosX2);
// console.log(novaArray);

//

// const tempoAulas = aulas.map(aula => aula.min);

// const nomeAulas = aula => aula.nome;

// const nomeAulas2 = function(aula) {
//     aula.nome;
// }

// const arrayNomeAulas = aulas.map(nomeAulas);

// const aulas = [10, 25, 30];

// const reduceAulas = aulas.reduce((acumulador, item) => {
//     console.log(acumulador, item);
//     return item;
// }, 0);

// console.log(reduceAulas)

// const numeros = [10, 25, 30, 3, 54, 33, 22];

// const maiorNumero = numeros.reduce((anterior, atual) => {
//     return anterior > atual ? anterior : atual;
// }, 0);

// console.log(maiorNumero);

// const aulas = [
//         {
//           nome: 'HTML 1',
//           min: 15
//         },
//         {
//           nome: 'HTML 2',
//           min: 10
//         },
//         {
//           nome: 'CSS 1',
//           min: 20
//         },
//         {
//           nome: 'JS 1',
//           min: 25
//         },
//       ];

// const listaAulas = aulas.reduce((acumulador, aula, index) => {
//     console.log(aula.nome)
//     acumulador[index] = aula.nome;
//     return acumulador
// }, [])

// const frutas = ['Banana', 'Pêra', 'Uva'];

// const temUva = frutas.some((item) => {
//     console.log(item);
//     return item === 'Uva';
// });

// const every = frutas.every((fruta) => {
//     console.log(fruta);
//     return fruta
// });

// console.log(every);

// const numeros = [6, 43, 22, 88, 101, 29];

// const maiorQue3 = numeros.every(n => n >= 6);

// console.log(maiorQue3);

// const frutas = ['Banana', 'Pêra', 'Uva'];

// const indexUva = frutas.findIndex((fruta) => {
//     return fruta === 'Uva';
// });

// console.log(indexUva)

// const frutas = ['Banana', null, undefined, 'Pêra', 0, 'Uva'];

// const arrayFrutas = frutas.filter((fruta) => {
//     console.log(fruta);
//     return fruta;
// });

// console.log(arrayFrutas);

const aulas = [
  {
    nome: "HTML 1",
    min: 15,
  },
  {
    nome: "HTML 2",
    min: 10,
  },
  {
    nome: "CSS 1",
    min: 20,
  },
  {
    nome: "JS 1",
    min: 25,
  },
];

const maiores15 = aulas.filter((aula) => {
    return aula.min >= 15;
});

console.log(maiores15)