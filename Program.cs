using Internal;

namespace secondMay2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character(100);
            Player player1 = new Player(100);
            Enemy enemy1 = new Enemy(100);

            Console.WriteLine(enemy1.levelUp());
        }

        class Character
        {
            private int health;

            public Character(int health)
            {
                this.health = health;
            }

            public int modifyHealth(int modifier)
            {
                health += modifier;
                return health;
            }

            public int getHealth()
            {
                return health;
            }
        }

        class Player : Character
        {
            public Player(int health) : base(health)
            {

            }

        }

        class Enemy : Character
        {
            private int level = 1;
            public Enemy(int health) : base(health)
            {

            }

            public int levelUp()
            {
                return level++;
            }
        }
    }
}

