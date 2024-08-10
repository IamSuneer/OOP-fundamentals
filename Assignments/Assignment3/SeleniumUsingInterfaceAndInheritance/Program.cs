HomePage homePage = new HomePage
{
    MenuItems = new[] { "Home", "About us" },
    Height = 800,
    Width = 600,
    ProfileAvatar = new byte[] { 123, 234, 111, 222 }
};

AboutUsPage aboutUsPage = new AboutUsPage
{
    MenuItems = new[] { "Home", "About us" },
    Height = 800,
    Width = 600,
    ProfileAvatar = new byte[] { 123, 234, 111, 222 },
    Title = "About Us",
    Contacts = new[] { 6551234, 6612345, 4312932 }
};

homePage.Login("", "");
homePage.Login("   ", "demoData");
homePage.Login("suneer", "              ");
homePage.Login("suneer", "demoData");


homePage.Navigate("https://www.example.com/home");
homePage.GetCurrentUrl();

homePage.HandleMenuClick("About us");

aboutUsPage.Navigate("https://www.example.com/aboutus");
aboutUsPage.GetCurrentUrl();
aboutUsPage.HandleMenuClick("test");

aboutUsPage.InitiatePhone("65512341");
aboutUsPage.InitiatePhone("6551234");
aboutUsPage.InitiateEmail("suneer@suneer");
aboutUsPage.InitiateEmail("suneer@gmail.com");