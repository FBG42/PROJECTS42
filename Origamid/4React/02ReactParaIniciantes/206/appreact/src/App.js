import React from 'react';

const titulo = <h1>Esse é um título</h1>;

function App() {
  const random = Math.random();
  const ativo = true;
  return (
    // <a href="https://origamid.com" className="ativo" title="Plataforma digital de cursos sobre Front-End">
    //   Origamid
    // </a>

    // <React.Fragment>
    //   <label htmlFor="nome">Nome</label>
    //   <input type="text" id="nome"></input>
    // </React.Fragment>
      
    <>
      {titulo}
      <p className={ativo ? 'ativo' : 'inativo'}>{(random * 1000) / 50}</p>
    </>
  );
}

export default App;
