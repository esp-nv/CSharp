using System;
using System.IO;

using Logger.Models.Contracts;


namespace Logger.Models.IOManagement;
public class IOManager : IIOManager
{

    //искам да ги съхраня, но не искам да са видими отвън

    //това съхнанява къде съм в момента
    //в този field ще set-на това което ми е върнал метода this.GetCurrentDirectory();
    private string currentPath;

    private string folderNme;
    private string fileName;

    //този констуктор да отговаря само за запазването им
    public IOManager(string folderName, string fileName)
        : this()
    {
        this.folderNme = folderName;
        this.fileName = fileName;
    }
    //този констуктор да отговаря да намери само къде работи приложението/програмата
    public IOManager()
    {
        this.currentPath = this.GetCurrentDirectory();
    }

    //трябва да си взема сегашната директория
    public string CurrentDirectoryPath =>
        this.currentPath + this.folderNme;

    public string CurrentFilePath => this.CurrentDirectoryPath + this.fileName;

    public void EnsureDirectoryAndFileExist()
    {
        if (!Directory.Exists(this.CurrentDirectoryPath))
        { 
            Directory.CreateDirectory(this.CurrentDirectoryPath);
        }

        File.WriteAllText(this.CurrentFilePath, string.Empty);
    }

    public string GetCurrentDirectory()
    {
        //това спомага да се вземе текущата работна директория, където работи приложението ми, но после ако кякой друг иска да го инсталира на друго място ще вземе неговата текуща директория 
        //т.е. така ще я взима динамично

        string currentDir = Directory.GetCurrentDirectory();

        return currentDir;
    }
}
