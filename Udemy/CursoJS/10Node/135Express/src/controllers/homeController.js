exports.paginaInicial = (request, response) => {
	response.render('index')
};


exports.trataPost = (request, response) => {
	response.send('Ei, sou sua nova rota de POST.')
}