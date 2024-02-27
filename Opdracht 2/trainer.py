# trainer.py
from pokeball import Pokeball

class Trainer:
    def __init__(self, name):
        self.name = name
        self.belt = [Pokeball() for _ in range(6)]
        for pokeball in self.belt:
            pokeball.retrieve_charmander()  # Load each Pokeball with a Charmander

    def throw_pokeball(self):
        if self.belt:
            pokeball = self.belt.pop(0)
            pokeball.throw()
            return pokeball
        else:
            print(f"{self.name} has no more Pokeballs!")

    def return_pokemon(self, pokeball):
        if len(self.belt) < 6:
            pokeball.retrieve_charmander()
            self.belt.append(pokeball)
        else:
            raise Exception("Cannot carry more than six Pokeballs on the belt.")

