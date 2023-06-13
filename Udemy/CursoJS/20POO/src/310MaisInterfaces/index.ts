// Declaration merging
interface Pessoa {
  nome: string;
}

interface Pessoa {
  readonly sobrenome: string;
  // readonly enderecos:  string[]; // Readonly apenas no valor da array
  readonly enderecos: readonly string[]; // Readonly nos elementos dentro da array
  idade?: number; // Opcional
}

const pessoa: Pessoa = {
  nome: 'Fabrício',
  sobrenome: 'Grigolo',
  enderecos: ['Av. Brasil'],
  idade: 21,
};

pessoa.idade = 22;
console.log(pessoa);
