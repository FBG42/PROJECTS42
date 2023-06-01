type Age = number;
type People = {
  name: string;
  age: Age;
  wage: number;
  favoriteColor?: string;
};
type ColorRGB = 'Red' | 'Green' | 'Blue';
type ColorCMYK = 'Cyan' | 'Magenta' | 'Yellow' | 'Black';
type FavoriteColor = ColorRGB | ColorCMYK;

const people: People = {
  name: 'Fabrício',
  age: 21,
  wage: 200_000,
};

export function setFavoriteColor(people: People, color: FavoriteColor): People {
  return { ...people, favoriteColor: color };
}

console.log(setFavoriteColor(people, 'Black'));
console.log(people);
