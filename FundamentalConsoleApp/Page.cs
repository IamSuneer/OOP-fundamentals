//Create a CLass Called "Page" with fields height (inch), width (inch) and title
//"Page" should have Parameterized Constructor which assigns each fields
//Create a method that prints height and width of that page in pixels
//Create instance of this class and display details in Console.


class Page{
    public Page() {}
    public Page(int height, int width, string title)
    {
        this.height = height;
        this.width = width;
        this.title = title;
    }
    public int height;
    public int width;
    public string title;

    //  void ConvertPixel(int height, int width)
    //  {
    //     this.height = height * 96;
    //     this.width = width * 96;
    //  }
    public void PrintDetails()
    {
        // ConvertPixel(this.height, this.width);
        Console.WriteLine($"Title: {this.title}\nHeight: {this.height * 96} px\nWidth: {this.width * 96} px");
    }
}