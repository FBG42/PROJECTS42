// Utilizando o foreach na array abaixo,
// some os valores de Taxa e os valores de Recebimento

const transacoes = [
    {
      descricao: 'Taxa do Pão',
      valor: 'R$ 39',
    },
    {
      descricao: 'Taxa do Mercado',
      valor: 'R$ 129',
    },
    {
      descricao: 'Recebimento de Cliente',
      valor: 'R$ 99',
    },
    {
      descricao: 'Taxa do Banco',
      valor: 'R$ 129',
    },
    {
      descricao: 'Recebimento de Cliente',
      valor: 'R$ 49',
    },
  ];
  
  let valorTotaltaxa = 0;
  let valorAtualtaxa = 0;

  let valorTotalrecibo = 0;
  let valorAtualrecibo = 0;

  transacoes.forEach((transacao) => {
    if(transacao.descricao.startsWith('Taxa')) {
        valorAtualtaxa = transacao.valor;
        valorAtualtaxa = valorAtualtaxa.replace('R$', '').trim();
        valorAtualtaxa = Number(valorAtualtaxa);
        valorTotaltaxa += valorAtualtaxa;

    } else if(transacao.descricao.startsWith('Recebimento')) {
        valorAtualrecibo = transacao.valor;
        valorAtualrecibo = valorAtualrecibo.replace('R$', '').trim();
        valorAtualrecibo = Number(valorAtualrecibo);
        valorTotalrecibo += valorAtualrecibo;
    }
})
console.log(`O valor total das taxas são R$${valorTotaltaxa}`);
console.log(`O valor total dos recibos são R$${valorTotalrecibo}`);

  // Retorne uma array com a lista abaixo
  const transportes = 'Carro;Avião;Trem;Ônibus;Bicicleta';

  transportesArray = transportes.split(';');
  console.log(transportesArray);
  
  // Substitua todos os span's por a's
  const html = `<ul>
                  <li><span>Sobre</span></li>
                  <li><span>Produtos</span></li>
                  <li><span>Contato</span></li>
                </ul>`;
    const newHtml = html.replaceAll('span', 'a');

    console.log(newHtml);
  
  // Retorne o último caracter da frase
  const frase = 'Melhor do ano!';

  console.log(frase[frase.length - 1]);
  
  // Retorne o total de taxas
  const transacoes2 = ['Taxa do Banco', '   TAXA DO PÃO', '  taxa do mercado', 'depósito Bancário', 'TARIFA especial'];

  let contagemDetaxas = 0;

  transacoes2.forEach((transacao) => {
    let transacaoIf = transacao.toLocaleLowerCase().trim();
    if(transacaoIf.includes('tax')) {
        ++contagemDetaxas;
    }
  });
  
  console.log(`O total de taxas é ${contagemDetaxas}`);
  
  