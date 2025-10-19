//06.Operations Between Numbers - Calculator

//input
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
char operation  = char.Parse(Console.ReadLine());


int c = 0;

//output
if (b == 0)
{
    Console.WriteLine( $"Cannot divide {a} by zero");
}
else if (b != 0)
{
    switch (operation)
    {
        case '+':
            c = a + b;
            if (c % 2 == 0)
            {
                Console.WriteLine($"{a} + {b} = {c} - even");
            }
            else
            {
                Console.WriteLine($"{a} + {b} = {c} - odd");
            } 
            break;
        case '-':
            c = a - b;
            if (c % 2 == 0)
            {
                Console.WriteLine($"{a} - {b} = {c} - even");
            }
            else
            {
                Console.WriteLine($"{a} - {b} = {c} - odd");
            }
            break;
        case '*':
            c = a * b;
            if (c % 2 == 0)
            {
                Console.WriteLine($"{a} * {b} = {c} - even");
            }
            else
            {
                Console.WriteLine($"{a} * {b} = {c} - odd");
            }
            break;
        case '/':
             double d  = (double) a / b;
            Console.WriteLine($"{a} / {b} = {d:f2}");
            break;
        case '%':
            c = a % b;
            Console.WriteLine($"{a} % {b} = {c}");
            break;

    }
    
}
