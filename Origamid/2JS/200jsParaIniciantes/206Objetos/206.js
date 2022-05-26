var pessoa = {
    nome: 'Fabrício',
    idade:'20',
};

var quadrado = {
    lados:4,
    area(lado) {
        return console.log( lado * lado )
    },
    perimetro(lado) {
        return console.log(this.lados * lado)
    },
    cinco() {
        return console.log(5)
    }
}

quadrado.lados; // 4
quadrado.area(5); // 25
quadrado.perimetro(5) // 20
quadrado.cinco()


var pi = Math.PI; // 3.1415
Math.random(); // número aleatório


var a = {};

console.log(typeof a)


var menu = {
    width: 800,
    height:50,
    backgroundColor: '#84E',
}

menu.backgroundColor = '#000'
var bg = menu.backgroundColor;