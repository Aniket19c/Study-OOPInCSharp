using System;

class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} barks");
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} meows");
    }
}

class Program
{
    static void Main()
    {
        Animal myDog = new Dog("Buddy");
        Animal myCat = new Cat("Whiskers");
        myDog.MakeSound();
        myCat.MakeSound();
    }
}