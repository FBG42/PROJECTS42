const img = document.querySelector('img')

// img.addEventListener('click', callback)
// function callback(event) {
//   console.log(event)
  
// }


const animaisLista = document.querySelector('.animais-lista')

animaisLista.addEventListener('click', callbackLista)
function callbackLista(event) {
  console.log(event.currentTarget) 
  console.log(event.target) 
}


const linkExterno = document.querySelector('a[href^="http"]')

linkExterno.addEventListener('click', handleLinkExterno)
function handleLinkExterno(event) {
  event.preventDefault();
  console.log(event)
  console.log(this.getAttribute('hre'))
  console.log(event.currentTarget)
}


const h1 = document.querySelector('h1')
// h1.addEventListener('click', handleEvent)
// h1.addEventListener('mouseenter', handleEvent)
// h1.addEventListener('mousemove', handleEvent)

function handleEvent(event) {
  console.log(event.type, event)
}

// window.addEventListener('scroll',handleEvent)
// window.addEventListener('resize',handleEvent)
// window.addEventListener('keydown',handleEvent)


window.addEventListener('keydown', handleKeyboard);

function handleKeyboard(event) {
  if(event.key === 'f') {
    document.body.classList.toggle('fullscreen')
  }
  console.log(event.key)
};
