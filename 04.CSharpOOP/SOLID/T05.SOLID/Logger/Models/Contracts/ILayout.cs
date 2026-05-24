using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Models.Contracts;
public interface ILayout
{
    string Format {  get; }
}
