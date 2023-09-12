import React from 'react';
import './App.css'
import { dataContext } from './dataContext'

function App() {
  const data = React.useContext(dataContext);

  console.log(data)

  return (
    <>
      {data.data && (
        <div>{data.data[0].id}</div>
      )}
    </>
  )
}

export default App
