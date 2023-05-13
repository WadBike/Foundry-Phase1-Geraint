namespace _13_05_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Book b1 = new Book("Lord of the Rings", 1178, Material.Hardback);
            Book b2 = new Book("The Hobbit", 2000, Material.Paperback);
            */
            VideoGame v1 = new VideoGame("PewPew", 30, Genre.Shooter);
            VideoGame v2 = new VideoGame("Wanderer", 40, Genre.RPG);
            VideoGame v3 = new VideoGame("Zoomies", 25, Genre.SimRacer);
            Console.WriteLine(v2.Genre);

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

    enum Genre
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
        }
    }
}