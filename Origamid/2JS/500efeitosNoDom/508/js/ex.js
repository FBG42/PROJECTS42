// Mude a cor da tela para azul e depois para vermelho a cada 2s.
const body = document.querySelector("body");

function bgAzul() {
  body.style.backgroundColor = "white";
}
function bgVermelho() {
  body.style.backgroundColor = "black";
}

// let i = 0;
// setInterval(() => {
//     if(i % 2 === 0) {
//         bgAzul();
//     }
//     if(i % 2 === 1) {
//         bgVermelho();
//     }
//     console.log(i)
//     i++;
// }, 1000)

// Crie um cronometro utilizando o setInterval. Deve ser possível
// iniciar, pausar e resetar (duplo clique no pausar).

const init = document.querySelector(".btn-init");
const stop = document.querySelector(".btn-reset");
const div = document.querySelector("div p");

let i = 0;
let timer;

function iniciarTempo() {
    timer = setInterval(() => {
        div.innerText = i++
    }, 100);
    init.setAttribute('disabled', '');
}

function pararTempo() {
    clearInterval(timer);
    init.removeAttribute('disabled', '');
}

function resetarTempo() {
    div.innerText = '0';
    i = 0;

}

init.addEventListener("click", iniciarTempo);
stop.addEventListener("click", pararTempo);
stop.addEventListener("dblclick", resetarTempo);
