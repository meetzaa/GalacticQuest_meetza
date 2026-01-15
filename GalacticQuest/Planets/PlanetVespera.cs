using GalacticQuest.Items;
using GalacticQuest.Monsters;

namespace GalacticQuest.Planets
{
   internal class PlanetVespera : IPlanet
   {
      private static readonly IList<Item> _itemsList = new List<Item>()
      {
         new WeepingShard("WeepingShard", PlanetHelper.RandomNumberGenerator.Next(100, 1000), PlanetHelper.RandomNumberGenerator.Next(1, 80)),
      };

      public IList<Monster> GetInhabitants()
      {
         return new List<Monster>() { new Ignifax("Tom Beron", 320, 1), new Xenotutzi("Bolojanus", 30, 70) };
      }

      public IList<Item> GetAvailableItems()
      {
         return _itemsList;
      }
   }
}
