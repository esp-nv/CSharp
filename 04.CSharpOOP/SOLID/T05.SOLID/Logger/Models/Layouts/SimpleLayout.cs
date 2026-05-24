using Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Models.Layouts;

//той единствеще се грижи да ни даде формата
public class SimpleLayout : ILayout
{
    public string Format => "{0} - {1} - {2}";
}
