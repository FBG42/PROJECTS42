// Crie um objeto com os seus dados pessoais
// Deve possui pelo menos duas propriedades nome e sobrenome

var dadosPessoais = {
  nome: "Fabricio",
  sobrenome: "Grigolo",
  idade: 20,
  altura: 1.71,

  nomeCompleto() {
    console.log(`${this.nome} ${this.sobrenome}`);
  },
};

// Crie um método no objeto anterior, que mostre o seu nome completo

dadosPessoais.nomeCompleto();

// Atribua o valor da propriedade preco para 3000
var carro = {
  preco: 1000,
  portas: 4,
  marca: "Audi",
};

carro.preco = 3000;


// Crie um objeto de um cachorro que represente um labrador,
// preto com 10 anos, que late ao ver um homem

var Labrador = {
    cor: preto,
    idade: '10 anos',
    latir() {
        console.log('Au au')
    },
}