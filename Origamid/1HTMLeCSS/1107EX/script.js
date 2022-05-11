const botao = document.querySelector(".adicionar");

if (Boolean(botao)) {
  botao.addEventListener("click", Somar);

  function Somar() {
    const numero = document.querySelector(".numero");
    const total = Number(numero.innerText) + 1;

    if (total < 10) {
      numero.innerText = total;
    }
  }
}
