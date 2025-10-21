using System;

namespace _05.DecryptingMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kay = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string decryptedMessage = string.Empty;
            
            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();

                string decrypted = string.Empty;
                
                foreach (char ch in message)
                {
                    decrypted += (char)(ch + kay);
                }

                decryptedMessage += decrypted;
            }

            Console.WriteLine(decryptedMessage);

        }
    }
}
