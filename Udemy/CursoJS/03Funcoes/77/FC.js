// Função construtora -> objeto
// Função fabrica -> objetos
// Construtura -> Pessoa (new)

function Pessoa(nome, sobrenome) {
	// Atributos ou métodos privados
	const ID = 123456;
	const metodoInterno = function () {
		//metodo
	};

	// Atributos ou métodos públicos
	this.nome = nome;
	this.sobrenome = sobrenome;

	this.metodo = () => {
		console.log(this.nome + ": sou um método")
	}
}


const p1 = new Pessoa('Fabrício', 'Grigolo');
const p2 = new Pessoa('Maria', 'Bittencourt');

