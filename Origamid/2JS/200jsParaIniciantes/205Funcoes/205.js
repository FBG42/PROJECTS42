function areaQuadrado(lado) {
  return lado * lado;
}

console.log(areaQuadrado(42));

function pi() {
  return 3.1415;
}

var total = 5 * pi(); // 15.
console.log(total);

function img(peso, altura) {
  const imc = peso / (altura * altura);
  return imc;
}

console.log(img(76, 1.71), "IMC de Fabrício");

function corFavorita(cor) {
  if (cor === "azul") {
    return "Eu gosto do céu";
  } else if (cor === "verde") {
    return "Eu gosto de mato";
  } else {
    return "Eu não gosto de cores";
  }
}

// addEventListener('click', function(){ console.log('Oi') });

function terceiraIdade(idade) {
  if (typeof idade !== "number") {
    return "Informe a sua idade!";
  } else if (idade >= 60) {
    return "Você é velho!";
  } else {
    return "Você não é velho!";
  }

  console.log('Depois do return nada acontece')
}

//   console.log(terceiraIdade(gaga))

console.log(terceiraIdade(60));

console.log(terceiraIdade(42));




function faltaVisitados(paisesVisitados) {
    var totalPaises = 193;
    return `Faltando visitar ${totalPaises - paisesVisitados} países`
}

console.log(faltaVisitados(42))
// console.log(totalPaises)