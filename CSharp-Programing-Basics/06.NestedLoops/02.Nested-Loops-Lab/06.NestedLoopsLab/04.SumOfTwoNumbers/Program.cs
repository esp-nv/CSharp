namespace _04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 04.SumOfTwoNumbers
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isFound = false;

            for (int x1 = start; x1 <= end; x1++)
            {
                for (int x2 = start; x2 <= end; x2++)
                {
                    counter++;
                    if (x1 + x2 == sum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({x1} + {x2} = {sum})");
                        isFound = true;
                        break;
                    }

                }

                if (isFound)
                {
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {sum}");
            }
        }
    }
}
