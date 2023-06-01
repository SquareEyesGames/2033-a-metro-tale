using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace _2033_A_Metro_Tale
{
    public class Story
    {
        public static void Polis()
        {
            Console.Clear();
            Program.Print("You did it. You finally reached the end of the tunnel.");
            ClearScreen();
            Program.Print("There, you halt, standing before a heavy steel gate.");
            ClearScreen();
            Program.Print("Not knowing what else to do you slam your assault rifle against it" +
                "\nin hope of receiving some kind of answer.");
            ClearScreen();
            ClearScreen();
            Program.Print("Several painfully long moments pass as you're waiting desperately for any sign of life" +
                "\non the other side of the gate...");
            ClearScreen();
            ClearScreen();
            Program.Print("Then, with a loud noise, the gate opens and you feel a strong breeze of fresh air coming out of it.");
            ClearScreen();
            Program.Print("As the very bright lights of Polis blind your eyes" +
                "\nyou finally feel hope again that your home now has a fighting chance to survive!");
            ClearScreen();
            ClearScreen();
            Program.Print("To be continued...");
            ClearScreen();
            ClearScreen();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                               Created by Thomas Schüren");
            ClearScreen();
            ClearScreen();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                               Based on the novel 'Metro 2033'");
            Console.WriteLine("                               Written by Dmitry Glukhovsky");
            ClearScreen();
            System.Environment.Exit(0);
        }

        public static void PolyankaTunnel()
        {
            Console.Clear();
            Program.Print("As you walk through the tunnel you almost stumble and fall on the tracks.");
            ClearScreen();
            Program.Print("As you illuminate the floor with your new flashlight" +
                "\nyou see corpses of giant rats, wild dogs and other creatures.");
            ClearScreen();
            Program.Print("You wonder what could have killed all those beasts as you carefully weave your way around them.");
            ClearScreen();
            Program.Print("Then, you hear loud noises that shake the ground each time they occur.");
            Console.ReadKey();
            Program.Print("Something big is coming your way!");
            ClearScreen();
            Program.Print("You ready your gun and prepare for a tough battle" +
                "\nwhen a giant beast enters the cone of light from your flashlight.");
            ClearScreen();
            Program.Print("It looks like several mutated beasts merged into one.");
            Console.ReadKey();
            Program.Print("You only heard stories of it, never believed them to be real...");
            Encounters.Chimera();
            Console.Clear();
            Program.Print("Injured, exhausted, and soaked in the chimeras blood, you limp your way towards the tunnel exit.");
            ClearScreen();
        }

        public static void PolyankaStation()
        {
            Console.Clear();
            Console.Clear();
            Program.Print("That’s it. Your final stop before Polis.");
            ClearScreen();
            Program.Print("You walk right through in the lookout for a weapon shop to fix your flashlight. You find one.");
            Console.ReadKey();
            Program.Print("‘This is the last weapon shop on my journey.’ You think to yourself. ‘I should spend my money wisely.’");
            ClearScreen();
            Shop.LoadShop(Program.currentPlayer);
            Console.Clear();
            Program.Print("With a new flashlight and restocked supplies, you feel as prepared as you’re ever going to be." +
                "\nNothing can stop you now from reaching your destination!");
            ClearScreen();
            Program.Print("With courage and confidence, you enter the tunnel to Polis.");
            ClearScreen();
        }

        public static void DobryninskayaTunnel()
        {
            Console.Clear();
            Program.Print("You walk through the dark tunnel and as you keep walking you wonder how long this tunnel might be.");
            ClearScreen();
            Program.Print("The lights of the last station have faded a long time ago" +
                "\nand you can’t make out any kind of illuminated tunnel exit in front you.");
            Console.ReadKey();
            Program.Print("‘What else is there to do but to keep walking’ you think. And you go on.");
            ClearScreen();
            Program.Print("After a few more minutes, your flashlight begins to flicker.");
            Console.ReadKey();
            Program.Print("Finally, it runs out and leaves you in complete blackness.");
            ClearScreen();
            ClearScreen();
            Program.Print("Nothing.");
            ClearScreen();
            ClearScreen();
            Program.Print("You see absolutely NOTHING!");
            ClearScreen();
            ClearScreen();
            Program.Print("'This is bad...' You think and your muscles begin to tense, your chest tightens.");
            Console.ReadKey();
            Program.Print("‘Okay, keep cool. You can still feel the train tracks beneath you.");
            Console.ReadKey();
            Program.Print("All you have to do is to move forwards and follow the sleepers until you reach the tunnel exit.’");
            ClearScreen();
            Program.Print("You take a deep breath and start walking again, careful to not stumble over the track sleepers.");
            ClearScreen();
            Program.Print("As you walk there all by yourself in complete darkness, you hear a second set of steps behind you" +
                "\nalmost identical to your own with just a tiny little delay.");
            ClearScreen();
            Program.Print("‘Echoes maybe? Were they here before and I didn’t notice them?’");

            while (true)
            {
                ClearScreen();
                Program.Print("You’re starting to feel uneasy and you wonder" +
                    "\nif you should stop really quick just to check if that sound is really just an echo..." +
                    "\n" +
                    "\n(1) Stop" +
                    "\n(2) Keep walking");

                string choice1 = Console.ReadLine().ToLower();

                if (choice1 == "1" || choice1 == "stop")
                {
                    Console.Clear();
                    Program.Print("You pause on the spot and listen into the tunnel.");
                    ClearScreen();
                    Program.Print("The steps behind you stopped as well, again with a little delay" +
                        "\nbut you can’t tell for sure if it really is an echo or if there might be someone or something behind you" +
                        "\nthat simply stopped, too.");
                    ClearScreen();
                    Program.Print("You start walking again and the echo behind you starts again as well.");
                    Console.ReadKey();
                    Program.Print("This time, you somehow feel like the echo has become a little louder than before...");

                    while (true)
                    {
                        ClearScreen();
                        Program.Print("Your tension increases and you feel the urge to stop again and listen one more time." +
                            "\n" +
                            "\n(1) Stop" +
                            "\n(2) Keep walking");

                        string choice2 = Console.ReadLine().ToLower();

                        if (choice2 == "1" || choice2 == "stop")
                        {
                            Console.Clear();
                            Program.Print("You pause again and listen very carefully.");
                            Console.ReadKey();
                            Program.Print("The echo stopped, too, you believe you heard a little trip at the echoes last step.");
                            ClearScreen();
                            Program.Print("Now the fear really gets to you!");
                            ClearScreen();
                            Program.Print("Out of pure flight instinct you start walking again, this time with a faster pace.");
                            Console.ReadKey();
                            Program.Print("As expected, the unknown echo follows you and this time you’re sure it’s louder than before!");
                            ClearScreen();
                            Program.Print("You walk and you walk through a mist of nothingness" +
                                "\nand it feels like the darkness itself is chasing you!");

                            while (true)
                            {
                                ClearScreen();
                                Program.Print("One last time you feel the compelling need to stop" +
                                    "\nand reassure yourself that this is all your imagination playing mind games with you." +
                                    "\n" +
                                    "\n(1) Stop" +
                                    "\n(2) Keep walking");

                                string choice3 = Console.ReadLine().ToLower();

                                if (choice3 == "1" || choice3 == "stop")
                                {
                                    Console.Clear();
                                    Program.Print("You stop walking.");
                                    ClearScreen();
                                    Program.Print("Now you’re standing alone in the dark, trying to listen to your senses.");
                                    ClearScreen();
                                    Program.Print("You undoubtedly feel a cold and terrifying presence directly behind you.");
                                    Console.ReadKey();
                                    Program.Print("You sense a soft and warm breath that makes the hairs on your neck stand up.");
                                    ClearScreen();
                                    Program.Print("You want to turn around and look at what you believe is behind you.");
                                    Console.ReadKey();
                                    Program.Print("But you’re paralyzed by fear. You can’t even move a muscle.");
                                    ClearScreen();
                                    Program.Print("You feel your mind breaking into a thousand pieces.");
                                    ClearScreen();
                                    Program.Print("And then...");
                                    ClearScreen();
                                    Program.Print("You don’t feel anything at all.");
                                    Console.ReadKey();
                                    System.Environment.Exit(0);
                                }
                                else if (choice3 == "2" || choice3 == "keep" || choice3 == "keep walking")
                                {
                                    break;
                                }
                                else
                                    Console.WriteLine("[Invalid Input]");
                            }
                            break;
                        }
                        else if (choice2 == "2" || choice2 == "keep" || choice2 == "keep walking")
                        {
                            break;
                        }
                        else
                            Console.WriteLine("[Invalid Input]");
                    }
                    break;
                }
                else if (choice1 == "2" || choice1 == "keep" || choice1 == "keep walking")
                {
                    break;
                }
                else
                    Console.WriteLine("[Invalid Input]");
            }
            Console.Clear();
            Program.Print("You ignore your fears and keep your mind focused on the way in front of you.");
            ClearScreen();
            Program.Print("After a while, you make out a dim light in front of you, looking like a tunnel exit sign.");
            ClearScreen();
            Program.Print("You keep walking and notice that the echo has somehow disappeared.");
            ClearScreen();
            Program.Print("With a sense of relief, you finally exit this nightmare of a tunnel.");
            ClearScreen();
            Encounters.ReceiveXP();
        }

        public static void DobryninskayaStation()
        {
            Console.Clear();
            Program.Print("You arrive at a fairly populated station.");
            ClearScreen();
            Program.Print("As you pass an old man sitting on a carpet, looking like a fortune teller, he speaks to you:" +
                "\n‘I feel that you are in need of something.’");
            ClearScreen();
            Program.Print("You stop and turn to him:" +
                "\n‘The only thing I need is to know the way to Polis. Does this tunnel lead me there?’");
            ClearScreen();
            Program.Print("You point to a tunnel entrance leading north from here.");

            while (true)
            {
                ClearScreen();
                Program.Print("Fortune teller: ‘Yes. Polis is only two stations north from here. But you’re wrong. " +
                    "\nYou need much more to get there. For 1 bullet, I’ll tell you what you really need...’" +
                    "\n" +
                    "\n(1) Pay" +
                    "\n(2) Refuse");

                string choice = Console.ReadLine().ToLower();

                if (choice == "1" || choice == "pay")
                {
                    Console.Clear();
                    Program.Print("Curious what the teller could mean" +
                        "\nyou hand over 1 bullet from your magazine, waiting for useful information.");
                    Program.currentPlayer.bullets--;
                    ClearScreen();
                    Program.Print("Fortune teller: 'It’s courage!");
                    ClearScreen();
                    Program.Print(Program.currentPlayer.name + ": 'What?'");
                    ClearScreen();
                    Program.Print("Fortune teller: 'When the darkness creeps up to you, gets under your skin, weighing you down" +
                        "\nyou need to keep walking! Don’t give in to the fear telling you to stop. Be courageous!'");
                    ClearScreen();
                    Program.Print("With a disappointed look and the feeling that you’ve just been swindled out of your money" +
                        "\nyou turn away from that whacko and take your leave without saying another word.");
                    ClearScreen();
                    Program.Print("You enter the tunnel to Polyanka and after that to Polis. Almost there...");
                    ClearScreen();
                    break;
                }
                else if (choice == "2" || choice == "refuse")
                {
                    Console.Clear();
                    Program.Print(Program.currentPlayer.name + ": ‘What I really need is people to stop getting in my way! Goodbye!’");
                    ClearScreen();
                    Program.Print("You turn away and start walking towards the tunnel entrance.");
                    ClearScreen();
                    Program.Print("‘Don’t let the darkness get to you!’ you hear him shout with an ominous laugh." +
                        "\n‘Good luck, blind one!’");
                    ClearScreen();
                    Program.Print("You ignore him and enter the tunnel to Polyanka and after that to Polis.");
                    ClearScreen();
                    Program.Print("Almost there...");
                    ClearScreen();
                    break;
                }
                else
                    Console.WriteLine("[Invalid Input]");
            }
        }

        public static void PaveletskayaStation()
        {
            Console.Clear();
            Program.Print("The four guys from the Red Line drop you off und wish you good luck on your journey.");
            ClearScreen();
            Program.Print("You see a lot of people, cowered behind barricades. They don’t seem to notice you.");
            ClearScreen();
            Program.Print("Before the entrance to Paveletskaya you see a massive iron gate. It seems closed.");
            ClearScreen();
            Program.Print("You walk to the gate and ask the man next to it: ‘Excuse me, I need to get into Paveletskaya.’");
            Console.ReadKey();
            Program.Print("Man: ‘Gate opens in a few hours in the morning. At night it’s closed when we’re expecting visitors.’");
            Console.ReadKey();
            Program.Print("‘Visitors?’ you ask.");
            ClearScreen();
            Program.Print("His finger points up to the ceiling.");
            Console.ReadKey();
            Program.Print("You look up and you almost can’t believe what you see...");
            ClearScreen();
            Program.Print("There is a HOLE in the ceiling! You can actually see the night sky!");
            ClearScreen();
            Program.Print("It’s beautiful...");
            ClearScreen();
            Program.Print("...");
            ClearScreen();
            Program.Print("As you regain control of your thoughts, you wonder for how long you must have stared through that hole.");
            ClearScreen();
            Program.Print("Now you suddenly feel the urge to cover your mouth.");
            Console.ReadKey();
            Program.Print("As you look around closer, you notice a lot of people with deformations on their bodies" +
                "\nprobably because they spent too much time in this radioactive environment.");
            ClearScreen();
            Program.Print("You turn back to the man at the gate. ‘Listen, I need to get to Polis. Can I please just go through quick?’");
            Console.ReadKey();
            Program.Print("Man: ‘Dude, the gate opens only from the inside. There’s nothing you can do but wait.");
            Console.ReadKey();
            Program.Print("Paveletskaya will open at dawn, when it’s safe. Visitors only hunt at night.’");
            Console.ReadKey();
            Program.Print(Program.currentPlayer.name + ": ‘What do you mean by Visitors?’");
            ClearScreen();
            Program.Print("‘THEY’RE COMING!’ you hear another one screaming.");
            ClearScreen();
            Encounters.Creeper();
            Console.Clear();
            Program.Print("The other men manage to finish the remaining creepers");
            ClearScreen();
            Program.Print("The rest of the night goes by withouth further attacks. " +
                "\nAs you wait impatiently, the sky slowly changes its color and gate to Paveletskaya opens.");
            ClearScreen();
            Program.Print("You swiftly go through and walk right into the next best weapon shop.");
            ClearScreen();
            Shop.LoadShop(Program.currentPlayer);
            Console.Clear();
            Program.Print("With your supplies restocked, you run into the next tunnel leading west as you were told.");
            ClearScreen();
        }

        public static void PushkinskayaTunnel()
        {
            Console.Clear();
            Program.Print("‘Hey Hangman! We got your pulse, so stop simulating!’ a voice says.");
            ClearScreen();
            Program.Print("You feel a powerful slap in the face. Your eyes open and you try to understand where you are...");
            ClearScreen();
            Program.Print("You’re in a dark tunnel riding on a fast motorized trolley with four other guys all staring at you.");
            Console.ReadKey();
            Program.Print("‘Am I dead?’ you ask.");
            ClearScreen();
            Program.Print("The one who appears to be their leader chuckles. " +
                "\n‘You may be in hell, but you’re not dead yet, comrade.");
            Console.ReadKey();
            Program.Print("Say, you’re not from the Red Line, are you? I’ve never seen you before.’");
            ClearScreen();
            Program.Print(Program.currentPlayer.name + ": ‘I’m from VDNKh.’");

            while (true)
            {
                ClearScreen();
                Program.Print("Leader: ‘Now, that’s a long way from home." +
                    "\nWhat did you do to piss off those nazi bastards so much they wanted to hang you?’" +
                    "\n" +
                    "\n(1) Say you killed one" +
                    "\n(2) Say nothing");

                string choice = Console.ReadLine().ToLower();

                if (choice == "1" || choice == "killed one" || choice == "say you killed one")
                {
                    Console.Clear();
                    Program.Print(Program.currentPlayer.name + ": ‘I killed one of their officers.’");
                    ClearScreen();
                    Program.Print("They all look at each other fairly impressed.");
                    Console.ReadKey();
                    Program.Print("‘Right on! To hell with those bastards!’ one of the other guys says" +
                        "\nand pats you respectfully on your shoulder.");
                    ClearScreen();
                    break;
                }
                else if (choice == "2" || choice == "nothing" || choice == "say nothing")
                {
                    Console.Clear();
                    Program.Print("You look down and say nothing...");
                    ClearScreen();
                    Program.Print("‘It’s okay, you don’t have to tell us.’ the leader says." +
                        "\n‘As long as you caused them trouble, we’re happy.’");
                    ClearScreen();
                    break;
                }
                else
                    Console.WriteLine("[Invalid Input]");
            }
            Program.Print("Suddenly, you jump up, scared of one thought!");
            Console.ReadKey();
            Program.Print("‘Where are we going?!’ you ask worriedly. ‘I need to get to Polis!’");
            ClearScreen();
            Program.Print("Leader: ‘Sorry, we can’t go back. We’re being followed by those assholes.");
            Console.ReadKey();
            Program.Print("If you want, we can drop you off at Paveletskaya. It’s not that far from Polis." +
                "\nFrom there, you just have to go west and then north.’");
            ClearScreen();
            Program.Print("You feel a nasty sting of disappointment about that step back. You were almost there!");
            ClearScreen();
            Program.Print("Then again... ");
            Console.ReadKey();
            Program.Print("It’s a miracle that you’re still breathing...");
            Console.ReadKey();
            Program.Print("You feel a sudden sense of gratitude for the men around you.");
            ClearScreen();
            Program.Print(Program.currentPlayer.name + ": ‘Thank you for saving my life, by the way’.");
            Console.ReadKey();
            Program.Print("The guys look at each other and smile back at you.");
            ClearScreen();
            Program.Print(Program.currentPlayer.name + ": ‘If it’s not too much to ask, I’d like you to drop me off at Paveletskaya then.’");
            Console.ReadKey();
            Program.Print("Leader: ‘Sure, kid. Will do.’");
            ClearScreen();
        }

        public static void PushkinskayaStation()
        {
            Console.Clear();
            Program.Print("You awake lying on the floor in a gloomy and dirty room.");
            ClearScreen();
            Program.Print("Everything hurts.");
            Console.ReadKey();
            Program.Print("You can taste blood.");
            Console.ReadKey();
            Program.Print("Some of your ribs seem cracked and one of your eyes is so swollen, you can’t even open it.");
            ClearScreen();
            Program.Print("You see a small wooden stool in front of you, above it a rope hanging from the ceiling.");
            ClearScreen();
            Program.Print("‘He’s awake.’ you hear a voice without a body say. ‘Let’s get it over with!’");
            ClearScreen();
            Program.Print("A strong hand grabs you by the hair, picks you up and binds the rope around your neck.");
            Console.ReadKey();
            Program.Print("Then he pulls the rope up and makes you stand on the wooden stool.");
            ClearScreen();
            Program.Print("‘Since you’ve been caught spying and sabotaging against the REICH" +
                "\nyou’re hereby sentenced to death by hanging. What do you have to say in your defense?" +
                "\n" +
                "\n(1) Plea" +
                "\n(2) Insult");
            Console.ReadLine();
            Console.Clear();
            Program.Print("As you open your mouth, you feel a force behind you kicking the stool down.");
            ClearScreen();
            Program.Print("You reflexively tense all your neck muscles as they catch your entire bodyweight hanging now from the rope.");
            Console.ReadKey();
            Program.Print("You hear several people laughing out loud while your lungs desperately grasp for air.");
            ClearScreen();
            Program.Print("It’s no use...");
            ClearScreen();
            Program.Print("As you feel your body shutting down," +
                "\nthe last thing you think about is Sukhoi and your home and how you almost made it.");
            ClearScreen();
            Program.Print("So fucking close...");
            ClearScreen();
            Program.Print("As your whole world turns black you believe you hear some noises. But they seem far, far away...");
            ClearScreen();
            ClearScreen();
            ClearScreen();
        }

        public static void KitayGorodTunnel()
        {
            Console.Clear();
            Program.Print("After some running with all these people in the dark, you slow down and look back.");
            Console.ReadKey();
            Program.Print("They don’t seem to follow you.");
            ClearScreen();
            Program.Print("You catch your breath and walk on further.");
            ClearScreen();
            Program.Print("The crowd is gone. Here and there you notice occasional refugees running past you.");
            ClearScreen();
            Program.Print("On your way through the tunnel, you notice an old man leaning on a wall" +
                "\na strange looking boy next to him.");

            while (true)
            {
                ClearScreen();
                Program.Print("The old man is grasping for air and points and waves at you in a miserable way." +
                    "\nIt looks like he’s calling out to you for help." +
                    "\n" +
                    "\n (1) Help him" +
                    "\n (2) Ignore him");

                string choice1 = Console.ReadLine().ToLower();

                if (choice1 == "1" || choice1 == "help" || choice1 == "help him")
                {
                    Console.Clear();
                    Program.Print("You stop and turn in his direction.");
                    Console.ReadKey();
                    Program.Print("Now he’s pointing to a small plastic thing on the ground. Seems like he cannot reach it.");
                    ClearScreen();
                    Program.Print("You pick it up and give it to him.");
                    ClearScreen();
                    Program.Print("He frantically puts it in his mouth, pushes some kind of button and takes a really deep breath.");
                    ClearScreen();
                    Program.Print("‘Thank you very much. I really thought I was going to suffocate.’ says the old man, still breathing very heavily.");
                    Console.ReadKey();
                    Program.Print("‘I’m Mikhail by the way, what’s your name?’");
                    ClearScreen();
                    Program.Print(Program.currentPlayer.name + ": ‘No problem. My name is " + Program.currentPlayer.name + ".’");
                    ClearScreen();
                    Program.Print("The child looks at you with a weird smile. His eyes look slanted and his face is very flat.");
                    ClearScreen();
                    Program.Print("‘Is he okay?’ you ask.");
                    Console.ReadKey();
                    Program.Print("Mikhail: ‘He has Down-Syndrome. Don’t worry about him. He’s fine. His name is Filip." +
                        "\nCan you help me up please?’");
                    ClearScreen();
                    Program.Print("You help him get up and the three of you start walking.");
                    ClearScreen();
                    Program.Print(Program.currentPlayer.name + ": ‘I left Kitay-Gorod in a hurry and I’ve no idea where I am. " +
                        "\nI need to get to Polis as fast as possible!’");
                    Console.ReadKey();
                    Program.Print("Mikhail: ‘Yes, we too ran from the bandits. Don’t worry, you’re on the right track.");
                    Console.ReadKey();
                    Program.Print("There should be a checkpoint coming soon. Past that, this tunnel leads to Pushkinskaya station." +
                        "\nPolis is the station directly south of Pushkinskaya.’");
                    ClearScreen();
                    Program.Print("Relieved you walk with Makhail and Filip until you reach a guarded checkpoint.");
                    ClearScreen();
                    Program.Print("‘Stop!’ the guard shouts at you as you're trying to pass the checkpoint. " +
                        "\n‘Show me your passport! You need to pay a fee to pass!’");
                    ClearScreen();
                    Program.Print("Mikhail: ‘Don’t worry. I’ll handle it.’");
                    ClearScreen();
                    Program.Print("You don’t understand what Mikhail says with a very low voice into the guard’s ear. But apparently it worked.");
                    Console.ReadKey();
                    Program.Print("The guard lets the three of you pass without the need to show your documents or any toll fees.");
                    ClearScreen();
                    Program.Print("You walk right past the checkpoint into the next tunnel leading to Pushkinskaya.");
                    ClearScreen();
                    Encounters.GenericCombatEncounter();
                    Console.Clear();
                    Program.Print("As you exit the tunnel you see the lights of Pushkinskaya and before it another checkpoint.");
                    ClearScreen();
                    Program.Print("You’re starting to feel excited. You’re so close!");
                    ClearScreen();
                    Program.Print(Program.currentPlayer.name + ": ‘And you say I only have to enter the south tunnel of that station and I will directly reach the Polis?’");
                    Console.ReadKey();
                    Program.Print("Mikhail: ‘Yes. But you need to be careful here. This is REICH-Territory!");
                    Console.ReadKey();
                    Program.Print("I’ve heard they are sympathizers of the 1940’s German Hitler Regime. They are very dangerous" +
                        "\nand don’t take kindly to outsiders. Keep calm and let me do the talking’.");
                    ClearScreen();
                    Program.Print("You don’t know any Hitler but since he handled the last checkpoint so well, you trust him and keep quiet.");
                    ClearScreen();
                    Program.Print("As you approach the guard, Mikhail again tries to whisper something in his ear.");
                    Console.ReadKey();
                    Program.Print("But this time the guard doesn’t seem impressed at all. They seem to argue.");
                    ClearScreen();
                    Program.Print("All of a sudden, the guard hits Mikhail on the head with the back of his assault rifle!");
                    Console.ReadKey();
                    Program.Print("In obvious pain, he falls to the ground.");
                    ClearScreen();
                    Program.Print("Silent until now, Filip starts to scream and bites the guard in his arm.");
                    ClearScreen();
                    Program.Print("Now the guard screams and punches Filip viciously in the face.");
                    Console.ReadKey();
                    Program.Print("With a bleeding nose, Filip falls to his knees and starts to cry.");
                    Console.ReadKey();
                    Program.Print("Without hesitation, the guard puts out his pistol, aims right between Filips watery eyes" +
                        "\nand with absolute disgust in his face, he pulls the trigger.");
                    ClearScreen();
                    Program.Print("The crying stops instantly, as if the sound of the pistol itself erased it.");
                    ClearScreen();
                    Program.Print("The guard turns back to Mikhail, who just stares at Filip’s lifeless body as his bloody head brutally hits the ground.");
                    Console.ReadKey();
                    Program.Print("Mikhail’s mouth and eyes are wide open." +
                        "\nHis voice cracks and he just brings out some squealing noises as the guard slowly approaches him with his pistol in hand.");

                    while (true)
                    {
                        ClearScreen();
                        Program.Print("In shock until now, you regain your composure and consider what to do." +
                            "\n" +
                            "\n (1) Run" +
                            "\n (2) Fight");

                        string choice2 = Console.ReadLine().ToLower();

                        if (choice2 == "1" || choice2 == "run")
                        {
                            Console.Clear();
                            Program.Print("As the guard turns his back on you, eyes on Mikhail, you use your chance and run past him.");
                            ClearScreen();
                            Program.Print("‘He’s trying to get past without showing his documents! He’s a spy!’ you hear from behind.");
                            ClearScreen();
                            Program.Print("Then, all of a sudden three men storm out of a tent next to the checkpoint, tackle you to the ground" +
                                "\nand start kicking you with their boots until you lose consciousness.");
                            ClearScreen();
                            Program.Print("The last thing you hear is a loud gunshot.");
                            Console.ReadKey();
                            Program.Print("You can’t help but to think that that bullet had Mikhail’s name on it.");
                            break;
                        }
                        else if (choice2 == "2" || choice2 == "fight")
                        {
                            Console.Clear();
                            Program.Print("As the guard turns his back on you, eyes on Mikhail, you slowly reach to your assault rifle.");
                            Console.ReadKey();
                            Program.Print("Without thinking, as if your rifle would lift up itself, you point the barrel at the guard’s back.");
                            ClearScreen();
                            Program.Print("Everything becomes blurry.");
                            Console.ReadKey();
                            Program.Print("Everything becomes meaningless.");
                            Console.ReadKey();
                            Program.Print("Right now, you don’t care about your mission.");
                            Console.ReadKey();
                            Program.Print("You don’t care about your war, about Dark Ones, or anything else.");
                            Console.ReadKey();
                            Program.Print("The only thing that matters now, is that this piece of shit of a child murderer is going to die.");
                            ClearScreen();
                            Program.Print("You pull the trigger.");
                            ClearScreen();
                            Program.Print("Alarmed by the gunshots, three other guards storm out of the tent nearby and run towards you" +
                                "\nas you empty your magazine on that blood-soaked bastard.");
                            Console.ReadKey();
                            Program.Print("As you run out of bullets, the other guards tackle you to the ground and start kicking you with their boots.");
                            ClearScreen();
                            Program.Print("You lose consciousness with a satisfied smile on your face.");
                            ClearScreen();
                            Encounters.ReceiveXP();
                            break;
                        }
                        else
                            Console.WriteLine("[Invalid Input]");
                    }
                    ClearScreen();
                    break;
                }
                else if (choice1 == "2" || choice1 == "ignore" || choice1 == "ignore him")
                {
                    Console.Clear();
                    Program.Print("You can’t lose any more time.");
                    Console.ReadKey();
                    Program.Print("Without looking twice you walk past the old man and the kid.");
                    ClearScreen();
                    Program.Print("A few seconds later, the wheezing stops as you hear something falling to the ground.");
                    ClearScreen();
                    Program.Print("After a while, you reach a guarded checkpoint.");
                    Console.ReadKey();
                    Program.Print("‘Stop!’ the guard shouts at you at you try to pass it. ‘Show me your passport!’");
                    ClearScreen();
                    Program.Print("You show him your documents.");

                    while (true)
                    {
                        ClearScreen();
                        Program.Print("‘VDNKh, huh? Long way from home, aren’t you? The toll is 10 rounds!’" +
                            "\n" +
                            "\n(1) Pay" +
                            "\n(2) Bargain" +
                            "\n(3) Fight");

                        string choice3 = Console.ReadLine().ToLower();

                        if (choice3 == "1" || choice3 == "pay")
                        {
                            Console.Clear();
                            Program.Print("Without complaining you pay the fee and be on your way into the next tunnel.");
                            Program.currentPlayer.bullets -= 10;
                            if (Program.currentPlayer.bullets < 0)
                                Program.currentPlayer.bullets = 0;
                            break;
                        }
                        else if (choice3 == "2" || choice3 == "bargain")
                        {
                            Console.Clear();
                            Program.Print(Program.currentPlayer.name + ": ‘How about 5?’");
                            Console.ReadKey();
                            Program.Print("Guard: ‘A wicked one, aren’t we?’ hey says with a condescending look.");

                            while (true)
                            {
                                ClearScreen();
                                Program.Print("‘Let’s make it 15. Pay or leave!’" +
                                    "\n" +
                                    "\n(1) Pay" +
                                    "\n(2) Fight");

                                string choice4 = Console.ReadLine().ToLower();

                                if (choice4 == "1" || choice4 == "pay")
                                {
                                    Console.Clear();
                                    Program.Print("With clenched Teeth you pay the fee and be on your way into the next tunnel.");
                                    Program.currentPlayer.bullets -= 15;
                                    if (Program.currentPlayer.bullets < 0)
                                        Program.currentPlayer.bullets = 0;
                                    break;
                                }
                                else if (choice4 == "2" || choice4 == "fight")
                                {
                                    Console.Clear();
                                    Encounters.CheckpointGuard();
                                    Console.Clear();
                                    Program.Print("Without looking back, you run into the tunnel in front of you.");
                                    break;
                                }
                                else
                                    Console.WriteLine("[Invalid Input]");
                            }
                            break;
                        }
                        else if (choice3 == "3" || choice3 == "fight")
                        {
                            Console.Clear();
                            Encounters.CheckpointGuard();
                            Console.Clear();
                            Program.Print("Without looking back, you run into the tunnel in front of you.");
                            break;
                        }
                        else
                            Console.WriteLine("[Invalid Input]");
                    }
                    ClearScreen();
                    Encounters.GenericCombatEncounter();
                    Console.Clear();
                    Program.Print("Not knowing exactly where you are, you exit the tunnel and see the lights of a very big station" +
                        "\nanother checkpoint right before it.");
                    Console.ReadKey();
                    Program.Print("The sign reads: ‘Pushkinskaya’.");
                    ClearScreen();
                    Program.Print("You’re starting to feel excited. You know where you are!");
                    Console.ReadKey();
                    Program.Print("It’s just one station north to the Polis. You’re so close!");
                    ClearScreen();
                    Program.Print("But now you remember of what you heard about this station.");
                    Console.ReadKey();
                    Program.Print("This is REICH-Territory!");
                    Console.ReadKey();
                    Program.Print("Here are living sympathizers with some dead German guy called Hikler or something like that." +
                        "\nThey are very dangerous people and they don’t take kindly to outsiders.");
                    ClearScreen();
                    Program.Print("‘What the fuck do YOU want here?!’ The guard aggressively asks the woman in front of you.");
                    Console.ReadKey();
                    Program.Print("She’s got remarkably dark skin for someone living in the metro.");
                    Console.ReadKey();
                    Program.Print("She seems to be a refugee from Kitay-Gorod.");
                    ClearScreen();
                    Program.Print("Woman: ‘Please, let me pass! Our station got raided by bandits. I can’t go back!’");
                    Console.ReadKey();
                    Program.Print("Guard: ‘The REICH is for Russians only! We don’t let vermin into our station. " +
                        "\nTurn back now, this is your last warning!’");
                    Console.ReadKey();
                    Program.Print("The woman starts to panic. ‘But... but if you send me back, they’ll kill me! You just need to –‘");
                    ClearScreen();
                    Program.Print("The guard will never know what he needed to do.");
                    Console.ReadKey();
                    Program.Print("The gun in his hand ended the conversation abruptly.");

                    while (true)
                    {
                        ClearScreen();
                        Program.Print("Still in shock, you regain your composure and consider what to do." +
                            "\n" +
                            "\n (1) Run" +
                            "\n (2) Fight");

                        string choice5 = Console.ReadLine().ToLower();

                        if (choice5 == "1" || choice5 == "run")
                        {
                            Console.Clear();
                            Program.Print("As the guard turns his back on you, eyes on the woman on the ground writhing in pain" +
                                "\nyou use your chance and run past him.");
                            ClearScreen();
                            Program.Print("‘He’s trying to get past without showing his documents! He’s a spy!’ you hear from behind.");
                            ClearScreen();
                            Program.Print("Then, all of a sudden three men storm out of a tent next to the checkpoint, tackle you to the ground" +
                                "\nand start kicking you with their boots until you lose consciousness.");
                            ClearScreen();
                            Program.Print("The last thing you hear is a loud gunshot.");
                            Console.ReadKey();
                            Program.Print("You can’t help but think that the woman has stopped writhing now...");
                            break;
                        }
                        else if (choice5 == "2" || choice5 == "fight")
                        {
                            Console.Clear();
                            Program.Print("As the guard turns his back on you, eyes on the woman on the ground writhing in pain" +
                                "\nyou slowly reach to your assault rifle.");
                            Console.ReadKey();
                            Program.Print("Without thinking, as if your rifle would lift up itself, you point the barrel at the guard’s back.");
                            ClearScreen();
                            Program.Print("Everything becomes blurry.");
                            Console.ReadKey();
                            Program.Print("Everything becomes meaningless.");
                            Console.ReadKey();
                            Program.Print("Right now, you don’t care about your mission.");
                            Console.ReadKey();
                            Program.Print("You don’t care about your war, about Dark Ones, or anything else.");
                            Console.ReadKey();
                            Program.Print("The only thing that matters now, is that this racist piece of shit is going to die.");
                            ClearScreen();
                            Program.Print("You pull the trigger.");
                            ClearScreen();
                            Program.Print("Alarmed by the gunshots, three other guards storm out of the tent nearby and run towards you" +
                                "\nas you empty your magazine on that blood-soaked bastard.");
                            Console.ReadKey();
                            Program.Print("As you run out of bullets, the other guards tackle you to the ground and start kicking you with their boots.");
                            ClearScreen();
                            Program.Print("You lose consciousness with a satisfied smile on your face.");
                            ClearScreen();
                            Encounters.ReceiveXP();
                            break;
                        }
                        else
                            Console.WriteLine("[Invalid Input]");
                    }
                    ClearScreen();
                    break;
                }
                else
                    Console.WriteLine("[Invalid Input]");
            }
        }

        public static void KitayGorodStation()
        {
            Console.Clear();
            Program.Print("Kitay-Gorod is also quite big and dense, but its condition seems a lot worse than the last stations you visited.");
            Console.ReadKey();
            Program.Print("You believe that it’s run by a powerful crime syndicate.");
            ClearScreen();
            Program.Print("You see a weapon shop and decide to look for supplies.");
            ClearScreen();
            Shop.LoadShopSavePoint(Program.currentPlayer);
            Console.Clear();
            Program.Print("As you exit the shop, you see a group of people sitting around a fire, roasting their rat skewers over it.");
            Console.ReadKey();
            Program.Print("On the other side of the tracks there is a crowd listening to a musician playing an instrument you never heard before.");
            Console.ReadKey();
            Program.Print("‘For a run-down station like this, it seems quite peaceful’ you think.");
            ClearScreen();
            Program.Print("Then, all of a sudden, you hear gunshots!");
            Console.ReadKey();
            Program.Print("Panic’s spreading fast. People are running in all directions.");
            ClearScreen();
            Program.Print("It seems that the station is getting raided by bandits.");
            Console.ReadKey();
            Program.Print("You try to avoid them by changing the metro line.");
            ClearScreen();
            Encounters.KitayGorodBandit();
            Console.Clear();
            Program.Print("You hear more of them coming and don’t intend to wait for them" +
                "\nso you disguise yourself in the fleeing crowd and run with them into the next tunnel.");
            ClearScreen();
        }

        public static void TurgenevskayaStation()
        {
            Console.Clear();
            Program.Print("Finally, you reach the Turgenevskaya.");
            Console.ReadKey();
            Program.Print("This station is even larger than the market station.");
            Console.ReadKey();
            Program.Print("After all, this station is a junction between three different lines in Moscow’s Metro.");
            ClearScreen();
            Program.Print("The place is crowded with people, stores, and restaurants in tents.");
            Console.ReadKey();
            Program.Print("The smell of cooked pork reminds you that you haven’t eaten in almost a day.");
            ClearScreen();
            Program.Print("You shake it off! You can eat at the Polis after you delivered Sukhoi’s message.");
            ClearScreen();
            Program.Print("You find your way through the crowd and enter the tunnel to Kitay-Gorod station.");
            ClearScreen();
        }

        public static void ProspektMiraTunnel()
        {
            Console.Clear();
            Program.Print("As the many lights and the noises of the busy Prospekt Mira begin to fade" +
                "\neverything seems fine for now.");
            ClearScreen();
            Program.Print("Without a word you march forward, paying a lot of attention to your surroundings.");
            ClearScreen();
            Program.Print("After a few minutes, you hear that familiar noise again.");
            ClearScreen();
            Program.Print(Program.currentPlayer.name + ": ‘I can hear it! It’s still very subtle, but we’re getting closer.’");
            Console.ReadKey();
            Program.Print("Bourbon: ‘Listen man, if I go crazy or something I need you to get me out of there. I’m counting on you!’");
            ClearScreen();
            Program.Print("You nod and move forward to the ominous force.");
            ClearScreen();
            Program.Print("As you come closer, the noise gets louder. Exactly as you have witnessed before.");
            ClearScreen();
            Program.Print("Going even further, every fiber of your body is telling you to turn around, but you keep moving.");
            ClearScreen();
            Program.Print("Bourbon is being remarkably quiet.");
            ClearScreen();
            Program.Print("At one point, as the noise and the pain become almost unbearable for you," +
                "\nyou notice a large pipe to your right. ");
            Console.ReadKey();
            Program.Print("Some kind of gas seems to leak from it.");
            ClearScreen();
            Program.Print("All of a sudden, Bourbon stops and says in a calm and peaceful voice: ‘Okay. I die now.’");
            Console.ReadKey();
            Program.Print("Then he lays down on the ground and closes his eyes.");
            ClearScreen();
            Program.Print("You start to panic. You grab him and shake him hard trying to wake him up. He’s not reacting one bit.");

            while (true)
            {
                ClearScreen();
                Program.Print("You know you can’t stay here any longer! What do you do?" +
                    "\n" +
                    "\n(1) Leave him" +
                    "\n(2) Carry him");

                string choice1 = Console.ReadLine().ToLower();

                if(choice1 == "1" || choice1 == "leave" || choice1 == "leave him")
                {
                    Console.Clear();
                    Program.Print("You can’t handle the pain anymore. And Bourbon seems too heavy to carry.");
                    ClearScreen();
                    Program.Print("With a heavy heart you decide to leave him in the tunnel and run as fast as you can to the exit.");
                    ClearScreen();
                    Program.Print("After some time, the pain stops and you finally reach the next station.");
                    ClearScreen();
                    Program.Print("To your surprise, you’re the only one here.");
                    ClearScreen();
                    Program.Print("You remember Sukhoi telling you about an uninhabited station functioning as a transit between different metro lines.");
                    ClearScreen();
                    Program.Print("With remorse you look back into the tunnel.");
                    Console.ReadKey();
                    Program.Print("‘Maybe he’ll wake up on his own and find his way here.’ You say to yourself." +
                        "\nWell knowing you don’t actually believe it...");
                    ClearScreen();
                    Program.Print("As your conscience grows heavier by the second, you try not to dwell on it and ignore your feelings.");
                    ClearScreen();
                    Program.Print("You have a mission to fulfill. Your station is counting on you.");
                    ClearScreen();
                    Program.Print("No time to waste. You walk quietly through the transit station into the next tunnel.");
                    ClearScreen();
                    break;
                }
                else if (choice1 == "2" || choice1 == "carry" || choice1 == "carry him")
                {
                    Console.Clear();
                    Program.Print("You heave him on your shoulders and start walking slowly towards the end of the tunnel.");
                    ClearScreen();
                    Program.Print("Your eardrums feel like they will burst any second. But you keep walking!");
                    ClearScreen();
                    Program.Print("Finally, the noise dies down and you think you can make out the end of the tunnel, even though you see no lights.");
                    ClearScreen();
                    Program.Print("You reach the next station, but to your surprise, you’re the only one here.");
                    ClearScreen();
                    Program.Print("You remember Sukhoi telling you about an uninhabited station functioning as a transit between different metro lines.");
                    ClearScreen();
                    Program.Print("Worn out by the exertion you sink down to the floor, Bourbon’s motionless body next to you, catching your breath.");
                    ClearScreen();
                    Program.Print("After a few minutes of regaining strength, you try to wake up Bourbon once more.");
                    Console.ReadKey();
                    Program.Print("Without success.");
                    ClearScreen();
                    Program.Print("You notice that he looks very pale.");
                    Console.ReadKey();
                    Program.Print("You didn’t think that someone who has never seen the sunlight could look paler than Bourbon did before, but right now he does.");
                    ClearScreen();
                    Program.Print("You check for a pulse...");
                    Console.ReadKey();
                    Program.Print("He’s dead.");
                    ClearScreen();
                    Program.Print("How is this possible? He just lay down for a minute.");
                    Console.ReadKey();
                    Program.Print("Did you carry him too roughly?");
                    ClearScreen();
                    Program.Print("You think about burying him, but you have to get to Polis as soon as you can.");
                    Console.ReadKey();
                    Program.Print("You have no choice but to leave him here.");
                    ClearScreen();
                    Program.Print("Before you go, the reward he promised you for getting him to Turgenevskaya springs back into your mind.");

                    while (true)
                    {
                        ClearScreen();
                        Program.Print("Should you maybe have a little look through his stuff?" +
                            "\n" +
                            "\n(1) Loot him" +
                            "\n(2) Leave him");

                        string choice2 = Console.ReadLine().ToLower();

                        if (choice2 == "1" || choice2 == "loot" || choice2 == "loot him")
                        {
                            Console.Clear();
                            Program.Print("‘He doesn’t need it anymore’ you think to yourself and have a look in his backpack.");
                            ClearScreen();
                            Program.Print("To your surprise, except for some worthless stuff you can’t find anything remotely useful.");
                            ClearScreen();
                            Program.Print("What’s more, there’s no sign of the reward you were supposed to get after a successful mission.");
                            ClearScreen();
                            Program.Print("Somehow you can’t shake the feeling that he would’ve gotten rid of you shortly before you reached Turgenevskaya station.");
                            ClearScreen();
                            Program.Print("Disappointed, your attention falls on his assault rifle.");
                            Console.ReadKey();
                            Program.Print("It looks in better shape than yours and it even has a scope attached to it.");
                            ClearScreen();
                            Program.Print("Even though you didn’t finish the mission, you did the best you could.");
                            Console.ReadKey();
                            Program.Print("You feel like taking his assault rifle and magazine as a reward is justified.");
                            ClearScreen();

                            Console.ResetColor();
                            Console.WriteLine("You recieve 30 bullets and your ranged weapon value increased +2!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Program.currentPlayer.bullets += 30;
                            Program.currentPlayer.rangedWeaponValue += 2;
                            ClearScreen();

                            Program.Print("Without any remorse of guilt, you swap weapons and start moving into the tunnel leading to Turgenevskaya.");
                            ClearScreen();
                            break;
                        }
                        else if (choice2 == "2" || choice2 == "leave" || choice2 == "leave him")
                        {
                            Console.Clear();
                            Program.Print("‘It’s not right. I didn’t finish the mission’ you think.");
                            Console.ReadKey();
                            Program.Print("You can’t bury him here. But you can at least keep your honor and let him rest in peace.");
                            ClearScreen();
                            Program.Print("Satisied with your decision you leave him at the transit station and start moving into the tunnel leading to Turgenevskaya.");
                            ClearScreen();
                            Encounters.ReceiveXP();
                            Console.Clear();
                            break;
                        }
                        else
                            Console.WriteLine("[Invalid Input]");
                    }
                    break;
                }
                else
                    Console.WriteLine("[Invalid Input]");
            }
        }

        public static void ProspektMiraStation()
        {
            Console.Clear();
            Program.Print("You arrive at the market station.");
            Console.ReadKey();
            Program.Print("Prospekt Mira is considerably bigger than the other stations you visited.");
            ClearScreen();
            Program.Print("It’s crowded and there are indeed many improvised stores.");
            ClearScreen();
            Program.Print("You say goodbye to Boris and the rest of the boys and look for supplies for your journey.");
            ClearScreen();
            Program.Print("Close by, you can make out a weapons shop:");
            ClearScreen();
            Shop.LoadShop(Program.currentPlayer);
            Console.Clear();
            Program.Print("As you browse through the shop’s inventory you feel a presence approaching from behind.");

            while (true)
            {
                ClearScreen();
                Program.Print("‘They say you’re immune to the force. Is that true?’ asks a young man with a cunning smile." +
                    "\n" +
                    "\n (1) Respond" +
                    "\n (2) Ignore him");

                string choice1 = Console.ReadLine().ToLower();

                if (choice1 == "1" || choice1 == "respond")
                {
                    Console.Clear();
                    Program.Print(Program.currentPlayer.name + ": ‘I hear a loud noise. But I don’t become crazy, if that’s what you mean.’");
                    ClearScreen();
                    Program.Print("‘Perfect! You’re exactly the person that I need!’ says the young man.");
                    Console.ReadKey();
                    Program.Print("‘My name is Bourbon and I need an escort to Turgenevskaya station.'");
                    ClearScreen();
                    Program.Print("Bourbon: 'There is another force waiting on the way there. I need you to make sure I don’t go nuts." +
                        "\nIf I arrive there safely, I’ll give you one stack for your assault rifle. What do you say?’");
                    ClearScreen();
                    break;
                }
                else if (choice1 == "2" || choice1 == "ignore" || choice1 == "ignore him")
                {
                    Console.Clear();
                    Program.Print("‘I don’t know what you’re talking about.’ You mumble briefly.");
                    ClearScreen();
                    Program.Print("‘Come on man! I know Boris. He told me you saved their lives.’ says the young man.");
                    Console.ReadKey();
                    Program.Print("My name is Bourbon and I need an escort to Turgenevskaya station.'");
                    ClearScreen();
                    Program.Print("There is another force waiting on the way there. I need you to make sure I don’t go nuts." +
                        "\nIf I arrive there safely, I give you one stack for your assault rifle. What do you say?");
                    ClearScreen();
                    break;
                }
                else
                    Console.WriteLine("[Invalid Input]");
            }

            Program.Print("You consider his offer...");
            Console.ReadKey();
            Program.Print("You pass Turgenevskaya on your way to Polis anyway." +
                "\nIt’s just two stations to Turgenevskaya. And then just a few more to Polis.");
            Console.ReadKey();
            Program.Print("Also, the 30 rounds for your assault rifle could come in handy on your journey...");

            while (true)
            {
                ClearScreen();
                Program.Print("You tell him your decision:" +
                    "\n" +
                    "\n (1) Accept" +
                    "\n (2) Bargain");

                string choice2 = Console.ReadLine().ToLower();

                if (choice2 == "1" || choice2 == "accept")
                {
                    Console.Clear();
                    Program.Print(Program.currentPlayer.name + ": ‘Alright, I’ll take you there. But we need to leave now!’");
                    Console.ReadKey();
                    Program.Print("Bourbon: ‘Lead the way!’");
                    ClearScreen();
                    break;
                }
                else if (choice2 == "2" || choice2 == "bargain")
                {
                    Console.Clear();
                    Program.Print(Program.currentPlayer.name + ": ‘Two stacks! And we have to leave now!’");
                    ClearScreen();
                    Program.Print("Bourbon: ‘You’re quite the haggler...");
                    Console.ReadKey();
                    Program.Print("Alright fine. 60 rounds when we arrive at Turgenevskaya! Lead the way.’");
                    ClearScreen();
                    break;
                }
                else
                    Console.WriteLine("[Invalid Input]");
            }
            Program.Print("You both leave the shop and enter the next tunnel.");
        }

        public static void RigskayaTunnel()
        {
            Console.Clear();
            Program.Print("As the lights from Rigskaya station are beginning to fade, it’s getting even darker.");
            Console.ReadKey();
            Program.Print("So far, everything seems quiet...");
            ClearScreen();
            Program.Print("After a while, you believe you hear a little sound coming from in front of you...");
            Console.ReadKey();
            Program.Print("...something like a soft humming.");
            ClearScreen();
            Program.Print("As you travel deeper into the tunnel, the humming sound gets louder, almost impossible to ignore.");

            while (true)
            {
                ClearScreen();
                Program.Print("You look around, wondering if anybody else is noticing it..." +
                    "\n" +
                    "\n(1) Ask around" +
                    "\n(2) Say nothing");

                string choice1 = Console.ReadLine().ToLower();

                if (choice1 == "1" || choice1 == "ask" || choice1 == "ask around")
                {
                    Console.Clear();
                    Program.Print(Program.currentPlayer.name + ": ‘Anybody else hearing this?’");
                    ClearScreen();
                    Program.Print("Boris gives the order to stop the escort." +
                        "\nEveryone listens carefully into the darkness...");
                    ClearScreen();
                    Program.Print("After a few moments Boris and the others give you a confused look as if they didn’t hear anything...");
                    ClearScreen();
                    Program.Print("You suddenly feel a rush of blood getting pumped into your head.");
                    ClearScreen();
                    Program.Print("‘Getting cold feet?’ jokes one of the soldiers. " +
                        "\nOthers laugh.");
                    ClearScreen();
                    Program.Print("‘Enough!’ shouts Boris. ‘This is no game. Focus on the mission!");
                    Console.ReadKey();
                    Program.Print("And don’t tease the kid. At this age you all would have lost your nerve. Forward!’");
                    ClearScreen();
                    Program.Print("The formation starts moving again.");
                    ClearScreen();
                    Program.Print("Embarrassed, you sink into your seat and don’t dare to open your mouth once more.");
                    ClearScreen();
                    Program.Print("Still, you wonder why nobody is hearing that obvious noise...");
                    ClearScreen();
                    break;
                }
                else if (choice1 == "2" || choice1 == "say nothing" || choice1 == "nothing")
                {
                    Console.Clear();
                    Program.Print("You keep your thoughts to yourself.");
                    ClearScreen();
                    Program.Print("Still, you wonder why nobody is mentioning the obvious noise.");
                    Console.ReadKey();
                    Program.Print("Maybe they’re just focusing on the mission...");
                    ClearScreen();
                    break;
                }
                else
                    Console.WriteLine("[Invalid Input]");
            }
            Program.Print("As you move closer to the source of the noise, the humming is getting so loud and painful" +
                    "\nthat you need to cover your ears.");
            ClearScreen();
            Program.Print("Confused you look around if the others are still ignoring that unbearable sound.");
            Console.ReadKey();
            Program.Print("Nobody else is covering their ears.");
            ClearScreen();
            Program.Print("But as you look closer, some of the men start acting weird.");
            Console.ReadKey();
            Program.Print("One of them starts laughing without a reason." +
                "\nAnother one faints.");
            Console.ReadKey();
            Program.Print("Boris is just standing there, his eyes and mouth wide open, making weird noises.");
            Console.ReadKey();
            Program.Print("The guy in the back turns backwards and, without a word, starts walking in the direction you came from" +
                "\nwhile the guy in the front breaks down on the spot and starts crying.");
            ClearScreen();
            Program.Print("You don’t understand what’s happening here, but you know one thing:");
            Console.ReadKey();
            Program.Print("If you stay here any longer, you will never get out of this tunnel!");
            ClearScreen();
            Program.Print("You rip off some pieces of cloth and plug them into your ears.");
            ClearScreen();
            Program.Print("Then you start gathering everyone onto the trolly, starting with the guy who walked backwards.");

            while (true)
            {
                ClearScreen();
                Program.Print("As you try to collect the guy who broke down in the front, he screams at you:" +
                    "‘THEY ARE VERY ANGRY! THEY WANT JUSTICE!’" +
                    "\n" +
                    "\n(1) Smack him" +
                    "\n(2) Calm him");

                string choice2 = Console.ReadLine().ToLower();

                if (choice2 == "1" || choice2 == "smack" || choice2 == "smack him")
                {
                    Console.Clear();
                    Program.Print("Worrying he might panic the other guys on the trolley, you smack him right in the face" +
                        "\nin the hope to get him out of his trance!");
                    ClearScreen();
                    Encounters.RigskayaSoldier();
                    Console.Clear();
                    break;
                }
                else if (choice2 == "2" || choice2 == "calm" || choice2 == "calm him")
                {
                    Console.Clear();
                    Program.Print("You try to calm him:");
                    ClearScreen();
                    Program.Print(Program.currentPlayer.name + ": ‘Shhhh... listen closely. Don’t you hear them?");
                    Console.ReadKey();
                    Program.Print("They want you to get on that trolley’");
                    ClearScreen();
                    Program.Print("‘You’re right!’ he responds with delight. And he calmly steps on the handcar.");
                    ClearScreen();

                    Encounters.ReceiveXP();

                    Console.Clear();
                    break;
                }
                else
                    Console.WriteLine("[Invalid Input]");
            }
            Program.Print("With the rest on the trolley, you use all your strength to operate the wagon on your own " +
                "and finally get you away from this nightmare.");
            ClearScreen();
            Program.Print("After a while, the humming noise is getting quieter and the men around you become themselves again.");
            ClearScreen();
            Program.Print("Boris: ‘I don’t know what happened back there, but thanks to you we got out in one piece." +
                "\nThank you, " + Program.currentPlayer.name + "!’");
            ClearScreen();
            Program.Print("You nod and push the trolley further to Prospekt Mira.");
            ClearScreen();
        }

        public static void RigskayaStation()
        {
            Console.Clear();
            Program.Print("You enter Rigskaya station.");
            Console.ReadKey();
            Program.Print("It looks even less populated than the Alexeyevskaya.");
            ClearScreen();
            Program.Print("You hurry through the empty station." +
                "\nAt the far end, you indeed see a group of people getting ready to enter the tunnel.");
            Console.ReadKey();
            Program.Print("Five strong men, armed to the teeth, prepare a trolly standing in front of the tunnel entrance.");
            ClearScreen();
            Program.Print("You approach the crew and ask if you can join their mission.");
            ClearScreen();
            Program.Print("Boris, who appears to be the leader, responds:" +
                "\n‘You’re Sukhoi’s kid, from VDNKh, right? Sure, you can. We take all the help we can get.");
            Console.ReadKey();
            Program.Print("Hope you know what you’re getting yourself into...’");
            ClearScreen();
            Program.Print("You jump on the trolley and together you enter the tunnel to Prospekt Mira.");
            ClearScreen();
        }

        public static void AlexeyevskyaStation()
        {
            Console.Clear();
            Program.Print("You arrive at Alexeyevskaya, a sparsely populated station.");
            Console.ReadKey();
            Program.Print("To get to Polis you need to get to the next station, the Rigskaya" +
                "\nand from there to the market station, Prospekt Mira.");
            ClearScreen();
            Program.Print("As you walk towards the next tunnel to Rigskaya, you spot Pavel, your uncle's friend.");
            ClearScreen();
            Program.Print(Program.currentPlayer.name + ": 'Pavel!'");
            ClearScreen();
            Program.Print("Pavel: '" + Program.currentPlayer.name + "! How are you, my friend? How's Sukhoi?'");
            ClearScreen();
            Program.Print(Program.currentPlayer.name + ": 'Listen Pavel, I have no time to explain. I need to get to Prospekt Mira quickly!" +
                "\nHow is the situation in the tunnels?'");
            ClearScreen();
            Program.Print("Pavel: 'Well, in the tunnel to Rigskaya we just have some small visitors. Nothing we can't handle.");
            Program.Print("But the tunnel to Prospekt Mira is something different...");
            ClearScreen();
            Program.Print("Rigskaya already sent out two caravans. They haven't returned yet.");
            ClearScreen();
            Program.Print("People are scared... They are sending out a third and last crew soon." +
                "\nIf you hurry, you can maybe catch them and escort them." +
                "\nI wouldn't recommend going through that tunnel alone.'");
            ClearScreen();
            Program.Print("You thank Pavel for the info and rush towards the Rigskaya tunnel in the hope of catching the escort to Propekt Mira in time!");
            ClearScreen();
        }

        public static void VDNKhStation()
        {
            Console.Clear();
            Program.Print("You return to your post and after a while the relief watchmen finally arrive" +
                "\nand you make your way back to the VDNKh Metro Station.");
            ClearScreen();
            Program.Print("Back home, you tell your uncle Sukhoi, that there was another Dark One attack.");
            ClearScreen();
            Program.Print("Sukhoi: 'Another one?! This is the third one this week!");
            Console.ReadKey();
            Program.Print(Program.currentPlayer.name + ", I need your help!'");
            ClearScreen();
            Program.Print("Sukhoi: 'This is becoming a war. Our People are dying...");
            Console.ReadKey();
            Program.Print("Please, " + Program.currentPlayer.name + ", I need you to travel to the heart of the metro..." +
                "\nTo Polis! Ask them for support!'");
            ClearScreen();
            Program.Print("Sukhoi: 'I know, it's dangerous... but I know you can do it! You have to!");
            ClearScreen();
            Program.Print("If they don't help us, we're doomed...'");
            ClearScreen();
            Program.Print("You don't need to think twice. You know he's right.");
            ClearScreen();
            Program.Print("You ignore your fatigue from the twelve-hour shift and silently pack your things." +
                "\nThen you say goodbye to Sukhoi and march south.");
            Console.ReadKey();
            Program.Print("To Polis!");
            ClearScreen();
            Program.Print("You enter the dark tunnel leading to the next station, the Alexeyevskaya.");
            ClearScreen();
        }

        public static void VDNKhOutpost()
        {
            string choice;

            Console.Clear();
            Program.Print("Moscow - 2033");
            ClearScreen();
            Program.Print("20 years have passed since the leading world nations annihilated themselves and the rest of the world with them." +
                "\nA few thousand managed to seek shelter in Moscow's Metro, surviving the explosions.");
            ClearScreen();
            Program.Print("Cut off from the surface and its poisonous atmosphere contaminated by radiation, " +
                "\nthe citizens had no other choice but to build a new civilization underground, inside the metro.");
            ClearScreen();
            Program.Print("There you are, sitting at a guard post 450 meters north of the VDNKh, your home station," +
                "\ntogether with two other guards from VDNKh, your friends Piotre and Evgeny.");
            ClearScreen();
            Program.Print("Suddenly, you hear a suspicious noise...");
            
            while (true)
            {
                ClearScreen();
                Program.Print("Piotre: 'What was that? " + Program.currentPlayer.name + "! Go and have a look!'" +
                    "\n" +
                    "\n(1) Obey" +
                    "\n(2) Refuse");

                choice = Console.ReadLine().ToLower();

                if (choice == "1" || choice == "obey")
                {
                    Console.Clear();
                    Program.Print("You go to the edge of your post and stare into the tunnel with your flashlight." +
                        "\nYou see a gloomy creature creeping towards you... it's a Dark One!");
                    ClearScreen();
                    break;
                }
                else if (choice == "2" || choice == "refuse")
                {
                    Console.Clear();
                    Program.Print(Program.currentPlayer.name + ": 'No way I'm going there! Look for yourself if you have the guts!'");
                    ClearScreen();
                    Program.Print("Piotre stands up and walks moaning to the edge of the guard post.");
                    Console.ReadKey();
                    Program.Print("Several minutes pass without him returning or answering your calls.");
                    Console.ReadKey();
                    Program.Print("Worrying about your friend, you go to the edge of your post and stare into the tunnel with your flashlight.");
                    ClearScreen();
                    Program.Print("There, you see a gloomy creature leaning over Piotre's corpse... it's a Dark One!");
                    ClearScreen();
                    break;
                }
                else
                    Console.WriteLine("[Invalid Input]");
            }
        }

        public static void ClearScreen()    // waits for an input an clears the screen; makes two lines into one
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
    