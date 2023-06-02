type HaveName = { name: string };
type HaveSurname = { surname: string };
type haveAge = { age: number };
type People = HaveName & HaveSurname & haveAge; // AND

type AB = 'A' | 'B';
type AC = 'A' | 'C';
type AD = 'D' | 'A';
type Intersecao = AB & AC;

const pessoa: People = {
  age: 30,
  name: 'Fabrício',
  surname: 'Grigolo',
};

console.log(pessoa);

// Module mode
export { pessoa };
