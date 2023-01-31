// Global
function retornaFuncao(nome) {
	return function () {
		return nome;
	}
};

const funcao = retornaFuncao("Fabrício");
const funcao2 = retornaFuncao("Grigolo");

console.dir(funcao);
console.log(funcao(), funcao2());