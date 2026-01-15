namespace GalacticQuest.Monsters
{
    public class Glorbazorg : Monster
    {
        public Glorbazorg(string name, int hp, int attack) : base(name, hp, attack)
        {
            BattleCry();
        }

        public override void BattleCry()
        {
            Console.WriteLine($"I AM {Name}! KNEEL BEFORE THE DAWN OF YOUR DEFEAT!");
        }

        public override void OnDeath()
        {
            Console.WriteLine("ROOOOAR");
        }
    }
}
