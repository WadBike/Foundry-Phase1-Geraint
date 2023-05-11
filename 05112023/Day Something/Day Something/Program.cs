namespace daySomething
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Joe", 1234);
            acc1.Login();
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

        public void Login()
        {
            while (true)
            {
                if (ValidateUserName() && ValidatePasscode())
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
                else
                {
                    Console.WriteLine("Username or password incorrect. Try again.")
                }
            }
        }

        private bool ValidateUserName()
        {
            Console.WriteLine("Enter your username:");
            string usernameAttempt = Console.ReadLine();
            if (usernameAttempt == Username)
            {
                return true;
            }
            return false;
        }

        private bool ValidatePasscode()
        {
            try
            {
                Console.WriteLine("Enter your password:");
                int passcodeAttempt = Convert.ToInt32(Console.ReadLine());
                if (passcodeAttempt == Passcode)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid format");
            }
            return false;
        }
    }
}
