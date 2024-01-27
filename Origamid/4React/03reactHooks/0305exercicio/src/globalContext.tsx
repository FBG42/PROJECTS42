import React, { Dispatch, ReactNode, SetStateAction } from "react";

export const GlobalContext = React.createContext<GlobalContextProps | undefined>(undefined);


type GlobalContextProps = {
  dados: ArrayLike<object> | undefined,
  setDados: React.Dispatch<React.SetStateAction<ArrayLike<object> | undefined>>,
  limparDados: () => void,
  fetchDados: () => void
};


type Props = {
  children: ReactNode
}


export const GlobalStorage = ({ children }: Props) => {
    const [dados, setDados] = React.useState<ArrayLike<object>  | undefined>(undefined)

    async function fetchDados() {
      try {
          const resposta = await fetch("https://ranekapi.origamid.dev/json/api/produto/");
          const dadosFetch = await resposta.json();
          setDados(dadosFetch);
          console.log('cheguei')
        } catch (erro) {
          console.error("Erro ao buscar dados:", erro);
        }
    }

    function limparDados() {
        setDados([])
        console.log('limpei')
    }

    React.useEffect(() => {
      fetchDados();
      console.log(dados)
    }, [])

   const contextValue: GlobalContextProps = {
    dados: dados || [],
    setDados: setDados as Dispatch<SetStateAction<ArrayLike<object> | undefined>>,
    limparDados,
    fetchDados
  };

   return (
      <GlobalContext.Provider value={contextValue}>
         {children}
      </GlobalContext.Provider>
   )
}