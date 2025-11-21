using System;
using System.Collections.Generic;
using System.Linq;

namespace GalacticQuest;

class Monster{
    public string Name { get; set; }
    public int HP { get; set; }
    public int Attack { get; set; }

    public Monster(string name, int hp, int attack){
        Name = name;
        HP = hp;
        Attack = attack;
    }
}

class Program{
    enum MainMenuAction { Travel = 1, Journal = 2, Exit = 3 }
    enum TravelMenuAction { Explore = 1, SearchForItems = 2, BackToShip = 3 }
    enum JournalMenuAction { Monsters = 1, Planets = 2, Items = 3, Back = 4 }
    enum MonsterSubMenuAction { FilterByName = 1, Back = 2 }

    static void Main(string[] args){
        List<Monster> monsters = new(){
            new Monster("Void Seeker", 150, 25),
            new Monster("Mega-Mech", 80, 15),
            new Monster("Banshee", 40, 45),
            new Monster("Sprite Mother", 300, 10),
            new Monster("C'thun", 500, 99),
            new Monster("Yogg Saron", 60, 20),
            new Monster("Terapagos", 230, 35)
        };
        
        List<string> planets = new(){ 
            "Obelisk End", "Tatooine", "The Void Gate", "The Arena", "The Dreaming Tree" 
        };

        List<string> items = new(){ 
            "Plasma Rifle", "Health Stim", "Map Fragment", "Void Key" 
        };

        bool isRunning = true;

        while (isRunning){
            Console.Clear();
            Console.WriteLine("=== GALACTIC QUEST COMMAND DECK ===");
            Console.WriteLine("Select System:");
            Console.WriteLine($"{(int)MainMenuAction.Travel}. Travel");
            Console.WriteLine($"{(int)MainMenuAction.Journal}. Journal");
            Console.WriteLine($"{(int)MainMenuAction.Exit}. Exit Game");
            Console.Write("> ");

            if (Enum.TryParse(Console.ReadLine(), out MainMenuAction action)){
                switch (action){
                    case MainMenuAction.Travel:
                        HandleTravelMenu();
                        break;

                    case MainMenuAction.Journal:
                        HandleJournalMenu(monsters, planets, items);
                        break;

                    case MainMenuAction.Exit:
                        Console.WriteLine("Systems powering down...");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Command not recognized.");
                        Pause();
                        break;
                }
            }
            else{
                Console.WriteLine("Invalid input format.");
                Pause();
            }
        }
    }
    
    static void HandleTravelMenu(){
        bool inTravelMenu = true;
        while (inTravelMenu){
            Console.Clear();
            Console.WriteLine("--- NAVIGATION SYSTEMS ---");
            Console.WriteLine($"{(int)TravelMenuAction.Explore}. Explore Sector");
            Console.WriteLine($"{(int)TravelMenuAction.SearchForItems}. Search For Items");
            Console.WriteLine($"{(int)TravelMenuAction.BackToShip}. Back To Ship");
            Console.Write("> ");

            if (Enum.TryParse(Console.ReadLine(), out TravelMenuAction action)){
                switch (action){
                    case TravelMenuAction.Explore:
                        Console.WriteLine("\nThrusters engaged... You discover a nebula!");
                        Pause();
                        break;

                    case TravelMenuAction.SearchForItems:
                        Console.WriteLine("\nScanning surface... No items found in this sector.");
                        Pause();
                        break;

                    case TravelMenuAction.BackToShip:
                        inTravelMenu = false;
                        break;
                }
            }
        }
    }
    
    static void HandleJournalMenu(List<Monster> monsters, List<string> planets, List<string> items){
        bool inJournalMenu = true;
        while (inJournalMenu) {
            Console.Clear();
            Console.WriteLine("--- CAPTAIN'S LOG ---");
            Console.WriteLine($"{(int)JournalMenuAction.Monsters}. Monsters Database");
            Console.WriteLine($"{(int)JournalMenuAction.Planets}. Discovered Planets");
            Console.WriteLine($"{(int)JournalMenuAction.Items}. Inventory / Items");
            Console.WriteLine($"{(int)JournalMenuAction.Back}. Close Journal");
            Console.Write("> ");

            if (Enum.TryParse(Console.ReadLine(), out JournalMenuAction action)){
                switch (action){
                    case JournalMenuAction.Monsters:
                        HandleMonsterLogic(monsters); 
                        break;

                    case JournalMenuAction.Planets:
                        Console.WriteLine("\n[Planets Logged]");
                        planets.ForEach(p => Console.WriteLine($"- {p}"));
                        Pause();
                        break;

                    case JournalMenuAction.Items:
                        Console.WriteLine("\n[Cargo Hold]");
                        items.ForEach(i => Console.WriteLine($"- {i}"));
                        Pause();
                        break;

                    case JournalMenuAction.Back:
                        inJournalMenu = false;
                        break;
                }
            }
        }
    }
    
    static void HandleMonsterLogic(List<Monster> collection){
        bool inMonsterMenu = true;
        while (inMonsterMenu){
            Console.Clear();
            Console.WriteLine("--- ALIEN BIOLOGY DATABASE ---");
            PrintMonsterList(collection);

            Console.WriteLine("\nOptions:");
            Console.WriteLine($"{(int)MonsterSubMenuAction.FilterByName}. Filter by Name");
            Console.WriteLine($"{(int)MonsterSubMenuAction.Back}. Back to Journal");
            Console.Write("> ");

            if (Enum.TryParse(Console.ReadLine(), out MonsterSubMenuAction action)){
                switch (action){
                    case MonsterSubMenuAction.FilterByName:
                        ApplyFilter(collection);
                        Pause();
                        break;

                    case MonsterSubMenuAction.Back:
                        inMonsterMenu = false;
                        break;
                }
            }
        }
    }

    static void ApplyFilter(List<Monster> collection){
        Console.Write("\nEnter search sequence: ");
        string? filterInput = Console.ReadLine();

        if (string.IsNullOrEmpty(filterInput)) return;
        
        var filtered = collection
            .Where(m => m.Name.Contains(filterInput, StringComparison.OrdinalIgnoreCase))
            .ToList();

        Console.WriteLine($"\n=== RESULTS FOR '{filterInput}' ===");
        if (filtered.Count > 0) PrintMonsterList(filtered);
        else Console.WriteLine("No matches found.");
    }
    
    static void PrintMonsterList(List<Monster> collection){
        Console.WriteLine($"{"NAME".PadRight(20)} | {"HP".PadRight(5)} | {"ATK"}");
        Console.WriteLine(new string('-', 40));

        foreach (var m in collection){
            Console.WriteLine($"{m.Name.PadRight(20)} | {m.HP.ToString().PadRight(5)} | {m.Attack}");
        }
    }
    
    static void Pause()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}