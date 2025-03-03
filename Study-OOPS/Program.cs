using System;
using System.Collections.Generic;


public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Age: {Age}";
    }
}

public class StudentManager
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public void RemoveStudent(int id)
    {
        students.RemoveAll(s => s.Id == id);
    }

    public void DisplayStudents()
    {
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}

class Program
{
    static void Main()
    {
        StudentManager manager = new StudentManager();
        List<Student> studentList = new List<Student>();

        while (true)
        {
            Console.WriteLine("\n1. Add Student");
            Console.WriteLine("2. Remove Student");
            Console.WriteLine("3. Display Students");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Student ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Student Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Student Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Student newStudent = new Student(id, name, age);
                    manager.AddStudent(newStudent);
                    studentList.Add(newStudent);
                    Console.WriteLine("Student Added Successfully!");
                    break;

                case 2:
                    Console.Write("Enter Student ID to Remove: ");
                    int removeId = Convert.ToInt32(Console.ReadLine());
                    manager.RemoveStudent(removeId);
                    studentList.RemoveAll(s => s.Id == removeId);
                    Console.WriteLine("Student Removed Successfully!");
                    break;

                case 3:
                    Console.WriteLine("\nStudent Records:");
                    manager.DisplayStudents();
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid Choice! Try again.");
                    break;
            }
        }
    }
}
