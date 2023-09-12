import React from 'react'
import UserContext from './UserContext'
import './App.css'
import Produto from './Produto'
import { GlobalStorage } from './GlobalContext'

function App() {

  console.log(UserContext)

  return (
    <GlobalStorage>
      <Produto />
    </GlobalStorage>
  )
}

export default App
