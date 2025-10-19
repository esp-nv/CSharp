//14.Password Generator

int n = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());

int r = 1;
string text = "";
for (int i = 1; i <= n; i++)
{

    for (int j = 1; j <= n; j++)
    {
        for (int k = 1; k <= l; k++)
        {
            for (int m = 1; m <= l; m++)
            {
                if ((i = j) || (i < j))
                {
                    text += $"{i}{j}{(char)(k + 96)}{(char)(m + 96)}{r} ";
                }
            }
        }
    }
}

Console.WriteLine(text);