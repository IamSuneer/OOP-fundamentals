class Person
{
    public Person(){}
    //Before Building object.
    public Person(string name, DateTime dob, long nid)
    {
        this.name = name;
        this.dob = dob;
        this.nid = nid;
        //PrintDetails();
    }
    public string name;
    public long nid;
    public DateTime dob;

    //After Building Object.
    public void PrintDetails()
    {
        Console.WriteLine($"Name: {this.name}\n Date of Birth : {this.dob.ToLongDateString()}\n National Id: {this.nid}");
        Console.WriteLine($"Name: {this.name}\n Date of Birth : {this.dob.ToString("ddd MM dd, yyy")}\n National Id: {this.nid}");
    }

    public void PrintDetailsWithData(string name, long nid, DateTime dob)
    {
        Console.WriteLine($"Name: {name}\n Date of Birth : {dob.ToLongDateString()}\n National Id: {nid}");
        Console.WriteLine($"Name: {name}\n Date of Birth : {dob.ToString("ddd MM dd, yyy")}\n National Id: {nid}");
    }
}