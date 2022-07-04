// function somar(n1, n2) {
//   return n1 + n2;
// }

// console.log(somar.name);

// function correioElegante(remetente) {
//  console.log(`Com você por perto, eu não preciso de quentão para me esquentar =) <3 -${remetente}`);
// }

// correioElegante.call(null, "Nordestina");

// // Não faça isso, apenas demosntração how it works

// window.marca = 'Honda';
// window.ano = 288;


// function descricaoCarro(velocidade) {
//   console.log(this)
//   console.log(this.marca + ' ' + this.ano + velocidade);
// };

// descricaoCarro.call({marca: 'Honda', ano: 2015}, 100);


// const carros = ['Ford', 'Fiat', 'VW'];
// const frutas = ['Banana', 'Uva', 'Pêra']

// carros.forEach.call(frutas, (carro) => {
//   console.log(carro)
// })

// function Dom(seletor) {
//   this.element = document.querySelector(seletor);
// }

// Dom.prototype.ativo = function(classe) {
//   console.log(this)
//   this.element.classList.add(classe)
// }

// const ul = new Dom('ul');

// const li = {
//   element: document.querySelector('li')
// }

// ul.ativo.call(li,'ativar')
// ul.ativo('ativar');



// const frutas = ['Banana', 'Uva', 'Maçã'];

// Array.prototype.pop.call(frutas);
// frutas.pop();

// const arrayLike = {
//   0: 'Item 1',
//   1: 'Item 2',
//   2: 'Item 3',
//   3: 'Item 4',
//   lenght: 4,
// }

// const li = document.querySelectorAll('li');

// const filtro = Array.prototype.filter.bind(li, (item) => {
//   return item.classList.contains('ativo');
// });

// console.log(filtro);
// console.log(li);


// numeros = [3232, 32, 1243, 235, 23, 564];

// const carro = {
//   marca: 'Ford',
//   ano: 2018,
//   acelerar: function(aceleracao, tempo) {
//     return `${this.marca} acelerou ${aceleracao} em ${tempo}`
//   }
// }

// const honda = {
//   marca: 'Honda'
// }

// const acelerarHonda = carro.acelerar.bind(honda, 100);

// console.log(carro);
// console.log(acelerarHonda(20));

function imc(altura, peso) {
  return peso / (altura * altura);
}

const img180 = imc.bind(null, 1.80);

imc(1.80, 70) // 21.6
imc(70) // 21.6