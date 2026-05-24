using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Models.Contracts;
public interface ILogger
{
    IReadOnlyCollection<IAppender> Appenders { get; }

    // този метод ще извиква foreach горната колекция и така осигурява че всеки appender на правилното място:един за конзолата, един за Log файла, един за web и т.н. 
    
    void Log(IError error);
}
