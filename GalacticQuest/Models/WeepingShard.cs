
namespace GalacticQuest.Items
{
   public class WeepingShard : Item
   {
      public WeepingShard(string name, int attack, int resiliance) : base(name, attack, resiliance) { }

      public override void SpecialPower()
      {
         Console.WriteLine("PLEASE ROTATE YOUR HEAD 90 DEGREES TO THE RIGHT");
         Console.Write("\n");
      }
   }
}
