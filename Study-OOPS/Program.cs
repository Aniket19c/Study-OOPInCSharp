using System;

class Person
{
    private string name;
    private int age;
    public string Name
    {
        get { return name; }
        set { if (!string.IsNullOrWhiteSpace(value)) name = value; }
    }
    public int Age
    {
        get { return age; }
        set { if (value > 0) age = value; }
    }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Introduce()
    {
        Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("Alice", 25);
        person.Introduce();
        person.Name = "Bob";
        person.Age = 30;
        person.Introduce();
    }
}
