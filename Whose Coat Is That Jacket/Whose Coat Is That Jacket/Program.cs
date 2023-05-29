namespace WhoseCoatIsThatJacket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bryn bryn = new Bryn("Bryn", 46, "6ft 1'", "Slim");
            Gwen gwen = new Gwen("Gwen", 48, "5ft 6'", "Slim");
            Smithy smithy = new Smithy("Smithy", 28, "5ft 8'", "Stocky");
            FishingRod fr1 = new FishingRod("Large", 3, "A standard fishing rod. You notice the fishing line is missing and blood splatters on the handle. There is also coat/jacket hanging on the floor next to it which would fit a taller person");
            InflatableLeeke leeke = new InflatableLeeke("Small", 1, "It's an inflateable Leeke... The kind of thing you see Welsh people holding during the Rugby for some inexplicable reason.");
            Knife knife = new Knife("Small", 1, "An unused butter knife found on the table. Great for buttering your toast!");

            Console.WriteLine(bryn.Greet);

            Console.WriteLine("Siwmae! What is your name? \n");
            string playerName = Console.ReadLine();
            Console.WriteLine($"\nI'm gonna be honest with you here, {playerName}. This isn't a game with beautiful graphics, alright? You're going to need your imagination. You're about to be transported to a room in Cardiff with 3 weird people and a dead body. You need to find out what happened before the Rozzers get there or they'll arrest you (and ignore the others, how weeeeird...). Good luck! WEEEEEE");

            //Adding a 2 second pause to seperate intro to game
            string pause = " ";

            for (int count = 0; count < 10; count++)
            {
                Console.WriteLine(string.Format(" ", count, pause));

                //wait for 2 seconds
                Thread.Sleep(200);
            }

            Console.WriteLine("\nYou are now in the room. What would you like to do? Type: " +
                "\n 1 to speak to Character1 " +
                "\n 2 to speak to Character2 " +
                "\n 3 to speak to Character3 " +
                "\n 4 to check the body " +
                "\n 5 to look around the room " +
                "\n 6 to cry. " +
                "\n");

            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    int playerInput = Convert.ToInt32(Console.ReadLine());
                    if (playerInput == 1)
                    {
                        Console.WriteLine(bryn.Greet());
                    }
                    else

                    if (playerInput == 2)
                    {
                        Console.WriteLine(gwen.Greet());
                        string playerOmelette = (Console.ReadLine());
                        if (playerOmelette == "yes")
                        {
                            Console.WriteLine("Aw, lovely. Here you go!");
                        }
                        else if (playerOmelette == "no")
                        {
                            Console.WriteLine("Suit yourself, you ungrateful little toerag!");
                        }
                    }

                    else if (playerInput == 3)
                    {
                        Console.WriteLine(smithy.Greet);
                    }

                    else if (playerInput == 4)
                    {
                        Console.WriteLine("The body is of a person around 5ft 10 with curly brown hair, slim build and shares many visual characteristics as Bryn... You check his wallet and find a driving license belonging to a 'Jason West'. There is a prominent thin line around his neck which looks to be the cause of his demise.");
                    }

                    else if (playerInput == 5)
                    {
                        Console.WriteLine("When looking around the room you find various items - a fishing rod, an inflatable leeke and a knife. Do you want to investigate further?");
                        string investigate = Console.ReadLine();
                        if (investigate == "yes")
                        {
                            Console.WriteLine("Which item would you like more information on? " +
                                "\n1. The fishing rod" +
                                "\n2. The inflatable leeke" +
                                "\n3. The knife");
                            int itemChoice = Convert.ToInt32(Console.ReadLine());

                            if(itemChoice == 1)
                            {
                                Console.WriteLine($"{fr1.Description} It is a {fr1.Size} item and has a weight of {fr1.Weight}.");
                            }
                            else

                            if (itemChoice == 2)
                            {
                                Console.WriteLine($"{leeke.Description}. It is a {leeke.Size} item and has a weight of {leeke.Weight}.");
                            }
                            else

                            if (itemChoice == 3)
                            {
                                Console.WriteLine($"{leeke.Description}. It is a {leeke.Size} item and has a weight of {leeke.Weight}.");
                            }
                            
                        }
                    }

                    else if (playerInput == 6)
                    {

                    }

                    break;    
                }
                catch
                {
                    Console.WriteLine("Not a number, ya twpsyn. Try again...");
                }
            }
        }


        //Using abstract class as the Greet method will be manipulated by the Characters using Override
        abstract class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Height { get; set; }
            public string Build { get; set; }

            //protecting Person as these should not be writeable by the player
            protected Person(string name, int age, string height, string build)
            {
                Name = name;
                Age = age;
                Height = height;
                Build = build;
            }
            //using void type as method will not return a value


            public abstract string Greet();

        }

        abstract class Items
        {

            public string Size { get; set; }
            public int Weight { get; set; }
            public string Description { get; set; }

            protected Items(string size, int weight, string description)
            {
                Size = size;
                Weight = weight;
                Description = description;
            }

        }

        class Bryn : Person
        {
            public object playerName;


            public Bryn(string Name, int Age, string Height, string Build) : base(Name, Age, Height, Build)
            {

            }
            
            public override string Greet()
            {
                
                return $"Hello, {playerName}! The name's Bryn. It means 'hill' in Welsh. What can I do you for?"; 
            }
        }

        class Gwen : Person
        {
            private object playerName;

            public Gwen(string Name, int Age, string Height, string Build) : base(Name, Age, Height, Build)
            {

            }

            public override string Greet()
            {
                return $"Hello, {playerName}? Can I make you an omelette?";
            }
        }

        class Smithy : Person
        {
            private object playerName;

            public Smithy(string Name, int Age, string Height, string Build) : base(Name, Age, Height, Build)
            {

            }

            //returns type not value. why?
            public override string Greet()
            {
                return $"*does robot dance* {playerName}aaaaar! This is a nightmare of epic proportions is it not, my friend?! How can I do ya?";
            }
        }

        class FishingRod : Items
        {
            public FishingRod(string Size, int Weight, string Description) : base(Size, Weight, Description)
            {
                Size = "Large";
                Weight = 3;
                Description = "A standard fishing rod. You notice the fishing line is missing and blood splatters on the handle. There is also coat/jacket hanging on the floor next to it which would fit a taller person";
            }
        }

        class InflatableLeeke : Items
        {
            public InflatableLeeke(string Size, int Weight, string Description) : base(Size, Weight, Description)
            {
                Size = "Small";
                Weight = 1;
                Description = "It's an inflateable Leeke... The kind of thing you see Welsh people holding during the Rugby for some inexplicable reason.";
            }
        }

        class Knife : Items
        {
            public Knife(string Size, int Weight, string Description) : base(Size, Weight, Description)
            {
                Size = "Small";
                Weight = 1;
                Description = "A small ";
            }
        }
    }
}