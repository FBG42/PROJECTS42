// Crie uma função construtora de Pessoas
// Deve conter nome, sobrenome e idade
// Crie um método no protótipo que retorne
// o nome completo da pessoa

function Pessoa(nome, sobrenome, idade) {
    this.nome = nome;
    this.sobrenome = sobrenome;
    this.idade = idade;
}

Pessoa.prototype.nomeCompleto = function() {
    return `${this.nome} ${this.sobrenome} tem ${this.idade} anos de idade.`
}

fabricio = new Pessoa('Fabrício', 'Grigolo', 20);
console.log(fabricio.nomeCompleto())

// Liste os métodos acessados por 
// dados criados com NodeList,
// HTMLCollection, Document
console.log(NodeList.prototype, 'NodeList')

console.log(HTMLCollection.prototype, 'HTMLCollection')

console.log(Array.prototype, 'Array')

console.log(Document.prototype, 'Dom')
// Liste os construtores dos dados abaixo
const li = document.querySelector('li');

li; // HTMLLIElement
li.click();  //  Function
li.innerText;  // String
li.value;  // Number
li.hidden;  // Boolean
li.offsetLeft;  // Number

console.log(String.prototype, 'Função construtora de uma string')
console.log(Number.prototype, 'Função construtora de um número')
console.log(Boolean.prototype, 'Função construtora de um valor booleano')
console.log(Function.prototype, 'Função construtora de uma função')
// Qual o construtor do dado abaixo:
li.hidden.constructor.name;

// String