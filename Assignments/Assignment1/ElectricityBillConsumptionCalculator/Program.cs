bool validEnd = true;
while (validEnd)
{
    char end = 'O';
    Console.Write("Please enter the electricity units consumed: ");
    try
    {
        int unitsConsumed = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Your total bill amount is: Rs {BillCalculator(unitsConsumed)}");
    }
    catch (FormatException fe)
    {
        Console.WriteLine(fe.Message);
        Console.WriteLine("Please enter numbers.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    while (end != 'Y' && end != 'y' && end != 'N' && end != 'n')
    {
        Console.Write("Do you want to submit new bill? (y/n): ");
        try
        {
            end = Convert.ToChar(Console.ReadLine());
            RedoLoop(end);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Choose y/n only.");
        }

    }
}

decimal BillCalculator(int units)
{
    decimal billAmount = 0;
    switch (units)
    {
        case int unit when (unit >= 1 && unit <= 20):
            billAmount = 100;
            break;

        case int unit when (unit >= 21 && unit <= 25):
            billAmount = 100 + ((units - 20) * 5);
            break;

        case int unit when (unit >= 26 && unit <= 50):
            billAmount = 125 + ((units - 25) * 10);
            break;

        case int unit when (unit > 50):
            billAmount = 2000;
            break;
        default:
            Console.WriteLine("Units consumed cannot be less than 1.");
            break;
    }
    return billAmount;
}

void RedoLoop(char endChar)
{
    if (endChar == 'Y' || endChar == 'y')
    {
        validEnd = true;
    }
    else if (endChar == 'N' || endChar == 'n')
    {
        validEnd = false;
        Console.WriteLine("Thank you for your time.");
    }
    else
    {
        Console.WriteLine("Choose y/n only.");
    }
}