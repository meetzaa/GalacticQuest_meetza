
using GalacticQuest.Items;
using GalacticQuest.Monsters;

namespace GalacticQuest.Planets
{
   internal interface IPlanet
   {
      IList<Monster> GetInhabitants();

      IList<Item> GetAvailableItems();
   }
}
