using Logger.Core;
using Logger.Core.Contracts;
using Logger.Factories;
using Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int appendersCount = int.Parse(Console.ReadLine());

            ICollection<IAppender> appenders = new List<IAppender>();
            ParseAppenderInput(appendersCount, appenders);

            // когато класа и namespace са с еднакво име трябва да се изпише целия път
            ILogger logger = new Logger.Models.Logger(appenders);

            IEngine engine = new Engine(logger);
            engine.Run();


        }

        private static void ParseAppenderInput(int appendersCount, ICollection<IAppender> appenders)
        {
            AppenderFactory appenderFactory = new AppenderFactory();

            for (int i = 0; i < appendersCount; i++)
            {
                string[] appendersArg = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string appenderType = appendersArg[0];

                string layoutType = appendersArg[1];

                //тази позиция е optional
                string level = "INFO";

                if (appendersArg.Length == 3)
                {
                    level = appendersArg[2];
                }

                try
                {

                    IAppender appender = appenderFactory.ProduceAppender(appenderType, layoutType, level);

                    appenders.Add(appender);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

}
