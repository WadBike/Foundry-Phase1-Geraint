namespace secondMay2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character(100, 10, 20);
            Player player1 = new Player(100, 10, 20);
            Enemy enemy1 = new Enemy(100, 10, 20);

            Console.WriteLine("1. Normal Attack. 2. Power Attack");
            int attack = Convert.ToInt32(Console.ReadLine());

            if (attack == 1)
            {
                Console.WriteLine($"Player does normal attack and hits, inflicting 10 damage to the enemy. The enemy now has {Enemy.getHealth(-10)}");
            }

            if (attack == 2)
            {
                Console.WriteLine($"Player does normal attack and hits, inflicting 20 damage to the enemy. The enemy now has {Enemy.getHealth(-20)}");
            }
        }

        class Character
        {
            protected int health = 100;
            protected int normAtk = 10;
            protected int pwrAtk = 20;
            protected int Random rnd = new Random();

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

            public int getHealth(int v)
            {
                return health;
            }

            public int getNormAtk()
            {
                return normAtk;
            }

            public int getPwrAtk()
            {
                return pwrAtk;
            }
        }

        class Player : Character
        {
            public Player(int health, int normAtk, int pwrAtk) : base(health, normAtk, pwrAtk)
            {

            }

            public void Attack()
            {
                Console.WriteLine("1. Normal Attack. 2. Power Attack");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1 && rand.Next(1, 101) > 30)
                {
                    Enemy.modifyHealth(-20);
                    Console.WriteLine($"Normal attack hits. Enemy now has {Enemy.getHealth()}");
                }
                else if (input == 2 && rand.Next(1, 101) > 70)
                {
                    Enemy.modifyHealth(-50);
                    Console.WriteLine($"Power attack hits. Enemy now has {Enemy.getHealth()}");
                }
                else
                {
                    Console.WriteLine($"Attack missed. Enemy still has {Enemy.getHealth()}");
                }
            }
        }

        class Enemy : Character
        {
            private int level = 1;
            public Enemy(int health, int normAtk, int pwrAtk) : base(health, normAtk, pwrAtk)
            {

            }

            public int levelUp()
            {
                return level++;
            }
        }
    }
}