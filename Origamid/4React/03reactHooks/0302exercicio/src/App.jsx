import React from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {
  const [data, setData] = React.useState(null);

  async function handleClick(e) {
    fetch(`https://ranekapi.origamid.dev/json/api/produto/${e.target.innerText}`)
      .then(data => data.json())
      .then(json => {
        setData(json)
        localStorage.setItem('produto', json.id)
      })
  }


  React.useEffect(() => {
    let produtoSalvo = localStorage.getItem('produto');
    if (produtoSalvo !== null) {
      fetch(`https://ranekapi.origamid.dev/json/api/produto/${produtoSalvo}`)
      .then(data => data.json())
      .then(json => setData(json))
    }
  }, [])

  return (
    <main>
      <div>
        <h2>Preferência: {data && data.nome}</h2>
        <button style={{marginRight: "1rem"}} onClick={handleClick}>notebook</button>
        <button onClick={handleClick}>smartphone</button>
      </div>
        {data && (
          <div>
            <h1>{data.nome}</h1>
            <p>R$ {data.preco}</p>
          </div>
        )}
    </main>
  )
}

export default App
