internal class Trainee(string name, DateTime dob, string college, string program)
{
    public string name = name;
    public DateTime dob = dob;
    public string college = college;
    public string program = program;

    // Calculate age of a trainee in years and months e.g. 22 Years and 2 Months
    public (string, int) CalculateAge()
    {
        var ageSpan = DateTime.Now - dob;
        var year = ageSpan.Days / 365;
        var months = ageSpan.Days % 365 / 30;
        return ($"{year} Years and {months} Months", ageSpan.Days);
    }

    // Get name initials of a trainee e.g. Bishnu Singh Rawal => BR
    public string GetInitials()
    {
        var nameParts = name.Split(" ");
        char firstInitial = nameParts[0][0];
        var lastInitial = nameParts[^1][0];

        return $"{firstInitial}{lastInitial}";
    }

    public static string PrintDetails(Trainee trainee) =>
        $"{trainee.name}\t{trainee.dob.ToShortDateString()}\t{trainee.college}\t{trainee.program}";
}