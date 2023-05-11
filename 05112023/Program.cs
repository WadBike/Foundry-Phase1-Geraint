namespace daySomething
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Joe", 1234);
            Console.WriteLine("Enter passcode:");

            while (true)
            {
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Incorrect passcode. Try again:");
                }
            }

            Console.WriteLine("Welcome!");
        }
    }
    class Account
    {
        public string Username { get; private set; }
        public int Passcode { get; set; }


        public Account(string Username, int Passcode)
        {
            this.Username = Username;
            this.Passcode = Passcode;
        }
    }
}
