// Crie uma função para verificar se um valor é Truthy
function verificar(valor) {
  if (!!valor) {
    return console.log("true!");
  } else {
    return console.log("false!");
  }
}

// Crie uma função matemática que retorne o perímetro de um quadrado
// lembrando: perímetro é a soma dos quatro lados do quadrado

function perimetro(lado) {
  var perimetro = lado * 4;
  return console.log(`O perímetro do quadro é ${perimetro}`);
}

perimetro(4, 6, 12, 8);

// Crie uma função que retorne o seu nome completo
// ela deve possuir os parâmetros: nome e sobrenome

function nomeCompleto(nome, sobrenome) {
  var nomeCompleto = `${nome} ${sobrenome}`;
  return console.log(`Seu nome completo é ${nomeCompleto}`);
}

nomeCompleto("Jose, Silva");

// Crie uma função que verifica se um número é par

function isPar(numero) {
  if (numero % 2 === 0) {
    return console.log(`${numero} é par`);
  } else {
    return console.log(`${numero} é impar`);
  }
}

isPar(3);

// Crie uma função que retorne o tipo de
// dado do argumento passado nela (typeof)

function returnTypeof(dado) {
  return console.log(`O argumento passado é um(a) ${typeof dado}`);
}

returnTypeof(42);
returnTypeof(" ");

// addEventListener é uma função nativa do JavaScript
// o primeiro parâmetro é o evento que ocorre e o segundo o Callback
// utilize essa função para mostrar no console o seu nome completo
// quando o evento 'scroll' ocorrer.

// addEventListener('scroll', function NomeCompleto(){ return console.log("Fabrício B Grigolo")})
var totalPaises = 193;
precisoVisitar(20);
jaVisitei(20);
// // Corrija o erro abaixo
function precisoVisitar(paisesVisitados) {
  return `Ainda faltam ${totalPaises - paisesVisitados} países para visitar`;
}
function jaVisitei(paisesVisitados) {
  return `Já visitei ${paisesVisitados} do total de ${totalPaises} países`;
}
