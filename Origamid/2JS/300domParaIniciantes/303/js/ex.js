// Retorne no console todas as imagens do site
const imgs = document.querySelectorAll("img");
console.log(imgs, "Todas imgs do site");

// Retorne no console apenas as imagens que começaram com a palavra imagem
const imagens = document.querySelectorAll('[src^="./img/imagem"]');
console.log(imagens, "Imagens que começam com imagem");

// Selecione todos os links internos (onde o href começa com #)
const links = document.querySelectorAll('[href^="#"]');
console.log(links, "Links internos");

// Selecione o primeiro h2 dentro de .animais-descricao
const primeiroH2 = document.querySelector(".animais-descricao h2");
console.log(primeiroH2, "Primeiro h2 da descrição");

// Selecione o último p do site
const ultimoP = document.querySelectorAll("p");
console.log(ultimoP[--ultimoP.length], "Ultimo Paragrafo do site");
