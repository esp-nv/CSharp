using Logger.Models.Appenders;
using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using Logger.Models.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Factories;

//това е транзишън фактори

// ако беше сингълтън фактори -- да е едно и също; от стартирането на програма да се използва едно и също фактори, тогава можеше да идва отвън и някъде в Main и да бъде инициализирано

public class AppenderFactory
{
    private LayoutFactory layoutFactory;

    // всеки път като се извика ще се създава ново layoutFactory
    public AppenderFactory()
    {
        this.layoutFactory = new LayoutFactory();
    }

    //може да се направи да идва и отвън като optional аргументи -- могат да дойдат и да не дойдат
    public IAppender ProduceAppender(string appenderType, string layoutType, string levelStr)
    {
        Level level;

        bool hasParsed = Enum.TryParse<Level>(levelStr,true, out level);

        if (!hasParsed)
        {
            throw new ArgumentException("Invalid level type!");
        }

        ILayout layout = this.layoutFactory.ProduceLayout(layoutType);

        IAppender appender;

        if(appenderType == "ConsoleAppender")
        {
            appender= new ConsoleAppender(layout,level);
        }
        else if (appenderType == "FileAppender")
        {
            IFile file = new LogFile("\\data\\", "logs.txt");
             appender = new FileAppender(layout,level,file);
        }
        else
        {
            throw new ArgumentException("Invalid appendr type!");
        }

        return appender;
    }
}
