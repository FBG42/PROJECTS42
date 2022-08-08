// // const carro = {
// //    marca: 'Honda',
// //    ano: 2018,
// // };

// // const {marca, ano, portas} = carro;

// // console.log(carro.marca);
// // console.log(marca, ano, portas);

// const cliente = {
//    nome: 'Fabrício',
//    compras: {
//       digitais: {
//          livros: ['Livro 1', 'Livro 2'],
//          videos: ['Video JS', 'Video HTML']
//       },
//       fisicas: {
//          cadernos: ['Caderno 1']
//       }
//    }
// }

// // console.log(cliente.compras.digitais.livros)
// // console.log(cliente.compras.digitais.videos)

// // const {livros, videos} = cliente.compras.digitais;
// const {digitais, fisicas, digitais: {livros, videos}} = cliente.compras;

// console.log(livros, 'Destructuring');
// console.log(videos, 'Destructuring');
// console.log(digitais, 'Destructuring');
// console.log(fisicas, 'Destructuring');


// const cliente = {
//    nome: 'Fabrício',
//    compras: 10,
// };

// const {nome: nomeFabricio, email = 'email@gmail.com'} = cliente;

// console.log(nomeFabricio, email);


// const frutas = ['Banana', 'Uva', 'Morango'];

// const [primeira, segunda, terceira] = frutas;


// console.log(frutas[0]);
// console.log(frutas[1]);
// console.log(frutas[2]);
// console.log(primeira);
// console.log(segunda);
// console.log(terceira);

// const [primeiro, segundo, terceiro] = ['Item 1', 'Item 2', 'Item 3'];

// console.log(terceiro)

function handleKeyboard({key, keyCode}) {
   console.log(key, keyCode)
}


document.addEventListener('keyup', handleKeyboard);