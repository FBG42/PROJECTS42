// Crie uma função que verifique
// corretamente o tipo de dado
function verify(dado) {
  return Object.prototype.toString.call(dado);
}

const Aray = [];
const Sting = "";

console.log(verify(Aray));

// Crie um objeto quadrado com
// a propriedade lados e torne
// ela imutável

const quadrado = {};
Object.defineProperties(quadrado, {
  lados: {
    value: 4,
  },
});

quadrado.lados = 2;

console.log(quadrado);

// Previna qualquer mudança
// no objeto abaixo
const configuracao = {
  width: 800,
  height: 600,
  background: "#333",
};

Object.freeze(configuracao);

configuracao.seila = "222";

console.log(configuracao);

// Liste o nome de todas
// as propriedades do
// protótipo de String e Array

console.log(Object.getOwnPropertyDescriptors(Array.prototype));
console.log(Object.getOwnPropertyDescriptors(String.prototype));
