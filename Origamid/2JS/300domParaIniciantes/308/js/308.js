// const h1 = document.querySelector("h1");
// const animaisDescricao = document.querySelector(".animais-descricao");

// console.log(h1.innerHTML);
// console.log(h1.outerHTML);

// h1.outerHTML = "<h1>Novo Título</h1>";

// const lista = document.querySelector(".animais-lista");

// console.log(lista.parentElement, "O pai da lista");
// console.log(lista.children, "HTMLCollection com os filhos, ou seja array like");

// console.log(lista.children[--lista.children.length]);
// console.log(lista.querySelector("li:last-child"));

// const animais = document.querySelector(".animais");
// const contato = document.querySelector(".contato");
// const titulo = contato.querySelector(".titulo");
// const mapa = document.querySelector(".mapa");

// // contato.removeChild(titulo)
// contato.replaceChild(lista, titulo);


// const novoh1 = document.createElement('h1');
// novoh1.innerText = 'Título Novo'


const h1 = document.querySelector('h1');
const faq = document.querySelector('.faq')

const cloneH1 = h1.cloneNode(true);

faq.appendChild(cloneH1)