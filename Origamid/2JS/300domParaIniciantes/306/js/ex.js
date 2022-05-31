// Verifique a distância da primeira imagem
// em relação ao topo da página
const firstImg = document.querySelector("img");

console.log(
  `A primeira imagem da página está a ${firstImg.offsetTop}px de distância do topo.`
);

// Retorne a soma da largura de todas as imagens
const imgs = document.querySelectorAll("img");

let total = 0;
imgs.forEach((img) => {
  let width = img.offsetWidth;
  total += width;

  console.log(`A imagem ${img.innerHTML} atual tem ${width}pxs de largura, tendo o total atual de ${total}`);
});

// Verifique se os links da página possuem
// o mínimo recomendado para telas utilizadas
// com o dedo. (48px/48px de acordo com o google)
const links = document.querySelectorAll("a");
const telaCelular = window.matchMedia("(max-width:800px").matches;

if (telaCelular) {
  links.forEach((link) => {
    if (link.offsetWidth >= 48 && link.offsetHeight >= 48) {
      console.log(`${link}, tem o width e height recomendado pelo google.`);
    } else {
      console.log(
        `"${link.innerHTML}", não tem o width ou height recomendado pelo google.`
      );
      console.log(
        `O height/width respectivamente de "${link.innerHTML}" é ${link.offsetHeight} e ${link.offsetWidth}. `
      );
    }
  });
}
// Se o browser for menor que 720px,
// adicione a classe menu-mobile ao menu
const menu = document.querySelector('.menu');
const media720 = window.matchMedia('(max-width:720px)').matches;



if(media720) {
 menu.classList.add('.menu-mobile')
}