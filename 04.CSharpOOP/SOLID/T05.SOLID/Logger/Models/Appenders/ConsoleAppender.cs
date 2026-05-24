using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using System;
using System.Globalization;

namespace Logger.Models.Appenders;
public class ConsoleAppender : IAppender
{
    // няма да работи с injection/конкретики/, а с абстракции и да се изпълни 5тия принцип за dependence injection с конструктура
    public ConsoleAppender(ILayout layout, Level level)
    {
        this.Layout = layout;
        this.Level = level;
    }

    public Level Level { get; private set; }

    public ILayout Layout { get; private set; }

    public long MessaggesAppender { get; private set; }

    //това е Dependency injection направени чрез аргументите на метода
    
    public void Append(IError error)
    {
        string formattedMessage = string.Format(
       this.Layout.Format,
       error.DateTime,
       error.Level,
       error.Message);

        Console.WriteLine(formattedMessage);

       // Console.WriteLine(formattedMesage); 
        this.MessaggesAppender++;
    }

    public override string ToString()
    {
        return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.Level.ToString().ToUpper()}, Messages appended: {this.MessaggesAppender}";
    }
}
