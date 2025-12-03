using System;
using System.Collections.Generic;

namespace GalacticQuest
{
    public class Player
    {
        public int Hp { get; set; }
        public int Level { get; set; }
        
        public int Credits { get; set; }
        
        public List<(string, int)> Items { get; set; }

        public Player(int hp, int level, List<(string, int)> items)
        {
            Hp = hp;
            Level = level;
            Items = items;
            Credits = 0;
        }

        public void ShowProfile()
        {
            Console.WriteLine($"Player Profile - Level: {Level}, HP: {Hp}, Credits: {Credits}");
            Console.WriteLine("Items:");
            foreach (var item in Items)
            {
                Console.WriteLine($"- {item.Item1} (Value: {item.Item2})");
            }
        }

        public void UpdateHp(int amount)
        {
            Hp += amount;
            if (Hp <= 0)
            {
                OnDeath();
            }
        }
        
        private void OnDeath()
        {
            Console.WriteLine("You have perished in the cold void of space. Game Over.");
        }
        
        public void UpdateCredits(int amount)
        {
            Credits += amount;
        }
        
        public void ManageItem((string, int) item, bool isBuying)
        {
            if (isBuying)
            {
                Items.Add(item);
            }
            else
            {
                Items.Remove(item);
            }
        }
    }
}