internal class Reports
{
    static List<Trainee> trainees = [
        new("Ram Bista", new DateTime(1990, 12, 12), "Vedas", "BIT"),
        new("Laxman Shrestha", new DateTime(1988, 1, 10), "Ascol", "BSC"),
        new("Bishnu Rawal", new DateTime(1990, 4, 22), "PK", "BIM"),
        new("Suneer Bista", new DateTime(2000, 6, 10), "Cenral TU", "BIT"),
        new("Sita Acharya", new DateTime(2010, 8, 29), "CCRC", "BIT"),
        new("Ram Basnet", new DateTime(2004, 9, 23), "People's College", "BSC"),
        new("Rama Chitrakar", new DateTime(2003, 8, 17), "People's College", "BSC"),
        new("Mahesh Manandhar", new DateTime(2004, 9, 23), "CCRC", "BIM"),
        new("Renu Shahi", new DateTime(2004, 9, 23), "Vedas", "BIM"),
        new("Sanjana Luitel", new DateTime(2007, 4, 26), "PK", "BSC")
    ];

    public static void LetsQuery()
    {
        // Get all trainees grouped by their college
        Console.WriteLine("Trainees Grouped by College:");
        var traineeGroupedByCollege = trainees.GroupBy(x => x.college);
        foreach (var traineeGroup in traineeGroupedByCollege)
        {
            Console.WriteLine($"{traineeGroup.Key}:");
            foreach (var trainee in traineeGroup)
            {
                Console.WriteLine($"    {trainee.name}\t{trainee.dob}\t{trainee.college}\t{trainee.program}");
            }
        }
        Console.WriteLine();

        // Get name and age of trainees who are on their teens
        Console.WriteLine("Trainees in Teens:");
        var traineeInTeens = trainees.Where(x => x.CalculateAge().Item2 / 365 >= 13 && x.CalculateAge().Item2 / 365 <= 19);
        foreach (var trainee in traineeInTeens)
        {
            Console.WriteLine($"{trainee.name}\t{trainee.CalculateAge().Item1}");
        }
        Console.WriteLine();

        // Get name initial, age and academic program of trainees and order result by initials
        Console.WriteLine("Trainees Ordered by Initials:");
        var traineeOrderedByInitials = trainees.OrderBy(x => x.GetInitials());
        foreach (var trainee in traineeOrderedByInitials)
        {
            Console.WriteLine($"{trainee.GetInitials()}\t{trainee.CalculateAge().Item1}\t{trainee.program}");
        }
    }
}
