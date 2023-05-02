using Internal;

namespace secondMay2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character(100, 10, 20);
            Player player1 = new Player(100, 10, 20);
            Enemy enemy1 = new Enemy(100, 10, 20);

            Console.WriteLine(enemy1.levelUp());
        }

        class Character
        {
            protected int health = 100;
            protected int normAtk = 10;
            protected int pwrAtk = 20;

            public Character(int health, int normAtk, int pwrAtk)
            {
                this.health = health;
                this.normAtk = normAtk;
                this.pwrAtk = pwrAtk;
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

            public int damage(int damage)
            {
                health - damage;
                return health;
            }
        }

        class Player : Character
        {
            public Player(int health, int normAtk, int pwrAtk) : base(health, normAtk pwrAtk)
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