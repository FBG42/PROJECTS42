import React from 'react'
import Produto from './subComponents/Produto';
import Titulo from './subComponents/Titulo';

const produtos = [
	{ nome: 'Notebook', propriedades: ['16gb ram', '512gb'] },
	{ nome: 'Smartphone', propriedades: ['2gb ram', '128gb'] },
 ];


function Produtos() {
  return (
	 <main>
		<Titulo texto="Produtos"/>
		<ul>
			{produtos.map((produto) => {
				return <Produto key={produto.nome} {...produto} />
			})}
		</ul>
	</main>
  )
}

export default Produtos