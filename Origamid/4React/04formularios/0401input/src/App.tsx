import React, { ChangeEvent, FormEvent } from 'react';
import './app.css';

export default function App() {
	const [form, setForm] = React.useState({
		nome: '',
		email: '',
		senha: '',
		cep: '',
		rua: '',
		numero: '',
		bairro: '',
		cidade: '',
		estado: '',
	});
	const [response, setResponse] = React.useState<Response | null>(null);

	const handleChange = (e: ChangeEvent<HTMLInputElement>) => {
		const { id, value } = e.target;
		setForm({ ...form, [id]: value });
	};
	const handleSubmit = (e: FormEvent<HTMLFormElement>) => {
		e.preventDefault();
		try {
			fetch('https://ranekapi.origamid.dev/json/api/usuario', {
				method: 'POST',
				headers: {
					'Content-Type': 'application/json',
				},
				// form é o objeto com os dados do formulário
				body: JSON.stringify(form),
			}).then(response => {
				setResponse(response);
				console.log(response);
			});
		} catch (e) {
			console.error(e);
		}
	};

	return (
		<>
			<form onSubmit={handleSubmit}>
				<label htmlFor="nome">Nome</label>
				<input
					type="text"
					id="nome"
					value={form.nome}
					onChange={handleChange}
				/>
				<label htmlFor="email">email</label>
				<input
					type="email"
					id="email"
					value={form.email}
					onChange={handleChange}
				/>
				<label htmlFor="senha">senha</label>
				<input
					type="password"
					id="senha"
					value={form.senha}
					onChange={handleChange}
				/>
				<label htmlFor="cep">cep</label>
				<input
					type="text"
					id="cep"
					value={form.cep}
					onChange={handleChange}
				/>
				<label htmlFor="rua">rua</label>
				<input
					type="text"
					id="rua"
					value={form.rua}
					onChange={handleChange}
				/>
				<label htmlFor="numero">numero</label>
				<input
					type="text"
					id="numero"
					value={form.numero}
					onChange={handleChange}
				/>
				<label htmlFor="bairro">bairro</label>
				<input
					type="text"
					id="bairro"
					value={form.bairro}
					onChange={handleChange}
				/>
				<label htmlFor="cidade">cidade</label>
				<input
					type="text"
					id="cidade"
					value={form.cidade}
					onChange={handleChange}
				/>
				<label htmlFor="estado">estado</label>
				<input
					type="text"
					id="estado"
					value={form.estado}
					onChange={handleChange}
				/>
				<p>{response?.ok === true && 'Formulário enviado com sucesso.'}</p>
				<button type="submit">Enviar</button>
			</form>
		</>
	);
}
