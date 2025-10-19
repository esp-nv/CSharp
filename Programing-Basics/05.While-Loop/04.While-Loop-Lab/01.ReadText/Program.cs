//01.Read Text

/*
 string text = Console.ReadLine();

while (text != "Stop")
{
    Console.WriteLine(text);
    text = Console.ReadLine();
}
*/

while (true)
{
    string input = Console.ReadLine();
    if (input == "Stop")
    {
        break;
    }
    Console.WriteLine(input);
}