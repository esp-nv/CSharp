//01.Old Books
string loveBook = Console.ReadLine();

string input = Console.ReadLine();
bool isFound = false;
int bookCounter = 0;

while (input != "No More Books")
{
    if (input == loveBook)
    {
        isFound = true;
        break;
    }
    bookCounter++;
    input = Console.ReadLine();
}

if (isFound)
{
    Console.WriteLine($"You checked {bookCounter} books and found it.");
}
else
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {bookCounter} books.");
}