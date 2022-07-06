// Retorne a soma total de caracteres dos
// parágrafos acima utilizando reduce
const paras = document.querySelectorAll('section p');


let total = Array.prototype.reduce.call(paras,(acumulador, p) => {
    console.log(p.innerText.length)
    return acumulador + p.innerText.length
}, 0);

console.log(total);

//

// Crie uma função que retorne novos elementos
// html, com os seguintes parâmetros
// tag, classe e conteudo.

function retorno(tag, classe, conteudo) {
   const elemento = document.createElement(tag);
   classe ? elemento.classList.add(classe) : null;
   conteudo ? elemento.innerHTML = conteudo : null;
    return elemento
}
console.log(retorno('p', 'teste', "blablabla"));

// Crie uma nova função utilizando a anterior como base
// essa nova função deverá sempre criar h1 com a
// classe titulo. Porém o parâmetro conteudo continuará dinâmico

const base = retorno.bind(null, 'h1', 'teste');

console.log(base('finalizado'));
//