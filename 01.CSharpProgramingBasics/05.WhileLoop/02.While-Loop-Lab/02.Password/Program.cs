//02.Password
string username = Console.ReadLine();
string password = Console.ReadLine();

string inputPass  = Console.ReadLine();

while (inputPass != password)
{
    inputPass = Console.ReadLine();
}

Console.WriteLine($"Welcome {username}!");