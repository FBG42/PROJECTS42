import React, { ReactNode } from 'react';
import './style.css';

interface pergunta {
	pergunta: string;
	options: Array<string>;
	resposta: string;
	id: string;
}

const perguntas = [
	{
		pergunta: 'Qual método é utilizado para criar componentes?',
		options: ['React.makeComponent()', 'React.createComponent()', 'React.createElement()'],
		resposta: 'React.createElement()',
		id: 'p1',
	},
	{
		pergunta: 'Como importamos um componente externo?',
		options: ['import Component from "./Component"', 'require("./Component")', 'import "./Component"'],
		resposta: 'import Component from "./Component"',
		id: 'p2',
	},
	{
		pergunta: 'Qual hook não é nativo?',
		options: ['useEffect()', 'useFetch()', 'useCallback()'],
		resposta: 'useFetch()',
		id: 'p3',
	},
	{
		pergunta: 'Qual palavra deve ser utilizada para criarmos um hook?',
		options: ['set', 'get', 'use'],
		resposta: 'use',
		id: 'p4',
	},
];

function App() {
	const [indexOf, setIndexOf] = React.useState<number>(0);
	const [respostasCorretas, setRespostasCorretas] = React.useState<number>(0);

	return (
		<>
			{perguntas.map((pergunta: pergunta, index: number) => {
				return (
					<section key={`${pergunta.id}`}>
						{indexOf === index && (
							<>
								<h1>{pergunta.pergunta}</h1>
								<div>
									{pergunta.options.map((option: string, index: number): ReactNode => {
										return (
											<div key={`${option} - ${index}`}>
												<input
													type="radio"
													name="radioGroup"
													id=""
													value={option}
													onClick={(e: React.MouseEvent<HTMLInputElement>) => {
														const target = e.target as HTMLInputElement;
														if (target.value === pergunta.resposta) {
															setRespostasCorretas(respostasCorretas + 1);
														}
													}}
												/>
												{option}
											</div>
										);
									})}
								</div>
								<button
									onClick={() => {
										!(index === perguntas.length - 1) && setIndexOf(anterior => anterior + 1);
										index === perguntas.length - 1 && setIndexOf(anterior => anterior + 1);
									}}>
									Próxima
								</button>
							</>
						)}
					</section>
				);
			})}
			{indexOf === perguntas.length && (
				<section>
					Você acertou {respostasCorretas} de {perguntas.length}
				</section>
			)}
		</>
	);
}

export default App;
