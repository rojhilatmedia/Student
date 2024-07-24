using System;
using System.Security.Cryptography;
using System.Text.Json;
namespace MyNamespace;


class Program
{

    static void Main(string[] args)
    {

        StudentManager manager = new StudentManager();
        manager.Add(new Student
        {
            Id = 1,
            Name = "John Doe",
            Age = 20
        });

        StudentManager manager2 = new StudentManager();
        manager2.Add(new Student
        {
            Id = 2,
            Name = "Jane Smith",
            Age = 22,
            
        });
        


    }

    interface IStudent
    {
        int Id 
        {
            get;
            set;
        }

        string Name
        {
            get; set;
        }


    }

    class Student:IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class InternationalStudent:Student
    {
        public string country;
    }

    class Class:IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Course
    {
        public string Courses { get; set; }
    }

    class Grade
    {
        public int Grades { get; set; }
    }

    class StudentManager
    {
        public void Add(Student student)
        {
            Console.WriteLine(student.Name);
        }
        
        
    }
    
    


   
}