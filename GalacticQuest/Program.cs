using GalacticQuest.Items;
using GalacticQuest.Monsters;
using GalacticQuest.Planets;

namespace GalacticQuest
{
    internal class Program
    {
        internal static Player currentPlayer = new Player(100, 10, 250); 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Galactic Quest!");

            //CreateAndDisplayPlayerStats();

            OpenMainMenu();
        }

        internal static void CreateAndDisplayItems()
        {
            Console.Write("\n");
            Console.WriteLine("Displaying Created Items:");

            Random randomGenerator = new Random();
            List<Item> items = new List<Item>()
            {
                new Excalibur("Excalibur", randomGenerator.Next(50, 200), randomGenerator.Next(100, 200)),
                new Tessaiga ("Tessaiga", randomGenerator.Next(100, 300), randomGenerator.Next(50, 100)),
            };

            for (int index = 0; index < items.Count; ++index)
            {
                Console.WriteLine($"Item: {items[index].Name} | Attack: {items[index].Attack} | Resistance: {items[index].Resitance}");
                Console.WriteLine("Item's Special Power: ");
                items[index].SpecialPower();
            }
        }

        //internal static void CreateAndDisplayPlayerStats()
        //{
        //    Console.Write("\n");

        //    List<(string, int)> items = new List<(string, int)>() { ("Excalibur", 500), ("Tessaiga", 1000) };
        //    Player player = new Player(50, 1, 10);
        //    //Player player = new Player(50, 1, items);
        //    //Player player = new Player(40, 2);
        //    //Player player = new Player(30);
        //    //Player player = new Player();

        //    player.ShowProfile();

        //    (string, int) newItem = ("Dragon Slayer", 1500);
        //    player.AddItemToBackpack(newItem);

        //    player.ShowProfile();

        //    player.UpdateHp(-60);
        //    Console.WriteLine($"After updating HP: {player.Hp}");
        //}

