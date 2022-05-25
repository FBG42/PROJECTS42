// Crie uma array com os anos que o Brasil ganhou a copa
// 1959, 1962, 1970, 1994, 2002

var anosCampeao = [1959, 1962, 1970, 1994, 2002];

// Interaja com a array utilizando um loop, para mostrar
// no console a seguinte mensagem, `O brasil ganhou a copa de ${ano}`
anosCampeao.forEach(function(ano) {
  console.log(`O brasil ganhou a copa de ${ano}`);
});

// Interaja com um loop nas frutas abaixo e pare ao chegar em Pera
var frutas = ["Banana", "Maçã", "Pera", "Uva", "Melância"];

for (var i = 0; i <= frutas.length; i++) {
    console.log(frutas[i])

    if(frutas[i] === 'Pera'){
        break;
    }
}

// Coloque a última fruta da array acima em uma variável,
// sem remover a mesma da array.

var ultimaFruta1 = frutas.slice(4)
var ultimaFruta2 = frutas[frutas.length - 1]; // forma mais correta

console.log(ultimaFruta1)
console.log(ultimaFruta2)
console.log(frutas)