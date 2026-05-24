using Logger.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Models.Contracts;
public interface IAppender
{
   ILayout Layout { get; }

    Level Level { get; }

    long MessaggesAppender {  get; }

    void Append(IError error);
}
