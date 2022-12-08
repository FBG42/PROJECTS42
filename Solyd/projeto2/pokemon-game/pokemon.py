class Pokemon:
   def __init__(self, tipo, especie):
      self.tipo = tipo
      self.especie = especie
   
   def __str__(self):
      return f"{self.especie} ({self.tipo})"

   def atacar(self, pokemon):
      print(f"{self.especie} atacou {pokemon.especie}")
   

meu_pokemon = Pokemon("fogo", "charmander")
pokemon_amigo = Pokemon("elétrico", "pikachu")

meu_pokemon.atacar(pokemon_amigo)
pokemon_amigo.atacar(meu_pokemon)
