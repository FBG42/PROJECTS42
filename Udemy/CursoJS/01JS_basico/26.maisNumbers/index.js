//  IEE 754-2008

let num1 = 1500; // Number
let num2 = 2.5; // Number

console.log(num1.toString() + num2, "Concatenação");
// Convertendo num1 para string neste log

console.log(num1.toString(2), "Binario")
// O parâmetro 2, faz com que  o num1 seja convertido para números bínarios.

let pi = 3.14159265
console.log(pi.toFixed(2), "Pi duas casas decimais")
console.log(pi.toFixed(3), "Pi três casas decimais")
// toFixed expressa quantas casas decimais quer que o número tenha. (Expecificado nos parentêses)

let inteiro = -42;
console.log(Number.isInteger(inteiro), 'Boolean Inteiro');
//  Faz um valor booleano perguntando se o número é inteiro... 

let test = num1 * 'NaN';
console.log(Number.isNaN(test), 'Boolean NaN em conta de multiplicação');
// Faz um valor booleano perguntando se o número é NaN (Not a Number)
let test2 = num1 + 'NaN';
console.log(Number.isNaN(test2), 'Boolean NaN em conta de adição(Concatenação)')
// Temos que tomar cuidado com a concatenação que irá retornar um valor falso em NaN


let strange1 = 0.7;
let strange2 = 0.1;
console.log(strange1 + strange2, 'Percebes uma imprecisão, mas uma imprecisão muito pequena');

strange1 += strange2; // 0.8
strange1 += strange2; // 0.9
strange1 += strange2; // 1.0
console.log(strange1, 'teste de atribuição')

// Pensando no que aprendemos a cima é era uma boa converter, mas não receberemos a resposta esperada
// strange1 = strange1.toFixed(2);
// console.log(strange1, 'De primeira parece certo')
// console.log(Number.isInteger(strange1), 'Mas aqui vemos que não é nesta forma que se corrige a imprecisão')

// Assim é a melhor forma de resolução
strange1 = Number(strange1.toFixed(2))

console.log(strange1)
console.log(Number.isInteger(strange1), '')


// Outra forma de resolução é não realizar contas com floats, mas não mais usual.

let strange3 = 0.7;
let strange4 = 0.1;

strange3 = ((strange3 * 100) + (strange4 * 100)) / 100;// 0.8
strange3 = ((strange3 * 100) + (strange4 * 100)) / 100;// 0.9
strange3 = ((strange3 * 100) + (strange4 * 100)) / 100;// 1.0
strange3 = ((strange3 * 100) + (strange4 * 100)) / 100;// 1.1
console.log(strange3)