namespace _13_05_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog("Rover");
            Cat c1 = new Cat("Garfield");
            /*Book b1 = new Book("Lord of the Rings", 1178, Material.Hardback);
            Book b2 = new Book("The Hobbit", 2000, Material.Paperback);
            
            VideoGame v1 = new VideoGame("PewPew", 30, Genre.Shooter);
            VideoGame v2 = new VideoGame("Wanderer", 40, Genre.RPG);
            VideoGame v3 = new VideoGame("Zoomies", 25, Genre.SimRacer);
            Console.WriteLine(v2.Genre);*/
            Console.WriteLine(c1.Affection);

        }
    }
    //fixed set of constants to define certain attributes.
    /*enum Material
    {
        Paperback,
        Hardback,
        Digital
    }

    class Book
    {
        public string Name { get; set; }
        public int NumPages { get; set; }

        public Material Material { get; set; }

        public Book(string name, int pages, Material material)
        {
            Name = name;
            NumPages = NumPages;
            Material = material;
        }*/

    /*enum Genre
    {
        Shooter,
        RPG,
        SimRacer
    }

    class VideoGame
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Genre Genre { get; set; }

        public VideoGame(string name, int price, Genre genre)
        {
            Name = name;
            Price = price;
            Genre = genre;
        }*/

    abstract class Animal
    {
        public string Name { get; set; }
        public abstract int Speed { get; set; }
        public abstract string Affection { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        
        public abstract void AnimalSound();

        public void sleep()
        {
            Console.WriteLine("ZzzZzZz");
        }

    }

    class Dog : Animal
    {
        public override int Speed { get; set; }

        public override string Affection { get; set; }

        public Dog(string name) : base(name)
        {
            Speed = 10;
            Affection = "Very affectionate";
        }

        public override void AnimalSound()
        {
            Console.WriteLine("WOOF");
        }
    }

    class Cat : Animal
    {
        public override string Affection { get; set; }

        public override int Speed { get; set; }

        public Cat(string name) : base(name)
        {
            Speed = 5;
            Affection = "Hates you and everything you stand for.";
        }

        public override void AnimalSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}