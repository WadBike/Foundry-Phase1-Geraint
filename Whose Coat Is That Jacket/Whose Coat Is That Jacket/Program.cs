namespace WhoseCoatIsThatJacket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siwmae! What is your name?");
            string playerName = Console.ReadLine();
            Console.WriteLine($"I'm gonna be honest with you here, {playerName}. This isn't a game with beautiful graphics, alright? You're going to need your imagination. You're about to be transported to a room in Cardiff with 3 weird people and a dead body. You need to find out what happened before the Rozzers get there or they'll arrest you (and ignore the others, how weeeeird...). Good luck! WEEEEEE");

            //Adding a 2 second pause to seperate intro to game
            string pause = " ";

            for (int count = 0; count < 10; count++)
            {
                Console.WriteLine(string.Format(" ", count, pause));

                //wait for 2 seconds
                Thread.Sleep(200);
            }

            Console.WriteLine("You are now in the room. What would you like to do? Type: \n 1 to talk to Character1 \n 2 to talk to Character2 \n 3 to speak to Character3 \n 4 to check the body \n 5 to look around the room \n 6 to cry.");
            int playerInput = Convert.ToInt32(Console.ReadLine());
            
            if (playerInput != 
            {

            }

        }


        enum ItemSize
        {
            Small,
            Medium,
            Large
        }

        public static void Joke(string[] jokes)
        {
            string[] Jokes = { "How do you approach an angry Welsh cheese? Caerphilly.", "I once dated someone with 36DDs. It was a ridiculously long name.", "Transport for Wales", "Joke 4", "Joke 5", };

            Random rnd = new Random();

            int rndjoke = rnd.Next(0);

            Console.WriteLine(rndjoke);
        }


        //Using abstract class as the Greet method will be manipulated by the Characters using Override
        abstract class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Height { get; set; }
            public string Build { get; set; }
            public static string Joke { get; internal set; }

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
            public ItemSize ItemSize { get; }

            protected Items(string size, int weight, string description, ItemSize itemSize)
            {
                Size = size;
                Weight = weight;
                Description = description;
                ItemSize = itemSize;
            }

        }

        class Character1 : Person, ICanPlay
        {
            private object playerName;

            public Character1(string Name, int Age, string Height, string Build) : base(Name, Age, Height, Build)
            {

            }

            public override string Greet()
            {
                return $"Alright {playerName} how's it going alright?";
            }

            public string play()
            {
                return play();
            }
        }

        class Character2 : Person
        {

            public Character2(string Name, int Age, string Height, string Build) : base(Name, Age, Height, Build)
            {

            }

            public override string Greet()
            {
                return "$";
            }

            public string play()
            {
                return play();
            }

        }

        interface ICanPlay
        {
            string play();
        }

        class Jacket : Items
        {
            public Jacket(string Size, int Weight, string Description) : base(Size, Weight, Description, ItemSize.Medium)
            {
                Size = "Medium";
                Weight = 3;
                Description = "A large jacket, looks to belong to a large person. It has a rip near the chest pocket with what appears to be blood splatters across it.";
            }
        }

        class InflatableLeeke : Items
        {
            public InflatableLeeke(string Size, int Weight, string Description) : base(Size, Weight, Description, ItemSize.Small)
            {
                Size = "Small";
                Weight = 1;
                Description = "It's an inflateable Leeke... The kind of thing you see Welsh people holding during the Rugby for some inexplicable reason.";
            }
        }

        class Knife : Items
        {
            public Knife(string Size, int Weight, string Description) : base(Size, Weight, Description, ItemSize.Small)
            {
                Size = "Small";
                Weight = 1;
                Description = "A small ";
            }
        }
    }
}