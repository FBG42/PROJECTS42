// function perimetroForma(lado, totalLados, ...listaArgumentos) {
//    console.log(listaArgumentos);
//    console.log(arguments);
//    return lado * totalLados;
// }


// perimetroForma(10, 20, 30, 'teste', 'seila'); // 40
// // perimetroForma(10); // NaN



// function anunciarGanhadores(premio, ...ganhadores) {
//    ganhadores.forEach(ganhador => {
//       console.log(`${ganhador} ganhou um ${premio}`);
//    })
// };

// const ganhadores = ['Pedro', 'Marta', 'Maria', 'Beto']

// anunciarGanhadores('Carro', ...ganhadores);

// const frutas = ['Banana', 'Uva', 'Morango', 'Tomate'];
// const legumes = ['Cenoura', 'Batata'];

// const comidas = [...frutas, 'Pizza', ...legumes];

// console.log(comidas);

// const todosOsNumeros = [3,4,5,123,12,32,32,321,32];

// const numeroMaximo = Math.max(...todosOsNumeros);

// console.log(numeroMaximo)


const btns = document.querySelectorAll('button');

console.log(btns);

const btnsArray = [...btns]

console.log(btnsArray);