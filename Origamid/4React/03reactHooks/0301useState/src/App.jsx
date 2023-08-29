import React from 'react'

function App() {
  const [contar, setContar] = React.useState(1);
  const [items, setItems] = React.useState(['Item 1']);

    function handleClick() {
        setContar(contar + 1);
        setItems(...items, "Item " + (contar));
    }

    return (
    <div>
        {items.map((item) => (
            <li key={item}>{item}</li>
        ))}
        <button onClick={handleClick}>{contar}</button>
    </div>
  )
}

export default App