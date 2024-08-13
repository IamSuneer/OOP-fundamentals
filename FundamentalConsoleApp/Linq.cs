using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalConsoleApp;

internal class Linq //Language Integrated Query
{
    static double[] marks = [34.5, 67.1, 80.5, 65, 70.3, 54.6, 89.8];

    static List<Student> students = [
        new ("Suneer Ranjitkar", new DateTime (1996, 12, 07), "Texas", "BIT"),
        new ("Binaya R Devkota", new DateTime (1999, 11, 12), "TU", "CSIT"),
        new ("Karina Rajthala", new DateTime (1998, 07, 13), "Prime","BSW"),
        new ("Sanju Shrestha", new DateTime (1998, 12, 25), "Khwopa","BEE"),
        new ("Bishnu Rawal", new DateTime (1990, 4, 22), "PK","BIM"),
        new ("Milan Giri", new DateTime (1999, 5, 2), "Nepal","IT")
        ];

    // Get all marks which surpass passmark 40
    //imperative and declarative.

    public static void PassMark()
    {
        //Imperative
        List<double> passMarks = new();
        foreach (var mark in marks)
        {
            if (mark > 40)
                passMarks.Add(mark);
                Console.WriteLine(mark);
        }

        //Declarative
        var marks1 = marks.Where(x => x > 40); // returns IEnumerable
        List<double> marks2 = marks.Where(x => x > 40).ToList(); //Filter

        var marksToString = marks.Select(x => x.ToString("F2")); //Projection
        foreach (var mark in marksToString)
        {
            Console.WriteLine(mark);
        }
        //casting is only possible to similar datatype.
        //tryparse and convert is required for changing from one datatype to another.


        //get all passmarks and convert to nearest integer
        //method syntax
        var passMarkToInt = marks.Where(x => x > 40).Select(x => Math.Round(x, MidpointRounding.AwayFromZero));
        //expression syntax
        var PassMarkToIntExp = from mark in marks
                               where mark > 40
                               select Math.Round(mark);

        foreach (var mark in passMarkToInt)
        {
            Console.WriteLine(mark);
        }
        
        foreach (var mark in PassMarkToIntExp)
        {
            Console.WriteLine(mark);
        }

        //get all employees who are older than 25 years
        //get employee name with their ages and order by age
        var peoples25 = students.Where(x => DateTime.Now.Year - x.dob.Year > 25);
        foreach (var person in peoples25)
        {
            Console.WriteLine($"Name: {person.name}\nDate of Birth: {person.dob.ToShortDateString()}");
        }

        var studentData = students.Select(x => new { Name = x.name, Age = x.CalculateAge() }).OrderBy(x => x.Age.Item2);
        foreach (var student in studentData)
        {
            Console.WriteLine($"{student.Name}\t{student.Age.Item1}");
        }
        
    }
}
