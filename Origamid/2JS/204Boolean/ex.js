// Verifique se a sua idade é maior do que a de algum parente
// Dependendo do resultado coloque no console 'É maior', 'É igual' ou 'É menor'

var fabIdade = 20
var joelIdade = 51


if (fabIdade < joelIdade) {
    console.log('Joel é mais velho')
} else if (fabIdade === joelIdade) {
    console.log('Joel tem a mesma idade')
} else {
    console.log('Joel é mais noovo')
}

// Qual valor é retornado na seguinte expressão?
var expressao = (5 - 2) && (5 - ' ') && (5 - 2); // true
console.log(expressao)

// Verifique se as seguintes variáveis são Truthy ou Falsy
var nome = 'Andre';
var idade = 28;
var possuiDoutorado = false;
var empregoFuturo;
var dinheiroNaConta = 0;

!!nome
!!idade
!!possuiDoutorado
!!empregoFuturo
!!dinheiroNaConta

// Compare o total de habitantes do Brasil com China (valor em milhões)
var brasil = 207e6;
var china = 1340e6;

if (brasil < china) {
    console.log('China tem mais habitantes')
} else {
    console.log('Brasil tem mais habitantes')
}

// O que irá aparecer no console? // 
if(('Gato' === 'gato') && (5 > 2)) {
  console.log('Verdadeiro');
} else {
  console.log('Falso');
}

// O que irá aparecer no console? // Cão
if(('Gato' === 'gato') || (5 > 2)) {
  console.log('Gato' && 'Cão');
} else {
  console.log('Falso');
}