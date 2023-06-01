using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2033_A_Metro_Tale
{
    public class Encounters
    {
        static Random randomNumber = new Random();

        // GENERIC ENCOUNTERS
        public static string GetName()
        {
            switch (randomNumber.Next(0, 9))        // switches between different enemy types for the generic combat encounters
            {
                case 0:
                    return "Watcher";
                case 1:
                    return "Human Rogue";
                case 2:
                    return "Bandit";
                case 3:
                    return "Demon";
                case 4:
                    return "Degenerate";
                case 5:
                    return "Wild Dog";
                case 6:
                    return "Mutant";
                case 7:
                    return "Giant Rat";
                case 8:
                    return "Giant Slug";
            }
            return "Bandit";
        }

        public static void GenericCombatEncounter()
        {
            Console.Clear();
            Program.Print("As you walk through the dark tunnel, you see a menacing silhouette standing before you...");
            Console.ReadKey();
            Combat(true, "", 0, 0);     // values here are just placeholders
        }

        // SPECIFIC ENCOUNTERS
        public static void FirstEncounter()
        {
            Console.Clear();
            Program.Print("As the Dark One focusses you with its penetrating glance," +
                "\nyou ready your assault rifle with your pounding heart almost bursting through your chest!");
            ClearScreen();
            Program.Print("Info: You're now entering the the combat system.");      // Short Tutorial
            Console.ReadKey();
            Program.Print("      Notice that you have three different opportunities to attack:");
            Console.ReadKey();
            Program.Print("      1. Your standard MELEE ATTACK is weaker and makes you more vulnerable, but it doesn't cost any bullets.");
            Console.ReadKey();
            Program.Print("      2. Your PRECISION shot is a highly effecitve attack that will cost you one bullet.");
            Console.ReadKey();
            Program.Print("      3. Your SALVO attack isn't as effecitve as your single shot, but deals the most damage." +
                "\n      However, it will cost you 10 bullets.");
            ClearScreen();
            Program.Print("Info: Keep in mind that your ammo, the bullets you carry with you, are also the currency of the Moscow Metro.");
            Console.ReadKey();
            Program.Print("      Don't waste too much of them because you might need them to buy weapon upgrades or to bribe guards.");
            ClearScreen();
            CombatNoEscape(false, "Dark One", 10, 25);
        }

        public static void RigskayaSoldier()
        {
            Program.Print("He glances at you very angrily and screams: ‘DEATH TO THE OPPRESSORS!!!’" +
                "\nAnd he tries to attack you!");
            ClearScreen();
            CombatNoEscape(false, "Rigskaya Soldier", 12, 30);
        }

        public static void KitayGorodBandit()
        {
            Program.Print("As you climb the stairs to the upper levels, one of them is blocking your way, ready to attack!");
            ClearScreen();
            CombatNoEscape(false, "Bandit", 15, 40);
        }

        public static void CheckpointGuard()
        {
            Program.Print("Neither having the time nor the nerve to be exploited by that greedy bastard" +
                "\nyou grab your assault rifle, ready to give him the bullets he wanted!");
            ClearScreen();
            CombatNoEscape(false, "Guard", 20, 50);
        }

        public static void Creeper()
        {
            Program.Print("You look up again and see several eight-legged creatures coming through the ceiling." +
                "\nOne of them crawls right down to you, all of its six eyes piercing you with a threatening glance");
            ClearScreen();
            CombatNoEscape(false, "Creeper", 25, 100);
        }

        public static void Chimera()
        {
            ClearScreen();
            Program.Print("A Chimera!");
            ClearScreen();
            CombatNoEscape(false, "Chimera", 35, 200);
        }

        // COMBAT SYSTEM
        public static void Combat(bool generic, string name, int power, int health)     /* determins if the encounter is generic (or a specific
                                                                                         one), the encounters name, power Level and health */
        {
            string encounterName = "";
            int encounterPower = 0;
            int encounterHealth = 0;
            if (generic)
            {
                encounterName = GetName();                           // chooses a random name from the switch statement above
                encounterPower = Program.currentPlayer.GetPower();   // includes difficulty modifiers for late game (see Player Class)
                encounterHealth = Program.currentPlayer.GetHealth();
            }
            else                            // if the encounter is specific the arguments will be respectively what I name them
            {
                encounterName = name;
                encounterPower = power;
                encounterHealth = health;
            }
            while (encounterHealth > 0)     // as long as the encounter is alive, the combat loop stays active
            {
                Console.Clear();
                Console.WriteLine(encounterName);
                Console.WriteLine("Power: " + encounterPower + "/Health: " + encounterHealth);
                Console.WriteLine("=====================================");
                Console.WriteLine("|(A)ttack         (Melee Weapon)    |");
                Console.WriteLine("|(P)recision Shot (Cost: 1 Bullet)  |");
                Console.WriteLine("|(S)alvo          (Cost: 10 Bullets)|");
                Console.WriteLine("|(M)edKit         (Cost: 1 MedKit)  |");
                Console.WriteLine("|(R)un                              |");
                Console.WriteLine("=====================================");
                Console.WriteLine(Program.currentPlayer.name + "'s Stats:");
                Console.WriteLine("Health: " + Program.currentPlayer.health + " | Armor Value: " + Program.currentPlayer.armorValue);
                Console.WriteLine("Bullets: " + Program.currentPlayer.bullets + " | Medikits: " + Program.currentPlayer.medikits);
                
                string playerAction = Console.ReadLine().ToLower();
                
                if (playerAction == "a" || playerAction == "attack")
                {
                    // Melee Attack
                    int attack = randomNumber.Next(0, Program.currentPlayer.meleeWeaponValue) + Program.currentPlayer.meleeWeaponValue;
                    int damage = (encounterPower - Program.currentPlayer.armorValue) * 3 / 2;
                    if (damage < 0)     // checks that if the damage is negative (through armor value), it doesn't accidentally heal the Player
                        damage = 0;

                    Program.Print("Holding your knife firmly in your hand, you charge forward and sink your weapon deep into the " + encounterName + "'s body!" +
                        "\nYou deal " + attack + " damage!", 1);
                    encounterHealth -= attack;
                    Console.ReadKey();
                    if (encounterHealth > 0)
                    {
                        Program.Print("With your defense wide open, the " + encounterName + " retaliates your attack." +
                        "\nYou lose " + damage + " health!", 1);
                        Program.currentPlayer.health -= damage;
                    }
                    else
                        ReceiveXPAndLoot();     // receives only when the encounter is dead
                }
                else if (playerAction == "p" || playerAction == "precision" || playerAction == "precision shot")
                {
                    // Single Shot Attack
                    int attack = randomNumber.Next(0, Program.currentPlayer.rangedWeaponValue) + Program.currentPlayer.rangedWeaponValue;
                    int damage = encounterPower - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;

                    if (Program.currentPlayer.bullets <= 0)
                        Program.Print("You're out of ammo!");
                    else
                    {
                        Program.Print("You aim carefully with your assault rifle at the " + encounterName + "'s vital point." +
                        "\nYou breathe out and release one bullet with excellent precision!" +
                        "\nYou deal " + attack + " damage!", 1);
                        encounterHealth -= attack;
                        Program.currentPlayer.bullets--;
                        if (Program.currentPlayer.bullets < 0)
                            Program.currentPlayer.bullets = 0;
                        Console.ReadKey();
                        if (encounterHealth > 0)
                        {
                            Program.Print("The " + encounterName + " regains focus and attacks you right back!" +
                            "\nYou lose " + damage + " health!", 1);
                            Program.currentPlayer.health -= damage;
                        }
                        else
                            ReceiveXPAndLoot();
                    }
                }
                else if (playerAction == "s" || playerAction == "salvo")
                {
                    // Burst Attack
                    int attack = randomNumber.Next(5, Program.currentPlayer.rangedWeaponValue) * 5 + (Program.currentPlayer.rangedWeaponValue * 2);
                    int damage = encounterPower - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;

                    if (Program.currentPlayer.bullets <= 0)
                        Program.Print("You're out of ammo!", 1);
                    else
                    {
                        Program.Print("You point your assault rifle in the direction of the " + encounterName +
                        "\nand unleash a salvo of bullets!" +
                        "\nYou deal " + attack + " damage!", 1);
                        encounterHealth -= attack;
                        Program.currentPlayer.bullets -= 10;
                        if (Program.currentPlayer.bullets < 0)
                            Program.currentPlayer.bullets = 0;
                        if (encounterHealth > 0)
                        {
                            Console.ReadKey();
                            Program.Print("The " + encounterName + " recovers from this devastating attack and launches a counterattack!" +
                                "\nYou lose " + damage + " health!", 1);
                            Program.currentPlayer.health -= damage;
                        }
                        else
                            ReceiveXPAndLoot();
                    }
                }
                else if (playerAction == "m" || playerAction == "medkit")
                {
                    // First Aid
                    if (Program.currentPlayer.medikits == 0)
                    {
                        Program.Print("As you desperately reach into your backpack for something to treat your wounds," +
                            "\nYou realize that you're all out of MedKits!", 1);
                        Console.ReadKey();
                        int damage = encounterPower - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Program.Print("As your attention is focused on the contents of your backpack, " +
                            "\nthe " + encounterName + " charges forward and attacks you!" +
                            "\nYou lose " + damage + " health!", 1);
                        Program.currentPlayer.health -= damage;
                    }
                    else
                    {
                        Program.Print("You grab a MedKit and hastily tie it around your open wound, stopping the bleeding." +
                            "\nYou're back to full health.", 1);
                        Program.currentPlayer.medikits--;
                        Program.currentPlayer.health = 100;
                        Console.ReadKey();
                        int damage = encounterPower - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Program.Print("As you shift your attention to treating your wounds, " +
                            "\nthe " + encounterName + " attacks you relentlessly!" +
                            "\nYou lose " + damage + " health!", 1);
                        Program.currentPlayer.health -= damage;
                    }
                }
                else if (playerAction == "r" || playerAction == "run")
                {
                    // Run
                    if (randomNumber.Next(0, 2) == 0)
                    {
                        Program.Print("As you try to run away, the " + encounterName + " attacks you from behind" +
                            "\nthrowing you sprawling onto the ground!", 1);
                        int damage = encounterPower - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Program.currentPlayer.health -= damage;
                        Program.Print("You lose " + damage + " health and are unable to escape.", 1);
                    }
                    else
                    {
                        Program.Print("In a lucky turn of events you manage to distract the " + encounterName +
                            "\nand use your chance to escape successfully.", 1);
                        encounterHealth = 0;    // manually sets the encounter health to 0 to break the while loop but withoug giving the player loot/XP
                    }
                }
                if (Program.currentPlayer.health <= 0)
                {
                    // Death Code
                    Program.Print("The" + encounterName + "'s final blow throws you onto the ground!" +
                        "\nAs the " + encounterName + " stands over you howling into the empty tunnel, you faint and bleed to death...", 75);
                    ClearScreen();
                    Program.Print("GAME OVER", 150);
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                Console.ReadKey();
            }
        }

        public static void CombatNoEscape(bool generic, string name, int power, int health)     // Combat without possibility to escape (for specific encounters like boses)

        {
            string encounterName = "";
            int encounterPower = 0;
            int encounterHealth = 0;
            if (generic)
            {
                encounterName = GetName();
                encounterPower = Program.currentPlayer.GetPower();
                encounterHealth = Program.currentPlayer.GetHealth();
            }
            else                            
            {
                encounterName = name;
                encounterPower = power;
                encounterHealth = health;
            }
            while (encounterHealth > 0)
            {
                Console.Clear();
                Console.WriteLine(encounterName);
                Console.WriteLine("Power: " + encounterPower + "/Health: " + encounterHealth);
                Console.WriteLine("=====================================");
                Console.WriteLine("|(A)ttack         (Melee Weapon)    |");
                Console.WriteLine("|(P)recision Shot (Cost: 1 Bullet)  |");
                Console.WriteLine("|(S)alvo          (Cost: 10 Bullets)|");
                Console.WriteLine("|(M)edKit         (Cost: 1 MedKit)  |");
                Console.WriteLine("=====================================");
                Console.WriteLine(Program.currentPlayer.name + "'s Stats:");
                Console.WriteLine("Health: " + Program.currentPlayer.health + " | Armor Value: " + Program.currentPlayer.armorValue);
                Console.WriteLine("Bullets: " + Program.currentPlayer.bullets + " | Medikits: " + Program.currentPlayer.medikits);
                
                string playerAction = Console.ReadLine().ToLower();
                
                if (playerAction == "a" || playerAction == "attack")
                {
                    // Melee
                    int attack = randomNumber.Next(0, Program.currentPlayer.meleeWeaponValue) + Program.currentPlayer.meleeWeaponValue;    
                    int damage = (encounterPower - Program.currentPlayer.armorValue) * 3 / 2;
                    if (damage < 0)    
                        damage = 0;

                    Program.Print("Holding your knife firmly in your hand, you charge forward and sink your weapon deep into the " + encounterName + "'s body!" +
                        "\nYou deal " + attack + " damage!", 1);
                    encounterHealth -= attack;
                    Console.ReadKey();
                    if (encounterHealth > 0)
                    {
                        Program.Print("With your defense wide open, the " + encounterName + " retaliates your attack." +
                        "\nYou lose " + damage + " health!", 1);
                        Program.currentPlayer.health -= damage;
                    }
                    else
                        ReceiveXPAndLoot();
                }
                else if (playerAction == "p" || playerAction == "precision" || playerAction == "precision shot")
                {
                    // Single Shot Attack
                    int attack = randomNumber.Next(0, Program.currentPlayer.rangedWeaponValue) + Program.currentPlayer.rangedWeaponValue;
                    int damage = encounterPower - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;

                    if (Program.currentPlayer.bullets <= 0)
                        Program.Print("You're out of ammo!", 1);
                    else
                    {
                        Program.Print("You aim carefully with your assault rifle at the " + encounterName + "'s vital point." +
                        "\nYou breathe out and release one bullet with excellent precision!" +
                        "\nYou deal " + attack + " damage!", 1);
                        encounterHealth -= attack;
                        Program.currentPlayer.bullets--;
                        if (Program.currentPlayer.bullets < 0)
                            Program.currentPlayer.bullets = 0;
                        Console.ReadKey();
                        if (encounterHealth > 0)
                        {
                            Program.Print("The " + encounterName + " regains focus and attacks you right back!" +
                            "\nYou lose " + damage + " health!", 1);
                            Program.currentPlayer.health -= damage;
                        }
                        else
                            ReceiveXPAndLoot();
                    }
                }
                else if (playerAction == "s" || playerAction == "salvo")
                {
                    // Burst Attack
                    int attack = randomNumber.Next(5, Program.currentPlayer.rangedWeaponValue) * 5 + (Program.currentPlayer.rangedWeaponValue * 2);
                    int damage = encounterPower - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;

                    if (Program.currentPlayer.bullets <= 0)
                        Program.Print("You're out of ammo!", 1);
                    else
                    {
                        Program.Print("You point your assault rifle in the direction of the " + encounterName +
                        "\nand unleash a salvo of bullets!" +
                        "\nYou deal " + attack + " damage!", 1);
                        encounterHealth -= attack;
                        Program.currentPlayer.bullets -= 10;
                        if (Program.currentPlayer.bullets < 0)
                            Program.currentPlayer.bullets = 0;
                        if (encounterHealth > 0)
                        {
                            Console.ReadKey();
                            Program.Print("The " + encounterName + " recovers from this devastating attack and launches a counterattack!" +
                                "\nYou lose " + damage + " health!", 1);
                            Program.currentPlayer.health -= damage;
                        }
                        else
                            ReceiveXPAndLoot();
                    }
                }
                else if (playerAction == "m" || playerAction == "medkit")
                {
                    // First Aid
                    if (Program.currentPlayer.medikits == 0)
                    {
                        Program.Print("As you desperately reach into your backpack for something to treat your wounds," +
                            "\nYou realize that you're all out of MedKits!", 1);
                        Console.ReadKey();
                        int damage = encounterPower - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Program.Print("As your attention is focused on the contents of your backpack, " +
                            "\nthe " + encounterName + " charges forward and attacks you!" +
                            "\nYou lose " + damage + " health!", 1);
                        Program.currentPlayer.health -= damage;
                    }
                    else
                    {
                        Program.Print("You grab a MedKit and hastily tie it around your open wound, stopping the bleeding." +
                            "\nYou're back to full health.", 1);
                        Program.currentPlayer.medikits--;
                        Program.currentPlayer.health = 100;
                        Console.ReadKey();
                        int damage = encounterPower - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Program.Print("As you shift your attention to treating your wounds, " +
                            "\nthe " + encounterName + " attacks you relentlessly!" +
                            "\nYou lose " + damage + " health!", 1);
                        Program.currentPlayer.health -= damage;
                    }
                }
                
                if (Program.currentPlayer.health <= 0)
                {
                    // Death Code
                    Program.Print("The" + encounterName + "'s final blow throws you onto the ground!" +
                        "\nAs the " + encounterName + " stands over you howling into the empty tunnel, you faint and bleed to death...", 75);
                    ClearScreen();
                    Program.Print("GAME OVER", 150);
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                Console.ReadKey();
            }
        }

        public static void ReceiveXP()      // just receive xp (for example for special story achievements without combat)
        {
            int xp = Program.currentPlayer.GetXP();
            Console.ResetColor();
            Program.Print("You gain " + xp + " XP!", 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Program.currentPlayer.xp += xp;
            Console.ReadKey();

            if (Program.currentPlayer.CanLevelUp())     // if able to level up...
            {
                Program.currentPlayer.LevelUp();        // level++
                Console.ReadKey();
            }
        }

        public static void ReceiveLoot()        // just receive loot (for looting in the story without combat (e.g. looting Bourban))
        {
            int loot = Program.currentPlayer.GetBullets();
            Console.ResetColor();
            Program.Print("You receive " + loot + " bullets!", 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Program.currentPlayer.bullets += loot;

            Console.ReadKey();
        }

        public static void ReceiveXPAndLoot()       // standard combat rewards
        {
            int loot = Program.currentPlayer.GetBullets();
            int xp = Program.currentPlayer.GetXP();
            Program.Print("As you stand victorious over the defeated enemy, you catch your breath and salvage the corpse.", 1);
            Console.ResetColor();
            Program.Print("You receive " + loot + " bullets and gain " + xp + " XP!", 1);
            Program.currentPlayer.bullets += loot;
            Program.currentPlayer.xp += xp;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey();

            if (Program.currentPlayer.CanLevelUp())     
                Program.currentPlayer.LevelUp();        
        }

        static void ClearScreen()    // waits for an input an clears the screen; makes two lines into one
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
