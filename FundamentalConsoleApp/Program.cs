// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Datatypes
//Numbers: Integers and Floating point

byte age = 34;
short numberOfPeopleInCompany = 23424; //camelCasing, PascalCasing
int areaOfCountry = 324123344; //32 bit
long distanceBetweenPlanets = 975431234567890; //64

//Accuracy (Precision)
float averageWeight = 67.5512456F;
double averageDistance = 72634.2132174;
decimal averageDistanceBetweenElectrons = 72634.2131234562174M;

//Text
string name = "Suneer ";
char gender = 'M';

//Flags
bool isQA = true;

//Dates
DateTime dob = new(1996, 12, 07);

//Nullables


// Console.WriteLine(averageWeight);
// Console.WriteLine("Enter some text:");
// string data = Console.ReadLine();

// Console.WriteLine("Characters count "+ data.Length);
// Console.WriteLine($"Characters count {data.Length}"); //string interpolation.


// get username and convert into uppercase.
Console.WriteLine("Enter user name:");
string userName = Console.ReadLine();
Console.WriteLine($"Your uppercase username is: {userName.ToUpper()}");