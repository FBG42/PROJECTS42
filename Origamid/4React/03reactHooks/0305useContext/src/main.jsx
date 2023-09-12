import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App.jsx'
import './index.css'
import userContext from './UserContext.js'

ReactDOM.createRoot(document.getElementById('root')).render(
  <userContext.Provider value={{nome: "Fabrício"}}>
    <App />
  </userContext.Provider>,
)
