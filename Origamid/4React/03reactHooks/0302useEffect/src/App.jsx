import { useState } from 'react'
import './App.css'
import Produto from './Produto';

function App() {
  // const [count, setCount] = useState(0);
  // const [data, setData] = useState(null);
  const [ativo, setAtivo] = useState(false);

  // React.useEffect(() => {
  //   fetch('https://ranekapi.origamid.dev/json/api/produto/notebook')
  //     .then((response) => response.json())
  //     .then((json) => setData(json))
  // }, [])

  return (
    // <div>
    //   {data && (
    //     <div>
    //       <h1>{data.nome}</h1>
    //       <p>{data.preco * count}</p>
    //     </div>
    //   )}
    //   <button onClick={() => setCount(count + 1)}>{count}</button>
    // </div>

    <div>
      {ativo && <Produto />}
      <button onClick={() => setAtivo(!ativo)}>Ativar</button>
    </div>
  )
}

export default App
