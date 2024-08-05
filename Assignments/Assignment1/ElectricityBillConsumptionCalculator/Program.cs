bool validEnd = true;
string calc = "";
while (validEnd)
{
    char end = 'O';
    int start = 0;
    while (start != 1 && start != 2)
    {
        Console.WriteLine("1. Calculate Bill using if/else. ");
        Console.WriteLine("2. Calculate Bill using switch. ");
        Console.Write("How do you want to calculate your bill? (1/2): ");
        try
        {
            start = Convert.ToInt32(Console.ReadLine());
            if (start != 1 && start != 2)
            {
                Console.WriteLine("Choose 1/2 only.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Choose 1/2 only.");
        }

    }
    Console.Write("Please enter the electricity units consumed: ");
    try
    {
        int unitsConsumed = Convert.ToInt32(Console.ReadLine());
        if (start == 1)
        {
            Console.WriteLine($"Your total bill amount is: Rs {BillCalculatorWithIfElse(unitsConsumed)}");
        }
        else if (start == 2)
        {
            Console.WriteLine($"Your total bill amount is: Rs {BillCalculatorWithSwitch(unitsConsumed)}");
        }
        else
        {
            System.Console.WriteLine("Invalid. Please restart again.");
        }
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

decimal BillCalculatorWithSwitch(int units)
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

decimal BillCalculatorWithIfElse(int units)
{
    decimal billAmount = 0;

    if (units >= 1 && units <= 20)
    {
        billAmount = 100;
    }
    else if (units >= 21 && units <= 25)
    {
        billAmount = 100 + ((units - 20) * 5);
    }
    else if (units >= 26 && units <= 50)
    {
        billAmount = 125 + ((units - 25) * 10);
    }
    else if (units > 50)
    {
        billAmount = 2000;
    }
    else
    {
        Console.WriteLine("Units consumed cannot be less than 1.");
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