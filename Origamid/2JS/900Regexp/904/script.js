// const regexp = /\w+/gi;

// const regexp1 = new RegExp('\\w+', 'gi')

// console.log(frase.replace(regexp1, 'X'));

// console.log(regexp.test(frase));


// const regexp = /Java/g;
// const frase =  'Javascript e Java Linguagem 101, Java';

// let i = 0;
// while(regexp.test(frase)) {
//    console.log(i++, regexp.lastIndex);
// }


const frase = 'JavaScript, typeScript, coffeeScript, java';

const regexp = /\w+/g;

let i = 0;
while(regexp.exec(frase)) {
   console.log(++i);
}