namespace enemyplayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(100);
            Enemy enemy = new Enemy(100);
            player.Attack(enemy);
        }
    }

    class Entity
    {
        protected int health;
        protected Random rand = new Random();

        public Entity(int health)
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

    class Player : Entity
    {
        public Player(int health) : base(health)
        {

        }

        public void Attack(Enemy enemy)
        {
            Console.WriteLine("1. Normal Attack  2. Power Attack");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1 && rand.Next(1, 101) > 30)
            {
                enemy.modifyHealth(-20);
                Console.WriteLine($"Normal attack hits, enemy now has {enemy.getHealth()} health");
            }
            else if (input == 2 && rand.Next(1, 101) > 70)
            {
                enemy.modifyHealth(-50);
                Console.WriteLine($"Power attack hits, enemy now has {enemy.getHealth()} health");
            }
            else
            {
                Console.WriteLine($"Attack missed, enemy still has {enemy.getHealth()} health");
            }

        }
    }

    class Enemy : Entity
    {

        private int level = 1;
        public Enemy(int health) : base(health)
        {

        }

        public int levelUp()
        {
            level++;
            return level;
        }

        public int getLevel()
        {
            return level;
        }
    }
}