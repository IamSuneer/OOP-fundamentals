public class HomePage : IDriver
{
    public string[] MenuItems { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public byte[] ProfileAvatar { get; set; }

    public void HandleMenuClick(string menuItem)
    {
        //do something
    }

    public void Login(string userName, string password)
    {
        //do Login
    }

    public void Navigate(string url)
    {
        // navigate to url
    }
    public void GetCurrentUrl()
    {
        //get current url
    }
}