// Duplique o menu e adicione ele em copy
const menu = document.querySelector('.menu')
const copy = document.querySelector('.footer')

const cloneMenu = menu.cloneNode(true)


copy.appendChild(cloneMenu)
// Selecione o primeiro DT da dl de Faq
const dl = document.querySelector('dl')

const primeiroDT = dl.querySelector('dt')
console.log(primeiroDT)

// Selecione o DD referente ao primeiro DT
console.log(primeiroDT.nextElementSibling)
// Substitua o conteúdo html de .faq pelo de .animais

const faq = document.querySelector('.faq')
const animais = document.querySelector('.animais')
const animaisConteudo = document.querySelector('.animais-descricao')

faq.innerHTML = animaisConteudo.innerHTML;