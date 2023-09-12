import React from "react";

export const dataContext = React.createContext();

export const DataStorage = ({ children }) => {
   const [data, setData] = React.useState({});

   React.useEffect(() => {
      fetch("https://ranekapi.origamid.dev/json/api/produto/")
         .then(data => data.json())
         .then(json => setData(json));
   }, [])

   function clearData() {
      setData(null)
   }

   return (
      <dataContext.Provider value={{ data, setData, clearData }}>
         {children}
      </dataContext.Provider>
   )
}
