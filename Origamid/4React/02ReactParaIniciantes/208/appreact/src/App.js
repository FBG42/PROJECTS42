import React from 'react';

// const App = () => {
//   const livros = [
//     { nome: 'A Game of Thrones', ano: 1996 },
//     { nome: 'A Clash of Kings', ano: 1998 },
//     { nome: 'A Storm of Swords', ano: 2000 },
//   ];

//   return (
//     <ul>
//       {livros.map(({nome, ano}) => {
//         return <li key={nome}>
//           {nome}, {ano}
//         </li>
//       })}
//     </ul>
//   )
// }

// Organize os produtos como mostrado no vídeo
// Mostre apenas produtos que forem mais caros que R$ 1500
const produtos = [
  {
    id: 1,
    nome: 'Smartphone',
    preco: 'R$ 2000',
    cores: ['#29d8d5', '#252a34', '#fc3766'],
  },
  {
    id: 2,
    nome: 'Notebook',
    preco: 'R$ 3000',
    cores: ['#ffd045', '#d4394b', '#f37c59'],
  },
  {
    id: 3,
    nome: 'Tablet',
    preco: 'R$ 1500',
    cores: ['#365069', '#47c1c8', '#f95786'],
  },
];

const produtosAcimaDe1500 = produtos.filter((produto) => +produto.preco.replace("R$ ", "") > 1500) 
 

const App = () => {
  return (
  <section>
    { produtosAcimaDe1500.map(({nome, preco, cores}) => {
      return (
        <div>
          <h1>{nome}</h1>
          <p>Preço: R$ {preco}</p>
          <p style={{background:cores[0], color: "white"}}>{cores[0]}</p>
          <p style={{background:cores[1], color: "white"}}>{cores[1]}</p>
          <p style={{background:cores[2], color: "white"}}>{cores[2]}</p>
        </div>
      );
    })}
  </section>
  );
};


export default App;
