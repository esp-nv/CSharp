using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.StudentSystem
{
    public class ConsoleInputOutputProvider : IInputOutputProvider
    {
        public string GetInput() => Console.ReadLine();
        

        public void ShowOutput(string data) => Console.WriteLine(data);
        
    }
}
