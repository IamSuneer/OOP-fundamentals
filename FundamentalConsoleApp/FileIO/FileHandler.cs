using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalConsoleApp.FileIO;

internal class FileHandler
{
    public List<Person> ReadFile()
    {
        string filePath = "/Files/Employees.txt";  //Absoulte full path: C:\Users\suneer_teksewa\OneDrive\Desktop\Dotnet Training\Github Training\OOP-fundamentals\FundamentalConsoleApp\FileIO\Files\Employees.txt
        string fileFullPath = @"C:\Users\suneer_teksewa\OneDrive\Desktop\Dotnet Training\Github Training\OOP-fundamentals\FundamentalConsoleApp\FileIO\Files\Employees.csv"; // @ is verbating character, represents string as it is.

        var fileContent = File.ReadAllText(fileFullPath);
        //Console.WriteLine(fileContent);

        //display only name and dob of all people in employee.csv


        var lines = fileContent.Split(["\n","\r"], StringSplitOptions.RemoveEmptyEntries);

        List<Person> persons = new();
        foreach (var item in lines.Skip(1)/*.Take(10)*/)
        {
            var personData = item.Split(",", StringSplitOptions.RemoveEmptyEntries);
            DateTime.TryParse(personData[1], out DateTime date);
            persons.Add(new(personData[0], date, long.Parse(personData[2])));
        }
        foreach (var item in persons) {
            Console.WriteLine($"{item.name}\t{item.dob.ToShortDateString()}");
        }
        return persons;
    }

    public void WriteFile()
    {
        string fileFullPath = @"C:\Users\suneer_teksewa\OneDrive\Desktop\Dotnet Training\Github Training\OOP-fundamentals\FundamentalConsoleApp\FileIO\Files\People.csv";
        string fileContents = "This files was created by FileHandler.";
        File.WriteAllText(fileFullPath, fileContents);
    }

    public void WriteEmployeesToFile(List<Person> people)
    {
        string fileFullPath = @"C:\Users\suneer_teksewa\OneDrive\Desktop\Dotnet Training\Github Training\OOP-fundamentals\FundamentalConsoleApp\FileIO\Files\People.txt";
        //foreach (var person in people)
        //{
        //    person.PrintDetails(person);
        //}
        var peopleText = people.Select(Person.PrintDetails);
        //Console.WriteLine(peopleText);
        File.WriteAllLines(fileFullPath, peopleText);
    }
}
