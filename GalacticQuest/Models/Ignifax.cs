namespace GalacticQuest.Monsters
{
    public class Ignifax : Monster
    {
        public Ignifax(string name, int hp, int attack) : base(name, hp, attack)
        {
            BattleCry();
        }

        public override void BattleCry()
        {
            Console.WriteLine($"BURN TO CINDERS! {Name} HAS ARRIVED TO CONSUME THE LIGHT");
        }

        public override void OnDeath()
        {
            Console.WriteLine("YOU DOUSE ONE SPARK... BUT THE FIRE OF DESTRUCTION IS ETERNAL! I AM ONLY THE BEGINNING OF YOUR ASH!");
        }
    }
}
