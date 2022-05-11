function livro(nome, ano, autor) {

    
  const frase = {
    maiuscula: nome.toUpperCase(),

    lancamento_ate_aqui: 2022 - Number(ano),

    criado_por:  nome + " por " + autor,
    };
  return frase
}


const frase_final = livro('O Senhor dos Anéis', 1954, 'J. R. R. Tolkien')

console.log(frase_final.criado_por)