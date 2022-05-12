// Constante é uma variável que não muda seu valor

// REGRAS DAS VARÍAVEIS
// Não podemos criar constantes com palavras reservadas pela linguagem, por exemplo if ou console
// Constantes precisam ter nomes significativos
// Não podemos começar com o nome de uma constantes com um número
// Não podem conter espaços ou traços, apenas underline
// Utilizamos camelCase
// Case-sensitive
// Não pode modificar o valor de uma constante
// NÃO UTILIZE VAR, UTILIZE CONST.

const nome = 'Fabrício B Grigolo'


const primeiroNumero = 5;
const segundoNumero = 10;
const resultado = primeiroNumero * segundoNumero;
const resultadoDuplicado = resultado * 2;

let resultadoTriplicado = resultado * 3;
resultadoTriplicado = resultadoTriplicado + 5;


// typeof me dira o tipo da variável, sendo string = texto ou number = número.
console.log(typeof primeiroNumero)