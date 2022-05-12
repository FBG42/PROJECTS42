// String, number, undefined, null, boolean, symbol(Não falado nesta aula)

const nomeComAspa = 'Fabrício'; // string
const nomeComAspas = "Fabrício"; // string
const nomeComCrase = `Fabrício`; // string

const num1 = 10 // number
const num2 = 10.52; // number

let semValor;  // undefined -> não aponta para lugar nenhum na memória
// Diferença entre é que nulo é explicitamente ditada para ser nula.
const Semdado = null; // Nulo -> não aponta para lugar nenhum na memória


const booleanT = true; 
// ou                   // boolean = true or false  (lógico)
const booleanF = false;


let a = 2;
const b = a;
console.log(a , b) // 2, 2
// Tipo de dado passado por referência

a = 3;
console.log(a, b)


