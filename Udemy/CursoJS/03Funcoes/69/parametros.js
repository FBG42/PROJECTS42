// // arguments
// function funcao({nome, sobrenome, idade}) {
// 	// let total = 0;
// 	// for (let argumento of arguments) {
// 	// 	total += argumento;
// 	// }

// 	console.log(nome, sobrenome, idade)
// }
// funcao({nome:'fabricio', sobrenome:'grigolo', idade:20 });

// rest operator
// function conta(operador, acumulador, ...numeros) {
// 	for (let numero of numeros) {
// 		if (operador === '+') acumulador += numero;
// 		if (operador === '-') acumulador -= numero;
// 		if (operador === '/') acumulador /= numero;
// 		if (operador === '*') acumulador *= numero;
// 	}

// 	console.log(acumulador)
// };
// conta('+', 0, 20, 30, 40, 50)

// rest operator
// const conta = function(operador, acumulador, ...numeros) {
// 	for (let numero of numeros) {
// 		if (operador === '+') acumulador += numero;
// 		if (operador === '-') acumulador -= numero;
// 		if (operador === '/') acumulador /= numero;
// 		if (operador === '*') acumulador *= numero;
// 	}

// 	console.log(acumulador)
// };
// conta('+', 0, 20, 30, 40, 50)

// rest operator with arrow function
const conta = (...args) => {
	console.log(args)
}
conta('+', 0, 20, 30, 40, 50)