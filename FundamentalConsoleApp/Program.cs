// // // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");

#region Day2
// // //Datatypes
// // //Numbers: Integers and Floating point

// // byte age = 34;
// // short numberOfPeopleInCompany = 23424; //camelCasing, PascalCasing
// // int areaOfCountry = 324123344; //32 bit
// // long distanceBetweenPlanets = 975431234567890; //64

// // //Accuracy (Precision)
// // float averageWeight = 67.5512456F;
// // double averageDistance = 72634.2132174;
// // decimal averageDistanceBetweenElectrons = 72634.2131234562174M;

// // //Text
// // string name = "Suneer ";
// // char gender = 'M';

// // //Flags
// // bool isQA = true;

// // //Dates
// // DateTime dob = new(1996, 12, 07);

// // //Nullables


// // // Console.WriteLine(averageWeight);
// // // Console.WriteLine("Enter some text:");
// // // string data = Console.ReadLine();

// // // Console.WriteLine("Characters count "+ data.Length);
// // // Console.WriteLine($"Characters count {data.Length}"); //string interpolation.


// // // get username and convert into uppercase.
// // Console.WriteLine("Enter user name:");
// // string userName = Console.ReadLine();
// // Console.WriteLine($"Your uppercase username is: {userName.ToUpper()}");
#endregion

#region Day3
// Person suneer = new("Suneer Ranjitkar", new DateTime(1996, 12, 07), 700100360);
// suneer.PrintDetails();

// Person suneerOne = new();
// suneerOne.name = "Suneer Ranjitkar";
// suneerOne.dob = new DateTime(1996, 12, 07);
// suneerOne.nid = 700100360;
// suneerOne.PrintDetails();

// Person binaya = new();
// binaya.PrintDetailsWithData("Binaya", 123, DateTime.Now);

Console.Write("Enter Title of Page: ");
string title = Console.ReadLine();
if (String.IsNullOrWhiteSpace(title) || String.IsNullOrEmpty(title))
{
    Console.WriteLine("Enter Valid Title. The Title must have at least 1 character.");
}
else
{
    Console.Write("Enter Height of Page in inch: ");
    try
    {
        int height = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Width of Page in inch: ");
        try
        {
            int width = Convert.ToInt32(Console.ReadLine());


            Page desktopPage = new(height, width, title);
            desktopPage.PrintDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

#endregion