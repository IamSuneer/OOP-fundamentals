public class AboutUsPage : HomePage
{
    public string Title { get; set; }
    public int[] Contacts { get; set; }

    public void InitiatePhone(string number)
    {
        if (!string.IsNullOrWhiteSpace(number) && Contacts.Contains(Convert.ToInt32(number)))
        {
            Console.WriteLine($"Initiate Phone: {number}");
        }
        else
        {
            Console.WriteLine("Initiating Phone Failed.");
        }
    }

    public void InitiateEmail(string email)
    {
        if (!string.IsNullOrWhiteSpace(email) && email.Contains("@"))
        {
            char[] delimiters = { '@', '.' };
            var emailData = email.Split(delimiters);
            if (emailData.Count() >= 3)
            {
                Console.WriteLine($"Initiate Email: {email}");
            }
            else
            {
                Console.WriteLine("Initiating Email Failed.");
            }
        }
        else
        {
            Console.WriteLine("Initiating Email Failed.");
        }
    }
}