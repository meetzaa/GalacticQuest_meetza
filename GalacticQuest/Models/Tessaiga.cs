namespace GalacticQuest.Items
{
    public class Tessaiga : Item
    {
        public Tessaiga(string name, int attack, int resitance) : base(name, attack, resitance)
        {
        }

        public override void SpecialPower()
        {
            Console.WriteLine("MEDIUM ZAN GHEN ZAN");
            Console.Write("\n");
        }
    }
}
