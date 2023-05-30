namespace WhoseCoatIsThatJacket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("", 0, "Unknown", "Unknown", 100);
            Bryn bryn = new Bryn("Bryn", 46, "6ft 1'", "Slim", 100);
            Gwen gwen = new Gwen("Gwen", 48, "5ft 6'", "Slim", 100);
            Smithy smithy = new Smithy("Smithy", 28, "5ft 8'", "Stocky", 100); ;
            FishingRod fr1 = new FishingRod("Large", 3, "A standard fishing rod. You notice the fishing line is missing and blood splatters on the handle. There is also coat/jacket hanging on the floor next to it which would fit a taller person", 100);
            InflatableLeek leek = new InflatableLeek("Small", 1, "It's an inflateable leek... The kind of thing you see Welsh people holding during the Rugby for some inexplicable reason.", 10);
            Knife knife = new Knife("Small", 1, "An unused butter knife found on the table. Great for buttering your toast!", 1);

            //Game introduction asking for the player's name
            Console.WriteLine("Siwmae! What is your name? \n");
            string playerName = Console.ReadLine();
            Console.WriteLine($"I'm gonna be honest with you here, {playerName}. This isn't a game with beautiful graphics, alright? You're going to need your imagination. You're about to be transported to a room in Cardiff with 3 weird people and a dead body. You need to find out what happened before the Rozzers get there or they'll arrest you (and ignore the others, how weeeeird...). Good luck! WEEEEEE");

            //Adding a 2 second pause using a for loop to seperate intro to game
            string pause = " ";

            for (int count = 0; count < 10; count++)
            {
                Console.WriteLine(string.Format(" ", count, pause));

                //wait for 2 seconds
                Thread.Sleep(200);
            }

            Console.WriteLine("You are now in the room, and it is bloody freezing!\n");
            //using the custom mainMenu method to easily return the player to the main selection section
            Console.WriteLine(mainMenu());

            //setting a for loop for the player to return to the main menu if exception is caught. Set the try limit to 1000 to allow for multiple uses of exception handling.
            for (int i = 0; i < 1000; i++)
            {
                try
                {   //as user input requires number it needs to be converted from string to int
                    int playerInput = Convert.ToInt32(Console.ReadLine());
                    //setting multiple if statements to determine the path of the player
                    if (playerInput == 1)
                    {   //using custom methods of character.Greet for code efficiency
                        Console.WriteLine(bryn.Greet());
                        Console.WriteLine($"You notice Bryn is the tallest of the guests at around {bryn.Height}. They are roughly {bryn.Age} years old and of {bryn.Build} build. They are the only one not wearing a coat...\n");
                        //returning mainMenu method to the console so players can keep track of where they are
                        Console.WriteLine(mainMenu());
                    }

                    if (playerInput == 2)
                    {
                        Console.WriteLine(gwen.Greet());
                        //using the ToLower string method to account for players capitalising. If players uses capital letters the condition wouldn't be met as the criteria needs to be all lower case
                        string playerOmelette = (Console.ReadLine().ToLower());
                        if (playerOmelette == "yes")
                        {
                            Console.WriteLine("Aw, lovely. Here you go!\n");

                        }
                        //setting else if statements to account for players choosing a different path
                        else if (playerOmelette == "no")
                        {
                            Console.WriteLine("Suit yourself, you ungrateful little toerag!\n");
                        }
                        Console.WriteLine($"Gwen is the shortest of the guests at around {gwen.Height}. They are roughly {gwen.Age} years old and of {gwen.Build} build.\n\n");
                        Console.WriteLine(mainMenu());
                    }
                    
                    else if (playerInput == 3)
                    {
                        Console.WriteLine(smithy.Greet());
                        Console.WriteLine($"Smithy doesn't seem to be from around here. They are the youngest of the guests at around {smithy.Age}. They are roughly {smithy.Height} and of {smithy.Build} build.\n\n");
                        Console.WriteLine(mainMenu());
                    }

                    else if (playerInput == 4)
                    {
                        Console.WriteLine(Body());
                        Console.WriteLine(mainMenu());
                    }

                    else if (playerInput == 5)
                    {
                        Console.WriteLine("When looking around the room you find various items - a fishing rod, an inflatable leek and a knife. Do you want to investigate further? If you want to return to the menu, type menu to go back to the main menu.\n");
                        string investigate = Console.ReadLine().ToLower();
                        {
                            while (investigate == "yes")
                            {
                                Console.WriteLine(ItemInfo());
                                int itemChoice = Convert.ToInt32(Console.ReadLine());
                                {
                                    if (itemChoice == 1)
                                    {
                                        Console.WriteLine($"{fr1.Description} It is a {fr1.Size} item and has a weight of {fr1.Weight}.\n");

                                    }
                                    else

                                   if (itemChoice == 2)
                                    {
                                        Console.WriteLine($"{leek.Description}. It is a {leek.Size} item and has a weight of {leek.Weight}.\n");

                                    }
                                    else

                                   if (itemChoice == 3)
                                    {
                                        Console.WriteLine($"{knife.Description}. It is a {knife.Size} item and has a weight of {knife.Weight}.\n");

                                    }

                                    if (itemChoice == 4)
                                    {
                                        Console.WriteLine(mainMenu());
                                        break;
                                    }
                                }
                            }
                            while (investigate == "no")
                            {
                                {
                                    Console.WriteLine(mainMenu());
                                    break;
                                }
                            }

                            while (investigate == "menu")
                            {
                                Console.WriteLine(mainMenu());
                                break;
                            }
                        }
                    }
                    else if (playerInput == 6)
                    {
                        Console.WriteLine($"Like a predator to its prey, Bryn senses your fear and starts leathering you with the inflatable leek while yelling 'SURPRIIISE! SURPRIIISE!'.\n");
                        Console.WriteLine("Do you want to fight or run?");
                        //need to add a try catch statement here to account for invalid user input (e.g integers or different string)
                        string playerFightChoice = Console.ReadLine().ToLower();
                        if (playerFightChoice == "fight")
                        {
                            Console.WriteLine(Fight());
                            int weaponChoice = Convert.ToInt32(Console.ReadLine());

                            if (weaponChoice == 1)
                            {
                                bryn.modifyHealth(-100);
                                Console.WriteLine($"Excellent choice. You pick up the fishing rod and hit Bryn. This is Bryn's kryptonite! Bryn now has {bryn.GetHealth()} health");
                                Console.WriteLine(PlayerWin());
                            }
                            else if (weaponChoice == 2)
                            {
                                bryn.modifyHealth(-10);
                                Console.WriteLine($"...Really? \n\n\nYou manage to grab the inflatable leek from Bryn and start smacking him. Bryn takes the inflateable leek to the face like a champ. Bryn now has {bryn.GetHealth()} health.\n");
                                Console.WriteLine(BrynAttack());
                                string rebelPlayer = Console.ReadLine();
                                Console.WriteLine(PlayerLose());
                                break;

                            }
                            else if (weaponChoice == 3)
                            {
                                Console.WriteLine($"Ah yes, you'd think that was a wise move wouldn't you? I bet you didn't read the description! The knife does next to no damage, but leaves a bit of butter across his cheek. Bryn now has {bryn.GetHealth()} health. He is enraged by the butter! {BrynAttack()}");
                            }
                        }
                        else
                        Console.WriteLine(PlayerLose());
                        break;
                    }

                    else if (playerInput == 7)
                    {
                        for (int g = 0; i < 1000; i++)
                        {
                            try
                            {
                                Console.WriteLine(Guess());
                                string playerGuess = Console.ReadLine().ToLower();

                                if (playerGuess == "bryn")
                                {
                                    Console.WriteLine(PlayerWin());
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine("No, you see... that's not right. You've just sent an innocent person to the slammer! Step away from your keyboard, you've done enough damage here.");
                                    string rebelPlayer = Console.ReadLine();
                                    Console.WriteLine(PlayerLose());
                                    break;
                                }
                            }

                            catch
                            {
                                Console.WriteLine("Who's that? Think you've been playing too many of our games, Matt... Try again!\n");
                            }
                        }
                        break;
                    }
                }

                catch
                {
                    Console.WriteLine("Not a number, ya twpsyn. Try again...\n");
                    Console.WriteLine(mainMenu());
                }
            }
        }

        public static string Guess()
        {
            return "Okay, Who do you think is the murderer?\n";
        }

        //setting a custom mainMenu method to easily return the player to the main selection section
        public static string mainMenu()
        {
            return "What would you like to do? Type: " +
            "\n 1 to speak to Bryn " +
            "\n 2 to speak to Gwen " +
            "\n 3 to speak to Smithy " +
            "\n 4 to check the body " +
            "\n 5 to look around the room " +
            "\n 6 to cry. " +
            "\n7 to take a guess";
        }

        public static string Body()
        {
            return ($"The body is of a person around 5ft 10 with curly brown hair, slim build and shares many visual characteristics as Bryn... You check his wallet and find a driving license belonging to a 'Jason West'. There is a prominent thin line around his neck which looks to be the cause of his demise.\n");
        }

        public static string Fight()
        {
            return("What is your weapon of choice?" +
            "\n1. The fishing rod" +
            "\n2. The inflateable leek" +
            "\n3. The knife\n");
        }

        public static string BrynAttack()
        {
            return $"Bryn picks up the fishing rod and gains super powers. He critially hits you and kills you instantly. Now step away from the keyboard before he kills someone else!\n";
        }

        public static string ItemInfo()
        {
            return "Which item would you like more information on? " +
            "\n1. The fishing rod" +
            "\n2. The inflatable leek" +
            "\n3. The knife" +
            "\n4. Return to menu";
        }

        public static string PlayerLose()
        {
            return "OH! Peidiwch a chyffwrdd a'r peiriannau! You've lost the game, now sling yer hook or I'll break your face!";
        }

        public static string PlayerWin()
        {
            return "Aw that's a crackin' guess, fair play. At the end of the day, when all's said and done... Tidy. YOU WIN!";
        }
    }

    //Using abstract class as the Greet method will be manipulated by the Characters using Override
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Height { get; set; }
        public string Build { get; set; }
        //encapsulating the Health attribute as private so the player can't modify this and give them more health
        protected private int Health { get; set; }

        //protecting Person as these should not be writeable by the player
        protected Person(string name, int age, string height, string build, int health)
        {
            Name = name;
            Age = age;
            Height = height;
            Build = build;
            Health = health;
        }

        public int modifyHealth(int modifier)
        {
            Health += modifier;
            return Health;
        }

        public abstract string Greet();
    }

    public abstract class Items
    {

        public string Size { get; set; }
        public int Weight { get; set; }
        public string Description { get; set; }
        protected private int Damage { get; set; }

        protected Items(string size, int weight, string description, int damage)
        {
            Size = size;
            Weight = weight;
            Description = description;
            Damage = damage;
        }

        public abstract bool containsBlood();
    }

    public class Player : Person
    {
        public Player(string Name, int Age, string Height, string Build, int Health) : base(Name, Age, Height, Build, Health)
        {
            this.Name = "";
            this.Age = 0;
            this.Height = "Unknown";
            this.Build = "Unknown";
            this.Health = 100;
        }

        public override string Greet()
        {
            return "";
        }

        public int GetHealth()
        {
            return Health;
        }
    }

    public class Bryn : Person
    {
        public object playerName;

        public Bryn(string Name, int Age, string Height, string Build, int Health) : base(Name, Age, Height, Build, Health)
        {
            this.Name = "Bryn";
            this.Age = 46;
            this.Height = "6ft 1";
            this.Build = "Slim";
            this.Health = 100;
        }

        public override string Greet()
        {

            return $"Hello, {playerName}! The name's Bryn. It means 'hill' in Welsh.\n";
        }

        public int GetHealth()
        {
            return Health;
        }
    }


    public class Gwen : Person
    {
        private object playerName;

        public Gwen(string Name, int Age, string Height, string Build, int Health) : base(Name, Age, Height, Build, Health)
        {
            this.Name = "Gwen";
            this.Age = 48;
            this.Height = "5ft 6";
            this.Build = "Slim";
            this.Health = 100;
        }

        public override string Greet()
        {
            return $"Hello, {playerName}? Can I make you an omelette?\n";
        }

    }
    public class Smithy : Person
    {
        private object playerName;

        public Smithy(string Name, int Age, string Height, string Build, int Health) : base(Name, Age, Height, Build, Health)
        {
            this.Name = "Smithy";
            this.Age = 28;
            this.Height = "5ft 8";
            this.Build = "Stocky";
            this.Health = 100;
        }

        //returns type not value. why?
        public override string Greet()
        {
            return $"*does robot dance* {playerName}aaaaar! This is a nightmare of epic proportions is it not, my friend?!\n";
        }
    }

    public class FishingRod : Items
    {
        public FishingRod(string Size, int Weight, string Description, int Damage) : base(Size, Weight, Description, Damage)
        {
            this.Size = "Large";
            this.Weight = 3;
            this.Description = "A standard fishing rod. You notice the fishing line is missing and blood splatters on the handle. There is also a ripped coat/jacket hanging on the floor next to it which looks like it would fit a taller person\n";
            this.Damage = 100;
        }

        public override bool containsBlood()
        {
            return true;
        }
    }

    public class InflatableLeek : Items
    {
        public InflatableLeek(string Size, int Weight, string Description, int Damage) : base(Size, Weight, Description, Damage)
        {
            this.Size = "Small";
            this.Weight = 1;
            this.Description = "It's an inflateable leek... The kind of thing you see Welsh people holding during the Rugby for some inexplicable reason.\n";
            this.Damage = 10;
        }

        public override bool containsBlood()
        {
            return false;
        }
    }

    public class Knife : Items
    {
        public Knife(string Size, int Weight, string Description, int Damage) : base(Size, Weight, Description, Damage)
        {
            this.Size = "Small";
            this.Weight = 1;
            this.Description = "An unused butter knife found on the table. Great for buttering your toast!\n";
            this.Damage = 1;
        }

        public override bool containsBlood()
        {
            return false;
        }
    }
}