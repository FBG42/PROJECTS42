// Selecione cada curso e retorne uma array
// com objetos contendo o título, descricao,
// aulas e horas de cada curso
let sections = Array.from(document.querySelectorAll(".curso"));
let cursoArrays = sections.map((curso) => {
   return Array.from(curso.children);
});
let cursos = cursoArrays.map((curso) => {
   return curso.map((item) => {
       return [item.outerHTML.slice(0, 3), item.innerHTML]
   })
});

cursos.map((curso) => {
  curso.map((item) => {
    if (item[0].includes('h1'))
    {
      return  item[0] = item[0].replaceAll('<h1', 'Curso')
    } 
    else if (item[0].includes('p'))
    {
      return   item[0] = item[0].replaceAll('<p>', 'Descrição')
    }  
    else if (item[0].includes('<sp'))
    {
      return  item[0] = item[0].replaceAll('<sp', 'Aulas')
      console.log(item[0])
    }
  });
});
console.log(cursos)




// Retorne uma lista com os
// números maiores que 100
const numeros = [3, 44, 333, 23, 122, 322, 33];


// Verifique se Baixo faz parte
// da lista de instrumentos e retorne true
const instrumentos = ['Guitarra', 'Baixo', 'Bateria', 'Teclado']


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
]
;