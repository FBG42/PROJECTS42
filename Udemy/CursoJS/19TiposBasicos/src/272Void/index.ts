function semRetorno(...args: string[]): void {
  console.log(args.join(' '));
}

const pessoa = {
  nome: 'Fabrício',
  sobrenome: 'Grigolo',

  exibirNome(): void {
    console.log(this.nome + ' ' + this.sobrenome);
  },
};

semRetorno('Fabrício', 'Grigolo');
pessoa.exibirNome();

export { pessoa };
