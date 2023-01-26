import React from "react";
import Home from "./pages/Home";
import Produtos from "./pages/Produtos";

function App() {
	const { pathname } = window.location;

	let Content;

	if (pathname === "/") {
		Content = Home;
	} 
	else {
		Content = Produtos;
	}
  return (
    <>
	 <Content />
	 </>
  );
}

export default App;
