// "You are <firstName> <lastName>, a <age>-years old person from <town>."

string firstName = Console.ReadLine();
string lastName = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
string town = Console.ReadLine();

//Console.WriteLine("You are " + firstName + " " + lastName + ", a " + age + "-years old person from " + town + ".");
// towa e 2ri variant na rezultat
Console.WriteLine($"You are {firstName} { lastName}, a {age}-years old person from {town}.");