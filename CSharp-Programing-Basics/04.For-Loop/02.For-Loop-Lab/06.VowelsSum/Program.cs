//06.Vowels Sum

string input = Console.ReadLine();

int sum  = 0;

for (int i = 0; i<input.Length; i++)
{
    char c = input[i];

    switch (c)
    {
        case 'a': sum +=1; break;
        case 'e': sum += 2; break;
        case 'i': sum += 3; break;
        case 'o': sum += 4; break;
        case 'u': sum += 5; break;
    }
}

Console.WriteLine(sum);