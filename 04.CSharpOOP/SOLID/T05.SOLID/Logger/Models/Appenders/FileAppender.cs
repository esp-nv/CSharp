using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Models.Appenders;
public class FileAppender : IAppender
{
    public FileAppender(ILayout layout, Level level, IFile file)
    {
        this.Layout = layout;
        this.Level = level;
        this.File = file;
    }
    public ILayout Layout { get; private set; }

    public Level Level { get; private set; }

    public IFile File { get; private set; }

    public long MessaggesAppender { get; private set; }

    

    public void Append(IError error)
    {
       string formattedMessage = this.File.Write(this.Layout, error);

        //експлицитно извикване на File статичния клас които идва от езика c#, неговте библиотеки
        System.IO.File.WriteAllText(this.File.Path,formattedMessage);

        this.MessaggesAppender++;

        //throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.Level.ToString().ToUpper()}, Messages appended: {this.MessaggesAppender}, File size {this.File.Size}";
    }
}
