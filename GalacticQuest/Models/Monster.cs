namespace GalacticQuest.Monsters
{
    public abstract class Monster
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }

        public Monster(string name, int hp, int attack)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
        }

        public abstract void BattleCry();

        public virtual void OnDeath()
        {
            Console.WriteLine($"{Name} has been defeated!");
        }
    }
}
