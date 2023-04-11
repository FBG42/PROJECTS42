exports.paginaInicial = (request, response) => {
	response.send(`
	<form action="/" method="POST">
	Nome do cliente: <input type="text" name="qualquercoisa"><br>
	Outro campo: <input type="text" name="aquioutrocampo">
	<button>Olá mundo</button>
	</form>
	`);
};


exports.trataPost = (request, response) => {
	response.send('Ei, sou sua nova rota de POST.')
}