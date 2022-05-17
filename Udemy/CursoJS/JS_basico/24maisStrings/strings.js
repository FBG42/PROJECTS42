// Strings são uma sequência númerica
let umaString = 'um "texto"';
let umaStringConfusa = "um \"texto\""  ;
// Uma forma de utilizar aspas dentro das mesmas aspas, são com a barra invertida
let outraStringConfusa = "um \\texto\\"; 
// Para poder utilizar uma barra invertida dentro da barra invertida



// Strings tem indices, com isso queremos dizer que cada uma tem um caracter
//                     012345678  
const stringIndice =  'index 6 8'

console.log(stringIndice[4])
console.log(stringIndice.charAt(6))


// As três formas de concatenar
const texto = "Hoje estamos";

console.log(texto.concat(' em um lindo dia.'))
console.log(texto + ' em um lindo dia.')
console.log(`${texto} em um lindo dia.`) // Mais eficaz

// Para vermos em qual indice começa a palavra estamos
console.log(texto.indexOf('estamos'));
console.log(texto.indexOf('o', 3)); // onde tem a letra o após a linha 3?
console.log(texto.lastIndexOf('o', 3)); /* last indica que começa do ultimo item, para o primeiro */

console.log(texto.match(/[0-z]/g)); // Uma expressão relugar, não explicada pelo professor

console.log(texto.search(/x/)); // encontrará a letra x

console.log(texto.replace('estamos', 'deveriamos estar')); // substituirá o primeiro pelo segundo

//            0123456789
const rato = "O rato roeu a roupa do rei de roma";

console.log(rato.replace(/r/, '#'));
console.log(rato.replace(/r/g, '#'));
console.log(rato.length) 
console.log(rato.slice(2, 6)) //irá me retornar os indices 
console.log(rato.slice(-4)) 
console.log(rato.length - 4) 
console.log(rato.slice(30)) 

console.log(rato.split(' ')) // Irá me retornar a palavra 

console.log(rato.toLocaleUpperCase())
console.log(rato.toLocaleLowerCase())
