const menu = document.querySelector(".menu");

menu.classList.add("ativo", "teste");
menu.classList.remove("teste"); //removeu
menu.classList.toggle("teste"); //

if (menu.classList.contains("teste")) {
  console.log("Possui teste");
}

menu.className += " vermelho";

// console.log(menu.classList);

const animais = document.querySelector(".animais");

console.log(animais);
console.log(animais.attributes);

const img = document.querySelector("img");
const srcImg = img.getAttribute("src");
const altImg = img.getAttribute("alt");

console.log(srcImg);
console.log(altImg);

img.setAttribute("alt", "É uma raposa");
console.log(altImg);
