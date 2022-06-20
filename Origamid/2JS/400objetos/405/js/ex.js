// Retorne um número aleatório
// entre 1050 e 2000
const ale = Math.floor(Math.random() * (2000 - 1050 + 1) + 1050);
console.log(ale);

// Retorne o maior número da lista abaixo
let numeros = "4, 5, 20, 8, 9";
let numeroArray = [];

numeros = numeros.split(", ");
console.log(numeros);
numeros.forEach((numero) => {
  numero = Number.parseInt(numero);
  numeroArray.push(numero);
});
console.log(Math.max(...numeroArray));


// Crie uma função para limpar os preços
// e retornar os números com centavos arredondados
// depois retorne a soma total

const listaPrecos = ["R$ 59,99", " R$ 100,222", "R$ 230  ", "r$  200"];

let total = 0;
function limpar(array) {
  let itemAtribuido;
  array.forEach((item) => {
    if (item.includes("R$")) {
      itemAtribuido = item.replace("R$", "");
    } else {
      itemAtribuido = item.replace("r$", "");
    }
    itemAtribuido = itemAtribuido.replaceAll(",", ".");
    itemAtribuido = Math.round(itemAtribuido);
    total += itemAtribuido;
    return total;
  });
}

limpar(listaPrecos);
console.log(total)