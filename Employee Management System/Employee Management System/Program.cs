namespace employeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MiddleManager.boss);
        }

        enum RNDAccess
        {
            None,
            Restrcited,
            Full
        }

        abstract class People
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int EmpNum { get; private set; }
            public RNDAccess RNDAccess { get; }
            public abstract RNDAccess AccessLevel { get; }

            public People(string name, int age, int empNum, RNDAccess rNDAccess)
            {
                Name = name;
                Age = age;
                EmpNum = empNum;
                RNDAccess = rNDAccess;
            }

            protected People(string name, int age, int empNum)
            {
                Name = name;
                Age = age;
                EmpNum = empNum;
            }
        }
        
        interface ICanBoss
        {
            public void boss();
        }

        interface ICanHire
        {
            public void hire();
        }

        interface ICheckFinances
        {
            public void finances();
        }

        class Employee : People
        {
            public override RNDAccess AccessLevel { get; } = RNDAccess.Restrcited;
            public Employee(string name, int age, int empNum) : base(name, age, empNum)
            {
            
            }
        }

        class MiddleManager : People, ICanBoss, ICanHire
        {
            public override RNDAccess AccessLevel { get; } = RNDAccess.Restrcited;

            public MiddleManager(string name, int age, int empNum) : base(name, age, empNum)
            {

            }

            public void boss()
            {
                Console.WriteLine("Do this and do it now!");
            }

            public void hire()
            {
                Console.WriteLine("You'll do. You're hired!");
            }
        }

        class CEO : People, ICanHire, ICanBoss, ICheckFinances
        {
            public override RNDAccess AccessLevel { get; } = RNDAccess.Full;

            public CEO(string name, int age, int empNum) : base(name, age, empNum, RNDAccess.Full)
            {

            }

            public void boss()
            {
                Console.WriteLine("Do this and do it now!");
            }

            public void hire()
            {
                Console.WriteLine("You'll do. You're hired!");
            }

            public void finances()
            {
                Console.WriteLine("Yeeeeah we have no money we need to fire people");
            }
        }
    }
}