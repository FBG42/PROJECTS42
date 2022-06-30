// Selecione cada curso e retorne uma array
// com objetos contendo o título, descricao,
// aulas e horas de cada curso
function Curso(titulo, desc, aulas, horas) {
  this.titulo =  titulo;
  this.desc = desc;
  this.aulas = aulas;
  this.horas = horas;
}

let sections = Array.from(document.querySelectorAll(".curso"));
let cursoArrays = sections.map((curso) => {
   return Array.from(curso.children);
});
let cursos = cursoArrays.map((curso) => {
   return curso.map((item) => {
       return [item.outerHTML.slice(0, 3), item.innerHTML, item.className]
   })
});

cursosObj = [];

cursos.forEach((curso) => {
  let objeto = new Curso();
  curso.forEach((item, index) => {
    if (item[0].includes('<h1'))
    {
      objeto.titulo = item[1];
    }
    else if (item[0].includes('<p>'))
    {
      objeto.desc = item[1];
    }
    else if (item[0].includes('<sp') && item[2] === 'aulas')
    {
      objeto.aulas = item[1];
    }
    else if (item[0].includes('<sp') && item[2] === 'horas')
    {
      objeto.horas = item[1];
      cursosObj.push(objeto);
    }
  })
});
console.log(cursosObj);
//



// Retorne uma lista com os
// números maiores que 100
const numeros = [3, 44, 333, 23, 122, 322, 33];
const maiores100 = [];

  numeros.forEach((numero) => {
    if (numero > 100)
    {
      maiores100.push(numero);
    }
  });

  console.log(maiores100);

// Verifique se Baixo faz parte
// da lista de instrumentos e retorne true
const instrumentos = ['Guitarra', 'Baixo', 'Bateria', 'Teclado']

const isTrue = instrumentos.some((instrumento) => {
  return instrumento === 'Baixo';
});

console.log(isTrue)
//



//
// Retorne o valor total das compras
const compras = [
  {
    item: 'Banana',
    preco: 'R$ 4,99'
  },
  {
    item: 'Ovo',
    preco: 'R$ 2,99'
  },
  {
    item: 'Carne',
    preco: 'R$ 25,49'
  },
  {
    item: 'Refrigerante',
    preco: 'R$ 5,35'
  },
  {
    item: 'Quejo',
    preco: 'R$ 10,60'
  }
];

let total = 0;

compras.forEach((compra) => {
  let nmrLimpo;
  nmrLimpo = +compra.preco.replace('R$ ', '').replace(',', '.');
  total += nmrLimpo;
  console.log(compra.preco, nmrLimpo, total);
});

console.log(`O preço total das compras foi R$${total}`)