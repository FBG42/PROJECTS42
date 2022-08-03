import Coutdown from './countdown.js';

const tempoParaONatal = new Coutdown(' 24 December 2022 23:59:59 GMT-0300 ');
const tempoParaOAnoNovo = new Coutdown(' 31 December 2022 23:59:59 GMT-0300 ');

console.log(tempoParaONatal.total);

setInterval(() => {
	console.log(tempoParaOAnoNovo.total);
}, 1000);

