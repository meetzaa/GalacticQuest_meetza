using GalacticQuest.Items;
using System;
using System.Reflection;

namespace GalacticQuest
{
    public class Player
    {
        public int Hp { get; private set; } = 100;
        public int Attack { get; private set; } = 10;

        public List<Item> Backpack { get; private set; } = new List<Item>();
        public int Credits { get; private set; } = 0;

        public Player(int hp, int attack, int credits)
        {
            Hp = hp;
            Attack = attack;
            Credits = credits;
        }

        public Player(int hp, int attack)
        {
            Hp = hp;
            Attack = attack;
        }

        public Player(int hp)
        {
           Hp = hp;
        }

        public Player()
        {
        }

        public void UpdateHp(int hp)
        {
            Hp += hp;
            if (Hp <= 0)
            {
                Hp = 0;
                OnDeath();
            }
        }

        private void OnDeath()
        {
            Console.WriteLine("Player has died. Game Over. (-_-')");
        }

        /// <summary>
        /// Adds an item to the backpack
        /// </summary>
        /// <param name="item"> The item to add into the backpack </param>
        public void AddItemToBackpack(Item item)
        {
           if(item is null)
           {
              return;
           }

           Backpack.Add(item);
        }
         
        /// <summary>
        /// Writes the current items in the backpack to the console
        /// </summary>
        public void ShowItemsInBackpack()
        {
           Console.Write("\n");
           if (Backpack.Count < 1)
           {
              Console.WriteLine("No items in the backpack currently");
           }

           foreach( Item item in Backpack)
           {
              Console.WriteLine($"Item -> Name: {item.Name} | Attack: {item.Attack} | Resistance: {item.Resitance}");
           }
        }
        
        /// <summary>
        /// Removes an item from the backpack
        /// </summary>
        /// <param name="item"> The item to remove from the backpack </param>
        /// <returns> True if the item is removed successfully or false otherwise </returns>
        private bool RemoveItemFromBackpack(Item item)
        {
            if (item is null || Backpack.Count < 1)
            {
               return false;
            }
            
            return Backpack.Remove(item);         
        }

        private void UpdateCredits(int credits)
        {
            Credits += credits;
        }

        public void ShowProfile()
        {
            Console.WriteLine("/-------------------------/");
            Console.WriteLine("Displaying Player Profile:");

            Console.WriteLine($"Player HP: {Hp}");
            Console.Write("\n");

            Console.WriteLine("Player Backpack items: ");
            ShowItemsInBackpack();
            Console.Write("\n");

            Console.WriteLine($"Player Credits: {Credits}");
            Console.Write("\n");

            Console.WriteLine($"Player Attack: {Attack}");
            int playerTotalAttack = Attack;
            for (int index = 0; index < Backpack.Count; ++index)
            {
                playerTotalAttack += Backpack[index].Attack;
            }

            Console.WriteLine($"Player Attack (Combined With Items Attack): {playerTotalAttack}");
            Console.WriteLine("/-------------------------/");
            Console.Write("\n");
        }
    }
}
