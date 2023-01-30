const nome = prompt("Digite seu nome completo: ");
document.body.innerHTML += `O seu nome é:${nome} <br>`;

document.body.innerHTML += `O seu nome tem:${nome.length} letras <br>`;

document.body.innerHTML += `A segunda letra do seu nome é:${nome[2]} <br>`;

document.body.innerHTML += `O primeiro indice da letra i no seu nome é:${nome.search(/i/)} <br>`;

document.body.innerHTML += `O ultimo indice da letra i no seu nome é:${nome.lastIndexOf('i')} <br>`;

document.body.innerHTML += `As ultimas três letras do seu nome são ${nome.slice(-3)} <br>`;

document.body.innerHTML += `As palavras do seu nome são ${nome.split(" ")} <br>`;

document.body.innerHTML += `Seu nome com letra maiúsculas ${nome.toUpperCase()} <br>`;

document.body.innerHTML += `Seu nome com letra minúsculas ${nome.toLowerCase()} <br>`;


//  Fabrício Bittencourt Grigolo