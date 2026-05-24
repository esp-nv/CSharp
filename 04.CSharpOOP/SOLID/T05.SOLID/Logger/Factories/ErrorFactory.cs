using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using Logger.Models.Errors;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Factories;

// това отговаря само да парсне нещата или да хвърли грешки
public class ErrorFactory
{
    private const string DATE_FORMAT = "M/dd/yyyy h:mm:ss tt";

    public IError ProduceError(string dateStr, string message, string levelStr)
    {
        //DateTime dateTime;

        //try
        //{
        //    DateTime date = DateTime.ParseExact(dateStr, DATE_FORMAT, CultureInfo.InvariantCulture);
        //    dateTime = date;
        //}
        //catch (Exception)
        //{

        //    throw new ArgumentException("Invalid date type!");
        //}

        bool isValidDate = DateTime.TryParseExact(
       dateStr,
       DATE_FORMAT,
       CultureInfo.InvariantCulture,
       DateTimeStyles.None,
       out DateTime dateTime);

        if (!isValidDate)
        {
            throw new ArgumentException("Invalid date type!");
        }



        Level level;

        bool hasParsed = Enum.TryParse(levelStr, out level);

        if (!hasParsed)
        {
            throw new ArgumentException("Invalid Level type!");
        }

        IError error = new Error(dateTime,message,level);

        return error;
    }
}
