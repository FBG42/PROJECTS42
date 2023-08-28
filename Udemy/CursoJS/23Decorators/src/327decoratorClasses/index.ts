const pessoas = [
  {"Nome": "Vanessa", "Sobrenome": "Dutra", "Idade": 24},
  {"Nome": "Diogo", "Sobrenome": "Magalhães", "Idade": 27},
  {"Nome":  "Alice", "Sobrenome": "Ferraz", "Idade": 19},
  {"Nome": "Manuel", "Sobrenome": "Nobre", "Idade": 21},
  {"Nome": "Carlos" , "Sobrenome": "Evangelista", "Idade": 37}
];

const nomeProcurado = "Alice";
const pessoaEncontrada = pessoas.find((pessoa) => pessoa.Nome === nomeProcurado);

console.log(pessoaEncontrada); // Output: {"Nome": "Alice", "Sobrenome": "Ferraz", "Idade": 19}
