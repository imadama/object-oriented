# pokeball.py

class Pokeball:
    def __init__(self):
        self.contains_charmander = False

    def throw(self):
        if self.contains_charmander:
            print("Charmander, I choose you!")
            self.contains_charmander = False
        else:
            print("The pokeball is empty.")

    def retrieve_charmander(self):
        if not self.contains_charmander:
            print("Charmander, return!")
            self.contains_charmander = True
        else:
            print("The pokeball already has a Charmander inside.")
