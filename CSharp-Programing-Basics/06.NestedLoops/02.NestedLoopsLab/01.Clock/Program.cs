namespace _01.Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01.Clock
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minute = 0; minute <= 59; minute++)
                {
                    Console.WriteLine($"{hour}:{minute}");
                }
            }
        }
    }
}
