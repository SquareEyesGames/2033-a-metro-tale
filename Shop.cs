using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2033_A_Metro_Tale
{
    public class Shop
    {
        public static void LoadShop(Player player)
        {
            int medikitPrice;
            int armorPrice;
            int meleeWeaponPrice;
            int rangedWeaponPrice;
            
            while (true)
            {
                medikitPrice = 10;
                armorPrice = 4 * (player.armorValue + 5);           // more armor has to be way more expensive so the player needs to be able to take damage
                meleeWeaponPrice = 3 * (player.meleeWeaponValue);
                rangedWeaponPrice = 3 * (player.rangedWeaponValue);
                Console.Clear();
                Console.WriteLine("       Weapon Shop       ");
                Console.WriteLine("=========================");
                Console.WriteLine(" (M)elee Weapon Mod:  " + meleeWeaponPrice + "bullets");
                Console.WriteLine(" (R)anged Weapon Mod: " + rangedWeaponPrice + "bullets");
                Console.WriteLine(" (A)rmor:             " + armorPrice + "bullets");
                Console.WriteLine(" (F)irst Aid MedKit:  " + medikitPrice + "bullets");
                Console.WriteLine("=========================");
                Console.WriteLine("(E)xit Shop");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(player.name + "'s Stats");
                Console.WriteLine("=====================");
                Console.WriteLine("Current Health:  " + player.health);
                Console.WriteLine("Armor  Value: " + player.armorValue);
                Console.WriteLine("Bullets: " + player.bullets);
                Console.WriteLine("Melee Weapon Strength: " + player.meleeWeaponValue);
                Console.WriteLine("Ranged Weapon Strength: " + player.rangedWeaponValue);
                Console.WriteLine("First Aid MedKits: " + player.medikits);
                Console.WriteLine();

                Console.WriteLine("XP:");
                Console.Write("[");     // Level Up Bar
                Program.ProgressBar("+", " ", ((decimal)player.xp / (decimal)player.GetLevelUpValue()), 20);  // "+" is the fillerCharacter, the background just a space, the value is the player XP divided by the GetLevelUpValue (both casted to decimals) and 20 is the length of the progress bar
                Console.WriteLine("]");
                Console.WriteLine("Level: " + player.level);    // Add: With each level up, encounters should get stronger
                Console.WriteLine("======================");
                                
                string input = Console.ReadLine().ToLower();

                if (input == "m" || input == "melee" || input == "melee weapon")
                    TryBuy("melee weapon", meleeWeaponPrice, player);
                if (input == "r" || input == "ranged" || input == "ranged weapon")
                    TryBuy("ranged weapon", rangedWeaponPrice, player);
                if (input == "a" || input == "armor")
                    TryBuy("armor", armorPrice, player);
                if (input == "f" || input == "first" || input == "first aid" || input == "first aid medkit" || input == "medkit")
                    TryBuy("medkit", medikitPrice, player);
                else if (input == "e" || input == "exit" || input == "exit shop")
                    break;                   // Exits the shop (breaks the while loop)

                if (player.bullets == 0)
                {
                    Console.Clear();
                    Program.Print("You've run out of bullets to buy anything and leave the shop.");
                    Program.ClearScreen();
                    break;
                }
            }
        }

        public static void LoadShopSavePoint(Player player)         // Loads a shop with a save function
        {
            int medikitPrice;
            int armorPrice;
            int meleeWeaponPrice;
            int rangedWeaponPrice;

            while (true)
            {
                medikitPrice = 10;
                armorPrice = 4 * (player.armorValue + 5);           // more armor has to be way more expensive so the player needs to be able to take damage
                meleeWeaponPrice = 3 * (player.meleeWeaponValue);
                rangedWeaponPrice = 3 * (player.rangedWeaponValue);
                Console.Clear();
                Console.WriteLine("       Weapon Shop       ");
                Console.WriteLine("=========================");
                Console.WriteLine(" (M)elee Weapon Mod:  " + meleeWeaponPrice + "bullets");
                Console.WriteLine(" (R)anged Weapon Mod: " + rangedWeaponPrice + "bullets");
                Console.WriteLine(" (A)rmor:             " + armorPrice + "bullets");
                Console.WriteLine(" (F)irst Aid MedKit:  " + medikitPrice + "bullets");
                Console.WriteLine("=========================");
                Console.WriteLine("(E)xit Shop");
                Console.WriteLine("(S)ave & Quit Game");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(player.name + "'s Stats");
                Console.WriteLine("=====================");
                Console.WriteLine("Current Health:  " + player.health);
                Console.WriteLine("Armor  Value: " + player.armorValue);
                Console.WriteLine("Bullets: " + player.bullets);
                Console.WriteLine("Melee Weapon Strength: " + player.meleeWeaponValue);
                Console.WriteLine("Ranged Weapon Strength: " + player.rangedWeaponValue);
                Console.WriteLine("First Aid MedKits: " + player.medikits);
                Console.WriteLine();
                Console.WriteLine("XP:");
                Console.Write("[");     // Level Up Bar
                Program.ProgressBar("+", " ", ((decimal)player.xp / (decimal)player.GetLevelUpValue()), 20);  // + is the fillerCharacter, the background just a space, the value is the player XP divided by the GetLevelUpValue (both casted to decimals) and 20 is the length of the progress bar
                Console.WriteLine("]");
                Console.WriteLine("Level: " + player.level);    // Add: With each level up, encounters should get stronger
                Console.WriteLine("======================");

                string input = Console.ReadLine().ToLower();

                if (input == "m" || input == "melee" || input == "melee weapon")
                    TryBuy("melee weapon", meleeWeaponPrice, player);
                if (input == "r" || input == "ranged" || input == "ranged weapon")
                    TryBuy("ranged weapon", rangedWeaponPrice, player);
                if (input == "a" || input == "armor")
                    TryBuy("armor", armorPrice, player);
                if (input == "f" || input == "first" || input == "first aid" || input == "first aid medkit" || input == "medkit")
                    TryBuy("medkit", medikitPrice, player);
                else if (input == "s" || input == "save" || input == "save & quit" || input == "save & quit game")
                    Program.Quit();          // Saves and Quits the Game
                else if (input == "e" || input == "exit" || input == "exit shop")
                    break;                   // Exits the shop (breaks the while loop)

                if (player.bullets == 0)
                {
                    Console.Clear();
                    Program.Print("You've run out of bullets to buy anything and leave the shop.");
                    Program.ClearScreen();
                    break;
                }
            }
        }

        static void TryBuy(string shopItem, int itemCost, Player player)
        {
            if (player.bullets >= itemCost)
            {
                if (shopItem == "medkit")
                    player.medikits++;
                else if (shopItem == "melee weapon")
                    player.meleeWeaponValue += 2;
                else if (shopItem == "ranged weapon")
                    player.rangedWeaponValue += 2;
                else if (shopItem == "armor")
                    player.armorValue += 5;
                
                player.bullets -= itemCost;
                if (player.bullets < 0)
                    player.bullets = 0;     // bullets can only be positive values or zero
            }
            else
            {
                Program.Print("You don't have enough bullets.");    // error if player doesn't have enough bullets to buy something
                Console.ReadKey();
            }
        }
    }
}
