namespace GalacticQuest.Monsters
{
    public class Kryostasis : Monster
    {
        public Kryostasis(string name, int hp, int attack) : base(name, hp, attack)
        {
            BattleCry();
        }

        public override void BattleCry()
        {
            Console.WriteLine($"FEEL THE BREATH OF WINTER'S END! I AM {Name}, AND ALL LIFE FREEZES");
        }

        public override void OnDeath()
        {
            Console.WriteLine("THIS WARMTH... IT IS FLEETING... THE COLD REMAINS... AND IT WAITS FOR YOU!");
        }
    }
}
