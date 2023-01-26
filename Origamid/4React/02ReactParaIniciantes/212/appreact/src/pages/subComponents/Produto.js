import React from 'react'

function Produto({nome, propriedades}) {
  return (
	<li style={{border: "1px solid", margin: "1rem"}} key={nome} className='produto'>
		<h3>{nome}</h3>
		<ul>
			{propriedades.map((propriedade, index) => {
				return (
					<li key={index}>{propriedade}</li>
				)
			})}
		</ul>
	</li>
  )
}

export default Produto