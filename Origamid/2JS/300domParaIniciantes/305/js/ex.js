const menu = document.querySelectorAll(".menu ul li");
console.log(menu);

// Adicione a classe ativo a todos os itens do menu
menu.forEach((li) => {
  li.classList.add(".ativo");
  console.log(li.classList, "Adicionando");
});
// Remove a classe ativo de todos os itens do menu e mantenha apenas no primeiro
menu.forEach((li, index) => {
  if (index >= 1) li.classList.remove(".ativo");
  console.log(li.classList, "Removendo");
});

// Verifique se as imagens possuem o atributo alt
const imgs = document.querySelectorAll("img");

imgs.forEach((img) => {
  if (img.hasAttribute("alt")) {
    console.log("Todas as imagens contém alt");
  } else if (!img.hasAttribute("alt")) {
    console.log(
      img.attributes,
      "Procure a imagem que não contem alt, e ponha!"
    );
  }
});

// Modifique o href do link externo no menu

const ultimoLi = menu[menu.length - 1];
 ultimoLi.setAttribute('href', 'seila.com')
