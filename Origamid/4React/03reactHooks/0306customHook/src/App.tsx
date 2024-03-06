import React from 'react'
import useLocalStorage from './useLocalStorage'
import useFetch, { typesReturnsOfFetch } from './useFetch'

export type produtoType = {
  nome: string
  id: number
}

function App() {
  const [produto, setProduto] = useLocalStorage('produto', '')
  const {request, data, loading, error}: typesReturnsOfFetch = useFetch()

  function handleClick(event: React.MouseEvent<HTMLButtonElement>) {
    const target = event.currentTarget
    if (target instanceof HTMLButtonElement) {
      (setProduto as React.Dispatch<React.SetStateAction<string>>)(target.innerText)
    }
  }

  React.useEffect(() => {
    const fetchData = async () => {
      try {
       const result = await request('https://ranekapi.origamid.dev/json/api/produto/')

       if (result) {
        const { response, json } = result;
        console.log(response, json)
       }
      } catch(err) {
        console.error(err)
      }
    }

    fetchData()
  }, [request])

  if (error) return <p>{JSON.stringify(error)}</p>
  if (loading) return <p>Carregando...</p>
  if (data) {
    return (
      <>
        <p>Produto preferido {produto && String(produto)}</p>
        <button onClick={handleClick}>notebook</button>
        <button onClick={handleClick}>smartphone</button>

        {data.map((produto: produtoType) => (
          <div key={produto.id}>
            <h1>{produto.nome}</h1>
          </div>
        ))}
     </>
    )
  }
}

export default App
