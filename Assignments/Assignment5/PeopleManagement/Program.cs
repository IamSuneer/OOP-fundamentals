using PeopleManagement.Methods;
using PeopleManagement.Model;

string filePath = @"C:\Users\suneer_teksewa\OneDrive\Desktop\Dotnet Training\Github Training\OOP-fundamentals\Assignments\Assignment5\PeopleManagement\CSVFiles\";
List<Person> people = await CSVParser.ParseCSV(filePath);
await PeopleReport.SaveMales(people, filePath);
await PeopleReport.SaveFemales(people, filePath);
await PeopleReport.SaveDotComUsers(people, filePath);
