// Transforme o objeto abaixo em uma Constructor Function
function Pessoa(nome, idade)  {
    this.nome = nome;
    this.idade = idade + ' anos';
    this.andar = function() {
      console.log(this.nome + ' andou');
    }
  }
  
  // Crie 3 pessoas, João - 20 anos,
  // Maria - 25 anos, Bruno - 15 anos
  const jao = new Pessoa('João', 20)
  const mary = new Pessoa('Maria', 25)
  const brn = new Pessoa('Bruno', 15)
  
  // Crie uma Constructor Function (Dom) para manipulação
  // de listas de elementos do dom. Deve conter as seguintes
  // propriedades e métodos:
  //
  // elements, retorna NodeList com os elementos selecionados
  // addClass(classe), adiciona a classe a todos os elementos
  // removeClass(classe), remove a classe a todos os elementos
  
  function Dom(seletor) {
      const elementLists = document.querySelectorAll(seletor);
      this.elements = elementLists
      this.addClass = (classe) => {
        elementLists.forEach((element) => {
            element.classList.add(classe)
        })
      }
      this.removeClass = (classe) => {
        elementLists.forEach((element) => {
            element.classList.remove(classe)
        })
      }
  }

  const listaItens = new Dom('li')