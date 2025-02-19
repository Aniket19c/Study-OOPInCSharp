using System;

interface IAnimal
{
    void MakeSound();
}

class Dog : IAnimal
{
    public string Name { get; set; }
    public Dog(string name)
    {
        Name = name;
    }
    public void MakeSound()
    {
        Console.WriteLine($"{Name} barks");
    }
}

class Cat : IAnimal
{
    public string Name { get; set; }
    public Cat(string name)
    {
        Name = name;
    }
    public void MakeSound()
    {
        Console.WriteLine($"{Name} meows");
    }
}

class Program
{
    static void Main()
    {
        IAnimal myDog = new Dog("Buddy");
        IAnimal myCat = new Cat("Whiskers");
        myDog.MakeSound();
        myCat.MakeSound();
    }
}
