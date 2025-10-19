//14.Password Generator

int n = int.Parse(Console.ReadLine());
int l  = int.Parse(Console.ReadLine());

string text = "";

for (int i = 1; i <= n; i++)
{
   for (int j = 1; j <= n; j++)
   {
        for (int k = 1; k <= l; k++)
        {
            for (int m = 1; m <= l; m++)
            {
                for (int r = 1; r <= n; r++)
                {
                    if (i < r && j< r)
                    {
                       text += $"{i}{j}{(char)(k + 96)}{(char)(m + 96)}{r} ";
                    }
                }
                
            }
        }
    }
}

Console.WriteLine(text);