using P03.ShoppingSpree.Core;

namespace P03.ShoppingSpree
{
    internal class StartUp
    {
        static void Main()
        {
            /*
             ако напиша try-catch ще хване грешката и ще пиключи програмата
             ако го сложа в друг фаил  ще я обработи, ще я завърти и няма да може да приключи, 
                                                        а ще продължи с изпълнението на програмата
                 Engine engine = new Engine();
                  engine.Run();
            */
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
