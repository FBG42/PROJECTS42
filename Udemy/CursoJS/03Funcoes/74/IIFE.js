// IIFE -> Immediately Invoked Function Expression

((idade, peso, altura) => {
	const sobrenome = 'Miranda';

	function criaNome(nome) {
		return nome + ' ' + sobrenome;
	}

	function falaNome() {
		console.log(criaNome('Luiz'))
	}

	falaNome()
	console.log(idade, peso, altura)
})(20, 1.70, 1,71)

const nome = "Qualquer coisa"