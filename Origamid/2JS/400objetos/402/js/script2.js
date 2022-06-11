const pais = 'Brasil';

const listaAnimais = ['Cachorro', 'Gato', 'Cavalo']


const lista = document.querySelectorAll('li');

// Transforma em uma array
const listaArray1 = Array.prototype.slice.call(lista);
const listaArray2 = Array.from(lista);