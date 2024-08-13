using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalConsoleApp.Generics;

internal class PlayingWithCollections
{
    //Arrays, Lists, Dictionaries
    //can make static becasue it doesnot implement other member/references of class like properties unless it is an static member.
    // doesnot let it make inside static member.
    public static void LearnArray()
    {
        string[] empNames = new string[10];
        empNames[0] = "Suneer";
        empNames[1] = "Binaya";
        empNames[2] = "Teksewa";

        //alternatives
        string[] names = ["Suneer", "Binaya", "Teksewa"];

        byte[] evenNumbers = {2,4,6,8,10};

        int[][] mat1 = [[2, 3, 4], [3, 4]]; //jagged arrays
        int[,] mat2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        //create array on numbers from one to hundred
        //from that collection, print

        int[] numbers = [100];
        int[] allNumbers = Enumerable.Range(1, 100).ToArray();

        foreach (int number in allNumbers)
        {
            if (number % 3 == 0 || number % 5 == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
    public void LearnList()
    {
        List<string> empNames = ["Suneer", "Binaya", "Teksewa"];
        empNames.Add("Samir");

        List<(string Country, string Capitals)> countries = new();
        countries.Add(("Nepal", "Kathmandu"));
        countries.Add(("India", "Delhi"));
        countries.Add(("China", "Bejing"));


        List<Person> people = new();

        people.Add(new Person
        {
            name = "Suneer",
            dob = DateTime.Now,
            nid = 1
        });
    }
    public void LearnDistionary()
    {
        //set of colletions with key value pair.
        //key must be unique.
        Dictionary<string, string> countries = new();
        countries.Add("Nepal", "Kathmandu");
        countries.Add("India", "Delhi");
        countries.Add("China", "Bejing");
    }
}
