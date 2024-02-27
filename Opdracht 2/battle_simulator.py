# battle_simulator.py
from trainer import Trainer

def main():
    print("Welcome to the Pokemon Battle Simulator!")
    trainer1_name = input("Enter the name for Trainer 1: ")
    trainer2_name = input("Enter the name for Trainer 2: ")

    trainer1 = Trainer(trainer1_name)
    trainer2 = Trainer(trainer2_name)

    for _ in range(6):
        print(f"{trainer1.name} throws a Pokeball!")
        pokeball1 = trainer1.throw_pokeball()

        print(f"{trainer2.name} throws a Pokeball!")
        pokeball2 = trainer2.throw_pokeball()

        trainer1.return_pokemon(pokeball1)
        trainer2.return_pokemon(pokeball2)

        action = input("Press 'n' to continue the battle or 'q' to quit: ")
        if action.lower() == 'q':
            break

    print("Game Over. Thank you for playing!")

if __name__ == "__main__":
    main()
