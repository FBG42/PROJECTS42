const express = require('express');
const app = express();

app.use(express.urlencoded({ extended: true }))


app.get('/', (request, response) => {
	response.send(`
	<form action="/" method="POST">
	Nome do cliente: <input type="text" name="qualquercoisa">
	<button>Enviar formulário</button>
	</form>
	`);
});

app.get('/testes/:idUsuarios?/:parametro?', (request, response) => {
	//Params são rotas tipo /profiles/3
	console.log(request.params);
	// Query são query strings na url tipo ?nome=fabricio&sobrenome=grigolo
	console.log(request.query);
	response.send(request.query)

	// http://localhost:3000/testes/123?nome=fabricio&sobrenome=grigolo&idade=20&redesocial=nenhuma
})

app.post('/', (request, response) => {
	console.log(request.body)
	response.send(`O que você me enviou foi: ${request.body.qualquercoisa}`);
})

app.listen(3000, () => {
	console.log('Acessar http://localhost:3000')
	console.log("Servidor executando na porta 3000")
});