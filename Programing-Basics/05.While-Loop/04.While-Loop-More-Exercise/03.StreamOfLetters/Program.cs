//03.Stream Of Letters
string text = "";
string nextWord = "";
string currWord = "";

string input = Console.ReadLine();
while (input != "End")
{
    char letter = char.Parse(input);
    if ((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z'))
    {
        if (letter == 'c' && !(currWord.Contains("c")))
        {
            currWord += char.ToString(letter);
        }
        else if (letter == 'o' && !(currWord.Contains("o")))
        {
            currWord += char.ToString(letter);
        }
        else if (letter == 'n' && !(currWord.Contains("n")))
        {
            currWord += char.ToString(letter);
        }
        else
        {
            text += char.ToString(letter);
        }
        if (currWord == "con" || currWord == "cno" || currWord == "ocn" ||
            currWord == "onc" || currWord == "nco" || currWord == "noc")
        {
            text += " ";
            nextWord = text;
            currWord = "";
        }
    }
    input = Console.ReadLine();
}
Console.WriteLine(nextWord);
