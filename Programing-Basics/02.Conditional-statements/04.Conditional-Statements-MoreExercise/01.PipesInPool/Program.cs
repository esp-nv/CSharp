//01.Pipes In Pool

//input
int volume = int.Parse(Console.ReadLine());
int pipe1 = int.Parse(Console.ReadLine());
int pipe2  = int.Parse(Console.ReadLine());
double hour  = double.Parse(Console.ReadLine());

//calculate
double fullPipe1 = pipe1 * hour;
double fullPipe2 = pipe2 * hour;
double totalFullPipes = fullPipe1 + fullPipe2;

//output
if (totalFullPipes > volume)
{
    double literUp = totalFullPipes - volume;
    Console.WriteLine($"For {hour} hours the pool overflows with {literUp} liters.");
}
else if (totalFullPipes <= volume)
{
    double percentFromVolume = (totalFullPipes / volume) * 100;
    double percentPipe1 =(fullPipe1 /totalFullPipes)*100;
    double percentPipe2=(fullPipe2 /totalFullPipes) * 100;
    Console.WriteLine($"The pool is {percentFromVolume}% full. Pipe 1: {percentPipe1:f2}%. Pipe 2: {percentPipe2:f2}%.");
}
