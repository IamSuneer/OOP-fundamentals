class PersonBMI
{
    public PersonBMI(string name, double height, double weight)
    {
        this.name = name;
        this.height = height;
        this.weight = weight;
    }
    public string name;
    public double height;
    public double weight;

    double BMICalulator(double height, double weight)
    {
        double bmi = weight / Math.Pow((height * 0.3048),2);
        return Math.Round(bmi,2);
    }

    public void PrintBMIDetails()
    {
        Console.WriteLine($"BMI Index of {this.name} having height {this.height} feet and weight {this.weight} kg is {BMICalulator(this.height, this.weight)}.");
    }
}