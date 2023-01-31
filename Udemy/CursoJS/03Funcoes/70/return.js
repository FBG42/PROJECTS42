// return
// Retorna um valor
// Termina a função

// function soma(a, b) {
// 	return a + b;
// }

// function criaPessoa(nome, sobrenome) {
// 	return { nome: nome, sobrenome: sobrenome };
// }

// const p1 = criaPessoa('Fabrício', 'Bittencourt');
// const p2 = {
// 	nome: 'Italo',
// 	sobrenome: 'Feijó'
// }

// function falaFrase(comeco) {
// 	function falaResto(resto) {
// 		return comeco + ' ' + resto;
// 	}

// 	return falaResto;
// }

// const ola = falaFrase('Olá');

// console.log(ola('MUNDO'));

// function duplica(n) {
// 	return n * 2;
// }

// function triplica(n) {
// 	return n * 3;
// }

// function quadriplica(n) {
// 	return n * 4;
// }


function criaMultiplicador(multiplicador) {
	return function(n) {
		return n * multiplicador;
	}
}

const duplica = criaMultiplicador(2);
const triplica = criaMultiplicador(3);
const quadriplica = criaMultiplicador(4);

console.log(duplica(2));
console.log(triplica(2));
console.log(quadriplica(2));