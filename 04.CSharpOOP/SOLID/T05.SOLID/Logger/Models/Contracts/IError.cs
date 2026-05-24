using System;
using Logger.Models.Enumerations;

using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Models.Contracts;
public interface IError
{
    DateTime DateTime { get; }

    string Message {  get; }

    Level Level { get; }

}
