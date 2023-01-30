/* 
Operadores aritméticos, atribuição e incremento

 +  Adição / Concatenação 
(Uma concatenação é basicamente unir dois valores, se um deles for uma string)

 -  Subtração

 /  Divisão

 *  Multiplicação

 ** Potenciação

 %  Resto da divisão



 Precedência dos operadores aritméticos

 ()
 **
 *
 /
 %
 +
 -


*/  


console.log(10 + 10, 'Soma');
console.log(10 + '10', 'Concatenação');

console.log(42 - 21, 'Subtração');

console.log(42 / 2, 'Divisão');

console.log(21 * 2, 'Multiplicação');

console.log(2.112 ** 5, 'Potenciação');

console.log(10 %  3, 'Resto da divisão');



// Operadores de atribuição


// Operador de incremento (++) faz com que a varíavel tenha o valor dela +1
let contador = 1;
contador++; // 2
++contador; // 3
contador++; // 4
++contador; // 5
/* A diferença entre a sequência é que se o operador de encremento estiver após a variável no console.log(contador++)
primeiro será exibido seu valor antigo depois encrementado e vice-versa */

// Operador de decremento (--) faz com que a varíavel tenha o valor dela -1

// Tambêm podemos fazer assim
contador = contador + 1; // 6
contador = contador - 1; // 5

let passo = 2;
contador = 0;

contador = contador + passo;//2
contador = contador + passo;//4
contador = contador + passo;//6
 
// Ou podemos fazer assim
contador += passo; //8
contador += passo; //10
contador += passo; //12
// que é igual a fazer contador = contador + passo;
// podemos utilizar outros operadores
contador *= passo; //24
contador -= passo; //22
// etc..


// NaN = Not a Number
// Significa que algum tipo de dado é uma string

const numero = 2
const string = 'string'
console.log(numero * string)
// Me dará o resultado NaN
// Mas se um dos dados, "ditado" como string se parecer com um número a engine converterá para você
const StringMasUmNumero = '5'
console.log(numero * StringMasUmNumero)

// As formas de resolver um valor dado como string que é um número são
const StringMasUmNumero2 = Number('10')
// Number() converterá a string para um número.
// parseInt() converterá a string para um número inteiro.
// parseFloat() converterá a string para um número float.