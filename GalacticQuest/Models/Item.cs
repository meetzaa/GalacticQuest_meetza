namespace GalacticQuest.Items
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Resitance { get; set; }

        public Item(string name, int attack, int resitance)
        {
            Name = name;
            Attack = attack;
            Resitance = resitance;
        }

        public abstract void SpecialPower();
    }
}
