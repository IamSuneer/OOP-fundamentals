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

// // Person suneer = new("Suneer Ranjitkar", new DateTime(1996, 12, 07), 700100360);
// // suneer.PrintDetails();

// // Person suneerOne = new();
// // suneerOne.name = "Suneer Ranjitkar";
// // suneerOne.dob = new DateTime(1996, 12, 07);
// // suneerOne.nid = 700100360;
// // suneerOne.PrintDetails();

// // Person binaya = new();
// // binaya.PrintDetailsWithData("Binaya", 123, DateTime.Now);

// Console.Write("Enter Title of Page: ");
// string title = Console.ReadLine();
// if (String.IsNullOrWhiteSpace(title) || String.IsNullOrEmpty(title))
// {
//     Console.WriteLine("Enter Valid Title. The Title must have at least 1 character.");
// }
// else
// {
//     Console.Write("Enter Height of Page in inch: ");
//     try
//     {
//         int height = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Enter Width of Page in inch: ");
//         try
//         {
//             int width = Convert.ToInt32(Console.ReadLine());


//             Page desktopPage = new(height, width, title);
//             desktopPage.PrintDetails();
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine(ex.Message);
//     }
// }

#endregion

#region Day4

// Student student1 = new("Suneer 123 I Don't Know Ranjitkar",new DateTime(1996,12,07),"Texas", "BIT");
// var age = student1.CalculateAge();
// (string yearsMonths, int days) = student1.CalculateAge();
// // var initials = student1.NameInitial();
// var shortInitials = student1.GetInitials();
// Student.PrintStudentDetails(shortInitials, age.Item1);
// Student.PrintStudentDetails(student1.GetInitials(), student1.CalculateAge().Item1);
// Student.PrintStudentDetails(student1.GetInitials(), student1.CalculateAge().Item1, student1.CalculateAge().Item2);
// Student.PrintStudentDetails(student1.GetInitials());
// // Console.WriteLine(age);
// // Console.WriteLine(initials);
// // Console.WriteLine(shortInitials);

#endregion

#region Day5

// Vehicle vehicle= new();
// vehicle.VehicleNumber = "BA PA 3455";
// var x = vehicle.VehicleNumber;

// ElectricVehicle ev = new();
// float data  = ev.GetDistanceCovered(60);
// Console.WriteLine(ev.GetDistanceCovered(60));
// Console.WriteLine(data);

#endregion

#region Day6

//// IVehicle car1 = new ElectricVehicle("BA 02 PA 3455");
//// IVehicle car2 = new EngineVehicle("BA 02 PA 3455");
////modify instantiation process
////electric vehicle = number, range, batterycapacity
////engine vehicle = number, mileage, engine cc

//ElectricVehicle car1 = new ElectricVehicle("BA 02 PA 3455", 350, 70.6f);
//Console.WriteLine($"Vehicle number: {car1.VehicleNumber}, Range: {car1.Range}, BatteryCapacity: {car1.BatteryCapacity}");
//EngineVehicle car2 = new EngineVehicle("BA 02 PA 3455", 1999.5f, 35.2f);
//Console.WriteLine($"Vehicle number: {car2.VehicleNumber}, EngineCC: {car2.EngineCC}, BatteryCapacity: {car2.Mileage}");

//Generics g = new ();
//g.PrintDetails(car1.VehicleNumber, car2.VehicleNumber);

//Generics<string, float> g2 = new ();
//g2.PrintDetails(car1.VehicleNumber,car1.Range);


#endregion

#region Day7

////namespace collection of classes. can create multiple classes of same name in different classes.
////required <ImplicitUsings>enable</ImplicitUsings> for using program without using system and other provided ckasses.
//using FundamentalConsoleApp.Generics;

//PlayingWithCollections.LearnArray();

#endregion

#region Day8

using FundamentalConsoleApp;

Linq.PassMark();



#endregion