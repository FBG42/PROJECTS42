// console.log(Number.isNaN("ds"));
// console.log(Number.isInteger(10));
// console.log(Number.isInteger(10.1));

// console.log(Number.parseFloat('32434,324'), 'Number.parseFloat');
// console.log(Number.parseFloat('R$ 32434,324'));
// console.log(Number.parseFloat('32434,324 reais'));
// console.log(Number.parseFloat('32434.324'));
// console.log(Number.parseInt('32.4213123'));

const preco = 10.3232;
console.log(preco.toFixed()); // Retorna uma string o toFixed()

let valor = 48.49;
valor = valor.toLocaleString("pt-BR", { style: "currency", currency: "BRL" });
let US = valor.toLocaleString("en-US", { style: "currency", currency: "USD" });

console.log(valor);
console.log(US);

const aleatorio = Math.round(Math.random() * 420);

console.log(aleatorio);
