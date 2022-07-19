const contato = document.querySelector('#contato');
const texto = document.querySelector('.texto');

const dados = {};


function handleKeyUp(event) {
    const target = event.target;

    if(!target.checkValidity()) {
        target.classList.add('invalido');
        contato.nome.setCustomValidity('Nome é totalmente necessário.');
        target.nextElementSibling.innerText = target.validationMessage;
    }

    document.body.style.backgroundColor = event.target.value;

    if(target.checked) {
        console.log(target.value);
    }

    dados[event.target.name] = event.target.value;
}

contato.addEventListener('change', handleKeyUp);