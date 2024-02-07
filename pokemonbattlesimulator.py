import time

class Charmander:
    strength = ""
    weakness = ""
    def __init__(self, nickname):
        self.nickname = nickname
        self.strength = "fire"
        self.weakness = "water"

    def battle_cry(self):
        return f"{self.nickname.upper()}!!!"

def main():
    while True:
        print("Welcome to the Pokemon Battle Simulator!")
        charmander_name = input("Enter a name for your Charmander: ")
        charmander = Charmander(charmander_name, "Fire", "Water")

        for _ in range(10):
            print(charmander.battle_cry())
            time.sleep(1)  # Add a delay for better visibility

        change_name = input("Do you want to give a new name to your Charmander? (yes/no): ").lower()
        if change_name != 'yes':
            print("Thanks for playing! Exiting the game.")
            break

if __name__ == "__main__":
    main()