//02.Equal Sums Even Odd Position

int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());


for (int currNum = firstNum; currNum <= secondNum; currNum++)
{
    string currNumString= currNum.ToString();
    int evenSum= 0;
    int oddSum= 0;

    for (int digitPosition = 0; digitPosition < currNumString.Length; digitPosition++)
    {
       int currDigit = int.Parse(currNumString[digitPosition].ToString());

        if (digitPosition % 2 == 0)
        {
            evenSum += currDigit;
        }
        else 
        { 
            oddSum += currDigit;
        }
        
    }

    if (oddSum == evenSum)
    Console.Write(currNum + " ");
}