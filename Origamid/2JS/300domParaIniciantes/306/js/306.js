const listaAnimais = document.querySelector('.animais-lista');

const height =  listaAnimais.scrollHeight;
const animaisTop = listaAnimais.offsetTop;


const primeiroh2 = document.querySelector('h2')

const h2Left = primeiroh2.offsetLeft;
const h2rect = primeiroh2.getBoundingClientRect();

// console.log(h2rect, '"Cordenadas"')


// if(h2rect.top <= 0) {
//   console.log('Passou do elemento')
// }

// console.log(
//   window.innerWidth, 'Largura da janela',
//   window.innerHeight, 'Altura da janela',

//   window.outerWidth, 'Largura da janela + Barra DevTools',
//   window.outerHeight, 'Altura da janela + Aba e barra de pesquisa',
// );


const small = window.matchMedia('(max-width: 600px').matches;

if(small) {
  console.log('Usuário mobile')
}