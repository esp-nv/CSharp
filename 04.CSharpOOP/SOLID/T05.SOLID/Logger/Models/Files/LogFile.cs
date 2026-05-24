using System;
using System.IO;
using System.Linq;
using System.Globalization;

using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using Logger.Models.IOManagement;

namespace Logger.Models.Files;
public class LogFile : IFile
{
    //това е последното ниво на абстракция и в такъв случай трябва да се създава в конструктура

    private IOManager IOManager;

    public LogFile(string folderName, string fileName)
    {
        this.IOManager = new IOManager(folderName, fileName);
        this.IOManager.EnsureDirectoryAndFileExist();
    }
    public string Path => this.IOManager.CurrentFilePath;

    public long Size => this.GetFileSize();

    /// <summary>
    /// returns formatted message in provided layout with provided error''s data
    /// </summary>
    /// <param name="layout"></param>
    /// <param name="error"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public string Write(ILayout layout, IError error)
    {
        string format = layout.Format;



        DateTime dateTime = error.DateTime;
        string message = error.Message;
        Level level = error.Level;

        string formattedMesage = String.Format(format, dateTime.ToString("M/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture), message, level.ToString());

        return formattedMesage;
    }

    private long GetFileSize()
    {
        string text = File.ReadAllText(this.Path);

        long size = text.Where(ch => Char.IsLetter(ch)).Sum(ch => ch);

        return size;
    }
}
