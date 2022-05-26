

// for (var n = 0; n < 10;) {  INFINITE LOOP    
//     console.log(n)
// }

// for (var n = 0; n < 10; n++) {
//     console.log(n)
// }


// var i = 0;
// while (i < 10) {
//   console.log(i);
//   i++;
// }
// // Retorna de 0 a 9 no console




var linguagens = ['Python', 'Ruby', 'Javascript', 'CSS', 'Perl', 'Html', 'Java'];

linguagens[0] // Python
linguagens[2] // Javascript


for (var item = 0; item < linguagens.length; item++) {
    console.log(linguagens[item])
    if(linguagens[item] === 'CSS') {
        break;
    }
}

var animais = ['Cachorro', 'Gato', 'Passaro', 'Papagaio', 'Golfinho', 'Ornitorinco']

animais.forEach(function(animal, index) {
    console.log(animal, index)
})