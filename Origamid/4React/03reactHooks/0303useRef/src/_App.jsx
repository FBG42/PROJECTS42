import React from 'react'
import './App.css'

function App() {
  const [comentarios, setComentarios] = React.useState([]);
  const [input, setInput] = React.useState();
  const inputElement = React.useRef();

  function handleClick() {
    setComentarios([...comentarios, input]);
    setInput('');
    inputElement.current.focus();
  }

  return (
    <div>
      <ul>
        {comentarios.map((comentario, index) => (
          <li key={index}>{comentario}</li>
        ))}
      </ul>
      <input type="text" ref={inputElement} value={input} onChange={({target}) => setInput(target.value)}/>
      <br></br>
      <button onClick={handleClick}>Enviar</button>
    </div>
  )
}

export default App
