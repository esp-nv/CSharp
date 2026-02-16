namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05.Travelling
            string destination = Console.ReadLine();

            bool isEnd = false;

            while (destination != "End")
            {
                double needMoney = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while (savedMoney < needMoney)
                {
                    double currMoney = double.Parse(Console.ReadLine());
                    savedMoney += currMoney;

                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }

        }
    }
}
