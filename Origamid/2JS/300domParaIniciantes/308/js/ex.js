// Quando o usuário clicar nos links internos do site,
// adicione a classe ativo ao item clicado e remova dos
// demais itens caso eles possuam a mesma. Previna
// o comportamento padrão desses links
const links = document.querySelectorAll('a[href^="#"]');

links.forEach((link) => {
  link.addEventListener("click", handleClick);
});
function handleClick(event) {
  this.classList.toggle("ativo");
  event.preventDefault();
}

// Selecione todos os elementos do site começando a partir do body,
// ao clique mostre exatamente quais elementos estão sendo clicados
const todosElementos = document.querySelectorAll('body')

todosElementos.forEach((elemento) => {
    elemento.addEventListener('click', mostrarElemento)
})

function mostrarElemento(elemento) {
    elemento.target.remove()

}
// Utilizando o código anterior, ao invés de mostrar no console,
// remova o elemento que está sendo clicado, o método remove() remove um elemento



// Se o usuário clicar na tecla (t), aumente todo o texto do site.
const textos = document.querySelectorAll('*')


textos.forEach((texto) => {
    texto.addEventListener('keydown', handleKeyboard)
})

function handleKeyboard(event) {
    if(event.key === 't') {
        this.classList.toggle('textogrande')
    }
}