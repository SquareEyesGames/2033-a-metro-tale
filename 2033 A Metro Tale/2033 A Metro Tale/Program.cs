using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;

namespace _2033_A_Metro_Tale
{
    public class Program
    {
        public static Player currentPlayer = new Player();
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            CreateSaveFolder();
            // File.Delete("saves/" + currentPlayer.saveID.ToString() + ".level");      // This deletes unwanted player saves (uncomment to delete saves!)
            currentPlayer = Load(out bool tryNewPlayer);
            if (tryNewPlayer)                                    // if a new Player is created the story starts at the beginning
            {
                Story.VDNKhOutpost();
                Encounters.FirstEncounter();
                Story.VDNKhStation();
                Encounters.GenericCombatEncounter();
                Story.AlexeyevskyaStation();
                Encounters.GenericCombatEncounter();
                Story.RigskayaStation();
                Story.RigskayaTunnel();
                Story.ProspektMiraStation();
                Story.ProspektMiraTunnel();
                Encounters.GenericCombatEncounter();
                Story.TurgenevskayaStation();
                Encounters.GenericCombatEncounter();
            }
            Story.KitayGorodStation();                          // if a saved Player is loaded it starts from the checkpoint
            Story.KitayGorodTunnel();
            Story.PushkinskayaStation();
            Story.PushkinskayaTunnel();
            Story.PaveletskayaStation();
            Encounters.GenericCombatEncounter();
            Story.DobryninskayaStation();
            Story.DobryninskayaTunnel();
            Story.PolyankaStation();
            Story.PolyankaTunnel();
            Story.Polis();
        }

        static Player NewStart(int playerID)
        {
            Player player = new Player();

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("           ___________________________________________");
            Console.WriteLine("          |  _____      _____      _____      _____   |");
            Console.WriteLine("          | |___  |    |     |    |___  |    |___  |  |");
            Console.WriteLine("          | |  ___|    |  |  |    |___  |    |___  |  |");
            Console.WriteLine("          | |_____|    |_____|    |_____|    |_____|  |");
            Console.WriteLine("          |                                           |");
            Console.WriteLine("          |    -----     A METRO TALE      -----      |");
            Console.WriteLine("          |                                           |");
            Console.WriteLine("          |        (Press 'Enter' to continue)        |");
            Console.WriteLine("          |___________________________________________|");
            ClearScreen();
            
            while (true)                // infinite loop (until break command)
            {
                Print("What's your character's name?");
                player.name = Console.ReadLine();           // creates a new player (name)
                player.saveID = playerID;                   // and ID
                Console.Clear();
                Print("Your character's name is " + player.name + "." +
                    "\n" +
                    "\n(1) Accept" +
                    "\n(2) Try again");

                string choice = Console.ReadLine().ToLower();

                if(choice == "1" || choice == "accept")
                {
                    break;
                }
                else if(choice == "2" || choice == "again" || choice == "Tray again")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("[Invalid Input]");
                    ClearScreen();
                }
            }
            return player;
        }

        static void CreateSaveFolder()
        {
            if (!Directory.Exists("saves"))     // if there is no Save Game Folder...
            {
                Directory.CreateDirectory("saves");    // ...it creates one
            }
        }
        public static void ClearScreen()    // waits for an input an clears the screen; makes two lines into one
        {
            Console.ReadKey();
            Console.Clear();
        }

        public static void Quit()   // can get called in the Shop (at the checkpoint); saves and exits the game
        {
            Save();
            Environment.Exit(0);
        }

        public static void Save()       // saves the Game
        {
            BinaryFormatter binForm = new BinaryFormatter();
            string path = "saves/" + currentPlayer.saveID.ToString() + ".level";
            FileStream file = File.Open(path, FileMode.OpenOrCreate);   // creates or opens (= overrides) the file
            binForm.Serialize(file, currentPlayer);     // serializes the current Player
            file.Close();
        }

        public static Player Load(out bool tryNewPlayer)     // returns a saved player when loading the game
        {
            tryNewPlayer = false;
            Console.Clear();
            string[] paths = Directory.GetFiles("saves");    // the array displays all the different savegames
            List<Player> players = new List<Player>();
            int idCount = 0;                                 // number of player IDs

            BinaryFormatter binForm = new BinaryFormatter();
            foreach (string path in paths)     // goes through every path and adds them to the list
            {
                FileStream file = File.Open(path, FileMode.Open);
                Player player = (Player)binForm.Deserialize(file);      // takes the data into "file" and assumes it to be a player; otherwise there will be an error
                file.Close();
                players.Add(player);
            }

            idCount = players.Count;    // example: 3 saves with the ids 0, 1 & 2 (length of players list would be 3)

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose your player:");

                foreach (Player player in players)   // prints the name for every Player in the list "players" (plus the Player's id in case he has two savegames with the same name)
                {
                    Console.WriteLine(player.saveID + ": " + player.name);
                }

                Console.WriteLine("Please enter your player name or your player id (enter 'id:#' or 'playername'). to load a savegame." +
                    "\nOtherwise enter 'create' to start a new save!");
                string[] data = Console.ReadLine().Split(':');
                try    // tries code for a number input
                {
                    if (data[0] == "id")
                    {
                        if (int.TryParse(data[1], out int id))
                        {
                            foreach (Player player in players)
                            {
                                if (player.saveID == id) // if the player id is equal to the id, it returns the Player
                                {
                                    return player;
                                }
                            }
                            Console.WriteLine("There is no player with that id!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Your id needs to be a number! Press any key to continue!");
                            Console.ReadKey();
                        }
                    }
                    else if (data[0] == "create")
                    {
                        Player newPlayer = NewStart(idCount);
                        tryNewPlayer = true;
                        return newPlayer;
                    }
                    else
                    {
                        foreach (Player player in players)      // loads the savegame if the entered name is the same as the name in the savegame
                        {
                            if (player.name == data[0])
                            {
                                return player;
                            }
                        }
                        Console.WriteLine("There is no player with that name!");
                        Console.ReadKey();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Your id needs to be a number! Press any key to continue!");
                    Console.ReadKey();
                }
            }

        }
        public static void Print(string text, int speed = 40)   // 40 milliseconds is defined as the default value for sleep
        {
            SoundPlayer soundPlayer = new SoundPlayer ("sounds/keyboard2.wav");
            soundPlayer.PlayLooping();
            foreach (char character in text)    // c = character
            {
                Console.Write(character);
                System.Threading.Thread.Sleep(speed);    // The higher the speed int (it's in millisconds), the longer this is going to sleep
            }
            soundPlayer.Stop();
            Console.WriteLine();
        }

        public static void ProgressBar(string filledSpace, string unfilledSpace, decimal value, int size)
        {
            int differentiator = (int)(value * size);      // differentioter displays how much the progress bar will be filled (current xp : level up value)
            for (int i = 0; i < size; i++)
            {
                if (i < differentiator)
                    Console.Write(filledSpace);
                else
                    Console.Write(unfilledSpace);
            }
        }
    }
}
