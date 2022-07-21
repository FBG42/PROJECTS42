// const doc = fetch('./doc.txt');
// const styleR = fetch('./style.css');
// const cep = fetch('https://viacep.com.br/ws/01001000/json');


// doc.then(resolucao => resolucao.text())
// .then(body => {
//     const teste = document.querySelector('.teste');
//     teste.innerText = body;
//     console.log(body)
// })

// cep.then(r => r.json())
// .then(body => {
//     const conteduo = document.querySelector('.conteudo');
//     conteduo.innerText = body.logradouro;
// })

// styleR.then(r => r.text())
// .then(body => {
    //     const teste = document.querySelector('.teste');
    //     const style = document.createElement('style');
    
    //     style.innerHTML = body;
//     teste.appendChild(style);
// })


// const sobre = fetch('./sobre.html');

// const div = document.createElement('div');

// sobre.then(r => r.text())
// .then(body => {
//     div.innerHTML = body;
//     const titulo = div.querySelector('h1');
//     document.querySelector('h1').innerText = titulo.innerText

//     console.log(titulo);
//     console.log(div);
// })


// const imagem = fetch('./dean.jpg');

// imagem.then(r => r.blob())
// .then(body => {
//     const blobUrl = URL.createObjectURL(body);
//     const imagemDom = document.querySelector('img');
//     imagemDom.src = blobUrl;
// })


const cep = fetch('https://viacep.com.br/ws/01001000/json');

// cep.then(r => {
//     const r2 = r.clone();
//     r.text().then((text) => {
//         console.log(text);
//     });
//     r2.json().then((json) => {
//         console.log(json);
//     });
// })


cep.then(response => {
    console.log(response.type);
});