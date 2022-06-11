function Pessoa(nome, idade) {
    this.nome = nome;
    this.idade = idade;
    this.abracar = function() {
        return 'Abraçou';
    }
    this.andar = function() {
        return 'Andou pelo objeto'
    }
}

Pessoa.prototype.andar = function() {
    return this.nome + ',  Pessoa andou';
} // Neste ocorre como o "desejado"

Pessoa.prototype.nadar = () => {
    return this.nome + ',  Pessoa nadou';
} // Neste o nome da undefined

const fabricio = new Pessoa('Fabrício', 20);

