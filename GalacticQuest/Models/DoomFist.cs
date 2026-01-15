
namespace GalacticQuest.Items
{
   internal class DoomFist : Item
   {
      public DoomFist(string name, int attack, int resiliance) : base(name, attack, resiliance) { }

      public override void SpecialPower()
      {
         Console.WriteLine("FIST OF DOOM !!!!");
         Console.Write("\n");
      }
   }
}
