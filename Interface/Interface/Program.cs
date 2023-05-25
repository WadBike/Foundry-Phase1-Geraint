internal class Program
{
    static void Main(string[] args)
    {
        Dog d1 = new Dog("Rover");
        Cat c1 = new Cat("Garfield");
        Crocodile c2 = new Crocodile("Stevie");
        Console.WriteLine(d1.animalSound());
        Console.WriteLine(c1.animalSound());
        Console.WriteLine(d1.sleep());
        Console.WriteLine(c2.swim());
    }
}

//0...N implementation
abstract class Animal
{

    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }

    public string sleep()
    {
        return "ZZZZzzzz";
    }

    public abstract string animalSound();
}

class Dog : Animal
{

    public Dog(string name) : base(name)
    {

    }

    public override string animalSound()
    {
        return "BARK";
    }

}

class Cat : Animal
{

    public Cat(string name) : base(name)
    {

    }

    public override string animalSound()
    {
        return "MEOW";
    }

}

interface Iflyingcreature
{
    string fly();
}

interface Icanswim
{
    string swim();
}

class Bird : Animal, Iflyingcreature
{

    public Bird(string name) : base(name)
    {

    }

    public override string animalSound()
    {
        return "SQUARRRRRRK";
    }

    public string fly()
    {
        return "WEEEEEEEEEEEEEEEEEE";
    }

}

class Crocodile : Animal, Icanswim
{
    public Crocodile(string name) : base(name)
    {

    }

    public override string animalSound()
    {
        return("SNAPSNAP");
    }

    public string swim()
    {
        return "SPLISH SPLASH";
    }
}
