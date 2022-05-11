const div = document.querySelector('.div')

window.addEventListener('mousemove', alter);

function alter(event) {
   div.style.top = event.y + 'px'

   div.style.left = event.x + 'px'

}

