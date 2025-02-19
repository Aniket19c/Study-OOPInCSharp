using System;

interface IWorker
{
    void Work();
}

interface IStudent
{
    void Study();
}

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

class WorkingStudent : Person, IWorker, IStudent
{
    public WorkingStudent(string name, int age) : base(name, age) { }
    public void Work()
    {
        Console.WriteLine($"{Name} is working.");
    }
    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }
}

class Program
{
    static void Main()
    {
        WorkingStudent student = new WorkingStudent("Alice", 25);
        student.Introduce();
        student.Work();
        student.Study();
    }
}
