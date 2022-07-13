// function espera(texto) {
//     console.log(texto);
// }

// setTimeout(espera, 0, 'Passou 0s');

// setTimeout(espera, 2000, 'Passou 2s');


// setTimeout(function() {
//     console.log('Passou 4.2s')
// }, 4210);

// setTimeout(() => {
//     console.log('Se passou 8.4s')
// }, 8420);


// for(let i = 0; i <= 20; i++) {
//     setTimeout(() => {
//         console.log(i, 420 * i);
//     }, 420 * i);
// }

// 

function loop(texto) {
    console.log(texto);
}

// setInterval(loop, 300, '300ms');

let i = 0;
const meuLoop = setInterval(() => {
    console.log(i++);
    if(i > 20) {
        clearInterval(meuLoop);
    }
}, 300);