        internal static void OpenMainMenu()
        {
            bool stillInRun = true;

            while (stillInRun)
            {
                Console.Write("\n");
                Console.WriteLine("Select your option and press Enter: \n 1.Travel \n 2.Journal \n 3.Backpack \n 4.Finish Run \n");
                int.TryParse(Console.ReadLine(), out int readOption);

                try
                {
                    switch (readOption)
                    {
                        case 1:
                            OpenTravelMenu();
                            break;

                        case 2:
                            OpenJournalMenu();
                            break;

                        case 3:
                            OpenBackpackMenu();
                            break;

                        case 4:
                            stillInRun = false;
                            break;

                        default:
                            throw new Exception("Invalid Option");

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("(-_-') " + ex.Message);
                    stillInRun = false;
                }
            }
        }

        internal static void OpenTravelMenu()
        {
            Console.Write("\n");
            Console.WriteLine("Select your option and press Enter: \n 1.Explore \n 2.Search For Items \n 3.Back To Ship \n 4.Back To Main Menu\n");

            int.TryParse(Console.ReadLine(), out int readOption);

            switch (readOption)
            {
                case 1:
                    Console.WriteLine("Selected Explore");
                    PlanetHelper.TravelToRandomPlanet();
                    break;

                case 2:
                    Console.WriteLine("Selected Search For Items");
                    PlanetHelper.SearchForItems();
                    break;

                case 3:
                    Console.WriteLine("Selected Back To Ship");
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Invalid Option. Please try a valid option.");
                    break;

            }
        }

        internal static void OpenJournalMenu()
        {
            Console.Write("\n");
            Console.WriteLine("Select your option and press Enter: \n 1.Monsters \n 2.Planets \n 3.Items \n 4.Back To Main Menu\n");

            int.TryParse(Console.ReadLine(), out int readOption);

            switch (readOption)
            {
                case 1:
                    CreateAndDisplayMonsters();
                    break;

                case 2:
                    CreateAndDisplayItems();
                    break;

                case 3:
                    Console.WriteLine("Selected Items");
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Invalid Option. Please try a valid option.");
                    break;
            }
        }

      internal static void CreateAndDisplayMonsters()
      {
         Console.Write("\n");
         Console.WriteLine("Displaying Created Monsters:");

         Random randomGenerator = new Random();
         List<Monster> monsters = new List<Monster>()
            {
                new Glorbazorg("Glorbazorg", randomGenerator.Next(10, 100), randomGenerator.Next(10, 100)),
                new Xenotutzi("Xenotutzi", randomGenerator.Next(10, 100), randomGenerator.Next(10, 100)),
                new Kryostasis("Kryostasis", randomGenerator.Next(10, 100), randomGenerator.Next(10, 100)),
                new Ignifax("Ignifax", randomGenerator.Next(10, 100), randomGenerator.Next(10, 100))
            };

         ShowMonsters(monsters);
      }

      internal static void ShowMonsters(List<Monster> monsters)
        {
            Console.Write("\n");
            Console.WriteLine("The monsters are : ");

            for (int index = 0; index < monsters.Count; ++index)
            {
                Console.WriteLine(monsters[index].Name + " - " + monsters[index].Hp + " HP | " + monsters[index].Attack + " Attack");
            }
            Console.Write("\n");

            ShowMonstersOptions(monsters);
        }

        internal static void ShowMonstersOptions(List<Monster> monsters)
        {
            Console.WriteLine("Select your option and press Enter: \n 1.Go Back \n 2.Filter Monsters By Name \n 3.Show Monsters Last Words\n");

            int.TryParse(Console.ReadLine(), out int userOption);
            switch (userOption)
            {
                case 1:
                    break;

                case 2:
                    FilterMonstersByName(monsters);
                    break;

                case 3:
                    ShowMonstersLastWords(monsters);
                    break;

                default:
                    Console.WriteLine("Invalid Option. Please try a valid option.");
                    break;
            }
        }

         internal static void OpenBackpackMenu()
         {
            Console.Write("\n");
            Console.WriteLine("Displaying the Backpack menu\n");

            Console.WriteLine("Select your option and press Enter: \n 1.Show current items in backpack.\n 2.Add a basic DoomFist to backpack\n 3.Back to Main Menu\n");

            int.TryParse(Console.ReadLine(), out int userOption);

            switch (userOption)
            {
               case 1:
                  currentPlayer.ShowItemsInBackpack();
                  break;

               case 2:
                  Item basicItem = new DoomFist("Basic doomfist", 100, 20);
                  currentPlayer.AddItemToBackpack(basicItem);
                  break;

               case 3:
                  break;

               default:
                  Console.WriteLine("Invalid Option. Please try a valid option.");
                  break;
            }
         }

      internal static void FilterMonstersByName(List<Monster> monsters)
        {
            Console.WriteLine("Enter letters to filter monsters: ");
            string? userInput = Console.ReadLine();

            Console.Write("\n");

            Dictionary<string, int> filteredMonstersByName = new Dictionary<string, int>();
            if (!string.IsNullOrEmpty(userInput))
            {
                string lowerCasedUserInput = userInput.ToLower();
                for (int index = 0; index < monsters.Count; ++index)
                {
                    string currentMonsterName = monsters[index].Name;
                    string lowerCasedCurrentMonster = currentMonsterName.ToLower();

                    if (lowerCasedCurrentMonster.StartsWith(lowerCasedUserInput))
                    {
                        int currentMonsterHp = monsters[index].Hp;
                        filteredMonstersByName.Add(currentMonsterName, currentMonsterHp);
                    }
                }
            }
            else
            {
                Console.WriteLine("No input provided. Showing all monsters.");
                Console.Write("\n");

                for (int index = 0; index < monsters.Count; ++index)
                {
                    Console.WriteLine(monsters[index].Name);
                }
            }

            if (filteredMonstersByName.Count == 0)
            {
                Console.WriteLine("None of the monsters starts with these letters.");
                Console.Write("\n");
            }
            else
            {
                for (int index = 0; index < filteredMonstersByName.Count; ++index)
                {
                    Console.WriteLine(filteredMonstersByName.Keys.ElementAt(index) + " - " + filteredMonstersByName.Values.ElementAt(index) + " HP");
                }
            }
        }

        internal static void ShowMonstersLastWords(List<Monster> monsters)
        {
            Console.WriteLine("Monsters' Last Words:");

            for (int index = 0; index < monsters.Count; ++index)
            {
                monsters[index].OnDeath();
            }
        }
    }
}