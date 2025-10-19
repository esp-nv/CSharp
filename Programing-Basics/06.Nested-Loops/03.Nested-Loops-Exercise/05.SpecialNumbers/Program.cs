//05.Special Numbers
int n = int.Parse(Console.ReadLine());

for (int currNum = 1111; currNum <= 9999; currNum++)
{
    bool isSpecial=true;
    string currNumString = currNum.ToString();

    for (int j = 0; j < currNumString.Length; j++)
    {
        int currDigit = int.Parse(currNumString[j].ToString());

        if (currDigit == 0 || n % currDigit != 0 )
        {
            isSpecial = false;
            break;
        }
    }

    if (isSpecial)
    {
        Console.Write(currNum + " ");
    }
}