
using GalacticQuest.Items;
using GalacticQuest.Monsters;

namespace GalacticQuest.Planets
{
   internal class PlanetNibiru : IPlanet
   {
      private static readonly IList<Item> _itemsList = new List<Item>()
      {
         new Excalibur("Excalibur", PlanetHelper.RandomNumberGenerator.Next(50, 200), PlanetHelper.RandomNumberGenerator.Next(100, 200)),
         new DoomFist ("DoomFist", PlanetHelper.RandomNumberGenerator.Next(300, 700), PlanetHelper.RandomNumberGenerator.Next(10, 25)),
      };

      public IList<Monster> GetInhabitants()
      {
         return new List<Monster>() { new Xenotutzi("Selaru Andrei", 50, 49) };
      }

      public IList<Item> GetAvailableItems()
      {
         return _itemsList;
      }
   }
}
