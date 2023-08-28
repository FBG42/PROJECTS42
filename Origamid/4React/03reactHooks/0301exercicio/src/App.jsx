import React from 'react'
import './App.css';
import Produto from './Produto';

function App() {
  const [dados, setDados] = React.useState(null);
  const [carregando, setCarregando] = React.useState(false)

  function handleClick({target}) {
    setCarregando(true)
    const url = `https://ranekapi.origamid.dev/json/api/produto/${target.innerText}`

    fetch(url)
      .then(dados => dados.json())
      .then(json => setDados(json));
    setCarregando(false);
  }

  return (
    <>
      <div className='ctn-buttons'>
        <button onClick={handleClick}>notebook</button>
        <button onClick={handleClick}>smartphone</button>
        <button onClick={handleClick}>tablet</button>
      </div>

      <div className='ctn-dados'>
        {carregando && <p>Carregando...</p>}
        {!carregando && dados && <Produto dados={dados}/>}
      </div>
    </>
  )
}

export default App
