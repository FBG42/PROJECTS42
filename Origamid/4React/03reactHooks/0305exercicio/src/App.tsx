import React from 'react'
import { GlobalContext, GlobalStorage } from './globalContext'

export default function App() {
  const context = React.useContext(GlobalContext)

  React.useEffect(() => {
    // Este useEffect será executado quando context?.dados for alterado.
    console.log('Dados atualizados:', context?.dados);
  }, [context?.dados]);

  return (
    <GlobalStorage>
      <GlobalContext.Consumer>
        {(context) => (
          <>
            <p>{context?.dados && JSON.stringify(context.dados)}</p>
            <button onClick={() => context?.fetchDados()}>Pesquisar dados</button>
            <button onClick={() => context?.limparDados()}>Limpar dados</button>
          </>
        )}
      </GlobalContext.Consumer>
    </GlobalStorage>
  )
}
