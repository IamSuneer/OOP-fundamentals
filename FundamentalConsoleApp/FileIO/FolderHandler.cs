namespace FundamentalConsoleApp.FileIO;
internal class FolderHandler
{
    public void CreateFolder(string newFolderName, string folderPath = "C:\\Users\\suneer_teksewa\\OneDrive\\Desktop\\Dotnet Training\\Github Training\\OOP-fundamentals\\FundamentalConsoleApp\\FileIO\\")
    {
        var newFolderPath = $"{folderPath}{newFolderName}";
        if (!Directory.Exists(newFolderPath))
        {
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            Console.WriteLine("Folder Already Exists.");
        }
    }
}