namespace GalacticQuest.Monsters
{
    public class Xenotutzi : Monster
    {
        public Xenotutzi(string name, int hp, int attack) : base(name, hp, attack)
        {
            BattleCry();
        }

        public override void BattleCry()
        {
            Console.WriteLine($"THE VOID SINGS MY NAME! {Name} CLAIMS THIS WORLD");
        }
    }
}
