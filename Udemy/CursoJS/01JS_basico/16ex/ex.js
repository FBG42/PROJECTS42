const nome = "Fabrício";
const sobrenome = "B Grigolo";
const idade = 20;
const peso = 70
const altura = 1.71
const anoNascimento = 2002

let IndiceMassaCorporal = peso/(altura*altura);

console.log(nome, sobrenome,"tem",idade,"anos, pesa",peso,"kg, tem", altura," e seu IMC é de", IndiceMassaCorporal)

console.log()

console.log(`${nome} ${sobrenome} tem ${idade} anos, pesa ${peso}kg, tem ${altura}, seu Iindice de Massa Corporal é de ${IndiceMassaCorporal}, e nasceu em ${anoNascimento}`)