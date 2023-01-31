function criaPessoa(nome, sobrenome, altura, peso) {
	return {
		nome,
		sobrenome,
		// Getter
		get nomeCompleto() {
			return `${this.nome} ${this.sobrenome}`
		},

		set nomeCompleto(valor) {
			valor = valor.split(' ');
			this.nome = valor.shift()
			this.sobrenome = valor.join(' ')
		}, 

		fala(assunto) {
			return `${this.nome} está ${assunto}.`;
		},

		altura,
		peso,

		// Getter
		get imc() {
			const indice = this.peso / (this.altura * this.altura);
			return indice.toFixed(2);
		}

	};
}

const p1 = criaPessoa('Fabrício', 'Grigolo', 1.71, 65)
// console.log(p1.nomeCompleto, p1.imc);
// const p2 = criaPessoa('Maria', 'Joaquina', 1.60, 42)
// console.log(p2.nomeCompleto, p2.imc)

p1.nomeCompleto = "Fabrício Bittencourt Grigolo";
console.log(p1.nomeCompleto)