namespace BankingApp
{
    internal class Programe
    {
        static void Main(string[] args)
        {
            string art = Figgle.FiggleFonts.Crazy.Render("Boyd's Lank");
            Console.WriteLine(art);

            if (args.Length > 0)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"Username:{args[0]}");
                Console.WriteLine($"Password:{args[1]}");
            }

            Console.ReadLine();
        }
    }
}