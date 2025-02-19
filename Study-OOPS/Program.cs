using System;

abstract class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public abstract void MakeSound();
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} barks");
    }
}

class Program
{
    static void Main()
    {
        Animal dog = new Dog("Buddy");
        dog.MakeSound();
    }
}
