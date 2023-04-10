// const nome = "Luiz";
// const sobrenome = 'Miranda';

// const falaNome = () => `${nome} ${sobrenome}`;

// // module.exports.nome = nome;
// // module.exports.sobrenome = sobrenome;
// // module.exports.falaNome = falaNome;

// exports.nome = nome;
// exports.sobrenome = sobrenome;
// exports.falaNome = falaNome;
// this.qualquerCoisa = 'O que eu quiser exportar';

// console.log(exports)

class Pessoa {
	constructor(nome) {
		this.nome = nome;
	}
}

// module.exports.nome = 'Luiz';
// exports.Pessoa = Pessoa;
// this.sobrenome = 'Qualquer coisa que eu quiser.';

const nome = 'Luiz';
const sobrenome = 'Miranda;'

module.exports = {
	nome, sobrenome, Pessoa,
	qualquerCoisa: 'Qualquer Coisa.'
}

