let x = 10; // eslint-disable-line
x = 0b1010;
const y = 10;
const a = 100; // eslint-disable-line

const people = {
  name: 'Fabrício' as const,
  surname: 'Grigolo',
};

function choiceColor(color: 'Red' | 'Yellow' | 'Blue'): string {
  return color;
}

console.log(choiceColor('Red'));

// Module mode
export default 1;
