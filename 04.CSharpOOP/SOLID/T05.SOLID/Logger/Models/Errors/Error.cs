using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Models.Errors;
public class Error : IError
{
    // как ще дойдат тези неща нас не ни интересува
    // т.е. ние не работим с конкретики, а ние работим с абтракции. това е идеята на Dependace injection
    // тук не подавам като string date и не казвам this.DateTime=DateTime.ParseExact(..);
    // - това ще се случило някъде другаде, аз взимам само резултата
    public Error(DateTime dateTime, string message, Level level)
    {
        this.DateTime = dateTime;
        this.Message = message;
        this.Level = level;
    }

    //прави се с get и private set - наслетниците да не го счупят поведението на класа и да не може класовете да го променят, така се изпълнява и Liskov принципа
    public DateTime DateTime {  get; private set; }

    public string Message { get; private set; }

    public Level Level { get; private set; }
}
