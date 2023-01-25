import React from 'react'

const Button = () => {
	return <button>Clique aqui</button>;
};

const Input = ({label, id, ...props}) => {
	return (
		<>
			<label htmlFor={id}>{label}</label>
			<input id={id} type="text" {...props}/>
		</>
	);
};


const Form = () => {
  return (
	 <form>
		<Input id="email" label="Email" required/>
		<Input id="password" type="password" label="Password"/>
		<Button />
	</form>
  );
};

export default Form