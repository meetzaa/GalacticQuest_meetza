namespace GalacticQuest.Items
{
    public class Excalibur : Item
    {
        public Excalibur(string name, int attack, int resitance) : base(name, attack, resitance)
        {
        }

        public override void SpecialPower()
        {
            Console.WriteLine("DIVINE POWER");
            Console.Write("\n");
        }
    }
}
