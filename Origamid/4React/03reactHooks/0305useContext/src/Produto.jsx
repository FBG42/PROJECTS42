import React from 'react'
import UserContext from './UserContext';
import { GlobalContext } from './GlobalContext';

const Produto = (props) => {
  const dados = React.useContext(UserContext);
  const data = React.useContext(GlobalContext)

  return (
    <section>
      <div>{dados.nome}</div>
      <div>{data.contar}</div>
      <button onClick={data.adicionarDois}>Adicionar</button>
    </section>
  )
}

export default Produto