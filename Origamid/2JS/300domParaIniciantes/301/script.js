const href = window.location.href

console.log(href)



const h1 = document.querySelector('h1')

const h1CLasses = h1.classList

h1.addEventListener('click', callbackh1)

function callbackh1() {
    console.log('Ciclou em', h1.innerText)
}