using System;
using System.Text;

using Logger.Models.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logger.Models.Layouts;
public class XmlLayout : ILayout
{
    public string Format => this.GetDataFormat();

    private string GetDataFormat()
    {
        StringBuilder sb = new StringBuilder();

        sb
            .AppendLine("<log>")
            .AppendLine("<date>{0}</date>")
            .AppendLine("<level>{2}</level>")
            .AppendLine("<message>{1}</message>")
            .AppendLine("</log>");

        return sb.ToString().TrimEnd();
    }
}
