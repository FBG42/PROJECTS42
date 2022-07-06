// const pessoa = new Object({
//     nome: 'Fabrício',
// })

// console.log(pessoa);

// const carro = {
//     rodas: 4,
//     init(valor) {
//         this.marca = valor;
//         return this
//     },
//     acelerar() {
//         return this.marca + ' acelerou';
//     },
//     buzinar() {
//         return this.marca + ' buzinou';
//     }
// }

// const honda = Object.create(carro).init('Honda');
// console.log(honda.acelerar());

// const ferrari = Object.create(carro).init('Ferrari');

// console.log(ferrari.buzinar());

// const funcaoAutomovel = {
//     acelerar() {
//         return 'acelerou';
//     },
//     buzinar() {
//         return 'buzinou';
//     },
// }

// const moto = {
//     rodas: 2,
//     capacete: true,
// }

// Object.assign(moto, funcaoAutomovel);
// console.log(moto);

// const moto = {
//   capacete: true,
// };

// Object.defineProperties(moto, {
//   rodas: {
//     get() {
//       return this._rodas;
//     },
//     set(valor) {
//         this._rodas = valor * 4
//     },
//   },
// });

// const frutas = ['banana'];

// console.log(moto);

// const carro = {
//     marca: 'Ford',
//     ano: 2018,
// }

// carro.marca = 'Honda';

// console.log(carro)

const frutas = ["Banana", "Uva"];
const frase = "Oi frase";
const somar = function (a, b) {
  return a + b;
};

const carro = {
  marca: "Ford",
};

console.log(carro.toString());

console.log(Object.prototype.toString.call(somar));
