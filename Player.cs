using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace _2033_A_Metro_Tale
{
    [Serializable]  // means data in Player Class can be serialized into a file to be saved somewhere
    public class Player
    {
        Random randomNumber = new Random();

        public string name;
        public int saveID;
        public int bullets = 60;
        public int level = 1;
        public int xp = 0;
        public int health = 100;
        public int damage = 1;
        public int armorValue = 0;
        public int medikits = 1;
        public int meleeWeaponValue = 5;
        public int rangedWeaponValue = 10;

        public int difficultyModifier = 0;          // increases with each level up and with it...

        public int GetPower()                                       // ...the strength of enemies...
        {
            int upperRange = (2 * difficultyModifier + 20);
            int lowerRange = (difficultyModifier + 8);
            return randomNumber.Next(lowerRange, upperRange);
        }
        public int GetHealth()                                      // ...their health...
        {
            int upperRange = (2 * difficultyModifier + 50);
            int lowerRange = (difficultyModifier + 25);
            return randomNumber.Next(lowerRange, upperRange);
        }
        public int GetBullets()                                     //...as well as the bullets...
        {
            int upperRange = (10 * difficultyModifier + 20);
            int lowerRange = (3 * difficultyModifier + 3);
            return randomNumber.Next(lowerRange, upperRange);
        }

        public int GetXP()                                          // ...and the XP the player recieves for killing it.
        {
            int upper = (17 * difficultyModifier + 50);
            int lower = (7 * difficultyModifier + 10);
            return randomNumber.Next(lower, upper);
        }

        public int GetLevelUpValue()                // determines number for next level up
        {
            return 15 * level + 50;
        }

        public bool CanLevelUp()                    // determines if the player can level up
        {
            if (xp >= GetLevelUpValue())            // if current XP is greater than the level up value, it's possible
                return true;
            else
                return false;
        }

        public void LevelUp()       
        {
            while (CanLevelUp())
            {
                xp -= GetLevelUpValue();            // level and diff mod up when able to do so
                level++;
                difficultyModifier++;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            SoundPlayer soundPlayer = new SoundPlayer("sounds/levelUp.wav");
            soundPlayer.Play();
            Console.WriteLine("Level Up! You are now Level " + level + "!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey();
        }

    }
}
