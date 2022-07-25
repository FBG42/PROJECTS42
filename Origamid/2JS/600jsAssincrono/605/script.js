fetch("https://pokeapi.co/api/v2/pokemon/")
  .then((r) => r.json())
  .then((pokemon) => {
    console.log(pokemon);
  });

const url = "https://jsonplaceholder.typicode.com/posts";
const options = {
  method: "POST",
  body: '{"title": "Javascript"}',
  headers: {
    "Content-Type": "application/json; charset=utf-8",
  },
};

fetch(url, options)
  .then((response) => response.json())
  .then((json) => console.log(json));

const url1 = "https://jsonplaceholder.typicode.com/posts/2";
const options1 = {
  method: "PUT",
  body: '{"title": "Javascript"}',
  headers: {
    "Content-Type": "application/json; charset=utf-8",
  },
};

fetch(url1, options1).then((response) =>
  console.log(response.headers.forEach(console.log))
);
