
const button = ({ dados }) => {
  let src = []
  if (dados) {
    src = dados.fotos[0].src;
  }
  else {
    src = [];
  }

  return (
    <div>
      <h1>{dados.nome}</h1>
      <p>{dados.preco}</p>
      <img src={src}  />
    </div>
  )
}

export default button