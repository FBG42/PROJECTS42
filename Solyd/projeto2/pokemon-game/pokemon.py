import random

class Pokemon:
   def __init__(self, especie, level=random.randint(1, 100), nome=None):
      self.especie = especie
      self.level = level
      
      if nome:
         self.nome = nome
      else:
         self.nome = especie
   
   def __str__(self):
      return f"{self.especie}({self.tipo, self.level})"

   def atacar(self, pokemon):
      print(f"{self.especie} atacou {pokemon.especie}")

class PokemonEletrico(Pokemon):
   tipo = "Elétrico"
   def atacar(self, pokemon):
      print(f"{self} lançou um raio do trovão em {pokemon}")
   
class PokemonFogo(Pokemon):
   tipo = "Fogo"
   def atacar(self, pokemon):
      print(f"{self} lançou uma bola de fogo em {pokemon}")

class PokemonAgua(Pokemon):
   tipo = "Água"
   def atacar(self, pokemon):
      print(f"{self} lançou um jato d'água em {pokemon}")

