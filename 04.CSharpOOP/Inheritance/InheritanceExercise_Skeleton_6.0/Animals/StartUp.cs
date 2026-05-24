using System;
using System.Linq.Expressions;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //така се хващат всички грешки exception bubbling
            try
            {
                Engine engine = new Engine();
                engine.Run();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
