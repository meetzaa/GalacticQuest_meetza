
using GalacticQuest.Items;
using GalacticQuest.Monsters;

namespace GalacticQuest.Planets
{
   internal class PlanetMeridian : IPlanet
   {
      private static readonly IList<Item> _itemsList = new List<Item>()
      {
         new Excalibur("Excalibur", PlanetHelper.RandomNumberGenerator.Next(50, 200), PlanetHelper.RandomNumberGenerator.Next(100, 200)),
         new Tessaiga ("Tessaiga", PlanetHelper.RandomNumberGenerator.Next(100, 300), PlanetHelper.RandomNumberGenerator.Next(50, 100)),
      };

      public IList<Monster> GetInhabitants()
      {
         return new List<Monster>() { new Glorbazorg("zorba the greek", 150, 10), new Ignifax("Valentinus", 20, 30), new Kryostasis("Rava", 1, 100) };
      }

      public IList<Item> GetAvailableItems()
      {
         return _itemsList;
      }
   }
}
