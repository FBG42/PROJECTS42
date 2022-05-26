// Retorne o url da página atual utilizando o objeto window
const href1 = window.location.href
// Seleciona o primeiro elemento da página que
// possua a classe ativo

const ativo = window.document.querySelector('.ativo')
// Retorne a linguagem do navegador
const linguagem = window.navigator.language
console.log(`A linguagem de preferência do usuário é "${linguagem}"`)
// Retorne a largura da janela 
const largura = window.innerWidth
console.log(`A largura de sua tela é ${largura}px`)