// Utilizando a API https://viacep.com.br/ws/${CEP}/json/
// crie um formulário onde o usuário pode digitar o cep
// e o endereço completo é retornado ao clicar em buscar


// const viaURL = 'https://viacep.com.br/ws/${CEP}/json/';
// const formCEP = document.getElementById('formCEP');
// const resposta = document.querySelector('.resposta');

// function pegarCEP(event) {
//     event.preventDefault();
//     const CEP = event.target.value;
//     const url = viaURL.replace('${CEP}', CEP);

//     fetch(url).then((response) => {
//         return response.text()
//     }).then((text) => {
//         resposta.innerHTML = text;
//     })
// }

// formCEP.addEventListener('change', pegarCEP);



// Utilizando a API https://blockchain.info/ticker
// retorne no DOM o valor de compra da bitcoin and reais.
// atualize este valor a cada 30s
const compra = document.querySelector('.compra');
const real = document.querySelector('.real');

// setTimeout(() => {
//     fetch('https://blockchain.info/ticker').then((response) => {
//         return response.json();
//     }).then((json) => {
//         console.log(json.BRL);
//         compra.innerText = json.BRL.buy;
//         real.innerText = json.BRL.buy;
//     })
// }, 0)


// Utilizando a API https://api.chucknorris.io/jokes/random
// retorne uma piada randomica do chucknorris, toda vez que
// clicar em próxima
const botao = document.querySelector('.btnPiada');
const piada = document.querySelector('.piada');

function gerarPiada() {
    fetch('https://api.chucknorris.io/jokes/random')
    .then(response => {
        return response.json()
    }).then(json => {
        piada.innerText = json.value;
    })
}


botao.addEventListener('click', gerarPiada);