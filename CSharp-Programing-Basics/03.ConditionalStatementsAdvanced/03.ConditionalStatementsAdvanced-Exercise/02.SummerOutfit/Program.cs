//02.Summer Outfit

//"It's {градуси} degrees, get your {облекло} and {обувки}."

int degree = int.Parse(Console.ReadLine());
string timeOfDay  = Console.ReadLine();

string outfit = "";
string shoes = "";

switch (timeOfDay)
{
    case "Morning":
        switch (degree)
        {
            case >=10 and <=18:
                outfit = "Sweatshirt";
                shoes = "Sneakers";
                Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                break;
            case >18 and <= 24:
                outfit = "Shirt";
                shoes = "Moccasins";
                Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                break;
            case >=25:
                outfit = "T-Shirt";
                shoes = "Sandals";
                Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                break;
        }
        break;
    case "Afternoon":
        switch (degree)
        {
            case >= 10 and <= 18:
                outfit = "Shirt";
                shoes = "Moccasins"; 
                Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                break;
            case > 18 and <= 24:
               outfit = "T-Shirt";
                shoes = "Sandals";
                Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                break;
            case >= 25:
                outfit = "Swim Suit";
                shoes = "Barefoot";
                Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                break;
        }
        break;
    case "Evening":
       if(degree >= 10)
        { 
            outfit = "Shirt";
            shoes = "Moccasins";
            Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
        }            
        break;

}