// const promessa = new Promise((resolve, reject) => {
//     let condicao = true;
    
//     if (condicao) 
//     {
//         setTimeout(() => {
//             resolve({nome: 'Fabrício', idade: 20});
//         }, 1000);
//     } 
//     else 
//     {
//         reject(Error('Um erro ocorreu na promise'));
//     }
// });

// const retorno = promessa
// .then(resolucao => {
//     resolucao.profissao = 'Desenvolvedor de Software';
//     return resolucao;
// })
// .then((resolucao) => {
//     console.log(resolucao);
// }, 
// rejeitada => {
//     console.log(rejeitada);
// })
// .finally(() => {
//     console.log('Acabou');
// });

// console.log(retorno);



const login = new Promise((resolve) => {
    setTimeout(() => {
        resolve('Usuário logado');
    }, 1000)
})

const dados = new Promise((resolve) => {
    setTimeout(() => {
        resolve('Dados carregados');
    }, 1500)
})

const carregouTudo = Promise.all([login, dados]);
const carregouPrimeiro = Promise.race([login, dados]);

carregouTudo.then((resolucao) => {
    console.log(resolucao);
})
carregouPrimeiro.then((resolucao) => {
    console.log(resolucao);
})
